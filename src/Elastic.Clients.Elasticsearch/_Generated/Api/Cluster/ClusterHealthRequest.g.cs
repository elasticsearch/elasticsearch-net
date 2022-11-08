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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster;
public sealed class ClusterHealthRequestParameters : RequestParameters<ClusterHealthRequestParameters>
{
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Level? Level { get => Q<Elastic.Clients.Elasticsearch.Level?>("level"); set => Q("level", value); }

	[JsonIgnore]
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.WaitForEvents? WaitForEvents { get => Q<Elastic.Clients.Elasticsearch.WaitForEvents?>("wait_for_events"); set => Q("wait_for_events", value); }

	[JsonIgnore]
	public Union<string?, int?>? WaitForNodes { get => Q<Union<string?, int?>?>("wait_for_nodes"); set => Q("wait_for_nodes", value); }

	[JsonIgnore]
	public bool? WaitForNoInitializingShards { get => Q<bool?>("wait_for_no_initializing_shards"); set => Q("wait_for_no_initializing_shards", value); }

	[JsonIgnore]
	public bool? WaitForNoRelocatingShards { get => Q<bool?>("wait_for_no_relocating_shards"); set => Q("wait_for_no_relocating_shards", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.HealthStatus? WaitForStatus { get => Q<Elastic.Clients.Elasticsearch.HealthStatus?>("wait_for_status"); set => Q("wait_for_status", value); }
}

public sealed partial class ClusterHealthRequest : PlainRequest<ClusterHealthRequestParameters>
{
	public ClusterHealthRequest()
	{
	}

	public ClusterHealthRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterHealth;
	internal override HttpMethod HttpMethod => HttpMethod.GET;
	internal override bool SupportsBody => false;
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Level? Level { get => Q<Elastic.Clients.Elasticsearch.Level?>("level"); set => Q("level", value); }

	[JsonIgnore]
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.WaitForEvents? WaitForEvents { get => Q<Elastic.Clients.Elasticsearch.WaitForEvents?>("wait_for_events"); set => Q("wait_for_events", value); }

	[JsonIgnore]
	public Union<string?, int?>? WaitForNodes { get => Q<Union<string?, int?>?>("wait_for_nodes"); set => Q("wait_for_nodes", value); }

	[JsonIgnore]
	public bool? WaitForNoInitializingShards { get => Q<bool?>("wait_for_no_initializing_shards"); set => Q("wait_for_no_initializing_shards", value); }

	[JsonIgnore]
	public bool? WaitForNoRelocatingShards { get => Q<bool?>("wait_for_no_relocating_shards"); set => Q("wait_for_no_relocating_shards", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.HealthStatus? WaitForStatus { get => Q<Elastic.Clients.Elasticsearch.HealthStatus?>("wait_for_status"); set => Q("wait_for_status", value); }
}

public sealed partial class ClusterHealthRequestDescriptor<TDocument> : RequestDescriptor<ClusterHealthRequestDescriptor<TDocument>, ClusterHealthRequestParameters>
{
	internal ClusterHealthRequestDescriptor(Action<ClusterHealthRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public ClusterHealthRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterHealth;
	internal override HttpMethod HttpMethod => HttpMethod.GET;
	internal override bool SupportsBody => false;
	public ClusterHealthRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public ClusterHealthRequestDescriptor<TDocument> Level(Elastic.Clients.Elasticsearch.Level? level) => Qs("level", level);
	public ClusterHealthRequestDescriptor<TDocument> Local(bool? local = true) => Qs("local", local);
	public ClusterHealthRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public ClusterHealthRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public ClusterHealthRequestDescriptor<TDocument> WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
	public ClusterHealthRequestDescriptor<TDocument> WaitForEvents(Elastic.Clients.Elasticsearch.WaitForEvents? waitForEvents) => Qs("wait_for_events", waitForEvents);
	public ClusterHealthRequestDescriptor<TDocument> WaitForNoInitializingShards(bool? waitForNoInitializingShards = true) => Qs("wait_for_no_initializing_shards", waitForNoInitializingShards);
	public ClusterHealthRequestDescriptor<TDocument> WaitForNoRelocatingShards(bool? waitForNoRelocatingShards = true) => Qs("wait_for_no_relocating_shards", waitForNoRelocatingShards);
	public ClusterHealthRequestDescriptor<TDocument> WaitForNodes(Union<string?, int?>? waitForNodes) => Qs("wait_for_nodes", waitForNodes);
	public ClusterHealthRequestDescriptor<TDocument> WaitForStatus(Elastic.Clients.Elasticsearch.HealthStatus? waitForStatus) => Qs("wait_for_status", waitForStatus);
	public ClusterHealthRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

public sealed partial class ClusterHealthRequestDescriptor : RequestDescriptor<ClusterHealthRequestDescriptor, ClusterHealthRequestParameters>
{
	internal ClusterHealthRequestDescriptor(Action<ClusterHealthRequestDescriptor> configure) => configure.Invoke(this);
	public ClusterHealthRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterHealth;
	internal override HttpMethod HttpMethod => HttpMethod.GET;
	internal override bool SupportsBody => false;
	public ClusterHealthRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public ClusterHealthRequestDescriptor Level(Elastic.Clients.Elasticsearch.Level? level) => Qs("level", level);
	public ClusterHealthRequestDescriptor Local(bool? local = true) => Qs("local", local);
	public ClusterHealthRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public ClusterHealthRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public ClusterHealthRequestDescriptor WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
	public ClusterHealthRequestDescriptor WaitForEvents(Elastic.Clients.Elasticsearch.WaitForEvents? waitForEvents) => Qs("wait_for_events", waitForEvents);
	public ClusterHealthRequestDescriptor WaitForNoInitializingShards(bool? waitForNoInitializingShards = true) => Qs("wait_for_no_initializing_shards", waitForNoInitializingShards);
	public ClusterHealthRequestDescriptor WaitForNoRelocatingShards(bool? waitForNoRelocatingShards = true) => Qs("wait_for_no_relocating_shards", waitForNoRelocatingShards);
	public ClusterHealthRequestDescriptor WaitForNodes(Union<string?, int?>? waitForNodes) => Qs("wait_for_nodes", waitForNodes);
	public ClusterHealthRequestDescriptor WaitForStatus(Elastic.Clients.Elasticsearch.HealthStatus? waitForStatus) => Qs("wait_for_status", waitForStatus);
	public ClusterHealthRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}