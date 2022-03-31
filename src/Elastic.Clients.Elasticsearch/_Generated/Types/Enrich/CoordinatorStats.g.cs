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
namespace Elastic.Clients.Elasticsearch.Enrich
{
	public partial class CoordinatorStats
	{
		[JsonInclude]
		[JsonPropertyName("executed_searches_total")]
		public long ExecutedSearchesTotal { get; init; }

		[JsonInclude]
		[JsonPropertyName("node_id")]
		public string NodeId { get; init; }

		[JsonInclude]
		[JsonPropertyName("queue_size")]
		public int QueueSize { get; init; }

		[JsonInclude]
		[JsonPropertyName("remote_requests_current")]
		public int RemoteRequestsCurrent { get; init; }

		[JsonInclude]
		[JsonPropertyName("remote_requests_total")]
		public long RemoteRequestsTotal { get; init; }
	}
}