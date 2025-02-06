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

#nullable restore

using Elastic.Clients.Elasticsearch.Core;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Rollup;

[JsonConverter(typeof(IndexingJobStateConverter))]
public enum IndexingJobState
{
	[EnumMember(Value = "stopping")]
	Stopping,
	[EnumMember(Value = "stopped")]
	Stopped,
	[EnumMember(Value = "started")]
	Started,
	[EnumMember(Value = "indexing")]
	Indexing,
	[EnumMember(Value = "aborting")]
	Aborting
}

internal sealed partial class IndexingJobStateConverter : System.Text.Json.Serialization.JsonConverter<IndexingJobState>
{
	private static readonly System.Text.Json.JsonEncodedText MemberStopping = System.Text.Json.JsonEncodedText.Encode("stopping");
	private static readonly System.Text.Json.JsonEncodedText MemberStopped = System.Text.Json.JsonEncodedText.Encode("stopped");
	private static readonly System.Text.Json.JsonEncodedText MemberStarted = System.Text.Json.JsonEncodedText.Encode("started");
	private static readonly System.Text.Json.JsonEncodedText MemberIndexing = System.Text.Json.JsonEncodedText.Encode("indexing");
	private static readonly System.Text.Json.JsonEncodedText MemberAborting = System.Text.Json.JsonEncodedText.Encode("aborting");

	public override IndexingJobState Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.String);
		if (reader.ValueTextEquals(MemberStopping))
		{
			return IndexingJobState.Stopping;
		}

		if (reader.ValueTextEquals(MemberStopped))
		{
			return IndexingJobState.Stopped;
		}

		if (reader.ValueTextEquals(MemberStarted))
		{
			return IndexingJobState.Started;
		}

		if (reader.ValueTextEquals(MemberIndexing))
		{
			return IndexingJobState.Indexing;
		}

		if (reader.ValueTextEquals(MemberAborting))
		{
			return IndexingJobState.Aborting;
		}

		var value = reader.GetString()!;
		if (string.Equals(value, MemberStopping.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return IndexingJobState.Stopping;
		}

		if (string.Equals(value, MemberStopped.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return IndexingJobState.Stopped;
		}

		if (string.Equals(value, MemberStarted.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return IndexingJobState.Started;
		}

		if (string.Equals(value, MemberIndexing.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return IndexingJobState.Indexing;
		}

		if (string.Equals(value, MemberAborting.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return IndexingJobState.Aborting;
		}

		throw new System.Text.Json.JsonException($"Unknown member '{value}' for enum '{nameof(IndexingJobState)}'.");
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, IndexingJobState value, System.Text.Json.JsonSerializerOptions options)
	{
		switch (value)
		{
			case IndexingJobState.Stopping:
				writer.WriteStringValue(MemberStopping);
				break;
			case IndexingJobState.Stopped:
				writer.WriteStringValue(MemberStopped);
				break;
			case IndexingJobState.Started:
				writer.WriteStringValue(MemberStarted);
				break;
			case IndexingJobState.Indexing:
				writer.WriteStringValue(MemberIndexing);
				break;
			case IndexingJobState.Aborting:
				writer.WriteStringValue(MemberAborting);
				break;
			default:
				throw new System.Text.Json.JsonException($"Invalid value '{value}' for enum '{nameof(IndexingJobState)}'.");
		}
	}
}

[JsonConverter(typeof(MetricConverter))]
public enum Metric
{
	[EnumMember(Value = "value_count")]
	ValueCount,
	[EnumMember(Value = "sum")]
	Sum,
	[EnumMember(Value = "min")]
	Min,
	[EnumMember(Value = "max")]
	Max,
	[EnumMember(Value = "avg")]
	Avg
}

internal sealed partial class MetricConverter : System.Text.Json.Serialization.JsonConverter<Metric>
{
	private static readonly System.Text.Json.JsonEncodedText MemberValueCount = System.Text.Json.JsonEncodedText.Encode("value_count");
	private static readonly System.Text.Json.JsonEncodedText MemberSum = System.Text.Json.JsonEncodedText.Encode("sum");
	private static readonly System.Text.Json.JsonEncodedText MemberMin = System.Text.Json.JsonEncodedText.Encode("min");
	private static readonly System.Text.Json.JsonEncodedText MemberMax = System.Text.Json.JsonEncodedText.Encode("max");
	private static readonly System.Text.Json.JsonEncodedText MemberAvg = System.Text.Json.JsonEncodedText.Encode("avg");

	public override Metric Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.String);
		if (reader.ValueTextEquals(MemberValueCount))
		{
			return Metric.ValueCount;
		}

		if (reader.ValueTextEquals(MemberSum))
		{
			return Metric.Sum;
		}

		if (reader.ValueTextEquals(MemberMin))
		{
			return Metric.Min;
		}

		if (reader.ValueTextEquals(MemberMax))
		{
			return Metric.Max;
		}

		if (reader.ValueTextEquals(MemberAvg))
		{
			return Metric.Avg;
		}

		var value = reader.GetString()!;
		if (string.Equals(value, MemberValueCount.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return Metric.ValueCount;
		}

		if (string.Equals(value, MemberSum.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return Metric.Sum;
		}

		if (string.Equals(value, MemberMin.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return Metric.Min;
		}

		if (string.Equals(value, MemberMax.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return Metric.Max;
		}

		if (string.Equals(value, MemberAvg.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return Metric.Avg;
		}

		throw new System.Text.Json.JsonException($"Unknown member '{value}' for enum '{nameof(Metric)}'.");
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, Metric value, System.Text.Json.JsonSerializerOptions options)
	{
		switch (value)
		{
			case Metric.ValueCount:
				writer.WriteStringValue(MemberValueCount);
				break;
			case Metric.Sum:
				writer.WriteStringValue(MemberSum);
				break;
			case Metric.Min:
				writer.WriteStringValue(MemberMin);
				break;
			case Metric.Max:
				writer.WriteStringValue(MemberMax);
				break;
			case Metric.Avg:
				writer.WriteStringValue(MemberAvg);
				break;
			default:
				throw new System.Text.Json.JsonException($"Invalid value '{value}' for enum '{nameof(Metric)}'.");
		}
	}
}