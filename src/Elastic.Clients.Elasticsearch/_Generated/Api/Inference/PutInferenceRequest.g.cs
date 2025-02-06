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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Inference;

public sealed partial class PutInferenceRequestParameters : RequestParameters
{
}

internal sealed partial class PutInferenceRequestConverter : System.Text.Json.Serialization.JsonConverter<PutInferenceRequest>
{
	public override PutInferenceRequest Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		return new PutInferenceRequest { InferenceConfig = reader.ReadValue<Elastic.Clients.Elasticsearch.Inference.InferenceEndpoint>(options) };
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, PutInferenceRequest value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteValue(options, value.InferenceConfig);
	}
}

/// <summary>
/// <para>
/// Create an inference endpoint.
/// When you create an inference endpoint, the associated machine learning model is automatically deployed if it is not already running.
/// After creating the endpoint, wait for the model deployment to complete before using it.
/// To verify the deployment status, use the get trained model statistics API.
/// Look for <c>"state": "fully_allocated"</c> in the response and ensure that the <c>"allocation_count"</c> matches the <c>"target_allocation_count"</c>.
/// Avoid creating multiple endpoints for the same model unless required, as each endpoint consumes significant resources.
/// </para>
/// <para>
/// IMPORTANT: The inference APIs enable you to use certain services, such as built-in machine learning models (ELSER, E5), models uploaded through Eland, Cohere, OpenAI, Mistral, Azure OpenAI, Google AI Studio, Google Vertex AI, Anthropic, Watsonx.ai, or Hugging Face.
/// For built-in models and models uploaded through Eland, the inference APIs offer an alternative way to use and manage trained models.
/// However, if you do not plan to use the inference APIs to use these models or if you want to use non-NLP models, use the machine learning trained model APIs.
/// </para>
/// </summary>
[JsonConverter(typeof(PutInferenceRequestConverter))]
public sealed partial class PutInferenceRequest : PlainRequest<PutInferenceRequestParameters>
{
	public PutInferenceRequest(Elastic.Clients.Elasticsearch.Id inferenceId) : base(r => r.Required("inference_id", inferenceId))
	{
	}

	public PutInferenceRequest(Elastic.Clients.Elasticsearch.Inference.TaskType? taskType, Elastic.Clients.Elasticsearch.Id inferenceId) : base(r => r.Optional("task_type", taskType).Required("inference_id", inferenceId))
	{
	}

	[JsonConstructor]
	internal PutInferenceRequest()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.InferencePut;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "inference.put";

	/// <summary>
	/// <para>
	/// The inference Id
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Id InferenceId { get => P<Elastic.Clients.Elasticsearch.Id>("inference_id"); set => PR("inference_id", value); }

	/// <summary>
	/// <para>
	/// The task type
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Inference.TaskType? TaskType { get => P<Elastic.Clients.Elasticsearch.Inference.TaskType?>("task_type"); set => PO("task_type", value); }
	public Elastic.Clients.Elasticsearch.Inference.InferenceEndpoint InferenceConfig { get; set; }
}

/// <summary>
/// <para>
/// Create an inference endpoint.
/// When you create an inference endpoint, the associated machine learning model is automatically deployed if it is not already running.
/// After creating the endpoint, wait for the model deployment to complete before using it.
/// To verify the deployment status, use the get trained model statistics API.
/// Look for <c>"state": "fully_allocated"</c> in the response and ensure that the <c>"allocation_count"</c> matches the <c>"target_allocation_count"</c>.
/// Avoid creating multiple endpoints for the same model unless required, as each endpoint consumes significant resources.
/// </para>
/// <para>
/// IMPORTANT: The inference APIs enable you to use certain services, such as built-in machine learning models (ELSER, E5), models uploaded through Eland, Cohere, OpenAI, Mistral, Azure OpenAI, Google AI Studio, Google Vertex AI, Anthropic, Watsonx.ai, or Hugging Face.
/// For built-in models and models uploaded through Eland, the inference APIs offer an alternative way to use and manage trained models.
/// However, if you do not plan to use the inference APIs to use these models or if you want to use non-NLP models, use the machine learning trained model APIs.
/// </para>
/// </summary>
public sealed partial class PutInferenceRequestDescriptor : RequestDescriptor<PutInferenceRequestDescriptor, PutInferenceRequestParameters>
{
	internal PutInferenceRequestDescriptor(Action<PutInferenceRequestDescriptor> configure) => configure.Invoke(this);
	public PutInferenceRequestDescriptor(Elastic.Clients.Elasticsearch.Inference.InferenceEndpoint inferenceConfig, Elastic.Clients.Elasticsearch.Inference.TaskType? taskType, Elastic.Clients.Elasticsearch.Id inferenceId) : base(r => r.Optional("task_type", taskType).Required("inference_id", inferenceId)) => InferenceConfigValue = inferenceConfig;
	public PutInferenceRequestDescriptor(Elastic.Clients.Elasticsearch.Inference.InferenceEndpoint inferenceConfig, Elastic.Clients.Elasticsearch.Id inferenceId) : base(r => r.Required("inference_id", inferenceId)) => InferenceConfigValue = inferenceConfig;

	internal override ApiUrls ApiUrls => ApiUrlLookup.InferencePut;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "inference.put";

	public PutInferenceRequestDescriptor InferenceId(Elastic.Clients.Elasticsearch.Id inferenceId)
	{
		RouteValues.Required("inference_id", inferenceId);
		return Self;
	}

	public PutInferenceRequestDescriptor TaskType(Elastic.Clients.Elasticsearch.Inference.TaskType? taskType)
	{
		RouteValues.Optional("task_type", taskType);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Inference.InferenceEndpoint InferenceConfigValue { get; set; }
	private Elastic.Clients.Elasticsearch.Inference.InferenceEndpointDescriptor InferenceConfigDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Inference.InferenceEndpointDescriptor> InferenceConfigDescriptorAction { get; set; }

	public PutInferenceRequestDescriptor InferenceConfig(Elastic.Clients.Elasticsearch.Inference.InferenceEndpoint inferenceConfig)
	{
		InferenceConfigDescriptor = null;
		InferenceConfigDescriptorAction = null;
		InferenceConfigValue = inferenceConfig;
		return Self;
	}

	public PutInferenceRequestDescriptor InferenceConfig(Elastic.Clients.Elasticsearch.Inference.InferenceEndpointDescriptor descriptor)
	{
		InferenceConfigValue = null;
		InferenceConfigDescriptorAction = null;
		InferenceConfigDescriptor = descriptor;
		return Self;
	}

	public PutInferenceRequestDescriptor InferenceConfig(Action<Elastic.Clients.Elasticsearch.Inference.InferenceEndpointDescriptor> configure)
	{
		InferenceConfigValue = null;
		InferenceConfigDescriptor = null;
		InferenceConfigDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		JsonSerializer.Serialize(writer, InferenceConfigValue, options);
	}
}