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

namespace Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement;

public sealed partial class StartSlmRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Start snapshot lifecycle management.
/// Snapshot lifecycle management (SLM) starts automatically when a cluster is formed.
/// Manually starting SLM is necessary only if it has been stopped using the stop SLM API.
/// </para>
/// </summary>
public sealed partial class StartSlmRequest : PlainRequest<StartSlmRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotLifecycleManagementStart;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "slm.start";
}

/// <summary>
/// <para>
/// Start snapshot lifecycle management.
/// Snapshot lifecycle management (SLM) starts automatically when a cluster is formed.
/// Manually starting SLM is necessary only if it has been stopped using the stop SLM API.
/// </para>
/// </summary>
public sealed partial class StartSlmRequestDescriptor : RequestDescriptor<StartSlmRequestDescriptor, StartSlmRequestParameters>
{
	internal StartSlmRequestDescriptor(Action<StartSlmRequestDescriptor> configure) => configure.Invoke(this);

	public StartSlmRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotLifecycleManagementStart;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "slm.start";

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}