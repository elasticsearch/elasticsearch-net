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

public sealed class PendingTasksRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If `true`, the request retrieves information from the local node only.<br/>If `false`, information is retrieved from the master node.</para>
	/// </summary>
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

	/// <summary>
	/// <para>Period to wait for a connection to the master node.<br/>If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>Returns cluster-level changes (such as create index, update mapping, allocate or fail shard) that have not yet been executed.<br/>NOTE: This API returns a list of any pending updates to the cluster state.<br/>These are distinct from the tasks reported by the Task Management API which include periodic tasks and tasks initiated by the user, such as node stats, search queries, or create index requests.<br/>However, if a user-initiated task such as a create index command causes a cluster state update, the activity of this task might be reported by both task api and pending cluster tasks API.</para>
/// </summary>
public sealed partial class PendingTasksRequest : PlainRequest<PendingTasksRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.ClusterPendingTasks;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "cluster.pending_tasks";

	/// <summary>
	/// <para>If `true`, the request retrieves information from the local node only.<br/>If `false`, information is retrieved from the master node.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

	/// <summary>
	/// <para>Period to wait for a connection to the master node.<br/>If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>Returns cluster-level changes (such as create index, update mapping, allocate or fail shard) that have not yet been executed.<br/>NOTE: This API returns a list of any pending updates to the cluster state.<br/>These are distinct from the tasks reported by the Task Management API which include periodic tasks and tasks initiated by the user, such as node stats, search queries, or create index requests.<br/>However, if a user-initiated task such as a create index command causes a cluster state update, the activity of this task might be reported by both task api and pending cluster tasks API.</para>
/// </summary>
public sealed partial class PendingTasksRequestDescriptor : RequestDescriptor<PendingTasksRequestDescriptor, PendingTasksRequestParameters>
{
	internal PendingTasksRequestDescriptor(Action<PendingTasksRequestDescriptor> configure) => configure.Invoke(this);

	public PendingTasksRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.ClusterPendingTasks;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "cluster.pending_tasks";

	public PendingTasksRequestDescriptor Local(bool? local = true) => Qs("local", local);
	public PendingTasksRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}