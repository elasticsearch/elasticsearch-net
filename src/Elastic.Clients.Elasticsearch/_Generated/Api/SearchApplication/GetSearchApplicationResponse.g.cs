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

namespace Elastic.Clients.Elasticsearch.SearchApplication;

internal sealed partial class GetSearchApplicationResponseConverter : System.Text.Json.Serialization.JsonConverter<GetSearchApplicationResponse>
{
	private static readonly System.Text.Json.JsonEncodedText PropAnalyticsCollectionName = System.Text.Json.JsonEncodedText.Encode("analytics_collection_name");
	private static readonly System.Text.Json.JsonEncodedText PropIndices = System.Text.Json.JsonEncodedText.Encode("indices");
	private static readonly System.Text.Json.JsonEncodedText PropName = System.Text.Json.JsonEncodedText.Encode("name");
	private static readonly System.Text.Json.JsonEncodedText PropTemplate = System.Text.Json.JsonEncodedText.Encode("template");
	private static readonly System.Text.Json.JsonEncodedText PropUpdatedAtMillis = System.Text.Json.JsonEncodedText.Encode("updated_at_millis");

	public override GetSearchApplicationResponse Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<string?> propAnalyticsCollectionName = default;
		LocalJsonValue<IReadOnlyCollection<string>> propIndices = default;
		LocalJsonValue<string> propName = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.SearchApplication.SearchApplicationTemplate?> propTemplate = default;
		LocalJsonValue<long> propUpdatedAtMillis = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propAnalyticsCollectionName.TryReadProperty(ref reader, options, PropAnalyticsCollectionName, null))
			{
				continue;
			}

			if (propIndices.TryReadProperty(ref reader, options, PropIndices, static IReadOnlyCollection<string> (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadCollectionValue<string>(o, null)!))
			{
				continue;
			}

			if (propName.TryReadProperty(ref reader, options, PropName, null))
			{
				continue;
			}

			if (propTemplate.TryReadProperty(ref reader, options, PropTemplate, null))
			{
				continue;
			}

			if (propUpdatedAtMillis.TryReadProperty(ref reader, options, PropUpdatedAtMillis, null))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new GetSearchApplicationResponse
		{
			AnalyticsCollectionName = propAnalyticsCollectionName.Value
,
			Indices = propIndices.Value
,
			Name = propName.Value
,
			Template = propTemplate.Value
,
			UpdatedAtMillis = propUpdatedAtMillis.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, GetSearchApplicationResponse value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropAnalyticsCollectionName, value.AnalyticsCollectionName, null, null);
		writer.WriteProperty(options, PropIndices, value.Indices, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, IReadOnlyCollection<string> v) => w.WriteCollectionValue<string>(o, v, null));
		writer.WriteProperty(options, PropName, value.Name, null, null);
		writer.WriteProperty(options, PropTemplate, value.Template, null, null);
		writer.WriteProperty(options, PropUpdatedAtMillis, value.UpdatedAtMillis, null, null);
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(GetSearchApplicationResponseConverter))]
public sealed partial class GetSearchApplicationResponse : ElasticsearchResponse
{
	/// <summary>
	/// <para>
	/// Analytics collection associated to the Search Application.
	/// </para>
	/// </summary>
	public string? AnalyticsCollectionName { get; init; }

	/// <summary>
	/// <para>
	/// Indices that are part of the Search Application.
	/// </para>
	/// </summary>
	public IReadOnlyCollection<string> Indices { get; init; }

	/// <summary>
	/// <para>
	/// Search Application name
	/// </para>
	/// </summary>
	public string Name { get; init; }

	/// <summary>
	/// <para>
	/// Search template to use on search operations.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.SearchApplication.SearchApplicationTemplate? Template { get; init; }

	/// <summary>
	/// <para>
	/// Last time the Search Application was updated.
	/// </para>
	/// </summary>
	public long UpdatedAtMillis { get; init; }
}