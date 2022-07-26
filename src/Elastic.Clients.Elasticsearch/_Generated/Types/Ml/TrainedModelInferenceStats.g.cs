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
	public sealed partial class TrainedModelInferenceStats
	{
		[JsonInclude]
		[JsonPropertyName("cache_miss_count")]
		public int CacheMissCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("failure_count")]
		public int FailureCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("inference_count")]
		public int InferenceCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("missing_all_fields_count")]
		public int MissingAllFieldsCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("timestamp")]
		public DateTimeOffset Timestamp { get; init; }
	}
}