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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Mapping
{
	public sealed partial class SearchAsYouTypeProperty : IProperty
	{
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("copy_to")]
		public Elastic.Clients.Elasticsearch.Fields? CopyTo { get; set; }

		[JsonInclude]
		[JsonPropertyName("dynamic")]
		public Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? Dynamic { get; set; }

		[JsonInclude]
		[JsonPropertyName("fields")]
		public Elastic.Clients.Elasticsearch.Mapping.Properties? Fields { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_above")]
		public int? IgnoreAbove { get; set; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public bool? Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("index_options")]
		public Elastic.Clients.Elasticsearch.Mapping.IndexOptions? IndexOptions { get; set; }

		[JsonInclude]
		[JsonPropertyName("local_metadata")]
		public Dictionary<string, object>? LocalMetadata { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_shingle_size")]
		public int? MaxShingleSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("meta")]
		public Dictionary<string, string>? Meta { get; set; }

		[JsonInclude]
		[JsonPropertyName("norms")]
		public bool? Norms { get; set; }

		[JsonInclude]
		[JsonPropertyName("properties")]
		public Elastic.Clients.Elasticsearch.Mapping.Properties? Properties { get; set; }

		[JsonInclude]
		[JsonPropertyName("search_analyzer")]
		public string? SearchAnalyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("search_quote_analyzer")]
		public string? SearchQuoteAnalyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("similarity")]
		public string? Similarity { get; set; }

		[JsonInclude]
		[JsonPropertyName("store")]
		public bool? Store { get; set; }

		[JsonInclude]
		[JsonPropertyName("term_vector")]
		public Elastic.Clients.Elasticsearch.Mapping.TermVectorOption? TermVector { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "search_as_you_type";
	}

	public sealed partial class SearchAsYouTypePropertyDescriptor<TDocument> : SerializableDescriptorBase<SearchAsYouTypePropertyDescriptor<TDocument>>, IBuildableDescriptor<SearchAsYouTypeProperty>
	{
		internal SearchAsYouTypePropertyDescriptor(Action<SearchAsYouTypePropertyDescriptor<TDocument>> configure) => configure.Invoke(this);
		public SearchAsYouTypePropertyDescriptor() : base()
		{
		}

		private string? AnalyzerValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

		private int? IgnoreAboveValue { get; set; }

		private bool? IndexValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.IndexOptions? IndexOptionsValue { get; set; }

		private Dictionary<string, object>? LocalMetadataValue { get; set; }

		private int? MaxShingleSizeValue { get; set; }

		private Dictionary<string, string>? MetaValue { get; set; }

		private bool? NormsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

		private string? SearchAnalyzerValue { get; set; }

		private string? SearchQuoteAnalyzerValue { get; set; }

		private string? SimilarityValue { get; set; }

		private bool? StoreValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.TermVectorOption? TermVectorValue { get; set; }

		public SearchAsYouTypePropertyDescriptor<TDocument> Analyzer(string? analyzer)
		{
			AnalyzerValue = analyzer;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
		{
			DynamicValue = dynamic;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> Fields(PropertiesDescriptor<TDocument> descriptor)
		{
			FieldsValue = descriptor.PromisedValue;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> Fields(Action<PropertiesDescriptor<TDocument>> configure)
		{
			var descriptor = new PropertiesDescriptor<TDocument>();
			configure?.Invoke(descriptor);
			FieldsValue = descriptor.PromisedValue;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> IgnoreAbove(int? ignoreAbove)
		{
			IgnoreAboveValue = ignoreAbove;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> Index(bool? index = true)
		{
			IndexValue = index;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> IndexOptions(Elastic.Clients.Elasticsearch.Mapping.IndexOptions? indexOptions)
		{
			IndexOptionsValue = indexOptions;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> LocalMetadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			LocalMetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> MaxShingleSize(int? maxShingleSize)
		{
			MaxShingleSizeValue = maxShingleSize;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> Norms(bool? norms = true)
		{
			NormsValue = norms;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
		{
			PropertiesValue = properties;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> Properties(PropertiesDescriptor<TDocument> descriptor)
		{
			PropertiesValue = descriptor.PromisedValue;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> Properties(Action<PropertiesDescriptor<TDocument>> configure)
		{
			var descriptor = new PropertiesDescriptor<TDocument>();
			configure?.Invoke(descriptor);
			PropertiesValue = descriptor.PromisedValue;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> SearchAnalyzer(string? searchAnalyzer)
		{
			SearchAnalyzerValue = searchAnalyzer;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> SearchQuoteAnalyzer(string? searchQuoteAnalyzer)
		{
			SearchQuoteAnalyzerValue = searchQuoteAnalyzer;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> Similarity(string? similarity)
		{
			SimilarityValue = similarity;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> Store(bool? store = true)
		{
			StoreValue = store;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor<TDocument> TermVector(Elastic.Clients.Elasticsearch.Mapping.TermVectorOption? termVector)
		{
			TermVectorValue = termVector;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (CopyToValue is not null)
			{
				writer.WritePropertyName("copy_to");
				JsonSerializer.Serialize(writer, CopyToValue, options);
			}

			if (DynamicValue is not null)
			{
				writer.WritePropertyName("dynamic");
				JsonSerializer.Serialize(writer, DynamicValue, options);
			}

			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (IgnoreAboveValue.HasValue)
			{
				writer.WritePropertyName("ignore_above");
				writer.WriteNumberValue(IgnoreAboveValue.Value);
			}

			if (IndexValue.HasValue)
			{
				writer.WritePropertyName("index");
				writer.WriteBooleanValue(IndexValue.Value);
			}

			if (IndexOptionsValue is not null)
			{
				writer.WritePropertyName("index_options");
				JsonSerializer.Serialize(writer, IndexOptionsValue, options);
			}

			if (LocalMetadataValue is not null)
			{
				writer.WritePropertyName("local_metadata");
				JsonSerializer.Serialize(writer, LocalMetadataValue, options);
			}

			if (MaxShingleSizeValue.HasValue)
			{
				writer.WritePropertyName("max_shingle_size");
				writer.WriteNumberValue(MaxShingleSizeValue.Value);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (NormsValue.HasValue)
			{
				writer.WritePropertyName("norms");
				writer.WriteBooleanValue(NormsValue.Value);
			}

			if (PropertiesValue is not null)
			{
				writer.WritePropertyName("properties");
				JsonSerializer.Serialize(writer, PropertiesValue, options);
			}

			if (!string.IsNullOrEmpty(SearchAnalyzerValue))
			{
				writer.WritePropertyName("search_analyzer");
				writer.WriteStringValue(SearchAnalyzerValue);
			}

			if (!string.IsNullOrEmpty(SearchQuoteAnalyzerValue))
			{
				writer.WritePropertyName("search_quote_analyzer");
				writer.WriteStringValue(SearchQuoteAnalyzerValue);
			}

			if (!string.IsNullOrEmpty(SimilarityValue))
			{
				writer.WritePropertyName("similarity");
				writer.WriteStringValue(SimilarityValue);
			}

			if (StoreValue.HasValue)
			{
				writer.WritePropertyName("store");
				writer.WriteBooleanValue(StoreValue.Value);
			}

			if (TermVectorValue is not null)
			{
				writer.WritePropertyName("term_vector");
				JsonSerializer.Serialize(writer, TermVectorValue, options);
			}

			writer.WritePropertyName("type");
			writer.WriteStringValue("search_as_you_type");
			writer.WriteEndObject();
		}

		SearchAsYouTypeProperty IBuildableDescriptor<SearchAsYouTypeProperty>.Build() => new()
		{ Analyzer = AnalyzerValue, CopyTo = CopyToValue, Dynamic = DynamicValue, Fields = FieldsValue, IgnoreAbove = IgnoreAboveValue, Index = IndexValue, IndexOptions = IndexOptionsValue, LocalMetadata = LocalMetadataValue, MaxShingleSize = MaxShingleSizeValue, Meta = MetaValue, Norms = NormsValue, Properties = PropertiesValue, SearchAnalyzer = SearchAnalyzerValue, SearchQuoteAnalyzer = SearchQuoteAnalyzerValue, Similarity = SimilarityValue, Store = StoreValue, TermVector = TermVectorValue };
	}

	public sealed partial class SearchAsYouTypePropertyDescriptor : SerializableDescriptorBase<SearchAsYouTypePropertyDescriptor>, IBuildableDescriptor<SearchAsYouTypeProperty>
	{
		internal SearchAsYouTypePropertyDescriptor(Action<SearchAsYouTypePropertyDescriptor> configure) => configure.Invoke(this);
		public SearchAsYouTypePropertyDescriptor() : base()
		{
		}

		private string? AnalyzerValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

		private int? IgnoreAboveValue { get; set; }

		private bool? IndexValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.IndexOptions? IndexOptionsValue { get; set; }

		private Dictionary<string, object>? LocalMetadataValue { get; set; }

		private int? MaxShingleSizeValue { get; set; }

		private Dictionary<string, string>? MetaValue { get; set; }

		private bool? NormsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

		private string? SearchAnalyzerValue { get; set; }

		private string? SearchQuoteAnalyzerValue { get; set; }

		private string? SimilarityValue { get; set; }

		private bool? StoreValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.TermVectorOption? TermVectorValue { get; set; }

		public SearchAsYouTypePropertyDescriptor Analyzer(string? analyzer)
		{
			AnalyzerValue = analyzer;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
		{
			DynamicValue = dynamic;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor Fields<TDocument>(PropertiesDescriptor<TDocument> descriptor)
		{
			FieldsValue = descriptor.PromisedValue;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor Fields<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
		{
			var descriptor = new PropertiesDescriptor<TDocument>();
			configure?.Invoke(descriptor);
			FieldsValue = descriptor.PromisedValue;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor IgnoreAbove(int? ignoreAbove)
		{
			IgnoreAboveValue = ignoreAbove;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor Index(bool? index = true)
		{
			IndexValue = index;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor IndexOptions(Elastic.Clients.Elasticsearch.Mapping.IndexOptions? indexOptions)
		{
			IndexOptionsValue = indexOptions;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor LocalMetadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			LocalMetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor MaxShingleSize(int? maxShingleSize)
		{
			MaxShingleSizeValue = maxShingleSize;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor Norms(bool? norms = true)
		{
			NormsValue = norms;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
		{
			PropertiesValue = properties;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor Properties<TDocument>(PropertiesDescriptor<TDocument> descriptor)
		{
			PropertiesValue = descriptor.PromisedValue;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor Properties<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
		{
			var descriptor = new PropertiesDescriptor<TDocument>();
			configure?.Invoke(descriptor);
			PropertiesValue = descriptor.PromisedValue;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor SearchAnalyzer(string? searchAnalyzer)
		{
			SearchAnalyzerValue = searchAnalyzer;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor SearchQuoteAnalyzer(string? searchQuoteAnalyzer)
		{
			SearchQuoteAnalyzerValue = searchQuoteAnalyzer;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor Similarity(string? similarity)
		{
			SimilarityValue = similarity;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor Store(bool? store = true)
		{
			StoreValue = store;
			return Self;
		}

		public SearchAsYouTypePropertyDescriptor TermVector(Elastic.Clients.Elasticsearch.Mapping.TermVectorOption? termVector)
		{
			TermVectorValue = termVector;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (CopyToValue is not null)
			{
				writer.WritePropertyName("copy_to");
				JsonSerializer.Serialize(writer, CopyToValue, options);
			}

			if (DynamicValue is not null)
			{
				writer.WritePropertyName("dynamic");
				JsonSerializer.Serialize(writer, DynamicValue, options);
			}

			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (IgnoreAboveValue.HasValue)
			{
				writer.WritePropertyName("ignore_above");
				writer.WriteNumberValue(IgnoreAboveValue.Value);
			}

			if (IndexValue.HasValue)
			{
				writer.WritePropertyName("index");
				writer.WriteBooleanValue(IndexValue.Value);
			}

			if (IndexOptionsValue is not null)
			{
				writer.WritePropertyName("index_options");
				JsonSerializer.Serialize(writer, IndexOptionsValue, options);
			}

			if (LocalMetadataValue is not null)
			{
				writer.WritePropertyName("local_metadata");
				JsonSerializer.Serialize(writer, LocalMetadataValue, options);
			}

			if (MaxShingleSizeValue.HasValue)
			{
				writer.WritePropertyName("max_shingle_size");
				writer.WriteNumberValue(MaxShingleSizeValue.Value);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (NormsValue.HasValue)
			{
				writer.WritePropertyName("norms");
				writer.WriteBooleanValue(NormsValue.Value);
			}

			if (PropertiesValue is not null)
			{
				writer.WritePropertyName("properties");
				JsonSerializer.Serialize(writer, PropertiesValue, options);
			}

			if (!string.IsNullOrEmpty(SearchAnalyzerValue))
			{
				writer.WritePropertyName("search_analyzer");
				writer.WriteStringValue(SearchAnalyzerValue);
			}

			if (!string.IsNullOrEmpty(SearchQuoteAnalyzerValue))
			{
				writer.WritePropertyName("search_quote_analyzer");
				writer.WriteStringValue(SearchQuoteAnalyzerValue);
			}

			if (!string.IsNullOrEmpty(SimilarityValue))
			{
				writer.WritePropertyName("similarity");
				writer.WriteStringValue(SimilarityValue);
			}

			if (StoreValue.HasValue)
			{
				writer.WritePropertyName("store");
				writer.WriteBooleanValue(StoreValue.Value);
			}

			if (TermVectorValue is not null)
			{
				writer.WritePropertyName("term_vector");
				JsonSerializer.Serialize(writer, TermVectorValue, options);
			}

			writer.WritePropertyName("type");
			writer.WriteStringValue("search_as_you_type");
			writer.WriteEndObject();
		}

		SearchAsYouTypeProperty IBuildableDescriptor<SearchAsYouTypeProperty>.Build() => new()
		{ Analyzer = AnalyzerValue, CopyTo = CopyToValue, Dynamic = DynamicValue, Fields = FieldsValue, IgnoreAbove = IgnoreAboveValue, Index = IndexValue, IndexOptions = IndexOptionsValue, LocalMetadata = LocalMetadataValue, MaxShingleSize = MaxShingleSizeValue, Meta = MetaValue, Norms = NormsValue, Properties = PropertiesValue, SearchAnalyzer = SearchAnalyzerValue, SearchQuoteAnalyzer = SearchQuoteAnalyzerValue, Similarity = SimilarityValue, Store = StoreValue, TermVector = TermVectorValue };
	}
}