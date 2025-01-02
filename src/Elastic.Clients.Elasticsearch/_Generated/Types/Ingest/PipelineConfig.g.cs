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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Ingest;

public sealed partial class PipelineConfig
{
	/// <summary>
	/// <para>
	/// Description of the ingest pipeline.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; init; }

	/// <summary>
	/// <para>
	/// Processors used to perform transformations on documents before indexing.
	/// Processors run sequentially in the order specified.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("processors")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Ingest.Processor> Processors { get; init; }

	/// <summary>
	/// <para>
	/// Version number used by external systems to track ingest pipelines.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("version")]
	public long? Version { get; init; }
}