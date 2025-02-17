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

namespace Elastic.Clients.Elasticsearch.SearchApplication;

public sealed partial class GetBehavioralAnalyticsRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Get behavioral analytics collections.
/// </para>
/// </summary>
public sealed partial class GetBehavioralAnalyticsRequest : PlainRequest<GetBehavioralAnalyticsRequestParameters>
{
	[JsonConstructor]
	public GetBehavioralAnalyticsRequest()
	{
	}

	public GetBehavioralAnalyticsRequest(IReadOnlyCollection<Elastic.Clients.Elasticsearch.Name>? name) : base(r => r.Optional("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SearchApplicationGetBehavioralAnalytics;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "search_application.get_behavioral_analytics";

	/// <summary>
	/// <para>
	/// A list of analytics collections to limit the returned information
	/// </para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.Name>? Name { get => P<ICollection<Elastic.Clients.Elasticsearch.Name>?>("name"); set => PO("name", value); }
}

/// <summary>
/// <para>
/// Get behavioral analytics collections.
/// </para>
/// </summary>
public sealed partial class GetBehavioralAnalyticsRequestDescriptor : RequestDescriptor<GetBehavioralAnalyticsRequestDescriptor, GetBehavioralAnalyticsRequestParameters>
{
	internal GetBehavioralAnalyticsRequestDescriptor(Action<GetBehavioralAnalyticsRequestDescriptor> configure) => configure.Invoke(this);

	public GetBehavioralAnalyticsRequestDescriptor(IReadOnlyCollection<Elastic.Clients.Elasticsearch.Name>? name) : base(r => r.Optional("name", name))
	{
	}

	public GetBehavioralAnalyticsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SearchApplicationGetBehavioralAnalytics;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "search_application.get_behavioral_analytics";

	public GetBehavioralAnalyticsRequestDescriptor Name(IReadOnlyCollection<Elastic.Clients.Elasticsearch.Name>? name)
	{
		RouteValues.Optional("name", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}