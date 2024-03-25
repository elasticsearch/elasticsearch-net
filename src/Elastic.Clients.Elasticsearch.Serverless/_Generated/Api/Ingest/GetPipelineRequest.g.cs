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

namespace Elastic.Clients.Elasticsearch.Serverless.Ingest;

public sealed partial class GetPipelineRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Period to wait for a connection to the master node.<br/>If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>Return pipelines without their definitions (default: false)</para>
	/// </summary>
	public bool? Summary { get => Q<bool?>("summary"); set => Q("summary", value); }
}

/// <summary>
/// <para>Returns information about one or more ingest pipelines.<br/>This API returns a local reference of the pipeline.</para>
/// </summary>
public sealed partial class GetPipelineRequest : PlainRequest<GetPipelineRequestParameters>
{
	public GetPipelineRequest()
	{
	}

	public GetPipelineRequest(Elastic.Clients.Elasticsearch.Serverless.Id? id) : base(r => r.Optional("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestGetPipeline;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ingest.get_pipeline";

	/// <summary>
	/// <para>Period to wait for a connection to the master node.<br/>If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>Return pipelines without their definitions (default: false)</para>
	/// </summary>
	[JsonIgnore]
	public bool? Summary { get => Q<bool?>("summary"); set => Q("summary", value); }
}

/// <summary>
/// <para>Returns information about one or more ingest pipelines.<br/>This API returns a local reference of the pipeline.</para>
/// </summary>
public sealed partial class GetPipelineRequestDescriptor<TDocument> : RequestDescriptor<GetPipelineRequestDescriptor<TDocument>, GetPipelineRequestParameters>
{
	internal GetPipelineRequestDescriptor(Action<GetPipelineRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GetPipelineRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestGetPipeline;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ingest.get_pipeline";

	public GetPipelineRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public GetPipelineRequestDescriptor<TDocument> Summary(bool? summary = true) => Qs("summary", summary);

	public GetPipelineRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Serverless.Id? id)
	{
		RouteValues.Optional("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>Returns information about one or more ingest pipelines.<br/>This API returns a local reference of the pipeline.</para>
/// </summary>
public sealed partial class GetPipelineRequestDescriptor : RequestDescriptor<GetPipelineRequestDescriptor, GetPipelineRequestParameters>
{
	internal GetPipelineRequestDescriptor(Action<GetPipelineRequestDescriptor> configure) => configure.Invoke(this);

	public GetPipelineRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestGetPipeline;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ingest.get_pipeline";

	public GetPipelineRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public GetPipelineRequestDescriptor Summary(bool? summary = true) => Qs("summary", summary);

	public GetPipelineRequestDescriptor Id(Elastic.Clients.Elasticsearch.Serverless.Id? id)
	{
		RouteValues.Optional("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}