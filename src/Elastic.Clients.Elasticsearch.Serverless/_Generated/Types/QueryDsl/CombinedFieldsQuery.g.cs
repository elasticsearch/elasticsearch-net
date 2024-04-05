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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.QueryDsl;

public sealed partial class CombinedFieldsQuery
{
	/// <summary>
	/// <para>If true, match phrase queries are automatically created for multi-term synonyms.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("auto_generate_synonyms_phrase_query")]
	public bool? AutoGenerateSynonymsPhraseQuery { get; set; }

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }

	/// <summary>
	/// <para>List of fields to search. Field wildcard patterns are allowed. Only `text` fields are supported, and they must all have the same search `analyzer`.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fields")]
	[JsonConverter(typeof(FieldsConverter))]
	public Elastic.Clients.Elasticsearch.Serverless.Fields Fields { get; set; }

	/// <summary>
	/// <para>Minimum number of clauses that must match for a document to be returned.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("minimum_should_match")]
	public Elastic.Clients.Elasticsearch.Serverless.MinimumShouldMatch? MinimumShouldMatch { get; set; }

	/// <summary>
	/// <para>Boolean logic used to interpret text in the query value.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("operator")]
	public Elastic.Clients.Elasticsearch.Serverless.QueryDsl.CombinedFieldsOperator? Operator { get; set; }

	/// <summary>
	/// <para>Text to search for in the provided `fields`.<br/>The `combined_fields` query analyzes the provided text before performing a search.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query")]
	public string Query { get; set; }
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	/// <summary>
	/// <para>Indicates whether no documents are returned if the analyzer removes all tokens, such as when using a `stop` filter.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("zero_terms_query")]
	public Elastic.Clients.Elasticsearch.Serverless.QueryDsl.CombinedFieldsZeroTerms? ZeroTermsQuery { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query(CombinedFieldsQuery combinedFieldsQuery) => Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query.CombinedFields(combinedFieldsQuery);
}

public sealed partial class CombinedFieldsQueryDescriptor<TDocument> : SerializableDescriptor<CombinedFieldsQueryDescriptor<TDocument>>
{
	internal CombinedFieldsQueryDescriptor(Action<CombinedFieldsQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public CombinedFieldsQueryDescriptor() : base()
	{
	}

	private bool? AutoGenerateSynonymsPhraseQueryValue { get; set; }
	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fields FieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.CombinedFieldsOperator? OperatorValue { get; set; }
	private string QueryValue { get; set; }
	private string? QueryNameValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.CombinedFieldsZeroTerms? ZeroTermsQueryValue { get; set; }

	/// <summary>
	/// <para>If true, match phrase queries are automatically created for multi-term synonyms.</para>
	/// </summary>
	public CombinedFieldsQueryDescriptor<TDocument> AutoGenerateSynonymsPhraseQuery(bool? autoGenerateSynonymsPhraseQuery = true)
	{
		AutoGenerateSynonymsPhraseQueryValue = autoGenerateSynonymsPhraseQuery;
		return Self;
	}

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public CombinedFieldsQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>List of fields to search. Field wildcard patterns are allowed. Only `text` fields are supported, and they must all have the same search `analyzer`.</para>
	/// </summary>
	public CombinedFieldsQueryDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Serverless.Fields fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>Minimum number of clauses that must match for a document to be returned.</para>
	/// </summary>
	public CombinedFieldsQueryDescriptor<TDocument> MinimumShouldMatch(Elastic.Clients.Elasticsearch.Serverless.MinimumShouldMatch? minimumShouldMatch)
	{
		MinimumShouldMatchValue = minimumShouldMatch;
		return Self;
	}

	/// <summary>
	/// <para>Boolean logic used to interpret text in the query value.</para>
	/// </summary>
	public CombinedFieldsQueryDescriptor<TDocument> Operator(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.CombinedFieldsOperator? value)
	{
		OperatorValue = value;
		return Self;
	}

	/// <summary>
	/// <para>Text to search for in the provided `fields`.<br/>The `combined_fields` query analyzes the provided text before performing a search.</para>
	/// </summary>
	public CombinedFieldsQueryDescriptor<TDocument> Query(string query)
	{
		QueryValue = query;
		return Self;
	}

	public CombinedFieldsQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	/// <summary>
	/// <para>Indicates whether no documents are returned if the analyzer removes all tokens, such as when using a `stop` filter.</para>
	/// </summary>
	public CombinedFieldsQueryDescriptor<TDocument> ZeroTermsQuery(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.CombinedFieldsZeroTerms? zeroTermsQuery)
	{
		ZeroTermsQueryValue = zeroTermsQuery;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
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

		writer.WritePropertyName("fields");
		JsonSerializer.Serialize(writer, FieldsValue, options);
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

		writer.WritePropertyName("query");
		writer.WriteStringValue(QueryValue);
		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (ZeroTermsQueryValue is not null)
		{
			writer.WritePropertyName("zero_terms_query");
			JsonSerializer.Serialize(writer, ZeroTermsQueryValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class CombinedFieldsQueryDescriptor : SerializableDescriptor<CombinedFieldsQueryDescriptor>
{
	internal CombinedFieldsQueryDescriptor(Action<CombinedFieldsQueryDescriptor> configure) => configure.Invoke(this);

	public CombinedFieldsQueryDescriptor() : base()
	{
	}

	private bool? AutoGenerateSynonymsPhraseQueryValue { get; set; }
	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fields FieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.CombinedFieldsOperator? OperatorValue { get; set; }
	private string QueryValue { get; set; }
	private string? QueryNameValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.CombinedFieldsZeroTerms? ZeroTermsQueryValue { get; set; }

	/// <summary>
	/// <para>If true, match phrase queries are automatically created for multi-term synonyms.</para>
	/// </summary>
	public CombinedFieldsQueryDescriptor AutoGenerateSynonymsPhraseQuery(bool? autoGenerateSynonymsPhraseQuery = true)
	{
		AutoGenerateSynonymsPhraseQueryValue = autoGenerateSynonymsPhraseQuery;
		return Self;
	}

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public CombinedFieldsQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>List of fields to search. Field wildcard patterns are allowed. Only `text` fields are supported, and they must all have the same search `analyzer`.</para>
	/// </summary>
	public CombinedFieldsQueryDescriptor Fields(Elastic.Clients.Elasticsearch.Serverless.Fields fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>Minimum number of clauses that must match for a document to be returned.</para>
	/// </summary>
	public CombinedFieldsQueryDescriptor MinimumShouldMatch(Elastic.Clients.Elasticsearch.Serverless.MinimumShouldMatch? minimumShouldMatch)
	{
		MinimumShouldMatchValue = minimumShouldMatch;
		return Self;
	}

	/// <summary>
	/// <para>Boolean logic used to interpret text in the query value.</para>
	/// </summary>
	public CombinedFieldsQueryDescriptor Operator(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.CombinedFieldsOperator? value)
	{
		OperatorValue = value;
		return Self;
	}

	/// <summary>
	/// <para>Text to search for in the provided `fields`.<br/>The `combined_fields` query analyzes the provided text before performing a search.</para>
	/// </summary>
	public CombinedFieldsQueryDescriptor Query(string query)
	{
		QueryValue = query;
		return Self;
	}

	public CombinedFieldsQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	/// <summary>
	/// <para>Indicates whether no documents are returned if the analyzer removes all tokens, such as when using a `stop` filter.</para>
	/// </summary>
	public CombinedFieldsQueryDescriptor ZeroTermsQuery(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.CombinedFieldsZeroTerms? zeroTermsQuery)
	{
		ZeroTermsQueryValue = zeroTermsQuery;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
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

		writer.WritePropertyName("fields");
		JsonSerializer.Serialize(writer, FieldsValue, options);
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

		writer.WritePropertyName("query");
		writer.WriteStringValue(QueryValue);
		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (ZeroTermsQueryValue is not null)
		{
			writer.WritePropertyName("zero_terms_query");
			JsonSerializer.Serialize(writer, ZeroTermsQueryValue, options);
		}

		writer.WriteEndObject();
	}
}