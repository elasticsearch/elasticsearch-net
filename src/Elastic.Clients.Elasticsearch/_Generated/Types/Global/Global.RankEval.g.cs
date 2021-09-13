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

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Global.RankEval
{
	public partial class DocumentRating
	{
		[JsonInclude]
		[JsonPropertyName("_id")]
		public Elastic.Clients.Elasticsearch.Id Id { get; set; }

		[JsonInclude]
		[JsonPropertyName("_index")]
		public Elastic.Clients.Elasticsearch.IndexName Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("rating")]
		public int Rating { get; set; }
	}

	public partial class RankEvalHit
	{
		[JsonInclude]
		[JsonPropertyName("_id")]
		public Elastic.Clients.Elasticsearch.Id Id
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_index")]
		public Elastic.Clients.Elasticsearch.IndexName Index
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_score")]
		public double Score
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_type")]
		public Elastic.Clients.Elasticsearch.DocType? Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class RankEvalHitItem
	{
		[JsonInclude]
		[JsonPropertyName("hit")]
		public Elastic.Clients.Elasticsearch.Global.RankEval.RankEvalHit Hit
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("rating")]
		public double? Rating
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class RankEvalMetric
	{
		[JsonInclude]
		[JsonPropertyName("dcg")]
		public Elastic.Clients.Elasticsearch.Global.RankEval.RankEvalMetricDiscountedCumulativeGain? Dcg { get; set; }

		[JsonInclude]
		[JsonPropertyName("expected_reciprocal_rank")]
		public Elastic.Clients.Elasticsearch.Global.RankEval.RankEvalMetricExpectedReciprocalRank? ExpectedReciprocalRank { get; set; }

		[JsonInclude]
		[JsonPropertyName("mean_reciprocal_rank")]
		public Elastic.Clients.Elasticsearch.Global.RankEval.RankEvalMetricMeanReciprocalRank? MeanReciprocalRank { get; set; }

		[JsonInclude]
		[JsonPropertyName("precision")]
		public Elastic.Clients.Elasticsearch.Global.RankEval.RankEvalMetricPrecision? Precision { get; set; }

		[JsonInclude]
		[JsonPropertyName("recall")]
		public Elastic.Clients.Elasticsearch.Global.RankEval.RankEvalMetricRecall? Recall { get; set; }
	}

	public abstract partial class RankEvalMetricBase
	{
		[JsonInclude]
		[JsonPropertyName("k")]
		public int? k { get; set; }
	}

	public partial class RankEvalMetricDetail
	{
		[JsonInclude]
		[JsonPropertyName("hits")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Global.RankEval.RankEvalHitItem> Hits
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("metric_details")]
		public Dictionary<string, Dictionary<string, object>> MetricDetails
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("metric_score")]
		public double MetricScore
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("unrated_docs")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Global.RankEval.UnratedDocument> UnratedDocs
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class RankEvalMetricDiscountedCumulativeGain : Global.RankEval.RankEvalMetricBase
	{
		[JsonInclude]
		[JsonPropertyName("normalize")]
		public bool? Normalize { get; set; }
	}

	public partial class RankEvalMetricExpectedReciprocalRank : Global.RankEval.RankEvalMetricBase
	{
		[JsonInclude]
		[JsonPropertyName("maximum_relevance")]
		public int MaximumRelevance { get; set; }
	}

	public partial class RankEvalMetricMeanReciprocalRank : Global.RankEval.RankEvalMetricRatingTreshold
	{
	}

	public partial class RankEvalMetricPrecision : Global.RankEval.RankEvalMetricRatingTreshold
	{
		[JsonInclude]
		[JsonPropertyName("ignore_unlabeled")]
		public bool? IgnoreUnlabeled { get; set; }
	}

	public partial class RankEvalMetricRatingTreshold : Global.RankEval.RankEvalMetricBase
	{
		[JsonInclude]
		[JsonPropertyName("relevant_rating_threshold")]
		public int? RelevantRatingThreshold { get; set; }
	}

	public partial class RankEvalMetricRecall : Global.RankEval.RankEvalMetricRatingTreshold
	{
	}

	public partial class RankEvalQuery
	{
		[JsonInclude]
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.IQueryContainer Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("size")]
		public int? Size { get; set; }
	}

	public partial class RankEvalRequestItem
	{
		[JsonInclude]
		[JsonPropertyName("id")]
		public Elastic.Clients.Elasticsearch.Id Id { get; set; }

		[JsonInclude]
		[JsonPropertyName("params")]
		public Dictionary<string, object>? Params { get; set; }

		[JsonInclude]
		[JsonPropertyName("ratings")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Global.RankEval.DocumentRating> Ratings { get; set; }

		[JsonInclude]
		[JsonPropertyName("request")]
		public Elastic.Clients.Elasticsearch.Global.RankEval.RankEvalQuery? Request { get; set; }

		[JsonInclude]
		[JsonPropertyName("template_id")]
		public Elastic.Clients.Elasticsearch.Id? TemplateId { get; set; }
	}

	public partial class UnratedDocument
	{
		[JsonInclude]
		[JsonPropertyName("_id")]
		public Elastic.Clients.Elasticsearch.Id Id
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_index")]
		public Elastic.Clients.Elasticsearch.IndexName Index
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}
}