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

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class GetDataLifecycleRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Type of data stream that wildcard patterns can match.<br/>Supports comma-separated values, such as `open,hidden`.<br/>Valid values are: `all`, `open`, `closed`, `hidden`, `none`.</para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>If `true`, return all default settings in the response.</para>
	/// </summary>
	public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }
}

/// <summary>
/// <para>Get data stream lifecycles.<br/>Retrieves the data stream lifecycle configuration of one or more data streams.</para>
/// </summary>
public sealed partial class GetDataLifecycleRequest : PlainRequest<GetDataLifecycleRequestParameters>
{
	public GetDataLifecycleRequest(Elastic.Clients.Elasticsearch.Serverless.DataStreamNames name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementGetDataLifecycle;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.get_data_lifecycle";

	/// <summary>
	/// <para>Type of data stream that wildcard patterns can match.<br/>Supports comma-separated values, such as `open,hidden`.<br/>Valid values are: `all`, `open`, `closed`, `hidden`, `none`.</para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>If `true`, return all default settings in the response.</para>
	/// </summary>
	[JsonIgnore]
	public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }
}

/// <summary>
/// <para>Get data stream lifecycles.<br/>Retrieves the data stream lifecycle configuration of one or more data streams.</para>
/// </summary>
public sealed partial class GetDataLifecycleRequestDescriptor : RequestDescriptor<GetDataLifecycleRequestDescriptor, GetDataLifecycleRequestParameters>
{
	internal GetDataLifecycleRequestDescriptor(Action<GetDataLifecycleRequestDescriptor> configure) => configure.Invoke(this);

	public GetDataLifecycleRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.DataStreamNames name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementGetDataLifecycle;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.get_data_lifecycle";

	public GetDataLifecycleRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public GetDataLifecycleRequestDescriptor IncludeDefaults(bool? includeDefaults = true) => Qs("include_defaults", includeDefaults);

	public GetDataLifecycleRequestDescriptor Name(Elastic.Clients.Elasticsearch.Serverless.DataStreamNames name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}