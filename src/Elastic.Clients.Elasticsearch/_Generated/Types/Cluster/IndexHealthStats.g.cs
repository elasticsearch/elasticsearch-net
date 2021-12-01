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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster.Health
{
	public partial class IndexHealthStats
	{
		[JsonInclude]
		[JsonPropertyName("active_primary_shards")]
		public int ActivePrimaryShards { get; init; }

		[JsonInclude]
		[JsonPropertyName("active_shards")]
		public int ActiveShards { get; init; }

		[JsonInclude]
		[JsonPropertyName("initializing_shards")]
		public int InitializingShards { get; init; }

		[JsonInclude]
		[JsonPropertyName("number_of_replicas")]
		public int NumberOfReplicas { get; init; }

		[JsonInclude]
		[JsonPropertyName("number_of_shards")]
		public int NumberOfShards { get; init; }

		[JsonInclude]
		[JsonPropertyName("relocating_shards")]
		public int RelocatingShards { get; init; }

		[JsonInclude]
		[JsonPropertyName("shards")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Cluster.Health.ShardHealthStats>? Shards { get; init; }

		[JsonInclude]
		[JsonPropertyName("status")]
		public Elastic.Clients.Elasticsearch.HealthStatus Status { get; init; }

		[JsonInclude]
		[JsonPropertyName("unassigned_shards")]
		public int UnassignedShards { get; init; }
	}
}