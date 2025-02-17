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

internal sealed partial class GetResponseConverter<TDocument> : System.Text.Json.Serialization.JsonConverter<GetResponse<TDocument>>
{
	private static readonly System.Text.Json.JsonEncodedText PropFields = System.Text.Json.JsonEncodedText.Encode("fields");
	private static readonly System.Text.Json.JsonEncodedText PropFound = System.Text.Json.JsonEncodedText.Encode("found");
	private static readonly System.Text.Json.JsonEncodedText PropId = System.Text.Json.JsonEncodedText.Encode("_id");
	private static readonly System.Text.Json.JsonEncodedText PropIgnored = System.Text.Json.JsonEncodedText.Encode("_ignored");
	private static readonly System.Text.Json.JsonEncodedText PropIndex = System.Text.Json.JsonEncodedText.Encode("_index");
	private static readonly System.Text.Json.JsonEncodedText PropPrimaryTerm = System.Text.Json.JsonEncodedText.Encode("_primary_term");
	private static readonly System.Text.Json.JsonEncodedText PropRouting = System.Text.Json.JsonEncodedText.Encode("_routing");
	private static readonly System.Text.Json.JsonEncodedText PropSeqNo = System.Text.Json.JsonEncodedText.Encode("_seq_no");
	private static readonly System.Text.Json.JsonEncodedText PropSource = System.Text.Json.JsonEncodedText.Encode("_source");
	private static readonly System.Text.Json.JsonEncodedText PropVersion = System.Text.Json.JsonEncodedText.Encode("_version");

	public override GetResponse<TDocument> Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<Elastic.Clients.Elasticsearch.FieldValues?> propFields = default;
		LocalJsonValue<bool> propFound = default;
		LocalJsonValue<string> propId = default;
		LocalJsonValue<IReadOnlyCollection<string>?> propIgnored = default;
		LocalJsonValue<string> propIndex = default;
		LocalJsonValue<long?> propPrimaryTerm = default;
		LocalJsonValue<string?> propRouting = default;
		LocalJsonValue<long?> propSeqNo = default;
		LocalJsonValue<TDocument?> propSource = default;
		LocalJsonValue<long?> propVersion = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propFields.TryReadProperty(ref reader, options, PropFields, null))
			{
				continue;
			}

			if (propFound.TryReadProperty(ref reader, options, PropFound, null))
			{
				continue;
			}

			if (propId.TryReadProperty(ref reader, options, PropId, null))
			{
				continue;
			}

			if (propIgnored.TryReadProperty(ref reader, options, PropIgnored, static IReadOnlyCollection<string>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadCollectionValue<string>(o, null)))
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

			if (propRouting.TryReadProperty(ref reader, options, PropRouting, null))
			{
				continue;
			}

			if (propSeqNo.TryReadProperty(ref reader, options, PropSeqNo, null))
			{
				continue;
			}

			if (propSource.TryReadProperty(ref reader, options, PropSource, static TDocument? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadValueEx<TDocument?>(o, typeof(SourceMarker<TDocument?>))))
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
		return new GetResponse<TDocument>
		{
			Fields = propFields.Value
,
			Found = propFound.Value
,
			Id = propId.Value
,
			Ignored = propIgnored.Value
,
			Index = propIndex.Value
,
			PrimaryTerm = propPrimaryTerm.Value
,
			Routing = propRouting.Value
,
			SeqNo = propSeqNo.Value
,
			Source = propSource.Value
,
			Version = propVersion.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, GetResponse<TDocument> value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropFields, value.Fields, null, null);
		writer.WriteProperty(options, PropFound, value.Found, null, null);
		writer.WriteProperty(options, PropId, value.Id, null, null);
		writer.WriteProperty(options, PropIgnored, value.Ignored, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, IReadOnlyCollection<string>? v) => w.WriteCollectionValue<string>(o, v, null));
		writer.WriteProperty(options, PropIndex, value.Index, null, null);
		writer.WriteProperty(options, PropPrimaryTerm, value.PrimaryTerm, null, null);
		writer.WriteProperty(options, PropRouting, value.Routing, null, null);
		writer.WriteProperty(options, PropSeqNo, value.SeqNo, null, null);
		writer.WriteProperty(options, PropSource, value.Source, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, TDocument? v) => w.WriteValueEx<TDocument?>(o, v, typeof(SourceMarker<TDocument?>)));
		writer.WriteProperty(options, PropVersion, value.Version, null, null);
		writer.WriteEndObject();
	}
}

internal sealed partial class GetResponseConverterFactory : System.Text.Json.Serialization.JsonConverterFactory
{
	public override bool CanConvert(System.Type typeToConvert)
	{
		return typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(GetResponse<>);
	}

	public override System.Text.Json.Serialization.JsonConverter CreateConverter(System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		var args = typeToConvert.GetGenericArguments();
#pragma warning disable IL3050
		var converter = (System.Text.Json.Serialization.JsonConverter)System.Activator.CreateInstance(typeof(GetResponseConverter<>).MakeGenericType(args[0]), System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public, binder: null, args: null, culture: null)!;
#pragma warning restore IL3050
		return converter;
	}
}

[JsonConverter(typeof(GetResponseConverterFactory))]
public sealed partial class GetResponse<TDocument> : ElasticsearchResponse
{
	public Elastic.Clients.Elasticsearch.FieldValues? Fields { get; init; }
	public bool Found { get; init; }
	public string Id { get; init; }
	public IReadOnlyCollection<string>? Ignored { get; init; }
	public string Index { get; init; }
	public long? PrimaryTerm { get; init; }
	public string? Routing { get; init; }
	public long? SeqNo { get; init; }
	public TDocument? Source { get; init; }
	public long? Version { get; init; }
}