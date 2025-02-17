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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

internal sealed partial class PutCalendarJobResponseConverter : System.Text.Json.Serialization.JsonConverter<PutCalendarJobResponse>
{
	private static readonly System.Text.Json.JsonEncodedText PropCalendarId = System.Text.Json.JsonEncodedText.Encode("calendar_id");
	private static readonly System.Text.Json.JsonEncodedText PropDescription = System.Text.Json.JsonEncodedText.Encode("description");
	private static readonly System.Text.Json.JsonEncodedText PropJobIds = System.Text.Json.JsonEncodedText.Encode("job_ids");

	public override PutCalendarJobResponse Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<string> propCalendarId = default;
		LocalJsonValue<string?> propDescription = default;
		LocalJsonValue<IReadOnlyCollection<string>> propJobIds = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propCalendarId.TryReadProperty(ref reader, options, PropCalendarId, null))
			{
				continue;
			}

			if (propDescription.TryReadProperty(ref reader, options, PropDescription, null))
			{
				continue;
			}

			if (propJobIds.TryReadProperty(ref reader, options, PropJobIds, static IReadOnlyCollection<string> (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadSingleOrManyCollectionValue<string>(o, null)!))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new PutCalendarJobResponse
		{
			CalendarId = propCalendarId.Value
,
			Description = propDescription.Value
,
			JobIds = propJobIds.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, PutCalendarJobResponse value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropCalendarId, value.CalendarId, null, null);
		writer.WriteProperty(options, PropDescription, value.Description, null, null);
		writer.WriteProperty(options, PropJobIds, value.JobIds, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, IReadOnlyCollection<string> v) => w.WriteSingleOrManyCollectionValue<string>(o, v, null));
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(PutCalendarJobResponseConverter))]
public sealed partial class PutCalendarJobResponse : ElasticsearchResponse
{
	/// <summary>
	/// <para>
	/// A string that uniquely identifies a calendar.
	/// </para>
	/// </summary>
	public string CalendarId { get; init; }

	/// <summary>
	/// <para>
	/// A description of the calendar.
	/// </para>
	/// </summary>
	public string? Description { get; init; }

	/// <summary>
	/// <para>
	/// A list of anomaly detection job identifiers or group names.
	/// </para>
	/// </summary>
	public IReadOnlyCollection<string> JobIds { get; init; }
}