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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class StartDataFrameAnalyticsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Controls the amount of time to wait until the data frame analytics job<br/>starts.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>Starts a data frame analytics job.<br/>A data frame analytics job can be started and stopped multiple times<br/>throughout its lifecycle.<br/>If the destination index does not exist, it is created automatically the<br/>first time you start the data frame analytics job. The<br/>`index.number_of_shards` and `index.number_of_replicas` settings for the<br/>destination index are copied from the source index. If there are multiple<br/>source indices, the destination index copies the highest setting values. The<br/>mappings for the destination index are also copied from the source indices.<br/>If there are any mapping conflicts, the job fails to start.<br/>If the destination index exists, it is used as is. You can therefore set up<br/>the destination index in advance with custom settings and mappings.</para>
/// </summary>
public sealed partial class StartDataFrameAnalyticsRequest : PlainRequest<StartDataFrameAnalyticsRequestParameters>
{
	public StartDataFrameAnalyticsRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningStartDataFrameAnalytics;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.start_data_frame_analytics";

	/// <summary>
	/// <para>Controls the amount of time to wait until the data frame analytics job<br/>starts.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>Starts a data frame analytics job.<br/>A data frame analytics job can be started and stopped multiple times<br/>throughout its lifecycle.<br/>If the destination index does not exist, it is created automatically the<br/>first time you start the data frame analytics job. The<br/>`index.number_of_shards` and `index.number_of_replicas` settings for the<br/>destination index are copied from the source index. If there are multiple<br/>source indices, the destination index copies the highest setting values. The<br/>mappings for the destination index are also copied from the source indices.<br/>If there are any mapping conflicts, the job fails to start.<br/>If the destination index exists, it is used as is. You can therefore set up<br/>the destination index in advance with custom settings and mappings.</para>
/// </summary>
public sealed partial class StartDataFrameAnalyticsRequestDescriptor<TDocument> : RequestDescriptor<StartDataFrameAnalyticsRequestDescriptor<TDocument>, StartDataFrameAnalyticsRequestParameters>
{
	internal StartDataFrameAnalyticsRequestDescriptor(Action<StartDataFrameAnalyticsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public StartDataFrameAnalyticsRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningStartDataFrameAnalytics;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.start_data_frame_analytics";

	public StartDataFrameAnalyticsRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	public StartDataFrameAnalyticsRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>Starts a data frame analytics job.<br/>A data frame analytics job can be started and stopped multiple times<br/>throughout its lifecycle.<br/>If the destination index does not exist, it is created automatically the<br/>first time you start the data frame analytics job. The<br/>`index.number_of_shards` and `index.number_of_replicas` settings for the<br/>destination index are copied from the source index. If there are multiple<br/>source indices, the destination index copies the highest setting values. The<br/>mappings for the destination index are also copied from the source indices.<br/>If there are any mapping conflicts, the job fails to start.<br/>If the destination index exists, it is used as is. You can therefore set up<br/>the destination index in advance with custom settings and mappings.</para>
/// </summary>
public sealed partial class StartDataFrameAnalyticsRequestDescriptor : RequestDescriptor<StartDataFrameAnalyticsRequestDescriptor, StartDataFrameAnalyticsRequestParameters>
{
	internal StartDataFrameAnalyticsRequestDescriptor(Action<StartDataFrameAnalyticsRequestDescriptor> configure) => configure.Invoke(this);

	public StartDataFrameAnalyticsRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningStartDataFrameAnalytics;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.start_data_frame_analytics";

	public StartDataFrameAnalyticsRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	public StartDataFrameAnalyticsRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}