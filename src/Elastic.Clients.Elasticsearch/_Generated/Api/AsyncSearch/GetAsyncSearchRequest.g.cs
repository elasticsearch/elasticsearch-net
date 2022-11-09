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
namespace Elastic.Clients.Elasticsearch.AsyncSearch;
public sealed class GetAsyncSearchRequestParameters : RequestParameters
{
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? KeepAlive { get => Q<Elastic.Clients.Elasticsearch.Duration?>("keep_alive"); set => Q("keep_alive", value); }

	[JsonIgnore]
	public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? WaitForCompletionTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("wait_for_completion_timeout"); set => Q("wait_for_completion_timeout", value); }
}

public sealed partial class GetAsyncSearchRequest : PlainRequest<GetAsyncSearchRequestParameters>
{
	public GetAsyncSearchRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.AsyncSearchGet;
	internal override HttpMethod HttpMethod => HttpMethod.GET;
	internal override bool SupportsBody => false;
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? KeepAlive { get => Q<Elastic.Clients.Elasticsearch.Duration?>("keep_alive"); set => Q("keep_alive", value); }

	[JsonIgnore]
	public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? WaitForCompletionTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("wait_for_completion_timeout"); set => Q("wait_for_completion_timeout", value); }
}

public sealed partial class GetAsyncSearchRequestDescriptor<TDocument> : RequestDescriptor<GetAsyncSearchRequestDescriptor<TDocument>, GetAsyncSearchRequestParameters>
{
	internal GetAsyncSearchRequestDescriptor(Action<GetAsyncSearchRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public GetAsyncSearchRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal GetAsyncSearchRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.AsyncSearchGet;
	internal override HttpMethod HttpMethod => HttpMethod.GET;
	internal override bool SupportsBody => false;
	public GetAsyncSearchRequestDescriptor<TDocument> KeepAlive(Elastic.Clients.Elasticsearch.Duration? keepAlive) => Qs("keep_alive", keepAlive);
	public GetAsyncSearchRequestDescriptor<TDocument> TypedKeys(bool? typedKeys = true) => Qs("typed_keys", typedKeys);
	public GetAsyncSearchRequestDescriptor<TDocument> WaitForCompletionTimeout(Elastic.Clients.Elasticsearch.Duration? waitForCompletionTimeout) => Qs("wait_for_completion_timeout", waitForCompletionTimeout);
	public GetAsyncSearchRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

public sealed partial class GetAsyncSearchRequestDescriptor : RequestDescriptor<GetAsyncSearchRequestDescriptor, GetAsyncSearchRequestParameters>
{
	internal GetAsyncSearchRequestDescriptor(Action<GetAsyncSearchRequestDescriptor> configure) => configure.Invoke(this);
	public GetAsyncSearchRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal GetAsyncSearchRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.AsyncSearchGet;
	internal override HttpMethod HttpMethod => HttpMethod.GET;
	internal override bool SupportsBody => false;
	public GetAsyncSearchRequestDescriptor KeepAlive(Elastic.Clients.Elasticsearch.Duration? keepAlive) => Qs("keep_alive", keepAlive);
	public GetAsyncSearchRequestDescriptor TypedKeys(bool? typedKeys = true) => Qs("typed_keys", typedKeys);
	public GetAsyncSearchRequestDescriptor WaitForCompletionTimeout(Elastic.Clients.Elasticsearch.Duration? waitForCompletionTimeout) => Qs("wait_for_completion_timeout", waitForCompletionTimeout);
	public GetAsyncSearchRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}