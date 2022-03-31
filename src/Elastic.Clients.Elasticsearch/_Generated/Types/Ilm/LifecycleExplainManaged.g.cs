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
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ilm.ExplainLifecycle
{
	public partial class LifecycleExplainManaged : ILifecycleExplain
	{
		[JsonInclude]
		[JsonPropertyName("action")]
		public string Action { get; init; }

		[JsonInclude]
		[JsonPropertyName("action_time_millis")]
		public Elastic.Clients.Elasticsearch.EpochMillis ActionTimeMillis { get; init; }

		[JsonInclude]
		[JsonPropertyName("age")]
		public Elastic.Clients.Elasticsearch.Time Age { get; init; }

		[JsonInclude]
		[JsonPropertyName("failed_step")]
		public string? FailedStep { get; init; }

		[JsonInclude]
		[JsonPropertyName("failed_step_retry_count")]
		public int? FailedStepRetryCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public string Index { get; init; }

		[JsonInclude]
		[JsonPropertyName("index_creation_date_millis")]
		public Elastic.Clients.Elasticsearch.EpochMillis? IndexCreationDateMillis { get; init; }

		[JsonInclude]
		[JsonPropertyName("is_auto_retryable_error")]
		public bool? IsAutoRetryableError { get; init; }

		[JsonInclude]
		[JsonPropertyName("lifecycle_date_millis")]
		public Elastic.Clients.Elasticsearch.EpochMillis LifecycleDateMillis { get; init; }

		[JsonInclude]
		[JsonPropertyName("managed")]
		public bool Managed => true;
		[JsonInclude]
		[JsonPropertyName("phase")]
		public string Phase { get; init; }

		[JsonInclude]
		[JsonPropertyName("phase_execution")]
		public Elastic.Clients.Elasticsearch.Ilm.ExplainLifecycle.LifecycleExplainPhaseExecution PhaseExecution { get; init; }

		[JsonInclude]
		[JsonPropertyName("phase_time_millis")]
		public Elastic.Clients.Elasticsearch.EpochMillis PhaseTimeMillis { get; init; }

		[JsonInclude]
		[JsonPropertyName("policy")]
		public string Policy { get; init; }

		[JsonInclude]
		[JsonPropertyName("step")]
		public string Step { get; init; }

		[JsonInclude]
		[JsonPropertyName("step_info")]
		public Dictionary<string, object>? StepInfo { get; init; }

		[JsonInclude]
		[JsonPropertyName("step_time_millis")]
		public Elastic.Clients.Elasticsearch.EpochMillis StepTimeMillis { get; init; }

		[JsonInclude]
		[JsonPropertyName("time_since_index_creation")]
		public Elastic.Clients.Elasticsearch.Time? TimeSinceIndexCreation { get; init; }
	}
}