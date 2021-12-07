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
	internal sealed class TTestAggregationConverter : JsonConverter<TTestAggregation>
	{
		public override TTestAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "t_test")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new TTestAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("a"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.TestPopulation?>(ref reader, options);
						if (value is not null)
						{
							agg.a = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("b"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.TestPopulation?>(ref reader, options);
						if (value is not null)
						{
							agg.b = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("type"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.TTestType?>(ref reader, options);
						if (value is not null)
						{
							agg.Type = value;
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
				}
			}

			reader.Read();
			return agg;
		}

		public override void Write(Utf8JsonWriter writer, TTestAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("t_test");
			writer.WriteStartObject();
			if (value.a is not null)
			{
				writer.WritePropertyName("a");
				JsonSerializer.Serialize(writer, value.a, options);
			}

			if (value.b is not null)
			{
				writer.WritePropertyName("b");
				JsonSerializer.Serialize(writer, value.b, options);
			}

			if (value.Type is not null)
			{
				writer.WritePropertyName("type");
				JsonSerializer.Serialize(writer, value.Type, options);
			}

			writer.WriteEndObject();
			if (value.Meta is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, value.Meta, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(TTestAggregationConverter))]
	public partial class TTestAggregation : Aggregations.AggregationBase
	{
		public TTestAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("a")]
		public Elastic.Clients.Elasticsearch.Aggregations.TestPopulation? a { get; set; }

		[JsonInclude]
		[JsonPropertyName("b")]
		public Elastic.Clients.Elasticsearch.Aggregations.TestPopulation? b { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public Elastic.Clients.Elasticsearch.Aggregations.TTestType? Type { get; set; }
	}

	public sealed partial class TTestAggregationDescriptor<T> : DescriptorBase<TTestAggregationDescriptor<T>>
	{
		public TTestAggregationDescriptor()
		{
		}

		internal TTestAggregationDescriptor(Action<TTestAggregationDescriptor<T>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Aggregations.TestPopulation? aValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.TestPopulation? bValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.TTestType? TypeValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal TestPopulationDescriptor<T> aDescriptor { get; private set; }

		internal TestPopulationDescriptor<T> bDescriptor { get; private set; }

		internal Action<TestPopulationDescriptor<T>> aDescriptorAction { get; private set; }

		internal Action<TestPopulationDescriptor<T>> bDescriptorAction { get; private set; }

		public TTestAggregationDescriptor<T> a(Elastic.Clients.Elasticsearch.Aggregations.TestPopulation? a)
		{
			aDescriptor = null;
			aDescriptorAction = null;
			return Assign(a, (a, v) => a.aValue = v);
		}

		public TTestAggregationDescriptor<T> a(Aggregations.TestPopulationDescriptor<T> descriptor)
		{
			aValue = null;
			aDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.aDescriptor = v);
		}

		public TTestAggregationDescriptor<T> a(Action<Aggregations.TestPopulationDescriptor<T>> configure)
		{
			aValue = null;
			aDescriptorAction = null;
			return Assign(configure, (a, v) => a.aDescriptorAction = v);
		}

		public TTestAggregationDescriptor<T> b(Elastic.Clients.Elasticsearch.Aggregations.TestPopulation? b)
		{
			bDescriptor = null;
			bDescriptorAction = null;
			return Assign(b, (a, v) => a.bValue = v);
		}

		public TTestAggregationDescriptor<T> b(Aggregations.TestPopulationDescriptor<T> descriptor)
		{
			bValue = null;
			bDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.bDescriptor = v);
		}

		public TTestAggregationDescriptor<T> b(Action<Aggregations.TestPopulationDescriptor<T>> configure)
		{
			bValue = null;
			bDescriptorAction = null;
			return Assign(configure, (a, v) => a.bDescriptorAction = v);
		}

		public TTestAggregationDescriptor<T> Type(Elastic.Clients.Elasticsearch.Aggregations.TTestType? type) => Assign(type, (a, v) => a.TypeValue = v);
		public TTestAggregationDescriptor<T> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("t_test");
			writer.WriteStartObject();
			if (aDescriptor is not null)
			{
				writer.WritePropertyName("a");
				JsonSerializer.Serialize(writer, aDescriptor, options);
			}
			else if (aDescriptorAction is not null)
			{
				writer.WritePropertyName("a");
				JsonSerializer.Serialize(writer, new Aggregations.TestPopulationDescriptor<T>(aDescriptorAction), options);
			}
			else if (aValue is not null)
			{
				writer.WritePropertyName("a");
				JsonSerializer.Serialize(writer, aValue, options);
			}

			if (bDescriptor is not null)
			{
				writer.WritePropertyName("b");
				JsonSerializer.Serialize(writer, bDescriptor, options);
			}
			else if (bDescriptorAction is not null)
			{
				writer.WritePropertyName("b");
				JsonSerializer.Serialize(writer, new Aggregations.TestPopulationDescriptor<T>(bDescriptorAction), options);
			}
			else if (bValue is not null)
			{
				writer.WritePropertyName("b");
				JsonSerializer.Serialize(writer, bValue, options);
			}

			if (TypeValue is not null)
			{
				writer.WritePropertyName("type");
				JsonSerializer.Serialize(writer, TypeValue, options);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			writer.WriteEndObject();
		}
	}
}