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
using Elastic.Transport.Products.Elasticsearch;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch;

public sealed partial class SearchTemplateResponse<TDocument> : ElasticsearchResponse
{
	[JsonInclude, JsonPropertyName("aggregations")]
	public Elastic.Clients.Elasticsearch.Aggregations.AggregateDictionary? Aggregations { get; init; }
	[JsonInclude, JsonPropertyName("_clusters")]
	public Elastic.Clients.Elasticsearch.ClusterStatistics? Clusters { get; init; }
	[JsonInclude, JsonPropertyName("fields")]
	public IReadOnlyDictionary<string, object>? Fields { get; init; }
	[JsonInclude, JsonPropertyName("hits")]
	public Elastic.Clients.Elasticsearch.Core.Search.HitsMetadata<TDocument> Hits { get; init; }
	[JsonInclude, JsonPropertyName("max_score")]
	public double? MaxScore { get; init; }
	[JsonInclude, JsonPropertyName("num_reduce_phases")]
	public long? NumReducePhases { get; init; }
	[JsonInclude, JsonPropertyName("pit_id")]
	public string? PitId { get; init; }
	[JsonInclude, JsonPropertyName("profile")]
	public Elastic.Clients.Elasticsearch.Core.Search.Profile? Profile { get; init; }
	[JsonInclude, JsonPropertyName("_scroll_id")]
	public Elastic.Clients.Elasticsearch.ScrollId? ScrollId { get; init; }
	[JsonInclude, JsonPropertyName("_shards")]
	public Elastic.Clients.Elasticsearch.ShardStatistics Shards { get; init; }
	[JsonInclude, JsonPropertyName("terminated_early")]
	public bool? TerminatedEarly { get; init; }
	[JsonInclude, JsonPropertyName("timed_out")]
	public bool TimedOut { get; init; }
	[JsonInclude, JsonPropertyName("took")]
	public long Took { get; init; }
}