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
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class AnalyzeIndexRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Performs analysis on a text string and returns the resulting tokens.</para>
/// </summary>
public sealed partial class AnalyzeIndexRequest : PlainRequest<AnalyzeIndexRequestParameters>
{
	public AnalyzeIndexRequest()
	{
	}

	public AnalyzeIndexRequest(Elastic.Clients.Elasticsearch.Serverless.IndexName? index) : base(r => r.Optional("index", index))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementAnalyze;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.analyze";

	/// <summary>
	/// <para>The name of the analyzer that should be applied to the provided `text`.<br/>This could be a built-in analyzer, or an analyzer that’s been configured in the index.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("analyzer")]
	public string? Analyzer { get; set; }

	/// <summary>
	/// <para>Array of token attributes used to filter the output of the `explain` parameter.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("attributes")]
	public ICollection<string>? Attributes { get; set; }

	/// <summary>
	/// <para>Array of character filters used to preprocess characters before the tokenizer.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("char_filter")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Analysis.ICharFilter>? CharFilter { get; set; }

	/// <summary>
	/// <para>If `true`, the response includes token attributes and additional details.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("explain")]
	public bool? Explain { get; set; }

	/// <summary>
	/// <para>Field used to derive the analyzer.<br/>To use this parameter, you must specify an index.<br/>If specified, the `analyzer` parameter overrides this value.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field? Field { get; set; }

	/// <summary>
	/// <para>Array of token filters used to apply after the tokenizer.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("filter")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Analysis.ITokenFilter>? Filter { get; set; }

	/// <summary>
	/// <para>Normalizer to use to convert text into a single token.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("normalizer")]
	public string? Normalizer { get; set; }

	/// <summary>
	/// <para>Text to analyze.<br/>If an array of strings is provided, it is analyzed as a multi-value field.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("text")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public ICollection<string>? Text { get; set; }

	/// <summary>
	/// <para>Tokenizer to use to convert text into tokens.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tokenizer")]
	public Elastic.Clients.Elasticsearch.Serverless.Analysis.ITokenizer? Tokenizer { get; set; }
}

/// <summary>
/// <para>Performs analysis on a text string and returns the resulting tokens.</para>
/// </summary>
public sealed partial class AnalyzeIndexRequestDescriptor<TDocument> : RequestDescriptor<AnalyzeIndexRequestDescriptor<TDocument>, AnalyzeIndexRequestParameters>
{
	internal AnalyzeIndexRequestDescriptor(Action<AnalyzeIndexRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public AnalyzeIndexRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.IndexName? index) : base(r => r.Optional("index", index))
	{
	}

	public AnalyzeIndexRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementAnalyze;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.analyze";

	public AnalyzeIndexRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.Serverless.IndexName? index)
	{
		RouteValues.Optional("index", index);
		return Self;
	}

	private string? AnalyzerValue { get; set; }
	private ICollection<string>? AttributesValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Analysis.ICharFilter>? CharFilterValue { get; set; }
	private bool? ExplainValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? FieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Analysis.ITokenFilter>? FilterValue { get; set; }
	private string? NormalizerValue { get; set; }
	private ICollection<string>? TextValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Analysis.ITokenizer? TokenizerValue { get; set; }

	/// <summary>
	/// <para>The name of the analyzer that should be applied to the provided `text`.<br/>This could be a built-in analyzer, or an analyzer that’s been configured in the index.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Analyzer(string? analyzer)
	{
		AnalyzerValue = analyzer;
		return Self;
	}

	/// <summary>
	/// <para>Array of token attributes used to filter the output of the `explain` parameter.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Attributes(ICollection<string>? attributes)
	{
		AttributesValue = attributes;
		return Self;
	}

	/// <summary>
	/// <para>Array of character filters used to preprocess characters before the tokenizer.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> CharFilter(ICollection<Elastic.Clients.Elasticsearch.Serverless.Analysis.ICharFilter>? charFilter)
	{
		CharFilterValue = charFilter;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, the response includes token attributes and additional details.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Explain(bool? explain = true)
	{
		ExplainValue = explain;
		return Self;
	}

	/// <summary>
	/// <para>Field used to derive the analyzer.<br/>To use this parameter, you must specify an index.<br/>If specified, the `analyzer` parameter overrides this value.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Field used to derive the analyzer.<br/>To use this parameter, you must specify an index.<br/>If specified, the `analyzer` parameter overrides this value.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Field used to derive the analyzer.<br/>To use this parameter, you must specify an index.<br/>If specified, the `analyzer` parameter overrides this value.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Array of token filters used to apply after the tokenizer.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Filter(ICollection<Elastic.Clients.Elasticsearch.Serverless.Analysis.ITokenFilter>? filter)
	{
		FilterValue = filter;
		return Self;
	}

	/// <summary>
	/// <para>Normalizer to use to convert text into a single token.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Normalizer(string? normalizer)
	{
		NormalizerValue = normalizer;
		return Self;
	}

	/// <summary>
	/// <para>Text to analyze.<br/>If an array of strings is provided, it is analyzed as a multi-value field.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Text(ICollection<string>? text)
	{
		TextValue = text;
		return Self;
	}

	/// <summary>
	/// <para>Tokenizer to use to convert text into tokens.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor<TDocument> Tokenizer(Elastic.Clients.Elasticsearch.Serverless.Analysis.ITokenizer? tokenizer)
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
/// <para>Performs analysis on a text string and returns the resulting tokens.</para>
/// </summary>
public sealed partial class AnalyzeIndexRequestDescriptor : RequestDescriptor<AnalyzeIndexRequestDescriptor, AnalyzeIndexRequestParameters>
{
	internal AnalyzeIndexRequestDescriptor(Action<AnalyzeIndexRequestDescriptor> configure) => configure.Invoke(this);

	public AnalyzeIndexRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.IndexName? index) : base(r => r.Optional("index", index))
	{
	}

	public AnalyzeIndexRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementAnalyze;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.analyze";

	public AnalyzeIndexRequestDescriptor Index(Elastic.Clients.Elasticsearch.Serverless.IndexName? index)
	{
		RouteValues.Optional("index", index);
		return Self;
	}

	private string? AnalyzerValue { get; set; }
	private ICollection<string>? AttributesValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Analysis.ICharFilter>? CharFilterValue { get; set; }
	private bool? ExplainValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? FieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Analysis.ITokenFilter>? FilterValue { get; set; }
	private string? NormalizerValue { get; set; }
	private ICollection<string>? TextValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Analysis.ITokenizer? TokenizerValue { get; set; }

	/// <summary>
	/// <para>The name of the analyzer that should be applied to the provided `text`.<br/>This could be a built-in analyzer, or an analyzer that’s been configured in the index.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Analyzer(string? analyzer)
	{
		AnalyzerValue = analyzer;
		return Self;
	}

	/// <summary>
	/// <para>Array of token attributes used to filter the output of the `explain` parameter.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Attributes(ICollection<string>? attributes)
	{
		AttributesValue = attributes;
		return Self;
	}

	/// <summary>
	/// <para>Array of character filters used to preprocess characters before the tokenizer.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor CharFilter(ICollection<Elastic.Clients.Elasticsearch.Serverless.Analysis.ICharFilter>? charFilter)
	{
		CharFilterValue = charFilter;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, the response includes token attributes and additional details.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Explain(bool? explain = true)
	{
		ExplainValue = explain;
		return Self;
	}

	/// <summary>
	/// <para>Field used to derive the analyzer.<br/>To use this parameter, you must specify an index.<br/>If specified, the `analyzer` parameter overrides this value.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Field used to derive the analyzer.<br/>To use this parameter, you must specify an index.<br/>If specified, the `analyzer` parameter overrides this value.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Field used to derive the analyzer.<br/>To use this parameter, you must specify an index.<br/>If specified, the `analyzer` parameter overrides this value.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Array of token filters used to apply after the tokenizer.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Filter(ICollection<Elastic.Clients.Elasticsearch.Serverless.Analysis.ITokenFilter>? filter)
	{
		FilterValue = filter;
		return Self;
	}

	/// <summary>
	/// <para>Normalizer to use to convert text into a single token.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Normalizer(string? normalizer)
	{
		NormalizerValue = normalizer;
		return Self;
	}

	/// <summary>
	/// <para>Text to analyze.<br/>If an array of strings is provided, it is analyzed as a multi-value field.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Text(ICollection<string>? text)
	{
		TextValue = text;
		return Self;
	}

	/// <summary>
	/// <para>Tokenizer to use to convert text into tokens.</para>
	/// </summary>
	public AnalyzeIndexRequestDescriptor Tokenizer(Elastic.Clients.Elasticsearch.Serverless.Analysis.ITokenizer? tokenizer)
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