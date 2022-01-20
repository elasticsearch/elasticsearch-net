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

namespace Elastic.Clients.Elasticsearch
{
	internal static class ApiUrlsLookups
	{
		internal static ApiUrls NoNamespaceBulk = new ApiUrls(new[] { "/_bulk", "/{index}/_bulk" });
		internal static ApiUrls NoNamespaceClosePointInTime = new ApiUrls(new[] { "/_pit" });
		internal static ApiUrls ClusterAllocationExplain = new ApiUrls(new[] { "/_cluster/allocation/explain" });
		internal static ApiUrls ClusterHealth = new ApiUrls(new[] { "/_cluster/health", "/_cluster/health/{index}" });
		internal static ApiUrls ClusterPendingTasks = new ApiUrls(new[] { "/_cluster/pending_tasks" });
		internal static ApiUrls ClusterState = new ApiUrls(new[] { "/_cluster/state", "/_cluster/state/{metric}", "/_cluster/state/{metric}/{index}" });
		internal static ApiUrls NoNamespaceCount = new ApiUrls(new[] { "/_count", "/{index}/_count" });
		internal static ApiUrls NoNamespaceCreate = new ApiUrls(new[] { "/{index}/_create/{id}" });
		internal static ApiUrls NoNamespaceDelete = new ApiUrls(new[] { "/{index}/_doc/{id}" });
		internal static ApiUrls NoNamespaceExists = new ApiUrls(new[] { "/{index}/_doc/{id}" });
		internal static ApiUrls NoNamespaceGet = new ApiUrls(new[] { "/{index}/_doc/{id}" });
		internal static ApiUrls IndexManagementDelete = new ApiUrls(new[] { "/{index}" });
		internal static ApiUrls IndexManagementExists = new ApiUrls(new[] { "/{index}" });
		internal static ApiUrls IndexManagementRefresh = new ApiUrls(new[] { "/_refresh", "/{index}/_refresh" });
		internal static ApiUrls NoNamespaceIndex = new ApiUrls(new[] { "/{index}/_doc/{id}", "/{index}/_doc" });
		internal static ApiUrls NoNamespaceOpenPointInTime = new ApiUrls(new[] { "/{index}/_pit" });
		internal static ApiUrls NoNamespacePing = new ApiUrls(new[] { "/" });
		internal static ApiUrls NoNamespaceSearch = new ApiUrls(new[] { "/_search", "/{index}/_search" });
		internal static ApiUrls NoNamespaceGetSource = new ApiUrls(new[] { "/{index}/_source/{id}" });
		internal static ApiUrls NoNamespaceUpdate = new ApiUrls(new[] { "/{index}/_update/{id}" });
	}
}