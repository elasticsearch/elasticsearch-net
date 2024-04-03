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

public partial class Analyzers : IsADictionary<string, IAnalyzer>
{
	public Analyzers()
	{
	}

	public Analyzers(IDictionary<string, IAnalyzer> container) : base(container)
	{
	}

	public void Add(string name, IAnalyzer analyzer) => BackingDictionary.Add(Sanitize(name), analyzer);
	public bool TryGetAnalyzer(string name, [NotNullWhen(returnValue: true)] out IAnalyzer analyzer) => BackingDictionary.TryGetValue(Sanitize(name), out analyzer);

	public bool TryGetAnalyzer<T>(string name, [NotNullWhen(returnValue: true)] out T? analyzer) where T : class, IAnalyzer
	{
		if (BackingDictionary.TryGetValue(Sanitize(name), out var matchedValue) && matchedValue is T finalValue)
		{
			analyzer = finalValue;
			return true;
		}

		analyzer = null;
		return false;
	}
}

public sealed partial class AnalyzersDescriptor : IsADictionaryDescriptor<AnalyzersDescriptor, Analyzers, string, IAnalyzer>
{
	public AnalyzersDescriptor() : base(new Analyzers())
	{
	}

	public AnalyzersDescriptor(Analyzers analyzers) : base(analyzers ?? new Analyzers())
	{
	}

	public AnalyzersDescriptor Custom(string analyzerName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.CustomAnalyzerDescriptor, CustomAnalyzer>(analyzerName, null);
	public AnalyzersDescriptor Custom(string analyzerName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.CustomAnalyzerDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.CustomAnalyzerDescriptor, CustomAnalyzer>(analyzerName, configure);
	public AnalyzersDescriptor Custom(string analyzerName, CustomAnalyzer customAnalyzer) => AssignVariant(analyzerName, customAnalyzer);
	public AnalyzersDescriptor Dutch(string analyzerName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.DutchAnalyzerDescriptor, DutchAnalyzer>(analyzerName, null);
	public AnalyzersDescriptor Dutch(string analyzerName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.DutchAnalyzerDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.DutchAnalyzerDescriptor, DutchAnalyzer>(analyzerName, configure);
	public AnalyzersDescriptor Dutch(string analyzerName, DutchAnalyzer dutchAnalyzer) => AssignVariant(analyzerName, dutchAnalyzer);
	public AnalyzersDescriptor Fingerprint(string analyzerName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.FingerprintAnalyzerDescriptor, FingerprintAnalyzer>(analyzerName, null);
	public AnalyzersDescriptor Fingerprint(string analyzerName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.FingerprintAnalyzerDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.FingerprintAnalyzerDescriptor, FingerprintAnalyzer>(analyzerName, configure);
	public AnalyzersDescriptor Fingerprint(string analyzerName, FingerprintAnalyzer fingerprintAnalyzer) => AssignVariant(analyzerName, fingerprintAnalyzer);
	public AnalyzersDescriptor Icu(string analyzerName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.IcuAnalyzerDescriptor, IcuAnalyzer>(analyzerName, null);
	public AnalyzersDescriptor Icu(string analyzerName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.IcuAnalyzerDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.IcuAnalyzerDescriptor, IcuAnalyzer>(analyzerName, configure);
	public AnalyzersDescriptor Icu(string analyzerName, IcuAnalyzer icuAnalyzer) => AssignVariant(analyzerName, icuAnalyzer);
	public AnalyzersDescriptor Keyword(string analyzerName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.KeywordAnalyzerDescriptor, KeywordAnalyzer>(analyzerName, null);
	public AnalyzersDescriptor Keyword(string analyzerName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.KeywordAnalyzerDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.KeywordAnalyzerDescriptor, KeywordAnalyzer>(analyzerName, configure);
	public AnalyzersDescriptor Keyword(string analyzerName, KeywordAnalyzer keywordAnalyzer) => AssignVariant(analyzerName, keywordAnalyzer);
	public AnalyzersDescriptor Kuromoji(string analyzerName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.KuromojiAnalyzerDescriptor, KuromojiAnalyzer>(analyzerName, null);
	public AnalyzersDescriptor Kuromoji(string analyzerName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.KuromojiAnalyzerDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.KuromojiAnalyzerDescriptor, KuromojiAnalyzer>(analyzerName, configure);
	public AnalyzersDescriptor Kuromoji(string analyzerName, KuromojiAnalyzer kuromojiAnalyzer) => AssignVariant(analyzerName, kuromojiAnalyzer);
	public AnalyzersDescriptor Language(string analyzerName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.LanguageAnalyzerDescriptor, LanguageAnalyzer>(analyzerName, null);
	public AnalyzersDescriptor Language(string analyzerName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.LanguageAnalyzerDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.LanguageAnalyzerDescriptor, LanguageAnalyzer>(analyzerName, configure);
	public AnalyzersDescriptor Language(string analyzerName, LanguageAnalyzer languageAnalyzer) => AssignVariant(analyzerName, languageAnalyzer);
	public AnalyzersDescriptor Nori(string analyzerName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.NoriAnalyzerDescriptor, NoriAnalyzer>(analyzerName, null);
	public AnalyzersDescriptor Nori(string analyzerName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.NoriAnalyzerDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.NoriAnalyzerDescriptor, NoriAnalyzer>(analyzerName, configure);
	public AnalyzersDescriptor Nori(string analyzerName, NoriAnalyzer noriAnalyzer) => AssignVariant(analyzerName, noriAnalyzer);
	public AnalyzersDescriptor Pattern(string analyzerName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.PatternAnalyzerDescriptor, PatternAnalyzer>(analyzerName, null);
	public AnalyzersDescriptor Pattern(string analyzerName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.PatternAnalyzerDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.PatternAnalyzerDescriptor, PatternAnalyzer>(analyzerName, configure);
	public AnalyzersDescriptor Pattern(string analyzerName, PatternAnalyzer patternAnalyzer) => AssignVariant(analyzerName, patternAnalyzer);
	public AnalyzersDescriptor Simple(string analyzerName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.SimpleAnalyzerDescriptor, SimpleAnalyzer>(analyzerName, null);
	public AnalyzersDescriptor Simple(string analyzerName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.SimpleAnalyzerDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.SimpleAnalyzerDescriptor, SimpleAnalyzer>(analyzerName, configure);
	public AnalyzersDescriptor Simple(string analyzerName, SimpleAnalyzer simpleAnalyzer) => AssignVariant(analyzerName, simpleAnalyzer);
	public AnalyzersDescriptor Snowball(string analyzerName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.SnowballAnalyzerDescriptor, SnowballAnalyzer>(analyzerName, null);
	public AnalyzersDescriptor Snowball(string analyzerName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.SnowballAnalyzerDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.SnowballAnalyzerDescriptor, SnowballAnalyzer>(analyzerName, configure);
	public AnalyzersDescriptor Snowball(string analyzerName, SnowballAnalyzer snowballAnalyzer) => AssignVariant(analyzerName, snowballAnalyzer);
	public AnalyzersDescriptor Standard(string analyzerName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.StandardAnalyzerDescriptor, StandardAnalyzer>(analyzerName, null);
	public AnalyzersDescriptor Standard(string analyzerName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.StandardAnalyzerDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.StandardAnalyzerDescriptor, StandardAnalyzer>(analyzerName, configure);
	public AnalyzersDescriptor Standard(string analyzerName, StandardAnalyzer standardAnalyzer) => AssignVariant(analyzerName, standardAnalyzer);
	public AnalyzersDescriptor Stop(string analyzerName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.StopAnalyzerDescriptor, StopAnalyzer>(analyzerName, null);
	public AnalyzersDescriptor Stop(string analyzerName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.StopAnalyzerDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.StopAnalyzerDescriptor, StopAnalyzer>(analyzerName, configure);
	public AnalyzersDescriptor Stop(string analyzerName, StopAnalyzer stopAnalyzer) => AssignVariant(analyzerName, stopAnalyzer);
	public AnalyzersDescriptor Whitespace(string analyzerName) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.WhitespaceAnalyzerDescriptor, WhitespaceAnalyzer>(analyzerName, null);
	public AnalyzersDescriptor Whitespace(string analyzerName, Action<Elastic.Clients.Elasticsearch.Serverless.Analysis.WhitespaceAnalyzerDescriptor> configure) => AssignVariant<Elastic.Clients.Elasticsearch.Serverless.Analysis.WhitespaceAnalyzerDescriptor, WhitespaceAnalyzer>(analyzerName, configure);
	public AnalyzersDescriptor Whitespace(string analyzerName, WhitespaceAnalyzer whitespaceAnalyzer) => AssignVariant(analyzerName, whitespaceAnalyzer);
}

internal sealed partial class AnalyzerInterfaceConverter : JsonConverter<IAnalyzer>
{
	public override IAnalyzer Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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
			case "custom":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.CustomAnalyzer>(ref reader, options);
			case "dutch":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.DutchAnalyzer>(ref reader, options);
			case "fingerprint":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.FingerprintAnalyzer>(ref reader, options);
			case "icu_analyzer":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.IcuAnalyzer>(ref reader, options);
			case "keyword":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.KeywordAnalyzer>(ref reader, options);
			case "kuromoji":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.KuromojiAnalyzer>(ref reader, options);
			case "language":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.LanguageAnalyzer>(ref reader, options);
			case "nori":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.NoriAnalyzer>(ref reader, options);
			case "pattern":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.PatternAnalyzer>(ref reader, options);
			case "simple":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.SimpleAnalyzer>(ref reader, options);
			case "snowball":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.SnowballAnalyzer>(ref reader, options);
			case "standard":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.StandardAnalyzer>(ref reader, options);
			case "stop":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.StopAnalyzer>(ref reader, options);
			case "whitespace":
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.WhitespaceAnalyzer>(ref reader, options);
			default:
				return JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Analysis.CustomAnalyzer>(ref reader, options);
		}
	}

	public override void Write(Utf8JsonWriter writer, IAnalyzer value, JsonSerializerOptions options)
	{
		if (value is null)
		{
			writer.WriteNullValue();
			return;
		}

		switch (value.Type)
		{
			case "custom":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.CustomAnalyzer), options);
				return;
			case "dutch":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.DutchAnalyzer), options);
				return;
			case "fingerprint":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.FingerprintAnalyzer), options);
				return;
			case "icu_analyzer":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.IcuAnalyzer), options);
				return;
			case "keyword":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.KeywordAnalyzer), options);
				return;
			case "kuromoji":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.KuromojiAnalyzer), options);
				return;
			case "language":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.LanguageAnalyzer), options);
				return;
			case "nori":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.NoriAnalyzer), options);
				return;
			case "pattern":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.PatternAnalyzer), options);
				return;
			case "simple":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.SimpleAnalyzer), options);
				return;
			case "snowball":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.SnowballAnalyzer), options);
				return;
			case "standard":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.StandardAnalyzer), options);
				return;
			case "stop":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.StopAnalyzer), options);
				return;
			case "whitespace":
				JsonSerializer.Serialize(writer, value, typeof(Elastic.Clients.Elasticsearch.Serverless.Analysis.WhitespaceAnalyzer), options);
				return;
			default:
				var type = value.GetType();
				JsonSerializer.Serialize(writer, value, type, options);
				return;
		}
	}
}

[JsonConverter(typeof(AnalyzerInterfaceConverter))]
public partial interface IAnalyzer
{
	public string? Type { get; }
}