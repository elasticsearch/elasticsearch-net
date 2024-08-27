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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed partial class DataStreamIndex
{
	/// <summary>
	/// <para>
	/// Name of the current ILM lifecycle policy configured for this backing index.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ilm_policy")]
	public string? IlmPolicy { get; init; }

	/// <summary>
	/// <para>
	/// Name of the backing index.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index_name")]
	public string IndexName { get; init; }

	/// <summary>
	/// <para>
	/// Universally unique identifier (UUID) for the index.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index_uuid")]
	public string IndexUuid { get; init; }

	/// <summary>
	/// <para>
	/// Name of the lifecycle system that's currently managing this backing index.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("managed_by")]
	public Elastic.Clients.Elasticsearch.IndexManagement.ManagedBy? ManagedBy { get; init; }

	/// <summary>
	/// <para>
	/// Indicates if ILM should take precedence over DSL in case both are configured to manage this index.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("prefer_ilm")]
	public bool? PreferIlm { get; init; }
}