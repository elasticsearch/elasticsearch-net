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
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class EstimateModelMemoryRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Estimate job model memory usage.
/// Makes an estimation of the memory usage for an anomaly detection job model.
/// It is based on analysis configuration details for the job and cardinality
/// estimates for the fields it references.
/// </para>
/// </summary>
public sealed partial class EstimateModelMemoryRequest : PlainRequest<EstimateModelMemoryRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningEstimateModelMemory;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.estimate_model_memory";

	/// <summary>
	/// <para>
	/// For a list of the properties that you can specify in the
	/// <c>analysis_config</c> component of the body of this API.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("analysis_config")]
	public Elastic.Clients.Elasticsearch.Serverless.MachineLearning.AnalysisConfig? AnalysisConfig { get; set; }

	/// <summary>
	/// <para>
	/// Estimates of the highest cardinality in a single bucket that is observed
	/// for influencer fields over the time period that the job analyzes data.
	/// To produce a good answer, values must be provided for all influencer
	/// fields. Providing values for fields that are not listed as <c>influencers</c>
	/// has no effect on the estimation.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("max_bucket_cardinality")]
	public IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>? MaxBucketCardinality { get; set; }

	/// <summary>
	/// <para>
	/// Estimates of the cardinality that is observed for fields over the whole
	/// time period that the job analyzes data. To produce a good answer, values
	/// must be provided for fields referenced in the <c>by_field_name</c>,
	/// <c>over_field_name</c> and <c>partition_field_name</c> of any detectors. Providing
	/// values for other fields has no effect on the estimation. It can be
	/// omitted from the request if no detectors have a <c>by_field_name</c>,
	/// <c>over_field_name</c> or <c>partition_field_name</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("overall_cardinality")]
	public IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>? OverallCardinality { get; set; }
}

/// <summary>
/// <para>
/// Estimate job model memory usage.
/// Makes an estimation of the memory usage for an anomaly detection job model.
/// It is based on analysis configuration details for the job and cardinality
/// estimates for the fields it references.
/// </para>
/// </summary>
public sealed partial class EstimateModelMemoryRequestDescriptor<TDocument> : RequestDescriptor<EstimateModelMemoryRequestDescriptor<TDocument>, EstimateModelMemoryRequestParameters>
{
	internal EstimateModelMemoryRequestDescriptor(Action<EstimateModelMemoryRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public EstimateModelMemoryRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningEstimateModelMemory;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.estimate_model_memory";

	private Elastic.Clients.Elasticsearch.Serverless.MachineLearning.AnalysisConfig? AnalysisConfigValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.MachineLearning.AnalysisConfigDescriptor<TDocument> AnalysisConfigDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.AnalysisConfigDescriptor<TDocument>> AnalysisConfigDescriptorAction { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>? MaxBucketCardinalityValue { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>? OverallCardinalityValue { get; set; }

	/// <summary>
	/// <para>
	/// For a list of the properties that you can specify in the
	/// <c>analysis_config</c> component of the body of this API.
	/// </para>
	/// </summary>
	public EstimateModelMemoryRequestDescriptor<TDocument> AnalysisConfig(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.AnalysisConfig? analysisConfig)
	{
		AnalysisConfigDescriptor = null;
		AnalysisConfigDescriptorAction = null;
		AnalysisConfigValue = analysisConfig;
		return Self;
	}

	public EstimateModelMemoryRequestDescriptor<TDocument> AnalysisConfig(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.AnalysisConfigDescriptor<TDocument> descriptor)
	{
		AnalysisConfigValue = null;
		AnalysisConfigDescriptorAction = null;
		AnalysisConfigDescriptor = descriptor;
		return Self;
	}

	public EstimateModelMemoryRequestDescriptor<TDocument> AnalysisConfig(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.AnalysisConfigDescriptor<TDocument>> configure)
	{
		AnalysisConfigValue = null;
		AnalysisConfigDescriptor = null;
		AnalysisConfigDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Estimates of the highest cardinality in a single bucket that is observed
	/// for influencer fields over the time period that the job analyzes data.
	/// To produce a good answer, values must be provided for all influencer
	/// fields. Providing values for fields that are not listed as <c>influencers</c>
	/// has no effect on the estimation.
	/// </para>
	/// </summary>
	public EstimateModelMemoryRequestDescriptor<TDocument> MaxBucketCardinality(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>, FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>> selector)
	{
		MaxBucketCardinalityValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// Estimates of the cardinality that is observed for fields over the whole
	/// time period that the job analyzes data. To produce a good answer, values
	/// must be provided for fields referenced in the <c>by_field_name</c>,
	/// <c>over_field_name</c> and <c>partition_field_name</c> of any detectors. Providing
	/// values for other fields has no effect on the estimation. It can be
	/// omitted from the request if no detectors have a <c>by_field_name</c>,
	/// <c>over_field_name</c> or <c>partition_field_name</c>.
	/// </para>
	/// </summary>
	public EstimateModelMemoryRequestDescriptor<TDocument> OverallCardinality(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>, FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>> selector)
	{
		OverallCardinalityValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AnalysisConfigDescriptor is not null)
		{
			writer.WritePropertyName("analysis_config");
			JsonSerializer.Serialize(writer, AnalysisConfigDescriptor, options);
		}
		else if (AnalysisConfigDescriptorAction is not null)
		{
			writer.WritePropertyName("analysis_config");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.MachineLearning.AnalysisConfigDescriptor<TDocument>(AnalysisConfigDescriptorAction), options);
		}
		else if (AnalysisConfigValue is not null)
		{
			writer.WritePropertyName("analysis_config");
			JsonSerializer.Serialize(writer, AnalysisConfigValue, options);
		}

		if (MaxBucketCardinalityValue is not null)
		{
			writer.WritePropertyName("max_bucket_cardinality");
			JsonSerializer.Serialize(writer, MaxBucketCardinalityValue, options);
		}

		if (OverallCardinalityValue is not null)
		{
			writer.WritePropertyName("overall_cardinality");
			JsonSerializer.Serialize(writer, OverallCardinalityValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Estimate job model memory usage.
/// Makes an estimation of the memory usage for an anomaly detection job model.
/// It is based on analysis configuration details for the job and cardinality
/// estimates for the fields it references.
/// </para>
/// </summary>
public sealed partial class EstimateModelMemoryRequestDescriptor : RequestDescriptor<EstimateModelMemoryRequestDescriptor, EstimateModelMemoryRequestParameters>
{
	internal EstimateModelMemoryRequestDescriptor(Action<EstimateModelMemoryRequestDescriptor> configure) => configure.Invoke(this);

	public EstimateModelMemoryRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningEstimateModelMemory;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.estimate_model_memory";

	private Elastic.Clients.Elasticsearch.Serverless.MachineLearning.AnalysisConfig? AnalysisConfigValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.MachineLearning.AnalysisConfigDescriptor AnalysisConfigDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.AnalysisConfigDescriptor> AnalysisConfigDescriptorAction { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>? MaxBucketCardinalityValue { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>? OverallCardinalityValue { get; set; }

	/// <summary>
	/// <para>
	/// For a list of the properties that you can specify in the
	/// <c>analysis_config</c> component of the body of this API.
	/// </para>
	/// </summary>
	public EstimateModelMemoryRequestDescriptor AnalysisConfig(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.AnalysisConfig? analysisConfig)
	{
		AnalysisConfigDescriptor = null;
		AnalysisConfigDescriptorAction = null;
		AnalysisConfigValue = analysisConfig;
		return Self;
	}

	public EstimateModelMemoryRequestDescriptor AnalysisConfig(Elastic.Clients.Elasticsearch.Serverless.MachineLearning.AnalysisConfigDescriptor descriptor)
	{
		AnalysisConfigValue = null;
		AnalysisConfigDescriptorAction = null;
		AnalysisConfigDescriptor = descriptor;
		return Self;
	}

	public EstimateModelMemoryRequestDescriptor AnalysisConfig(Action<Elastic.Clients.Elasticsearch.Serverless.MachineLearning.AnalysisConfigDescriptor> configure)
	{
		AnalysisConfigValue = null;
		AnalysisConfigDescriptor = null;
		AnalysisConfigDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Estimates of the highest cardinality in a single bucket that is observed
	/// for influencer fields over the time period that the job analyzes data.
	/// To produce a good answer, values must be provided for all influencer
	/// fields. Providing values for fields that are not listed as <c>influencers</c>
	/// has no effect on the estimation.
	/// </para>
	/// </summary>
	public EstimateModelMemoryRequestDescriptor MaxBucketCardinality(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>, FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>> selector)
	{
		MaxBucketCardinalityValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// Estimates of the cardinality that is observed for fields over the whole
	/// time period that the job analyzes data. To produce a good answer, values
	/// must be provided for fields referenced in the <c>by_field_name</c>,
	/// <c>over_field_name</c> and <c>partition_field_name</c> of any detectors. Providing
	/// values for other fields has no effect on the estimation. It can be
	/// omitted from the request if no detectors have a <c>by_field_name</c>,
	/// <c>over_field_name</c> or <c>partition_field_name</c>.
	/// </para>
	/// </summary>
	public EstimateModelMemoryRequestDescriptor OverallCardinality(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>, FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>> selector)
	{
		OverallCardinalityValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, long>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AnalysisConfigDescriptor is not null)
		{
			writer.WritePropertyName("analysis_config");
			JsonSerializer.Serialize(writer, AnalysisConfigDescriptor, options);
		}
		else if (AnalysisConfigDescriptorAction is not null)
		{
			writer.WritePropertyName("analysis_config");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.MachineLearning.AnalysisConfigDescriptor(AnalysisConfigDescriptorAction), options);
		}
		else if (AnalysisConfigValue is not null)
		{
			writer.WritePropertyName("analysis_config");
			JsonSerializer.Serialize(writer, AnalysisConfigValue, options);
		}

		if (MaxBucketCardinalityValue is not null)
		{
			writer.WritePropertyName("max_bucket_cardinality");
			JsonSerializer.Serialize(writer, MaxBucketCardinalityValue, options);
		}

		if (OverallCardinalityValue is not null)
		{
			writer.WritePropertyName("overall_cardinality");
			JsonSerializer.Serialize(writer, OverallCardinalityValue, options);
		}

		writer.WriteEndObject();
	}
}