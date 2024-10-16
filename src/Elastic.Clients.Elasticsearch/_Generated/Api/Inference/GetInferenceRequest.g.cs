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

public sealed partial class GetInferenceRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Get an inference endpoint
/// </para>
/// </summary>
public sealed partial class GetInferenceRequest : PlainRequest<GetInferenceRequestParameters>
{
	public GetInferenceRequest()
	{
	}

	public GetInferenceRequest(Elastic.Clients.Elasticsearch.Id? inferenceId) : base(r => r.Optional("inference_id", inferenceId))
	{
	}

	public GetInferenceRequest(Elastic.Clients.Elasticsearch.Inference.TaskType? taskType, Elastic.Clients.Elasticsearch.Id? inferenceId) : base(r => r.Optional("task_type", taskType).Optional("inference_id", inferenceId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.InferenceGet;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "inference.get";
}

/// <summary>
/// <para>
/// Get an inference endpoint
/// </para>
/// </summary>
public sealed partial class GetInferenceRequestDescriptor : RequestDescriptor<GetInferenceRequestDescriptor, GetInferenceRequestParameters>
{
	internal GetInferenceRequestDescriptor(Action<GetInferenceRequestDescriptor> configure) => configure.Invoke(this);

	public GetInferenceRequestDescriptor(Elastic.Clients.Elasticsearch.Inference.TaskType? taskType, Elastic.Clients.Elasticsearch.Id? inferenceId) : base(r => r.Optional("task_type", taskType).Optional("inference_id", inferenceId))
	{
	}

	public GetInferenceRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.InferenceGet;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "inference.get";

	public GetInferenceRequestDescriptor InferenceId(Elastic.Clients.Elasticsearch.Id? inferenceId)
	{
		RouteValues.Optional("inference_id", inferenceId);
		return Self;
	}

	public GetInferenceRequestDescriptor TaskType(Elastic.Clients.Elasticsearch.Inference.TaskType? taskType)
	{
		RouteValues.Optional("task_type", taskType);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}