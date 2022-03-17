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
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	internal sealed class SpanTermQueryConverter : FieldNameQueryConverterBase<SpanTermQuery>
	{
		internal override SpanTermQuery ReadInternal(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			var variant = new SpanTermQuery();
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					var property = reader.GetString();
					if (property == "value")
					{
						variant.Value = JsonSerializer.Deserialize<string>(ref reader, options);
						continue;
					}

					if (property == "_name")
					{
						variant.QueryName = JsonSerializer.Deserialize<string?>(ref reader, options);
						continue;
					}

					if (property == "boost")
					{
						variant.Boost = JsonSerializer.Deserialize<float?>(ref reader, options);
						continue;
					}
				}
			}

			reader.Read();
			return variant;
		}

		internal override void WriteInternal(Utf8JsonWriter writer, SpanTermQuery value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("value");
			writer.WriteStringValue(value.Value);
			if (!string.IsNullOrEmpty(value.QueryName))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(value.QueryName);
			}

			if (value.Boost.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(value.Boost.Value);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(SpanTermQueryConverter))]
	public partial class SpanTermQuery : FieldNameQueryBase, IQueryContainerVariant, ISpanQueryVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "span_term";
		[JsonIgnore]
		string QueryDsl.ISpanQueryVariant.SpanQueryVariantName => "span_term";
		[JsonInclude]
		[JsonPropertyName("value")]
		public string Value { get; set; }
	}

	public sealed partial class SpanTermQueryDescriptor<TDocument> : DescriptorBase<SpanTermQueryDescriptor<TDocument>>
	{
		internal SpanTermQueryDescriptor(Action<SpanTermQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public SpanTermQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private string ValueValue { get; set; }

		public SpanTermQueryDescriptor<TDocument> QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public SpanTermQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public SpanTermQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public SpanTermQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public SpanTermQueryDescriptor<TDocument> Value(string value)
		{
			ValueValue = value;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WritePropertyName("value");
			writer.WriteStringValue(ValueValue);
			writer.WriteEndObject();
			writer.WriteEndObject();
		}
	}

	public sealed partial class SpanTermQueryDescriptor : DescriptorBase<SpanTermQueryDescriptor>
	{
		internal SpanTermQueryDescriptor(Action<SpanTermQueryDescriptor> configure) => configure.Invoke(this);
		public SpanTermQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private string ValueValue { get; set; }

		public SpanTermQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public SpanTermQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public SpanTermQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public SpanTermQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public SpanTermQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public SpanTermQueryDescriptor Value(string value)
		{
			ValueValue = value;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WritePropertyName("value");
			writer.WriteStringValue(ValueValue);
			writer.WriteEndObject();
			writer.WriteEndObject();
		}
	}
}