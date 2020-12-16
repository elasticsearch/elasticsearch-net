// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

namespace Scripts

open System
open System.IO
open Fake.Core
open Fake.IO
open Fake.IO.Globbing.Operators
open Fake.Tools.Git
open Newtonsoft.Json

module Versioning = 
    // We used to rely on AssemblyInfo.cs from NEST to read and write the current version.
    // Since that file is now generated by the dotnet tooling and GitVersion and similar tooling all still have
    // active issues related to dotnet core, we now just burn this info in global.json
    
    let parse (v:string) = SemVer.parse(v)

    //Versions in form of e.g 6.1.0 is inferred as datetime so we bake the json shape into the provider like this
    type SdkVersion = { version:string;  }
    type GlobalJson = { sdk: SdkVersion; version:string; doc_current:string; doc_branch: string; }
        
    let private globalJson () =
        let jsonString = File.ReadAllText "global.json"
        JsonConvert.DeserializeObject<GlobalJson>(jsonString)
        
    let writeVersionIntoAutoLabel oldVersion newVersion =
        let path = Path.Join(".github","auto-label.json")
        let text = File.ReadAllText(path)
        let oldV = sprintf "v%s" oldVersion
        let newV = sprintf "v%s" newVersion
        if  not(text.Contains(oldV)) then
            failwithf "auto-label.json does not contain %s" oldV
        
        let replaced = String.replace oldV newV text
        File.WriteAllText(path, replaced)
                                    
        
    let writeVersionIntoGlobalJson version =
        let globalJson = globalJson ()
        let doc_current =
            match globalJson.doc_current with
            | "master" -> "master"
            | _ -> sprintf "%i.%i" version.Major version.Minor
        let doc_branch =
            match globalJson.doc_current with
            | "master" -> "master"
            | _ -> sprintf "%i.x" version.Major 
            
        let newGlobalJson = {
            globalJson with
                version = version.ToString()
                doc_current = doc_current
                doc_branch = doc_branch
        }
        File.WriteAllText("global.json", JsonConvert.SerializeObject(newGlobalJson, Formatting.Indented))
        printfn "Written (%s) to global.json as the current version will use this version from now on as current in the build" (version.ToString()) 

    let GlobalJsonVersion = parse <| globalJson().version
    
    let private getVersion (args:Commandline.PassedArguments) =
        match (args.Target, args.CommandArguments) with
        | (_, Commandline.SetVersion v) ->
            match v.Version with
            | v when String.IsNullOrEmpty v -> None
            | v -> Some <| parse v
        | ("canary", _) ->
            let v = GlobalJsonVersion
            let timestampedVersion = (sprintf "ci%s" (DateTime.UtcNow.ToString("yyyyMMddTHHmmss")))
            let canaryVersion = parse ((sprintf "%d.%d.0-%s" v.Major (v.Minor + 1u) timestampedVersion).Trim())
            Some canaryVersion
        | _ -> None
    
    
    type AnchoredVersion = { Full: SemVerInfo; Assembly:SemVerInfo; AssemblyFile:SemVerInfo }
    type BuildVersions =
        | Update of New: AnchoredVersion * Old: AnchoredVersion 
        | NoChange of Current: AnchoredVersion
        
    let AnchoredVersion version = 
        let av v = parse (sprintf "%s.0.0" (v.Major.ToString()))
        let fv v = parse (sprintf "%s.%s.%s.0" (v.Major.ToString()) (v.Minor.ToString()) (v.Patch.ToString()))
        { Full = version; Assembly = av version; AssemblyFile = fv version }
    
    let BuildVersioning args =
        let currentVersion = GlobalJsonVersion
        let buildVersion = getVersion args
        match buildVersion with
        | None -> NoChange(Current = AnchoredVersion currentVersion)
        | Some v -> Update(New = AnchoredVersion v, Old = AnchoredVersion currentVersion)
        
    let Validate target version = 
        match (target, version) with
        | ("release", version) ->
            match version with
            | NoChange _ -> failwithf "cannot run release because no explicit version number was passed on the command line"
            | Update (newVersion, currentVersion) ->
                match newVersion.Full.PreRelease with
                | Some v when v.Name.StartsWith("SNAPSHOT", StringComparison.OrdinalIgnoreCase) ->
                    printfn "Building snapshot, foregoing persisting version information"
                | _ ->
                    // fail if current is greater than the new version
                    if (currentVersion > newVersion) then
                        failwithf "Can not release %O as it's lower then current %O" newVersion.Full currentVersion.Full
                    writeVersionIntoGlobalJson newVersion.Full
                    writeVersionIntoAutoLabel (currentVersion.Full.ToString()) (newVersion.Full.ToString())
        | _ -> ignore()
    
    let ArtifactsVersion buildVersions =
        match buildVersions with
        | NoChange n -> n
        | Update (newVersion, _) -> newVersion
    
    let private officialToken = "96c599bbe3e70f5d"

    let BuiltArtifacts (version: AnchoredVersion) = 
        let packages =
            let allPackages = !! "build/output/*.nupkg" |> Seq.toList
            let toProject (package: string) =
                let id = Path.GetFileName(package) |> String.replace (version.Full.ToString()) "" |> String.replace "..nupkg" ""
                let assembly = id |> String.replace "NEST" "Nest"
                {| Package = package; NugetId = id; AssemblyName = assembly |} 
                
            allPackages |> List.map toProject
        packages
    
    let ValidateArtifacts version =
        let tmp = "build/output/tmp"
        
        let packages = BuiltArtifacts version
        printf "%O" packages
        
        packages
        // do not validate versioned packages for now
        |> Seq.filter(fun f -> not <| f.NugetId.EndsWith(sprintf ".v%i" version.Assembly.Major))
        |> Seq.iter(fun p ->
            let v = sprintf "%O+%s" version.Full (Information.getCurrentSHA1("."))
            // loading dlls is locked down on APPVEYOR so we can not assert release mode
            let ciArgs =
                let appVeyor = Environment.hasEnvironVar "APPVEYOR"
                let azDevops = Environment.hasEnvironVar "TF_BUILD"
                if  appVeyor || azDevops then ["-r"; "true"] else []
            ReposTooling.PackageValidator
                <| [p.Package; "-v"; v; "-a"; p.AssemblyName; "-k"; officialToken] @ ciArgs
                |> ignore 
            
            Zip.unzip tmp p.Package
            let nugetId = p.NugetId

            let directories = Directory.GetDirectories <| sprintf "%s/lib" tmp
            directories
            |> Seq.iter(fun d ->
                
                let info = DirectoryInfo d
                let tfm = info.Name
                let fullPath = Path.GetFullPath d
                
                let command = [ sprintf "previous-nuget|%s|%s|%s" nugetId (version.Full.ToString()) tfm;
                                sprintf "directory|%s" fullPath
                                "-a"; "-f"; "github-comment"; "--output"; Paths.BuildOutput]
                
                ReposTooling.Differ command
            )
            Directory.delete tmp
        )