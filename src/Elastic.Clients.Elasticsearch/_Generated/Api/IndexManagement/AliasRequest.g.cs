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
namespace Elastic.Clients.Elasticsearch.IndexManagement;
public sealed class AliasRequestParameters : RequestParameters<AliasRequestParameters>
{
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	[JsonIgnore]
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
}

public sealed partial class AliasRequest : PlainRequest<AliasRequestParameters>
{
	public AliasRequest()
	{
	}

	public AliasRequest(Elastic.Clients.Elasticsearch.Names? name) : base(r => r.Optional("name", name))
	{
	}

	public AliasRequest(Elastic.Clients.Elasticsearch.Indices? indices, Elastic.Clients.Elasticsearch.Names? name) : base(r => r.Optional("index", indices).Optional("name", name))
	{
	}

	public AliasRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementGetAlias;
	internal override HttpMethod HttpMethod => HttpMethod.GET;
	internal override bool SupportsBody => false;
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	[JsonIgnore]
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
}

public sealed partial class AliasRequestDescriptor<TDocument> : RequestDescriptor<AliasRequestDescriptor<TDocument>, AliasRequestParameters>
{
	internal AliasRequestDescriptor(Action<AliasRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public AliasRequestDescriptor()
	{
	}

	public AliasRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices, Elastic.Clients.Elasticsearch.Names? name) : base(r => r.Optional("index", indices).Optional("name", name))
	{
	}

	public AliasRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementGetAlias;
	internal override HttpMethod HttpMethod => HttpMethod.GET;
	internal override bool SupportsBody => false;
	public AliasRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public AliasRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public AliasRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public AliasRequestDescriptor<TDocument> Local(bool? local = true) => Qs("local", local);
	public AliasRequestDescriptor<TDocument> Name(Elastic.Clients.Elasticsearch.Names? name)
	{
		RouteValues.Optional("name", name);
		return Self;
	}

	public AliasRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

public sealed partial class AliasRequestDescriptor : RequestDescriptor<AliasRequestDescriptor, AliasRequestParameters>
{
	internal AliasRequestDescriptor(Action<AliasRequestDescriptor> configure) => configure.Invoke(this);
	public AliasRequestDescriptor()
	{
	}

	public AliasRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices, Elastic.Clients.Elasticsearch.Names? name) : base(r => r.Optional("index", indices).Optional("name", name))
	{
	}

	public AliasRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementGetAlias;
	internal override HttpMethod HttpMethod => HttpMethod.GET;
	internal override bool SupportsBody => false;
	public AliasRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public AliasRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public AliasRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public AliasRequestDescriptor Local(bool? local = true) => Qs("local", local);
	public AliasRequestDescriptor Name(Elastic.Clients.Elasticsearch.Names? name)
	{
		RouteValues.Optional("name", name);
		return Self;
	}

	public AliasRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}