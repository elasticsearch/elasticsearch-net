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

internal sealed partial class FingerprintAnalyzerConverter : System.Text.Json.Serialization.JsonConverter<FingerprintAnalyzer>
{
	private static readonly System.Text.Json.JsonEncodedText PropMaxOutputSize = System.Text.Json.JsonEncodedText.Encode("max_output_size");
	private static readonly System.Text.Json.JsonEncodedText PropPreserveOriginal = System.Text.Json.JsonEncodedText.Encode("preserve_original");
	private static readonly System.Text.Json.JsonEncodedText PropSeparator = System.Text.Json.JsonEncodedText.Encode("separator");
	private static readonly System.Text.Json.JsonEncodedText PropStopwords = System.Text.Json.JsonEncodedText.Encode("stopwords");
	private static readonly System.Text.Json.JsonEncodedText PropStopwordsPath = System.Text.Json.JsonEncodedText.Encode("stopwords_path");
	private static readonly System.Text.Json.JsonEncodedText PropType = System.Text.Json.JsonEncodedText.Encode("type");
	private static readonly System.Text.Json.JsonEncodedText PropVersion = System.Text.Json.JsonEncodedText.Encode("version");

	public override FingerprintAnalyzer Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<int> propMaxOutputSize = default;
		LocalJsonValue<bool> propPreserveOriginal = default;
		LocalJsonValue<string> propSeparator = default;
		LocalJsonValue<ICollection<string>?> propStopwords = default;
		LocalJsonValue<string?> propStopwordsPath = default;
		LocalJsonValue<string?> propVersion = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propMaxOutputSize.TryReadProperty(ref reader, options, PropMaxOutputSize, null))
			{
				continue;
			}

			if (propPreserveOriginal.TryReadProperty(ref reader, options, PropPreserveOriginal, null))
			{
				continue;
			}

			if (propSeparator.TryReadProperty(ref reader, options, PropSeparator, null))
			{
				continue;
			}

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

			if (propVersion.TryReadProperty(ref reader, options, PropVersion, null))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new FingerprintAnalyzer
		{
			MaxOutputSize = propMaxOutputSize.Value
,
			PreserveOriginal = propPreserveOriginal.Value
,
			Separator = propSeparator.Value
,
			Stopwords = propStopwords.Value
,
			StopwordsPath = propStopwordsPath.Value
,
			Version = propVersion.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, FingerprintAnalyzer value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropMaxOutputSize, value.MaxOutputSize, null, null);
		writer.WriteProperty(options, PropPreserveOriginal, value.PreserveOriginal, null, null);
		writer.WriteProperty(options, PropSeparator, value.Separator, null, null);
		writer.WriteProperty(options, PropStopwords, value.Stopwords, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<string>? v) => w.WriteSingleOrManyCollectionValue<string>(o, v, null));
		writer.WriteProperty(options, PropStopwordsPath, value.StopwordsPath, null, null);
		writer.WriteProperty(options, PropType, value.Type, null, null);
		writer.WriteProperty(options, PropVersion, value.Version, null, null);
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(FingerprintAnalyzerConverter))]
public sealed partial class FingerprintAnalyzer : IAnalyzer
{
	public int MaxOutputSize { get; set; }
	public bool PreserveOriginal { get; set; }
	public string Separator { get; set; }
	public ICollection<string>? Stopwords { get; set; }
	public string? StopwordsPath { get; set; }

	public string Type => "fingerprint";

	public string? Version { get; set; }
}

public sealed partial class FingerprintAnalyzerDescriptor : SerializableDescriptor<FingerprintAnalyzerDescriptor>, IBuildableDescriptor<FingerprintAnalyzer>
{
	internal FingerprintAnalyzerDescriptor(Action<FingerprintAnalyzerDescriptor> configure) => configure.Invoke(this);

	public FingerprintAnalyzerDescriptor() : base()
	{
	}

	private int MaxOutputSizeValue { get; set; }
	private bool PreserveOriginalValue { get; set; }
	private string SeparatorValue { get; set; }
	private ICollection<string>? StopwordsValue { get; set; }
	private string? StopwordsPathValue { get; set; }
	private string? VersionValue { get; set; }

	public FingerprintAnalyzerDescriptor MaxOutputSize(int maxOutputSize)
	{
		MaxOutputSizeValue = maxOutputSize;
		return Self;
	}

	public FingerprintAnalyzerDescriptor PreserveOriginal(bool preserveOriginal = true)
	{
		PreserveOriginalValue = preserveOriginal;
		return Self;
	}

	public FingerprintAnalyzerDescriptor Separator(string separator)
	{
		SeparatorValue = separator;
		return Self;
	}

	public FingerprintAnalyzerDescriptor Stopwords(ICollection<string>? stopwords)
	{
		StopwordsValue = stopwords;
		return Self;
	}

	public FingerprintAnalyzerDescriptor StopwordsPath(string? stopwordsPath)
	{
		StopwordsPathValue = stopwordsPath;
		return Self;
	}

	public FingerprintAnalyzerDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("max_output_size");
		writer.WriteNumberValue(MaxOutputSizeValue);
		writer.WritePropertyName("preserve_original");
		writer.WriteBooleanValue(PreserveOriginalValue);
		writer.WritePropertyName("separator");
		writer.WriteStringValue(SeparatorValue);
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
		writer.WriteStringValue("fingerprint");
		if (!string.IsNullOrEmpty(VersionValue))
		{
			writer.WritePropertyName("version");
			writer.WriteStringValue(VersionValue);
		}

		writer.WriteEndObject();
	}

	FingerprintAnalyzer IBuildableDescriptor<FingerprintAnalyzer>.Build() => new()
	{
		MaxOutputSize = MaxOutputSizeValue,
		PreserveOriginal = PreserveOriginalValue,
		Separator = SeparatorValue,
		Stopwords = StopwordsValue,
		StopwordsPath = StopwordsPathValue,
		Version = VersionValue
	};
}