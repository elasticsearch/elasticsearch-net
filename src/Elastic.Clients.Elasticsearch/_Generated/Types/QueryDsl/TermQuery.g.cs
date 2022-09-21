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
	internal sealed class TermQueryConverter : JsonConverter<TermQuery>
	{
		public override TermQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			reader.Read();
			reader.Read();
			var fieldName = reader.GetString();
			reader.Read();
			var variant = new TermQuery(fieldName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					var property = reader.GetString();
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

					if (property == "case_insensitive")
					{
						variant.CaseInsensitive = JsonSerializer.Deserialize<bool?>(ref reader, options);
						continue;
					}

					if (property == "value")
					{
						variant.Value = JsonSerializer.Deserialize<object>(ref reader, options);
						continue;
					}
				}
			}

			reader.Read();
			reader.Read();
			return variant;
		}

		public override void Write(Utf8JsonWriter writer, TermQuery value, JsonSerializerOptions options)
		{
			if (value.Field is null)
				writer.WriteNullValue();
			if (options.TryGetClientSettings(out var settings))
			{
				writer.WriteStartObject();
				writer.WritePropertyName(settings.Inferrer.Field(value.Field));
				writer.WriteStartObject();
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

				if (value.CaseInsensitive.HasValue)
				{
					writer.WritePropertyName("case_insensitive");
					writer.WriteBooleanValue(value.CaseInsensitive.Value);
				}

				writer.WritePropertyName("value");
				JsonSerializer.Serialize(writer, value.Value, options);
				writer.WriteEndObject();
				writer.WriteEndObject();
				return;
			}

			throw new JsonException("Unable to retrieve client settings to infer field.");
		}
	}

	[JsonConverter(typeof(TermQueryConverter))]
	public sealed partial class TermQuery : Query, IQueryVariant
	{
		public TermQuery(Field field)
		{
			if (field is null)
				throw new ArgumentNullException(nameof(field));
			Field = field;
		}

		public string? QueryName { get; set; }

		public float? Boost { get; set; }

		public bool? CaseInsensitive { get; set; }

		public object Value { get; set; }

		public Elastic.Clients.Elasticsearch.Field Field { get; init; }
	}

	public sealed partial class TermQueryDescriptor<TDocument> : SerializableDescriptorBase<TermQueryDescriptor<TDocument>>
	{
		internal TermQueryDescriptor(Action<TermQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal TermQueryDescriptor() : base()
		{
		}

		public TermQueryDescriptor(Field field)
		{
			if (field is null)
				throw new ArgumentNullException(nameof(field));
			FieldValue = field;
		}

		public TermQueryDescriptor(Expression<Func<TDocument, object>> field)
		{
			if (field is null)
				throw new ArgumentNullException(nameof(field));
			FieldValue = field;
		}

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private bool? CaseInsensitiveValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private object ValueValue { get; set; }

		public TermQueryDescriptor<TDocument> QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public TermQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public TermQueryDescriptor<TDocument> CaseInsensitive(bool? caseInsensitive = true)
		{
			CaseInsensitiveValue = caseInsensitive;
			return Self;
		}

		public TermQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public TermQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public TermQueryDescriptor<TDocument> Value(object value)
		{
			ValueValue = value;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (FieldValue is null)
				throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
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

			if (CaseInsensitiveValue.HasValue)
			{
				writer.WritePropertyName("case_insensitive");
				writer.WriteBooleanValue(CaseInsensitiveValue.Value);
			}

			writer.WritePropertyName("value");
			JsonSerializer.Serialize(writer, ValueValue, options);
			writer.WriteEndObject();
			writer.WriteEndObject();
		}
	}

	public sealed partial class TermQueryDescriptor : SerializableDescriptorBase<TermQueryDescriptor>
	{
		internal TermQueryDescriptor(Action<TermQueryDescriptor> configure) => configure.Invoke(this);
		internal TermQueryDescriptor() : base()
		{
		}

		public TermQueryDescriptor(Field field)
		{
			if (field is null)
				throw new ArgumentNullException(nameof(field));
			FieldValue = field;
		}

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private bool? CaseInsensitiveValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private object ValueValue { get; set; }

		public TermQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public TermQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public TermQueryDescriptor CaseInsensitive(bool? caseInsensitive = true)
		{
			CaseInsensitiveValue = caseInsensitive;
			return Self;
		}

		public TermQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public TermQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public TermQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public TermQueryDescriptor Value(object value)
		{
			ValueValue = value;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (FieldValue is null)
				throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
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

			if (CaseInsensitiveValue.HasValue)
			{
				writer.WritePropertyName("case_insensitive");
				writer.WriteBooleanValue(CaseInsensitiveValue.Value);
			}

			writer.WritePropertyName("value");
			JsonSerializer.Serialize(writer, ValueValue, options);
			writer.WriteEndObject();
			writer.WriteEndObject();
		}
	}
}