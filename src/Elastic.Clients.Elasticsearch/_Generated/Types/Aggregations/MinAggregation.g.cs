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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations;
internal sealed class MinAggregationConverter : JsonConverter<MinAggregation>
{
	public override MinAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "min")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new MinAggregation(aggName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("field"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
					if (value is not null)
					{
						agg.Field = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("format"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<string?>(ref reader, options);
					if (value is not null)
					{
						agg.Format = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("missing"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<FieldValue?>(ref reader, options);
					if (value is not null)
					{
						agg.Missing = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("script"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
					if (value is not null)
					{
						agg.Script = value;
					}

					continue;
				}
			}
		}

		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("meta"))
				{
					var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
					if (value is not null)
					{
						agg.Meta = value;
					}

					continue;
				}
			}
		}

		return agg;
	}

	public override void Write(Utf8JsonWriter writer, MinAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("min");
		writer.WriteStartObject();
		if (value.Field is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, value.Field, options);
		}

		if (!string.IsNullOrEmpty(value.Format))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(value.Format);
		}

		if (value.Missing is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, value.Missing, options);
		}

		if (value.Script is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, value.Script, options);
		}

		writer.WriteEndObject();
		if (value.Meta is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, value.Meta, options);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(MinAggregationConverter))]
public sealed partial class MinAggregation : SearchAggregation
{
	public MinAggregation(string name, Field field) : this(name) => Field = field;
	public MinAggregation(string name) => Name = name;
	internal MinAggregation()
	{
	}

	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

	public string? Format { get; set; }

	public IDictionary<string, object>? Meta { get; set; }

	public FieldValue? Missing { get; set; }

	public override string? Name { get; internal set; }

	public Elastic.Clients.Elasticsearch.Script? Script { get; set; }
}

public sealed partial class MinAggregationDescriptor<TDocument> : SerializableDescriptor<MinAggregationDescriptor<TDocument>>
{
	internal MinAggregationDescriptor(Action<MinAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
	public MinAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

	private string? FormatValue { get; set; }

	private IDictionary<string, object>? MetaValue { get; set; }

	private FieldValue? MissingValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }

	public MinAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	public MinAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public MinAggregationDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public MinAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public MinAggregationDescriptor<TDocument> Missing(FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public MinAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("min");
		writer.WriteStartObject();
		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class MinAggregationDescriptor : SerializableDescriptor<MinAggregationDescriptor>
{
	internal MinAggregationDescriptor(Action<MinAggregationDescriptor> configure) => configure.Invoke(this);
	public MinAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

	private string? FormatValue { get; set; }

	private IDictionary<string, object>? MetaValue { get; set; }

	private FieldValue? MissingValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }

	public MinAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	public MinAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public MinAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public MinAggregationDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public MinAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public MinAggregationDescriptor Missing(FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public MinAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("min");
		writer.WriteStartObject();
		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}