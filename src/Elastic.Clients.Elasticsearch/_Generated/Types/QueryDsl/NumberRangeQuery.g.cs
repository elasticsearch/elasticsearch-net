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
	internal sealed class NumberRangeQueryConverter : JsonConverter<NumberRangeQuery>
	{
		public override NumberRangeQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			reader.Read();
			reader.Read();
			var fieldName = reader.GetString();
			reader.Read();
			var variant = new NumberRangeQuery()
			{ Field = fieldName };
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

					if (property == "from")
					{
						variant.From = JsonSerializer.Deserialize<double?>(ref reader, options);
						continue;
					}

					if (property == "gt")
					{
						variant.Gt = JsonSerializer.Deserialize<double?>(ref reader, options);
						continue;
					}

					if (property == "gte")
					{
						variant.Gte = JsonSerializer.Deserialize<double?>(ref reader, options);
						continue;
					}

					if (property == "lt")
					{
						variant.Lt = JsonSerializer.Deserialize<double?>(ref reader, options);
						continue;
					}

					if (property == "lte")
					{
						variant.Lte = JsonSerializer.Deserialize<double?>(ref reader, options);
						continue;
					}

					if (property == "relation")
					{
						variant.Relation = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation?>(ref reader, options);
						continue;
					}

					if (property == "to")
					{
						variant.To = JsonSerializer.Deserialize<double?>(ref reader, options);
						continue;
					}
				}
			}

			reader.Read();
			reader.Read();
			return variant;
		}

		public override void Write(Utf8JsonWriter writer, NumberRangeQuery value, JsonSerializerOptions options)
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

				if (value.From.HasValue)
				{
					writer.WritePropertyName("from");
					writer.WriteNumberValue(value.From.Value);
				}

				if (value.Gt.HasValue)
				{
					writer.WritePropertyName("gt");
					writer.WriteNumberValue(value.Gt.Value);
				}

				if (value.Gte.HasValue)
				{
					writer.WritePropertyName("gte");
					writer.WriteNumberValue(value.Gte.Value);
				}

				if (value.Lt.HasValue)
				{
					writer.WritePropertyName("lt");
					writer.WriteNumberValue(value.Lt.Value);
				}

				if (value.Lte.HasValue)
				{
					writer.WritePropertyName("lte");
					writer.WriteNumberValue(value.Lte.Value);
				}

				if (value.Relation is not null)
				{
					writer.WritePropertyName("relation");
					JsonSerializer.Serialize(writer, value.Relation, options);
				}

				if (value.To.HasValue)
				{
					writer.WritePropertyName("to");
					writer.WriteNumberValue(value.To.Value);
				}

				writer.WriteEndObject();
				writer.WriteEndObject();
				return;
			}

			throw new JsonException("Unable to retrieve client settings to infer field.");
		}
	}

	[JsonConverter(typeof(NumberRangeQueryConverter))]
	public sealed partial class NumberRangeQuery : IQueryVariant
	{
		public string? QueryName { get; set; }

		public float? Boost { get; set; }

		public double? From { get; set; }

		public double? Gt { get; set; }

		public double? Gte { get; set; }

		public double? Lt { get; set; }

		public double? Lte { get; set; }

		public Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation? Relation { get; set; }

		public double? To { get; set; }

		public Elastic.Clients.Elasticsearch.Field? Field { get; set; }
	}

	public sealed partial class NumberRangeQueryDescriptor<TDocument> : SerializableDescriptorBase<NumberRangeQueryDescriptor<TDocument>>
	{
		internal NumberRangeQueryDescriptor(Action<NumberRangeQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public NumberRangeQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private double? FromValue { get; set; }

		private double? GtValue { get; set; }

		private double? GteValue { get; set; }

		private double? LtValue { get; set; }

		private double? LteValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation? RelationValue { get; set; }

		private double? ToValue { get; set; }

		public NumberRangeQueryDescriptor<TDocument> QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public NumberRangeQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public NumberRangeQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public NumberRangeQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public NumberRangeQueryDescriptor<TDocument> From(double? from)
		{
			FromValue = from;
			return Self;
		}

		public NumberRangeQueryDescriptor<TDocument> Gt(double? gt)
		{
			GtValue = gt;
			return Self;
		}

		public NumberRangeQueryDescriptor<TDocument> Gte(double? gte)
		{
			GteValue = gte;
			return Self;
		}

		public NumberRangeQueryDescriptor<TDocument> Lt(double? lt)
		{
			LtValue = lt;
			return Self;
		}

		public NumberRangeQueryDescriptor<TDocument> Lte(double? lte)
		{
			LteValue = lte;
			return Self;
		}

		public NumberRangeQueryDescriptor<TDocument> Relation(Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation? relation)
		{
			RelationValue = relation;
			return Self;
		}

		public NumberRangeQueryDescriptor<TDocument> To(double? to)
		{
			ToValue = to;
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

			if (FromValue.HasValue)
			{
				writer.WritePropertyName("from");
				writer.WriteNumberValue(FromValue.Value);
			}

			if (GtValue.HasValue)
			{
				writer.WritePropertyName("gt");
				writer.WriteNumberValue(GtValue.Value);
			}

			if (GteValue.HasValue)
			{
				writer.WritePropertyName("gte");
				writer.WriteNumberValue(GteValue.Value);
			}

			if (LtValue.HasValue)
			{
				writer.WritePropertyName("lt");
				writer.WriteNumberValue(LtValue.Value);
			}

			if (LteValue.HasValue)
			{
				writer.WritePropertyName("lte");
				writer.WriteNumberValue(LteValue.Value);
			}

			if (RelationValue is not null)
			{
				writer.WritePropertyName("relation");
				JsonSerializer.Serialize(writer, RelationValue, options);
			}

			if (ToValue.HasValue)
			{
				writer.WritePropertyName("to");
				writer.WriteNumberValue(ToValue.Value);
			}

			writer.WriteEndObject();
			writer.WriteEndObject();
		}
	}

	public sealed partial class NumberRangeQueryDescriptor : SerializableDescriptorBase<NumberRangeQueryDescriptor>
	{
		internal NumberRangeQueryDescriptor(Action<NumberRangeQueryDescriptor> configure) => configure.Invoke(this);
		public NumberRangeQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private double? FromValue { get; set; }

		private double? GtValue { get; set; }

		private double? GteValue { get; set; }

		private double? LtValue { get; set; }

		private double? LteValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation? RelationValue { get; set; }

		private double? ToValue { get; set; }

		public NumberRangeQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public NumberRangeQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public NumberRangeQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public NumberRangeQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public NumberRangeQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public NumberRangeQueryDescriptor From(double? from)
		{
			FromValue = from;
			return Self;
		}

		public NumberRangeQueryDescriptor Gt(double? gt)
		{
			GtValue = gt;
			return Self;
		}

		public NumberRangeQueryDescriptor Gte(double? gte)
		{
			GteValue = gte;
			return Self;
		}

		public NumberRangeQueryDescriptor Lt(double? lt)
		{
			LtValue = lt;
			return Self;
		}

		public NumberRangeQueryDescriptor Lte(double? lte)
		{
			LteValue = lte;
			return Self;
		}

		public NumberRangeQueryDescriptor Relation(Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation? relation)
		{
			RelationValue = relation;
			return Self;
		}

		public NumberRangeQueryDescriptor To(double? to)
		{
			ToValue = to;
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

			if (FromValue.HasValue)
			{
				writer.WritePropertyName("from");
				writer.WriteNumberValue(FromValue.Value);
			}

			if (GtValue.HasValue)
			{
				writer.WritePropertyName("gt");
				writer.WriteNumberValue(GtValue.Value);
			}

			if (GteValue.HasValue)
			{
				writer.WritePropertyName("gte");
				writer.WriteNumberValue(GteValue.Value);
			}

			if (LtValue.HasValue)
			{
				writer.WritePropertyName("lt");
				writer.WriteNumberValue(LtValue.Value);
			}

			if (LteValue.HasValue)
			{
				writer.WritePropertyName("lte");
				writer.WriteNumberValue(LteValue.Value);
			}

			if (RelationValue is not null)
			{
				writer.WritePropertyName("relation");
				JsonSerializer.Serialize(writer, RelationValue, options);
			}

			if (ToValue.HasValue)
			{
				writer.WritePropertyName("to");
				writer.WriteNumberValue(ToValue.Value);
			}

			writer.WriteEndObject();
			writer.WriteEndObject();
		}
	}
}