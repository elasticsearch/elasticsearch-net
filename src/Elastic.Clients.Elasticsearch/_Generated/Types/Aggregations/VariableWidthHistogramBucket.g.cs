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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Aggregations;

[JsonConverter(typeof(VariableWidthHistogramBucketConverter))]
public sealed partial class VariableWidthHistogramBucket : AggregateDictionary
{
	public VariableWidthHistogramBucket(IReadOnlyDictionary<string, IAggregate> backingDictionary) : base(backingDictionary)
	{
	}

	[JsonInclude, JsonPropertyName("doc_count")]
	public long DocCount { get; init; }
	[JsonInclude, JsonPropertyName("key")]
	public double Key { get; init; }
	[JsonInclude, JsonPropertyName("key_as_string")]
	public string? KeyAsString { get; init; }
	[JsonInclude, JsonPropertyName("max")]
	public double Max { get; init; }
	[JsonInclude, JsonPropertyName("max_as_string")]
	public string? MaxAsString { get; init; }
	[JsonInclude, JsonPropertyName("min")]
	public double Min { get; init; }
	[JsonInclude, JsonPropertyName("min_as_string")]
	public string? MinAsString { get; init; }
}

internal sealed class VariableWidthHistogramBucketConverter : JsonConverter<VariableWidthHistogramBucket>
{
	public override VariableWidthHistogramBucket? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException($"Expected {JsonTokenType.StartObject} but read {reader.TokenType}.");
		var subAggs = new Dictionary<string, IAggregate>();// TODO - Optimise this and only create if we need it.
		long docCount = default;
		double key = default;
		string? keyAsString = default;
		double max = default;
		string? maxAsString = default;
		double min = default;
		string? minAsString = default;
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
				key = JsonSerializer.Deserialize<double>(ref reader, options);
				continue;
			}

			if (name.Equals("key_as_string", StringComparison.Ordinal))
			{
				keyAsString = JsonSerializer.Deserialize<string?>(ref reader, options);
				continue;
			}

			if (name.Equals("max", StringComparison.Ordinal))
			{
				max = JsonSerializer.Deserialize<double>(ref reader, options);
				continue;
			}

			if (name.Equals("max_as_string", StringComparison.Ordinal))
			{
				maxAsString = JsonSerializer.Deserialize<string?>(ref reader, options);
				continue;
			}

			if (name.Equals("min", StringComparison.Ordinal))
			{
				min = JsonSerializer.Deserialize<double>(ref reader, options);
				continue;
			}

			if (name.Equals("min_as_string", StringComparison.Ordinal))
			{
				minAsString = JsonSerializer.Deserialize<string?>(ref reader, options);
				continue;
			}

			if (name.Contains("#"))
			{
				AggregateDictionaryConverter.ReadAggregate(ref reader, options, subAggs, name);
				continue;
			}

			throw new JsonException("Unknown property read from JSON.");
		}

		return new VariableWidthHistogramBucket(subAggs) { DocCount = docCount, Key = key, KeyAsString = keyAsString, Max = max, MaxAsString = maxAsString, Min = min, MinAsString = minAsString };
	}

	public override void Write(Utf8JsonWriter writer, VariableWidthHistogramBucket value, JsonSerializerOptions options) => throw new NotImplementedException();
}