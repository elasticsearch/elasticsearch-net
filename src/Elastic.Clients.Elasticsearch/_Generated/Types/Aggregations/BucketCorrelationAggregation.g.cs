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

/// <summary>
/// <para>A sibling pipeline aggregation which executes a correlation function on the configured sibling multi-bucket aggregation.</para>
/// </summary>
public sealed partial class BucketCorrelationAggregation
{
	/// <summary>
	/// <para>Path to the buckets that contain one set of values to correlate.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("buckets_path")]
	public Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPath { get; set; }

	/// <summary>
	/// <para>The correlation function to execute.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("function")]
	public Elastic.Clients.Elasticsearch.Aggregations.BucketCorrelationFunction Function { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Aggregations.Aggregation(BucketCorrelationAggregation bucketCorrelationAggregation) => Elastic.Clients.Elasticsearch.Aggregations.Aggregation.BucketCorrelation(bucketCorrelationAggregation);
}

/// <summary>
/// <para>A sibling pipeline aggregation which executes a correlation function on the configured sibling multi-bucket aggregation.</para>
/// </summary>
public sealed partial class BucketCorrelationAggregationDescriptor : SerializableDescriptor<BucketCorrelationAggregationDescriptor>
{
	internal BucketCorrelationAggregationDescriptor(Action<BucketCorrelationAggregationDescriptor> configure) => configure.Invoke(this);

	public BucketCorrelationAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPathValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.BucketCorrelationFunction FunctionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.BucketCorrelationFunctionDescriptor FunctionDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.BucketCorrelationFunctionDescriptor> FunctionDescriptorAction { get; set; }

	/// <summary>
	/// <para>Path to the buckets that contain one set of values to correlate.</para>
	/// </summary>
	public BucketCorrelationAggregationDescriptor BucketsPath(Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? bucketsPath)
	{
		BucketsPathValue = bucketsPath;
		return Self;
	}

	/// <summary>
	/// <para>The correlation function to execute.</para>
	/// </summary>
	public BucketCorrelationAggregationDescriptor Function(Elastic.Clients.Elasticsearch.Aggregations.BucketCorrelationFunction function)
	{
		FunctionDescriptor = null;
		FunctionDescriptorAction = null;
		FunctionValue = function;
		return Self;
	}

	public BucketCorrelationAggregationDescriptor Function(Elastic.Clients.Elasticsearch.Aggregations.BucketCorrelationFunctionDescriptor descriptor)
	{
		FunctionValue = null;
		FunctionDescriptorAction = null;
		FunctionDescriptor = descriptor;
		return Self;
	}

	public BucketCorrelationAggregationDescriptor Function(Action<Elastic.Clients.Elasticsearch.Aggregations.BucketCorrelationFunctionDescriptor> configure)
	{
		FunctionValue = null;
		FunctionDescriptor = null;
		FunctionDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BucketsPathValue is not null)
		{
			writer.WritePropertyName("buckets_path");
			JsonSerializer.Serialize(writer, BucketsPathValue, options);
		}

		if (FunctionDescriptor is not null)
		{
			writer.WritePropertyName("function");
			JsonSerializer.Serialize(writer, FunctionDescriptor, options);
		}
		else if (FunctionDescriptorAction is not null)
		{
			writer.WritePropertyName("function");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.BucketCorrelationFunctionDescriptor(FunctionDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("function");
			JsonSerializer.Serialize(writer, FunctionValue, options);
		}

		writer.WriteEndObject();
	}
}