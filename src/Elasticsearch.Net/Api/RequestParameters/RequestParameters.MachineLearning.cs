// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elastic.Transport;

// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Specification.MachineLearningApi
{
	///<summary>Request options for CloseJob <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-close-job.html</para></summary>
	public class CloseJobRequestParameters : RequestParameters<CloseJobRequestParameters>
	{
		///<summary>Whether to ignore if a wildcard expression matches no jobs. (This includes `_all` string or when no jobs have been specified)</summary>
		[Obsolete("Scheduled to be removed in 8.0, deprecated")]
		public bool? AllowNoJobs
		{
			get => Q<bool? >("allow_no_jobs");
			set => Q("allow_no_jobs", value);
		}

		///<summary>Whether to ignore if a wildcard expression matches no jobs. (This includes `_all` string or when no jobs have been specified)</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}

		///<summary>True if the job should be forcefully closed</summary>
		public bool? Force
		{
			get => Q<bool? >("force");
			set => Q("force", value);
		}

		///<summary>Controls the time to wait until a job has closed. Default to 30 minutes</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}

	///<summary>Request options for DeleteCalendar <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-delete-calendar.html</para></summary>
	public class DeleteCalendarRequestParameters : RequestParameters<DeleteCalendarRequestParameters>
	{
	}

	///<summary>Request options for DeleteCalendarEvent <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-delete-calendar-event.html</para></summary>
	public class DeleteCalendarEventRequestParameters : RequestParameters<DeleteCalendarEventRequestParameters>
	{
	}

	///<summary>Request options for DeleteCalendarJob <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-delete-calendar-job.html</para></summary>
	public class DeleteCalendarJobRequestParameters : RequestParameters<DeleteCalendarJobRequestParameters>
	{
	}

	///<summary>Request options for DeleteDataFrameAnalytics <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/delete-dfanalytics.html</para></summary>
	public class DeleteDataFrameAnalyticsRequestParameters : RequestParameters<DeleteDataFrameAnalyticsRequestParameters>
	{
		///<summary>True if the job should be forcefully deleted</summary>
		public bool? Force
		{
			get => Q<bool? >("force");
			set => Q("force", value);
		}

		///<summary>Controls the time to wait until a job is deleted. Defaults to 1 minute</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}

	///<summary>Request options for DeleteDatafeed <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-delete-datafeed.html</para></summary>
	public class DeleteDatafeedRequestParameters : RequestParameters<DeleteDatafeedRequestParameters>
	{
		///<summary>True if the datafeed should be forcefully deleted</summary>
		public bool? Force
		{
			get => Q<bool? >("force");
			set => Q("force", value);
		}
	}

	///<summary>Request options for DeleteExpiredData <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-delete-expired-data.html</para></summary>
	public class DeleteExpiredDataRequestParameters : RequestParameters<DeleteExpiredDataRequestParameters>
	{
		///<summary>The desired requests per second for the deletion processes.</summary>
		public long? RequestsPerSecond
		{
			get => Q<long? >("requests_per_second");
			set => Q("requests_per_second", value);
		}

		///<summary>How long can the underlying delete processes run until they are canceled</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}

	///<summary>Request options for DeleteFilter <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-delete-filter.html</para></summary>
	public class DeleteFilterRequestParameters : RequestParameters<DeleteFilterRequestParameters>
	{
	}

	///<summary>Request options for DeleteForecast <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-delete-forecast.html</para></summary>
	public class DeleteForecastRequestParameters : RequestParameters<DeleteForecastRequestParameters>
	{
		///<summary>Whether to ignore if `_all` matches no forecasts</summary>
		public bool? AllowNoForecasts
		{
			get => Q<bool? >("allow_no_forecasts");
			set => Q("allow_no_forecasts", value);
		}

		///<summary>Controls the time to wait until the forecast(s) are deleted. Default to 30 seconds</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}

	///<summary>Request options for DeleteJob <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-delete-job.html</para></summary>
	public class DeleteJobRequestParameters : RequestParameters<DeleteJobRequestParameters>
	{
		///<summary>True if the job should be forcefully deleted</summary>
		public bool? Force
		{
			get => Q<bool? >("force");
			set => Q("force", value);
		}

		///<summary>Should this request wait until the operation has completed before returning</summary>
		public bool? WaitForCompletion
		{
			get => Q<bool? >("wait_for_completion");
			set => Q("wait_for_completion", value);
		}
	}

	///<summary>Request options for DeleteModelSnapshot <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-delete-snapshot.html</para></summary>
	public class DeleteModelSnapshotRequestParameters : RequestParameters<DeleteModelSnapshotRequestParameters>
	{
	}

	///<summary>Request options for DeleteTrainedModel <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/delete-trained-models.html</para></summary>
	public class DeleteTrainedModelRequestParameters : RequestParameters<DeleteTrainedModelRequestParameters>
	{
	}

	///<summary>Request options for DeleteTrainedModelAlias <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/delete-trained-models-aliases.html</para></summary>
	public class DeleteTrainedModelAliasRequestParameters : RequestParameters<DeleteTrainedModelAliasRequestParameters>
	{
	}

	///<summary>Request options for EstimateModelMemory <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-apis.html</para></summary>
	public class EstimateModelMemoryRequestParameters : RequestParameters<EstimateModelMemoryRequestParameters>
	{
	}

	///<summary>Request options for EvaluateDataFrame <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/evaluate-dfanalytics.html</para></summary>
	public class EvaluateDataFrameRequestParameters : RequestParameters<EvaluateDataFrameRequestParameters>
	{
	}

	///<summary>Request options for ExplainDataFrameAnalytics <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/explain-dfanalytics.html</para></summary>
	public class ExplainDataFrameAnalyticsRequestParameters : RequestParameters<ExplainDataFrameAnalyticsRequestParameters>
	{
	}

	///<summary>Request options for FlushJob <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-flush-job.html</para></summary>
	public class FlushJobRequestParameters : RequestParameters<FlushJobRequestParameters>
	{
		///<summary>Skips time to the given value without generating results or updating the model for the skipped interval</summary>
		public string SkipTime
		{
			get => Q<string>("skip_time");
			set => Q("skip_time", value);
		}
	}

	///<summary>Request options for ForecastJob <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-forecast.html</para></summary>
	public class ForecastJobRequestParameters : RequestParameters<ForecastJobRequestParameters>
	{
		///<summary>The max memory able to be used by the forecast. Default is 20mb.</summary>
		public string MaxModelMemory
		{
			get => Q<string>("max_model_memory");
			set => Q("max_model_memory", value);
		}
	}

	///<summary>Request options for GetBuckets <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-bucket.html</para></summary>
	public class GetBucketsRequestParameters : RequestParameters<GetBucketsRequestParameters>
	{
	}

	///<summary>Request options for GetCalendarEvents <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-calendar-event.html</para></summary>
	public class GetCalendarEventsRequestParameters : RequestParameters<GetCalendarEventsRequestParameters>
	{
		///<summary>Get events before this time</summary>
		public DateTimeOffset? End
		{
			get => Q<DateTimeOffset? >("end");
			set => Q("end", value);
		}

		///<summary>Get events for the job. When this option is used calendar_id must be '_all'</summary>
		public string JobId
		{
			get => Q<string>("job_id");
			set => Q("job_id", value);
		}

		///<summary>Get events after this time</summary>
		public string Start
		{
			get => Q<string>("start");
			set => Q("start", value);
		}
	}

	///<summary>Request options for GetCalendars <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-calendar.html</para></summary>
	public class GetCalendarsRequestParameters : RequestParameters<GetCalendarsRequestParameters>
	{
	}

	///<summary>Request options for GetCategories <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-category.html</para></summary>
	public class GetCategoriesRequestParameters : RequestParameters<GetCategoriesRequestParameters>
	{
		///<summary>
		/// Specifies the partition to retrieve categories for. This is optional, and should never be used for jobs where per-partition categorization
		/// is disabled.
		///</summary>
		public string PartitionFieldValue
		{
			get => Q<string>("partition_field_value");
			set => Q("partition_field_value", value);
		}
	}

	///<summary>Request options for GetDataFrameAnalytics <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/get-dfanalytics.html</para></summary>
	public class GetDataFrameAnalyticsRequestParameters : RequestParameters<GetDataFrameAnalyticsRequestParameters>
	{
		///<summary>
		/// Whether to ignore if a wildcard expression matches no data frame analytics. (This includes `_all` string or when no data frame analytics
		/// have been specified)
		///</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}

		///<summary>Omits fields that are illegal to set on data frame analytics PUT</summary>
		public bool? ExcludeGenerated
		{
			get => Q<bool? >("exclude_generated");
			set => Q("exclude_generated", value);
		}

		///<summary>skips a number of analytics</summary>
		public int? From
		{
			get => Q<int? >("from");
			set => Q("from", value);
		}

		///<summary>specifies a max number of analytics to get</summary>
		public int? Size
		{
			get => Q<int? >("size");
			set => Q("size", value);
		}
	}

	///<summary>Request options for GetDataFrameAnalyticsStats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/get-dfanalytics-stats.html</para></summary>
	public class GetDataFrameAnalyticsStatsRequestParameters : RequestParameters<GetDataFrameAnalyticsStatsRequestParameters>
	{
		///<summary>
		/// Whether to ignore if a wildcard expression matches no data frame analytics. (This includes `_all` string or when no data frame analytics
		/// have been specified)
		///</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}

		///<summary>skips a number of analytics</summary>
		public int? From
		{
			get => Q<int? >("from");
			set => Q("from", value);
		}

		///<summary>specifies a max number of analytics to get</summary>
		public int? Size
		{
			get => Q<int? >("size");
			set => Q("size", value);
		}

		///<summary>whether the stats response should be verbose</summary>
		public bool? Verbose
		{
			get => Q<bool? >("verbose");
			set => Q("verbose", value);
		}
	}

	///<summary>Request options for GetDatafeedStats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-datafeed-stats.html</para></summary>
	public class GetDatafeedStatsRequestParameters : RequestParameters<GetDatafeedStatsRequestParameters>
	{
		///<summary>Whether to ignore if a wildcard expression matches no datafeeds. (This includes `_all` string or when no datafeeds have been specified)</summary>
		[Obsolete("Scheduled to be removed in 8.0, deprecated")]
		public bool? AllowNoDatafeeds
		{
			get => Q<bool? >("allow_no_datafeeds");
			set => Q("allow_no_datafeeds", value);
		}

		///<summary>Whether to ignore if a wildcard expression matches no datafeeds. (This includes `_all` string or when no datafeeds have been specified)</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}
	}

	///<summary>Request options for GetDatafeeds <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-datafeed.html</para></summary>
	public class GetDatafeedsRequestParameters : RequestParameters<GetDatafeedsRequestParameters>
	{
		///<summary>Whether to ignore if a wildcard expression matches no datafeeds. (This includes `_all` string or when no datafeeds have been specified)</summary>
		[Obsolete("Scheduled to be removed in 8.0, deprecated")]
		public bool? AllowNoDatafeeds
		{
			get => Q<bool? >("allow_no_datafeeds");
			set => Q("allow_no_datafeeds", value);
		}

		///<summary>Whether to ignore if a wildcard expression matches no datafeeds. (This includes `_all` string or when no datafeeds have been specified)</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}

		///<summary>Omits fields that are illegal to set on datafeed PUT</summary>
		public bool? ExcludeGenerated
		{
			get => Q<bool? >("exclude_generated");
			set => Q("exclude_generated", value);
		}
	}

	///<summary>Request options for GetFilters <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-filter.html</para></summary>
	public class GetFiltersRequestParameters : RequestParameters<GetFiltersRequestParameters>
	{
		///<summary>skips a number of filters</summary>
		public int? From
		{
			get => Q<int? >("from");
			set => Q("from", value);
		}

		///<summary>specifies a max number of filters to get</summary>
		public int? Size
		{
			get => Q<int? >("size");
			set => Q("size", value);
		}
	}

	///<summary>Request options for GetInfluencers <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-influencer.html</para></summary>
	public class GetInfluencersRequestParameters : RequestParameters<GetInfluencersRequestParameters>
	{
	}

	///<summary>Request options for GetJobStats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-job-stats.html</para></summary>
	public class GetJobStatsRequestParameters : RequestParameters<GetJobStatsRequestParameters>
	{
		///<summary>Whether to ignore if a wildcard expression matches no jobs. (This includes `_all` string or when no jobs have been specified)</summary>
		[Obsolete("Scheduled to be removed in 8.0, deprecated")]
		public bool? AllowNoJobs
		{
			get => Q<bool? >("allow_no_jobs");
			set => Q("allow_no_jobs", value);
		}

		///<summary>Whether to ignore if a wildcard expression matches no jobs. (This includes `_all` string or when no jobs have been specified)</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}
	}

	///<summary>Request options for GetJobs <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-job.html</para></summary>
	public class GetJobsRequestParameters : RequestParameters<GetJobsRequestParameters>
	{
		///<summary>Whether to ignore if a wildcard expression matches no jobs. (This includes `_all` string or when no jobs have been specified)</summary>
		[Obsolete("Scheduled to be removed in 8.0, deprecated")]
		public bool? AllowNoJobs
		{
			get => Q<bool? >("allow_no_jobs");
			set => Q("allow_no_jobs", value);
		}

		///<summary>Whether to ignore if a wildcard expression matches no jobs. (This includes `_all` string or when no jobs have been specified)</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}

		///<summary>Omits fields that are illegal to set on job PUT</summary>
		public bool? ExcludeGenerated
		{
			get => Q<bool? >("exclude_generated");
			set => Q("exclude_generated", value);
		}
	}

	///<summary>Request options for GetModelSnapshots <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-snapshot.html</para></summary>
	public class GetModelSnapshotsRequestParameters : RequestParameters<GetModelSnapshotsRequestParameters>
	{
	}

	///<summary>Request options for GetOverallBuckets <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-overall-buckets.html</para></summary>
	public class GetOverallBucketsRequestParameters : RequestParameters<GetOverallBucketsRequestParameters>
	{
		///<summary>Whether to ignore if a wildcard expression matches no jobs. (This includes `_all` string or when no jobs have been specified)</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}
	}

	///<summary>Request options for GetAnomalyRecords <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-record.html</para></summary>
	public class GetAnomalyRecordsRequestParameters : RequestParameters<GetAnomalyRecordsRequestParameters>
	{
	}

	///<summary>Request options for GetTrainedModelDeploymentStats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-trained-model-deployment-stats.html</para></summary>
	public class GetTrainedModelDeploymentStatsRequestParameters : RequestParameters<GetTrainedModelDeploymentStatsRequestParameters>
	{
	}

	///<summary>Request options for GetTrainedModels <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/get-trained-models.html</para></summary>
	public class GetTrainedModelsRequestParameters : RequestParameters<GetTrainedModelsRequestParameters>
	{
		///<summary>
		/// Whether to ignore if a wildcard expression matches no trained models. (This includes `_all` string or when no trained models have been
		/// specified)
		///</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}

		///<summary>Should the model definition be decompressed into valid JSON or returned in a custom compressed format. Defaults to true.</summary>
		public bool? DecompressDefinition
		{
			get => Q<bool? >("decompress_definition");
			set => Q("decompress_definition", value);
		}

		///<summary>Omits fields that are illegal to set on model PUT</summary>
		public bool? ExcludeGenerated
		{
			get => Q<bool? >("exclude_generated");
			set => Q("exclude_generated", value);
		}

		///<summary>skips a number of trained models</summary>
		public int? From
		{
			get => Q<int? >("from");
			set => Q("from", value);
		}

		///<summary>A comma-separate list of fields to optionally include. Valid options are 'definition' and 'total_feature_importance'. Default is none.</summary>
		public string Include
		{
			get => Q<string>("include");
			set => Q("include", value);
		}

		///<summary>
		/// Should the full model definition be included in the results. These definitions can be large. So be cautious when including them. Defaults
		/// to false.
		///</summary>
		[Obsolete("Scheduled to be removed in 8.0, deprecated")]
		public bool? IncludeModelDefinition
		{
			get => Q<bool? >("include_model_definition");
			set => Q("include_model_definition", value);
		}

		///<summary>specifies a max number of trained models to get</summary>
		public int? Size
		{
			get => Q<int? >("size");
			set => Q("size", value);
		}

		///<summary>A comma-separated list of tags that the model must have.</summary>
		public string[] Tags
		{
			get => Q<string[]>("tags");
			set => Q("tags", value);
		}
	}

	///<summary>Request options for GetTrainedModelsStats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/get-trained-models-stats.html</para></summary>
	public class GetTrainedModelsStatsRequestParameters : RequestParameters<GetTrainedModelsStatsRequestParameters>
	{
		///<summary>
		/// Whether to ignore if a wildcard expression matches no trained models. (This includes `_all` string or when no trained models have been
		/// specified)
		///</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}

		///<summary>skips a number of trained models</summary>
		public int? From
		{
			get => Q<int? >("from");
			set => Q("from", value);
		}

		///<summary>specifies a max number of trained models to get</summary>
		public int? Size
		{
			get => Q<int? >("size");
			set => Q("size", value);
		}
	}

	///<summary>Request options for InferTrainedModelDeployment <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/infer-trained-model-deployment.html</para></summary>
	public class InferTrainedModelDeploymentRequestParameters : RequestParameters<InferTrainedModelDeploymentRequestParameters>
	{
		///<summary>Controls the amount of time to wait for inference results.</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}

	///<summary>Request options for Info <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/get-ml-info.html</para></summary>
	public class MachineLearningInfoRequestParameters : RequestParameters<MachineLearningInfoRequestParameters>
	{
	}

	///<summary>Request options for OpenJob <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-open-job.html</para></summary>
	public class OpenJobRequestParameters : RequestParameters<OpenJobRequestParameters>
	{
	}

	///<summary>Request options for PostCalendarEvents <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-post-calendar-event.html</para></summary>
	public class PostCalendarEventsRequestParameters : RequestParameters<PostCalendarEventsRequestParameters>
	{
	}

	///<summary>Request options for PostJobData <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-post-data.html</para></summary>
	public class PostJobDataRequestParameters : RequestParameters<PostJobDataRequestParameters>
	{
		///<summary>Optional parameter to specify the end of the bucket resetting range</summary>
		public DateTimeOffset? ResetEnd
		{
			get => Q<DateTimeOffset? >("reset_end");
			set => Q("reset_end", value);
		}

		///<summary>Optional parameter to specify the start of the bucket resetting range</summary>
		public DateTimeOffset? ResetStart
		{
			get => Q<DateTimeOffset? >("reset_start");
			set => Q("reset_start", value);
		}
	}

	///<summary>Request options for PreviewDataFrameAnalytics <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/preview-dfanalytics.html</para></summary>
	public class PreviewDataFrameAnalyticsRequestParameters : RequestParameters<PreviewDataFrameAnalyticsRequestParameters>
	{
	}

	///<summary>Request options for PreviewDatafeed <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-preview-datafeed.html</para></summary>
	public class PreviewDatafeedRequestParameters : RequestParameters<PreviewDatafeedRequestParameters>
	{
	}

	///<summary>Request options for PutCalendar <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-put-calendar.html</para></summary>
	public class PutCalendarRequestParameters : RequestParameters<PutCalendarRequestParameters>
	{
	}

	///<summary>Request options for PutCalendarJob <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-put-calendar-job.html</para></summary>
	public class PutCalendarJobRequestParameters : RequestParameters<PutCalendarJobRequestParameters>
	{
	}

	///<summary>Request options for PutDataFrameAnalytics <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/put-dfanalytics.html</para></summary>
	public class PutDataFrameAnalyticsRequestParameters : RequestParameters<PutDataFrameAnalyticsRequestParameters>
	{
	}

	///<summary>Request options for PutDatafeed <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-put-datafeed.html</para></summary>
	public class PutDatafeedRequestParameters : RequestParameters<PutDatafeedRequestParameters>
	{
		///<summary>Ignore if the source indices expressions resolves to no concrete indices (default: true)</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether source index expressions should get expanded to open or closed indices (default: open)</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Ignore indices that are marked as throttled (default: true)</summary>
		public bool? IgnoreThrottled
		{
			get => Q<bool? >("ignore_throttled");
			set => Q("ignore_throttled", value);
		}

		///<summary>Ignore unavailable indexes (default: false)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}
	}

	///<summary>Request options for PutFilter <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-put-filter.html</para></summary>
	public class PutFilterRequestParameters : RequestParameters<PutFilterRequestParameters>
	{
	}

	///<summary>Request options for PutJob <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-put-job.html</para></summary>
	public class PutJobRequestParameters : RequestParameters<PutJobRequestParameters>
	{
		///<summary>Ignore if the source indices expressions resolves to no concrete indices (default: true). Only set if datafeed_config is provided.</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether source index expressions should get expanded to open or closed indices (default: open). Only set if datafeed_config is provided.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Ignore indices that are marked as throttled (default: true). Only set if datafeed_config is provided.</summary>
		public bool? IgnoreThrottled
		{
			get => Q<bool? >("ignore_throttled");
			set => Q("ignore_throttled", value);
		}

		///<summary>Ignore unavailable indexes (default: false). Only set if datafeed_config is provided.</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}
	}

	///<summary>Request options for PutTrainedModel <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/put-trained-models.html</para></summary>
	public class PutTrainedModelRequestParameters : RequestParameters<PutTrainedModelRequestParameters>
	{
		///<summary>If set to `true` and a `compressed_definition` is provided, the request defers definition decompression and skips relevant validations.</summary>
		public bool? DeferDefinitionDecompression
		{
			get => Q<bool? >("defer_definition_decompression");
			set => Q("defer_definition_decompression", value);
		}
	}

	///<summary>Request options for PutTrainedModelAlias <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/put-trained-models-aliases.html</para></summary>
	public class PutTrainedModelAliasRequestParameters : RequestParameters<PutTrainedModelAliasRequestParameters>
	{
		///<summary>If the model_alias already exists and points to a separate model_id, this parameter must be true. Defaults to false.</summary>
		public bool? Reassign
		{
			get => Q<bool? >("reassign");
			set => Q("reassign", value);
		}
	}

	///<summary>Request options for PutTrainedModelDefinitionPart <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/put-trained-model-definition-part.html</para></summary>
	public class PutTrainedModelDefinitionPartRequestParameters : RequestParameters<PutTrainedModelDefinitionPartRequestParameters>
	{
	}

	///<summary>Request options for PutTrainedModelVocabulary <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/put-trained-model-vocabulary.html</para></summary>
	public class PutTrainedModelVocabularyRequestParameters : RequestParameters<PutTrainedModelVocabularyRequestParameters>
	{
	}

	///<summary>Request options for ResetJob <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-reset-job.html</para></summary>
	public class ResetJobRequestParameters : RequestParameters<ResetJobRequestParameters>
	{
		///<summary>Should this request wait until the operation has completed before returning</summary>
		public bool? WaitForCompletion
		{
			get => Q<bool? >("wait_for_completion");
			set => Q("wait_for_completion", value);
		}
	}

	///<summary>Request options for RevertModelSnapshot <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-revert-snapshot.html</para></summary>
	public class RevertModelSnapshotRequestParameters : RequestParameters<RevertModelSnapshotRequestParameters>
	{
	}

	///<summary>Request options for SetUpgradeMode <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-set-upgrade-mode.html</para></summary>
	public class SetUpgradeModeRequestParameters : RequestParameters<SetUpgradeModeRequestParameters>
	{
		///<summary>Whether to enable upgrade_mode ML setting or not. Defaults to false.</summary>
		public bool? Enabled
		{
			get => Q<bool? >("enabled");
			set => Q("enabled", value);
		}

		///<summary>Controls the time to wait before action times out. Defaults to 30 seconds</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}

	///<summary>Request options for StartDataFrameAnalytics <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/start-dfanalytics.html</para></summary>
	public class StartDataFrameAnalyticsRequestParameters : RequestParameters<StartDataFrameAnalyticsRequestParameters>
	{
		///<summary>Controls the time to wait until the task has started. Defaults to 20 seconds</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}

	///<summary>Request options for StartDatafeed <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-start-datafeed.html</para></summary>
	public class StartDatafeedRequestParameters : RequestParameters<StartDatafeedRequestParameters>
	{
	}

	///<summary>Request options for StartTrainedModelDeployment <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/start-trained-model-deployment.html</para></summary>
	public class StartTrainedModelDeploymentRequestParameters : RequestParameters<StartTrainedModelDeploymentRequestParameters>
	{
		///<summary>Controls the amount of time to wait for the model to deploy.</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}

		///<summary>The allocation status for which to wait</summary>
		public string WaitFor
		{
			get => Q<string>("wait_for");
			set => Q("wait_for", value);
		}
	}

	///<summary>Request options for StopDataFrameAnalytics <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/stop-dfanalytics.html</para></summary>
	public class StopDataFrameAnalyticsRequestParameters : RequestParameters<StopDataFrameAnalyticsRequestParameters>
	{
		///<summary>
		/// Whether to ignore if a wildcard expression matches no data frame analytics. (This includes `_all` string or when no data frame analytics
		/// have been specified)
		///</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}

		///<summary>True if the data frame analytics should be forcefully stopped</summary>
		public bool? Force
		{
			get => Q<bool? >("force");
			set => Q("force", value);
		}

		///<summary>Controls the time to wait until the task has stopped. Defaults to 20 seconds</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}

	///<summary>Request options for StopDatafeed <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-stop-datafeed.html</para></summary>
	public class StopDatafeedRequestParameters : RequestParameters<StopDatafeedRequestParameters>
	{
		///<summary>Whether to ignore if a wildcard expression matches no datafeeds. (This includes `_all` string or when no datafeeds have been specified)</summary>
		[Obsolete("Scheduled to be removed in 8.0, deprecated")]
		public bool? AllowNoDatafeeds
		{
			get => Q<bool? >("allow_no_datafeeds");
			set => Q("allow_no_datafeeds", value);
		}

		///<summary>Whether to ignore if a wildcard expression matches no datafeeds. (This includes `_all` string or when no datafeeds have been specified)</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}
	}

	///<summary>Request options for StopTrainedModelDeployment <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/stop-trained-model-deployment.html</para></summary>
	public class StopTrainedModelDeploymentRequestParameters : RequestParameters<StopTrainedModelDeploymentRequestParameters>
	{
	}

	///<summary>Request options for UpdateDataFrameAnalytics <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/update-dfanalytics.html</para></summary>
	public class UpdateDataFrameAnalyticsRequestParameters : RequestParameters<UpdateDataFrameAnalyticsRequestParameters>
	{
	}

	///<summary>Request options for UpdateDatafeed <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-update-datafeed.html</para></summary>
	public class UpdateDatafeedRequestParameters : RequestParameters<UpdateDatafeedRequestParameters>
	{
		///<summary>Ignore if the source indices expressions resolves to no concrete indices (default: true)</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Whether source index expressions should get expanded to open or closed indices (default: open)</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Ignore indices that are marked as throttled (default: true)</summary>
		public bool? IgnoreThrottled
		{
			get => Q<bool? >("ignore_throttled");
			set => Q("ignore_throttled", value);
		}

		///<summary>Ignore unavailable indexes (default: false)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}
	}

	///<summary>Request options for UpdateFilter <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-update-filter.html</para></summary>
	public class UpdateFilterRequestParameters : RequestParameters<UpdateFilterRequestParameters>
	{
	}

	///<summary>Request options for UpdateJob <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-update-job.html</para></summary>
	public class UpdateJobRequestParameters : RequestParameters<UpdateJobRequestParameters>
	{
	}

	///<summary>Request options for UpdateModelSnapshot <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-update-snapshot.html</para></summary>
	public class UpdateModelSnapshotRequestParameters : RequestParameters<UpdateModelSnapshotRequestParameters>
	{
	}

	///<summary>Request options for UpgradeJobSnapshot <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-upgrade-job-model-snapshot.html</para></summary>
	public class UpgradeJobSnapshotRequestParameters : RequestParameters<UpgradeJobSnapshotRequestParameters>
	{
		///<summary>How long should the API wait for the job to be opened and the old snapshot to be loaded.</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Should the request wait until the task is complete before responding to the caller. Default is false.</summary>
		public bool? WaitForCompletion
		{
			get => Q<bool? >("wait_for_completion");
			set => Q("wait_for_completion", value);
		}
	}

	///<summary>Request options for ValidateJob <para>https://www.elastic.co/guide/en/machine-learning/current/ml-jobs.html</para></summary>
	public class ValidateJobRequestParameters : RequestParameters<ValidateJobRequestParameters>
	{
	}

	///<summary>Request options for ValidateDetector <para>https://www.elastic.co/guide/en/machine-learning/current/ml-jobs.html</para></summary>
	public class ValidateDetectorRequestParameters : RequestParameters<ValidateDetectorRequestParameters>
	{
	}
}