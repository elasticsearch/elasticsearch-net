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

namespace Elastic.Clients.Elasticsearch.Serverless.Cluster;

public sealed partial class ComponentTemplateSummary
{
	[JsonInclude, JsonPropertyName("aliases")]
	public IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.AliasDefinition>? Aliases { get; init; }
	[JsonInclude, JsonPropertyName("lifecycle")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamLifecycleWithRollover? Lifecycle { get; init; }
	[JsonInclude, JsonPropertyName("mappings")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMapping? Mappings { get; init; }
	[JsonInclude, JsonPropertyName("_meta")]
	public IReadOnlyDictionary<string, object>? Meta { get; init; }
	[JsonInclude, JsonPropertyName("settings")]
	[ReadOnlyIndexNameDictionaryConverter(typeof(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettings))]
	public IReadOnlyDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettings>? Settings { get; init; }
	[JsonInclude, JsonPropertyName("version")]
	public long? Version { get; init; }
}