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

namespace Elastic.Clients.Elasticsearch.Serverless.Core.RankEval;

/// <summary>
/// <para>Precision at K (P@k)</para>
/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/search-rank-eval.html#k-precision">Learn more about this API in the Elasticsearch documentation.</see></para>
/// </summary>
public sealed partial class RankEvalMetricPrecision
{
	/// <summary>
	/// <para>Controls how unlabeled documents in the search results are counted. If set to true, unlabeled documents are ignored and neither count as relevant or irrelevant. Set to false (the default), they are treated as irrelevant.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ignore_unlabeled")]
	public bool? IgnoreUnlabeled { get; set; }

	/// <summary>
	/// <para>Sets the maximum number of documents retrieved per query. This value will act in place of the usual size parameter in the query.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("k")]
	public int? k { get; set; }

	/// <summary>
	/// <para>Sets the rating threshold above which documents are considered to be "relevant".</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("relevant_rating_threshold")]
	public int? RelevantRatingThreshold { get; set; }
}

/// <summary>
/// <para>Precision at K (P@k)</para>
/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/search-rank-eval.html#k-precision">Learn more about this API in the Elasticsearch documentation.</see></para>
/// </summary>
public sealed partial class RankEvalMetricPrecisionDescriptor : SerializableDescriptor<RankEvalMetricPrecisionDescriptor>
{
	internal RankEvalMetricPrecisionDescriptor(Action<RankEvalMetricPrecisionDescriptor> configure) => configure.Invoke(this);

	public RankEvalMetricPrecisionDescriptor() : base()
	{
	}

	private bool? IgnoreUnlabeledValue { get; set; }
	private int? kValue { get; set; }
	private int? RelevantRatingThresholdValue { get; set; }

	/// <summary>
	/// <para>Controls how unlabeled documents in the search results are counted. If set to true, unlabeled documents are ignored and neither count as relevant or irrelevant. Set to false (the default), they are treated as irrelevant.</para>
	/// </summary>
	public RankEvalMetricPrecisionDescriptor IgnoreUnlabeled(bool? ignoreUnlabeled = true)
	{
		IgnoreUnlabeledValue = ignoreUnlabeled;
		return Self;
	}

	/// <summary>
	/// <para>Sets the maximum number of documents retrieved per query. This value will act in place of the usual size parameter in the query.</para>
	/// </summary>
	public RankEvalMetricPrecisionDescriptor k(int? k)
	{
		kValue = k;
		return Self;
	}

	/// <summary>
	/// <para>Sets the rating threshold above which documents are considered to be "relevant".</para>
	/// </summary>
	public RankEvalMetricPrecisionDescriptor RelevantRatingThreshold(int? relevantRatingThreshold)
	{
		RelevantRatingThresholdValue = relevantRatingThreshold;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IgnoreUnlabeledValue.HasValue)
		{
			writer.WritePropertyName("ignore_unlabeled");
			writer.WriteBooleanValue(IgnoreUnlabeledValue.Value);
		}

		if (kValue.HasValue)
		{
			writer.WritePropertyName("k");
			writer.WriteNumberValue(kValue.Value);
		}

		if (RelevantRatingThresholdValue.HasValue)
		{
			writer.WritePropertyName("relevant_rating_threshold");
			writer.WriteNumberValue(RelevantRatingThresholdValue.Value);
		}

		writer.WriteEndObject();
	}
}