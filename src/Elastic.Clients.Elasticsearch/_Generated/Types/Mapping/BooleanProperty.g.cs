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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Mapping
{
	public partial class BooleanProperty : DocValuesPropertyBase, IProperty
	{
		[JsonInclude]
		[JsonPropertyName("boost")]
		public double? Boost { get; set; }

		[JsonInclude]
		[JsonPropertyName("fielddata")]
		public Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata? Fielddata { get; set; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public bool? Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("null_value")]
		public bool? NullValue { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "boolean";
	}

	public sealed partial class BooleanPropertyDescriptor<TDocument> : SerializableDescriptorBase<BooleanPropertyDescriptor<TDocument>>
	{
		internal BooleanPropertyDescriptor(Action<BooleanPropertyDescriptor<TDocument>> configure) => configure.Invoke(this);
		public BooleanPropertyDescriptor() : base()
		{
		}

		private double? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }

		private bool? DocValuesValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

		private Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata? FielddataValue { get; set; }

		private IndexManagement.NumericFielddataDescriptor FielddataDescriptor { get; set; }

		private Action<IndexManagement.NumericFielddataDescriptor> FielddataDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

		private int? IgnoreAboveValue { get; set; }

		private bool? IndexValue { get; set; }

		private Dictionary<string, object>? LocalMetadataValue { get; set; }

		private Dictionary<string, string>? MetaValue { get; set; }

		private bool? NullValueValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

		private string? SimilarityValue { get; set; }

		private bool? StoreValue { get; set; }

		public BooleanPropertyDescriptor<TDocument> Boost(double? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public BooleanPropertyDescriptor<TDocument> CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public BooleanPropertyDescriptor<TDocument> CopyTo<TValue>(Expression<Func<TDocument, TValue>> copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public BooleanPropertyDescriptor<TDocument> DocValues(bool? docValues = true)
		{
			DocValuesValue = docValues;
			return Self;
		}

		public BooleanPropertyDescriptor<TDocument> Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
		{
			DynamicValue = dynamic;
			return Self;
		}

		public BooleanPropertyDescriptor<TDocument> Fielddata(Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata? fielddata)
		{
			FielddataDescriptor = null;
			FielddataDescriptorAction = null;
			FielddataValue = fielddata;
			return Self;
		}

		public BooleanPropertyDescriptor<TDocument> Fielddata(IndexManagement.NumericFielddataDescriptor descriptor)
		{
			FielddataValue = null;
			FielddataDescriptorAction = null;
			FielddataDescriptor = descriptor;
			return Self;
		}

		public BooleanPropertyDescriptor<TDocument> Fielddata(Action<IndexManagement.NumericFielddataDescriptor> configure)
		{
			FielddataValue = null;
			FielddataDescriptor = null;
			FielddataDescriptorAction = configure;
			return Self;
		}

		public BooleanPropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public BooleanPropertyDescriptor<TDocument> IgnoreAbove(int? ignoreAbove)
		{
			IgnoreAboveValue = ignoreAbove;
			return Self;
		}

		public BooleanPropertyDescriptor<TDocument> Index(bool? index = true)
		{
			IndexValue = index;
			return Self;
		}

		public BooleanPropertyDescriptor<TDocument> LocalMetadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			LocalMetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public BooleanPropertyDescriptor<TDocument> Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
			return Self;
		}

		public BooleanPropertyDescriptor<TDocument> NullValue(bool? nullValue = true)
		{
			NullValueValue = nullValue;
			return Self;
		}

		public BooleanPropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
		{
			PropertiesValue = properties;
			return Self;
		}

		public BooleanPropertyDescriptor<TDocument> Similarity(string? similarity)
		{
			SimilarityValue = similarity;
			return Self;
		}

		public BooleanPropertyDescriptor<TDocument> Store(bool? store = true)
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

			if (FielddataDescriptor is not null)
			{
				writer.WritePropertyName("fielddata");
				JsonSerializer.Serialize(writer, FielddataDescriptor, options);
			}
			else if (FielddataDescriptorAction is not null)
			{
				writer.WritePropertyName("fielddata");
				JsonSerializer.Serialize(writer, new IndexManagement.NumericFielddataDescriptor(FielddataDescriptorAction), options);
			}
			else if (FielddataValue is not null)
			{
				writer.WritePropertyName("fielddata");
				JsonSerializer.Serialize(writer, FielddataValue, options);
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

			if (LocalMetadataValue is not null)
			{
				writer.WritePropertyName("local_metadata");
				JsonSerializer.Serialize(writer, LocalMetadataValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (NullValueValue.HasValue)
			{
				writer.WritePropertyName("null_value");
				writer.WriteBooleanValue(NullValueValue.Value);
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
			writer.WriteStringValue("boolean");
			writer.WriteEndObject();
		}
	}

	public sealed partial class BooleanPropertyDescriptor : SerializableDescriptorBase<BooleanPropertyDescriptor>
	{
		internal BooleanPropertyDescriptor(Action<BooleanPropertyDescriptor> configure) => configure.Invoke(this);
		public BooleanPropertyDescriptor() : base()
		{
		}

		private double? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }

		private bool? DocValuesValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

		private Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata? FielddataValue { get; set; }

		private IndexManagement.NumericFielddataDescriptor FielddataDescriptor { get; set; }

		private Action<IndexManagement.NumericFielddataDescriptor> FielddataDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

		private int? IgnoreAboveValue { get; set; }

		private bool? IndexValue { get; set; }

		private Dictionary<string, object>? LocalMetadataValue { get; set; }

		private Dictionary<string, string>? MetaValue { get; set; }

		private bool? NullValueValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

		private string? SimilarityValue { get; set; }

		private bool? StoreValue { get; set; }

		public BooleanPropertyDescriptor Boost(double? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public BooleanPropertyDescriptor CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public BooleanPropertyDescriptor CopyTo<TDocument, TValue>(Expression<Func<TDocument, TValue>> copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public BooleanPropertyDescriptor CopyTo<TDocument>(Expression<Func<TDocument, object>> copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public BooleanPropertyDescriptor DocValues(bool? docValues = true)
		{
			DocValuesValue = docValues;
			return Self;
		}

		public BooleanPropertyDescriptor Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
		{
			DynamicValue = dynamic;
			return Self;
		}

		public BooleanPropertyDescriptor Fielddata(Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata? fielddata)
		{
			FielddataDescriptor = null;
			FielddataDescriptorAction = null;
			FielddataValue = fielddata;
			return Self;
		}

		public BooleanPropertyDescriptor Fielddata(IndexManagement.NumericFielddataDescriptor descriptor)
		{
			FielddataValue = null;
			FielddataDescriptorAction = null;
			FielddataDescriptor = descriptor;
			return Self;
		}

		public BooleanPropertyDescriptor Fielddata(Action<IndexManagement.NumericFielddataDescriptor> configure)
		{
			FielddataValue = null;
			FielddataDescriptor = null;
			FielddataDescriptorAction = configure;
			return Self;
		}

		public BooleanPropertyDescriptor Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public BooleanPropertyDescriptor IgnoreAbove(int? ignoreAbove)
		{
			IgnoreAboveValue = ignoreAbove;
			return Self;
		}

		public BooleanPropertyDescriptor Index(bool? index = true)
		{
			IndexValue = index;
			return Self;
		}

		public BooleanPropertyDescriptor LocalMetadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			LocalMetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public BooleanPropertyDescriptor Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
			return Self;
		}

		public BooleanPropertyDescriptor NullValue(bool? nullValue = true)
		{
			NullValueValue = nullValue;
			return Self;
		}

		public BooleanPropertyDescriptor Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
		{
			PropertiesValue = properties;
			return Self;
		}

		public BooleanPropertyDescriptor Similarity(string? similarity)
		{
			SimilarityValue = similarity;
			return Self;
		}

		public BooleanPropertyDescriptor Store(bool? store = true)
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

			if (FielddataDescriptor is not null)
			{
				writer.WritePropertyName("fielddata");
				JsonSerializer.Serialize(writer, FielddataDescriptor, options);
			}
			else if (FielddataDescriptorAction is not null)
			{
				writer.WritePropertyName("fielddata");
				JsonSerializer.Serialize(writer, new IndexManagement.NumericFielddataDescriptor(FielddataDescriptorAction), options);
			}
			else if (FielddataValue is not null)
			{
				writer.WritePropertyName("fielddata");
				JsonSerializer.Serialize(writer, FielddataValue, options);
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

			if (LocalMetadataValue is not null)
			{
				writer.WritePropertyName("local_metadata");
				JsonSerializer.Serialize(writer, LocalMetadataValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (NullValueValue.HasValue)
			{
				writer.WritePropertyName("null_value");
				writer.WriteBooleanValue(NullValueValue.Value);
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
			writer.WriteStringValue("boolean");
			writer.WriteEndObject();
		}
	}
}