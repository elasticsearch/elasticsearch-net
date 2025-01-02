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
using Elastic.Transport.Products.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.TextStructure;

public sealed partial class FindFieldStructureResponse : ElasticsearchResponse
{
	[JsonInclude, JsonPropertyName("charset")]
	public string Charset { get; init; }
	[JsonInclude, JsonPropertyName("ecs_compatibility")]
	public Elastic.Clients.Elasticsearch.TextStructure.EcsCompatibilityType? EcsCompatibility { get; init; }
	[JsonInclude, JsonPropertyName("field_stats")]
	[ReadOnlyFieldDictionaryConverter(typeof(Elastic.Clients.Elasticsearch.TextStructure.FieldStat))]
	public IReadOnlyDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.TextStructure.FieldStat> FieldStats { get; init; }
	[JsonInclude, JsonPropertyName("format")]
	public Elastic.Clients.Elasticsearch.TextStructure.FormatType Format { get; init; }
	[JsonInclude, JsonPropertyName("grok_pattern")]
	public string? GrokPattern { get; init; }
	[JsonInclude, JsonPropertyName("ingest_pipeline")]
	public Elastic.Clients.Elasticsearch.Ingest.PipelineConfig IngestPipeline { get; init; }
	[JsonInclude, JsonPropertyName("java_timestamp_formats")]
	public IReadOnlyCollection<string>? JavaTimestampFormats { get; init; }
	[JsonInclude, JsonPropertyName("joda_timestamp_formats")]
	public IReadOnlyCollection<string>? JodaTimestampFormats { get; init; }
	[JsonInclude, JsonPropertyName("mappings")]
	public Elastic.Clients.Elasticsearch.Mapping.TypeMapping Mappings { get; init; }
	[JsonInclude, JsonPropertyName("multiline_start_pattern")]
	public string? MultilineStartPattern { get; init; }
	[JsonInclude, JsonPropertyName("need_client_timezone")]
	public bool NeedClientTimezone { get; init; }
	[JsonInclude, JsonPropertyName("num_lines_analyzed")]
	public int NumLinesAnalyzed { get; init; }
	[JsonInclude, JsonPropertyName("num_messages_analyzed")]
	public int NumMessagesAnalyzed { get; init; }
	[JsonInclude, JsonPropertyName("sample_start")]
	public string SampleStart { get; init; }
	[JsonInclude, JsonPropertyName("timestamp_field")]
	public string? TimestampField { get; init; }
}