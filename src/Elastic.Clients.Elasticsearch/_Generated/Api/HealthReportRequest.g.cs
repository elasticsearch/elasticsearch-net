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

namespace Elastic.Clients.Elasticsearch;

public sealed partial class HealthReportRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Limit the number of affected resources the health report API returns.
	/// </para>
	/// </summary>
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }

	/// <summary>
	/// <para>
	/// Explicit operation timeout.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>
	/// Opt-in for more information about the health of the system.
	/// </para>
	/// </summary>
	public bool? Verbose { get => Q<bool?>("verbose"); set => Q("verbose", value); }
}

/// <summary>
/// <para>
/// Get the cluster health.
/// Get a report with the health status of an Elasticsearch cluster.
/// The report contains a list of indicators that compose Elasticsearch functionality.
/// </para>
/// <para>
/// Each indicator has a health status of: green, unknown, yellow or red.
/// The indicator will provide an explanation and metadata describing the reason for its current health status.
/// </para>
/// <para>
/// The cluster’s status is controlled by the worst indicator status.
/// </para>
/// <para>
/// In the event that an indicator’s status is non-green, a list of impacts may be present in the indicator result which detail the functionalities that are negatively affected by the health issue.
/// Each impact carries with it a severity level, an area of the system that is affected, and a simple description of the impact on the system.
/// </para>
/// <para>
/// Some health indicators can determine the root cause of a health problem and prescribe a set of steps that can be performed in order to improve the health of the system.
/// The root cause and remediation steps are encapsulated in a diagnosis.
/// A diagnosis contains a cause detailing a root cause analysis, an action containing a brief description of the steps to take to fix the problem, the list of affected resources (if applicable), and a detailed step-by-step troubleshooting guide to fix the diagnosed problem.
/// </para>
/// <para>
/// NOTE: The health indicators perform root cause analysis of non-green health statuses. This can be computationally expensive when called frequently.
/// When setting up automated polling of the API for health status, set verbose to false to disable the more expensive analysis logic.
/// </para>
/// </summary>
public sealed partial class HealthReportRequest : PlainRequest<HealthReportRequestParameters>
{
	[JsonConstructor]
	public HealthReportRequest()
	{
	}

	public HealthReportRequest(IReadOnlyCollection<string>? feature) : base(r => r.Optional("feature", feature))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceHealthReport;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "health_report";

	/// <summary>
	/// <para>
	/// A feature of the cluster, as returned by the top-level health report API.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public ICollection<string>? Feature { get => P<ICollection<string>?>("feature"); set => PO("feature", value); }

	/// <summary>
	/// <para>
	/// Limit the number of affected resources the health report API returns.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }

	/// <summary>
	/// <para>
	/// Explicit operation timeout.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>
	/// Opt-in for more information about the health of the system.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? Verbose { get => Q<bool?>("verbose"); set => Q("verbose", value); }
}

/// <summary>
/// <para>
/// Get the cluster health.
/// Get a report with the health status of an Elasticsearch cluster.
/// The report contains a list of indicators that compose Elasticsearch functionality.
/// </para>
/// <para>
/// Each indicator has a health status of: green, unknown, yellow or red.
/// The indicator will provide an explanation and metadata describing the reason for its current health status.
/// </para>
/// <para>
/// The cluster’s status is controlled by the worst indicator status.
/// </para>
/// <para>
/// In the event that an indicator’s status is non-green, a list of impacts may be present in the indicator result which detail the functionalities that are negatively affected by the health issue.
/// Each impact carries with it a severity level, an area of the system that is affected, and a simple description of the impact on the system.
/// </para>
/// <para>
/// Some health indicators can determine the root cause of a health problem and prescribe a set of steps that can be performed in order to improve the health of the system.
/// The root cause and remediation steps are encapsulated in a diagnosis.
/// A diagnosis contains a cause detailing a root cause analysis, an action containing a brief description of the steps to take to fix the problem, the list of affected resources (if applicable), and a detailed step-by-step troubleshooting guide to fix the diagnosed problem.
/// </para>
/// <para>
/// NOTE: The health indicators perform root cause analysis of non-green health statuses. This can be computationally expensive when called frequently.
/// When setting up automated polling of the API for health status, set verbose to false to disable the more expensive analysis logic.
/// </para>
/// </summary>
public sealed partial class HealthReportRequestDescriptor : RequestDescriptor<HealthReportRequestDescriptor, HealthReportRequestParameters>
{
	internal HealthReportRequestDescriptor(Action<HealthReportRequestDescriptor> configure) => configure.Invoke(this);

	public HealthReportRequestDescriptor(IReadOnlyCollection<string>? feature) : base(r => r.Optional("feature", feature))
	{
	}

	public HealthReportRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceHealthReport;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "health_report";

	public HealthReportRequestDescriptor Size(int? size) => Qs("size", size);
	public HealthReportRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public HealthReportRequestDescriptor Verbose(bool? verbose = true) => Qs("verbose", verbose);

	public HealthReportRequestDescriptor Feature(IReadOnlyCollection<string>? feature)
	{
		RouteValues.Optional("feature", feature);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}