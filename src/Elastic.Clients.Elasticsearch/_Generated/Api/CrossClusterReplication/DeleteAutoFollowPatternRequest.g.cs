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

namespace Elastic.Clients.Elasticsearch.CrossClusterReplication;

public sealed partial class DeleteAutoFollowPatternRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Delete auto-follow patterns.
/// Delete a collection of cross-cluster replication auto-follow patterns.
/// </para>
/// </summary>
public sealed partial class DeleteAutoFollowPatternRequest : PlainRequest<DeleteAutoFollowPatternRequestParameters>
{
	public DeleteAutoFollowPatternRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.CrossClusterReplicationDeleteAutoFollowPattern;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ccr.delete_auto_follow_pattern";
}

/// <summary>
/// <para>
/// Delete auto-follow patterns.
/// Delete a collection of cross-cluster replication auto-follow patterns.
/// </para>
/// </summary>
public sealed partial class DeleteAutoFollowPatternRequestDescriptor : RequestDescriptor<DeleteAutoFollowPatternRequestDescriptor, DeleteAutoFollowPatternRequestParameters>
{
	internal DeleteAutoFollowPatternRequestDescriptor(Action<DeleteAutoFollowPatternRequestDescriptor> configure) => configure.Invoke(this);

	public DeleteAutoFollowPatternRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.CrossClusterReplicationDeleteAutoFollowPattern;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ccr.delete_auto_follow_pattern";

	public DeleteAutoFollowPatternRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}