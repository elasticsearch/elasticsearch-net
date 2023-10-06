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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Aggregations;

[JsonConverter(typeof(StringRareTermsBucketConverter))]
public sealed partial class StringRareTermsBucket : AggregateDictionary
{
	public StringRareTermsBucket(IReadOnlyDictionary<string, IAggregate> backingDictionary) : base(backingDictionary)
	{
	}

	[JsonInclude, JsonPropertyName("doc_count")]
	public long DocCount { get; init; }
	[JsonInclude, JsonPropertyName("key")]
	public string Key { get; init; }
}

internal sealed class StringRareTermsBucketConverter : JsonConverter<StringRareTermsBucket>
{
	public override StringRareTermsBucket? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException($"Expected {JsonTokenType.StartObject} but read {reader.TokenType}.");
		var subAggs = new Dictionary<string, IAggregate>();// TODO - Optimise this and only create if we need it.
		long docCount = default;
		string key = default;
		while (reader.Read())
		{
			if (reader.TokenType == JsonTokenType.EndObject)
				break;
			if (reader.TokenType != JsonTokenType.PropertyName)
				throw new JsonException($"Expected {JsonTokenType.PropertyName} but read {reader.TokenType}.");
			var name = reader.GetString();// TODO: Future optimisation, get raw bytes span and parse based on those
			reader.Read();
			if (name.Equals("doc_count", StringComparison.Ordinal))
			{
				docCount = JsonSerializer.Deserialize<long>(ref reader, options);
				continue;
			}

			if (name.Equals("key", StringComparison.Ordinal))
			{
				key = JsonSerializer.Deserialize<string>(ref reader, options);
				continue;
			}

			if (name.Contains("#"))
			{
				AggregateDictionaryConverter.ReadAggregate(ref reader, options, subAggs, name);
				continue;
			}

			throw new JsonException("Unknown property read from JSON.");
		}

		return new StringRareTermsBucket(subAggs) { DocCount = docCount, Key = key };
	}

	public override void Write(Utf8JsonWriter writer, StringRareTermsBucket value, JsonSerializerOptions options) => throw new NotImplementedException();
}