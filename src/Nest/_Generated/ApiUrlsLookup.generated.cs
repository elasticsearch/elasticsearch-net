//This file contains all the typed querystring parameters that are generated of the client spec.
//This file is automatically generated from https://github.com/elastic/elasticsearch/tree/master/rest-api-spec
namespace Nest
{
	internal static class ApiUrlsLookups
	{
		internal static ApiUrls NoNamespaceBulk = new ApiUrls(new[]{"_bulk", "{index}/_bulk"});
		internal static ApiUrls CatAliases = new ApiUrls(new[]{"_cat/aliases", "_cat/aliases/{name}"});
		internal static ApiUrls CatAllocation = new ApiUrls(new[]{"_cat/allocation", "_cat/allocation/{node_id}"});
		internal static ApiUrls CatCount = new ApiUrls(new[]{"_cat/count", "_cat/count/{index}"});
		internal static ApiUrls CatFielddata = new ApiUrls(new[]{"_cat/fielddata", "_cat/fielddata/{fields}"});
		internal static ApiUrls CatHealth = new ApiUrls(new[]{"_cat/health"});
		internal static ApiUrls CatHelp = new ApiUrls(new[]{"_cat"});
		internal static ApiUrls CatIndices = new ApiUrls(new[]{"_cat/indices", "_cat/indices/{index}"});
		internal static ApiUrls CatMaster = new ApiUrls(new[]{"_cat/master"});
		internal static ApiUrls CatNodeAttributes = new ApiUrls(new[]{"_cat/nodeattrs"});
		internal static ApiUrls CatNodes = new ApiUrls(new[]{"_cat/nodes"});
		internal static ApiUrls CatPendingTasks = new ApiUrls(new[]{"_cat/pending_tasks"});
		internal static ApiUrls CatPlugins = new ApiUrls(new[]{"_cat/plugins"});
		internal static ApiUrls CatRecovery = new ApiUrls(new[]{"_cat/recovery", "_cat/recovery/{index}"});
		internal static ApiUrls CatRepositories = new ApiUrls(new[]{"_cat/repositories"});
		internal static ApiUrls CatSegments = new ApiUrls(new[]{"_cat/segments", "_cat/segments/{index}"});
		internal static ApiUrls CatShards = new ApiUrls(new[]{"_cat/shards", "_cat/shards/{index}"});
		internal static ApiUrls CatSnapshots = new ApiUrls(new[]{"_cat/snapshots", "_cat/snapshots/{repository}"});
		internal static ApiUrls CatTasks = new ApiUrls(new[]{"_cat/tasks"});
		internal static ApiUrls CatTemplates = new ApiUrls(new[]{"_cat/templates", "_cat/templates/{name}"});
		internal static ApiUrls CatThreadPool = new ApiUrls(new[]{"_cat/thread_pool", "_cat/thread_pool/{thread_pool_patterns}"});
		internal static ApiUrls CrossClusterReplicationDeleteAutoFollowPattern = new ApiUrls(new[]{"_ccr/auto_follow/{name}"});
		internal static ApiUrls CrossClusterReplicationCreateFollowIndex = new ApiUrls(new[]{"{index}/_ccr/follow"});
		internal static ApiUrls CrossClusterReplicationFollowIndexStats = new ApiUrls(new[]{"{index}/_ccr/stats"});
		internal static ApiUrls CrossClusterReplicationGetAutoFollowPattern = new ApiUrls(new[]{"_ccr/auto_follow", "_ccr/auto_follow/{name}"});
		internal static ApiUrls CrossClusterReplicationPauseFollowIndex = new ApiUrls(new[]{"{index}/_ccr/pause_follow"});
		internal static ApiUrls CrossClusterReplicationCreateAutoFollowPattern = new ApiUrls(new[]{"_ccr/auto_follow/{name}"});
		internal static ApiUrls CrossClusterReplicationResumeFollowIndex = new ApiUrls(new[]{"{index}/_ccr/resume_follow"});
		internal static ApiUrls CrossClusterReplicationStats = new ApiUrls(new[]{"_ccr/stats"});
		internal static ApiUrls CrossClusterReplicationUnfollowIndex = new ApiUrls(new[]{"{index}/_ccr/unfollow"});
		internal static ApiUrls NoNamespaceClearScroll = new ApiUrls(new[]{"_search/scroll"});
		internal static ApiUrls ClusterAllocationExplain = new ApiUrls(new[]{"_cluster/allocation/explain"});
		internal static ApiUrls ClusterGetSettings = new ApiUrls(new[]{"_cluster/settings"});
		internal static ApiUrls ClusterHealth = new ApiUrls(new[]{"_cluster/health", "_cluster/health/{index}"});
		internal static ApiUrls ClusterPendingTasks = new ApiUrls(new[]{"_cluster/pending_tasks"});
		internal static ApiUrls ClusterPutSettings = new ApiUrls(new[]{"_cluster/settings"});
		internal static ApiUrls ClusterRemoteInfo = new ApiUrls(new[]{"_remote/info"});
		internal static ApiUrls ClusterReroute = new ApiUrls(new[]{"_cluster/reroute"});
		internal static ApiUrls ClusterState = new ApiUrls(new[]{"_cluster/state", "_cluster/state/{metric}", "_cluster/state/{metric}/{index}"});
		internal static ApiUrls ClusterStats = new ApiUrls(new[]{"_cluster/stats", "_cluster/stats/nodes/{node_id}"});
		internal static ApiUrls NoNamespaceCount = new ApiUrls(new[]{"_count", "{index}/_count"});
		internal static ApiUrls NoNamespaceCreate = new ApiUrls(new[]{"{index}/_create/{id}"});
		internal static ApiUrls NoNamespaceDelete = new ApiUrls(new[]{"{index}/_doc/{id}"});
		internal static ApiUrls NoNamespaceDeleteByQuery = new ApiUrls(new[]{"{index}/_delete_by_query"});
		internal static ApiUrls NoNamespaceDeleteByQueryRethrottle = new ApiUrls(new[]{"_delete_by_query/{task_id}/_rethrottle"});
		internal static ApiUrls NoNamespaceDeleteScript = new ApiUrls(new[]{"_scripts/{id}"});
		internal static ApiUrls NoNamespaceDocumentExists = new ApiUrls(new[]{"{index}/_doc/{id}"});
		internal static ApiUrls NoNamespaceSourceExists = new ApiUrls(new[]{"{index}/_source/{id}"});
		internal static ApiUrls NoNamespaceExplain = new ApiUrls(new[]{"{index}/_explain/{id}"});
		internal static ApiUrls NoNamespaceFieldCapabilities = new ApiUrls(new[]{"_field_caps", "{index}/_field_caps"});
		internal static ApiUrls NoNamespaceGet = new ApiUrls(new[]{"{index}/_doc/{id}"});
		internal static ApiUrls NoNamespaceGetScript = new ApiUrls(new[]{"_scripts/{id}"});
		internal static ApiUrls NoNamespaceSource = new ApiUrls(new[]{"{index}/_source/{id}"});
		internal static ApiUrls GraphExplore = new ApiUrls(new[]{"{index}/_graph/explore"});
		internal static ApiUrls IndexLifecycleManagementDeleteLifecycle = new ApiUrls(new[]{"_ilm/policy/{policy_id}"});
		internal static ApiUrls IndexLifecycleManagementExplainLifecycle = new ApiUrls(new[]{"{index}/_ilm/explain"});
		internal static ApiUrls IndexLifecycleManagementGetLifecycle = new ApiUrls(new[]{"_ilm/policy/{policy_id}", "_ilm/policy"});
		internal static ApiUrls IndexLifecycleManagementGetStatus = new ApiUrls(new[]{"_ilm/status"});
		internal static ApiUrls IndexLifecycleManagementMoveToStep = new ApiUrls(new[]{"_ilm/move/{index}"});
		internal static ApiUrls IndexLifecycleManagementPutLifecycle = new ApiUrls(new[]{"_ilm/policy/{policy_id}"});
		internal static ApiUrls IndexLifecycleManagementRemovePolicy = new ApiUrls(new[]{"{index}/_ilm/remove"});
		internal static ApiUrls IndexLifecycleManagementRetry = new ApiUrls(new[]{"{index}/_ilm/retry"});
		internal static ApiUrls IndexLifecycleManagementStart = new ApiUrls(new[]{"_ilm/start"});
		internal static ApiUrls IndexLifecycleManagementStop = new ApiUrls(new[]{"_ilm/stop"});
		internal static ApiUrls NoNamespaceIndex = new ApiUrls(new[]{"{index}/_doc/{id}", "{index}/_doc"});
		internal static ApiUrls IndicesAnalyze = new ApiUrls(new[]{"_analyze", "{index}/_analyze"});
		internal static ApiUrls IndicesClearCache = new ApiUrls(new[]{"_cache/clear", "{index}/_cache/clear"});
		internal static ApiUrls IndicesClose = new ApiUrls(new[]{"{index}/_close"});
		internal static ApiUrls IndicesCreate = new ApiUrls(new[]{"{index}"});
		internal static ApiUrls IndicesDelete = new ApiUrls(new[]{"{index}"});
		internal static ApiUrls IndicesDeleteAlias = new ApiUrls(new[]{"{index}/_alias/{name}"});
		internal static ApiUrls IndicesDeleteTemplate = new ApiUrls(new[]{"_template/{name}"});
		internal static ApiUrls IndicesExists = new ApiUrls(new[]{"{index}"});
		internal static ApiUrls IndicesAliasExists = new ApiUrls(new[]{"_alias/{name}", "{index}/_alias/{name}"});
		internal static ApiUrls IndicesTemplateExists = new ApiUrls(new[]{"_template/{name}"});
		internal static ApiUrls IndicesTypeExists = new ApiUrls(new[]{"{index}/_mapping/{type}"});
		internal static ApiUrls IndicesFlush = new ApiUrls(new[]{"_flush", "{index}/_flush"});
		internal static ApiUrls IndicesSyncedFlush = new ApiUrls(new[]{"_flush/synced", "{index}/_flush/synced"});
		internal static ApiUrls IndicesForceMerge = new ApiUrls(new[]{"_forcemerge", "{index}/_forcemerge"});
		internal static ApiUrls IndicesGet = new ApiUrls(new[]{"{index}"});
		internal static ApiUrls IndicesGetAlias = new ApiUrls(new[]{"_alias", "_alias/{name}", "{index}/_alias/{name}", "{index}/_alias"});
		internal static ApiUrls IndicesGetFieldMapping = new ApiUrls(new[]{"_mapping/field/{fields}", "{index}/_mapping/field/{fields}"});
		internal static ApiUrls IndicesGetMapping = new ApiUrls(new[]{"_mapping", "{index}/_mapping"});
		internal static ApiUrls IndicesGetSettings = new ApiUrls(new[]{"_settings", "{index}/_settings", "{index}/_settings/{name}", "_settings/{name}"});
		internal static ApiUrls IndicesGetTemplate = new ApiUrls(new[]{"_template", "_template/{name}"});
		internal static ApiUrls IndicesUpgradeStatus = new ApiUrls(new[]{"_upgrade", "{index}/_upgrade"});
		internal static ApiUrls IndicesOpen = new ApiUrls(new[]{"{index}/_open"});
		internal static ApiUrls IndicesPutAlias = new ApiUrls(new[]{"{index}/_alias/{name}"});
		internal static ApiUrls IndicesPutMapping = new ApiUrls(new[]{"{index}/_mapping"});
		internal static ApiUrls IndicesUpdateSettings = new ApiUrls(new[]{"_settings", "{index}/_settings"});
		internal static ApiUrls IndicesPutTemplate = new ApiUrls(new[]{"_template/{name}"});
		internal static ApiUrls IndicesRecoveryStatus = new ApiUrls(new[]{"_recovery", "{index}/_recovery"});
		internal static ApiUrls IndicesRefresh = new ApiUrls(new[]{"_refresh", "{index}/_refresh"});
		internal static ApiUrls IndicesRollover = new ApiUrls(new[]{"{alias}/_rollover", "{alias}/_rollover/{new_index}"});
		internal static ApiUrls IndicesSegments = new ApiUrls(new[]{"_segments", "{index}/_segments"});
		internal static ApiUrls IndicesShardStores = new ApiUrls(new[]{"_shard_stores", "{index}/_shard_stores"});
		internal static ApiUrls IndicesShrink = new ApiUrls(new[]{"{index}/_shrink/{target}"});
		internal static ApiUrls IndicesSplit = new ApiUrls(new[]{"{index}/_split/{target}"});
		internal static ApiUrls IndicesStats = new ApiUrls(new[]{"_stats", "_stats/{metric}", "{index}/_stats", "{index}/_stats/{metric}"});
		internal static ApiUrls IndicesBulkAlias = new ApiUrls(new[]{"_aliases"});
		internal static ApiUrls IndicesUpgrade = new ApiUrls(new[]{"_upgrade", "{index}/_upgrade"});
		internal static ApiUrls IndicesValidateQuery = new ApiUrls(new[]{"_validate/query", "{index}/_validate/query"});
		internal static ApiUrls NoNamespaceRootNodeInfo = new ApiUrls(new[]{""});
		internal static ApiUrls IngestDeletePipeline = new ApiUrls(new[]{"_ingest/pipeline/{id}"});
		internal static ApiUrls IngestGetPipeline = new ApiUrls(new[]{"_ingest/pipeline", "_ingest/pipeline/{id}"});
		internal static ApiUrls IngestGrokProcessorPatterns = new ApiUrls(new[]{"_ingest/processor/grok"});
		internal static ApiUrls IngestPutPipeline = new ApiUrls(new[]{"_ingest/pipeline/{id}"});
		internal static ApiUrls IngestSimulatePipeline = new ApiUrls(new[]{"_ingest/pipeline/_simulate", "_ingest/pipeline/{id}/_simulate"});
		internal static ApiUrls LicenseDelete = new ApiUrls(new[]{"_license"});
		internal static ApiUrls LicenseGet = new ApiUrls(new[]{"_license"});
		internal static ApiUrls LicenseGetBasicStatus = new ApiUrls(new[]{"_license/basic_status"});
		internal static ApiUrls LicenseGetTrialStatus = new ApiUrls(new[]{"_license/trial_status"});
		internal static ApiUrls LicensePost = new ApiUrls(new[]{"_license"});
		internal static ApiUrls LicenseStartBasic = new ApiUrls(new[]{"_license/start_basic"});
		internal static ApiUrls LicenseStartTrial = new ApiUrls(new[]{"_license/start_trial"});
		internal static ApiUrls NoNamespaceMultiGet = new ApiUrls(new[]{"_mget", "{index}/_mget"});
		internal static ApiUrls MigrationDeprecationInfo = new ApiUrls(new[]{"_migration/deprecations", "{index}/_migration/deprecations"});
		internal static ApiUrls MigrationAssistance = new ApiUrls(new[]{"_migration/assistance", "_migration/assistance/{index}"});
		internal static ApiUrls MigrationUpgrade = new ApiUrls(new[]{"_migration/upgrade/{index}"});
		internal static ApiUrls MachineLearningCloseJob = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}/_close"});
		internal static ApiUrls MachineLearningDeleteCalendar = new ApiUrls(new[]{"_ml/calendars/{calendar_id}"});
		internal static ApiUrls MachineLearningDeleteCalendarEvent = new ApiUrls(new[]{"_ml/calendars/{calendar_id}/events/{event_id}"});
		internal static ApiUrls MachineLearningDeleteCalendarJob = new ApiUrls(new[]{"_ml/calendars/{calendar_id}/jobs/{job_id}"});
		internal static ApiUrls MachineLearningDeleteDatafeed = new ApiUrls(new[]{"_ml/datafeeds/{datafeed_id}"});
		internal static ApiUrls MachineLearningDeleteExpiredData = new ApiUrls(new[]{"_ml/_delete_expired_data"});
		internal static ApiUrls MachineLearningDeleteFilter = new ApiUrls(new[]{"_ml/filters/{filter_id}"});
		internal static ApiUrls MachineLearningDeleteForecast = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}/_forecast/{forecast_id}"});
		internal static ApiUrls MachineLearningDeleteJob = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}"});
		internal static ApiUrls MachineLearningDeleteModelSnapshot = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}/model_snapshots/{snapshot_id}"});
		internal static ApiUrls MachineLearningFlushJob = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}/_flush"});
		internal static ApiUrls MachineLearningForecastJob = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}/_forecast"});
		internal static ApiUrls MachineLearningGetBuckets = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}/results/buckets/{timestamp}", "_ml/anomaly_detectors/{job_id}/results/buckets"});
		internal static ApiUrls MachineLearningGetCalendarEvents = new ApiUrls(new[]{"_ml/calendars/{calendar_id}/events"});
		internal static ApiUrls MachineLearningGetCalendars = new ApiUrls(new[]{"_ml/calendars", "_ml/calendars/{calendar_id}"});
		internal static ApiUrls MachineLearningGetCategories = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}/results/categories/{category_id}", "_ml/anomaly_detectors/{job_id}/results/categories/"});
		internal static ApiUrls MachineLearningGetDatafeedStats = new ApiUrls(new[]{"_ml/datafeeds/{datafeed_id}/_stats", "_ml/datafeeds/_stats"});
		internal static ApiUrls MachineLearningGetDatafeeds = new ApiUrls(new[]{"_ml/datafeeds/{datafeed_id}", "_ml/datafeeds"});
		internal static ApiUrls MachineLearningGetFilters = new ApiUrls(new[]{"_ml/filters", "_ml/filters/{filter_id}"});
		internal static ApiUrls MachineLearningGetInfluencers = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}/results/influencers"});
		internal static ApiUrls MachineLearningGetJobStats = new ApiUrls(new[]{"_ml/anomaly_detectors/_stats", "_ml/anomaly_detectors/{job_id}/_stats"});
		internal static ApiUrls MachineLearningGetJobs = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}", "_ml/anomaly_detectors"});
		internal static ApiUrls MachineLearningGetModelSnapshots = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}/model_snapshots/{snapshot_id}", "_ml/anomaly_detectors/{job_id}/model_snapshots"});
		internal static ApiUrls MachineLearningGetOverallBuckets = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}/results/overall_buckets"});
		internal static ApiUrls MachineLearningGetAnomalyRecords = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}/results/records"});
		internal static ApiUrls MachineLearningInfo = new ApiUrls(new[]{"_ml/info"});
		internal static ApiUrls MachineLearningOpenJob = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}/_open"});
		internal static ApiUrls MachineLearningPostCalendarEvents = new ApiUrls(new[]{"_ml/calendars/{calendar_id}/events"});
		internal static ApiUrls MachineLearningPostJobData = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}/_data"});
		internal static ApiUrls MachineLearningPreviewDatafeed = new ApiUrls(new[]{"_ml/datafeeds/{datafeed_id}/_preview"});
		internal static ApiUrls MachineLearningPutCalendar = new ApiUrls(new[]{"_ml/calendars/{calendar_id}"});
		internal static ApiUrls MachineLearningPutCalendarJob = new ApiUrls(new[]{"_ml/calendars/{calendar_id}/jobs/{job_id}"});
		internal static ApiUrls MachineLearningPutDatafeed = new ApiUrls(new[]{"_ml/datafeeds/{datafeed_id}"});
		internal static ApiUrls MachineLearningPutFilter = new ApiUrls(new[]{"_ml/filters/{filter_id}"});
		internal static ApiUrls MachineLearningPutJob = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}"});
		internal static ApiUrls MachineLearningRevertModelSnapshot = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}/model_snapshots/{snapshot_id}/_revert"});
		internal static ApiUrls MachineLearningStartDatafeed = new ApiUrls(new[]{"_ml/datafeeds/{datafeed_id}/_start"});
		internal static ApiUrls MachineLearningStopDatafeed = new ApiUrls(new[]{"_ml/datafeeds/{datafeed_id}/_stop"});
		internal static ApiUrls MachineLearningUpdateDatafeed = new ApiUrls(new[]{"_ml/datafeeds/{datafeed_id}/_update"});
		internal static ApiUrls MachineLearningUpdateFilter = new ApiUrls(new[]{"_ml/filters/{filter_id}/_update"});
		internal static ApiUrls MachineLearningUpdateJob = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}/_update"});
		internal static ApiUrls MachineLearningUpdateModelSnapshot = new ApiUrls(new[]{"_ml/anomaly_detectors/{job_id}/model_snapshots/{snapshot_id}/_update"});
		internal static ApiUrls MachineLearningValidateJob = new ApiUrls(new[]{"_ml/anomaly_detectors/_validate"});
		internal static ApiUrls MachineLearningValidateDetector = new ApiUrls(new[]{"_ml/anomaly_detectors/_validate/detector"});
		internal static ApiUrls NoNamespaceMultiSearch = new ApiUrls(new[]{"_msearch", "{index}/_msearch"});
		internal static ApiUrls NoNamespaceMultiSearchTemplate = new ApiUrls(new[]{"_msearch/template", "{index}/_msearch/template"});
		internal static ApiUrls NoNamespaceMultiTermVectors = new ApiUrls(new[]{"_mtermvectors", "{index}/_mtermvectors"});
		internal static ApiUrls NodesHotThreads = new ApiUrls(new[]{"_nodes/hot_threads", "_nodes/{node_id}/hot_threads"});
		internal static ApiUrls NodesInfo = new ApiUrls(new[]{"_nodes", "_nodes/{node_id}", "_nodes/{metric}", "_nodes/{node_id}/{metric}"});
		internal static ApiUrls NodesReloadSecureSettings = new ApiUrls(new[]{"_nodes/reload_secure_settings", "_nodes/{node_id}/reload_secure_settings"});
		internal static ApiUrls NodesStats = new ApiUrls(new[]{"_nodes/stats", "_nodes/{node_id}/stats", "_nodes/stats/{metric}", "_nodes/{node_id}/stats/{metric}", "_nodes/stats/{metric}/{index_metric}", "_nodes/{node_id}/stats/{metric}/{index_metric}"});
		internal static ApiUrls NodesUsage = new ApiUrls(new[]{"_nodes/usage", "_nodes/{node_id}/usage", "_nodes/usage/{metric}", "_nodes/{node_id}/usage/{metric}"});
		internal static ApiUrls NoNamespacePing = new ApiUrls(new[]{""});
		internal static ApiUrls NoNamespacePutScript = new ApiUrls(new[]{"_scripts/{id}", "_scripts/{id}/{context}"});
		internal static ApiUrls NoNamespaceReindexOnServer = new ApiUrls(new[]{"_reindex"});
		internal static ApiUrls NoNamespaceReindexRethrottle = new ApiUrls(new[]{"_reindex/{task_id}/_rethrottle"});
		internal static ApiUrls NoNamespaceRenderSearchTemplate = new ApiUrls(new[]{"_render/template", "_render/template/{id}"});
		internal static ApiUrls RollupDeleteJob = new ApiUrls(new[]{"_rollup/job/{id}"});
		internal static ApiUrls RollupGetJob = new ApiUrls(new[]{"_rollup/job/{id}", "_rollup/job/"});
		internal static ApiUrls RollupGetCapabilities = new ApiUrls(new[]{"_rollup/data/{id}", "_rollup/data/"});
		internal static ApiUrls RollupGetIndexCapabilities = new ApiUrls(new[]{"{index}/_rollup/data"});
		internal static ApiUrls RollupCreateJob = new ApiUrls(new[]{"_rollup/job/{id}"});
		internal static ApiUrls RollupSearch = new ApiUrls(new[]{"{index}/_rollup_search"});
		internal static ApiUrls RollupStartJob = new ApiUrls(new[]{"_rollup/job/{id}/_start"});
		internal static ApiUrls RollupStopJob = new ApiUrls(new[]{"_rollup/job/{id}/_stop"});
		internal static ApiUrls NoNamespaceExecutePainlessScript = new ApiUrls(new[]{"_scripts/painless/_execute"});
		internal static ApiUrls NoNamespaceScroll = new ApiUrls(new[]{"_search/scroll"});
		internal static ApiUrls NoNamespaceSearch = new ApiUrls(new[]{"_search", "{index}/_search"});
		internal static ApiUrls NoNamespaceSearchShards = new ApiUrls(new[]{"_search_shards", "{index}/_search_shards"});
		internal static ApiUrls NoNamespaceSearchTemplate = new ApiUrls(new[]{"_search/template", "{index}/_search/template"});
		internal static ApiUrls SecurityAuthenticate = new ApiUrls(new[]{"_security/_authenticate"});
		internal static ApiUrls SecurityChangePassword = new ApiUrls(new[]{"_security/user/{username}/_password", "_security/user/_password"});
		internal static ApiUrls SecurityClearCachedRealms = new ApiUrls(new[]{"_security/realm/{realms}/_clear_cache"});
		internal static ApiUrls SecurityClearCachedRoles = new ApiUrls(new[]{"_security/role/{name}/_clear_cache"});
		internal static ApiUrls SecurityCreateApiKey = new ApiUrls(new[]{"_security/api_key"});
		internal static ApiUrls SecurityDeletePrivileges = new ApiUrls(new[]{"_security/privilege/{application}/{name}"});
		internal static ApiUrls SecurityDeleteRole = new ApiUrls(new[]{"_security/role/{name}"});
		internal static ApiUrls SecurityDeleteRoleMapping = new ApiUrls(new[]{"_security/role_mapping/{name}"});
		internal static ApiUrls SecurityDeleteUser = new ApiUrls(new[]{"_security/user/{username}"});
		internal static ApiUrls SecurityDisableUser = new ApiUrls(new[]{"_security/user/{username}/_disable"});
		internal static ApiUrls SecurityEnableUser = new ApiUrls(new[]{"_security/user/{username}/_enable"});
		internal static ApiUrls SecurityGetApiKey = new ApiUrls(new[]{"_security/api_key"});
		internal static ApiUrls SecurityGetPrivileges = new ApiUrls(new[]{"_security/privilege", "_security/privilege/{application}", "_security/privilege/{application}/{name}"});
		internal static ApiUrls SecurityGetRole = new ApiUrls(new[]{"_security/role/{name}", "_security/role"});
		internal static ApiUrls SecurityGetRoleMapping = new ApiUrls(new[]{"_security/role_mapping/{name}", "_security/role_mapping"});
		internal static ApiUrls SecurityGetUserAccessToken = new ApiUrls(new[]{"_security/oauth2/token"});
		internal static ApiUrls SecurityGetUser = new ApiUrls(new[]{"_security/user/{username}", "_security/user"});
		internal static ApiUrls SecurityGetUserPrivileges = new ApiUrls(new[]{"_security/user/_privileges"});
		internal static ApiUrls SecurityHasPrivileges = new ApiUrls(new[]{"_security/user/_has_privileges", "_security/user/{user}/_has_privileges"});
		internal static ApiUrls SecurityInvalidateApiKey = new ApiUrls(new[]{"_security/api_key"});
		internal static ApiUrls SecurityInvalidateUserAccessToken = new ApiUrls(new[]{"_security/oauth2/token"});
		internal static ApiUrls SecurityPutPrivileges = new ApiUrls(new[]{"_security/privilege/"});
		internal static ApiUrls SecurityPutRole = new ApiUrls(new[]{"_security/role/{name}"});
		internal static ApiUrls SecurityPutRoleMapping = new ApiUrls(new[]{"_security/role_mapping/{name}"});
		internal static ApiUrls SecurityPutUser = new ApiUrls(new[]{"_security/user/{username}"});
		internal static ApiUrls SnapshotSnapshot = new ApiUrls(new[]{"_snapshot/{repository}/{snapshot}"});
		internal static ApiUrls SnapshotCreateRepository = new ApiUrls(new[]{"_snapshot/{repository}"});
		internal static ApiUrls SnapshotDelete = new ApiUrls(new[]{"_snapshot/{repository}/{snapshot}"});
		internal static ApiUrls SnapshotDeleteRepository = new ApiUrls(new[]{"_snapshot/{repository}"});
		internal static ApiUrls SnapshotGet = new ApiUrls(new[]{"_snapshot/{repository}/{snapshot}"});
		internal static ApiUrls SnapshotGetRepository = new ApiUrls(new[]{"_snapshot", "_snapshot/{repository}"});
		internal static ApiUrls SnapshotRestore = new ApiUrls(new[]{"_snapshot/{repository}/{snapshot}/_restore"});
		internal static ApiUrls SnapshotStatus = new ApiUrls(new[]{"_snapshot/_status", "_snapshot/{repository}/_status", "_snapshot/{repository}/{snapshot}/_status"});
		internal static ApiUrls SnapshotVerifyRepository = new ApiUrls(new[]{"_snapshot/{repository}/_verify"});
		internal static ApiUrls SqlClearCursor = new ApiUrls(new[]{"_sql/close"});
		internal static ApiUrls SqlQuery = new ApiUrls(new[]{"_sql"});
		internal static ApiUrls SqlTranslate = new ApiUrls(new[]{"_sql/translate"});
		internal static ApiUrls SecurityGetCertificates = new ApiUrls(new[]{"_ssl/certificates"});
		internal static ApiUrls TasksCancel = new ApiUrls(new[]{"_tasks/_cancel", "_tasks/{task_id}/_cancel"});
		internal static ApiUrls TasksGetTask = new ApiUrls(new[]{"_tasks/{task_id}"});
		internal static ApiUrls TasksList = new ApiUrls(new[]{"_tasks"});
		internal static ApiUrls NoNamespaceTermVectors = new ApiUrls(new[]{"{index}/_termvectors/{id}", "{index}/_termvectors"});
		internal static ApiUrls NoNamespaceUpdate = new ApiUrls(new[]{"{index}/_update/{id}"});
		internal static ApiUrls NoNamespaceUpdateByQuery = new ApiUrls(new[]{"{index}/_update_by_query"});
		internal static ApiUrls NoNamespaceUpdateByQueryRethrottle = new ApiUrls(new[]{"_update_by_query/{task_id}/_rethrottle"});
		internal static ApiUrls WatcherAcknowledge = new ApiUrls(new[]{"_watcher/watch/{watch_id}/_ack", "_watcher/watch/{watch_id}/_ack/{action_id}"});
		internal static ApiUrls WatcherActivate = new ApiUrls(new[]{"_watcher/watch/{watch_id}/_activate"});
		internal static ApiUrls WatcherDeactivate = new ApiUrls(new[]{"_watcher/watch/{watch_id}/_deactivate"});
		internal static ApiUrls WatcherDelete = new ApiUrls(new[]{"_watcher/watch/{id}"});
		internal static ApiUrls WatcherExecute = new ApiUrls(new[]{"_watcher/watch/{id}/_execute", "_watcher/watch/_execute"});
		internal static ApiUrls WatcherGet = new ApiUrls(new[]{"_watcher/watch/{id}"});
		internal static ApiUrls WatcherPut = new ApiUrls(new[]{"_watcher/watch/{id}"});
		internal static ApiUrls WatcherStart = new ApiUrls(new[]{"_watcher/_start"});
		internal static ApiUrls WatcherStats = new ApiUrls(new[]{"_watcher/stats", "_watcher/stats/{metric}"});
		internal static ApiUrls WatcherStop = new ApiUrls(new[]{"_watcher/_stop"});
		internal static ApiUrls XPackInfo = new ApiUrls(new[]{"_xpack"});
		internal static ApiUrls XPackUsage = new ApiUrls(new[]{"_xpack/usage"});
	}
}