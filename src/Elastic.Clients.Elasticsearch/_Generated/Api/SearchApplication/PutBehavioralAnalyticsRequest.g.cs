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

public sealed partial class PutBehavioralAnalyticsRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Create a behavioral analytics collection.
/// </para>
/// </summary>
public sealed partial class PutBehavioralAnalyticsRequest : PlainRequest<PutBehavioralAnalyticsRequestParameters>
{
	public PutBehavioralAnalyticsRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
	{
	}

	[JsonConstructor]
	internal PutBehavioralAnalyticsRequest()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SearchApplicationPutBehavioralAnalytics;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => false;

	internal override string OperationName => "search_application.put_behavioral_analytics";

	/// <summary>
	/// <para>
	/// The name of the analytics collection to be created or updated.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Name Name { get => P<Elastic.Clients.Elasticsearch.Name>("name"); set => PR("name", value); }
}

/// <summary>
/// <para>
/// Create a behavioral analytics collection.
/// </para>
/// </summary>
public sealed partial class PutBehavioralAnalyticsRequestDescriptor : RequestDescriptor<PutBehavioralAnalyticsRequestDescriptor, PutBehavioralAnalyticsRequestParameters>
{
	internal PutBehavioralAnalyticsRequestDescriptor(Action<PutBehavioralAnalyticsRequestDescriptor> configure) => configure.Invoke(this);

	public PutBehavioralAnalyticsRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SearchApplicationPutBehavioralAnalytics;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => false;

	internal override string OperationName => "search_application.put_behavioral_analytics";

	public PutBehavioralAnalyticsRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}