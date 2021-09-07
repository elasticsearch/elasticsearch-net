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

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster.Reroute
{
	public partial class Command
	{
		[JsonInclude]
		[JsonPropertyName("allocate_empty_primary")]
		public Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocatePrimaryAction? AllocateEmptyPrimary { get; set; }

		[JsonInclude]
		[JsonPropertyName("allocate_replica")]
		public Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocateReplicaAction? AllocateReplica { get; set; }

		[JsonInclude]
		[JsonPropertyName("allocate_stale_primary")]
		public Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocatePrimaryAction? AllocateStalePrimary { get; set; }

		[JsonInclude]
		[JsonPropertyName("cancel")]
		public Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandCancelAction? Cancel { get; set; }

		[JsonInclude]
		[JsonPropertyName("move")]
		public Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandMoveAction? Move { get; set; }
	}

	public partial class CommandAllocatePrimaryAction
	{
		[JsonInclude]
		[JsonPropertyName("accept_data_loss")]
		public bool AcceptDataLoss { get; set; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("node")]
		public string Node { get; set; }

		[JsonInclude]
		[JsonPropertyName("shard")]
		public int Shard { get; set; }
	}

	public partial class CommandAllocateReplicaAction
	{
		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("node")]
		public string Node { get; set; }

		[JsonInclude]
		[JsonPropertyName("shard")]
		public int Shard { get; set; }
	}

	public partial class CommandCancelAction
	{
		[JsonInclude]
		[JsonPropertyName("allow_primary")]
		public bool? AllowPrimary { get; set; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("node")]
		public string Node { get; set; }

		[JsonInclude]
		[JsonPropertyName("shard")]
		public int Shard { get; set; }
	}

	public partial class CommandMoveAction
	{
		[JsonInclude]
		[JsonPropertyName("from_node")]
		public string FromNode { get; set; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("shard")]
		public int Shard { get; set; }

		[JsonInclude]
		[JsonPropertyName("to_node")]
		public string ToNode { get; set; }
	}

	public partial class RerouteDecision
	{
		[JsonInclude]
		[JsonPropertyName("decider")]
		public string Decider
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("decision")]
		public string Decision
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("explanation")]
		public string Explanation
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class RerouteExplanation
	{
		[JsonInclude]
		[JsonPropertyName("command")]
		public string Command
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("decisions")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Reroute.RerouteDecision> Decisions
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("parameters")]
		public Elastic.Clients.Elasticsearch.Cluster.Reroute.RerouteParameters Parameters
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class RerouteParameters
	{
		[JsonInclude]
		[JsonPropertyName("allow_primary")]
		public bool AllowPrimary
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("from_node")]
		public Elastic.Clients.Elasticsearch.NodeName? FromNode
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName Index
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("node")]
		public Elastic.Clients.Elasticsearch.NodeName Node
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("shard")]
		public int Shard
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("to_node")]
		public Elastic.Clients.Elasticsearch.NodeName? ToNode
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class RerouteState
	{
		[JsonInclude]
		[JsonPropertyName("blocks")]
		public Elastic.Clients.Elasticsearch.EmptyObject? Blocks
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("cluster_uuid")]
		public Elastic.Clients.Elasticsearch.Uuid ClusterUuid
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("master_node")]
		public string? MasterNode
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("metadata")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterStateMetadata? Metadata
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("nodes")]
		public Dictionary<Elastic.Clients.Elasticsearch.NodeName, Elastic.Clients.Elasticsearch.NodeAttributes>? Nodes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("routing_nodes")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterStateRoutingNodes? RoutingNodes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("routing_table")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.EmptyObject>? RoutingTable
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("security_tokens")]
		public Dictionary<string, string>? SecurityTokens
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("snapshot_deletions")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterStateDeletedSnapshots? SnapshotDeletions
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("snapshots")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterStateSnapshots? Snapshots
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("state_uuid")]
		public Elastic.Clients.Elasticsearch.Uuid? StateUuid
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("version")]
		public Elastic.Clients.Elasticsearch.VersionNumber? Version
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}
}