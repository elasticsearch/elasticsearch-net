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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class DeleteTrainedModelRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Forcefully deletes a trained model that is referenced by ingest pipelines or has a started deployment.</para>
	/// </summary>
	public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }
}

/// <summary>
/// <para>Delete an unreferenced trained model.<br/>The request deletes a trained inference model that is not referenced by an ingest pipeline.</para>
/// </summary>
public sealed partial class DeleteTrainedModelRequest : PlainRequest<DeleteTrainedModelRequestParameters>
{
	public DeleteTrainedModelRequest(Elastic.Clients.Elasticsearch.Serverless.Id modelId) : base(r => r.Required("model_id", modelId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningDeleteTrainedModel;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.delete_trained_model";

	/// <summary>
	/// <para>Forcefully deletes a trained model that is referenced by ingest pipelines or has a started deployment.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }
}

/// <summary>
/// <para>Delete an unreferenced trained model.<br/>The request deletes a trained inference model that is not referenced by an ingest pipeline.</para>
/// </summary>
public sealed partial class DeleteTrainedModelRequestDescriptor : RequestDescriptor<DeleteTrainedModelRequestDescriptor, DeleteTrainedModelRequestParameters>
{
	internal DeleteTrainedModelRequestDescriptor(Action<DeleteTrainedModelRequestDescriptor> configure) => configure.Invoke(this);

	public DeleteTrainedModelRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id modelId) : base(r => r.Required("model_id", modelId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningDeleteTrainedModel;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.delete_trained_model";

	public DeleteTrainedModelRequestDescriptor Force(bool? force = true) => Qs("force", force);

	public DeleteTrainedModelRequestDescriptor ModelId(Elastic.Clients.Elasticsearch.Serverless.Id modelId)
	{
		RouteValues.Required("model_id", modelId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}