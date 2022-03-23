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
	public partial class IpRangeAggregationRange
	{
		[JsonInclude]
		[JsonPropertyName("from")]
		public string? From { get; set; }

		[JsonInclude]
		[JsonPropertyName("mask")]
		public string? Mask { get; set; }

		[JsonInclude]
		[JsonPropertyName("to")]
		public string? To { get; set; }
	}

	public sealed partial class IpRangeAggregationRangeDescriptor : DescriptorBase<IpRangeAggregationRangeDescriptor>
	{
		internal IpRangeAggregationRangeDescriptor(Action<IpRangeAggregationRangeDescriptor> configure) => configure.Invoke(this);
		public IpRangeAggregationRangeDescriptor() : base()
		{
		}

		private string? FromValue { get; set; }

		private string? MaskValue { get; set; }

		private string? ToValue { get; set; }

		public IpRangeAggregationRangeDescriptor From(string? from)
		{
			FromValue = from;
			return Self;
		}

		public IpRangeAggregationRangeDescriptor Mask(string? mask)
		{
			MaskValue = mask;
			return Self;
		}

		public IpRangeAggregationRangeDescriptor To(string? to)
		{
			ToValue = to;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(FromValue))
			{
				writer.WritePropertyName("from");
				writer.WriteStringValue(FromValue);
			}

			if (!string.IsNullOrEmpty(MaskValue))
			{
				writer.WritePropertyName("mask");
				writer.WriteStringValue(MaskValue);
			}

			if (!string.IsNullOrEmpty(ToValue))
			{
				writer.WritePropertyName("to");
				writer.WriteStringValue(ToValue);
			}

			writer.WriteEndObject();
		}
	}
}