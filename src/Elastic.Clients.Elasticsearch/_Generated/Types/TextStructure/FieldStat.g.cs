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

namespace Elastic.Clients.Elasticsearch.TextStructure;

public sealed partial class FieldStat
{
	[JsonInclude, JsonPropertyName("cardinality")]
	public int Cardinality { get; init; }
	[JsonInclude, JsonPropertyName("count")]
	public int Count { get; init; }
	[JsonInclude, JsonPropertyName("earliest")]
	public string? Earliest { get; init; }
	[JsonInclude, JsonPropertyName("latest")]
	public string? Latest { get; init; }
	[JsonInclude, JsonPropertyName("max_value")]
	public int? MaxValue { get; init; }
	[JsonInclude, JsonPropertyName("mean_value")]
	public int? MeanValue { get; init; }
	[JsonInclude, JsonPropertyName("median_value")]
	public int? MedianValue { get; init; }
	[JsonInclude, JsonPropertyName("min_value")]
	public int? MinValue { get; init; }
	[JsonInclude, JsonPropertyName("top_hits")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.TextStructure.TopHit> TopHits { get; init; }
}