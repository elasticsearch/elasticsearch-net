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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	[JsonConverter(typeof(AggregateDictionaryConverter))]
	public partial class AggregateDictionary : IsAReadOnlyDictionaryBase<string, AggregateBase>
	{
		public AggregateDictionary(IReadOnlyDictionary<string, AggregateBase> backingDictionary) : base(backingDictionary)
		{
		}

		public Elastic.Clients.Elasticsearch.Aggregations.CardinalityAggregate? Cardinality(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.CardinalityAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.MedianAbsoluteDeviationAggregate? MedianAbsoluteDeviation(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.MedianAbsoluteDeviationAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.MinAggregate? Min(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.MinAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.MaxAggregate? Max(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.MaxAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.SumAggregate? Sum(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.SumAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.AvgAggregate? Avg(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.AvgAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.WeightedAvgAggregate? WeightedAvg(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.WeightedAvgAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.ValueCountAggregate? ValueCount(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.ValueCountAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.StatsAggregate? Stats(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.StatsAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.ExtendedStatsAggregate? ExtendedStats(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.ExtendedStatsAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.HistogramAggregate? Histogram(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.HistogramAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.DateHistogramAggregate? DateHistogram(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.DateHistogramAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.AutoDateHistogramAggregate? AutoDateHistogram(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.AutoDateHistogramAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.VariableWidthHistogramAggregate? VariableWidthHistogram(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.VariableWidthHistogramAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.StringTermsAggregate? StringTerms(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.StringTermsAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.LongTermsAggregate? LongTerms(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.LongTermsAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.DoubleTermsAggregate? DoubleTerms(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.DoubleTermsAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.MultiTermsAggregate? MultiTerms(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.MultiTermsAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.MissingAggregate? Missing(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.MissingAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.NestedAggregate? Nested(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.NestedAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.GlobalAggregate? Global(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.GlobalAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.FilterAggregate? Filter(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.FilterAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.ChildrenAggregate? Children(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.ChildrenAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.RangeAggregate? Range(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.RangeAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.DateRangeAggregate? DateRange(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.DateRangeAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.IpRangeAggregate? IpRange(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.IpRangeAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.FiltersAggregate? Filters(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.FiltersAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.AdjacencyMatrixAggregate? AdjacencyMatrix(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.AdjacencyMatrixAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.CompositeAggregate? Composite(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.CompositeAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.StringStatsAggregate? StringStats(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.StringStatsAggregate?>(key);
		public Elastic.Clients.Elasticsearch.Aggregations.BoxPlotAggregate? BoxPlot(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.BoxPlotAggregate?>(key);
		private TAggregate TryGet<TAggregate>(string key)
			where TAggregate : AggregateBase => BackingDictionary.TryGetValue(key, out var agg) ? agg as TAggregate : null;
	}
}