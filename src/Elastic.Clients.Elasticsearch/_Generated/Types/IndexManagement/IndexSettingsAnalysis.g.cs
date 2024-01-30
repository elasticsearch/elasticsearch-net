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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed partial class IndexSettingsAnalysis
{
	[JsonInclude, JsonPropertyName("analyzer")]
	public Elastic.Clients.Elasticsearch.Analysis.Analyzers? Analyzers { get; set; }
	[JsonInclude, JsonPropertyName("char_filter")]
	public Elastic.Clients.Elasticsearch.Analysis.CharFilters? CharFilters { get; set; }
	[JsonInclude, JsonPropertyName("filter")]
	public Elastic.Clients.Elasticsearch.Analysis.TokenFilters? TokenFilters { get; set; }
	[JsonInclude, JsonPropertyName("normalizer")]
	public Elastic.Clients.Elasticsearch.Analysis.Normalizers? Normalizers { get; set; }
	[JsonInclude, JsonPropertyName("tokenizer")]
	public Elastic.Clients.Elasticsearch.Analysis.Tokenizers? Tokenizers { get; set; }
}

public sealed partial class IndexSettingsAnalysisDescriptor : SerializableDescriptor<IndexSettingsAnalysisDescriptor>
{
	internal IndexSettingsAnalysisDescriptor(Action<IndexSettingsAnalysisDescriptor> configure) => configure.Invoke(this);

	public IndexSettingsAnalysisDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Analysis.Analyzers? AnalyzersValue { get; set; }
	private Elastic.Clients.Elasticsearch.Analysis.CharFilters? CharFiltersValue { get; set; }
	private Elastic.Clients.Elasticsearch.Analysis.Normalizers? NormalizersValue { get; set; }
	private Elastic.Clients.Elasticsearch.Analysis.TokenFilters? TokenFiltersValue { get; set; }
	private Elastic.Clients.Elasticsearch.Analysis.Tokenizers? TokenizersValue { get; set; }

	public IndexSettingsAnalysisDescriptor Analyzers(Elastic.Clients.Elasticsearch.Analysis.Analyzers? analyzers)
	{
		AnalyzersValue = analyzers;
		return Self;
	}

	public IndexSettingsAnalysisDescriptor Analyzers(Analysis.AnalyzersDescriptor descriptor)
	{
		AnalyzersValue = descriptor.PromisedValue;
		return Self;
	}

	public IndexSettingsAnalysisDescriptor Analyzers(Action<Analysis.AnalyzersDescriptor> configure)
	{
		var descriptor = new Analysis.AnalyzersDescriptor();
		configure?.Invoke(descriptor);
		AnalyzersValue = descriptor.PromisedValue;
		return Self;
	}

	public IndexSettingsAnalysisDescriptor CharFilters(Elastic.Clients.Elasticsearch.Analysis.CharFilters? charFilters)
	{
		CharFiltersValue = charFilters;
		return Self;
	}

	public IndexSettingsAnalysisDescriptor CharFilters(Analysis.CharFiltersDescriptor descriptor)
	{
		CharFiltersValue = descriptor.PromisedValue;
		return Self;
	}

	public IndexSettingsAnalysisDescriptor CharFilters(Action<Analysis.CharFiltersDescriptor> configure)
	{
		var descriptor = new Analysis.CharFiltersDescriptor();
		configure?.Invoke(descriptor);
		CharFiltersValue = descriptor.PromisedValue;
		return Self;
	}

	public IndexSettingsAnalysisDescriptor Normalizers(Elastic.Clients.Elasticsearch.Analysis.Normalizers? normalizers)
	{
		NormalizersValue = normalizers;
		return Self;
	}

	public IndexSettingsAnalysisDescriptor Normalizers(Analysis.NormalizersDescriptor descriptor)
	{
		NormalizersValue = descriptor.PromisedValue;
		return Self;
	}

	public IndexSettingsAnalysisDescriptor Normalizers(Action<Analysis.NormalizersDescriptor> configure)
	{
		var descriptor = new Analysis.NormalizersDescriptor();
		configure?.Invoke(descriptor);
		NormalizersValue = descriptor.PromisedValue;
		return Self;
	}

	public IndexSettingsAnalysisDescriptor TokenFilters(Elastic.Clients.Elasticsearch.Analysis.TokenFilters? tokenFilters)
	{
		TokenFiltersValue = tokenFilters;
		return Self;
	}

	public IndexSettingsAnalysisDescriptor TokenFilters(Analysis.TokenFiltersDescriptor descriptor)
	{
		TokenFiltersValue = descriptor.PromisedValue;
		return Self;
	}

	public IndexSettingsAnalysisDescriptor TokenFilters(Action<Analysis.TokenFiltersDescriptor> configure)
	{
		var descriptor = new Analysis.TokenFiltersDescriptor();
		configure?.Invoke(descriptor);
		TokenFiltersValue = descriptor.PromisedValue;
		return Self;
	}

	public IndexSettingsAnalysisDescriptor Tokenizers(Elastic.Clients.Elasticsearch.Analysis.Tokenizers? tokenizers)
	{
		TokenizersValue = tokenizers;
		return Self;
	}

	public IndexSettingsAnalysisDescriptor Tokenizers(Analysis.TokenizersDescriptor descriptor)
	{
		TokenizersValue = descriptor.PromisedValue;
		return Self;
	}

	public IndexSettingsAnalysisDescriptor Tokenizers(Action<Analysis.TokenizersDescriptor> configure)
	{
		var descriptor = new Analysis.TokenizersDescriptor();
		configure?.Invoke(descriptor);
		TokenizersValue = descriptor.PromisedValue;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AnalyzersValue is not null)
		{
			writer.WritePropertyName("analyzer");
			JsonSerializer.Serialize(writer, AnalyzersValue, options);
		}

		if (CharFiltersValue is not null)
		{
			writer.WritePropertyName("char_filter");
			JsonSerializer.Serialize(writer, CharFiltersValue, options);
		}

		if (NormalizersValue is not null)
		{
			writer.WritePropertyName("normalizer");
			JsonSerializer.Serialize(writer, NormalizersValue, options);
		}

		if (TokenFiltersValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, TokenFiltersValue, options);
		}

		if (TokenizersValue is not null)
		{
			writer.WritePropertyName("tokenizer");
			JsonSerializer.Serialize(writer, TokenizersValue, options);
		}

		writer.WriteEndObject();
	}
}