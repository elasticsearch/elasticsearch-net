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

internal sealed partial class NestedAggregateConverter : System.Text.Json.Serialization.JsonConverter<NestedAggregate>
{
	private static readonly System.Text.Json.JsonEncodedText PropDocCount = System.Text.Json.JsonEncodedText.Encode("doc_count");
	private static readonly System.Text.Json.JsonEncodedText PropMeta = System.Text.Json.JsonEncodedText.Encode("meta");

	public override NestedAggregate Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		System.Collections.Generic.Dictionary<string, Elastic.Clients.Elasticsearch.Aggregations.IAggregate> propAggregations = default;
		LocalJsonValue<long> propDocCount = default;
		LocalJsonValue<IReadOnlyDictionary<string, object>?> propMeta = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propDocCount.TryReadProperty(ref reader, options, PropDocCount, null))
			{
				continue;
			}

			if (propMeta.TryReadProperty(ref reader, options, PropMeta, static IReadOnlyDictionary<string, object>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadDictionaryValue<string, object>(o, null, null)))
			{
				continue;
			}

			propAggregations ??= new System.Collections.Generic.Dictionary<string, Elastic.Clients.Elasticsearch.Aggregations.IAggregate>();
			Elastic.Clients.Elasticsearch.Aggregations.AggregateDictionaryConverter.ReadItem(ref reader, options, out string key, out Elastic.Clients.Elasticsearch.Aggregations.IAggregate value);
			propAggregations[key] = value;
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new NestedAggregate
		{
			Aggregations = new Elastic.Clients.Elasticsearch.Aggregations.AggregateDictionary(propAggregations)
,
			DocCount = propDocCount.Value
,
			Meta = propMeta.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, NestedAggregate value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropDocCount, value.DocCount, null, null);
		writer.WriteProperty(options, PropMeta, value.Meta, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, IReadOnlyDictionary<string, object>? v) => w.WriteDictionaryValue<string, object>(o, v, null, null));
		if (value.Aggregations is not null)
		{
			foreach (var item in value.Aggregations)
			{
				Elastic.Clients.Elasticsearch.Aggregations.AggregateDictionaryConverter.WriteItem(writer, options, item.Key, item.Value);
			}
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(NestedAggregateConverter))]
public sealed partial class NestedAggregate : IAggregate
{
	/// <summary>
	/// <para>
	/// Nested aggregations
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Aggregations.AggregateDictionary Aggregations { get; init; }
	public long DocCount { get; init; }
	public IReadOnlyDictionary<string, object>? Meta { get; init; }

	string IAggregate.Type => "nested";
}