using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Specification.WatcherApi;

//This file is automatically generated from https://github.com/elastic/elasticsearch/tree/master/rest-api-spec
// ReSharper disable once CheckNamespace
namespace Nest.Specification.WatcherApi
{
	///<summary>
	/// Logically groups all Watcher API's together so that they may be discovered more naturally.
	/// <para>Not intended to be instantiated directly please defer to the <see cref = "IElasticClient.Watcher"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class WatcherNamespace : NamespacedClientProxy
	{
		internal WatcherNamespace(ElasticClient client): base(client)
		{
		}

		///<inheritdoc cref = "IAcknowledgeWatchRequest"/>
		public AcknowledgeWatchResponse AcknowledgeWatch(Id watchId, Func<AcknowledgeWatchDescriptor, IAcknowledgeWatchRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IAcknowledgeWatchRequest"/>
		public Task<AcknowledgeWatchResponse> AcknowledgeWatchAsync(Id watchId, Func<AcknowledgeWatchDescriptor, IAcknowledgeWatchRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IAcknowledgeWatchRequest"/>
		public AcknowledgeWatchResponse AcknowledgeWatch(IAcknowledgeWatchRequest request) => DoRequest<IAcknowledgeWatchRequest, AcknowledgeWatchResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IAcknowledgeWatchRequest"/>
		public Task<AcknowledgeWatchResponse> AcknowledgeWatchAsync(IAcknowledgeWatchRequest request, CancellationToken ct = default) => DoRequestAsync<IAcknowledgeWatchRequest, AcknowledgeWatchResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IActivateWatchRequest"/>
		public ActivateWatchResponse ActivateWatch(Id watchId, Func<ActivateWatchDescriptor, IActivateWatchRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IActivateWatchRequest"/>
		public Task<ActivateWatchResponse> ActivateWatchAsync(Id watchId, Func<ActivateWatchDescriptor, IActivateWatchRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IActivateWatchRequest"/>
		public ActivateWatchResponse ActivateWatch(IActivateWatchRequest request) => DoRequest<IActivateWatchRequest, ActivateWatchResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IActivateWatchRequest"/>
		public Task<ActivateWatchResponse> ActivateWatchAsync(IActivateWatchRequest request, CancellationToken ct = default) => DoRequestAsync<IActivateWatchRequest, ActivateWatchResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IDeactivateWatchRequest"/>
		public DeactivateWatchResponse DeactivateWatch(Id watchId, Func<DeactivateWatchDescriptor, IDeactivateWatchRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IDeactivateWatchRequest"/>
		public Task<DeactivateWatchResponse> DeactivateWatchAsync(Id watchId, Func<DeactivateWatchDescriptor, IDeactivateWatchRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IDeactivateWatchRequest"/>
		public DeactivateWatchResponse DeactivateWatch(IDeactivateWatchRequest request) => DoRequest<IDeactivateWatchRequest, DeactivateWatchResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IDeactivateWatchRequest"/>
		public Task<DeactivateWatchResponse> DeactivateWatchAsync(IDeactivateWatchRequest request, CancellationToken ct = default) => DoRequestAsync<IDeactivateWatchRequest, DeactivateWatchResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IDeleteWatchRequest"/>
		public DeleteWatchResponse DeleteWatch(Id id, Func<DeleteWatchDescriptor, IDeleteWatchRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IDeleteWatchRequest"/>
		public Task<DeleteWatchResponse> DeleteWatchAsync(Id id, Func<DeleteWatchDescriptor, IDeleteWatchRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IDeleteWatchRequest"/>
		public DeleteWatchResponse DeleteWatch(IDeleteWatchRequest request) => DoRequest<IDeleteWatchRequest, DeleteWatchResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IDeleteWatchRequest"/>
		public Task<DeleteWatchResponse> DeleteWatchAsync(IDeleteWatchRequest request, CancellationToken ct = default) => DoRequestAsync<IDeleteWatchRequest, DeleteWatchResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IExecuteWatchRequest"/>
		public ExecuteWatchResponse ExecuteWatch(Func<ExecuteWatchDescriptor, IExecuteWatchRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IExecuteWatchRequest"/>
		public Task<ExecuteWatchResponse> ExecuteWatchAsync(Func<ExecuteWatchDescriptor, IExecuteWatchRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IExecuteWatchRequest"/>
		public ExecuteWatchResponse ExecuteWatch(IExecuteWatchRequest request) => DoRequest<IExecuteWatchRequest, ExecuteWatchResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IExecuteWatchRequest"/>
		public Task<ExecuteWatchResponse> ExecuteWatchAsync(IExecuteWatchRequest request, CancellationToken ct = default) => DoRequestAsync<IExecuteWatchRequest, ExecuteWatchResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IGetWatchRequest"/>
		public GetWatchResponse GetWatch(Id id, Func<GetWatchDescriptor, IGetWatchRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IGetWatchRequest"/>
		public Task<GetWatchResponse> GetWatchAsync(Id id, Func<GetWatchDescriptor, IGetWatchRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IGetWatchRequest"/>
		public GetWatchResponse GetWatch(IGetWatchRequest request) => DoRequest<IGetWatchRequest, GetWatchResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IGetWatchRequest"/>
		public Task<GetWatchResponse> GetWatchAsync(IGetWatchRequest request, CancellationToken ct = default) => DoRequestAsync<IGetWatchRequest, GetWatchResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IPutWatchRequest"/>
		public PutWatchResponse PutWatch(Id id, Func<PutWatchDescriptor, IPutWatchRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IPutWatchRequest"/>
		public Task<PutWatchResponse> PutWatchAsync(Id id, Func<PutWatchDescriptor, IPutWatchRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IPutWatchRequest"/>
		public PutWatchResponse PutWatch(IPutWatchRequest request) => DoRequest<IPutWatchRequest, PutWatchResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IPutWatchRequest"/>
		public Task<PutWatchResponse> PutWatchAsync(IPutWatchRequest request, CancellationToken ct = default) => DoRequestAsync<IPutWatchRequest, PutWatchResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IStartWatcherRequest"/>
		public StartWatcherResponse StartWatcher(Func<StartWatcherDescriptor, IStartWatcherRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IStartWatcherRequest"/>
		public Task<StartWatcherResponse> StartWatcherAsync(Func<StartWatcherDescriptor, IStartWatcherRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IStartWatcherRequest"/>
		public StartWatcherResponse StartWatcher(IStartWatcherRequest request) => DoRequest<IStartWatcherRequest, StartWatcherResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IStartWatcherRequest"/>
		public Task<StartWatcherResponse> StartWatcherAsync(IStartWatcherRequest request, CancellationToken ct = default) => DoRequestAsync<IStartWatcherRequest, StartWatcherResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IWatcherStatsRequest"/>
		public WatcherStatsResponse Stats(Func<WatcherStatsDescriptor, IWatcherStatsRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IWatcherStatsRequest"/>
		public Task<WatcherStatsResponse> StatsAsync(Func<WatcherStatsDescriptor, IWatcherStatsRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IWatcherStatsRequest"/>
		public WatcherStatsResponse Stats(IWatcherStatsRequest request) => DoRequest<IWatcherStatsRequest, WatcherStatsResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IWatcherStatsRequest"/>
		public Task<WatcherStatsResponse> StatsAsync(IWatcherStatsRequest request, CancellationToken ct = default) => DoRequestAsync<IWatcherStatsRequest, WatcherStatsResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IStopWatcherRequest"/>
		public StopWatcherResponse StopWatcher(Func<StopWatcherDescriptor, IStopWatcherRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IStopWatcherRequest"/>
		public Task<StopWatcherResponse> StopWatcherAsync(Func<StopWatcherDescriptor, IStopWatcherRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IStopWatcherRequest"/>
		public StopWatcherResponse StopWatcher(IStopWatcherRequest request) => DoRequest<IStopWatcherRequest, StopWatcherResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IStopWatcherRequest"/>
		public Task<StopWatcherResponse> StopWatcherAsync(IStopWatcherRequest request, CancellationToken ct = default) => DoRequestAsync<IStopWatcherRequest, StopWatcherResponse>(request, request.RequestParameters, ct);
	}
}