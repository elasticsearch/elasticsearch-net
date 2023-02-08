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
namespace Elastic.Clients.Elasticsearch.Analysis;
public sealed partial class HunspellTokenFilter : ITokenFilter
{
	[JsonInclude, JsonPropertyName("dedup")]
	public bool? Dedup { get; set; }

	[JsonInclude, JsonPropertyName("dictionary")]
	public string? Dictionary { get; set; }

	[JsonInclude, JsonPropertyName("locale")]
	public string Locale { get; set; }

	[JsonInclude, JsonPropertyName("longest_only")]
	public bool? LongestOnly { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "hunspell";
	[JsonInclude, JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class HunspellTokenFilterDescriptor : SerializableDescriptor<HunspellTokenFilterDescriptor>, IBuildableDescriptor<HunspellTokenFilter>
{
	internal HunspellTokenFilterDescriptor(Action<HunspellTokenFilterDescriptor> configure) => configure.Invoke(this);
	public HunspellTokenFilterDescriptor() : base()
	{
	}

	private bool? DedupValue { get; set; }

	private string? DictionaryValue { get; set; }

	private string LocaleValue { get; set; }

	private bool? LongestOnlyValue { get; set; }

	private string? VersionValue { get; set; }

	public HunspellTokenFilterDescriptor Dedup(bool? dedup = true)
	{
		DedupValue = dedup;
		return Self;
	}

	public HunspellTokenFilterDescriptor Dictionary(string? dictionary)
	{
		DictionaryValue = dictionary;
		return Self;
	}

	public HunspellTokenFilterDescriptor Locale(string locale)
	{
		LocaleValue = locale;
		return Self;
	}

	public HunspellTokenFilterDescriptor LongestOnly(bool? longestOnly = true)
	{
		LongestOnlyValue = longestOnly;
		return Self;
	}

	public HunspellTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DedupValue.HasValue)
		{
			writer.WritePropertyName("dedup");
			writer.WriteBooleanValue(DedupValue.Value);
		}

		if (!string.IsNullOrEmpty(DictionaryValue))
		{
			writer.WritePropertyName("dictionary");
			writer.WriteStringValue(DictionaryValue);
		}

		writer.WritePropertyName("locale");
		writer.WriteStringValue(LocaleValue);
		if (LongestOnlyValue.HasValue)
		{
			writer.WritePropertyName("longest_only");
			writer.WriteBooleanValue(LongestOnlyValue.Value);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("hunspell");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	HunspellTokenFilter IBuildableDescriptor<HunspellTokenFilter>.Build() => new()
	{ Dedup = DedupValue, Dictionary = DictionaryValue, Locale = LocaleValue, LongestOnly = LongestOnlyValue, Version = VersionValue };
}