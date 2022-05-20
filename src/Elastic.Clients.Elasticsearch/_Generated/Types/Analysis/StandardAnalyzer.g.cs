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
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public partial class StandardAnalyzer : IAnalyzer
	{
		[JsonInclude]
		[JsonPropertyName("max_token_length")]
		public int? MaxTokenLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("stopwords")]
		public Elastic.Clients.Elasticsearch.Analysis.StopWords? Stopwords { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "standard";
	}

	public sealed partial class StandardAnalyzerDescriptor : SerializableDescriptorBase<StandardAnalyzerDescriptor>, IBuildableDescriptor<StandardAnalyzer>
	{
		internal StandardAnalyzerDescriptor(Action<StandardAnalyzerDescriptor> configure) => configure.Invoke(this);
		public StandardAnalyzerDescriptor() : base()
		{
		}

		private int? MaxTokenLengthValue { get; set; }

		private Elastic.Clients.Elasticsearch.Analysis.StopWords? StopwordsValue { get; set; }

		public StandardAnalyzerDescriptor MaxTokenLength(int? maxTokenLength)
		{
			MaxTokenLengthValue = maxTokenLength;
			return Self;
		}

		public StandardAnalyzerDescriptor Stopwords(Elastic.Clients.Elasticsearch.Analysis.StopWords? stopwords)
		{
			StopwordsValue = stopwords;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (MaxTokenLengthValue.HasValue)
			{
				writer.WritePropertyName("max_token_length");
				writer.WriteNumberValue(MaxTokenLengthValue.Value);
			}

			if (StopwordsValue is not null)
			{
				writer.WritePropertyName("stopwords");
				JsonSerializer.Serialize(writer, StopwordsValue, options);
			}

			writer.WritePropertyName("type");
			writer.WriteStringValue("standard");
			writer.WriteEndObject();
		}

		StandardAnalyzer IBuildableDescriptor<StandardAnalyzer>.Build() => new()
		{ MaxTokenLength = MaxTokenLengthValue, Stopwords = StopwordsValue };
	}
}