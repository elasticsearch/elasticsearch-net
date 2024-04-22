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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed partial class ShardStoresRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If false, the request returns an error if any wildcard expression, index alias, or _all<br/>value targets only missing or closed indices. This behavior applies even if the request<br/>targets other open indices.</para>
	/// </summary>
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>Type of index that wildcard patterns can match. If the request can target data streams,<br/>this argument determines whether wildcard expressions match hidden data streams.</para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>If true, missing or closed indices are not included in the response.</para>
	/// </summary>
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>List of shard health statuses used to limit the request.</para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.IndexManagement.ShardStoreStatus>? Status { get => Q<ICollection<Elastic.Clients.Elasticsearch.IndexManagement.ShardStoreStatus>?>("status"); set => Q("status", value); }
}

/// <summary>
/// <para>Retrieves store information about replica shards in one or more indices.<br/>For data streams, the API retrieves store information for the stream’s backing indices.</para>
/// </summary>
public sealed partial class ShardStoresRequest : PlainRequest<ShardStoresRequestParameters>
{
	public ShardStoresRequest()
	{
	}

	public ShardStoresRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementShardStores;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.shard_stores";

	/// <summary>
	/// <para>If false, the request returns an error if any wildcard expression, index alias, or _all<br/>value targets only missing or closed indices. This behavior applies even if the request<br/>targets other open indices.</para>
	/// </summary>
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>Type of index that wildcard patterns can match. If the request can target data streams,<br/>this argument determines whether wildcard expressions match hidden data streams.</para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>If true, missing or closed indices are not included in the response.</para>
	/// </summary>
	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>List of shard health statuses used to limit the request.</para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.IndexManagement.ShardStoreStatus>? Status { get => Q<ICollection<Elastic.Clients.Elasticsearch.IndexManagement.ShardStoreStatus>?>("status"); set => Q("status", value); }
}

/// <summary>
/// <para>Retrieves store information about replica shards in one or more indices.<br/>For data streams, the API retrieves store information for the stream’s backing indices.</para>
/// </summary>
public sealed partial class ShardStoresRequestDescriptor<TDocument> : RequestDescriptor<ShardStoresRequestDescriptor<TDocument>, ShardStoresRequestParameters>
{
	internal ShardStoresRequestDescriptor(Action<ShardStoresRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public ShardStoresRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	public ShardStoresRequestDescriptor() : this(typeof(TDocument))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementShardStores;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.shard_stores";

	public ShardStoresRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public ShardStoresRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public ShardStoresRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public ShardStoresRequestDescriptor<TDocument> Status(ICollection<Elastic.Clients.Elasticsearch.IndexManagement.ShardStoreStatus>? status) => Qs("status", status);

	public ShardStoresRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>Retrieves store information about replica shards in one or more indices.<br/>For data streams, the API retrieves store information for the stream’s backing indices.</para>
/// </summary>
public sealed partial class ShardStoresRequestDescriptor : RequestDescriptor<ShardStoresRequestDescriptor, ShardStoresRequestParameters>
{
	internal ShardStoresRequestDescriptor(Action<ShardStoresRequestDescriptor> configure) => configure.Invoke(this);

	public ShardStoresRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	public ShardStoresRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementShardStores;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.shard_stores";

	public ShardStoresRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public ShardStoresRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public ShardStoresRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public ShardStoresRequestDescriptor Status(ICollection<Elastic.Clients.Elasticsearch.IndexManagement.ShardStoreStatus>? status) => Qs("status", status);

	public ShardStoresRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}