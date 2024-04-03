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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class DataDescription
{
	[JsonInclude, JsonPropertyName("field_delimiter")]
	public string? FieldDelimiter { get; set; }

	/// <summary>
	/// <para>Only JSON format is supported at this time.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("format")]
	public string? Format { get; set; }

	/// <summary>
	/// <para>The name of the field that contains the timestamp.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("time_field")]
	public Elastic.Clients.Elasticsearch.Field? TimeField { get; set; }

	/// <summary>
	/// <para>The time format, which can be `epoch`, `epoch_ms`, or a custom pattern. The value `epoch` refers to UNIX or Epoch time (the number of seconds since 1 Jan 1970). The value `epoch_ms` indicates that time is measured in milliseconds since the epoch. The `epoch` and `epoch_ms` time formats accept either integer or real values. Custom patterns must conform to the Java DateTimeFormatter class. When you use date-time formatting patterns, it is recommended that you provide the full date, time and time zone. For example: `yyyy-MM-dd'T'HH:mm:ssX`. If the pattern that you specify is not sufficient to produce a complete timestamp, job creation fails.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("time_format")]
	public string? TimeFormat { get; set; }
}

public sealed partial class DataDescriptionDescriptor<TDocument> : SerializableDescriptor<DataDescriptionDescriptor<TDocument>>
{
	internal DataDescriptionDescriptor(Action<DataDescriptionDescriptor<TDocument>> configure) => configure.Invoke(this);

	public DataDescriptionDescriptor() : base()
	{
	}

	private string? FieldDelimiterValue { get; set; }
	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? TimeFieldValue { get; set; }
	private string? TimeFormatValue { get; set; }

	public DataDescriptionDescriptor<TDocument> FieldDelimiter(string? fieldDelimiter)
	{
		FieldDelimiterValue = fieldDelimiter;
		return Self;
	}

	/// <summary>
	/// <para>Only JSON format is supported at this time.</para>
	/// </summary>
	public DataDescriptionDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field that contains the timestamp.</para>
	/// </summary>
	public DataDescriptionDescriptor<TDocument> TimeField(Elastic.Clients.Elasticsearch.Field? timeField)
	{
		TimeFieldValue = timeField;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field that contains the timestamp.</para>
	/// </summary>
	public DataDescriptionDescriptor<TDocument> TimeField<TValue>(Expression<Func<TDocument, TValue>> timeField)
	{
		TimeFieldValue = timeField;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field that contains the timestamp.</para>
	/// </summary>
	public DataDescriptionDescriptor<TDocument> TimeField(Expression<Func<TDocument, object>> timeField)
	{
		TimeFieldValue = timeField;
		return Self;
	}

	/// <summary>
	/// <para>The time format, which can be `epoch`, `epoch_ms`, or a custom pattern. The value `epoch` refers to UNIX or Epoch time (the number of seconds since 1 Jan 1970). The value `epoch_ms` indicates that time is measured in milliseconds since the epoch. The `epoch` and `epoch_ms` time formats accept either integer or real values. Custom patterns must conform to the Java DateTimeFormatter class. When you use date-time formatting patterns, it is recommended that you provide the full date, time and time zone. For example: `yyyy-MM-dd'T'HH:mm:ssX`. If the pattern that you specify is not sufficient to produce a complete timestamp, job creation fails.</para>
	/// </summary>
	public DataDescriptionDescriptor<TDocument> TimeFormat(string? timeFormat)
	{
		TimeFormatValue = timeFormat;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(FieldDelimiterValue))
		{
			writer.WritePropertyName("field_delimiter");
			writer.WriteStringValue(FieldDelimiterValue);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (TimeFieldValue is not null)
		{
			writer.WritePropertyName("time_field");
			JsonSerializer.Serialize(writer, TimeFieldValue, options);
		}

		if (!string.IsNullOrEmpty(TimeFormatValue))
		{
			writer.WritePropertyName("time_format");
			writer.WriteStringValue(TimeFormatValue);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class DataDescriptionDescriptor : SerializableDescriptor<DataDescriptionDescriptor>
{
	internal DataDescriptionDescriptor(Action<DataDescriptionDescriptor> configure) => configure.Invoke(this);

	public DataDescriptionDescriptor() : base()
	{
	}

	private string? FieldDelimiterValue { get; set; }
	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? TimeFieldValue { get; set; }
	private string? TimeFormatValue { get; set; }

	public DataDescriptionDescriptor FieldDelimiter(string? fieldDelimiter)
	{
		FieldDelimiterValue = fieldDelimiter;
		return Self;
	}

	/// <summary>
	/// <para>Only JSON format is supported at this time.</para>
	/// </summary>
	public DataDescriptionDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field that contains the timestamp.</para>
	/// </summary>
	public DataDescriptionDescriptor TimeField(Elastic.Clients.Elasticsearch.Field? timeField)
	{
		TimeFieldValue = timeField;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field that contains the timestamp.</para>
	/// </summary>
	public DataDescriptionDescriptor TimeField<TDocument, TValue>(Expression<Func<TDocument, TValue>> timeField)
	{
		TimeFieldValue = timeField;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field that contains the timestamp.</para>
	/// </summary>
	public DataDescriptionDescriptor TimeField<TDocument>(Expression<Func<TDocument, object>> timeField)
	{
		TimeFieldValue = timeField;
		return Self;
	}

	/// <summary>
	/// <para>The time format, which can be `epoch`, `epoch_ms`, or a custom pattern. The value `epoch` refers to UNIX or Epoch time (the number of seconds since 1 Jan 1970). The value `epoch_ms` indicates that time is measured in milliseconds since the epoch. The `epoch` and `epoch_ms` time formats accept either integer or real values. Custom patterns must conform to the Java DateTimeFormatter class. When you use date-time formatting patterns, it is recommended that you provide the full date, time and time zone. For example: `yyyy-MM-dd'T'HH:mm:ssX`. If the pattern that you specify is not sufficient to produce a complete timestamp, job creation fails.</para>
	/// </summary>
	public DataDescriptionDescriptor TimeFormat(string? timeFormat)
	{
		TimeFormatValue = timeFormat;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(FieldDelimiterValue))
		{
			writer.WritePropertyName("field_delimiter");
			writer.WriteStringValue(FieldDelimiterValue);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (TimeFieldValue is not null)
		{
			writer.WritePropertyName("time_field");
			JsonSerializer.Serialize(writer, TimeFieldValue, options);
		}

		if (!string.IsNullOrEmpty(TimeFormatValue))
		{
			writer.WritePropertyName("time_format");
			writer.WriteStringValue(TimeFormatValue);
		}

		writer.WriteEndObject();
	}
}