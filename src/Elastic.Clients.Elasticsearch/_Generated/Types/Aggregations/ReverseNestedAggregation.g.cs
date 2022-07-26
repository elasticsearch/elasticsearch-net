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
	internal sealed class ReverseNestedAggregationConverter : JsonConverter<ReverseNestedAggregation>
	{
		public override ReverseNestedAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "reverse_nested")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new ReverseNestedAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("path"))
					{
						reader.Read();
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
						if (value is not null)
						{
							agg.Path = value;
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

			return agg;
		}

		public override void Write(Utf8JsonWriter writer, ReverseNestedAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("reverse_nested");
			writer.WriteStartObject();
			if (value.Path is not null)
			{
				writer.WritePropertyName("path");
				JsonSerializer.Serialize(writer, value.Path, options);
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

	[JsonConverter(typeof(ReverseNestedAggregationConverter))]
	public sealed partial class ReverseNestedAggregation : Aggregation
	{
		public ReverseNestedAggregation(string name) => Name = name;
		internal ReverseNestedAggregation()
		{
		}

		public Dictionary<string, object>? Meta { get; set; }

		public override string? Name { get; internal set; }

		public Elastic.Clients.Elasticsearch.Field? Path { get; set; }
	}

	public sealed partial class ReverseNestedAggregationDescriptor<TDocument> : SerializableDescriptorBase<ReverseNestedAggregationDescriptor<TDocument>>
	{
		internal ReverseNestedAggregationDescriptor(Action<ReverseNestedAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
		public ReverseNestedAggregationDescriptor() : base()
		{
		}

		private Dictionary<string, object>? MetaValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? PathValue { get; set; }

		public ReverseNestedAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public ReverseNestedAggregationDescriptor<TDocument> Path(Elastic.Clients.Elasticsearch.Field? path)
		{
			PathValue = path;
			return Self;
		}

		public ReverseNestedAggregationDescriptor<TDocument> Path<TValue>(Expression<Func<TDocument, TValue>> path)
		{
			PathValue = path;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("reverse_nested");
			writer.WriteStartObject();
			if (PathValue is not null)
			{
				writer.WritePropertyName("path");
				JsonSerializer.Serialize(writer, PathValue, options);
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

	public sealed partial class ReverseNestedAggregationDescriptor : SerializableDescriptorBase<ReverseNestedAggregationDescriptor>
	{
		internal ReverseNestedAggregationDescriptor(Action<ReverseNestedAggregationDescriptor> configure) => configure.Invoke(this);
		public ReverseNestedAggregationDescriptor() : base()
		{
		}

		private Dictionary<string, object>? MetaValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? PathValue { get; set; }

		public ReverseNestedAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public ReverseNestedAggregationDescriptor Path(Elastic.Clients.Elasticsearch.Field? path)
		{
			PathValue = path;
			return Self;
		}

		public ReverseNestedAggregationDescriptor Path<TDocument, TValue>(Expression<Func<TDocument, TValue>> path)
		{
			PathValue = path;
			return Self;
		}

		public ReverseNestedAggregationDescriptor Path<TDocument>(Expression<Func<TDocument, object>> path)
		{
			PathValue = path;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("reverse_nested");
			writer.WriteStartObject();
			if (PathValue is not null)
			{
				writer.WritePropertyName("path");
				JsonSerializer.Serialize(writer, PathValue, options);
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