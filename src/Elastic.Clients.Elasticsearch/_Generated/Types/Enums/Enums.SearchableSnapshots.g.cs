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

using Elastic.Clients.Elasticsearch.Core;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.SearchableSnapshots;

[JsonConverter(typeof(StatsLevelConverter))]
public enum StatsLevel
{
	[EnumMember(Value = "shards")]
	Shards,
	[EnumMember(Value = "indices")]
	Indices,
	[EnumMember(Value = "cluster")]
	Cluster
}

internal sealed partial class StatsLevelConverter : System.Text.Json.Serialization.JsonConverter<StatsLevel>
{
	private static readonly System.Text.Json.JsonEncodedText MemberShards = System.Text.Json.JsonEncodedText.Encode("shards");
	private static readonly System.Text.Json.JsonEncodedText MemberIndices = System.Text.Json.JsonEncodedText.Encode("indices");
	private static readonly System.Text.Json.JsonEncodedText MemberCluster = System.Text.Json.JsonEncodedText.Encode("cluster");

	public override StatsLevel Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.String);
		if (reader.ValueTextEquals(MemberShards))
		{
			return StatsLevel.Shards;
		}

		if (reader.ValueTextEquals(MemberIndices))
		{
			return StatsLevel.Indices;
		}

		if (reader.ValueTextEquals(MemberCluster))
		{
			return StatsLevel.Cluster;
		}

		var value = reader.GetString()!;
		if (string.Equals(value, MemberShards.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return StatsLevel.Shards;
		}

		if (string.Equals(value, MemberIndices.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return StatsLevel.Indices;
		}

		if (string.Equals(value, MemberCluster.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return StatsLevel.Cluster;
		}

		throw new System.Text.Json.JsonException($"Unknown member '{value}' for enum '{nameof(StatsLevel)}'.");
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, StatsLevel value, System.Text.Json.JsonSerializerOptions options)
	{
		switch (value)
		{
			case StatsLevel.Shards:
				writer.WriteStringValue(MemberShards);
				break;
			case StatsLevel.Indices:
				writer.WriteStringValue(MemberIndices);
				break;
			case StatsLevel.Cluster:
				writer.WriteStringValue(MemberCluster);
				break;
			default:
				throw new System.Text.Json.JsonException($"Invalid value '{value}' for enum '{nameof(StatsLevel)}'.");
		}
	}
}