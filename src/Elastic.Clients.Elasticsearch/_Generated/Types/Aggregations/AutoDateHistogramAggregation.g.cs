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
	internal sealed class AutoDateHistogramAggregationConverter : JsonConverter<AutoDateHistogramAggregation>
	{
		public override AutoDateHistogramAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "auto_date_histogram")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new AutoDateHistogramAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("buckets"))
					{
						var value = JsonSerializer.Deserialize<int?>(ref reader, options);
						if (value is not null)
						{
							agg.Buckets = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("field"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
						if (value is not null)
						{
							agg.Field = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("format"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Format = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("minimum_interval"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.MinimumInterval?>(ref reader, options);
						if (value is not null)
						{
							agg.MinimumInterval = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("missing"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Missing = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("offset"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Offset = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("params"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, object>?>(ref reader, options);
						if (value is not null)
						{
							agg.Params = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("script"))
					{
						var value = JsonSerializer.Deserialize<ScriptBase?>(ref reader, options);
						if (value is not null)
						{
							agg.Script = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("time_zone"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.TimeZone = value;
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

		public override void Write(Utf8JsonWriter writer, AutoDateHistogramAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("auto_date_histogram");
			writer.WriteStartObject();
			if (value.Buckets.HasValue)
			{
				writer.WritePropertyName("buckets");
				writer.WriteNumberValue(value.Buckets.Value);
			}

			if (value.Field is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, value.Field, options);
			}

			if (!string.IsNullOrEmpty(value.Format))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(value.Format);
			}

			if (value.MinimumInterval is not null)
			{
				writer.WritePropertyName("minimum_interval");
				JsonSerializer.Serialize(writer, value.MinimumInterval, options);
			}

			if (value.Missing is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, value.Missing, options);
			}

			if (!string.IsNullOrEmpty(value.Offset))
			{
				writer.WritePropertyName("offset");
				writer.WriteStringValue(value.Offset);
			}

			if (value.Params is not null)
			{
				writer.WritePropertyName("params");
				JsonSerializer.Serialize(writer, value.Params, options);
			}

			if (value.Script is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, value.Script, options);
			}

			if (!string.IsNullOrEmpty(value.TimeZone))
			{
				writer.WritePropertyName("time_zone");
				writer.WriteStringValue(value.TimeZone);
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

	[JsonConverter(typeof(AutoDateHistogramAggregationConverter))]
	public partial class AutoDateHistogramAggregation : BucketAggregationBase
	{
		public AutoDateHistogramAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("buckets")]
		public int? Buckets { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonInclude]
		[JsonPropertyName("minimum_interval")]
		public Elastic.Clients.Elasticsearch.Aggregations.MinimumInterval? MinimumInterval { get; set; }

		[JsonInclude]
		[JsonPropertyName("missing")]
		public string? Missing { get; set; }

		[JsonInclude]
		[JsonPropertyName("offset")]
		public string? Offset { get; set; }

		[JsonInclude]
		[JsonPropertyName("params")]
		public Dictionary<string, object>? Params { get; set; }

		[JsonInclude]
		[JsonPropertyName("script")]
		public ScriptBase? Script { get; set; }

		[JsonInclude]
		[JsonPropertyName("time_zone")]
		public string? TimeZone { get; set; }
	}

	public sealed partial class AutoDateHistogramAggregationDescriptor<TDocument> : DescriptorBase<AutoDateHistogramAggregationDescriptor<TDocument>>
	{
		internal AutoDateHistogramAggregationDescriptor(Action<AutoDateHistogramAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
		public AutoDateHistogramAggregationDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument> AggregationsDescriptor { get; set; }

		private Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument>> AggregationsDescriptorAction { get; set; }

		private ScriptBase? ScriptValue { get; set; }

		private ScriptDescriptor ScriptDescriptor { get; set; }

		private Action<ScriptDescriptor> ScriptDescriptorAction { get; set; }

		private int? BucketsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private string? FormatValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.MinimumInterval? MinimumIntervalValue { get; set; }

		private string? MissingValue { get; set; }

		private string? OffsetValue { get; set; }

		private Dictionary<string, object>? ParamsValue { get; set; }

		private string? TimeZoneValue { get; set; }

		public AutoDateHistogramAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
		{
			AggregationsDescriptor = null;
			AggregationsDescriptorAction = null;
			AggregationsValue = aggregations;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument> descriptor)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			AggregationsDescriptor = descriptor;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor<TDocument> Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument>> configure)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			AggregationsDescriptorAction = configure;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor<TDocument> Script(ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			ScriptValue = script;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor<TDocument> Script(ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			ScriptDescriptor = descriptor;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor<TDocument> Script(Action<ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			ScriptDescriptorAction = configure;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor<TDocument> Buckets(int? buckets)
		{
			BucketsValue = buckets;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor<TDocument> Format(string? format)
		{
			FormatValue = format;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor<TDocument> MinimumInterval(Elastic.Clients.Elasticsearch.Aggregations.MinimumInterval? minimumInterval)
		{
			MinimumIntervalValue = minimumInterval;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor<TDocument> Missing(string? missing)
		{
			MissingValue = missing;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor<TDocument> Offset(string? offset)
		{
			OffsetValue = offset;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor<TDocument> Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor<TDocument> TimeZone(string? timeZone)
		{
			TimeZoneValue = timeZone;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("auto_date_histogram");
			writer.WriteStartObject();
			if (ScriptDescriptor is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptDescriptor, options);
			}
			else if (ScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, new ScriptDescriptor(ScriptDescriptorAction), options);
			}
			else if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (BucketsValue.HasValue)
			{
				writer.WritePropertyName("buckets");
				writer.WriteNumberValue(BucketsValue.Value);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (MinimumIntervalValue is not null)
			{
				writer.WritePropertyName("minimum_interval");
				JsonSerializer.Serialize(writer, MinimumIntervalValue, options);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (!string.IsNullOrEmpty(OffsetValue))
			{
				writer.WritePropertyName("offset");
				writer.WriteStringValue(OffsetValue);
			}

			if (ParamsValue is not null)
			{
				writer.WritePropertyName("params");
				JsonSerializer.Serialize(writer, ParamsValue, options);
			}

			if (!string.IsNullOrEmpty(TimeZoneValue))
			{
				writer.WritePropertyName("time_zone");
				writer.WriteStringValue(TimeZoneValue);
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

	public sealed partial class AutoDateHistogramAggregationDescriptor : DescriptorBase<AutoDateHistogramAggregationDescriptor>
	{
		internal AutoDateHistogramAggregationDescriptor(Action<AutoDateHistogramAggregationDescriptor> configure) => configure.Invoke(this);
		public AutoDateHistogramAggregationDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor AggregationsDescriptor { get; set; }

		private Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor> AggregationsDescriptorAction { get; set; }

		private ScriptBase? ScriptValue { get; set; }

		private ScriptDescriptor ScriptDescriptor { get; set; }

		private Action<ScriptDescriptor> ScriptDescriptorAction { get; set; }

		private int? BucketsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private string? FormatValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.MinimumInterval? MinimumIntervalValue { get; set; }

		private string? MissingValue { get; set; }

		private string? OffsetValue { get; set; }

		private Dictionary<string, object>? ParamsValue { get; set; }

		private string? TimeZoneValue { get; set; }

		public AutoDateHistogramAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
		{
			AggregationsDescriptor = null;
			AggregationsDescriptorAction = null;
			AggregationsValue = aggregations;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor descriptor)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			AggregationsDescriptor = descriptor;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor> configure)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			AggregationsDescriptorAction = configure;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor Script(ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			ScriptValue = script;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor Script(ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			ScriptDescriptor = descriptor;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor Script(Action<ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			ScriptDescriptorAction = configure;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor Buckets(int? buckets)
		{
			BucketsValue = buckets;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor Format(string? format)
		{
			FormatValue = format;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor MinimumInterval(Elastic.Clients.Elasticsearch.Aggregations.MinimumInterval? minimumInterval)
		{
			MinimumIntervalValue = minimumInterval;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor Missing(string? missing)
		{
			MissingValue = missing;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor Offset(string? offset)
		{
			OffsetValue = offset;
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public AutoDateHistogramAggregationDescriptor TimeZone(string? timeZone)
		{
			TimeZoneValue = timeZone;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("auto_date_histogram");
			writer.WriteStartObject();
			if (ScriptDescriptor is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptDescriptor, options);
			}
			else if (ScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, new ScriptDescriptor(ScriptDescriptorAction), options);
			}
			else if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (BucketsValue.HasValue)
			{
				writer.WritePropertyName("buckets");
				writer.WriteNumberValue(BucketsValue.Value);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (MinimumIntervalValue is not null)
			{
				writer.WritePropertyName("minimum_interval");
				JsonSerializer.Serialize(writer, MinimumIntervalValue, options);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (!string.IsNullOrEmpty(OffsetValue))
			{
				writer.WritePropertyName("offset");
				writer.WriteStringValue(OffsetValue);
			}

			if (ParamsValue is not null)
			{
				writer.WritePropertyName("params");
				JsonSerializer.Serialize(writer, ParamsValue, options);
			}

			if (!string.IsNullOrEmpty(TimeZoneValue))
			{
				writer.WritePropertyName("time_zone");
				writer.WriteStringValue(TimeZoneValue);
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