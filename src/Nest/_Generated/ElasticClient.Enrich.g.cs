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
// ------------------------------------------------

using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Nest
{
	public class EnrichNamespace : NamespacedClientProxy
	{
		internal EnrichNamespace(ElasticClient client) : base(client)
		{
		}

		public DeleteEnrichPolicyResponse DeleteEnrichPolicy(IDeleteEnrichPolicyRequest request)
		{
			return DoRequest<IDeleteEnrichPolicyRequest, DeleteEnrichPolicyResponse>(request, request.RequestParameters);
		}

		public Task<DeleteEnrichPolicyResponse> DeleteEnrichPolicyAsync(IDeleteEnrichPolicyRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IDeleteEnrichPolicyRequest, DeleteEnrichPolicyResponse>(request, request.RequestParameters, cancellationToken);
		}

		public ExecuteEnrichPolicyResponse ExecuteEnrichPolicy(IExecuteEnrichPolicyRequest request)
		{
			return DoRequest<IExecuteEnrichPolicyRequest, ExecuteEnrichPolicyResponse>(request, request.RequestParameters);
		}

		public Task<ExecuteEnrichPolicyResponse> ExecuteEnrichPolicyAsync(IExecuteEnrichPolicyRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IExecuteEnrichPolicyRequest, ExecuteEnrichPolicyResponse>(request, request.RequestParameters, cancellationToken);
		}

		public GetEnrichPolicyResponse GetEnrichPolicy(IGetEnrichPolicyRequest request)
		{
			return DoRequest<IGetEnrichPolicyRequest, GetEnrichPolicyResponse>(request, request.RequestParameters);
		}

		public Task<GetEnrichPolicyResponse> GetEnrichPolicyAsync(IGetEnrichPolicyRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IGetEnrichPolicyRequest, GetEnrichPolicyResponse>(request, request.RequestParameters, cancellationToken);
		}

		public PutEnrichPolicyResponse PutEnrichPolicy(IPutEnrichPolicyRequest request)
		{
			return DoRequest<IPutEnrichPolicyRequest, PutEnrichPolicyResponse>(request, request.RequestParameters);
		}

		public Task<PutEnrichPolicyResponse> PutEnrichPolicyAsync(IPutEnrichPolicyRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IPutEnrichPolicyRequest, PutEnrichPolicyResponse>(request, request.RequestParameters, cancellationToken);
		}

		public EnrichStatsResponse Stats(IEnrichStatsRequest request)
		{
			return DoRequest<IEnrichStatsRequest, EnrichStatsResponse>(request, request.RequestParameters);
		}

		public Task<EnrichStatsResponse> StatsAsync(IEnrichStatsRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IEnrichStatsRequest, EnrichStatsResponse>(request, request.RequestParameters, cancellationToken);
		}
	}
}