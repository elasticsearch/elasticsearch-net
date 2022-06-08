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
namespace Elastic.Clients.Elasticsearch
{
	public partial class MultisearchHeader
	{
		[JsonInclude]
		[JsonPropertyName("allow_no_indices")]
		public bool? AllowNoIndices { get; init; }

		[JsonInclude]
		[JsonPropertyName("allow_partial_search_results")]
		public bool? AllowPartialSearchResults { get; init; }

		[JsonInclude]
		[JsonPropertyName("ccs_minimize_roundtrips")]
		public bool? CcsMinimizeRoundtrips { get; init; }

		[JsonInclude]
		[JsonPropertyName("expand_wildcards")]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get; init; }

		[JsonInclude]
		[JsonPropertyName("ignore_throttled")]
		public bool? IgnoreThrottled { get; init; }

		[JsonInclude]
		[JsonPropertyName("ignore_unavailable")]
		public bool? IgnoreUnavailable { get; init; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.Indices? Index { get; init; }

		[JsonInclude]
		[JsonPropertyName("preference")]
		public string? Preference { get; init; }

		[JsonInclude]
		[JsonPropertyName("request_cache")]
		public bool? RequestCache { get; init; }

		[JsonInclude]
		[JsonPropertyName("routing")]
		public string? Routing { get; init; }

		[JsonInclude]
		[JsonPropertyName("search_type")]
		public Elastic.Clients.Elasticsearch.SearchType? SearchType { get; init; }
	}
}