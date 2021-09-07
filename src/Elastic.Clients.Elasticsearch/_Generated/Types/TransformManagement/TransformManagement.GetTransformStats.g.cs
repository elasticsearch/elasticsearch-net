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
namespace Elastic.Clients.Elasticsearch.TransformManagement.GetTransformStats
{
	public partial class CheckpointStats
	{
		[JsonPropertyName("checkpoint")]
		public long Checkpoint
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("checkpoint_progress")]
		public Elastic.Clients.Elasticsearch.TransformManagement.GetTransformStats.TransformProgress? CheckpointProgress
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("timestamp")]
		public Elastic.Clients.Elasticsearch.DateString? Timestamp
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("timestamp_millis")]
		public Elastic.Clients.Elasticsearch.EpochMillis TimestampMillis
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("time_upper_bound")]
		public Elastic.Clients.Elasticsearch.DateString? TimeUpperBound
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("time_upper_bound_millis")]
		public Elastic.Clients.Elasticsearch.EpochMillis? TimeUpperBoundMillis
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Checkpointing
	{
		[JsonPropertyName("changes_last_detected_at")]
		public long ChangesLastDetectedAt
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("changes_last_detected_at_date_time")]
		public Elastic.Clients.Elasticsearch.DateString? ChangesLastDetectedAtDateTime
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("last")]
		public Elastic.Clients.Elasticsearch.TransformManagement.GetTransformStats.CheckpointStats Last
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("next")]
		public Elastic.Clients.Elasticsearch.TransformManagement.GetTransformStats.CheckpointStats? Next
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("operations_behind")]
		public long? OperationsBehind
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class TransformIndexerStats
	{
		[JsonPropertyName("documents_indexed")]
		public long DocumentsIndexed
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("documents_processed")]
		public long DocumentsProcessed
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("exponential_avg_checkpoint_duration_ms")]
		public double ExponentialAvgCheckpointDurationMs
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("exponential_avg_documents_indexed")]
		public double ExponentialAvgDocumentsIndexed
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("exponential_avg_documents_processed")]
		public double ExponentialAvgDocumentsProcessed
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("index_failures")]
		public long IndexFailures
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("index_time_in_ms")]
		public long IndexTimeInMs
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("index_total")]
		public long IndexTotal
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("pages_processed")]
		public long PagesProcessed
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("processing_time_in_ms")]
		public long ProcessingTimeInMs
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("processing_total")]
		public long ProcessingTotal
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("search_failures")]
		public long SearchFailures
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("search_time_in_ms")]
		public long SearchTimeInMs
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("search_total")]
		public long SearchTotal
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("trigger_count")]
		public long TriggerCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class TransformProgress
	{
		[JsonPropertyName("docs_indexed")]
		public long DocsIndexed
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("docs_processed")]
		public long DocsProcessed
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("docs_remaining")]
		public long DocsRemaining
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("percent_complete")]
		public double PercentComplete
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total_docs")]
		public long TotalDocs
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class TransformStats
	{
		[JsonPropertyName("checkpointing")]
		public Elastic.Clients.Elasticsearch.TransformManagement.GetTransformStats.Checkpointing Checkpointing
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("id")]
		public Elastic.Clients.Elasticsearch.Id Id
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("node")]
		public Elastic.Clients.Elasticsearch.NodeAttributes? Node
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("reason")]
		public string? Reason
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

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

		[JsonPropertyName("stats")]
		public Elastic.Clients.Elasticsearch.TransformManagement.GetTransformStats.TransformIndexerStats Stats
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