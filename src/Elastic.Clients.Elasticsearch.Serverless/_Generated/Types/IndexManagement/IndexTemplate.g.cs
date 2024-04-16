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

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class IndexTemplate
{
	[JsonInclude, JsonPropertyName("allow_auto_create")]
	public bool? AllowAutoCreate { get; init; }

	/// <summary>
	/// <para>An ordered list of component template names.<br/>Component templates are merged in the order specified, meaning that the last component template specified has the highest precedence.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("composed_of")]
	public IReadOnlyCollection<string> ComposedOf { get; init; }

	/// <summary>
	/// <para>If this object is included, the template is used to create data streams and their backing indices.<br/>Supports an empty object.<br/>Data streams require a matching index template with a `data_stream` object.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("data_stream")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexTemplateDataStreamConfiguration? DataStream { get; init; }

	/// <summary>
	/// <para>Name of the index template.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index_patterns")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public IReadOnlyCollection<string> IndexPatterns { get; init; }

	/// <summary>
	/// <para>Optional user metadata about the index template. May have any contents.<br/>This map is not automatically generated by Elasticsearch.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_meta")]
	public IReadOnlyDictionary<string, object>? Meta { get; init; }

	/// <summary>
	/// <para>Priority to determine index template precedence when a new data stream or index is created.<br/>The index template with the highest priority is chosen.<br/>If no priority is specified the template is treated as though it is of priority 0 (lowest priority).<br/>This number is not automatically generated by Elasticsearch.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("priority")]
	public long? Priority { get; init; }

	/// <summary>
	/// <para>Template to be applied.<br/>It may optionally include an `aliases`, `mappings`, or `settings` configuration.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("template")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexTemplateSummary? Template { get; init; }

	/// <summary>
	/// <para>Version number used to manage index templates externally.<br/>This number is not automatically generated by Elasticsearch.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("version")]
	public long? Version { get; init; }
}