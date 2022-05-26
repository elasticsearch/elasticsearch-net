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
		internal static ApiUrls AsyncSearchStatus = new ApiUrls(new[] { "/_async_search/status/{id}" });
		internal static ApiUrls AsyncSearchSubmit = new ApiUrls(new[] { "/_async_search", "/{index}/_async_search" });
		internal static ApiUrls AsyncSearchDelete = new ApiUrls(new[] { "/_async_search/{id}" });
		internal static ApiUrls AsyncSearchGet = new ApiUrls(new[] { "/_async_search/{id}" });
		internal static ApiUrls AutoscalingDeleteAutoscalingPolicy = new ApiUrls(new[] { "/_autoscaling/policy/{name}" });
		internal static ApiUrls AutoscalingGetAutoscalingCapacity = new ApiUrls(new[] { "/_autoscaling/capacity" });
		internal static ApiUrls AutoscalingGetAutoscalingPolicy = new ApiUrls(new[] { "/_autoscaling/policy/{name}" });
		internal static ApiUrls AutoscalingPutAutoscalingPolicy = new ApiUrls(new[] { "/_autoscaling/policy/{name}" });
		internal static ApiUrls NoNamespaceBulk = new ApiUrls(new[] { "/_bulk", "/{index}/_bulk" });
		internal static ApiUrls CrossClusterReplicationDeleteAutoFollowPattern = new ApiUrls(new[] { "/_ccr/auto_follow/{name}" });
		internal static ApiUrls CrossClusterReplicationFollowInfo = new ApiUrls(new[] { "/{index}/_ccr/info" });
		internal static ApiUrls CrossClusterReplicationFollow = new ApiUrls(new[] { "/{index}/_ccr/follow" });
		internal static ApiUrls CrossClusterReplicationFollowStats = new ApiUrls(new[] { "/{index}/_ccr/stats" });
		internal static ApiUrls CrossClusterReplicationForgetFollower = new ApiUrls(new[] { "/{index}/_ccr/forget_follower" });
		internal static ApiUrls CrossClusterReplicationGetAutoFollowPattern = new ApiUrls(new[] { "/_ccr/auto_follow", "/_ccr/auto_follow/{name}" });
		internal static ApiUrls CrossClusterReplicationPauseAutoFollowPattern = new ApiUrls(new[] { "/_ccr/auto_follow/{name}/pause" });
		internal static ApiUrls CrossClusterReplicationPauseFollow = new ApiUrls(new[] { "/{index}/_ccr/pause_follow" });
		internal static ApiUrls CrossClusterReplicationPutAutoFollowPattern = new ApiUrls(new[] { "/_ccr/auto_follow/{name}" });
		internal static ApiUrls CrossClusterReplicationResumeAutoFollowPattern = new ApiUrls(new[] { "/_ccr/auto_follow/{name}/resume" });
		internal static ApiUrls CrossClusterReplicationResumeFollow = new ApiUrls(new[] { "/{index}/_ccr/resume_follow" });
		internal static ApiUrls CrossClusterReplicationStats = new ApiUrls(new[] { "/_ccr/stats" });
		internal static ApiUrls CrossClusterReplicationUnfollow = new ApiUrls(new[] { "/{index}/_ccr/unfollow" });
		internal static ApiUrls NoNamespaceClearScroll = new ApiUrls(new[] { "/_search/scroll" });
		internal static ApiUrls NoNamespaceClosePointInTime = new ApiUrls(new[] { "/_pit" });
		internal static ApiUrls ClusterAllocationExplain = new ApiUrls(new[] { "/_cluster/allocation/explain" });
		internal static ApiUrls ClusterDeleteComponentTemplate = new ApiUrls(new[] { "/_component_template/{name}" });
		internal static ApiUrls ClusterDeleteVotingConfigExclusions = new ApiUrls(new[] { "/_cluster/voting_config_exclusions" });
		internal static ApiUrls ClusterExistsComponentTemplate = new ApiUrls(new[] { "/_component_template/{name}" });
		internal static ApiUrls ClusterGetComponentTemplate = new ApiUrls(new[] { "/_component_template", "/_component_template/{name}" });
		internal static ApiUrls ClusterGetSettings = new ApiUrls(new[] { "/_cluster/settings" });
		internal static ApiUrls ClusterHealth = new ApiUrls(new[] { "/_cluster/health", "/_cluster/health/{index}" });
		internal static ApiUrls ClusterPendingTasks = new ApiUrls(new[] { "/_cluster/pending_tasks" });
		internal static ApiUrls ClusterPostVotingConfigExclusions = new ApiUrls(new[] { "/_cluster/voting_config_exclusions" });
		internal static ApiUrls ClusterPutComponentTemplate = new ApiUrls(new[] { "/_component_template/{name}" });
		internal static ApiUrls ClusterPutSettings = new ApiUrls(new[] { "/_cluster/settings" });
		internal static ApiUrls ClusterRemoteInfo = new ApiUrls(new[] { "/_remote/info" });
		internal static ApiUrls ClusterReroute = new ApiUrls(new[] { "/_cluster/reroute" });
		internal static ApiUrls ClusterState = new ApiUrls(new[] { "/_cluster/state", "/_cluster/state/{metric}", "/_cluster/state/{metric}/{index}" });
		internal static ApiUrls ClusterStats = new ApiUrls(new[] { "/_cluster/stats", "/_cluster/stats/nodes/{node_id}" });
		internal static ApiUrls NoNamespaceCount = new ApiUrls(new[] { "/_count", "/{index}/_count" });
		internal static ApiUrls NoNamespaceCreate = new ApiUrls(new[] { "/{index}/_create/{id}" });
		internal static ApiUrls DanglingIndicesListDanglingIndices = new ApiUrls(new[] { "/_dangling" });
		internal static ApiUrls NoNamespaceDeleteByQuery = new ApiUrls(new[] { "/{index}/_delete_by_query" });
		internal static ApiUrls NoNamespaceDeleteByQueryRethrottle = new ApiUrls(new[] { "/_delete_by_query/{task_id}/_rethrottle" });
		internal static ApiUrls NoNamespaceDelete = new ApiUrls(new[] { "/{index}/_doc/{id}" });
		internal static ApiUrls NoNamespaceDeleteScript = new ApiUrls(new[] { "/_scripts/{id}" });
		internal static ApiUrls EnrichDeletePolicy = new ApiUrls(new[] { "/_enrich/policy/{name}" });
		internal static ApiUrls EnrichExecutePolicy = new ApiUrls(new[] { "/_enrich/policy/{name}/_execute" });
		internal static ApiUrls EnrichGetPolicy = new ApiUrls(new[] { "/_enrich/policy/{name}", "/_enrich/policy" });
		internal static ApiUrls EnrichPutPolicy = new ApiUrls(new[] { "/_enrich/policy/{name}" });
		internal static ApiUrls EnrichStats = new ApiUrls(new[] { "/_enrich/_stats" });
		internal static ApiUrls EqlDelete = new ApiUrls(new[] { "/_eql/search/{id}" });
		internal static ApiUrls EqlGetStatus = new ApiUrls(new[] { "/_eql/search/status/{id}" });
		internal static ApiUrls EqlSearch = new ApiUrls(new[] { "/{index}/_eql/search" });
		internal static ApiUrls EqlGet = new ApiUrls(new[] { "/_eql/search/{id}" });
		internal static ApiUrls NoNamespaceExists = new ApiUrls(new[] { "/{index}/_doc/{id}" });
		internal static ApiUrls NoNamespaceExistsSource = new ApiUrls(new[] { "/{index}/_source/{id}" });
		internal static ApiUrls NoNamespaceExplain = new ApiUrls(new[] { "/{index}/_explain/{id}" });
		internal static ApiUrls FeaturesGetFeatures = new ApiUrls(new[] { "/_features" });
		internal static ApiUrls NoNamespaceFieldCaps = new ApiUrls(new[] { "/_field_caps", "/{index}/_field_caps" });
		internal static ApiUrls NoNamespaceGet = new ApiUrls(new[] { "/{index}/_doc/{id}" });
		internal static ApiUrls GraphExplore = new ApiUrls(new[] { "/{index}/_graph/explore" });
		internal static ApiUrls IndexLifecycleManagementDeleteLifecycle = new ApiUrls(new[] { "/_ilm/policy/{policy}" });
		internal static ApiUrls IndexLifecycleManagementExplainLifecycle = new ApiUrls(new[] { "/{index}/_ilm/explain" });
		internal static ApiUrls IndexLifecycleManagementGetLifecycle = new ApiUrls(new[] { "/_ilm/policy/{policy}", "/_ilm/policy" });
		internal static ApiUrls IndexLifecycleManagementGetStatus = new ApiUrls(new[] { "/_ilm/status" });
		internal static ApiUrls IndexLifecycleManagementMigrateToDataTiers = new ApiUrls(new[] { "/_ilm/migrate_to_data_tiers" });
		internal static ApiUrls IndexLifecycleManagementMoveToStep = new ApiUrls(new[] { "/_ilm/move/{index}" });
		internal static ApiUrls IndexLifecycleManagementPutLifecycle = new ApiUrls(new[] { "/_ilm/policy/{policy}" });
		internal static ApiUrls IndexLifecycleManagementRemovePolicy = new ApiUrls(new[] { "/{index}/_ilm/remove" });
		internal static ApiUrls IndexLifecycleManagementRetry = new ApiUrls(new[] { "/{index}/_ilm/retry" });
		internal static ApiUrls IndexLifecycleManagementStart = new ApiUrls(new[] { "/_ilm/start" });
		internal static ApiUrls IndexLifecycleManagementStop = new ApiUrls(new[] { "/_ilm/stop" });
		internal static ApiUrls IndexManagementGetAlias = new ApiUrls(new[] { "/_alias", "/_alias/{name}", "/{index}/_alias/{name}", "/{index}/_alias" });
		internal static ApiUrls IndexManagementAnalyze = new ApiUrls(new[] { "/_analyze", "/{index}/_analyze" });
		internal static ApiUrls IndexManagementClearCache = new ApiUrls(new[] { "/_cache/clear", "/{index}/_cache/clear" });
		internal static ApiUrls IndexManagementClone = new ApiUrls(new[] { "/{index}/_clone/{target}" });
		internal static ApiUrls IndexManagementClose = new ApiUrls(new[] { "/{index}/_close" });
		internal static ApiUrls IndexManagementCreateDataStream = new ApiUrls(new[] { "/_data_stream/{name}" });
		internal static ApiUrls IndexManagementCreate = new ApiUrls(new[] { "/{index}" });
		internal static ApiUrls IndexManagementGetDataStream = new ApiUrls(new[] { "/_data_stream", "/_data_stream/{name}" });
		internal static ApiUrls IndexManagementDataStreamsStats = new ApiUrls(new[] { "/_data_stream/_stats", "/_data_stream/{name}/_stats" });
		internal static ApiUrls IndexManagementDeleteAlias = new ApiUrls(new[] { "/{index}/_alias/{name}" });
		internal static ApiUrls IndexManagementDeleteDataStream = new ApiUrls(new[] { "/_data_stream/{name}" });
		internal static ApiUrls IndexManagementDeleteIndexTemplate = new ApiUrls(new[] { "/_index_template/{name}" });
		internal static ApiUrls IndexManagementDelete = new ApiUrls(new[] { "/{index}" });
		internal static ApiUrls IndexManagementDeleteTemplate = new ApiUrls(new[] { "/_template/{name}" });
		internal static ApiUrls IndexManagementExistsAlias = new ApiUrls(new[] { "/_alias/{name}", "/{index}/_alias/{name}" });
		internal static ApiUrls IndexManagementExistsIndexTemplate = new ApiUrls(new[] { "/_index_template/{name}" });
		internal static ApiUrls IndexManagementExists = new ApiUrls(new[] { "/{index}" });
		internal static ApiUrls IndexManagementExistsTemplate = new ApiUrls(new[] { "/_template/{name}" });
		internal static ApiUrls IndexManagementGetFieldMapping = new ApiUrls(new[] { "/_mapping/field/{fields}", "/{index}/_mapping/field/{fields}" });
		internal static ApiUrls IndexManagementFlush = new ApiUrls(new[] { "/_flush", "/{index}/_flush" });
		internal static ApiUrls IndexManagementForcemerge = new ApiUrls(new[] { "/_forcemerge", "/{index}/_forcemerge" });
		internal static ApiUrls IndexManagementGet = new ApiUrls(new[] { "/{index}" });
		internal static ApiUrls IndexManagementGetIndexTemplate = new ApiUrls(new[] { "/_index_template", "/_index_template/{name}" });
		internal static ApiUrls IndexManagementGetMapping = new ApiUrls(new[] { "/_mapping", "/{index}/_mapping" });
		internal static ApiUrls IndexManagementMigrateToDataStream = new ApiUrls(new[] { "/_data_stream/_migrate/{name}" });
		internal static ApiUrls IndexManagementOpen = new ApiUrls(new[] { "/{index}/_open" });
		internal static ApiUrls IndexManagementPromoteDataStream = new ApiUrls(new[] { "/_data_stream/_promote/{name}" });
		internal static ApiUrls IndexManagementPutAlias = new ApiUrls(new[] { "/{index}/_alias/{name}" });
		internal static ApiUrls IndexManagementPutIndexTemplate = new ApiUrls(new[] { "/_index_template/{name}" });
		internal static ApiUrls IndexManagementPutMapping = new ApiUrls(new[] { "/{index}/_mapping" });
		internal static ApiUrls IndexManagementPutSettings = new ApiUrls(new[] { "/_settings", "/{index}/_settings" });
		internal static ApiUrls IndexManagementPutTemplate = new ApiUrls(new[] { "/_template/{name}" });
		internal static ApiUrls IndexManagementRecovery = new ApiUrls(new[] { "/_recovery", "/{index}/_recovery" });
		internal static ApiUrls IndexManagementRefresh = new ApiUrls(new[] { "/_refresh", "/{index}/_refresh" });
		internal static ApiUrls IndexManagementReloadSearchAnalyzers = new ApiUrls(new[] { "/{index}/_reload_search_analyzers" });
		internal static ApiUrls IndexManagementResolveIndex = new ApiUrls(new[] { "/_resolve/index/{name}" });
		internal static ApiUrls IndexManagementRollover = new ApiUrls(new[] { "/{alias}/_rollover", "/{alias}/_rollover/{new_index}" });
		internal static ApiUrls IndexManagementSegments = new ApiUrls(new[] { "/_segments", "/{index}/_segments" });
		internal static ApiUrls IndexManagementGetSettings = new ApiUrls(new[] { "/_settings", "/{index}/_settings", "/{index}/_settings/{name}", "/_settings/{name}" });
		internal static ApiUrls IndexManagementShardStores = new ApiUrls(new[] { "/_shard_stores", "/{index}/_shard_stores" });
		internal static ApiUrls IndexManagementShrink = new ApiUrls(new[] { "/{index}/_shrink/{target}" });
		internal static ApiUrls IndexManagementSimulateIndexTemplate = new ApiUrls(new[] { "/_index_template/_simulate_index/{name}" });
		internal static ApiUrls IndexManagementSimulateTemplate = new ApiUrls(new[] { "/_index_template/_simulate", "/_index_template/_simulate/{name}" });
		internal static ApiUrls IndexManagementSplit = new ApiUrls(new[] { "/{index}/_split/{target}" });
		internal static ApiUrls IndexManagementStats = new ApiUrls(new[] { "/_stats", "/_stats/{metric}", "/{index}/_stats", "/{index}/_stats/{metric}" });
		internal static ApiUrls IndexManagementGetTemplate = new ApiUrls(new[] { "/_template", "/_template/{name}" });
		internal static ApiUrls IndexManagementValidateQuery = new ApiUrls(new[] { "/_validate/query", "/{index}/_validate/query" });
		internal static ApiUrls NoNamespaceIndex = new ApiUrls(new[] { "/{index}/_doc/{id}", "/{index}/_doc" });
		internal static ApiUrls NoNamespaceInfo = new ApiUrls(new[] { "/" });
		internal static ApiUrls IngestDeletePipeline = new ApiUrls(new[] { "/_ingest/pipeline/{id}" });
		internal static ApiUrls IngestGeoIpStats = new ApiUrls(new[] { "/_ingest/geoip/stats" });
		internal static ApiUrls IngestGetPipeline = new ApiUrls(new[] { "/_ingest/pipeline", "/_ingest/pipeline/{id}" });
		internal static ApiUrls IngestProcessorGrok = new ApiUrls(new[] { "/_ingest/processor/grok" });
		internal static ApiUrls IngestPutPipeline = new ApiUrls(new[] { "/_ingest/pipeline/{id}" });
		internal static ApiUrls IngestSimulate = new ApiUrls(new[] { "/_ingest/pipeline/_simulate", "/_ingest/pipeline/{id}/_simulate" });
		internal static ApiUrls LicenseDelete = new ApiUrls(new[] { "/_license" });
		internal static ApiUrls LicenseGet = new ApiUrls(new[] { "/_license" });
		internal static ApiUrls LicenseGetBasicStatus = new ApiUrls(new[] { "/_license/basic_status" });
		internal static ApiUrls LicenseGetTrialStatus = new ApiUrls(new[] { "/_license/trial_status" });
		internal static ApiUrls LicensePost = new ApiUrls(new[] { "/_license" });
		internal static ApiUrls LicensePostStartBasic = new ApiUrls(new[] { "/_license/start_basic" });
		internal static ApiUrls LicensePostStartTrial = new ApiUrls(new[] { "/_license/start_trial" });
		internal static ApiUrls LogstashDeletePipeline = new ApiUrls(new[] { "/_logstash/pipeline/{id}" });
		internal static ApiUrls LogstashPutPipeline = new ApiUrls(new[] { "/_logstash/pipeline/{id}" });
		internal static ApiUrls MigrationDeprecations = new ApiUrls(new[] { "/_migration/deprecations", "/{index}/_migration/deprecations" });
		internal static ApiUrls MigrationGetFeatureUpgradeStatus = new ApiUrls(new[] { "/_migration/system_features" });
		internal static ApiUrls MigrationPostFeatureUpgrade = new ApiUrls(new[] { "/_migration/system_features" });
		internal static ApiUrls MachineLearningCloseJob = new ApiUrls(new[] { "/_ml/anomaly_detectors/{job_id}/_close" });
		internal static ApiUrls MachineLearningDeleteCalendarEvent = new ApiUrls(new[] { "/_ml/calendars/{calendar_id}/events/{event_id}" });
		internal static ApiUrls MachineLearningDeleteCalendar = new ApiUrls(new[] { "/_ml/calendars/{calendar_id}" });
		internal static ApiUrls MachineLearningDeleteDatafeed = new ApiUrls(new[] { "/_ml/datafeeds/{datafeed_id}" });
		internal static ApiUrls MachineLearningDeleteDataFrameAnalytics = new ApiUrls(new[] { "/_ml/data_frame/analytics/{id}" });
		internal static ApiUrls MachineLearningDeleteExpiredData = new ApiUrls(new[] { "/_ml/_delete_expired_data/{job_id}", "/_ml/_delete_expired_data" });
		internal static ApiUrls MachineLearningDeleteFilter = new ApiUrls(new[] { "/_ml/filters/{filter_id}" });
		internal static ApiUrls MachineLearningDeleteForecast = new ApiUrls(new[] { "/_ml/anomaly_detectors/{job_id}/_forecast", "/_ml/anomaly_detectors/{job_id}/_forecast/{forecast_id}" });
		internal static ApiUrls MachineLearningDeleteJob = new ApiUrls(new[] { "/_ml/anomaly_detectors/{job_id}" });
		internal static ApiUrls MachineLearningDeleteModelSnapshot = new ApiUrls(new[] { "/_ml/anomaly_detectors/{job_id}/model_snapshots/{snapshot_id}" });
		internal static ApiUrls MachineLearningDeleteTrainedModelAlias = new ApiUrls(new[] { "/_ml/trained_models/{model_id}/model_aliases/{model_alias}" });
		internal static ApiUrls MachineLearningDeleteTrainedModel = new ApiUrls(new[] { "/_ml/trained_models/{model_id}" });
		internal static ApiUrls MachineLearningEstimateModelMemory = new ApiUrls(new[] { "/_ml/anomaly_detectors/_estimate_model_memory" });
		internal static ApiUrls MachineLearningEvaluateDataFrame = new ApiUrls(new[] { "/_ml/data_frame/_evaluate" });
		internal static ApiUrls MachineLearningExplainDataFrameAnalytics = new ApiUrls(new[] { "/_ml/data_frame/analytics/_explain", "/_ml/data_frame/analytics/{id}/_explain" });
		internal static ApiUrls MachineLearningFlushJob = new ApiUrls(new[] { "/_ml/anomaly_detectors/{job_id}/_flush" });
		internal static ApiUrls MachineLearningForecast = new ApiUrls(new[] { "/_ml/anomaly_detectors/{job_id}/_forecast" });
		internal static ApiUrls MachineLearningGetCalendarEvents = new ApiUrls(new[] { "/_ml/calendars/{calendar_id}/events" });
		internal static ApiUrls MachineLearningGetCalendars = new ApiUrls(new[] { "/_ml/calendars", "/_ml/calendars/{calendar_id}" });
		internal static ApiUrls MachineLearningGetDataFrameAnalytics = new ApiUrls(new[] { "/_ml/data_frame/analytics/{id}", "/_ml/data_frame/analytics" });
		internal static ApiUrls MachineLearningGetDataFrameAnalyticsStats = new ApiUrls(new[] { "/_ml/data_frame/analytics/_stats", "/_ml/data_frame/analytics/{id}/_stats" });
		internal static ApiUrls MachineLearningGetInfluencers = new ApiUrls(new[] { "/_ml/anomaly_detectors/{job_id}/results/influencers" });
		internal static ApiUrls MachineLearningGetJobStats = new ApiUrls(new[] { "/_ml/anomaly_detectors/_stats", "/_ml/anomaly_detectors/{job_id}/_stats" });
		internal static ApiUrls MachineLearningGetMemoryStats = new ApiUrls(new[] { "/_ml/memory/_stats", "/_ml/memory/{node_id}/_stats" });
		internal static ApiUrls MachineLearningGetModelSnapshots = new ApiUrls(new[] { "/_ml/anomaly_detectors/{job_id}/model_snapshots/{snapshot_id}", "/_ml/anomaly_detectors/{job_id}/model_snapshots" });
		internal static ApiUrls MachineLearningGetOverallBuckets = new ApiUrls(new[] { "/_ml/anomaly_detectors/{job_id}/results/overall_buckets" });
		internal static ApiUrls MachineLearningGetRecords = new ApiUrls(new[] { "/_ml/anomaly_detectors/{job_id}/results/records" });
		internal static ApiUrls MachineLearningGetTrainedModelsStats = new ApiUrls(new[] { "/_ml/trained_models/{model_id}/_stats", "/_ml/trained_models/_stats" });
		internal static ApiUrls MachineLearningInfo = new ApiUrls(new[] { "/_ml/info" });
		internal static ApiUrls MachineLearningOpenJob = new ApiUrls(new[] { "/_ml/anomaly_detectors/{job_id}/_open" });
		internal static ApiUrls MachineLearningPostCalendarEvents = new ApiUrls(new[] { "/_ml/calendars/{calendar_id}/events" });
		internal static ApiUrls MachineLearningPreviewDatafeed = new ApiUrls(new[] { "/_ml/datafeeds/{datafeed_id}/_preview", "/_ml/datafeeds/_preview" });
		internal static ApiUrls MachineLearningPreviewDataFrameAnalytics = new ApiUrls(new[] { "/_ml/data_frame/analytics/_preview", "/_ml/data_frame/analytics/{id}/_preview" });
		internal static ApiUrls MachineLearningPutCalendarJob = new ApiUrls(new[] { "/_ml/calendars/{calendar_id}/jobs/{job_id}" });
		internal static ApiUrls MachineLearningPutCalendar = new ApiUrls(new[] { "/_ml/calendars/{calendar_id}" });
		internal static ApiUrls MachineLearningPutDatafeed = new ApiUrls(new[] { "/_ml/datafeeds/{datafeed_id}" });
		internal static ApiUrls MachineLearningPutDataFrameAnalytics = new ApiUrls(new[] { "/_ml/data_frame/analytics/{id}" });
		internal static ApiUrls MachineLearningPutFilter = new ApiUrls(new[] { "/_ml/filters/{filter_id}" });
		internal static ApiUrls MachineLearningPutJob = new ApiUrls(new[] { "/_ml/anomaly_detectors/{job_id}" });
		internal static ApiUrls MachineLearningPutTrainedModelAlias = new ApiUrls(new[] { "/_ml/trained_models/{model_id}/model_aliases/{model_alias}" });
		internal static ApiUrls MachineLearningPutTrainedModel = new ApiUrls(new[] { "/_ml/trained_models/{model_id}" });
		internal static ApiUrls MachineLearningResetJob = new ApiUrls(new[] { "/_ml/anomaly_detectors/{job_id}/_reset" });
		internal static ApiUrls MachineLearningRevertModelSnapshot = new ApiUrls(new[] { "/_ml/anomaly_detectors/{job_id}/model_snapshots/{snapshot_id}/_revert" });
		internal static ApiUrls MachineLearningSetUpgradeMode = new ApiUrls(new[] { "/_ml/set_upgrade_mode" });
		internal static ApiUrls MachineLearningStartDatafeed = new ApiUrls(new[] { "/_ml/datafeeds/{datafeed_id}/_start" });
		internal static ApiUrls MachineLearningStartDataFrameAnalytics = new ApiUrls(new[] { "/_ml/data_frame/analytics/{id}/_start" });
		internal static ApiUrls MachineLearningStopDatafeed = new ApiUrls(new[] { "/_ml/datafeeds/{datafeed_id}/_stop" });
		internal static ApiUrls MachineLearningStopDataFrameAnalytics = new ApiUrls(new[] { "/_ml/data_frame/analytics/{id}/_stop" });
		internal static ApiUrls MachineLearningUpdateDatafeed = new ApiUrls(new[] { "/_ml/datafeeds/{datafeed_id}/_update" });
		internal static ApiUrls MachineLearningUpdateDataFrameAnalytics = new ApiUrls(new[] { "/_ml/data_frame/analytics/{id}/_update" });
		internal static ApiUrls MachineLearningUpdateFilter = new ApiUrls(new[] { "/_ml/filters/{filter_id}/_update" });
		internal static ApiUrls MachineLearningUpdateJob = new ApiUrls(new[] { "/_ml/anomaly_detectors/{job_id}/_update" });
		internal static ApiUrls MachineLearningUpdateModelSnapshot = new ApiUrls(new[] { "/_ml/anomaly_detectors/{job_id}/model_snapshots/{snapshot_id}/_update" });
		internal static ApiUrls MachineLearningUpgradeJobSnapshot = new ApiUrls(new[] { "/_ml/anomaly_detectors/{job_id}/model_snapshots/{snapshot_id}/_upgrade" });
		internal static ApiUrls MachineLearningValidateDetector = new ApiUrls(new[] { "/_ml/anomaly_detectors/_validate/detector" });
		internal static ApiUrls MachineLearningValidate = new ApiUrls(new[] { "/_ml/anomaly_detectors/_validate" });
		internal static ApiUrls NodesHotThreads = new ApiUrls(new[] { "/_nodes/hot_threads", "/_nodes/{node_id}/hot_threads" });
		internal static ApiUrls NodesInfo = new ApiUrls(new[] { "/_nodes", "/_nodes/{node_id}", "/_nodes/{metric}", "/_nodes/{node_id}/{metric}" });
		internal static ApiUrls NodesReloadSecureSettings = new ApiUrls(new[] { "/_nodes/reload_secure_settings", "/_nodes/{node_id}/reload_secure_settings" });
		internal static ApiUrls NodesStats = new ApiUrls(new[] { "/_nodes/stats", "/_nodes/{node_id}/stats", "/_nodes/stats/{metric}", "/_nodes/{node_id}/stats/{metric}", "/_nodes/stats/{metric}/{index_metric}", "/_nodes/{node_id}/stats/{metric}/{index_metric}" });
		internal static ApiUrls NodesUsage = new ApiUrls(new[] { "/_nodes/usage", "/_nodes/{node_id}/usage", "/_nodes/usage/{metric}", "/_nodes/{node_id}/usage/{metric}" });
		internal static ApiUrls NoNamespaceOpenPointInTime = new ApiUrls(new[] { "/{index}/_pit" });
		internal static ApiUrls NoNamespacePing = new ApiUrls(new[] { "/" });
		internal static ApiUrls NoNamespacePutScript = new ApiUrls(new[] { "/_scripts/{id}", "/_scripts/{id}/{context}" });
		internal static ApiUrls NoNamespaceRankEval = new ApiUrls(new[] { "/_rank_eval", "/{index}/_rank_eval" });
		internal static ApiUrls NoNamespaceReindex = new ApiUrls(new[] { "/_reindex" });
		internal static ApiUrls NoNamespaceReindexRethrottle = new ApiUrls(new[] { "/_reindex/{task_id}/_rethrottle" });
		internal static ApiUrls NoNamespaceGetScriptContext = new ApiUrls(new[] { "/_script_context" });
		internal static ApiUrls NoNamespaceGetScriptLanguages = new ApiUrls(new[] { "/_script_language" });
		internal static ApiUrls NoNamespaceGetScript = new ApiUrls(new[] { "/_scripts/{id}" });
		internal static ApiUrls NoNamespaceScroll = new ApiUrls(new[] { "/_search/scroll" });
		internal static ApiUrls SearchableSnapshotsMount = new ApiUrls(new[] { "/_snapshot/{repository}/{snapshot}/_mount" });
		internal static ApiUrls SearchableSnapshotsStats = new ApiUrls(new[] { "/_searchable_snapshots/stats", "/{index}/_searchable_snapshots/stats" });
		internal static ApiUrls NoNamespaceSearch = new ApiUrls(new[] { "/_search", "/{index}/_search" });
		internal static ApiUrls NoNamespaceSearchShards = new ApiUrls(new[] { "/_search_shards", "/{index}/_search_shards" });
		internal static ApiUrls SecurityAuthenticate = new ApiUrls(new[] { "/_security/_authenticate" });
		internal static ApiUrls SecurityChangePassword = new ApiUrls(new[] { "/_security/user/{username}/_password", "/_security/user/_password" });
		internal static ApiUrls SecurityClearApiKeyCache = new ApiUrls(new[] { "/_security/api_key/{ids}/_clear_cache" });
		internal static ApiUrls SecurityClearCachedPrivileges = new ApiUrls(new[] { "/_security/privilege/{application}/_clear_cache" });
		internal static ApiUrls SecurityClearCachedRealms = new ApiUrls(new[] { "/_security/realm/{realms}/_clear_cache" });
		internal static ApiUrls SecurityClearCachedRoles = new ApiUrls(new[] { "/_security/role/{name}/_clear_cache" });
		internal static ApiUrls SecurityDeletePrivileges = new ApiUrls(new[] { "/_security/privilege/{application}/{name}" });
		internal static ApiUrls SecurityDeleteRoleMapping = new ApiUrls(new[] { "/_security/role_mapping/{name}" });
		internal static ApiUrls SecurityDeleteRole = new ApiUrls(new[] { "/_security/role/{name}" });
		internal static ApiUrls SecurityDeleteUser = new ApiUrls(new[] { "/_security/user/{username}" });
		internal static ApiUrls SecurityDisableUser = new ApiUrls(new[] { "/_security/user/{username}/_disable" });
		internal static ApiUrls SecurityEnableUser = new ApiUrls(new[] { "/_security/user/{username}/_enable" });
		internal static ApiUrls SecurityGetApiKey = new ApiUrls(new[] { "/_security/api_key" });
		internal static ApiUrls SecurityGetBuiltinPrivileges = new ApiUrls(new[] { "/_security/privilege/_builtin" });
		internal static ApiUrls SecurityGetPrivileges = new ApiUrls(new[] { "/_security/privilege", "/_security/privilege/{application}", "/_security/privilege/{application}/{name}" });
		internal static ApiUrls SecurityGetRoleMapping = new ApiUrls(new[] { "/_security/role_mapping/{name}", "/_security/role_mapping" });
		internal static ApiUrls SecurityGetRole = new ApiUrls(new[] { "/_security/role/{name}", "/_security/role" });
		internal static ApiUrls SecurityGetToken = new ApiUrls(new[] { "/_security/oauth2/token" });
		internal static ApiUrls SecurityGrantApiKey = new ApiUrls(new[] { "/_security/api_key/grant" });
		internal static ApiUrls SecurityHasPrivileges = new ApiUrls(new[] { "/_security/user/_has_privileges", "/_security/user/{user}/_has_privileges" });
		internal static ApiUrls SecurityInvalidateApiKey = new ApiUrls(new[] { "/_security/api_key" });
		internal static ApiUrls SecurityInvalidateToken = new ApiUrls(new[] { "/_security/oauth2/token" });
		internal static ApiUrls SecurityPutUser = new ApiUrls(new[] { "/_security/user/{username}" });
		internal static ApiUrls SecurityQueryApiKeys = new ApiUrls(new[] { "/_security/_query/api_key" });
		internal static ApiUrls SecuritySamlAuthenticate = new ApiUrls(new[] { "/_security/saml/authenticate" });
		internal static ApiUrls SecuritySamlCompleteLogout = new ApiUrls(new[] { "/_security/saml/complete_logout" });
		internal static ApiUrls SecuritySamlInvalidate = new ApiUrls(new[] { "/_security/saml/invalidate" });
		internal static ApiUrls SecuritySamlLogout = new ApiUrls(new[] { "/_security/saml/logout" });
		internal static ApiUrls SecuritySamlPrepareAuthentication = new ApiUrls(new[] { "/_security/saml/prepare" });
		internal static ApiUrls SecuritySamlServiceProviderMetadata = new ApiUrls(new[] { "/_security/saml/metadata/{realm_name}" });
		internal static ApiUrls SnapshotLifecycleManagementDeleteLifecycle = new ApiUrls(new[] { "/_slm/policy/{policy_id}" });
		internal static ApiUrls SnapshotLifecycleManagementExecuteLifecycle = new ApiUrls(new[] { "/_slm/policy/{policy_id}/_execute" });
		internal static ApiUrls SnapshotLifecycleManagementExecuteRetention = new ApiUrls(new[] { "/_slm/_execute_retention" });
		internal static ApiUrls SnapshotLifecycleManagementGetLifecycle = new ApiUrls(new[] { "/_slm/policy/{policy_id}", "/_slm/policy" });
		internal static ApiUrls SnapshotLifecycleManagementGetStats = new ApiUrls(new[] { "/_slm/stats" });
		internal static ApiUrls SnapshotLifecycleManagementGetStatus = new ApiUrls(new[] { "/_slm/status" });
		internal static ApiUrls SnapshotLifecycleManagementPutLifecycle = new ApiUrls(new[] { "/_slm/policy/{policy_id}" });
		internal static ApiUrls SnapshotLifecycleManagementStart = new ApiUrls(new[] { "/_slm/start" });
		internal static ApiUrls SnapshotLifecycleManagementStop = new ApiUrls(new[] { "/_slm/stop" });
		internal static ApiUrls SnapshotCreate = new ApiUrls(new[] { "/_snapshot/{repository}/{snapshot}" });
		internal static ApiUrls SnapshotDelete = new ApiUrls(new[] { "/_snapshot/{repository}/{snapshot}" });
		internal static ApiUrls SnapshotGet = new ApiUrls(new[] { "/_snapshot/{repository}/{snapshot}" });
		internal static ApiUrls SnapshotCleanupRepository = new ApiUrls(new[] { "/_snapshot/{repository}/_cleanup" });
		internal static ApiUrls SnapshotClone = new ApiUrls(new[] { "/_snapshot/{repository}/{snapshot}/_clone/{target_snapshot}" });
		internal static ApiUrls SnapshotCreateRepository = new ApiUrls(new[] { "/_snapshot/{repository}" });
		internal static ApiUrls SnapshotDeleteRepository = new ApiUrls(new[] { "/_snapshot/{repository}" });
		internal static ApiUrls SnapshotGetRepository = new ApiUrls(new[] { "/_snapshot", "/_snapshot/{repository}" });
		internal static ApiUrls SnapshotRestore = new ApiUrls(new[] { "/_snapshot/{repository}/{snapshot}/_restore" });
		internal static ApiUrls SnapshotStatus = new ApiUrls(new[] { "/_snapshot/_status", "/_snapshot/{repository}/_status", "/_snapshot/{repository}/{snapshot}/_status" });
		internal static ApiUrls SnapshotVerifyRepository = new ApiUrls(new[] { "/_snapshot/{repository}/_verify" });
		internal static ApiUrls NoNamespaceGetSource = new ApiUrls(new[] { "/{index}/_source/{id}" });
		internal static ApiUrls SqlClearCursor = new ApiUrls(new[] { "/_sql/close" });
		internal static ApiUrls SqlDeleteAsync = new ApiUrls(new[] { "/_sql/async/delete/{id}" });
		internal static ApiUrls SqlGetAsync = new ApiUrls(new[] { "/_sql/async/{id}" });
		internal static ApiUrls SqlGetAsyncStatus = new ApiUrls(new[] { "/_sql/async/status/{id}" });
		internal static ApiUrls SqlQuery = new ApiUrls(new[] { "/_sql" });
		internal static ApiUrls SecurityCertificates = new ApiUrls(new[] { "/_ssl/certificates" });
		internal static ApiUrls NoNamespaceTermsEnum = new ApiUrls(new[] { "/{index}/_terms_enum" });
		internal static ApiUrls TransformManagementDeleteTransform = new ApiUrls(new[] { "/_transform/{transform_id}" });
		internal static ApiUrls TransformManagementGetTransform = new ApiUrls(new[] { "/_transform/{transform_id}", "/_transform" });
		internal static ApiUrls TransformManagementGetTransformStats = new ApiUrls(new[] { "/_transform/{transform_id}/_stats" });
		internal static ApiUrls TransformManagementPreviewTransform = new ApiUrls(new[] { "/_transform/{transform_id}/_preview", "/_transform/_preview" });
		internal static ApiUrls TransformManagementPutTransform = new ApiUrls(new[] { "/_transform/{transform_id}" });
		internal static ApiUrls TransformManagementResetTransform = new ApiUrls(new[] { "/_transform/{transform_id}/_reset" });
		internal static ApiUrls TransformManagementStartTransform = new ApiUrls(new[] { "/_transform/{transform_id}/_start" });
		internal static ApiUrls TransformManagementStopTransform = new ApiUrls(new[] { "/_transform/{transform_id}/_stop" });
		internal static ApiUrls TransformManagementUpdateTransform = new ApiUrls(new[] { "/_transform/{transform_id}/_update" });
		internal static ApiUrls TransformManagementUpgradeTransforms = new ApiUrls(new[] { "/_transform/_upgrade" });
		internal static ApiUrls NoNamespaceUpdateByQuery = new ApiUrls(new[] { "/{index}/_update_by_query" });
		internal static ApiUrls NoNamespaceUpdateByQueryRethrottle = new ApiUrls(new[] { "/_update_by_query/{task_id}/_rethrottle" });
		internal static ApiUrls NoNamespaceUpdate = new ApiUrls(new[] { "/{index}/_update/{id}" });
		internal static ApiUrls XpackInfo = new ApiUrls(new[] { "/_xpack" });
		internal static ApiUrls XpackUsage = new ApiUrls(new[] { "/_xpack/usage" });
	}
}