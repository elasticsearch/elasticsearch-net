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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Mapping;
public sealed partial class DynamicProperty : IProperty
{
	[JsonInclude]
	[JsonPropertyName("analyzer")]
	public string? Analyzer { get; set; }

	[JsonInclude]
	[JsonPropertyName("boost")]
	public double? Boost { get; set; }

	[JsonInclude]
	[JsonPropertyName("coerce")]
	public bool? Coerce { get; set; }

	[JsonInclude]
	[JsonPropertyName("copy_to")]
	public Elastic.Clients.Elasticsearch.Fields? CopyTo { get; set; }

	[JsonInclude]
	[JsonPropertyName("doc_values")]
	public bool? DocValues { get; set; }

	[JsonInclude]
	[JsonPropertyName("dynamic")]
	public Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? Dynamic { get; set; }

	[JsonInclude]
	[JsonPropertyName("eager_global_ordinals")]
	public bool? EagerGlobalOrdinals { get; set; }

	[JsonInclude]
	[JsonPropertyName("enabled")]
	public bool? Enabled { get; set; }

	[JsonInclude]
	[JsonPropertyName("fields")]
	public Elastic.Clients.Elasticsearch.Mapping.Properties? Fields { get; set; }

	[JsonInclude]
	[JsonPropertyName("format")]
	public string? Format { get; set; }

	[JsonInclude]
	[JsonPropertyName("ignore_above")]
	public int? IgnoreAbove { get; set; }

	[JsonInclude]
	[JsonPropertyName("ignore_malformed")]
	public bool? IgnoreMalformed { get; set; }

	[JsonInclude]
	[JsonPropertyName("index")]
	public bool? Index { get; set; }

	[JsonInclude]
	[JsonPropertyName("index_options")]
	public Elastic.Clients.Elasticsearch.Mapping.IndexOptions? IndexOptions { get; set; }

	[JsonInclude]
	[JsonPropertyName("index_phrases")]
	public bool? IndexPhrases { get; set; }

	[JsonInclude]
	[JsonPropertyName("index_prefixes")]
	public Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes? IndexPrefixes { get; set; }

	[JsonInclude]
	[JsonPropertyName("local_metadata")]
	public Dictionary<string, object>? LocalMetadata { get; set; }

	[JsonInclude]
	[JsonPropertyName("locale")]
	public string? Locale { get; set; }

	[JsonInclude]
	[JsonPropertyName("meta")]
	public Dictionary<string, string>? Meta { get; set; }

	[JsonInclude]
	[JsonPropertyName("norms")]
	public bool? Norms { get; set; }

	[JsonInclude]
	[JsonPropertyName("null_value")]
	public Elastic.Clients.Elasticsearch.FieldValue? NullValue { get; set; }

	[JsonInclude]
	[JsonPropertyName("on_script_error")]
	public Elastic.Clients.Elasticsearch.Mapping.OnScriptError? OnScriptError { get; set; }

	[JsonInclude]
	[JsonPropertyName("position_increment_gap")]
	public int? PositionIncrementGap { get; set; }

	[JsonInclude]
	[JsonPropertyName("precision_step")]
	public int? PrecisionStep { get; set; }

	[JsonInclude]
	[JsonPropertyName("properties")]
	public Elastic.Clients.Elasticsearch.Mapping.Properties? Properties { get; set; }

	[JsonInclude]
	[JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Script? Script { get; set; }

	[JsonInclude]
	[JsonPropertyName("search_analyzer")]
	public string? SearchAnalyzer { get; set; }

	[JsonInclude]
	[JsonPropertyName("search_quote_analyzer")]
	public string? SearchQuoteAnalyzer { get; set; }

	[JsonInclude]
	[JsonPropertyName("similarity")]
	public string? Similarity { get; set; }

	[JsonInclude]
	[JsonPropertyName("store")]
	public bool? Store { get; set; }

	[JsonInclude]
	[JsonPropertyName("term_vector")]
	public Elastic.Clients.Elasticsearch.Mapping.TermVectorOption? TermVector { get; set; }

	[JsonInclude]
	[JsonPropertyName("time_series_metric")]
	public Elastic.Clients.Elasticsearch.Mapping.TimeSeriesMetricType? TimeSeriesMetric { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "{dynamic_property}";
}

public sealed partial class DynamicPropertyDescriptor<TDocument> : SerializableDescriptor<DynamicPropertyDescriptor<TDocument>>, IBuildableDescriptor<DynamicProperty>
{
	internal DynamicPropertyDescriptor(Action<DynamicPropertyDescriptor<TDocument>> configure) => configure.Invoke(this);
	public DynamicPropertyDescriptor() : base()
	{
	}

	private string? AnalyzerValue { get; set; }

	private double? BoostValue { get; set; }

	private bool? CoerceValue { get; set; }

	private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }

	private bool? DocValuesValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

	private bool? EagerGlobalOrdinalsValue { get; set; }

	private bool? EnabledValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

	private string? FormatValue { get; set; }

	private int? IgnoreAboveValue { get; set; }

	private bool? IgnoreMalformedValue { get; set; }

	private bool? IndexValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.IndexOptions? IndexOptionsValue { get; set; }

	private bool? IndexPhrasesValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes? IndexPrefixesValue { get; set; }

	private TextIndexPrefixesDescriptor IndexPrefixesDescriptor { get; set; }

	private Action<TextIndexPrefixesDescriptor> IndexPrefixesDescriptorAction { get; set; }

	private Dictionary<string, object>? LocalMetadataValue { get; set; }

	private string? LocaleValue { get; set; }

	private Dictionary<string, string>? MetaValue { get; set; }

	private bool? NormsValue { get; set; }

	private Elastic.Clients.Elasticsearch.FieldValue? NullValueValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.OnScriptError? OnScriptErrorValue { get; set; }

	private int? PositionIncrementGapValue { get; set; }

	private int? PrecisionStepValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }

	private string? SearchAnalyzerValue { get; set; }

	private string? SearchQuoteAnalyzerValue { get; set; }

	private string? SimilarityValue { get; set; }

	private bool? StoreValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.TermVectorOption? TermVectorValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.TimeSeriesMetricType? TimeSeriesMetricValue { get; set; }

	public DynamicPropertyDescriptor<TDocument> Analyzer(string? analyzer)
	{
		AnalyzerValue = analyzer;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Boost(double? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Coerce(bool? coerce = true)
	{
		CoerceValue = coerce;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
	{
		CopyToValue = copyTo;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> DocValues(bool? docValues = true)
	{
		DocValuesValue = docValues;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> EagerGlobalOrdinals(bool? eagerGlobalOrdinals = true)
	{
		EagerGlobalOrdinalsValue = eagerGlobalOrdinals;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Enabled(bool? enabled = true)
	{
		EnabledValue = enabled;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Fields(PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Fields(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> IgnoreMalformed(bool? ignoreMalformed = true)
	{
		IgnoreMalformedValue = ignoreMalformed;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Index(bool? index = true)
	{
		IndexValue = index;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> IndexOptions(Elastic.Clients.Elasticsearch.Mapping.IndexOptions? indexOptions)
	{
		IndexOptionsValue = indexOptions;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> IndexPhrases(bool? indexPhrases = true)
	{
		IndexPhrasesValue = indexPhrases;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> IndexPrefixes(Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes? indexPrefixes)
	{
		IndexPrefixesDescriptor = null;
		IndexPrefixesDescriptorAction = null;
		IndexPrefixesValue = indexPrefixes;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> IndexPrefixes(TextIndexPrefixesDescriptor descriptor)
	{
		IndexPrefixesValue = null;
		IndexPrefixesDescriptorAction = null;
		IndexPrefixesDescriptor = descriptor;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> IndexPrefixes(Action<TextIndexPrefixesDescriptor> configure)
	{
		IndexPrefixesValue = null;
		IndexPrefixesDescriptor = null;
		IndexPrefixesDescriptorAction = configure;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> LocalMetadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		LocalMetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Locale(string? locale)
	{
		LocaleValue = locale;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Norms(bool? norms = true)
	{
		NormsValue = norms;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> NullValue(Elastic.Clients.Elasticsearch.FieldValue? nullValue)
	{
		NullValueValue = nullValue;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> OnScriptError(Elastic.Clients.Elasticsearch.Mapping.OnScriptError? onScriptError)
	{
		OnScriptErrorValue = onScriptError;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> PositionIncrementGap(int? positionIncrementGap)
	{
		PositionIncrementGapValue = positionIncrementGap;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> PrecisionStep(int? precisionStep)
	{
		PrecisionStepValue = precisionStep;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Properties(PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Properties(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> SearchAnalyzer(string? searchAnalyzer)
	{
		SearchAnalyzerValue = searchAnalyzer;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> SearchQuoteAnalyzer(string? searchQuoteAnalyzer)
	{
		SearchQuoteAnalyzerValue = searchQuoteAnalyzer;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Similarity(string? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> Store(bool? store = true)
	{
		StoreValue = store;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> TermVector(Elastic.Clients.Elasticsearch.Mapping.TermVectorOption? termVector)
	{
		TermVectorValue = termVector;
		return Self;
	}

	public DynamicPropertyDescriptor<TDocument> TimeSeriesMetric(Elastic.Clients.Elasticsearch.Mapping.TimeSeriesMetricType? timeSeriesMetric)
	{
		TimeSeriesMetricValue = timeSeriesMetric;
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

		if (CoerceValue.HasValue)
		{
			writer.WritePropertyName("coerce");
			writer.WriteBooleanValue(CoerceValue.Value);
		}

		if (CopyToValue is not null)
		{
			writer.WritePropertyName("copy_to");
			JsonSerializer.Serialize(writer, CopyToValue, options);
		}

		if (DocValuesValue.HasValue)
		{
			writer.WritePropertyName("doc_values");
			writer.WriteBooleanValue(DocValuesValue.Value);
		}

		if (DynamicValue is not null)
		{
			writer.WritePropertyName("dynamic");
			JsonSerializer.Serialize(writer, DynamicValue, options);
		}

		if (EagerGlobalOrdinalsValue.HasValue)
		{
			writer.WritePropertyName("eager_global_ordinals");
			writer.WriteBooleanValue(EagerGlobalOrdinalsValue.Value);
		}

		if (EnabledValue.HasValue)
		{
			writer.WritePropertyName("enabled");
			writer.WriteBooleanValue(EnabledValue.Value);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (IgnoreAboveValue.HasValue)
		{
			writer.WritePropertyName("ignore_above");
			writer.WriteNumberValue(IgnoreAboveValue.Value);
		}

		if (IgnoreMalformedValue.HasValue)
		{
			writer.WritePropertyName("ignore_malformed");
			writer.WriteBooleanValue(IgnoreMalformedValue.Value);
		}

		if (IndexValue.HasValue)
		{
			writer.WritePropertyName("index");
			writer.WriteBooleanValue(IndexValue.Value);
		}

		if (IndexOptionsValue is not null)
		{
			writer.WritePropertyName("index_options");
			JsonSerializer.Serialize(writer, IndexOptionsValue, options);
		}

		if (IndexPhrasesValue.HasValue)
		{
			writer.WritePropertyName("index_phrases");
			writer.WriteBooleanValue(IndexPhrasesValue.Value);
		}

		if (IndexPrefixesDescriptor is not null)
		{
			writer.WritePropertyName("index_prefixes");
			JsonSerializer.Serialize(writer, IndexPrefixesDescriptor, options);
		}
		else if (IndexPrefixesDescriptorAction is not null)
		{
			writer.WritePropertyName("index_prefixes");
			JsonSerializer.Serialize(writer, new TextIndexPrefixesDescriptor(IndexPrefixesDescriptorAction), options);
		}
		else if (IndexPrefixesValue is not null)
		{
			writer.WritePropertyName("index_prefixes");
			JsonSerializer.Serialize(writer, IndexPrefixesValue, options);
		}

		if (LocalMetadataValue is not null)
		{
			writer.WritePropertyName("local_metadata");
			JsonSerializer.Serialize(writer, LocalMetadataValue, options);
		}

		if (!string.IsNullOrEmpty(LocaleValue))
		{
			writer.WritePropertyName("locale");
			writer.WriteStringValue(LocaleValue);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (NormsValue.HasValue)
		{
			writer.WritePropertyName("norms");
			writer.WriteBooleanValue(NormsValue.Value);
		}

		if (NullValueValue is not null)
		{
			writer.WritePropertyName("null_value");
			JsonSerializer.Serialize(writer, NullValueValue, options);
		}

		if (OnScriptErrorValue is not null)
		{
			writer.WritePropertyName("on_script_error");
			JsonSerializer.Serialize(writer, OnScriptErrorValue, options);
		}

		if (PositionIncrementGapValue.HasValue)
		{
			writer.WritePropertyName("position_increment_gap");
			writer.WriteNumberValue(PositionIncrementGapValue.Value);
		}

		if (PrecisionStepValue.HasValue)
		{
			writer.WritePropertyName("precision_step");
			writer.WriteNumberValue(PrecisionStepValue.Value);
		}

		if (PropertiesValue is not null)
		{
			writer.WritePropertyName("properties");
			JsonSerializer.Serialize(writer, PropertiesValue, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (!string.IsNullOrEmpty(SearchAnalyzerValue))
		{
			writer.WritePropertyName("search_analyzer");
			writer.WriteStringValue(SearchAnalyzerValue);
		}

		if (!string.IsNullOrEmpty(SearchQuoteAnalyzerValue))
		{
			writer.WritePropertyName("search_quote_analyzer");
			writer.WriteStringValue(SearchQuoteAnalyzerValue);
		}

		if (!string.IsNullOrEmpty(SimilarityValue))
		{
			writer.WritePropertyName("similarity");
			writer.WriteStringValue(SimilarityValue);
		}

		if (StoreValue.HasValue)
		{
			writer.WritePropertyName("store");
			writer.WriteBooleanValue(StoreValue.Value);
		}

		if (TermVectorValue is not null)
		{
			writer.WritePropertyName("term_vector");
			JsonSerializer.Serialize(writer, TermVectorValue, options);
		}

		if (TimeSeriesMetricValue is not null)
		{
			writer.WritePropertyName("time_series_metric");
			JsonSerializer.Serialize(writer, TimeSeriesMetricValue, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("{dynamic_property}");
		writer.WriteEndObject();
	}

	private Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes? BuildIndexPrefixes()
	{
		if (IndexPrefixesValue is not null)
		{
			return IndexPrefixesValue;
		}

		if (IndexPrefixesDescriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes?> buildable)
		{
			return buildable.Build();
		}

		if (IndexPrefixesDescriptorAction is not null)
		{
			var descriptor = new TextIndexPrefixesDescriptor(IndexPrefixesDescriptorAction);
			if (descriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes?> buildableFromAction)
			{
				return buildableFromAction.Build();
			}
		}

		return null;
	}

	DynamicProperty IBuildableDescriptor<DynamicProperty>.Build() => new()
	{ Analyzer = AnalyzerValue, Boost = BoostValue, Coerce = CoerceValue, CopyTo = CopyToValue, DocValues = DocValuesValue, Dynamic = DynamicValue, EagerGlobalOrdinals = EagerGlobalOrdinalsValue, Enabled = EnabledValue, Fields = FieldsValue, Format = FormatValue, IgnoreAbove = IgnoreAboveValue, IgnoreMalformed = IgnoreMalformedValue, Index = IndexValue, IndexOptions = IndexOptionsValue, IndexPhrases = IndexPhrasesValue, IndexPrefixes = BuildIndexPrefixes(), LocalMetadata = LocalMetadataValue, Locale = LocaleValue, Meta = MetaValue, Norms = NormsValue, NullValue = NullValueValue, OnScriptError = OnScriptErrorValue, PositionIncrementGap = PositionIncrementGapValue, PrecisionStep = PrecisionStepValue, Properties = PropertiesValue, Script = ScriptValue, SearchAnalyzer = SearchAnalyzerValue, SearchQuoteAnalyzer = SearchQuoteAnalyzerValue, Similarity = SimilarityValue, Store = StoreValue, TermVector = TermVectorValue, TimeSeriesMetric = TimeSeriesMetricValue };
}

public sealed partial class DynamicPropertyDescriptor : SerializableDescriptor<DynamicPropertyDescriptor>, IBuildableDescriptor<DynamicProperty>
{
	internal DynamicPropertyDescriptor(Action<DynamicPropertyDescriptor> configure) => configure.Invoke(this);
	public DynamicPropertyDescriptor() : base()
	{
	}

	private string? AnalyzerValue { get; set; }

	private double? BoostValue { get; set; }

	private bool? CoerceValue { get; set; }

	private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }

	private bool? DocValuesValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

	private bool? EagerGlobalOrdinalsValue { get; set; }

	private bool? EnabledValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

	private string? FormatValue { get; set; }

	private int? IgnoreAboveValue { get; set; }

	private bool? IgnoreMalformedValue { get; set; }

	private bool? IndexValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.IndexOptions? IndexOptionsValue { get; set; }

	private bool? IndexPhrasesValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes? IndexPrefixesValue { get; set; }

	private TextIndexPrefixesDescriptor IndexPrefixesDescriptor { get; set; }

	private Action<TextIndexPrefixesDescriptor> IndexPrefixesDescriptorAction { get; set; }

	private Dictionary<string, object>? LocalMetadataValue { get; set; }

	private string? LocaleValue { get; set; }

	private Dictionary<string, string>? MetaValue { get; set; }

	private bool? NormsValue { get; set; }

	private Elastic.Clients.Elasticsearch.FieldValue? NullValueValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.OnScriptError? OnScriptErrorValue { get; set; }

	private int? PositionIncrementGapValue { get; set; }

	private int? PrecisionStepValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }

	private string? SearchAnalyzerValue { get; set; }

	private string? SearchQuoteAnalyzerValue { get; set; }

	private string? SimilarityValue { get; set; }

	private bool? StoreValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.TermVectorOption? TermVectorValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.TimeSeriesMetricType? TimeSeriesMetricValue { get; set; }

	public DynamicPropertyDescriptor Analyzer(string? analyzer)
	{
		AnalyzerValue = analyzer;
		return Self;
	}

	public DynamicPropertyDescriptor Boost(double? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public DynamicPropertyDescriptor Coerce(bool? coerce = true)
	{
		CoerceValue = coerce;
		return Self;
	}

	public DynamicPropertyDescriptor CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
	{
		CopyToValue = copyTo;
		return Self;
	}

	public DynamicPropertyDescriptor DocValues(bool? docValues = true)
	{
		DocValuesValue = docValues;
		return Self;
	}

	public DynamicPropertyDescriptor Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public DynamicPropertyDescriptor EagerGlobalOrdinals(bool? eagerGlobalOrdinals = true)
	{
		EagerGlobalOrdinalsValue = eagerGlobalOrdinals;
		return Self;
	}

	public DynamicPropertyDescriptor Enabled(bool? enabled = true)
	{
		EnabledValue = enabled;
		return Self;
	}

	public DynamicPropertyDescriptor Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public DynamicPropertyDescriptor Fields<TDocument>(PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public DynamicPropertyDescriptor Fields<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public DynamicPropertyDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public DynamicPropertyDescriptor IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public DynamicPropertyDescriptor IgnoreMalformed(bool? ignoreMalformed = true)
	{
		IgnoreMalformedValue = ignoreMalformed;
		return Self;
	}

	public DynamicPropertyDescriptor Index(bool? index = true)
	{
		IndexValue = index;
		return Self;
	}

	public DynamicPropertyDescriptor IndexOptions(Elastic.Clients.Elasticsearch.Mapping.IndexOptions? indexOptions)
	{
		IndexOptionsValue = indexOptions;
		return Self;
	}

	public DynamicPropertyDescriptor IndexPhrases(bool? indexPhrases = true)
	{
		IndexPhrasesValue = indexPhrases;
		return Self;
	}

	public DynamicPropertyDescriptor IndexPrefixes(Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes? indexPrefixes)
	{
		IndexPrefixesDescriptor = null;
		IndexPrefixesDescriptorAction = null;
		IndexPrefixesValue = indexPrefixes;
		return Self;
	}

	public DynamicPropertyDescriptor IndexPrefixes(TextIndexPrefixesDescriptor descriptor)
	{
		IndexPrefixesValue = null;
		IndexPrefixesDescriptorAction = null;
		IndexPrefixesDescriptor = descriptor;
		return Self;
	}

	public DynamicPropertyDescriptor IndexPrefixes(Action<TextIndexPrefixesDescriptor> configure)
	{
		IndexPrefixesValue = null;
		IndexPrefixesDescriptor = null;
		IndexPrefixesDescriptorAction = configure;
		return Self;
	}

	public DynamicPropertyDescriptor LocalMetadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		LocalMetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public DynamicPropertyDescriptor Locale(string? locale)
	{
		LocaleValue = locale;
		return Self;
	}

	public DynamicPropertyDescriptor Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public DynamicPropertyDescriptor Norms(bool? norms = true)
	{
		NormsValue = norms;
		return Self;
	}

	public DynamicPropertyDescriptor NullValue(Elastic.Clients.Elasticsearch.FieldValue? nullValue)
	{
		NullValueValue = nullValue;
		return Self;
	}

	public DynamicPropertyDescriptor OnScriptError(Elastic.Clients.Elasticsearch.Mapping.OnScriptError? onScriptError)
	{
		OnScriptErrorValue = onScriptError;
		return Self;
	}

	public DynamicPropertyDescriptor PositionIncrementGap(int? positionIncrementGap)
	{
		PositionIncrementGapValue = positionIncrementGap;
		return Self;
	}

	public DynamicPropertyDescriptor PrecisionStep(int? precisionStep)
	{
		PrecisionStepValue = precisionStep;
		return Self;
	}

	public DynamicPropertyDescriptor Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public DynamicPropertyDescriptor Properties<TDocument>(PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public DynamicPropertyDescriptor Properties<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public DynamicPropertyDescriptor Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	public DynamicPropertyDescriptor SearchAnalyzer(string? searchAnalyzer)
	{
		SearchAnalyzerValue = searchAnalyzer;
		return Self;
	}

	public DynamicPropertyDescriptor SearchQuoteAnalyzer(string? searchQuoteAnalyzer)
	{
		SearchQuoteAnalyzerValue = searchQuoteAnalyzer;
		return Self;
	}

	public DynamicPropertyDescriptor Similarity(string? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	public DynamicPropertyDescriptor Store(bool? store = true)
	{
		StoreValue = store;
		return Self;
	}

	public DynamicPropertyDescriptor TermVector(Elastic.Clients.Elasticsearch.Mapping.TermVectorOption? termVector)
	{
		TermVectorValue = termVector;
		return Self;
	}

	public DynamicPropertyDescriptor TimeSeriesMetric(Elastic.Clients.Elasticsearch.Mapping.TimeSeriesMetricType? timeSeriesMetric)
	{
		TimeSeriesMetricValue = timeSeriesMetric;
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

		if (CoerceValue.HasValue)
		{
			writer.WritePropertyName("coerce");
			writer.WriteBooleanValue(CoerceValue.Value);
		}

		if (CopyToValue is not null)
		{
			writer.WritePropertyName("copy_to");
			JsonSerializer.Serialize(writer, CopyToValue, options);
		}

		if (DocValuesValue.HasValue)
		{
			writer.WritePropertyName("doc_values");
			writer.WriteBooleanValue(DocValuesValue.Value);
		}

		if (DynamicValue is not null)
		{
			writer.WritePropertyName("dynamic");
			JsonSerializer.Serialize(writer, DynamicValue, options);
		}

		if (EagerGlobalOrdinalsValue.HasValue)
		{
			writer.WritePropertyName("eager_global_ordinals");
			writer.WriteBooleanValue(EagerGlobalOrdinalsValue.Value);
		}

		if (EnabledValue.HasValue)
		{
			writer.WritePropertyName("enabled");
			writer.WriteBooleanValue(EnabledValue.Value);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (IgnoreAboveValue.HasValue)
		{
			writer.WritePropertyName("ignore_above");
			writer.WriteNumberValue(IgnoreAboveValue.Value);
		}

		if (IgnoreMalformedValue.HasValue)
		{
			writer.WritePropertyName("ignore_malformed");
			writer.WriteBooleanValue(IgnoreMalformedValue.Value);
		}

		if (IndexValue.HasValue)
		{
			writer.WritePropertyName("index");
			writer.WriteBooleanValue(IndexValue.Value);
		}

		if (IndexOptionsValue is not null)
		{
			writer.WritePropertyName("index_options");
			JsonSerializer.Serialize(writer, IndexOptionsValue, options);
		}

		if (IndexPhrasesValue.HasValue)
		{
			writer.WritePropertyName("index_phrases");
			writer.WriteBooleanValue(IndexPhrasesValue.Value);
		}

		if (IndexPrefixesDescriptor is not null)
		{
			writer.WritePropertyName("index_prefixes");
			JsonSerializer.Serialize(writer, IndexPrefixesDescriptor, options);
		}
		else if (IndexPrefixesDescriptorAction is not null)
		{
			writer.WritePropertyName("index_prefixes");
			JsonSerializer.Serialize(writer, new TextIndexPrefixesDescriptor(IndexPrefixesDescriptorAction), options);
		}
		else if (IndexPrefixesValue is not null)
		{
			writer.WritePropertyName("index_prefixes");
			JsonSerializer.Serialize(writer, IndexPrefixesValue, options);
		}

		if (LocalMetadataValue is not null)
		{
			writer.WritePropertyName("local_metadata");
			JsonSerializer.Serialize(writer, LocalMetadataValue, options);
		}

		if (!string.IsNullOrEmpty(LocaleValue))
		{
			writer.WritePropertyName("locale");
			writer.WriteStringValue(LocaleValue);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (NormsValue.HasValue)
		{
			writer.WritePropertyName("norms");
			writer.WriteBooleanValue(NormsValue.Value);
		}

		if (NullValueValue is not null)
		{
			writer.WritePropertyName("null_value");
			JsonSerializer.Serialize(writer, NullValueValue, options);
		}

		if (OnScriptErrorValue is not null)
		{
			writer.WritePropertyName("on_script_error");
			JsonSerializer.Serialize(writer, OnScriptErrorValue, options);
		}

		if (PositionIncrementGapValue.HasValue)
		{
			writer.WritePropertyName("position_increment_gap");
			writer.WriteNumberValue(PositionIncrementGapValue.Value);
		}

		if (PrecisionStepValue.HasValue)
		{
			writer.WritePropertyName("precision_step");
			writer.WriteNumberValue(PrecisionStepValue.Value);
		}

		if (PropertiesValue is not null)
		{
			writer.WritePropertyName("properties");
			JsonSerializer.Serialize(writer, PropertiesValue, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (!string.IsNullOrEmpty(SearchAnalyzerValue))
		{
			writer.WritePropertyName("search_analyzer");
			writer.WriteStringValue(SearchAnalyzerValue);
		}

		if (!string.IsNullOrEmpty(SearchQuoteAnalyzerValue))
		{
			writer.WritePropertyName("search_quote_analyzer");
			writer.WriteStringValue(SearchQuoteAnalyzerValue);
		}

		if (!string.IsNullOrEmpty(SimilarityValue))
		{
			writer.WritePropertyName("similarity");
			writer.WriteStringValue(SimilarityValue);
		}

		if (StoreValue.HasValue)
		{
			writer.WritePropertyName("store");
			writer.WriteBooleanValue(StoreValue.Value);
		}

		if (TermVectorValue is not null)
		{
			writer.WritePropertyName("term_vector");
			JsonSerializer.Serialize(writer, TermVectorValue, options);
		}

		if (TimeSeriesMetricValue is not null)
		{
			writer.WritePropertyName("time_series_metric");
			JsonSerializer.Serialize(writer, TimeSeriesMetricValue, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("{dynamic_property}");
		writer.WriteEndObject();
	}

	private Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes? BuildIndexPrefixes()
	{
		if (IndexPrefixesValue is not null)
		{
			return IndexPrefixesValue;
		}

		if (IndexPrefixesDescriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes?> buildable)
		{
			return buildable.Build();
		}

		if (IndexPrefixesDescriptorAction is not null)
		{
			var descriptor = new TextIndexPrefixesDescriptor(IndexPrefixesDescriptorAction);
			if (descriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes?> buildableFromAction)
			{
				return buildableFromAction.Build();
			}
		}

		return null;
	}

	DynamicProperty IBuildableDescriptor<DynamicProperty>.Build() => new()
	{ Analyzer = AnalyzerValue, Boost = BoostValue, Coerce = CoerceValue, CopyTo = CopyToValue, DocValues = DocValuesValue, Dynamic = DynamicValue, EagerGlobalOrdinals = EagerGlobalOrdinalsValue, Enabled = EnabledValue, Fields = FieldsValue, Format = FormatValue, IgnoreAbove = IgnoreAboveValue, IgnoreMalformed = IgnoreMalformedValue, Index = IndexValue, IndexOptions = IndexOptionsValue, IndexPhrases = IndexPhrasesValue, IndexPrefixes = BuildIndexPrefixes(), LocalMetadata = LocalMetadataValue, Locale = LocaleValue, Meta = MetaValue, Norms = NormsValue, NullValue = NullValueValue, OnScriptError = OnScriptErrorValue, PositionIncrementGap = PositionIncrementGapValue, PrecisionStep = PrecisionStepValue, Properties = PropertiesValue, Script = ScriptValue, SearchAnalyzer = SearchAnalyzerValue, SearchQuoteAnalyzer = SearchQuoteAnalyzerValue, Similarity = SimilarityValue, Store = StoreValue, TermVector = TermVectorValue, TimeSeriesMetric = TimeSeriesMetricValue };
}