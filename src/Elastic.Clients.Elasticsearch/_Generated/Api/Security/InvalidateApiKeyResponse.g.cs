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

internal sealed partial class InvalidateApiKeyResponseConverter : System.Text.Json.Serialization.JsonConverter<InvalidateApiKeyResponse>
{
	private static readonly System.Text.Json.JsonEncodedText PropErrorCount = System.Text.Json.JsonEncodedText.Encode("error_count");
	private static readonly System.Text.Json.JsonEncodedText PropErrorDetails = System.Text.Json.JsonEncodedText.Encode("error_details");
	private static readonly System.Text.Json.JsonEncodedText PropInvalidatedApiKeys = System.Text.Json.JsonEncodedText.Encode("invalidated_api_keys");
	private static readonly System.Text.Json.JsonEncodedText PropPreviouslyInvalidatedApiKeys = System.Text.Json.JsonEncodedText.Encode("previously_invalidated_api_keys");

	public override InvalidateApiKeyResponse Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<int> propErrorCount = default;
		LocalJsonValue<IReadOnlyCollection<Elastic.Clients.Elasticsearch.ErrorCause>?> propErrorDetails = default;
		LocalJsonValue<IReadOnlyCollection<string>> propInvalidatedApiKeys = default;
		LocalJsonValue<IReadOnlyCollection<string>> propPreviouslyInvalidatedApiKeys = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propErrorCount.TryReadProperty(ref reader, options, PropErrorCount, null))
			{
				continue;
			}

			if (propErrorDetails.TryReadProperty(ref reader, options, PropErrorDetails, static IReadOnlyCollection<Elastic.Clients.Elasticsearch.ErrorCause>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadCollectionValue<Elastic.Clients.Elasticsearch.ErrorCause>(o, null)))
			{
				continue;
			}

			if (propInvalidatedApiKeys.TryReadProperty(ref reader, options, PropInvalidatedApiKeys, static IReadOnlyCollection<string> (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadCollectionValue<string>(o, null)!))
			{
				continue;
			}

			if (propPreviouslyInvalidatedApiKeys.TryReadProperty(ref reader, options, PropPreviouslyInvalidatedApiKeys, static IReadOnlyCollection<string> (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadCollectionValue<string>(o, null)!))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new InvalidateApiKeyResponse
		{
			ErrorCount = propErrorCount.Value
,
			ErrorDetails = propErrorDetails.Value
,
			InvalidatedApiKeys = propInvalidatedApiKeys.Value
,
			PreviouslyInvalidatedApiKeys = propPreviouslyInvalidatedApiKeys.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, InvalidateApiKeyResponse value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropErrorCount, value.ErrorCount, null, null);
		writer.WriteProperty(options, PropErrorDetails, value.ErrorDetails, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, IReadOnlyCollection<Elastic.Clients.Elasticsearch.ErrorCause>? v) => w.WriteCollectionValue<Elastic.Clients.Elasticsearch.ErrorCause>(o, v, null));
		writer.WriteProperty(options, PropInvalidatedApiKeys, value.InvalidatedApiKeys, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, IReadOnlyCollection<string> v) => w.WriteCollectionValue<string>(o, v, null));
		writer.WriteProperty(options, PropPreviouslyInvalidatedApiKeys, value.PreviouslyInvalidatedApiKeys, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, IReadOnlyCollection<string> v) => w.WriteCollectionValue<string>(o, v, null));
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(InvalidateApiKeyResponseConverter))]
public sealed partial class InvalidateApiKeyResponse : ElasticsearchResponse
{
	public int ErrorCount { get; init; }
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.ErrorCause>? ErrorDetails { get; init; }
	public IReadOnlyCollection<string> InvalidatedApiKeys { get; init; }
	public IReadOnlyCollection<string> PreviouslyInvalidatedApiKeys { get; init; }
}