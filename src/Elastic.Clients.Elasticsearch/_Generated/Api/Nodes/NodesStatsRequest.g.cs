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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Nodes;

public sealed partial class NodesStatsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Comma-separated list or wildcard expressions of fields to include in fielddata and suggest statistics.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Fields? CompletionFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("completion_fields"); set => Q("completion_fields", value); }

	/// <summary>
	/// <para>
	/// Comma-separated list or wildcard expressions of fields to include in fielddata statistics.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Fields? FielddataFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fielddata_fields"); set => Q("fielddata_fields", value); }

	/// <summary>
	/// <para>
	/// Comma-separated list or wildcard expressions of fields to include in the statistics.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fields"); set => Q("fields", value); }

	/// <summary>
	/// <para>
	/// Comma-separated list of search groups to include in the search statistics.
	/// </para>
	/// </summary>
	public bool? Groups { get => Q<bool?>("groups"); set => Q("groups", value); }

	/// <summary>
	/// <para>
	/// If true, the call reports the aggregated disk usage of each one of the Lucene index files (only applies if segment stats are requested).
	/// </para>
	/// </summary>
	public bool? IncludeSegmentFileSizes { get => Q<bool?>("include_segment_file_sizes"); set => Q("include_segment_file_sizes", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the response includes information from segments that are not loaded into memory.
	/// </para>
	/// </summary>
	public bool? IncludeUnloadedSegments { get => Q<bool?>("include_unloaded_segments"); set => Q("include_unloaded_segments", value); }

	/// <summary>
	/// <para>
	/// Indicates whether statistics are aggregated at the cluster, index, or shard level.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Level? Level { get => Q<Elastic.Clients.Elasticsearch.Level?>("level"); set => Q("level", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a response. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>
	/// A comma-separated list of document types for the indexing index metric.
	/// </para>
	/// </summary>
	public ICollection<string>? Types { get => Q<ICollection<string>?>("types"); set => Q("types", value); }
}

/// <summary>
/// <para>
/// Get node statistics.
/// Get statistics for nodes in a cluster.
/// By default, all stats are returned. You can limit the returned information by using metrics.
/// </para>
/// </summary>
public sealed partial class NodesStatsRequest : PlainRequest<NodesStatsRequestParameters>
{
	[JsonConstructor]
	public NodesStatsRequest()
	{
	}

	public NodesStatsRequest(Elastic.Clients.Elasticsearch.NodeIds? nodeId) : base(r => r.Optional("node_id", nodeId))
	{
	}

	public NodesStatsRequest(Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("metric", metric))
	{
	}

	public NodesStatsRequest(Elastic.Clients.Elasticsearch.NodeIds? nodeId, Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("node_id", nodeId).Optional("metric", metric))
	{
	}

	public NodesStatsRequest(Elastic.Clients.Elasticsearch.Metrics? metric, Elastic.Clients.Elasticsearch.Metrics? indexMetric) : base(r => r.Optional("metric", metric).Optional("index_metric", indexMetric))
	{
	}

	public NodesStatsRequest(Elastic.Clients.Elasticsearch.NodeIds? nodeId, Elastic.Clients.Elasticsearch.Metrics? metric, Elastic.Clients.Elasticsearch.Metrics? indexMetric) : base(r => r.Optional("node_id", nodeId).Optional("metric", metric).Optional("index_metric", indexMetric))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NodesStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "nodes.stats";

	/// <summary>
	/// <para>
	/// Limit the information returned for indices metric to the specific index metrics. It can be used only if indices (or all) metric is specified.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Metrics? IndexMetric { get => P<Elastic.Clients.Elasticsearch.Metrics?>("index_metric"); set => PO("index_metric", value); }

	/// <summary>
	/// <para>
	/// Limit the information returned to the specified metrics
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Metrics? Metric { get => P<Elastic.Clients.Elasticsearch.Metrics?>("metric"); set => PO("metric", value); }

	/// <summary>
	/// <para>
	/// Comma-separated list of node IDs or names used to limit returned information.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.NodeIds? NodeId { get => P<Elastic.Clients.Elasticsearch.NodeIds?>("node_id"); set => PO("node_id", value); }

	/// <summary>
	/// <para>
	/// Comma-separated list or wildcard expressions of fields to include in fielddata and suggest statistics.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Fields? CompletionFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("completion_fields"); set => Q("completion_fields", value); }

	/// <summary>
	/// <para>
	/// Comma-separated list or wildcard expressions of fields to include in fielddata statistics.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Fields? FielddataFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fielddata_fields"); set => Q("fielddata_fields", value); }

	/// <summary>
	/// <para>
	/// Comma-separated list or wildcard expressions of fields to include in the statistics.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fields"); set => Q("fields", value); }

	/// <summary>
	/// <para>
	/// Comma-separated list of search groups to include in the search statistics.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? Groups { get => Q<bool?>("groups"); set => Q("groups", value); }

	/// <summary>
	/// <para>
	/// If true, the call reports the aggregated disk usage of each one of the Lucene index files (only applies if segment stats are requested).
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? IncludeSegmentFileSizes { get => Q<bool?>("include_segment_file_sizes"); set => Q("include_segment_file_sizes", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the response includes information from segments that are not loaded into memory.
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
	public Elastic.Clients.Elasticsearch.Level? Level { get => Q<Elastic.Clients.Elasticsearch.Level?>("level"); set => Q("level", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a response. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>
	/// A comma-separated list of document types for the indexing index metric.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public ICollection<string>? Types { get => Q<ICollection<string>?>("types"); set => Q("types", value); }
}

/// <summary>
/// <para>
/// Get node statistics.
/// Get statistics for nodes in a cluster.
/// By default, all stats are returned. You can limit the returned information by using metrics.
/// </para>
/// </summary>
public sealed partial class NodesStatsRequestDescriptor<TDocument> : RequestDescriptor<NodesStatsRequestDescriptor<TDocument>, NodesStatsRequestParameters>
{
	internal NodesStatsRequestDescriptor(Action<NodesStatsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public NodesStatsRequestDescriptor(Elastic.Clients.Elasticsearch.NodeIds? nodeId, Elastic.Clients.Elasticsearch.Metrics? metric, Elastic.Clients.Elasticsearch.Metrics? indexMetric) : base(r => r.Optional("node_id", nodeId).Optional("metric", metric).Optional("index_metric", indexMetric))
	{
	}

	public NodesStatsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NodesStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "nodes.stats";

	public NodesStatsRequestDescriptor<TDocument> CompletionFields(Elastic.Clients.Elasticsearch.Fields? completionFields) => Qs("completion_fields", completionFields);
	public NodesStatsRequestDescriptor<TDocument> FielddataFields(Elastic.Clients.Elasticsearch.Fields? fielddataFields) => Qs("fielddata_fields", fielddataFields);
	public NodesStatsRequestDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields? fields) => Qs("fields", fields);
	public NodesStatsRequestDescriptor<TDocument> Groups(bool? groups = true) => Qs("groups", groups);
	public NodesStatsRequestDescriptor<TDocument> IncludeSegmentFileSizes(bool? includeSegmentFileSizes = true) => Qs("include_segment_file_sizes", includeSegmentFileSizes);
	public NodesStatsRequestDescriptor<TDocument> IncludeUnloadedSegments(bool? includeUnloadedSegments = true) => Qs("include_unloaded_segments", includeUnloadedSegments);
	public NodesStatsRequestDescriptor<TDocument> Level(Elastic.Clients.Elasticsearch.Level? level) => Qs("level", level);
	public NodesStatsRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public NodesStatsRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public NodesStatsRequestDescriptor<TDocument> Types(ICollection<string>? types) => Qs("types", types);

	public NodesStatsRequestDescriptor<TDocument> IndexMetric(Elastic.Clients.Elasticsearch.Metrics? indexMetric)
	{
		RouteValues.Optional("index_metric", indexMetric);
		return Self;
	}

	public NodesStatsRequestDescriptor<TDocument> Metric(Elastic.Clients.Elasticsearch.Metrics? metric)
	{
		RouteValues.Optional("metric", metric);
		return Self;
	}

	public NodesStatsRequestDescriptor<TDocument> NodeId(Elastic.Clients.Elasticsearch.NodeIds? nodeId)
	{
		RouteValues.Optional("node_id", nodeId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>
/// Get node statistics.
/// Get statistics for nodes in a cluster.
/// By default, all stats are returned. You can limit the returned information by using metrics.
/// </para>
/// </summary>
public sealed partial class NodesStatsRequestDescriptor : RequestDescriptor<NodesStatsRequestDescriptor, NodesStatsRequestParameters>
{
	internal NodesStatsRequestDescriptor(Action<NodesStatsRequestDescriptor> configure) => configure.Invoke(this);

	public NodesStatsRequestDescriptor(Elastic.Clients.Elasticsearch.NodeIds? nodeId, Elastic.Clients.Elasticsearch.Metrics? metric, Elastic.Clients.Elasticsearch.Metrics? indexMetric) : base(r => r.Optional("node_id", nodeId).Optional("metric", metric).Optional("index_metric", indexMetric))
	{
	}

	public NodesStatsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NodesStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "nodes.stats";

	public NodesStatsRequestDescriptor CompletionFields(Elastic.Clients.Elasticsearch.Fields? completionFields) => Qs("completion_fields", completionFields);
	public NodesStatsRequestDescriptor FielddataFields(Elastic.Clients.Elasticsearch.Fields? fielddataFields) => Qs("fielddata_fields", fielddataFields);
	public NodesStatsRequestDescriptor Fields(Elastic.Clients.Elasticsearch.Fields? fields) => Qs("fields", fields);
	public NodesStatsRequestDescriptor Groups(bool? groups = true) => Qs("groups", groups);
	public NodesStatsRequestDescriptor IncludeSegmentFileSizes(bool? includeSegmentFileSizes = true) => Qs("include_segment_file_sizes", includeSegmentFileSizes);
	public NodesStatsRequestDescriptor IncludeUnloadedSegments(bool? includeUnloadedSegments = true) => Qs("include_unloaded_segments", includeUnloadedSegments);
	public NodesStatsRequestDescriptor Level(Elastic.Clients.Elasticsearch.Level? level) => Qs("level", level);
	public NodesStatsRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public NodesStatsRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public NodesStatsRequestDescriptor Types(ICollection<string>? types) => Qs("types", types);

	public NodesStatsRequestDescriptor IndexMetric(Elastic.Clients.Elasticsearch.Metrics? indexMetric)
	{
		RouteValues.Optional("index_metric", indexMetric);
		return Self;
	}

	public NodesStatsRequestDescriptor Metric(Elastic.Clients.Elasticsearch.Metrics? metric)
	{
		RouteValues.Optional("metric", metric);
		return Self;
	}

	public NodesStatsRequestDescriptor NodeId(Elastic.Clients.Elasticsearch.NodeIds? nodeId)
	{
		RouteValues.Optional("node_id", nodeId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}