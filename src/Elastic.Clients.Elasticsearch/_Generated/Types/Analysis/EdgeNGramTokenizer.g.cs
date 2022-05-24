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
	public partial class EdgeNGramTokenizer : TokenizerBase, ITokenizerDefinition
	{
		[JsonInclude]
		[JsonPropertyName("custom_token_chars")]
		public string? CustomTokenChars { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_gram")]
		public int MaxGram { get; set; }

		[JsonInclude]
		[JsonPropertyName("min_gram")]
		public int MinGram { get; set; }

		[JsonInclude]
		[JsonPropertyName("token_chars")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Analysis.TokenChar> TokenChars { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "edge_ngram";
	}

	public sealed partial class EdgeNGramTokenizerDescriptor : SerializableDescriptorBase<EdgeNGramTokenizerDescriptor>, IBuildableDescriptor<EdgeNGramTokenizer>
	{
		internal EdgeNGramTokenizerDescriptor(Action<EdgeNGramTokenizerDescriptor> configure) => configure.Invoke(this);
		public EdgeNGramTokenizerDescriptor() : base()
		{
		}

		private string? CustomTokenCharsValue { get; set; }

		private int MaxGramValue { get; set; }

		private int MinGramValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.Analysis.TokenChar> TokenCharsValue { get; set; }

		private string? VersionValue { get; set; }

		public EdgeNGramTokenizerDescriptor CustomTokenChars(string? customTokenChars)
		{
			CustomTokenCharsValue = customTokenChars;
			return Self;
		}

		public EdgeNGramTokenizerDescriptor MaxGram(int maxGram)
		{
			MaxGramValue = maxGram;
			return Self;
		}

		public EdgeNGramTokenizerDescriptor MinGram(int minGram)
		{
			MinGramValue = minGram;
			return Self;
		}

		public EdgeNGramTokenizerDescriptor TokenChars(IEnumerable<Elastic.Clients.Elasticsearch.Analysis.TokenChar> tokenChars)
		{
			TokenCharsValue = tokenChars;
			return Self;
		}

		public EdgeNGramTokenizerDescriptor Version(string? version)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(CustomTokenCharsValue))
			{
				writer.WritePropertyName("custom_token_chars");
				writer.WriteStringValue(CustomTokenCharsValue);
			}

			writer.WritePropertyName("max_gram");
			writer.WriteNumberValue(MaxGramValue);
			writer.WritePropertyName("min_gram");
			writer.WriteNumberValue(MinGramValue);
			writer.WritePropertyName("token_chars");
			JsonSerializer.Serialize(writer, TokenCharsValue, options);
			writer.WritePropertyName("type");
			writer.WriteStringValue("edge_ngram");
			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			writer.WriteEndObject();
		}

		EdgeNGramTokenizer IBuildableDescriptor<EdgeNGramTokenizer>.Build() => new()
		{ CustomTokenChars = CustomTokenCharsValue, MaxGram = MaxGramValue, MinGram = MinGramValue, TokenChars = TokenCharsValue, Version = VersionValue };
	}
}