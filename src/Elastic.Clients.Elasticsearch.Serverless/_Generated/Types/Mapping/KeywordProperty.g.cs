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

public sealed partial class KeywordProperty : IProperty
{
	[JsonInclude, JsonPropertyName("boost")]
	public double? Boost { get; set; }
	[JsonInclude, JsonPropertyName("copy_to")]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? CopyTo { get; set; }
	[JsonInclude, JsonPropertyName("doc_values")]
	public bool? DocValues { get; set; }
	[JsonInclude, JsonPropertyName("dynamic")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? Dynamic { get; set; }
	[JsonInclude, JsonPropertyName("eager_global_ordinals")]
	public bool? EagerGlobalOrdinals { get; set; }
	[JsonInclude, JsonPropertyName("fields")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? Fields { get; set; }
	[JsonInclude, JsonPropertyName("ignore_above")]
	public int? IgnoreAbove { get; set; }
	[JsonInclude, JsonPropertyName("index")]
	public bool? Index { get; set; }
	[JsonInclude, JsonPropertyName("index_options")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.IndexOptions? IndexOptions { get; set; }

	/// <summary>
	/// <para>Metadata about the field.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("meta")]
	public IDictionary<string, string>? Meta { get; set; }
	[JsonInclude, JsonPropertyName("normalizer")]
	public string? Normalizer { get; set; }
	[JsonInclude, JsonPropertyName("norms")]
	public bool? Norms { get; set; }
	[JsonInclude, JsonPropertyName("null_value")]
	public string? NullValue { get; set; }
	[JsonInclude, JsonPropertyName("properties")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? Properties { get; set; }
	[JsonInclude, JsonPropertyName("similarity")]
	public string? Similarity { get; set; }
	[JsonInclude, JsonPropertyName("split_queries_on_whitespace")]
	public bool? SplitQueriesOnWhitespace { get; set; }
	[JsonInclude, JsonPropertyName("store")]
	public bool? Store { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "keyword";
}

public sealed partial class KeywordPropertyDescriptor<TDocument> : SerializableDescriptor<KeywordPropertyDescriptor<TDocument>>, IBuildableDescriptor<KeywordProperty>
{
	internal KeywordPropertyDescriptor(Action<KeywordPropertyDescriptor<TDocument>> configure) => configure.Invoke(this);

	public KeywordPropertyDescriptor() : base()
	{
	}

	private double? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fields? CopyToValue { get; set; }
	private bool? DocValuesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? DynamicValue { get; set; }
	private bool? EagerGlobalOrdinalsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? FieldsValue { get; set; }
	private int? IgnoreAboveValue { get; set; }
	private bool? IndexValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.IndexOptions? IndexOptionsValue { get; set; }
	private IDictionary<string, string>? MetaValue { get; set; }
	private string? NormalizerValue { get; set; }
	private bool? NormsValue { get; set; }
	private string? NullValueValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? PropertiesValue { get; set; }
	private string? SimilarityValue { get; set; }
	private bool? SplitQueriesOnWhitespaceValue { get; set; }
	private bool? StoreValue { get; set; }

	public KeywordPropertyDescriptor<TDocument> Boost(double? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> CopyTo(Elastic.Clients.Elasticsearch.Serverless.Fields? copyTo)
	{
		CopyToValue = copyTo;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> DocValues(bool? docValues = true)
	{
		DocValuesValue = docValues;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> Dynamic(Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> EagerGlobalOrdinals(bool? eagerGlobalOrdinals = true)
	{
		EagerGlobalOrdinalsValue = eagerGlobalOrdinals;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> Fields(Action<Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> Index(bool? index = true)
	{
		IndexValue = index;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> IndexOptions(Elastic.Clients.Elasticsearch.Serverless.Mapping.IndexOptions? indexOptions)
	{
		IndexOptionsValue = indexOptions;
		return Self;
	}

	/// <summary>
	/// <para>Metadata about the field.</para>
	/// </summary>
	public KeywordPropertyDescriptor<TDocument> Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> Normalizer(string? normalizer)
	{
		NormalizerValue = normalizer;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> Norms(bool? norms = true)
	{
		NormsValue = norms;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> NullValue(string? nullValue)
	{
		NullValueValue = nullValue;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> Properties(Action<Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> Similarity(string? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> SplitQueriesOnWhitespace(bool? splitQueriesOnWhitespace = true)
	{
		SplitQueriesOnWhitespaceValue = splitQueriesOnWhitespace;
		return Self;
	}

	public KeywordPropertyDescriptor<TDocument> Store(bool? store = true)
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

		if (IndexOptionsValue is not null)
		{
			writer.WritePropertyName("index_options");
			JsonSerializer.Serialize(writer, IndexOptionsValue, options);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (!string.IsNullOrEmpty(NormalizerValue))
		{
			writer.WritePropertyName("normalizer");
			writer.WriteStringValue(NormalizerValue);
		}

		if (NormsValue.HasValue)
		{
			writer.WritePropertyName("norms");
			writer.WriteBooleanValue(NormsValue.Value);
		}

		if (!string.IsNullOrEmpty(NullValueValue))
		{
			writer.WritePropertyName("null_value");
			writer.WriteStringValue(NullValueValue);
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

		if (SplitQueriesOnWhitespaceValue.HasValue)
		{
			writer.WritePropertyName("split_queries_on_whitespace");
			writer.WriteBooleanValue(SplitQueriesOnWhitespaceValue.Value);
		}

		if (StoreValue.HasValue)
		{
			writer.WritePropertyName("store");
			writer.WriteBooleanValue(StoreValue.Value);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("keyword");
		writer.WriteEndObject();
	}

	KeywordProperty IBuildableDescriptor<KeywordProperty>.Build() => new()
	{
		Boost = BoostValue,
		CopyTo = CopyToValue,
		DocValues = DocValuesValue,
		Dynamic = DynamicValue,
		EagerGlobalOrdinals = EagerGlobalOrdinalsValue,
		Fields = FieldsValue,
		IgnoreAbove = IgnoreAboveValue,
		Index = IndexValue,
		IndexOptions = IndexOptionsValue,
		Meta = MetaValue,
		Normalizer = NormalizerValue,
		Norms = NormsValue,
		NullValue = NullValueValue,
		Properties = PropertiesValue,
		Similarity = SimilarityValue,
		SplitQueriesOnWhitespace = SplitQueriesOnWhitespaceValue,
		Store = StoreValue
	};
}

public sealed partial class KeywordPropertyDescriptor : SerializableDescriptor<KeywordPropertyDescriptor>, IBuildableDescriptor<KeywordProperty>
{
	internal KeywordPropertyDescriptor(Action<KeywordPropertyDescriptor> configure) => configure.Invoke(this);

	public KeywordPropertyDescriptor() : base()
	{
	}

	private double? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fields? CopyToValue { get; set; }
	private bool? DocValuesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? DynamicValue { get; set; }
	private bool? EagerGlobalOrdinalsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? FieldsValue { get; set; }
	private int? IgnoreAboveValue { get; set; }
	private bool? IndexValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.IndexOptions? IndexOptionsValue { get; set; }
	private IDictionary<string, string>? MetaValue { get; set; }
	private string? NormalizerValue { get; set; }
	private bool? NormsValue { get; set; }
	private string? NullValueValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? PropertiesValue { get; set; }
	private string? SimilarityValue { get; set; }
	private bool? SplitQueriesOnWhitespaceValue { get; set; }
	private bool? StoreValue { get; set; }

	public KeywordPropertyDescriptor Boost(double? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public KeywordPropertyDescriptor CopyTo(Elastic.Clients.Elasticsearch.Serverless.Fields? copyTo)
	{
		CopyToValue = copyTo;
		return Self;
	}

	public KeywordPropertyDescriptor DocValues(bool? docValues = true)
	{
		DocValuesValue = docValues;
		return Self;
	}

	public KeywordPropertyDescriptor Dynamic(Elastic.Clients.Elasticsearch.Serverless.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public KeywordPropertyDescriptor EagerGlobalOrdinals(bool? eagerGlobalOrdinals = true)
	{
		EagerGlobalOrdinalsValue = eagerGlobalOrdinals;
		return Self;
	}

	public KeywordPropertyDescriptor Fields(Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public KeywordPropertyDescriptor Fields<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public KeywordPropertyDescriptor Fields<TDocument>(Action<Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public KeywordPropertyDescriptor IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public KeywordPropertyDescriptor Index(bool? index = true)
	{
		IndexValue = index;
		return Self;
	}

	public KeywordPropertyDescriptor IndexOptions(Elastic.Clients.Elasticsearch.Serverless.Mapping.IndexOptions? indexOptions)
	{
		IndexOptionsValue = indexOptions;
		return Self;
	}

	/// <summary>
	/// <para>Metadata about the field.</para>
	/// </summary>
	public KeywordPropertyDescriptor Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public KeywordPropertyDescriptor Normalizer(string? normalizer)
	{
		NormalizerValue = normalizer;
		return Self;
	}

	public KeywordPropertyDescriptor Norms(bool? norms = true)
	{
		NormsValue = norms;
		return Self;
	}

	public KeywordPropertyDescriptor NullValue(string? nullValue)
	{
		NullValueValue = nullValue;
		return Self;
	}

	public KeywordPropertyDescriptor Properties(Elastic.Clients.Elasticsearch.Serverless.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public KeywordPropertyDescriptor Properties<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public KeywordPropertyDescriptor Properties<TDocument>(Action<Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new Elastic.Clients.Elasticsearch.Serverless.Mapping.PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public KeywordPropertyDescriptor Similarity(string? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	public KeywordPropertyDescriptor SplitQueriesOnWhitespace(bool? splitQueriesOnWhitespace = true)
	{
		SplitQueriesOnWhitespaceValue = splitQueriesOnWhitespace;
		return Self;
	}

	public KeywordPropertyDescriptor Store(bool? store = true)
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

		if (IndexOptionsValue is not null)
		{
			writer.WritePropertyName("index_options");
			JsonSerializer.Serialize(writer, IndexOptionsValue, options);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (!string.IsNullOrEmpty(NormalizerValue))
		{
			writer.WritePropertyName("normalizer");
			writer.WriteStringValue(NormalizerValue);
		}

		if (NormsValue.HasValue)
		{
			writer.WritePropertyName("norms");
			writer.WriteBooleanValue(NormsValue.Value);
		}

		if (!string.IsNullOrEmpty(NullValueValue))
		{
			writer.WritePropertyName("null_value");
			writer.WriteStringValue(NullValueValue);
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

		if (SplitQueriesOnWhitespaceValue.HasValue)
		{
			writer.WritePropertyName("split_queries_on_whitespace");
			writer.WriteBooleanValue(SplitQueriesOnWhitespaceValue.Value);
		}

		if (StoreValue.HasValue)
		{
			writer.WritePropertyName("store");
			writer.WriteBooleanValue(StoreValue.Value);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("keyword");
		writer.WriteEndObject();
	}

	KeywordProperty IBuildableDescriptor<KeywordProperty>.Build() => new()
	{
		Boost = BoostValue,
		CopyTo = CopyToValue,
		DocValues = DocValuesValue,
		Dynamic = DynamicValue,
		EagerGlobalOrdinals = EagerGlobalOrdinalsValue,
		Fields = FieldsValue,
		IgnoreAbove = IgnoreAboveValue,
		Index = IndexValue,
		IndexOptions = IndexOptionsValue,
		Meta = MetaValue,
		Normalizer = NormalizerValue,
		Norms = NormsValue,
		NullValue = NullValueValue,
		Properties = PropertiesValue,
		Similarity = SimilarityValue,
		SplitQueriesOnWhitespace = SplitQueriesOnWhitespaceValue,
		Store = StoreValue
	};
}