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

namespace Elastic.Clients.Elasticsearch.Serverless.Aggregations;

public sealed partial class GeoDistanceAggregation
{
	/// <summary>
	/// <para>The distance calculation type.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("distance_type")]
	public Elastic.Clients.Elasticsearch.Serverless.GeoDistanceType? DistanceType { get; set; }

	/// <summary>
	/// <para>A field of type `geo_point` used to evaluate the distance.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field? Field { get; set; }

	/// <summary>
	/// <para>The origin  used to evaluate the distance.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("origin")]
	public Elastic.Clients.Elasticsearch.Serverless.GeoLocation? Origin { get; set; }

	/// <summary>
	/// <para>An array of ranges used to bucket documents.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ranges")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRange>? Ranges { get; set; }

	/// <summary>
	/// <para>The distance unit.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("unit")]
	public Elastic.Clients.Elasticsearch.Serverless.DistanceUnit? Unit { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.Aggregations.Aggregation(GeoDistanceAggregation geoDistanceAggregation) => Elastic.Clients.Elasticsearch.Serverless.Aggregations.Aggregation.GeoDistance(geoDistanceAggregation);
}

public sealed partial class GeoDistanceAggregationDescriptor<TDocument> : SerializableDescriptor<GeoDistanceAggregationDescriptor<TDocument>>
{
	internal GeoDistanceAggregationDescriptor(Action<GeoDistanceAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GeoDistanceAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.GeoDistanceType? DistanceTypeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.GeoLocation? OriginValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRange>? RangesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRangeDescriptor RangesDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRangeDescriptor> RangesDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRangeDescriptor>[] RangesDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.DistanceUnit? UnitValue { get; set; }

	/// <summary>
	/// <para>The distance calculation type.</para>
	/// </summary>
	public GeoDistanceAggregationDescriptor<TDocument> DistanceType(Elastic.Clients.Elasticsearch.Serverless.GeoDistanceType? distanceType)
	{
		DistanceTypeValue = distanceType;
		return Self;
	}

	/// <summary>
	/// <para>A field of type `geo_point` used to evaluate the distance.</para>
	/// </summary>
	public GeoDistanceAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>A field of type `geo_point` used to evaluate the distance.</para>
	/// </summary>
	public GeoDistanceAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>A field of type `geo_point` used to evaluate the distance.</para>
	/// </summary>
	public GeoDistanceAggregationDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The origin  used to evaluate the distance.</para>
	/// </summary>
	public GeoDistanceAggregationDescriptor<TDocument> Origin(Elastic.Clients.Elasticsearch.Serverless.GeoLocation? origin)
	{
		OriginValue = origin;
		return Self;
	}

	/// <summary>
	/// <para>An array of ranges used to bucket documents.</para>
	/// </summary>
	public GeoDistanceAggregationDescriptor<TDocument> Ranges(ICollection<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRange>? ranges)
	{
		RangesDescriptor = null;
		RangesDescriptorAction = null;
		RangesDescriptorActions = null;
		RangesValue = ranges;
		return Self;
	}

	public GeoDistanceAggregationDescriptor<TDocument> Ranges(Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRangeDescriptor descriptor)
	{
		RangesValue = null;
		RangesDescriptorAction = null;
		RangesDescriptorActions = null;
		RangesDescriptor = descriptor;
		return Self;
	}

	public GeoDistanceAggregationDescriptor<TDocument> Ranges(Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRangeDescriptor> configure)
	{
		RangesValue = null;
		RangesDescriptor = null;
		RangesDescriptorActions = null;
		RangesDescriptorAction = configure;
		return Self;
	}

	public GeoDistanceAggregationDescriptor<TDocument> Ranges(params Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRangeDescriptor>[] configure)
	{
		RangesValue = null;
		RangesDescriptor = null;
		RangesDescriptorAction = null;
		RangesDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>The distance unit.</para>
	/// </summary>
	public GeoDistanceAggregationDescriptor<TDocument> Unit(Elastic.Clients.Elasticsearch.Serverless.DistanceUnit? unit)
	{
		UnitValue = unit;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DistanceTypeValue is not null)
		{
			writer.WritePropertyName("distance_type");
			JsonSerializer.Serialize(writer, DistanceTypeValue, options);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (OriginValue is not null)
		{
			writer.WritePropertyName("origin");
			JsonSerializer.Serialize(writer, OriginValue, options);
		}

		if (RangesDescriptor is not null)
		{
			writer.WritePropertyName("ranges");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, RangesDescriptor, options);
			writer.WriteEndArray();
		}
		else if (RangesDescriptorAction is not null)
		{
			writer.WritePropertyName("ranges");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRangeDescriptor(RangesDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (RangesDescriptorActions is not null)
		{
			writer.WritePropertyName("ranges");
			writer.WriteStartArray();
			foreach (var action in RangesDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRangeDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (RangesValue is not null)
		{
			writer.WritePropertyName("ranges");
			JsonSerializer.Serialize(writer, RangesValue, options);
		}

		if (UnitValue is not null)
		{
			writer.WritePropertyName("unit");
			JsonSerializer.Serialize(writer, UnitValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class GeoDistanceAggregationDescriptor : SerializableDescriptor<GeoDistanceAggregationDescriptor>
{
	internal GeoDistanceAggregationDescriptor(Action<GeoDistanceAggregationDescriptor> configure) => configure.Invoke(this);

	public GeoDistanceAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.GeoDistanceType? DistanceTypeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.GeoLocation? OriginValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRange>? RangesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRangeDescriptor RangesDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRangeDescriptor> RangesDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRangeDescriptor>[] RangesDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.DistanceUnit? UnitValue { get; set; }

	/// <summary>
	/// <para>The distance calculation type.</para>
	/// </summary>
	public GeoDistanceAggregationDescriptor DistanceType(Elastic.Clients.Elasticsearch.Serverless.GeoDistanceType? distanceType)
	{
		DistanceTypeValue = distanceType;
		return Self;
	}

	/// <summary>
	/// <para>A field of type `geo_point` used to evaluate the distance.</para>
	/// </summary>
	public GeoDistanceAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>A field of type `geo_point` used to evaluate the distance.</para>
	/// </summary>
	public GeoDistanceAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>A field of type `geo_point` used to evaluate the distance.</para>
	/// </summary>
	public GeoDistanceAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The origin  used to evaluate the distance.</para>
	/// </summary>
	public GeoDistanceAggregationDescriptor Origin(Elastic.Clients.Elasticsearch.Serverless.GeoLocation? origin)
	{
		OriginValue = origin;
		return Self;
	}

	/// <summary>
	/// <para>An array of ranges used to bucket documents.</para>
	/// </summary>
	public GeoDistanceAggregationDescriptor Ranges(ICollection<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRange>? ranges)
	{
		RangesDescriptor = null;
		RangesDescriptorAction = null;
		RangesDescriptorActions = null;
		RangesValue = ranges;
		return Self;
	}

	public GeoDistanceAggregationDescriptor Ranges(Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRangeDescriptor descriptor)
	{
		RangesValue = null;
		RangesDescriptorAction = null;
		RangesDescriptorActions = null;
		RangesDescriptor = descriptor;
		return Self;
	}

	public GeoDistanceAggregationDescriptor Ranges(Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRangeDescriptor> configure)
	{
		RangesValue = null;
		RangesDescriptor = null;
		RangesDescriptorActions = null;
		RangesDescriptorAction = configure;
		return Self;
	}

	public GeoDistanceAggregationDescriptor Ranges(params Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRangeDescriptor>[] configure)
	{
		RangesValue = null;
		RangesDescriptor = null;
		RangesDescriptorAction = null;
		RangesDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>The distance unit.</para>
	/// </summary>
	public GeoDistanceAggregationDescriptor Unit(Elastic.Clients.Elasticsearch.Serverless.DistanceUnit? unit)
	{
		UnitValue = unit;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DistanceTypeValue is not null)
		{
			writer.WritePropertyName("distance_type");
			JsonSerializer.Serialize(writer, DistanceTypeValue, options);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (OriginValue is not null)
		{
			writer.WritePropertyName("origin");
			JsonSerializer.Serialize(writer, OriginValue, options);
		}

		if (RangesDescriptor is not null)
		{
			writer.WritePropertyName("ranges");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, RangesDescriptor, options);
			writer.WriteEndArray();
		}
		else if (RangesDescriptorAction is not null)
		{
			writer.WritePropertyName("ranges");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRangeDescriptor(RangesDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (RangesDescriptorActions is not null)
		{
			writer.WritePropertyName("ranges");
			writer.WriteStartArray();
			foreach (var action in RangesDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationRangeDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (RangesValue is not null)
		{
			writer.WritePropertyName("ranges");
			JsonSerializer.Serialize(writer, RangesValue, options);
		}

		if (UnitValue is not null)
		{
			writer.WritePropertyName("unit");
			JsonSerializer.Serialize(writer, UnitValue, options);
		}

		writer.WriteEndObject();
	}
}