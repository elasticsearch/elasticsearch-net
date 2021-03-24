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

#nullable restore
namespace Nest
{
	public class AutoscalingNamespace : NamespacedClientProxy
	{
		internal AutoscalingNamespace(ElasticClient client) : base(client)
		{
		}

		public DeleteAutoscalingPolicyResponse DeleteAutoscalingPolicy(IDeleteAutoscalingPolicyRequest request)
		{
			return DoRequest<IDeleteAutoscalingPolicyRequest, DeleteAutoscalingPolicyResponse>(request, request.RequestParameters);
		}

		public Task<DeleteAutoscalingPolicyResponse> DeleteAutoscalingPolicyAsync(IDeleteAutoscalingPolicyRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IDeleteAutoscalingPolicyRequest, DeleteAutoscalingPolicyResponse>(request, request.RequestParameters, cancellationToken);
		}

		public GetAutoscalingCapacityResponse GetAutoscalingCapacity(IGetAutoscalingCapacityRequest request)
		{
			return DoRequest<IGetAutoscalingCapacityRequest, GetAutoscalingCapacityResponse>(request, request.RequestParameters);
		}

		public Task<GetAutoscalingCapacityResponse> GetAutoscalingCapacityAsync(IGetAutoscalingCapacityRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IGetAutoscalingCapacityRequest, GetAutoscalingCapacityResponse>(request, request.RequestParameters, cancellationToken);
		}

		public GetAutoscalingPolicyResponse GetAutoscalingPolicy(IGetAutoscalingPolicyRequest request)
		{
			return DoRequest<IGetAutoscalingPolicyRequest, GetAutoscalingPolicyResponse>(request, request.RequestParameters);
		}

		public Task<GetAutoscalingPolicyResponse> GetAutoscalingPolicyAsync(IGetAutoscalingPolicyRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IGetAutoscalingPolicyRequest, GetAutoscalingPolicyResponse>(request, request.RequestParameters, cancellationToken);
		}

		public PutAutoscalingPolicyResponse PutAutoscalingPolicy(IPutAutoscalingPolicyRequest request)
		{
			return DoRequest<IPutAutoscalingPolicyRequest, PutAutoscalingPolicyResponse>(request, request.RequestParameters);
		}

		public Task<PutAutoscalingPolicyResponse> PutAutoscalingPolicyAsync(IPutAutoscalingPolicyRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IPutAutoscalingPolicyRequest, PutAutoscalingPolicyResponse>(request, request.RequestParameters, cancellationToken);
		}
	}
}