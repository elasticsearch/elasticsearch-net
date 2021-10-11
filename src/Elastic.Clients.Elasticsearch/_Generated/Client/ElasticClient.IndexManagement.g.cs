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
	public class IndexManagementNamespace : NamespacedClientProxy
	{
		internal IndexManagementNamespace(ElasticClient client) : base(client)
		{
		}

		public IndexManagementCreateResponse Create(IIndexManagementCreateRequest request) => DoRequest<IIndexManagementCreateRequest, IndexManagementCreateResponse>(request, request.RequestParameters);
		public Task<IndexManagementCreateResponse> CreateAsync(IIndexManagementCreateRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IIndexManagementCreateRequest, IndexManagementCreateResponse>(request, request.RequestParameters, cancellationToken);
		public IndexManagementCreateResponse Create(IndexName index, Func<IndexManagementCreateRequestDescriptor, IIndexManagementCreateRequest> selector = null) => Create(selector.InvokeOrDefault(new IndexManagementCreateRequestDescriptor(index)));
		public Task<IndexManagementCreateResponse> CreateAsync(IndexName index, Func<IndexManagementCreateRequestDescriptor, IIndexManagementCreateRequest> selector = null, CancellationToken cancellationToken = default) => CreateAsync(selector.InvokeOrDefault(new IndexManagementCreateRequestDescriptor(index)), cancellationToken);
	}
}