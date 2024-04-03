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

namespace Elastic.Clients.Elasticsearch.Serverless.Enrich;

public sealed partial class DeletePolicyRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Deletes an existing enrich policy and its enrich index.</para>
/// </summary>
public sealed partial class DeletePolicyRequest : PlainRequest<DeletePolicyRequestParameters>
{
	public DeletePolicyRequest(Elastic.Clients.Elasticsearch.Serverless.Name name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EnrichDeletePolicy;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "enrich.delete_policy";
}

/// <summary>
/// <para>Deletes an existing enrich policy and its enrich index.</para>
/// </summary>
public sealed partial class DeletePolicyRequestDescriptor : RequestDescriptor<DeletePolicyRequestDescriptor, DeletePolicyRequestParameters>
{
	internal DeletePolicyRequestDescriptor(Action<DeletePolicyRequestDescriptor> configure) => configure.Invoke(this);

	public DeletePolicyRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Name name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EnrichDeletePolicy;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "enrich.delete_policy";

	public DeletePolicyRequestDescriptor Name(Elastic.Clients.Elasticsearch.Serverless.Name name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}