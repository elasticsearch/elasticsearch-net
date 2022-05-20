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
	public partial class LowercaseTokenizer : TokenizerBase, ITokenizerDefinition
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "lowercase";
	}

	public sealed partial class LowercaseTokenizerDescriptor : SerializableDescriptorBase<LowercaseTokenizerDescriptor>, IBuildableDescriptor<LowercaseTokenizer>
	{
		internal LowercaseTokenizerDescriptor(Action<LowercaseTokenizerDescriptor> configure) => configure.Invoke(this);
		public LowercaseTokenizerDescriptor() : base()
		{
		}

		private string? VersionValue { get; set; }

		public LowercaseTokenizerDescriptor Version(string? version)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("type");
			writer.WriteStringValue("lowercase");
			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			writer.WriteEndObject();
		}

		LowercaseTokenizer IBuildableDescriptor<LowercaseTokenizer>.Build() => new()
		{ Version = VersionValue };
	}
}