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

internal sealed partial class MatchBoolPrefixQueryConverter : System.Text.Json.Serialization.JsonConverter<MatchBoolPrefixQuery>
{
	private static readonly System.Text.Json.JsonEncodedText PropAnalyzer = System.Text.Json.JsonEncodedText.Encode("analyzer");
	private static readonly System.Text.Json.JsonEncodedText PropBoost = System.Text.Json.JsonEncodedText.Encode("boost");
	private static readonly System.Text.Json.JsonEncodedText PropFuzziness = System.Text.Json.JsonEncodedText.Encode("fuzziness");
	private static readonly System.Text.Json.JsonEncodedText PropFuzzyRewrite = System.Text.Json.JsonEncodedText.Encode("fuzzy_rewrite");
	private static readonly System.Text.Json.JsonEncodedText PropFuzzyTranspositions = System.Text.Json.JsonEncodedText.Encode("fuzzy_transpositions");
	private static readonly System.Text.Json.JsonEncodedText PropMaxExpansions = System.Text.Json.JsonEncodedText.Encode("max_expansions");
	private static readonly System.Text.Json.JsonEncodedText PropMinimumShouldMatch = System.Text.Json.JsonEncodedText.Encode("minimum_should_match");
	private static readonly System.Text.Json.JsonEncodedText PropOperator = System.Text.Json.JsonEncodedText.Encode("operator");
	private static readonly System.Text.Json.JsonEncodedText PropPrefixLength = System.Text.Json.JsonEncodedText.Encode("prefix_length");
	private static readonly System.Text.Json.JsonEncodedText PropQuery = System.Text.Json.JsonEncodedText.Encode("query");
	private static readonly System.Text.Json.JsonEncodedText PropQueryName = System.Text.Json.JsonEncodedText.Encode("_name");

	public override MatchBoolPrefixQuery Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<Elastic.Clients.Elasticsearch.Field> propField = default;
		reader.Read();
		propField.ReadPropertyName(ref reader, options, null);
		reader.Read();
		if (reader.TokenType is not System.Text.Json.JsonTokenType.StartObject)
		{
			var value = reader.ReadValue<string>(options, null);
			reader.Read();
			return new MatchBoolPrefixQuery { Query = value };
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<string?> propAnalyzer = default;
		LocalJsonValue<float?> propBoost = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.Fuzziness?> propFuzziness = default;
		LocalJsonValue<string?> propFuzzyRewrite = default;
		LocalJsonValue<bool?> propFuzzyTranspositions = default;
		LocalJsonValue<int?> propMaxExpansions = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.MinimumShouldMatch?> propMinimumShouldMatch = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.QueryDsl.Operator?> propOperator = default;
		LocalJsonValue<int?> propPrefixLength = default;
		LocalJsonValue<string> propQuery = default;
		LocalJsonValue<string?> propQueryName = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propAnalyzer.TryReadProperty(ref reader, options, PropAnalyzer, null))
			{
				continue;
			}

			if (propBoost.TryReadProperty(ref reader, options, PropBoost, null))
			{
				continue;
			}

			if (propFuzziness.TryReadProperty(ref reader, options, PropFuzziness, null))
			{
				continue;
			}

			if (propFuzzyRewrite.TryReadProperty(ref reader, options, PropFuzzyRewrite, null))
			{
				continue;
			}

			if (propFuzzyTranspositions.TryReadProperty(ref reader, options, PropFuzzyTranspositions, null))
			{
				continue;
			}

			if (propMaxExpansions.TryReadProperty(ref reader, options, PropMaxExpansions, null))
			{
				continue;
			}

			if (propMinimumShouldMatch.TryReadProperty(ref reader, options, PropMinimumShouldMatch, null))
			{
				continue;
			}

			if (propOperator.TryReadProperty(ref reader, options, PropOperator, null))
			{
				continue;
			}

			if (propPrefixLength.TryReadProperty(ref reader, options, PropPrefixLength, null))
			{
				continue;
			}

			if (propQuery.TryReadProperty(ref reader, options, PropQuery, null))
			{
				continue;
			}

			if (propQueryName.TryReadProperty(ref reader, options, PropQueryName, null))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		reader.Read();
		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new MatchBoolPrefixQuery
		{
			Analyzer = propAnalyzer.Value
,
			Boost = propBoost.Value
,
			Field = propField.Value
,
			Fuzziness = propFuzziness.Value
,
			FuzzyRewrite = propFuzzyRewrite.Value
,
			FuzzyTranspositions = propFuzzyTranspositions.Value
,
			MaxExpansions = propMaxExpansions.Value
,
			MinimumShouldMatch = propMinimumShouldMatch.Value
,
			Operator = propOperator.Value
,
			PrefixLength = propPrefixLength.Value
,
			Query = propQuery.Value
,
			QueryName = propQueryName.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, MatchBoolPrefixQuery value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName(options, value.Field, null);
		writer.WriteStartObject();
		writer.WriteProperty(options, PropAnalyzer, value.Analyzer, null, null);
		writer.WriteProperty(options, PropBoost, value.Boost, null, null);
		writer.WriteProperty(options, PropFuzziness, value.Fuzziness, null, null);
		writer.WriteProperty(options, PropFuzzyRewrite, value.FuzzyRewrite, null, null);
		writer.WriteProperty(options, PropFuzzyTranspositions, value.FuzzyTranspositions, null, null);
		writer.WriteProperty(options, PropMaxExpansions, value.MaxExpansions, null, null);
		writer.WriteProperty(options, PropMinimumShouldMatch, value.MinimumShouldMatch, null, null);
		writer.WriteProperty(options, PropOperator, value.Operator, null, null);
		writer.WriteProperty(options, PropPrefixLength, value.PrefixLength, null, null);
		writer.WriteProperty(options, PropQuery, value.Query, null, null);
		writer.WriteProperty(options, PropQueryName, value.QueryName, null, null);
		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(MatchBoolPrefixQueryConverter))]
public sealed partial class MatchBoolPrefixQuery
{
	public MatchBoolPrefixQuery(Elastic.Clients.Elasticsearch.Field field)
	{
		if (field is null)
			throw new ArgumentNullException(nameof(field));
		Field = field;
	}

	internal MatchBoolPrefixQuery()
	{
	}

	/// <summary>
	/// <para>
	/// Analyzer used to convert the text in the query value into tokens.
	/// </para>
	/// </summary>
	public string? Analyzer { get; set; }

	/// <summary>
	/// <para>
	/// Floating point number used to decrease or increase the relevance scores of the query.
	/// Boost values are relative to the default value of 1.0.
	/// A boost value between 0 and 1.0 decreases the relevance score.
	/// A value greater than 1.0 increases the relevance score.
	/// </para>
	/// </summary>
	public float? Boost { get; set; }
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	/// <summary>
	/// <para>
	/// Maximum edit distance allowed for matching.
	/// Can be applied to the term subqueries constructed for all terms but the final term.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Fuzziness? Fuzziness { get; set; }

	/// <summary>
	/// <para>
	/// Method used to rewrite the query.
	/// Can be applied to the term subqueries constructed for all terms but the final term.
	/// </para>
	/// </summary>
	public string? FuzzyRewrite { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, edits for fuzzy matching include transpositions of two adjacent characters (for example, <c>ab</c> to <c>ba</c>).
	/// Can be applied to the term subqueries constructed for all terms but the final term.
	/// </para>
	/// </summary>
	public bool? FuzzyTranspositions { get; set; }

	/// <summary>
	/// <para>
	/// Maximum number of terms to which the query will expand.
	/// Can be applied to the term subqueries constructed for all terms but the final term.
	/// </para>
	/// </summary>
	public int? MaxExpansions { get; set; }

	/// <summary>
	/// <para>
	/// Minimum number of clauses that must match for a document to be returned.
	/// Applied to the constructed bool query.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

	/// <summary>
	/// <para>
	/// Boolean logic used to interpret text in the query value.
	/// Applied to the constructed bool query.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.QueryDsl.Operator? Operator { get; set; }

	/// <summary>
	/// <para>
	/// Number of beginning characters left unchanged for fuzzy matching.
	/// Can be applied to the term subqueries constructed for all terms but the final term.
	/// </para>
	/// </summary>
	public int? PrefixLength { get; set; }

	/// <summary>
	/// <para>
	/// Terms you wish to find in the provided field.
	/// The last term is used in a prefix query.
	/// </para>
	/// </summary>
	public string Query { get; set; }
	public string? QueryName { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.QueryDsl.Query(MatchBoolPrefixQuery matchBoolPrefixQuery) => Elastic.Clients.Elasticsearch.QueryDsl.Query.MatchBoolPrefix(matchBoolPrefixQuery);
}

public sealed partial class MatchBoolPrefixQueryDescriptor<TDocument> : SerializableDescriptor<MatchBoolPrefixQueryDescriptor<TDocument>>
{
	internal MatchBoolPrefixQueryDescriptor(Action<MatchBoolPrefixQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public MatchBoolPrefixQueryDescriptor() : base()
	{
	}

	private string? AnalyzerValue { get; set; }
	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; set; }
	private string? FuzzyRewriteValue { get; set; }
	private bool? FuzzyTranspositionsValue { get; set; }
	private int? MaxExpansionsValue { get; set; }
	private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Operator? OperatorValue { get; set; }
	private int? PrefixLengthValue { get; set; }
	private string QueryValue { get; set; }
	private string? QueryNameValue { get; set; }

	/// <summary>
	/// <para>
	/// Analyzer used to convert the text in the query value into tokens.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor<TDocument> Analyzer(string? analyzer)
	{
		AnalyzerValue = analyzer;
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
	public MatchBoolPrefixQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public MatchBoolPrefixQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public MatchBoolPrefixQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public MatchBoolPrefixQueryDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Maximum edit distance allowed for matching.
	/// Can be applied to the term subqueries constructed for all terms but the final term.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor<TDocument> Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness)
	{
		FuzzinessValue = fuzziness;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Method used to rewrite the query.
	/// Can be applied to the term subqueries constructed for all terms but the final term.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor<TDocument> FuzzyRewrite(string? fuzzyRewrite)
	{
		FuzzyRewriteValue = fuzzyRewrite;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, edits for fuzzy matching include transpositions of two adjacent characters (for example, <c>ab</c> to <c>ba</c>).
	/// Can be applied to the term subqueries constructed for all terms but the final term.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor<TDocument> FuzzyTranspositions(bool? fuzzyTranspositions = true)
	{
		FuzzyTranspositionsValue = fuzzyTranspositions;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Maximum number of terms to which the query will expand.
	/// Can be applied to the term subqueries constructed for all terms but the final term.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor<TDocument> MaxExpansions(int? maxExpansions)
	{
		MaxExpansionsValue = maxExpansions;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Minimum number of clauses that must match for a document to be returned.
	/// Applied to the constructed bool query.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor<TDocument> MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
	{
		MinimumShouldMatchValue = minimumShouldMatch;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Boolean logic used to interpret text in the query value.
	/// Applied to the constructed bool query.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor<TDocument> Operator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? value)
	{
		OperatorValue = value;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Number of beginning characters left unchanged for fuzzy matching.
	/// Can be applied to the term subqueries constructed for all terms but the final term.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor<TDocument> PrefixLength(int? prefixLength)
	{
		PrefixLengthValue = prefixLength;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Terms you wish to find in the provided field.
	/// The last term is used in a prefix query.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor<TDocument> Query(string query)
	{
		QueryValue = query;
		return Self;
	}

	public MatchBoolPrefixQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (FieldValue is null)
			throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(AnalyzerValue))
		{
			writer.WritePropertyName("analyzer");
			writer.WriteStringValue(AnalyzerValue);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (FuzzinessValue is not null)
		{
			writer.WritePropertyName("fuzziness");
			JsonSerializer.Serialize(writer, FuzzinessValue, options);
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
		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}

public sealed partial class MatchBoolPrefixQueryDescriptor : SerializableDescriptor<MatchBoolPrefixQueryDescriptor>
{
	internal MatchBoolPrefixQueryDescriptor(Action<MatchBoolPrefixQueryDescriptor> configure) => configure.Invoke(this);

	public MatchBoolPrefixQueryDescriptor() : base()
	{
	}

	private string? AnalyzerValue { get; set; }
	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; set; }
	private string? FuzzyRewriteValue { get; set; }
	private bool? FuzzyTranspositionsValue { get; set; }
	private int? MaxExpansionsValue { get; set; }
	private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Operator? OperatorValue { get; set; }
	private int? PrefixLengthValue { get; set; }
	private string QueryValue { get; set; }
	private string? QueryNameValue { get; set; }

	/// <summary>
	/// <para>
	/// Analyzer used to convert the text in the query value into tokens.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor Analyzer(string? analyzer)
	{
		AnalyzerValue = analyzer;
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
	public MatchBoolPrefixQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public MatchBoolPrefixQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public MatchBoolPrefixQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public MatchBoolPrefixQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Maximum edit distance allowed for matching.
	/// Can be applied to the term subqueries constructed for all terms but the final term.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness)
	{
		FuzzinessValue = fuzziness;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Method used to rewrite the query.
	/// Can be applied to the term subqueries constructed for all terms but the final term.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor FuzzyRewrite(string? fuzzyRewrite)
	{
		FuzzyRewriteValue = fuzzyRewrite;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, edits for fuzzy matching include transpositions of two adjacent characters (for example, <c>ab</c> to <c>ba</c>).
	/// Can be applied to the term subqueries constructed for all terms but the final term.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor FuzzyTranspositions(bool? fuzzyTranspositions = true)
	{
		FuzzyTranspositionsValue = fuzzyTranspositions;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Maximum number of terms to which the query will expand.
	/// Can be applied to the term subqueries constructed for all terms but the final term.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor MaxExpansions(int? maxExpansions)
	{
		MaxExpansionsValue = maxExpansions;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Minimum number of clauses that must match for a document to be returned.
	/// Applied to the constructed bool query.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
	{
		MinimumShouldMatchValue = minimumShouldMatch;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Boolean logic used to interpret text in the query value.
	/// Applied to the constructed bool query.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor Operator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? value)
	{
		OperatorValue = value;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Number of beginning characters left unchanged for fuzzy matching.
	/// Can be applied to the term subqueries constructed for all terms but the final term.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor PrefixLength(int? prefixLength)
	{
		PrefixLengthValue = prefixLength;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Terms you wish to find in the provided field.
	/// The last term is used in a prefix query.
	/// </para>
	/// </summary>
	public MatchBoolPrefixQueryDescriptor Query(string query)
	{
		QueryValue = query;
		return Self;
	}

	public MatchBoolPrefixQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (FieldValue is null)
			throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(AnalyzerValue))
		{
			writer.WritePropertyName("analyzer");
			writer.WriteStringValue(AnalyzerValue);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (FuzzinessValue is not null)
		{
			writer.WritePropertyName("fuzziness");
			JsonSerializer.Serialize(writer, FuzzinessValue, options);
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
		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}