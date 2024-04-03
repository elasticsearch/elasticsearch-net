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

namespace Elastic.Clients.Elasticsearch.Serverless.Nodes;

public sealed partial class Http
{
	/// <summary>
	/// <para>Information on current and recently-closed HTTP client connections.<br/>Clients that have been closed longer than the `http.client_stats.closed_channels.max_age` setting will not be represented here.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("clients")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Nodes.Client>? Clients { get; init; }

	/// <summary>
	/// <para>Current number of open HTTP connections for the node.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("current_open")]
	public int? CurrentOpen { get; init; }

	/// <summary>
	/// <para>Total number of HTTP connections opened for the node.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("total_opened")]
	public long? TotalOpened { get; init; }
}