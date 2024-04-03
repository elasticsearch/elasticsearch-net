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

public sealed partial class HistogramAggregation
{
	/// <summary>
	/// <para>The name of the field to aggregate on.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field? Field { get; set; }
	[JsonInclude, JsonPropertyName("format")]
	public string? Format { get; set; }

	/// <summary>
	/// <para>The interval for the buckets.<br/>Must be a positive decimal.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("interval")]
	public double? Interval { get; set; }
	[JsonInclude, JsonPropertyName("meta")]
	public IDictionary<string, object>? Meta { get; set; }

	/// <summary>
	/// <para>Only returns buckets that have `min_doc_count` number of documents.<br/>By default, the response will fill gaps in the histogram with empty buckets.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("min_doc_count")]
	public int? MinDocCount { get; set; }

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("missing")]
	public double? Missing { get; set; }
	[JsonInclude, JsonPropertyName("name")]
	public string? Name { get; set; }

	/// <summary>
	/// <para>By default, the bucket keys start with 0 and then continue in even spaced steps of `interval`.<br/>The bucket boundaries can be shifted by using the `offset` option.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("offset")]
	public double? Offset { get; set; }

	/// <summary>
	/// <para>The sort order of the returned buckets.<br/>By default, the returned buckets are sorted by their key ascending.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("order")]
	[SingleOrManyCollectionConverter(typeof(IReadOnlyDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.SortOrder>))]
	public ICollection<IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.SortOrder>>? Order { get; set; }
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Serverless.Script? Script { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.Aggregations.Aggregation(HistogramAggregation histogramAggregation) => Elastic.Clients.Elasticsearch.Serverless.Aggregations.Aggregation.Histogram(histogramAggregation);
	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.TransformManagement.PivotGroupBy(HistogramAggregation histogramAggregation) => Elastic.Clients.Elasticsearch.Serverless.TransformManagement.PivotGroupBy.Histogram(histogramAggregation);
}

public sealed partial class HistogramAggregationDescriptor<TDocument> : SerializableDescriptor<HistogramAggregationDescriptor<TDocument>>
{
	internal HistogramAggregationDescriptor(Action<HistogramAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public HistogramAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Field? FieldValue { get; set; }
	private string? FormatValue { get; set; }
	private double? IntervalValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private int? MinDocCountValue { get; set; }
	private double? MissingValue { get; set; }
	private string? NameValue { get; set; }
	private double? OffsetValue { get; set; }
	private ICollection<IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.SortOrder>>? OrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Script? ScriptValue { get; set; }

	/// <summary>
	/// <para>The name of the field to aggregate on.</para>
	/// </summary>
	public HistogramAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field to aggregate on.</para>
	/// </summary>
	public HistogramAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field to aggregate on.</para>
	/// </summary>
	public HistogramAggregationDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public HistogramAggregationDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	/// <summary>
	/// <para>The interval for the buckets.<br/>Must be a positive decimal.</para>
	/// </summary>
	public HistogramAggregationDescriptor<TDocument> Interval(double? interval)
	{
		IntervalValue = interval;
		return Self;
	}

	public HistogramAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>Only returns buckets that have `min_doc_count` number of documents.<br/>By default, the response will fill gaps in the histogram with empty buckets.</para>
	/// </summary>
	public HistogramAggregationDescriptor<TDocument> MinDocCount(int? minDocCount)
	{
		MinDocCountValue = minDocCount;
		return Self;
	}

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	public HistogramAggregationDescriptor<TDocument> Missing(double? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public HistogramAggregationDescriptor<TDocument> Name(string? name)
	{
		NameValue = name;
		return Self;
	}

	/// <summary>
	/// <para>By default, the bucket keys start with 0 and then continue in even spaced steps of `interval`.<br/>The bucket boundaries can be shifted by using the `offset` option.</para>
	/// </summary>
	public HistogramAggregationDescriptor<TDocument> Offset(double? offset)
	{
		OffsetValue = offset;
		return Self;
	}

	/// <summary>
	/// <para>The sort order of the returned buckets.<br/>By default, the returned buckets are sorted by their key ascending.</para>
	/// </summary>
	public HistogramAggregationDescriptor<TDocument> Order(ICollection<IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.SortOrder>>? order)
	{
		OrderValue = order;
		return Self;
	}

	public HistogramAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Serverless.Script? script)
	{
		ScriptValue = script;
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

		if (IntervalValue.HasValue)
		{
			writer.WritePropertyName("interval");
			writer.WriteNumberValue(IntervalValue.Value);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (MinDocCountValue.HasValue)
		{
			writer.WritePropertyName("min_doc_count");
			writer.WriteNumberValue(MinDocCountValue.Value);
		}

		if (MissingValue.HasValue)
		{
			writer.WritePropertyName("missing");
			writer.WriteNumberValue(MissingValue.Value);
		}

		if (!string.IsNullOrEmpty(NameValue))
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(NameValue);
		}

		if (OffsetValue.HasValue)
		{
			writer.WritePropertyName("offset");
			writer.WriteNumberValue(OffsetValue.Value);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			SingleOrManySerializationHelper.Serialize<IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.SortOrder>>(OrderValue, writer, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class HistogramAggregationDescriptor : SerializableDescriptor<HistogramAggregationDescriptor>
{
	internal HistogramAggregationDescriptor(Action<HistogramAggregationDescriptor> configure) => configure.Invoke(this);

	public HistogramAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Field? FieldValue { get; set; }
	private string? FormatValue { get; set; }
	private double? IntervalValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private int? MinDocCountValue { get; set; }
	private double? MissingValue { get; set; }
	private string? NameValue { get; set; }
	private double? OffsetValue { get; set; }
	private ICollection<IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.SortOrder>>? OrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Script? ScriptValue { get; set; }

	/// <summary>
	/// <para>The name of the field to aggregate on.</para>
	/// </summary>
	public HistogramAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field to aggregate on.</para>
	/// </summary>
	public HistogramAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field to aggregate on.</para>
	/// </summary>
	public HistogramAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public HistogramAggregationDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	/// <summary>
	/// <para>The interval for the buckets.<br/>Must be a positive decimal.</para>
	/// </summary>
	public HistogramAggregationDescriptor Interval(double? interval)
	{
		IntervalValue = interval;
		return Self;
	}

	public HistogramAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>Only returns buckets that have `min_doc_count` number of documents.<br/>By default, the response will fill gaps in the histogram with empty buckets.</para>
	/// </summary>
	public HistogramAggregationDescriptor MinDocCount(int? minDocCount)
	{
		MinDocCountValue = minDocCount;
		return Self;
	}

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	public HistogramAggregationDescriptor Missing(double? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public HistogramAggregationDescriptor Name(string? name)
	{
		NameValue = name;
		return Self;
	}

	/// <summary>
	/// <para>By default, the bucket keys start with 0 and then continue in even spaced steps of `interval`.<br/>The bucket boundaries can be shifted by using the `offset` option.</para>
	/// </summary>
	public HistogramAggregationDescriptor Offset(double? offset)
	{
		OffsetValue = offset;
		return Self;
	}

	/// <summary>
	/// <para>The sort order of the returned buckets.<br/>By default, the returned buckets are sorted by their key ascending.</para>
	/// </summary>
	public HistogramAggregationDescriptor Order(ICollection<IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.SortOrder>>? order)
	{
		OrderValue = order;
		return Self;
	}

	public HistogramAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Serverless.Script? script)
	{
		ScriptValue = script;
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

		if (IntervalValue.HasValue)
		{
			writer.WritePropertyName("interval");
			writer.WriteNumberValue(IntervalValue.Value);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (MinDocCountValue.HasValue)
		{
			writer.WritePropertyName("min_doc_count");
			writer.WriteNumberValue(MinDocCountValue.Value);
		}

		if (MissingValue.HasValue)
		{
			writer.WritePropertyName("missing");
			writer.WriteNumberValue(MissingValue.Value);
		}

		if (!string.IsNullOrEmpty(NameValue))
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(NameValue);
		}

		if (OffsetValue.HasValue)
		{
			writer.WritePropertyName("offset");
			writer.WriteNumberValue(OffsetValue.Value);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			SingleOrManySerializationHelper.Serialize<IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.SortOrder>>(OrderValue, writer, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		writer.WriteEndObject();
	}
}