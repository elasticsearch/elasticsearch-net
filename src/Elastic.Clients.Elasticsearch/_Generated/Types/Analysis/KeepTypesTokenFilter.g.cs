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
	public partial class KeepTypesTokenFilter : TokenFilterBase, ITokenFilterDefinition
	{
		[JsonInclude]
		[JsonPropertyName("mode")]
		public Elastic.Clients.Elasticsearch.Analysis.KeepTypesMode? Mode { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "keep_types";
		[JsonInclude]
		[JsonPropertyName("types")]
		public IEnumerable<string>? Types { get; set; }
	}

	public sealed partial class KeepTypesTokenFilterDescriptor : SerializableDescriptorBase<KeepTypesTokenFilterDescriptor>, IBuildableDescriptor<KeepTypesTokenFilter>
	{
		internal KeepTypesTokenFilterDescriptor(Action<KeepTypesTokenFilterDescriptor> configure) => configure.Invoke(this);
		public KeepTypesTokenFilterDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Analysis.KeepTypesMode? ModeValue { get; set; }

		private IEnumerable<string>? TypesValue { get; set; }

		private string? VersionValue { get; set; }

		public KeepTypesTokenFilterDescriptor Mode(Elastic.Clients.Elasticsearch.Analysis.KeepTypesMode? mode)
		{
			ModeValue = mode;
			return Self;
		}

		public KeepTypesTokenFilterDescriptor Types(IEnumerable<string>? types)
		{
			TypesValue = types;
			return Self;
		}

		public KeepTypesTokenFilterDescriptor Version(string? version)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ModeValue is not null)
			{
				writer.WritePropertyName("mode");
				JsonSerializer.Serialize(writer, ModeValue, options);
			}

			writer.WritePropertyName("type");
			writer.WriteStringValue("keep_types");
			if (TypesValue is not null)
			{
				writer.WritePropertyName("types");
				JsonSerializer.Serialize(writer, TypesValue, options);
			}

			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			writer.WriteEndObject();
		}

		KeepTypesTokenFilter IBuildableDescriptor<KeepTypesTokenFilter>.Build() => new()
		{ Mode = ModeValue, Types = TypesValue, Version = VersionValue };
	}
}