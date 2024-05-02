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

public sealed partial class FlushRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If `false`, the request returns an error if any wildcard expression, index alias, or `_all` value targets only missing or closed indices.<br/>This behavior applies even if the request targets other open indices.</para>
	/// </summary>
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>Type of index that wildcard patterns can match.<br/>If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.<br/>Supports comma-separated values, such as `open,hidden`.<br/>Valid values are: `all`, `open`, `closed`, `hidden`, `none`.</para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>If `true`, the request forces a flush even if there are no changes to commit to the index.</para>
	/// </summary>
	public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }

	/// <summary>
	/// <para>If `false`, the request returns an error if it targets a missing or closed index.</para>
	/// </summary>
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>If `true`, the flush operation blocks until execution when another flush operation is running.<br/>If `false`, Elasticsearch returns an error if you request a flush when another flush operation is running.</para>
	/// </summary>
	public bool? WaitIfOngoing { get => Q<bool?>("wait_if_ongoing"); set => Q("wait_if_ongoing", value); }
}

/// <summary>
/// <para>Flushes one or more data streams or indices.</para>
/// </summary>
public sealed partial class FlushRequest : PlainRequest<FlushRequestParameters>
{
	public FlushRequest()
	{
	}

	public FlushRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementFlush;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.flush";

	/// <summary>
	/// <para>If `false`, the request returns an error if any wildcard expression, index alias, or `_all` value targets only missing or closed indices.<br/>This behavior applies even if the request targets other open indices.</para>
	/// </summary>
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>Type of index that wildcard patterns can match.<br/>If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.<br/>Supports comma-separated values, such as `open,hidden`.<br/>Valid values are: `all`, `open`, `closed`, `hidden`, `none`.</para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>If `true`, the request forces a flush even if there are no changes to commit to the index.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }

	/// <summary>
	/// <para>If `false`, the request returns an error if it targets a missing or closed index.</para>
	/// </summary>
	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>If `true`, the flush operation blocks until execution when another flush operation is running.<br/>If `false`, Elasticsearch returns an error if you request a flush when another flush operation is running.</para>
	/// </summary>
	[JsonIgnore]
	public bool? WaitIfOngoing { get => Q<bool?>("wait_if_ongoing"); set => Q("wait_if_ongoing", value); }
}

/// <summary>
/// <para>Flushes one or more data streams or indices.</para>
/// </summary>
public sealed partial class FlushRequestDescriptor<TDocument> : RequestDescriptor<FlushRequestDescriptor<TDocument>, FlushRequestParameters>
{
	internal FlushRequestDescriptor(Action<FlushRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public FlushRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	public FlushRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementFlush;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.flush";

	public FlushRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public FlushRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public FlushRequestDescriptor<TDocument> Force(bool? force = true) => Qs("force", force);
	public FlushRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public FlushRequestDescriptor<TDocument> WaitIfOngoing(bool? waitIfOngoing = true) => Qs("wait_if_ongoing", waitIfOngoing);

	public FlushRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>Flushes one or more data streams or indices.</para>
/// </summary>
public sealed partial class FlushRequestDescriptor : RequestDescriptor<FlushRequestDescriptor, FlushRequestParameters>
{
	internal FlushRequestDescriptor(Action<FlushRequestDescriptor> configure) => configure.Invoke(this);

	public FlushRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	public FlushRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementFlush;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.flush";

	public FlushRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public FlushRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public FlushRequestDescriptor Force(bool? force = true) => Qs("force", force);
	public FlushRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public FlushRequestDescriptor WaitIfOngoing(bool? waitIfOngoing = true) => Qs("wait_if_ongoing", waitIfOngoing);

	public FlushRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}