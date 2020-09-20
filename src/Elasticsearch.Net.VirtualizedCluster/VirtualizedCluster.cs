// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System;
using System.Threading;
using System.Threading.Tasks;
using Elastic.Transport;
using Elasticsearch.Net.VirtualizedCluster.Providers;

namespace Elasticsearch.Net.VirtualizedCluster
{
	public class VirtualizedCluster
	{
		private readonly FixedPipelineFactory _fixedRequestPipeline;
		private readonly TestableDateTimeProvider _dateTimeProvider;
		private readonly ConnectionConfiguration _settings;
		private Func<IElasticLowLevelClient, Func<RequestConfigurationDescriptor, IRequestConfiguration>, Task<ITransportResponse>> _asyncCall;
		private Func<IElasticLowLevelClient, Func<RequestConfigurationDescriptor, IRequestConfiguration>, ITransportResponse> _syncCall;

		private class VirtualResponse : ResponseBase { }

		public VirtualizedCluster(TestableDateTimeProvider dateTimeProvider, ConnectionConfiguration settings)
		{
			_dateTimeProvider = dateTimeProvider;
			_settings = settings;
			_fixedRequestPipeline = new FixedPipelineFactory(settings, _dateTimeProvider);

			_syncCall = (c, r) => c.Search<VirtualResponse>(PostData.Serializable(new {}), new SearchRequestParameters
			{
					RequestConfiguration = r?.Invoke(new RequestConfigurationDescriptor(null))
			});
			_asyncCall = async (c, r) =>
			{
				var res = await c.SearchAsync<VirtualResponse>
				(
					PostData.Serializable(new { }),
					new SearchRequestParameters { RequestConfiguration = r?.Invoke(new RequestConfigurationDescriptor(null)) },
					CancellationToken.None
				).ConfigureAwait(false);
				return (ITransportResponse)res;
			};
		}

		public VirtualClusterConnection Connection => Client.Settings.Connection as VirtualClusterConnection;
		public IConnectionPool ConnectionPool => Client.Settings.ConnectionPool;
		public ElasticLowLevelClient Client => _fixedRequestPipeline?.Client;

		public VirtualizedCluster ClientProxiesTo(
			Func<IElasticLowLevelClient, Func<RequestConfigurationDescriptor, IRequestConfiguration>, ITransportResponse> sync,
			Func<IElasticLowLevelClient, Func<RequestConfigurationDescriptor, IRequestConfiguration>, Task<ITransportResponse>> async
		)
		{
			_syncCall = sync;
			_asyncCall = async;
			return this;
		}

		public ITransportResponse ClientCall(Func<RequestConfigurationDescriptor, IRequestConfiguration> requestOverrides = null) =>
			_syncCall(Client, requestOverrides);

		public async Task<ITransportResponse> ClientCallAsync(Func<RequestConfigurationDescriptor, IRequestConfiguration> requestOverrides = null) =>
			await _asyncCall(Client, requestOverrides).ConfigureAwait(false);

		public void ChangeTime(Func<DateTime, DateTime> change) => _dateTimeProvider.ChangeTime(change);

		public void ClientThrows(bool throws) => _settings.ThrowExceptions(throws);
	}
}
