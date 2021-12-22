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
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class LikeDocument
	{
		[JsonInclude]
		[JsonPropertyName("doc")]
		public object? Doc { get; init; }

		[JsonInclude]
		[JsonPropertyName("fields")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Field>? Fields { get; init; }

		[JsonInclude]
		[JsonPropertyName("_id")]
		public Elastic.Clients.Elasticsearch.Id? Id { get; init; }

		[JsonInclude]
		[JsonPropertyName("_index")]
		public Elastic.Clients.Elasticsearch.IndexName? Index { get; init; }

		[JsonInclude]
		[JsonPropertyName("per_field_analyzer")]
		public Dictionary<Elastic.Clients.Elasticsearch.Field, string>? PerFieldAnalyzer { get; init; }

		[JsonInclude]
		[JsonPropertyName("routing")]
		public Elastic.Clients.Elasticsearch.Routing? Routing { get; init; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public long? Version { get; init; }

		[JsonInclude]
		[JsonPropertyName("version_type")]
		public Elastic.Clients.Elasticsearch.VersionType? VersionType { get; init; }
	}
}