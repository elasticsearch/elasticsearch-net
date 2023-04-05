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

#nullable restore

namespace Elastic.Clients.Elasticsearch.Requests;

internal static class ApiUrlLookup
{
	internal static ApiUrls AsyncSearchStatus = new ApiUrls(new[] { "/_async_search/status/{id}" });
	internal static ApiUrls AsyncSearchDelete = new ApiUrls(new[] { "/_async_search/{id}" });
	internal static ApiUrls AsyncSearchGet = new ApiUrls(new[] { "/_async_search/{id}" });
	internal static ApiUrls AsyncSearchSubmit = new ApiUrls(new[] { "/_async_search", "/{index}/_async_search" });
	internal static ApiUrls NoNamespaceBulk = new ApiUrls(new[] { "/_bulk", "/{index}/_bulk" });
	internal static ApiUrls NoNamespaceClearScroll = new ApiUrls(new[] { "/_search/scroll" });
	internal static ApiUrls NoNamespaceClosePointInTime = new ApiUrls(new[] { "/_pit" });
	internal static ApiUrls ClusterHealth = new ApiUrls(new[] { "/_cluster/health", "/_cluster/health/{index}" });
	internal static ApiUrls NoNamespaceCount = new ApiUrls(new[] { "/_count", "/{index}/_count" });
	internal static ApiUrls NoNamespaceCreate = new ApiUrls(new[] { "/{index}/_create/{id}" });
	internal static ApiUrls NoNamespaceDeleteByQuery = new ApiUrls(new[] { "/{index}/_delete_by_query" });
	internal static ApiUrls NoNamespaceDeleteByQueryRethrottle = new ApiUrls(new[] { "/_delete_by_query/{task_id}/_rethrottle" });
	internal static ApiUrls NoNamespaceDelete = new ApiUrls(new[] { "/{index}/_doc/{id}" });
	internal static ApiUrls NoNamespaceDeleteScript = new ApiUrls(new[] { "/_scripts/{id}" });
	internal static ApiUrls EqlDelete = new ApiUrls(new[] { "/_eql/search/{id}" });
	internal static ApiUrls EqlGet = new ApiUrls(new[] { "/_eql/search/{id}" });
	internal static ApiUrls EqlSearch = new ApiUrls(new[] { "/{index}/_eql/search" });
	internal static ApiUrls EqlGetStatus = new ApiUrls(new[] { "/_eql/search/status/{id}" });
	internal static ApiUrls NoNamespaceExists = new ApiUrls(new[] { "/{index}/_doc/{id}" });
	internal static ApiUrls NoNamespaceExistsSource = new ApiUrls(new[] { "/{index}/_source/{id}" });
	internal static ApiUrls NoNamespaceExplain = new ApiUrls(new[] { "/{index}/_explain/{id}" });
	internal static ApiUrls NoNamespaceFieldCaps = new ApiUrls(new[] { "/_field_caps", "/{index}/_field_caps" });
	internal static ApiUrls NoNamespaceGet = new ApiUrls(new[] { "/{index}/_doc/{id}" });
	internal static ApiUrls NoNamespaceGetScriptContext = new ApiUrls(new[] { "/_script_context" });
	internal static ApiUrls NoNamespaceGetScriptLanguages = new ApiUrls(new[] { "/_script_language" });
	internal static ApiUrls NoNamespaceGetScript = new ApiUrls(new[] { "/_scripts/{id}" });
	internal static ApiUrls NoNamespaceGetSource = new ApiUrls(new[] { "/{index}/_source/{id}" });
	internal static ApiUrls IndexManagementClone = new ApiUrls(new[] { "/{index}/_clone/{target}" });
	internal static ApiUrls IndexManagementClose = new ApiUrls(new[] { "/{index}/_close" });
	internal static ApiUrls IndexManagementCreateDataStream = new ApiUrls(new[] { "/_data_stream/{name}" });
	internal static ApiUrls IndexManagementCreate = new ApiUrls(new[] { "/{index}" });
	internal static ApiUrls IndexManagementDeleteAlias = new ApiUrls(new[] { "/{index}/_alias/{name}" });
	internal static ApiUrls IndexManagementDeleteDataStream = new ApiUrls(new[] { "/_data_stream/{name}" });
	internal static ApiUrls IndexManagementDelete = new ApiUrls(new[] { "/{index}" });
	internal static ApiUrls IndexManagementDeleteIndexTemplate = new ApiUrls(new[] { "/_index_template/{name}" });
	internal static ApiUrls IndexManagementDeleteTemplate = new ApiUrls(new[] { "/_template/{name}" });
	internal static ApiUrls IndexManagementExistsAlias = new ApiUrls(new[] { "/_alias/{name}", "/{index}/_alias/{name}" });
	internal static ApiUrls IndexManagementExistsIndexTemplate = new ApiUrls(new[] { "/_index_template/{name}" });
	internal static ApiUrls IndexManagementExists = new ApiUrls(new[] { "/{index}" });
	internal static ApiUrls IndexManagementExistsTemplate = new ApiUrls(new[] { "/_template/{name}" });
	internal static ApiUrls IndexManagementFlush = new ApiUrls(new[] { "/_flush", "/{index}/_flush" });
	internal static ApiUrls IndexManagementForcemerge = new ApiUrls(new[] { "/_forcemerge", "/{index}/_forcemerge" });
	internal static ApiUrls IndexManagementGetAlias = new ApiUrls(new[] { "/_alias", "/_alias/{name}", "/{index}/_alias/{name}", "/{index}/_alias" });
	internal static ApiUrls IndexManagementGetDataStream = new ApiUrls(new[] { "/_data_stream", "/_data_stream/{name}" });
	internal static ApiUrls IndexManagementGetFieldMapping = new ApiUrls(new[] { "/_mapping/field/{fields}", "/{index}/_mapping/field/{fields}" });
	internal static ApiUrls IndexManagementGet = new ApiUrls(new[] { "/{index}" });
	internal static ApiUrls IndexManagementGetIndexTemplate = new ApiUrls(new[] { "/_index_template", "/_index_template/{name}" });
	internal static ApiUrls IndexManagementGetMapping = new ApiUrls(new[] { "/_mapping", "/{index}/_mapping" });
	internal static ApiUrls IndexManagementGetTemplate = new ApiUrls(new[] { "/_template", "/_template/{name}" });
	internal static ApiUrls IndexManagementStats = new ApiUrls(new[] { "/_stats", "/_stats/{metric}", "/{index}/_stats", "/{index}/_stats/{metric}" });
	internal static ApiUrls IndexManagementMigrateToDataStream = new ApiUrls(new[] { "/_data_stream/_migrate/{name}" });
	internal static ApiUrls IndexManagementOpen = new ApiUrls(new[] { "/{index}/_open" });
	internal static ApiUrls IndexManagementPutAlias = new ApiUrls(new[] { "/{index}/_alias/{name}" });
	internal static ApiUrls IndexManagementPutIndexTemplate = new ApiUrls(new[] { "/_index_template/{name}" });
	internal static ApiUrls IndexManagementPutMapping = new ApiUrls(new[] { "/{index}/_mapping" });
	internal static ApiUrls IndexManagementPutTemplate = new ApiUrls(new[] { "/_template/{name}" });
	internal static ApiUrls IndexManagementRefresh = new ApiUrls(new[] { "/_refresh", "/{index}/_refresh" });
	internal static ApiUrls IndexManagementRollover = new ApiUrls(new[] { "/{alias}/_rollover", "/{alias}/_rollover/{new_index}" });
	internal static ApiUrls IndexManagementShrink = new ApiUrls(new[] { "/{index}/_shrink/{target}" });
	internal static ApiUrls IndexManagementSimulateIndexTemplate = new ApiUrls(new[] { "/_index_template/_simulate_index/{name}" });
	internal static ApiUrls IndexManagementSimulateTemplate = new ApiUrls(new[] { "/_index_template/_simulate", "/_index_template/_simulate/{name}" });
	internal static ApiUrls IndexManagementSplit = new ApiUrls(new[] { "/{index}/_split/{target}" });
	internal static ApiUrls IndexManagementUpdateAliases = new ApiUrls(new[] { "/_aliases" });
	internal static ApiUrls NoNamespaceIndex = new ApiUrls(new[] { "/{index}/_doc/{id}", "/{index}/_doc" });
	internal static ApiUrls NoNamespaceInfo = new ApiUrls(new[] { "/" });
	internal static ApiUrls IngestDeletePipeline = new ApiUrls(new[] { "/_ingest/pipeline/{id}" });
	internal static ApiUrls IngestGeoIpStats = new ApiUrls(new[] { "/_ingest/geoip/stats" });
	internal static ApiUrls IngestGetPipeline = new ApiUrls(new[] { "/_ingest/pipeline", "/_ingest/pipeline/{id}" });
	internal static ApiUrls IngestProcessorGrok = new ApiUrls(new[] { "/_ingest/processor/grok" });
	internal static ApiUrls IngestPutPipeline = new ApiUrls(new[] { "/_ingest/pipeline/{id}" });
	internal static ApiUrls IngestSimulate = new ApiUrls(new[] { "/_ingest/pipeline/_simulate", "/_ingest/pipeline/{id}/_simulate" });
	internal static ApiUrls NoNamespaceMget = new ApiUrls(new[] { "/_mget", "/{index}/_mget" });
	internal static ApiUrls NoNamespaceMsearch = new ApiUrls(new[] { "/_msearch", "/{index}/_msearch" });
	internal static ApiUrls NoNamespaceMsearchTemplate = new ApiUrls(new[] { "/_msearch/template", "/{index}/_msearch/template" });
	internal static ApiUrls NoNamespaceOpenPointInTime = new ApiUrls(new[] { "/{index}/_pit" });
	internal static ApiUrls NoNamespacePing = new ApiUrls(new[] { "/" });
	internal static ApiUrls NoNamespacePutScript = new ApiUrls(new[] { "/_scripts/{id}", "/_scripts/{id}/{context}" });
	internal static ApiUrls NoNamespaceRankEval = new ApiUrls(new[] { "/_rank_eval", "/{index}/_rank_eval" });
	internal static ApiUrls NoNamespaceReindex = new ApiUrls(new[] { "/_reindex" });
	internal static ApiUrls NoNamespaceReindexRethrottle = new ApiUrls(new[] { "/_reindex/{task_id}/_rethrottle" });
	internal static ApiUrls NoNamespaceScroll = new ApiUrls(new[] { "/_search/scroll" });
	internal static ApiUrls NoNamespaceSearch = new ApiUrls(new[] { "/_search", "/{index}/_search" });
	internal static ApiUrls NoNamespaceSearchShards = new ApiUrls(new[] { "/_search_shards", "/{index}/_search_shards" });
	internal static ApiUrls SqlClearCursor = new ApiUrls(new[] { "/_sql/close" });
	internal static ApiUrls SqlDeleteAsync = new ApiUrls(new[] { "/_sql/async/delete/{id}" });
	internal static ApiUrls SqlGetAsync = new ApiUrls(new[] { "/_sql/async/{id}" });
	internal static ApiUrls SqlGetAsyncStatus = new ApiUrls(new[] { "/_sql/async/status/{id}" });
	internal static ApiUrls SqlQuery = new ApiUrls(new[] { "/_sql" });
	internal static ApiUrls TasksCancel = new ApiUrls(new[] { "/_tasks/_cancel", "/_tasks/{task_id}/_cancel" });
	internal static ApiUrls TasksGet = new ApiUrls(new[] { "/_tasks/{task_id}" });
	internal static ApiUrls TasksList = new ApiUrls(new[] { "/_tasks" });
	internal static ApiUrls NoNamespaceTermsEnum = new ApiUrls(new[] { "/{index}/_terms_enum" });
	internal static ApiUrls NoNamespaceUpdateByQuery = new ApiUrls(new[] { "/{index}/_update_by_query" });
	internal static ApiUrls NoNamespaceUpdateByQueryRethrottle = new ApiUrls(new[] { "/_update_by_query/{task_id}/_rethrottle" });
	internal static ApiUrls NoNamespaceUpdate = new ApiUrls(new[] { "/{index}/_update/{id}" });
}