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

namespace Elastic.Clients.Elasticsearch.Serverless.Nodes;

public sealed partial class NodesInfoRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If true, returns settings in flat format.
	/// </para>
	/// </summary>
	public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a response. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Returns cluster nodes information.
/// </para>
/// </summary>
public sealed partial class NodesInfoRequest : PlainRequest<NodesInfoRequestParameters>
{
	public NodesInfoRequest()
	{
	}

	public NodesInfoRequest(Elastic.Clients.Elasticsearch.Serverless.NodeIds? nodeId) : base(r => r.Optional("node_id", nodeId))
	{
	}

	public NodesInfoRequest(Elastic.Clients.Elasticsearch.Serverless.Metrics? metric) : base(r => r.Optional("metric", metric))
	{
	}

	public NodesInfoRequest(Elastic.Clients.Elasticsearch.Serverless.NodeIds? nodeId, Elastic.Clients.Elasticsearch.Serverless.Metrics? metric) : base(r => r.Optional("node_id", nodeId).Optional("metric", metric))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NodesInfo;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "nodes.info";

	/// <summary>
	/// <para>
	/// If true, returns settings in flat format.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a response. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Returns cluster nodes information.
/// </para>
/// </summary>
public sealed partial class NodesInfoRequestDescriptor : RequestDescriptor<NodesInfoRequestDescriptor, NodesInfoRequestParameters>
{
	internal NodesInfoRequestDescriptor(Action<NodesInfoRequestDescriptor> configure) => configure.Invoke(this);

	public NodesInfoRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.NodeIds? nodeId, Elastic.Clients.Elasticsearch.Serverless.Metrics? metric) : base(r => r.Optional("node_id", nodeId).Optional("metric", metric))
	{
	}

	public NodesInfoRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NodesInfo;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "nodes.info";

	public NodesInfoRequestDescriptor FlatSettings(bool? flatSettings = true) => Qs("flat_settings", flatSettings);
	public NodesInfoRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public NodesInfoRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout) => Qs("timeout", timeout);

	public NodesInfoRequestDescriptor Metric(Elastic.Clients.Elasticsearch.Serverless.Metrics? metric)
	{
		RouteValues.Optional("metric", metric);
		return Self;
	}

	public NodesInfoRequestDescriptor NodeId(Elastic.Clients.Elasticsearch.Serverless.NodeIds? nodeId)
	{
		RouteValues.Optional("node_id", nodeId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}