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

namespace Elastic.Clients.Elasticsearch;

internal sealed partial class GeoDistanceSortConverter : System.Text.Json.Serialization.JsonConverter<GeoDistanceSort>
{
	private static readonly System.Text.Json.JsonEncodedText PropDistanceType = System.Text.Json.JsonEncodedText.Encode("distance_type");
	private static readonly System.Text.Json.JsonEncodedText PropIgnoreUnmapped = System.Text.Json.JsonEncodedText.Encode("ignore_unmapped");
	private static readonly System.Text.Json.JsonEncodedText PropMode = System.Text.Json.JsonEncodedText.Encode("mode");
	private static readonly System.Text.Json.JsonEncodedText PropNested = System.Text.Json.JsonEncodedText.Encode("nested");
	private static readonly System.Text.Json.JsonEncodedText PropOrder = System.Text.Json.JsonEncodedText.Encode("order");
	private static readonly System.Text.Json.JsonEncodedText PropUnit = System.Text.Json.JsonEncodedText.Encode("unit");

	public override GeoDistanceSort Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<Elastic.Clients.Elasticsearch.Field> propField = default;
		LocalJsonValue<ICollection<Elastic.Clients.Elasticsearch.GeoLocation>> propLocation = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.GeoDistanceType?> propDistanceType = default;
		LocalJsonValue<bool?> propIgnoreUnmapped = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.SortMode?> propMode = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.NestedSortValue?> propNested = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.SortOrder?> propOrder = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.DistanceUnit?> propUnit = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propDistanceType.TryReadProperty(ref reader, options, PropDistanceType, null))
			{
				continue;
			}

			if (propIgnoreUnmapped.TryReadProperty(ref reader, options, PropIgnoreUnmapped, null))
			{
				continue;
			}

			if (propMode.TryReadProperty(ref reader, options, PropMode, null))
			{
				continue;
			}

			if (propNested.TryReadProperty(ref reader, options, PropNested, null))
			{
				continue;
			}

			if (propOrder.TryReadProperty(ref reader, options, PropOrder, null))
			{
				continue;
			}

			if (propUnit.TryReadProperty(ref reader, options, PropUnit, null))
			{
				continue;
			}

			propField.Initialized = propLocation.Initialized = true;
			reader.ReadProperty(options, out propField.Value, out propLocation.Value, null, static ICollection<Elastic.Clients.Elasticsearch.GeoLocation> (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.GeoLocation>(o, null)!);
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new GeoDistanceSort
		{
			Field = propField.Value
,
			Location = propLocation.Value
,
			DistanceType = propDistanceType.Value
,
			IgnoreUnmapped = propIgnoreUnmapped.Value
,
			Mode = propMode.Value
,
			Nested = propNested.Value
,
			Order = propOrder.Value
,
			Unit = propUnit.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, GeoDistanceSort value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropDistanceType, value.DistanceType, null, null);
		writer.WriteProperty(options, PropIgnoreUnmapped, value.IgnoreUnmapped, null, null);
		writer.WriteProperty(options, PropMode, value.Mode, null, null);
		writer.WriteProperty(options, PropNested, value.Nested, null, null);
		writer.WriteProperty(options, PropOrder, value.Order, null, null);
		writer.WriteProperty(options, PropUnit, value.Unit, null, null);
		writer.WriteProperty(options, value.Field, value.Location, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<Elastic.Clients.Elasticsearch.GeoLocation> v) => w.WriteSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.GeoLocation>(o, v, null));
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(GeoDistanceSortConverter))]
public sealed partial class GeoDistanceSort
{
	public Elastic.Clients.Elasticsearch.GeoDistanceType? DistanceType { get; set; }
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }
	public bool? IgnoreUnmapped { get; set; }
	public ICollection<Elastic.Clients.Elasticsearch.GeoLocation> Location { get; set; }
	public Elastic.Clients.Elasticsearch.SortMode? Mode { get; set; }
	public Elastic.Clients.Elasticsearch.NestedSortValue? Nested { get; set; }
	public Elastic.Clients.Elasticsearch.SortOrder? Order { get; set; }
	public Elastic.Clients.Elasticsearch.DistanceUnit? Unit { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.SortOptions(GeoDistanceSort geoDistanceSort) => Elastic.Clients.Elasticsearch.SortOptions.GeoDistance(geoDistanceSort);
}

public sealed partial class GeoDistanceSortDescriptor<TDocument> : SerializableDescriptor<GeoDistanceSortDescriptor<TDocument>>
{
	internal GeoDistanceSortDescriptor(Action<GeoDistanceSortDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GeoDistanceSortDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.GeoDistanceType? DistanceTypeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private bool? IgnoreUnmappedValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.GeoLocation> LocationValue { get; set; }
	private Elastic.Clients.Elasticsearch.SortMode? ModeValue { get; set; }
	private Elastic.Clients.Elasticsearch.NestedSortValue? NestedValue { get; set; }
	private Elastic.Clients.Elasticsearch.NestedSortValueDescriptor<TDocument> NestedDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.NestedSortValueDescriptor<TDocument>> NestedDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.SortOrder? OrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.DistanceUnit? UnitValue { get; set; }

	public GeoDistanceSortDescriptor<TDocument> DistanceType(Elastic.Clients.Elasticsearch.GeoDistanceType? distanceType)
	{
		DistanceTypeValue = distanceType;
		return Self;
	}

	public GeoDistanceSortDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoDistanceSortDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoDistanceSortDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoDistanceSortDescriptor<TDocument> IgnoreUnmapped(bool? ignoreUnmapped = true)
	{
		IgnoreUnmappedValue = ignoreUnmapped;
		return Self;
	}

	public GeoDistanceSortDescriptor<TDocument> Location(ICollection<Elastic.Clients.Elasticsearch.GeoLocation> location)
	{
		LocationValue = location;
		return Self;
	}

	public GeoDistanceSortDescriptor<TDocument> Mode(Elastic.Clients.Elasticsearch.SortMode? mode)
	{
		ModeValue = mode;
		return Self;
	}

	public GeoDistanceSortDescriptor<TDocument> Nested(Elastic.Clients.Elasticsearch.NestedSortValue? nested)
	{
		NestedDescriptor = null;
		NestedDescriptorAction = null;
		NestedValue = nested;
		return Self;
	}

	public GeoDistanceSortDescriptor<TDocument> Nested(Elastic.Clients.Elasticsearch.NestedSortValueDescriptor<TDocument> descriptor)
	{
		NestedValue = null;
		NestedDescriptorAction = null;
		NestedDescriptor = descriptor;
		return Self;
	}

	public GeoDistanceSortDescriptor<TDocument> Nested(Action<Elastic.Clients.Elasticsearch.NestedSortValueDescriptor<TDocument>> configure)
	{
		NestedValue = null;
		NestedDescriptor = null;
		NestedDescriptorAction = configure;
		return Self;
	}

	public GeoDistanceSortDescriptor<TDocument> Order(Elastic.Clients.Elasticsearch.SortOrder? order)
	{
		OrderValue = order;
		return Self;
	}

	public GeoDistanceSortDescriptor<TDocument> Unit(Elastic.Clients.Elasticsearch.DistanceUnit? unit)
	{
		UnitValue = unit;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FieldValue is not null && LocationValue is not null)
		{
			var propertyName = settings.Inferrer.Field(FieldValue);
			writer.WritePropertyName(propertyName);
			JsonSerializer.Serialize(writer, LocationValue, options);
		}

		if (DistanceTypeValue is not null)
		{
			writer.WritePropertyName("distance_type");
			JsonSerializer.Serialize(writer, DistanceTypeValue, options);
		}

		if (IgnoreUnmappedValue.HasValue)
		{
			writer.WritePropertyName("ignore_unmapped");
			writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
		}

		if (ModeValue is not null)
		{
			writer.WritePropertyName("mode");
			JsonSerializer.Serialize(writer, ModeValue, options);
		}

		if (NestedDescriptor is not null)
		{
			writer.WritePropertyName("nested");
			JsonSerializer.Serialize(writer, NestedDescriptor, options);
		}
		else if (NestedDescriptorAction is not null)
		{
			writer.WritePropertyName("nested");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.NestedSortValueDescriptor<TDocument>(NestedDescriptorAction), options);
		}
		else if (NestedValue is not null)
		{
			writer.WritePropertyName("nested");
			JsonSerializer.Serialize(writer, NestedValue, options);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			JsonSerializer.Serialize(writer, OrderValue, options);
		}

		if (UnitValue is not null)
		{
			writer.WritePropertyName("unit");
			JsonSerializer.Serialize(writer, UnitValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class GeoDistanceSortDescriptor : SerializableDescriptor<GeoDistanceSortDescriptor>
{
	internal GeoDistanceSortDescriptor(Action<GeoDistanceSortDescriptor> configure) => configure.Invoke(this);

	public GeoDistanceSortDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.GeoDistanceType? DistanceTypeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private bool? IgnoreUnmappedValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.GeoLocation> LocationValue { get; set; }
	private Elastic.Clients.Elasticsearch.SortMode? ModeValue { get; set; }
	private Elastic.Clients.Elasticsearch.NestedSortValue? NestedValue { get; set; }
	private Elastic.Clients.Elasticsearch.NestedSortValueDescriptor NestedDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.NestedSortValueDescriptor> NestedDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.SortOrder? OrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.DistanceUnit? UnitValue { get; set; }

	public GeoDistanceSortDescriptor DistanceType(Elastic.Clients.Elasticsearch.GeoDistanceType? distanceType)
	{
		DistanceTypeValue = distanceType;
		return Self;
	}

	public GeoDistanceSortDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoDistanceSortDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoDistanceSortDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoDistanceSortDescriptor IgnoreUnmapped(bool? ignoreUnmapped = true)
	{
		IgnoreUnmappedValue = ignoreUnmapped;
		return Self;
	}

	public GeoDistanceSortDescriptor Location(ICollection<Elastic.Clients.Elasticsearch.GeoLocation> location)
	{
		LocationValue = location;
		return Self;
	}

	public GeoDistanceSortDescriptor Mode(Elastic.Clients.Elasticsearch.SortMode? mode)
	{
		ModeValue = mode;
		return Self;
	}

	public GeoDistanceSortDescriptor Nested(Elastic.Clients.Elasticsearch.NestedSortValue? nested)
	{
		NestedDescriptor = null;
		NestedDescriptorAction = null;
		NestedValue = nested;
		return Self;
	}

	public GeoDistanceSortDescriptor Nested(Elastic.Clients.Elasticsearch.NestedSortValueDescriptor descriptor)
	{
		NestedValue = null;
		NestedDescriptorAction = null;
		NestedDescriptor = descriptor;
		return Self;
	}

	public GeoDistanceSortDescriptor Nested(Action<Elastic.Clients.Elasticsearch.NestedSortValueDescriptor> configure)
	{
		NestedValue = null;
		NestedDescriptor = null;
		NestedDescriptorAction = configure;
		return Self;
	}

	public GeoDistanceSortDescriptor Order(Elastic.Clients.Elasticsearch.SortOrder? order)
	{
		OrderValue = order;
		return Self;
	}

	public GeoDistanceSortDescriptor Unit(Elastic.Clients.Elasticsearch.DistanceUnit? unit)
	{
		UnitValue = unit;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FieldValue is not null && LocationValue is not null)
		{
			var propertyName = settings.Inferrer.Field(FieldValue);
			writer.WritePropertyName(propertyName);
			JsonSerializer.Serialize(writer, LocationValue, options);
		}

		if (DistanceTypeValue is not null)
		{
			writer.WritePropertyName("distance_type");
			JsonSerializer.Serialize(writer, DistanceTypeValue, options);
		}

		if (IgnoreUnmappedValue.HasValue)
		{
			writer.WritePropertyName("ignore_unmapped");
			writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
		}

		if (ModeValue is not null)
		{
			writer.WritePropertyName("mode");
			JsonSerializer.Serialize(writer, ModeValue, options);
		}

		if (NestedDescriptor is not null)
		{
			writer.WritePropertyName("nested");
			JsonSerializer.Serialize(writer, NestedDescriptor, options);
		}
		else if (NestedDescriptorAction is not null)
		{
			writer.WritePropertyName("nested");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.NestedSortValueDescriptor(NestedDescriptorAction), options);
		}
		else if (NestedValue is not null)
		{
			writer.WritePropertyName("nested");
			JsonSerializer.Serialize(writer, NestedValue, options);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			JsonSerializer.Serialize(writer, OrderValue, options);
		}

		if (UnitValue is not null)
		{
			writer.WritePropertyName("unit");
			JsonSerializer.Serialize(writer, UnitValue, options);
		}

		writer.WriteEndObject();
	}
}