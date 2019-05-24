using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Specification.IndicesApi;

//This file is automatically generated from https://github.com/elastic/elasticsearch/tree/master/rest-api-spec
// ReSharper disable once CheckNamespace
namespace Nest.Specification.IndicesApi
{
	///<summary>
	/// Logically groups all Indices API's together so that they may be discovered more naturally.
	/// <para>Not intended to be instantiated directly please defer to the <see cref = "IElasticClient.Indices"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class IndicesNamespace : NamespacedClientProxy
	{
		internal IndicesNamespace(ElasticClient client): base(client)
		{
		}

		///<inheritdoc cref = "IAnalyzeRequest"/>
		public AnalyzeResponse Analyze(Func<AnalyzeDescriptor, IAnalyzeRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IAnalyzeRequest"/>
		public Task<AnalyzeResponse> AnalyzeAsync(Func<AnalyzeDescriptor, IAnalyzeRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IAnalyzeRequest"/>
		public AnalyzeResponse Analyze(IAnalyzeRequest request) => DoRequest<IAnalyzeRequest, AnalyzeResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IAnalyzeRequest"/>
		public Task<AnalyzeResponse> AnalyzeAsync(IAnalyzeRequest request, CancellationToken ct = default) => DoRequestAsync<IAnalyzeRequest, AnalyzeResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IClearCacheRequest"/>
		public ClearCacheResponse ClearCache(Indices index = null, Func<ClearCacheDescriptor, IClearCacheRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IClearCacheRequest"/>
		public Task<ClearCacheResponse> ClearCacheAsync(Indices index = null, Func<ClearCacheDescriptor, IClearCacheRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IClearCacheRequest"/>
		public ClearCacheResponse ClearCache(IClearCacheRequest request) => DoRequest<IClearCacheRequest, ClearCacheResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IClearCacheRequest"/>
		public Task<ClearCacheResponse> ClearCacheAsync(IClearCacheRequest request, CancellationToken ct = default) => DoRequestAsync<IClearCacheRequest, ClearCacheResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "ICloseIndexRequest"/>
		public CloseIndexResponse CloseIndex(Indices index, Func<CloseIndexDescriptor, ICloseIndexRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "ICloseIndexRequest"/>
		public Task<CloseIndexResponse> CloseIndexAsync(Indices index, Func<CloseIndexDescriptor, ICloseIndexRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "ICloseIndexRequest"/>
		public CloseIndexResponse CloseIndex(ICloseIndexRequest request) => DoRequest<ICloseIndexRequest, CloseIndexResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "ICloseIndexRequest"/>
		public Task<CloseIndexResponse> CloseIndexAsync(ICloseIndexRequest request, CancellationToken ct = default) => DoRequestAsync<ICloseIndexRequest, CloseIndexResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "ICreateIndexRequest"/>
		public CreateIndexResponse CreateIndex(IndexName index, Func<CreateIndexDescriptor, ICreateIndexRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "ICreateIndexRequest"/>
		public Task<CreateIndexResponse> CreateIndexAsync(IndexName index, Func<CreateIndexDescriptor, ICreateIndexRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "ICreateIndexRequest"/>
		public CreateIndexResponse CreateIndex(ICreateIndexRequest request) => DoRequest<ICreateIndexRequest, CreateIndexResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "ICreateIndexRequest"/>
		public Task<CreateIndexResponse> CreateIndexAsync(ICreateIndexRequest request, CancellationToken ct = default) => DoRequestAsync<ICreateIndexRequest, CreateIndexResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IDeleteIndexRequest"/>
		public DeleteIndexResponse DeleteIndex(Indices index, Func<DeleteIndexDescriptor, IDeleteIndexRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IDeleteIndexRequest"/>
		public Task<DeleteIndexResponse> DeleteIndexAsync(Indices index, Func<DeleteIndexDescriptor, IDeleteIndexRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IDeleteIndexRequest"/>
		public DeleteIndexResponse DeleteIndex(IDeleteIndexRequest request) => DoRequest<IDeleteIndexRequest, DeleteIndexResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IDeleteIndexRequest"/>
		public Task<DeleteIndexResponse> DeleteIndexAsync(IDeleteIndexRequest request, CancellationToken ct = default) => DoRequestAsync<IDeleteIndexRequest, DeleteIndexResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IDeleteAliasRequest"/>
		public DeleteAliasResponse DeleteAlias(Indices index, Names name, Func<DeleteAliasDescriptor, IDeleteAliasRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IDeleteAliasRequest"/>
		public Task<DeleteAliasResponse> DeleteAliasAsync(Indices index, Names name, Func<DeleteAliasDescriptor, IDeleteAliasRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IDeleteAliasRequest"/>
		public DeleteAliasResponse DeleteAlias(IDeleteAliasRequest request) => DoRequest<IDeleteAliasRequest, DeleteAliasResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IDeleteAliasRequest"/>
		public Task<DeleteAliasResponse> DeleteAliasAsync(IDeleteAliasRequest request, CancellationToken ct = default) => DoRequestAsync<IDeleteAliasRequest, DeleteAliasResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IDeleteIndexTemplateRequest"/>
		public DeleteIndexTemplateResponse DeleteIndexTemplate(Name name, Func<DeleteIndexTemplateDescriptor, IDeleteIndexTemplateRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IDeleteIndexTemplateRequest"/>
		public Task<DeleteIndexTemplateResponse> DeleteIndexTemplateAsync(Name name, Func<DeleteIndexTemplateDescriptor, IDeleteIndexTemplateRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IDeleteIndexTemplateRequest"/>
		public DeleteIndexTemplateResponse DeleteIndexTemplate(IDeleteIndexTemplateRequest request) => DoRequest<IDeleteIndexTemplateRequest, DeleteIndexTemplateResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IDeleteIndexTemplateRequest"/>
		public Task<DeleteIndexTemplateResponse> DeleteIndexTemplateAsync(IDeleteIndexTemplateRequest request, CancellationToken ct = default) => DoRequestAsync<IDeleteIndexTemplateRequest, DeleteIndexTemplateResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IIndexExistsRequest"/>
		public ExistsResponse IndexExists(Indices index, Func<IndexExistsDescriptor, IIndexExistsRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IIndexExistsRequest"/>
		public Task<ExistsResponse> IndexExistsAsync(Indices index, Func<IndexExistsDescriptor, IIndexExistsRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IIndexExistsRequest"/>
		public ExistsResponse IndexExists(IIndexExistsRequest request) => DoRequest<IIndexExistsRequest, ExistsResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IIndexExistsRequest"/>
		public Task<ExistsResponse> IndexExistsAsync(IIndexExistsRequest request, CancellationToken ct = default) => DoRequestAsync<IIndexExistsRequest, ExistsResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IAliasExistsRequest"/>
		public ExistsResponse AliasExists(Names name, Func<AliasExistsDescriptor, IAliasExistsRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IAliasExistsRequest"/>
		public Task<ExistsResponse> AliasExistsAsync(Names name, Func<AliasExistsDescriptor, IAliasExistsRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IAliasExistsRequest"/>
		public ExistsResponse AliasExists(IAliasExistsRequest request) => DoRequest<IAliasExistsRequest, ExistsResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IAliasExistsRequest"/>
		public Task<ExistsResponse> AliasExistsAsync(IAliasExistsRequest request, CancellationToken ct = default) => DoRequestAsync<IAliasExistsRequest, ExistsResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IIndexTemplateExistsRequest"/>
		public ExistsResponse IndexTemplateExists(Names name, Func<IndexTemplateExistsDescriptor, IIndexTemplateExistsRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IIndexTemplateExistsRequest"/>
		public Task<ExistsResponse> IndexTemplateExistsAsync(Names name, Func<IndexTemplateExistsDescriptor, IIndexTemplateExistsRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IIndexTemplateExistsRequest"/>
		public ExistsResponse IndexTemplateExists(IIndexTemplateExistsRequest request) => DoRequest<IIndexTemplateExistsRequest, ExistsResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IIndexTemplateExistsRequest"/>
		public Task<ExistsResponse> IndexTemplateExistsAsync(IIndexTemplateExistsRequest request, CancellationToken ct = default) => DoRequestAsync<IIndexTemplateExistsRequest, ExistsResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "ITypeExistsRequest"/>
		public ExistsResponse TypeExists(Indices index, Names type, Func<TypeExistsDescriptor, ITypeExistsRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "ITypeExistsRequest"/>
		public Task<ExistsResponse> TypeExistsAsync(Indices index, Names type, Func<TypeExistsDescriptor, ITypeExistsRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "ITypeExistsRequest"/>
		public ExistsResponse TypeExists(ITypeExistsRequest request) => DoRequest<ITypeExistsRequest, ExistsResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "ITypeExistsRequest"/>
		public Task<ExistsResponse> TypeExistsAsync(ITypeExistsRequest request, CancellationToken ct = default) => DoRequestAsync<ITypeExistsRequest, ExistsResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IFlushRequest"/>
		public FlushResponse Flush(Indices index = null, Func<FlushDescriptor, IFlushRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IFlushRequest"/>
		public Task<FlushResponse> FlushAsync(Indices index = null, Func<FlushDescriptor, IFlushRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IFlushRequest"/>
		public FlushResponse Flush(IFlushRequest request) => DoRequest<IFlushRequest, FlushResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IFlushRequest"/>
		public Task<FlushResponse> FlushAsync(IFlushRequest request, CancellationToken ct = default) => DoRequestAsync<IFlushRequest, FlushResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "ISyncedFlushRequest"/>
		public SyncedFlushResponse SyncedFlush(Indices index = null, Func<SyncedFlushDescriptor, ISyncedFlushRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "ISyncedFlushRequest"/>
		public Task<SyncedFlushResponse> SyncedFlushAsync(Indices index = null, Func<SyncedFlushDescriptor, ISyncedFlushRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "ISyncedFlushRequest"/>
		public SyncedFlushResponse SyncedFlush(ISyncedFlushRequest request) => DoRequest<ISyncedFlushRequest, SyncedFlushResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "ISyncedFlushRequest"/>
		public Task<SyncedFlushResponse> SyncedFlushAsync(ISyncedFlushRequest request, CancellationToken ct = default) => DoRequestAsync<ISyncedFlushRequest, SyncedFlushResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IForceMergeRequest"/>
		public ForceMergeResponse ForceMerge(Indices index = null, Func<ForceMergeDescriptor, IForceMergeRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IForceMergeRequest"/>
		public Task<ForceMergeResponse> ForceMergeAsync(Indices index = null, Func<ForceMergeDescriptor, IForceMergeRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IForceMergeRequest"/>
		public ForceMergeResponse ForceMerge(IForceMergeRequest request) => DoRequest<IForceMergeRequest, ForceMergeResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IForceMergeRequest"/>
		public Task<ForceMergeResponse> ForceMergeAsync(IForceMergeRequest request, CancellationToken ct = default) => DoRequestAsync<IForceMergeRequest, ForceMergeResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IGetIndexRequest"/>
		public GetIndexResponse GetIndex(Indices index, Func<GetIndexDescriptor, IGetIndexRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IGetIndexRequest"/>
		public Task<GetIndexResponse> GetIndexAsync(Indices index, Func<GetIndexDescriptor, IGetIndexRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IGetIndexRequest"/>
		public GetIndexResponse GetIndex(IGetIndexRequest request) => DoRequest<IGetIndexRequest, GetIndexResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IGetIndexRequest"/>
		public Task<GetIndexResponse> GetIndexAsync(IGetIndexRequest request, CancellationToken ct = default) => DoRequestAsync<IGetIndexRequest, GetIndexResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IGetAliasRequest"/>
		public GetAliasResponse GetAlias(Indices index = null, Func<GetAliasDescriptor, IGetAliasRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IGetAliasRequest"/>
		public Task<GetAliasResponse> GetAliasAsync(Indices index = null, Func<GetAliasDescriptor, IGetAliasRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IGetAliasRequest"/>
		public GetAliasResponse GetAlias(IGetAliasRequest request) => DoRequest<IGetAliasRequest, GetAliasResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IGetAliasRequest"/>
		public Task<GetAliasResponse> GetAliasAsync(IGetAliasRequest request, CancellationToken ct = default) => DoRequestAsync<IGetAliasRequest, GetAliasResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IGetFieldMappingRequest"/>
		public GetFieldMappingResponse GetFieldMapping<TDocument>(Fields fields, Func<GetFieldMappingDescriptor<TDocument>, IGetFieldMappingRequest> selector = null)
			where TDocument : class => throw new NotImplementedException();
		///<inheritdoc cref = "IGetFieldMappingRequest"/>
		public Task<GetFieldMappingResponse> GetFieldMappingAsync<TDocument>(Fields fields, Func<GetFieldMappingDescriptor<TDocument>, IGetFieldMappingRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => throw new NotImplementedException();
		///<inheritdoc cref = "IGetFieldMappingRequest"/>
		public GetFieldMappingResponse GetFieldMapping(IGetFieldMappingRequest request) => DoRequest<IGetFieldMappingRequest, GetFieldMappingResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IGetFieldMappingRequest"/>
		public Task<GetFieldMappingResponse> GetFieldMappingAsync(IGetFieldMappingRequest request, CancellationToken ct = default) => DoRequestAsync<IGetFieldMappingRequest, GetFieldMappingResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IGetMappingRequest"/>
		public GetMappingResponse GetMapping<TDocument>(Func<GetMappingDescriptor<TDocument>, IGetMappingRequest> selector = null)
			where TDocument : class => throw new NotImplementedException();
		///<inheritdoc cref = "IGetMappingRequest"/>
		public Task<GetMappingResponse> GetMappingAsync<TDocument>(Func<GetMappingDescriptor<TDocument>, IGetMappingRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => throw new NotImplementedException();
		///<inheritdoc cref = "IGetMappingRequest"/>
		public GetMappingResponse GetMapping(IGetMappingRequest request) => DoRequest<IGetMappingRequest, GetMappingResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IGetMappingRequest"/>
		public Task<GetMappingResponse> GetMappingAsync(IGetMappingRequest request, CancellationToken ct = default) => DoRequestAsync<IGetMappingRequest, GetMappingResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IGetIndexSettingsRequest"/>
		public GetIndexSettingsResponse GetIndexSettings(Indices index = null, Func<GetIndexSettingsDescriptor, IGetIndexSettingsRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IGetIndexSettingsRequest"/>
		public Task<GetIndexSettingsResponse> GetIndexSettingsAsync(Indices index = null, Func<GetIndexSettingsDescriptor, IGetIndexSettingsRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IGetIndexSettingsRequest"/>
		public GetIndexSettingsResponse GetIndexSettings(IGetIndexSettingsRequest request) => DoRequest<IGetIndexSettingsRequest, GetIndexSettingsResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IGetIndexSettingsRequest"/>
		public Task<GetIndexSettingsResponse> GetIndexSettingsAsync(IGetIndexSettingsRequest request, CancellationToken ct = default) => DoRequestAsync<IGetIndexSettingsRequest, GetIndexSettingsResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IGetIndexTemplateRequest"/>
		public GetIndexTemplateResponse GetIndexTemplate(Names name = null, Func<GetIndexTemplateDescriptor, IGetIndexTemplateRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IGetIndexTemplateRequest"/>
		public Task<GetIndexTemplateResponse> GetIndexTemplateAsync(Names name = null, Func<GetIndexTemplateDescriptor, IGetIndexTemplateRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IGetIndexTemplateRequest"/>
		public GetIndexTemplateResponse GetIndexTemplate(IGetIndexTemplateRequest request) => DoRequest<IGetIndexTemplateRequest, GetIndexTemplateResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IGetIndexTemplateRequest"/>
		public Task<GetIndexTemplateResponse> GetIndexTemplateAsync(IGetIndexTemplateRequest request, CancellationToken ct = default) => DoRequestAsync<IGetIndexTemplateRequest, GetIndexTemplateResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IUpgradeStatusRequest"/>
		public UpgradeStatusResponse UpgradeStatus(Indices index = null, Func<UpgradeStatusDescriptor, IUpgradeStatusRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IUpgradeStatusRequest"/>
		public Task<UpgradeStatusResponse> UpgradeStatusAsync(Indices index = null, Func<UpgradeStatusDescriptor, IUpgradeStatusRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IUpgradeStatusRequest"/>
		public UpgradeStatusResponse UpgradeStatus(IUpgradeStatusRequest request) => DoRequest<IUpgradeStatusRequest, UpgradeStatusResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IUpgradeStatusRequest"/>
		public Task<UpgradeStatusResponse> UpgradeStatusAsync(IUpgradeStatusRequest request, CancellationToken ct = default) => DoRequestAsync<IUpgradeStatusRequest, UpgradeStatusResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IOpenIndexRequest"/>
		public OpenIndexResponse OpenIndex(Indices index, Func<OpenIndexDescriptor, IOpenIndexRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IOpenIndexRequest"/>
		public Task<OpenIndexResponse> OpenIndexAsync(Indices index, Func<OpenIndexDescriptor, IOpenIndexRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IOpenIndexRequest"/>
		public OpenIndexResponse OpenIndex(IOpenIndexRequest request) => DoRequest<IOpenIndexRequest, OpenIndexResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IOpenIndexRequest"/>
		public Task<OpenIndexResponse> OpenIndexAsync(IOpenIndexRequest request, CancellationToken ct = default) => DoRequestAsync<IOpenIndexRequest, OpenIndexResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IPutAliasRequest"/>
		public PutAliasResponse PutAlias(Indices index, Name name, Func<PutAliasDescriptor, IPutAliasRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IPutAliasRequest"/>
		public Task<PutAliasResponse> PutAliasAsync(Indices index, Name name, Func<PutAliasDescriptor, IPutAliasRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IPutAliasRequest"/>
		public PutAliasResponse PutAlias(IPutAliasRequest request) => DoRequest<IPutAliasRequest, PutAliasResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IPutAliasRequest"/>
		public Task<PutAliasResponse> PutAliasAsync(IPutAliasRequest request, CancellationToken ct = default) => DoRequestAsync<IPutAliasRequest, PutAliasResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IPutMappingRequest"/>
		public PutMappingResponse PutMapping<TDocument>(Func<PutMappingDescriptor<TDocument>, IPutMappingRequest> selector)
			where TDocument : class => throw new NotImplementedException();
		///<inheritdoc cref = "IPutMappingRequest"/>
		public Task<PutMappingResponse> PutMappingAsync<TDocument>(Func<PutMappingDescriptor<TDocument>, IPutMappingRequest> selector, CancellationToken ct = default)
			where TDocument : class => throw new NotImplementedException();
		///<inheritdoc cref = "IPutMappingRequest"/>
		public PutMappingResponse PutMapping(IPutMappingRequest request) => DoRequest<IPutMappingRequest, PutMappingResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IPutMappingRequest"/>
		public Task<PutMappingResponse> PutMappingAsync(IPutMappingRequest request, CancellationToken ct = default) => DoRequestAsync<IPutMappingRequest, PutMappingResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IUpdateIndexSettingsRequest"/>
		public UpdateIndexSettingsResponse UpdateIndexSettings(Indices index, Func<UpdateIndexSettingsDescriptor, IUpdateIndexSettingsRequest> selector) => throw new NotImplementedException();
		///<inheritdoc cref = "IUpdateIndexSettingsRequest"/>
		public Task<UpdateIndexSettingsResponse> UpdateIndexSettingsAsync(Indices index, Func<UpdateIndexSettingsDescriptor, IUpdateIndexSettingsRequest> selector, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IUpdateIndexSettingsRequest"/>
		public UpdateIndexSettingsResponse UpdateIndexSettings(IUpdateIndexSettingsRequest request) => DoRequest<IUpdateIndexSettingsRequest, UpdateIndexSettingsResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IUpdateIndexSettingsRequest"/>
		public Task<UpdateIndexSettingsResponse> UpdateIndexSettingsAsync(IUpdateIndexSettingsRequest request, CancellationToken ct = default) => DoRequestAsync<IUpdateIndexSettingsRequest, UpdateIndexSettingsResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IPutIndexTemplateRequest"/>
		public PutIndexTemplateResponse PutIndexTemplate(Name name, Func<PutIndexTemplateDescriptor, IPutIndexTemplateRequest> selector) => throw new NotImplementedException();
		///<inheritdoc cref = "IPutIndexTemplateRequest"/>
		public Task<PutIndexTemplateResponse> PutIndexTemplateAsync(Name name, Func<PutIndexTemplateDescriptor, IPutIndexTemplateRequest> selector, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IPutIndexTemplateRequest"/>
		public PutIndexTemplateResponse PutIndexTemplate(IPutIndexTemplateRequest request) => DoRequest<IPutIndexTemplateRequest, PutIndexTemplateResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IPutIndexTemplateRequest"/>
		public Task<PutIndexTemplateResponse> PutIndexTemplateAsync(IPutIndexTemplateRequest request, CancellationToken ct = default) => DoRequestAsync<IPutIndexTemplateRequest, PutIndexTemplateResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IRecoveryStatusRequest"/>
		public RecoveryStatusResponse RecoveryStatus(Indices index = null, Func<RecoveryStatusDescriptor, IRecoveryStatusRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IRecoveryStatusRequest"/>
		public Task<RecoveryStatusResponse> RecoveryStatusAsync(Indices index = null, Func<RecoveryStatusDescriptor, IRecoveryStatusRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IRecoveryStatusRequest"/>
		public RecoveryStatusResponse RecoveryStatus(IRecoveryStatusRequest request) => DoRequest<IRecoveryStatusRequest, RecoveryStatusResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IRecoveryStatusRequest"/>
		public Task<RecoveryStatusResponse> RecoveryStatusAsync(IRecoveryStatusRequest request, CancellationToken ct = default) => DoRequestAsync<IRecoveryStatusRequest, RecoveryStatusResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IRefreshRequest"/>
		public RefreshResponse Refresh(Indices index = null, Func<RefreshDescriptor, IRefreshRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IRefreshRequest"/>
		public Task<RefreshResponse> RefreshAsync(Indices index = null, Func<RefreshDescriptor, IRefreshRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IRefreshRequest"/>
		public RefreshResponse Refresh(IRefreshRequest request) => DoRequest<IRefreshRequest, RefreshResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IRefreshRequest"/>
		public Task<RefreshResponse> RefreshAsync(IRefreshRequest request, CancellationToken ct = default) => DoRequestAsync<IRefreshRequest, RefreshResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IRolloverIndexRequest"/>
		public RolloverIndexResponse RolloverIndex(Name alias, Func<RolloverIndexDescriptor, IRolloverIndexRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IRolloverIndexRequest"/>
		public Task<RolloverIndexResponse> RolloverIndexAsync(Name alias, Func<RolloverIndexDescriptor, IRolloverIndexRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IRolloverIndexRequest"/>
		public RolloverIndexResponse RolloverIndex(IRolloverIndexRequest request) => DoRequest<IRolloverIndexRequest, RolloverIndexResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IRolloverIndexRequest"/>
		public Task<RolloverIndexResponse> RolloverIndexAsync(IRolloverIndexRequest request, CancellationToken ct = default) => DoRequestAsync<IRolloverIndexRequest, RolloverIndexResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "ISegmentsRequest"/>
		public SegmentsResponse Segments(Indices index = null, Func<SegmentsDescriptor, ISegmentsRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "ISegmentsRequest"/>
		public Task<SegmentsResponse> SegmentsAsync(Indices index = null, Func<SegmentsDescriptor, ISegmentsRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "ISegmentsRequest"/>
		public SegmentsResponse Segments(ISegmentsRequest request) => DoRequest<ISegmentsRequest, SegmentsResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "ISegmentsRequest"/>
		public Task<SegmentsResponse> SegmentsAsync(ISegmentsRequest request, CancellationToken ct = default) => DoRequestAsync<ISegmentsRequest, SegmentsResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IIndicesShardStoresRequest"/>
		public IndicesShardStoresResponse ShardStores(Indices index = null, Func<IndicesShardStoresDescriptor, IIndicesShardStoresRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IIndicesShardStoresRequest"/>
		public Task<IndicesShardStoresResponse> ShardStoresAsync(Indices index = null, Func<IndicesShardStoresDescriptor, IIndicesShardStoresRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IIndicesShardStoresRequest"/>
		public IndicesShardStoresResponse ShardStores(IIndicesShardStoresRequest request) => DoRequest<IIndicesShardStoresRequest, IndicesShardStoresResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IIndicesShardStoresRequest"/>
		public Task<IndicesShardStoresResponse> ShardStoresAsync(IIndicesShardStoresRequest request, CancellationToken ct = default) => DoRequestAsync<IIndicesShardStoresRequest, IndicesShardStoresResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IShrinkIndexRequest"/>
		public ShrinkIndexResponse ShrinkIndex(IndexName index, IndexName target, Func<ShrinkIndexDescriptor, IShrinkIndexRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IShrinkIndexRequest"/>
		public Task<ShrinkIndexResponse> ShrinkIndexAsync(IndexName index, IndexName target, Func<ShrinkIndexDescriptor, IShrinkIndexRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IShrinkIndexRequest"/>
		public ShrinkIndexResponse ShrinkIndex(IShrinkIndexRequest request) => DoRequest<IShrinkIndexRequest, ShrinkIndexResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IShrinkIndexRequest"/>
		public Task<ShrinkIndexResponse> ShrinkIndexAsync(IShrinkIndexRequest request, CancellationToken ct = default) => DoRequestAsync<IShrinkIndexRequest, ShrinkIndexResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "ISplitIndexRequest"/>
		public SplitIndexResponse SplitIndex(IndexName index, IndexName target, Func<SplitIndexDescriptor, ISplitIndexRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "ISplitIndexRequest"/>
		public Task<SplitIndexResponse> SplitIndexAsync(IndexName index, IndexName target, Func<SplitIndexDescriptor, ISplitIndexRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "ISplitIndexRequest"/>
		public SplitIndexResponse SplitIndex(ISplitIndexRequest request) => DoRequest<ISplitIndexRequest, SplitIndexResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "ISplitIndexRequest"/>
		public Task<SplitIndexResponse> SplitIndexAsync(ISplitIndexRequest request, CancellationToken ct = default) => DoRequestAsync<ISplitIndexRequest, SplitIndexResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IIndicesStatsRequest"/>
		public IndicesStatsResponse Stats(Indices index = null, Func<IndicesStatsDescriptor, IIndicesStatsRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IIndicesStatsRequest"/>
		public Task<IndicesStatsResponse> StatsAsync(Indices index = null, Func<IndicesStatsDescriptor, IIndicesStatsRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IIndicesStatsRequest"/>
		public IndicesStatsResponse Stats(IIndicesStatsRequest request) => DoRequest<IIndicesStatsRequest, IndicesStatsResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IIndicesStatsRequest"/>
		public Task<IndicesStatsResponse> StatsAsync(IIndicesStatsRequest request, CancellationToken ct = default) => DoRequestAsync<IIndicesStatsRequest, IndicesStatsResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IBulkAliasRequest"/>
		public BulkAliasResponse BulkAlias(Func<BulkAliasDescriptor, IBulkAliasRequest> selector) => throw new NotImplementedException();
		///<inheritdoc cref = "IBulkAliasRequest"/>
		public Task<BulkAliasResponse> BulkAliasAsync(Func<BulkAliasDescriptor, IBulkAliasRequest> selector, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IBulkAliasRequest"/>
		public BulkAliasResponse BulkAlias(IBulkAliasRequest request) => DoRequest<IBulkAliasRequest, BulkAliasResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IBulkAliasRequest"/>
		public Task<BulkAliasResponse> BulkAliasAsync(IBulkAliasRequest request, CancellationToken ct = default) => DoRequestAsync<IBulkAliasRequest, BulkAliasResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IUpgradeRequest"/>
		public UpgradeResponse Upgrade(Indices index = null, Func<UpgradeDescriptor, IUpgradeRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IUpgradeRequest"/>
		public Task<UpgradeResponse> UpgradeAsync(Indices index = null, Func<UpgradeDescriptor, IUpgradeRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IUpgradeRequest"/>
		public UpgradeResponse Upgrade(IUpgradeRequest request) => DoRequest<IUpgradeRequest, UpgradeResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IUpgradeRequest"/>
		public Task<UpgradeResponse> UpgradeAsync(IUpgradeRequest request, CancellationToken ct = default) => DoRequestAsync<IUpgradeRequest, UpgradeResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IValidateQueryRequest"/>
		public ValidateQueryResponse ValidateQuery<TDocument>(Func<ValidateQueryDescriptor<TDocument>, IValidateQueryRequest> selector = null)
			where TDocument : class => throw new NotImplementedException();
		///<inheritdoc cref = "IValidateQueryRequest"/>
		public Task<ValidateQueryResponse> ValidateQueryAsync<TDocument>(Func<ValidateQueryDescriptor<TDocument>, IValidateQueryRequest> selector = null, CancellationToken ct = default)
			where TDocument : class => throw new NotImplementedException();
		///<inheritdoc cref = "IValidateQueryRequest"/>
		public ValidateQueryResponse ValidateQuery(IValidateQueryRequest request) => DoRequest<IValidateQueryRequest, ValidateQueryResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IValidateQueryRequest"/>
		public Task<ValidateQueryResponse> ValidateQueryAsync(IValidateQueryRequest request, CancellationToken ct = default) => DoRequestAsync<IValidateQueryRequest, ValidateQueryResponse>(request, request.RequestParameters, ct);
	}
}