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

namespace Elastic.Clients.Elasticsearch.Security;

public sealed partial class GetServiceAccountsRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Get service accounts.
/// </para>
/// <para>
/// Get a list of service accounts that match the provided path parameters.
/// </para>
/// </summary>
public sealed partial class GetServiceAccountsRequest : PlainRequest<GetServiceAccountsRequestParameters>
{
	[JsonConstructor]
	public GetServiceAccountsRequest()
	{
	}

	public GetServiceAccountsRequest(string? ns, string? service) : base(r => r.Optional("namespace", ns).Optional("service", service))
	{
	}

	public GetServiceAccountsRequest(string? ns) : base(r => r.Optional("namespace", ns))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityGetServiceAccounts;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "security.get_service_accounts";

	/// <summary>
	/// <para>
	/// Name of the namespace. Omit this parameter to retrieve information about all service accounts. If you omit this parameter, you must also omit the <c>service</c> parameter.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public string? Namespace { get => P<string?>("namespace"); set => PO("namespace", value); }

	/// <summary>
	/// <para>
	/// Name of the service name. Omit this parameter to retrieve information about all service accounts that belong to the specified <c>namespace</c>.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public string? Service { get => P<string?>("service"); set => PO("service", value); }
}

/// <summary>
/// <para>
/// Get service accounts.
/// </para>
/// <para>
/// Get a list of service accounts that match the provided path parameters.
/// </para>
/// </summary>
public sealed partial class GetServiceAccountsRequestDescriptor : RequestDescriptor<GetServiceAccountsRequestDescriptor, GetServiceAccountsRequestParameters>
{
	internal GetServiceAccountsRequestDescriptor(Action<GetServiceAccountsRequestDescriptor> configure) => configure.Invoke(this);

	public GetServiceAccountsRequestDescriptor(string? ns, string? service) : base(r => r.Optional("namespace", ns).Optional("service", service))
	{
	}

	public GetServiceAccountsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityGetServiceAccounts;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "security.get_service_accounts";

	public GetServiceAccountsRequestDescriptor Namespace(string? ns)
	{
		RouteValues.Optional("namespace", ns);
		return Self;
	}

	public GetServiceAccountsRequestDescriptor Service(string? service)
	{
		RouteValues.Optional("service", service);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}