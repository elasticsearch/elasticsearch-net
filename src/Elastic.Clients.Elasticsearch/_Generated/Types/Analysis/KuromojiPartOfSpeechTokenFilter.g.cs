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
	public partial class KuromojiPartOfSpeechTokenFilter : TokenFilterBase, ITokenFilterDefinition
	{
		[JsonInclude]
		[JsonPropertyName("stoptags")]
		public IEnumerable<string> Stoptags { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "kuromoji_part_of_speech";
	}

	public sealed partial class KuromojiPartOfSpeechTokenFilterDescriptor : SerializableDescriptorBase<KuromojiPartOfSpeechTokenFilterDescriptor>, IBuildableDescriptor<KuromojiPartOfSpeechTokenFilter>
	{
		internal KuromojiPartOfSpeechTokenFilterDescriptor(Action<KuromojiPartOfSpeechTokenFilterDescriptor> configure) => configure.Invoke(this);
		public KuromojiPartOfSpeechTokenFilterDescriptor() : base()
		{
		}

		private IEnumerable<string> StoptagsValue { get; set; }

		private string? VersionValue { get; set; }

		public KuromojiPartOfSpeechTokenFilterDescriptor Stoptags(IEnumerable<string> stoptags)
		{
			StoptagsValue = stoptags;
			return Self;
		}

		public KuromojiPartOfSpeechTokenFilterDescriptor Version(string? version)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("stoptags");
			JsonSerializer.Serialize(writer, StoptagsValue, options);
			writer.WritePropertyName("type");
			writer.WriteStringValue("kuromoji_part_of_speech");
			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			writer.WriteEndObject();
		}

		KuromojiPartOfSpeechTokenFilter IBuildableDescriptor<KuromojiPartOfSpeechTokenFilter>.Build() => new()
		{ Stoptags = StoptagsValue, Version = VersionValue };
	}
}