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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Tasks;

public sealed class ListRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Comma-separated list or wildcard expression of actions used to limit the request.</para>
	/// </summary>
	public ICollection<string>? Actions { get => Q<ICollection<string>?>("actions"); set => Q("actions", value); }

	/// <summary>
	/// <para>If `true`, the response includes detailed information about shard recoveries.</para>
	/// </summary>
	public bool? Detailed { get => Q<bool?>("detailed"); set => Q("detailed", value); }

	/// <summary>
	/// <para>Key used to group tasks in the response.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Tasks.GroupBy? GroupBy { get => Q<Elastic.Clients.Elasticsearch.Tasks.GroupBy?>("group_by"); set => Q("group_by", value); }

	/// <summary>
	/// <para>Comma-separated list of node IDs or names used to limit returned information.</para>
	/// </summary>
	public ICollection<string>? NodeId { get => Q<ICollection<string>?>("node_id"); set => Q("node_id", value); }

	/// <summary>
	/// <para>Parent task ID used to limit returned information. To return all tasks, omit this parameter or use a value of `-1`.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Id? ParentTaskId { get => Q<Elastic.Clients.Elasticsearch.Id?>("parent_task_id"); set => Q("parent_task_id", value); }

	/// <summary>
	/// <para>Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>Period to wait for a response. If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>If `true`, the request blocks until the operation is complete.</para>
	/// </summary>
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
}

/// <summary>
/// EXPERIMENTAL! May change in ways that are not backwards compatible or be removed entirely.
/// <para>The task management API returns information about tasks currently executing on one or more nodes in the cluster.</para>
/// </summary>
public sealed partial class ListRequest : PlainRequest<ListRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.TasksList;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	/// <summary>
	/// <para>Comma-separated list or wildcard expression of actions used to limit the request.</para>
	/// </summary>
	[JsonIgnore]
	public ICollection<string>? Actions { get => Q<ICollection<string>?>("actions"); set => Q("actions", value); }

	/// <summary>
	/// <para>If `true`, the response includes detailed information about shard recoveries.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Detailed { get => Q<bool?>("detailed"); set => Q("detailed", value); }

	/// <summary>
	/// <para>Key used to group tasks in the response.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Tasks.GroupBy? GroupBy { get => Q<Elastic.Clients.Elasticsearch.Tasks.GroupBy?>("group_by"); set => Q("group_by", value); }

	/// <summary>
	/// <para>Comma-separated list of node IDs or names used to limit returned information.</para>
	/// </summary>
	[JsonIgnore]
	public ICollection<string>? NodeId { get => Q<ICollection<string>?>("node_id"); set => Q("node_id", value); }

	/// <summary>
	/// <para>Parent task ID used to limit returned information. To return all tasks, omit this parameter or use a value of `-1`.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Id? ParentTaskId { get => Q<Elastic.Clients.Elasticsearch.Id?>("parent_task_id"); set => Q("parent_task_id", value); }

	/// <summary>
	/// <para>Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>Period to wait for a response. If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>If `true`, the request blocks until the operation is complete.</para>
	/// </summary>
	[JsonIgnore]
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
}

/// <summary>
/// EXPERIMENTAL! May change in ways that are not backwards compatible or be removed entirely.
/// <para>The task management API returns information about tasks currently executing on one or more nodes in the cluster.</para>
/// </summary>
public sealed partial class ListRequestDescriptor : RequestDescriptor<ListRequestDescriptor, ListRequestParameters>
{
	internal ListRequestDescriptor(Action<ListRequestDescriptor> configure) => configure.Invoke(this);

	public ListRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.TasksList;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	public ListRequestDescriptor Actions(ICollection<string>? actions) => Qs("actions", actions);
	public ListRequestDescriptor Detailed(bool? detailed = true) => Qs("detailed", detailed);
	public ListRequestDescriptor GroupBy(Elastic.Clients.Elasticsearch.Tasks.GroupBy? groupBy) => Qs("group_by", groupBy);
	public ListRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public ListRequestDescriptor NodeId(ICollection<string>? nodeId) => Qs("node_id", nodeId);
	public ListRequestDescriptor ParentTaskId(Elastic.Clients.Elasticsearch.Id? parentTaskId) => Qs("parent_task_id", parentTaskId);
	public ListRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public ListRequestDescriptor WaitForCompletion(bool? waitForCompletion = true) => Qs("wait_for_completion", waitForCompletion);

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}