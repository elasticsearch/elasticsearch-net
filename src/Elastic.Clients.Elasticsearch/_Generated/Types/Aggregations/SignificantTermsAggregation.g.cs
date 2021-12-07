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
	internal sealed class SignificantTermsAggregationConverter : JsonConverter<SignificantTermsAggregation>
	{
		public override SignificantTermsAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "significant_terms")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new SignificantTermsAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("background_filter"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer?>(ref reader, options);
						if (value is not null)
						{
							agg.BackgroundFilter = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("chi_square"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.ChiSquareHeuristic?>(ref reader, options);
						if (value is not null)
						{
							agg.ChiSquare = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("exclude"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.TermsExclude?>(ref reader, options);
						if (value is not null)
						{
							agg.Exclude = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("execution_hint"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationExecutionHint?>(ref reader, options);
						if (value is not null)
						{
							agg.ExecutionHint = value;
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

					if (reader.ValueTextEquals("gnd"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.GoogleNormalizedDistanceHeuristic?>(ref reader, options);
						if (value is not null)
						{
							agg.Gnd = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("include"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Include = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("min_doc_count"))
					{
						var value = JsonSerializer.Deserialize<long?>(ref reader, options);
						if (value is not null)
						{
							agg.MinDocCount = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("mutual_information"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.MutualInformationHeuristic?>(ref reader, options);
						if (value is not null)
						{
							agg.MutualInformation = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("percentage"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.PercentageScoreHeuristic?>(ref reader, options);
						if (value is not null)
						{
							agg.Percentage = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("script_heuristic"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.ScriptedHeuristic?>(ref reader, options);
						if (value is not null)
						{
							agg.ScriptHeuristic = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("shard_min_doc_count"))
					{
						var value = JsonSerializer.Deserialize<long?>(ref reader, options);
						if (value is not null)
						{
							agg.ShardMinDocCount = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("shard_size"))
					{
						var value = JsonSerializer.Deserialize<int?>(ref reader, options);
						if (value is not null)
						{
							agg.ShardSize = value;
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

		public override void Write(Utf8JsonWriter writer, SignificantTermsAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("significant_terms");
			writer.WriteStartObject();
			if (value.BackgroundFilter is not null)
			{
				writer.WritePropertyName("background_filter");
				JsonSerializer.Serialize(writer, value.BackgroundFilter, options);
			}

			if (value.ChiSquare is not null)
			{
				writer.WritePropertyName("chi_square");
				JsonSerializer.Serialize(writer, value.ChiSquare, options);
			}

			if (value.Exclude is not null)
			{
				writer.WritePropertyName("exclude");
				JsonSerializer.Serialize(writer, value.Exclude, options);
			}

			if (value.ExecutionHint is not null)
			{
				writer.WritePropertyName("execution_hint");
				JsonSerializer.Serialize(writer, value.ExecutionHint, options);
			}

			if (value.Field is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, value.Field, options);
			}

			if (value.Gnd is not null)
			{
				writer.WritePropertyName("gnd");
				JsonSerializer.Serialize(writer, value.Gnd, options);
			}

			if (!string.IsNullOrEmpty(value.Include))
			{
				writer.WritePropertyName("include");
				writer.WriteStringValue(value.Include);
			}

			if (value.MinDocCount.HasValue)
			{
				writer.WritePropertyName("min_doc_count");
				writer.WriteNumberValue(value.MinDocCount.Value);
			}

			if (value.MutualInformation is not null)
			{
				writer.WritePropertyName("mutual_information");
				JsonSerializer.Serialize(writer, value.MutualInformation, options);
			}

			if (value.Percentage is not null)
			{
				writer.WritePropertyName("percentage");
				JsonSerializer.Serialize(writer, value.Percentage, options);
			}

			if (value.ScriptHeuristic is not null)
			{
				writer.WritePropertyName("script_heuristic");
				JsonSerializer.Serialize(writer, value.ScriptHeuristic, options);
			}

			if (value.ShardMinDocCount.HasValue)
			{
				writer.WritePropertyName("shard_min_doc_count");
				writer.WriteNumberValue(value.ShardMinDocCount.Value);
			}

			if (value.ShardSize.HasValue)
			{
				writer.WritePropertyName("shard_size");
				writer.WriteNumberValue(value.ShardSize.Value);
			}

			if (value.Size.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(value.Size.Value);
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

	[JsonConverter(typeof(SignificantTermsAggregationConverter))]
	public partial class SignificantTermsAggregation : Aggregations.BucketAggregationBase
	{
		public SignificantTermsAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("background_filter")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? BackgroundFilter { get; set; }

		[JsonInclude]
		[JsonPropertyName("chi_square")]
		public Elastic.Clients.Elasticsearch.Aggregations.ChiSquareHeuristic? ChiSquare { get; set; }

		[JsonInclude]
		[JsonPropertyName("exclude")]
		public Elastic.Clients.Elasticsearch.Aggregations.TermsExclude? Exclude { get; set; }

		[JsonInclude]
		[JsonPropertyName("execution_hint")]
		public Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationExecutionHint? ExecutionHint { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("gnd")]
		public Elastic.Clients.Elasticsearch.Aggregations.GoogleNormalizedDistanceHeuristic? Gnd { get; set; }

		[JsonInclude]
		[JsonPropertyName("include")]
		public string? Include { get; set; }

		[JsonInclude]
		[JsonPropertyName("min_doc_count")]
		public long? MinDocCount { get; set; }

		[JsonInclude]
		[JsonPropertyName("mutual_information")]
		public Elastic.Clients.Elasticsearch.Aggregations.MutualInformationHeuristic? MutualInformation { get; set; }

		[JsonInclude]
		[JsonPropertyName("percentage")]
		public Elastic.Clients.Elasticsearch.Aggregations.PercentageScoreHeuristic? Percentage { get; set; }

		[JsonInclude]
		[JsonPropertyName("script_heuristic")]
		public Elastic.Clients.Elasticsearch.Aggregations.ScriptedHeuristic? ScriptHeuristic { get; set; }

		[JsonInclude]
		[JsonPropertyName("shard_min_doc_count")]
		public long? ShardMinDocCount { get; set; }

		[JsonInclude]
		[JsonPropertyName("shard_size")]
		public int? ShardSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("size")]
		public int? Size { get; set; }
	}

	public sealed partial class SignificantTermsAggregationDescriptor<T> : DescriptorBase<SignificantTermsAggregationDescriptor<T>>
	{
		public SignificantTermsAggregationDescriptor()
		{
		}

		internal SignificantTermsAggregationDescriptor(Action<SignificantTermsAggregationDescriptor<T>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? BackgroundFilterValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.ChiSquareHeuristic? ChiSquareValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.TermsExclude? ExcludeValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationExecutionHint? ExecutionHintValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field? FieldValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.GoogleNormalizedDistanceHeuristic? GndValue { get; private set; }

		internal string? IncludeValue { get; private set; }

		internal long? MinDocCountValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.MutualInformationHeuristic? MutualInformationValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.PercentageScoreHeuristic? PercentageValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.ScriptedHeuristic? ScriptHeuristicValue { get; private set; }

		internal long? ShardMinDocCountValue { get; private set; }

		internal int? ShardSizeValue { get; private set; }

		internal int? SizeValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal QueryDsl.QueryContainerDescriptor<T> BackgroundFilterDescriptor { get; private set; }

		internal ChiSquareHeuristicDescriptor ChiSquareDescriptor { get; private set; }

		internal GoogleNormalizedDistanceHeuristicDescriptor GndDescriptor { get; private set; }

		internal MutualInformationHeuristicDescriptor MutualInformationDescriptor { get; private set; }

		internal PercentageScoreHeuristicDescriptor PercentageDescriptor { get; private set; }

		internal ScriptedHeuristicDescriptor ScriptHeuristicDescriptor { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<T> AggregationsDescriptor { get; private set; }

		internal Action<QueryDsl.QueryContainerDescriptor<T>> BackgroundFilterDescriptorAction { get; private set; }

		internal Action<ChiSquareHeuristicDescriptor> ChiSquareDescriptorAction { get; private set; }

		internal Action<GoogleNormalizedDistanceHeuristicDescriptor> GndDescriptorAction { get; private set; }

		internal Action<MutualInformationHeuristicDescriptor> MutualInformationDescriptorAction { get; private set; }

		internal Action<PercentageScoreHeuristicDescriptor> PercentageDescriptorAction { get; private set; }

		internal Action<ScriptedHeuristicDescriptor> ScriptHeuristicDescriptorAction { get; private set; }

		internal Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<T>> AggregationsDescriptorAction { get; private set; }

		public SignificantTermsAggregationDescriptor<T> BackgroundFilter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? backgroundFilter)
		{
			BackgroundFilterDescriptor = null;
			BackgroundFilterDescriptorAction = null;
			return Assign(backgroundFilter, (a, v) => a.BackgroundFilterValue = v);
		}

		public SignificantTermsAggregationDescriptor<T> BackgroundFilter(QueryDsl.QueryContainerDescriptor<T> descriptor)
		{
			BackgroundFilterValue = null;
			BackgroundFilterDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.BackgroundFilterDescriptor = v);
		}

		public SignificantTermsAggregationDescriptor<T> BackgroundFilter(Action<QueryDsl.QueryContainerDescriptor<T>> configure)
		{
			BackgroundFilterValue = null;
			BackgroundFilterDescriptorAction = null;
			return Assign(configure, (a, v) => a.BackgroundFilterDescriptorAction = v);
		}

		public SignificantTermsAggregationDescriptor<T> ChiSquare(Elastic.Clients.Elasticsearch.Aggregations.ChiSquareHeuristic? chiSquare)
		{
			ChiSquareDescriptor = null;
			ChiSquareDescriptorAction = null;
			return Assign(chiSquare, (a, v) => a.ChiSquareValue = v);
		}

		public SignificantTermsAggregationDescriptor<T> ChiSquare(Aggregations.ChiSquareHeuristicDescriptor descriptor)
		{
			ChiSquareValue = null;
			ChiSquareDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.ChiSquareDescriptor = v);
		}

		public SignificantTermsAggregationDescriptor<T> ChiSquare(Action<Aggregations.ChiSquareHeuristicDescriptor> configure)
		{
			ChiSquareValue = null;
			ChiSquareDescriptorAction = null;
			return Assign(configure, (a, v) => a.ChiSquareDescriptorAction = v);
		}

		public SignificantTermsAggregationDescriptor<T> Exclude(Elastic.Clients.Elasticsearch.Aggregations.TermsExclude? exclude) => Assign(exclude, (a, v) => a.ExcludeValue = v);
		public SignificantTermsAggregationDescriptor<T> ExecutionHint(Elastic.Clients.Elasticsearch.Aggregations.TermsAggregationExecutionHint? executionHint) => Assign(executionHint, (a, v) => a.ExecutionHintValue = v);
		public SignificantTermsAggregationDescriptor<T> Field(Elastic.Clients.Elasticsearch.Field? field) => Assign(field, (a, v) => a.FieldValue = v);
		public SignificantTermsAggregationDescriptor<T> Field<TValue>(Expression<Func<T, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public SignificantTermsAggregationDescriptor<T> Gnd(Elastic.Clients.Elasticsearch.Aggregations.GoogleNormalizedDistanceHeuristic? gnd)
		{
			GndDescriptor = null;
			GndDescriptorAction = null;
			return Assign(gnd, (a, v) => a.GndValue = v);
		}

		public SignificantTermsAggregationDescriptor<T> Gnd(Aggregations.GoogleNormalizedDistanceHeuristicDescriptor descriptor)
		{
			GndValue = null;
			GndDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.GndDescriptor = v);
		}

		public SignificantTermsAggregationDescriptor<T> Gnd(Action<Aggregations.GoogleNormalizedDistanceHeuristicDescriptor> configure)
		{
			GndValue = null;
			GndDescriptorAction = null;
			return Assign(configure, (a, v) => a.GndDescriptorAction = v);
		}

		public SignificantTermsAggregationDescriptor<T> Include(string? include) => Assign(include, (a, v) => a.IncludeValue = v);
		public SignificantTermsAggregationDescriptor<T> MinDocCount(long? minDocCount) => Assign(minDocCount, (a, v) => a.MinDocCountValue = v);
		public SignificantTermsAggregationDescriptor<T> MutualInformation(Elastic.Clients.Elasticsearch.Aggregations.MutualInformationHeuristic? mutualInformation)
		{
			MutualInformationDescriptor = null;
			MutualInformationDescriptorAction = null;
			return Assign(mutualInformation, (a, v) => a.MutualInformationValue = v);
		}

		public SignificantTermsAggregationDescriptor<T> MutualInformation(Aggregations.MutualInformationHeuristicDescriptor descriptor)
		{
			MutualInformationValue = null;
			MutualInformationDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.MutualInformationDescriptor = v);
		}

		public SignificantTermsAggregationDescriptor<T> MutualInformation(Action<Aggregations.MutualInformationHeuristicDescriptor> configure)
		{
			MutualInformationValue = null;
			MutualInformationDescriptorAction = null;
			return Assign(configure, (a, v) => a.MutualInformationDescriptorAction = v);
		}

		public SignificantTermsAggregationDescriptor<T> Percentage(Elastic.Clients.Elasticsearch.Aggregations.PercentageScoreHeuristic? percentage)
		{
			PercentageDescriptor = null;
			PercentageDescriptorAction = null;
			return Assign(percentage, (a, v) => a.PercentageValue = v);
		}

		public SignificantTermsAggregationDescriptor<T> Percentage(Aggregations.PercentageScoreHeuristicDescriptor descriptor)
		{
			PercentageValue = null;
			PercentageDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.PercentageDescriptor = v);
		}

		public SignificantTermsAggregationDescriptor<T> Percentage(Action<Aggregations.PercentageScoreHeuristicDescriptor> configure)
		{
			PercentageValue = null;
			PercentageDescriptorAction = null;
			return Assign(configure, (a, v) => a.PercentageDescriptorAction = v);
		}

		public SignificantTermsAggregationDescriptor<T> ScriptHeuristic(Elastic.Clients.Elasticsearch.Aggregations.ScriptedHeuristic? scriptHeuristic)
		{
			ScriptHeuristicDescriptor = null;
			ScriptHeuristicDescriptorAction = null;
			return Assign(scriptHeuristic, (a, v) => a.ScriptHeuristicValue = v);
		}

		public SignificantTermsAggregationDescriptor<T> ScriptHeuristic(Aggregations.ScriptedHeuristicDescriptor descriptor)
		{
			ScriptHeuristicValue = null;
			ScriptHeuristicDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.ScriptHeuristicDescriptor = v);
		}

		public SignificantTermsAggregationDescriptor<T> ScriptHeuristic(Action<Aggregations.ScriptedHeuristicDescriptor> configure)
		{
			ScriptHeuristicValue = null;
			ScriptHeuristicDescriptorAction = null;
			return Assign(configure, (a, v) => a.ScriptHeuristicDescriptorAction = v);
		}

		public SignificantTermsAggregationDescriptor<T> ShardMinDocCount(long? shardMinDocCount) => Assign(shardMinDocCount, (a, v) => a.ShardMinDocCountValue = v);
		public SignificantTermsAggregationDescriptor<T> ShardSize(int? shardSize) => Assign(shardSize, (a, v) => a.ShardSizeValue = v);
		public SignificantTermsAggregationDescriptor<T> Size(int? size) => Assign(size, (a, v) => a.SizeValue = v);
		public SignificantTermsAggregationDescriptor<T> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
		{
			AggregationsDescriptor = null;
			AggregationsDescriptorAction = null;
			return Assign(aggregations, (a, v) => a.AggregationsValue = v);
		}

		public SignificantTermsAggregationDescriptor<T> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<T> descriptor)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.AggregationsDescriptor = v);
		}

		public SignificantTermsAggregationDescriptor<T> Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<T>> configure)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			return Assign(configure, (a, v) => a.AggregationsDescriptorAction = v);
		}

		public SignificantTermsAggregationDescriptor<T> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("significant_terms");
			writer.WriteStartObject();
			if (BackgroundFilterDescriptor is not null)
			{
				writer.WritePropertyName("background_filter");
				JsonSerializer.Serialize(writer, BackgroundFilterDescriptor, options);
			}
			else if (BackgroundFilterDescriptorAction is not null)
			{
				writer.WritePropertyName("background_filter");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<T>(BackgroundFilterDescriptorAction), options);
			}
			else if (BackgroundFilterValue is not null)
			{
				writer.WritePropertyName("background_filter");
				JsonSerializer.Serialize(writer, BackgroundFilterValue, options);
			}

			if (ChiSquareDescriptor is not null)
			{
				writer.WritePropertyName("chi_square");
				JsonSerializer.Serialize(writer, ChiSquareDescriptor, options);
			}
			else if (ChiSquareDescriptorAction is not null)
			{
				writer.WritePropertyName("chi_square");
				JsonSerializer.Serialize(writer, new Aggregations.ChiSquareHeuristicDescriptor(ChiSquareDescriptorAction), options);
			}
			else if (ChiSquareValue is not null)
			{
				writer.WritePropertyName("chi_square");
				JsonSerializer.Serialize(writer, ChiSquareValue, options);
			}

			if (ExcludeValue is not null)
			{
				writer.WritePropertyName("exclude");
				JsonSerializer.Serialize(writer, ExcludeValue, options);
			}

			if (ExecutionHintValue is not null)
			{
				writer.WritePropertyName("execution_hint");
				JsonSerializer.Serialize(writer, ExecutionHintValue, options);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (GndDescriptor is not null)
			{
				writer.WritePropertyName("gnd");
				JsonSerializer.Serialize(writer, GndDescriptor, options);
			}
			else if (GndDescriptorAction is not null)
			{
				writer.WritePropertyName("gnd");
				JsonSerializer.Serialize(writer, new Aggregations.GoogleNormalizedDistanceHeuristicDescriptor(GndDescriptorAction), options);
			}
			else if (GndValue is not null)
			{
				writer.WritePropertyName("gnd");
				JsonSerializer.Serialize(writer, GndValue, options);
			}

			if (!string.IsNullOrEmpty(IncludeValue))
			{
				writer.WritePropertyName("include");
				writer.WriteStringValue(IncludeValue);
			}

			if (MinDocCountValue.HasValue)
			{
				writer.WritePropertyName("min_doc_count");
				writer.WriteNumberValue(MinDocCountValue.Value);
			}

			if (MutualInformationDescriptor is not null)
			{
				writer.WritePropertyName("mutual_information");
				JsonSerializer.Serialize(writer, MutualInformationDescriptor, options);
			}
			else if (MutualInformationDescriptorAction is not null)
			{
				writer.WritePropertyName("mutual_information");
				JsonSerializer.Serialize(writer, new Aggregations.MutualInformationHeuristicDescriptor(MutualInformationDescriptorAction), options);
			}
			else if (MutualInformationValue is not null)
			{
				writer.WritePropertyName("mutual_information");
				JsonSerializer.Serialize(writer, MutualInformationValue, options);
			}

			if (PercentageDescriptor is not null)
			{
				writer.WritePropertyName("percentage");
				JsonSerializer.Serialize(writer, PercentageDescriptor, options);
			}
			else if (PercentageDescriptorAction is not null)
			{
				writer.WritePropertyName("percentage");
				JsonSerializer.Serialize(writer, new Aggregations.PercentageScoreHeuristicDescriptor(PercentageDescriptorAction), options);
			}
			else if (PercentageValue is not null)
			{
				writer.WritePropertyName("percentage");
				JsonSerializer.Serialize(writer, PercentageValue, options);
			}

			if (ScriptHeuristicDescriptor is not null)
			{
				writer.WritePropertyName("script_heuristic");
				JsonSerializer.Serialize(writer, ScriptHeuristicDescriptor, options);
			}
			else if (ScriptHeuristicDescriptorAction is not null)
			{
				writer.WritePropertyName("script_heuristic");
				JsonSerializer.Serialize(writer, new Aggregations.ScriptedHeuristicDescriptor(ScriptHeuristicDescriptorAction), options);
			}
			else if (ScriptHeuristicValue is not null)
			{
				writer.WritePropertyName("script_heuristic");
				JsonSerializer.Serialize(writer, ScriptHeuristicValue, options);
			}

			if (ShardMinDocCountValue.HasValue)
			{
				writer.WritePropertyName("shard_min_doc_count");
				writer.WriteNumberValue(ShardMinDocCountValue.Value);
			}

			if (ShardSizeValue.HasValue)
			{
				writer.WritePropertyName("shard_size");
				writer.WriteNumberValue(ShardSizeValue.Value);
			}

			if (SizeValue.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(SizeValue.Value);
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
				JsonSerializer.Serialize(writer, new AggregationContainerDescriptor<T>(AggregationsDescriptorAction), options);
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