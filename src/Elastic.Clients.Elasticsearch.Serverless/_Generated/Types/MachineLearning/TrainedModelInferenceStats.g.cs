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

#nullable restore

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class TrainedModelInferenceStats
{
	/// <summary>
	/// <para>The number of times the model was loaded for inference and was not retrieved from the cache.<br/>If this number is close to the `inference_count`, the cache is not being appropriately used.<br/>This can be solved by increasing the cache size or its time-to-live (TTL).<br/>Refer to general machine learning settings for the appropriate settings.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("cache_miss_count")]
	public int CacheMissCount { get; init; }

	/// <summary>
	/// <para>The number of failures when using the model for inference.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("failure_count")]
	public int FailureCount { get; init; }

	/// <summary>
	/// <para>The total number of times the model has been called for inference.<br/>This is across all inference contexts, including all pipelines.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("inference_count")]
	public int InferenceCount { get; init; }

	/// <summary>
	/// <para>The number of inference calls where all the training features for the model were missing.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("missing_all_fields_count")]
	public int MissingAllFieldsCount { get; init; }

	/// <summary>
	/// <para>The time when the statistics were last updated.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("timestamp")]
	public long Timestamp { get; init; }
}