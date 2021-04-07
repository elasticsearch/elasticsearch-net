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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using Elastic.Transport.Products.Elasticsearch.Failures;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest
{
	public partial class AllocationDecision
	{
		[JsonPropertyName("decider")]
		public string Decider
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("decision")]
		public AllocationExplainDecision Decision
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("explanation")]
		public string Explanation
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	public partial class AllocationStore
	{
		[JsonPropertyName("allocation_id")]
		public string AllocationId
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("found")]
		public bool Found
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("in_sync")]
		public bool InSync
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("matching_size_in_bytes")]
		public long MatchingSizeInBytes
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("matching_sync_id")]
		public bool MatchingSyncId
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("store_exception")]
		public string StoreException
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterInfo
	{
		[JsonPropertyName("nodes")]
		public IDictionary<string, NodeDiskUsage> Nodes
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("reserved_sizes")]
		public IEnumerable<ReservedSize> ReservedSizes
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("shard_paths")]
		public IDictionary<string, string> ShardPaths
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("shard_sizes")]
		public IDictionary<string, long> ShardSizes
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	public partial class CurrentNode
	{
		[JsonPropertyName("attributes")]
		public IDictionary<string, string> Attributes
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("id")]
		public string Id
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("name")]
		public string Name
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("transport_address")]
		public string TransportAddress
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("weight_ranking")]
		public int WeightRanking
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	public partial class DiskUsage
	{
		[JsonPropertyName("free_bytes")]
		public long FreeBytes
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("free_disk_percent")]
		public double FreeDiskPercent
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("path")]
		public string Path
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total_bytes")]
		public long TotalBytes
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("used_bytes")]
		public long UsedBytes
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("used_disk_percent")]
		public double UsedDiskPercent
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	public partial class IndexHealthStats
	{
		[JsonPropertyName("active_primary_shards")]
		public int ActivePrimaryShards
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("active_shards")]
		public int ActiveShards
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("initializing_shards")]
		public int InitializingShards
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("number_of_replicas")]
		public int NumberOfReplicas
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("number_of_shards")]
		public int NumberOfShards
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("relocating_shards")]
		public int RelocatingShards
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("shards")]
		public IDictionary<string, ShardHealthStats>? Shards
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("status")]
		public Health Status
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("unassigned_shards")]
		public int UnassignedShards
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeAllocationExplanation
	{
		[JsonPropertyName("deciders")]
		public IEnumerable<AllocationDecision> Deciders
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("node_attributes")]
		public IDictionary<string, string> NodeAttributes
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("node_decision")]
		public Decision NodeDecision
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("node_id")]
		public string NodeId
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("node_name")]
		public string NodeName
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("store")]
		public AllocationStore? Store
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("transport_address")]
		public string TransportAddress
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("weight_ranking")]
		public int WeightRanking
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	public partial class NodeDiskUsage
	{
		[JsonPropertyName("least_available")]
		public DiskUsage LeastAvailable
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("most_available")]
		public DiskUsage MostAvailable
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("node_name")]
		public string NodeName
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	public partial class ReservedSize
	{
		[JsonPropertyName("node_id")]
		public string NodeId
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("path")]
		public string Path
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("shards")]
		public IEnumerable<string> Shards
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total")]
		public long Total
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	public partial class ShardFailure
	{
		[JsonPropertyName("index")]
		public string Index
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("node")]
		public string Node
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("reason")]
		public ErrorCause Reason
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("shard")]
		public int Shard
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("status")]
		public string? Status
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	public partial class ShardHealthStats
	{
		[JsonPropertyName("active_shards")]
		public int ActiveShards
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("initializing_shards")]
		public int InitializingShards
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("primary_active")]
		public bool PrimaryActive
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("relocating_shards")]
		public int RelocatingShards
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("status")]
		public Health Status
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("unassigned_shards")]
		public int UnassignedShards
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	public partial class ShardStatistics
	{
		[JsonPropertyName("failed")]
		public uint Failed
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("failures")]
		public IEnumerable<ShardFailure>? Failures
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("skipped")]
		public uint? Skipped
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("successful")]
		public uint Successful
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total")]
		public uint Total
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	public partial class UnassignedInformation
	{
		[JsonPropertyName("at")]
		public DateTimeOffset At
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("details")]
		public string? Details
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("failed_allocation_attempts")]
		public int? FailedAllocationAttempts
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("last_allocation_status")]
		public string LastAllocationStatus
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("reason")]
		public UnassignedInformationReason Reason
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}
}