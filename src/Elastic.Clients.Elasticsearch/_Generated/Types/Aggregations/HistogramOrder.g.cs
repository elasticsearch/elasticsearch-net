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
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public partial class HistogramOrder
	{
		[JsonInclude]
		[JsonPropertyName("_count")]
		public Elastic.Clients.Elasticsearch.SortOrder? Count { get; set; }

		[JsonInclude]
		[JsonPropertyName("_key")]
		public Elastic.Clients.Elasticsearch.SortOrder? Key { get; set; }
	}

	public sealed partial class HistogramOrderDescriptor : SerializableDescriptorBase<HistogramOrderDescriptor>
	{
		internal HistogramOrderDescriptor(Action<HistogramOrderDescriptor> configure) => configure.Invoke(this);
		public HistogramOrderDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.SortOrder? CountValue { get; set; }

		private Elastic.Clients.Elasticsearch.SortOrder? KeyValue { get; set; }

		public HistogramOrderDescriptor Count(Elastic.Clients.Elasticsearch.SortOrder? count)
		{
			CountValue = count;
			return Self;
		}

		public HistogramOrderDescriptor Key(Elastic.Clients.Elasticsearch.SortOrder? key)
		{
			KeyValue = key;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (CountValue is not null)
			{
				writer.WritePropertyName("_count");
				JsonSerializer.Serialize(writer, CountValue, options);
			}

			if (KeyValue is not null)
			{
				writer.WritePropertyName("_key");
				JsonSerializer.Serialize(writer, KeyValue, options);
			}

			writer.WriteEndObject();
		}
	}
}