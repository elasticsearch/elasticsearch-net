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

namespace Elastic.Clients.Elasticsearch.LicenseManagement;

public sealed partial class GetLicenseRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Specifies whether to retrieve local information. The default value is `false`, which means the information is retrieved from the master node.</para>
	/// </summary>
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
}

/// <summary>
/// <para>This API returns information about the type of license, when it was issued, and when it expires, for example.<br/>For more information about the different types of licenses, see https://www.elastic.co/subscriptions.</para>
/// </summary>
public sealed partial class GetLicenseRequest : PlainRequest<GetLicenseRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.LicenseManagementGet;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "license.get";

	/// <summary>
	/// <para>Specifies whether to retrieve local information. The default value is `false`, which means the information is retrieved from the master node.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
}

/// <summary>
/// <para>This API returns information about the type of license, when it was issued, and when it expires, for example.<br/>For more information about the different types of licenses, see https://www.elastic.co/subscriptions.</para>
/// </summary>
public sealed partial class GetLicenseRequestDescriptor : RequestDescriptor<GetLicenseRequestDescriptor, GetLicenseRequestParameters>
{
	internal GetLicenseRequestDescriptor(Action<GetLicenseRequestDescriptor> configure) => configure.Invoke(this);

	public GetLicenseRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.LicenseManagementGet;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "license.get";

	public GetLicenseRequestDescriptor Local(bool? local = true) => Qs("local", local);

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}