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

public sealed partial class FloatRangeProperty : IProperty
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
	[JsonInclude, JsonPropertyName("index")]
	public bool? Index { get; set; }
	[JsonInclude, JsonPropertyName("meta")]
	public IDictionary<string, string>? Meta { get; set; }
	[JsonInclude, JsonPropertyName("properties")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? Properties { get; set; }
	[JsonInclude, JsonPropertyName("similarity")]
	public string? Similarity { get; set; }
	[JsonInclude, JsonPropertyName("store")]
	public bool? Store { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "float_range";
}

public sealed partial class FloatRangePropertyDescriptor<TDocument> : SerializableDescriptor<FloatRangePropertyDescriptor<TDocument>>, IBuildableDescriptor<FloatRangeProperty>
{
	internal FloatRangePropertyDescriptor(Action<FloatRangePropertyDescriptor<TDocument>> configure) => configure.Invoke(this);

	public FloatRangePropertyDescriptor() : base()
	{
	}

	private double? BoostValue { get; set; }
	private bool? CoerceValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fields? CopyToValue { get; set; }
	private bool? DocValuesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? DynamicValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? FieldsValue { get; set; }
	private int? IgnoreAboveValue { get; set; }
	private bool? IndexValue { get; set; }
	private IDictionary<string, string>? MetaValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? PropertiesValue { get; set; }
	private string? SimilarityValue { get; set; }
	private bool? StoreValue { get; set; }

	public FloatRangePropertyDescriptor<TDocument> Boost(double? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public FloatRangePropertyDescriptor<TDocument> Coerce(bool? coerce = true)
	{
		CoerceValue = coerce;
		return Self;
	}

	public FloatRangePropertyDescriptor<TDocument> CopyTo(Elastic.Clients.Elasticsearch.Serverless.Fields? copyTo)
	{
		CopyToValue = copyTo;
		return Self;
	}

	public FloatRangePropertyDescriptor<TDocument> DocValues(bool? docValues = true)
	{
		DocValuesValue = docValues;
		return Self;
	}

	public FloatRangePropertyDescriptor<TDocument> Dynamic(Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public FloatRangePropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public FloatRangePropertyDescriptor<TDocument> Fields(PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public FloatRangePropertyDescriptor<TDocument> Fields(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public FloatRangePropertyDescriptor<TDocument> IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public FloatRangePropertyDescriptor<TDocument> Index(bool? index = true)
	{
		IndexValue = index;
		return Self;
	}

	public FloatRangePropertyDescriptor<TDocument> Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public FloatRangePropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public FloatRangePropertyDescriptor<TDocument> Properties(PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public FloatRangePropertyDescriptor<TDocument> Properties(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public FloatRangePropertyDescriptor<TDocument> Similarity(string? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	public FloatRangePropertyDescriptor<TDocument> Store(bool? store = true)
	{
		StoreValue = store;
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

		if (PropertiesValue is not null)
		{
			writer.WritePropertyName("properties");
			JsonSerializer.Serialize(writer, PropertiesValue, options);
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

		writer.WritePropertyName("type");
		writer.WriteStringValue("float_range");
		writer.WriteEndObject();
	}

	FloatRangeProperty IBuildableDescriptor<FloatRangeProperty>.Build() => new()
	{
		Boost = BoostValue,
		Coerce = CoerceValue,
		CopyTo = CopyToValue,
		DocValues = DocValuesValue,
		Dynamic = DynamicValue,
		Fields = FieldsValue,
		IgnoreAbove = IgnoreAboveValue,
		Index = IndexValue,
		Meta = MetaValue,
		Properties = PropertiesValue,
		Similarity = SimilarityValue,
		Store = StoreValue
	};
}

public sealed partial class FloatRangePropertyDescriptor : SerializableDescriptor<FloatRangePropertyDescriptor>, IBuildableDescriptor<FloatRangeProperty>
{
	internal FloatRangePropertyDescriptor(Action<FloatRangePropertyDescriptor> configure) => configure.Invoke(this);

	public FloatRangePropertyDescriptor() : base()
	{
	}

	private double? BoostValue { get; set; }
	private bool? CoerceValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fields? CopyToValue { get; set; }
	private bool? DocValuesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? DynamicValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? FieldsValue { get; set; }
	private int? IgnoreAboveValue { get; set; }
	private bool? IndexValue { get; set; }
	private IDictionary<string, string>? MetaValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? PropertiesValue { get; set; }
	private string? SimilarityValue { get; set; }
	private bool? StoreValue { get; set; }

	public FloatRangePropertyDescriptor Boost(double? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public FloatRangePropertyDescriptor Coerce(bool? coerce = true)
	{
		CoerceValue = coerce;
		return Self;
	}

	public FloatRangePropertyDescriptor CopyTo(Elastic.Clients.Elasticsearch.Serverless.Fields? copyTo)
	{
		CopyToValue = copyTo;
		return Self;
	}

	public FloatRangePropertyDescriptor DocValues(bool? docValues = true)
	{
		DocValuesValue = docValues;
		return Self;
	}

	public FloatRangePropertyDescriptor Dynamic(Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public FloatRangePropertyDescriptor Fields(Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public FloatRangePropertyDescriptor Fields<TDocument>(PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public FloatRangePropertyDescriptor Fields<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public FloatRangePropertyDescriptor IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public FloatRangePropertyDescriptor Index(bool? index = true)
	{
		IndexValue = index;
		return Self;
	}

	public FloatRangePropertyDescriptor Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public FloatRangePropertyDescriptor Properties(Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public FloatRangePropertyDescriptor Properties<TDocument>(PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public FloatRangePropertyDescriptor Properties<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public FloatRangePropertyDescriptor Similarity(string? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	public FloatRangePropertyDescriptor Store(bool? store = true)
	{
		StoreValue = store;
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

		if (PropertiesValue is not null)
		{
			writer.WritePropertyName("properties");
			JsonSerializer.Serialize(writer, PropertiesValue, options);
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

		writer.WritePropertyName("type");
		writer.WriteStringValue("float_range");
		writer.WriteEndObject();
	}

	FloatRangeProperty IBuildableDescriptor<FloatRangeProperty>.Build() => new()
	{
		Boost = BoostValue,
		Coerce = CoerceValue,
		CopyTo = CopyToValue,
		DocValues = DocValuesValue,
		Dynamic = DynamicValue,
		Fields = FieldsValue,
		IgnoreAbove = IgnoreAboveValue,
		Index = IndexValue,
		Meta = MetaValue,
		Properties = PropertiesValue,
		Similarity = SimilarityValue,
		Store = StoreValue
	};
}