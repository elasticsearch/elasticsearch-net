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

public sealed partial class DateRangeAggregation
{
	/// <summary>
	/// <para>
	/// The date field whose values are use to build ranges.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

	/// <summary>
	/// <para>
	/// The date format used to format <c>from</c> and <c>to</c> in the response.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("format")]
	public string? Format { get; set; }

	/// <summary>
	/// <para>
	/// The value to apply to documents that do not have a value.
	/// By default, documents without a value are ignored.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("missing")]
	public Elastic.Clients.Elasticsearch.FieldValue? Missing { get; set; }

	/// <summary>
	/// <para>
	/// Array of date ranges.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ranges")]
	public ICollection<Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpression>? Ranges { get; set; }

	/// <summary>
	/// <para>
	/// Time zone used to convert dates from another time zone to UTC.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("time_zone")]
	public string? TimeZone { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Aggregations.Aggregation(DateRangeAggregation dateRangeAggregation) => Elastic.Clients.Elasticsearch.Aggregations.Aggregation.DateRange(dateRangeAggregation);
	public static implicit operator Elastic.Clients.Elasticsearch.Security.ApiKeyAggregation(DateRangeAggregation dateRangeAggregation) => Elastic.Clients.Elasticsearch.Security.ApiKeyAggregation.DateRange(dateRangeAggregation);
}

public sealed partial class DateRangeAggregationDescriptor<TDocument> : SerializableDescriptor<DateRangeAggregationDescriptor<TDocument>>
{
	internal DateRangeAggregationDescriptor(Action<DateRangeAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public DateRangeAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.FieldValue? MissingValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpression>? RangesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpressionDescriptor RangesDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpressionDescriptor> RangesDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpressionDescriptor>[] RangesDescriptorActions { get; set; }
	private string? TimeZoneValue { get; set; }

	/// <summary>
	/// <para>
	/// The date field whose values are use to build ranges.
	/// </para>
	/// </summary>
	public DateRangeAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The date field whose values are use to build ranges.
	/// </para>
	/// </summary>
	public DateRangeAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The date field whose values are use to build ranges.
	/// </para>
	/// </summary>
	public DateRangeAggregationDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The date format used to format <c>from</c> and <c>to</c> in the response.
	/// </para>
	/// </summary>
	public DateRangeAggregationDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The value to apply to documents that do not have a value.
	/// By default, documents without a value are ignored.
	/// </para>
	/// </summary>
	public DateRangeAggregationDescriptor<TDocument> Missing(Elastic.Clients.Elasticsearch.FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Array of date ranges.
	/// </para>
	/// </summary>
	public DateRangeAggregationDescriptor<TDocument> Ranges(ICollection<Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpression>? ranges)
	{
		RangesDescriptor = null;
		RangesDescriptorAction = null;
		RangesDescriptorActions = null;
		RangesValue = ranges;
		return Self;
	}

	public DateRangeAggregationDescriptor<TDocument> Ranges(Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpressionDescriptor descriptor)
	{
		RangesValue = null;
		RangesDescriptorAction = null;
		RangesDescriptorActions = null;
		RangesDescriptor = descriptor;
		return Self;
	}

	public DateRangeAggregationDescriptor<TDocument> Ranges(Action<Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpressionDescriptor> configure)
	{
		RangesValue = null;
		RangesDescriptor = null;
		RangesDescriptorActions = null;
		RangesDescriptorAction = configure;
		return Self;
	}

	public DateRangeAggregationDescriptor<TDocument> Ranges(params Action<Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpressionDescriptor>[] configure)
	{
		RangesValue = null;
		RangesDescriptor = null;
		RangesDescriptorAction = null;
		RangesDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Time zone used to convert dates from another time zone to UTC.
	/// </para>
	/// </summary>
	public DateRangeAggregationDescriptor<TDocument> TimeZone(string? timeZone)
	{
		TimeZoneValue = timeZone;
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

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
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
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpressionDescriptor(RangesDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (RangesDescriptorActions is not null)
		{
			writer.WritePropertyName("ranges");
			writer.WriteStartArray();
			foreach (var action in RangesDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpressionDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (RangesValue is not null)
		{
			writer.WritePropertyName("ranges");
			JsonSerializer.Serialize(writer, RangesValue, options);
		}

		if (!string.IsNullOrEmpty(TimeZoneValue))
		{
			writer.WritePropertyName("time_zone");
			writer.WriteStringValue(TimeZoneValue);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class DateRangeAggregationDescriptor : SerializableDescriptor<DateRangeAggregationDescriptor>
{
	internal DateRangeAggregationDescriptor(Action<DateRangeAggregationDescriptor> configure) => configure.Invoke(this);

	public DateRangeAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.FieldValue? MissingValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpression>? RangesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpressionDescriptor RangesDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpressionDescriptor> RangesDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpressionDescriptor>[] RangesDescriptorActions { get; set; }
	private string? TimeZoneValue { get; set; }

	/// <summary>
	/// <para>
	/// The date field whose values are use to build ranges.
	/// </para>
	/// </summary>
	public DateRangeAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The date field whose values are use to build ranges.
	/// </para>
	/// </summary>
	public DateRangeAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The date field whose values are use to build ranges.
	/// </para>
	/// </summary>
	public DateRangeAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The date format used to format <c>from</c> and <c>to</c> in the response.
	/// </para>
	/// </summary>
	public DateRangeAggregationDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The value to apply to documents that do not have a value.
	/// By default, documents without a value are ignored.
	/// </para>
	/// </summary>
	public DateRangeAggregationDescriptor Missing(Elastic.Clients.Elasticsearch.FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Array of date ranges.
	/// </para>
	/// </summary>
	public DateRangeAggregationDescriptor Ranges(ICollection<Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpression>? ranges)
	{
		RangesDescriptor = null;
		RangesDescriptorAction = null;
		RangesDescriptorActions = null;
		RangesValue = ranges;
		return Self;
	}

	public DateRangeAggregationDescriptor Ranges(Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpressionDescriptor descriptor)
	{
		RangesValue = null;
		RangesDescriptorAction = null;
		RangesDescriptorActions = null;
		RangesDescriptor = descriptor;
		return Self;
	}

	public DateRangeAggregationDescriptor Ranges(Action<Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpressionDescriptor> configure)
	{
		RangesValue = null;
		RangesDescriptor = null;
		RangesDescriptorActions = null;
		RangesDescriptorAction = configure;
		return Self;
	}

	public DateRangeAggregationDescriptor Ranges(params Action<Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpressionDescriptor>[] configure)
	{
		RangesValue = null;
		RangesDescriptor = null;
		RangesDescriptorAction = null;
		RangesDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Time zone used to convert dates from another time zone to UTC.
	/// </para>
	/// </summary>
	public DateRangeAggregationDescriptor TimeZone(string? timeZone)
	{
		TimeZoneValue = timeZone;
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

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
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
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpressionDescriptor(RangesDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (RangesDescriptorActions is not null)
		{
			writer.WritePropertyName("ranges");
			writer.WriteStartArray();
			foreach (var action in RangesDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.DateRangeExpressionDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (RangesValue is not null)
		{
			writer.WritePropertyName("ranges");
			JsonSerializer.Serialize(writer, RangesValue, options);
		}

		if (!string.IsNullOrEmpty(TimeZoneValue))
		{
			writer.WritePropertyName("time_zone");
			writer.WriteStringValue(TimeZoneValue);
		}

		writer.WriteEndObject();
	}
}