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
	internal sealed class DerivativeAggregationConverter : JsonConverter<DerivativeAggregation>
	{
		public override DerivativeAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "derivative")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new DerivativeAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("format"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Format = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("gap_policy"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.GapPolicy?>(ref reader, options);
						if (value is not null)
						{
							agg.GapPolicy = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("buckets_path"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.BucketsPath?>(ref reader, options);
						if (value is not null)
						{
							agg.BucketsPath = value;
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

		public override void Write(Utf8JsonWriter writer, DerivativeAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("derivative");
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(value.Format))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(value.Format);
			}

			if (value.GapPolicy is not null)
			{
				writer.WritePropertyName("gap_policy");
				JsonSerializer.Serialize(writer, value.GapPolicy, options);
			}

			if (value.BucketsPath is not null)
			{
				writer.WritePropertyName("buckets_path");
				JsonSerializer.Serialize(writer, value.BucketsPath, options);
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

	[JsonConverter(typeof(DerivativeAggregationConverter))]
	public partial class DerivativeAggregation : PipelineAggregationBase
	{
		public DerivativeAggregation(string name) : base(name)
		{
		}
	}

	public sealed partial class DerivativeAggregationDescriptor : DescriptorBase<DerivativeAggregationDescriptor>
	{
		internal DerivativeAggregationDescriptor(Action<DerivativeAggregationDescriptor> configure) => configure.Invoke(this);
		public DerivativeAggregationDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPathValue { get; set; }

		private string? FormatValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicyValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		public DerivativeAggregationDescriptor BucketsPath(Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? bucketsPath)
		{
			BucketsPathValue = bucketsPath;
			return Self;
		}

		public DerivativeAggregationDescriptor Format(string? format)
		{
			FormatValue = format;
			return Self;
		}

		public DerivativeAggregationDescriptor GapPolicy(Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? gapPolicy)
		{
			GapPolicyValue = gapPolicy;
			return Self;
		}

		public DerivativeAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("derivative");
			writer.WriteStartObject();
			if (BucketsPathValue is not null)
			{
				writer.WritePropertyName("buckets_path");
				JsonSerializer.Serialize(writer, BucketsPathValue, options);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (GapPolicyValue is not null)
			{
				writer.WritePropertyName("gap_policy");
				JsonSerializer.Serialize(writer, GapPolicyValue, options);
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