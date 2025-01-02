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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class Limits
{
	[JsonInclude, JsonPropertyName("effective_max_model_memory_limit")]
	public Elastic.Clients.Elasticsearch.ByteSize? EffectiveMaxModelMemoryLimit { get; init; }
	[JsonInclude, JsonPropertyName("max_model_memory_limit")]
	public Elastic.Clients.Elasticsearch.ByteSize? MaxModelMemoryLimit { get; init; }
	[JsonInclude, JsonPropertyName("max_single_ml_node_processors")]
	public int? MaxSingleMlNodeProcessors { get; init; }
	[JsonInclude, JsonPropertyName("total_ml_memory")]
	public Elastic.Clients.Elasticsearch.ByteSize TotalMlMemory { get; init; }
	[JsonInclude, JsonPropertyName("total_ml_processors")]
	public int? TotalMlProcessors { get; init; }
}