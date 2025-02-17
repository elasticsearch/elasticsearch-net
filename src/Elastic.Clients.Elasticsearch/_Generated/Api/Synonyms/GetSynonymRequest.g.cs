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

namespace Elastic.Clients.Elasticsearch.Synonyms;

public sealed partial class GetSynonymRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Starting offset for query rules to be retrieved
	/// </para>
	/// </summary>
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>
	/// specifies a max number of query rules to retrieve
	/// </para>
	/// </summary>
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }
}

/// <summary>
/// <para>
/// Get a synonym set.
/// </para>
/// </summary>
public sealed partial class GetSynonymRequest : PlainRequest<GetSynonymRequestParameters>
{
	public GetSynonymRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	[JsonConstructor]
	internal GetSynonymRequest()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SynonymsGetSynonym;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "synonyms.get_synonym";

	/// <summary>
	/// <para>
	/// "The id of the synonyms set to be retrieved
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Id Id { get => P<Elastic.Clients.Elasticsearch.Id>("id"); set => PR("id", value); }

	/// <summary>
	/// <para>
	/// Starting offset for query rules to be retrieved
	/// </para>
	/// </summary>
	[JsonIgnore]
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>
	/// specifies a max number of query rules to retrieve
	/// </para>
	/// </summary>
	[JsonIgnore]
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }
}

/// <summary>
/// <para>
/// Get a synonym set.
/// </para>
/// </summary>
public sealed partial class GetSynonymRequestDescriptor<TDocument> : RequestDescriptor<GetSynonymRequestDescriptor<TDocument>, GetSynonymRequestParameters>
{
	internal GetSynonymRequestDescriptor(Action<GetSynonymRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GetSynonymRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SynonymsGetSynonym;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "synonyms.get_synonym";

	public GetSynonymRequestDescriptor<TDocument> From(int? from) => Qs("from", from);
	public GetSynonymRequestDescriptor<TDocument> Size(int? size) => Qs("size", size);

	public GetSynonymRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>
/// Get a synonym set.
/// </para>
/// </summary>
public sealed partial class GetSynonymRequestDescriptor : RequestDescriptor<GetSynonymRequestDescriptor, GetSynonymRequestParameters>
{
	internal GetSynonymRequestDescriptor(Action<GetSynonymRequestDescriptor> configure) => configure.Invoke(this);

	public GetSynonymRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SynonymsGetSynonym;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "synonyms.get_synonym";

	public GetSynonymRequestDescriptor From(int? from) => Qs("from", from);
	public GetSynonymRequestDescriptor Size(int? size) => Qs("size", size);

	public GetSynonymRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}