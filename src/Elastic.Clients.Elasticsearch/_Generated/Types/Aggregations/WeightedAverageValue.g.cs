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

namespace Elastic.Clients.Elasticsearch.Aggregations;

public sealed partial class WeightedAverageValue
{
	/// <summary>
	/// <para>The field from which to extract the values or weights.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

	/// <summary>
	/// <para>A value or weight to use if the field is missing.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("missing")]
	public double? Missing { get; set; }
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Script? Script { get; set; }
}

public sealed partial class WeightedAverageValueDescriptor<TDocument> : SerializableDescriptor<WeightedAverageValueDescriptor<TDocument>>
{
	internal WeightedAverageValueDescriptor(Action<WeightedAverageValueDescriptor<TDocument>> configure) => configure.Invoke(this);

	public WeightedAverageValueDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private double? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }

	/// <summary>
	/// <para>The field from which to extract the values or weights.</para>
	/// </summary>
	public WeightedAverageValueDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field from which to extract the values or weights.</para>
	/// </summary>
	public WeightedAverageValueDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field from which to extract the values or weights.</para>
	/// </summary>
	public WeightedAverageValueDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>A value or weight to use if the field is missing.</para>
	/// </summary>
	public WeightedAverageValueDescriptor<TDocument> Missing(double? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public WeightedAverageValueDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (MissingValue.HasValue)
		{
			writer.WritePropertyName("missing");
			writer.WriteNumberValue(MissingValue.Value);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class WeightedAverageValueDescriptor : SerializableDescriptor<WeightedAverageValueDescriptor>
{
	internal WeightedAverageValueDescriptor(Action<WeightedAverageValueDescriptor> configure) => configure.Invoke(this);

	public WeightedAverageValueDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private double? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }

	/// <summary>
	/// <para>The field from which to extract the values or weights.</para>
	/// </summary>
	public WeightedAverageValueDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field from which to extract the values or weights.</para>
	/// </summary>
	public WeightedAverageValueDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field from which to extract the values or weights.</para>
	/// </summary>
	public WeightedAverageValueDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>A value or weight to use if the field is missing.</para>
	/// </summary>
	public WeightedAverageValueDescriptor Missing(double? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public WeightedAverageValueDescriptor Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (MissingValue.HasValue)
		{
			writer.WritePropertyName("missing");
			writer.WriteNumberValue(MissingValue.Value);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		writer.WriteEndObject();
	}
}