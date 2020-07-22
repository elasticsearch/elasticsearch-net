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

// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Specification.MachineLearningApi
{
	///<summary>Request options for CloseJob <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-close-job.html</para></summary>
	public class CloseJobRequestParameters : RequestParameters<CloseJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
		///<summary>Whether to ignore if a wildcard expression matches no jobs. (This includes `_all` string or when no jobs have been specified)</summary>
		public bool? AllowNoJobs
		{
			get => Q<bool? >("allow_no_jobs");
			set => Q("allow_no_jobs", value);
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
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for DeleteCalendarEvent <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-delete-calendar-event.html</para></summary>
	public class DeleteCalendarEventRequestParameters : RequestParameters<DeleteCalendarEventRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for DeleteCalendarJob <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-delete-calendar-job.html</para></summary>
	public class DeleteCalendarJobRequestParameters : RequestParameters<DeleteCalendarJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for DeleteDataFrameAnalytics <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/delete-dfanalytics.html</para></summary>
	public class DeleteDataFrameAnalyticsRequestParameters : RequestParameters<DeleteDataFrameAnalyticsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
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
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
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
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => true;
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
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for DeleteForecast <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-delete-forecast.html</para></summary>
	public class DeleteForecastRequestParameters : RequestParameters<DeleteForecastRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
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
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
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
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for DeleteTrainedModel <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/delete-inference.html</para></summary>
	public class DeleteTrainedModelRequestParameters : RequestParameters<DeleteTrainedModelRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for EstimateModelMemory <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-apis.html</para></summary>
	public class EstimateModelMemoryRequestParameters : RequestParameters<EstimateModelMemoryRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for EvaluateDataFrame <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/evaluate-dfanalytics.html</para></summary>
	public class EvaluateDataFrameRequestParameters : RequestParameters<EvaluateDataFrameRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for ExplainDataFrameAnalytics <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/explain-dfanalytics.html</para></summary>
	public class ExplainDataFrameAnalyticsRequestParameters : RequestParameters<ExplainDataFrameAnalyticsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for FindFileStructure <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-find-file-structure.html</para></summary>
	public class FindFileStructureRequestParameters : RequestParameters<FindFileStructureRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
		///<summary>Optional parameter to specify the character set of the file</summary>
		public string Charset
		{
			get => Q<string>("charset");
			set => Q("charset", value);
		}

		///<summary>Optional parameter containing a comma separated list of the column names for a delimited file</summary>
		public string[] ColumnNames
		{
			get => Q<string[]>("column_names");
			set => Q("column_names", value);
		}

		///<summary>Optional parameter to specify the delimiter character for a delimited file - must be a single character</summary>
		public string Delimiter
		{
			get => Q<string>("delimiter");
			set => Q("delimiter", value);
		}

		///<summary>Whether to include a commentary on how the structure was derived</summary>
		public bool? Explain
		{
			get => Q<bool? >("explain");
			set => Q("explain", value);
		}

		///<summary>Optional parameter to specify the high level file format</summary>
		public MachineLearningFindFileStructureFormat? MachineLearningFindFileStructureFormat
		{
			get => Q<MachineLearningFindFileStructureFormat? >("format");
			set => Q("format", value);
		}

		///<summary>Optional parameter to specify the Grok pattern that should be used to extract fields from messages in a semi-structured text file</summary>
		public string GrokPattern
		{
			get => Q<string>("grok_pattern");
			set => Q("grok_pattern", value);
		}

		///<summary>Optional parameter to specify whether a delimited file includes the column names in its first row</summary>
		public bool? HasHeaderRow
		{
			get => Q<bool? >("has_header_row");
			set => Q("has_header_row", value);
		}

		///<summary>Maximum number of characters permitted in a single message when lines are merged to create messages.</summary>
		public int? LineMergeSizeLimit
		{
			get => Q<int? >("line_merge_size_limit");
			set => Q("line_merge_size_limit", value);
		}

		///<summary>How many lines of the file should be included in the analysis</summary>
		public int? LinesToSample
		{
			get => Q<int? >("lines_to_sample");
			set => Q("lines_to_sample", value);
		}

		///<summary>Optional parameter to specify the quote character for a delimited file - must be a single character</summary>
		public string Quote
		{
			get => Q<string>("quote");
			set => Q("quote", value);
		}

		///<summary>Optional parameter to specify whether the values between delimiters in a delimited file should have whitespace trimmed from them</summary>
		public bool? ShouldTrimFields
		{
			get => Q<bool? >("should_trim_fields");
			set => Q("should_trim_fields", value);
		}

		///<summary>Timeout after which the analysis will be aborted</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Optional parameter to specify the timestamp field in the file</summary>
		public string TimestampField
		{
			get => Q<string>("timestamp_field");
			set => Q("timestamp_field", value);
		}

		///<summary>Optional parameter to specify the timestamp format in the file - may be either a Joda or Java time format</summary>
		public string TimestampFormat
		{
			get => Q<string>("timestamp_format");
			set => Q("timestamp_format", value);
		}
	}

	///<summary>Request options for FlushJob <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-flush-job.html</para></summary>
	public class FlushJobRequestParameters : RequestParameters<FlushJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
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
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => false;
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
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for GetCalendarEvents <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-calendar-event.html</para></summary>
	public class GetCalendarEventsRequestParameters : RequestParameters<GetCalendarEventsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
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
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for GetCategories <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-category.html</para></summary>
	public class GetCategoriesRequestParameters : RequestParameters<GetCategoriesRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
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
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
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
	}

	///<summary>Request options for GetDataFrameAnalyticsStats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/get-dfanalytics-stats.html</para></summary>
	public class GetDataFrameAnalyticsStatsRequestParameters : RequestParameters<GetDataFrameAnalyticsStatsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
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
	}

	///<summary>Request options for GetDatafeedStats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-datafeed-stats.html</para></summary>
	public class GetDatafeedStatsRequestParameters : RequestParameters<GetDatafeedStatsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
		///<summary>Whether to ignore if a wildcard expression matches no datafeeds. (This includes `_all` string or when no datafeeds have been specified)</summary>
		public bool? AllowNoDatafeeds
		{
			get => Q<bool? >("allow_no_datafeeds");
			set => Q("allow_no_datafeeds", value);
		}
	}

	///<summary>Request options for GetDatafeeds <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-datafeed.html</para></summary>
	public class GetDatafeedsRequestParameters : RequestParameters<GetDatafeedsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
		///<summary>Whether to ignore if a wildcard expression matches no datafeeds. (This includes `_all` string or when no datafeeds have been specified)</summary>
		public bool? AllowNoDatafeeds
		{
			get => Q<bool? >("allow_no_datafeeds");
			set => Q("allow_no_datafeeds", value);
		}
	}

	///<summary>Request options for GetFilters <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-filter.html</para></summary>
	public class GetFiltersRequestParameters : RequestParameters<GetFiltersRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
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
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for GetJobStats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-job-stats.html</para></summary>
	public class GetJobStatsRequestParameters : RequestParameters<GetJobStatsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
		///<summary>Whether to ignore if a wildcard expression matches no jobs. (This includes `_all` string or when no jobs have been specified)</summary>
		public bool? AllowNoJobs
		{
			get => Q<bool? >("allow_no_jobs");
			set => Q("allow_no_jobs", value);
		}
	}

	///<summary>Request options for GetJobs <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-job.html</para></summary>
	public class GetJobsRequestParameters : RequestParameters<GetJobsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
		///<summary>Whether to ignore if a wildcard expression matches no jobs. (This includes `_all` string or when no jobs have been specified)</summary>
		public bool? AllowNoJobs
		{
			get => Q<bool? >("allow_no_jobs");
			set => Q("allow_no_jobs", value);
		}
	}

	///<summary>Request options for GetModelSnapshots <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-snapshot.html</para></summary>
	public class GetModelSnapshotsRequestParameters : RequestParameters<GetModelSnapshotsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for GetOverallBuckets <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-overall-buckets.html</para></summary>
	public class GetOverallBucketsRequestParameters : RequestParameters<GetOverallBucketsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for GetAnomalyRecords <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-record.html</para></summary>
	public class GetAnomalyRecordsRequestParameters : RequestParameters<GetAnomalyRecordsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for GetTrainedModels <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/get-inference.html</para></summary>
	public class GetTrainedModelsRequestParameters : RequestParameters<GetTrainedModelsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
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
		public bool? ForExport
		{
			get => Q<bool? >("for_export");
			set => Q("for_export", value);
		}

		///<summary>skips a number of trained models</summary>
		public int? From
		{
			get => Q<int? >("from");
			set => Q("from", value);
		}

		///<summary>
		/// Should the full model definition be included in the results. These definitions can be large. So be cautious when including them. Defaults
		/// to false.
		///</summary>
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

	///<summary>Request options for GetTrainedModelsStats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/get-inference-stats.html</para></summary>
	public class GetTrainedModelsStatsRequestParameters : RequestParameters<GetTrainedModelsStatsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
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

	///<summary>Request options for Info <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/get-ml-info.html</para></summary>
	public class MachineLearningInfoRequestParameters : RequestParameters<MachineLearningInfoRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for OpenJob <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-open-job.html</para></summary>
	public class OpenJobRequestParameters : RequestParameters<OpenJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for PostCalendarEvents <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-post-calendar-event.html</para></summary>
	public class PostCalendarEventsRequestParameters : RequestParameters<PostCalendarEventsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for PostJobData <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-post-data.html</para></summary>
	public class PostJobDataRequestParameters : RequestParameters<PostJobDataRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
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

	///<summary>Request options for PreviewDatafeed <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-preview-datafeed.html</para></summary>
	public class PreviewDatafeedRequestParameters : RequestParameters<PreviewDatafeedRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for PutCalendar <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-put-calendar.html</para></summary>
	public class PutCalendarRequestParameters : RequestParameters<PutCalendarRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for PutCalendarJob <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-put-calendar-job.html</para></summary>
	public class PutCalendarJobRequestParameters : RequestParameters<PutCalendarJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for PutDataFrameAnalytics <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/put-dfanalytics.html</para></summary>
	public class PutDataFrameAnalyticsRequestParameters : RequestParameters<PutDataFrameAnalyticsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for PutDatafeed <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-put-datafeed.html</para></summary>
	public class PutDatafeedRequestParameters : RequestParameters<PutDatafeedRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
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
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for PutJob <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-put-job.html</para></summary>
	public class PutJobRequestParameters : RequestParameters<PutJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for PutTrainedModel <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/put-inference.html</para></summary>
	public class PutTrainedModelRequestParameters : RequestParameters<PutTrainedModelRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for RevertModelSnapshot <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-revert-snapshot.html</para></summary>
	public class RevertModelSnapshotRequestParameters : RequestParameters<RevertModelSnapshotRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for SetUpgradeMode <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-set-upgrade-mode.html</para></summary>
	public class SetUpgradeModeRequestParameters : RequestParameters<SetUpgradeModeRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => false;
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
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
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
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for StopDataFrameAnalytics <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/stop-dfanalytics.html</para></summary>
	public class StopDataFrameAnalyticsRequestParameters : RequestParameters<StopDataFrameAnalyticsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
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
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => false;
		///<summary>Whether to ignore if a wildcard expression matches no datafeeds. (This includes `_all` string or when no datafeeds have been specified)</summary>
		public bool? AllowNoDatafeeds
		{
			get => Q<bool? >("allow_no_datafeeds");
			set => Q("allow_no_datafeeds", value);
		}
	}

	///<summary>Request options for UpdateDataFrameAnalytics <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/update-dfanalytics.html</para></summary>
	public class UpdateDataFrameAnalyticsRequestParameters : RequestParameters<UpdateDataFrameAnalyticsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for UpdateDatafeed <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-update-datafeed.html</para></summary>
	public class UpdateDatafeedRequestParameters : RequestParameters<UpdateDatafeedRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
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
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for UpdateJob <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-update-job.html</para></summary>
	public class UpdateJobRequestParameters : RequestParameters<UpdateJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for UpdateModelSnapshot <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ml-update-snapshot.html</para></summary>
	public class UpdateModelSnapshotRequestParameters : RequestParameters<UpdateModelSnapshotRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for ValidateJob <para>https://www.elastic.co/guide/en/machine-learning/current/ml-jobs.html</para></summary>
	public class ValidateJobRequestParameters : RequestParameters<ValidateJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for ValidateDetector <para>https://www.elastic.co/guide/en/machine-learning/current/ml-jobs.html</para></summary>
	public class ValidateDetectorRequestParameters : RequestParameters<ValidateDetectorRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
	}
}