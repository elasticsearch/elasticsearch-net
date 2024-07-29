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

public sealed partial class CompositeDateHistogramAggregation
{
	/// <summary>
	/// <para>Either `calendar_interval` or `fixed_interval` must be present</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("calendar_interval")]
	public string? CalendarInterval { get; set; }

	/// <summary>
	/// <para>Either `field` or `script` must be present</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

	/// <summary>
	/// <para>Either `calendar_interval` or `fixed_interval` must be present</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fixed_interval")]
	public string? FixedInterval { get; set; }
	[JsonInclude, JsonPropertyName("format")]
	public string? Format { get; set; }
	[JsonInclude, JsonPropertyName("missing_bucket")]
	public bool? MissingBucket { get; set; }
	[JsonInclude, JsonPropertyName("missing_order")]
	public Elastic.Clients.Elasticsearch.Aggregations.MissingOrder? MissingOrder { get; set; }
	[JsonInclude, JsonPropertyName("offset")]
	public Elastic.Clients.Elasticsearch.Duration? Offset { get; set; }
	[JsonInclude, JsonPropertyName("order")]
	public Elastic.Clients.Elasticsearch.SortOrder? Order { get; set; }

	/// <summary>
	/// <para>Either `field` or `script` must be present</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Script? Script { get; set; }
	[JsonInclude, JsonPropertyName("time_zone")]
	public string? TimeZone { get; set; }
	[JsonInclude, JsonPropertyName("value_type")]
	public Elastic.Clients.Elasticsearch.Aggregations.ValueType? ValueType { get; set; }
}

public sealed partial class CompositeDateHistogramAggregationDescriptor<TDocument> : SerializableDescriptor<CompositeDateHistogramAggregationDescriptor<TDocument>>
{
	internal CompositeDateHistogramAggregationDescriptor(Action<CompositeDateHistogramAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public CompositeDateHistogramAggregationDescriptor() : base()
	{
	}

	private string? CalendarIntervalValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private string? FixedIntervalValue { get; set; }
	private string? FormatValue { get; set; }
	private bool? MissingBucketValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.MissingOrder? MissingOrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.Duration? OffsetValue { get; set; }
	private Elastic.Clients.Elasticsearch.SortOrder? OrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }
	private Elastic.Clients.Elasticsearch.ScriptDescriptor ScriptDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> ScriptDescriptorAction { get; set; }
	private string? TimeZoneValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.ValueType? ValueTypeValue { get; set; }

	/// <summary>
	/// <para>Either `calendar_interval` or `fixed_interval` must be present</para>
	/// </summary>
	public CompositeDateHistogramAggregationDescriptor<TDocument> CalendarInterval(string? calendarInterval)
	{
		CalendarIntervalValue = calendarInterval;
		return Self;
	}

	/// <summary>
	/// <para>Either `field` or `script` must be present</para>
	/// </summary>
	public CompositeDateHistogramAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Either `field` or `script` must be present</para>
	/// </summary>
	public CompositeDateHistogramAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Either `field` or `script` must be present</para>
	/// </summary>
	public CompositeDateHistogramAggregationDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Either `calendar_interval` or `fixed_interval` must be present</para>
	/// </summary>
	public CompositeDateHistogramAggregationDescriptor<TDocument> FixedInterval(string? fixedInterval)
	{
		FixedIntervalValue = fixedInterval;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor<TDocument> MissingBucket(bool? missingBucket = true)
	{
		MissingBucketValue = missingBucket;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor<TDocument> MissingOrder(Elastic.Clients.Elasticsearch.Aggregations.MissingOrder? missingOrder)
	{
		MissingOrderValue = missingOrder;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor<TDocument> Offset(Elastic.Clients.Elasticsearch.Duration? offset)
	{
		OffsetValue = offset;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor<TDocument> Order(Elastic.Clients.Elasticsearch.SortOrder? order)
	{
		OrderValue = order;
		return Self;
	}

	/// <summary>
	/// <para>Either `field` or `script` must be present</para>
	/// </summary>
	public CompositeDateHistogramAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptDescriptor = null;
		ScriptDescriptorAction = null;
		ScriptValue = script;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.ScriptDescriptor descriptor)
	{
		ScriptValue = null;
		ScriptDescriptorAction = null;
		ScriptDescriptor = descriptor;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor<TDocument> Script(Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> configure)
	{
		ScriptValue = null;
		ScriptDescriptor = null;
		ScriptDescriptorAction = configure;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor<TDocument> TimeZone(string? timeZone)
	{
		TimeZoneValue = timeZone;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor<TDocument> ValueType(Elastic.Clients.Elasticsearch.Aggregations.ValueType? valueType)
	{
		ValueTypeValue = valueType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(CalendarIntervalValue))
		{
			writer.WritePropertyName("calendar_interval");
			writer.WriteStringValue(CalendarIntervalValue);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (!string.IsNullOrEmpty(FixedIntervalValue))
		{
			writer.WritePropertyName("fixed_interval");
			writer.WriteStringValue(FixedIntervalValue);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (MissingBucketValue.HasValue)
		{
			writer.WritePropertyName("missing_bucket");
			writer.WriteBooleanValue(MissingBucketValue.Value);
		}

		if (MissingOrderValue is not null)
		{
			writer.WritePropertyName("missing_order");
			JsonSerializer.Serialize(writer, MissingOrderValue, options);
		}

		if (OffsetValue is not null)
		{
			writer.WritePropertyName("offset");
			JsonSerializer.Serialize(writer, OffsetValue, options);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			JsonSerializer.Serialize(writer, OrderValue, options);
		}

		if (ScriptDescriptor is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptDescriptor, options);
		}
		else if (ScriptDescriptorAction is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.ScriptDescriptor(ScriptDescriptorAction), options);
		}
		else if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (!string.IsNullOrEmpty(TimeZoneValue))
		{
			writer.WritePropertyName("time_zone");
			writer.WriteStringValue(TimeZoneValue);
		}

		if (ValueTypeValue is not null)
		{
			writer.WritePropertyName("value_type");
			JsonSerializer.Serialize(writer, ValueTypeValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class CompositeDateHistogramAggregationDescriptor : SerializableDescriptor<CompositeDateHistogramAggregationDescriptor>
{
	internal CompositeDateHistogramAggregationDescriptor(Action<CompositeDateHistogramAggregationDescriptor> configure) => configure.Invoke(this);

	public CompositeDateHistogramAggregationDescriptor() : base()
	{
	}

	private string? CalendarIntervalValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private string? FixedIntervalValue { get; set; }
	private string? FormatValue { get; set; }
	private bool? MissingBucketValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.MissingOrder? MissingOrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.Duration? OffsetValue { get; set; }
	private Elastic.Clients.Elasticsearch.SortOrder? OrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }
	private Elastic.Clients.Elasticsearch.ScriptDescriptor ScriptDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> ScriptDescriptorAction { get; set; }
	private string? TimeZoneValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.ValueType? ValueTypeValue { get; set; }

	/// <summary>
	/// <para>Either `calendar_interval` or `fixed_interval` must be present</para>
	/// </summary>
	public CompositeDateHistogramAggregationDescriptor CalendarInterval(string? calendarInterval)
	{
		CalendarIntervalValue = calendarInterval;
		return Self;
	}

	/// <summary>
	/// <para>Either `field` or `script` must be present</para>
	/// </summary>
	public CompositeDateHistogramAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Either `field` or `script` must be present</para>
	/// </summary>
	public CompositeDateHistogramAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Either `field` or `script` must be present</para>
	/// </summary>
	public CompositeDateHistogramAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Either `calendar_interval` or `fixed_interval` must be present</para>
	/// </summary>
	public CompositeDateHistogramAggregationDescriptor FixedInterval(string? fixedInterval)
	{
		FixedIntervalValue = fixedInterval;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor MissingBucket(bool? missingBucket = true)
	{
		MissingBucketValue = missingBucket;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor MissingOrder(Elastic.Clients.Elasticsearch.Aggregations.MissingOrder? missingOrder)
	{
		MissingOrderValue = missingOrder;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor Offset(Elastic.Clients.Elasticsearch.Duration? offset)
	{
		OffsetValue = offset;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor Order(Elastic.Clients.Elasticsearch.SortOrder? order)
	{
		OrderValue = order;
		return Self;
	}

	/// <summary>
	/// <para>Either `field` or `script` must be present</para>
	/// </summary>
	public CompositeDateHistogramAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptDescriptor = null;
		ScriptDescriptorAction = null;
		ScriptValue = script;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor Script(Elastic.Clients.Elasticsearch.ScriptDescriptor descriptor)
	{
		ScriptValue = null;
		ScriptDescriptorAction = null;
		ScriptDescriptor = descriptor;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor Script(Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> configure)
	{
		ScriptValue = null;
		ScriptDescriptor = null;
		ScriptDescriptorAction = configure;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor TimeZone(string? timeZone)
	{
		TimeZoneValue = timeZone;
		return Self;
	}

	public CompositeDateHistogramAggregationDescriptor ValueType(Elastic.Clients.Elasticsearch.Aggregations.ValueType? valueType)
	{
		ValueTypeValue = valueType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(CalendarIntervalValue))
		{
			writer.WritePropertyName("calendar_interval");
			writer.WriteStringValue(CalendarIntervalValue);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (!string.IsNullOrEmpty(FixedIntervalValue))
		{
			writer.WritePropertyName("fixed_interval");
			writer.WriteStringValue(FixedIntervalValue);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (MissingBucketValue.HasValue)
		{
			writer.WritePropertyName("missing_bucket");
			writer.WriteBooleanValue(MissingBucketValue.Value);
		}

		if (MissingOrderValue is not null)
		{
			writer.WritePropertyName("missing_order");
			JsonSerializer.Serialize(writer, MissingOrderValue, options);
		}

		if (OffsetValue is not null)
		{
			writer.WritePropertyName("offset");
			JsonSerializer.Serialize(writer, OffsetValue, options);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			JsonSerializer.Serialize(writer, OrderValue, options);
		}

		if (ScriptDescriptor is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptDescriptor, options);
		}
		else if (ScriptDescriptorAction is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.ScriptDescriptor(ScriptDescriptorAction), options);
		}
		else if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (!string.IsNullOrEmpty(TimeZoneValue))
		{
			writer.WritePropertyName("time_zone");
			writer.WriteStringValue(TimeZoneValue);
		}

		if (ValueTypeValue is not null)
		{
			writer.WritePropertyName("value_type");
			JsonSerializer.Serialize(writer, ValueTypeValue, options);
		}

		writer.WriteEndObject();
	}
}