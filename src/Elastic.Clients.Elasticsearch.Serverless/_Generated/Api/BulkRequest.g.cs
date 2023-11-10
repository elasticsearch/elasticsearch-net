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

namespace Elastic.Clients.Elasticsearch.Serverless;

public sealed class BulkRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>The pipeline id to preprocess incoming documents with</para>
	/// </summary>
	public string? Pipeline { get => Q<string?>("pipeline"); set => Q("pipeline", value); }

	/// <summary>
	/// <para>If `true` then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` (the default) then do nothing with refreshes.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Serverless.Refresh?>("refresh"); set => Q("refresh", value); }

	/// <summary>
	/// <para>Specific routing value</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Serverless.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>True or false to return the _source field or not, or default list of fields to return, can be overridden on each sub-request</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfigParam? Source { get => Q<Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfigParam?>("_source"); set => Q("_source", value); }

	/// <summary>
	/// <para>Default list of fields to exclude from the returned _source field, can be overridden on each sub-request</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

	/// <summary>
	/// <para>Default list of fields to extract and return from the _source field, can be overridden on each sub-request</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("_source_includes"); set => Q("_source_includes", value); }

	/// <summary>
	/// <para>Explicit operation timeout</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>Sets the number of shard copies that must be active before proceeding with the bulk operation. Defaults to 1, meaning the primary shard only. Set to `all` for all shard copies, otherwise set to any non-negative value less than or equal to the total number of copies for the shard (number of replicas + 1)</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.Serverless.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

	/// <summary>
	/// <para>Sets require_alias for all incoming documents. Defaults to unset (false)</para>
	/// </summary>
	public bool? RequireAlias { get => Q<bool?>("require_alias"); set => Q("require_alias", value); }
}

/// <summary>
/// <para>Allows to perform multiple index/update/delete operations in a single request.</para>
/// </summary>
public sealed partial class BulkRequest : PlainRequest<BulkRequestParameters>
{
	public BulkRequest()
	{
	}

	public BulkRequest(Elastic.Clients.Elasticsearch.Serverless.IndexName? index) : base(r => r.Optional("index", index))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceBulk;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "bulk";

	/// <summary>
	/// <para>The pipeline id to preprocess incoming documents with</para>
	/// </summary>
	[JsonIgnore]
	public string? Pipeline { get => Q<string?>("pipeline"); set => Q("pipeline", value); }

	/// <summary>
	/// <para>If `true` then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` (the default) then do nothing with refreshes.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Serverless.Refresh?>("refresh"); set => Q("refresh", value); }

	/// <summary>
	/// <para>Specific routing value</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Serverless.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>True or false to return the _source field or not, or default list of fields to return, can be overridden on each sub-request</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfigParam? Source { get => Q<Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfigParam?>("_source"); set => Q("_source", value); }

	/// <summary>
	/// <para>Default list of fields to exclude from the returned _source field, can be overridden on each sub-request</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

	/// <summary>
	/// <para>Default list of fields to extract and return from the _source field, can be overridden on each sub-request</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Serverless.Fields?>("_source_includes"); set => Q("_source_includes", value); }

	/// <summary>
	/// <para>Explicit operation timeout</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>Sets the number of shard copies that must be active before proceeding with the bulk operation. Defaults to 1, meaning the primary shard only. Set to `all` for all shard copies, otherwise set to any non-negative value less than or equal to the total number of copies for the shard (number of replicas + 1)</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.Serverless.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

	/// <summary>
	/// <para>Sets require_alias for all incoming documents. Defaults to unset (false)</para>
	/// </summary>
	[JsonIgnore]
	public bool? RequireAlias { get => Q<bool?>("require_alias"); set => Q("require_alias", value); }
}

/// <summary>
/// <para>Allows to perform multiple index/update/delete operations in a single request.</para>
/// </summary>
public sealed partial class BulkRequestDescriptor<TDocument> : RequestDescriptor<BulkRequestDescriptor<TDocument>, BulkRequestParameters>
{
	internal BulkRequestDescriptor(Action<BulkRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public BulkRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceBulk;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "bulk";

	public BulkRequestDescriptor<TDocument> Source(Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfigParam? source) => Qs("_source", source);
	public BulkRequestDescriptor<TDocument> SourceExcludes(Elastic.Clients.Elasticsearch.Serverless.Fields? sourceExcludes) => Qs("_source_excludes", sourceExcludes);
	public BulkRequestDescriptor<TDocument> SourceIncludes(Elastic.Clients.Elasticsearch.Serverless.Fields? sourceIncludes) => Qs("_source_includes", sourceIncludes);
	public BulkRequestDescriptor<TDocument> Pipeline(string? pipeline) => Qs("pipeline", pipeline);
	public BulkRequestDescriptor<TDocument> Refresh(Elastic.Clients.Elasticsearch.Serverless.Refresh? refresh) => Qs("refresh", refresh);
	public BulkRequestDescriptor<TDocument> RequireAlias(bool? requireAlias = true) => Qs("require_alias", requireAlias);
	public BulkRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Serverless.Routing? routing) => Qs("routing", routing);
	public BulkRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout) => Qs("timeout", timeout);
	public BulkRequestDescriptor<TDocument> WaitForActiveShards(Elastic.Clients.Elasticsearch.Serverless.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);

	public BulkRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.Serverless.IndexName? index)
	{
		RouteValues.Optional("index", index);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>Allows to perform multiple index/update/delete operations in a single request.</para>
/// </summary>
public sealed partial class BulkRequestDescriptor : RequestDescriptor<BulkRequestDescriptor, BulkRequestParameters>
{
	internal BulkRequestDescriptor(Action<BulkRequestDescriptor> configure) => configure.Invoke(this);

	public BulkRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceBulk;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "bulk";

	public BulkRequestDescriptor Source(Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfigParam? source) => Qs("_source", source);
	public BulkRequestDescriptor SourceExcludes(Elastic.Clients.Elasticsearch.Serverless.Fields? sourceExcludes) => Qs("_source_excludes", sourceExcludes);
	public BulkRequestDescriptor SourceIncludes(Elastic.Clients.Elasticsearch.Serverless.Fields? sourceIncludes) => Qs("_source_includes", sourceIncludes);
	public BulkRequestDescriptor Pipeline(string? pipeline) => Qs("pipeline", pipeline);
	public BulkRequestDescriptor Refresh(Elastic.Clients.Elasticsearch.Serverless.Refresh? refresh) => Qs("refresh", refresh);
	public BulkRequestDescriptor RequireAlias(bool? requireAlias = true) => Qs("require_alias", requireAlias);
	public BulkRequestDescriptor Routing(Elastic.Clients.Elasticsearch.Serverless.Routing? routing) => Qs("routing", routing);
	public BulkRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout) => Qs("timeout", timeout);
	public BulkRequestDescriptor WaitForActiveShards(Elastic.Clients.Elasticsearch.Serverless.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);

	public BulkRequestDescriptor Index(Elastic.Clients.Elasticsearch.Serverless.IndexName? index)
	{
		RouteValues.Optional("index", index);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}