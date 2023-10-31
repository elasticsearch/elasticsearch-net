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

internal sealed class TermsAggregationConverter : JsonConverter<TermsAggregation>
{
	public override TermsAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "terms")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new TermsAggregation(aggName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("collect_mode"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsAggregationCollectMode?>(ref reader, options);
					if (value is not null)
					{
						agg.CollectMode = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("exclude"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsExclude?>(ref reader, options);
					if (value is not null)
					{
						agg.Exclude = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("execution_hint"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsAggregationExecutionHint?>(ref reader, options);
					if (value is not null)
					{
						agg.ExecutionHint = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("field"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Field?>(ref reader, options);
					if (value is not null)
					{
						agg.Field = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("format"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<string?>(ref reader, options);
					if (value is not null)
					{
						agg.Format = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("include"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsInclude?>(ref reader, options);
					if (value is not null)
					{
						agg.Include = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("min_doc_count"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<int?>(ref reader, options);
					if (value is not null)
					{
						agg.MinDocCount = value;
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

				if (reader.ValueTextEquals("missing_bucket"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<bool?>(ref reader, options);
					if (value is not null)
					{
						agg.MissingBucket = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("missing_order"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Aggregations.MissingOrder?>(ref reader, options);
					if (value is not null)
					{
						agg.MissingOrder = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("order"))
				{
					reader.Read();
					var value = SingleOrManySerializationHelper.Deserialize<KeyValuePair<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.SortOrder>>(ref reader, options);
					if (value is not null)
					{
						agg.Order = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("script"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Script?>(ref reader, options);
					if (value is not null)
					{
						agg.Script = value;
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

				if (reader.ValueTextEquals("show_term_doc_count_error"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<bool?>(ref reader, options);
					if (value is not null)
					{
						agg.ShowTermDocCountError = value;
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

				if (reader.ValueTextEquals("value_type"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<string?>(ref reader, options);
					if (value is not null)
					{
						agg.ValueType = value;
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

	public override void Write(Utf8JsonWriter writer, TermsAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("terms");
		writer.WriteStartObject();
		if (value.CollectMode is not null)
		{
			writer.WritePropertyName("collect_mode");
			JsonSerializer.Serialize(writer, value.CollectMode, options);
		}

		if (value.Exclude is not null)
		{
			writer.WritePropertyName("exclude");
			JsonSerializer.Serialize(writer, value.Exclude, options);
		}

		if (value.ExecutionHint is not null)
		{
			writer.WritePropertyName("execution_hint");
			JsonSerializer.Serialize(writer, value.ExecutionHint, options);
		}

		if (value.Field is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, value.Field, options);
		}

		if (!string.IsNullOrEmpty(value.Format))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(value.Format);
		}

		if (value.Include is not null)
		{
			writer.WritePropertyName("include");
			JsonSerializer.Serialize(writer, value.Include, options);
		}

		if (value.MinDocCount.HasValue)
		{
			writer.WritePropertyName("min_doc_count");
			writer.WriteNumberValue(value.MinDocCount.Value);
		}

		if (value.Missing is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, value.Missing, options);
		}

		if (value.MissingBucket.HasValue)
		{
			writer.WritePropertyName("missing_bucket");
			writer.WriteBooleanValue(value.MissingBucket.Value);
		}

		if (value.MissingOrder is not null)
		{
			writer.WritePropertyName("missing_order");
			JsonSerializer.Serialize(writer, value.MissingOrder, options);
		}

		if (value.Order is not null)
		{
			writer.WritePropertyName("order");
			SingleOrManySerializationHelper.Serialize<KeyValuePair<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.SortOrder>>(value.Order, writer, options);
		}

		if (value.Script is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, value.Script, options);
		}

		if (value.ShardSize.HasValue)
		{
			writer.WritePropertyName("shard_size");
			writer.WriteNumberValue(value.ShardSize.Value);
		}

		if (value.ShowTermDocCountError.HasValue)
		{
			writer.WritePropertyName("show_term_doc_count_error");
			writer.WriteBooleanValue(value.ShowTermDocCountError.Value);
		}

		if (value.Size.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(value.Size.Value);
		}

		if (!string.IsNullOrEmpty(value.ValueType))
		{
			writer.WritePropertyName("value_type");
			writer.WriteStringValue(value.ValueType);
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

[JsonConverter(typeof(TermsAggregationConverter))]
public sealed partial class TermsAggregation : SearchAggregation
{
	public TermsAggregation(string name) => Name = name;

	internal TermsAggregation()
	{
	}

	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDictionary? Aggregations { get; set; }

	/// <summary>
	/// <para>Determines how child aggregations should be calculated: breadth-first or depth-first.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsAggregationCollectMode? CollectMode { get; set; }

	/// <summary>
	/// <para>Values to exclude.<br/>Accepts regular expressions and partitions.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsExclude? Exclude { get; set; }

	/// <summary>
	/// <para>Determines whether the aggregation will use field values directly or global ordinals.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsAggregationExecutionHint? ExecutionHint { get; set; }

	/// <summary>
	/// <para>The field from which to return terms.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Field? Field { get; set; }
	public string? Format { get; set; }

	/// <summary>
	/// <para>Values to include.<br/>Accepts regular expressions and partitions.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsInclude? Include { get; set; }
	public IDictionary<string, object>? Meta { get; set; }

	/// <summary>
	/// <para>Only return values that are found in more than `min_doc_count` hits.</para>
	/// </summary>
	public int? MinDocCount { get; set; }

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	public FieldValue? Missing { get; set; }
	public bool? MissingBucket { get; set; }
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.MissingOrder? MissingOrder { get; set; }
	override public string? Name { get; internal set; }
	[JsonConverter(typeof(AggregateOrderConverter))]
	/// <summary>
	/// <para>Specifies the sort order of the buckets.<br/>Defaults to sorting by descending document count.</para>
	/// </summary>
	public ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.SortOrder>>? Order { get; set; }
	public Elastic.Clients.Elasticsearch.Serverless.Script? Script { get; set; }

	/// <summary>
	/// <para>The number of candidate terms produced by each shard.<br/>By default, `shard_size` will be automatically estimated based on the number of shards and the `size` parameter.</para>
	/// </summary>
	public int? ShardSize { get; set; }

	/// <summary>
	/// <para>Set to `true` to return the `doc_count_error_upper_bound`, which is an upper bound to the error on the `doc_count` returned by each shard.</para>
	/// </summary>
	public bool? ShowTermDocCountError { get; set; }

	/// <summary>
	/// <para>The number of buckets returned out of the overall terms list.</para>
	/// </summary>
	public int? Size { get; set; }

	/// <summary>
	/// <para>Coerced unmapped fields into the specified type.</para>
	/// </summary>
	public string? ValueType { get; set; }
}

public sealed partial class TermsAggregationDescriptor<TDocument> : SerializableDescriptor<TermsAggregationDescriptor<TDocument>>
{
	internal TermsAggregationDescriptor(Action<TermsAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public TermsAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDictionary? AggregationsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor<TDocument> AggregationsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor<TDocument>> AggregationsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsAggregationCollectMode? CollectModeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsExclude? ExcludeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsAggregationExecutionHint? ExecutionHintValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? FieldValue { get; set; }
	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsInclude? IncludeValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private int? MinDocCountValue { get; set; }
	private FieldValue? MissingValue { get; set; }
	private bool? MissingBucketValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.MissingOrder? MissingOrderValue { get; set; }
	private ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.SortOrder>>? OrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Script? ScriptValue { get; set; }
	private int? ShardSizeValue { get; set; }
	private bool? ShowTermDocCountErrorValue { get; set; }
	private int? SizeValue { get; set; }
	private string? ValueTypeValue { get; set; }

	public TermsAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDictionary? aggregations)
	{
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = null;
		AggregationsValue = aggregations;
		return Self;
	}

	public TermsAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor<TDocument> descriptor)
	{
		AggregationsValue = null;
		AggregationsDescriptorAction = null;
		AggregationsDescriptor = descriptor;
		return Self;
	}

	public TermsAggregationDescriptor<TDocument> Aggregations(Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor<TDocument>> configure)
	{
		AggregationsValue = null;
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Determines how child aggregations should be calculated: breadth-first or depth-first.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> CollectMode(Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsAggregationCollectMode? collectMode)
	{
		CollectModeValue = collectMode;
		return Self;
	}

	/// <summary>
	/// <para>Values to exclude.<br/>Accepts regular expressions and partitions.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> Exclude(Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsExclude? exclude)
	{
		ExcludeValue = exclude;
		return Self;
	}

	/// <summary>
	/// <para>Determines whether the aggregation will use field values directly or global ordinals.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> ExecutionHint(Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsAggregationExecutionHint? executionHint)
	{
		ExecutionHintValue = executionHint;
		return Self;
	}

	/// <summary>
	/// <para>The field from which to return terms.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field? field)
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

	public TermsAggregationDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	/// <summary>
	/// <para>Values to include.<br/>Accepts regular expressions and partitions.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> Include(Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsInclude? include)
	{
		IncludeValue = include;
		return Self;
	}

	public TermsAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
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
	public TermsAggregationDescriptor<TDocument> Missing(FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public TermsAggregationDescriptor<TDocument> MissingBucket(bool? missingBucket = true)
	{
		MissingBucketValue = missingBucket;
		return Self;
	}

	public TermsAggregationDescriptor<TDocument> MissingOrder(Elastic.Clients.Elasticsearch.Serverless.Aggregations.MissingOrder? missingOrder)
	{
		MissingOrderValue = missingOrder;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the sort order of the buckets.<br/>Defaults to sorting by descending document count.</para>
	/// </summary>
	public TermsAggregationDescriptor<TDocument> Order(ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.SortOrder>>? order)
	{
		OrderValue = order;
		return Self;
	}

	public TermsAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Serverless.Script? script)
	{
		ScriptValue = script;
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
		writer.WritePropertyName("terms");
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
			SingleOrManySerializationHelper.Serialize<KeyValuePair<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.SortOrder>>(OrderValue, writer, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
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

public sealed partial class TermsAggregationDescriptor : SerializableDescriptor<TermsAggregationDescriptor>
{
	internal TermsAggregationDescriptor(Action<TermsAggregationDescriptor> configure) => configure.Invoke(this);

	public TermsAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDictionary? AggregationsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor AggregationsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor> AggregationsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsAggregationCollectMode? CollectModeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsExclude? ExcludeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsAggregationExecutionHint? ExecutionHintValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? FieldValue { get; set; }
	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsInclude? IncludeValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private int? MinDocCountValue { get; set; }
	private FieldValue? MissingValue { get; set; }
	private bool? MissingBucketValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.MissingOrder? MissingOrderValue { get; set; }
	private ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.SortOrder>>? OrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Script? ScriptValue { get; set; }
	private int? ShardSizeValue { get; set; }
	private bool? ShowTermDocCountErrorValue { get; set; }
	private int? SizeValue { get; set; }
	private string? ValueTypeValue { get; set; }

	public TermsAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDictionary? aggregations)
	{
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = null;
		AggregationsValue = aggregations;
		return Self;
	}

	public TermsAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor descriptor)
	{
		AggregationsValue = null;
		AggregationsDescriptorAction = null;
		AggregationsDescriptor = descriptor;
		return Self;
	}

	public TermsAggregationDescriptor Aggregations(Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor> configure)
	{
		AggregationsValue = null;
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Determines how child aggregations should be calculated: breadth-first or depth-first.</para>
	/// </summary>
	public TermsAggregationDescriptor CollectMode(Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsAggregationCollectMode? collectMode)
	{
		CollectModeValue = collectMode;
		return Self;
	}

	/// <summary>
	/// <para>Values to exclude.<br/>Accepts regular expressions and partitions.</para>
	/// </summary>
	public TermsAggregationDescriptor Exclude(Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsExclude? exclude)
	{
		ExcludeValue = exclude;
		return Self;
	}

	/// <summary>
	/// <para>Determines whether the aggregation will use field values directly or global ordinals.</para>
	/// </summary>
	public TermsAggregationDescriptor ExecutionHint(Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsAggregationExecutionHint? executionHint)
	{
		ExecutionHintValue = executionHint;
		return Self;
	}

	/// <summary>
	/// <para>The field from which to return terms.</para>
	/// </summary>
	public TermsAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field? field)
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
	public TermsAggregationDescriptor Include(Elastic.Clients.Elasticsearch.Serverless.Aggregations.TermsInclude? include)
	{
		IncludeValue = include;
		return Self;
	}

	public TermsAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
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
	public TermsAggregationDescriptor Missing(FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public TermsAggregationDescriptor MissingBucket(bool? missingBucket = true)
	{
		MissingBucketValue = missingBucket;
		return Self;
	}

	public TermsAggregationDescriptor MissingOrder(Elastic.Clients.Elasticsearch.Serverless.Aggregations.MissingOrder? missingOrder)
	{
		MissingOrderValue = missingOrder;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the sort order of the buckets.<br/>Defaults to sorting by descending document count.</para>
	/// </summary>
	public TermsAggregationDescriptor Order(ICollection<KeyValuePair<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.SortOrder>>? order)
	{
		OrderValue = order;
		return Self;
	}

	public TermsAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Serverless.Script? script)
	{
		ScriptValue = script;
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
		writer.WritePropertyName("terms");
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
			SingleOrManySerializationHelper.Serialize<KeyValuePair<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.SortOrder>>(OrderValue, writer, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
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