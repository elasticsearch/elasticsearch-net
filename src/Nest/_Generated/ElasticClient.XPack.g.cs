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
	public class XPackNamespace : NamespacedClientProxy
	{
		internal XPackNamespace(ElasticClient client) : base(client)
		{
		}

		public XPackInfoResponse Info(IXPackInfoRequest request)
		{
			return DoRequest<IXPackInfoRequest, XPackInfoResponse>(request, request.RequestParameters);
		}

		public Task<XPackInfoResponse> InfoAsync(IXPackInfoRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IXPackInfoRequest, XPackInfoResponse>(request, request.RequestParameters, cancellationToken);
		}

		public XPackUsageResponse Usage(IXPackUsageRequest request)
		{
			return DoRequest<IXPackUsageRequest, XPackUsageResponse>(request, request.RequestParameters);
		}

		public Task<XPackUsageResponse> UsageAsync(IXPackUsageRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IXPackUsageRequest, XPackUsageResponse>(request, request.RequestParameters, cancellationToken);
		}
	}
}