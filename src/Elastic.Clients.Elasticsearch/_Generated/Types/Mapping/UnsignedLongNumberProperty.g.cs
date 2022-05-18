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
	public partial class UnsignedLongNumberProperty : NumberPropertyBase, IProperty
	{
		[JsonInclude]
		[JsonPropertyName("null_value")]
		public long? NullValue { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "unsigned_long";
	}

	public sealed partial class UnsignedLongNumberPropertyDescriptor<TDocument> : SerializableDescriptorBase<UnsignedLongNumberPropertyDescriptor<TDocument>>
	{
		internal UnsignedLongNumberPropertyDescriptor(Action<UnsignedLongNumberPropertyDescriptor<TDocument>> configure) => configure.Invoke(this);
		public UnsignedLongNumberPropertyDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }

		private bool? DocValuesValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

		private int? IgnoreAboveValue { get; set; }

		private bool? IgnoreMalformedValue { get; set; }

		private bool? IndexValue { get; set; }

		private Dictionary<string, object>? LocalMetadataValue { get; set; }

		private Dictionary<string, string>? MetaValue { get; set; }

		private long? NullValueValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

		private string? SimilarityValue { get; set; }

		private bool? StoreValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.TimeSeriesMetricType? TimeSeriesMetricValue { get; set; }

		public UnsignedLongNumberPropertyDescriptor<TDocument> CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor<TDocument> CopyTo<TValue>(Expression<Func<TDocument, TValue>> copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor<TDocument> DocValues(bool? docValues = true)
		{
			DocValuesValue = docValues;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor<TDocument> Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
		{
			DynamicValue = dynamic;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor<TDocument> IgnoreAbove(int? ignoreAbove)
		{
			IgnoreAboveValue = ignoreAbove;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor<TDocument> IgnoreMalformed(bool? ignoreMalformed = true)
		{
			IgnoreMalformedValue = ignoreMalformed;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor<TDocument> Index(bool? index = true)
		{
			IndexValue = index;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor<TDocument> LocalMetadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			LocalMetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor<TDocument> Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor<TDocument> NullValue(long? nullValue)
		{
			NullValueValue = nullValue;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
		{
			PropertiesValue = properties;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor<TDocument> Similarity(string? similarity)
		{
			SimilarityValue = similarity;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor<TDocument> Store(bool? store = true)
		{
			StoreValue = store;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor<TDocument> TimeSeriesMetric(Elastic.Clients.Elasticsearch.Mapping.TimeSeriesMetricType? timeSeriesMetric)
		{
			TimeSeriesMetricValue = timeSeriesMetric;
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
				writer.WriteNumberValue(NullValueValue.Value);
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

			if (TimeSeriesMetricValue is not null)
			{
				writer.WritePropertyName("time_series_metric");
				JsonSerializer.Serialize(writer, TimeSeriesMetricValue, options);
			}

			writer.WritePropertyName("type");
			writer.WriteStringValue("unsigned_long");
			writer.WriteEndObject();
		}
	}

	public sealed partial class UnsignedLongNumberPropertyDescriptor : SerializableDescriptorBase<UnsignedLongNumberPropertyDescriptor>
	{
		internal UnsignedLongNumberPropertyDescriptor(Action<UnsignedLongNumberPropertyDescriptor> configure) => configure.Invoke(this);
		public UnsignedLongNumberPropertyDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }

		private bool? DocValuesValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

		private int? IgnoreAboveValue { get; set; }

		private bool? IgnoreMalformedValue { get; set; }

		private bool? IndexValue { get; set; }

		private Dictionary<string, object>? LocalMetadataValue { get; set; }

		private Dictionary<string, string>? MetaValue { get; set; }

		private long? NullValueValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

		private string? SimilarityValue { get; set; }

		private bool? StoreValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.TimeSeriesMetricType? TimeSeriesMetricValue { get; set; }

		public UnsignedLongNumberPropertyDescriptor CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor CopyTo<TDocument, TValue>(Expression<Func<TDocument, TValue>> copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor CopyTo<TDocument>(Expression<Func<TDocument, object>> copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor DocValues(bool? docValues = true)
		{
			DocValuesValue = docValues;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
		{
			DynamicValue = dynamic;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor IgnoreAbove(int? ignoreAbove)
		{
			IgnoreAboveValue = ignoreAbove;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor IgnoreMalformed(bool? ignoreMalformed = true)
		{
			IgnoreMalformedValue = ignoreMalformed;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor Index(bool? index = true)
		{
			IndexValue = index;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor LocalMetadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			LocalMetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor NullValue(long? nullValue)
		{
			NullValueValue = nullValue;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
		{
			PropertiesValue = properties;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor Similarity(string? similarity)
		{
			SimilarityValue = similarity;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor Store(bool? store = true)
		{
			StoreValue = store;
			return Self;
		}

		public UnsignedLongNumberPropertyDescriptor TimeSeriesMetric(Elastic.Clients.Elasticsearch.Mapping.TimeSeriesMetricType? timeSeriesMetric)
		{
			TimeSeriesMetricValue = timeSeriesMetric;
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
				writer.WriteNumberValue(NullValueValue.Value);
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

			if (TimeSeriesMetricValue is not null)
			{
				writer.WritePropertyName("time_series_metric");
				JsonSerializer.Serialize(writer, TimeSeriesMetricValue, options);
			}

			writer.WritePropertyName("type");
			writer.WriteStringValue("unsigned_long");
			writer.WriteEndObject();
		}
	}
}