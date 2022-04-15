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
	public partial class DataframeEvaluationClassificationMetricsAucRoc
	{
		[JsonInclude]
		[JsonPropertyName("class_name")]
		public Elastic.Clients.Elasticsearch.Name? ClassName { get; set; }

		[JsonInclude]
		[JsonPropertyName("include_curve")]
		public bool? IncludeCurve { get; set; }
	}

	public sealed partial class DataframeEvaluationClassificationMetricsAucRocDescriptor : DescriptorBase<DataframeEvaluationClassificationMetricsAucRocDescriptor>
	{
		internal DataframeEvaluationClassificationMetricsAucRocDescriptor(Action<DataframeEvaluationClassificationMetricsAucRocDescriptor> configure) => configure.Invoke(this);
		public DataframeEvaluationClassificationMetricsAucRocDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Name? ClassNameValue { get; set; }

		private bool? IncludeCurveValue { get; set; }

		public DataframeEvaluationClassificationMetricsAucRocDescriptor ClassName(Elastic.Clients.Elasticsearch.Name? className)
		{
			ClassNameValue = className;
			return Self;
		}

		public DataframeEvaluationClassificationMetricsAucRocDescriptor IncludeCurve(bool? includeCurve = true)
		{
			IncludeCurveValue = includeCurve;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ClassNameValue is not null)
			{
				writer.WritePropertyName("class_name");
				JsonSerializer.Serialize(writer, ClassNameValue, options);
			}

			if (IncludeCurveValue.HasValue)
			{
				writer.WritePropertyName("include_curve");
				writer.WriteBooleanValue(IncludeCurveValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}