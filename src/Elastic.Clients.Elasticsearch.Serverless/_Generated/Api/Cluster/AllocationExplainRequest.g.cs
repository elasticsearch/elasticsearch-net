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

namespace Elastic.Clients.Elasticsearch.Serverless.Cluster;

public sealed partial class AllocationExplainRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If true, returns information about disk usage and shard sizes.
	/// </para>
	/// </summary>
	public bool? IncludeDiskInfo { get => Q<bool?>("include_disk_info"); set => Q("include_disk_info", value); }

	/// <summary>
	/// <para>
	/// If true, returns YES decisions in explanation.
	/// </para>
	/// </summary>
	public bool? IncludeYesDecisions { get => Q<bool?>("include_yes_decisions"); set => Q("include_yes_decisions", value); }
}

/// <summary>
/// <para>
/// Provides explanations for shard allocations in the cluster.
/// </para>
/// </summary>
public sealed partial class AllocationExplainRequest : PlainRequest<AllocationExplainRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.ClusterAllocationExplain;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "cluster.allocation_explain";

	/// <summary>
	/// <para>
	/// If true, returns information about disk usage and shard sizes.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? IncludeDiskInfo { get => Q<bool?>("include_disk_info"); set => Q("include_disk_info", value); }

	/// <summary>
	/// <para>
	/// If true, returns YES decisions in explanation.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? IncludeYesDecisions { get => Q<bool?>("include_yes_decisions"); set => Q("include_yes_decisions", value); }

	/// <summary>
	/// <para>
	/// Specifies the node ID or the name of the node to only explain a shard that is currently located on the specified node.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("current_node")]
	public string? CurrentNode { get; set; }

	/// <summary>
	/// <para>
	/// Specifies the name of the index that you would like an explanation for.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexName? Index { get; set; }

	/// <summary>
	/// <para>
	/// If true, returns explanation for the primary shard for the given shard ID.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("primary")]
	public bool? Primary { get; set; }

	/// <summary>
	/// <para>
	/// Specifies the ID of the shard that you would like an explanation for.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("shard")]
	public int? Shard { get; set; }
}

/// <summary>
/// <para>
/// Provides explanations for shard allocations in the cluster.
/// </para>
/// </summary>
public sealed partial class AllocationExplainRequestDescriptor : RequestDescriptor<AllocationExplainRequestDescriptor, AllocationExplainRequestParameters>
{
	internal AllocationExplainRequestDescriptor(Action<AllocationExplainRequestDescriptor> configure) => configure.Invoke(this);

	public AllocationExplainRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.ClusterAllocationExplain;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "cluster.allocation_explain";

	public AllocationExplainRequestDescriptor IncludeDiskInfo(bool? includeDiskInfo = true) => Qs("include_disk_info", includeDiskInfo);
	public AllocationExplainRequestDescriptor IncludeYesDecisions(bool? includeYesDecisions = true) => Qs("include_yes_decisions", includeYesDecisions);

	private string? CurrentNodeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexName? IndexValue { get; set; }
	private bool? PrimaryValue { get; set; }
	private int? ShardValue { get; set; }

	/// <summary>
	/// <para>
	/// Specifies the node ID or the name of the node to only explain a shard that is currently located on the specified node.
	/// </para>
	/// </summary>
	public AllocationExplainRequestDescriptor CurrentNode(string? currentNode)
	{
		CurrentNodeValue = currentNode;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Specifies the name of the index that you would like an explanation for.
	/// </para>
	/// </summary>
	public AllocationExplainRequestDescriptor Index(Elastic.Clients.Elasticsearch.Serverless.IndexName? index)
	{
		IndexValue = index;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If true, returns explanation for the primary shard for the given shard ID.
	/// </para>
	/// </summary>
	public AllocationExplainRequestDescriptor Primary(bool? primary = true)
	{
		PrimaryValue = primary;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Specifies the ID of the shard that you would like an explanation for.
	/// </para>
	/// </summary>
	public AllocationExplainRequestDescriptor Shard(int? shard)
	{
		ShardValue = shard;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(CurrentNodeValue))
		{
			writer.WritePropertyName("current_node");
			writer.WriteStringValue(CurrentNodeValue);
		}

		if (IndexValue is not null)
		{
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		if (PrimaryValue.HasValue)
		{
			writer.WritePropertyName("primary");
			writer.WriteBooleanValue(PrimaryValue.Value);
		}

		if (ShardValue.HasValue)
		{
			writer.WritePropertyName("shard");
			writer.WriteNumberValue(ShardValue.Value);
		}

		writer.WriteEndObject();
	}
}