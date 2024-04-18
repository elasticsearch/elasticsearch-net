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
/// <para>A sibling pipeline aggregation which executes a two sample Kolmogorov–Smirnov test (referred<br/>to as a "K-S test" from now on) against a provided distribution, and the distribution implied<br/>by the documents counts in the configured sibling aggregation. Specifically, for some metric,<br/>assuming that the percentile intervals of the metric are known beforehand or have been computed<br/>by an aggregation, then one would use range aggregation for the sibling to compute the p-value<br/>of the distribution difference between the metric and the restriction of that metric to a subset<br/>of the documents. A natural use case is if the sibling aggregation range aggregation nested in a<br/>terms aggregation, in which case one compares the overall distribution of metric to its restriction<br/>to each term.</para>
/// </summary>
public sealed partial class BucketKsAggregation
{
	/// <summary>
	/// <para>A list of string values indicating which K-S test alternative to calculate. The valid values<br/>are: "greater", "less", "two_sided". This parameter is key for determining the K-S statistic used<br/>when calculating the K-S test. Default value is all possible alternative hypotheses.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("alternative")]
	public ICollection<string>? Alternative { get; set; }

	/// <summary>
	/// <para>Path to the buckets that contain one set of values to correlate.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("buckets_path")]
	public Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPath { get; set; }

	/// <summary>
	/// <para>A list of doubles indicating the distribution of the samples with which to compare to the `buckets_path` results.<br/>In typical usage this is the overall proportion of documents in each bucket, which is compared with the actual<br/>document proportions in each bucket from the sibling aggregation counts. The default is to assume that overall<br/>documents are uniformly distributed on these buckets, which they would be if one used equal percentiles of a<br/>metric to define the bucket end points.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fractions")]
	public ICollection<double>? Fractions { get; set; }

	/// <summary>
	/// <para>Indicates the sampling methodology when calculating the K-S test. Note, this is sampling of the returned values.<br/>This determines the cumulative distribution function (CDF) points used comparing the two samples. Default is<br/>`upper_tail`, which emphasizes the upper end of the CDF points. Valid options are: `upper_tail`, `uniform`,<br/>and `lower_tail`.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("sampling_method")]
	public string? SamplingMethod { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Aggregations.Aggregation(BucketKsAggregation bucketKsAggregation) => Elastic.Clients.Elasticsearch.Aggregations.Aggregation.BucketCountKsTest(bucketKsAggregation);
}

/// <summary>
/// <para>A sibling pipeline aggregation which executes a two sample Kolmogorov–Smirnov test (referred<br/>to as a "K-S test" from now on) against a provided distribution, and the distribution implied<br/>by the documents counts in the configured sibling aggregation. Specifically, for some metric,<br/>assuming that the percentile intervals of the metric are known beforehand or have been computed<br/>by an aggregation, then one would use range aggregation for the sibling to compute the p-value<br/>of the distribution difference between the metric and the restriction of that metric to a subset<br/>of the documents. A natural use case is if the sibling aggregation range aggregation nested in a<br/>terms aggregation, in which case one compares the overall distribution of metric to its restriction<br/>to each term.</para>
/// </summary>
public sealed partial class BucketKsAggregationDescriptor : SerializableDescriptor<BucketKsAggregationDescriptor>
{
	internal BucketKsAggregationDescriptor(Action<BucketKsAggregationDescriptor> configure) => configure.Invoke(this);

	public BucketKsAggregationDescriptor() : base()
	{
	}

	private ICollection<string>? AlternativeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPathValue { get; set; }
	private ICollection<double>? FractionsValue { get; set; }
	private string? SamplingMethodValue { get; set; }

	/// <summary>
	/// <para>A list of string values indicating which K-S test alternative to calculate. The valid values<br/>are: "greater", "less", "two_sided". This parameter is key for determining the K-S statistic used<br/>when calculating the K-S test. Default value is all possible alternative hypotheses.</para>
	/// </summary>
	public BucketKsAggregationDescriptor Alternative(ICollection<string>? alternative)
	{
		AlternativeValue = alternative;
		return Self;
	}

	/// <summary>
	/// <para>Path to the buckets that contain one set of values to correlate.</para>
	/// </summary>
	public BucketKsAggregationDescriptor BucketsPath(Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? bucketsPath)
	{
		BucketsPathValue = bucketsPath;
		return Self;
	}

	/// <summary>
	/// <para>A list of doubles indicating the distribution of the samples with which to compare to the `buckets_path` results.<br/>In typical usage this is the overall proportion of documents in each bucket, which is compared with the actual<br/>document proportions in each bucket from the sibling aggregation counts. The default is to assume that overall<br/>documents are uniformly distributed on these buckets, which they would be if one used equal percentiles of a<br/>metric to define the bucket end points.</para>
	/// </summary>
	public BucketKsAggregationDescriptor Fractions(ICollection<double>? fractions)
	{
		FractionsValue = fractions;
		return Self;
	}

	/// <summary>
	/// <para>Indicates the sampling methodology when calculating the K-S test. Note, this is sampling of the returned values.<br/>This determines the cumulative distribution function (CDF) points used comparing the two samples. Default is<br/>`upper_tail`, which emphasizes the upper end of the CDF points. Valid options are: `upper_tail`, `uniform`,<br/>and `lower_tail`.</para>
	/// </summary>
	public BucketKsAggregationDescriptor SamplingMethod(string? samplingMethod)
	{
		SamplingMethodValue = samplingMethod;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AlternativeValue is not null)
		{
			writer.WritePropertyName("alternative");
			JsonSerializer.Serialize(writer, AlternativeValue, options);
		}

		if (BucketsPathValue is not null)
		{
			writer.WritePropertyName("buckets_path");
			JsonSerializer.Serialize(writer, BucketsPathValue, options);
		}

		if (FractionsValue is not null)
		{
			writer.WritePropertyName("fractions");
			JsonSerializer.Serialize(writer, FractionsValue, options);
		}

		if (!string.IsNullOrEmpty(SamplingMethodValue))
		{
			writer.WritePropertyName("sampling_method");
			writer.WriteStringValue(SamplingMethodValue);
		}

		writer.WriteEndObject();
	}
}