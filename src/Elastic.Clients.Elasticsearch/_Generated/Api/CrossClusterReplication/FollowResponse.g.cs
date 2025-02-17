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

internal sealed partial class FollowResponseConverter : System.Text.Json.Serialization.JsonConverter<FollowResponse>
{
	private static readonly System.Text.Json.JsonEncodedText PropFollowIndexCreated = System.Text.Json.JsonEncodedText.Encode("follow_index_created");
	private static readonly System.Text.Json.JsonEncodedText PropFollowIndexShardsAcked = System.Text.Json.JsonEncodedText.Encode("follow_index_shards_acked");
	private static readonly System.Text.Json.JsonEncodedText PropIndexFollowingStarted = System.Text.Json.JsonEncodedText.Encode("index_following_started");

	public override FollowResponse Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<bool> propFollowIndexCreated = default;
		LocalJsonValue<bool> propFollowIndexShardsAcked = default;
		LocalJsonValue<bool> propIndexFollowingStarted = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propFollowIndexCreated.TryReadProperty(ref reader, options, PropFollowIndexCreated, null))
			{
				continue;
			}

			if (propFollowIndexShardsAcked.TryReadProperty(ref reader, options, PropFollowIndexShardsAcked, null))
			{
				continue;
			}

			if (propIndexFollowingStarted.TryReadProperty(ref reader, options, PropIndexFollowingStarted, null))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new FollowResponse
		{
			FollowIndexCreated = propFollowIndexCreated.Value
,
			FollowIndexShardsAcked = propFollowIndexShardsAcked.Value
,
			IndexFollowingStarted = propIndexFollowingStarted.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, FollowResponse value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropFollowIndexCreated, value.FollowIndexCreated, null, null);
		writer.WriteProperty(options, PropFollowIndexShardsAcked, value.FollowIndexShardsAcked, null, null);
		writer.WriteProperty(options, PropIndexFollowingStarted, value.IndexFollowingStarted, null, null);
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(FollowResponseConverter))]
public sealed partial class FollowResponse : ElasticsearchResponse
{
	public bool FollowIndexCreated { get; init; }
	public bool FollowIndexShardsAcked { get; init; }
	public bool IndexFollowingStarted { get; init; }
}