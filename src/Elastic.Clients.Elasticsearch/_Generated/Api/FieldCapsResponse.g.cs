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

namespace Elastic.Clients.Elasticsearch;

public sealed partial class FieldCapsResponse : ElasticsearchResponse
{
	[JsonInclude, JsonPropertyName("fields")]
	[ReadOnlyFieldDictionaryConverter(typeof(IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.Core.FieldCaps.FieldCapability>))]
	public IReadOnlyDictionary<Elastic.Clients.Elasticsearch.Field, IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.Core.FieldCaps.FieldCapability>> Fields { get; init; }
	[JsonInclude, JsonPropertyName("indices")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public IReadOnlyCollection<string> Indices { get; init; }
}