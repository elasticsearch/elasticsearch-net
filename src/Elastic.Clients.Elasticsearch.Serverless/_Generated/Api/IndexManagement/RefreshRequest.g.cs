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

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class RefreshRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If `false`, the request returns an error if any wildcard expression, index alias, or `_all` value targets only missing or closed indices.<br/>This behavior applies even if the request targets other open indices.</para>
	/// </summary>
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>Type of index that wildcard patterns can match.<br/>If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.<br/>Supports comma-separated values, such as `open,hidden`.<br/>Valid values are: `all`, `open`, `closed`, `hidden`, `none`.</para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>If `false`, the request returns an error if it targets a missing or closed index.</para>
	/// </summary>
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }
}

/// <summary>
/// <para>A refresh makes recent operations performed on one or more indices available for search.<br/>For data streams, the API runs the refresh operation on the stream’s backing indices.</para>
/// </summary>
public sealed partial class RefreshRequest : PlainRequest<RefreshRequestParameters>
{
	public RefreshRequest()
	{
	}

	public RefreshRequest(Elastic.Clients.Elasticsearch.Serverless.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementRefresh;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.refresh";

	/// <summary>
	/// <para>If `false`, the request returns an error if any wildcard expression, index alias, or `_all` value targets only missing or closed indices.<br/>This behavior applies even if the request targets other open indices.</para>
	/// </summary>
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>Type of index that wildcard patterns can match.<br/>If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.<br/>Supports comma-separated values, such as `open,hidden`.<br/>Valid values are: `all`, `open`, `closed`, `hidden`, `none`.</para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>If `false`, the request returns an error if it targets a missing or closed index.</para>
	/// </summary>
	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }
}

/// <summary>
/// <para>A refresh makes recent operations performed on one or more indices available for search.<br/>For data streams, the API runs the refresh operation on the stream’s backing indices.</para>
/// </summary>
public sealed partial class RefreshRequestDescriptor<TDocument> : RequestDescriptor<RefreshRequestDescriptor<TDocument>, RefreshRequestParameters>
{
	internal RefreshRequestDescriptor(Action<RefreshRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public RefreshRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementRefresh;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.refresh";

	public RefreshRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public RefreshRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public RefreshRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);

	public RefreshRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Serverless.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>A refresh makes recent operations performed on one or more indices available for search.<br/>For data streams, the API runs the refresh operation on the stream’s backing indices.</para>
/// </summary>
public sealed partial class RefreshRequestDescriptor : RequestDescriptor<RefreshRequestDescriptor, RefreshRequestParameters>
{
	internal RefreshRequestDescriptor(Action<RefreshRequestDescriptor> configure) => configure.Invoke(this);

	public RefreshRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementRefresh;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.refresh";

	public RefreshRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public RefreshRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public RefreshRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);

	public RefreshRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Serverless.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}