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
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Nest
{
    public partial interface IElasticClient
    {
        ClusterNamespace Cluster { get; }

        IndexLifecycleManagementNamespace IndexLifecycleManagement { get; }

        IndicesNamespace Indices { get; }

        DeleteResponse Delete(IDeleteRequest request);
        Task<DeleteResponse> DeleteAsync(IDeleteRequest request, CancellationToken cancellationToken = default);
        DeleteResponse Delete(IndexName index, Id id, Func<DeleteDescriptor, IDeleteRequest> selector = null);
        Task<DeleteResponse> DeleteAsync(IndexName index, Id id, Func<DeleteDescriptor, IDeleteRequest> selector = null, CancellationToken cancellationToken = default);
        ExistsResponse Exists(IExistsRequest request);
        Task<ExistsResponse> ExistsAsync(IExistsRequest request, CancellationToken cancellationToken = default);
        ExistsResponse Exists(IndexName index, Id id, Func<ExistsDescriptor, IExistsRequest> selector = null);
        Task<ExistsResponse> ExistsAsync(IndexName index, Id id, Func<ExistsDescriptor, IExistsRequest> selector = null, CancellationToken cancellationToken = default);
        GetResponse<TDocument> Get<TDocument>(IGetRequest request);
        Task<GetResponse<TDocument>> GetAsync<TDocument>(IGetRequest request, CancellationToken cancellationToken = default);
        GetResponse<TDocument> Get<TDocument>(IndexName index, Id id, Func<GetDescriptor, IGetRequest> selector = null);
        Task<GetResponse<TDocument>> GetAsync<TDocument>(IndexName index, Id id, Func<GetDescriptor, IGetRequest> selector = null, CancellationToken cancellationToken = default);
        IndexResponse Index<TDocument>(IIndexRequest<TDocument> request);
        Task<IndexResponse> IndexAsync<TDocument>(IIndexRequest<TDocument> request, CancellationToken cancellationToken = default);
        IndexResponse Index<TDocument>(TDocument document, IndexName index, Func<IndexDescriptor<TDocument>, IIndexRequest<TDocument>> selector = null);
        Task<IndexResponse> IndexAsync<TDocument>(TDocument document, IndexName index, Func<IndexDescriptor<TDocument>, IIndexRequest<TDocument>> selector = null, CancellationToken cancellationToken = default);
        PingResponse Ping(IPingRequest request);
        Task<PingResponse> PingAsync(IPingRequest request, CancellationToken cancellationToken = default);
        PingResponse Ping(Func<PingDescriptor, IPingRequest> selector = null);
        Task<PingResponse> PingAsync(Func<PingDescriptor, IPingRequest> selector = null, CancellationToken cancellationToken = default);
        SearchResponse<TDocument> Search<TDocument>(ISearchRequest request);
        Task<SearchResponse<TDocument>> SearchAsync<TDocument>(ISearchRequest request, CancellationToken cancellationToken = default);
        SearchResponse<TDocument> Search<TDocument>(Func<SearchDescriptor, ISearchRequest> selector = null);
        Task<SearchResponse<TDocument>> SearchAsync<TDocument>(Func<SearchDescriptor, ISearchRequest> selector = null, CancellationToken cancellationToken = default);
    }
}