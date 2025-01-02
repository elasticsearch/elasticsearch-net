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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.QueryDsl;

internal sealed partial class NumberRangeQueryConverter : JsonConverter<NumberRangeQuery>
{
	public override NumberRangeQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var fieldName = reader.GetString();
		reader.Read();
		var variant = new NumberRangeQuery(fieldName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				var property = reader.GetString();
				if (property == "boost")
				{
					variant.Boost = JsonSerializer.Deserialize<float?>(ref reader, options);
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

				if (property == "_name")
				{
					variant.QueryName = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "relation")
				{
					variant.Relation = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation?>(ref reader, options);
					continue;
				}
			}
		}

		reader.Read();
		return variant;
	}

	public override void Write(Utf8JsonWriter writer, NumberRangeQuery value, JsonSerializerOptions options)
	{
		if (value.Field is null)
			throw new JsonException("Unable to serialize NumberRangeQuery because the `Field` property is not set. Field name queries must include a valid field name.");
		if (!options.TryGetClientSettings(out var settings))
			throw new JsonException("Unable to retrieve client settings required to infer field.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(value.Field));
		writer.WriteStartObject();
		if (value.Boost.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(value.Boost.Value);
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

		if (!string.IsNullOrEmpty(value.QueryName))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(value.QueryName);
		}

		if (value.Relation is not null)
		{
			writer.WritePropertyName("relation");
			JsonSerializer.Serialize(writer, value.Relation, options);
		}

		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(NumberRangeQueryConverter))]
public sealed partial class NumberRangeQuery
{
	public NumberRangeQuery(Elastic.Clients.Elasticsearch.Field field)
	{
		if (field is null)
			throw new ArgumentNullException(nameof(field));
		Field = field;
	}

	/// <summary>
	/// <para>
	/// Floating point number used to decrease or increase the relevance scores of the query.
	/// Boost values are relative to the default value of 1.0.
	/// A boost value between 0 and 1.0 decreases the relevance score.
	/// A value greater than 1.0 increases the relevance score.
	/// </para>
	/// </summary>
	public float? Boost { get; set; }
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	/// <summary>
	/// <para>
	/// Greater than.
	/// </para>
	/// </summary>
	public double? Gt { get; set; }

	/// <summary>
	/// <para>
	/// Greater than or equal to.
	/// </para>
	/// </summary>
	public double? Gte { get; set; }

	/// <summary>
	/// <para>
	/// Less than.
	/// </para>
	/// </summary>
	public double? Lt { get; set; }

	/// <summary>
	/// <para>
	/// Less than or equal to.
	/// </para>
	/// </summary>
	public double? Lte { get; set; }
	public string? QueryName { get; set; }

	/// <summary>
	/// <para>
	/// Indicates how the range query matches values for <c>range</c> fields.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation? Relation { get; set; }
}

public sealed partial class NumberRangeQueryDescriptor<TDocument> : SerializableDescriptor<NumberRangeQueryDescriptor<TDocument>>
{
	internal NumberRangeQueryDescriptor(Action<NumberRangeQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public NumberRangeQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private double? GtValue { get; set; }
	private double? GteValue { get; set; }
	private double? LtValue { get; set; }
	private double? LteValue { get; set; }
	private string? QueryNameValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation? RelationValue { get; set; }

	/// <summary>
	/// <para>
	/// Floating point number used to decrease or increase the relevance scores of the query.
	/// Boost values are relative to the default value of 1.0.
	/// A boost value between 0 and 1.0 decreases the relevance score.
	/// A value greater than 1.0 increases the relevance score.
	/// </para>
	/// </summary>
	public NumberRangeQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public NumberRangeQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public NumberRangeQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public NumberRangeQueryDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Greater than.
	/// </para>
	/// </summary>
	public NumberRangeQueryDescriptor<TDocument> Gt(double? gt)
	{
		GtValue = gt;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Greater than or equal to.
	/// </para>
	/// </summary>
	public NumberRangeQueryDescriptor<TDocument> Gte(double? gte)
	{
		GteValue = gte;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Less than.
	/// </para>
	/// </summary>
	public NumberRangeQueryDescriptor<TDocument> Lt(double? lt)
	{
		LtValue = lt;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Less than or equal to.
	/// </para>
	/// </summary>
	public NumberRangeQueryDescriptor<TDocument> Lte(double? lte)
	{
		LteValue = lte;
		return Self;
	}

	public NumberRangeQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Indicates how the range query matches values for <c>range</c> fields.
	/// </para>
	/// </summary>
	public NumberRangeQueryDescriptor<TDocument> Relation(Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation? relation)
	{
		RelationValue = relation;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (FieldValue is null)
			throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
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

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (RelationValue is not null)
		{
			writer.WritePropertyName("relation");
			JsonSerializer.Serialize(writer, RelationValue, options);
		}

		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}

public sealed partial class NumberRangeQueryDescriptor : SerializableDescriptor<NumberRangeQueryDescriptor>
{
	internal NumberRangeQueryDescriptor(Action<NumberRangeQueryDescriptor> configure) => configure.Invoke(this);

	public NumberRangeQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private double? GtValue { get; set; }
	private double? GteValue { get; set; }
	private double? LtValue { get; set; }
	private double? LteValue { get; set; }
	private string? QueryNameValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation? RelationValue { get; set; }

	/// <summary>
	/// <para>
	/// Floating point number used to decrease or increase the relevance scores of the query.
	/// Boost values are relative to the default value of 1.0.
	/// A boost value between 0 and 1.0 decreases the relevance score.
	/// A value greater than 1.0 increases the relevance score.
	/// </para>
	/// </summary>
	public NumberRangeQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public NumberRangeQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
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

	/// <summary>
	/// <para>
	/// Greater than.
	/// </para>
	/// </summary>
	public NumberRangeQueryDescriptor Gt(double? gt)
	{
		GtValue = gt;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Greater than or equal to.
	/// </para>
	/// </summary>
	public NumberRangeQueryDescriptor Gte(double? gte)
	{
		GteValue = gte;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Less than.
	/// </para>
	/// </summary>
	public NumberRangeQueryDescriptor Lt(double? lt)
	{
		LtValue = lt;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Less than or equal to.
	/// </para>
	/// </summary>
	public NumberRangeQueryDescriptor Lte(double? lte)
	{
		LteValue = lte;
		return Self;
	}

	public NumberRangeQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Indicates how the range query matches values for <c>range</c> fields.
	/// </para>
	/// </summary>
	public NumberRangeQueryDescriptor Relation(Elastic.Clients.Elasticsearch.QueryDsl.RangeRelation? relation)
	{
		RelationValue = relation;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (FieldValue is null)
			throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
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

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (RelationValue is not null)
		{
			writer.WritePropertyName("relation");
			JsonSerializer.Serialize(writer, RelationValue, options);
		}

		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}