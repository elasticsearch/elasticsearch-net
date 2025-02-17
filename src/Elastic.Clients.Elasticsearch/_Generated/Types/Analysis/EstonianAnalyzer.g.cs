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

internal sealed partial class EstonianAnalyzerConverter : System.Text.Json.Serialization.JsonConverter<EstonianAnalyzer>
{
	private static readonly System.Text.Json.JsonEncodedText PropStopwords = System.Text.Json.JsonEncodedText.Encode("stopwords");
	private static readonly System.Text.Json.JsonEncodedText PropStopwordsPath = System.Text.Json.JsonEncodedText.Encode("stopwords_path");
	private static readonly System.Text.Json.JsonEncodedText PropType = System.Text.Json.JsonEncodedText.Encode("type");

	public override EstonianAnalyzer Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<ICollection<string>?> propStopwords = default;
		LocalJsonValue<string?> propStopwordsPath = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propStopwords.TryReadProperty(ref reader, options, PropStopwords, static ICollection<string>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadSingleOrManyCollectionValue<string>(o, null)))
			{
				continue;
			}

			if (propStopwordsPath.TryReadProperty(ref reader, options, PropStopwordsPath, null))
			{
				continue;
			}

			if (reader.ValueTextEquals(PropType))
			{
				reader.Skip();
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new EstonianAnalyzer
		{
			Stopwords = propStopwords.Value
,
			StopwordsPath = propStopwordsPath.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, EstonianAnalyzer value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropStopwords, value.Stopwords, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<string>? v) => w.WriteSingleOrManyCollectionValue<string>(o, v, null));
		writer.WriteProperty(options, PropStopwordsPath, value.StopwordsPath, null, null);
		writer.WriteProperty(options, PropType, value.Type, null, null);
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(EstonianAnalyzerConverter))]
public sealed partial class EstonianAnalyzer : IAnalyzer
{
	public ICollection<string>? Stopwords { get; set; }
	public string? StopwordsPath { get; set; }

	public string Type => "estonian";
}

public sealed partial class EstonianAnalyzerDescriptor : SerializableDescriptor<EstonianAnalyzerDescriptor>, IBuildableDescriptor<EstonianAnalyzer>
{
	internal EstonianAnalyzerDescriptor(Action<EstonianAnalyzerDescriptor> configure) => configure.Invoke(this);

	public EstonianAnalyzerDescriptor() : base()
	{
	}

	private ICollection<string>? StopwordsValue { get; set; }
	private string? StopwordsPathValue { get; set; }

	public EstonianAnalyzerDescriptor Stopwords(ICollection<string>? stopwords)
	{
		StopwordsValue = stopwords;
		return Self;
	}

	public EstonianAnalyzerDescriptor StopwordsPath(string? stopwordsPath)
	{
		StopwordsPathValue = stopwordsPath;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (StopwordsValue is not null)
		{
			writer.WritePropertyName("stopwords");
			SingleOrManySerializationHelper.Serialize<string>(StopwordsValue, writer, options);
		}

		if (!string.IsNullOrEmpty(StopwordsPathValue))
		{
			writer.WritePropertyName("stopwords_path");
			writer.WriteStringValue(StopwordsPathValue);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("estonian");
		writer.WriteEndObject();
	}

	EstonianAnalyzer IBuildableDescriptor<EstonianAnalyzer>.Build() => new()
	{
		Stopwords = StopwordsValue,
		StopwordsPath = StopwordsPathValue
	};
}