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

namespace Elastic.Clients.Elasticsearch.Serverless;

public sealed partial class IndexingStats
{
	[JsonInclude, JsonPropertyName("delete_current")]
	public long DeleteCurrent { get; init; }
	[JsonInclude, JsonPropertyName("delete_time")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? DeleteTime { get; init; }
	[JsonInclude, JsonPropertyName("delete_time_in_millis")]
	public long DeleteTimeInMillis { get; init; }
	[JsonInclude, JsonPropertyName("delete_total")]
	public long DeleteTotal { get; init; }
	[JsonInclude, JsonPropertyName("index_current")]
	public long IndexCurrent { get; init; }
	[JsonInclude, JsonPropertyName("index_failed")]
	public long IndexFailed { get; init; }
	[JsonInclude, JsonPropertyName("index_time")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? IndexTime { get; init; }
	[JsonInclude, JsonPropertyName("index_time_in_millis")]
	public long IndexTimeInMillis { get; init; }
	[JsonInclude, JsonPropertyName("index_total")]
	public long IndexTotal { get; init; }
	[JsonInclude, JsonPropertyName("is_throttled")]
	public bool IsThrottled { get; init; }
	[JsonInclude, JsonPropertyName("noop_update_total")]
	public long NoopUpdateTotal { get; init; }
	[JsonInclude, JsonPropertyName("throttle_time")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? ThrottleTime { get; init; }
	[JsonInclude, JsonPropertyName("throttle_time_in_millis")]
	public long ThrottleTimeInMillis { get; init; }
	[JsonInclude, JsonPropertyName("types")]
	public IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.Serverless.IndexingStats>? Types { get; init; }
	[JsonInclude, JsonPropertyName("write_load")]
	public double? WriteLoad { get; init; }
}