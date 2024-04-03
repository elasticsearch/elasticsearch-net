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

using Elastic.Clients.Elasticsearch.Serverless.Core;
using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Analysis;

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

	public CharFiltersDescriptor HtmlStrip(string charFilterName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.HtmlStripCharFilterDescriptor, HtmlStripCharFilter>(charFilterName, null);
	public CharFiltersDescriptor HtmlStrip(string charFilterName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.HtmlStripCharFilterDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.HtmlStripCharFilterDescriptor, HtmlStripCharFilter>(charFilterName, configure);
	public CharFiltersDescriptor HtmlStrip(string charFilterName, HtmlStripCharFilter htmlStripCharFilter) => AssignVariant(charFilterName, htmlStripCharFilter);
	public CharFiltersDescriptor IcuNormalization(string charFilterName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.IcuNormalizationCharFilterDescriptor, IcuNormalizationCharFilter>(charFilterName, null);
	public CharFiltersDescriptor IcuNormalization(string charFilterName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.IcuNormalizationCharFilterDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.IcuNormalizationCharFilterDescriptor, IcuNormalizationCharFilter>(charFilterName, configure);
	public CharFiltersDescriptor IcuNormalization(string charFilterName, IcuNormalizationCharFilter icuNormalizationCharFilter) => AssignVariant(charFilterName, icuNormalizationCharFilter);
	public CharFiltersDescriptor KuromojiIterationMark(string charFilterName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.KuromojiIterationMarkCharFilterDescriptor, KuromojiIterationMarkCharFilter>(charFilterName, null);
	public CharFiltersDescriptor KuromojiIterationMark(string charFilterName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.KuromojiIterationMarkCharFilterDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.KuromojiIterationMarkCharFilterDescriptor, KuromojiIterationMarkCharFilter>(charFilterName, configure);
	public CharFiltersDescriptor KuromojiIterationMark(string charFilterName, KuromojiIterationMarkCharFilter kuromojiIterationMarkCharFilter) => AssignVariant(charFilterName, kuromojiIterationMarkCharFilter);
	public CharFiltersDescriptor Mapping(string charFilterName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.MappingCharFilterDescriptor, MappingCharFilter>(charFilterName, null);
	public CharFiltersDescriptor Mapping(string charFilterName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.MappingCharFilterDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.MappingCharFilterDescriptor, MappingCharFilter>(charFilterName, configure);
	public CharFiltersDescriptor Mapping(string charFilterName, MappingCharFilter mappingCharFilter) => AssignVariant(charFilterName, mappingCharFilter);
	public CharFiltersDescriptor PatternReplace(string charFilterName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.PatternReplaceCharFilterDescriptor, PatternReplaceCharFilter>(charFilterName, null);
	public CharFiltersDescriptor PatternReplace(string charFilterName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.PatternReplaceCharFilterDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.PatternReplaceCharFilterDescriptor, PatternReplaceCharFilter>(charFilterName, configure);
	public CharFiltersDescriptor PatternReplace(string charFilterName, PatternReplaceCharFilter patternReplaceCharFilter) => AssignVariant(charFilterName, patternReplaceCharFilter);
}

internal sealed partial class CharFilterInterfaceConverter : JsonConverter<ICharFilter>
{
	public override ICharFilter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var copiedReader = reader;
		string? type = null;
		using var jsonDoc = JsonDocument.ParseValue(ref copiedReader);
		if (jsonDoc is not null && jsonDoc.RootElement.TryGetProperty("type", out var readType) && readType.ValueKind == JsonValueKind.String)
		{
			type = readType.ToString();
		}

		switch (type)
		{
			case "html_strip":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.HtmlStripCharFilter>(ref reader, options);
			case "icu_normalizer":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.IcuNormalizationCharFilter>(ref reader, options);
			case "kuromoji_iteration_mark":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.KuromojiIterationMarkCharFilter>(ref reader, options);
			case "mapping":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.MappingCharFilter>(ref reader, options);
			case "pattern_replace":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.PatternReplaceCharFilter>(ref reader, options);
			default:
				ThrowHelper.ThrowUnknownTaggedUnionVariantJsonException(type, typeof(ICharFilter));
				return null;
		}
	}

	public override void Write(Utf8JsonWriter writer, ICharFilter value, JsonSerializerOptions options)
	{
		if (value is null)
		{
			writer.WriteNullValue();
			return;
		}

		switch (value.Type)
		{
			case "html_strip":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.HtmlStripCharFilter), options);
				return;
			case "icu_normalizer":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.IcuNormalizationCharFilter), options);
				return;
			case "kuromoji_iteration_mark":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.KuromojiIterationMarkCharFilter), options);
				return;
			case "mapping":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.MappingCharFilter), options);
				return;
			case "pattern_replace":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.PatternReplaceCharFilter), options);
				return;
			default:
				var type = value.GetType();
				JsonSerializer.Serialize(writer, value, type, options);
				return;
		}
	}
}

[JsonConverter(typeof(CharFilterInterfaceConverter))]
public partial interface ICharFilter
{
	public string? Type { get; }
}