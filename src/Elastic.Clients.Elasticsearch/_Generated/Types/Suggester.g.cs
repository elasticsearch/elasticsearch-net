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
namespace Elastic.Clients.Elasticsearch
{
	public partial class Suggester
	{
		[JsonInclude]
		[JsonPropertyName("text")]
		public string? Text { get; set; }
	}

	public sealed partial class SuggesterDescriptor : DescriptorBase<SuggesterDescriptor>
	{
		internal SuggesterDescriptor(Action<SuggesterDescriptor> configure) => configure.Invoke(this);
		public SuggesterDescriptor() : base()
		{
		}

		private string? TextValue { get; set; }

		public SuggesterDescriptor Text(string? text)
		{
			TextValue = text;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(TextValue))
			{
				writer.WritePropertyName("text");
				writer.WriteStringValue(TextValue);
			}

			writer.WriteEndObject();
		}
	}
}