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

internal sealed class GeoBoundsAggregationConverter : JsonConverter<GeoBoundsAggregation>
{
	public override GeoBoundsAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "geo_bounds")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new GeoBoundsAggregation(aggName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
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

				if (reader.ValueTextEquals("missing"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<FieldValue?>(ref reader, options);
					if (value is not null)
					{
						agg.Missing = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("script"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
					if (value is not null)
					{
						agg.Script = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("wrap_longitude"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<bool?>(ref reader, options);
					if (value is not null)
					{
						agg.WrapLongitude = value;
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
			}
		}

		return agg;
	}

	public override void Write(Utf8JsonWriter writer, GeoBoundsAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("geo_bounds");
		writer.WriteStartObject();
		if (value.Field is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, value.Field, options);
		}

		if (value.Missing is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, value.Missing, options);
		}

		if (value.Script is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, value.Script, options);
		}

		if (value.WrapLongitude.HasValue)
		{
			writer.WritePropertyName("wrap_longitude");
			writer.WriteBooleanValue(value.WrapLongitude.Value);
		}

		writer.WriteEndObject();
		if (value.Meta is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, value.Meta, options);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(GeoBoundsAggregationConverter))]
public sealed partial class GeoBoundsAggregation : SearchAggregation
{
	public GeoBoundsAggregation(string name, Field field) : this(name) => Field = field;
	public GeoBoundsAggregation(string name) => Name = name;

	internal GeoBoundsAggregation()
	{
	}

	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }
	public IDictionary<string, object>? Meta { get; set; }
	public FieldValue? Missing { get; set; }
	override public string? Name { get; internal set; }
	public Elastic.Clients.Elasticsearch.Script? Script { get; set; }

	/// <summary>
	/// <para>Specifies whether the bounding box should be allowed to overlap the international date line.</para>
	/// </summary>
	public bool? WrapLongitude { get; set; }
}

public sealed partial class GeoBoundsAggregationDescriptor<TDocument> : SerializableDescriptor<GeoBoundsAggregationDescriptor<TDocument>>
{
	internal GeoBoundsAggregationDescriptor(Action<GeoBoundsAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GeoBoundsAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private FieldValue? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }
	private bool? WrapLongitudeValue { get; set; }

	public GeoBoundsAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoBoundsAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoBoundsAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public GeoBoundsAggregationDescriptor<TDocument> Missing(FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public GeoBoundsAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	/// <summary>
	/// <para>Specifies whether the bounding box should be allowed to overlap the international date line.</para>
	/// </summary>
	public GeoBoundsAggregationDescriptor<TDocument> WrapLongitude(bool? wrapLongitude = true)
	{
		WrapLongitudeValue = wrapLongitude;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("geo_bounds");
		writer.WriteStartObject();
		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
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

		if (WrapLongitudeValue.HasValue)
		{
			writer.WritePropertyName("wrap_longitude");
			writer.WriteBooleanValue(WrapLongitudeValue.Value);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class GeoBoundsAggregationDescriptor : SerializableDescriptor<GeoBoundsAggregationDescriptor>
{
	internal GeoBoundsAggregationDescriptor(Action<GeoBoundsAggregationDescriptor> configure) => configure.Invoke(this);

	public GeoBoundsAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private FieldValue? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }
	private bool? WrapLongitudeValue { get; set; }

	public GeoBoundsAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoBoundsAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoBoundsAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoBoundsAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public GeoBoundsAggregationDescriptor Missing(FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public GeoBoundsAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	/// <summary>
	/// <para>Specifies whether the bounding box should be allowed to overlap the international date line.</para>
	/// </summary>
	public GeoBoundsAggregationDescriptor WrapLongitude(bool? wrapLongitude = true)
	{
		WrapLongitudeValue = wrapLongitude;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("geo_bounds");
		writer.WriteStartObject();
		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
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

		if (WrapLongitudeValue.HasValue)
		{
			writer.WritePropertyName("wrap_longitude");
			writer.WriteBooleanValue(WrapLongitudeValue.Value);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}