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
namespace Elastic.Clients.Elasticsearch.Mapping
{
	public partial class FlattenedProperty : PropertyBase, IProperty
	{
		[JsonInclude]
		[JsonPropertyName("boost")]
		public double? Boost { get; init; }

		[JsonInclude]
		[JsonPropertyName("depth_limit")]
		public int? DepthLimit { get; init; }

		[JsonInclude]
		[JsonPropertyName("doc_values")]
		public bool? DocValues { get; init; }

		[JsonInclude]
		[JsonPropertyName("eager_global_ordinals")]
		public bool? EagerGlobalOrdinals { get; init; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public bool? Index { get; init; }

		[JsonInclude]
		[JsonPropertyName("index_options")]
		public Elastic.Clients.Elasticsearch.Mapping.IndexOptions? IndexOptions { get; init; }

		[JsonInclude]
		[JsonPropertyName("null_value")]
		public string? NullValue { get; init; }

		[JsonInclude]
		[JsonPropertyName("similarity")]
		public string? Similarity { get; init; }

		[JsonInclude]
		[JsonPropertyName("split_queries_on_whitespace")]
		public bool? SplitQueriesOnWhitespace { get; init; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "flattened";
	}
}