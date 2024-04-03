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

public sealed partial class GeoLineAggregation
{
	/// <summary>
	/// <para>When `true`, returns an additional array of the sort values in the feature properties.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("include_sort")]
	public bool? IncludeSort { get; set; }

	/// <summary>
	/// <para>The name of the geo_point field.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("point")]
	public Elastic.Clients.Elasticsearch.Aggregations.GeoLinePoint Point { get; set; }

	/// <summary>
	/// <para>The maximum length of the line represented in the aggregation.<br/>Valid sizes are between 1 and 10000.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("size")]
	public int? Size { get; set; }

	/// <summary>
	/// <para>The name of the numeric field to use as the sort key for ordering the points.<br/>When the `geo_line` aggregation is nested inside a `time_series` aggregation, this field defaults to `@timestamp`, and any other value will result in error.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("sort")]
	public Elastic.Clients.Elasticsearch.Aggregations.GeoLineSort Sort { get; set; }

	/// <summary>
	/// <para>The order in which the line is sorted (ascending or descending).</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("sort_order")]
	public Elastic.Clients.Elasticsearch.SortOrder? SortOrder { get; set; }
}

public sealed partial class GeoLineAggregationDescriptor<TDocument> : SerializableDescriptor<GeoLineAggregationDescriptor<TDocument>>
{
	internal GeoLineAggregationDescriptor(Action<GeoLineAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GeoLineAggregationDescriptor() : base()
	{
	}

	private bool? IncludeSortValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.GeoLinePoint PointValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.GeoLinePointDescriptor<TDocument> PointDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.GeoLinePointDescriptor<TDocument>> PointDescriptorAction { get; set; }
	private int? SizeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.GeoLineSort SortValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.GeoLineSortDescriptor<TDocument> SortDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.GeoLineSortDescriptor<TDocument>> SortDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.SortOrder? SortOrderValue { get; set; }

	/// <summary>
	/// <para>When `true`, returns an additional array of the sort values in the feature properties.</para>
	/// </summary>
	public GeoLineAggregationDescriptor<TDocument> IncludeSort(bool? includeSort = true)
	{
		IncludeSortValue = includeSort;
		return Self;
	}

	/// <summary>
	/// <para>The name of the geo_point field.</para>
	/// </summary>
	public GeoLineAggregationDescriptor<TDocument> Point(Elastic.Clients.Elasticsearch.Aggregations.GeoLinePoint point)
	{
		PointDescriptor = null;
		PointDescriptorAction = null;
		PointValue = point;
		return Self;
	}

	public GeoLineAggregationDescriptor<TDocument> Point(Elastic.Clients.Elasticsearch.Aggregations.GeoLinePointDescriptor<TDocument> descriptor)
	{
		PointValue = null;
		PointDescriptorAction = null;
		PointDescriptor = descriptor;
		return Self;
	}

	public GeoLineAggregationDescriptor<TDocument> Point(Action<Elastic.Clients.Elasticsearch.Aggregations.GeoLinePointDescriptor<TDocument>> configure)
	{
		PointValue = null;
		PointDescriptor = null;
		PointDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The maximum length of the line represented in the aggregation.<br/>Valid sizes are between 1 and 10000.</para>
	/// </summary>
	public GeoLineAggregationDescriptor<TDocument> Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	/// <summary>
	/// <para>The name of the numeric field to use as the sort key for ordering the points.<br/>When the `geo_line` aggregation is nested inside a `time_series` aggregation, this field defaults to `@timestamp`, and any other value will result in error.</para>
	/// </summary>
	public GeoLineAggregationDescriptor<TDocument> Sort(Elastic.Clients.Elasticsearch.Aggregations.GeoLineSort sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortValue = sort;
		return Self;
	}

	public GeoLineAggregationDescriptor<TDocument> Sort(Elastic.Clients.Elasticsearch.Aggregations.GeoLineSortDescriptor<TDocument> descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public GeoLineAggregationDescriptor<TDocument> Sort(Action<Elastic.Clients.Elasticsearch.Aggregations.GeoLineSortDescriptor<TDocument>> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The order in which the line is sorted (ascending or descending).</para>
	/// </summary>
	public GeoLineAggregationDescriptor<TDocument> SortOrder(Elastic.Clients.Elasticsearch.SortOrder? sortOrder)
	{
		SortOrderValue = sortOrder;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IncludeSortValue.HasValue)
		{
			writer.WritePropertyName("include_sort");
			writer.WriteBooleanValue(IncludeSortValue.Value);
		}

		if (PointDescriptor is not null)
		{
			writer.WritePropertyName("point");
			JsonSerializer.Serialize(writer, PointDescriptor, options);
		}
		else if (PointDescriptorAction is not null)
		{
			writer.WritePropertyName("point");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.GeoLinePointDescriptor<TDocument>(PointDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("point");
			JsonSerializer.Serialize(writer, PointValue, options);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.GeoLineSortDescriptor<TDocument>(SortDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortValue, options);
		}

		if (SortOrderValue is not null)
		{
			writer.WritePropertyName("sort_order");
			JsonSerializer.Serialize(writer, SortOrderValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class GeoLineAggregationDescriptor : SerializableDescriptor<GeoLineAggregationDescriptor>
{
	internal GeoLineAggregationDescriptor(Action<GeoLineAggregationDescriptor> configure) => configure.Invoke(this);

	public GeoLineAggregationDescriptor() : base()
	{
	}

	private bool? IncludeSortValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.GeoLinePoint PointValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.GeoLinePointDescriptor PointDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.GeoLinePointDescriptor> PointDescriptorAction { get; set; }
	private int? SizeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.GeoLineSort SortValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.GeoLineSortDescriptor SortDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.GeoLineSortDescriptor> SortDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.SortOrder? SortOrderValue { get; set; }

	/// <summary>
	/// <para>When `true`, returns an additional array of the sort values in the feature properties.</para>
	/// </summary>
	public GeoLineAggregationDescriptor IncludeSort(bool? includeSort = true)
	{
		IncludeSortValue = includeSort;
		return Self;
	}

	/// <summary>
	/// <para>The name of the geo_point field.</para>
	/// </summary>
	public GeoLineAggregationDescriptor Point(Elastic.Clients.Elasticsearch.Aggregations.GeoLinePoint point)
	{
		PointDescriptor = null;
		PointDescriptorAction = null;
		PointValue = point;
		return Self;
	}

	public GeoLineAggregationDescriptor Point(Elastic.Clients.Elasticsearch.Aggregations.GeoLinePointDescriptor descriptor)
	{
		PointValue = null;
		PointDescriptorAction = null;
		PointDescriptor = descriptor;
		return Self;
	}

	public GeoLineAggregationDescriptor Point(Action<Elastic.Clients.Elasticsearch.Aggregations.GeoLinePointDescriptor> configure)
	{
		PointValue = null;
		PointDescriptor = null;
		PointDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The maximum length of the line represented in the aggregation.<br/>Valid sizes are between 1 and 10000.</para>
	/// </summary>
	public GeoLineAggregationDescriptor Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	/// <summary>
	/// <para>The name of the numeric field to use as the sort key for ordering the points.<br/>When the `geo_line` aggregation is nested inside a `time_series` aggregation, this field defaults to `@timestamp`, and any other value will result in error.</para>
	/// </summary>
	public GeoLineAggregationDescriptor Sort(Elastic.Clients.Elasticsearch.Aggregations.GeoLineSort sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortValue = sort;
		return Self;
	}

	public GeoLineAggregationDescriptor Sort(Elastic.Clients.Elasticsearch.Aggregations.GeoLineSortDescriptor descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public GeoLineAggregationDescriptor Sort(Action<Elastic.Clients.Elasticsearch.Aggregations.GeoLineSortDescriptor> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The order in which the line is sorted (ascending or descending).</para>
	/// </summary>
	public GeoLineAggregationDescriptor SortOrder(Elastic.Clients.Elasticsearch.SortOrder? sortOrder)
	{
		SortOrderValue = sortOrder;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IncludeSortValue.HasValue)
		{
			writer.WritePropertyName("include_sort");
			writer.WriteBooleanValue(IncludeSortValue.Value);
		}

		if (PointDescriptor is not null)
		{
			writer.WritePropertyName("point");
			JsonSerializer.Serialize(writer, PointDescriptor, options);
		}
		else if (PointDescriptorAction is not null)
		{
			writer.WritePropertyName("point");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.GeoLinePointDescriptor(PointDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("point");
			JsonSerializer.Serialize(writer, PointValue, options);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.GeoLineSortDescriptor(SortDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortValue, options);
		}

		if (SortOrderValue is not null)
		{
			writer.WritePropertyName("sort_order");
			JsonSerializer.Serialize(writer, SortOrderValue, options);
		}

		writer.WriteEndObject();
	}
}