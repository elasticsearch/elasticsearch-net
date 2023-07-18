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

using System;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Elastic.Clients.Elasticsearch.Core;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;

namespace Elastic.Clients.Elasticsearch.Mapping;

[JsonConverter(typeof(DynamicMappingConverter))]
public enum DynamicMapping
{
	[EnumMember(Value = "true")]
	True,
	[EnumMember(Value = "strict")]
	Strict,
	[EnumMember(Value = "runtime")]
	Runtime,
	[EnumMember(Value = "false")]
	False
}

internal sealed class DynamicMappingConverter : JsonConverter<DynamicMapping>
{
	public override DynamicMapping Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "true":
				return DynamicMapping.True;
			case "strict":
				return DynamicMapping.Strict;
			case "runtime":
				return DynamicMapping.Runtime;
			case "false":
				return DynamicMapping.False;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, DynamicMapping value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case DynamicMapping.True:
				writer.WriteStringValue("true");
				return;
			case DynamicMapping.Strict:
				writer.WriteStringValue("strict");
				return;
			case DynamicMapping.Runtime:
				writer.WriteStringValue("runtime");
				return;
			case DynamicMapping.False:
				writer.WriteStringValue("false");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(FieldTypeConverter))]
public enum FieldType
{
	[EnumMember(Value = "token_count")]
	TokenCount,
	[EnumMember(Value = "text")]
	Text,
	[EnumMember(Value = "short")]
	Short,
	[EnumMember(Value = "shape")]
	Shape,
	[EnumMember(Value = "search_as_you_type")]
	SearchAsYouType,
	[EnumMember(Value = "scaled_float")]
	ScaledFloat,
	[EnumMember(Value = "rank_features")]
	RankFeatures,
	[EnumMember(Value = "rank_feature")]
	RankFeature,
	[EnumMember(Value = "percolator")]
	Percolator,
	[EnumMember(Value = "object")]
	Object,
	[EnumMember(Value = "none")]
	None,
	[EnumMember(Value = "nested")]
	Nested,
	[EnumMember(Value = "murmur3")]
	Murmur3,
	[EnumMember(Value = "match_only_text")]
	MatchOnlyText,
	[EnumMember(Value = "long_range")]
	LongRange,
	[EnumMember(Value = "long")]
	Long,
	[EnumMember(Value = "keyword")]
	Keyword,
	[EnumMember(Value = "join")]
	Join,
	[EnumMember(Value = "ip_range")]
	IpRange,
	[EnumMember(Value = "ip")]
	Ip,
	[EnumMember(Value = "integer_range")]
	IntegerRange,
	[EnumMember(Value = "integer")]
	Integer,
	[EnumMember(Value = "histogram")]
	Histogram,
	[EnumMember(Value = "half_float")]
	HalfFloat,
	[EnumMember(Value = "geo_shape")]
	GeoShape,
	[EnumMember(Value = "geo_point")]
	GeoPoint,
	[EnumMember(Value = "float_range")]
	FloatRange,
	[EnumMember(Value = "float")]
	Float,
	[EnumMember(Value = "flattened")]
	Flattened,
	[EnumMember(Value = "double_range")]
	DoubleRange,
	[EnumMember(Value = "double")]
	Double,
	[EnumMember(Value = "dense_vector")]
	DenseVector,
	[EnumMember(Value = "date_range")]
	DateRange,
	[EnumMember(Value = "date_nanos")]
	DateNanos,
	[EnumMember(Value = "date")]
	Date,
	[EnumMember(Value = "constant_keyword")]
	ConstantKeyword,
	[EnumMember(Value = "completion")]
	Completion,
	[EnumMember(Value = "byte")]
	Byte,
	[EnumMember(Value = "boolean")]
	Boolean,
	[EnumMember(Value = "binary")]
	Binary,
	[EnumMember(Value = "alias")]
	Alias,
	[EnumMember(Value = "aggregate_metric_double")]
	AggregateMetricDouble
}

internal sealed class FieldTypeConverter : JsonConverter<FieldType>
{
	public override FieldType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "token_count":
				return FieldType.TokenCount;
			case "text":
				return FieldType.Text;
			case "short":
				return FieldType.Short;
			case "shape":
				return FieldType.Shape;
			case "search_as_you_type":
				return FieldType.SearchAsYouType;
			case "scaled_float":
				return FieldType.ScaledFloat;
			case "rank_features":
				return FieldType.RankFeatures;
			case "rank_feature":
				return FieldType.RankFeature;
			case "percolator":
				return FieldType.Percolator;
			case "object":
				return FieldType.Object;
			case "none":
				return FieldType.None;
			case "nested":
				return FieldType.Nested;
			case "murmur3":
				return FieldType.Murmur3;
			case "match_only_text":
				return FieldType.MatchOnlyText;
			case "long_range":
				return FieldType.LongRange;
			case "long":
				return FieldType.Long;
			case "keyword":
				return FieldType.Keyword;
			case "join":
				return FieldType.Join;
			case "ip_range":
				return FieldType.IpRange;
			case "ip":
				return FieldType.Ip;
			case "integer_range":
				return FieldType.IntegerRange;
			case "integer":
				return FieldType.Integer;
			case "histogram":
				return FieldType.Histogram;
			case "half_float":
				return FieldType.HalfFloat;
			case "geo_shape":
				return FieldType.GeoShape;
			case "geo_point":
				return FieldType.GeoPoint;
			case "float_range":
				return FieldType.FloatRange;
			case "float":
				return FieldType.Float;
			case "flattened":
				return FieldType.Flattened;
			case "double_range":
				return FieldType.DoubleRange;
			case "double":
				return FieldType.Double;
			case "dense_vector":
				return FieldType.DenseVector;
			case "date_range":
				return FieldType.DateRange;
			case "date_nanos":
				return FieldType.DateNanos;
			case "date":
				return FieldType.Date;
			case "constant_keyword":
				return FieldType.ConstantKeyword;
			case "completion":
				return FieldType.Completion;
			case "byte":
				return FieldType.Byte;
			case "boolean":
				return FieldType.Boolean;
			case "binary":
				return FieldType.Binary;
			case "alias":
				return FieldType.Alias;
			case "aggregate_metric_double":
				return FieldType.AggregateMetricDouble;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, FieldType value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case FieldType.TokenCount:
				writer.WriteStringValue("token_count");
				return;
			case FieldType.Text:
				writer.WriteStringValue("text");
				return;
			case FieldType.Short:
				writer.WriteStringValue("short");
				return;
			case FieldType.Shape:
				writer.WriteStringValue("shape");
				return;
			case FieldType.SearchAsYouType:
				writer.WriteStringValue("search_as_you_type");
				return;
			case FieldType.ScaledFloat:
				writer.WriteStringValue("scaled_float");
				return;
			case FieldType.RankFeatures:
				writer.WriteStringValue("rank_features");
				return;
			case FieldType.RankFeature:
				writer.WriteStringValue("rank_feature");
				return;
			case FieldType.Percolator:
				writer.WriteStringValue("percolator");
				return;
			case FieldType.Object:
				writer.WriteStringValue("object");
				return;
			case FieldType.None:
				writer.WriteStringValue("none");
				return;
			case FieldType.Nested:
				writer.WriteStringValue("nested");
				return;
			case FieldType.Murmur3:
				writer.WriteStringValue("murmur3");
				return;
			case FieldType.MatchOnlyText:
				writer.WriteStringValue("match_only_text");
				return;
			case FieldType.LongRange:
				writer.WriteStringValue("long_range");
				return;
			case FieldType.Long:
				writer.WriteStringValue("long");
				return;
			case FieldType.Keyword:
				writer.WriteStringValue("keyword");
				return;
			case FieldType.Join:
				writer.WriteStringValue("join");
				return;
			case FieldType.IpRange:
				writer.WriteStringValue("ip_range");
				return;
			case FieldType.Ip:
				writer.WriteStringValue("ip");
				return;
			case FieldType.IntegerRange:
				writer.WriteStringValue("integer_range");
				return;
			case FieldType.Integer:
				writer.WriteStringValue("integer");
				return;
			case FieldType.Histogram:
				writer.WriteStringValue("histogram");
				return;
			case FieldType.HalfFloat:
				writer.WriteStringValue("half_float");
				return;
			case FieldType.GeoShape:
				writer.WriteStringValue("geo_shape");
				return;
			case FieldType.GeoPoint:
				writer.WriteStringValue("geo_point");
				return;
			case FieldType.FloatRange:
				writer.WriteStringValue("float_range");
				return;
			case FieldType.Float:
				writer.WriteStringValue("float");
				return;
			case FieldType.Flattened:
				writer.WriteStringValue("flattened");
				return;
			case FieldType.DoubleRange:
				writer.WriteStringValue("double_range");
				return;
			case FieldType.Double:
				writer.WriteStringValue("double");
				return;
			case FieldType.DenseVector:
				writer.WriteStringValue("dense_vector");
				return;
			case FieldType.DateRange:
				writer.WriteStringValue("date_range");
				return;
			case FieldType.DateNanos:
				writer.WriteStringValue("date_nanos");
				return;
			case FieldType.Date:
				writer.WriteStringValue("date");
				return;
			case FieldType.ConstantKeyword:
				writer.WriteStringValue("constant_keyword");
				return;
			case FieldType.Completion:
				writer.WriteStringValue("completion");
				return;
			case FieldType.Byte:
				writer.WriteStringValue("byte");
				return;
			case FieldType.Boolean:
				writer.WriteStringValue("boolean");
				return;
			case FieldType.Binary:
				writer.WriteStringValue("binary");
				return;
			case FieldType.Alias:
				writer.WriteStringValue("alias");
				return;
			case FieldType.AggregateMetricDouble:
				writer.WriteStringValue("aggregate_metric_double");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(GeoOrientationConverter))]
public enum GeoOrientation
{
	[EnumMember(Value = "right")]
	Right,
	[EnumMember(Value = "left")]
	Left
}

internal sealed class GeoOrientationConverter : JsonConverter<GeoOrientation>
{
	public override GeoOrientation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "right":
			case "RIGHT":
			case "counterclockwise":
			case "ccw":
				return GeoOrientation.Right;
			case "left":
			case "LEFT":
			case "clockwise":
			case "cw":
				return GeoOrientation.Left;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, GeoOrientation value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case GeoOrientation.Right:
				writer.WriteStringValue("right");
				return;
			case GeoOrientation.Left:
				writer.WriteStringValue("left");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(GeoStrategyConverter))]
public enum GeoStrategy
{
	[EnumMember(Value = "term")]
	Term,
	[EnumMember(Value = "recursive")]
	Recursive
}

internal sealed class GeoStrategyConverter : JsonConverter<GeoStrategy>
{
	public override GeoStrategy Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "term":
				return GeoStrategy.Term;
			case "recursive":
				return GeoStrategy.Recursive;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, GeoStrategy value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case GeoStrategy.Term:
				writer.WriteStringValue("term");
				return;
			case GeoStrategy.Recursive:
				writer.WriteStringValue("recursive");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(IndexOptionsConverter))]
public enum IndexOptions
{
	[EnumMember(Value = "positions")]
	Positions,
	[EnumMember(Value = "offsets")]
	Offsets,
	[EnumMember(Value = "freqs")]
	Freqs,
	[EnumMember(Value = "docs")]
	Docs
}

internal sealed class IndexOptionsConverter : JsonConverter<IndexOptions>
{
	public override IndexOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "positions":
				return IndexOptions.Positions;
			case "offsets":
				return IndexOptions.Offsets;
			case "freqs":
				return IndexOptions.Freqs;
			case "docs":
				return IndexOptions.Docs;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, IndexOptions value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case IndexOptions.Positions:
				writer.WriteStringValue("positions");
				return;
			case IndexOptions.Offsets:
				writer.WriteStringValue("offsets");
				return;
			case IndexOptions.Freqs:
				writer.WriteStringValue("freqs");
				return;
			case IndexOptions.Docs:
				writer.WriteStringValue("docs");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(MatchTypeConverter))]
public enum MatchType
{
	[EnumMember(Value = "simple")]
	Simple,
	[EnumMember(Value = "regex")]
	Regex
}

internal sealed class MatchTypeConverter : JsonConverter<MatchType>
{
	public override MatchType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "simple":
				return MatchType.Simple;
			case "regex":
				return MatchType.Regex;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, MatchType value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case MatchType.Simple:
				writer.WriteStringValue("simple");
				return;
			case MatchType.Regex:
				writer.WriteStringValue("regex");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(OnScriptErrorConverter))]
public enum OnScriptError
{
	[EnumMember(Value = "fail")]
	Fail,
	[EnumMember(Value = "continue")]
	Continue
}

internal sealed class OnScriptErrorConverter : JsonConverter<OnScriptError>
{
	public override OnScriptError Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "fail":
				return OnScriptError.Fail;
			case "continue":
				return OnScriptError.Continue;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, OnScriptError value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case OnScriptError.Fail:
				writer.WriteStringValue("fail");
				return;
			case OnScriptError.Continue:
				writer.WriteStringValue("continue");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(RuntimeFieldTypeConverter))]
public enum RuntimeFieldType
{
	[EnumMember(Value = "lookup")]
	Lookup,
	[EnumMember(Value = "long")]
	Long,
	[EnumMember(Value = "keyword")]
	Keyword,
	[EnumMember(Value = "ip")]
	Ip,
	[EnumMember(Value = "geo_point")]
	GeoPoint,
	[EnumMember(Value = "double")]
	Double,
	[EnumMember(Value = "date")]
	Date,
	[EnumMember(Value = "boolean")]
	Boolean
}

internal sealed class RuntimeFieldTypeConverter : JsonConverter<RuntimeFieldType>
{
	public override RuntimeFieldType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "lookup":
				return RuntimeFieldType.Lookup;
			case "long":
				return RuntimeFieldType.Long;
			case "keyword":
				return RuntimeFieldType.Keyword;
			case "ip":
				return RuntimeFieldType.Ip;
			case "geo_point":
				return RuntimeFieldType.GeoPoint;
			case "double":
				return RuntimeFieldType.Double;
			case "date":
				return RuntimeFieldType.Date;
			case "boolean":
				return RuntimeFieldType.Boolean;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, RuntimeFieldType value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case RuntimeFieldType.Lookup:
				writer.WriteStringValue("lookup");
				return;
			case RuntimeFieldType.Long:
				writer.WriteStringValue("long");
				return;
			case RuntimeFieldType.Keyword:
				writer.WriteStringValue("keyword");
				return;
			case RuntimeFieldType.Ip:
				writer.WriteStringValue("ip");
				return;
			case RuntimeFieldType.GeoPoint:
				writer.WriteStringValue("geo_point");
				return;
			case RuntimeFieldType.Double:
				writer.WriteStringValue("double");
				return;
			case RuntimeFieldType.Date:
				writer.WriteStringValue("date");
				return;
			case RuntimeFieldType.Boolean:
				writer.WriteStringValue("boolean");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(SourceFieldModeConverter))]
public enum SourceFieldMode
{
	/// <summary>
	/// <para>Instead of storing source documents on disk exactly as you send them,<br/> Elasticsearch can reconstruct source content on the fly upon retrieval.</para>
	/// </summary>
	[EnumMember(Value = "synthetic")]
	Synthetic,
	[EnumMember(Value = "stored")]
	Stored,
	[EnumMember(Value = "disabled")]
	Disabled
}

internal sealed class SourceFieldModeConverter : JsonConverter<SourceFieldMode>
{
	public override SourceFieldMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "synthetic":
				return SourceFieldMode.Synthetic;
			case "stored":
				return SourceFieldMode.Stored;
			case "disabled":
				return SourceFieldMode.Disabled;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, SourceFieldMode value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case SourceFieldMode.Synthetic:
				writer.WriteStringValue("synthetic");
				return;
			case SourceFieldMode.Stored:
				writer.WriteStringValue("stored");
				return;
			case SourceFieldMode.Disabled:
				writer.WriteStringValue("disabled");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(TermVectorOptionConverter))]
public enum TermVectorOption
{
	[EnumMember(Value = "yes")]
	Yes,
	[EnumMember(Value = "with_positions_payloads")]
	WithPositionsPayloads,
	[EnumMember(Value = "with_positions_offsets_payloads")]
	WithPositionsOffsetsPayloads,
	[EnumMember(Value = "with_positions_offsets")]
	WithPositionsOffsets,
	[EnumMember(Value = "with_positions")]
	WithPositions,
	[EnumMember(Value = "with_offsets")]
	WithOffsets,
	[EnumMember(Value = "no")]
	No
}

internal sealed class TermVectorOptionConverter : JsonConverter<TermVectorOption>
{
	public override TermVectorOption Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "yes":
				return TermVectorOption.Yes;
			case "with_positions_payloads":
				return TermVectorOption.WithPositionsPayloads;
			case "with_positions_offsets_payloads":
				return TermVectorOption.WithPositionsOffsetsPayloads;
			case "with_positions_offsets":
				return TermVectorOption.WithPositionsOffsets;
			case "with_positions":
				return TermVectorOption.WithPositions;
			case "with_offsets":
				return TermVectorOption.WithOffsets;
			case "no":
				return TermVectorOption.No;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, TermVectorOption value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case TermVectorOption.Yes:
				writer.WriteStringValue("yes");
				return;
			case TermVectorOption.WithPositionsPayloads:
				writer.WriteStringValue("with_positions_payloads");
				return;
			case TermVectorOption.WithPositionsOffsetsPayloads:
				writer.WriteStringValue("with_positions_offsets_payloads");
				return;
			case TermVectorOption.WithPositionsOffsets:
				writer.WriteStringValue("with_positions_offsets");
				return;
			case TermVectorOption.WithPositions:
				writer.WriteStringValue("with_positions");
				return;
			case TermVectorOption.WithOffsets:
				writer.WriteStringValue("with_offsets");
				return;
			case TermVectorOption.No:
				writer.WriteStringValue("no");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(TimeSeriesMetricTypeConverter))]
public enum TimeSeriesMetricType
{
	[EnumMember(Value = "summary")]
	Summary,
	[EnumMember(Value = "position")]
	Position,
	[EnumMember(Value = "histogram")]
	Histogram,
	[EnumMember(Value = "gauge")]
	Gauge,
	[EnumMember(Value = "counter")]
	Counter
}

internal sealed class TimeSeriesMetricTypeConverter : JsonConverter<TimeSeriesMetricType>
{
	public override TimeSeriesMetricType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "summary":
				return TimeSeriesMetricType.Summary;
			case "position":
				return TimeSeriesMetricType.Position;
			case "histogram":
				return TimeSeriesMetricType.Histogram;
			case "gauge":
				return TimeSeriesMetricType.Gauge;
			case "counter":
				return TimeSeriesMetricType.Counter;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, TimeSeriesMetricType value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case TimeSeriesMetricType.Summary:
				writer.WriteStringValue("summary");
				return;
			case TimeSeriesMetricType.Position:
				writer.WriteStringValue("position");
				return;
			case TimeSeriesMetricType.Histogram:
				writer.WriteStringValue("histogram");
				return;
			case TimeSeriesMetricType.Gauge:
				writer.WriteStringValue("gauge");
				return;
			case TimeSeriesMetricType.Counter:
				writer.WriteStringValue("counter");
				return;
		}

		writer.WriteNullValue();
	}
}