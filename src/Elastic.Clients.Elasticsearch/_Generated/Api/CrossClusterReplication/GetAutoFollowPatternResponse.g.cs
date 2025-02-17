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

namespace Elastic.Clients.Elasticsearch.CrossClusterReplication;

internal sealed partial class GetAutoFollowPatternResponseConverter : System.Text.Json.Serialization.JsonConverter<GetAutoFollowPatternResponse>
{
	private static readonly System.Text.Json.JsonEncodedText PropPatterns = System.Text.Json.JsonEncodedText.Encode("patterns");

	public override GetAutoFollowPatternResponse Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<IReadOnlyCollection<Elastic.Clients.Elasticsearch.CrossClusterReplication.AutoFollowPattern>> propPatterns = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propPatterns.TryReadProperty(ref reader, options, PropPatterns, static IReadOnlyCollection<Elastic.Clients.Elasticsearch.CrossClusterReplication.AutoFollowPattern> (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadCollectionValue<Elastic.Clients.Elasticsearch.CrossClusterReplication.AutoFollowPattern>(o, null)!))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new GetAutoFollowPatternResponse
		{
			Patterns = propPatterns.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, GetAutoFollowPatternResponse value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropPatterns, value.Patterns, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, IReadOnlyCollection<Elastic.Clients.Elasticsearch.CrossClusterReplication.AutoFollowPattern> v) => w.WriteCollectionValue<Elastic.Clients.Elasticsearch.CrossClusterReplication.AutoFollowPattern>(o, v, null));
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(GetAutoFollowPatternResponseConverter))]
public sealed partial class GetAutoFollowPatternResponse : ElasticsearchResponse
{
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.CrossClusterReplication.AutoFollowPattern> Patterns { get; init; }
}