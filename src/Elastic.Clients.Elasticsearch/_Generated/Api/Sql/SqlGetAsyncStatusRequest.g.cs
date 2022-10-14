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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Sql;
public sealed class SqlGetAsyncStatusRequestParameters : RequestParameters<SqlGetAsyncStatusRequestParameters>
{
}

public sealed partial class SqlGetAsyncStatusRequest : PlainRequest<SqlGetAsyncStatusRequestParameters>
{
	public SqlGetAsyncStatusRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlGetAsyncStatus;
	protected override HttpMethod HttpMethod => HttpMethod.GET;
	protected override bool SupportsBody => false;
}

public sealed partial class SqlGetAsyncStatusRequestDescriptor<TDocument> : RequestDescriptor<SqlGetAsyncStatusRequestDescriptor<TDocument>, SqlGetAsyncStatusRequestParameters>
{
	internal SqlGetAsyncStatusRequestDescriptor(Action<SqlGetAsyncStatusRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public SqlGetAsyncStatusRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal SqlGetAsyncStatusRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlGetAsyncStatus;
	protected override HttpMethod HttpMethod => HttpMethod.GET;
	protected override bool SupportsBody => false;
	public SqlGetAsyncStatusRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

public sealed partial class SqlGetAsyncStatusRequestDescriptor : RequestDescriptor<SqlGetAsyncStatusRequestDescriptor, SqlGetAsyncStatusRequestParameters>
{
	internal SqlGetAsyncStatusRequestDescriptor(Action<SqlGetAsyncStatusRequestDescriptor> configure) => configure.Invoke(this);
	public SqlGetAsyncStatusRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal SqlGetAsyncStatusRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlGetAsyncStatus;
	protected override HttpMethod HttpMethod => HttpMethod.GET;
	protected override bool SupportsBody => false;
	public SqlGetAsyncStatusRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}