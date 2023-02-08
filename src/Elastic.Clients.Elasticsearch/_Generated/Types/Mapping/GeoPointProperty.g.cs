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
public sealed partial class GeoPointProperty : IProperty
{
	[JsonInclude, JsonPropertyName("copy_to")]
	public Elastic.Clients.Elasticsearch.Fields? CopyTo { get; set; }

	[JsonInclude, JsonPropertyName("doc_values")]
	public bool? DocValues { get; set; }

	[JsonInclude, JsonPropertyName("dynamic")]
	public Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? Dynamic { get; set; }

	[JsonInclude, JsonPropertyName("fields")]
	public Elastic.Clients.Elasticsearch.Mapping.Properties? Fields { get; set; }

	[JsonInclude, JsonPropertyName("ignore_above")]
	public int? IgnoreAbove { get; set; }

	[JsonInclude, JsonPropertyName("ignore_malformed")]
	public bool? IgnoreMalformed { get; set; }

	[JsonInclude, JsonPropertyName("ignore_z_value")]
	public bool? IgnoreZValue { get; set; }

	[JsonInclude, JsonPropertyName("meta")]
	public IDictionary<string, string>? Meta { get; set; }

	[JsonInclude, JsonPropertyName("properties")]
	public Elastic.Clients.Elasticsearch.Mapping.Properties? Properties { get; set; }

	[JsonInclude, JsonPropertyName("similarity")]
	public string? Similarity { get; set; }

	[JsonInclude, JsonPropertyName("store")]
	public bool? Store { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "geo_point";
}

public sealed partial class GeoPointPropertyDescriptor<TDocument> : SerializableDescriptor<GeoPointPropertyDescriptor<TDocument>>, IBuildableDescriptor<GeoPointProperty>
{
	internal GeoPointPropertyDescriptor(Action<GeoPointPropertyDescriptor<TDocument>> configure) => configure.Invoke(this);
	public GeoPointPropertyDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }

	private bool? DocValuesValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

	private int? IgnoreAboveValue { get; set; }

	private bool? IgnoreMalformedValue { get; set; }

	private bool? IgnoreZValueValue { get; set; }

	private IDictionary<string, string>? MetaValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

	private string? SimilarityValue { get; set; }

	private bool? StoreValue { get; set; }

	public GeoPointPropertyDescriptor<TDocument> CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
	{
		CopyToValue = copyTo;
		return Self;
	}

	public GeoPointPropertyDescriptor<TDocument> DocValues(bool? docValues = true)
	{
		DocValuesValue = docValues;
		return Self;
	}

	public GeoPointPropertyDescriptor<TDocument> Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public GeoPointPropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public GeoPointPropertyDescriptor<TDocument> Fields(PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public GeoPointPropertyDescriptor<TDocument> Fields(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public GeoPointPropertyDescriptor<TDocument> IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public GeoPointPropertyDescriptor<TDocument> IgnoreMalformed(bool? ignoreMalformed = true)
	{
		IgnoreMalformedValue = ignoreMalformed;
		return Self;
	}

	public GeoPointPropertyDescriptor<TDocument> IgnoreZValue(bool? ignoreZValue = true)
	{
		IgnoreZValueValue = ignoreZValue;
		return Self;
	}

	public GeoPointPropertyDescriptor<TDocument> Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public GeoPointPropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public GeoPointPropertyDescriptor<TDocument> Properties(PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public GeoPointPropertyDescriptor<TDocument> Properties(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public GeoPointPropertyDescriptor<TDocument> Similarity(string? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	public GeoPointPropertyDescriptor<TDocument> Store(bool? store = true)
	{
		StoreValue = store;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
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

		if (IgnoreZValueValue.HasValue)
		{
			writer.WritePropertyName("ignore_z_value");
			writer.WriteBooleanValue(IgnoreZValueValue.Value);
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
		writer.WriteStringValue("geo_point");
		writer.WriteEndObject();
	}

	GeoPointProperty IBuildableDescriptor<GeoPointProperty>.Build() => new()
	{ CopyTo = CopyToValue, DocValues = DocValuesValue, Dynamic = DynamicValue, Fields = FieldsValue, IgnoreAbove = IgnoreAboveValue, IgnoreMalformed = IgnoreMalformedValue, IgnoreZValue = IgnoreZValueValue, Meta = MetaValue, Properties = PropertiesValue, Similarity = SimilarityValue, Store = StoreValue };
}

public sealed partial class GeoPointPropertyDescriptor : SerializableDescriptor<GeoPointPropertyDescriptor>, IBuildableDescriptor<GeoPointProperty>
{
	internal GeoPointPropertyDescriptor(Action<GeoPointPropertyDescriptor> configure) => configure.Invoke(this);
	public GeoPointPropertyDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }

	private bool? DocValuesValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

	private int? IgnoreAboveValue { get; set; }

	private bool? IgnoreMalformedValue { get; set; }

	private bool? IgnoreZValueValue { get; set; }

	private IDictionary<string, string>? MetaValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

	private string? SimilarityValue { get; set; }

	private bool? StoreValue { get; set; }

	public GeoPointPropertyDescriptor CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
	{
		CopyToValue = copyTo;
		return Self;
	}

	public GeoPointPropertyDescriptor DocValues(bool? docValues = true)
	{
		DocValuesValue = docValues;
		return Self;
	}

	public GeoPointPropertyDescriptor Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public GeoPointPropertyDescriptor Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public GeoPointPropertyDescriptor Fields<TDocument>(PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public GeoPointPropertyDescriptor Fields<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public GeoPointPropertyDescriptor IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public GeoPointPropertyDescriptor IgnoreMalformed(bool? ignoreMalformed = true)
	{
		IgnoreMalformedValue = ignoreMalformed;
		return Self;
	}

	public GeoPointPropertyDescriptor IgnoreZValue(bool? ignoreZValue = true)
	{
		IgnoreZValueValue = ignoreZValue;
		return Self;
	}

	public GeoPointPropertyDescriptor Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public GeoPointPropertyDescriptor Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public GeoPointPropertyDescriptor Properties<TDocument>(PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public GeoPointPropertyDescriptor Properties<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public GeoPointPropertyDescriptor Similarity(string? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	public GeoPointPropertyDescriptor Store(bool? store = true)
	{
		StoreValue = store;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
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

		if (IgnoreZValueValue.HasValue)
		{
			writer.WritePropertyName("ignore_z_value");
			writer.WriteBooleanValue(IgnoreZValueValue.Value);
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
		writer.WriteStringValue("geo_point");
		writer.WriteEndObject();
	}

	GeoPointProperty IBuildableDescriptor<GeoPointProperty>.Build() => new()
	{ CopyTo = CopyToValue, DocValues = DocValuesValue, Dynamic = DynamicValue, Fields = FieldsValue, IgnoreAbove = IgnoreAboveValue, IgnoreMalformed = IgnoreMalformedValue, IgnoreZValue = IgnoreZValueValue, Meta = MetaValue, Properties = PropertiesValue, Similarity = SimilarityValue, Store = StoreValue };
}