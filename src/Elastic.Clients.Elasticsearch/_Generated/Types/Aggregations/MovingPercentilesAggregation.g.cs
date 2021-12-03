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
	public partial class MovingPercentilesAggregation : Aggregations.PipelineAggregationBase, IAggregationContainerVariant
	{
		[JsonConstructor]
		public MovingPercentilesAggregation(string name) : base(name)
		{
		}

		[JsonIgnore]
		string Aggregations.IAggregationContainerVariant.AggregationContainerVariantName => "moving_percentiles";
		[JsonInclude]
		[JsonPropertyName("window")]
		public int? Window { get; set; }

		[JsonInclude]
		[JsonPropertyName("shift")]
		public int? Shift { get; set; }

		[JsonInclude]
		[JsonPropertyName("keyed")]
		public bool? Keyed { get; set; }
	}

	public sealed partial class MovingPercentilesAggregationDescriptor : DescriptorBase<MovingPercentilesAggregationDescriptor>
	{
		public MovingPercentilesAggregationDescriptor()
		{
		}

		internal MovingPercentilesAggregationDescriptor(Action<MovingPercentilesAggregationDescriptor> configure) => configure.Invoke(this);
		internal int? WindowValue { get; private set; }

		internal int? ShiftValue { get; private set; }

		internal bool? KeyedValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPathValue { get; private set; }

		internal string? FormatValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicyValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		public MovingPercentilesAggregationDescriptor Window(int? window) => Assign(window, (a, v) => a.WindowValue = v);
		public MovingPercentilesAggregationDescriptor Shift(int? shift) => Assign(shift, (a, v) => a.ShiftValue = v);
		public MovingPercentilesAggregationDescriptor Keyed(bool? keyed = true) => Assign(keyed, (a, v) => a.KeyedValue = v);
		public MovingPercentilesAggregationDescriptor BucketsPath(Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? bucketsPath) => Assign(bucketsPath, (a, v) => a.BucketsPathValue = v);
		public MovingPercentilesAggregationDescriptor Format(string? format) => Assign(format, (a, v) => a.FormatValue = v);
		public MovingPercentilesAggregationDescriptor GapPolicy(Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? gapPolicy) => Assign(gapPolicy, (a, v) => a.GapPolicyValue = v);
		public MovingPercentilesAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("moving_percentiles");
			writer.WriteStartObject();
			if (WindowValue.HasValue)
			{
				writer.WritePropertyName("window");
				writer.WriteNumberValue(WindowValue.Value);
			}

			if (ShiftValue.HasValue)
			{
				writer.WritePropertyName("shift");
				writer.WriteNumberValue(ShiftValue.Value);
			}

			if (KeyedValue.HasValue)
			{
				writer.WritePropertyName("keyed");
				writer.WriteBooleanValue(KeyedValue.Value);
			}

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