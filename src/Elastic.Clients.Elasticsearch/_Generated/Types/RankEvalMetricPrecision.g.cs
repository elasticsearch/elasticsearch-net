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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public sealed partial class RankEvalMetricPrecision
	{
		[JsonInclude]
		[JsonPropertyName("ignore_unlabeled")]
		public bool? IgnoreUnlabeled { get; set; }

		[JsonInclude]
		[JsonPropertyName("k")]
		public int? k { get; set; }

		[JsonInclude]
		[JsonPropertyName("relevant_rating_threshold")]
		public int? RelevantRatingThreshold { get; set; }
	}

	public sealed partial class RankEvalMetricPrecisionDescriptor : SerializableDescriptorBase<RankEvalMetricPrecisionDescriptor>
	{
		internal RankEvalMetricPrecisionDescriptor(Action<RankEvalMetricPrecisionDescriptor> configure) => configure.Invoke(this);
		public RankEvalMetricPrecisionDescriptor() : base()
		{
		}

		private bool? IgnoreUnlabeledValue { get; set; }

		private int? kValue { get; set; }

		private int? RelevantRatingThresholdValue { get; set; }

		public RankEvalMetricPrecisionDescriptor IgnoreUnlabeled(bool? ignoreUnlabeled = true)
		{
			IgnoreUnlabeledValue = ignoreUnlabeled;
			return Self;
		}

		public RankEvalMetricPrecisionDescriptor k(int? k)
		{
			kValue = k;
			return Self;
		}

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
}