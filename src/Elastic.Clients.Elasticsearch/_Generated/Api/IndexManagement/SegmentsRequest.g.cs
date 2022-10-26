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
public sealed class SegmentsRequestParameters : RequestParameters<SegmentsRequestParameters>
{
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	[JsonIgnore]
	public IList<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<IList<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	[JsonIgnore]
	public bool? Verbose { get => Q<bool?>("verbose"); set => Q("verbose", value); }
}

public sealed partial class SegmentsRequest : PlainRequest<SegmentsRequestParameters>
{
	public SegmentsRequest()
	{
	}

	public SegmentsRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementSegments;
	protected override HttpMethod HttpMethod => HttpMethod.GET;
	protected override bool SupportsBody => false;
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	[JsonIgnore]
	public IList<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<IList<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	[JsonIgnore]
	public bool? Verbose { get => Q<bool?>("verbose"); set => Q("verbose", value); }
}

public sealed partial class SegmentsRequestDescriptor<TDocument> : RequestDescriptor<SegmentsRequestDescriptor<TDocument>, SegmentsRequestParameters>
{
	internal SegmentsRequestDescriptor(Action<SegmentsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public SegmentsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementSegments;
	protected override HttpMethod HttpMethod => HttpMethod.GET;
	protected override bool SupportsBody => false;
	public SegmentsRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public SegmentsRequestDescriptor<TDocument> ExpandWildcards(IList<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public SegmentsRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public SegmentsRequestDescriptor<TDocument> Verbose(bool? verbose = true) => Qs("verbose", verbose);
	public SegmentsRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

public sealed partial class SegmentsRequestDescriptor : RequestDescriptor<SegmentsRequestDescriptor, SegmentsRequestParameters>
{
	internal SegmentsRequestDescriptor(Action<SegmentsRequestDescriptor> configure) => configure.Invoke(this);
	public SegmentsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementSegments;
	protected override HttpMethod HttpMethod => HttpMethod.GET;
	protected override bool SupportsBody => false;
	public SegmentsRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public SegmentsRequestDescriptor ExpandWildcards(IList<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public SegmentsRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public SegmentsRequestDescriptor Verbose(bool? verbose = true) => Qs("verbose", verbose);
	public SegmentsRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}