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
namespace Elastic.Clients.Elasticsearch;
public sealed class IndexRequestParameters : RequestParameters
{
	[JsonIgnore]
	public long? IfPrimaryTerm { get => Q<long?>("if_primary_term"); set => Q("if_primary_term", value); }

	[JsonIgnore]
	public long? IfSeqNo { get => Q<long?>("if_seq_no"); set => Q("if_seq_no", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.OpType? OpType { get => Q<Elastic.Clients.Elasticsearch.OpType?>("op_type"); set => Q("op_type", value); }

	[JsonIgnore]
	public string? Pipeline { get => Q<string?>("pipeline"); set => Q("pipeline", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	[JsonIgnore]
	public long? Version { get => Q<long?>("version"); set => Q("version", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.VersionType?>("version_type"); set => Q("version_type", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

	[JsonIgnore]
	public bool? RequireAlias { get => Q<bool?>("require_alias"); set => Q("require_alias", value); }
}

public sealed partial class IndexRequest<TDocument> : PlainRequest<IndexRequestParameters>
{
	public IndexRequest(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Required("index", index).Optional("id", id))
	{
	}

	public IndexRequest(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceIndex;
	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;
	internal override bool SupportsBody => true;
	[JsonIgnore]
	public TDocument Document { get; set; }

	[JsonIgnore]
	public long? IfPrimaryTerm { get => Q<long?>("if_primary_term"); set => Q("if_primary_term", value); }

	[JsonIgnore]
	public long? IfSeqNo { get => Q<long?>("if_seq_no"); set => Q("if_seq_no", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.OpType? OpType { get => Q<Elastic.Clients.Elasticsearch.OpType?>("op_type"); set => Q("op_type", value); }

	[JsonIgnore]
	public string? Pipeline { get => Q<string?>("pipeline"); set => Q("pipeline", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	[JsonIgnore]
	public long? Version { get => Q<long?>("version"); set => Q("version", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.VersionType?>("version_type"); set => Q("version_type", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

	[JsonIgnore]
	public bool? RequireAlias { get => Q<bool?>("require_alias"); set => Q("require_alias", value); }
}

public sealed partial class IndexRequestDescriptor<TDocument> : RequestDescriptor<IndexRequestDescriptor<TDocument>, IndexRequestParameters>
{
	internal IndexRequestDescriptor(Action<IndexRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	internal IndexRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Required("index", index).Optional("id", id))
	{
	}

	public IndexRequestDescriptor(TDocument document) : this(typeof(TDocument), Elasticsearch.Id.From(document)) => DocumentValue = document;
	public IndexRequestDescriptor(TDocument document, IndexName index, Id id) : this(index, id) => DocumentValue = document;
	public IndexRequestDescriptor(TDocument document, IndexName index) : this(index, Elasticsearch.Id.From(document)) => DocumentValue = document;
	public IndexRequestDescriptor(TDocument document, Id id) : this(typeof(TDocument), id) => DocumentValue = document;
	public IndexRequestDescriptor(Id id) : this(typeof(TDocument), id)
	{
	}

	public IndexRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
	{
	}

	internal IndexRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceIndex;
	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;
	internal override bool SupportsBody => true;
	public IndexRequestDescriptor<TDocument> IfPrimaryTerm(long? ifPrimaryTerm) => Qs("if_primary_term", ifPrimaryTerm);
	public IndexRequestDescriptor<TDocument> IfSeqNo(long? ifSeqNo) => Qs("if_seq_no", ifSeqNo);
	public IndexRequestDescriptor<TDocument> OpType(Elastic.Clients.Elasticsearch.OpType? opType) => Qs("op_type", opType);
	public IndexRequestDescriptor<TDocument> Pipeline(string? pipeline) => Qs("pipeline", pipeline);
	public IndexRequestDescriptor<TDocument> Refresh(Elastic.Clients.Elasticsearch.Refresh? refresh) => Qs("refresh", refresh);
	public IndexRequestDescriptor<TDocument> RequireAlias(bool? requireAlias = true) => Qs("require_alias", requireAlias);
	public IndexRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public IndexRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public IndexRequestDescriptor<TDocument> Version(long? version) => Qs("version", version);
	public IndexRequestDescriptor<TDocument> VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType) => Qs("version_type", versionType);
	public IndexRequestDescriptor<TDocument> WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
	public IndexRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id? id)
	{
		RouteValues.Optional("id", id);
		return Self;
	}

	public IndexRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName index)
	{
		RouteValues.Required("index", index);
		return Self;
	}

	private TDocument DocumentValue { get; set; }

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		SourceSerialization.Serialize(DocumentValue, writer, settings.SourceSerializer);
	}
}