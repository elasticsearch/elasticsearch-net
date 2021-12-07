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
	internal sealed class ScriptedMetricAggregationConverter : JsonConverter<ScriptedMetricAggregation>
	{
		public override ScriptedMetricAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "scripted_metric")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new ScriptedMetricAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("combine_script"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
						if (value is not null)
						{
							agg.CombineScript = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("init_script"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
						if (value is not null)
						{
							agg.InitScript = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("map_script"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
						if (value is not null)
						{
							agg.MapScript = value;
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

					if (reader.ValueTextEquals("reduce_script"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
						if (value is not null)
						{
							agg.ReduceScript = value;
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

					if (reader.ValueTextEquals("missing"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.Missing?>(ref reader, options);
						if (value is not null)
						{
							agg.Missing = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("script"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
						if (value is not null)
						{
							agg.Script = value;
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

		public override void Write(Utf8JsonWriter writer, ScriptedMetricAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("scripted_metric");
			writer.WriteStartObject();
			if (value.CombineScript is not null)
			{
				writer.WritePropertyName("combine_script");
				JsonSerializer.Serialize(writer, value.CombineScript, options);
			}

			if (value.InitScript is not null)
			{
				writer.WritePropertyName("init_script");
				JsonSerializer.Serialize(writer, value.InitScript, options);
			}

			if (value.MapScript is not null)
			{
				writer.WritePropertyName("map_script");
				JsonSerializer.Serialize(writer, value.MapScript, options);
			}

			if (value.Params is not null)
			{
				writer.WritePropertyName("params");
				JsonSerializer.Serialize(writer, value.Params, options);
			}

			if (value.ReduceScript is not null)
			{
				writer.WritePropertyName("reduce_script");
				JsonSerializer.Serialize(writer, value.ReduceScript, options);
			}

			if (value.Field is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, value.Field, options);
			}

			if (value.Missing is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, value.Missing, options);
			}

			if (value.Script is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, value.Script, options);
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

	[JsonConverter(typeof(ScriptedMetricAggregationConverter))]
	public partial class ScriptedMetricAggregation : Aggregations.MetricAggregationBase
	{
		public ScriptedMetricAggregation(string name, Field field) : base(name) => Field = field;
		public ScriptedMetricAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("combine_script")]
		public Elastic.Clients.Elasticsearch.Script? CombineScript { get; set; }

		[JsonInclude]
		[JsonPropertyName("init_script")]
		public Elastic.Clients.Elasticsearch.Script? InitScript { get; set; }

		[JsonInclude]
		[JsonPropertyName("map_script")]
		public Elastic.Clients.Elasticsearch.Script? MapScript { get; set; }

		[JsonInclude]
		[JsonPropertyName("params")]
		public Dictionary<string, object>? Params { get; set; }

		[JsonInclude]
		[JsonPropertyName("reduce_script")]
		public Elastic.Clients.Elasticsearch.Script? ReduceScript { get; set; }
	}

	public sealed partial class ScriptedMetricAggregationDescriptor<T> : DescriptorBase<ScriptedMetricAggregationDescriptor<T>>
	{
		public ScriptedMetricAggregationDescriptor()
		{
		}

		internal ScriptedMetricAggregationDescriptor(Action<ScriptedMetricAggregationDescriptor<T>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Script? CombineScriptValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Script? InitScriptValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Script? MapScriptValue { get; private set; }

		internal Dictionary<string, object>? ParamsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Script? ReduceScriptValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field? FieldValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.Missing? MissingValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Script? ScriptValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		public ScriptedMetricAggregationDescriptor<T> CombineScript(Elastic.Clients.Elasticsearch.Script? combineScript) => Assign(combineScript, (a, v) => a.CombineScriptValue = v);
		public ScriptedMetricAggregationDescriptor<T> InitScript(Elastic.Clients.Elasticsearch.Script? initScript) => Assign(initScript, (a, v) => a.InitScriptValue = v);
		public ScriptedMetricAggregationDescriptor<T> MapScript(Elastic.Clients.Elasticsearch.Script? mapScript) => Assign(mapScript, (a, v) => a.MapScriptValue = v);
		public ScriptedMetricAggregationDescriptor<T> Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.ParamsValue = v?.Invoke(new FluentDictionary<string, object>()));
		public ScriptedMetricAggregationDescriptor<T> ReduceScript(Elastic.Clients.Elasticsearch.Script? reduceScript) => Assign(reduceScript, (a, v) => a.ReduceScriptValue = v);
		public ScriptedMetricAggregationDescriptor<T> Field(Elastic.Clients.Elasticsearch.Field? field) => Assign(field, (a, v) => a.FieldValue = v);
		public ScriptedMetricAggregationDescriptor<T> Field<TValue>(Expression<Func<T, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public ScriptedMetricAggregationDescriptor<T> Missing(Elastic.Clients.Elasticsearch.Aggregations.Missing? missing) => Assign(missing, (a, v) => a.MissingValue = v);
		public ScriptedMetricAggregationDescriptor<T> Script(Elastic.Clients.Elasticsearch.Script? script) => Assign(script, (a, v) => a.ScriptValue = v);
		public ScriptedMetricAggregationDescriptor<T> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("scripted_metric");
			writer.WriteStartObject();
			if (CombineScriptValue is not null)
			{
				writer.WritePropertyName("combine_script");
				JsonSerializer.Serialize(writer, CombineScriptValue, options);
			}

			if (InitScriptValue is not null)
			{
				writer.WritePropertyName("init_script");
				JsonSerializer.Serialize(writer, InitScriptValue, options);
			}

			if (MapScriptValue is not null)
			{
				writer.WritePropertyName("map_script");
				JsonSerializer.Serialize(writer, MapScriptValue, options);
			}

			if (ParamsValue is not null)
			{
				writer.WritePropertyName("params");
				JsonSerializer.Serialize(writer, ParamsValue, options);
			}

			if (ReduceScriptValue is not null)
			{
				writer.WritePropertyName("reduce_script");
				JsonSerializer.Serialize(writer, ReduceScriptValue, options);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
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