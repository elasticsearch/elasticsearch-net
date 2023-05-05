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

namespace Elastic.Clients.Elasticsearch.Analysis;

internal sealed partial class StemmerTokenFilterConverter : JsonConverter<StemmerTokenFilter>
{
	public override StemmerTokenFilter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		var variant = new StemmerTokenFilter();
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				var property = reader.GetString();
				if (property == "language" || property == "name")
				{
					variant.Language = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "version")
				{
					variant.Version = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}
			}
		}

		return variant;
	}

	public override void Write(Utf8JsonWriter writer, StemmerTokenFilter value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(value.Language))
		{
			writer.WritePropertyName("language");
			writer.WriteStringValue(value.Language);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("stemmer");
		if (value.Version is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, value.Version, options);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(StemmerTokenFilterConverter))]
public sealed partial class StemmerTokenFilter : ITokenFilter
{
	public string? Language { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "stemmer";

	public string? Version { get; set; }
}

public sealed partial class StemmerTokenFilterDescriptor : SerializableDescriptor<StemmerTokenFilterDescriptor>, IBuildableDescriptor<StemmerTokenFilter>
{
	internal StemmerTokenFilterDescriptor(Action<StemmerTokenFilterDescriptor> configure) => configure.Invoke(this);

	public StemmerTokenFilterDescriptor() : base()
	{
	}

	private string? LanguageValue { get; set; }
	private string? VersionValue { get; set; }

	public StemmerTokenFilterDescriptor Language(string? language)
	{
		LanguageValue = language;
		return Self;
	}

	public StemmerTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(LanguageValue))
		{
			writer.WritePropertyName("language");
			writer.WriteStringValue(LanguageValue);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("stemmer");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	StemmerTokenFilter IBuildableDescriptor<StemmerTokenFilter>.Build() => new()
	{
		Language = LanguageValue,
		Version = VersionValue
	};
}