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

using Elastic.Transport.Products.Elasticsearch;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public partial class MlInferTrainedModelDeploymentResponse : ElasticsearchResponseBase
	{
		[JsonInclude]
		[JsonPropertyName("entities")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Ml.TrainedModelEntities>? Entities { get; init; }

		[JsonInclude]
		[JsonPropertyName("is_truncated")]
		public bool? IsTruncated { get; init; }

		[JsonInclude]
		[JsonPropertyName("predicted_value")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Ml.PredictedValue>? PredictedValue { get; init; }

		[JsonInclude]
		[JsonPropertyName("predicted_value_sequence")]
		public string? PredictedValueSequence { get; init; }

		[JsonInclude]
		[JsonPropertyName("prediction_probability")]
		public double? PredictionProbability { get; init; }

		[JsonInclude]
		[JsonPropertyName("top_classes")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Ml.TopClassEntry> TopClasses { get; init; }

		[JsonInclude]
		[JsonPropertyName("warning")]
		public string? Warning { get; init; }
	}
}