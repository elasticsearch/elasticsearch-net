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

namespace Elastic.Clients.Elasticsearch.Synonyms;

public sealed partial class PutSynonymRuleResponse : ElasticsearchResponse
{
	/// <summary>
	/// <para>Updating synonyms in a synonym set reloads the associated analyzers.<br/>This is the analyzers reloading result</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("reload_analyzers_details")]
	public Elastic.Clients.Elasticsearch.IndexManagement.ReloadResult ReloadAnalyzersDetails { get; init; }

	/// <summary>
	/// <para>Update operation result</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("result")]
	public Elastic.Clients.Elasticsearch.Result Result { get; init; }
}