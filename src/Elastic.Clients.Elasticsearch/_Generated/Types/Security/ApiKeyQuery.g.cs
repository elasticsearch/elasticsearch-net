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
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Security;

[JsonConverter(typeof(ApiKeyQueryConverter))]
public sealed partial class ApiKeyQuery
{
	internal ApiKeyQuery(string variantName, object variant)
	{
		if (variantName is null)
			throw new ArgumentNullException(nameof(variantName));
		if (variant is null)
			throw new ArgumentNullException(nameof(variant));
		if (string.IsNullOrWhiteSpace(variantName))
			throw new ArgumentException("Variant name must not be empty or whitespace.");
		VariantType = variantName;
		Variant = variant;
	}

	internal ApiKeyQuery()
	{
	}

	public object Variant { get; internal set; }
	public string VariantType { get; internal set; }

	public static ApiKeyQuery Bool(Elastic.Clients.Elasticsearch.QueryDsl.BoolQuery boolQuery) => new ApiKeyQuery("bool", boolQuery);
	public static ApiKeyQuery Exists(Elastic.Clients.Elasticsearch.QueryDsl.ExistsQuery existsQuery) => new ApiKeyQuery("exists", existsQuery);
	public static ApiKeyQuery Ids(Elastic.Clients.Elasticsearch.QueryDsl.IdsQuery idsQuery) => new ApiKeyQuery("ids", idsQuery);
	public static ApiKeyQuery Match(Elastic.Clients.Elasticsearch.QueryDsl.MatchQuery matchQuery) => new ApiKeyQuery("match", matchQuery);
	public static ApiKeyQuery MatchAll(Elastic.Clients.Elasticsearch.QueryDsl.MatchAllQuery matchAllQuery) => new ApiKeyQuery("match_all", matchAllQuery);
	public static ApiKeyQuery Prefix(Elastic.Clients.Elasticsearch.QueryDsl.PrefixQuery prefixQuery) => new ApiKeyQuery("prefix", prefixQuery);
	public static ApiKeyQuery Range(Elastic.Clients.Elasticsearch.QueryDsl.IRangeQuery rangeQuery) => new ApiKeyQuery("range", rangeQuery);
	public static ApiKeyQuery Range(Elastic.Clients.Elasticsearch.QueryDsl.UntypedRangeQuery rangeQuery) => new ApiKeyQuery("range", rangeQuery);
	public static ApiKeyQuery Range(Elastic.Clients.Elasticsearch.QueryDsl.DateRangeQuery rangeQuery) => new ApiKeyQuery("range", rangeQuery);
	public static ApiKeyQuery Range(Elastic.Clients.Elasticsearch.QueryDsl.NumberRangeQuery rangeQuery) => new ApiKeyQuery("range", rangeQuery);
	public static ApiKeyQuery Range(Elastic.Clients.Elasticsearch.QueryDsl.TermRangeQuery rangeQuery) => new ApiKeyQuery("range", rangeQuery);
	public static ApiKeyQuery SimpleQueryString(Elastic.Clients.Elasticsearch.QueryDsl.SimpleQueryStringQuery simpleQueryStringQuery) => new ApiKeyQuery("simple_query_string", simpleQueryStringQuery);
	public static ApiKeyQuery Term(Elastic.Clients.Elasticsearch.QueryDsl.TermQuery termQuery) => new ApiKeyQuery("term", termQuery);
	public static ApiKeyQuery Terms(Elastic.Clients.Elasticsearch.QueryDsl.TermsQuery termsQuery) => new ApiKeyQuery("terms", termsQuery);
	public static ApiKeyQuery Wildcard(Elastic.Clients.Elasticsearch.QueryDsl.WildcardQuery wildcardQuery) => new ApiKeyQuery("wildcard", wildcardQuery);

	public bool TryGet<T>([NotNullWhen(true)] out T? result) where T : class
	{
		result = default;
		if (Variant is T variant)
		{
			result = variant;
			return true;
		}

		return false;
	}
}

internal sealed partial class ApiKeyQueryConverter : System.Text.Json.Serialization.JsonConverter<ApiKeyQuery>
{
	private static readonly System.Text.Json.JsonEncodedText VariantBool = System.Text.Json.JsonEncodedText.Encode("bool");
	private static readonly System.Text.Json.JsonEncodedText VariantExists = System.Text.Json.JsonEncodedText.Encode("exists");
	private static readonly System.Text.Json.JsonEncodedText VariantIds = System.Text.Json.JsonEncodedText.Encode("ids");
	private static readonly System.Text.Json.JsonEncodedText VariantMatch = System.Text.Json.JsonEncodedText.Encode("match");
	private static readonly System.Text.Json.JsonEncodedText VariantMatchAll = System.Text.Json.JsonEncodedText.Encode("match_all");
	private static readonly System.Text.Json.JsonEncodedText VariantPrefix = System.Text.Json.JsonEncodedText.Encode("prefix");
	private static readonly System.Text.Json.JsonEncodedText VariantRange = System.Text.Json.JsonEncodedText.Encode("range");
	private static readonly System.Text.Json.JsonEncodedText VariantSimpleQueryString = System.Text.Json.JsonEncodedText.Encode("simple_query_string");
	private static readonly System.Text.Json.JsonEncodedText VariantTerm = System.Text.Json.JsonEncodedText.Encode("term");
	private static readonly System.Text.Json.JsonEncodedText VariantTerms = System.Text.Json.JsonEncodedText.Encode("terms");
	private static readonly System.Text.Json.JsonEncodedText VariantWildcard = System.Text.Json.JsonEncodedText.Encode("wildcard");

	public override ApiKeyQuery Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		var variantType = string.Empty;
		object? variant = null;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (reader.ValueTextEquals(VariantBool))
			{
				variantType = VariantBool.Value;
				reader.Read();
				variant = reader.ReadValue<Elastic.Clients.Elasticsearch.QueryDsl.BoolQuery?>(options, null);
				continue;
			}

			if (reader.ValueTextEquals(VariantExists))
			{
				variantType = VariantExists.Value;
				reader.Read();
				variant = reader.ReadValue<Elastic.Clients.Elasticsearch.QueryDsl.ExistsQuery?>(options, null);
				continue;
			}

			if (reader.ValueTextEquals(VariantIds))
			{
				variantType = VariantIds.Value;
				reader.Read();
				variant = reader.ReadValue<Elastic.Clients.Elasticsearch.QueryDsl.IdsQuery?>(options, null);
				continue;
			}

			if (reader.ValueTextEquals(VariantMatch))
			{
				variantType = VariantMatch.Value;
				reader.Read();
				variant = reader.ReadValue<Elastic.Clients.Elasticsearch.QueryDsl.MatchQuery?>(options, null);
				continue;
			}

			if (reader.ValueTextEquals(VariantMatchAll))
			{
				variantType = VariantMatchAll.Value;
				reader.Read();
				variant = reader.ReadValue<Elastic.Clients.Elasticsearch.QueryDsl.MatchAllQuery?>(options, null);
				continue;
			}

			if (reader.ValueTextEquals(VariantPrefix))
			{
				variantType = VariantPrefix.Value;
				reader.Read();
				variant = reader.ReadValue<Elastic.Clients.Elasticsearch.QueryDsl.PrefixQuery?>(options, null);
				continue;
			}

			if (reader.ValueTextEquals(VariantRange))
			{
				variantType = VariantRange.Value;
				reader.Read();
				variant = reader.ReadValue<Elastic.Clients.Elasticsearch.QueryDsl.IRangeQuery>(options, null);
				continue;
			}

			if (reader.ValueTextEquals(VariantSimpleQueryString))
			{
				variantType = VariantSimpleQueryString.Value;
				reader.Read();
				variant = reader.ReadValue<Elastic.Clients.Elasticsearch.QueryDsl.SimpleQueryStringQuery?>(options, null);
				continue;
			}

			if (reader.ValueTextEquals(VariantTerm))
			{
				variantType = VariantTerm.Value;
				reader.Read();
				variant = reader.ReadValue<Elastic.Clients.Elasticsearch.QueryDsl.TermQuery?>(options, null);
				continue;
			}

			if (reader.ValueTextEquals(VariantTerms))
			{
				variantType = VariantTerms.Value;
				reader.Read();
				variant = reader.ReadValue<Elastic.Clients.Elasticsearch.QueryDsl.TermsQuery?>(options, null);
				continue;
			}

			if (reader.ValueTextEquals(VariantWildcard))
			{
				variantType = VariantWildcard.Value;
				reader.Read();
				variant = reader.ReadValue<Elastic.Clients.Elasticsearch.QueryDsl.WildcardQuery?>(options, null);
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new ApiKeyQuery { VariantType = variantType, Variant = variant };
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, ApiKeyQuery value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		switch (value.VariantType)
		{
			case "":
				break;
			case "bool":
				writer.WriteProperty(options, value.VariantType, (Elastic.Clients.Elasticsearch.QueryDsl.BoolQuery?)value.Variant, null, null);
				break;
			case "exists":
				writer.WriteProperty(options, value.VariantType, (Elastic.Clients.Elasticsearch.QueryDsl.ExistsQuery?)value.Variant, null, null);
				break;
			case "ids":
				writer.WriteProperty(options, value.VariantType, (Elastic.Clients.Elasticsearch.QueryDsl.IdsQuery?)value.Variant, null, null);
				break;
			case "match":
				writer.WriteProperty(options, value.VariantType, (Elastic.Clients.Elasticsearch.QueryDsl.MatchQuery?)value.Variant, null, null);
				break;
			case "match_all":
				writer.WriteProperty(options, value.VariantType, (Elastic.Clients.Elasticsearch.QueryDsl.MatchAllQuery?)value.Variant, null, null);
				break;
			case "prefix":
				writer.WriteProperty(options, value.VariantType, (Elastic.Clients.Elasticsearch.QueryDsl.PrefixQuery?)value.Variant, null, null);
				break;
			case "range":
				writer.WriteProperty(options, value.VariantType, (Elastic.Clients.Elasticsearch.QueryDsl.IRangeQuery)value.Variant, null, null);
				break;
			case "simple_query_string":
				writer.WriteProperty(options, value.VariantType, (Elastic.Clients.Elasticsearch.QueryDsl.SimpleQueryStringQuery?)value.Variant, null, null);
				break;
			case "term":
				writer.WriteProperty(options, value.VariantType, (Elastic.Clients.Elasticsearch.QueryDsl.TermQuery?)value.Variant, null, null);
				break;
			case "terms":
				writer.WriteProperty(options, value.VariantType, (Elastic.Clients.Elasticsearch.QueryDsl.TermsQuery?)value.Variant, null, null);
				break;
			case "wildcard":
				writer.WriteProperty(options, value.VariantType, (Elastic.Clients.Elasticsearch.QueryDsl.WildcardQuery?)value.Variant, null, null);
				break;
			default:
				throw new System.Text.Json.JsonException($"Variant '{value.VariantType}' is not supported for type '{nameof(ApiKeyQuery)}'.");
		}

		writer.WriteEndObject();
	}
}

public sealed partial class ApiKeyQueryDescriptor<TDocument> : SerializableDescriptor<ApiKeyQueryDescriptor<TDocument>>
{
	internal ApiKeyQueryDescriptor(Action<ApiKeyQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public ApiKeyQueryDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private ApiKeyQueryDescriptor<TDocument> Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private ApiKeyQueryDescriptor<TDocument> Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public ApiKeyQueryDescriptor<TDocument> Bool(Elastic.Clients.Elasticsearch.QueryDsl.BoolQuery boolQuery) => Set(boolQuery, "bool");
	public ApiKeyQueryDescriptor<TDocument> Bool(Action<Elastic.Clients.Elasticsearch.QueryDsl.BoolQueryDescriptor<TDocument>> configure) => Set(configure, "bool");
	public ApiKeyQueryDescriptor<TDocument> Exists(Elastic.Clients.Elasticsearch.QueryDsl.ExistsQuery existsQuery) => Set(existsQuery, "exists");
	public ApiKeyQueryDescriptor<TDocument> Exists(Action<Elastic.Clients.Elasticsearch.QueryDsl.ExistsQueryDescriptor<TDocument>> configure) => Set(configure, "exists");
	public ApiKeyQueryDescriptor<TDocument> Ids(Elastic.Clients.Elasticsearch.QueryDsl.IdsQuery idsQuery) => Set(idsQuery, "ids");
	public ApiKeyQueryDescriptor<TDocument> Ids(Action<Elastic.Clients.Elasticsearch.QueryDsl.IdsQueryDescriptor> configure) => Set(configure, "ids");
	public ApiKeyQueryDescriptor<TDocument> Match(Elastic.Clients.Elasticsearch.QueryDsl.MatchQuery matchQuery) => Set(matchQuery, "match");
	public ApiKeyQueryDescriptor<TDocument> Match(Action<Elastic.Clients.Elasticsearch.QueryDsl.MatchQueryDescriptor<TDocument>> configure) => Set(configure, "match");
	public ApiKeyQueryDescriptor<TDocument> MatchAll(Elastic.Clients.Elasticsearch.QueryDsl.MatchAllQuery matchAllQuery) => Set(matchAllQuery, "match_all");
	public ApiKeyQueryDescriptor<TDocument> MatchAll(Action<Elastic.Clients.Elasticsearch.QueryDsl.MatchAllQueryDescriptor> configure) => Set(configure, "match_all");
	public ApiKeyQueryDescriptor<TDocument> Prefix(Elastic.Clients.Elasticsearch.QueryDsl.PrefixQuery prefixQuery) => Set(prefixQuery, "prefix");
	public ApiKeyQueryDescriptor<TDocument> Prefix(Action<Elastic.Clients.Elasticsearch.QueryDsl.PrefixQueryDescriptor<TDocument>> configure) => Set(configure, "prefix");
	public ApiKeyQueryDescriptor<TDocument> Range(Elastic.Clients.Elasticsearch.QueryDsl.IRangeQuery rangeQuery) => Set(rangeQuery, "range");
	public ApiKeyQueryDescriptor<TDocument> Range(Elastic.Clients.Elasticsearch.QueryDsl.UntypedRangeQuery rangeQuery) => Set(rangeQuery, "range");
	public ApiKeyQueryDescriptor<TDocument> Range(Elastic.Clients.Elasticsearch.QueryDsl.DateRangeQuery rangeQuery) => Set(rangeQuery, "range");
	public ApiKeyQueryDescriptor<TDocument> Range(Elastic.Clients.Elasticsearch.QueryDsl.NumberRangeQuery rangeQuery) => Set(rangeQuery, "range");
	public ApiKeyQueryDescriptor<TDocument> Range(Elastic.Clients.Elasticsearch.QueryDsl.TermRangeQuery rangeQuery) => Set(rangeQuery, "range");
	public ApiKeyQueryDescriptor<TDocument> SimpleQueryString(Elastic.Clients.Elasticsearch.QueryDsl.SimpleQueryStringQuery simpleQueryStringQuery) => Set(simpleQueryStringQuery, "simple_query_string");
	public ApiKeyQueryDescriptor<TDocument> SimpleQueryString(Action<Elastic.Clients.Elasticsearch.QueryDsl.SimpleQueryStringQueryDescriptor<TDocument>> configure) => Set(configure, "simple_query_string");
	public ApiKeyQueryDescriptor<TDocument> Term(Elastic.Clients.Elasticsearch.QueryDsl.TermQuery termQuery) => Set(termQuery, "term");
	public ApiKeyQueryDescriptor<TDocument> Term(Action<Elastic.Clients.Elasticsearch.QueryDsl.TermQueryDescriptor<TDocument>> configure) => Set(configure, "term");
	public ApiKeyQueryDescriptor<TDocument> Terms(Elastic.Clients.Elasticsearch.QueryDsl.TermsQuery termsQuery) => Set(termsQuery, "terms");
	public ApiKeyQueryDescriptor<TDocument> Terms(Action<Elastic.Clients.Elasticsearch.QueryDsl.TermsQueryDescriptor<TDocument>> configure) => Set(configure, "terms");
	public ApiKeyQueryDescriptor<TDocument> Wildcard(Elastic.Clients.Elasticsearch.QueryDsl.WildcardQuery wildcardQuery) => Set(wildcardQuery, "wildcard");
	public ApiKeyQueryDescriptor<TDocument> Wildcard(Action<Elastic.Clients.Elasticsearch.QueryDsl.WildcardQueryDescriptor<TDocument>> configure) => Set(configure, "wildcard");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(ContainedVariantName))
		{
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
				writer.WriteEndObject();
				return;
			}

			JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class ApiKeyQueryDescriptor : SerializableDescriptor<ApiKeyQueryDescriptor>
{
	internal ApiKeyQueryDescriptor(Action<ApiKeyQueryDescriptor> configure) => configure.Invoke(this);

	public ApiKeyQueryDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private ApiKeyQueryDescriptor Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private ApiKeyQueryDescriptor Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public ApiKeyQueryDescriptor Bool(Elastic.Clients.Elasticsearch.QueryDsl.BoolQuery boolQuery) => Set(boolQuery, "bool");
	public ApiKeyQueryDescriptor Bool<TDocument>(Action<Elastic.Clients.Elasticsearch.QueryDsl.BoolQueryDescriptor> configure) => Set(configure, "bool");
	public ApiKeyQueryDescriptor Exists(Elastic.Clients.Elasticsearch.QueryDsl.ExistsQuery existsQuery) => Set(existsQuery, "exists");
	public ApiKeyQueryDescriptor Exists<TDocument>(Action<Elastic.Clients.Elasticsearch.QueryDsl.ExistsQueryDescriptor> configure) => Set(configure, "exists");
	public ApiKeyQueryDescriptor Ids(Elastic.Clients.Elasticsearch.QueryDsl.IdsQuery idsQuery) => Set(idsQuery, "ids");
	public ApiKeyQueryDescriptor Ids(Action<Elastic.Clients.Elasticsearch.QueryDsl.IdsQueryDescriptor> configure) => Set(configure, "ids");
	public ApiKeyQueryDescriptor Match(Elastic.Clients.Elasticsearch.QueryDsl.MatchQuery matchQuery) => Set(matchQuery, "match");
	public ApiKeyQueryDescriptor Match<TDocument>(Action<Elastic.Clients.Elasticsearch.QueryDsl.MatchQueryDescriptor> configure) => Set(configure, "match");
	public ApiKeyQueryDescriptor MatchAll(Elastic.Clients.Elasticsearch.QueryDsl.MatchAllQuery matchAllQuery) => Set(matchAllQuery, "match_all");
	public ApiKeyQueryDescriptor MatchAll(Action<Elastic.Clients.Elasticsearch.QueryDsl.MatchAllQueryDescriptor> configure) => Set(configure, "match_all");
	public ApiKeyQueryDescriptor Prefix(Elastic.Clients.Elasticsearch.QueryDsl.PrefixQuery prefixQuery) => Set(prefixQuery, "prefix");
	public ApiKeyQueryDescriptor Prefix<TDocument>(Action<Elastic.Clients.Elasticsearch.QueryDsl.PrefixQueryDescriptor> configure) => Set(configure, "prefix");
	public ApiKeyQueryDescriptor Range(Elastic.Clients.Elasticsearch.QueryDsl.IRangeQuery rangeQuery) => Set(rangeQuery, "range");
	public ApiKeyQueryDescriptor Range(Elastic.Clients.Elasticsearch.QueryDsl.UntypedRangeQuery rangeQuery) => Set(rangeQuery, "range");
	public ApiKeyQueryDescriptor Range(Elastic.Clients.Elasticsearch.QueryDsl.DateRangeQuery rangeQuery) => Set(rangeQuery, "range");
	public ApiKeyQueryDescriptor Range(Elastic.Clients.Elasticsearch.QueryDsl.NumberRangeQuery rangeQuery) => Set(rangeQuery, "range");
	public ApiKeyQueryDescriptor Range(Elastic.Clients.Elasticsearch.QueryDsl.TermRangeQuery rangeQuery) => Set(rangeQuery, "range");
	public ApiKeyQueryDescriptor SimpleQueryString(Elastic.Clients.Elasticsearch.QueryDsl.SimpleQueryStringQuery simpleQueryStringQuery) => Set(simpleQueryStringQuery, "simple_query_string");
	public ApiKeyQueryDescriptor SimpleQueryString<TDocument>(Action<Elastic.Clients.Elasticsearch.QueryDsl.SimpleQueryStringQueryDescriptor> configure) => Set(configure, "simple_query_string");
	public ApiKeyQueryDescriptor Term(Elastic.Clients.Elasticsearch.QueryDsl.TermQuery termQuery) => Set(termQuery, "term");
	public ApiKeyQueryDescriptor Term<TDocument>(Action<Elastic.Clients.Elasticsearch.QueryDsl.TermQueryDescriptor> configure) => Set(configure, "term");
	public ApiKeyQueryDescriptor Terms(Elastic.Clients.Elasticsearch.QueryDsl.TermsQuery termsQuery) => Set(termsQuery, "terms");
	public ApiKeyQueryDescriptor Terms<TDocument>(Action<Elastic.Clients.Elasticsearch.QueryDsl.TermsQueryDescriptor> configure) => Set(configure, "terms");
	public ApiKeyQueryDescriptor Wildcard(Elastic.Clients.Elasticsearch.QueryDsl.WildcardQuery wildcardQuery) => Set(wildcardQuery, "wildcard");
	public ApiKeyQueryDescriptor Wildcard<TDocument>(Action<Elastic.Clients.Elasticsearch.QueryDsl.WildcardQueryDescriptor> configure) => Set(configure, "wildcard");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(ContainedVariantName))
		{
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
				writer.WriteEndObject();
				return;
			}

			JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		}

		writer.WriteEndObject();
	}
}