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

public sealed partial class GeoCentroidAggregation
{
	[JsonInclude, JsonPropertyName("count")]
	public long? Count { get; set; }

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }
	[JsonInclude, JsonPropertyName("location")]
	public Elastic.Clients.Elasticsearch.GeoLocation? Location { get; set; }

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("missing")]
	public Elastic.Clients.Elasticsearch.FieldValue? Missing { get; set; }
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Script? Script { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Aggregations.Aggregation(GeoCentroidAggregation geoCentroidAggregation) => Elastic.Clients.Elasticsearch.Aggregations.Aggregation.GeoCentroid(geoCentroidAggregation);
}

public sealed partial class GeoCentroidAggregationDescriptor<TDocument> : SerializableDescriptor<GeoCentroidAggregationDescriptor<TDocument>>
{
	internal GeoCentroidAggregationDescriptor(Action<GeoCentroidAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GeoCentroidAggregationDescriptor() : base()
	{
	}

	private long? CountValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.GeoLocation? LocationValue { get; set; }
	private Elastic.Clients.Elasticsearch.FieldValue? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }

	public GeoCentroidAggregationDescriptor<TDocument> Count(long? count)
	{
		CountValue = count;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public GeoCentroidAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public GeoCentroidAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public GeoCentroidAggregationDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoCentroidAggregationDescriptor<TDocument> Location(Elastic.Clients.Elasticsearch.GeoLocation? location)
	{
		LocationValue = location;
		return Self;
	}

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	public GeoCentroidAggregationDescriptor<TDocument> Missing(Elastic.Clients.Elasticsearch.FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public GeoCentroidAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (CountValue.HasValue)
		{
			writer.WritePropertyName("count");
			writer.WriteNumberValue(CountValue.Value);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (LocationValue is not null)
		{
			writer.WritePropertyName("location");
			JsonSerializer.Serialize(writer, LocationValue, options);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class GeoCentroidAggregationDescriptor : SerializableDescriptor<GeoCentroidAggregationDescriptor>
{
	internal GeoCentroidAggregationDescriptor(Action<GeoCentroidAggregationDescriptor> configure) => configure.Invoke(this);

	public GeoCentroidAggregationDescriptor() : base()
	{
	}

	private long? CountValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.GeoLocation? LocationValue { get; set; }
	private Elastic.Clients.Elasticsearch.FieldValue? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }

	public GeoCentroidAggregationDescriptor Count(long? count)
	{
		CountValue = count;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public GeoCentroidAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public GeoCentroidAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public GeoCentroidAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoCentroidAggregationDescriptor Location(Elastic.Clients.Elasticsearch.GeoLocation? location)
	{
		LocationValue = location;
		return Self;
	}

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	public GeoCentroidAggregationDescriptor Missing(Elastic.Clients.Elasticsearch.FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public GeoCentroidAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (CountValue.HasValue)
		{
			writer.WritePropertyName("count");
			writer.WriteNumberValue(CountValue.Value);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (LocationValue is not null)
		{
			writer.WritePropertyName("location");
			JsonSerializer.Serialize(writer, LocationValue, options);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		writer.WriteEndObject();
	}
}