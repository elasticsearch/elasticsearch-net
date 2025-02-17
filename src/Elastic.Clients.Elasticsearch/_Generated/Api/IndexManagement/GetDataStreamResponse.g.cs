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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

internal sealed partial class GetDataStreamResponseConverter : System.Text.Json.Serialization.JsonConverter<GetDataStreamResponse>
{
	private static readonly System.Text.Json.JsonEncodedText PropDataStreams = System.Text.Json.JsonEncodedText.Encode("data_streams");

	public override GetDataStreamResponse Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<IReadOnlyCollection<Elastic.Clients.Elasticsearch.IndexManagement.DataStream>> propDataStreams = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propDataStreams.TryReadProperty(ref reader, options, PropDataStreams, static IReadOnlyCollection<Elastic.Clients.Elasticsearch.IndexManagement.DataStream> (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadCollectionValue<Elastic.Clients.Elasticsearch.IndexManagement.DataStream>(o, null)!))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new GetDataStreamResponse
		{
			DataStreams = propDataStreams.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, GetDataStreamResponse value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropDataStreams, value.DataStreams, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, IReadOnlyCollection<Elastic.Clients.Elasticsearch.IndexManagement.DataStream> v) => w.WriteCollectionValue<Elastic.Clients.Elasticsearch.IndexManagement.DataStream>(o, v, null));
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(GetDataStreamResponseConverter))]
public sealed partial class GetDataStreamResponse : ElasticsearchResponse
{
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.IndexManagement.DataStream> DataStreams { get; init; }
}