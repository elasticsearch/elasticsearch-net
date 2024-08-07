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
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.IndexLifecycleManagement;

public sealed partial class Actions
{
	/// <summary>
	/// <para>Phases allowed: warm, cold.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("allocate")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexLifecycleManagement.AllocateAction? Allocate { get; init; }

	/// <summary>
	/// <para>Phases allowed: delete.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("delete")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexLifecycleManagement.DeleteAction? Delete { get; init; }

	/// <summary>
	/// <para>Phases allowed: hot, warm, cold.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("downsample")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexLifecycleManagement.DownsampleAction? Downsample { get; init; }

	/// <summary>
	/// <para>Phases allowed: hot, warm.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("forcemerge")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexLifecycleManagement.ForceMergeAction? Forcemerge { get; init; }

	/// <summary>
	/// <para>Phases allowed: warm, cold.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("migrate")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexLifecycleManagement.MigrateAction? Migrate { get; init; }

	/// <summary>
	/// <para>Phases allowed: hot, warm, cold.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("readonly")]
	public Elastic.Clients.Elasticsearch.Serverless.EmptyObject? Readonly { get; init; }

	/// <summary>
	/// <para>Phases allowed: hot.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("rollover")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexLifecycleManagement.RolloverAction? Rollover { get; init; }

	/// <summary>
	/// <para>Phases allowed: hot, cold, frozen.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("searchable_snapshot")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexLifecycleManagement.SearchableSnapshotAction? SearchableSnapshot { get; init; }

	/// <summary>
	/// <para>Phases allowed: hot, warm, cold.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("set_priority")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexLifecycleManagement.SetPriorityAction? SetPriority { get; init; }

	/// <summary>
	/// <para>Phases allowed: hot, warm.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("shrink")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexLifecycleManagement.ShrinkAction? Shrink { get; init; }

	/// <summary>
	/// <para>Phases allowed: hot, warm, cold, frozen.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("unfollow")]
	public Elastic.Clients.Elasticsearch.Serverless.EmptyObject? Unfollow { get; init; }

	/// <summary>
	/// <para>Phases allowed: delete.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("wait_for_snapshot")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexLifecycleManagement.WaitForSnapshotAction? WaitForSnapshot { get; init; }
}