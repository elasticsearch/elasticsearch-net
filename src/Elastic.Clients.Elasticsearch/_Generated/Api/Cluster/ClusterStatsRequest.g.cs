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
	public sealed class ClusterStatsRequestParameters : RequestParameters<ClusterStatsRequestParameters>
	{
		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
	}

	public partial class ClusterStatsRequest : PlainRequestBase<ClusterStatsRequestParameters>
	{
		public ClusterStatsRequest()
		{
		}

		public ClusterStatsRequest(Elastic.Clients.Elasticsearch.NodeIds? node_id) : base(r => r.Optional("node_id", node_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
	}

	public sealed partial class ClusterStatsRequestDescriptor : RequestDescriptorBase<ClusterStatsRequestDescriptor, ClusterStatsRequestParameters>
	{
		internal ClusterStatsRequestDescriptor(Action<ClusterStatsRequestDescriptor> configure) => configure.Invoke(this);
		public ClusterStatsRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public ClusterStatsRequestDescriptor FlatSettings(bool? flatSettings = true) => Qs("flat_settings", flatSettings);
		public ClusterStatsRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
		public ClusterStatsRequestDescriptor NodeId(Elastic.Clients.Elasticsearch.NodeIds? node_id)
		{
			RouteValues.Optional("node_id", node_id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}