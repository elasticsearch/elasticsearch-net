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
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public partial class WordDelimiterTokenFilter : Analysis.TokenFilterBase, ITokenFilterDefinition
	{
		[JsonInclude]
		[JsonPropertyName("catenate_all")]
		public bool? CatenateAll { get; init; }

		[JsonInclude]
		[JsonPropertyName("catenate_numbers")]
		public bool? CatenateNumbers { get; init; }

		[JsonInclude]
		[JsonPropertyName("catenate_words")]
		public bool? CatenateWords { get; init; }

		[JsonInclude]
		[JsonPropertyName("generate_number_parts")]
		public bool? GenerateNumberParts { get; init; }

		[JsonInclude]
		[JsonPropertyName("generate_word_parts")]
		public bool? GenerateWordParts { get; init; }

		[JsonInclude]
		[JsonPropertyName("preserve_original")]
		public bool? PreserveOriginal { get; init; }

		[JsonInclude]
		[JsonPropertyName("protected_words")]
		public IReadOnlyCollection<string>? ProtectedWords { get; init; }

		[JsonInclude]
		[JsonPropertyName("protected_words_path")]
		public string? ProtectedWordsPath { get; init; }

		[JsonInclude]
		[JsonPropertyName("split_on_case_change")]
		public bool? SplitOnCaseChange { get; init; }

		[JsonInclude]
		[JsonPropertyName("split_on_numerics")]
		public bool? SplitOnNumerics { get; init; }

		[JsonInclude]
		[JsonPropertyName("stem_english_possessive")]
		public bool? StemEnglishPossessive { get; init; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "word_delimiter";
		[JsonInclude]
		[JsonPropertyName("type_table")]
		public IReadOnlyCollection<string>? TypeTable { get; init; }

		[JsonInclude]
		[JsonPropertyName("type_table_path")]
		public string? TypeTablePath { get; init; }
	}
}