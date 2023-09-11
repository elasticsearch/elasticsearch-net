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

internal sealed class GeohashGridAggregationConverter : JsonConverter<GeohashGridAggregation>
{
	public override GeohashGridAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "geohash_grid")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new GeohashGridAggregation(aggName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("bounds"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.GeoBounds?>(ref reader, options);
					if (value is not null)
					{
						agg.Bounds = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("field"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
					if (value is not null)
					{
						agg.Field = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("precision"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.GeohashPrecision?>(ref reader, options);
					if (value is not null)
					{
						agg.Precision = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("shard_size"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<int?>(ref reader, options);
					if (value is not null)
					{
						agg.ShardSize = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("size"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<int?>(ref reader, options);
					if (value is not null)
					{
						agg.Size = value;
					}

					continue;
				}
			}
		}

		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("meta"))
				{
					var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
					if (value is not null)
					{
						agg.Meta = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("aggs") || reader.ValueTextEquals("aggregations"))
				{
					var value = JsonSerializer.Deserialize<AggregationDictionary>(ref reader, options);
					if (value is not null)
					{
						agg.Aggregations = value;
					}

					continue;
				}
			}
		}

		return agg;
	}

	public override void Write(Utf8JsonWriter writer, GeohashGridAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("geohash_grid");
		writer.WriteStartObject();
		if (value.Bounds is not null)
		{
			writer.WritePropertyName("bounds");
			JsonSerializer.Serialize(writer, value.Bounds, options);
		}

		if (value.Field is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, value.Field, options);
		}

		if (value.Precision is not null)
		{
			writer.WritePropertyName("precision");
			JsonSerializer.Serialize(writer, value.Precision, options);
		}

		if (value.ShardSize.HasValue)
		{
			writer.WritePropertyName("shard_size");
			writer.WriteNumberValue(value.ShardSize.Value);
		}

		if (value.Size.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(value.Size.Value);
		}

		writer.WriteEndObject();
		if (value.Meta is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, value.Meta, options);
		}

		if (value.Aggregations is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, value.Aggregations, options);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(GeohashGridAggregationConverter))]
public sealed partial class GeohashGridAggregation : SearchAggregation
{
	public GeohashGridAggregation(string name) => Name = name;

	internal GeohashGridAggregation()
	{
	}

	public Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? Aggregations { get; set; }

	/// <summary>
	/// <para>The bounding box to filter the points in each bucket.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.GeoBounds? Bounds { get; set; }

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohash_grid` aggregates all array values.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }
	public IDictionary<string, object>? Meta { get; set; }
	override public string? Name { get; internal set; }

	/// <summary>
	/// <para>The string length of the geohashes used to define cells/buckets in the results.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.GeohashPrecision? Precision { get; set; }

	/// <summary>
	/// <para>Allows for more accurate counting of the top cells returned in the final result the aggregation.<br/>Defaults to returning `max(10,(size x number-of-shards))` buckets from each shard.</para>
	/// </summary>
	public int? ShardSize { get; set; }

	/// <summary>
	/// <para>The maximum number of geohash buckets to return.</para>
	/// </summary>
	public int? Size { get; set; }
}

public sealed partial class GeohashGridAggregationDescriptor<TDocument> : SerializableDescriptor<GeohashGridAggregationDescriptor<TDocument>>
{
	internal GeohashGridAggregationDescriptor(Action<GeohashGridAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GeohashGridAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument> AggregationsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument>> AggregationsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.GeoBounds? BoundsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private Elastic.Clients.Elasticsearch.GeohashPrecision? PrecisionValue { get; set; }
	private int? ShardSizeValue { get; set; }
	private int? SizeValue { get; set; }

	public GeohashGridAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
	{
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = null;
		AggregationsValue = aggregations;
		return Self;
	}

	public GeohashGridAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument> descriptor)
	{
		AggregationsValue = null;
		AggregationsDescriptorAction = null;
		AggregationsDescriptor = descriptor;
		return Self;
	}

	public GeohashGridAggregationDescriptor<TDocument> Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument>> configure)
	{
		AggregationsValue = null;
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The bounding box to filter the points in each bucket.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor<TDocument> Bounds(Elastic.Clients.Elasticsearch.GeoBounds? bounds)
	{
		BoundsValue = bounds;
		return Self;
	}

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohash_grid` aggregates all array values.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohash_grid` aggregates all array values.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GeohashGridAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>The string length of the geohashes used to define cells/buckets in the results.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor<TDocument> Precision(Elastic.Clients.Elasticsearch.GeohashPrecision? precision)
	{
		PrecisionValue = precision;
		return Self;
	}

	/// <summary>
	/// <para>Allows for more accurate counting of the top cells returned in the final result the aggregation.<br/>Defaults to returning `max(10,(size x number-of-shards))` buckets from each shard.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor<TDocument> ShardSize(int? shardSize)
	{
		ShardSizeValue = shardSize;
		return Self;
	}

	/// <summary>
	/// <para>The maximum number of geohash buckets to return.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor<TDocument> Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("geohash_grid");
		writer.WriteStartObject();
		if (BoundsValue is not null)
		{
			writer.WritePropertyName("bounds");
			JsonSerializer.Serialize(writer, BoundsValue, options);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (PrecisionValue is not null)
		{
			writer.WritePropertyName("precision");
			JsonSerializer.Serialize(writer, PrecisionValue, options);
		}

		if (ShardSizeValue.HasValue)
		{
			writer.WritePropertyName("shard_size");
			writer.WriteNumberValue(ShardSizeValue.Value);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (AggregationsDescriptor is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, AggregationsDescriptor, options);
		}
		else if (AggregationsDescriptorAction is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, new AggregationDescriptor<TDocument>(AggregationsDescriptorAction), options);
		}
		else if (AggregationsValue is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, AggregationsValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class GeohashGridAggregationDescriptor : SerializableDescriptor<GeohashGridAggregationDescriptor>
{
	internal GeohashGridAggregationDescriptor(Action<GeohashGridAggregationDescriptor> configure) => configure.Invoke(this);

	public GeohashGridAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor AggregationsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor> AggregationsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.GeoBounds? BoundsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private Elastic.Clients.Elasticsearch.GeohashPrecision? PrecisionValue { get; set; }
	private int? ShardSizeValue { get; set; }
	private int? SizeValue { get; set; }

	public GeohashGridAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
	{
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = null;
		AggregationsValue = aggregations;
		return Self;
	}

	public GeohashGridAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor descriptor)
	{
		AggregationsValue = null;
		AggregationsDescriptorAction = null;
		AggregationsDescriptor = descriptor;
		return Self;
	}

	public GeohashGridAggregationDescriptor Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor> configure)
	{
		AggregationsValue = null;
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The bounding box to filter the points in each bucket.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor Bounds(Elastic.Clients.Elasticsearch.GeoBounds? bounds)
	{
		BoundsValue = bounds;
		return Self;
	}

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohash_grid` aggregates all array values.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohash_grid` aggregates all array values.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohash_grid` aggregates all array values.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GeohashGridAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>The string length of the geohashes used to define cells/buckets in the results.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor Precision(Elastic.Clients.Elasticsearch.GeohashPrecision? precision)
	{
		PrecisionValue = precision;
		return Self;
	}

	/// <summary>
	/// <para>Allows for more accurate counting of the top cells returned in the final result the aggregation.<br/>Defaults to returning `max(10,(size x number-of-shards))` buckets from each shard.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor ShardSize(int? shardSize)
	{
		ShardSizeValue = shardSize;
		return Self;
	}

	/// <summary>
	/// <para>The maximum number of geohash buckets to return.</para>
	/// </summary>
	public GeohashGridAggregationDescriptor Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("geohash_grid");
		writer.WriteStartObject();
		if (BoundsValue is not null)
		{
			writer.WritePropertyName("bounds");
			JsonSerializer.Serialize(writer, BoundsValue, options);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (PrecisionValue is not null)
		{
			writer.WritePropertyName("precision");
			JsonSerializer.Serialize(writer, PrecisionValue, options);
		}

		if (ShardSizeValue.HasValue)
		{
			writer.WritePropertyName("shard_size");
			writer.WriteNumberValue(ShardSizeValue.Value);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (AggregationsDescriptor is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, AggregationsDescriptor, options);
		}
		else if (AggregationsDescriptorAction is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, new AggregationDescriptor(AggregationsDescriptorAction), options);
		}
		else if (AggregationsValue is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, AggregationsValue, options);
		}

		writer.WriteEndObject();
	}
}