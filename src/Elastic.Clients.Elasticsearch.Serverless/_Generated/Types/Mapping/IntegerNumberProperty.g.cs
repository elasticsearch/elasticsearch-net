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

namespace Elastic.Clients.Elasticsearch.Serverless.Mapping;

public sealed partial class IntegerNumberProperty : IProperty
{
	[JsonInclude, JsonPropertyName("boost")]
	public double? Boost { get; set; }
	[JsonInclude, JsonPropertyName("coerce")]
	public bool? Coerce { get; set; }
	[JsonInclude, JsonPropertyName("copy_to")]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? CopyTo { get; set; }
	[JsonInclude, JsonPropertyName("doc_values")]
	public bool? DocValues { get; set; }
	[JsonInclude, JsonPropertyName("dynamic")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? Dynamic { get; set; }
	[JsonInclude, JsonPropertyName("fields")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? Fields { get; set; }
	[JsonInclude, JsonPropertyName("ignore_above")]
	public int? IgnoreAbove { get; set; }
	[JsonInclude, JsonPropertyName("ignore_malformed")]
	public bool? IgnoreMalformed { get; set; }
	[JsonInclude, JsonPropertyName("index")]
	public bool? Index { get; set; }
	[JsonInclude, JsonPropertyName("meta")]
	public IDictionary<string, string>? Meta { get; set; }
	[JsonInclude, JsonPropertyName("null_value")]
	public int? NullValue { get; set; }
	[JsonInclude, JsonPropertyName("on_script_error")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.OnScriptError? OnScriptError { get; set; }
	[JsonInclude, JsonPropertyName("properties")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? Properties { get; set; }
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Serverless.Script? Script { get; set; }
	[JsonInclude, JsonPropertyName("similarity")]
	public string? Similarity { get; set; }
	[JsonInclude, JsonPropertyName("store")]
	public bool? Store { get; set; }
	[JsonInclude, JsonPropertyName("time_series_dimension")]
	public bool? TimeSeriesDimension { get; set; }
	[JsonInclude, JsonPropertyName("time_series_metric")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.TimeSeriesMetricType? TimeSeriesMetric { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "integer";
}

public sealed partial class IntegerNumberPropertyDescriptor<TDocument> : SerializableDescriptor<IntegerNumberPropertyDescriptor<TDocument>>, IBuildableDescriptor<IntegerNumberProperty>
{
	internal IntegerNumberPropertyDescriptor(Action<IntegerNumberPropertyDescriptor<TDocument>> configure) => configure.Invoke(this);

	public IntegerNumberPropertyDescriptor() : base()
	{
	}

	private double? BoostValue { get; set; }
	private bool? CoerceValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fields? CopyToValue { get; set; }
	private bool? DocValuesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? DynamicValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? FieldsValue { get; set; }
	private int? IgnoreAboveValue { get; set; }
	private bool? IgnoreMalformedValue { get; set; }
	private bool? IndexValue { get; set; }
	private IDictionary<string, string>? MetaValue { get; set; }
	private int? NullValueValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.OnScriptError? OnScriptErrorValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? PropertiesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Script? ScriptValue { get; set; }
	private string? SimilarityValue { get; set; }
	private bool? StoreValue { get; set; }
	private bool? TimeSeriesDimensionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.TimeSeriesMetricType? TimeSeriesMetricValue { get; set; }

	public IntegerNumberPropertyDescriptor<TDocument> Boost(double? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> Coerce(bool? coerce = true)
	{
		CoerceValue = coerce;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> CopyTo(Elastic.Clients.Elasticsearch.Serverless.Fields? copyTo)
	{
		CopyToValue = copyTo;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> DocValues(bool? docValues = true)
	{
		DocValuesValue = docValues;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> Dynamic(Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> Fields(PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> Fields(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> IgnoreMalformed(bool? ignoreMalformed = true)
	{
		IgnoreMalformedValue = ignoreMalformed;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> Index(bool? index = true)
	{
		IndexValue = index;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> NullValue(int? nullValue)
	{
		NullValueValue = nullValue;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> OnScriptError(Elastic.Clients.Elasticsearch.Serverless.Mapping.OnScriptError? onScriptError)
	{
		OnScriptErrorValue = onScriptError;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> Properties(PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> Properties(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Serverless.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> Similarity(string? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> Store(bool? store = true)
	{
		StoreValue = store;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> TimeSeriesDimension(bool? timeSeriesDimension = true)
	{
		TimeSeriesDimensionValue = timeSeriesDimension;
		return Self;
	}

	public IntegerNumberPropertyDescriptor<TDocument> TimeSeriesMetric(Elastic.Clients.Elasticsearch.Serverless.Mapping.TimeSeriesMetricType? timeSeriesMetric)
	{
		TimeSeriesMetricValue = timeSeriesMetric;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
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

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
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

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (NullValueValue.HasValue)
		{
			writer.WritePropertyName("null_value");
			writer.WriteNumberValue(NullValueValue.Value);
		}

		if (OnScriptErrorValue is not null)
		{
			writer.WritePropertyName("on_script_error");
			JsonSerializer.Serialize(writer, OnScriptErrorValue, options);
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

		if (TimeSeriesDimensionValue.HasValue)
		{
			writer.WritePropertyName("time_series_dimension");
			writer.WriteBooleanValue(TimeSeriesDimensionValue.Value);
		}

		if (TimeSeriesMetricValue is not null)
		{
			writer.WritePropertyName("time_series_metric");
			JsonSerializer.Serialize(writer, TimeSeriesMetricValue, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("integer");
		writer.WriteEndObject();
	}

	IntegerNumberProperty IBuildableDescriptor<IntegerNumberProperty>.Build() => new()
	{
		Boost = BoostValue,
		Coerce = CoerceValue,
		CopyTo = CopyToValue,
		DocValues = DocValuesValue,
		Dynamic = DynamicValue,
		Fields = FieldsValue,
		IgnoreAbove = IgnoreAboveValue,
		IgnoreMalformed = IgnoreMalformedValue,
		Index = IndexValue,
		Meta = MetaValue,
		NullValue = NullValueValue,
		OnScriptError = OnScriptErrorValue,
		Properties = PropertiesValue,
		Script = ScriptValue,
		Similarity = SimilarityValue,
		Store = StoreValue,
		TimeSeriesDimension = TimeSeriesDimensionValue,
		TimeSeriesMetric = TimeSeriesMetricValue
	};
}

public sealed partial class IntegerNumberPropertyDescriptor : SerializableDescriptor<IntegerNumberPropertyDescriptor>, IBuildableDescriptor<IntegerNumberProperty>
{
	internal IntegerNumberPropertyDescriptor(Action<IntegerNumberPropertyDescriptor> configure) => configure.Invoke(this);

	public IntegerNumberPropertyDescriptor() : base()
	{
	}

	private double? BoostValue { get; set; }
	private bool? CoerceValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fields? CopyToValue { get; set; }
	private bool? DocValuesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? DynamicValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? FieldsValue { get; set; }
	private int? IgnoreAboveValue { get; set; }
	private bool? IgnoreMalformedValue { get; set; }
	private bool? IndexValue { get; set; }
	private IDictionary<string, string>? MetaValue { get; set; }
	private int? NullValueValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.OnScriptError? OnScriptErrorValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? PropertiesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Script? ScriptValue { get; set; }
	private string? SimilarityValue { get; set; }
	private bool? StoreValue { get; set; }
	private bool? TimeSeriesDimensionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.TimeSeriesMetricType? TimeSeriesMetricValue { get; set; }

	public IntegerNumberPropertyDescriptor Boost(double? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public IntegerNumberPropertyDescriptor Coerce(bool? coerce = true)
	{
		CoerceValue = coerce;
		return Self;
	}

	public IntegerNumberPropertyDescriptor CopyTo(Elastic.Clients.Elasticsearch.Serverless.Fields? copyTo)
	{
		CopyToValue = copyTo;
		return Self;
	}

	public IntegerNumberPropertyDescriptor DocValues(bool? docValues = true)
	{
		DocValuesValue = docValues;
		return Self;
	}

	public IntegerNumberPropertyDescriptor Dynamic(Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public IntegerNumberPropertyDescriptor Fields(Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public IntegerNumberPropertyDescriptor Fields<TDocument>(PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public IntegerNumberPropertyDescriptor Fields<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public IntegerNumberPropertyDescriptor IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public IntegerNumberPropertyDescriptor IgnoreMalformed(bool? ignoreMalformed = true)
	{
		IgnoreMalformedValue = ignoreMalformed;
		return Self;
	}

	public IntegerNumberPropertyDescriptor Index(bool? index = true)
	{
		IndexValue = index;
		return Self;
	}

	public IntegerNumberPropertyDescriptor Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public IntegerNumberPropertyDescriptor NullValue(int? nullValue)
	{
		NullValueValue = nullValue;
		return Self;
	}

	public IntegerNumberPropertyDescriptor OnScriptError(Elastic.Clients.Elasticsearch.Serverless.Mapping.OnScriptError? onScriptError)
	{
		OnScriptErrorValue = onScriptError;
		return Self;
	}

	public IntegerNumberPropertyDescriptor Properties(Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public IntegerNumberPropertyDescriptor Properties<TDocument>(PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public IntegerNumberPropertyDescriptor Properties<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public IntegerNumberPropertyDescriptor Script(Elastic.Clients.Elasticsearch.Serverless.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	public IntegerNumberPropertyDescriptor Similarity(string? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	public IntegerNumberPropertyDescriptor Store(bool? store = true)
	{
		StoreValue = store;
		return Self;
	}

	public IntegerNumberPropertyDescriptor TimeSeriesDimension(bool? timeSeriesDimension = true)
	{
		TimeSeriesDimensionValue = timeSeriesDimension;
		return Self;
	}

	public IntegerNumberPropertyDescriptor TimeSeriesMetric(Elastic.Clients.Elasticsearch.Serverless.Mapping.TimeSeriesMetricType? timeSeriesMetric)
	{
		TimeSeriesMetricValue = timeSeriesMetric;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
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

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
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

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (NullValueValue.HasValue)
		{
			writer.WritePropertyName("null_value");
			writer.WriteNumberValue(NullValueValue.Value);
		}

		if (OnScriptErrorValue is not null)
		{
			writer.WritePropertyName("on_script_error");
			JsonSerializer.Serialize(writer, OnScriptErrorValue, options);
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

		if (TimeSeriesDimensionValue.HasValue)
		{
			writer.WritePropertyName("time_series_dimension");
			writer.WriteBooleanValue(TimeSeriesDimensionValue.Value);
		}

		if (TimeSeriesMetricValue is not null)
		{
			writer.WritePropertyName("time_series_metric");
			JsonSerializer.Serialize(writer, TimeSeriesMetricValue, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("integer");
		writer.WriteEndObject();
	}

	IntegerNumberProperty IBuildableDescriptor<IntegerNumberProperty>.Build() => new()
	{
		Boost = BoostValue,
		Coerce = CoerceValue,
		CopyTo = CopyToValue,
		DocValues = DocValuesValue,
		Dynamic = DynamicValue,
		Fields = FieldsValue,
		IgnoreAbove = IgnoreAboveValue,
		IgnoreMalformed = IgnoreMalformedValue,
		Index = IndexValue,
		Meta = MetaValue,
		NullValue = NullValueValue,
		OnScriptError = OnScriptErrorValue,
		Properties = PropertiesValue,
		Script = ScriptValue,
		Similarity = SimilarityValue,
		Store = StoreValue,
		TimeSeriesDimension = TimeSeriesDimensionValue,
		TimeSeriesMetric = TimeSeriesMetricValue
	};
}