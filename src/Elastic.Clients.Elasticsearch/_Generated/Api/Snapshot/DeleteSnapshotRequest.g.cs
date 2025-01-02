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

public sealed partial class DeleteSnapshotRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Explicit operation timeout for connection to master node
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>
/// Delete snapshots.
/// </para>
/// </summary>
public sealed partial class DeleteSnapshotRequest : PlainRequest<DeleteSnapshotRequestParameters>
{
	public DeleteSnapshotRequest(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotDelete;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "snapshot.delete";

	/// <summary>
	/// <para>
	/// Explicit operation timeout for connection to master node
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>
/// Delete snapshots.
/// </para>
/// </summary>
public sealed partial class DeleteSnapshotRequestDescriptor : RequestDescriptor<DeleteSnapshotRequestDescriptor, DeleteSnapshotRequestParameters>
{
	internal DeleteSnapshotRequestDescriptor(Action<DeleteSnapshotRequestDescriptor> configure) => configure.Invoke(this);

	public DeleteSnapshotRequestDescriptor(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotDelete;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "snapshot.delete";

	public DeleteSnapshotRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);

	public DeleteSnapshotRequestDescriptor Repository(Elastic.Clients.Elasticsearch.Name repository)
	{
		RouteValues.Required("repository", repository);
		return Self;
	}

	public DeleteSnapshotRequestDescriptor Snapshot(Elastic.Clients.Elasticsearch.Name snapshot)
	{
		RouteValues.Required("snapshot", snapshot);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}