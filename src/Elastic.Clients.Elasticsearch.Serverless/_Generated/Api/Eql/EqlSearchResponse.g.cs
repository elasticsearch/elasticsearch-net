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
using Elastic.Transport.Products.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Eql;

public sealed partial class EqlSearchResponse<TEvent> : ElasticsearchResponse
{
	/// <summary>
	/// <para>Contains matching events and sequences. Also contains related metadata.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("hits")]
	public Elastic.Clients.Elasticsearch.Serverless.Eql.EqlHits<TEvent> Hits { get; init; }

	/// <summary>
	/// <para>Identifier for the search.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("id")]
	public string? Id { get; init; }

	/// <summary>
	/// <para>If true, the response does not contain complete search results.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("is_partial")]
	public bool? IsPartial { get; init; }

	/// <summary>
	/// <para>If true, the search request is still executing.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("is_running")]
	public bool? IsRunning { get; init; }

	/// <summary>
	/// <para>If true, the request timed out before completion.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("timed_out")]
	public bool? TimedOut { get; init; }

	/// <summary>
	/// <para>Milliseconds it took Elasticsearch to execute the request.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("took")]
	public long? Took { get; init; }
}