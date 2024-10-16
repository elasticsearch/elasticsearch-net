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

namespace Elastic.Clients.Elasticsearch;

public sealed partial class ExistsSourceRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Specifies the node or shard the operation should be performed on.
	/// Random by default.
	/// </para>
	/// </summary>
	public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

	/// <summary>
	/// <para>
	/// If true, the request is real-time as opposed to near-real-time.
	/// </para>
	/// </summary>
	public bool? Realtime { get => Q<bool?>("realtime"); set => Q("realtime", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, Elasticsearch refreshes all shards involved in the delete by query after the request completes.
	/// </para>
	/// </summary>
	public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

	/// <summary>
	/// <para>
	/// Target the specified primary shard.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>
	/// <c>true</c> or <c>false</c> to return the <c>_source</c> field or not, or a list of fields to return.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Core.Search.SourceConfigParam? Source { get => Q<Elastic.Clients.Elasticsearch.Core.Search.SourceConfigParam?>("_source"); set => Q("_source", value); }

	/// <summary>
	/// <para>
	/// A comma-separated list of source fields to exclude in the response.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

	/// <summary>
	/// <para>
	/// A comma-separated list of source fields to include in the response.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_includes"); set => Q("_source_includes", value); }

	/// <summary>
	/// <para>
	/// Explicit version number for concurrency control.
	/// The specified version must match the current version of the document for the request to succeed.
	/// </para>
	/// </summary>
	public long? Version { get => Q<long?>("version"); set => Q("version", value); }

	/// <summary>
	/// <para>
	/// Specific version type: <c>external</c>, <c>external_gte</c>.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.VersionType?>("version_type"); set => Q("version_type", value); }
}

/// <summary>
/// <para>
/// Check for a document source.
/// Checks if a document's <c>_source</c> is stored.
/// </para>
/// </summary>
public sealed partial class ExistsSourceRequest : PlainRequest<ExistsSourceRequestParameters>
{
	public ExistsSourceRequest(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceExistsSource;

	protected override HttpMethod StaticHttpMethod => HttpMethod.HEAD;

	internal override bool SupportsBody => false;

	internal override string OperationName => "exists_source";

	/// <summary>
	/// <para>
	/// Specifies the node or shard the operation should be performed on.
	/// Random by default.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

	/// <summary>
	/// <para>
	/// If true, the request is real-time as opposed to near-real-time.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? Realtime { get => Q<bool?>("realtime"); set => Q("realtime", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, Elasticsearch refreshes all shards involved in the delete by query after the request completes.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

	/// <summary>
	/// <para>
	/// Target the specified primary shard.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>
	/// <c>true</c> or <c>false</c> to return the <c>_source</c> field or not, or a list of fields to return.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Core.Search.SourceConfigParam? Source { get => Q<Elastic.Clients.Elasticsearch.Core.Search.SourceConfigParam?>("_source"); set => Q("_source", value); }

	/// <summary>
	/// <para>
	/// A comma-separated list of source fields to exclude in the response.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

	/// <summary>
	/// <para>
	/// A comma-separated list of source fields to include in the response.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_includes"); set => Q("_source_includes", value); }

	/// <summary>
	/// <para>
	/// Explicit version number for concurrency control.
	/// The specified version must match the current version of the document for the request to succeed.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public long? Version { get => Q<long?>("version"); set => Q("version", value); }

	/// <summary>
	/// <para>
	/// Specific version type: <c>external</c>, <c>external_gte</c>.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.VersionType?>("version_type"); set => Q("version_type", value); }
}

/// <summary>
/// <para>
/// Check for a document source.
/// Checks if a document's <c>_source</c> is stored.
/// </para>
/// </summary>
public sealed partial class ExistsSourceRequestDescriptor<TDocument> : RequestDescriptor<ExistsSourceRequestDescriptor<TDocument>, ExistsSourceRequestParameters>
{
	internal ExistsSourceRequestDescriptor(Action<ExistsSourceRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public ExistsSourceRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
	{
	}

	public ExistsSourceRequestDescriptor(TDocument document) : this(typeof(TDocument), Elastic.Clients.Elasticsearch.Id.From(document))
	{
	}

	public ExistsSourceRequestDescriptor(TDocument document, Elastic.Clients.Elasticsearch.IndexName index) : this(index, Elastic.Clients.Elasticsearch.Id.From(document))
	{
	}

	public ExistsSourceRequestDescriptor(TDocument document, Elastic.Clients.Elasticsearch.Id id) : this(typeof(TDocument), id)
	{
	}

	public ExistsSourceRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : this(typeof(TDocument), id)
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceExistsSource;

	protected override HttpMethod StaticHttpMethod => HttpMethod.HEAD;

	internal override bool SupportsBody => false;

	internal override string OperationName => "exists_source";

	public ExistsSourceRequestDescriptor<TDocument> Preference(string? preference) => Qs("preference", preference);
	public ExistsSourceRequestDescriptor<TDocument> Realtime(bool? realtime = true) => Qs("realtime", realtime);
	public ExistsSourceRequestDescriptor<TDocument> Refresh(bool? refresh = true) => Qs("refresh", refresh);
	public ExistsSourceRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public ExistsSourceRequestDescriptor<TDocument> Source(Elastic.Clients.Elasticsearch.Core.Search.SourceConfigParam? source) => Qs("_source", source);
	public ExistsSourceRequestDescriptor<TDocument> SourceExcludes(Elastic.Clients.Elasticsearch.Fields? sourceExcludes) => Qs("_source_excludes", sourceExcludes);
	public ExistsSourceRequestDescriptor<TDocument> SourceIncludes(Elastic.Clients.Elasticsearch.Fields? sourceIncludes) => Qs("_source_includes", sourceIncludes);
	public ExistsSourceRequestDescriptor<TDocument> Version(long? version) => Qs("version", version);
	public ExistsSourceRequestDescriptor<TDocument> VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType) => Qs("version_type", versionType);

	public ExistsSourceRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	public ExistsSourceRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName index)
	{
		RouteValues.Required("index", index);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>
/// Check for a document source.
/// Checks if a document's <c>_source</c> is stored.
/// </para>
/// </summary>
public sealed partial class ExistsSourceRequestDescriptor : RequestDescriptor<ExistsSourceRequestDescriptor, ExistsSourceRequestParameters>
{
	internal ExistsSourceRequestDescriptor(Action<ExistsSourceRequestDescriptor> configure) => configure.Invoke(this);

	public ExistsSourceRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceExistsSource;

	protected override HttpMethod StaticHttpMethod => HttpMethod.HEAD;

	internal override bool SupportsBody => false;

	internal override string OperationName => "exists_source";

	public ExistsSourceRequestDescriptor Preference(string? preference) => Qs("preference", preference);
	public ExistsSourceRequestDescriptor Realtime(bool? realtime = true) => Qs("realtime", realtime);
	public ExistsSourceRequestDescriptor Refresh(bool? refresh = true) => Qs("refresh", refresh);
	public ExistsSourceRequestDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public ExistsSourceRequestDescriptor Source(Elastic.Clients.Elasticsearch.Core.Search.SourceConfigParam? source) => Qs("_source", source);
	public ExistsSourceRequestDescriptor SourceExcludes(Elastic.Clients.Elasticsearch.Fields? sourceExcludes) => Qs("_source_excludes", sourceExcludes);
	public ExistsSourceRequestDescriptor SourceIncludes(Elastic.Clients.Elasticsearch.Fields? sourceIncludes) => Qs("_source_includes", sourceIncludes);
	public ExistsSourceRequestDescriptor Version(long? version) => Qs("version", version);
	public ExistsSourceRequestDescriptor VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType) => Qs("version_type", versionType);

	public ExistsSourceRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	public ExistsSourceRequestDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index)
	{
		RouteValues.Required("index", index);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}