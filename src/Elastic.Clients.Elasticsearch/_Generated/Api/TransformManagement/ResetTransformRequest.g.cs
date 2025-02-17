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

namespace Elastic.Clients.Elasticsearch.TransformManagement;

public sealed partial class ResetTransformRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If this value is <c>true</c>, the transform is reset regardless of its current state. If it's <c>false</c>, the transform
	/// must be stopped before it can be reset.
	/// </para>
	/// </summary>
	public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }
}

/// <summary>
/// <para>
/// Reset a transform.
/// Resets a transform.
/// Before you can reset it, you must stop it; alternatively, use the <c>force</c> query parameter.
/// If the destination index was created by the transform, it is deleted.
/// </para>
/// </summary>
public sealed partial class ResetTransformRequest : PlainRequest<ResetTransformRequestParameters>
{
	public ResetTransformRequest(Elastic.Clients.Elasticsearch.Id transformId) : base(r => r.Required("transform_id", transformId))
	{
	}

	[JsonConstructor]
	internal ResetTransformRequest()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.TransformManagementResetTransform;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "transform.reset_transform";

	/// <summary>
	/// <para>
	/// Identifier for the transform. This identifier can contain lowercase alphanumeric characters (a-z and 0-9),
	/// hyphens, and underscores. It has a 64 character limit and must start and end with alphanumeric characters.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Id TransformId { get => P<Elastic.Clients.Elasticsearch.Id>("transform_id"); set => PR("transform_id", value); }

	/// <summary>
	/// <para>
	/// If this value is <c>true</c>, the transform is reset regardless of its current state. If it's <c>false</c>, the transform
	/// must be stopped before it can be reset.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }
}

/// <summary>
/// <para>
/// Reset a transform.
/// Resets a transform.
/// Before you can reset it, you must stop it; alternatively, use the <c>force</c> query parameter.
/// If the destination index was created by the transform, it is deleted.
/// </para>
/// </summary>
public sealed partial class ResetTransformRequestDescriptor : RequestDescriptor<ResetTransformRequestDescriptor, ResetTransformRequestParameters>
{
	internal ResetTransformRequestDescriptor(Action<ResetTransformRequestDescriptor> configure) => configure.Invoke(this);

	public ResetTransformRequestDescriptor(Elastic.Clients.Elasticsearch.Id transformId) : base(r => r.Required("transform_id", transformId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.TransformManagementResetTransform;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "transform.reset_transform";

	public ResetTransformRequestDescriptor Force(bool? force = true) => Qs("force", force);

	public ResetTransformRequestDescriptor TransformId(Elastic.Clients.Elasticsearch.Id transformId)
	{
		RouteValues.Required("transform_id", transformId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}