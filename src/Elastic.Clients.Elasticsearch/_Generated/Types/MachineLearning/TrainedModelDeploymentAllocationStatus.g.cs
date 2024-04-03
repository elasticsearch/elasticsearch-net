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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class TrainedModelDeploymentAllocationStatus
{
	/// <summary>
	/// <para>The current number of nodes where the model is allocated.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("allocation_count")]
	public int AllocationCount { get; init; }

	/// <summary>
	/// <para>The detailed allocation state related to the nodes.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("state")]
	public Elastic.Clients.Elasticsearch.MachineLearning.DeploymentAllocationState State { get; init; }

	/// <summary>
	/// <para>The desired number of nodes for model allocation.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("target_allocation_count")]
	public int TargetAllocationCount { get; init; }
}