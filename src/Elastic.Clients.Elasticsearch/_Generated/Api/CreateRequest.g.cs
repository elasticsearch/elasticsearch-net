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

namespace Elastic.Clients.Elasticsearch;

public sealed partial class CreateRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>ID of the pipeline to use to preprocess incoming documents.<br/>If the index has a default ingest pipeline specified, then setting the value to `_none` disables the default ingest pipeline for this request.<br/>If a final pipeline is configured it will always run, regardless of the value of this parameter.</para>
	/// </summary>
	public string? Pipeline { get => Q<string?>("pipeline"); set => Q("pipeline", value); }

	/// <summary>
	/// <para>If `true`, Elasticsearch refreshes the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` do nothing with refreshes.<br/>Valid values: `true`, `false`, `wait_for`.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }

	/// <summary>
	/// <para>Custom value used to route operations to a specific shard.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>Period the request waits for the following operations: automatic index creation, dynamic mapping updates, waiting for active shards.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>Explicit version number for concurrency control.<br/>The specified version must match the current version of the document for the request to succeed.</para>
	/// </summary>
	public long? Version { get => Q<long?>("version"); set => Q("version", value); }

	/// <summary>
	/// <para>Specific version type: `external`, `external_gte`.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.VersionType?>("version_type"); set => Q("version_type", value); }

	/// <summary>
	/// <para>The number of shard copies that must be active before proceeding with the operation.<br/>Set to `all` or any positive integer up to the total number of shards in the index (`number_of_replicas+1`).</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
}

/// <summary>
/// <para>Adds a JSON document to the specified data stream or index and makes it searchable.<br/>If the target is an index and the document already exists, the request updates the document and increments its version.</para>
/// </summary>
public sealed partial class CreateRequest<TDocument> : PlainRequest<CreateRequestParameters>
{
	public CreateRequest(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceCreate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "create";

	/// <summary>
	/// <para>ID of the pipeline to use to preprocess incoming documents.<br/>If the index has a default ingest pipeline specified, then setting the value to `_none` disables the default ingest pipeline for this request.<br/>If a final pipeline is configured it will always run, regardless of the value of this parameter.</para>
	/// </summary>
	[JsonIgnore]
	public string? Pipeline { get => Q<string?>("pipeline"); set => Q("pipeline", value); }

	/// <summary>
	/// <para>If `true`, Elasticsearch refreshes the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` do nothing with refreshes.<br/>Valid values: `true`, `false`, `wait_for`.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }

	/// <summary>
	/// <para>Custom value used to route operations to a specific shard.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>Period the request waits for the following operations: automatic index creation, dynamic mapping updates, waiting for active shards.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>Explicit version number for concurrency control.<br/>The specified version must match the current version of the document for the request to succeed.</para>
	/// </summary>
	[JsonIgnore]
	public long? Version { get => Q<long?>("version"); set => Q("version", value); }

	/// <summary>
	/// <para>Specific version type: `external`, `external_gte`.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.VersionType?>("version_type"); set => Q("version_type", value); }

	/// <summary>
	/// <para>The number of shard copies that must be active before proceeding with the operation.<br/>Set to `all` or any positive integer up to the total number of shards in the index (`number_of_replicas+1`).</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
	[JsonIgnore]
	public TDocument Document { get; set; }
}

/// <summary>
/// <para>Adds a JSON document to the specified data stream or index and makes it searchable.<br/>If the target is an index and the document already exists, the request updates the document and increments its version.</para>
/// </summary>
public sealed partial class CreateRequestDescriptor<TDocument> : RequestDescriptor<CreateRequestDescriptor<TDocument>, CreateRequestParameters>
{
	internal CreateRequestDescriptor(Action<CreateRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public CreateRequestDescriptor(TDocument document, Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id)) => DocumentValue = document;

	public CreateRequestDescriptor(TDocument document) : this(document, typeof(TDocument), Elastic.Clients.Elasticsearch.Id.From(document))
	{
	}

	public CreateRequestDescriptor(TDocument document, Elastic.Clients.Elasticsearch.IndexName index) : this(document, index, Elastic.Clients.Elasticsearch.Id.From(document))
	{
	}

	public CreateRequestDescriptor(TDocument document, Elastic.Clients.Elasticsearch.Id id) : this(document, typeof(TDocument), id)
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceCreate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "create";

	public CreateRequestDescriptor<TDocument> Pipeline(string? pipeline) => Qs("pipeline", pipeline);
	public CreateRequestDescriptor<TDocument> Refresh(Elastic.Clients.Elasticsearch.Refresh? refresh) => Qs("refresh", refresh);
	public CreateRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public CreateRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public CreateRequestDescriptor<TDocument> Version(long? version) => Qs("version", version);
	public CreateRequestDescriptor<TDocument> VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType) => Qs("version_type", versionType);
	public CreateRequestDescriptor<TDocument> WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);

	public CreateRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	public CreateRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName index)
	{
		RouteValues.Required("index", index);
		return Self;
	}

	private TDocument DocumentValue { get; set; }

	public CreateRequestDescriptor<TDocument> Document(TDocument document)
	{
		DocumentValue = document;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		SourceSerialization.Serialize(DocumentValue, writer, settings.SourceSerializer);
	}
}