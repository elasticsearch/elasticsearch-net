// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗ 
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝ 
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗   
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝   
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗ 
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝ 
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using System.Threading;
using System.Threading.Tasks;

namespace Nest
{
    public partial interface IElasticClient
    {
        AsyncSearchNamespace AsyncSearch { get; }

        AutoscalingNamespace Autoscaling { get; }

        CatNamespace Cat { get; }

        CrossClusterReplicationNamespace CrossClusterReplication { get; }

        ClusterNamespace Cluster { get; }

        DanglingIndicesNamespace DanglingIndices { get; }

        EnrichNamespace Enrich { get; }

        EqlNamespace Eql { get; }

        FeaturesNamespace Features { get; }

        GraphNamespace Graph { get; }

        IndexLifecycleManagementNamespace IndexLifecycleManagement { get; }

        IndicesNamespace Indices { get; }

        IngestNamespace Ingest { get; }

        LicenseNamespace License { get; }

        LogstashNamespace Logstash { get; }

        MigrationNamespace Migration { get; }

        MachineLearningNamespace MachineLearning { get; }

        MonitoringNamespace Monitoring { get; }

        NodesNamespace Nodes { get; }

        RollupNamespace Rollup { get; }

        SearchableSnapshotsNamespace SearchableSnapshots { get; }

        SecurityNamespace Security { get; }

        SnapshotLifecycleManagementNamespace SnapshotLifecycleManagement { get; }

        SnapshotNamespace Snapshot { get; }

        SqlNamespace Sql { get; }

        TasksNamespace Tasks { get; }

        TransformNamespace Transform { get; }

        WatcherNamespace Watcher { get; }

        XPackNamespace XPack { get; }

        ClearScrollResponse ClearScroll(IClearScrollRequest request);
        Task<ClearScrollResponse> ClearScrollAsync(IClearScrollRequest request, CancellationToken cancellationToken = default);
        ClosePointInTimeResponse ClosePointInTime(IClosePointInTimeRequest request);
        Task<ClosePointInTimeResponse> ClosePointInTimeAsync(IClosePointInTimeRequest request, CancellationToken cancellationToken = default);
        CountResponse Count(ICountRequest request);
        Task<CountResponse> CountAsync(ICountRequest request, CancellationToken cancellationToken = default);
        DeleteResponse Delete(IDeleteRequest request);
        Task<DeleteResponse> DeleteAsync(IDeleteRequest request, CancellationToken cancellationToken = default);
        DeleteByQueryResponse DeleteByQuery(IDeleteByQueryRequest request);
        Task<DeleteByQueryResponse> DeleteByQueryAsync(IDeleteByQueryRequest request, CancellationToken cancellationToken = default);
        DeleteByQueryRethrottleResponse DeleteByQueryRethrottle(IDeleteByQueryRethrottleRequest request);
        Task<DeleteByQueryRethrottleResponse> DeleteByQueryRethrottleAsync(IDeleteByQueryRethrottleRequest request, CancellationToken cancellationToken = default);
        DeleteScriptResponse DeleteScript(IDeleteScriptRequest request);
        Task<DeleteScriptResponse> DeleteScriptAsync(IDeleteScriptRequest request, CancellationToken cancellationToken = default);
        DocumentExistsResponse DocumentExists(IDocumentExistsRequest request);
        Task<DocumentExistsResponse> DocumentExistsAsync(IDocumentExistsRequest request, CancellationToken cancellationToken = default);
        SourceExistsResponse SourceExists(ISourceExistsRequest request);
        Task<SourceExistsResponse> SourceExistsAsync(ISourceExistsRequest request, CancellationToken cancellationToken = default);
        ExplainResponse Explain(IExplainRequest request);
        Task<ExplainResponse> ExplainAsync(IExplainRequest request, CancellationToken cancellationToken = default);
        FieldCapabilitiesResponse FieldCapabilities(IFieldCapabilitiesRequest request);
        Task<FieldCapabilitiesResponse> FieldCapabilitiesAsync(IFieldCapabilitiesRequest request, CancellationToken cancellationToken = default);
        GetResponse Get(IGetRequest request);
        Task<GetResponse> GetAsync(IGetRequest request, CancellationToken cancellationToken = default);
        GetScriptResponse GetScript(IGetScriptRequest request);
        Task<GetScriptResponse> GetScriptAsync(IGetScriptRequest request, CancellationToken cancellationToken = default);
        SourceResponse Source(ISourceRequest request);
        Task<SourceResponse> SourceAsync(ISourceRequest request, CancellationToken cancellationToken = default);
        RootNodeInfoResponse RootNodeInfo(IRootNodeInfoRequest request);
        Task<RootNodeInfoResponse> RootNodeInfoAsync(IRootNodeInfoRequest request, CancellationToken cancellationToken = default);
        MultiGetResponse MultiGet(IMultiGetRequest request);
        Task<MultiGetResponse> MultiGetAsync(IMultiGetRequest request, CancellationToken cancellationToken = default);
        MultiSearchResponse MultiSearch(IMultiSearchRequest request);
        Task<MultiSearchResponse> MultiSearchAsync(IMultiSearchRequest request, CancellationToken cancellationToken = default);
        MultiSearchTemplateResponse MultiSearchTemplate(IMultiSearchTemplateRequest request);
        Task<MultiSearchTemplateResponse> MultiSearchTemplateAsync(IMultiSearchTemplateRequest request, CancellationToken cancellationToken = default);
        MultiTermVectorsResponse MultiTermVectors(IMultiTermVectorsRequest request);
        Task<MultiTermVectorsResponse> MultiTermVectorsAsync(IMultiTermVectorsRequest request, CancellationToken cancellationToken = default);
        OpenPointInTimeResponse OpenPointInTime(IOpenPointInTimeRequest request);
        Task<OpenPointInTimeResponse> OpenPointInTimeAsync(IOpenPointInTimeRequest request, CancellationToken cancellationToken = default);
        PingResponse Ping(IPingRequest request);
        Task<PingResponse> PingAsync(IPingRequest request, CancellationToken cancellationToken = default);
        PutScriptResponse PutScript(IPutScriptRequest request);
        Task<PutScriptResponse> PutScriptAsync(IPutScriptRequest request, CancellationToken cancellationToken = default);
        ReindexResponse Reindex(IReindexRequest request);
        Task<ReindexResponse> ReindexAsync(IReindexRequest request, CancellationToken cancellationToken = default);
        ReindexRethrottleResponse ReindexRethrottle(IReindexRethrottleRequest request);
        Task<ReindexRethrottleResponse> ReindexRethrottleAsync(IReindexRethrottleRequest request, CancellationToken cancellationToken = default);
        RenderSearchTemplateResponse RenderSearchTemplate(IRenderSearchTemplateRequest request);
        Task<RenderSearchTemplateResponse> RenderSearchTemplateAsync(IRenderSearchTemplateRequest request, CancellationToken cancellationToken = default);
        ExecutePainlessScriptResponse ExecutePainlessScript(IExecutePainlessScriptRequest request);
        Task<ExecutePainlessScriptResponse> ExecutePainlessScriptAsync(IExecutePainlessScriptRequest request, CancellationToken cancellationToken = default);
        ScrollResponse Scroll(IScrollRequest request);
        Task<ScrollResponse> ScrollAsync(IScrollRequest request, CancellationToken cancellationToken = default);
        SearchResponse Search(ISearchRequest request);
        Task<SearchResponse> SearchAsync(ISearchRequest request, CancellationToken cancellationToken = default);
        SearchShardsResponse SearchShards(ISearchShardsRequest request);
        Task<SearchShardsResponse> SearchShardsAsync(ISearchShardsRequest request, CancellationToken cancellationToken = default);
        UpdateByQueryResponse UpdateByQuery(IUpdateByQueryRequest request);
        Task<UpdateByQueryResponse> UpdateByQueryAsync(IUpdateByQueryRequest request, CancellationToken cancellationToken = default);
    }
}