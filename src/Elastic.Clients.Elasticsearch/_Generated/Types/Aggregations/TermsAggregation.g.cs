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

public sealed partial class TermsAggregation
{
	/// <summary>
	/// <para>Determines how child aggregations should be calculated: breadth-first or depth-first.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("collect_mode")]
	public Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationCollectMode? CollectMode { get; set; }

	/// <summary>
	/// <para>Values to exclude.<br/>Accepts regular expressions and partitions.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("exclude")]
	public Elastic.Clients.Elasticsearch.Aggregations.TermsExclude? Exclude { get; set; }

	/// <summary>
	/// <para>Determines whether the aggregation will use field values directly or global ordinals.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("execution_hint")]
	public Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationExecutionHint? ExecutionHint { get; set; }

	/// <summary>
	/// <para>The field from which to return terms.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }
	[JsonInclude, JsonPropertyName("format")]
	public string? Format { get; set; }

	/// <summary>
	/// <para>Values to include.<br/>Accepts regular expressions and partitions.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("include")]
	public Elastic.Clients.Elasticsearch.Aggregations.TermsInclude? Include { get; set; }

	/// <summary>
	/// <para>Only return values that are found in more than `min_doc_count` hits.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("min_doc_count")]
	public int? MinDocCount { get; set; }

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("missing")]
	public Elastic.Clients.Elasticsearch.FieldValue? Missing { get; set; }
	[JsonInclude, JsonPropertyName("missing_bucket")]
	public bool? MissingBucket { get; set; }
	[JsonInclude, JsonPropertyName("missing_order")]
	public Elastic.Clients.Elasticsearch.Aggregations.MissingOrder? MissingOrder { get; set; }

	/// <summary>
	/// <para>Specifies the sort order of the buckets.<br/>Defaults to sorting by descending document count.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("order")]
	[SingleOrManyCollectionConverter(typeof(KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>))]
	public ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>? Order { get; set; }
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Script? Script { get; set; }

	/// <summary>
	/// <para>Regulates the certainty a shard has if the term should actually be added to the candidate list or not with respect to the `min_doc_count`.<br/>Terms will only be considered if their local shard frequency within the set is higher than the `shard_min_doc_count`.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("shard_min_doc_count")]
	public long? ShardMinDocCount { get; set; }

	/// <summary>
	/// <para>The number of candidate terms produced by each shard.<br/>By default, `shard_size` will be automatically estimated based on the number of shards and the `size` parameter.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("shard_size")]
	public int? ShardSize { get; set; }

	/// <summary>
	/// <para>Set to `true` to return the `doc_count_error_upper_bound`, which is an upper bound to the error on the `doc_count` returned by each shard.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("show_term_doc_count_error")]
	public bool? ShowTermDocCountError { get; set; }

	/// <summary>
	/// <para>The number of buckets returned out of the overall terms list.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("size")]
	public int? Size { get; set; }

	/// <summary>
	/// <para>Coerced unmapped fields into the specified type.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("value_type")]
	public string? ValueType { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Aggregations.Aggregation(TermsAggregation termsAggregation) => Elastic.Clients.Elasticsearch.Aggregations.Aggregation.Terms(termsAggregation);
	public static implicit operator Elastic.Clients.Elasticsearch.TransformManagement.PivotGroupBy(TermsAggregation termsAggregation) => Elastic.Clients.Elasticsearch.TransformManagement.PivotGroupBy.Terms(termsAggregation);
}

public sealed partial class TermsAggregationDescriptor<TDocument> : SerializableDescriptor<TermsAggregationDescriptor<TDocument>>
{
	internal TermsAggregationDescriptor(Action<TermsAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public TermsAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationCollectMode? CollectModeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.TermsExclude? ExcludeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationExecutionHint? ExecutionHintValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.TermsInclude? IncludeValue { get; set; }
	private int? MinDocCountValue { get; set; }
	private Elastic.Clients.Elasticsearch.FieldValue? MissingValue { get; set; }
	private bool? MissingBucketValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.MissingOrder? MissingOrderValue { get; set; }
	private ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>? OrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }
	private long? ShardMinDocCountValue { get; set; }
	private int? ShardSizeValue { get; set; }
	private bool? ShowTermDocCountErrorValue { get; set; }
	private int? SizeValue { get; set; }
	private string? ValueTypeValue { get; set; }

	/// <summary>
	/// <para>Determines how child aggregations should be calculated: breadth-first or depth-first.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> CollectMode(Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationCollectMode? collectMode)
	{
		CollectModeValue = collectMode;
		return Self;
	}

	/// <summary>
	/// <para>Values to exclude.<br/>Accepts regular expressions and partitions.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> Exclude(Elastic.Clients.Elasticsearch.Aggregations.TermsExclude? exclude)
	{
		ExcludeValue = exclude;
		return Self;
	}

	/// <summary>
	/// <para>Determines whether the aggregation will use field values directly or global ordinals.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> ExecutionHint(Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationExecutionHint? executionHint)
	{
		ExecutionHintValue = executionHint;
		return Self;
	}

	/// <summary>
	/// <para>The field from which to return terms.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field from which to return terms.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field from which to return terms.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TermsAggregationDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	/// <summary>
	/// <para>Values to include.<br/>Accepts regular expressions and partitions.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> Include(Elastic.Clients.Elasticsearch.Aggregations.TermsInclude? include)
	{
		IncludeValue = include;
		return Self;
	}

	/// <summary>
	/// <para>Only return values that are found in more than `min_doc_count` hits.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> MinDocCount(int? minDocCount)
	{
		MinDocCountValue = minDocCount;
		return Self;
	}

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> Missing(Elastic.Clients.Elasticsearch.FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public TermsAggregationDescriptor<TDocument> MissingBucket(bool? missingBucket = true)
	{
		MissingBucketValue = missingBucket;
		return Self;
	}

	public TermsAggregationDescriptor<TDocument> MissingOrder(Elastic.Clients.Elasticsearch.Aggregations.MissingOrder? missingOrder)
	{
		MissingOrderValue = missingOrder;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the sort order of the buckets.<br/>Defaults to sorting by descending document count.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> Order(ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>? order)
	{
		OrderValue = order;
		return Self;
	}

	public TermsAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	/// <summary>
	/// <para>Regulates the certainty a shard has if the term should actually be added to the candidate list or not with respect to the `min_doc_count`.<br/>Terms will only be considered if their local shard frequency within the set is higher than the `shard_min_doc_count`.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> ShardMinDocCount(long? shardMinDocCount)
	{
		ShardMinDocCountValue = shardMinDocCount;
		return Self;
	}

	/// <summary>
	/// <para>The number of candidate terms produced by each shard.<br/>By default, `shard_size` will be automatically estimated based on the number of shards and the `size` parameter.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> ShardSize(int? shardSize)
	{
		ShardSizeValue = shardSize;
		return Self;
	}

	/// <summary>
	/// <para>Set to `true` to return the `doc_count_error_upper_bound`, which is an upper bound to the error on the `doc_count` returned by each shard.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> ShowTermDocCountError(bool? showTermDocCountError = true)
	{
		ShowTermDocCountErrorValue = showTermDocCountError;
		return Self;
	}

	/// <summary>
	/// <para>The number of buckets returned out of the overall terms list.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	/// <summary>
	/// <para>Coerced unmapped fields into the specified type.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> ValueType(string? valueType)
	{
		ValueTypeValue = valueType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (CollectModeValue is not null)
		{
			writer.WritePropertyName("collect_mode");
			JsonSerializer.Serialize(writer, CollectModeValue, options);
		}

		if (ExcludeValue is not null)
		{
			writer.WritePropertyName("exclude");
			JsonSerializer.Serialize(writer, ExcludeValue, options);
		}

		if (ExecutionHintValue is not null)
		{
			writer.WritePropertyName("execution_hint");
			JsonSerializer.Serialize(writer, ExecutionHintValue, options);
		}

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

		if (IncludeValue is not null)
		{
			writer.WritePropertyName("include");
			JsonSerializer.Serialize(writer, IncludeValue, options);
		}

		if (MinDocCountValue.HasValue)
		{
			writer.WritePropertyName("min_doc_count");
			writer.WriteNumberValue(MinDocCountValue.Value);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
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

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			SingleOrManySerializationHelper.Serialize<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>(OrderValue, writer, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (ShardMinDocCountValue.HasValue)
		{
			writer.WritePropertyName("shard_min_doc_count");
			writer.WriteNumberValue(ShardMinDocCountValue.Value);
		}

		if (ShardSizeValue.HasValue)
		{
			writer.WritePropertyName("shard_size");
			writer.WriteNumberValue(ShardSizeValue.Value);
		}

		if (ShowTermDocCountErrorValue.HasValue)
		{
			writer.WritePropertyName("show_term_doc_count_error");
			writer.WriteBooleanValue(ShowTermDocCountErrorValue.Value);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		if (!string.IsNullOrEmpty(ValueTypeValue))
		{
			writer.WritePropertyName("value_type");
			writer.WriteStringValue(ValueTypeValue);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class TermsAggregationDescriptor : SerializableDescriptor<TermsAggregationDescriptor>
{
	internal TermsAggregationDescriptor(Action<TermsAggregationDescriptor> configure) => configure.Invoke(this);

	public TermsAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationCollectMode? CollectModeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.TermsExclude? ExcludeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationExecutionHint? ExecutionHintValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.TermsInclude? IncludeValue { get; set; }
	private int? MinDocCountValue { get; set; }
	private Elastic.Clients.Elasticsearch.FieldValue? MissingValue { get; set; }
	private bool? MissingBucketValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.MissingOrder? MissingOrderValue { get; set; }
	private ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>? OrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }
	private long? ShardMinDocCountValue { get; set; }
	private int? ShardSizeValue { get; set; }
	private bool? ShowTermDocCountErrorValue { get; set; }
	private int? SizeValue { get; set; }
	private string? ValueTypeValue { get; set; }

	/// <summary>
	/// <para>Determines how child aggregations should be calculated: breadth-first or depth-first.</para>
	/// </summary>
	public TermsAggregationDescriptor CollectMode(Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationCollectMode? collectMode)
	{
		CollectModeValue = collectMode;
		return Self;
	}

	/// <summary>
	/// <para>Values to exclude.<br/>Accepts regular expressions and partitions.</para>
	/// </summary>
	public TermsAggregationDescriptor Exclude(Elastic.Clients.Elasticsearch.Aggregations.TermsExclude? exclude)
	{
		ExcludeValue = exclude;
		return Self;
	}

	/// <summary>
	/// <para>Determines whether the aggregation will use field values directly or global ordinals.</para>
	/// </summary>
	public TermsAggregationDescriptor ExecutionHint(Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationExecutionHint? executionHint)
	{
		ExecutionHintValue = executionHint;
		return Self;
	}

	/// <summary>
	/// <para>The field from which to return terms.</para>
	/// </summary>
	public TermsAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field from which to return terms.</para>
	/// </summary>
	public TermsAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field from which to return terms.</para>
	/// </summary>
	public TermsAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TermsAggregationDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	/// <summary>
	/// <para>Values to include.<br/>Accepts regular expressions and partitions.</para>
	/// </summary>
	public TermsAggregationDescriptor Include(Elastic.Clients.Elasticsearch.Aggregations.TermsInclude? include)
	{
		IncludeValue = include;
		return Self;
	}

	/// <summary>
	/// <para>Only return values that are found in more than `min_doc_count` hits.</para>
	/// </summary>
	public TermsAggregationDescriptor MinDocCount(int? minDocCount)
	{
		MinDocCountValue = minDocCount;
		return Self;
	}

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	public TermsAggregationDescriptor Missing(Elastic.Clients.Elasticsearch.FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public TermsAggregationDescriptor MissingBucket(bool? missingBucket = true)
	{
		MissingBucketValue = missingBucket;
		return Self;
	}

	public TermsAggregationDescriptor MissingOrder(Elastic.Clients.Elasticsearch.Aggregations.MissingOrder? missingOrder)
	{
		MissingOrderValue = missingOrder;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the sort order of the buckets.<br/>Defaults to sorting by descending document count.</para>
	/// </summary>
	public TermsAggregationDescriptor Order(ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>? order)
	{
		OrderValue = order;
		return Self;
	}

	public TermsAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	/// <summary>
	/// <para>Regulates the certainty a shard has if the term should actually be added to the candidate list or not with respect to the `min_doc_count`.<br/>Terms will only be considered if their local shard frequency within the set is higher than the `shard_min_doc_count`.</para>
	/// </summary>
	public TermsAggregationDescriptor ShardMinDocCount(long? shardMinDocCount)
	{
		ShardMinDocCountValue = shardMinDocCount;
		return Self;
	}

	/// <summary>
	/// <para>The number of candidate terms produced by each shard.<br/>By default, `shard_size` will be automatically estimated based on the number of shards and the `size` parameter.</para>
	/// </summary>
	public TermsAggregationDescriptor ShardSize(int? shardSize)
	{
		ShardSizeValue = shardSize;
		return Self;
	}

	/// <summary>
	/// <para>Set to `true` to return the `doc_count_error_upper_bound`, which is an upper bound to the error on the `doc_count` returned by each shard.</para>
	/// </summary>
	public TermsAggregationDescriptor ShowTermDocCountError(bool? showTermDocCountError = true)
	{
		ShowTermDocCountErrorValue = showTermDocCountError;
		return Self;
	}

	/// <summary>
	/// <para>The number of buckets returned out of the overall terms list.</para>
	/// </summary>
	public TermsAggregationDescriptor Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	/// <summary>
	/// <para>Coerced unmapped fields into the specified type.</para>
	/// </summary>
	public TermsAggregationDescriptor ValueType(string? valueType)
	{
		ValueTypeValue = valueType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (CollectModeValue is not null)
		{
			writer.WritePropertyName("collect_mode");
			JsonSerializer.Serialize(writer, CollectModeValue, options);
		}

		if (ExcludeValue is not null)
		{
			writer.WritePropertyName("exclude");
			JsonSerializer.Serialize(writer, ExcludeValue, options);
		}

		if (ExecutionHintValue is not null)
		{
			writer.WritePropertyName("execution_hint");
			JsonSerializer.Serialize(writer, ExecutionHintValue, options);
		}

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

		if (IncludeValue is not null)
		{
			writer.WritePropertyName("include");
			JsonSerializer.Serialize(writer, IncludeValue, options);
		}

		if (MinDocCountValue.HasValue)
		{
			writer.WritePropertyName("min_doc_count");
			writer.WriteNumberValue(MinDocCountValue.Value);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
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

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			SingleOrManySerializationHelper.Serialize<KeyValuePair<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.SortOrder>>(OrderValue, writer, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (ShardMinDocCountValue.HasValue)
		{
			writer.WritePropertyName("shard_min_doc_count");
			writer.WriteNumberValue(ShardMinDocCountValue.Value);
		}

		if (ShardSizeValue.HasValue)
		{
			writer.WritePropertyName("shard_size");
			writer.WriteNumberValue(ShardSizeValue.Value);
		}

		if (ShowTermDocCountErrorValue.HasValue)
		{
			writer.WritePropertyName("show_term_doc_count_error");
			writer.WriteBooleanValue(ShowTermDocCountErrorValue.Value);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		if (!string.IsNullOrEmpty(ValueTypeValue))
		{
			writer.WritePropertyName("value_type");
			writer.WriteStringValue(ValueTypeValue);
		}

		writer.WriteEndObject();
	}
}