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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public partial class TokenizerDefinitions : IsADictionaryBase<string, ITokenizerDefinition>
	{
		public TokenizerDefinitions()
		{
		}

		public TokenizerDefinitions(IDictionary<string, ITokenizerDefinition> container) : base(container)
		{
		}

		public void Add(string name, ITokenizerDefinition tokenizerdefinitions) => BackingDictionary.Add(name, tokenizerdefinitions);
	}

	public sealed partial class TokenizerDefinitionsDescriptor : IsADictionaryDescriptor<TokenizerDefinitionsDescriptor, TokenizerDefinitions, string, ITokenizerDefinition>
	{
		public TokenizerDefinitionsDescriptor() : base(new TokenizerDefinitions())
		{
		}

		public TokenizerDefinitionsDescriptor(TokenizerDefinitions tokenizerDefinitions) : base(tokenizerDefinitions ?? new TokenizerDefinitions())
		{
		}
	}

	internal sealed partial class TokenizerDefinitionInterfaceConverter
	{
		private static ITokenizerDefinition DeserializeVariant(string type, ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			switch (type)
			{
				case "icu_tokenizer":
					return JsonSerializer.Deserialize<IcuTokenizer>(ref reader, options);
				case "pattern":
					return JsonSerializer.Deserialize<PatternTokenizer>(ref reader, options);
				case "kuromoji_tokenizer":
					return JsonSerializer.Deserialize<KuromojiTokenizer>(ref reader, options);
				case "whitespace":
					return JsonSerializer.Deserialize<WhitespaceTokenizer>(ref reader, options);
				case "uax_url_email":
					return JsonSerializer.Deserialize<UaxEmailUrlTokenizer>(ref reader, options);
				case "standard":
					return JsonSerializer.Deserialize<StandardTokenizer>(ref reader, options);
				case "path_hierarchy":
					return JsonSerializer.Deserialize<PathHierarchyTokenizer>(ref reader, options);
				case "nori_tokenizer":
					return JsonSerializer.Deserialize<NoriTokenizer>(ref reader, options);
				case "ngram":
					return JsonSerializer.Deserialize<NGramTokenizer>(ref reader, options);
				case "lowercase":
					return JsonSerializer.Deserialize<LowercaseTokenizer>(ref reader, options);
				case "letter":
					return JsonSerializer.Deserialize<LetterTokenizer>(ref reader, options);
				case "keyword":
					return JsonSerializer.Deserialize<KeywordTokenizer>(ref reader, options);
				case "edge_ngram":
					return JsonSerializer.Deserialize<EdgeNGramTokenizer>(ref reader, options);
				case "char_group":
					return JsonSerializer.Deserialize<CharGroupTokenizer>(ref reader, options);
				default:
					throw new JsonException("Encounted an unknown variant type which could not be deserialised.");
			}
		}
	}

	public partial interface ITokenizerDefinition
	{
		public string Type { get; }
	}
}