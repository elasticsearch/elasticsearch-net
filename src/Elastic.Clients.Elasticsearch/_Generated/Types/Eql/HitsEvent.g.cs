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

namespace Elastic.Clients.Elasticsearch.Eql;

internal sealed partial class HitsEventConverter<TEvent> : System.Text.Json.Serialization.JsonConverter<HitsEvent<TEvent>>
{
	private static readonly System.Text.Json.JsonEncodedText PropFields = System.Text.Json.JsonEncodedText.Encode("fields");
	private static readonly System.Text.Json.JsonEncodedText PropId = System.Text.Json.JsonEncodedText.Encode("_id");
	private static readonly System.Text.Json.JsonEncodedText PropIndex = System.Text.Json.JsonEncodedText.Encode("_index");
	private static readonly System.Text.Json.JsonEncodedText PropMissing = System.Text.Json.JsonEncodedText.Encode("missing");
	private static readonly System.Text.Json.JsonEncodedText PropSource = System.Text.Json.JsonEncodedText.Encode("_source");

	public override HitsEvent<TEvent> Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<IReadOnlyDictionary<Elastic.Clients.Elasticsearch.Field, IReadOnlyCollection<object>>?> propFields = default;
		LocalJsonValue<string> propId = default;
		LocalJsonValue<string> propIndex = default;
		LocalJsonValue<bool?> propMissing = default;
		LocalJsonValue<TEvent> propSource = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propFields.TryReadProperty(ref reader, options, PropFields, static IReadOnlyDictionary<Elastic.Clients.Elasticsearch.Field, IReadOnlyCollection<object>>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadDictionaryValue<Elastic.Clients.Elasticsearch.Field, IReadOnlyCollection<object>>(o, null, static IReadOnlyCollection<object> (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadCollectionValue<object>(o, null)!)))
			{
				continue;
			}

			if (propId.TryReadProperty(ref reader, options, PropId, null))
			{
				continue;
			}

			if (propIndex.TryReadProperty(ref reader, options, PropIndex, null))
			{
				continue;
			}

			if (propMissing.TryReadProperty(ref reader, options, PropMissing, null))
			{
				continue;
			}

			if (propSource.TryReadProperty(ref reader, options, PropSource, static TEvent (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadValueEx<TEvent>(o, typeof(SourceMarker<TEvent>))!))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new HitsEvent<TEvent>
		{
			Fields = propFields.Value
,
			Id = propId.Value
,
			Index = propIndex.Value
,
			Missing = propMissing.Value
,
			Source = propSource.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, HitsEvent<TEvent> value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropFields, value.Fields, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, IReadOnlyDictionary<Elastic.Clients.Elasticsearch.Field, IReadOnlyCollection<object>>? v) => w.WriteDictionaryValue<Elastic.Clients.Elasticsearch.Field, IReadOnlyCollection<object>>(o, v, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, IReadOnlyCollection<object> v) => w.WriteCollectionValue<object>(o, v, null)));
		writer.WriteProperty(options, PropId, value.Id, null, null);
		writer.WriteProperty(options, PropIndex, value.Index, null, null);
		writer.WriteProperty(options, PropMissing, value.Missing, null, null);
		writer.WriteProperty(options, PropSource, value.Source, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, TEvent v) => w.WriteValueEx<TEvent>(o, v, typeof(SourceMarker<TEvent>)));
		writer.WriteEndObject();
	}
}

internal sealed partial class HitsEventConverterFactory : System.Text.Json.Serialization.JsonConverterFactory
{
	public override bool CanConvert(System.Type typeToConvert)
	{
		return typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(HitsEvent<>);
	}

	public override System.Text.Json.Serialization.JsonConverter CreateConverter(System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		var args = typeToConvert.GetGenericArguments();
#pragma warning disable IL3050
		var converter = (System.Text.Json.Serialization.JsonConverter)System.Activator.CreateInstance(typeof(HitsEventConverter<>).MakeGenericType(args[0]), System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public, binder: null, args: null, culture: null)!;
#pragma warning restore IL3050
		return converter;
	}
}

[JsonConverter(typeof(HitsEventConverterFactory))]
public sealed partial class HitsEvent<TEvent>
{
	public IReadOnlyDictionary<Elastic.Clients.Elasticsearch.Field, IReadOnlyCollection<object>>? Fields { get; init; }

	/// <summary>
	/// <para>
	/// Unique identifier for the event. This ID is only unique within the index.
	/// </para>
	/// </summary>
	public string Id { get; init; }

	/// <summary>
	/// <para>
	/// Name of the index containing the event.
	/// </para>
	/// </summary>
	public string Index { get; init; }

	/// <summary>
	/// <para>
	/// Set to <c>true</c> for events in a timespan-constrained sequence that do not meet a given condition.
	/// </para>
	/// </summary>
	public bool? Missing { get; init; }

	/// <summary>
	/// <para>
	/// Original JSON body passed for the event at index time.
	/// </para>
	/// </summary>
	public TEvent Source { get; init; }
}