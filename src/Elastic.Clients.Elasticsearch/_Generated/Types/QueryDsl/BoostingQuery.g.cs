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
	public sealed partial class BoostingQuery : Query, IQueryVariant
	{
		[JsonInclude]
		[JsonPropertyName("_name")]
		public string? QueryName { get; set; }

		[JsonInclude]
		[JsonPropertyName("boost")]
		public float? Boost { get; set; }

		[JsonInclude]
		[JsonPropertyName("negative")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer Negative { get; set; }

		[JsonInclude]
		[JsonPropertyName("negative_boost")]
		public double NegativeBoost { get; set; }

		[JsonInclude]
		[JsonPropertyName("positive")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer Positive { get; set; }
	}

	public sealed partial class BoostingQueryDescriptor<TDocument> : SerializableDescriptorBase<BoostingQueryDescriptor<TDocument>>
	{
		internal BoostingQueryDescriptor(Action<BoostingQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public BoostingQueryDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer NegativeValue { get; set; }

		private QueryContainerDescriptor<TDocument> NegativeDescriptor { get; set; }

		private Action<QueryContainerDescriptor<TDocument>> NegativeDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer PositiveValue { get; set; }

		private QueryContainerDescriptor<TDocument> PositiveDescriptor { get; set; }

		private Action<QueryContainerDescriptor<TDocument>> PositiveDescriptorAction { get; set; }

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private double NegativeBoostValue { get; set; }

		public BoostingQueryDescriptor<TDocument> Negative(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer negative)
		{
			NegativeDescriptor = null;
			NegativeDescriptorAction = null;
			NegativeValue = negative;
			return Self;
		}

		public BoostingQueryDescriptor<TDocument> Negative(QueryContainerDescriptor<TDocument> descriptor)
		{
			NegativeValue = null;
			NegativeDescriptorAction = null;
			NegativeDescriptor = descriptor;
			return Self;
		}

		public BoostingQueryDescriptor<TDocument> Negative(Action<QueryContainerDescriptor<TDocument>> configure)
		{
			NegativeValue = null;
			NegativeDescriptor = null;
			NegativeDescriptorAction = configure;
			return Self;
		}

		public BoostingQueryDescriptor<TDocument> Positive(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer positive)
		{
			PositiveDescriptor = null;
			PositiveDescriptorAction = null;
			PositiveValue = positive;
			return Self;
		}

		public BoostingQueryDescriptor<TDocument> Positive(QueryContainerDescriptor<TDocument> descriptor)
		{
			PositiveValue = null;
			PositiveDescriptorAction = null;
			PositiveDescriptor = descriptor;
			return Self;
		}

		public BoostingQueryDescriptor<TDocument> Positive(Action<QueryContainerDescriptor<TDocument>> configure)
		{
			PositiveValue = null;
			PositiveDescriptor = null;
			PositiveDescriptorAction = configure;
			return Self;
		}

		public BoostingQueryDescriptor<TDocument> QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public BoostingQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public BoostingQueryDescriptor<TDocument> NegativeBoost(double negativeBoost)
		{
			NegativeBoostValue = negativeBoost;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (NegativeDescriptor is not null)
			{
				writer.WritePropertyName("negative");
				JsonSerializer.Serialize(writer, NegativeDescriptor, options);
			}
			else if (NegativeDescriptorAction is not null)
			{
				writer.WritePropertyName("negative");
				JsonSerializer.Serialize(writer, new QueryContainerDescriptor<TDocument>(NegativeDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("negative");
				JsonSerializer.Serialize(writer, NegativeValue, options);
			}

			if (PositiveDescriptor is not null)
			{
				writer.WritePropertyName("positive");
				JsonSerializer.Serialize(writer, PositiveDescriptor, options);
			}
			else if (PositiveDescriptorAction is not null)
			{
				writer.WritePropertyName("positive");
				JsonSerializer.Serialize(writer, new QueryContainerDescriptor<TDocument>(PositiveDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("positive");
				JsonSerializer.Serialize(writer, PositiveValue, options);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WritePropertyName("negative_boost");
			writer.WriteNumberValue(NegativeBoostValue);
			writer.WriteEndObject();
		}
	}

	public sealed partial class BoostingQueryDescriptor : SerializableDescriptorBase<BoostingQueryDescriptor>
	{
		internal BoostingQueryDescriptor(Action<BoostingQueryDescriptor> configure) => configure.Invoke(this);
		public BoostingQueryDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer NegativeValue { get; set; }

		private QueryContainerDescriptor NegativeDescriptor { get; set; }

		private Action<QueryContainerDescriptor> NegativeDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer PositiveValue { get; set; }

		private QueryContainerDescriptor PositiveDescriptor { get; set; }

		private Action<QueryContainerDescriptor> PositiveDescriptorAction { get; set; }

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private double NegativeBoostValue { get; set; }

		public BoostingQueryDescriptor Negative(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer negative)
		{
			NegativeDescriptor = null;
			NegativeDescriptorAction = null;
			NegativeValue = negative;
			return Self;
		}

		public BoostingQueryDescriptor Negative(QueryContainerDescriptor descriptor)
		{
			NegativeValue = null;
			NegativeDescriptorAction = null;
			NegativeDescriptor = descriptor;
			return Self;
		}

		public BoostingQueryDescriptor Negative(Action<QueryContainerDescriptor> configure)
		{
			NegativeValue = null;
			NegativeDescriptor = null;
			NegativeDescriptorAction = configure;
			return Self;
		}

		public BoostingQueryDescriptor Positive(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer positive)
		{
			PositiveDescriptor = null;
			PositiveDescriptorAction = null;
			PositiveValue = positive;
			return Self;
		}

		public BoostingQueryDescriptor Positive(QueryContainerDescriptor descriptor)
		{
			PositiveValue = null;
			PositiveDescriptorAction = null;
			PositiveDescriptor = descriptor;
			return Self;
		}

		public BoostingQueryDescriptor Positive(Action<QueryContainerDescriptor> configure)
		{
			PositiveValue = null;
			PositiveDescriptor = null;
			PositiveDescriptorAction = configure;
			return Self;
		}

		public BoostingQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public BoostingQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public BoostingQueryDescriptor NegativeBoost(double negativeBoost)
		{
			NegativeBoostValue = negativeBoost;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (NegativeDescriptor is not null)
			{
				writer.WritePropertyName("negative");
				JsonSerializer.Serialize(writer, NegativeDescriptor, options);
			}
			else if (NegativeDescriptorAction is not null)
			{
				writer.WritePropertyName("negative");
				JsonSerializer.Serialize(writer, new QueryContainerDescriptor(NegativeDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("negative");
				JsonSerializer.Serialize(writer, NegativeValue, options);
			}

			if (PositiveDescriptor is not null)
			{
				writer.WritePropertyName("positive");
				JsonSerializer.Serialize(writer, PositiveDescriptor, options);
			}
			else if (PositiveDescriptorAction is not null)
			{
				writer.WritePropertyName("positive");
				JsonSerializer.Serialize(writer, new QueryContainerDescriptor(PositiveDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("positive");
				JsonSerializer.Serialize(writer, PositiveValue, options);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WritePropertyName("negative_boost");
			writer.WriteNumberValue(NegativeBoostValue);
			writer.WriteEndObject();
		}
	}
}