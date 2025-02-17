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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class GetDatafeedStatsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Specifies what to do when the request:
	/// </para>
	/// <list type="number">
	/// <item>
	/// <para>
	/// Contains wildcard expressions and there are no datafeeds that match.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// Contains the <c>_all</c> string or no identifiers and there are no matches.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// Contains wildcard expressions and there are only partial matches.
	/// </para>
	/// </item>
	/// </list>
	/// <para>
	/// The default value is <c>true</c>, which returns an empty <c>datafeeds</c> array
	/// when there are no matches and the subset of results when there are
	/// partial matches. If this parameter is <c>false</c>, the request returns a
	/// <c>404</c> status code when there are no matches or only partial matches.
	/// </para>
	/// </summary>
	public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }
}

/// <summary>
/// <para>
/// Get datafeeds usage info.
/// You can get statistics for multiple datafeeds in a single API request by
/// using a comma-separated list of datafeeds or a wildcard expression. You can
/// get statistics for all datafeeds by using <c>_all</c>, by specifying <c>*</c> as the
/// <c>&lt;feed_id></c>, or by omitting the <c>&lt;feed_id></c>. If the datafeed is stopped, the
/// only information you receive is the <c>datafeed_id</c> and the <c>state</c>.
/// This API returns a maximum of 10,000 datafeeds.
/// </para>
/// </summary>
public sealed partial class GetDatafeedStatsRequest : PlainRequest<GetDatafeedStatsRequestParameters>
{
	[JsonConstructor]
	public GetDatafeedStatsRequest()
	{
	}

	public GetDatafeedStatsRequest(Elastic.Clients.Elasticsearch.Ids? datafeedId) : base(r => r.Optional("datafeed_id", datafeedId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningGetDatafeedStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.get_datafeed_stats";

	/// <summary>
	/// <para>
	/// Identifier for the datafeed. It can be a datafeed identifier or a
	/// wildcard expression. If you do not specify one of these options, the API
	/// returns information about all datafeeds.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Ids? DatafeedId { get => P<Elastic.Clients.Elasticsearch.Ids?>("datafeed_id"); set => PO("datafeed_id", value); }

	/// <summary>
	/// <para>
	/// Specifies what to do when the request:
	/// </para>
	/// <list type="number">
	/// <item>
	/// <para>
	/// Contains wildcard expressions and there are no datafeeds that match.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// Contains the <c>_all</c> string or no identifiers and there are no matches.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// Contains wildcard expressions and there are only partial matches.
	/// </para>
	/// </item>
	/// </list>
	/// <para>
	/// The default value is <c>true</c>, which returns an empty <c>datafeeds</c> array
	/// when there are no matches and the subset of results when there are
	/// partial matches. If this parameter is <c>false</c>, the request returns a
	/// <c>404</c> status code when there are no matches or only partial matches.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }
}

/// <summary>
/// <para>
/// Get datafeeds usage info.
/// You can get statistics for multiple datafeeds in a single API request by
/// using a comma-separated list of datafeeds or a wildcard expression. You can
/// get statistics for all datafeeds by using <c>_all</c>, by specifying <c>*</c> as the
/// <c>&lt;feed_id></c>, or by omitting the <c>&lt;feed_id></c>. If the datafeed is stopped, the
/// only information you receive is the <c>datafeed_id</c> and the <c>state</c>.
/// This API returns a maximum of 10,000 datafeeds.
/// </para>
/// </summary>
public sealed partial class GetDatafeedStatsRequestDescriptor : RequestDescriptor<GetDatafeedStatsRequestDescriptor, GetDatafeedStatsRequestParameters>
{
	internal GetDatafeedStatsRequestDescriptor(Action<GetDatafeedStatsRequestDescriptor> configure) => configure.Invoke(this);

	public GetDatafeedStatsRequestDescriptor(Elastic.Clients.Elasticsearch.Ids? datafeedId) : base(r => r.Optional("datafeed_id", datafeedId))
	{
	}

	public GetDatafeedStatsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningGetDatafeedStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.get_datafeed_stats";

	public GetDatafeedStatsRequestDescriptor AllowNoMatch(bool? allowNoMatch = true) => Qs("allow_no_match", allowNoMatch);

	public GetDatafeedStatsRequestDescriptor DatafeedId(Elastic.Clients.Elasticsearch.Ids? datafeedId)
	{
		RouteValues.Optional("datafeed_id", datafeedId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}