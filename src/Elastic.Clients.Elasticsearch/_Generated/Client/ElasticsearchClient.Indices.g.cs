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
//
// ------------------------------------------------

using System;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndicesNamespace : NamespacedClientProxy
	{
		internal IndicesNamespace(ElasticsearchClient client) : base(client)
		{
		}

		public AliasResponse GetAlias(AliasRequest request)
		{
			request.BeforeRequest();
			return DoRequest<AliasRequest, AliasResponse>(request);
		}

		public Task<AliasResponse> GetAliasAsync(AliasRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<AliasRequest, AliasResponse>(request, cancellationToken);
		}

		public AliasResponse GetAlias(Action<AliasRequestDescriptor> configureRequest = null)
		{
			var descriptor = new AliasRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<AliasRequestDescriptor, AliasResponse>(descriptor);
		}

		public Task<AliasResponse> GetAliasAsync(Action<AliasRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new AliasRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<AliasRequestDescriptor, AliasResponse>(descriptor);
		}

		public CloseResponse Close(CloseRequest request)
		{
			request.BeforeRequest();
			return DoRequest<CloseRequest, CloseResponse>(request);
		}

		public Task<CloseResponse> CloseAsync(CloseRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<CloseRequest, CloseResponse>(request, cancellationToken);
		}

		public CloseResponse Close(Elastic.Clients.Elasticsearch.Indices indices, Action<CloseRequestDescriptor> configureRequest = null)
		{
			var descriptor = new CloseRequestDescriptor(indices);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<CloseRequestDescriptor, CloseResponse>(descriptor);
		}

		public Task<CloseResponse> CloseAsync(Elastic.Clients.Elasticsearch.Indices indices, Action<CloseRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new CloseRequestDescriptor(indices);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<CloseRequestDescriptor, CloseResponse>(descriptor);
		}

		public CreateDataStreamResponse CreateDataStream(CreateDataStreamRequest request)
		{
			request.BeforeRequest();
			return DoRequest<CreateDataStreamRequest, CreateDataStreamResponse>(request);
		}

		public Task<CreateDataStreamResponse> CreateDataStreamAsync(CreateDataStreamRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<CreateDataStreamRequest, CreateDataStreamResponse>(request, cancellationToken);
		}

		public CreateDataStreamResponse CreateDataStream(Elastic.Clients.Elasticsearch.DataStreamName name, Action<CreateDataStreamRequestDescriptor> configureRequest = null)
		{
			var descriptor = new CreateDataStreamRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<CreateDataStreamRequestDescriptor, CreateDataStreamResponse>(descriptor);
		}

		public Task<CreateDataStreamResponse> CreateDataStreamAsync(Elastic.Clients.Elasticsearch.DataStreamName name, Action<CreateDataStreamRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new CreateDataStreamRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<CreateDataStreamRequestDescriptor, CreateDataStreamResponse>(descriptor);
		}

		public CreateResponse Create(CreateRequest request)
		{
			request.BeforeRequest();
			return DoRequest<CreateRequest, CreateResponse>(request);
		}

		public Task<CreateResponse> CreateAsync(CreateRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<CreateRequest, CreateResponse>(request, cancellationToken);
		}

		public CreateResponse Create(Elastic.Clients.Elasticsearch.IndexName index, Action<CreateRequestDescriptor> configureRequest = null)
		{
			var descriptor = new CreateRequestDescriptor(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<CreateRequestDescriptor, CreateResponse>(descriptor);
		}

		public Task<CreateResponse> CreateAsync(Elastic.Clients.Elasticsearch.IndexName index, Action<CreateRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new CreateRequestDescriptor(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<CreateRequestDescriptor, CreateResponse>(descriptor);
		}

		public DataStreamResponse GetDataStream(DataStreamRequest request)
		{
			request.BeforeRequest();
			return DoRequest<DataStreamRequest, DataStreamResponse>(request);
		}

		public Task<DataStreamResponse> GetDataStreamAsync(DataStreamRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<DataStreamRequest, DataStreamResponse>(request, cancellationToken);
		}

		public DataStreamResponse GetDataStream(Action<DataStreamRequestDescriptor> configureRequest = null)
		{
			var descriptor = new DataStreamRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<DataStreamRequestDescriptor, DataStreamResponse>(descriptor);
		}

		public Task<DataStreamResponse> GetDataStreamAsync(Action<DataStreamRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new DataStreamRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<DataStreamRequestDescriptor, DataStreamResponse>(descriptor);
		}

		public DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
		{
			request.BeforeRequest();
			return DoRequest<DeleteAliasRequest, DeleteAliasResponse>(request);
		}

		public Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<DeleteAliasRequest, DeleteAliasResponse>(request, cancellationToken);
		}

		public DeleteAliasResponse DeleteAlias(Elastic.Clients.Elasticsearch.Indices indices, Elastic.Clients.Elasticsearch.Names name, Action<DeleteAliasRequestDescriptor> configureRequest = null)
		{
			var descriptor = new DeleteAliasRequestDescriptor(indices, name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<DeleteAliasRequestDescriptor, DeleteAliasResponse>(descriptor);
		}

		public Task<DeleteAliasResponse> DeleteAliasAsync(Elastic.Clients.Elasticsearch.Indices indices, Elastic.Clients.Elasticsearch.Names name, Action<DeleteAliasRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new DeleteAliasRequestDescriptor(indices, name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<DeleteAliasRequestDescriptor, DeleteAliasResponse>(descriptor);
		}

		public DeleteDataStreamResponse DeleteDataStream(DeleteDataStreamRequest request)
		{
			request.BeforeRequest();
			return DoRequest<DeleteDataStreamRequest, DeleteDataStreamResponse>(request);
		}

		public Task<DeleteDataStreamResponse> DeleteDataStreamAsync(DeleteDataStreamRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<DeleteDataStreamRequest, DeleteDataStreamResponse>(request, cancellationToken);
		}

		public DeleteDataStreamResponse DeleteDataStream(Elastic.Clients.Elasticsearch.DataStreamNames name, Action<DeleteDataStreamRequestDescriptor> configureRequest = null)
		{
			var descriptor = new DeleteDataStreamRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<DeleteDataStreamRequestDescriptor, DeleteDataStreamResponse>(descriptor);
		}

		public Task<DeleteDataStreamResponse> DeleteDataStreamAsync(Elastic.Clients.Elasticsearch.DataStreamNames name, Action<DeleteDataStreamRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new DeleteDataStreamRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<DeleteDataStreamRequestDescriptor, DeleteDataStreamResponse>(descriptor);
		}

		public DeleteIndexTemplateResponse DeleteIndexTemplate(DeleteIndexTemplateRequest request)
		{
			request.BeforeRequest();
			return DoRequest<DeleteIndexTemplateRequest, DeleteIndexTemplateResponse>(request);
		}

		public Task<DeleteIndexTemplateResponse> DeleteIndexTemplateAsync(DeleteIndexTemplateRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<DeleteIndexTemplateRequest, DeleteIndexTemplateResponse>(request, cancellationToken);
		}

		public DeleteIndexTemplateResponse DeleteIndexTemplate(Elastic.Clients.Elasticsearch.Names name, Action<DeleteIndexTemplateRequestDescriptor> configureRequest = null)
		{
			var descriptor = new DeleteIndexTemplateRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<DeleteIndexTemplateRequestDescriptor, DeleteIndexTemplateResponse>(descriptor);
		}

		public Task<DeleteIndexTemplateResponse> DeleteIndexTemplateAsync(Elastic.Clients.Elasticsearch.Names name, Action<DeleteIndexTemplateRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new DeleteIndexTemplateRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<DeleteIndexTemplateRequestDescriptor, DeleteIndexTemplateResponse>(descriptor);
		}

		public DeleteResponse Delete(DeleteRequest request)
		{
			request.BeforeRequest();
			return DoRequest<DeleteRequest, DeleteResponse>(request);
		}

		public Task<DeleteResponse> DeleteAsync(DeleteRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<DeleteRequest, DeleteResponse>(request, cancellationToken);
		}

		public DeleteResponse Delete(Elastic.Clients.Elasticsearch.Indices indices, Action<DeleteRequestDescriptor> configureRequest = null)
		{
			var descriptor = new DeleteRequestDescriptor(indices);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<DeleteRequestDescriptor, DeleteResponse>(descriptor);
		}

		public Task<DeleteResponse> DeleteAsync(Elastic.Clients.Elasticsearch.Indices indices, Action<DeleteRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new DeleteRequestDescriptor(indices);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<DeleteRequestDescriptor, DeleteResponse>(descriptor);
		}

		public ExistsAliasResponse ExistsAlias(ExistsAliasRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ExistsAliasRequest, ExistsAliasResponse>(request);
		}

		public Task<ExistsAliasResponse> ExistsAliasAsync(ExistsAliasRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ExistsAliasRequest, ExistsAliasResponse>(request, cancellationToken);
		}

		public ExistsAliasResponse ExistsAlias(Elastic.Clients.Elasticsearch.Names name, Action<ExistsAliasRequestDescriptor> configureRequest = null)
		{
			var descriptor = new ExistsAliasRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ExistsAliasRequestDescriptor, ExistsAliasResponse>(descriptor);
		}

		public Task<ExistsAliasResponse> ExistsAliasAsync(Elastic.Clients.Elasticsearch.Names name, Action<ExistsAliasRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new ExistsAliasRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ExistsAliasRequestDescriptor, ExistsAliasResponse>(descriptor);
		}

		public ExistsIndexTemplateResponse ExistsIndexTemplate(ExistsIndexTemplateRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ExistsIndexTemplateRequest, ExistsIndexTemplateResponse>(request);
		}

		public Task<ExistsIndexTemplateResponse> ExistsIndexTemplateAsync(ExistsIndexTemplateRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ExistsIndexTemplateRequest, ExistsIndexTemplateResponse>(request, cancellationToken);
		}

		public ExistsIndexTemplateResponse ExistsIndexTemplate(Elastic.Clients.Elasticsearch.Name name, Action<ExistsIndexTemplateRequestDescriptor> configureRequest = null)
		{
			var descriptor = new ExistsIndexTemplateRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ExistsIndexTemplateRequestDescriptor, ExistsIndexTemplateResponse>(descriptor);
		}

		public Task<ExistsIndexTemplateResponse> ExistsIndexTemplateAsync(Elastic.Clients.Elasticsearch.Name name, Action<ExistsIndexTemplateRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new ExistsIndexTemplateRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ExistsIndexTemplateRequestDescriptor, ExistsIndexTemplateResponse>(descriptor);
		}

		public ExistsResponse Exists(ExistsRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ExistsRequest, ExistsResponse>(request);
		}

		public Task<ExistsResponse> ExistsAsync(ExistsRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ExistsRequest, ExistsResponse>(request, cancellationToken);
		}

		public ExistsResponse Exists(Elastic.Clients.Elasticsearch.Indices indices, Action<ExistsRequestDescriptor> configureRequest = null)
		{
			var descriptor = new ExistsRequestDescriptor(indices);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ExistsRequestDescriptor, ExistsResponse>(descriptor);
		}

		public Task<ExistsResponse> ExistsAsync(Elastic.Clients.Elasticsearch.Indices indices, Action<ExistsRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new ExistsRequestDescriptor(indices);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ExistsRequestDescriptor, ExistsResponse>(descriptor);
		}

		public GetResponse Get(GetRequest request)
		{
			request.BeforeRequest();
			return DoRequest<GetRequest, GetResponse>(request);
		}

		public Task<GetResponse> GetAsync(GetRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<GetRequest, GetResponse>(request, cancellationToken);
		}

		public GetResponse Get(Elastic.Clients.Elasticsearch.Indices indices, Action<GetRequestDescriptor> configureRequest = null)
		{
			var descriptor = new GetRequestDescriptor(indices);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<GetRequestDescriptor, GetResponse>(descriptor);
		}

		public Task<GetResponse> GetAsync(Elastic.Clients.Elasticsearch.Indices indices, Action<GetRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new GetRequestDescriptor(indices);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<GetRequestDescriptor, GetResponse>(descriptor);
		}

		public IndexTemplateResponse GetIndexTemplate(IndexTemplateRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IndexTemplateRequest, IndexTemplateResponse>(request);
		}

		public Task<IndexTemplateResponse> GetIndexTemplateAsync(IndexTemplateRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IndexTemplateRequest, IndexTemplateResponse>(request, cancellationToken);
		}

		public IndexTemplateResponse GetIndexTemplate(Action<IndexTemplateRequestDescriptor> configureRequest = null)
		{
			var descriptor = new IndexTemplateRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IndexTemplateRequestDescriptor, IndexTemplateResponse>(descriptor);
		}

		public Task<IndexTemplateResponse> GetIndexTemplateAsync(Action<IndexTemplateRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new IndexTemplateRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IndexTemplateRequestDescriptor, IndexTemplateResponse>(descriptor);
		}

		public MappingResponse GetMapping(MappingRequest request)
		{
			request.BeforeRequest();
			return DoRequest<MappingRequest, MappingResponse>(request);
		}

		public Task<MappingResponse> GetMappingAsync(MappingRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<MappingRequest, MappingResponse>(request, cancellationToken);
		}

		public MappingResponse GetMapping(Action<MappingRequestDescriptor> configureRequest = null)
		{
			var descriptor = new MappingRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<MappingRequestDescriptor, MappingResponse>(descriptor);
		}

		public Task<MappingResponse> GetMappingAsync(Action<MappingRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new MappingRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<MappingRequestDescriptor, MappingResponse>(descriptor);
		}

		public MigrateToDataStreamResponse MigrateToDataStream(MigrateToDataStreamRequest request)
		{
			request.BeforeRequest();
			return DoRequest<MigrateToDataStreamRequest, MigrateToDataStreamResponse>(request);
		}

		public Task<MigrateToDataStreamResponse> MigrateToDataStreamAsync(MigrateToDataStreamRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<MigrateToDataStreamRequest, MigrateToDataStreamResponse>(request, cancellationToken);
		}

		public MigrateToDataStreamResponse MigrateToDataStream(Elastic.Clients.Elasticsearch.IndexName name, Action<MigrateToDataStreamRequestDescriptor> configureRequest = null)
		{
			var descriptor = new MigrateToDataStreamRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<MigrateToDataStreamRequestDescriptor, MigrateToDataStreamResponse>(descriptor);
		}

		public Task<MigrateToDataStreamResponse> MigrateToDataStreamAsync(Elastic.Clients.Elasticsearch.IndexName name, Action<MigrateToDataStreamRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new MigrateToDataStreamRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<MigrateToDataStreamRequestDescriptor, MigrateToDataStreamResponse>(descriptor);
		}

		public OpenResponse Open(OpenRequest request)
		{
			request.BeforeRequest();
			return DoRequest<OpenRequest, OpenResponse>(request);
		}

		public Task<OpenResponse> OpenAsync(OpenRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<OpenRequest, OpenResponse>(request, cancellationToken);
		}

		public OpenResponse Open(Elastic.Clients.Elasticsearch.Indices indices, Action<OpenRequestDescriptor> configureRequest = null)
		{
			var descriptor = new OpenRequestDescriptor(indices);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<OpenRequestDescriptor, OpenResponse>(descriptor);
		}

		public Task<OpenResponse> OpenAsync(Elastic.Clients.Elasticsearch.Indices indices, Action<OpenRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new OpenRequestDescriptor(indices);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<OpenRequestDescriptor, OpenResponse>(descriptor);
		}

		public PromoteDataStreamResponse PromoteDataStream(PromoteDataStreamRequest request)
		{
			request.BeforeRequest();
			return DoRequest<PromoteDataStreamRequest, PromoteDataStreamResponse>(request);
		}

		public Task<PromoteDataStreamResponse> PromoteDataStreamAsync(PromoteDataStreamRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<PromoteDataStreamRequest, PromoteDataStreamResponse>(request, cancellationToken);
		}

		public PromoteDataStreamResponse PromoteDataStream(Elastic.Clients.Elasticsearch.IndexName name, Action<PromoteDataStreamRequestDescriptor> configureRequest = null)
		{
			var descriptor = new PromoteDataStreamRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<PromoteDataStreamRequestDescriptor, PromoteDataStreamResponse>(descriptor);
		}

		public Task<PromoteDataStreamResponse> PromoteDataStreamAsync(Elastic.Clients.Elasticsearch.IndexName name, Action<PromoteDataStreamRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new PromoteDataStreamRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<PromoteDataStreamRequestDescriptor, PromoteDataStreamResponse>(descriptor);
		}

		public PutAliasResponse PutAlias(PutAliasRequest request)
		{
			request.BeforeRequest();
			return DoRequest<PutAliasRequest, PutAliasResponse>(request);
		}

		public Task<PutAliasResponse> PutAliasAsync(PutAliasRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<PutAliasRequest, PutAliasResponse>(request, cancellationToken);
		}

		public PutAliasResponse PutAlias(Elastic.Clients.Elasticsearch.Indices indices, Elastic.Clients.Elasticsearch.Name name, Action<PutAliasRequestDescriptor> configureRequest = null)
		{
			var descriptor = new PutAliasRequestDescriptor(indices, name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<PutAliasRequestDescriptor, PutAliasResponse>(descriptor);
		}

		public Task<PutAliasResponse> PutAliasAsync(Elastic.Clients.Elasticsearch.Indices indices, Elastic.Clients.Elasticsearch.Name name, Action<PutAliasRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new PutAliasRequestDescriptor(indices, name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<PutAliasRequestDescriptor, PutAliasResponse>(descriptor);
		}

		public PutIndexTemplateResponse PutIndexTemplate(PutIndexTemplateRequest request)
		{
			request.BeforeRequest();
			return DoRequest<PutIndexTemplateRequest, PutIndexTemplateResponse>(request);
		}

		public Task<PutIndexTemplateResponse> PutIndexTemplateAsync(PutIndexTemplateRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<PutIndexTemplateRequest, PutIndexTemplateResponse>(request, cancellationToken);
		}

		public PutIndexTemplateResponse PutIndexTemplate(Elastic.Clients.Elasticsearch.Name name, Action<PutIndexTemplateRequestDescriptor> configureRequest = null)
		{
			var descriptor = new PutIndexTemplateRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<PutIndexTemplateRequestDescriptor, PutIndexTemplateResponse>(descriptor);
		}

		public Task<PutIndexTemplateResponse> PutIndexTemplateAsync(Elastic.Clients.Elasticsearch.Name name, Action<PutIndexTemplateRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new PutIndexTemplateRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<PutIndexTemplateRequestDescriptor, PutIndexTemplateResponse>(descriptor);
		}

		public PutMappingResponse PutMapping(PutMappingRequest request)
		{
			request.BeforeRequest();
			return DoRequest<PutMappingRequest, PutMappingResponse>(request);
		}

		public Task<PutMappingResponse> PutMappingAsync(PutMappingRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<PutMappingRequest, PutMappingResponse>(request, cancellationToken);
		}

		public PutMappingResponse PutMapping(Elastic.Clients.Elasticsearch.Indices indices, Action<PutMappingRequestDescriptor> configureRequest = null)
		{
			var descriptor = new PutMappingRequestDescriptor(indices);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<PutMappingRequestDescriptor, PutMappingResponse>(descriptor);
		}

		public Task<PutMappingResponse> PutMappingAsync(Elastic.Clients.Elasticsearch.Indices indices, Action<PutMappingRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new PutMappingRequestDescriptor(indices);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<PutMappingRequestDescriptor, PutMappingResponse>(descriptor);
		}

		public RefreshResponse Refresh(RefreshRequest request)
		{
			request.BeforeRequest();
			return DoRequest<RefreshRequest, RefreshResponse>(request);
		}

		public Task<RefreshResponse> RefreshAsync(RefreshRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<RefreshRequest, RefreshResponse>(request, cancellationToken);
		}

		public RefreshResponse Refresh(Action<RefreshRequestDescriptor> configureRequest = null)
		{
			var descriptor = new RefreshRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<RefreshRequestDescriptor, RefreshResponse>(descriptor);
		}

		public Task<RefreshResponse> RefreshAsync(Action<RefreshRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new RefreshRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<RefreshRequestDescriptor, RefreshResponse>(descriptor);
		}

		public ShrinkResponse Shrink(ShrinkRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ShrinkRequest, ShrinkResponse>(request);
		}

		public Task<ShrinkResponse> ShrinkAsync(ShrinkRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ShrinkRequest, ShrinkResponse>(request, cancellationToken);
		}

		public ShrinkResponse Shrink(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.IndexName target, Action<ShrinkRequestDescriptor> configureRequest = null)
		{
			var descriptor = new ShrinkRequestDescriptor(index, target);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ShrinkRequestDescriptor, ShrinkResponse>(descriptor);
		}

		public Task<ShrinkResponse> ShrinkAsync(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.IndexName target, Action<ShrinkRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new ShrinkRequestDescriptor(index, target);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ShrinkRequestDescriptor, ShrinkResponse>(descriptor);
		}

		public SplitResponse Split(SplitRequest request)
		{
			request.BeforeRequest();
			return DoRequest<SplitRequest, SplitResponse>(request);
		}

		public Task<SplitResponse> SplitAsync(SplitRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<SplitRequest, SplitResponse>(request, cancellationToken);
		}

		public SplitResponse Split(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.IndexName target, Action<SplitRequestDescriptor> configureRequest = null)
		{
			var descriptor = new SplitRequestDescriptor(index, target);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<SplitRequestDescriptor, SplitResponse>(descriptor);
		}

		public Task<SplitResponse> SplitAsync(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.IndexName target, Action<SplitRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new SplitRequestDescriptor(index, target);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<SplitRequestDescriptor, SplitResponse>(descriptor);
		}

		public UpdateAliasesResponse UpdateAliases(UpdateAliasesRequest request)
		{
			request.BeforeRequest();
			return DoRequest<UpdateAliasesRequest, UpdateAliasesResponse>(request);
		}

		public Task<UpdateAliasesResponse> UpdateAliasesAsync(UpdateAliasesRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<UpdateAliasesRequest, UpdateAliasesResponse>(request, cancellationToken);
		}

		public UpdateAliasesResponse UpdateAliases(Action<UpdateAliasesRequestDescriptor> configureRequest = null)
		{
			var descriptor = new UpdateAliasesRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<UpdateAliasesRequestDescriptor, UpdateAliasesResponse>(descriptor);
		}

		public Task<UpdateAliasesResponse> UpdateAliasesAsync(Action<UpdateAliasesRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new UpdateAliasesRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<UpdateAliasesRequestDescriptor, UpdateAliasesResponse>(descriptor);
		}
	}
}