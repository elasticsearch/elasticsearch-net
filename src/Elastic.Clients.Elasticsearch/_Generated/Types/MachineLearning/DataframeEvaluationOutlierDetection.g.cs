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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class DataframeEvaluationOutlierDetection
{
	/// <summary>
	/// <para>The field of the index which contains the ground truth. The data type of this field can be boolean or integer. If the data type is integer, the value has to be either 0 (false) or 1 (true).</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("actual_field")]
	public Elastic.Clients.Elasticsearch.Field ActualField { get; set; }

	/// <summary>
	/// <para>Specifies the metrics that are used for the evaluation.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("metrics")]
	public Elastic.Clients.Elasticsearch.MachineLearning.DataframeEvaluationOutlierDetectionMetrics? Metrics { get; set; }

	/// <summary>
	/// <para>The field of the index that defines the probability of whether the item belongs to the class in question or not. It’s the field that contains the results of the analysis.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("predicted_probability_field")]
	public Elastic.Clients.Elasticsearch.Field PredictedProbabilityField { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.MachineLearning.DataframeEvaluation(DataframeEvaluationOutlierDetection dataframeEvaluationOutlierDetection) => Elastic.Clients.Elasticsearch.MachineLearning.DataframeEvaluation.OutlierDetection(dataframeEvaluationOutlierDetection);
}

public sealed partial class DataframeEvaluationOutlierDetectionDescriptor<TDocument> : SerializableDescriptor<DataframeEvaluationOutlierDetectionDescriptor<TDocument>>
{
	internal DataframeEvaluationOutlierDetectionDescriptor(Action<DataframeEvaluationOutlierDetectionDescriptor<TDocument>> configure) => configure.Invoke(this);

	public DataframeEvaluationOutlierDetectionDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field ActualFieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.MachineLearning.DataframeEvaluationOutlierDetectionMetrics? MetricsValue { get; set; }
	private Elastic.Clients.Elasticsearch.MachineLearning.DataframeEvaluationOutlierDetectionMetricsDescriptor MetricsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframeEvaluationOutlierDetectionMetricsDescriptor> MetricsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Field PredictedProbabilityFieldValue { get; set; }

	/// <summary>
	/// <para>The field of the index which contains the ground truth. The data type of this field can be boolean or integer. If the data type is integer, the value has to be either 0 (false) or 1 (true).</para>
	/// </summary>
	public DataframeEvaluationOutlierDetectionDescriptor<TDocument> ActualField(Elastic.Clients.Elasticsearch.Field actualField)
	{
		ActualFieldValue = actualField;
		return Self;
	}

	/// <summary>
	/// <para>The field of the index which contains the ground truth. The data type of this field can be boolean or integer. If the data type is integer, the value has to be either 0 (false) or 1 (true).</para>
	/// </summary>
	public DataframeEvaluationOutlierDetectionDescriptor<TDocument> ActualField<TValue>(Expression<Func<TDocument, TValue>> actualField)
	{
		ActualFieldValue = actualField;
		return Self;
	}

	/// <summary>
	/// <para>The field of the index which contains the ground truth. The data type of this field can be boolean or integer. If the data type is integer, the value has to be either 0 (false) or 1 (true).</para>
	/// </summary>
	public DataframeEvaluationOutlierDetectionDescriptor<TDocument> ActualField(Expression<Func<TDocument, object>> actualField)
	{
		ActualFieldValue = actualField;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the metrics that are used for the evaluation.</para>
	/// </summary>
	public DataframeEvaluationOutlierDetectionDescriptor<TDocument> Metrics(Elastic.Clients.Elasticsearch.MachineLearning.DataframeEvaluationOutlierDetectionMetrics? metrics)
	{
		MetricsDescriptor = null;
		MetricsDescriptorAction = null;
		MetricsValue = metrics;
		return Self;
	}

	public DataframeEvaluationOutlierDetectionDescriptor<TDocument> Metrics(Elastic.Clients.Elasticsearch.MachineLearning.DataframeEvaluationOutlierDetectionMetricsDescriptor descriptor)
	{
		MetricsValue = null;
		MetricsDescriptorAction = null;
		MetricsDescriptor = descriptor;
		return Self;
	}

	public DataframeEvaluationOutlierDetectionDescriptor<TDocument> Metrics(Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframeEvaluationOutlierDetectionMetricsDescriptor> configure)
	{
		MetricsValue = null;
		MetricsDescriptor = null;
		MetricsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The field of the index that defines the probability of whether the item belongs to the class in question or not. It’s the field that contains the results of the analysis.</para>
	/// </summary>
	public DataframeEvaluationOutlierDetectionDescriptor<TDocument> PredictedProbabilityField(Elastic.Clients.Elasticsearch.Field predictedProbabilityField)
	{
		PredictedProbabilityFieldValue = predictedProbabilityField;
		return Self;
	}

	/// <summary>
	/// <para>The field of the index that defines the probability of whether the item belongs to the class in question or not. It’s the field that contains the results of the analysis.</para>
	/// </summary>
	public DataframeEvaluationOutlierDetectionDescriptor<TDocument> PredictedProbabilityField<TValue>(Expression<Func<TDocument, TValue>> predictedProbabilityField)
	{
		PredictedProbabilityFieldValue = predictedProbabilityField;
		return Self;
	}

	/// <summary>
	/// <para>The field of the index that defines the probability of whether the item belongs to the class in question or not. It’s the field that contains the results of the analysis.</para>
	/// </summary>
	public DataframeEvaluationOutlierDetectionDescriptor<TDocument> PredictedProbabilityField(Expression<Func<TDocument, object>> predictedProbabilityField)
	{
		PredictedProbabilityFieldValue = predictedProbabilityField;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("actual_field");
		JsonSerializer.Serialize(writer, ActualFieldValue, options);
		if (MetricsDescriptor is not null)
		{
			writer.WritePropertyName("metrics");
			JsonSerializer.Serialize(writer, MetricsDescriptor, options);
		}
		else if (MetricsDescriptorAction is not null)
		{
			writer.WritePropertyName("metrics");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.MachineLearning.DataframeEvaluationOutlierDetectionMetricsDescriptor(MetricsDescriptorAction), options);
		}
		else if (MetricsValue is not null)
		{
			writer.WritePropertyName("metrics");
			JsonSerializer.Serialize(writer, MetricsValue, options);
		}

		writer.WritePropertyName("predicted_probability_field");
		JsonSerializer.Serialize(writer, PredictedProbabilityFieldValue, options);
		writer.WriteEndObject();
	}
}

public sealed partial class DataframeEvaluationOutlierDetectionDescriptor : SerializableDescriptor<DataframeEvaluationOutlierDetectionDescriptor>
{
	internal DataframeEvaluationOutlierDetectionDescriptor(Action<DataframeEvaluationOutlierDetectionDescriptor> configure) => configure.Invoke(this);

	public DataframeEvaluationOutlierDetectionDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field ActualFieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.MachineLearning.DataframeEvaluationOutlierDetectionMetrics? MetricsValue { get; set; }
	private Elastic.Clients.Elasticsearch.MachineLearning.DataframeEvaluationOutlierDetectionMetricsDescriptor MetricsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframeEvaluationOutlierDetectionMetricsDescriptor> MetricsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Field PredictedProbabilityFieldValue { get; set; }

	/// <summary>
	/// <para>The field of the index which contains the ground truth. The data type of this field can be boolean or integer. If the data type is integer, the value has to be either 0 (false) or 1 (true).</para>
	/// </summary>
	public DataframeEvaluationOutlierDetectionDescriptor ActualField(Elastic.Clients.Elasticsearch.Field actualField)
	{
		ActualFieldValue = actualField;
		return Self;
	}

	/// <summary>
	/// <para>The field of the index which contains the ground truth. The data type of this field can be boolean or integer. If the data type is integer, the value has to be either 0 (false) or 1 (true).</para>
	/// </summary>
	public DataframeEvaluationOutlierDetectionDescriptor ActualField<TDocument, TValue>(Expression<Func<TDocument, TValue>> actualField)
	{
		ActualFieldValue = actualField;
		return Self;
	}

	/// <summary>
	/// <para>The field of the index which contains the ground truth. The data type of this field can be boolean or integer. If the data type is integer, the value has to be either 0 (false) or 1 (true).</para>
	/// </summary>
	public DataframeEvaluationOutlierDetectionDescriptor ActualField<TDocument>(Expression<Func<TDocument, object>> actualField)
	{
		ActualFieldValue = actualField;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the metrics that are used for the evaluation.</para>
	/// </summary>
	public DataframeEvaluationOutlierDetectionDescriptor Metrics(Elastic.Clients.Elasticsearch.MachineLearning.DataframeEvaluationOutlierDetectionMetrics? metrics)
	{
		MetricsDescriptor = null;
		MetricsDescriptorAction = null;
		MetricsValue = metrics;
		return Self;
	}

	public DataframeEvaluationOutlierDetectionDescriptor Metrics(Elastic.Clients.Elasticsearch.MachineLearning.DataframeEvaluationOutlierDetectionMetricsDescriptor descriptor)
	{
		MetricsValue = null;
		MetricsDescriptorAction = null;
		MetricsDescriptor = descriptor;
		return Self;
	}

	public DataframeEvaluationOutlierDetectionDescriptor Metrics(Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframeEvaluationOutlierDetectionMetricsDescriptor> configure)
	{
		MetricsValue = null;
		MetricsDescriptor = null;
		MetricsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The field of the index that defines the probability of whether the item belongs to the class in question or not. It’s the field that contains the results of the analysis.</para>
	/// </summary>
	public DataframeEvaluationOutlierDetectionDescriptor PredictedProbabilityField(Elastic.Clients.Elasticsearch.Field predictedProbabilityField)
	{
		PredictedProbabilityFieldValue = predictedProbabilityField;
		return Self;
	}

	/// <summary>
	/// <para>The field of the index that defines the probability of whether the item belongs to the class in question or not. It’s the field that contains the results of the analysis.</para>
	/// </summary>
	public DataframeEvaluationOutlierDetectionDescriptor PredictedProbabilityField<TDocument, TValue>(Expression<Func<TDocument, TValue>> predictedProbabilityField)
	{
		PredictedProbabilityFieldValue = predictedProbabilityField;
		return Self;
	}

	/// <summary>
	/// <para>The field of the index that defines the probability of whether the item belongs to the class in question or not. It’s the field that contains the results of the analysis.</para>
	/// </summary>
	public DataframeEvaluationOutlierDetectionDescriptor PredictedProbabilityField<TDocument>(Expression<Func<TDocument, object>> predictedProbabilityField)
	{
		PredictedProbabilityFieldValue = predictedProbabilityField;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("actual_field");
		JsonSerializer.Serialize(writer, ActualFieldValue, options);
		if (MetricsDescriptor is not null)
		{
			writer.WritePropertyName("metrics");
			JsonSerializer.Serialize(writer, MetricsDescriptor, options);
		}
		else if (MetricsDescriptorAction is not null)
		{
			writer.WritePropertyName("metrics");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.MachineLearning.DataframeEvaluationOutlierDetectionMetricsDescriptor(MetricsDescriptorAction), options);
		}
		else if (MetricsValue is not null)
		{
			writer.WritePropertyName("metrics");
			JsonSerializer.Serialize(writer, MetricsValue, options);
		}

		writer.WritePropertyName("predicted_probability_field");
		JsonSerializer.Serialize(writer, PredictedProbabilityFieldValue, options);
		writer.WriteEndObject();
	}
}