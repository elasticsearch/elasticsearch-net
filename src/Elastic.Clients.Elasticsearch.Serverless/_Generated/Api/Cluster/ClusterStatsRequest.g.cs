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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Cluster;

public sealed partial class ClusterStatsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If `true`, returns settings in flat format.</para>
	/// </summary>
	public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

	/// <summary>
	/// <para>Period to wait for each node to respond.<br/>If a node does not respond before its timeout expires, the response does not include its stats.<br/>However, timed out nodes are included in the response’s `_nodes.failed` property. Defaults to no timeout.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>Returns cluster statistics.<br/>It returns basic index metrics (shard numbers, store size, memory usage) and information about the current nodes that form the cluster (number, roles, os, jvm versions, memory usage, cpu and installed plugins).</para>
/// </summary>
public sealed partial class ClusterStatsRequest : PlainRequest<ClusterStatsRequestParameters>
{
	public ClusterStatsRequest()
	{
	}

	public ClusterStatsRequest(Elastic.Clients.Elasticsearch.Serverless.NodeIds? nodeId) : base(r => r.Optional("node_id", nodeId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.ClusterStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "cluster.stats";

	/// <summary>
	/// <para>If `true`, returns settings in flat format.</para>
	/// </summary>
	[JsonIgnore]
	public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

	/// <summary>
	/// <para>Period to wait for each node to respond.<br/>If a node does not respond before its timeout expires, the response does not include its stats.<br/>However, timed out nodes are included in the response’s `_nodes.failed` property. Defaults to no timeout.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>Returns cluster statistics.<br/>It returns basic index metrics (shard numbers, store size, memory usage) and information about the current nodes that form the cluster (number, roles, os, jvm versions, memory usage, cpu and installed plugins).</para>
/// </summary>
public sealed partial class ClusterStatsRequestDescriptor : RequestDescriptor<ClusterStatsRequestDescriptor, ClusterStatsRequestParameters>
{
	internal ClusterStatsRequestDescriptor(Action<ClusterStatsRequestDescriptor> configure) => configure.Invoke(this);

	public ClusterStatsRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.NodeIds? nodeId) : base(r => r.Optional("node_id", nodeId))
	{
	}

	public ClusterStatsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.ClusterStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "cluster.stats";

	public ClusterStatsRequestDescriptor FlatSettings(bool? flatSettings = true) => Qs("flat_settings", flatSettings);
	public ClusterStatsRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout) => Qs("timeout", timeout);

	public ClusterStatsRequestDescriptor NodeId(Elastic.Clients.Elasticsearch.Serverless.NodeIds? nodeId)
	{
		RouteValues.Optional("node_id", nodeId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}