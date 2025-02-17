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

public sealed partial class GetDataFrameAnalyticsStatsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Specifies what to do when the request:
	/// </para>
	/// <list type="number">
	/// <item>
	/// <para>
	/// Contains wildcard expressions and there are no data frame analytics
	/// jobs that match.
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
	/// The default value returns an empty data_frame_analytics array when there
	/// are no matches and the subset of results when there are partial matches.
	/// If this parameter is <c>false</c>, the request returns a 404 status code when
	/// there are no matches or only partial matches.
	/// </para>
	/// </summary>
	public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }

	/// <summary>
	/// <para>
	/// Skips the specified number of data frame analytics jobs.
	/// </para>
	/// </summary>
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>
	/// Specifies the maximum number of data frame analytics jobs to obtain.
	/// </para>
	/// </summary>
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }

	/// <summary>
	/// <para>
	/// Defines whether the stats response should be verbose.
	/// </para>
	/// </summary>
	public bool? Verbose { get => Q<bool?>("verbose"); set => Q("verbose", value); }
}

/// <summary>
/// <para>
/// Get data frame analytics jobs usage info.
/// </para>
/// </summary>
public sealed partial class GetDataFrameAnalyticsStatsRequest : PlainRequest<GetDataFrameAnalyticsStatsRequestParameters>
{
	public GetDataFrameAnalyticsStatsRequest()
	{
	}

	public GetDataFrameAnalyticsStatsRequest(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningGetDataFrameAnalyticsStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.get_data_frame_analytics_stats";

	/// <summary>
	/// <para>
	/// Specifies what to do when the request:
	/// </para>
	/// <list type="number">
	/// <item>
	/// <para>
	/// Contains wildcard expressions and there are no data frame analytics
	/// jobs that match.
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
	/// The default value returns an empty data_frame_analytics array when there
	/// are no matches and the subset of results when there are partial matches.
	/// If this parameter is <c>false</c>, the request returns a 404 status code when
	/// there are no matches or only partial matches.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }

	/// <summary>
	/// <para>
	/// Skips the specified number of data frame analytics jobs.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>
	/// Specifies the maximum number of data frame analytics jobs to obtain.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }

	/// <summary>
	/// <para>
	/// Defines whether the stats response should be verbose.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? Verbose { get => Q<bool?>("verbose"); set => Q("verbose", value); }
}

/// <summary>
/// <para>
/// Get data frame analytics jobs usage info.
/// </para>
/// </summary>
public sealed partial class GetDataFrameAnalyticsStatsRequestDescriptor<TDocument> : RequestDescriptor<GetDataFrameAnalyticsStatsRequestDescriptor<TDocument>, GetDataFrameAnalyticsStatsRequestParameters>
{
	internal GetDataFrameAnalyticsStatsRequestDescriptor(Action<GetDataFrameAnalyticsStatsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GetDataFrameAnalyticsStatsRequestDescriptor(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
	{
	}

	public GetDataFrameAnalyticsStatsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningGetDataFrameAnalyticsStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.get_data_frame_analytics_stats";

	public GetDataFrameAnalyticsStatsRequestDescriptor<TDocument> AllowNoMatch(bool? allowNoMatch = true) => Qs("allow_no_match", allowNoMatch);
	public GetDataFrameAnalyticsStatsRequestDescriptor<TDocument> From(int? from) => Qs("from", from);
	public GetDataFrameAnalyticsStatsRequestDescriptor<TDocument> Size(int? size) => Qs("size", size);
	public GetDataFrameAnalyticsStatsRequestDescriptor<TDocument> Verbose(bool? verbose = true) => Qs("verbose", verbose);

	public GetDataFrameAnalyticsStatsRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id? id)
	{
		RouteValues.Optional("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>
/// Get data frame analytics jobs usage info.
/// </para>
/// </summary>
public sealed partial class GetDataFrameAnalyticsStatsRequestDescriptor : RequestDescriptor<GetDataFrameAnalyticsStatsRequestDescriptor, GetDataFrameAnalyticsStatsRequestParameters>
{
	internal GetDataFrameAnalyticsStatsRequestDescriptor(Action<GetDataFrameAnalyticsStatsRequestDescriptor> configure) => configure.Invoke(this);

	public GetDataFrameAnalyticsStatsRequestDescriptor(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
	{
	}

	public GetDataFrameAnalyticsStatsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningGetDataFrameAnalyticsStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.get_data_frame_analytics_stats";

	public GetDataFrameAnalyticsStatsRequestDescriptor AllowNoMatch(bool? allowNoMatch = true) => Qs("allow_no_match", allowNoMatch);
	public GetDataFrameAnalyticsStatsRequestDescriptor From(int? from) => Qs("from", from);
	public GetDataFrameAnalyticsStatsRequestDescriptor Size(int? size) => Qs("size", size);
	public GetDataFrameAnalyticsStatsRequestDescriptor Verbose(bool? verbose = true) => Qs("verbose", verbose);

	public GetDataFrameAnalyticsStatsRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id? id)
	{
		RouteValues.Optional("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}