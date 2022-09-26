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
	internal sealed class TermsSetQueryConverter : JsonConverter<TermsSetQuery>
	{
		public override TermsSetQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			reader.Read();
			reader.Read();
			var fieldName = reader.GetString();
			reader.Read();
			var variant = new TermsSetQuery(fieldName);
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

					if (property == "minimum_should_match_field")
					{
						variant.MinimumShouldMatchField = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
						continue;
					}

					if (property == "minimum_should_match_script")
					{
						variant.MinimumShouldMatchScript = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
						continue;
					}

					if (property == "terms")
					{
						variant.Terms = JsonSerializer.Deserialize<IEnumerable<string>>(ref reader, options);
						continue;
					}
				}
			}

			reader.Read();
			reader.Read();
			return variant;
		}

		public override void Write(Utf8JsonWriter writer, TermsSetQuery value, JsonSerializerOptions options)
		{
			if (value.Field is null)
				throw new JsonException("Unable to serialize TermsSetQuery because the `Field` property is not set. Field name queries must include a valid field name.");
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

				if (value.MinimumShouldMatchField is not null)
				{
					writer.WritePropertyName("minimum_should_match_field");
					JsonSerializer.Serialize(writer, value.MinimumShouldMatchField, options);
				}

				if (value.MinimumShouldMatchScript is not null)
				{
					writer.WritePropertyName("minimum_should_match_script");
					JsonSerializer.Serialize(writer, value.MinimumShouldMatchScript, options);
				}

				writer.WritePropertyName("terms");
				JsonSerializer.Serialize(writer, value.Terms, options);
				writer.WriteEndObject();
				writer.WriteEndObject();
				return;
			}

			throw new JsonException("Unable to retrieve client settings required to infer field.");
		}
	}

	[JsonConverter(typeof(TermsSetQueryConverter))]
	public sealed partial class TermsSetQuery : Query, IQueryVariant
	{
		public TermsSetQuery(Field field)
		{
			if (field is null)
				throw new ArgumentNullException(nameof(field));
			Field = field;
		}

		public string? QueryName { get; set; }

		public float? Boost { get; set; }

		public Elastic.Clients.Elasticsearch.Field? MinimumShouldMatchField { get; set; }

		public Elastic.Clients.Elasticsearch.Script? MinimumShouldMatchScript { get; set; }

		public IEnumerable<string> Terms { get; set; }

		public Elastic.Clients.Elasticsearch.Field Field { get; set; }
	}

	public sealed partial class TermsSetQueryDescriptor<TDocument> : SerializableDescriptorBase<TermsSetQueryDescriptor<TDocument>>
	{
		internal TermsSetQueryDescriptor(Action<TermsSetQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal TermsSetQueryDescriptor() : base()
		{
		}

		public TermsSetQueryDescriptor(Field field)
		{
			if (field is null)
				throw new ArgumentNullException(nameof(field));
			FieldValue = field;
		}

		public TermsSetQueryDescriptor(Expression<Func<TDocument, object>> field)
		{
			if (field is null)
				throw new ArgumentNullException(nameof(field));
			FieldValue = field;
		}

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? MinimumShouldMatchFieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Script? MinimumShouldMatchScriptValue { get; set; }

		private IEnumerable<string> TermsValue { get; set; }

		public TermsSetQueryDescriptor<TDocument> QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public TermsSetQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public TermsSetQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public TermsSetQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public TermsSetQueryDescriptor<TDocument> MinimumShouldMatchField(Elastic.Clients.Elasticsearch.Field? minimumShouldMatchField)
		{
			MinimumShouldMatchFieldValue = minimumShouldMatchField;
			return Self;
		}

		public TermsSetQueryDescriptor<TDocument> MinimumShouldMatchField<TValue>(Expression<Func<TDocument, TValue>> minimumShouldMatchField)
		{
			MinimumShouldMatchFieldValue = minimumShouldMatchField;
			return Self;
		}

		public TermsSetQueryDescriptor<TDocument> MinimumShouldMatchScript(Elastic.Clients.Elasticsearch.Script? minimumShouldMatchScript)
		{
			MinimumShouldMatchScriptValue = minimumShouldMatchScript;
			return Self;
		}

		public TermsSetQueryDescriptor<TDocument> Terms(IEnumerable<string> terms)
		{
			TermsValue = terms;
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

			if (MinimumShouldMatchFieldValue is not null)
			{
				writer.WritePropertyName("minimum_should_match_field");
				JsonSerializer.Serialize(writer, MinimumShouldMatchFieldValue, options);
			}

			if (MinimumShouldMatchScriptValue is not null)
			{
				writer.WritePropertyName("minimum_should_match_script");
				JsonSerializer.Serialize(writer, MinimumShouldMatchScriptValue, options);
			}

			writer.WritePropertyName("terms");
			JsonSerializer.Serialize(writer, TermsValue, options);
			writer.WriteEndObject();
			writer.WriteEndObject();
		}
	}

	public sealed partial class TermsSetQueryDescriptor : SerializableDescriptorBase<TermsSetQueryDescriptor>
	{
		internal TermsSetQueryDescriptor(Action<TermsSetQueryDescriptor> configure) => configure.Invoke(this);
		internal TermsSetQueryDescriptor() : base()
		{
		}

		public TermsSetQueryDescriptor(Field field)
		{
			if (field is null)
				throw new ArgumentNullException(nameof(field));
			FieldValue = field;
		}

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? MinimumShouldMatchFieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Script? MinimumShouldMatchScriptValue { get; set; }

		private IEnumerable<string> TermsValue { get; set; }

		public TermsSetQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public TermsSetQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public TermsSetQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public TermsSetQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public TermsSetQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public TermsSetQueryDescriptor MinimumShouldMatchField(Elastic.Clients.Elasticsearch.Field? minimumShouldMatchField)
		{
			MinimumShouldMatchFieldValue = minimumShouldMatchField;
			return Self;
		}

		public TermsSetQueryDescriptor MinimumShouldMatchField<TDocument, TValue>(Expression<Func<TDocument, TValue>> minimumShouldMatchField)
		{
			MinimumShouldMatchFieldValue = minimumShouldMatchField;
			return Self;
		}

		public TermsSetQueryDescriptor MinimumShouldMatchField<TDocument>(Expression<Func<TDocument, object>> minimumShouldMatchField)
		{
			MinimumShouldMatchFieldValue = minimumShouldMatchField;
			return Self;
		}

		public TermsSetQueryDescriptor MinimumShouldMatchScript(Elastic.Clients.Elasticsearch.Script? minimumShouldMatchScript)
		{
			MinimumShouldMatchScriptValue = minimumShouldMatchScript;
			return Self;
		}

		public TermsSetQueryDescriptor Terms(IEnumerable<string> terms)
		{
			TermsValue = terms;
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

			if (MinimumShouldMatchFieldValue is not null)
			{
				writer.WritePropertyName("minimum_should_match_field");
				JsonSerializer.Serialize(writer, MinimumShouldMatchFieldValue, options);
			}

			if (MinimumShouldMatchScriptValue is not null)
			{
				writer.WritePropertyName("minimum_should_match_script");
				JsonSerializer.Serialize(writer, MinimumShouldMatchScriptValue, options);
			}

			writer.WritePropertyName("terms");
			JsonSerializer.Serialize(writer, TermsValue, options);
			writer.WriteEndObject();
			writer.WriteEndObject();
		}
	}
}