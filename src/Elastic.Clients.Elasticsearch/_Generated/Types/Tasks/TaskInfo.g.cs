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
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Tasks;

public sealed partial class TaskInfo
{
	[JsonInclude, JsonPropertyName("action")]
	public string Action { get; init; }
	[JsonInclude, JsonPropertyName("cancellable")]
	public bool Cancellable { get; init; }
	[JsonInclude, JsonPropertyName("cancelled")]
	public bool? Cancelled { get; init; }

	/// <summary>
	/// <para>
	/// Human readable text that identifies the particular request that the task is performing.
	/// For example, it might identify the search request being performed by a search task.
	/// Other kinds of tasks have different descriptions, like <c>_reindex</c> which has the source and the destination, or <c>_bulk</c> which just has the number of requests and the destination indices.
	/// Many requests will have only an empty description because more detailed information about the request is not easily available or particularly helpful in identifying the request.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; init; }
	[JsonInclude, JsonPropertyName("headers")]
	public IReadOnlyDictionary<string, string> Headers { get; init; }
	[JsonInclude, JsonPropertyName("id")]
	public long Id { get; init; }
	[JsonInclude, JsonPropertyName("node")]
	public string Node { get; init; }
	[JsonInclude, JsonPropertyName("parent_task_id")]
	public Elastic.Clients.Elasticsearch.TaskId? ParentTaskId { get; init; }
	[JsonInclude, JsonPropertyName("running_time")]
	public Elastic.Clients.Elasticsearch.Duration? RunningTime { get; init; }
	[JsonInclude, JsonPropertyName("running_time_in_nanos")]
	public long RunningTimeInNanos { get; init; }
	[JsonInclude, JsonPropertyName("start_time_in_millis")]
	public long StartTimeInMillis { get; init; }

	/// <summary>
	/// <para>
	/// The internal status of the task, which varies from task to task.
	/// The format also varies.
	/// While the goal is to keep the status for a particular task consistent from version to version, this is not always possible because sometimes the implementation changes.
	/// Fields might be removed from the status for a particular request so any parsing you do of the status might break in minor releases.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("status")]
	public object? Status { get; init; }
	[JsonInclude, JsonPropertyName("type")]
	public string Type { get; init; }
}