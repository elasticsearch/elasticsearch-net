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

namespace Elastic.Clients.Elasticsearch.Core.RankEval;

/// <summary>
/// <para>
/// Discounted cumulative gain (DCG)
/// </para>
/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.15/search-rank-eval.html#_discounted_cumulative_gain_dcg">Learn more about this API in the Elasticsearch documentation.</see></para>
/// </summary>
public sealed partial class RankEvalMetricDiscountedCumulativeGain
{
	/// <summary>
	/// <para>
	/// Sets the maximum number of documents retrieved per query. This value will act in place of the usual size parameter in the query.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("k")]
	public int? k { get; set; }

	/// <summary>
	/// <para>
	/// If set to true, this metric will calculate the Normalized DCG.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("normalize")]
	public bool? Normalize { get; set; }
}

/// <summary>
/// <para>
/// Discounted cumulative gain (DCG)
/// </para>
/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.15/search-rank-eval.html#_discounted_cumulative_gain_dcg">Learn more about this API in the Elasticsearch documentation.</see></para>
/// </summary>
public sealed partial class RankEvalMetricDiscountedCumulativeGainDescriptor : SerializableDescriptor<RankEvalMetricDiscountedCumulativeGainDescriptor>
{
	internal RankEvalMetricDiscountedCumulativeGainDescriptor(Action<RankEvalMetricDiscountedCumulativeGainDescriptor> configure) => configure.Invoke(this);

	public RankEvalMetricDiscountedCumulativeGainDescriptor() : base()
	{
	}

	private int? kValue { get; set; }
	private bool? NormalizeValue { get; set; }

	/// <summary>
	/// <para>
	/// Sets the maximum number of documents retrieved per query. This value will act in place of the usual size parameter in the query.
	/// </para>
	/// </summary>
	public RankEvalMetricDiscountedCumulativeGainDescriptor k(int? k)
	{
		kValue = k;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If set to true, this metric will calculate the Normalized DCG.
	/// </para>
	/// </summary>
	public RankEvalMetricDiscountedCumulativeGainDescriptor Normalize(bool? normalize = true)
	{
		NormalizeValue = normalize;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (kValue.HasValue)
		{
			writer.WritePropertyName("k");
			writer.WriteNumberValue(kValue.Value);
		}

		if (NormalizeValue.HasValue)
		{
			writer.WritePropertyName("normalize");
			writer.WriteBooleanValue(NormalizeValue.Value);
		}

		writer.WriteEndObject();
	}
}