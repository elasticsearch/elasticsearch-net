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

public sealed partial class ExtendedStatsBucketAggregation
{
	/// <summary>
	/// <para>Path to the buckets that contain one set of values to correlate.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("buckets_path")]
	public Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPath { get; set; }

	/// <summary>
	/// <para>`DecimalFormat` pattern for the output value.<br/>If specified, the formatted value is returned in the aggregation’s `value_as_string` property.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("format")]
	public string? Format { get; set; }

	/// <summary>
	/// <para>Policy to apply when gaps are found in the data.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("gap_policy")]
	public Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicy { get; set; }
	[JsonInclude, JsonPropertyName("meta")]
	public IDictionary<string, object>? Meta { get; set; }
	[JsonInclude, JsonPropertyName("name")]
	public string? Name { get; set; }

	/// <summary>
	/// <para>The number of standard deviations above/below the mean to display.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("sigma")]
	public double? Sigma { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Aggregations.Aggregation(ExtendedStatsBucketAggregation extendedStatsBucketAggregation) => Elastic.Clients.Elasticsearch.Aggregations.Aggregation.ExtendedStatsBucket(extendedStatsBucketAggregation);
}

public sealed partial class ExtendedStatsBucketAggregationDescriptor : SerializableDescriptor<ExtendedStatsBucketAggregationDescriptor>
{
	internal ExtendedStatsBucketAggregationDescriptor(Action<ExtendedStatsBucketAggregationDescriptor> configure) => configure.Invoke(this);

	public ExtendedStatsBucketAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPathValue { get; set; }
	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicyValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private string? NameValue { get; set; }
	private double? SigmaValue { get; set; }

	/// <summary>
	/// <para>Path to the buckets that contain one set of values to correlate.</para>
	/// </summary>
	public ExtendedStatsBucketAggregationDescriptor BucketsPath(Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? bucketsPath)
	{
		BucketsPathValue = bucketsPath;
		return Self;
	}

	/// <summary>
	/// <para>`DecimalFormat` pattern for the output value.<br/>If specified, the formatted value is returned in the aggregation’s `value_as_string` property.</para>
	/// </summary>
	public ExtendedStatsBucketAggregationDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	/// <summary>
	/// <para>Policy to apply when gaps are found in the data.</para>
	/// </summary>
	public ExtendedStatsBucketAggregationDescriptor GapPolicy(Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? gapPolicy)
	{
		GapPolicyValue = gapPolicy;
		return Self;
	}

	public ExtendedStatsBucketAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public ExtendedStatsBucketAggregationDescriptor Name(string? name)
	{
		NameValue = name;
		return Self;
	}

	/// <summary>
	/// <para>The number of standard deviations above/below the mean to display.</para>
	/// </summary>
	public ExtendedStatsBucketAggregationDescriptor Sigma(double? sigma)
	{
		SigmaValue = sigma;
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

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (GapPolicyValue is not null)
		{
			writer.WritePropertyName("gap_policy");
			JsonSerializer.Serialize(writer, GapPolicyValue, options);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (!string.IsNullOrEmpty(NameValue))
		{
			writer.WritePropertyName("name");
			writer.WriteStringValue(NameValue);
		}

		if (SigmaValue.HasValue)
		{
			writer.WritePropertyName("sigma");
			writer.WriteNumberValue(SigmaValue.Value);
		}

		writer.WriteEndObject();
	}
}