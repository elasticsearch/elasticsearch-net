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
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Xpack;

public sealed partial class MlInference
{
	[JsonInclude, JsonPropertyName("deployments")]
	public Elastic.Clients.Elasticsearch.Serverless.Xpack.MlInferenceDeployments? Deployments { get; init; }
	[JsonInclude, JsonPropertyName("ingest_processors")]
	public IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.Serverless.Xpack.MlInferenceIngestProcessor> IngestProcessors { get; init; }
	[JsonInclude, JsonPropertyName("trained_models")]
	public Elastic.Clients.Elasticsearch.Serverless.Xpack.MlInferenceTrainedModels TrainedModels { get; init; }
}