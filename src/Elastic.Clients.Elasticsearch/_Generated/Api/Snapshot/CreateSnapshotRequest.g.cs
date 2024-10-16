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

namespace Elastic.Clients.Elasticsearch.Snapshot;

public sealed partial class CreateSnapshotRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the request returns a response when the snapshot is complete. If <c>false</c>, the request returns a response when the snapshot initializes.
	/// </para>
	/// </summary>
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
}

/// <summary>
/// <para>
/// Creates a snapshot in a repository.
/// </para>
/// </summary>
public sealed partial class CreateSnapshotRequest : PlainRequest<CreateSnapshotRequestParameters>
{
	public CreateSnapshotRequest(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotCreate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "snapshot.create";

	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the request returns a response when the snapshot is complete. If <c>false</c>, the request returns a response when the snapshot initializes.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }

	/// <summary>
	/// <para>
	/// Feature states to include in the snapshot. Each feature state includes one or more system indices containing related data. You can view a list of eligible features using the get features API. If <c>include_global_state</c> is <c>true</c>, all current feature states are included by default. If <c>include_global_state</c> is <c>false</c>, no feature states are included by default.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("feature_states")]
	public ICollection<string>? FeatureStates { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the request ignores data streams and indices in <c>indices</c> that are missing or closed. If <c>false</c>, the request returns an error for any data stream or index that is missing or closed.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ignore_unavailable")]
	public bool? IgnoreUnavailable { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the current cluster state is included in the snapshot. The cluster state includes persistent cluster settings, composable index templates, legacy index templates, ingest pipelines, and ILM policies. It also includes data stored in system indices, such as Watches and task records (configurable via <c>feature_states</c>).
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("include_global_state")]
	public bool? IncludeGlobalState { get; set; }

	/// <summary>
	/// <para>
	/// Data streams and indices to include in the snapshot. Supports multi-target syntax. Includes all data streams and indices by default.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("indices")]
	public Elastic.Clients.Elasticsearch.Indices? Indices { get; set; }

	/// <summary>
	/// <para>
	/// Optional metadata for the snapshot. May have any contents. Must be less than 1024 bytes. This map is not automatically generated by Elasticsearch.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("metadata")]
	public IDictionary<string, object>? Metadata { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, allows restoring a partial snapshot of indices with unavailable shards. Only shards that were successfully included in the snapshot will be restored. All missing shards will be recreated as empty. If <c>false</c>, the entire restore operation will fail if one or more indices included in the snapshot do not have all primary shards available.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("partial")]
	public bool? Partial { get; set; }
}

/// <summary>
/// <para>
/// Creates a snapshot in a repository.
/// </para>
/// </summary>
public sealed partial class CreateSnapshotRequestDescriptor : RequestDescriptor<CreateSnapshotRequestDescriptor, CreateSnapshotRequestParameters>
{
	internal CreateSnapshotRequestDescriptor(Action<CreateSnapshotRequestDescriptor> configure) => configure.Invoke(this);

	public CreateSnapshotRequestDescriptor(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotCreate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "snapshot.create";

	public CreateSnapshotRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public CreateSnapshotRequestDescriptor WaitForCompletion(bool? waitForCompletion = true) => Qs("wait_for_completion", waitForCompletion);

	public CreateSnapshotRequestDescriptor Repository(Elastic.Clients.Elasticsearch.Name repository)
	{
		RouteValues.Required("repository", repository);
		return Self;
	}

	public CreateSnapshotRequestDescriptor Snapshot(Elastic.Clients.Elasticsearch.Name snapshot)
	{
		RouteValues.Required("snapshot", snapshot);
		return Self;
	}

	private ICollection<string>? FeatureStatesValue { get; set; }
	private bool? IgnoreUnavailableValue { get; set; }
	private bool? IncludeGlobalStateValue { get; set; }
	private Elastic.Clients.Elasticsearch.Indices? IndicesValue { get; set; }
	private IDictionary<string, object>? MetadataValue { get; set; }
	private bool? PartialValue { get; set; }

	/// <summary>
	/// <para>
	/// Feature states to include in the snapshot. Each feature state includes one or more system indices containing related data. You can view a list of eligible features using the get features API. If <c>include_global_state</c> is <c>true</c>, all current feature states are included by default. If <c>include_global_state</c> is <c>false</c>, no feature states are included by default.
	/// </para>
	/// </summary>
	public CreateSnapshotRequestDescriptor FeatureStates(ICollection<string>? featureStates)
	{
		FeatureStatesValue = featureStates;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, the request ignores data streams and indices in <c>indices</c> that are missing or closed. If <c>false</c>, the request returns an error for any data stream or index that is missing or closed.
	/// </para>
	/// </summary>
	public CreateSnapshotRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true)
	{
		IgnoreUnavailableValue = ignoreUnavailable;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, the current cluster state is included in the snapshot. The cluster state includes persistent cluster settings, composable index templates, legacy index templates, ingest pipelines, and ILM policies. It also includes data stored in system indices, such as Watches and task records (configurable via <c>feature_states</c>).
	/// </para>
	/// </summary>
	public CreateSnapshotRequestDescriptor IncludeGlobalState(bool? includeGlobalState = true)
	{
		IncludeGlobalStateValue = includeGlobalState;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Data streams and indices to include in the snapshot. Supports multi-target syntax. Includes all data streams and indices by default.
	/// </para>
	/// </summary>
	public CreateSnapshotRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		IndicesValue = indices;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Optional metadata for the snapshot. May have any contents. Must be less than 1024 bytes. This map is not automatically generated by Elasticsearch.
	/// </para>
	/// </summary>
	public CreateSnapshotRequestDescriptor Metadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, allows restoring a partial snapshot of indices with unavailable shards. Only shards that were successfully included in the snapshot will be restored. All missing shards will be recreated as empty. If <c>false</c>, the entire restore operation will fail if one or more indices included in the snapshot do not have all primary shards available.
	/// </para>
	/// </summary>
	public CreateSnapshotRequestDescriptor Partial(bool? partial = true)
	{
		PartialValue = partial;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FeatureStatesValue is not null)
		{
			writer.WritePropertyName("feature_states");
			JsonSerializer.Serialize(writer, FeatureStatesValue, options);
		}

		if (IgnoreUnavailableValue.HasValue)
		{
			writer.WritePropertyName("ignore_unavailable");
			writer.WriteBooleanValue(IgnoreUnavailableValue.Value);
		}

		if (IncludeGlobalStateValue.HasValue)
		{
			writer.WritePropertyName("include_global_state");
			writer.WriteBooleanValue(IncludeGlobalStateValue.Value);
		}

		if (IndicesValue is not null)
		{
			writer.WritePropertyName("indices");
			JsonSerializer.Serialize(writer, IndicesValue, options);
		}

		if (MetadataValue is not null)
		{
			writer.WritePropertyName("metadata");
			JsonSerializer.Serialize(writer, MetadataValue, options);
		}

		if (PartialValue.HasValue)
		{
			writer.WritePropertyName("partial");
			writer.WriteBooleanValue(PartialValue.Value);
		}

		writer.WriteEndObject();
	}
}