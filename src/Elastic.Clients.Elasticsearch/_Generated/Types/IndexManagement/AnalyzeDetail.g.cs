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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public sealed partial class AnalyzeDetail
	{
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public Elastic.Clients.Elasticsearch.IndexManagement.AnalyzerDetail? Analyzer { get; init; }

		[JsonInclude]
		[JsonPropertyName("charfilters")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.IndexManagement.CharFilterDetail>? Charfilters { get; init; }

		[JsonInclude]
		[JsonPropertyName("custom_analyzer")]
		public bool CustomAnalyzer { get; init; }

		[JsonInclude]
		[JsonPropertyName("tokenfilters")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.IndexManagement.TokenDetail>? Tokenfilters { get; init; }

		[JsonInclude]
		[JsonPropertyName("tokenizer")]
		public Elastic.Clients.Elasticsearch.IndexManagement.TokenDetail? Tokenizer { get; init; }
	}
}