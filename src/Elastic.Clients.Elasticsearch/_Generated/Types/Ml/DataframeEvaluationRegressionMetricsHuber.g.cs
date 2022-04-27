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
namespace Elastic.Clients.Elasticsearch.Ml
{
	public partial class DataframeEvaluationRegressionMetricsHuber
	{
		[JsonInclude]
		[JsonPropertyName("delta")]
		public double? Delta { get; set; }
	}

	public sealed partial class DataframeEvaluationRegressionMetricsHuberDescriptor : SerializableDescriptorBase<DataframeEvaluationRegressionMetricsHuberDescriptor>
	{
		internal DataframeEvaluationRegressionMetricsHuberDescriptor(Action<DataframeEvaluationRegressionMetricsHuberDescriptor> configure) => configure.Invoke(this);
		public DataframeEvaluationRegressionMetricsHuberDescriptor() : base()
		{
		}

		private double? DeltaValue { get; set; }

		public DataframeEvaluationRegressionMetricsHuberDescriptor Delta(double? delta)
		{
			DeltaValue = delta;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (DeltaValue.HasValue)
			{
				writer.WritePropertyName("delta");
				writer.WriteNumberValue(DeltaValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}