// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

module Tests.YamlRunner.Main

open System
open System.Linq
open System.Diagnostics
open Argu
open Elastic.Transport
open Tests.YamlRunner
open Tests.YamlRunner.Models
open Elasticsearch.Net
open Tests.YamlRunner.YamlMapConverter

type Arguments =
    | [<First; MainCommand; CliPrefix(CliPrefix.None)>] NamedSuite of TestSuite
    | [<AltCommandLine("-f")>]Folder of string
    | [<AltCommandLine("-t")>]TestFile of string
    | [<AltCommandLine("-s")>]TestSection of string
    | [<AltCommandLine("-e")>]Endpoint of string
    | [<AltCommandLine("-o")>]JUnitOutputFile of string
    | [<AltCommandLine("-p")>]Profile of bool
    | [<AltCommandLine("-d")>]DownloadSpecs of bool
    | [<AltCommandLine("-v")>]Version of string
    with
    interface IArgParserTemplate with
        member s.Usage =
            match s with
            | NamedSuite _ -> "specify a known yaml test suite. defaults to `opensource`."
            | Folder _ -> "Only run tests in this folder"
            | TestFile _ -> "Only run tests starting with this filename"
            | TestSection _ -> "Only run test with this name (best used in conjuction with -t)"
            | Endpoint _ -> "The elasticsearch endpoint to run tests against"
            | JUnitOutputFile _ -> "The path and file name to use for the junit xml output, defaults to a random tmp filename"
            | Profile _ -> "Print out process id and wait for confirmation to kick off the tests"
            | DownloadSpecs _ -> "Only locate and acquire the specification"
            | Version _ -> "The version to download the specification for, if not specified will attempt to find version Elasticsearch instance testing against"

let private runningMitmProxy = Process.GetProcessesByName("mitmproxy").Length > 0
let private runningProxy = runningMitmProxy || Process.GetProcessesByName("fiddler").Length > 0
let private defaultEndpoint namedSuite = 
    let host = 
        match (runningProxy, namedSuite) with
        | (true, _) -> "ipv4.fiddler"
        | _ -> "localhost"
    let https = match namedSuite with | Platinum -> "s" | _ -> ""
    sprintf "http%s://%s:9200" https host;

let private createClient endpoint namedSuite = 
    let uri, userInfo = 
        let e = Uri(endpoint)
        let sanitized = UriBuilder(e)
        sanitized.UserName <- null
        sanitized.Password <- null
        let uri = sanitized.Uri
        let tokens = e.UserInfo.Split(':') |> Seq.toList
        match (tokens, namedSuite) with 
        | ([username; password], _) -> uri, Some (username, password)
        | (_, Platinum) -> uri, Some ("elastic", "changeme")
        | _ -> uri, None
    let serializer = LowLevelRequestResponseSerializer([YamlMapConverterFactory()]);
    let pool = new SingleNodeConnectionPool(uri);
    let settings = new ConnectionConfiguration(pool, serializer)
    // proxy 
    let proxySettings =
        match (runningMitmProxy, namedSuite) with
        | (true, _) -> settings.Proxy(Uri("http://ipv4.fiddler:8080"), String(null), String(null))
        | _ -> settings
    // auth
    let authSettings =
        match userInfo with
        | Some(username, password) -> proxySettings.Authentication(new BasicAuthentication(username, password))
        | _ -> proxySettings
    // certs
    let certSettings =
        match namedSuite with
        | Platinum -> 
            authSettings.ServerCertificateValidationCallback(fun _ _ _ _ -> true)
        | _ -> authSettings
    ElasticLowLevelClient(certSettings)
    
let validateRevisionParams endpoint version namedSuite =    
    let client = createClient endpoint namedSuite
    
    let node = client.Settings.ConnectionPool.Nodes.First()
    let auth =     
        match client.Settings.Authentication with 
        | (:? BasicAuthentication as s) -> sprintf "basic auth: %s" s.Header
        | (:? ApiKey as s) -> sprintf "api key: %s" s.Header
        | _ -> ""
        
    printfn "Running elasticsearch %O %s" (node.Uri) auth
    
    let r =
        let config = RequestConfiguration(DisableDirectStreaming=Nullable(true))
        let p = RootNodeInfoRequestParameters(RequestConfiguration = config)
        client.RootNodeInfo<DynamicResponse>(p)
        
    printfn "%s" r.DebugInformation
    if not r.Success then
        failwithf "No running elasticsearch found at %s" endpoint
    
    let revision = r.Get<string>("version.build_hash")
    let version =
        match version with
        | Some v -> v |> SemVer.Version
        | None -> r.Get<string>("version.number") |> SemVer.Version
        
    (client, revision, version)
    
let runMain (parsed:ParseResults<Arguments>) = async {
    
    let namedSuite = parsed.TryGetResult NamedSuite |> Option.defaultValue Free
    let directory = parsed.TryGetResult Folder //|> Option.defaultValue "indices.create" |> Some
    let file = parsed.TryGetResult TestFile //|> Option.defaultValue "10_basic.yml" |> Some
    let section = parsed.TryGetResult TestSection //|> Option.defaultValue "10_basic.yml" |> Some
    let endpoint = parsed.TryGetResult Endpoint |> Option.defaultValue (defaultEndpoint namedSuite)
    let profile = parsed.TryGetResult Profile |> Option.defaultValue false
    let locateOnly = parsed.TryGetResult DownloadSpecs |> Option.defaultValue false
    let version = parsed.TryGetResult Version
    let outputFile =
        parsed.TryGetResult JUnitOutputFile
        |> Option.defaultValue (System.IO.Path.GetTempFileName())
        
    let (client, revision, version) = validateRevisionParams endpoint version namedSuite
    
    let! locateResults = Commands.LocateTests namedSuite version revision directory file
    
    if locateOnly then
        Environment.Exit <| if (locateResults |> List.isEmpty) then 1 else 0
    
    let readResults = Commands.ReadTests locateResults
    
    if profile then
        printf "Waiting for profiler to attach to pid: %O" <| Process.GetCurrentProcess().Id
        Console.ReadKey() |> ignore
        
    let! runResults = Commands.RunTests readResults client (version.ToString()) namedSuite section
    let summary = Commands.ExportTests runResults outputFile
    
    Commands.PrettyPrintResults outputFile
    
    printfn "JUnit output: %s" outputFile
    printfn "Total Tests: %i Failed: %i Errors: %i Skipped: %i"
        summary.Tests summary.Failed summary.Errors summary.Skipped
    printfn "Total Time %O" <| TimeSpan.FromSeconds summary.Time
        
    return summary.Failed + summary.Errors
}

[<EntryPoint>]
let main argv =
    
    let parser = ArgumentParser.Create<Arguments>(programName = "yaml-test-runner")
    let parsed = 
        try
            Some <| parser.ParseCommandLine(inputs = argv, raiseOnUsage = true)
        with e ->
            printfn "%s" e.Message
            None
    match parsed with
    | None -> 1
    | Some parsed ->
        async {
            do! Async.SwitchToThreadPool ()
            return! runMain parsed
        } |> Async.RunSynchronously
    
