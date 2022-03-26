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
namespace Elastic.Clients.Elasticsearch.Nodes
{
	public partial class NodeBufferPool
	{
		[JsonInclude]
		[JsonPropertyName("count")]
		public long? Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("total_capacity")]
		public string? TotalCapacity { get; init; }

		[JsonInclude]
		[JsonPropertyName("total_capacity_in_bytes")]
		public long? TotalCapacityInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("used")]
		public string? Used { get; init; }

		[JsonInclude]
		[JsonPropertyName("used_in_bytes")]
		public long? UsedInBytes { get; init; }
	}
}