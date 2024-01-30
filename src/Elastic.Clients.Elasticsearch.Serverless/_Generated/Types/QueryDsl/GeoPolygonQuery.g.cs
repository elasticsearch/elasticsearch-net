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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.QueryDsl;

internal sealed partial class GeoPolygonQueryConverter : JsonConverter<GeoPolygonQuery>
{
	public override GeoPolygonQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		var variant = new GeoPolygonQuery();
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

				if (property == "ignore_unmapped")
				{
					variant.IgnoreUnmapped = JsonSerializer.Deserialize<bool?>(ref reader, options);
					continue;
				}

				if (property == "_name")
				{
					variant.QueryName = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "validation_method")
				{
					variant.ValidationMethod = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.GeoValidationMethod?>(ref reader, options);
					continue;
				}

				variant.Field = property;
				reader.Read();
				variant.Polygon = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.GeoPolygonPoints>(ref reader, options);
			}
		}

		return variant;
	}

	public override void Write(Utf8JsonWriter writer, GeoPolygonQuery value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (value.Field is not null && value.Polygon is not null)
		{
			if (!options.TryGetClientSettings(out var settings))
			{
				ThrowHelper.ThrowJsonExceptionForMissingSettings();
			}

			var propertyName = settings.Inferrer.Field(value.Field);
			writer.WritePropertyName(propertyName);
			JsonSerializer.Serialize(writer, value.Polygon, options);
		}

		if (value.Boost.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(value.Boost.Value);
		}

		if (value.IgnoreUnmapped.HasValue)
		{
			writer.WritePropertyName("ignore_unmapped");
			writer.WriteBooleanValue(value.IgnoreUnmapped.Value);
		}

		if (!string.IsNullOrEmpty(value.QueryName))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(value.QueryName);
		}

		if (value.ValidationMethod is not null)
		{
			writer.WritePropertyName("validation_method");
			JsonSerializer.Serialize(writer, value.ValidationMethod, options);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(GeoPolygonQueryConverter))]
public sealed partial class GeoPolygonQuery : SearchQuery
{
	public string? QueryName { get; set; }
	public float? Boost { get; set; }
	public Elastic.Clients.Elasticsearch.Serverless.Field Field { get; set; }
	public bool? IgnoreUnmapped { get; set; }
	public Elastic.Clients.Elasticsearch.Serverless.QueryDsl.GeoPolygonPoints Polygon { get; set; }
	public Elastic.Clients.Elasticsearch.Serverless.QueryDsl.GeoValidationMethod? ValidationMethod { get; set; }

	public static implicit operator Query(GeoPolygonQuery geoPolygonQuery) => QueryDsl.Query.GeoPolygon(geoPolygonQuery);

	internal override void InternalWrapInContainer(Query container) => container.WrapVariant("geo_polygon", this);
}

public sealed partial class GeoPolygonQueryDescriptor<TDocument> : SerializableDescriptor<GeoPolygonQueryDescriptor<TDocument>>
{
	internal GeoPolygonQueryDescriptor(Action<GeoPolygonQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GeoPolygonQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private bool? IgnoreUnmappedValue { get; set; }
	private string? QueryNameValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.GeoValidationMethod? ValidationMethodValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.GeoPolygonPoints PolygonValue { get; set; }
	private GeoPolygonPointsDescriptor PolygonDescriptor { get; set; }
	private Action<GeoPolygonPointsDescriptor> PolygonDescriptorAction { get; set; }

	public GeoPolygonQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public GeoPolygonQueryDescriptor<TDocument> IgnoreUnmapped(bool? ignoreUnmapped = true)
	{
		IgnoreUnmappedValue = ignoreUnmapped;
		return Self;
	}

	public GeoPolygonQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public GeoPolygonQueryDescriptor<TDocument> ValidationMethod(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.GeoValidationMethod? validationMethod)
	{
		ValidationMethodValue = validationMethod;
		return Self;
	}

	public GeoPolygonQueryDescriptor<TDocument> Polygon(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.GeoPolygonPoints polygon)
	{
		PolygonValue = polygon;
		return Self;
	}

	public GeoPolygonQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoPolygonQueryDescriptor<TDocument> Polygon(GeoPolygonPointsDescriptor descriptor)
	{
		PolygonValue = null;
		PolygonDescriptorAction = null;
		PolygonDescriptor = descriptor;
		return Self;
	}

	public GeoPolygonQueryDescriptor<TDocument> Polygon(Action<GeoPolygonPointsDescriptor> configure)
	{
		PolygonValue = null;
		PolygonDescriptor = null;
		PolygonDescriptorAction = configure;
		return Self;
	}

	public GeoPolygonQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FieldValue is not null && (PolygonValue is not null || PolygonDescriptor is not null || PolygonDescriptorAction is not null))
		{
			var propertyName = settings.Inferrer.Field(FieldValue);
			writer.WritePropertyName(propertyName);
			if (PolygonValue is not null)
			{
				JsonSerializer.Serialize(writer, PolygonValue, options);
			}
			else if (PolygonDescriptor is not null)
			{
				JsonSerializer.Serialize(writer, PolygonDescriptor, options);
			}
			else if (PolygonDescriptorAction is not null)
			{
				var descriptor = new GeoPolygonPointsDescriptor(PolygonDescriptorAction);
				JsonSerializer.Serialize(writer, descriptor, options);
			}
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (IgnoreUnmappedValue.HasValue)
		{
			writer.WritePropertyName("ignore_unmapped");
			writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (ValidationMethodValue is not null)
		{
			writer.WritePropertyName("validation_method");
			JsonSerializer.Serialize(writer, ValidationMethodValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class GeoPolygonQueryDescriptor : SerializableDescriptor<GeoPolygonQueryDescriptor>
{
	internal GeoPolygonQueryDescriptor(Action<GeoPolygonQueryDescriptor> configure) => configure.Invoke(this);

	public GeoPolygonQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private bool? IgnoreUnmappedValue { get; set; }
	private string? QueryNameValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.GeoValidationMethod? ValidationMethodValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.GeoPolygonPoints PolygonValue { get; set; }
	private GeoPolygonPointsDescriptor PolygonDescriptor { get; set; }
	private Action<GeoPolygonPointsDescriptor> PolygonDescriptorAction { get; set; }

	public GeoPolygonQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public GeoPolygonQueryDescriptor IgnoreUnmapped(bool? ignoreUnmapped = true)
	{
		IgnoreUnmappedValue = ignoreUnmapped;
		return Self;
	}

	public GeoPolygonQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public GeoPolygonQueryDescriptor ValidationMethod(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.GeoValidationMethod? validationMethod)
	{
		ValidationMethodValue = validationMethod;
		return Self;
	}

	public GeoPolygonQueryDescriptor Polygon(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.GeoPolygonPoints polygon)
	{
		PolygonValue = polygon;
		return Self;
	}

	public GeoPolygonQueryDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoPolygonQueryDescriptor Polygon(GeoPolygonPointsDescriptor descriptor)
	{
		PolygonValue = null;
		PolygonDescriptorAction = null;
		PolygonDescriptor = descriptor;
		return Self;
	}

	public GeoPolygonQueryDescriptor Polygon(Action<GeoPolygonPointsDescriptor> configure)
	{
		PolygonValue = null;
		PolygonDescriptor = null;
		PolygonDescriptorAction = configure;
		return Self;
	}

	public GeoPolygonQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoPolygonQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FieldValue is not null && (PolygonValue is not null || PolygonDescriptor is not null || PolygonDescriptorAction is not null))
		{
			var propertyName = settings.Inferrer.Field(FieldValue);
			writer.WritePropertyName(propertyName);
			if (PolygonValue is not null)
			{
				JsonSerializer.Serialize(writer, PolygonValue, options);
			}
			else if (PolygonDescriptor is not null)
			{
				JsonSerializer.Serialize(writer, PolygonDescriptor, options);
			}
			else if (PolygonDescriptorAction is not null)
			{
				var descriptor = new GeoPolygonPointsDescriptor(PolygonDescriptorAction);
				JsonSerializer.Serialize(writer, descriptor, options);
			}
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (IgnoreUnmappedValue.HasValue)
		{
			writer.WritePropertyName("ignore_unmapped");
			writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (ValidationMethodValue is not null)
		{
			writer.WritePropertyName("validation_method");
			JsonSerializer.Serialize(writer, ValidationMethodValue, options);
		}

		writer.WriteEndObject();
	}
}