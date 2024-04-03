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

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class ForecastRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Predicts the future behavior of a time series by using its historical<br/>behavior.</para>
/// <para>Forecasts are not supported for jobs that perform population analysis; an<br/>error occurs if you try to create a forecast for a job that has an<br/>`over_field_name` in its configuration.</para>
/// </summary>
public sealed partial class ForecastRequest : PlainRequest<ForecastRequestParameters>
{
	public ForecastRequest(Elastic.Clients.Elasticsearch.Serverless.Id jobId) : base(r => r.Required("job_id", jobId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningForecast;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.forecast";

	/// <summary>
	/// <para>Refer to the description for the `duration` query parameter.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("duration")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Duration { get; set; }

	/// <summary>
	/// <para>Refer to the description for the `expires_in` query parameter.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("expires_in")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? ExpiresIn { get; set; }

	/// <summary>
	/// <para>Refer to the description for the `max_model_memory` query parameter.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("max_model_memory")]
	public string? MaxModelMemory { get; set; }
}

/// <summary>
/// <para>Predicts the future behavior of a time series by using its historical<br/>behavior.</para>
/// <para>Forecasts are not supported for jobs that perform population analysis; an<br/>error occurs if you try to create a forecast for a job that has an<br/>`over_field_name` in its configuration.</para>
/// </summary>
public sealed partial class ForecastRequestDescriptor : RequestDescriptor<ForecastRequestDescriptor, ForecastRequestParameters>
{
	internal ForecastRequestDescriptor(Action<ForecastRequestDescriptor> configure) => configure.Invoke(this);

	public ForecastRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id jobId) : base(r => r.Required("job_id", jobId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningForecast;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.forecast";

	public ForecastRequestDescriptor JobId(Elastic.Clients.Elasticsearch.Serverless.Id jobId)
	{
		RouteValues.Required("job_id", jobId);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Serverless.Duration? DurationValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Duration? ExpiresInValue { get; set; }
	private string? MaxModelMemoryValue { get; set; }

	/// <summary>
	/// <para>Refer to the description for the `duration` query parameter.</para>
	/// </summary>
	public ForecastRequestDescriptor Duration(Elastic.Clients.Elasticsearch.Serverless.Duration? duration)
	{
		DurationValue = duration;
		return Self;
	}

	/// <summary>
	/// <para>Refer to the description for the `expires_in` query parameter.</para>
	/// </summary>
	public ForecastRequestDescriptor ExpiresIn(Elastic.Clients.Elasticsearch.Serverless.Duration? expiresIn)
	{
		ExpiresInValue = expiresIn;
		return Self;
	}

	/// <summary>
	/// <para>Refer to the description for the `max_model_memory` query parameter.</para>
	/// </summary>
	public ForecastRequestDescriptor MaxModelMemory(string? maxModelMemory)
	{
		MaxModelMemoryValue = maxModelMemory;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DurationValue is not null)
		{
			writer.WritePropertyName("duration");
			JsonSerializer.Serialize(writer, DurationValue, options);
		}

		if (ExpiresInValue is not null)
		{
			writer.WritePropertyName("expires_in");
			JsonSerializer.Serialize(writer, ExpiresInValue, options);
		}

		if (!string.IsNullOrEmpty(MaxModelMemoryValue))
		{
			writer.WritePropertyName("max_model_memory");
			writer.WriteStringValue(MaxModelMemoryValue);
		}

		writer.WriteEndObject();
	}
}