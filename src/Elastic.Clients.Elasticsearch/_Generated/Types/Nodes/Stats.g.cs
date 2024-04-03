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

public sealed partial class Stats
{
	/// <summary>
	/// <para>Statistics about adaptive replica selection.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("adaptive_selection")]
	public IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.Nodes.AdaptiveSelection>? AdaptiveSelection { get; init; }

	/// <summary>
	/// <para>Contains a list of attributes for the node.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("attributes")]
	[ReadOnlyFieldDictionaryConverter(typeof(string))]
	public IReadOnlyDictionary<Elastic.Clients.Elasticsearch.Field, string>? Attributes { get; init; }

	/// <summary>
	/// <para>Statistics about the field data circuit breaker.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("breakers")]
	public IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.Nodes.Breaker>? Breakers { get; init; }

	/// <summary>
	/// <para>Contains node discovery statistics for the node.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("discovery")]
	public Elastic.Clients.Elasticsearch.Nodes.Discovery? Discovery { get; init; }

	/// <summary>
	/// <para>File system information, data path, free disk space, read/write stats.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fs")]
	public Elastic.Clients.Elasticsearch.Nodes.FileSystem? Fs { get; init; }

	/// <summary>
	/// <para>Network host for the node, based on the network host setting.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("host")]
	public string? Host { get; init; }

	/// <summary>
	/// <para>HTTP connection information.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("http")]
	public Elastic.Clients.Elasticsearch.Nodes.Http? Http { get; init; }

	/// <summary>
	/// <para>Contains indexing pressure statistics for the node.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("indexing_pressure")]
	public Elastic.Clients.Elasticsearch.Nodes.IndexingPressure? IndexingPressure { get; init; }

	/// <summary>
	/// <para>Indices stats about size, document count, indexing and deletion times, search times, field cache size, merges and flushes.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("indices")]
	public Elastic.Clients.Elasticsearch.IndexManagement.ShardStats? Indices { get; init; }

	/// <summary>
	/// <para>Statistics about ingest preprocessing.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ingest")]
	public Elastic.Clients.Elasticsearch.Nodes.Ingest? Ingest { get; init; }

	/// <summary>
	/// <para>IP address and port for the node.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ip")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public IReadOnlyCollection<string>? Ip { get; init; }

	/// <summary>
	/// <para>JVM stats, memory pool information, garbage collection, buffer pools, number of loaded/unloaded classes.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("jvm")]
	public Elastic.Clients.Elasticsearch.Nodes.Jvm? Jvm { get; init; }

	/// <summary>
	/// <para>Human-readable identifier for the node.<br/>Based on the node name setting.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("name")]
	public string? Name { get; init; }

	/// <summary>
	/// <para>Operating system stats, load average, mem, swap.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("os")]
	public Elastic.Clients.Elasticsearch.Nodes.OperatingSystem? Os { get; init; }

	/// <summary>
	/// <para>Process statistics, memory consumption, cpu usage, open file descriptors.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("process")]
	public Elastic.Clients.Elasticsearch.Nodes.Process? Process { get; init; }

	/// <summary>
	/// <para>Roles assigned to the node.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("roles")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.NodeRole>? Roles { get; init; }

	/// <summary>
	/// <para>Contains script statistics for the node.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Nodes.Scripting? Script { get; init; }
	[JsonInclude, JsonPropertyName("script_cache")]
	public IReadOnlyDictionary<string, Union<Elastic.Clients.Elasticsearch.Nodes.ScriptCache, IReadOnlyCollection<Elastic.Clients.Elasticsearch.Nodes.ScriptCache>>>? ScriptCache { get; init; }

	/// <summary>
	/// <para>Statistics about each thread pool, including current size, queue and rejected tasks.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("thread_pool")]
	public IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.Nodes.ThreadCount>? ThreadPool { get; init; }
	[JsonInclude, JsonPropertyName("timestamp")]
	public long? Timestamp { get; init; }

	/// <summary>
	/// <para>Transport statistics about sent and received bytes in cluster communication.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("transport")]
	public Elastic.Clients.Elasticsearch.Nodes.Transport? Transport { get; init; }

	/// <summary>
	/// <para>Host and port for the transport layer, used for internal communication between nodes in a cluster.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("transport_address")]
	public string? TransportAddress { get; init; }
}