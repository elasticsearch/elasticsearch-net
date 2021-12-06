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
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class SpanWithinQuery : QueryDsl.QueryBase, IQueryContainerVariant, ISpanQueryVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "span_within";
		[JsonIgnore]
		string QueryDsl.ISpanQueryVariant.SpanQueryVariantName => "span_within";
		[JsonInclude]
		[JsonPropertyName("big")]
		public Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery Big { get; set; }

		[JsonInclude]
		[JsonPropertyName("little")]
		public Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery Little { get; set; }
	}

	public sealed partial class SpanWithinQueryDescriptor<T> : DescriptorBase<SpanWithinQueryDescriptor<T>>
	{
		public SpanWithinQueryDescriptor()
		{
		}

		internal SpanWithinQueryDescriptor(Action<SpanWithinQueryDescriptor<T>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery BigValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery LittleValue { get; private set; }

		internal float? BoostValue { get; private set; }

		internal string? QueryNameValue { get; private set; }

		internal SpanQueryDescriptor<T> BigDescriptor { get; private set; }

		internal SpanQueryDescriptor<T> LittleDescriptor { get; private set; }

		internal Action<SpanQueryDescriptor<T>> BigDescriptorAction { get; private set; }

		internal Action<SpanQueryDescriptor<T>> LittleDescriptorAction { get; private set; }

		public SpanWithinQueryDescriptor<T> Big(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery big)
		{
			BigDescriptor = null;
			BigDescriptorAction = null;
			return Assign(big, (a, v) => a.BigValue = v);
		}

		public SpanWithinQueryDescriptor<T> Big(QueryDsl.SpanQueryDescriptor<T> descriptor)
		{
			BigValue = null;
			BigDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.BigDescriptor = v);
		}

		public SpanWithinQueryDescriptor<T> Big(Action<QueryDsl.SpanQueryDescriptor<T>> configure)
		{
			BigValue = null;
			BigDescriptorAction = null;
			return Assign(configure, (a, v) => a.BigDescriptorAction = v);
		}

		public SpanWithinQueryDescriptor<T> Little(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery little)
		{
			LittleDescriptor = null;
			LittleDescriptorAction = null;
			return Assign(little, (a, v) => a.LittleValue = v);
		}

		public SpanWithinQueryDescriptor<T> Little(QueryDsl.SpanQueryDescriptor<T> descriptor)
		{
			LittleValue = null;
			LittleDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.LittleDescriptor = v);
		}

		public SpanWithinQueryDescriptor<T> Little(Action<QueryDsl.SpanQueryDescriptor<T>> configure)
		{
			LittleValue = null;
			LittleDescriptorAction = null;
			return Assign(configure, (a, v) => a.LittleDescriptorAction = v);
		}

		public SpanWithinQueryDescriptor<T> Boost(float? boost) => Assign(boost, (a, v) => a.BoostValue = v);
		public SpanWithinQueryDescriptor<T> QueryName(string? queryName) => Assign(queryName, (a, v) => a.QueryNameValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (BigDescriptor is not null)
			{
				writer.WritePropertyName("big");
				JsonSerializer.Serialize(writer, BigDescriptor, options);
			}
			else if (BigDescriptorAction is not null)
			{
				writer.WritePropertyName("big");
				JsonSerializer.Serialize(writer, new QueryDsl.SpanQueryDescriptor<T>(BigDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("big");
				JsonSerializer.Serialize(writer, BigValue, options);
			}

			if (LittleDescriptor is not null)
			{
				writer.WritePropertyName("little");
				JsonSerializer.Serialize(writer, LittleDescriptor, options);
			}
			else if (LittleDescriptorAction is not null)
			{
				writer.WritePropertyName("little");
				JsonSerializer.Serialize(writer, new QueryDsl.SpanQueryDescriptor<T>(LittleDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("little");
				JsonSerializer.Serialize(writer, LittleValue, options);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			writer.WriteEndObject();
		}
	}
}