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
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class IndicesStatsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Comma-separated list or wildcard expressions of fields to include in fielddata and suggest statistics.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Fields? CompletionFields { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("completion_fields"); set => Q("completion_fields", value); }

	/// <summary>
	/// <para>
	/// Type of index that wildcard patterns can match. If the request can target data streams, this argument
	/// determines whether wildcard expressions match hidden data streams. Supports comma-separated values,
	/// such as <c>open,hidden</c>.
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>
	/// Comma-separated list or wildcard expressions of fields to include in fielddata statistics.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Fields? FielddataFields { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("fielddata_fields"); set => Q("fielddata_fields", value); }

	/// <summary>
	/// <para>
	/// Comma-separated list or wildcard expressions of fields to include in the statistics.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("fields"); set => Q("fields", value); }

	/// <summary>
	/// <para>
	/// If true, statistics are not collected from closed indices.
	/// </para>
	/// </summary>
	public bool? ForbidClosedIndices { get => Q<bool?>("forbid_closed_indices"); set => Q("forbid_closed_indices", value); }

	/// <summary>
	/// <para>
	/// Comma-separated list of search groups to include in the search statistics.
	/// </para>
	/// </summary>
	public ICollection<string>? Groups { get => Q<ICollection<string>?>("groups"); set => Q("groups", value); }

	/// <summary>
	/// <para>
	/// If true, the call reports the aggregated disk usage of each one of the Lucene index files (only applies if segment stats are requested).
	/// </para>
	/// </summary>
	public bool? IncludeSegmentFileSizes { get => Q<bool?>("include_segment_file_sizes"); set => Q("include_segment_file_sizes", value); }

	/// <summary>
	/// <para>
	/// If true, the response includes information from segments that are not loaded into memory.
	/// </para>
	/// </summary>
	public bool? IncludeUnloadedSegments { get => Q<bool?>("include_unloaded_segments"); set => Q("include_unloaded_segments", value); }

	/// <summary>
	/// <para>
	/// Indicates whether statistics are aggregated at the cluster, index, or shard level.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Level? Level { get => Q<Elastic.Clients.Elasticsearch.Serverless.Level?>("level"); set => Q("level", value); }
}

/// <summary>
/// <para>
/// Get index statistics.
/// For data streams, the API retrieves statistics for the stream's backing indices.
/// </para>
/// <para>
/// By default, the returned statistics are index-level with <c>primaries</c> and <c>total</c> aggregations.
/// <c>primaries</c> are the values for only the primary shards.
/// <c>total</c> are the accumulated values for both primary and replica shards.
/// </para>
/// <para>
/// To get shard-level statistics, set the <c>level</c> parameter to <c>shards</c>.
/// </para>
/// <para>
/// NOTE: When moving to another node, the shard-level statistics for a shard are cleared.
/// Although the shard is no longer part of the node, that node retains any node-level statistics to which the shard contributed.
/// </para>
/// </summary>
public sealed partial class IndicesStatsRequest : PlainRequest<IndicesStatsRequestParameters>
{
	public IndicesStatsRequest()
	{
	}

	public IndicesStatsRequest(Elastic.Clients.Elasticsearch.Serverless.Metrics? metric) : base(r => r.Optional("metric", metric))
	{
	}

	public IndicesStatsRequest(Elastic.Clients.Elasticsearch.Serverless.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	public IndicesStatsRequest(Elastic.Clients.Elasticsearch.Serverless.Indices? indices, Elastic.Clients.Elasticsearch.Serverless.Metrics? metric) : base(r => r.Optional("index", indices).Optional("metric", metric))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.stats";

	/// <summary>
	/// <para>
	/// Comma-separated list or wildcard expressions of fields to include in fielddata and suggest statistics.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? CompletionFields { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("completion_fields"); set => Q("completion_fields", value); }

	/// <summary>
	/// <para>
	/// Type of index that wildcard patterns can match. If the request can target data streams, this argument
	/// determines whether wildcard expressions match hidden data streams. Supports comma-separated values,
	/// such as <c>open,hidden</c>.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>
	/// Comma-separated list or wildcard expressions of fields to include in fielddata statistics.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? FielddataFields { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("fielddata_fields"); set => Q("fielddata_fields", value); }

	/// <summary>
	/// <para>
	/// Comma-separated list or wildcard expressions of fields to include in the statistics.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("fields"); set => Q("fields", value); }

	/// <summary>
	/// <para>
	/// If true, statistics are not collected from closed indices.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? ForbidClosedIndices { get => Q<bool?>("forbid_closed_indices"); set => Q("forbid_closed_indices", value); }

	/// <summary>
	/// <para>
	/// Comma-separated list of search groups to include in the search statistics.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public ICollection<string>? Groups { get => Q<ICollection<string>?>("groups"); set => Q("groups", value); }

	/// <summary>
	/// <para>
	/// If true, the call reports the aggregated disk usage of each one of the Lucene index files (only applies if segment stats are requested).
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? IncludeSegmentFileSizes { get => Q<bool?>("include_segment_file_sizes"); set => Q("include_segment_file_sizes", value); }

	/// <summary>
	/// <para>
	/// If true, the response includes information from segments that are not loaded into memory.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? IncludeUnloadedSegments { get => Q<bool?>("include_unloaded_segments"); set => Q("include_unloaded_segments", value); }

	/// <summary>
	/// <para>
	/// Indicates whether statistics are aggregated at the cluster, index, or shard level.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Level? Level { get => Q<Elastic.Clients.Elasticsearch.Serverless.Level?>("level"); set => Q("level", value); }
}

/// <summary>
/// <para>
/// Get index statistics.
/// For data streams, the API retrieves statistics for the stream's backing indices.
/// </para>
/// <para>
/// By default, the returned statistics are index-level with <c>primaries</c> and <c>total</c> aggregations.
/// <c>primaries</c> are the values for only the primary shards.
/// <c>total</c> are the accumulated values for both primary and replica shards.
/// </para>
/// <para>
/// To get shard-level statistics, set the <c>level</c> parameter to <c>shards</c>.
/// </para>
/// <para>
/// NOTE: When moving to another node, the shard-level statistics for a shard are cleared.
/// Although the shard is no longer part of the node, that node retains any node-level statistics to which the shard contributed.
/// </para>
/// </summary>
public sealed partial class IndicesStatsRequestDescriptor<TDocument> : RequestDescriptor<IndicesStatsRequestDescriptor<TDocument>, IndicesStatsRequestParameters>
{
	internal IndicesStatsRequestDescriptor(Action<IndicesStatsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public IndicesStatsRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Indices? indices, Elastic.Clients.Elasticsearch.Serverless.Metrics? metric) : base(r => r.Optional("index", indices).Optional("metric", metric))
	{
	}

	public IndicesStatsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.stats";

	public IndicesStatsRequestDescriptor<TDocument> CompletionFields(Elastic.Clients.Elasticsearch.Serverless.Fields? completionFields) => Qs("completion_fields", completionFields);
	public IndicesStatsRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public IndicesStatsRequestDescriptor<TDocument> FielddataFields(Elastic.Clients.Elasticsearch.Serverless.Fields? fielddataFields) => Qs("fielddata_fields", fielddataFields);
	public IndicesStatsRequestDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Serverless.Fields? fields) => Qs("fields", fields);
	public IndicesStatsRequestDescriptor<TDocument> ForbidClosedIndices(bool? forbidClosedIndices = true) => Qs("forbid_closed_indices", forbidClosedIndices);
	public IndicesStatsRequestDescriptor<TDocument> Groups(ICollection<string>? groups) => Qs("groups", groups);
	public IndicesStatsRequestDescriptor<TDocument> IncludeSegmentFileSizes(bool? includeSegmentFileSizes = true) => Qs("include_segment_file_sizes", includeSegmentFileSizes);
	public IndicesStatsRequestDescriptor<TDocument> IncludeUnloadedSegments(bool? includeUnloadedSegments = true) => Qs("include_unloaded_segments", includeUnloadedSegments);
	public IndicesStatsRequestDescriptor<TDocument> Level(Elastic.Clients.Elasticsearch.Serverless.Level? level) => Qs("level", level);

	public IndicesStatsRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Serverless.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	public IndicesStatsRequestDescriptor<TDocument> Metric(Elastic.Clients.Elasticsearch.Serverless.Metrics? metric)
	{
		RouteValues.Optional("metric", metric);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>
/// Get index statistics.
/// For data streams, the API retrieves statistics for the stream's backing indices.
/// </para>
/// <para>
/// By default, the returned statistics are index-level with <c>primaries</c> and <c>total</c> aggregations.
/// <c>primaries</c> are the values for only the primary shards.
/// <c>total</c> are the accumulated values for both primary and replica shards.
/// </para>
/// <para>
/// To get shard-level statistics, set the <c>level</c> parameter to <c>shards</c>.
/// </para>
/// <para>
/// NOTE: When moving to another node, the shard-level statistics for a shard are cleared.
/// Although the shard is no longer part of the node, that node retains any node-level statistics to which the shard contributed.
/// </para>
/// </summary>
public sealed partial class IndicesStatsRequestDescriptor : RequestDescriptor<IndicesStatsRequestDescriptor, IndicesStatsRequestParameters>
{
	internal IndicesStatsRequestDescriptor(Action<IndicesStatsRequestDescriptor> configure) => configure.Invoke(this);

	public IndicesStatsRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Indices? indices, Elastic.Clients.Elasticsearch.Serverless.Metrics? metric) : base(r => r.Optional("index", indices).Optional("metric", metric))
	{
	}

	public IndicesStatsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.stats";

	public IndicesStatsRequestDescriptor CompletionFields(Elastic.Clients.Elasticsearch.Serverless.Fields? completionFields) => Qs("completion_fields", completionFields);
	public IndicesStatsRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public IndicesStatsRequestDescriptor FielddataFields(Elastic.Clients.Elasticsearch.Serverless.Fields? fielddataFields) => Qs("fielddata_fields", fielddataFields);
	public IndicesStatsRequestDescriptor Fields(Elastic.Clients.Elasticsearch.Serverless.Fields? fields) => Qs("fields", fields);
	public IndicesStatsRequestDescriptor ForbidClosedIndices(bool? forbidClosedIndices = true) => Qs("forbid_closed_indices", forbidClosedIndices);
	public IndicesStatsRequestDescriptor Groups(ICollection<string>? groups) => Qs("groups", groups);
	public IndicesStatsRequestDescriptor IncludeSegmentFileSizes(bool? includeSegmentFileSizes = true) => Qs("include_segment_file_sizes", includeSegmentFileSizes);
	public IndicesStatsRequestDescriptor IncludeUnloadedSegments(bool? includeUnloadedSegments = true) => Qs("include_unloaded_segments", includeUnloadedSegments);
	public IndicesStatsRequestDescriptor Level(Elastic.Clients.Elasticsearch.Serverless.Level? level) => Qs("level", level);

	public IndicesStatsRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Serverless.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	public IndicesStatsRequestDescriptor Metric(Elastic.Clients.Elasticsearch.Serverless.Metrics? metric)
	{
		RouteValues.Optional("metric", metric);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}