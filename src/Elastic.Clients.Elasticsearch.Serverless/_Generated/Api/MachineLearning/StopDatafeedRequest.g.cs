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
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class StopDatafeedRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Stop datafeeds.
/// A datafeed that is stopped ceases to retrieve data from Elasticsearch. A datafeed can be started and stopped
/// multiple times throughout its lifecycle.
/// </para>
/// </summary>
public sealed partial class StopDatafeedRequest : PlainRequest<StopDatafeedRequestParameters>
{
	public StopDatafeedRequest(Elastic.Clients.Elasticsearch.Serverless.Id datafeedId) : base(r => r.Required("datafeed_id", datafeedId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningStopDatafeed;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.stop_datafeed";

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>allow_no_match</c> query parameter.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("allow_no_match")]
	public bool? AllowNoMatch { get; set; }

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>force</c> query parameter.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("force")]
	public bool? Force { get; set; }

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>timeout</c> query parameter.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("timeout")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get; set; }
}

/// <summary>
/// <para>
/// Stop datafeeds.
/// A datafeed that is stopped ceases to retrieve data from Elasticsearch. A datafeed can be started and stopped
/// multiple times throughout its lifecycle.
/// </para>
/// </summary>
public sealed partial class StopDatafeedRequestDescriptor : RequestDescriptor<StopDatafeedRequestDescriptor, StopDatafeedRequestParameters>
{
	internal StopDatafeedRequestDescriptor(Action<StopDatafeedRequestDescriptor> configure) => configure.Invoke(this);

	public StopDatafeedRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id datafeedId) : base(r => r.Required("datafeed_id", datafeedId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningStopDatafeed;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.stop_datafeed";

	public StopDatafeedRequestDescriptor DatafeedId(Elastic.Clients.Elasticsearch.Serverless.Id datafeedId)
	{
		RouteValues.Required("datafeed_id", datafeedId);
		return Self;
	}

	private bool? AllowNoMatchValue { get; set; }
	private bool? ForceValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Duration? TimeoutValue { get; set; }

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>allow_no_match</c> query parameter.
	/// </para>
	/// </summary>
	public StopDatafeedRequestDescriptor AllowNoMatch(bool? allowNoMatch = true)
	{
		AllowNoMatchValue = allowNoMatch;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>force</c> query parameter.
	/// </para>
	/// </summary>
	public StopDatafeedRequestDescriptor Force(bool? force = true)
	{
		ForceValue = force;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Refer to the description for the <c>timeout</c> query parameter.
	/// </para>
	/// </summary>
	public StopDatafeedRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout)
	{
		TimeoutValue = timeout;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AllowNoMatchValue.HasValue)
		{
			writer.WritePropertyName("allow_no_match");
			writer.WriteBooleanValue(AllowNoMatchValue.Value);
		}

		if (ForceValue.HasValue)
		{
			writer.WritePropertyName("force");
			writer.WriteBooleanValue(ForceValue.Value);
		}

		if (TimeoutValue is not null)
		{
			writer.WritePropertyName("timeout");
			JsonSerializer.Serialize(writer, TimeoutValue, options);
		}

		writer.WriteEndObject();
	}
}