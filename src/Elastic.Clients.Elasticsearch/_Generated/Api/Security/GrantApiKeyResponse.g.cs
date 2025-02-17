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

internal sealed partial class GrantApiKeyResponseConverter : System.Text.Json.Serialization.JsonConverter<GrantApiKeyResponse>
{
	private static readonly System.Text.Json.JsonEncodedText PropApiKey = System.Text.Json.JsonEncodedText.Encode("api_key");
	private static readonly System.Text.Json.JsonEncodedText PropEncoded = System.Text.Json.JsonEncodedText.Encode("encoded");
	private static readonly System.Text.Json.JsonEncodedText PropExpiration = System.Text.Json.JsonEncodedText.Encode("expiration");
	private static readonly System.Text.Json.JsonEncodedText PropId = System.Text.Json.JsonEncodedText.Encode("id");
	private static readonly System.Text.Json.JsonEncodedText PropName = System.Text.Json.JsonEncodedText.Encode("name");

	public override GrantApiKeyResponse Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<string> propApiKey = default;
		LocalJsonValue<string> propEncoded = default;
		LocalJsonValue<long?> propExpiration = default;
		LocalJsonValue<string> propId = default;
		LocalJsonValue<string> propName = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propApiKey.TryReadProperty(ref reader, options, PropApiKey, null))
			{
				continue;
			}

			if (propEncoded.TryReadProperty(ref reader, options, PropEncoded, null))
			{
				continue;
			}

			if (propExpiration.TryReadProperty(ref reader, options, PropExpiration, null))
			{
				continue;
			}

			if (propId.TryReadProperty(ref reader, options, PropId, null))
			{
				continue;
			}

			if (propName.TryReadProperty(ref reader, options, PropName, null))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new GrantApiKeyResponse
		{
			ApiKey = propApiKey.Value
,
			Encoded = propEncoded.Value
,
			Expiration = propExpiration.Value
,
			Id = propId.Value
,
			Name = propName.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, GrantApiKeyResponse value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropApiKey, value.ApiKey, null, null);
		writer.WriteProperty(options, PropEncoded, value.Encoded, null, null);
		writer.WriteProperty(options, PropExpiration, value.Expiration, null, null);
		writer.WriteProperty(options, PropId, value.Id, null, null);
		writer.WriteProperty(options, PropName, value.Name, null, null);
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(GrantApiKeyResponseConverter))]
public sealed partial class GrantApiKeyResponse : ElasticsearchResponse
{
	public string ApiKey { get; init; }
	public string Encoded { get; init; }
	public long? Expiration { get; init; }
	public string Id { get; init; }
	public string Name { get; init; }
}