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
	internal sealed class CompositeAggregationConverter : JsonConverter<CompositeAggregation>
	{
		public override CompositeAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "composite")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new CompositeAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("after"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, object>?>(ref reader, options);
						if (value is not null)
						{
							agg.After = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("size"))
					{
						var value = JsonSerializer.Deserialize<int?>(ref reader, options);
						if (value is not null)
						{
							agg.Size = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("sources"))
					{
						var value = JsonSerializer.Deserialize<IEnumerable<Dictionary<string, Elastic.Clients.Elasticsearch.Aggregations.CompositeAggregationSource>>?>(ref reader, options);
						if (value is not null)
						{
							agg.Sources = value;
						}

						continue;
					}
				}
			}

			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("meta"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
						if (value is not null)
						{
							agg.Meta = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("aggs") || reader.ValueTextEquals("aggregations"))
					{
						var value = JsonSerializer.Deserialize<AggregationDictionary>(ref reader, options);
						if (value is not null)
						{
							agg.Aggregations = value;
						}

						continue;
					}
				}
			}

			reader.Read();
			return agg;
		}

		public override void Write(Utf8JsonWriter writer, CompositeAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("composite");
			writer.WriteStartObject();
			if (value.After is not null)
			{
				writer.WritePropertyName("after");
				JsonSerializer.Serialize(writer, value.After, options);
			}

			if (value.Size.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(value.Size.Value);
			}

			if (value.Sources is not null)
			{
				writer.WritePropertyName("sources");
				JsonSerializer.Serialize(writer, value.Sources, options);
			}

			writer.WriteEndObject();
			if (value.Meta is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, value.Meta, options);
			}

			if (value.Aggregations is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, value.Aggregations, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(CompositeAggregationConverter))]
	public partial class CompositeAggregation : Aggregations.BucketAggregationBase
	{
		public CompositeAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("after")]
		public Dictionary<string, object>? After { get; set; }

		[JsonInclude]
		[JsonPropertyName("size")]
		public int? Size { get; set; }

		[JsonInclude]
		[JsonPropertyName("sources")]
		public IEnumerable<Dictionary<string, Elastic.Clients.Elasticsearch.Aggregations.CompositeAggregationSource>>? Sources { get; set; }
	}

	public sealed partial class CompositeAggregationDescriptor<TDocument> : DescriptorBase<CompositeAggregationDescriptor<TDocument>>
	{
		internal CompositeAggregationDescriptor(Action<CompositeAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
		public CompositeAggregationDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument> AggregationsDescriptor { get; set; }

		private Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument>> AggregationsDescriptorAction { get; set; }

		private Dictionary<string, object>? AfterValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private int? SizeValue { get; set; }

		private IEnumerable<Dictionary<string, Elastic.Clients.Elasticsearch.Aggregations.CompositeAggregationSource>>? SourcesValue { get; set; }

		public CompositeAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
		{
			AggregationsDescriptor = null;
			AggregationsDescriptorAction = null;
			AggregationsValue = aggregations;
			return Self;
		}

		public CompositeAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument> descriptor)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			AggregationsDescriptor = descriptor;
			return Self;
		}

		public CompositeAggregationDescriptor<TDocument> Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument>> configure)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			AggregationsDescriptorAction = configure;
			return Self;
		}

		public CompositeAggregationDescriptor<TDocument> After(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			AfterValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public CompositeAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public CompositeAggregationDescriptor<TDocument> Size(int? size)
		{
			SizeValue = size;
			return Self;
		}

		public CompositeAggregationDescriptor<TDocument> Sources(IEnumerable<Dictionary<string, Elastic.Clients.Elasticsearch.Aggregations.CompositeAggregationSource>>? sources)
		{
			SourcesValue = sources;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("composite");
			writer.WriteStartObject();
			if (AfterValue is not null)
			{
				writer.WritePropertyName("after");
				JsonSerializer.Serialize(writer, AfterValue, options);
			}

			if (SizeValue.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(SizeValue.Value);
			}

			if (SourcesValue is not null)
			{
				writer.WritePropertyName("sources");
				JsonSerializer.Serialize(writer, SourcesValue, options);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (AggregationsDescriptor is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsDescriptor, options);
			}
			else if (AggregationsDescriptorAction is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, new AggregationContainerDescriptor<TDocument>(AggregationsDescriptorAction), options);
			}
			else if (AggregationsValue is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class CompositeAggregationDescriptor : DescriptorBase<CompositeAggregationDescriptor>
	{
		internal CompositeAggregationDescriptor(Action<CompositeAggregationDescriptor> configure) => configure.Invoke(this);
		public CompositeAggregationDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor AggregationsDescriptor { get; set; }

		private Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor> AggregationsDescriptorAction { get; set; }

		private Dictionary<string, object>? AfterValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private int? SizeValue { get; set; }

		private IEnumerable<Dictionary<string, Elastic.Clients.Elasticsearch.Aggregations.CompositeAggregationSource>>? SourcesValue { get; set; }

		public CompositeAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
		{
			AggregationsDescriptor = null;
			AggregationsDescriptorAction = null;
			AggregationsValue = aggregations;
			return Self;
		}

		public CompositeAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor descriptor)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			AggregationsDescriptor = descriptor;
			return Self;
		}

		public CompositeAggregationDescriptor Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor> configure)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			AggregationsDescriptorAction = configure;
			return Self;
		}

		public CompositeAggregationDescriptor After(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			AfterValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public CompositeAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public CompositeAggregationDescriptor Size(int? size)
		{
			SizeValue = size;
			return Self;
		}

		public CompositeAggregationDescriptor Sources(IEnumerable<Dictionary<string, Elastic.Clients.Elasticsearch.Aggregations.CompositeAggregationSource>>? sources)
		{
			SourcesValue = sources;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("composite");
			writer.WriteStartObject();
			if (AfterValue is not null)
			{
				writer.WritePropertyName("after");
				JsonSerializer.Serialize(writer, AfterValue, options);
			}

			if (SizeValue.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(SizeValue.Value);
			}

			if (SourcesValue is not null)
			{
				writer.WritePropertyName("sources");
				JsonSerializer.Serialize(writer, SourcesValue, options);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (AggregationsDescriptor is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsDescriptor, options);
			}
			else if (AggregationsDescriptorAction is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, new AggregationContainerDescriptor(AggregationsDescriptorAction), options);
			}
			else if (AggregationsValue is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsValue, options);
			}

			writer.WriteEndObject();
		}
	}
}