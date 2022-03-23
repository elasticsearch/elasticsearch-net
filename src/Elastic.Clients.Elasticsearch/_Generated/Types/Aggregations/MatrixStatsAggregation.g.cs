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
	internal sealed class MatrixStatsAggregationConverter : JsonConverter<MatrixStatsAggregation>
	{
		public override MatrixStatsAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "matrix_stats")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new MatrixStatsAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("mode"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.SortMode?>(ref reader, options);
						if (value is not null)
						{
							agg.Mode = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("fields"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Fields?>(ref reader, options);
						if (value is not null)
						{
							agg.Fields = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("missing"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<Elastic.Clients.Elasticsearch.Field, double>?>(ref reader, options);
						if (value is not null)
						{
							agg.Missing = value;
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

		public override void Write(Utf8JsonWriter writer, MatrixStatsAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("matrix_stats");
			writer.WriteStartObject();
			if (value.Mode is not null)
			{
				writer.WritePropertyName("mode");
				JsonSerializer.Serialize(writer, value.Mode, options);
			}

			if (value.Fields is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, value.Fields, options);
			}

			if (value.Missing is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, value.Missing, options);
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

	[JsonConverter(typeof(MatrixStatsAggregationConverter))]
	public partial class MatrixStatsAggregation : Aggregations.MatrixAggregationBase
	{
		public MatrixStatsAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("mode")]
		public Elastic.Clients.Elasticsearch.SortMode? Mode { get; set; }
	}

	public sealed partial class MatrixStatsAggregationDescriptor<TDocument> : DescriptorBase<MatrixStatsAggregationDescriptor<TDocument>>
	{
		internal MatrixStatsAggregationDescriptor(Action<MatrixStatsAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
		public MatrixStatsAggregationDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private Dictionary<Elastic.Clients.Elasticsearch.Field, double>? MissingValue { get; set; }

		private Elastic.Clients.Elasticsearch.SortMode? ModeValue { get; set; }

		public MatrixStatsAggregationDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public MatrixStatsAggregationDescriptor<TDocument> Fields<TValue>(Expression<Func<TDocument, TValue>> fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public MatrixStatsAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public MatrixStatsAggregationDescriptor<TDocument> Missing(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>> selector)
		{
			MissingValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>());
			return Self;
		}

		public MatrixStatsAggregationDescriptor<TDocument> Mode(Elastic.Clients.Elasticsearch.SortMode? mode)
		{
			ModeValue = mode;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("matrix_stats");
			writer.WriteStartObject();
			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (ModeValue is not null)
			{
				writer.WritePropertyName("mode");
				JsonSerializer.Serialize(writer, ModeValue, options);
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

	public sealed partial class MatrixStatsAggregationDescriptor : DescriptorBase<MatrixStatsAggregationDescriptor>
	{
		internal MatrixStatsAggregationDescriptor(Action<MatrixStatsAggregationDescriptor> configure) => configure.Invoke(this);
		public MatrixStatsAggregationDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private Dictionary<Elastic.Clients.Elasticsearch.Field, double>? MissingValue { get; set; }

		private Elastic.Clients.Elasticsearch.SortMode? ModeValue { get; set; }

		public MatrixStatsAggregationDescriptor Fields(Elastic.Clients.Elasticsearch.Fields? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public MatrixStatsAggregationDescriptor Fields<TDocument, TValue>(Expression<Func<TDocument, TValue>> fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public MatrixStatsAggregationDescriptor Fields<TDocument>(Expression<Func<TDocument, object>> fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public MatrixStatsAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public MatrixStatsAggregationDescriptor Missing(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>> selector)
		{
			MissingValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>());
			return Self;
		}

		public MatrixStatsAggregationDescriptor Mode(Elastic.Clients.Elasticsearch.SortMode? mode)
		{
			ModeValue = mode;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("matrix_stats");
			writer.WriteStartObject();
			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (ModeValue is not null)
			{
				writer.WritePropertyName("mode");
				JsonSerializer.Serialize(writer, ModeValue, options);
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