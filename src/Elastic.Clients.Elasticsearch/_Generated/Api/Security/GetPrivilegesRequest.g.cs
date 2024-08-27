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

namespace Elastic.Clients.Elasticsearch.Security;

public sealed partial class GetPrivilegesRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Retrieves application privileges.
/// </para>
/// </summary>
public sealed partial class GetPrivilegesRequest : PlainRequest<GetPrivilegesRequestParameters>
{
	public GetPrivilegesRequest()
	{
	}

	public GetPrivilegesRequest(Elastic.Clients.Elasticsearch.Name? application) : base(r => r.Optional("application", application))
	{
	}

	public GetPrivilegesRequest(Elastic.Clients.Elasticsearch.Name? application, Elastic.Clients.Elasticsearch.Names? name) : base(r => r.Optional("application", application).Optional("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityGetPrivileges;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "security.get_privileges";
}

/// <summary>
/// <para>
/// Retrieves application privileges.
/// </para>
/// </summary>
public sealed partial class GetPrivilegesRequestDescriptor : RequestDescriptor<GetPrivilegesRequestDescriptor, GetPrivilegesRequestParameters>
{
	internal GetPrivilegesRequestDescriptor(Action<GetPrivilegesRequestDescriptor> configure) => configure.Invoke(this);

	public GetPrivilegesRequestDescriptor(Elastic.Clients.Elasticsearch.Name? application, Elastic.Clients.Elasticsearch.Names? name) : base(r => r.Optional("application", application).Optional("name", name))
	{
	}

	public GetPrivilegesRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityGetPrivileges;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "security.get_privileges";

	public GetPrivilegesRequestDescriptor Application(Elastic.Clients.Elasticsearch.Name? application)
	{
		RouteValues.Optional("application", application);
		return Self;
	}

	public GetPrivilegesRequestDescriptor Name(Elastic.Clients.Elasticsearch.Names? name)
	{
		RouteValues.Optional("name", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}