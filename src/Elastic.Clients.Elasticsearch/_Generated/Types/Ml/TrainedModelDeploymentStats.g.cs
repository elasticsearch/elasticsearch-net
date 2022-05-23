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
namespace Elastic.Clients.Elasticsearch.Ml
{
	public partial class TrainedModelDeploymentStats
	{
		[JsonInclude]
		[JsonPropertyName("allocation_status")]
		public Elastic.Clients.Elasticsearch.Ml.TrainedModelDeploymentAllocationStatus AllocationStatus { get; init; }

		[JsonInclude]
		[JsonPropertyName("error_count")]
		public int ErrorCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("inference_count")]
		public int InferenceCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("inference_threads")]
		public int InferenceThreads { get; init; }

		[JsonInclude]
		[JsonPropertyName("model_id")]
		public string ModelId { get; init; }

		[JsonInclude]
		[JsonPropertyName("model_threads")]
		public int ModelThreads { get; init; }

		[JsonInclude]
		[JsonPropertyName("nodes")]
		public Elastic.Clients.Elasticsearch.Ml.TrainedModelDeploymentNodesStats Nodes { get; init; }

		[JsonInclude]
		[JsonPropertyName("queue_capacity")]
		public int QueueCapacity { get; init; }

		[JsonInclude]
		[JsonPropertyName("reason")]
		public string Reason { get; init; }

		[JsonInclude]
		[JsonPropertyName("rejected_execution_count")]
		public int RejectedExecutionCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("start_time")]
		public long StartTime { get; init; }

		[JsonInclude]
		[JsonPropertyName("state")]
		public Elastic.Clients.Elasticsearch.Ml.DeploymentState State { get; init; }

		[JsonInclude]
		[JsonPropertyName("timeout_count")]
		public int TimeoutCount { get; init; }
	}
}