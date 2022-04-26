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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	[JsonConverter(typeof(RangeBucketConverter))]
	public sealed partial class RangeBucket : AggregateDictionary
	{
		public RangeBucket(IReadOnlyDictionary<string, AggregateBase> backingDictionary) : base(backingDictionary)
		{
		}

		[JsonInclude]
		[JsonPropertyName("doc_count")]
		public long DocCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("from")]
		public double? From { get; init; }

		[JsonInclude]
		[JsonPropertyName("from_as_string")]
		public string? FromAsString { get; init; }

		[JsonInclude]
		[JsonPropertyName("key")]
		public string? Key { get; init; }

		[JsonInclude]
		[JsonPropertyName("to")]
		public double? To { get; init; }

		[JsonInclude]
		[JsonPropertyName("to_as_string")]
		public string? ToAsString { get; init; }
	}

	internal sealed class RangeBucketConverter : JsonConverter<RangeBucket>
	{
		public override RangeBucket? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException($"Expected {JsonTokenType.StartObject} but read {reader.TokenType}.");
			var subAggs = new Dictionary<string, AggregateBase>(); // TODO - Optimise this and only create if we need it.
			long docCount = default;
			double? from = default;
			string? fromAsString = default;
			string? key = default;
			double? to = default;
			string? toAsString = default;
			while (reader.Read())
			{
				if (reader.TokenType == JsonTokenType.EndObject)
					break;
				if (reader.TokenType != JsonTokenType.PropertyName)
					throw new JsonException($"Expected {JsonTokenType.PropertyName} but read {reader.TokenType}.");
				var name = reader.GetString(); // TODO: Future optimisation, get raw bytes span and parse based on those
				reader.Read();
				if (name.Equals("doc_count", StringComparison.Ordinal))
				{
					docCount = JsonSerializer.Deserialize<long>(ref reader, options);
					continue;
				}

				if (name.Equals("from", StringComparison.Ordinal))
				{
					from = JsonSerializer.Deserialize<double?>(ref reader, options);
					continue;
				}

				if (name.Equals("from_as_string", StringComparison.Ordinal))
				{
					fromAsString = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (name.Equals("key", StringComparison.Ordinal))
				{
					key = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (name.Equals("to", StringComparison.Ordinal))
				{
					to = JsonSerializer.Deserialize<double?>(ref reader, options);
					continue;
				}

				if (name.Equals("to_as_string", StringComparison.Ordinal))
				{
					toAsString = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (name.Contains("#"))
				{
					AggregateDictionaryConverter.ReadAggregate(ref reader, options, subAggs, name);
					continue;
				}

				throw new JsonException("Unknown property read from JSON.");
			}

			return new RangeBucket(subAggs)
			{ DocCount = docCount, From = from, FromAsString = fromAsString, Key = key, To = to, ToAsString = toAsString };
		}

		public override void Write(Utf8JsonWriter writer, RangeBucket value, JsonSerializerOptions options) => throw new NotImplementedException();
	}
}