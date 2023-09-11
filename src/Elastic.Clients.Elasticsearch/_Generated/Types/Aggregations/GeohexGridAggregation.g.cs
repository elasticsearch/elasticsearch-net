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

internal sealed class GeohexGridAggregationConverter : JsonConverter<GeohexGridAggregation>
{
	public override GeohexGridAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "geohex_grid")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new GeohexGridAggregation(aggName);
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
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field>(ref reader, options);
					agg.Field = value;
					continue;
				}

				if (reader.ValueTextEquals("precision"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<int?>(ref reader, options);
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

	public override void Write(Utf8JsonWriter writer, GeohexGridAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("geohex_grid");
		writer.WriteStartObject();
		if (value.Bounds is not null)
		{
			writer.WritePropertyName("bounds");
			JsonSerializer.Serialize(writer, value.Bounds, options);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, value.Field, options);
		if (value.Precision.HasValue)
		{
			writer.WritePropertyName("precision");
			writer.WriteNumberValue(value.Precision.Value);
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

[JsonConverter(typeof(GeohexGridAggregationConverter))]
public sealed partial class GeohexGridAggregation : SearchAggregation
{
	public GeohexGridAggregation(string name) => Name = name;

	internal GeohexGridAggregation()
	{
	}

	public Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? Aggregations { get; set; }

	/// <summary>
	/// <para>Bounding box used to filter the geo-points in each bucket.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.GeoBounds? Bounds { get; set; }

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohex_grid` aggregates all array values.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }
	public IDictionary<string, object>? Meta { get; set; }
	override public string? Name { get; internal set; }

	/// <summary>
	/// <para>Integer zoom of the key used to defined cells or buckets<br/>in the results. Value should be between 0-15.</para>
	/// </summary>
	public int? Precision { get; set; }

	/// <summary>
	/// <para>Number of buckets returned from each shard.</para>
	/// </summary>
	public int? ShardSize { get; set; }

	/// <summary>
	/// <para>Maximum number of buckets to return.</para>
	/// </summary>
	public int? Size { get; set; }
}

public sealed partial class GeohexGridAggregationDescriptor<TDocument> : SerializableDescriptor<GeohexGridAggregationDescriptor<TDocument>>
{
	internal GeohexGridAggregationDescriptor(Action<GeohexGridAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GeohexGridAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument> AggregationsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument>> AggregationsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.GeoBounds? BoundsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private int? PrecisionValue { get; set; }
	private int? ShardSizeValue { get; set; }
	private int? SizeValue { get; set; }

	public GeohexGridAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
	{
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = null;
		AggregationsValue = aggregations;
		return Self;
	}

	public GeohexGridAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument> descriptor)
	{
		AggregationsValue = null;
		AggregationsDescriptorAction = null;
		AggregationsDescriptor = descriptor;
		return Self;
	}

	public GeohexGridAggregationDescriptor<TDocument> Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument>> configure)
	{
		AggregationsValue = null;
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Bounding box used to filter the geo-points in each bucket.</para>
	/// </summary>
	public GeohexGridAggregationDescriptor<TDocument> Bounds(Elastic.Clients.Elasticsearch.GeoBounds? bounds)
	{
		BoundsValue = bounds;
		return Self;
	}

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohex_grid` aggregates all array values.</para>
	/// </summary>
	public GeohexGridAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohex_grid` aggregates all array values.</para>
	/// </summary>
	public GeohexGridAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GeohexGridAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>Integer zoom of the key used to defined cells or buckets<br/>in the results. Value should be between 0-15.</para>
	/// </summary>
	public GeohexGridAggregationDescriptor<TDocument> Precision(int? precision)
	{
		PrecisionValue = precision;
		return Self;
	}

	/// <summary>
	/// <para>Number of buckets returned from each shard.</para>
	/// </summary>
	public GeohexGridAggregationDescriptor<TDocument> ShardSize(int? shardSize)
	{
		ShardSizeValue = shardSize;
		return Self;
	}

	/// <summary>
	/// <para>Maximum number of buckets to return.</para>
	/// </summary>
	public GeohexGridAggregationDescriptor<TDocument> Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("geohex_grid");
		writer.WriteStartObject();
		if (BoundsValue is not null)
		{
			writer.WritePropertyName("bounds");
			JsonSerializer.Serialize(writer, BoundsValue, options);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (PrecisionValue.HasValue)
		{
			writer.WritePropertyName("precision");
			writer.WriteNumberValue(PrecisionValue.Value);
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

public sealed partial class GeohexGridAggregationDescriptor : SerializableDescriptor<GeohexGridAggregationDescriptor>
{
	internal GeohexGridAggregationDescriptor(Action<GeohexGridAggregationDescriptor> configure) => configure.Invoke(this);

	public GeohexGridAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor AggregationsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor> AggregationsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.GeoBounds? BoundsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private int? PrecisionValue { get; set; }
	private int? ShardSizeValue { get; set; }
	private int? SizeValue { get; set; }

	public GeohexGridAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
	{
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = null;
		AggregationsValue = aggregations;
		return Self;
	}

	public GeohexGridAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor descriptor)
	{
		AggregationsValue = null;
		AggregationsDescriptorAction = null;
		AggregationsDescriptor = descriptor;
		return Self;
	}

	public GeohexGridAggregationDescriptor Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor> configure)
	{
		AggregationsValue = null;
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Bounding box used to filter the geo-points in each bucket.</para>
	/// </summary>
	public GeohexGridAggregationDescriptor Bounds(Elastic.Clients.Elasticsearch.GeoBounds? bounds)
	{
		BoundsValue = bounds;
		return Self;
	}

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohex_grid` aggregates all array values.</para>
	/// </summary>
	public GeohexGridAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohex_grid` aggregates all array values.</para>
	/// </summary>
	public GeohexGridAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Field containing indexed `geo_point` or `geo_shape` values.<br/>If the field contains an array, `geohex_grid` aggregates all array values.</para>
	/// </summary>
	public GeohexGridAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GeohexGridAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>Integer zoom of the key used to defined cells or buckets<br/>in the results. Value should be between 0-15.</para>
	/// </summary>
	public GeohexGridAggregationDescriptor Precision(int? precision)
	{
		PrecisionValue = precision;
		return Self;
	}

	/// <summary>
	/// <para>Number of buckets returned from each shard.</para>
	/// </summary>
	public GeohexGridAggregationDescriptor ShardSize(int? shardSize)
	{
		ShardSizeValue = shardSize;
		return Self;
	}

	/// <summary>
	/// <para>Maximum number of buckets to return.</para>
	/// </summary>
	public GeohexGridAggregationDescriptor Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("geohex_grid");
		writer.WriteStartObject();
		if (BoundsValue is not null)
		{
			writer.WritePropertyName("bounds");
			JsonSerializer.Serialize(writer, BoundsValue, options);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (PrecisionValue.HasValue)
		{
			writer.WritePropertyName("precision");
			writer.WriteNumberValue(PrecisionValue.Value);
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