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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Sql;

public sealed class DeleteAsyncRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Deletes an async SQL search or a stored synchronous SQL search. If the search is still running, the API cancels it.</para>
/// </summary>
public sealed partial class DeleteAsyncRequest : PlainRequest<DeleteAsyncRequestParameters>
{
	public DeleteAsyncRequest(Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SqlDeleteAsync;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "sql.delete_async";
}

/// <summary>
/// <para>Deletes an async SQL search or a stored synchronous SQL search. If the search is still running, the API cancels it.</para>
/// </summary>
public sealed partial class DeleteAsyncRequestDescriptor<TDocument> : RequestDescriptor<DeleteAsyncRequestDescriptor<TDocument>, DeleteAsyncRequestParameters>
{
	internal DeleteAsyncRequestDescriptor(Action<DeleteAsyncRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public DeleteAsyncRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("id", id))
	{
	}

	internal DeleteAsyncRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SqlDeleteAsync;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "sql.delete_async";

	public DeleteAsyncRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>Deletes an async SQL search or a stored synchronous SQL search. If the search is still running, the API cancels it.</para>
/// </summary>
public sealed partial class DeleteAsyncRequestDescriptor : RequestDescriptor<DeleteAsyncRequestDescriptor, DeleteAsyncRequestParameters>
{
	internal DeleteAsyncRequestDescriptor(Action<DeleteAsyncRequestDescriptor> configure) => configure.Invoke(this);

	public DeleteAsyncRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("id", id))
	{
	}

	internal DeleteAsyncRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SqlDeleteAsync;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "sql.delete_async";

	public DeleteAsyncRequestDescriptor Id(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}