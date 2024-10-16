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

namespace Elastic.Clients.Elasticsearch.SearchableSnapshots;

public sealed partial class MountRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Explicit operation timeout for connection to master node
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// Selects the kind of local storage used to accelerate searches. Experimental, and defaults to <c>full_copy</c>
	/// </para>
	/// </summary>
	public string? Storage { get => Q<string?>("storage"); set => Q("storage", value); }

	/// <summary>
	/// <para>
	/// Should this request wait until the operation has completed before returning
	/// </para>
	/// </summary>
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
}

/// <summary>
/// <para>
/// Mount a snapshot as a searchable index.
/// </para>
/// </summary>
public sealed partial class MountRequest : PlainRequest<MountRequestParameters>
{
	public MountRequest(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SearchableSnapshotsMount;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "searchable_snapshots.mount";

	/// <summary>
	/// <para>
	/// Explicit operation timeout for connection to master node
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// Selects the kind of local storage used to accelerate searches. Experimental, and defaults to <c>full_copy</c>
	/// </para>
	/// </summary>
	[JsonIgnore]
	public string? Storage { get => Q<string?>("storage"); set => Q("storage", value); }

	/// <summary>
	/// <para>
	/// Should this request wait until the operation has completed before returning
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
	[JsonInclude, JsonPropertyName("ignore_index_settings")]
	public ICollection<string>? IgnoreIndexSettings { get; set; }
	[JsonInclude, JsonPropertyName("index")]
	public Elastic.Clients.Elasticsearch.IndexName Index { get; set; }
	[JsonInclude, JsonPropertyName("index_settings")]
	public IDictionary<string, object>? IndexSettings { get; set; }
	[JsonInclude, JsonPropertyName("renamed_index")]
	public Elastic.Clients.Elasticsearch.IndexName? RenamedIndex { get; set; }
}

/// <summary>
/// <para>
/// Mount a snapshot as a searchable index.
/// </para>
/// </summary>
public sealed partial class MountRequestDescriptor : RequestDescriptor<MountRequestDescriptor, MountRequestParameters>
{
	internal MountRequestDescriptor(Action<MountRequestDescriptor> configure) => configure.Invoke(this);

	public MountRequestDescriptor(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SearchableSnapshotsMount;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "searchable_snapshots.mount";

	public MountRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public MountRequestDescriptor Storage(string? storage) => Qs("storage", storage);
	public MountRequestDescriptor WaitForCompletion(bool? waitForCompletion = true) => Qs("wait_for_completion", waitForCompletion);

	public MountRequestDescriptor Repository(Elastic.Clients.Elasticsearch.Name repository)
	{
		RouteValues.Required("repository", repository);
		return Self;
	}

	public MountRequestDescriptor Snapshot(Elastic.Clients.Elasticsearch.Name snapshot)
	{
		RouteValues.Required("snapshot", snapshot);
		return Self;
	}

	private ICollection<string>? IgnoreIndexSettingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexName IndexValue { get; set; }
	private IDictionary<string, object>? IndexSettingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexName? RenamedIndexValue { get; set; }

	public MountRequestDescriptor IgnoreIndexSettings(ICollection<string>? ignoreIndexSettings)
	{
		IgnoreIndexSettingsValue = ignoreIndexSettings;
		return Self;
	}

	public MountRequestDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index)
	{
		IndexValue = index;
		return Self;
	}

	public MountRequestDescriptor IndexSettings(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		IndexSettingsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public MountRequestDescriptor RenamedIndex(Elastic.Clients.Elasticsearch.IndexName? renamedIndex)
	{
		RenamedIndexValue = renamedIndex;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IgnoreIndexSettingsValue is not null)
		{
			writer.WritePropertyName("ignore_index_settings");
			JsonSerializer.Serialize(writer, IgnoreIndexSettingsValue, options);
		}

		writer.WritePropertyName("index");
		JsonSerializer.Serialize(writer, IndexValue, options);
		if (IndexSettingsValue is not null)
		{
			writer.WritePropertyName("index_settings");
			JsonSerializer.Serialize(writer, IndexSettingsValue, options);
		}

		if (RenamedIndexValue is not null)
		{
			writer.WritePropertyName("renamed_index");
			JsonSerializer.Serialize(writer, RenamedIndexValue, options);
		}

		writer.WriteEndObject();
	}
}