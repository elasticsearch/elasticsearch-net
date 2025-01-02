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

namespace Elastic.Clients.Elasticsearch.Eql;

public sealed partial class EqlDeleteRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Delete an async EQL search.
/// Delete an async EQL search or a stored synchronous EQL search.
/// The API also deletes results for the search.
/// </para>
/// </summary>
public sealed partial class EqlDeleteRequest : PlainRequest<EqlDeleteRequestParameters>
{
	public EqlDeleteRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EqlDelete;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "eql.delete";
}

/// <summary>
/// <para>
/// Delete an async EQL search.
/// Delete an async EQL search or a stored synchronous EQL search.
/// The API also deletes results for the search.
/// </para>
/// </summary>
public sealed partial class EqlDeleteRequestDescriptor<TDocument> : RequestDescriptor<EqlDeleteRequestDescriptor<TDocument>, EqlDeleteRequestParameters>
{
	internal EqlDeleteRequestDescriptor(Action<EqlDeleteRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public EqlDeleteRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EqlDelete;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "eql.delete";

	public EqlDeleteRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>
/// Delete an async EQL search.
/// Delete an async EQL search or a stored synchronous EQL search.
/// The API also deletes results for the search.
/// </para>
/// </summary>
public sealed partial class EqlDeleteRequestDescriptor : RequestDescriptor<EqlDeleteRequestDescriptor, EqlDeleteRequestParameters>
{
	internal EqlDeleteRequestDescriptor(Action<EqlDeleteRequestDescriptor> configure) => configure.Invoke(this);

	public EqlDeleteRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EqlDelete;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "eql.delete";

	public EqlDeleteRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}