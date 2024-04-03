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

namespace Elastic.Clients.Elasticsearch.Serverless.Core.Mtermvectors;

public sealed partial class MultiTermVectorsResult
{
	[JsonInclude, JsonPropertyName("error")]
	public Elastic.Clients.Elasticsearch.Serverless.ErrorCause? Error { get; init; }
	[JsonInclude, JsonPropertyName("found")]
	public bool? Found { get; init; }
	[JsonInclude, JsonPropertyName("_id")]
	public string Id { get; init; }
	[JsonInclude, JsonPropertyName("_index")]
	public string Index { get; init; }
	[JsonInclude, JsonPropertyName("term_vectors")]
	[ReadOnlyFieldDictionaryConverter(typeof(Elastic.Clients.Elasticsearch.Serverless.Core.TermVectors.TermVector))]
	public IReadOnlyDictionary<Elastic.Clients.Elasticsearch.Serverless.Field, Elastic.Clients.Elasticsearch.Serverless.Core.TermVectors.TermVector>? TermVectors { get; init; }
	[JsonInclude, JsonPropertyName("took")]
	public long? Took { get; init; }
	[JsonInclude, JsonPropertyName("_version")]
	public long? Version { get; init; }
}