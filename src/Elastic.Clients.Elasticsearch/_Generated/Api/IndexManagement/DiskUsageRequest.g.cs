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

public sealed partial class DiskUsageRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If false, the request returns an error if any wildcard expression, index alias, or `_all` value targets only missing or closed indices.<br/>This behavior applies even if the request targets other open indices.<br/>For example, a request targeting `foo*,bar*` returns an error if an index starts with `foo` but no index starts with `bar`.</para>
	/// </summary>
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>Type of index that wildcard patterns can match.<br/>If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.<br/>Supports comma-separated values, such as `open,hidden`.</para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>If `true`, the API performs a flush before analysis.<br/>If `false`, the response may not include uncommitted data.</para>
	/// </summary>
	public bool? Flush { get => Q<bool?>("flush"); set => Q("flush", value); }

	/// <summary>
	/// <para>If `true`, missing or closed indices are not included in the response.</para>
	/// </summary>
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>Analyzing field disk usage is resource-intensive.<br/>To use the API, this parameter must be set to `true`.</para>
	/// </summary>
	public bool? RunExpensiveTasks { get => Q<bool?>("run_expensive_tasks"); set => Q("run_expensive_tasks", value); }
}

/// <summary>
/// <para>Analyzes the disk usage of each field of an index or data stream.</para>
/// </summary>
public sealed partial class DiskUsageRequest : PlainRequest<DiskUsageRequestParameters>
{
	public DiskUsageRequest(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementDiskUsage;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.disk_usage";

	/// <summary>
	/// <para>If false, the request returns an error if any wildcard expression, index alias, or `_all` value targets only missing or closed indices.<br/>This behavior applies even if the request targets other open indices.<br/>For example, a request targeting `foo*,bar*` returns an error if an index starts with `foo` but no index starts with `bar`.</para>
	/// </summary>
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>Type of index that wildcard patterns can match.<br/>If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.<br/>Supports comma-separated values, such as `open,hidden`.</para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>If `true`, the API performs a flush before analysis.<br/>If `false`, the response may not include uncommitted data.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Flush { get => Q<bool?>("flush"); set => Q("flush", value); }

	/// <summary>
	/// <para>If `true`, missing or closed indices are not included in the response.</para>
	/// </summary>
	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>Analyzing field disk usage is resource-intensive.<br/>To use the API, this parameter must be set to `true`.</para>
	/// </summary>
	[JsonIgnore]
	public bool? RunExpensiveTasks { get => Q<bool?>("run_expensive_tasks"); set => Q("run_expensive_tasks", value); }
}

/// <summary>
/// <para>Analyzes the disk usage of each field of an index or data stream.</para>
/// </summary>
public sealed partial class DiskUsageRequestDescriptor<TDocument> : RequestDescriptor<DiskUsageRequestDescriptor<TDocument>, DiskUsageRequestParameters>
{
	internal DiskUsageRequestDescriptor(Action<DiskUsageRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public DiskUsageRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	public DiskUsageRequestDescriptor() : this(typeof(TDocument))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementDiskUsage;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.disk_usage";

	public DiskUsageRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public DiskUsageRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public DiskUsageRequestDescriptor<TDocument> Flush(bool? flush = true) => Qs("flush", flush);
	public DiskUsageRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public DiskUsageRequestDescriptor<TDocument> RunExpensiveTasks(bool? runExpensiveTasks = true) => Qs("run_expensive_tasks", runExpensiveTasks);

	public DiskUsageRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>Analyzes the disk usage of each field of an index or data stream.</para>
/// </summary>
public sealed partial class DiskUsageRequestDescriptor : RequestDescriptor<DiskUsageRequestDescriptor, DiskUsageRequestParameters>
{
	internal DiskUsageRequestDescriptor(Action<DiskUsageRequestDescriptor> configure) => configure.Invoke(this);

	public DiskUsageRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementDiskUsage;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.disk_usage";

	public DiskUsageRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public DiskUsageRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public DiskUsageRequestDescriptor Flush(bool? flush = true) => Qs("flush", flush);
	public DiskUsageRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public DiskUsageRequestDescriptor RunExpensiveTasks(bool? runExpensiveTasks = true) => Qs("run_expensive_tasks", runExpensiveTasks);

	public DiskUsageRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}