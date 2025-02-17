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

namespace Elastic.Clients.Elasticsearch;

internal sealed partial class IndexResponseConverter : System.Text.Json.Serialization.JsonConverter<IndexResponse>
{
	private static readonly System.Text.Json.JsonEncodedText PropForcedRefresh = System.Text.Json.JsonEncodedText.Encode("forced_refresh");
	private static readonly System.Text.Json.JsonEncodedText PropId = System.Text.Json.JsonEncodedText.Encode("_id");
	private static readonly System.Text.Json.JsonEncodedText PropIndex = System.Text.Json.JsonEncodedText.Encode("_index");
	private static readonly System.Text.Json.JsonEncodedText PropPrimaryTerm = System.Text.Json.JsonEncodedText.Encode("_primary_term");
	private static readonly System.Text.Json.JsonEncodedText PropResult = System.Text.Json.JsonEncodedText.Encode("result");
	private static readonly System.Text.Json.JsonEncodedText PropSeqNo = System.Text.Json.JsonEncodedText.Encode("_seq_no");
	private static readonly System.Text.Json.JsonEncodedText PropShards = System.Text.Json.JsonEncodedText.Encode("_shards");
	private static readonly System.Text.Json.JsonEncodedText PropVersion = System.Text.Json.JsonEncodedText.Encode("_version");

	public override IndexResponse Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<bool?> propForcedRefresh = default;
		LocalJsonValue<string> propId = default;
		LocalJsonValue<string> propIndex = default;
		LocalJsonValue<long?> propPrimaryTerm = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.Result> propResult = default;
		LocalJsonValue<long?> propSeqNo = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.ShardStatistics> propShards = default;
		LocalJsonValue<long> propVersion = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propForcedRefresh.TryReadProperty(ref reader, options, PropForcedRefresh, null))
			{
				continue;
			}

			if (propId.TryReadProperty(ref reader, options, PropId, null))
			{
				continue;
			}

			if (propIndex.TryReadProperty(ref reader, options, PropIndex, null))
			{
				continue;
			}

			if (propPrimaryTerm.TryReadProperty(ref reader, options, PropPrimaryTerm, null))
			{
				continue;
			}

			if (propResult.TryReadProperty(ref reader, options, PropResult, null))
			{
				continue;
			}

			if (propSeqNo.TryReadProperty(ref reader, options, PropSeqNo, null))
			{
				continue;
			}

			if (propShards.TryReadProperty(ref reader, options, PropShards, null))
			{
				continue;
			}

			if (propVersion.TryReadProperty(ref reader, options, PropVersion, null))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new IndexResponse
		{
			ForcedRefresh = propForcedRefresh.Value
,
			Id = propId.Value
,
			Index = propIndex.Value
,
			PrimaryTerm = propPrimaryTerm.Value
,
			Result = propResult.Value
,
			SeqNo = propSeqNo.Value
,
			Shards = propShards.Value
,
			Version = propVersion.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, IndexResponse value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropForcedRefresh, value.ForcedRefresh, null, null);
		writer.WriteProperty(options, PropId, value.Id, null, null);
		writer.WriteProperty(options, PropIndex, value.Index, null, null);
		writer.WriteProperty(options, PropPrimaryTerm, value.PrimaryTerm, null, null);
		writer.WriteProperty(options, PropResult, value.Result, null, null);
		writer.WriteProperty(options, PropSeqNo, value.SeqNo, null, null);
		writer.WriteProperty(options, PropShards, value.Shards, null, null);
		writer.WriteProperty(options, PropVersion, value.Version, null, null);
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(IndexResponseConverter))]
public sealed partial class IndexResponse : ElasticsearchResponse
{
	public bool? ForcedRefresh { get; init; }
	public string Id { get; init; }
	public string Index { get; init; }
	public long? PrimaryTerm { get; init; }
	public Elastic.Clients.Elasticsearch.Result Result { get; init; }
	public long? SeqNo { get; init; }
	public Elastic.Clients.Elasticsearch.ShardStatistics Shards { get; init; }
	public long Version { get; init; }
}