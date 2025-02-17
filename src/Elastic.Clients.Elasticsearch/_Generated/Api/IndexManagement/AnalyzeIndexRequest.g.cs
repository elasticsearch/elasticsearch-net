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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed partial class AnalyzeIndexRequestParameters : RequestParameters
{
}

internal sealed partial class AnalyzeIndexRequestConverter : System.Text.Json.Serialization.JsonConverter<AnalyzeIndexRequest>
{
	private static readonly System.Text.Json.JsonEncodedText PropAnalyzer = System.Text.Json.JsonEncodedText.Encode("analyzer");
	private static readonly System.Text.Json.JsonEncodedText PropAttributes = System.Text.Json.JsonEncodedText.Encode("attributes");
	private static readonly System.Text.Json.JsonEncodedText PropCharFilter = System.Text.Json.JsonEncodedText.Encode("char_filter");
	private static readonly System.Text.Json.JsonEncodedText PropExplain = System.Text.Json.JsonEncodedText.Encode("explain");
	private static readonly System.Text.Json.JsonEncodedText PropField = System.Text.Json.JsonEncodedText.Encode("field");
	private static readonly System.Text.Json.JsonEncodedText PropFilter = System.Text.Json.JsonEncodedText.Encode("filter");
	private static readonly System.Text.Json.JsonEncodedText PropNormalizer = System.Text.Json.JsonEncodedText.Encode("normalizer");
	private static readonly System.Text.Json.JsonEncodedText PropText = System.Text.Json.JsonEncodedText.Encode("text");
	private static readonly System.Text.Json.JsonEncodedText PropTokenizer = System.Text.Json.JsonEncodedText.Encode("tokenizer");

	public override AnalyzeIndexRequest Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<string?> propAnalyzer = default;
		LocalJsonValue<ICollection<string>?> propAttributes = default;
		LocalJsonValue<ICollection<Elastic.Clients.Elasticsearch.Analysis.ICharFilter>?> propCharFilter = default;
		LocalJsonValue<bool?> propExplain = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.Field?> propField = default;
		LocalJsonValue<ICollection<Elastic.Clients.Elasticsearch.Analysis.ITokenFilter>?> propFilter = default;
		LocalJsonValue<string?> propNormalizer = default;
		LocalJsonValue<ICollection<string>?> propText = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.Analysis.ITokenizer?> propTokenizer = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propAnalyzer.TryReadProperty(ref reader, options, PropAnalyzer, null))
			{
				continue;
			}

			if (propAttributes.TryReadProperty(ref reader, options, PropAttributes, static ICollection<string>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadCollectionValue<string>(o, null)))
			{
				continue;
			}

			if (propCharFilter.TryReadProperty(ref reader, options, PropCharFilter, static ICollection<Elastic.Clients.Elasticsearch.Analysis.ICharFilter>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadCollectionValue<Elastic.Clients.Elasticsearch.Analysis.ICharFilter>(o, null)))
			{
				continue;
			}

			if (propExplain.TryReadProperty(ref reader, options, PropExplain, null))
			{
				continue;
			}

			if (propField.TryReadProperty(ref reader, options, PropField, null))
			{
				continue;
			}

			if (propFilter.TryReadProperty(ref reader, options, PropFilter, static ICollection<Elastic.Clients.Elasticsearch.Analysis.ITokenFilter>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadCollectionValue<Elastic.Clients.Elasticsearch.Analysis.ITokenFilter>(o, null)))
			{
				continue;
			}

			if (propNormalizer.TryReadProperty(ref reader, options, PropNormalizer, null))
			{
				continue;
			}

			if (propText.TryReadProperty(ref reader, options, PropText, static ICollection<string>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadSingleOrManyCollectionValue<string>(o, null)))
			{
				continue;
			}

			if (propTokenizer.TryReadProperty(ref reader, options, PropTokenizer, null))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new AnalyzeIndexRequest
		{
			Analyzer = propAnalyzer.Value
,
			Attributes = propAttributes.Value
,
			CharFilter = propCharFilter.Value
,
			Explain = propExplain.Value
,
			Field = propField.Value
,
			Filter = propFilter.Value
,
			Normalizer = propNormalizer.Value
,
			Text = propText.Value
,
			Tokenizer = propTokenizer.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, AnalyzeIndexRequest value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropAnalyzer, value.Analyzer, null, null);
		writer.WriteProperty(options, PropAttributes, value.Attributes, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<string>? v) => w.WriteCollectionValue<string>(o, v, null));
		writer.WriteProperty(options, PropCharFilter, value.CharFilter, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<Elastic.Clients.Elasticsearch.Analysis.ICharFilter>? v) => w.WriteCollectionValue<Elastic.Clients.Elasticsearch.Analysis.ICharFilter>(o, v, null));
		writer.WriteProperty(options, PropExplain, value.Explain, null, null);
		writer.WriteProperty(options, PropField, value.Field, null, null);
		writer.WriteProperty(options, PropFilter, value.Filter, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<Elastic.Clients.Elasticsearch.Analysis.ITokenFilter>? v) => w.WriteCollectionValue<Elastic.Clients.Elasticsearch.Analysis.ITokenFilter>(o, v, null));
		writer.WriteProperty(options, PropNormalizer, value.Normalizer, null, null);
		writer.WriteProperty(options, PropText, value.Text, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<string>? v) => w.WriteSingleOrManyCollectionValue<string>(o, v, null));
		writer.WriteProperty(options, PropTokenizer, value.Tokenizer, null, null);
		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Get tokens from text analysis.
/// The analyze API performs <a href="https://www.elastic.co/guide/en/elasticsearch/reference/current/analysis.html">analysis</a> on a text string and returns the resulting tokens.
/// </para>
/// </summary>
[JsonConverter(typeof(AnalyzeIndexRequestConverter))]
public sealed partial class AnalyzeIndexRequest : PlainRequest<AnalyzeIndexRequestParameters>
{
	[JsonConstructor]
	public AnalyzeIndexRequest()
	{
	}

	public AnalyzeIndexRequest(Elastic.Clients.Elasticsearch.IndexName? index) : base(r => r.Optional("index", index))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementAnalyze;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.analyze";

	/// <summary>
	/// <para>
	/// Index used to derive the analyzer.
	/// If specified, the <c>analyzer</c> or field parameter overrides this value.
	/// If no index is specified or the index does not have a default analyzer, the analyze API uses the standard analyzer.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.IndexName? Index { get => P<Elastic.Clients.Elasticsearch.IndexName?>("index"); set => PO("index", value); }

	/// <summary>
	/// <para>
	/// The name of the analyzer that should be applied to the provided <c>text</c>.
	/// This could be a built-in analyzer, or an analyzer that’s been configured in the index.
	/// </para>
	/// </summary>
	public string? Analyzer { get; set; }

	/// <summary>
	/// <para>
	/// Array of token attributes used to filter the output of the <c>explain</c> parameter.
	/// </para>
	/// </summary>
	public ICollection<string>? Attributes { get; set; }

	/// <summary>
	/// <para>
	/// Array of character filters used to preprocess characters before the tokenizer.
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.Analysis.ICharFilter>? CharFilter { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the response includes token attributes and additional details.
	/// </para>
	/// </summary>
	public bool? Explain { get; set; }

	/// <summary>
	/// <para>
	/// Field used to derive the analyzer.
	/// To use this parameter, you must specify an index.
	/// If specified, the <c>analyzer</c> parameter overrides this value.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

	/// <summary>
	/// <para>
	/// Array of token filters used to apply after the tokenizer.
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.Analysis.ITokenFilter>? Filter { get; set; }

	/// <summary>
	/// <para>
	/// Normalizer to use to convert text into a single token.
	/// </para>
	/// </summary>
	public string? Normalizer { get; set; }

	/// <summary>
	/// <para>
	/// Text to analyze.
	/// If an array of strings is provided, it is analyzed as a multi-value field.
	/// </para>
	/// </summary>
	public ICollection<string>? Text { get; set; }

	/// <summary>
	/// <para>
	/// Tokenizer to use to convert text into tokens.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Analysis.ITokenizer? Tokenizer { get; set; }
}

/// <summary>
/// <para>
/// Get tokens from text analysis.
/// The analyze API performs <a href="https://www.elastic.co/guide/en/elasticsearch/reference/current/analysis.html">analysis</a> on a text string and returns the resulting tokens.
/// </para>
/// </summary>
public sealed partial class AnalyzeIndexRequestDescriptor<TDocument> : RequestDescriptor<AnalyzeIndexRequestDescriptor<TDocument>, AnalyzeIndexRequestParameters>
{
	internal AnalyzeIndexRequestDescriptor(Action<AnalyzeIndexRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public AnalyzeIndexRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName? index) : base(r => r.Optional("index", index))
	{
	}

	public AnalyzeIndexRequestDescriptor() : this(typeof(TDocument))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementAnalyze;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.analyze";

	public AnalyzeIndexRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName? index)
	{
		RouteValues.Optional("index", index);
		return Self;
	}

	private string? AnalyzerValue { get; set; }
	private ICollection<string>? AttributesValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Analysis.ICharFilter>? CharFilterValue { get; set; }
	private bool? ExplainValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Analysis.ITokenFilter>? FilterValue { get; set; }
	private string? NormalizerValue { get; set; }
	private ICollection<string>? TextValue { get; set; }
	private Elastic.Clients.Elasticsearch.Analysis.ITokenizer? TokenizerValue { get; set; }

	/// <summary>
	/// <para>
	/// The name of the analyzer that should be applied to the provided <c>text</c>.
	/// This could be a built-in analyzer, or an analyzer that’s been configured in the index.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Analyzer(string? analyzer)
	{
		AnalyzerValue = analyzer;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Array of token attributes used to filter the output of the <c>explain</c> parameter.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Attributes(ICollection<string>? attributes)
	{
		AttributesValue = attributes;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Array of character filters used to preprocess characters before the tokenizer.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> CharFilter(ICollection<Elastic.Clients.Elasticsearch.Analysis.ICharFilter>? charFilter)
	{
		CharFilterValue = charFilter;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, the response includes token attributes and additional details.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Explain(bool? explain = true)
	{
		ExplainValue = explain;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Field used to derive the analyzer.
	/// To use this parameter, you must specify an index.
	/// If specified, the <c>analyzer</c> parameter overrides this value.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Field used to derive the analyzer.
	/// To use this parameter, you must specify an index.
	/// If specified, the <c>analyzer</c> parameter overrides this value.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Field used to derive the analyzer.
	/// To use this parameter, you must specify an index.
	/// If specified, the <c>analyzer</c> parameter overrides this value.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Array of token filters used to apply after the tokenizer.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Filter(ICollection<Elastic.Clients.Elasticsearch.Analysis.ITokenFilter>? filter)
	{
		FilterValue = filter;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Normalizer to use to convert text into a single token.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Normalizer(string? normalizer)
	{
		NormalizerValue = normalizer;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Text to analyze.
	/// If an array of strings is provided, it is analyzed as a multi-value field.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Text(ICollection<string>? text)
	{
		TextValue = text;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Tokenizer to use to convert text into tokens.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Tokenizer(Elastic.Clients.Elasticsearch.Analysis.ITokenizer? tokenizer)
	{
		TokenizerValue = tokenizer;
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

		if (AttributesValue is not null)
		{
			writer.WritePropertyName("attributes");
			JsonSerializer.Serialize(writer, AttributesValue, options);
		}

		if (CharFilterValue is not null)
		{
			writer.WritePropertyName("char_filter");
			JsonSerializer.Serialize(writer, CharFilterValue, options);
		}

		if (ExplainValue.HasValue)
		{
			writer.WritePropertyName("explain");
			writer.WriteBooleanValue(ExplainValue.Value);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		if (!string.IsNullOrEmpty(NormalizerValue))
		{
			writer.WritePropertyName("normalizer");
			writer.WriteStringValue(NormalizerValue);
		}

		if (TextValue is not null)
		{
			writer.WritePropertyName("text");
			SingleOrManySerializationHelper.Serialize<string>(TextValue, writer, options);
		}

		if (TokenizerValue is not null)
		{
			writer.WritePropertyName("tokenizer");
			JsonSerializer.Serialize(writer, TokenizerValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Get tokens from text analysis.
/// The analyze API performs <a href="https://www.elastic.co/guide/en/elasticsearch/reference/current/analysis.html">analysis</a> on a text string and returns the resulting tokens.
/// </para>
/// </summary>
public sealed partial class AnalyzeIndexRequestDescriptor : RequestDescriptor<AnalyzeIndexRequestDescriptor, AnalyzeIndexRequestParameters>
{
	internal AnalyzeIndexRequestDescriptor(Action<AnalyzeIndexRequestDescriptor> configure) => configure.Invoke(this);

	public AnalyzeIndexRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName? index) : base(r => r.Optional("index", index))
	{
	}

	public AnalyzeIndexRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementAnalyze;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.analyze";

	public AnalyzeIndexRequestDescriptor Index(Elastic.Clients.Elasticsearch.IndexName? index)
	{
		RouteValues.Optional("index", index);
		return Self;
	}

	private string? AnalyzerValue { get; set; }
	private ICollection<string>? AttributesValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Analysis.ICharFilter>? CharFilterValue { get; set; }
	private bool? ExplainValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Analysis.ITokenFilter>? FilterValue { get; set; }
	private string? NormalizerValue { get; set; }
	private ICollection<string>? TextValue { get; set; }
	private Elastic.Clients.Elasticsearch.Analysis.ITokenizer? TokenizerValue { get; set; }

	/// <summary>
	/// <para>
	/// The name of the analyzer that should be applied to the provided <c>text</c>.
	/// This could be a built-in analyzer, or an analyzer that’s been configured in the index.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Analyzer(string? analyzer)
	{
		AnalyzerValue = analyzer;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Array of token attributes used to filter the output of the <c>explain</c> parameter.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Attributes(ICollection<string>? attributes)
	{
		AttributesValue = attributes;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Array of character filters used to preprocess characters before the tokenizer.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor CharFilter(ICollection<Elastic.Clients.Elasticsearch.Analysis.ICharFilter>? charFilter)
	{
		CharFilterValue = charFilter;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, the response includes token attributes and additional details.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Explain(bool? explain = true)
	{
		ExplainValue = explain;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Field used to derive the analyzer.
	/// To use this parameter, you must specify an index.
	/// If specified, the <c>analyzer</c> parameter overrides this value.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Field used to derive the analyzer.
	/// To use this parameter, you must specify an index.
	/// If specified, the <c>analyzer</c> parameter overrides this value.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Field used to derive the analyzer.
	/// To use this parameter, you must specify an index.
	/// If specified, the <c>analyzer</c> parameter overrides this value.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Array of token filters used to apply after the tokenizer.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Filter(ICollection<Elastic.Clients.Elasticsearch.Analysis.ITokenFilter>? filter)
	{
		FilterValue = filter;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Normalizer to use to convert text into a single token.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Normalizer(string? normalizer)
	{
		NormalizerValue = normalizer;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Text to analyze.
	/// If an array of strings is provided, it is analyzed as a multi-value field.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Text(ICollection<string>? text)
	{
		TextValue = text;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Tokenizer to use to convert text into tokens.
	/// </para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Tokenizer(Elastic.Clients.Elasticsearch.Analysis.ITokenizer? tokenizer)
	{
		TokenizerValue = tokenizer;
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

		if (AttributesValue is not null)
		{
			writer.WritePropertyName("attributes");
			JsonSerializer.Serialize(writer, AttributesValue, options);
		}

		if (CharFilterValue is not null)
		{
			writer.WritePropertyName("char_filter");
			JsonSerializer.Serialize(writer, CharFilterValue, options);
		}

		if (ExplainValue.HasValue)
		{
			writer.WritePropertyName("explain");
			writer.WriteBooleanValue(ExplainValue.Value);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		if (!string.IsNullOrEmpty(NormalizerValue))
		{
			writer.WritePropertyName("normalizer");
			writer.WriteStringValue(NormalizerValue);
		}

		if (TextValue is not null)
		{
			writer.WritePropertyName("text");
			SingleOrManySerializationHelper.Serialize<string>(TextValue, writer, options);
		}

		if (TokenizerValue is not null)
		{
			writer.WritePropertyName("tokenizer");
			JsonSerializer.Serialize(writer, TokenizerValue, options);
		}

		writer.WriteEndObject();
	}
}