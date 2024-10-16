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

namespace Elastic.Clients.Elasticsearch.Serverless.Snapshot;

public sealed partial class DeleteRepositoryRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Explicit operation timeout for connection to master node
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// Explicit operation timeout
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Deletes a repository.
/// </para>
/// </summary>
public sealed partial class DeleteRepositoryRequest : PlainRequest<DeleteRepositoryRequestParameters>
{
	public DeleteRepositoryRequest(Elastic.Clients.Elasticsearch.Serverless.Names name) : base(r => r.Required("repository", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotDeleteRepository;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "snapshot.delete_repository";

	/// <summary>
	/// <para>
	/// Explicit operation timeout for connection to master node
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// Explicit operation timeout
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Deletes a repository.
/// </para>
/// </summary>
public sealed partial class DeleteRepositoryRequestDescriptor : RequestDescriptor<DeleteRepositoryRequestDescriptor, DeleteRepositoryRequestParameters>
{
	internal DeleteRepositoryRequestDescriptor(Action<DeleteRepositoryRequestDescriptor> configure) => configure.Invoke(this);

	public DeleteRepositoryRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Names name) : base(r => r.Required("repository", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotDeleteRepository;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "snapshot.delete_repository";

	public DeleteRepositoryRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public DeleteRepositoryRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout) => Qs("timeout", timeout);

	public DeleteRepositoryRequestDescriptor Name(Elastic.Clients.Elasticsearch.Serverless.Names name)
	{
		RouteValues.Required("repository", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}