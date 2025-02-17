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

internal sealed partial class GetScriptResponseConverter : System.Text.Json.Serialization.JsonConverter<GetScriptResponse>
{
	private static readonly System.Text.Json.JsonEncodedText PropFound = System.Text.Json.JsonEncodedText.Encode("found");
	private static readonly System.Text.Json.JsonEncodedText PropId = System.Text.Json.JsonEncodedText.Encode("_id");
	private static readonly System.Text.Json.JsonEncodedText PropScript = System.Text.Json.JsonEncodedText.Encode("script");

	public override GetScriptResponse Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<bool> propFound = default;
		LocalJsonValue<string> propId = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.StoredScript?> propScript = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propFound.TryReadProperty(ref reader, options, PropFound, null))
			{
				continue;
			}

			if (propId.TryReadProperty(ref reader, options, PropId, null))
			{
				continue;
			}

			if (propScript.TryReadProperty(ref reader, options, PropScript, null))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new GetScriptResponse
		{
			Found = propFound.Value
,
			Id = propId.Value
,
			Script = propScript.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, GetScriptResponse value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropFound, value.Found, null, null);
		writer.WriteProperty(options, PropId, value.Id, null, null);
		writer.WriteProperty(options, PropScript, value.Script, null, null);
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(GetScriptResponseConverter))]
public sealed partial class GetScriptResponse : ElasticsearchResponse
{
	public bool Found { get; init; }
	public string Id { get; init; }
	public Elastic.Clients.Elasticsearch.StoredScript? Script { get; init; }
}