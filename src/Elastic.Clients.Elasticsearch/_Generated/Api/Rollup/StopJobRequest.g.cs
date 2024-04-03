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

namespace Elastic.Clients.Elasticsearch.Rollup;

public sealed partial class StopJobRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If `wait_for_completion` is `true`, the API blocks for (at maximum) the specified duration while waiting for the job to stop.<br/>If more than `timeout` time has passed, the API throws a timeout exception.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>If set to `true`, causes the API to block until the indexer state completely stops.<br/>If set to `false`, the API returns immediately and the indexer is stopped asynchronously in the background.</para>
	/// </summary>
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
}

/// <summary>
/// <para>Stops an existing, started rollup job.</para>
/// </summary>
public sealed partial class StopJobRequest : PlainRequest<StopJobRequestParameters>
{
	public StopJobRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.RollupStopJob;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "rollup.stop_job";

	/// <summary>
	/// <para>If `wait_for_completion` is `true`, the API blocks for (at maximum) the specified duration while waiting for the job to stop.<br/>If more than `timeout` time has passed, the API throws a timeout exception.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>If set to `true`, causes the API to block until the indexer state completely stops.<br/>If set to `false`, the API returns immediately and the indexer is stopped asynchronously in the background.</para>
	/// </summary>
	[JsonIgnore]
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
}

/// <summary>
/// <para>Stops an existing, started rollup job.</para>
/// </summary>
public sealed partial class StopJobRequestDescriptor<TDocument> : RequestDescriptor<StopJobRequestDescriptor<TDocument>, StopJobRequestParameters>
{
	internal StopJobRequestDescriptor(Action<StopJobRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public StopJobRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.RollupStopJob;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "rollup.stop_job";

	public StopJobRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public StopJobRequestDescriptor<TDocument> WaitForCompletion(bool? waitForCompletion = true) => Qs("wait_for_completion", waitForCompletion);

	public StopJobRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>Stops an existing, started rollup job.</para>
/// </summary>
public sealed partial class StopJobRequestDescriptor : RequestDescriptor<StopJobRequestDescriptor, StopJobRequestParameters>
{
	internal StopJobRequestDescriptor(Action<StopJobRequestDescriptor> configure) => configure.Invoke(this);

	public StopJobRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.RollupStopJob;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "rollup.stop_job";

	public StopJobRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public StopJobRequestDescriptor WaitForCompletion(bool? waitForCompletion = true) => Qs("wait_for_completion", waitForCompletion);

	public StopJobRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}