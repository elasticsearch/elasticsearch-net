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

namespace Elastic.Clients.Elasticsearch.Synonyms;

public sealed partial class GetSynonymsSetsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Starting offset</para>
	/// </summary>
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>specifies a max number of results to get</para>
	/// </summary>
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }
}

/// <summary>
/// <para>Retrieves a summary of all defined synonym sets</para>
/// </summary>
public sealed partial class GetSynonymsSetsRequest : PlainRequest<GetSynonymsSetsRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.SynonymsGetSynonymsSets;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "synonyms.get_synonyms_sets";

	/// <summary>
	/// <para>Starting offset</para>
	/// </summary>
	[JsonIgnore]
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>specifies a max number of results to get</para>
	/// </summary>
	[JsonIgnore]
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }
}

/// <summary>
/// <para>Retrieves a summary of all defined synonym sets</para>
/// </summary>
public sealed partial class GetSynonymsSetsRequestDescriptor : RequestDescriptor<GetSynonymsSetsRequestDescriptor, GetSynonymsSetsRequestParameters>
{
	internal GetSynonymsSetsRequestDescriptor(Action<GetSynonymsSetsRequestDescriptor> configure) => configure.Invoke(this);

	public GetSynonymsSetsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SynonymsGetSynonymsSets;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "synonyms.get_synonyms_sets";

	public GetSynonymsSetsRequestDescriptor From(int? from) => Qs("from", from);
	public GetSynonymsSetsRequestDescriptor Size(int? size) => Qs("size", size);

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}