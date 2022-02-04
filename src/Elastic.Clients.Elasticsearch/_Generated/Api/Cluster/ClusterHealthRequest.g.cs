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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public class ClusterHealthRequestParameters : RequestParameters<ClusterHealthRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Level? Level { get => Q<Elastic.Clients.Elasticsearch.Level?>("level"); set => Q("level", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

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

	public partial class ClusterHealthRequest : PlainRequestBase<ClusterHealthRequestParameters>
	{
		public ClusterHealthRequest()
		{
		}

		public ClusterHealthRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterHealth;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Level? Level { get => Q<Elastic.Clients.Elasticsearch.Level?>("level"); set => Q("level", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

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

	public sealed partial class ClusterHealthRequestDescriptor : RequestDescriptorBase<ClusterHealthRequestDescriptor, ClusterHealthRequestParameters>
	{
		public ClusterHealthRequestDescriptor()
		{
		}

		public ClusterHealthRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal ClusterHealthRequestDescriptor(Action<ClusterHealthRequestDescriptor> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterHealth;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public ClusterHealthRequestDescriptor ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public ClusterHealthRequestDescriptor Level(Elastic.Clients.Elasticsearch.Level? level) => Qs("level", level);
		public ClusterHealthRequestDescriptor Local(bool? local = true) => Qs("local", local);
		public ClusterHealthRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public ClusterHealthRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public ClusterHealthRequestDescriptor WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
		public ClusterHealthRequestDescriptor WaitForEvents(Elastic.Clients.Elasticsearch.WaitForEvents? waitForEvents) => Qs("wait_for_events", waitForEvents);
		public ClusterHealthRequestDescriptor WaitForNodes(Union<string?, int?>? waitForNodes) => Qs("wait_for_nodes", waitForNodes);
		public ClusterHealthRequestDescriptor WaitForNoInitializingShards(bool? waitForNoInitializingShards = true) => Qs("wait_for_no_initializing_shards", waitForNoInitializingShards);
		public ClusterHealthRequestDescriptor WaitForNoRelocatingShards(bool? waitForNoRelocatingShards = true) => Qs("wait_for_no_relocating_shards", waitForNoRelocatingShards);
		public ClusterHealthRequestDescriptor WaitForStatus(Elastic.Clients.Elasticsearch.HealthStatus? waitForStatus) => Qs("wait_for_status", waitForStatus);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}