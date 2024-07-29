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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Enrich;

public sealed partial class GetPolicyRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Get an enrich policy.<br/>Returns information about an enrich policy.</para>
/// </summary>
public sealed partial class GetPolicyRequest : PlainRequest<GetPolicyRequestParameters>
{
	public GetPolicyRequest()
	{
	}

	public GetPolicyRequest(Elastic.Clients.Elasticsearch.Names? name) : base(r => r.Optional("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EnrichGetPolicy;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "enrich.get_policy";
}

/// <summary>
/// <para>Get an enrich policy.<br/>Returns information about an enrich policy.</para>
/// </summary>
public sealed partial class GetPolicyRequestDescriptor : RequestDescriptor<GetPolicyRequestDescriptor, GetPolicyRequestParameters>
{
	internal GetPolicyRequestDescriptor(Action<GetPolicyRequestDescriptor> configure) => configure.Invoke(this);

	public GetPolicyRequestDescriptor(Elastic.Clients.Elasticsearch.Names? name) : base(r => r.Optional("name", name))
	{
	}

	public GetPolicyRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EnrichGetPolicy;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "enrich.get_policy";

	public GetPolicyRequestDescriptor Name(Elastic.Clients.Elasticsearch.Names? name)
	{
		RouteValues.Optional("name", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}