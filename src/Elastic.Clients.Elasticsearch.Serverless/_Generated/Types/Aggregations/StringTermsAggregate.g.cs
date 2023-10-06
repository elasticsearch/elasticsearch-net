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

namespace Elastic.Clients.Elasticsearch.Serverless.Aggregations;

/// <summary>
/// <para>Result of a `terms` aggregation when the field is a string.</para>
/// </summary>
public sealed partial class StringTermsAggregate : IAggregate
{
	[JsonInclude, JsonPropertyName("buckets")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Aggregations.StringTermsBucket> Buckets { get; init; }
	[JsonInclude, JsonPropertyName("doc_count_error_upper_bound")]
	public long? DocCountErrorUpperBound { get; init; }
	[JsonInclude, JsonPropertyName("meta")]
	public IReadOnlyDictionary<string, object>? Meta { get; init; }
	[JsonInclude, JsonPropertyName("sum_other_doc_count")]
	public long? SumOtherDocCount { get; init; }
}