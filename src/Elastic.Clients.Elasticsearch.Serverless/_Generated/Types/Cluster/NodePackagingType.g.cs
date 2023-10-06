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

public sealed partial class NodePackagingType
{
	/// <summary>
	/// <para>Number of selected nodes using the distribution flavor and file type.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("count")]
	public int Count { get; init; }

	/// <summary>
	/// <para>Type of Elasticsearch distribution. This is always `default`.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("flavor")]
	public string Flavor { get; init; }

	/// <summary>
	/// <para>File type (such as `tar` or `zip`) used for the distribution package.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("type")]
	public string Type { get; init; }
}