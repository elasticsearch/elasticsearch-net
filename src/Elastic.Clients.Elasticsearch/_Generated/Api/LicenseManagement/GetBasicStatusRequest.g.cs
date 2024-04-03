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

public sealed partial class GetBasicStatusRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Retrieves information about the status of the basic license.</para>
/// </summary>
public sealed partial class GetBasicStatusRequest : PlainRequest<GetBasicStatusRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.LicenseManagementGetBasicStatus;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "license.get_basic_status";
}

/// <summary>
/// <para>Retrieves information about the status of the basic license.</para>
/// </summary>
public sealed partial class GetBasicStatusRequestDescriptor : RequestDescriptor<GetBasicStatusRequestDescriptor, GetBasicStatusRequestParameters>
{
	internal GetBasicStatusRequestDescriptor(Action<GetBasicStatusRequestDescriptor> configure) => configure.Invoke(this);

	public GetBasicStatusRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.LicenseManagementGetBasicStatus;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "license.get_basic_status";

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}