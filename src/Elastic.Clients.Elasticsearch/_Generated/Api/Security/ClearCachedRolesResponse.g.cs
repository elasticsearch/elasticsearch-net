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
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Security;

internal sealed partial class ClearCachedRolesResponseConverter : System.Text.Json.Serialization.JsonConverter<ClearCachedRolesResponse>
{
	private static readonly System.Text.Json.JsonEncodedText PropClusterName = System.Text.Json.JsonEncodedText.Encode("cluster_name");
	private static readonly System.Text.Json.JsonEncodedText PropNodes = System.Text.Json.JsonEncodedText.Encode("nodes");
	private static readonly System.Text.Json.JsonEncodedText PropNodeStats = System.Text.Json.JsonEncodedText.Encode("_nodes");

	public override ClearCachedRolesResponse Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<string> propClusterName = default;
		LocalJsonValue<IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.Security.ClusterNode>> propNodes = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.NodeStatistics> propNodeStats = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propClusterName.TryReadProperty(ref reader, options, PropClusterName, null))
			{
				continue;
			}

			if (propNodes.TryReadProperty(ref reader, options, PropNodes, static IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.Security.ClusterNode> (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadDictionaryValue<string, Elastic.Clients.Elasticsearch.Security.ClusterNode>(o, null, null)!))
			{
				continue;
			}

			if (propNodeStats.TryReadProperty(ref reader, options, PropNodeStats, null))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new ClearCachedRolesResponse
		{
			ClusterName = propClusterName.Value
,
			Nodes = propNodes.Value
,
			NodeStats = propNodeStats.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, ClearCachedRolesResponse value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropClusterName, value.ClusterName, null, null);
		writer.WriteProperty(options, PropNodes, value.Nodes, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.Security.ClusterNode> v) => w.WriteDictionaryValue<string, Elastic.Clients.Elasticsearch.Security.ClusterNode>(o, v, null, null));
		writer.WriteProperty(options, PropNodeStats, value.NodeStats, null, null);
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(ClearCachedRolesResponseConverter))]
public sealed partial class ClearCachedRolesResponse : ElasticsearchResponse
{
	public string ClusterName { get; init; }
	public IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.Security.ClusterNode> Nodes { get; init; }
	public Elastic.Clients.Elasticsearch.NodeStatistics NodeStats { get; init; }
}