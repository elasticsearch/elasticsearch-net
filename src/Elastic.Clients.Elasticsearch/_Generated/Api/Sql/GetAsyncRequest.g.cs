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

namespace Elastic.Clients.Elasticsearch.Sql;

public sealed partial class GetAsyncRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Separator for CSV results. The API only supports this parameter for CSV responses.</para>
	/// </summary>
	public string? Delimiter { get => Q<string?>("delimiter"); set => Q("delimiter", value); }

	/// <summary>
	/// <para>Format for the response. You must specify a format using this parameter or the<br/>Accept HTTP header. If you specify both, the API uses this parameter.</para>
	/// </summary>
	public string? Format { get => Q<string?>("format"); set => Q("format", value); }

	/// <summary>
	/// <para>Retention period for the search and its results. Defaults<br/>to the `keep_alive` period for the original SQL search.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? KeepAlive { get => Q<Elastic.Clients.Elasticsearch.Duration?>("keep_alive"); set => Q("keep_alive", value); }

	/// <summary>
	/// <para>Period to wait for complete results. Defaults to no timeout,<br/>meaning the request waits for complete search results.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? WaitForCompletionTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("wait_for_completion_timeout"); set => Q("wait_for_completion_timeout", value); }
}

/// <summary>
/// <para>Returns the current status and available results for an async SQL search or stored synchronous SQL search</para>
/// </summary>
public sealed partial class GetAsyncRequest : PlainRequest<GetAsyncRequestParameters>
{
	public GetAsyncRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SqlGetAsync;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "sql.get_async";

	/// <summary>
	/// <para>Separator for CSV results. The API only supports this parameter for CSV responses.</para>
	/// </summary>
	[JsonIgnore]
	public string? Delimiter { get => Q<string?>("delimiter"); set => Q("delimiter", value); }

	/// <summary>
	/// <para>Format for the response. You must specify a format using this parameter or the<br/>Accept HTTP header. If you specify both, the API uses this parameter.</para>
	/// </summary>
	[JsonIgnore]
	public string? Format { get => Q<string?>("format"); set => Q("format", value); }

	/// <summary>
	/// <para>Retention period for the search and its results. Defaults<br/>to the `keep_alive` period for the original SQL search.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? KeepAlive { get => Q<Elastic.Clients.Elasticsearch.Duration?>("keep_alive"); set => Q("keep_alive", value); }

	/// <summary>
	/// <para>Period to wait for complete results. Defaults to no timeout,<br/>meaning the request waits for complete search results.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? WaitForCompletionTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("wait_for_completion_timeout"); set => Q("wait_for_completion_timeout", value); }
}

/// <summary>
/// <para>Returns the current status and available results for an async SQL search or stored synchronous SQL search</para>
/// </summary>
public sealed partial class GetAsyncRequestDescriptor<TDocument> : RequestDescriptor<GetAsyncRequestDescriptor<TDocument>, GetAsyncRequestParameters>
{
	internal GetAsyncRequestDescriptor(Action<GetAsyncRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GetAsyncRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SqlGetAsync;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "sql.get_async";

	public GetAsyncRequestDescriptor<TDocument> Delimiter(string? delimiter) => Qs("delimiter", delimiter);
	public GetAsyncRequestDescriptor<TDocument> Format(string? format) => Qs("format", format);
	public GetAsyncRequestDescriptor<TDocument> KeepAlive(Elastic.Clients.Elasticsearch.Duration? keepAlive) => Qs("keep_alive", keepAlive);
	public GetAsyncRequestDescriptor<TDocument> WaitForCompletionTimeout(Elastic.Clients.Elasticsearch.Duration? waitForCompletionTimeout) => Qs("wait_for_completion_timeout", waitForCompletionTimeout);

	public GetAsyncRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>Returns the current status and available results for an async SQL search or stored synchronous SQL search</para>
/// </summary>
public sealed partial class GetAsyncRequestDescriptor : RequestDescriptor<GetAsyncRequestDescriptor, GetAsyncRequestParameters>
{
	internal GetAsyncRequestDescriptor(Action<GetAsyncRequestDescriptor> configure) => configure.Invoke(this);

	public GetAsyncRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SqlGetAsync;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "sql.get_async";

	public GetAsyncRequestDescriptor Delimiter(string? delimiter) => Qs("delimiter", delimiter);
	public GetAsyncRequestDescriptor Format(string? format) => Qs("format", format);
	public GetAsyncRequestDescriptor KeepAlive(Elastic.Clients.Elasticsearch.Duration? keepAlive) => Qs("keep_alive", keepAlive);
	public GetAsyncRequestDescriptor WaitForCompletionTimeout(Elastic.Clients.Elasticsearch.Duration? waitForCompletionTimeout) => Qs("wait_for_completion_timeout", waitForCompletionTimeout);

	public GetAsyncRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}