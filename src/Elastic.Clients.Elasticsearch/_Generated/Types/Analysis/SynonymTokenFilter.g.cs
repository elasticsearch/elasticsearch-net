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
	public partial class SynonymTokenFilter : TokenFilterBase, ITokenFilterDefinition
	{
		[JsonInclude]
		[JsonPropertyName("expand")]
		public bool? Expand { get; set; }

		[JsonInclude]
		[JsonPropertyName("format")]
		public Elastic.Clients.Elasticsearch.Analysis.SynonymFormat? Format { get; set; }

		[JsonInclude]
		[JsonPropertyName("lenient")]
		public bool? Lenient { get; set; }

		[JsonInclude]
		[JsonPropertyName("synonyms")]
		public IEnumerable<string>? Synonyms { get; set; }

		[JsonInclude]
		[JsonPropertyName("synonyms_path")]
		public string? SynonymsPath { get; set; }

		[JsonInclude]
		[JsonPropertyName("tokenizer")]
		public string? Tokenizer { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "synonym";
		[JsonInclude]
		[JsonPropertyName("updateable")]
		public bool? Updateable { get; set; }
	}

	public sealed partial class SynonymTokenFilterDescriptor : SerializableDescriptorBase<SynonymTokenFilterDescriptor>, IBuildableDescriptor<SynonymTokenFilter>
	{
		internal SynonymTokenFilterDescriptor(Action<SynonymTokenFilterDescriptor> configure) => configure.Invoke(this);
		public SynonymTokenFilterDescriptor() : base()
		{
		}

		private bool? ExpandValue { get; set; }

		private Elastic.Clients.Elasticsearch.Analysis.SynonymFormat? FormatValue { get; set; }

		private bool? LenientValue { get; set; }

		private IEnumerable<string>? SynonymsValue { get; set; }

		private string? SynonymsPathValue { get; set; }

		private string? TokenizerValue { get; set; }

		private bool? UpdateableValue { get; set; }

		private string? VersionValue { get; set; }

		public SynonymTokenFilterDescriptor Expand(bool? expand = true)
		{
			ExpandValue = expand;
			return Self;
		}

		public SynonymTokenFilterDescriptor Format(Elastic.Clients.Elasticsearch.Analysis.SynonymFormat? format)
		{
			FormatValue = format;
			return Self;
		}

		public SynonymTokenFilterDescriptor Lenient(bool? lenient = true)
		{
			LenientValue = lenient;
			return Self;
		}

		public SynonymTokenFilterDescriptor Synonyms(IEnumerable<string>? synonyms)
		{
			SynonymsValue = synonyms;
			return Self;
		}

		public SynonymTokenFilterDescriptor SynonymsPath(string? synonymsPath)
		{
			SynonymsPathValue = synonymsPath;
			return Self;
		}

		public SynonymTokenFilterDescriptor Tokenizer(string? tokenizer)
		{
			TokenizerValue = tokenizer;
			return Self;
		}

		public SynonymTokenFilterDescriptor Updateable(bool? updateable = true)
		{
			UpdateableValue = updateable;
			return Self;
		}

		public SynonymTokenFilterDescriptor Version(string? version)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ExpandValue.HasValue)
			{
				writer.WritePropertyName("expand");
				writer.WriteBooleanValue(ExpandValue.Value);
			}

			if (FormatValue is not null)
			{
				writer.WritePropertyName("format");
				JsonSerializer.Serialize(writer, FormatValue, options);
			}

			if (LenientValue.HasValue)
			{
				writer.WritePropertyName("lenient");
				writer.WriteBooleanValue(LenientValue.Value);
			}

			if (SynonymsValue is not null)
			{
				writer.WritePropertyName("synonyms");
				JsonSerializer.Serialize(writer, SynonymsValue, options);
			}

			if (!string.IsNullOrEmpty(SynonymsPathValue))
			{
				writer.WritePropertyName("synonyms_path");
				writer.WriteStringValue(SynonymsPathValue);
			}

			if (!string.IsNullOrEmpty(TokenizerValue))
			{
				writer.WritePropertyName("tokenizer");
				writer.WriteStringValue(TokenizerValue);
			}

			writer.WritePropertyName("type");
			writer.WriteStringValue("synonym");
			if (UpdateableValue.HasValue)
			{
				writer.WritePropertyName("updateable");
				writer.WriteBooleanValue(UpdateableValue.Value);
			}

			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			writer.WriteEndObject();
		}

		SynonymTokenFilter IBuildableDescriptor<SynonymTokenFilter>.Build() => new()
		{ Expand = ExpandValue, Format = FormatValue, Lenient = LenientValue, Synonyms = SynonymsValue, SynonymsPath = SynonymsPathValue, Tokenizer = TokenizerValue, Updateable = UpdateableValue, Version = VersionValue };
	}
}