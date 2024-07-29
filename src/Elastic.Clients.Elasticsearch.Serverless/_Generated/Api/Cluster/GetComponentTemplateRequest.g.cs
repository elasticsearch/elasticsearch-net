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

namespace Elastic.Clients.Elasticsearch.Serverless.Cluster;

public sealed partial class GetComponentTemplateRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If `true`, returns settings in flat format.</para>
	/// </summary>
	public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

	/// <summary>
	/// <para>Return all default configurations for the component template (default: false)</para>
	/// </summary>
	public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

	/// <summary>
	/// <para>If `true`, the request retrieves information from the local node only.<br/>If `false`, information is retrieved from the master node.</para>
	/// </summary>
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

	/// <summary>
	/// <para>Period to wait for a connection to the master node.<br/>If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>Get component templates.<br/>Retrieves information about component templates.</para>
/// </summary>
public sealed partial class GetComponentTemplateRequest : PlainRequest<GetComponentTemplateRequestParameters>
{
	public GetComponentTemplateRequest()
	{
	}

	public GetComponentTemplateRequest(Elastic.Clients.Elasticsearch.Serverless.Name? name) : base(r => r.Optional("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.ClusterGetComponentTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "cluster.get_component_template";

	/// <summary>
	/// <para>If `true`, returns settings in flat format.</para>
	/// </summary>
	[JsonIgnore]
	public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

	/// <summary>
	/// <para>Return all default configurations for the component template (default: false)</para>
	/// </summary>
	[JsonIgnore]
	public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

	/// <summary>
	/// <para>If `true`, the request retrieves information from the local node only.<br/>If `false`, information is retrieved from the master node.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

	/// <summary>
	/// <para>Period to wait for a connection to the master node.<br/>If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>Get component templates.<br/>Retrieves information about component templates.</para>
/// </summary>
public sealed partial class GetComponentTemplateRequestDescriptor : RequestDescriptor<GetComponentTemplateRequestDescriptor, GetComponentTemplateRequestParameters>
{
	internal GetComponentTemplateRequestDescriptor(Action<GetComponentTemplateRequestDescriptor> configure) => configure.Invoke(this);

	public GetComponentTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Name? name) : base(r => r.Optional("name", name))
	{
	}

	public GetComponentTemplateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.ClusterGetComponentTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "cluster.get_component_template";

	public GetComponentTemplateRequestDescriptor FlatSettings(bool? flatSettings = true) => Qs("flat_settings", flatSettings);
	public GetComponentTemplateRequestDescriptor IncludeDefaults(bool? includeDefaults = true) => Qs("include_defaults", includeDefaults);
	public GetComponentTemplateRequestDescriptor Local(bool? local = true) => Qs("local", local);
	public GetComponentTemplateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);

	public GetComponentTemplateRequestDescriptor Name(Elastic.Clients.Elasticsearch.Serverless.Name? name)
	{
		RouteValues.Optional("name", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}