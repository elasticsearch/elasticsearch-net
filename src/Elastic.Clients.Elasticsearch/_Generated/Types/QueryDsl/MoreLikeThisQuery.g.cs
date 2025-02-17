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

internal sealed partial class MoreLikeThisQueryConverter : System.Text.Json.Serialization.JsonConverter<MoreLikeThisQuery>
{
	private static readonly System.Text.Json.JsonEncodedText PropAnalyzer = System.Text.Json.JsonEncodedText.Encode("analyzer");
	private static readonly System.Text.Json.JsonEncodedText PropBoost = System.Text.Json.JsonEncodedText.Encode("boost");
	private static readonly System.Text.Json.JsonEncodedText PropBoostTerms = System.Text.Json.JsonEncodedText.Encode("boost_terms");
	private static readonly System.Text.Json.JsonEncodedText PropFailOnUnsupportedField = System.Text.Json.JsonEncodedText.Encode("fail_on_unsupported_field");
	private static readonly System.Text.Json.JsonEncodedText PropFields = System.Text.Json.JsonEncodedText.Encode("fields");
	private static readonly System.Text.Json.JsonEncodedText PropInclude = System.Text.Json.JsonEncodedText.Encode("include");
	private static readonly System.Text.Json.JsonEncodedText PropLike = System.Text.Json.JsonEncodedText.Encode("like");
	private static readonly System.Text.Json.JsonEncodedText PropMaxDocFreq = System.Text.Json.JsonEncodedText.Encode("max_doc_freq");
	private static readonly System.Text.Json.JsonEncodedText PropMaxQueryTerms = System.Text.Json.JsonEncodedText.Encode("max_query_terms");
	private static readonly System.Text.Json.JsonEncodedText PropMaxWordLength = System.Text.Json.JsonEncodedText.Encode("max_word_length");
	private static readonly System.Text.Json.JsonEncodedText PropMinDocFreq = System.Text.Json.JsonEncodedText.Encode("min_doc_freq");
	private static readonly System.Text.Json.JsonEncodedText PropMinimumShouldMatch = System.Text.Json.JsonEncodedText.Encode("minimum_should_match");
	private static readonly System.Text.Json.JsonEncodedText PropMinTermFreq = System.Text.Json.JsonEncodedText.Encode("min_term_freq");
	private static readonly System.Text.Json.JsonEncodedText PropMinWordLength = System.Text.Json.JsonEncodedText.Encode("min_word_length");
	private static readonly System.Text.Json.JsonEncodedText PropQueryName = System.Text.Json.JsonEncodedText.Encode("_name");
	private static readonly System.Text.Json.JsonEncodedText PropRouting = System.Text.Json.JsonEncodedText.Encode("routing");
	private static readonly System.Text.Json.JsonEncodedText PropStopWords = System.Text.Json.JsonEncodedText.Encode("stop_words");
	private static readonly System.Text.Json.JsonEncodedText PropUnlike = System.Text.Json.JsonEncodedText.Encode("unlike");
	private static readonly System.Text.Json.JsonEncodedText PropVersion = System.Text.Json.JsonEncodedText.Encode("version");
	private static readonly System.Text.Json.JsonEncodedText PropVersionType = System.Text.Json.JsonEncodedText.Encode("version_type");

	public override MoreLikeThisQuery Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<string?> propAnalyzer = default;
		LocalJsonValue<float?> propBoost = default;
		LocalJsonValue<double?> propBoostTerms = default;
		LocalJsonValue<bool?> propFailOnUnsupportedField = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.Fields?> propFields = default;
		LocalJsonValue<bool?> propInclude = default;
		LocalJsonValue<ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Like>> propLike = default;
		LocalJsonValue<int?> propMaxDocFreq = default;
		LocalJsonValue<int?> propMaxQueryTerms = default;
		LocalJsonValue<int?> propMaxWordLength = default;
		LocalJsonValue<int?> propMinDocFreq = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.MinimumShouldMatch?> propMinimumShouldMatch = default;
		LocalJsonValue<int?> propMinTermFreq = default;
		LocalJsonValue<int?> propMinWordLength = default;
		LocalJsonValue<string?> propQueryName = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.Routing?> propRouting = default;
		LocalJsonValue<ICollection<string>?> propStopWords = default;
		LocalJsonValue<ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Like>?> propUnlike = default;
		LocalJsonValue<long?> propVersion = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.VersionType?> propVersionType = default;
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

			if (propBoostTerms.TryReadProperty(ref reader, options, PropBoostTerms, null))
			{
				continue;
			}

			if (propFailOnUnsupportedField.TryReadProperty(ref reader, options, PropFailOnUnsupportedField, null))
			{
				continue;
			}

			if (propFields.TryReadProperty(ref reader, options, PropFields, static Elastic.Clients.Elasticsearch.Fields? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadValueEx<Elastic.Clients.Elasticsearch.Fields?>(o, typeof(SingleOrManyFieldsMarker))))
			{
				continue;
			}

			if (propInclude.TryReadProperty(ref reader, options, PropInclude, null))
			{
				continue;
			}

			if (propLike.TryReadProperty(ref reader, options, PropLike, static ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Like> (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.QueryDsl.Like>(o, null)!))
			{
				continue;
			}

			if (propMaxDocFreq.TryReadProperty(ref reader, options, PropMaxDocFreq, null))
			{
				continue;
			}

			if (propMaxQueryTerms.TryReadProperty(ref reader, options, PropMaxQueryTerms, null))
			{
				continue;
			}

			if (propMaxWordLength.TryReadProperty(ref reader, options, PropMaxWordLength, null))
			{
				continue;
			}

			if (propMinDocFreq.TryReadProperty(ref reader, options, PropMinDocFreq, null))
			{
				continue;
			}

			if (propMinimumShouldMatch.TryReadProperty(ref reader, options, PropMinimumShouldMatch, null))
			{
				continue;
			}

			if (propMinTermFreq.TryReadProperty(ref reader, options, PropMinTermFreq, null))
			{
				continue;
			}

			if (propMinWordLength.TryReadProperty(ref reader, options, PropMinWordLength, null))
			{
				continue;
			}

			if (propQueryName.TryReadProperty(ref reader, options, PropQueryName, null))
			{
				continue;
			}

			if (propRouting.TryReadProperty(ref reader, options, PropRouting, null))
			{
				continue;
			}

			if (propStopWords.TryReadProperty(ref reader, options, PropStopWords, static ICollection<string>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadSingleOrManyCollectionValue<string>(o, null)))
			{
				continue;
			}

			if (propUnlike.TryReadProperty(ref reader, options, PropUnlike, static ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Like>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.QueryDsl.Like>(o, null)))
			{
				continue;
			}

			if (propVersion.TryReadProperty(ref reader, options, PropVersion, null))
			{
				continue;
			}

			if (propVersionType.TryReadProperty(ref reader, options, PropVersionType, null))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new MoreLikeThisQuery
		{
			Analyzer = propAnalyzer.Value
,
			Boost = propBoost.Value
,
			BoostTerms = propBoostTerms.Value
,
			FailOnUnsupportedField = propFailOnUnsupportedField.Value
,
			Fields = propFields.Value
,
			Include = propInclude.Value
,
			Like = propLike.Value
,
			MaxDocFreq = propMaxDocFreq.Value
,
			MaxQueryTerms = propMaxQueryTerms.Value
,
			MaxWordLength = propMaxWordLength.Value
,
			MinDocFreq = propMinDocFreq.Value
,
			MinimumShouldMatch = propMinimumShouldMatch.Value
,
			MinTermFreq = propMinTermFreq.Value
,
			MinWordLength = propMinWordLength.Value
,
			QueryName = propQueryName.Value
,
			Routing = propRouting.Value
,
			StopWords = propStopWords.Value
,
			Unlike = propUnlike.Value
,
			Version = propVersion.Value
,
			VersionType = propVersionType.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, MoreLikeThisQuery value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropAnalyzer, value.Analyzer, null, null);
		writer.WriteProperty(options, PropBoost, value.Boost, null, null);
		writer.WriteProperty(options, PropBoostTerms, value.BoostTerms, null, null);
		writer.WriteProperty(options, PropFailOnUnsupportedField, value.FailOnUnsupportedField, null, null);
		writer.WriteProperty(options, PropFields, value.Fields, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, Elastic.Clients.Elasticsearch.Fields? v) => w.WriteValueEx<Elastic.Clients.Elasticsearch.Fields?>(o, v, typeof(SingleOrManyFieldsMarker)));
		writer.WriteProperty(options, PropInclude, value.Include, null, null);
		writer.WriteProperty(options, PropLike, value.Like, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Like> v) => w.WriteSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.QueryDsl.Like>(o, v, null));
		writer.WriteProperty(options, PropMaxDocFreq, value.MaxDocFreq, null, null);
		writer.WriteProperty(options, PropMaxQueryTerms, value.MaxQueryTerms, null, null);
		writer.WriteProperty(options, PropMaxWordLength, value.MaxWordLength, null, null);
		writer.WriteProperty(options, PropMinDocFreq, value.MinDocFreq, null, null);
		writer.WriteProperty(options, PropMinimumShouldMatch, value.MinimumShouldMatch, null, null);
		writer.WriteProperty(options, PropMinTermFreq, value.MinTermFreq, null, null);
		writer.WriteProperty(options, PropMinWordLength, value.MinWordLength, null, null);
		writer.WriteProperty(options, PropQueryName, value.QueryName, null, null);
		writer.WriteProperty(options, PropRouting, value.Routing, null, null);
		writer.WriteProperty(options, PropStopWords, value.StopWords, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<string>? v) => w.WriteSingleOrManyCollectionValue<string>(o, v, null));
		writer.WriteProperty(options, PropUnlike, value.Unlike, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Like>? v) => w.WriteSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.QueryDsl.Like>(o, v, null));
		writer.WriteProperty(options, PropVersion, value.Version, null, null);
		writer.WriteProperty(options, PropVersionType, value.VersionType, null, null);
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(MoreLikeThisQueryConverter))]
public sealed partial class MoreLikeThisQuery
{
	/// <summary>
	/// <para>
	/// The analyzer that is used to analyze the free form text.
	/// Defaults to the analyzer associated with the first field in fields.
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

	/// <summary>
	/// <para>
	/// Each term in the formed query could be further boosted by their tf-idf score.
	/// This sets the boost factor to use when using this feature.
	/// Defaults to deactivated (0).
	/// </para>
	/// </summary>
	public double? BoostTerms { get; set; }

	/// <summary>
	/// <para>
	/// Controls whether the query should fail (throw an exception) if any of the specified fields are not of the supported types (<c>text</c> or <c>keyword</c>).
	/// </para>
	/// </summary>
	public bool? FailOnUnsupportedField { get; set; }

	/// <summary>
	/// <para>
	/// A list of fields to fetch and analyze the text from.
	/// Defaults to the <c>index.query.default_field</c> index setting, which has a default value of <c>*</c>.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Fields? Fields { get; set; }

	/// <summary>
	/// <para>
	/// Specifies whether the input documents should also be included in the search results returned.
	/// </para>
	/// </summary>
	public bool? Include { get; set; }

	/// <summary>
	/// <para>
	/// Specifies free form text and/or a single or multiple documents for which you want to find similar documents.
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Like> Like { get; set; }

	/// <summary>
	/// <para>
	/// The maximum document frequency above which the terms are ignored from the input document.
	/// </para>
	/// </summary>
	public int? MaxDocFreq { get; set; }

	/// <summary>
	/// <para>
	/// The maximum number of query terms that can be selected.
	/// </para>
	/// </summary>
	public int? MaxQueryTerms { get; set; }

	/// <summary>
	/// <para>
	/// The maximum word length above which the terms are ignored.
	/// Defaults to unbounded (<c>0</c>).
	/// </para>
	/// </summary>
	public int? MaxWordLength { get; set; }

	/// <summary>
	/// <para>
	/// The minimum document frequency below which the terms are ignored from the input document.
	/// </para>
	/// </summary>
	public int? MinDocFreq { get; set; }

	/// <summary>
	/// <para>
	/// After the disjunctive query has been formed, this parameter controls the number of terms that must match.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

	/// <summary>
	/// <para>
	/// The minimum term frequency below which the terms are ignored from the input document.
	/// </para>
	/// </summary>
	public int? MinTermFreq { get; set; }

	/// <summary>
	/// <para>
	/// The minimum word length below which the terms are ignored.
	/// </para>
	/// </summary>
	public int? MinWordLength { get; set; }
	public string? QueryName { get; set; }
	public Elastic.Clients.Elasticsearch.Routing? Routing { get; set; }

	/// <summary>
	/// <para>
	/// An array of stop words.
	/// Any word in this set is ignored.
	/// </para>
	/// </summary>
	public ICollection<string>? StopWords { get; set; }

	/// <summary>
	/// <para>
	/// Used in combination with <c>like</c> to exclude documents that match a set of terms.
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Like>? Unlike { get; set; }
	public long? Version { get; set; }
	public Elastic.Clients.Elasticsearch.VersionType? VersionType { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.QueryDsl.Query(MoreLikeThisQuery moreLikeThisQuery) => Elastic.Clients.Elasticsearch.QueryDsl.Query.MoreLikeThis(moreLikeThisQuery);
}

public sealed partial class MoreLikeThisQueryDescriptor<TDocument> : SerializableDescriptor<MoreLikeThisQueryDescriptor<TDocument>>
{
	internal MoreLikeThisQueryDescriptor(Action<MoreLikeThisQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public MoreLikeThisQueryDescriptor() : base()
	{
	}

	private string? AnalyzerValue { get; set; }
	private float? BoostValue { get; set; }
	private double? BoostTermsValue { get; set; }
	private bool? FailOnUnsupportedFieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }
	private bool? IncludeValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Like> LikeValue { get; set; }
	private int? MaxDocFreqValue { get; set; }
	private int? MaxQueryTermsValue { get; set; }
	private int? MaxWordLengthValue { get; set; }
	private int? MinDocFreqValue { get; set; }
	private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }
	private int? MinTermFreqValue { get; set; }
	private int? MinWordLengthValue { get; set; }
	private string? QueryNameValue { get; set; }
	private Elastic.Clients.Elasticsearch.Routing? RoutingValue { get; set; }
	private ICollection<string>? StopWordsValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Like>? UnlikeValue { get; set; }
	private long? VersionValue { get; set; }
	private Elastic.Clients.Elasticsearch.VersionType? VersionTypeValue { get; set; }

	/// <summary>
	/// <para>
	/// The analyzer that is used to analyze the free form text.
	/// Defaults to the analyzer associated with the first field in fields.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor<TDocument> Analyzer(string? analyzer)
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
	public MoreLikeThisQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Each term in the formed query could be further boosted by their tf-idf score.
	/// This sets the boost factor to use when using this feature.
	/// Defaults to deactivated (0).
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor<TDocument> BoostTerms(double? boostTerms)
	{
		BoostTermsValue = boostTerms;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Controls whether the query should fail (throw an exception) if any of the specified fields are not of the supported types (<c>text</c> or <c>keyword</c>).
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor<TDocument> FailOnUnsupportedField(bool? failOnUnsupportedField = true)
	{
		FailOnUnsupportedFieldValue = failOnUnsupportedField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A list of fields to fetch and analyze the text from.
	/// Defaults to the <c>index.query.default_field</c> index setting, which has a default value of <c>*</c>.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Specifies whether the input documents should also be included in the search results returned.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor<TDocument> Include(bool? include = true)
	{
		IncludeValue = include;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Specifies free form text and/or a single or multiple documents for which you want to find similar documents.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor<TDocument> Like(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Like> like)
	{
		LikeValue = like;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The maximum document frequency above which the terms are ignored from the input document.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor<TDocument> MaxDocFreq(int? maxDocFreq)
	{
		MaxDocFreqValue = maxDocFreq;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The maximum number of query terms that can be selected.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor<TDocument> MaxQueryTerms(int? maxQueryTerms)
	{
		MaxQueryTermsValue = maxQueryTerms;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The maximum word length above which the terms are ignored.
	/// Defaults to unbounded (<c>0</c>).
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor<TDocument> MaxWordLength(int? maxWordLength)
	{
		MaxWordLengthValue = maxWordLength;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The minimum document frequency below which the terms are ignored from the input document.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor<TDocument> MinDocFreq(int? minDocFreq)
	{
		MinDocFreqValue = minDocFreq;
		return Self;
	}

	/// <summary>
	/// <para>
	/// After the disjunctive query has been formed, this parameter controls the number of terms that must match.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor<TDocument> MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
	{
		MinimumShouldMatchValue = minimumShouldMatch;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The minimum term frequency below which the terms are ignored from the input document.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor<TDocument> MinTermFreq(int? minTermFreq)
	{
		MinTermFreqValue = minTermFreq;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The minimum word length below which the terms are ignored.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor<TDocument> MinWordLength(int? minWordLength)
	{
		MinWordLengthValue = minWordLength;
		return Self;
	}

	public MoreLikeThisQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public MoreLikeThisQueryDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing)
	{
		RoutingValue = routing;
		return Self;
	}

	/// <summary>
	/// <para>
	/// An array of stop words.
	/// Any word in this set is ignored.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor<TDocument> StopWords(ICollection<string>? stopWords)
	{
		StopWordsValue = stopWords;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Used in combination with <c>like</c> to exclude documents that match a set of terms.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor<TDocument> Unlike(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Like>? unlike)
	{
		UnlikeValue = unlike;
		return Self;
	}

	public MoreLikeThisQueryDescriptor<TDocument> Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	public MoreLikeThisQueryDescriptor<TDocument> VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType)
	{
		VersionTypeValue = versionType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
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

		if (BoostTermsValue.HasValue)
		{
			writer.WritePropertyName("boost_terms");
			writer.WriteNumberValue(BoostTermsValue.Value);
		}

		if (FailOnUnsupportedFieldValue.HasValue)
		{
			writer.WritePropertyName("fail_on_unsupported_field");
			writer.WriteBooleanValue(FailOnUnsupportedFieldValue.Value);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (IncludeValue.HasValue)
		{
			writer.WritePropertyName("include");
			writer.WriteBooleanValue(IncludeValue.Value);
		}

		writer.WritePropertyName("like");
		SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Like>(LikeValue, writer, options);
		if (MaxDocFreqValue.HasValue)
		{
			writer.WritePropertyName("max_doc_freq");
			writer.WriteNumberValue(MaxDocFreqValue.Value);
		}

		if (MaxQueryTermsValue.HasValue)
		{
			writer.WritePropertyName("max_query_terms");
			writer.WriteNumberValue(MaxQueryTermsValue.Value);
		}

		if (MaxWordLengthValue.HasValue)
		{
			writer.WritePropertyName("max_word_length");
			writer.WriteNumberValue(MaxWordLengthValue.Value);
		}

		if (MinDocFreqValue.HasValue)
		{
			writer.WritePropertyName("min_doc_freq");
			writer.WriteNumberValue(MinDocFreqValue.Value);
		}

		if (MinimumShouldMatchValue is not null)
		{
			writer.WritePropertyName("minimum_should_match");
			JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
		}

		if (MinTermFreqValue.HasValue)
		{
			writer.WritePropertyName("min_term_freq");
			writer.WriteNumberValue(MinTermFreqValue.Value);
		}

		if (MinWordLengthValue.HasValue)
		{
			writer.WritePropertyName("min_word_length");
			writer.WriteNumberValue(MinWordLengthValue.Value);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (RoutingValue is not null)
		{
			writer.WritePropertyName("routing");
			JsonSerializer.Serialize(writer, RoutingValue, options);
		}

		if (StopWordsValue is not null)
		{
			writer.WritePropertyName("stop_words");
			SingleOrManySerializationHelper.Serialize<string>(StopWordsValue, writer, options);
		}

		if (UnlikeValue is not null)
		{
			writer.WritePropertyName("unlike");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Like>(UnlikeValue, writer, options);
		}

		if (VersionValue.HasValue)
		{
			writer.WritePropertyName("version");
			writer.WriteNumberValue(VersionValue.Value);
		}

		if (VersionTypeValue is not null)
		{
			writer.WritePropertyName("version_type");
			JsonSerializer.Serialize(writer, VersionTypeValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class MoreLikeThisQueryDescriptor : SerializableDescriptor<MoreLikeThisQueryDescriptor>
{
	internal MoreLikeThisQueryDescriptor(Action<MoreLikeThisQueryDescriptor> configure) => configure.Invoke(this);

	public MoreLikeThisQueryDescriptor() : base()
	{
	}

	private string? AnalyzerValue { get; set; }
	private float? BoostValue { get; set; }
	private double? BoostTermsValue { get; set; }
	private bool? FailOnUnsupportedFieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }
	private bool? IncludeValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Like> LikeValue { get; set; }
	private int? MaxDocFreqValue { get; set; }
	private int? MaxQueryTermsValue { get; set; }
	private int? MaxWordLengthValue { get; set; }
	private int? MinDocFreqValue { get; set; }
	private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }
	private int? MinTermFreqValue { get; set; }
	private int? MinWordLengthValue { get; set; }
	private string? QueryNameValue { get; set; }
	private Elastic.Clients.Elasticsearch.Routing? RoutingValue { get; set; }
	private ICollection<string>? StopWordsValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Like>? UnlikeValue { get; set; }
	private long? VersionValue { get; set; }
	private Elastic.Clients.Elasticsearch.VersionType? VersionTypeValue { get; set; }

	/// <summary>
	/// <para>
	/// The analyzer that is used to analyze the free form text.
	/// Defaults to the analyzer associated with the first field in fields.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor Analyzer(string? analyzer)
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
	public MoreLikeThisQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Each term in the formed query could be further boosted by their tf-idf score.
	/// This sets the boost factor to use when using this feature.
	/// Defaults to deactivated (0).
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor BoostTerms(double? boostTerms)
	{
		BoostTermsValue = boostTerms;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Controls whether the query should fail (throw an exception) if any of the specified fields are not of the supported types (<c>text</c> or <c>keyword</c>).
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor FailOnUnsupportedField(bool? failOnUnsupportedField = true)
	{
		FailOnUnsupportedFieldValue = failOnUnsupportedField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A list of fields to fetch and analyze the text from.
	/// Defaults to the <c>index.query.default_field</c> index setting, which has a default value of <c>*</c>.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor Fields(Elastic.Clients.Elasticsearch.Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Specifies whether the input documents should also be included in the search results returned.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor Include(bool? include = true)
	{
		IncludeValue = include;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Specifies free form text and/or a single or multiple documents for which you want to find similar documents.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor Like(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Like> like)
	{
		LikeValue = like;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The maximum document frequency above which the terms are ignored from the input document.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor MaxDocFreq(int? maxDocFreq)
	{
		MaxDocFreqValue = maxDocFreq;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The maximum number of query terms that can be selected.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor MaxQueryTerms(int? maxQueryTerms)
	{
		MaxQueryTermsValue = maxQueryTerms;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The maximum word length above which the terms are ignored.
	/// Defaults to unbounded (<c>0</c>).
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor MaxWordLength(int? maxWordLength)
	{
		MaxWordLengthValue = maxWordLength;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The minimum document frequency below which the terms are ignored from the input document.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor MinDocFreq(int? minDocFreq)
	{
		MinDocFreqValue = minDocFreq;
		return Self;
	}

	/// <summary>
	/// <para>
	/// After the disjunctive query has been formed, this parameter controls the number of terms that must match.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
	{
		MinimumShouldMatchValue = minimumShouldMatch;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The minimum term frequency below which the terms are ignored from the input document.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor MinTermFreq(int? minTermFreq)
	{
		MinTermFreqValue = minTermFreq;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The minimum word length below which the terms are ignored.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor MinWordLength(int? minWordLength)
	{
		MinWordLengthValue = minWordLength;
		return Self;
	}

	public MoreLikeThisQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public MoreLikeThisQueryDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing)
	{
		RoutingValue = routing;
		return Self;
	}

	/// <summary>
	/// <para>
	/// An array of stop words.
	/// Any word in this set is ignored.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor StopWords(ICollection<string>? stopWords)
	{
		StopWordsValue = stopWords;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Used in combination with <c>like</c> to exclude documents that match a set of terms.
	/// </para>
	/// </summary>
	public MoreLikeThisQueryDescriptor Unlike(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Like>? unlike)
	{
		UnlikeValue = unlike;
		return Self;
	}

	public MoreLikeThisQueryDescriptor Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	public MoreLikeThisQueryDescriptor VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType)
	{
		VersionTypeValue = versionType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
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

		if (BoostTermsValue.HasValue)
		{
			writer.WritePropertyName("boost_terms");
			writer.WriteNumberValue(BoostTermsValue.Value);
		}

		if (FailOnUnsupportedFieldValue.HasValue)
		{
			writer.WritePropertyName("fail_on_unsupported_field");
			writer.WriteBooleanValue(FailOnUnsupportedFieldValue.Value);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (IncludeValue.HasValue)
		{
			writer.WritePropertyName("include");
			writer.WriteBooleanValue(IncludeValue.Value);
		}

		writer.WritePropertyName("like");
		SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Like>(LikeValue, writer, options);
		if (MaxDocFreqValue.HasValue)
		{
			writer.WritePropertyName("max_doc_freq");
			writer.WriteNumberValue(MaxDocFreqValue.Value);
		}

		if (MaxQueryTermsValue.HasValue)
		{
			writer.WritePropertyName("max_query_terms");
			writer.WriteNumberValue(MaxQueryTermsValue.Value);
		}

		if (MaxWordLengthValue.HasValue)
		{
			writer.WritePropertyName("max_word_length");
			writer.WriteNumberValue(MaxWordLengthValue.Value);
		}

		if (MinDocFreqValue.HasValue)
		{
			writer.WritePropertyName("min_doc_freq");
			writer.WriteNumberValue(MinDocFreqValue.Value);
		}

		if (MinimumShouldMatchValue is not null)
		{
			writer.WritePropertyName("minimum_should_match");
			JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
		}

		if (MinTermFreqValue.HasValue)
		{
			writer.WritePropertyName("min_term_freq");
			writer.WriteNumberValue(MinTermFreqValue.Value);
		}

		if (MinWordLengthValue.HasValue)
		{
			writer.WritePropertyName("min_word_length");
			writer.WriteNumberValue(MinWordLengthValue.Value);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (RoutingValue is not null)
		{
			writer.WritePropertyName("routing");
			JsonSerializer.Serialize(writer, RoutingValue, options);
		}

		if (StopWordsValue is not null)
		{
			writer.WritePropertyName("stop_words");
			SingleOrManySerializationHelper.Serialize<string>(StopWordsValue, writer, options);
		}

		if (UnlikeValue is not null)
		{
			writer.WritePropertyName("unlike");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Like>(UnlikeValue, writer, options);
		}

		if (VersionValue.HasValue)
		{
			writer.WritePropertyName("version");
			writer.WriteNumberValue(VersionValue.Value);
		}

		if (VersionTypeValue is not null)
		{
			writer.WritePropertyName("version_type");
			JsonSerializer.Serialize(writer, VersionTypeValue, options);
		}

		writer.WriteEndObject();
	}
}