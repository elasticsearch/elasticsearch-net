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
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class RolloverResponse : ElasticsearchResponse
{
	[JsonInclude, JsonPropertyName("acknowledged")]
	public bool Acknowledged { get; init; }
	[JsonInclude, JsonPropertyName("conditions")]
	public IReadOnlyDictionary<string, bool> Conditions { get; init; }
	[JsonInclude, JsonPropertyName("dry_run")]
	public bool DryRun { get; init; }
	[JsonInclude, JsonPropertyName("new_index")]
	public string NewIndex { get; init; }
	[JsonInclude, JsonPropertyName("old_index")]
	public string OldIndex { get; init; }
	[JsonInclude, JsonPropertyName("rolled_over")]
	public bool RolledOver { get; init; }
	[JsonInclude, JsonPropertyName("shards_acknowledged")]
	public bool ShardsAcknowledged { get; init; }
}