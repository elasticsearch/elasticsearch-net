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

public sealed partial class NodesUsageRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Period to wait for a response.
	/// If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Get feature usage information.
/// </para>
/// </summary>
public sealed partial class NodesUsageRequest : PlainRequest<NodesUsageRequestParameters>
{
	public NodesUsageRequest()
	{
	}

	public NodesUsageRequest(Elastic.Clients.Elasticsearch.Serverless.NodeIds? nodeId) : base(r => r.Optional("node_id", nodeId))
	{
	}

	public NodesUsageRequest(Elastic.Clients.Elasticsearch.Serverless.Metrics? metric) : base(r => r.Optional("metric", metric))
	{
	}

	public NodesUsageRequest(Elastic.Clients.Elasticsearch.Serverless.NodeIds? nodeId, Elastic.Clients.Elasticsearch.Serverless.Metrics? metric) : base(r => r.Optional("node_id", nodeId).Optional("metric", metric))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NodesUsage;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "nodes.usage";

	/// <summary>
	/// <para>
	/// Period to wait for a response.
	/// If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Get feature usage information.
/// </para>
/// </summary>
public sealed partial class NodesUsageRequestDescriptor : RequestDescriptor<NodesUsageRequestDescriptor, NodesUsageRequestParameters>
{
	internal NodesUsageRequestDescriptor(Action<NodesUsageRequestDescriptor> configure) => configure.Invoke(this);

	public NodesUsageRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.NodeIds? nodeId, Elastic.Clients.Elasticsearch.Serverless.Metrics? metric) : base(r => r.Optional("node_id", nodeId).Optional("metric", metric))
	{
	}

	public NodesUsageRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NodesUsage;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "nodes.usage";

	public NodesUsageRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout) => Qs("timeout", timeout);

	public NodesUsageRequestDescriptor Metric(Elastic.Clients.Elasticsearch.Serverless.Metrics? metric)
	{
		RouteValues.Optional("metric", metric);
		return Self;
	}

	public NodesUsageRequestDescriptor NodeId(Elastic.Clients.Elasticsearch.Serverless.NodeIds? nodeId)
	{
		RouteValues.Optional("node_id", nodeId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}