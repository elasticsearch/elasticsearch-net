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

internal sealed partial class PatternAnalyzerConverter : System.Text.Json.Serialization.JsonConverter<PatternAnalyzer>
{
	private static readonly System.Text.Json.JsonEncodedText PropFlags = System.Text.Json.JsonEncodedText.Encode("flags");
	private static readonly System.Text.Json.JsonEncodedText PropLowercase = System.Text.Json.JsonEncodedText.Encode("lowercase");
	private static readonly System.Text.Json.JsonEncodedText PropPattern = System.Text.Json.JsonEncodedText.Encode("pattern");
	private static readonly System.Text.Json.JsonEncodedText PropStopwords = System.Text.Json.JsonEncodedText.Encode("stopwords");
	private static readonly System.Text.Json.JsonEncodedText PropType = System.Text.Json.JsonEncodedText.Encode("type");
	private static readonly System.Text.Json.JsonEncodedText PropVersion = System.Text.Json.JsonEncodedText.Encode("version");

	public override PatternAnalyzer Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<string?> propFlags = default;
		LocalJsonValue<bool?> propLowercase = default;
		LocalJsonValue<string> propPattern = default;
		LocalJsonValue<ICollection<string>?> propStopwords = default;
		LocalJsonValue<string?> propVersion = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propFlags.TryReadProperty(ref reader, options, PropFlags, null))
			{
				continue;
			}

			if (propLowercase.TryReadProperty(ref reader, options, PropLowercase, null))
			{
				continue;
			}

			if (propPattern.TryReadProperty(ref reader, options, PropPattern, null))
			{
				continue;
			}

			if (propStopwords.TryReadProperty(ref reader, options, PropStopwords, static ICollection<string>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadSingleOrManyCollectionValue<string>(o, null)))
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
		return new PatternAnalyzer
		{
			Flags = propFlags.Value
,
			Lowercase = propLowercase.Value
,
			Pattern = propPattern.Value
,
			Stopwords = propStopwords.Value
,
			Version = propVersion.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, PatternAnalyzer value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropFlags, value.Flags, null, null);
		writer.WriteProperty(options, PropLowercase, value.Lowercase, null, null);
		writer.WriteProperty(options, PropPattern, value.Pattern, null, null);
		writer.WriteProperty(options, PropStopwords, value.Stopwords, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<string>? v) => w.WriteSingleOrManyCollectionValue<string>(o, v, null));
		writer.WriteProperty(options, PropType, value.Type, null, null);
		writer.WriteProperty(options, PropVersion, value.Version, null, null);
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(PatternAnalyzerConverter))]
public sealed partial class PatternAnalyzer : IAnalyzer
{
	public string? Flags { get; set; }
	public bool? Lowercase { get; set; }
	public string Pattern { get; set; }
	public ICollection<string>? Stopwords { get; set; }

	public string Type => "pattern";

	public string? Version { get; set; }
}

public sealed partial class PatternAnalyzerDescriptor : SerializableDescriptor<PatternAnalyzerDescriptor>, IBuildableDescriptor<PatternAnalyzer>
{
	internal PatternAnalyzerDescriptor(Action<PatternAnalyzerDescriptor> configure) => configure.Invoke(this);

	public PatternAnalyzerDescriptor() : base()
	{
	}

	private string? FlagsValue { get; set; }
	private bool? LowercaseValue { get; set; }
	private string PatternValue { get; set; }
	private ICollection<string>? StopwordsValue { get; set; }
	private string? VersionValue { get; set; }

	public PatternAnalyzerDescriptor Flags(string? flags)
	{
		FlagsValue = flags;
		return Self;
	}

	public PatternAnalyzerDescriptor Lowercase(bool? lowercase = true)
	{
		LowercaseValue = lowercase;
		return Self;
	}

	public PatternAnalyzerDescriptor Pattern(string pattern)
	{
		PatternValue = pattern;
		return Self;
	}

	public PatternAnalyzerDescriptor Stopwords(ICollection<string>? stopwords)
	{
		StopwordsValue = stopwords;
		return Self;
	}

	public PatternAnalyzerDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(FlagsValue))
		{
			writer.WritePropertyName("flags");
			writer.WriteStringValue(FlagsValue);
		}

		if (LowercaseValue.HasValue)
		{
			writer.WritePropertyName("lowercase");
			writer.WriteBooleanValue(LowercaseValue.Value);
		}

		writer.WritePropertyName("pattern");
		writer.WriteStringValue(PatternValue);
		if (StopwordsValue is not null)
		{
			writer.WritePropertyName("stopwords");
			SingleOrManySerializationHelper.Serialize<string>(StopwordsValue, writer, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("pattern");
		if (!string.IsNullOrEmpty(VersionValue))
		{
			writer.WritePropertyName("version");
			writer.WriteStringValue(VersionValue);
		}

		writer.WriteEndObject();
	}

	PatternAnalyzer IBuildableDescriptor<PatternAnalyzer>.Build() => new()
	{
		Flags = FlagsValue,
		Lowercase = LowercaseValue,
		Pattern = PatternValue,
		Stopwords = StopwordsValue,
		Version = VersionValue
	};
}