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
	public partial class IcuCollationTokenFilter : TokenFilterBase, ITokenFilterDefinition
	{
		[JsonInclude]
		[JsonPropertyName("alternate")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuCollationAlternate Alternate { get; set; }

		[JsonInclude]
		[JsonPropertyName("caseFirst")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuCollationCaseFirst Casefirst { get; set; }

		[JsonInclude]
		[JsonPropertyName("caseLevel")]
		public bool Caselevel { get; set; }

		[JsonInclude]
		[JsonPropertyName("country")]
		public string Country { get; set; }

		[JsonInclude]
		[JsonPropertyName("decomposition")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuCollationDecomposition Decomposition { get; set; }

		[JsonInclude]
		[JsonPropertyName("hiraganaQuaternaryMode")]
		public bool Hiraganaquaternarymode { get; set; }

		[JsonInclude]
		[JsonPropertyName("language")]
		public string Language { get; set; }

		[JsonInclude]
		[JsonPropertyName("numeric")]
		public bool Numeric { get; set; }

		[JsonInclude]
		[JsonPropertyName("strength")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuCollationStrength Strength { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "icu_collation";
		[JsonInclude]
		[JsonPropertyName("variableTop")]
		public string? Variabletop { get; set; }

		[JsonInclude]
		[JsonPropertyName("variant")]
		public string Variant { get; set; }
	}

	public sealed partial class IcuCollationTokenFilterDescriptor : SerializableDescriptorBase<IcuCollationTokenFilterDescriptor>, IBuildableDescriptor<IcuCollationTokenFilter>
	{
		internal IcuCollationTokenFilterDescriptor(Action<IcuCollationTokenFilterDescriptor> configure) => configure.Invoke(this);
		public IcuCollationTokenFilterDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Analysis.IcuCollationAlternate AlternateValue { get; set; }

		private Elastic.Clients.Elasticsearch.Analysis.IcuCollationCaseFirst CasefirstValue { get; set; }

		private bool CaselevelValue { get; set; }

		private string CountryValue { get; set; }

		private Elastic.Clients.Elasticsearch.Analysis.IcuCollationDecomposition DecompositionValue { get; set; }

		private bool HiraganaquaternarymodeValue { get; set; }

		private string LanguageValue { get; set; }

		private bool NumericValue { get; set; }

		private Elastic.Clients.Elasticsearch.Analysis.IcuCollationStrength StrengthValue { get; set; }

		private string? VariabletopValue { get; set; }

		private string VariantValue { get; set; }

		private string? VersionValue { get; set; }

		public IcuCollationTokenFilterDescriptor Alternate(Elastic.Clients.Elasticsearch.Analysis.IcuCollationAlternate alternate)
		{
			AlternateValue = alternate;
			return Self;
		}

		public IcuCollationTokenFilterDescriptor Casefirst(Elastic.Clients.Elasticsearch.Analysis.IcuCollationCaseFirst casefirst)
		{
			CasefirstValue = casefirst;
			return Self;
		}

		public IcuCollationTokenFilterDescriptor Caselevel(bool caselevel = true)
		{
			CaselevelValue = caselevel;
			return Self;
		}

		public IcuCollationTokenFilterDescriptor Country(string country)
		{
			CountryValue = country;
			return Self;
		}

		public IcuCollationTokenFilterDescriptor Decomposition(Elastic.Clients.Elasticsearch.Analysis.IcuCollationDecomposition decomposition)
		{
			DecompositionValue = decomposition;
			return Self;
		}

		public IcuCollationTokenFilterDescriptor Hiraganaquaternarymode(bool hiraganaquaternarymode = true)
		{
			HiraganaquaternarymodeValue = hiraganaquaternarymode;
			return Self;
		}

		public IcuCollationTokenFilterDescriptor Language(string language)
		{
			LanguageValue = language;
			return Self;
		}

		public IcuCollationTokenFilterDescriptor Numeric(bool numeric = true)
		{
			NumericValue = numeric;
			return Self;
		}

		public IcuCollationTokenFilterDescriptor Strength(Elastic.Clients.Elasticsearch.Analysis.IcuCollationStrength strength)
		{
			StrengthValue = strength;
			return Self;
		}

		public IcuCollationTokenFilterDescriptor Variabletop(string? variabletop)
		{
			VariabletopValue = variabletop;
			return Self;
		}

		public IcuCollationTokenFilterDescriptor Variant(string variant)
		{
			VariantValue = variant;
			return Self;
		}

		public IcuCollationTokenFilterDescriptor Version(string? version)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("alternate");
			JsonSerializer.Serialize(writer, AlternateValue, options);
			writer.WritePropertyName("caseFirst");
			JsonSerializer.Serialize(writer, CasefirstValue, options);
			writer.WritePropertyName("caseLevel");
			writer.WriteBooleanValue(CaselevelValue);
			writer.WritePropertyName("country");
			writer.WriteStringValue(CountryValue);
			writer.WritePropertyName("decomposition");
			JsonSerializer.Serialize(writer, DecompositionValue, options);
			writer.WritePropertyName("hiraganaQuaternaryMode");
			writer.WriteBooleanValue(HiraganaquaternarymodeValue);
			writer.WritePropertyName("language");
			writer.WriteStringValue(LanguageValue);
			writer.WritePropertyName("numeric");
			writer.WriteBooleanValue(NumericValue);
			writer.WritePropertyName("strength");
			JsonSerializer.Serialize(writer, StrengthValue, options);
			writer.WritePropertyName("type");
			writer.WriteStringValue("icu_collation");
			if (!string.IsNullOrEmpty(VariabletopValue))
			{
				writer.WritePropertyName("variableTop");
				writer.WriteStringValue(VariabletopValue);
			}

			writer.WritePropertyName("variant");
			writer.WriteStringValue(VariantValue);
			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			writer.WriteEndObject();
		}

		IcuCollationTokenFilter IBuildableDescriptor<IcuCollationTokenFilter>.Build() => new()
		{ Alternate = AlternateValue, Casefirst = CasefirstValue, Caselevel = CaselevelValue, Country = CountryValue, Decomposition = DecompositionValue, Hiraganaquaternarymode = HiraganaquaternarymodeValue, Language = LanguageValue, Numeric = NumericValue, Strength = StrengthValue, Variabletop = VariabletopValue, Variant = VariantValue, Version = VersionValue };
	}
}