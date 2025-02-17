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

#nullable restore

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.QueryDsl;

public sealed partial class QueryStringQuery
{
	/// <summary>
	/// <para>
	/// If <c>true</c>, the wildcard characters <c>*</c> and <c>?</c> are allowed as the first character of the query string.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("allow_leading_wildcard")]
	public bool? AllowLeadingWildcard { get; set; }

	/// <summary>
	/// <para>
	/// Analyzer used to convert text in the query string into tokens.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("analyzer")]
	public string? Analyzer { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the query attempts to analyze wildcard terms in the query string.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("analyze_wildcard")]
	public bool? AnalyzeWildcard { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, match phrase queries are automatically created for multi-term synonyms.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("auto_generate_synonyms_phrase_query")]
	public bool? AutoGenerateSynonymsPhraseQuery { get; set; }

	/// <summary>
	/// <para>
	/// Floating point number used to decrease or increase the relevance scores of the query.
	/// Boost values are relative to the default value of 1.0.
	/// A boost value between 0 and 1.0 decreases the relevance score.
	/// A value greater than 1.0 increases the relevance score.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }

	/// <summary>
	/// <para>
	/// Default field to search if no field is provided in the query string.
	/// Supports wildcards (<c>*</c>).
	/// Defaults to the <c>index.query.default_field</c> index setting, which has a default value of <c>*</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("default_field")]
	public Elastic.Clients.Elasticsearch.Field? DefaultField { get; set; }

	/// <summary>
	/// <para>
	/// Default boolean logic used to interpret text in the query string if no operators are specified.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("default_operator")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperator { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, enable position increments in queries constructed from a <c>query_string</c> search.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("enable_position_increments")]
	public bool? EnablePositionIncrements { get; set; }
	[JsonInclude, JsonPropertyName("escape")]
	public bool? Escape { get; set; }

	/// <summary>
	/// <para>
	/// Array of fields to search. Supports wildcards (<c>*</c>).
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fields")]
	public Elastic.Clients.Elasticsearch.Fields? Fields { get; set; }

	/// <summary>
	/// <para>
	/// Maximum edit distance allowed for fuzzy matching.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fuzziness")]
	public Elastic.Clients.Elasticsearch.Fuzziness? Fuzziness { get; set; }

	/// <summary>
	/// <para>
	/// Maximum number of terms to which the query expands for fuzzy matching.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fuzzy_max_expansions")]
	public int? FuzzyMaxExpansions { get; set; }

	/// <summary>
	/// <para>
	/// Number of beginning characters left unchanged for fuzzy matching.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fuzzy_prefix_length")]
	public int? FuzzyPrefixLength { get; set; }

	/// <summary>
	/// <para>
	/// Method used to rewrite the query.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fuzzy_rewrite")]
	public string? FuzzyRewrite { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, edits for fuzzy matching include transpositions of two adjacent characters (for example, <c>ab</c> to <c>ba</c>).
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fuzzy_transpositions")]
	public bool? FuzzyTranspositions { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, format-based errors, such as providing a text value for a numeric field, are ignored.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("lenient")]
	public bool? Lenient { get; set; }

	/// <summary>
	/// <para>
	/// Maximum number of automaton states required for the query.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("max_determinized_states")]
	public int? MaxDeterminizedStates { get; set; }

	/// <summary>
	/// <para>
	/// Minimum number of clauses that must match for a document to be returned.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("minimum_should_match")]
	public Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

	/// <summary>
	/// <para>
	/// Maximum number of positions allowed between matching tokens for phrases.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("phrase_slop")]
	public double? PhraseSlop { get; set; }

	/// <summary>
	/// <para>
	/// Query string you wish to parse and use for search.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query")]
	public string Query { get; set; }
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	/// <summary>
	/// <para>
	/// Analyzer used to convert quoted text in the query string into tokens.
	/// For quoted text, this parameter overrides the analyzer specified in the <c>analyzer</c> parameter.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("quote_analyzer")]
	public string? QuoteAnalyzer { get; set; }

	/// <summary>
	/// <para>
	/// Suffix appended to quoted text in the query string.
	/// You can use this suffix to use a different analysis method for exact matches.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("quote_field_suffix")]
	public string? QuoteFieldSuffix { get; set; }

	/// <summary>
	/// <para>
	/// Method used to rewrite the query.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("rewrite")]
	public string? Rewrite { get; set; }

	/// <summary>
	/// <para>
	/// How to combine the queries generated from the individual search terms in the resulting <c>dis_max</c> query.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tie_breaker")]
	public double? TieBreaker { get; set; }

	/// <summary>
	/// <para>
	/// Coordinated Universal Time (UTC) offset or IANA time zone used to convert date values in the query string to UTC.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("time_zone")]
	public string? TimeZone { get; set; }

	/// <summary>
	/// <para>
	/// Determines how the query matches and scores documents.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("type")]
	public Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? Type { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.QueryDsl.Query(QueryStringQuery queryStringQuery) => Elastic.Clients.Elasticsearch.QueryDsl.Query.QueryString(queryStringQuery);
}

public sealed partial class QueryStringQueryDescriptor<TDocument> : SerializableDescriptor<QueryStringQueryDescriptor<TDocument>>
{
	internal QueryStringQueryDescriptor(Action<QueryStringQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public QueryStringQueryDescriptor() : base()
	{
	}

	private bool? AllowLeadingWildcardValue { get; set; }
	private string? AnalyzerValue { get; set; }
	private bool? AnalyzeWildcardValue { get; set; }
	private bool? AutoGenerateSynonymsPhraseQueryValue { get; set; }
	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? DefaultFieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperatorValue { get; set; }
	private bool? EnablePositionIncrementsValue { get; set; }
	private bool? EscapeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; set; }
	private int? FuzzyMaxExpansionsValue { get; set; }
	private int? FuzzyPrefixLengthValue { get; set; }
	private string? FuzzyRewriteValue { get; set; }
	private bool? FuzzyTranspositionsValue { get; set; }
	private bool? LenientValue { get; set; }
	private int? MaxDeterminizedStatesValue { get; set; }
	private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }
	private double? PhraseSlopValue { get; set; }
	private string QueryValue { get; set; }
	private string? QueryNameValue { get; set; }
	private string? QuoteAnalyzerValue { get; set; }
	private string? QuoteFieldSuffixValue { get; set; }
	private string? RewriteValue { get; set; }
	private double? TieBreakerValue { get; set; }
	private string? TimeZoneValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? TypeValue { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the wildcard characters <c>*</c> and <c>?</c> are allowed as the first character of the query string.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> AllowLeadingWildcard(bool? allowLeadingWildcard = true)
	{
		AllowLeadingWildcardValue = allowLeadingWildcard;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Analyzer used to convert text in the query string into tokens.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> Analyzer(string? analyzer)
	{
		AnalyzerValue = analyzer;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, the query attempts to analyze wildcard terms in the query string.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> AnalyzeWildcard(bool? analyzeWildcard = true)
	{
		AnalyzeWildcardValue = analyzeWildcard;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, match phrase queries are automatically created for multi-term synonyms.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> AutoGenerateSynonymsPhraseQuery(bool? autoGenerateSynonymsPhraseQuery = true)
	{
		AutoGenerateSynonymsPhraseQueryValue = autoGenerateSynonymsPhraseQuery;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Floating point number used to decrease or increase the relevance scores of the query.
	/// Boost values are relative to the default value of 1.0.
	/// A boost value between 0 and 1.0 decreases the relevance score.
	/// A value greater than 1.0 increases the relevance score.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Default field to search if no field is provided in the query string.
	/// Supports wildcards (<c>*</c>).
	/// Defaults to the <c>index.query.default_field</c> index setting, which has a default value of <c>*</c>.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> DefaultField(Elastic.Clients.Elasticsearch.Field? defaultField)
	{
		DefaultFieldValue = defaultField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Default field to search if no field is provided in the query string.
	/// Supports wildcards (<c>*</c>).
	/// Defaults to the <c>index.query.default_field</c> index setting, which has a default value of <c>*</c>.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> DefaultField<TValue>(Expression<Func<TDocument, TValue>> defaultField)
	{
		DefaultFieldValue = defaultField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Default field to search if no field is provided in the query string.
	/// Supports wildcards (<c>*</c>).
	/// Defaults to the <c>index.query.default_field</c> index setting, which has a default value of <c>*</c>.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> DefaultField(Expression<Func<TDocument, object>> defaultField)
	{
		DefaultFieldValue = defaultField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Default boolean logic used to interpret text in the query string if no operators are specified.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> DefaultOperator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? defaultOperator)
	{
		DefaultOperatorValue = defaultOperator;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, enable position increments in queries constructed from a <c>query_string</c> search.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> EnablePositionIncrements(bool? enablePositionIncrements = true)
	{
		EnablePositionIncrementsValue = enablePositionIncrements;
		return Self;
	}

	public QueryStringQueryDescriptor<TDocument> Escape(bool? escape = true)
	{
		EscapeValue = escape;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Array of fields to search. Supports wildcards (<c>*</c>).
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Maximum edit distance allowed for fuzzy matching.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness)
	{
		FuzzinessValue = fuzziness;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Maximum number of terms to which the query expands for fuzzy matching.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> FuzzyMaxExpansions(int? fuzzyMaxExpansions)
	{
		FuzzyMaxExpansionsValue = fuzzyMaxExpansions;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Number of beginning characters left unchanged for fuzzy matching.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> FuzzyPrefixLength(int? fuzzyPrefixLength)
	{
		FuzzyPrefixLengthValue = fuzzyPrefixLength;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Method used to rewrite the query.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> FuzzyRewrite(string? fuzzyRewrite)
	{
		FuzzyRewriteValue = fuzzyRewrite;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, edits for fuzzy matching include transpositions of two adjacent characters (for example, <c>ab</c> to <c>ba</c>).
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> FuzzyTranspositions(bool? fuzzyTranspositions = true)
	{
		FuzzyTranspositionsValue = fuzzyTranspositions;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, format-based errors, such as providing a text value for a numeric field, are ignored.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> Lenient(bool? lenient = true)
	{
		LenientValue = lenient;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Maximum number of automaton states required for the query.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> MaxDeterminizedStates(int? maxDeterminizedStates)
	{
		MaxDeterminizedStatesValue = maxDeterminizedStates;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Minimum number of clauses that must match for a document to be returned.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
	{
		MinimumShouldMatchValue = minimumShouldMatch;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Maximum number of positions allowed between matching tokens for phrases.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> PhraseSlop(double? phraseSlop)
	{
		PhraseSlopValue = phraseSlop;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Query string you wish to parse and use for search.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> Query(string query)
	{
		QueryValue = query;
		return Self;
	}

	public QueryStringQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Analyzer used to convert quoted text in the query string into tokens.
	/// For quoted text, this parameter overrides the analyzer specified in the <c>analyzer</c> parameter.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> QuoteAnalyzer(string? quoteAnalyzer)
	{
		QuoteAnalyzerValue = quoteAnalyzer;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Suffix appended to quoted text in the query string.
	/// You can use this suffix to use a different analysis method for exact matches.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> QuoteFieldSuffix(string? quoteFieldSuffix)
	{
		QuoteFieldSuffixValue = quoteFieldSuffix;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Method used to rewrite the query.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> Rewrite(string? rewrite)
	{
		RewriteValue = rewrite;
		return Self;
	}

	/// <summary>
	/// <para>
	/// How to combine the queries generated from the individual search terms in the resulting <c>dis_max</c> query.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> TieBreaker(double? tieBreaker)
	{
		TieBreakerValue = tieBreaker;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Coordinated Universal Time (UTC) offset or IANA time zone used to convert date values in the query string to UTC.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> TimeZone(string? timeZone)
	{
		TimeZoneValue = timeZone;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Determines how the query matches and scores documents.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor<TDocument> Type(Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? type)
	{
		TypeValue = type;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AllowLeadingWildcardValue.HasValue)
		{
			writer.WritePropertyName("allow_leading_wildcard");
			writer.WriteBooleanValue(AllowLeadingWildcardValue.Value);
		}

		if (!string.IsNullOrEmpty(AnalyzerValue))
		{
			writer.WritePropertyName("analyzer");
			writer.WriteStringValue(AnalyzerValue);
		}

		if (AnalyzeWildcardValue.HasValue)
		{
			writer.WritePropertyName("analyze_wildcard");
			writer.WriteBooleanValue(AnalyzeWildcardValue.Value);
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

		if (DefaultFieldValue is not null)
		{
			writer.WritePropertyName("default_field");
			JsonSerializer.Serialize(writer, DefaultFieldValue, options);
		}

		if (DefaultOperatorValue is not null)
		{
			writer.WritePropertyName("default_operator");
			JsonSerializer.Serialize(writer, DefaultOperatorValue, options);
		}

		if (EnablePositionIncrementsValue.HasValue)
		{
			writer.WritePropertyName("enable_position_increments");
			writer.WriteBooleanValue(EnablePositionIncrementsValue.Value);
		}

		if (EscapeValue.HasValue)
		{
			writer.WritePropertyName("escape");
			writer.WriteBooleanValue(EscapeValue.Value);
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

		if (FuzzyMaxExpansionsValue.HasValue)
		{
			writer.WritePropertyName("fuzzy_max_expansions");
			writer.WriteNumberValue(FuzzyMaxExpansionsValue.Value);
		}

		if (FuzzyPrefixLengthValue.HasValue)
		{
			writer.WritePropertyName("fuzzy_prefix_length");
			writer.WriteNumberValue(FuzzyPrefixLengthValue.Value);
		}

		if (!string.IsNullOrEmpty(FuzzyRewriteValue))
		{
			writer.WritePropertyName("fuzzy_rewrite");
			writer.WriteStringValue(FuzzyRewriteValue);
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

		if (MaxDeterminizedStatesValue.HasValue)
		{
			writer.WritePropertyName("max_determinized_states");
			writer.WriteNumberValue(MaxDeterminizedStatesValue.Value);
		}

		if (MinimumShouldMatchValue is not null)
		{
			writer.WritePropertyName("minimum_should_match");
			JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
		}

		if (PhraseSlopValue.HasValue)
		{
			writer.WritePropertyName("phrase_slop");
			writer.WriteNumberValue(PhraseSlopValue.Value);
		}

		writer.WritePropertyName("query");
		writer.WriteStringValue(QueryValue);
		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (!string.IsNullOrEmpty(QuoteAnalyzerValue))
		{
			writer.WritePropertyName("quote_analyzer");
			writer.WriteStringValue(QuoteAnalyzerValue);
		}

		if (!string.IsNullOrEmpty(QuoteFieldSuffixValue))
		{
			writer.WritePropertyName("quote_field_suffix");
			writer.WriteStringValue(QuoteFieldSuffixValue);
		}

		if (!string.IsNullOrEmpty(RewriteValue))
		{
			writer.WritePropertyName("rewrite");
			writer.WriteStringValue(RewriteValue);
		}

		if (TieBreakerValue.HasValue)
		{
			writer.WritePropertyName("tie_breaker");
			writer.WriteNumberValue(TieBreakerValue.Value);
		}

		if (!string.IsNullOrEmpty(TimeZoneValue))
		{
			writer.WritePropertyName("time_zone");
			writer.WriteStringValue(TimeZoneValue);
		}

		if (TypeValue is not null)
		{
			writer.WritePropertyName("type");
			JsonSerializer.Serialize(writer, TypeValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class QueryStringQueryDescriptor : SerializableDescriptor<QueryStringQueryDescriptor>
{
	internal QueryStringQueryDescriptor(Action<QueryStringQueryDescriptor> configure) => configure.Invoke(this);

	public QueryStringQueryDescriptor() : base()
	{
	}

	private bool? AllowLeadingWildcardValue { get; set; }
	private string? AnalyzerValue { get; set; }
	private bool? AnalyzeWildcardValue { get; set; }
	private bool? AutoGenerateSynonymsPhraseQueryValue { get; set; }
	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? DefaultFieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperatorValue { get; set; }
	private bool? EnablePositionIncrementsValue { get; set; }
	private bool? EscapeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; set; }
	private int? FuzzyMaxExpansionsValue { get; set; }
	private int? FuzzyPrefixLengthValue { get; set; }
	private string? FuzzyRewriteValue { get; set; }
	private bool? FuzzyTranspositionsValue { get; set; }
	private bool? LenientValue { get; set; }
	private int? MaxDeterminizedStatesValue { get; set; }
	private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }
	private double? PhraseSlopValue { get; set; }
	private string QueryValue { get; set; }
	private string? QueryNameValue { get; set; }
	private string? QuoteAnalyzerValue { get; set; }
	private string? QuoteFieldSuffixValue { get; set; }
	private string? RewriteValue { get; set; }
	private double? TieBreakerValue { get; set; }
	private string? TimeZoneValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? TypeValue { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the wildcard characters <c>*</c> and <c>?</c> are allowed as the first character of the query string.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor AllowLeadingWildcard(bool? allowLeadingWildcard = true)
	{
		AllowLeadingWildcardValue = allowLeadingWildcard;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Analyzer used to convert text in the query string into tokens.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor Analyzer(string? analyzer)
	{
		AnalyzerValue = analyzer;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, the query attempts to analyze wildcard terms in the query string.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor AnalyzeWildcard(bool? analyzeWildcard = true)
	{
		AnalyzeWildcardValue = analyzeWildcard;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, match phrase queries are automatically created for multi-term synonyms.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor AutoGenerateSynonymsPhraseQuery(bool? autoGenerateSynonymsPhraseQuery = true)
	{
		AutoGenerateSynonymsPhraseQueryValue = autoGenerateSynonymsPhraseQuery;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Floating point number used to decrease or increase the relevance scores of the query.
	/// Boost values are relative to the default value of 1.0.
	/// A boost value between 0 and 1.0 decreases the relevance score.
	/// A value greater than 1.0 increases the relevance score.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Default field to search if no field is provided in the query string.
	/// Supports wildcards (<c>*</c>).
	/// Defaults to the <c>index.query.default_field</c> index setting, which has a default value of <c>*</c>.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor DefaultField(Elastic.Clients.Elasticsearch.Field? defaultField)
	{
		DefaultFieldValue = defaultField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Default field to search if no field is provided in the query string.
	/// Supports wildcards (<c>*</c>).
	/// Defaults to the <c>index.query.default_field</c> index setting, which has a default value of <c>*</c>.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor DefaultField<TDocument, TValue>(Expression<Func<TDocument, TValue>> defaultField)
	{
		DefaultFieldValue = defaultField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Default field to search if no field is provided in the query string.
	/// Supports wildcards (<c>*</c>).
	/// Defaults to the <c>index.query.default_field</c> index setting, which has a default value of <c>*</c>.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor DefaultField<TDocument>(Expression<Func<TDocument, object>> defaultField)
	{
		DefaultFieldValue = defaultField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Default boolean logic used to interpret text in the query string if no operators are specified.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor DefaultOperator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? defaultOperator)
	{
		DefaultOperatorValue = defaultOperator;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, enable position increments in queries constructed from a <c>query_string</c> search.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor EnablePositionIncrements(bool? enablePositionIncrements = true)
	{
		EnablePositionIncrementsValue = enablePositionIncrements;
		return Self;
	}

	public QueryStringQueryDescriptor Escape(bool? escape = true)
	{
		EscapeValue = escape;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Array of fields to search. Supports wildcards (<c>*</c>).
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor Fields(Elastic.Clients.Elasticsearch.Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Maximum edit distance allowed for fuzzy matching.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness)
	{
		FuzzinessValue = fuzziness;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Maximum number of terms to which the query expands for fuzzy matching.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor FuzzyMaxExpansions(int? fuzzyMaxExpansions)
	{
		FuzzyMaxExpansionsValue = fuzzyMaxExpansions;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Number of beginning characters left unchanged for fuzzy matching.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor FuzzyPrefixLength(int? fuzzyPrefixLength)
	{
		FuzzyPrefixLengthValue = fuzzyPrefixLength;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Method used to rewrite the query.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor FuzzyRewrite(string? fuzzyRewrite)
	{
		FuzzyRewriteValue = fuzzyRewrite;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, edits for fuzzy matching include transpositions of two adjacent characters (for example, <c>ab</c> to <c>ba</c>).
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor FuzzyTranspositions(bool? fuzzyTranspositions = true)
	{
		FuzzyTranspositionsValue = fuzzyTranspositions;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, format-based errors, such as providing a text value for a numeric field, are ignored.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor Lenient(bool? lenient = true)
	{
		LenientValue = lenient;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Maximum number of automaton states required for the query.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor MaxDeterminizedStates(int? maxDeterminizedStates)
	{
		MaxDeterminizedStatesValue = maxDeterminizedStates;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Minimum number of clauses that must match for a document to be returned.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
	{
		MinimumShouldMatchValue = minimumShouldMatch;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Maximum number of positions allowed between matching tokens for phrases.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor PhraseSlop(double? phraseSlop)
	{
		PhraseSlopValue = phraseSlop;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Query string you wish to parse and use for search.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor Query(string query)
	{
		QueryValue = query;
		return Self;
	}

	public QueryStringQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Analyzer used to convert quoted text in the query string into tokens.
	/// For quoted text, this parameter overrides the analyzer specified in the <c>analyzer</c> parameter.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor QuoteAnalyzer(string? quoteAnalyzer)
	{
		QuoteAnalyzerValue = quoteAnalyzer;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Suffix appended to quoted text in the query string.
	/// You can use this suffix to use a different analysis method for exact matches.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor QuoteFieldSuffix(string? quoteFieldSuffix)
	{
		QuoteFieldSuffixValue = quoteFieldSuffix;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Method used to rewrite the query.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor Rewrite(string? rewrite)
	{
		RewriteValue = rewrite;
		return Self;
	}

	/// <summary>
	/// <para>
	/// How to combine the queries generated from the individual search terms in the resulting <c>dis_max</c> query.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor TieBreaker(double? tieBreaker)
	{
		TieBreakerValue = tieBreaker;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Coordinated Universal Time (UTC) offset or IANA time zone used to convert date values in the query string to UTC.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor TimeZone(string? timeZone)
	{
		TimeZoneValue = timeZone;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Determines how the query matches and scores documents.
	/// </para>
	/// </summary>
	public QueryStringQueryDescriptor Type(Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? type)
	{
		TypeValue = type;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AllowLeadingWildcardValue.HasValue)
		{
			writer.WritePropertyName("allow_leading_wildcard");
			writer.WriteBooleanValue(AllowLeadingWildcardValue.Value);
		}

		if (!string.IsNullOrEmpty(AnalyzerValue))
		{
			writer.WritePropertyName("analyzer");
			writer.WriteStringValue(AnalyzerValue);
		}

		if (AnalyzeWildcardValue.HasValue)
		{
			writer.WritePropertyName("analyze_wildcard");
			writer.WriteBooleanValue(AnalyzeWildcardValue.Value);
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

		if (DefaultFieldValue is not null)
		{
			writer.WritePropertyName("default_field");
			JsonSerializer.Serialize(writer, DefaultFieldValue, options);
		}

		if (DefaultOperatorValue is not null)
		{
			writer.WritePropertyName("default_operator");
			JsonSerializer.Serialize(writer, DefaultOperatorValue, options);
		}

		if (EnablePositionIncrementsValue.HasValue)
		{
			writer.WritePropertyName("enable_position_increments");
			writer.WriteBooleanValue(EnablePositionIncrementsValue.Value);
		}

		if (EscapeValue.HasValue)
		{
			writer.WritePropertyName("escape");
			writer.WriteBooleanValue(EscapeValue.Value);
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

		if (FuzzyMaxExpansionsValue.HasValue)
		{
			writer.WritePropertyName("fuzzy_max_expansions");
			writer.WriteNumberValue(FuzzyMaxExpansionsValue.Value);
		}

		if (FuzzyPrefixLengthValue.HasValue)
		{
			writer.WritePropertyName("fuzzy_prefix_length");
			writer.WriteNumberValue(FuzzyPrefixLengthValue.Value);
		}

		if (!string.IsNullOrEmpty(FuzzyRewriteValue))
		{
			writer.WritePropertyName("fuzzy_rewrite");
			writer.WriteStringValue(FuzzyRewriteValue);
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

		if (MaxDeterminizedStatesValue.HasValue)
		{
			writer.WritePropertyName("max_determinized_states");
			writer.WriteNumberValue(MaxDeterminizedStatesValue.Value);
		}

		if (MinimumShouldMatchValue is not null)
		{
			writer.WritePropertyName("minimum_should_match");
			JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
		}

		if (PhraseSlopValue.HasValue)
		{
			writer.WritePropertyName("phrase_slop");
			writer.WriteNumberValue(PhraseSlopValue.Value);
		}

		writer.WritePropertyName("query");
		writer.WriteStringValue(QueryValue);
		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (!string.IsNullOrEmpty(QuoteAnalyzerValue))
		{
			writer.WritePropertyName("quote_analyzer");
			writer.WriteStringValue(QuoteAnalyzerValue);
		}

		if (!string.IsNullOrEmpty(QuoteFieldSuffixValue))
		{
			writer.WritePropertyName("quote_field_suffix");
			writer.WriteStringValue(QuoteFieldSuffixValue);
		}

		if (!string.IsNullOrEmpty(RewriteValue))
		{
			writer.WritePropertyName("rewrite");
			writer.WriteStringValue(RewriteValue);
		}

		if (TieBreakerValue.HasValue)
		{
			writer.WritePropertyName("tie_breaker");
			writer.WriteNumberValue(TieBreakerValue.Value);
		}

		if (!string.IsNullOrEmpty(TimeZoneValue))
		{
			writer.WritePropertyName("time_zone");
			writer.WriteStringValue(TimeZoneValue);
		}

		if (TypeValue is not null)
		{
			writer.WritePropertyName("type");
			JsonSerializer.Serialize(writer, TypeValue, options);
		}

		writer.WriteEndObject();
	}
}