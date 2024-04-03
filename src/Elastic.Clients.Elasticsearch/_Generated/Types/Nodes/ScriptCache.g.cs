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

namespace Elastic.Clients.Elasticsearch.Nodes;

public sealed partial class ScriptCache
{
	/// <summary>
	/// <para>Total number of times the script cache has evicted old data.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("cache_evictions")]
	public long? CacheEvictions { get; init; }

	/// <summary>
	/// <para>Total number of times the script compilation circuit breaker has limited inline script compilations.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("compilation_limit_triggered")]
	public long? CompilationLimitTriggered { get; init; }

	/// <summary>
	/// <para>Total number of inline script compilations performed by the node.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("compilations")]
	public long? Compilations { get; init; }
	[JsonInclude, JsonPropertyName("context")]
	public string? Context { get; init; }
}