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

public sealed partial class GetCalendarEventsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Specifies to get events with timestamps earlier than this time.
	/// </para>
	/// </summary>
	public DateTimeOffset? End { get => Q<DateTimeOffset?>("end"); set => Q("end", value); }

	/// <summary>
	/// <para>
	/// Skips the specified number of events.
	/// </para>
	/// </summary>
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>
	/// Specifies to get events for a specific anomaly detection job identifier or job group. It must be used with a calendar identifier of <c>_all</c> or <c>*</c>.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Id? JobId { get => Q<Elastic.Clients.Elasticsearch.Serverless.Id?>("job_id"); set => Q("job_id", value); }

	/// <summary>
	/// <para>
	/// Specifies the maximum number of events to obtain.
	/// </para>
	/// </summary>
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }

	/// <summary>
	/// <para>
	/// Specifies to get events with timestamps after this time.
	/// </para>
	/// </summary>
	public DateTimeOffset? Start { get => Q<DateTimeOffset?>("start"); set => Q("start", value); }
}

/// <summary>
/// <para>
/// Get info about events in calendars.
/// </para>
/// </summary>
public sealed partial class GetCalendarEventsRequest : PlainRequest<GetCalendarEventsRequestParameters>
{
	public GetCalendarEventsRequest(Elastic.Clients.Elasticsearch.Serverless.Id calendarId) : base(r => r.Required("calendar_id", calendarId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningGetCalendarEvents;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.get_calendar_events";

	/// <summary>
	/// <para>
	/// Specifies to get events with timestamps earlier than this time.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public DateTimeOffset? End { get => Q<DateTimeOffset?>("end"); set => Q("end", value); }

	/// <summary>
	/// <para>
	/// Skips the specified number of events.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>
	/// Specifies to get events for a specific anomaly detection job identifier or job group. It must be used with a calendar identifier of <c>_all</c> or <c>*</c>.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Id? JobId { get => Q<Elastic.Clients.Elasticsearch.Serverless.Id?>("job_id"); set => Q("job_id", value); }

	/// <summary>
	/// <para>
	/// Specifies the maximum number of events to obtain.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }

	/// <summary>
	/// <para>
	/// Specifies to get events with timestamps after this time.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public DateTimeOffset? Start { get => Q<DateTimeOffset?>("start"); set => Q("start", value); }
}

/// <summary>
/// <para>
/// Get info about events in calendars.
/// </para>
/// </summary>
public sealed partial class GetCalendarEventsRequestDescriptor : RequestDescriptor<GetCalendarEventsRequestDescriptor, GetCalendarEventsRequestParameters>
{
	internal GetCalendarEventsRequestDescriptor(Action<GetCalendarEventsRequestDescriptor> configure) => configure.Invoke(this);

	public GetCalendarEventsRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id calendarId) : base(r => r.Required("calendar_id", calendarId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningGetCalendarEvents;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.get_calendar_events";

	public GetCalendarEventsRequestDescriptor End(DateTimeOffset? end) => Qs("end", end);
	public GetCalendarEventsRequestDescriptor From(int? from) => Qs("from", from);
	public GetCalendarEventsRequestDescriptor JobId(Elastic.Clients.Elasticsearch.Serverless.Id? jobId) => Qs("job_id", jobId);
	public GetCalendarEventsRequestDescriptor Size(int? size) => Qs("size", size);
	public GetCalendarEventsRequestDescriptor Start(DateTimeOffset? start) => Qs("start", start);

	public GetCalendarEventsRequestDescriptor CalendarId(Elastic.Clients.Elasticsearch.Serverless.Id calendarId)
	{
		RouteValues.Required("calendar_id", calendarId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}