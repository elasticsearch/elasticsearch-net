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
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public partial class DropProcessor : Ingest.ProcessorBase, IProcessorContainerVariant
	{
		[JsonIgnore]
		string Ingest.IProcessorContainerVariant.ProcessorContainerVariantName => "drop";
	}

	public sealed partial class DropProcessorDescriptor : DescriptorBase<DropProcessorDescriptor>
	{
		public DropProcessorDescriptor()
		{
		}

		internal DropProcessorDescriptor(Action<DropProcessorDescriptor> configure) => configure.Invoke(this);
		internal string? IfValue { get; private set; }

		internal bool? IgnoreFailureValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; private set; }

		internal string? TagValue { get; private set; }

		public DropProcessorDescriptor If(string? ifValue) => Assign(ifValue, (a, v) => a.IfValue = v);
		public DropProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true) => Assign(ignoreFailure, (a, v) => a.IgnoreFailureValue = v);
		public DropProcessorDescriptor OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure) => Assign(onFailure, (a, v) => a.OnFailureValue = v);
		public DropProcessorDescriptor Tag(string? tag) => Assign(tag, (a, v) => a.TagValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(IfValue))
			{
				writer.WritePropertyName("if");
				writer.WriteStringValue(IfValue);
			}

			if (IgnoreFailureValue.HasValue)
			{
				writer.WritePropertyName("ignore_failure");
				writer.WriteBooleanValue(IgnoreFailureValue.Value);
			}

			if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
			}

			if (!string.IsNullOrEmpty(TagValue))
			{
				writer.WritePropertyName("tag");
				writer.WriteStringValue(TagValue);
			}

			writer.WriteEndObject();
		}
	}
}