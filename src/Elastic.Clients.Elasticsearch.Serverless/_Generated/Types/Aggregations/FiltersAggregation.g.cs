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

internal sealed class FiltersAggregationConverter : JsonConverter<FiltersAggregation>
{
	public override FiltersAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "filters")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new FiltersAggregation(aggName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("filters"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Aggregations.Buckets<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query>?>(ref reader, options);
					if (value is not null)
					{
						agg.Filters = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("other_bucket"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<bool?>(ref reader, options);
					if (value is not null)
					{
						agg.OtherBucket = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("other_bucket_key"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<string?>(ref reader, options);
					if (value is not null)
					{
						agg.OtherBucketKey = value;
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

	public override void Write(Utf8JsonWriter writer, FiltersAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("filters");
		writer.WriteStartObject();
		if (value.Filters is not null)
		{
			writer.WritePropertyName("filters");
			JsonSerializer.Serialize(writer, value.Filters, options);
		}

		if (value.OtherBucket.HasValue)
		{
			writer.WritePropertyName("other_bucket");
			writer.WriteBooleanValue(value.OtherBucket.Value);
		}

		if (!string.IsNullOrEmpty(value.OtherBucketKey))
		{
			writer.WritePropertyName("other_bucket_key");
			writer.WriteStringValue(value.OtherBucketKey);
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

[JsonConverter(typeof(FiltersAggregationConverter))]
public sealed partial class FiltersAggregation : SearchAggregation
{
	public FiltersAggregation(string name) => Name = name;

	internal FiltersAggregation()
	{
	}

	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDictionary? Aggregations { get; set; }

	/// <summary>
	/// <para>Collection of queries from which to build buckets.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.Buckets<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query>? Filters { get; set; }
	public IDictionary<string, object>? Meta { get; set; }
	override public string? Name { get; internal set; }

	/// <summary>
	/// <para>Set to `true` to add a bucket to the response which will contain all documents that do not match any of the given filters.</para>
	/// </summary>
	public bool? OtherBucket { get; set; }

	/// <summary>
	/// <para>The key with which the other bucket is returned.</para>
	/// </summary>
	public string? OtherBucketKey { get; set; }
}

public sealed partial class FiltersAggregationDescriptor<TDocument> : SerializableDescriptor<FiltersAggregationDescriptor<TDocument>>
{
	internal FiltersAggregationDescriptor(Action<FiltersAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public FiltersAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDictionary? AggregationsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor<TDocument> AggregationsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor<TDocument>> AggregationsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.Buckets<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query>? FiltersValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private bool? OtherBucketValue { get; set; }
	private string? OtherBucketKeyValue { get; set; }

	public FiltersAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDictionary? aggregations)
	{
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = null;
		AggregationsValue = aggregations;
		return Self;
	}

	public FiltersAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor<TDocument> descriptor)
	{
		AggregationsValue = null;
		AggregationsDescriptorAction = null;
		AggregationsDescriptor = descriptor;
		return Self;
	}

	public FiltersAggregationDescriptor<TDocument> Aggregations(Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor<TDocument>> configure)
	{
		AggregationsValue = null;
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Collection of queries from which to build buckets.</para>
	/// </summary>
	public FiltersAggregationDescriptor<TDocument> Filters(Elastic.Clients.Elasticsearch.Serverless.Aggregations.Buckets<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query>? filters)
	{
		FiltersValue = filters;
		return Self;
	}

	public FiltersAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>Set to `true` to add a bucket to the response which will contain all documents that do not match any of the given filters.</para>
	/// </summary>
	public FiltersAggregationDescriptor<TDocument> OtherBucket(bool? otherBucket = true)
	{
		OtherBucketValue = otherBucket;
		return Self;
	}

	/// <summary>
	/// <para>The key with which the other bucket is returned.</para>
	/// </summary>
	public FiltersAggregationDescriptor<TDocument> OtherBucketKey(string? otherBucketKey)
	{
		OtherBucketKeyValue = otherBucketKey;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("filters");
		writer.WriteStartObject();
		if (FiltersValue is not null)
		{
			writer.WritePropertyName("filters");
			JsonSerializer.Serialize(writer, FiltersValue, options);
		}

		if (OtherBucketValue.HasValue)
		{
			writer.WritePropertyName("other_bucket");
			writer.WriteBooleanValue(OtherBucketValue.Value);
		}

		if (!string.IsNullOrEmpty(OtherBucketKeyValue))
		{
			writer.WritePropertyName("other_bucket_key");
			writer.WriteStringValue(OtherBucketKeyValue);
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

public sealed partial class FiltersAggregationDescriptor : SerializableDescriptor<FiltersAggregationDescriptor>
{
	internal FiltersAggregationDescriptor(Action<FiltersAggregationDescriptor> configure) => configure.Invoke(this);

	public FiltersAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDictionary? AggregationsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor AggregationsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor> AggregationsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.Buckets<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query>? FiltersValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private bool? OtherBucketValue { get; set; }
	private string? OtherBucketKeyValue { get; set; }

	public FiltersAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDictionary? aggregations)
	{
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = null;
		AggregationsValue = aggregations;
		return Self;
	}

	public FiltersAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor descriptor)
	{
		AggregationsValue = null;
		AggregationsDescriptorAction = null;
		AggregationsDescriptor = descriptor;
		return Self;
	}

	public FiltersAggregationDescriptor Aggregations(Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor> configure)
	{
		AggregationsValue = null;
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Collection of queries from which to build buckets.</para>
	/// </summary>
	public FiltersAggregationDescriptor Filters(Elastic.Clients.Elasticsearch.Serverless.Aggregations.Buckets<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query>? filters)
	{
		FiltersValue = filters;
		return Self;
	}

	public FiltersAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>Set to `true` to add a bucket to the response which will contain all documents that do not match any of the given filters.</para>
	/// </summary>
	public FiltersAggregationDescriptor OtherBucket(bool? otherBucket = true)
	{
		OtherBucketValue = otherBucket;
		return Self;
	}

	/// <summary>
	/// <para>The key with which the other bucket is returned.</para>
	/// </summary>
	public FiltersAggregationDescriptor OtherBucketKey(string? otherBucketKey)
	{
		OtherBucketKeyValue = otherBucketKey;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("filters");
		writer.WriteStartObject();
		if (FiltersValue is not null)
		{
			writer.WritePropertyName("filters");
			JsonSerializer.Serialize(writer, FiltersValue, options);
		}

		if (OtherBucketValue.HasValue)
		{
			writer.WritePropertyName("other_bucket");
			writer.WriteBooleanValue(OtherBucketValue.Value);
		}

		if (!string.IsNullOrEmpty(OtherBucketKeyValue))
		{
			writer.WritePropertyName("other_bucket_key");
			writer.WriteStringValue(OtherBucketKeyValue);
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