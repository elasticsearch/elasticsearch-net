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

using Elastic.Clients.Elasticsearch.Core;
using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Analysis;

public partial class CharFilters : IsADictionary<string, ICharFilter>
{
	public CharFilters()
	{
	}

	public CharFilters(IDictionary<string, ICharFilter> container) : base(container)
	{
	}

	public void Add(string name, ICharFilter charFilter) => BackingDictionary.Add(Sanitize(name), charFilter);
	public bool TryGetCharFilter(string name, [NotNullWhen(returnValue: true)] out ICharFilter charFilter) => BackingDictionary.TryGetValue(Sanitize(name), out charFilter);

	public bool TryGetCharFilter<T>(string name, [NotNullWhen(returnValue: true)] out T? charFilter) where T : class, ICharFilter
	{
		if (BackingDictionary.TryGetValue(Sanitize(name), out var matchedValue) && matchedValue is T finalValue)
		{
			charFilter = finalValue;
			return true;
		}

		charFilter = null;
		return false;
	}
}

public sealed partial class CharFiltersDescriptor : IsADictionaryDescriptor<CharFiltersDescriptor, CharFilters, string, ICharFilter>
{
	public CharFiltersDescriptor() : base(new CharFilters())
	{
	}

	public CharFiltersDescriptor(CharFilters charFilters) : base(charFilters ?? new CharFilters())
	{
	}

	public CharFiltersDescriptor HtmlStrip(string charFilterName) => AssignVariant<Elastic.Clients.Elasticsearch.Analysis.HtmlStripCharFilterDescriptor, HtmlStripCharFilter>(charFilterName, null);
	public CharFiltersDescriptor HtmlStrip(string charFilterName, Action<Elastic.Clients.Elasticsearch.Analysis.HtmlStripCharFilterDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Analysis.HtmlStripCharFilterDescriptor, HtmlStripCharFilter>(charFilterName, configure);
	public CharFiltersDescriptor HtmlStrip(string charFilterName, HtmlStripCharFilter htmlStripCharFilter) => AssignVariant(charFilterName, htmlStripCharFilter);
	public CharFiltersDescriptor IcuNormalization(string charFilterName) => AssignVariant<Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationCharFilterDescriptor, IcuNormalizationCharFilter>(charFilterName, null);
	public CharFiltersDescriptor IcuNormalization(string charFilterName, Action<Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationCharFilterDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationCharFilterDescriptor, IcuNormalizationCharFilter>(charFilterName, configure);
	public CharFiltersDescriptor IcuNormalization(string charFilterName, IcuNormalizationCharFilter icuNormalizationCharFilter) => AssignVariant(charFilterName, icuNormalizationCharFilter);
	public CharFiltersDescriptor KuromojiIterationMark(string charFilterName) => AssignVariant<Elastic.Clients.Elasticsearch.Analysis.KuromojiIterationMarkCharFilterDescriptor, KuromojiIterationMarkCharFilter>(charFilterName, null);
	public CharFiltersDescriptor KuromojiIterationMark(string charFilterName, Action<Elastic.Clients.Elasticsearch.Analysis.KuromojiIterationMarkCharFilterDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Analysis.KuromojiIterationMarkCharFilterDescriptor, KuromojiIterationMarkCharFilter>(charFilterName, configure);
	public CharFiltersDescriptor KuromojiIterationMark(string charFilterName, KuromojiIterationMarkCharFilter kuromojiIterationMarkCharFilter) => AssignVariant(charFilterName, kuromojiIterationMarkCharFilter);
	public CharFiltersDescriptor Mapping(string charFilterName) => AssignVariant<Elastic.Clients.Elasticsearch.Analysis.MappingCharFilterDescriptor, MappingCharFilter>(charFilterName, null);
	public CharFiltersDescriptor Mapping(string charFilterName, Action<Elastic.Clients.Elasticsearch.Analysis.MappingCharFilterDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Analysis.MappingCharFilterDescriptor, MappingCharFilter>(charFilterName, configure);
	public CharFiltersDescriptor Mapping(string charFilterName, MappingCharFilter mappingCharFilter) => AssignVariant(charFilterName, mappingCharFilter);
	public CharFiltersDescriptor PatternReplace(string charFilterName) => AssignVariant<Elastic.Clients.Elasticsearch.Analysis.PatternReplaceCharFilterDescriptor, PatternReplaceCharFilter>(charFilterName, null);
	public CharFiltersDescriptor PatternReplace(string charFilterName, Action<Elastic.Clients.Elasticsearch.Analysis.PatternReplaceCharFilterDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Analysis.PatternReplaceCharFilterDescriptor, PatternReplaceCharFilter>(charFilterName, configure);
	public CharFiltersDescriptor PatternReplace(string charFilterName, PatternReplaceCharFilter patternReplaceCharFilter) => AssignVariant(charFilterName, patternReplaceCharFilter);
}

internal sealed partial class CharFilterInterfaceConverter : System.Text.Json.Serialization.JsonConverter<ICharFilter>
{
	private static readonly System.Text.Json.JsonEncodedText PropDiscriminator = System.Text.Json.JsonEncodedText.Encode("type");

	public override ICharFilter Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		var readerSnapshot = reader;
		string? discriminator = null;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (reader.TryReadProperty(options, PropDiscriminator, ref discriminator, null))
			{
				break;
			}

			reader.Skip();
		}

		reader = readerSnapshot;
		return discriminator switch
		{
			"html_strip" => reader.ReadValue<Elastic.Clients.Elasticsearch.Analysis.HtmlStripCharFilter>(options, null),
			"icu_normalizer" => reader.ReadValue<Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationCharFilter>(options, null),
			"kuromoji_iteration_mark" => reader.ReadValue<Elastic.Clients.Elasticsearch.Analysis.KuromojiIterationMarkCharFilter>(options, null),
			"mapping" => reader.ReadValue<Elastic.Clients.Elasticsearch.Analysis.MappingCharFilter>(options, null),
			"pattern_replace" => reader.ReadValue<Elastic.Clients.Elasticsearch.Analysis.PatternReplaceCharFilter>(options, null),
			_ => throw new System.Text.Json.JsonException($"Variant '{discriminator}' is not supported for type '{nameof(ICharFilter)}'.")
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, ICharFilter value, System.Text.Json.JsonSerializerOptions options)
	{
		switch (value.Type)
		{
			case "html_strip":
				writer.WriteValue(options, (Elastic.Clients.Elasticsearch.Analysis.HtmlStripCharFilter)value, null);
				break;
			case "icu_normalizer":
				writer.WriteValue(options, (Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationCharFilter)value, null);
				break;
			case "kuromoji_iteration_mark":
				writer.WriteValue(options, (Elastic.Clients.Elasticsearch.Analysis.KuromojiIterationMarkCharFilter)value, null);
				break;
			case "mapping":
				writer.WriteValue(options, (Elastic.Clients.Elasticsearch.Analysis.MappingCharFilter)value, null);
				break;
			case "pattern_replace":
				writer.WriteValue(options, (Elastic.Clients.Elasticsearch.Analysis.PatternReplaceCharFilter)value, null);
				break;
			default:
				throw new System.Text.Json.JsonException($"Variant '{value.Type}' is not supported for type '{nameof(ICharFilter)}'.");
		}
	}
}

[JsonConverter(typeof(CharFilterInterfaceConverter))]
public partial interface ICharFilter
{
	public string? Type { get; }
}