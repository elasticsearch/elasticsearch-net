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

namespace Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement;

public sealed partial class DeleteLifecycleRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Deletes an existing snapshot lifecycle policy.</para>
/// </summary>
public sealed partial class DeleteLifecycleRequest : PlainRequest<DeleteLifecycleRequestParameters>
{
	public DeleteLifecycleRequest(Elastic.Clients.Elasticsearch.Name policyId) : base(r => r.Required("policy_id", policyId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotLifecycleManagementDeleteLifecycle;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "slm.delete_lifecycle";
}

/// <summary>
/// <para>Deletes an existing snapshot lifecycle policy.</para>
/// </summary>
public sealed partial class DeleteLifecycleRequestDescriptor : RequestDescriptor<DeleteLifecycleRequestDescriptor, DeleteLifecycleRequestParameters>
{
	internal DeleteLifecycleRequestDescriptor(Action<DeleteLifecycleRequestDescriptor> configure) => configure.Invoke(this);

	public DeleteLifecycleRequestDescriptor(Elastic.Clients.Elasticsearch.Name policyId) : base(r => r.Required("policy_id", policyId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotLifecycleManagementDeleteLifecycle;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "slm.delete_lifecycle";

	public DeleteLifecycleRequestDescriptor PolicyId(Elastic.Clients.Elasticsearch.Name policyId)
	{
		RouteValues.Required("policy_id", policyId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}