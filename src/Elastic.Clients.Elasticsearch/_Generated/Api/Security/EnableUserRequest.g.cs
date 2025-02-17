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

public sealed partial class EnableUserRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If <c>true</c> (the default) then refresh the affected shards to make this operation visible to search, if <c>wait_for</c> then wait for a refresh to make this operation visible to search, if <c>false</c> then do nothing with refreshes.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }
}

/// <summary>
/// <para>
/// Enable users.
/// </para>
/// <para>
/// Enable users in the native realm.
/// </para>
/// </summary>
public sealed partial class EnableUserRequest : PlainRequest<EnableUserRequestParameters>
{
	public EnableUserRequest(Elastic.Clients.Elasticsearch.Username username) : base(r => r.Required("username", username))
	{
	}

	[JsonConstructor]
	internal EnableUserRequest()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityEnableUser;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => false;

	internal override string OperationName => "security.enable_user";

	/// <summary>
	/// <para>
	/// The username of the user to enable
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Username Username { get => P<Elastic.Clients.Elasticsearch.Username>("username"); set => PR("username", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c> (the default) then refresh the affected shards to make this operation visible to search, if <c>wait_for</c> then wait for a refresh to make this operation visible to search, if <c>false</c> then do nothing with refreshes.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }
}

/// <summary>
/// <para>
/// Enable users.
/// </para>
/// <para>
/// Enable users in the native realm.
/// </para>
/// </summary>
public sealed partial class EnableUserRequestDescriptor : RequestDescriptor<EnableUserRequestDescriptor, EnableUserRequestParameters>
{
	internal EnableUserRequestDescriptor(Action<EnableUserRequestDescriptor> configure) => configure.Invoke(this);

	public EnableUserRequestDescriptor(Elastic.Clients.Elasticsearch.Username username) : base(r => r.Required("username", username))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityEnableUser;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => false;

	internal override string OperationName => "security.enable_user";

	public EnableUserRequestDescriptor Refresh(Elastic.Clients.Elasticsearch.Refresh? refresh) => Qs("refresh", refresh);

	public EnableUserRequestDescriptor Username(Elastic.Clients.Elasticsearch.Username username)
	{
		RouteValues.Required("username", username);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}