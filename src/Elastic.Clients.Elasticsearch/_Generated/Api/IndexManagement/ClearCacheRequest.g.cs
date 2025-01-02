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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed partial class ClearCacheRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If <c>false</c>, the request returns an error if any wildcard expression, index alias, or <c>_all</c> value targets only missing or closed indices.
	/// This behavior applies even if the request targets other open indices.
	/// </para>
	/// </summary>
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>
	/// Type of index that wildcard patterns can match.
	/// If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.
	/// Supports comma-separated values, such as <c>open,hidden</c>.
	/// Valid values are: <c>all</c>, <c>open</c>, <c>closed</c>, <c>hidden</c>, <c>none</c>.
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, clears the fields cache.
	/// Use the <c>fields</c> parameter to clear the cache of specific fields only.
	/// </para>
	/// </summary>
	public bool? Fielddata { get => Q<bool?>("fielddata"); set => Q("fielddata", value); }

	/// <summary>
	/// <para>
	/// Comma-separated list of field names used to limit the <c>fielddata</c> parameter.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fields"); set => Q("fields", value); }

	/// <summary>
	/// <para>
	/// If <c>false</c>, the request returns an error if it targets a missing or closed index.
	/// </para>
	/// </summary>
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, clears the query cache.
	/// </para>
	/// </summary>
	public bool? Query { get => Q<bool?>("query"); set => Q("query", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, clears the request cache.
	/// </para>
	/// </summary>
	public bool? Request { get => Q<bool?>("request"); set => Q("request", value); }
}

/// <summary>
/// <para>
/// Clear the cache.
/// Clear the cache of one or more indices.
/// For data streams, the API clears the caches of the stream's backing indices.
/// </para>
/// </summary>
public sealed partial class ClearCacheRequest : PlainRequest<ClearCacheRequestParameters>
{
	public ClearCacheRequest()
	{
	}

	public ClearCacheRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementClearCache;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.clear_cache";

	/// <summary>
	/// <para>
	/// If <c>false</c>, the request returns an error if any wildcard expression, index alias, or <c>_all</c> value targets only missing or closed indices.
	/// This behavior applies even if the request targets other open indices.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>
	/// Type of index that wildcard patterns can match.
	/// If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.
	/// Supports comma-separated values, such as <c>open,hidden</c>.
	/// Valid values are: <c>all</c>, <c>open</c>, <c>closed</c>, <c>hidden</c>, <c>none</c>.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, clears the fields cache.
	/// Use the <c>fields</c> parameter to clear the cache of specific fields only.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? Fielddata { get => Q<bool?>("fielddata"); set => Q("fielddata", value); }

	/// <summary>
	/// <para>
	/// Comma-separated list of field names used to limit the <c>fielddata</c> parameter.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fields"); set => Q("fields", value); }

	/// <summary>
	/// <para>
	/// If <c>false</c>, the request returns an error if it targets a missing or closed index.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, clears the query cache.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? Query { get => Q<bool?>("query"); set => Q("query", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, clears the request cache.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? Request { get => Q<bool?>("request"); set => Q("request", value); }
}

/// <summary>
/// <para>
/// Clear the cache.
/// Clear the cache of one or more indices.
/// For data streams, the API clears the caches of the stream's backing indices.
/// </para>
/// </summary>
public sealed partial class ClearCacheRequestDescriptor<TDocument> : RequestDescriptor<ClearCacheRequestDescriptor<TDocument>, ClearCacheRequestParameters>
{
	internal ClearCacheRequestDescriptor(Action<ClearCacheRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public ClearCacheRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	public ClearCacheRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementClearCache;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.clear_cache";

	public ClearCacheRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public ClearCacheRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public ClearCacheRequestDescriptor<TDocument> Fielddata(bool? fielddata = true) => Qs("fielddata", fielddata);
	public ClearCacheRequestDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields? fields) => Qs("fields", fields);
	public ClearCacheRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public ClearCacheRequestDescriptor<TDocument> Query(bool? query = true) => Qs("query", query);
	public ClearCacheRequestDescriptor<TDocument> Request(bool? request = true) => Qs("request", request);

	public ClearCacheRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>
/// Clear the cache.
/// Clear the cache of one or more indices.
/// For data streams, the API clears the caches of the stream's backing indices.
/// </para>
/// </summary>
public sealed partial class ClearCacheRequestDescriptor : RequestDescriptor<ClearCacheRequestDescriptor, ClearCacheRequestParameters>
{
	internal ClearCacheRequestDescriptor(Action<ClearCacheRequestDescriptor> configure) => configure.Invoke(this);

	public ClearCacheRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	public ClearCacheRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementClearCache;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.clear_cache";

	public ClearCacheRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public ClearCacheRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public ClearCacheRequestDescriptor Fielddata(bool? fielddata = true) => Qs("fielddata", fielddata);
	public ClearCacheRequestDescriptor Fields(Elastic.Clients.Elasticsearch.Fields? fields) => Qs("fields", fields);
	public ClearCacheRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public ClearCacheRequestDescriptor Query(bool? query = true) => Qs("query", query);
	public ClearCacheRequestDescriptor Request(bool? request = true) => Qs("request", request);

	public ClearCacheRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}