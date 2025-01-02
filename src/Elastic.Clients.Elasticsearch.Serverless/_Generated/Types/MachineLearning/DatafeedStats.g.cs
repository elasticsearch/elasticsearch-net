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

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class DatafeedStats
{
	/// <summary>
	/// <para>
	/// For started datafeeds only, contains messages relating to the selection of a node.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("assignment_explanation")]
	public string? AssignmentExplanation { get; init; }

	/// <summary>
	/// <para>
	/// A numerical character string that uniquely identifies the datafeed.
	/// This identifier can contain lowercase alphanumeric characters (a-z and 0-9), hyphens, and underscores.
	/// It must start and end with alphanumeric characters.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("datafeed_id")]
	public string DatafeedId { get; init; }

	/// <summary>
	/// <para>
	/// An object containing the running state for this datafeed.
	/// It is only provided if the datafeed is started.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("running_state")]
	public Elastic.Clients.Elasticsearch.Serverless.MachineLearning.DatafeedRunningState? RunningState { get; init; }

	/// <summary>
	/// <para>
	/// The status of the datafeed, which can be one of the following values: <c>starting</c>, <c>started</c>, <c>stopping</c>, <c>stopped</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("state")]
	public Elastic.Clients.Elasticsearch.Serverless.MachineLearning.DatafeedState State { get; init; }

	/// <summary>
	/// <para>
	/// An object that provides statistical information about timing aspect of this datafeed.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("timing_stats")]
	public Elastic.Clients.Elasticsearch.Serverless.MachineLearning.DatafeedTimingStats? TimingStats { get; init; }
}