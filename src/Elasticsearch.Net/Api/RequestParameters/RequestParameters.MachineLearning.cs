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
	///<summary>Request options for CloseJob<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-close-job.html</pre></summary>
	public class CloseJobRequestParameters : RequestParameters<CloseJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
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

	///<summary>Request options for DeleteCalendar<pre></pre></summary>
	public class DeleteCalendarRequestParameters : RequestParameters<DeleteCalendarRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
	}

	///<summary>Request options for DeleteCalendarEvent<pre></pre></summary>
	public class DeleteCalendarEventRequestParameters : RequestParameters<DeleteCalendarEventRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
	}

	///<summary>Request options for DeleteCalendarJob<pre></pre></summary>
	public class DeleteCalendarJobRequestParameters : RequestParameters<DeleteCalendarJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
	}

	///<summary>Request options for DeleteDatafeed<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-delete-datafeed.html</pre></summary>
	public class DeleteDatafeedRequestParameters : RequestParameters<DeleteDatafeedRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		///<summary>True if the datafeed should be forcefully deleted</summary>
		public bool? Force
		{
			get => Q<bool? >("force");
			set => Q("force", value);
		}
	}

	///<summary>Request options for DeleteExpiredData<pre></pre></summary>
	public class DeleteExpiredDataRequestParameters : RequestParameters<DeleteExpiredDataRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
	}

	///<summary>Request options for DeleteFilter<pre></pre></summary>
	public class DeleteFilterRequestParameters : RequestParameters<DeleteFilterRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
	}

	///<summary>Request options for DeleteForecast<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-delete-forecast.html</pre></summary>
	public class DeleteForecastRequestParameters : RequestParameters<DeleteForecastRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
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

	///<summary>Request options for DeleteJob<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-delete-job.html</pre></summary>
	public class DeleteJobRequestParameters : RequestParameters<DeleteJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
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

	///<summary>Request options for DeleteModelSnapshot<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-delete-snapshot.html</pre></summary>
	public class DeleteModelSnapshotRequestParameters : RequestParameters<DeleteModelSnapshotRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
	}

	///<summary>Request options for FlushJob<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-flush-job.html</pre></summary>
	public class FlushJobRequestParameters : RequestParameters<FlushJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		///<summary>Skips time to the given value without generating results or updating the model for the skipped interval</summary>
		public string SkipTime
		{
			get => Q<string>("skip_time");
			set => Q("skip_time", value);
		}
	}

	///<summary>Request options for ForecastJob<pre></pre></summary>
	public class ForecastJobRequestParameters : RequestParameters<ForecastJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for GetBuckets<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-bucket.html</pre></summary>
	public class GetBucketsRequestParameters : RequestParameters<GetBucketsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for GetCalendarEvents<pre></pre></summary>
	public class GetCalendarEventsRequestParameters : RequestParameters<GetCalendarEventsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
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

	///<summary>Request options for GetCalendars<pre></pre></summary>
	public class GetCalendarsRequestParameters : RequestParameters<GetCalendarsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for GetCategories<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-category.html</pre></summary>
	public class GetCategoriesRequestParameters : RequestParameters<GetCategoriesRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for GetDatafeedStats<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-datafeed-stats.html</pre></summary>
	public class GetDatafeedStatsRequestParameters : RequestParameters<GetDatafeedStatsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		///<summary>Whether to ignore if a wildcard expression matches no datafeeds. (This includes `_all` string or when no datafeeds have been specified)</summary>
		public bool? AllowNoDatafeeds
		{
			get => Q<bool? >("allow_no_datafeeds");
			set => Q("allow_no_datafeeds", value);
		}
	}

	///<summary>Request options for GetDatafeeds<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-datafeed.html</pre></summary>
	public class GetDatafeedsRequestParameters : RequestParameters<GetDatafeedsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		///<summary>Whether to ignore if a wildcard expression matches no datafeeds. (This includes `_all` string or when no datafeeds have been specified)</summary>
		public bool? AllowNoDatafeeds
		{
			get => Q<bool? >("allow_no_datafeeds");
			set => Q("allow_no_datafeeds", value);
		}
	}

	///<summary>Request options for GetFilters<pre></pre></summary>
	public class GetFiltersRequestParameters : RequestParameters<GetFiltersRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
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

	///<summary>Request options for GetInfluencers<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-influencer.html</pre></summary>
	public class GetInfluencersRequestParameters : RequestParameters<GetInfluencersRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for GetJobStats<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-job-stats.html</pre></summary>
	public class GetJobStatsRequestParameters : RequestParameters<GetJobStatsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		///<summary>Whether to ignore if a wildcard expression matches no jobs. (This includes `_all` string or when no jobs have been specified)</summary>
		public bool? AllowNoJobs
		{
			get => Q<bool? >("allow_no_jobs");
			set => Q("allow_no_jobs", value);
		}
	}

	///<summary>Request options for GetJobs<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-job.html</pre></summary>
	public class GetJobsRequestParameters : RequestParameters<GetJobsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		///<summary>Whether to ignore if a wildcard expression matches no jobs. (This includes `_all` string or when no jobs have been specified)</summary>
		public bool? AllowNoJobs
		{
			get => Q<bool? >("allow_no_jobs");
			set => Q("allow_no_jobs", value);
		}
	}

	///<summary>Request options for GetModelSnapshots<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-snapshot.html</pre></summary>
	public class GetModelSnapshotsRequestParameters : RequestParameters<GetModelSnapshotsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for GetOverallBuckets<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-overall-buckets.html</pre></summary>
	public class GetOverallBucketsRequestParameters : RequestParameters<GetOverallBucketsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for GetAnomalyRecords<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-get-record.html</pre></summary>
	public class GetAnomalyRecordsRequestParameters : RequestParameters<GetAnomalyRecordsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for Info<pre></pre></summary>
	public class MachineLearningInfoRequestParameters : RequestParameters<MachineLearningInfoRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
	}

	///<summary>Request options for OpenJob<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-open-job.html</pre></summary>
	public class OpenJobRequestParameters : RequestParameters<OpenJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for PostCalendarEvents<pre></pre></summary>
	public class PostCalendarEventsRequestParameters : RequestParameters<PostCalendarEventsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for PostJobData<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-post-data.html</pre></summary>
	public class PostJobDataRequestParameters : RequestParameters<PostJobDataRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
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

	///<summary>Request options for PreviewDatafeed<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-preview-datafeed.html</pre></summary>
	public class PreviewDatafeedRequestParameters : RequestParameters<PreviewDatafeedRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
	}

	///<summary>Request options for PutCalendar<pre></pre></summary>
	public class PutCalendarRequestParameters : RequestParameters<PutCalendarRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
	}

	///<summary>Request options for PutCalendarJob<pre></pre></summary>
	public class PutCalendarJobRequestParameters : RequestParameters<PutCalendarJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
	}

	///<summary>Request options for PutDatafeed<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-put-datafeed.html</pre></summary>
	public class PutDatafeedRequestParameters : RequestParameters<PutDatafeedRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
	}

	///<summary>Request options for PutFilter<pre></pre></summary>
	public class PutFilterRequestParameters : RequestParameters<PutFilterRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
	}

	///<summary>Request options for PutJob<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-put-job.html</pre></summary>
	public class PutJobRequestParameters : RequestParameters<PutJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
	}

	///<summary>Request options for RevertModelSnapshot<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-revert-snapshot.html</pre></summary>
	public class RevertModelSnapshotRequestParameters : RequestParameters<RevertModelSnapshotRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for StartDatafeed<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-start-datafeed.html</pre></summary>
	public class StartDatafeedRequestParameters : RequestParameters<StartDatafeedRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for StopDatafeed<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-stop-datafeed.html</pre></summary>
	public class StopDatafeedRequestParameters : RequestParameters<StopDatafeedRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		///<summary>Whether to ignore if a wildcard expression matches no datafeeds. (This includes `_all` string or when no datafeeds have been specified)</summary>
		public bool? AllowNoDatafeeds
		{
			get => Q<bool? >("allow_no_datafeeds");
			set => Q("allow_no_datafeeds", value);
		}
	}

	///<summary>Request options for UpdateDatafeed<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-update-datafeed.html</pre></summary>
	public class UpdateDatafeedRequestParameters : RequestParameters<UpdateDatafeedRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for UpdateFilter<pre></pre></summary>
	public class UpdateFilterRequestParameters : RequestParameters<UpdateFilterRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for UpdateJob<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-update-job.html</pre></summary>
	public class UpdateJobRequestParameters : RequestParameters<UpdateJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for UpdateModelSnapshot<pre>http://www.elastic.co/guide/en/elasticsearch/reference/current/ml-update-snapshot.html</pre></summary>
	public class UpdateModelSnapshotRequestParameters : RequestParameters<UpdateModelSnapshotRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for ValidateJob<pre></pre></summary>
	public class ValidateJobRequestParameters : RequestParameters<ValidateJobRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for ValidateDetector<pre></pre></summary>
	public class ValidateDetectorRequestParameters : RequestParameters<ValidateDetectorRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}
}