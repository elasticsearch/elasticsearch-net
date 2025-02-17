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

internal sealed partial class GetServiceCredentialsResponseConverter : System.Text.Json.Serialization.JsonConverter<GetServiceCredentialsResponse>
{
	private static readonly System.Text.Json.JsonEncodedText PropCount = System.Text.Json.JsonEncodedText.Encode("count");
	private static readonly System.Text.Json.JsonEncodedText PropNodesCredentials = System.Text.Json.JsonEncodedText.Encode("nodes_credentials");
	private static readonly System.Text.Json.JsonEncodedText PropServiceAccount = System.Text.Json.JsonEncodedText.Encode("service_account");
	private static readonly System.Text.Json.JsonEncodedText PropTokens = System.Text.Json.JsonEncodedText.Encode("tokens");

	public override GetServiceCredentialsResponse Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<int> propCount = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.Security.NodesCredentials> propNodesCredentials = default;
		LocalJsonValue<string> propServiceAccount = default;
		LocalJsonValue<IReadOnlyDictionary<string, IReadOnlyDictionary<string, object>>> propTokens = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propCount.TryReadProperty(ref reader, options, PropCount, null))
			{
				continue;
			}

			if (propNodesCredentials.TryReadProperty(ref reader, options, PropNodesCredentials, null))
			{
				continue;
			}

			if (propServiceAccount.TryReadProperty(ref reader, options, PropServiceAccount, null))
			{
				continue;
			}

			if (propTokens.TryReadProperty(ref reader, options, PropTokens, static IReadOnlyDictionary<string, IReadOnlyDictionary<string, object>> (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadDictionaryValue<string, IReadOnlyDictionary<string, object>>(o, null, static IReadOnlyDictionary<string, object> (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadDictionaryValue<string, object>(o, null, null)!)!))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new GetServiceCredentialsResponse
		{
			Count = propCount.Value
,
			NodesCredentials = propNodesCredentials.Value
,
			ServiceAccount = propServiceAccount.Value
,
			Tokens = propTokens.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, GetServiceCredentialsResponse value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropCount, value.Count, null, null);
		writer.WriteProperty(options, PropNodesCredentials, value.NodesCredentials, null, null);
		writer.WriteProperty(options, PropServiceAccount, value.ServiceAccount, null, null);
		writer.WriteProperty(options, PropTokens, value.Tokens, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, IReadOnlyDictionary<string, IReadOnlyDictionary<string, object>> v) => w.WriteDictionaryValue<string, IReadOnlyDictionary<string, object>>(o, v, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, IReadOnlyDictionary<string, object> v) => w.WriteDictionaryValue<string, object>(o, v, null, null)));
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(GetServiceCredentialsResponseConverter))]
public sealed partial class GetServiceCredentialsResponse : ElasticsearchResponse
{
	public int Count { get; init; }

	/// <summary>
	/// <para>
	/// Contains service account credentials collected from all nodes of the cluster
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Security.NodesCredentials NodesCredentials { get; init; }
	public string ServiceAccount { get; init; }
	public IReadOnlyDictionary<string, IReadOnlyDictionary<string, object>> Tokens { get; init; }
}