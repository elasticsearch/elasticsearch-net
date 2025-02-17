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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

internal sealed partial class FieldUsageStatsResponseConverter : System.Text.Json.Serialization.JsonConverter<FieldUsageStatsResponse>
{
	private static readonly System.Text.Json.JsonEncodedText PropShards = System.Text.Json.JsonEncodedText.Encode("_shards");

	public override FieldUsageStatsResponse Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<Elastic.Clients.Elasticsearch.ShardStatistics> propShards = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propShards.TryReadProperty(ref reader, options, PropShards, null))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new FieldUsageStatsResponse
		{
			Shards = propShards.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, FieldUsageStatsResponse value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropShards, value.Shards, null, null);
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(FieldUsageStatsResponseConverter))]
public sealed partial class FieldUsageStatsResponse : ElasticsearchResponse
{
	public Elastic.Clients.Elasticsearch.ShardStatistics Shards { get; init; }
}