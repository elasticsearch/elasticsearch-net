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
	public partial class InlineGet<TDocument>
	{
		[JsonInclude]
		[JsonPropertyName("fields")]
		public Dictionary<string, object>? Fields { get; init; }

		[JsonInclude]
		[JsonPropertyName("found")]
		public bool Found { get; init; }

		[JsonInclude]
		[JsonPropertyName("_seq_no")]
		public long? SeqNo { get; init; }

		[JsonInclude]
		[JsonPropertyName("_primary_term")]
		public long? PrimaryTerm { get; init; }

		[JsonInclude]
		[JsonPropertyName("_routing")]
		public string? Routing { get; init; }

		[JsonInclude]
		[JsonPropertyName("_source")]
		public TDocument Source { get; init; }
	}
}