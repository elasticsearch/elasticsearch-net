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
	public partial class MultiMatchQuery : QueryBase, IQueryVariant
	{
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("auto_generate_synonyms_phrase_query")]
		public bool? AutoGenerateSynonymsPhraseQuery { get; set; }

		[JsonInclude]
		[JsonPropertyName("fields")]
		public Elastic.Clients.Elasticsearch.Fields? Fields { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzziness")]
		public Elastic.Clients.Elasticsearch.Fuzziness? Fuzziness { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_rewrite")]
		public string? FuzzyRewrite { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_transpositions")]
		public bool? FuzzyTranspositions { get; set; }

		[JsonInclude]
		[JsonPropertyName("lenient")]
		public bool? Lenient { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_expansions")]
		public int? MaxExpansions { get; set; }

		[JsonInclude]
		[JsonPropertyName("minimum_should_match")]
		public Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

		[JsonInclude]
		[JsonPropertyName("operator")]
		public Elastic.Clients.Elasticsearch.QueryDsl.Operator? Operator { get; set; }

		[JsonInclude]
		[JsonPropertyName("prefix_length")]
		public int? PrefixLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public string Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("slop")]
		public int? Slop { get; set; }

		[JsonInclude]
		[JsonPropertyName("tie_breaker")]
		public double? TieBreaker { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? Type { get; set; }

		[JsonInclude]
		[JsonPropertyName("zero_terms_query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? ZeroTermsQuery { get; set; }
	}

	public sealed partial class MultiMatchQueryDescriptor<TDocument> : SerializableDescriptorBase<MultiMatchQueryDescriptor<TDocument>>
	{
		internal MultiMatchQueryDescriptor(Action<MultiMatchQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public MultiMatchQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private string? AnalyzerValue { get; set; }

		private bool? AutoGenerateSynonymsPhraseQueryValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; set; }

		private string? FuzzyRewriteValue { get; set; }

		private bool? FuzzyTranspositionsValue { get; set; }

		private bool? LenientValue { get; set; }

		private int? MaxExpansionsValue { get; set; }

		private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.Operator? OperatorValue { get; set; }

		private int? PrefixLengthValue { get; set; }

		private string QueryValue { get; set; }

		private int? SlopValue { get; set; }

		private double? TieBreakerValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? TypeValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? ZeroTermsQueryValue { get; set; }

		public MultiMatchQueryDescriptor<TDocument> QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> Analyzer(string? analyzer)
		{
			AnalyzerValue = analyzer;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> AutoGenerateSynonymsPhraseQuery(bool? autoGenerateSynonymsPhraseQuery = true)
		{
			AutoGenerateSynonymsPhraseQueryValue = autoGenerateSynonymsPhraseQuery;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> Fields<TValue>(Expression<Func<TDocument, TValue>> fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness)
		{
			FuzzinessValue = fuzziness;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> FuzzyRewrite(string? fuzzyRewrite)
		{
			FuzzyRewriteValue = fuzzyRewrite;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> FuzzyTranspositions(bool? fuzzyTranspositions = true)
		{
			FuzzyTranspositionsValue = fuzzyTranspositions;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> Lenient(bool? lenient = true)
		{
			LenientValue = lenient;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> MaxExpansions(int? maxExpansions)
		{
			MaxExpansionsValue = maxExpansions;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
		{
			MinimumShouldMatchValue = minimumShouldMatch;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> Operator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? op)
		{
			OperatorValue = op;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> PrefixLength(int? prefixLength)
		{
			PrefixLengthValue = prefixLength;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> Query(string query)
		{
			QueryValue = query;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> Slop(int? slop)
		{
			SlopValue = slop;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> TieBreaker(double? tieBreaker)
		{
			TieBreakerValue = tieBreaker;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> Type(Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? type)
		{
			TypeValue = type;
			return Self;
		}

		public MultiMatchQueryDescriptor<TDocument> ZeroTermsQuery(Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? zeroTermsQuery)
		{
			ZeroTermsQueryValue = zeroTermsQuery;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (AutoGenerateSynonymsPhraseQueryValue.HasValue)
			{
				writer.WritePropertyName("auto_generate_synonyms_phrase_query");
				writer.WriteBooleanValue(AutoGenerateSynonymsPhraseQueryValue.Value);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (FuzzinessValue is not null)
			{
				writer.WritePropertyName("fuzziness");
				JsonSerializer.Serialize(writer, FuzzinessValue, options);
			}

			if (FuzzyRewriteValue is not null)
			{
				writer.WritePropertyName("fuzzy_rewrite");
				JsonSerializer.Serialize(writer, FuzzyRewriteValue, options);
			}

			if (FuzzyTranspositionsValue.HasValue)
			{
				writer.WritePropertyName("fuzzy_transpositions");
				writer.WriteBooleanValue(FuzzyTranspositionsValue.Value);
			}

			if (LenientValue.HasValue)
			{
				writer.WritePropertyName("lenient");
				writer.WriteBooleanValue(LenientValue.Value);
			}

			if (MaxExpansionsValue.HasValue)
			{
				writer.WritePropertyName("max_expansions");
				writer.WriteNumberValue(MaxExpansionsValue.Value);
			}

			if (MinimumShouldMatchValue is not null)
			{
				writer.WritePropertyName("minimum_should_match");
				JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
			}

			if (OperatorValue is not null)
			{
				writer.WritePropertyName("operator");
				JsonSerializer.Serialize(writer, OperatorValue, options);
			}

			if (PrefixLengthValue.HasValue)
			{
				writer.WritePropertyName("prefix_length");
				writer.WriteNumberValue(PrefixLengthValue.Value);
			}

			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
			if (SlopValue.HasValue)
			{
				writer.WritePropertyName("slop");
				writer.WriteNumberValue(SlopValue.Value);
			}

			if (TieBreakerValue.HasValue)
			{
				writer.WritePropertyName("tie_breaker");
				writer.WriteNumberValue(TieBreakerValue.Value);
			}

			if (TypeValue is not null)
			{
				writer.WritePropertyName("type");
				JsonSerializer.Serialize(writer, TypeValue, options);
			}

			if (ZeroTermsQueryValue is not null)
			{
				writer.WritePropertyName("zero_terms_query");
				JsonSerializer.Serialize(writer, ZeroTermsQueryValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class MultiMatchQueryDescriptor : SerializableDescriptorBase<MultiMatchQueryDescriptor>
	{
		internal MultiMatchQueryDescriptor(Action<MultiMatchQueryDescriptor> configure) => configure.Invoke(this);
		public MultiMatchQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private string? AnalyzerValue { get; set; }

		private bool? AutoGenerateSynonymsPhraseQueryValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; set; }

		private string? FuzzyRewriteValue { get; set; }

		private bool? FuzzyTranspositionsValue { get; set; }

		private bool? LenientValue { get; set; }

		private int? MaxExpansionsValue { get; set; }

		private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.Operator? OperatorValue { get; set; }

		private int? PrefixLengthValue { get; set; }

		private string QueryValue { get; set; }

		private int? SlopValue { get; set; }

		private double? TieBreakerValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? TypeValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? ZeroTermsQueryValue { get; set; }

		public MultiMatchQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public MultiMatchQueryDescriptor Analyzer(string? analyzer)
		{
			AnalyzerValue = analyzer;
			return Self;
		}

		public MultiMatchQueryDescriptor AutoGenerateSynonymsPhraseQuery(bool? autoGenerateSynonymsPhraseQuery = true)
		{
			AutoGenerateSynonymsPhraseQueryValue = autoGenerateSynonymsPhraseQuery;
			return Self;
		}

		public MultiMatchQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public MultiMatchQueryDescriptor Fields(Elastic.Clients.Elasticsearch.Fields? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public MultiMatchQueryDescriptor Fields<TDocument, TValue>(Expression<Func<TDocument, TValue>> fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public MultiMatchQueryDescriptor Fields<TDocument>(Expression<Func<TDocument, object>> fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public MultiMatchQueryDescriptor Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness)
		{
			FuzzinessValue = fuzziness;
			return Self;
		}

		public MultiMatchQueryDescriptor FuzzyRewrite(string? fuzzyRewrite)
		{
			FuzzyRewriteValue = fuzzyRewrite;
			return Self;
		}

		public MultiMatchQueryDescriptor FuzzyTranspositions(bool? fuzzyTranspositions = true)
		{
			FuzzyTranspositionsValue = fuzzyTranspositions;
			return Self;
		}

		public MultiMatchQueryDescriptor Lenient(bool? lenient = true)
		{
			LenientValue = lenient;
			return Self;
		}

		public MultiMatchQueryDescriptor MaxExpansions(int? maxExpansions)
		{
			MaxExpansionsValue = maxExpansions;
			return Self;
		}

		public MultiMatchQueryDescriptor MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
		{
			MinimumShouldMatchValue = minimumShouldMatch;
			return Self;
		}

		public MultiMatchQueryDescriptor Operator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? op)
		{
			OperatorValue = op;
			return Self;
		}

		public MultiMatchQueryDescriptor PrefixLength(int? prefixLength)
		{
			PrefixLengthValue = prefixLength;
			return Self;
		}

		public MultiMatchQueryDescriptor Query(string query)
		{
			QueryValue = query;
			return Self;
		}

		public MultiMatchQueryDescriptor Slop(int? slop)
		{
			SlopValue = slop;
			return Self;
		}

		public MultiMatchQueryDescriptor TieBreaker(double? tieBreaker)
		{
			TieBreakerValue = tieBreaker;
			return Self;
		}

		public MultiMatchQueryDescriptor Type(Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? type)
		{
			TypeValue = type;
			return Self;
		}

		public MultiMatchQueryDescriptor ZeroTermsQuery(Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? zeroTermsQuery)
		{
			ZeroTermsQueryValue = zeroTermsQuery;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (AutoGenerateSynonymsPhraseQueryValue.HasValue)
			{
				writer.WritePropertyName("auto_generate_synonyms_phrase_query");
				writer.WriteBooleanValue(AutoGenerateSynonymsPhraseQueryValue.Value);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (FuzzinessValue is not null)
			{
				writer.WritePropertyName("fuzziness");
				JsonSerializer.Serialize(writer, FuzzinessValue, options);
			}

			if (FuzzyRewriteValue is not null)
			{
				writer.WritePropertyName("fuzzy_rewrite");
				JsonSerializer.Serialize(writer, FuzzyRewriteValue, options);
			}

			if (FuzzyTranspositionsValue.HasValue)
			{
				writer.WritePropertyName("fuzzy_transpositions");
				writer.WriteBooleanValue(FuzzyTranspositionsValue.Value);
			}

			if (LenientValue.HasValue)
			{
				writer.WritePropertyName("lenient");
				writer.WriteBooleanValue(LenientValue.Value);
			}

			if (MaxExpansionsValue.HasValue)
			{
				writer.WritePropertyName("max_expansions");
				writer.WriteNumberValue(MaxExpansionsValue.Value);
			}

			if (MinimumShouldMatchValue is not null)
			{
				writer.WritePropertyName("minimum_should_match");
				JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
			}

			if (OperatorValue is not null)
			{
				writer.WritePropertyName("operator");
				JsonSerializer.Serialize(writer, OperatorValue, options);
			}

			if (PrefixLengthValue.HasValue)
			{
				writer.WritePropertyName("prefix_length");
				writer.WriteNumberValue(PrefixLengthValue.Value);
			}

			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
			if (SlopValue.HasValue)
			{
				writer.WritePropertyName("slop");
				writer.WriteNumberValue(SlopValue.Value);
			}

			if (TieBreakerValue.HasValue)
			{
				writer.WritePropertyName("tie_breaker");
				writer.WriteNumberValue(TieBreakerValue.Value);
			}

			if (TypeValue is not null)
			{
				writer.WritePropertyName("type");
				JsonSerializer.Serialize(writer, TypeValue, options);
			}

			if (ZeroTermsQueryValue is not null)
			{
				writer.WritePropertyName("zero_terms_query");
				JsonSerializer.Serialize(writer, ZeroTermsQueryValue, options);
			}

			writer.WriteEndObject();
		}
	}
}