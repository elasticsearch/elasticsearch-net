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

namespace Elastic.Clients.Elasticsearch.Serverless.Enrich;

public sealed partial class ExecutePolicyRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If <c>true</c>, the request blocks other enrich policy execution requests until complete.
	/// </para>
	/// </summary>
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
}

/// <summary>
/// <para>
/// Run an enrich policy.
/// Create the enrich index for an existing enrich policy.
/// </para>
/// </summary>
public sealed partial class ExecutePolicyRequest : PlainRequest<ExecutePolicyRequestParameters>
{
	public ExecutePolicyRequest(Elastic.Clients.Elasticsearch.Serverless.Name name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EnrichExecutePolicy;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => false;

	internal override string OperationName => "enrich.execute_policy";

	/// <summary>
	/// <para>
	/// If <c>true</c>, the request blocks other enrich policy execution requests until complete.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
}

/// <summary>
/// <para>
/// Run an enrich policy.
/// Create the enrich index for an existing enrich policy.
/// </para>
/// </summary>
public sealed partial class ExecutePolicyRequestDescriptor : RequestDescriptor<ExecutePolicyRequestDescriptor, ExecutePolicyRequestParameters>
{
	internal ExecutePolicyRequestDescriptor(Action<ExecutePolicyRequestDescriptor> configure) => configure.Invoke(this);

	public ExecutePolicyRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Name name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EnrichExecutePolicy;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => false;

	internal override string OperationName => "enrich.execute_policy";

	public ExecutePolicyRequestDescriptor WaitForCompletion(bool? waitForCompletion = true) => Qs("wait_for_completion", waitForCompletion);

	public ExecutePolicyRequestDescriptor Name(Elastic.Clients.Elasticsearch.Serverless.Name name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}