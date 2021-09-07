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

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Slm
{
	public partial class Configuration
	{
		[JsonInclude]
		[JsonPropertyName("feature_states")]
		public IEnumerable<string>? FeatureStates { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_unavailable")]
		public bool? IgnoreUnavailable { get; set; }

		[JsonInclude]
		[JsonPropertyName("include_global_state")]
		public bool? IncludeGlobalState { get; set; }

		[JsonInclude]
		[JsonPropertyName("indices")]
		public Elastic.Clients.Elasticsearch.Indices Indices { get; set; }

		[JsonInclude]
		[JsonPropertyName("metadata")]
		public Elastic.Clients.Elasticsearch.Metadata? Metadata { get; set; }

		[JsonInclude]
		[JsonPropertyName("partial")]
		public bool? Partial { get; set; }
	}

	public partial class InProgress
	{
		[JsonInclude]
		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("start_time_millis")]
		public Elastic.Clients.Elasticsearch.DateString StartTimeMillis
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("state")]
		public string State
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("uuid")]
		public Elastic.Clients.Elasticsearch.Uuid Uuid
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Invocation
	{
		[JsonInclude]
		[JsonPropertyName("snapshot_name")]
		public Elastic.Clients.Elasticsearch.Name SnapshotName
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("time")]
		public Elastic.Clients.Elasticsearch.DateString Time
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Policy
	{
		[JsonInclude]
		[JsonPropertyName("config")]
		public Elastic.Clients.Elasticsearch.Slm.Configuration Config
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("repository")]
		public string Repository
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("retention")]
		public Elastic.Clients.Elasticsearch.Slm.Retention Retention
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("schedule")]
		public Elastic.Clients.Elasticsearch.Watcher.CronExpression Schedule
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Retention
	{
		[JsonInclude]
		[JsonPropertyName("expire_after")]
		public Elastic.Clients.Elasticsearch.Time ExpireAfter { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_count")]
		public int MaxCount { get; set; }

		[JsonInclude]
		[JsonPropertyName("min_count")]
		public int MinCount { get; set; }
	}

	public partial class SnapshotLifecycle
	{
		[JsonInclude]
		[JsonPropertyName("in_progress")]
		public Elastic.Clients.Elasticsearch.Slm.InProgress? InProgress
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("last_failure")]
		public Elastic.Clients.Elasticsearch.Slm.Invocation? LastFailure
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("last_success")]
		public Elastic.Clients.Elasticsearch.Slm.Invocation? LastSuccess
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("modified_date")]
		public Elastic.Clients.Elasticsearch.DateString? ModifiedDate
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("modified_date_millis")]
		public Elastic.Clients.Elasticsearch.EpochMillis ModifiedDateMillis
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("next_execution")]
		public Elastic.Clients.Elasticsearch.DateString? NextExecution
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("next_execution_millis")]
		public Elastic.Clients.Elasticsearch.EpochMillis NextExecutionMillis
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("policy")]
		public Elastic.Clients.Elasticsearch.Slm.Policy Policy
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("stats")]
		public Elastic.Clients.Elasticsearch.Slm.Statistics Stats
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("version")]
		public Elastic.Clients.Elasticsearch.VersionNumber Version
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Statistics
	{
		[JsonInclude]
		[JsonPropertyName("policy")]
		public Elastic.Clients.Elasticsearch.Id? Policy
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("retention_deletion_time")]
		public Elastic.Clients.Elasticsearch.DateString? RetentionDeletionTime
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("retention_deletion_time_millis")]
		public Elastic.Clients.Elasticsearch.EpochMillis? RetentionDeletionTimeMillis
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("retention_failed")]
		public long? RetentionFailed
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("retention_runs")]
		public long? RetentionRuns
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("retention_timed_out")]
		public long? RetentionTimedOut
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("total_snapshot_deletion_failures")]
		public long? TotalSnapshotDeletionFailures
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("total_snapshots_deleted")]
		public long? TotalSnapshotsDeleted
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("total_snapshots_failed")]
		public long? TotalSnapshotsFailed
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("total_snapshots_taken")]
		public long? TotalSnapshotsTaken
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}
}