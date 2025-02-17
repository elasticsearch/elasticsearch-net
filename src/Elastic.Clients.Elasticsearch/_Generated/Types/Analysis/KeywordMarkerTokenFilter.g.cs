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

internal sealed partial class KeywordMarkerTokenFilterConverter : System.Text.Json.Serialization.JsonConverter<KeywordMarkerTokenFilter>
{
	private static readonly System.Text.Json.JsonEncodedText PropIgnoreCase = System.Text.Json.JsonEncodedText.Encode("ignore_case");
	private static readonly System.Text.Json.JsonEncodedText PropKeywords = System.Text.Json.JsonEncodedText.Encode("keywords");
	private static readonly System.Text.Json.JsonEncodedText PropKeywordsPath = System.Text.Json.JsonEncodedText.Encode("keywords_path");
	private static readonly System.Text.Json.JsonEncodedText PropKeywordsPattern = System.Text.Json.JsonEncodedText.Encode("keywords_pattern");
	private static readonly System.Text.Json.JsonEncodedText PropType = System.Text.Json.JsonEncodedText.Encode("type");
	private static readonly System.Text.Json.JsonEncodedText PropVersion = System.Text.Json.JsonEncodedText.Encode("version");

	public override KeywordMarkerTokenFilter Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<bool?> propIgnoreCase = default;
		LocalJsonValue<ICollection<string>?> propKeywords = default;
		LocalJsonValue<string?> propKeywordsPath = default;
		LocalJsonValue<string?> propKeywordsPattern = default;
		LocalJsonValue<string?> propVersion = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propIgnoreCase.TryReadProperty(ref reader, options, PropIgnoreCase, null))
			{
				continue;
			}

			if (propKeywords.TryReadProperty(ref reader, options, PropKeywords, static ICollection<string>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadSingleOrManyCollectionValue<string>(o, null)))
			{
				continue;
			}

			if (propKeywordsPath.TryReadProperty(ref reader, options, PropKeywordsPath, null))
			{
				continue;
			}

			if (propKeywordsPattern.TryReadProperty(ref reader, options, PropKeywordsPattern, null))
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
		return new KeywordMarkerTokenFilter
		{
			IgnoreCase = propIgnoreCase.Value
,
			Keywords = propKeywords.Value
,
			KeywordsPath = propKeywordsPath.Value
,
			KeywordsPattern = propKeywordsPattern.Value
,
			Version = propVersion.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, KeywordMarkerTokenFilter value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropIgnoreCase, value.IgnoreCase, null, null);
		writer.WriteProperty(options, PropKeywords, value.Keywords, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<string>? v) => w.WriteSingleOrManyCollectionValue<string>(o, v, null));
		writer.WriteProperty(options, PropKeywordsPath, value.KeywordsPath, null, null);
		writer.WriteProperty(options, PropKeywordsPattern, value.KeywordsPattern, null, null);
		writer.WriteProperty(options, PropType, value.Type, null, null);
		writer.WriteProperty(options, PropVersion, value.Version, null, null);
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(KeywordMarkerTokenFilterConverter))]
public sealed partial class KeywordMarkerTokenFilter : ITokenFilter
{
	public bool? IgnoreCase { get; set; }
	public ICollection<string>? Keywords { get; set; }
	public string? KeywordsPath { get; set; }
	public string? KeywordsPattern { get; set; }

	public string Type => "keyword_marker";

	public string? Version { get; set; }
}

public sealed partial class KeywordMarkerTokenFilterDescriptor : SerializableDescriptor<KeywordMarkerTokenFilterDescriptor>, IBuildableDescriptor<KeywordMarkerTokenFilter>
{
	internal KeywordMarkerTokenFilterDescriptor(Action<KeywordMarkerTokenFilterDescriptor> configure) => configure.Invoke(this);

	public KeywordMarkerTokenFilterDescriptor() : base()
	{
	}

	private bool? IgnoreCaseValue { get; set; }
	private ICollection<string>? KeywordsValue { get; set; }
	private string? KeywordsPathValue { get; set; }
	private string? KeywordsPatternValue { get; set; }
	private string? VersionValue { get; set; }

	public KeywordMarkerTokenFilterDescriptor IgnoreCase(bool? ignoreCase = true)
	{
		IgnoreCaseValue = ignoreCase;
		return Self;
	}

	public KeywordMarkerTokenFilterDescriptor Keywords(ICollection<string>? keywords)
	{
		KeywordsValue = keywords;
		return Self;
	}

	public KeywordMarkerTokenFilterDescriptor KeywordsPath(string? keywordsPath)
	{
		KeywordsPathValue = keywordsPath;
		return Self;
	}

	public KeywordMarkerTokenFilterDescriptor KeywordsPattern(string? keywordsPattern)
	{
		KeywordsPatternValue = keywordsPattern;
		return Self;
	}

	public KeywordMarkerTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IgnoreCaseValue.HasValue)
		{
			writer.WritePropertyName("ignore_case");
			writer.WriteBooleanValue(IgnoreCaseValue.Value);
		}

		if (KeywordsValue is not null)
		{
			writer.WritePropertyName("keywords");
			SingleOrManySerializationHelper.Serialize<string>(KeywordsValue, writer, options);
		}

		if (!string.IsNullOrEmpty(KeywordsPathValue))
		{
			writer.WritePropertyName("keywords_path");
			writer.WriteStringValue(KeywordsPathValue);
		}

		if (!string.IsNullOrEmpty(KeywordsPatternValue))
		{
			writer.WritePropertyName("keywords_pattern");
			writer.WriteStringValue(KeywordsPatternValue);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("keyword_marker");
		if (!string.IsNullOrEmpty(VersionValue))
		{
			writer.WritePropertyName("version");
			writer.WriteStringValue(VersionValue);
		}

		writer.WriteEndObject();
	}

	KeywordMarkerTokenFilter IBuildableDescriptor<KeywordMarkerTokenFilter>.Build() => new()
	{
		IgnoreCase = IgnoreCaseValue,
		Keywords = KeywordsValue,
		KeywordsPath = KeywordsPathValue,
		KeywordsPattern = KeywordsPatternValue,
		Version = VersionValue
	};
}