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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Mapping;

public sealed partial class AllField
{
	[JsonInclude, JsonPropertyName("analyzer")]
	public string Analyzer { get; set; }
	[JsonInclude, JsonPropertyName("enabled")]
	public bool Enabled { get; set; }
	[JsonInclude, JsonPropertyName("omit_norms")]
	public bool OmitNorms { get; set; }
	[JsonInclude, JsonPropertyName("search_analyzer")]
	public string SearchAnalyzer { get; set; }
	[JsonInclude, JsonPropertyName("similarity")]
	public string Similarity { get; set; }
	[JsonInclude, JsonPropertyName("store")]
	public bool Store { get; set; }
	[JsonInclude, JsonPropertyName("store_term_vector_offsets")]
	public bool StoreTermVectorOffsets { get; set; }
	[JsonInclude, JsonPropertyName("store_term_vector_payloads")]
	public bool StoreTermVectorPayloads { get; set; }
	[JsonInclude, JsonPropertyName("store_term_vector_positions")]
	public bool StoreTermVectorPositions { get; set; }
	[JsonInclude, JsonPropertyName("store_term_vectors")]
	public bool StoreTermVectors { get; set; }
}

public sealed partial class AllFieldDescriptor : SerializableDescriptor<AllFieldDescriptor>
{
	internal AllFieldDescriptor(Action<AllFieldDescriptor> configure) => configure.Invoke(this);

	public AllFieldDescriptor() : base()
	{
	}

	private string AnalyzerValue { get; set; }
	private bool EnabledValue { get; set; }
	private bool OmitNormsValue { get; set; }
	private string SearchAnalyzerValue { get; set; }
	private string SimilarityValue { get; set; }
	private bool StoreValue { get; set; }
	private bool StoreTermVectorOffsetsValue { get; set; }
	private bool StoreTermVectorPayloadsValue { get; set; }
	private bool StoreTermVectorPositionsValue { get; set; }
	private bool StoreTermVectorsValue { get; set; }

	public AllFieldDescriptor Analyzer(string analyzer)
	{
		AnalyzerValue = analyzer;
		return Self;
	}

	public AllFieldDescriptor Enabled(bool enabled = true)
	{
		EnabledValue = enabled;
		return Self;
	}

	public AllFieldDescriptor OmitNorms(bool omitNorms = true)
	{
		OmitNormsValue = omitNorms;
		return Self;
	}

	public AllFieldDescriptor SearchAnalyzer(string searchAnalyzer)
	{
		SearchAnalyzerValue = searchAnalyzer;
		return Self;
	}

	public AllFieldDescriptor Similarity(string similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	public AllFieldDescriptor Store(bool store = true)
	{
		StoreValue = store;
		return Self;
	}

	public AllFieldDescriptor StoreTermVectorOffsets(bool storeTermVectorOffsets = true)
	{
		StoreTermVectorOffsetsValue = storeTermVectorOffsets;
		return Self;
	}

	public AllFieldDescriptor StoreTermVectorPayloads(bool storeTermVectorPayloads = true)
	{
		StoreTermVectorPayloadsValue = storeTermVectorPayloads;
		return Self;
	}

	public AllFieldDescriptor StoreTermVectorPositions(bool storeTermVectorPositions = true)
	{
		StoreTermVectorPositionsValue = storeTermVectorPositions;
		return Self;
	}

	public AllFieldDescriptor StoreTermVectors(bool storeTermVectors = true)
	{
		StoreTermVectorsValue = storeTermVectors;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("analyzer");
		writer.WriteStringValue(AnalyzerValue);
		writer.WritePropertyName("enabled");
		writer.WriteBooleanValue(EnabledValue);
		writer.WritePropertyName("omit_norms");
		writer.WriteBooleanValue(OmitNormsValue);
		writer.WritePropertyName("search_analyzer");
		writer.WriteStringValue(SearchAnalyzerValue);
		writer.WritePropertyName("similarity");
		writer.WriteStringValue(SimilarityValue);
		writer.WritePropertyName("store");
		writer.WriteBooleanValue(StoreValue);
		writer.WritePropertyName("store_term_vector_offsets");
		writer.WriteBooleanValue(StoreTermVectorOffsetsValue);
		writer.WritePropertyName("store_term_vector_payloads");
		writer.WriteBooleanValue(StoreTermVectorPayloadsValue);
		writer.WritePropertyName("store_term_vector_positions");
		writer.WriteBooleanValue(StoreTermVectorPositionsValue);
		writer.WritePropertyName("store_term_vectors");
		writer.WriteBooleanValue(StoreTermVectorsValue);
		writer.WriteEndObject();
	}
}