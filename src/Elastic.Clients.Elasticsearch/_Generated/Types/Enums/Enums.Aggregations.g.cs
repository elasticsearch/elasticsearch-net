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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using Elastic.Transport;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	[JsonConverter(typeof(CalendarIntervalConverter))]
	public enum CalendarInterval
	{
		[EnumMember(Value = "year")]
		Year,
		[EnumMember(Value = "week")]
		Week,
		[EnumMember(Value = "second")]
		Second,
		[EnumMember(Value = "quarter")]
		Quarter,
		[EnumMember(Value = "month")]
		Month,
		[EnumMember(Value = "minute")]
		Minute,
		[EnumMember(Value = "hour")]
		Hour,
		[EnumMember(Value = "day")]
		Day
	}

	internal sealed class CalendarIntervalConverter : JsonConverter<CalendarInterval>
	{
		public override CalendarInterval Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "year":
					return CalendarInterval.Year;
				case "week":
					return CalendarInterval.Week;
				case "second":
					return CalendarInterval.Second;
				case "quarter":
					return CalendarInterval.Quarter;
				case "month":
					return CalendarInterval.Month;
				case "minute":
					return CalendarInterval.Minute;
				case "hour":
					return CalendarInterval.Hour;
				case "day":
					return CalendarInterval.Day;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, CalendarInterval value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case CalendarInterval.Year:
					writer.WriteStringValue("year");
					return;
				case CalendarInterval.Week:
					writer.WriteStringValue("week");
					return;
				case CalendarInterval.Second:
					writer.WriteStringValue("second");
					return;
				case CalendarInterval.Quarter:
					writer.WriteStringValue("quarter");
					return;
				case CalendarInterval.Month:
					writer.WriteStringValue("month");
					return;
				case CalendarInterval.Minute:
					writer.WriteStringValue("minute");
					return;
				case CalendarInterval.Hour:
					writer.WriteStringValue("hour");
					return;
				case CalendarInterval.Day:
					writer.WriteStringValue("day");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(MinimumIntervalConverter))]
	public enum MinimumInterval
	{
		[EnumMember(Value = "year")]
		Year,
		[EnumMember(Value = "second")]
		Second,
		[EnumMember(Value = "month")]
		Month,
		[EnumMember(Value = "minute")]
		Minute,
		[EnumMember(Value = "hour")]
		Hour,
		[EnumMember(Value = "day")]
		Day
	}

	internal sealed class MinimumIntervalConverter : JsonConverter<MinimumInterval>
	{
		public override MinimumInterval Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "year":
					return MinimumInterval.Year;
				case "second":
					return MinimumInterval.Second;
				case "month":
					return MinimumInterval.Month;
				case "minute":
					return MinimumInterval.Minute;
				case "hour":
					return MinimumInterval.Hour;
				case "day":
					return MinimumInterval.Day;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, MinimumInterval value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case MinimumInterval.Year:
					writer.WriteStringValue("year");
					return;
				case MinimumInterval.Second:
					writer.WriteStringValue("second");
					return;
				case MinimumInterval.Month:
					writer.WriteStringValue("month");
					return;
				case MinimumInterval.Minute:
					writer.WriteStringValue("minute");
					return;
				case MinimumInterval.Hour:
					writer.WriteStringValue("hour");
					return;
				case MinimumInterval.Day:
					writer.WriteStringValue("day");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(MissingOrderConverter))]
	public enum MissingOrder
	{
		[EnumMember(Value = "last")]
		Last,
		[EnumMember(Value = "first")]
		First,
		[EnumMember(Value = "default")]
		Default
	}

	internal sealed class MissingOrderConverter : JsonConverter<MissingOrder>
	{
		public override MissingOrder Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "last":
					return MissingOrder.Last;
				case "first":
					return MissingOrder.First;
				case "default":
					return MissingOrder.Default;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, MissingOrder value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case MissingOrder.Last:
					writer.WriteStringValue("last");
					return;
				case MissingOrder.First:
					writer.WriteStringValue("first");
					return;
				case MissingOrder.Default:
					writer.WriteStringValue("default");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(TermsAggregationCollectModeConverter))]
	public enum TermsAggregationCollectMode
	{
		[EnumMember(Value = "depth_first")]
		DepthFirst,
		[EnumMember(Value = "breadth_first")]
		BreadthFirst
	}

	internal sealed class TermsAggregationCollectModeConverter : JsonConverter<TermsAggregationCollectMode>
	{
		public override TermsAggregationCollectMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "depth_first":
					return TermsAggregationCollectMode.DepthFirst;
				case "breadth_first":
					return TermsAggregationCollectMode.BreadthFirst;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, TermsAggregationCollectMode value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case TermsAggregationCollectMode.DepthFirst:
					writer.WriteStringValue("depth_first");
					return;
				case TermsAggregationCollectMode.BreadthFirst:
					writer.WriteStringValue("breadth_first");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(TermsAggregationExecutionHintConverter))]
	public enum TermsAggregationExecutionHint
	{
		[EnumMember(Value = "map")]
		Map,
		[EnumMember(Value = "global_ordinals_low_cardinality")]
		GlobalOrdinalsLowCardinality,
		[EnumMember(Value = "global_ordinals_hash")]
		GlobalOrdinalsHash,
		[EnumMember(Value = "global_ordinals")]
		GlobalOrdinals
	}

	internal sealed class TermsAggregationExecutionHintConverter : JsonConverter<TermsAggregationExecutionHint>
	{
		public override TermsAggregationExecutionHint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "map":
					return TermsAggregationExecutionHint.Map;
				case "global_ordinals_low_cardinality":
					return TermsAggregationExecutionHint.GlobalOrdinalsLowCardinality;
				case "global_ordinals_hash":
					return TermsAggregationExecutionHint.GlobalOrdinalsHash;
				case "global_ordinals":
					return TermsAggregationExecutionHint.GlobalOrdinals;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, TermsAggregationExecutionHint value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case TermsAggregationExecutionHint.Map:
					writer.WriteStringValue("map");
					return;
				case TermsAggregationExecutionHint.GlobalOrdinalsLowCardinality:
					writer.WriteStringValue("global_ordinals_low_cardinality");
					return;
				case TermsAggregationExecutionHint.GlobalOrdinalsHash:
					writer.WriteStringValue("global_ordinals_hash");
					return;
				case TermsAggregationExecutionHint.GlobalOrdinals:
					writer.WriteStringValue("global_ordinals");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(ValueTypeConverter))]
	public enum ValueType
	{
		[EnumMember(Value = "string")]
		String,
		[EnumMember(Value = "numeric")]
		Numeric,
		[EnumMember(Value = "number")]
		Number,
		[EnumMember(Value = "long")]
		Long,
		[EnumMember(Value = "ip")]
		Ip,
		[EnumMember(Value = "geo_point")]
		GeoPoint,
		[EnumMember(Value = "double")]
		Double,
		[EnumMember(Value = "date_nanos")]
		DateNanos,
		[EnumMember(Value = "date")]
		Date,
		[EnumMember(Value = "boolean")]
		Boolean
	}

	internal sealed class ValueTypeConverter : JsonConverter<ValueType>
	{
		public override ValueType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "string":
					return ValueType.String;
				case "numeric":
					return ValueType.Numeric;
				case "number":
					return ValueType.Number;
				case "long":
					return ValueType.Long;
				case "ip":
					return ValueType.Ip;
				case "geo_point":
					return ValueType.GeoPoint;
				case "double":
					return ValueType.Double;
				case "date_nanos":
					return ValueType.DateNanos;
				case "date":
					return ValueType.Date;
				case "boolean":
					return ValueType.Boolean;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, ValueType value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case ValueType.String:
					writer.WriteStringValue("string");
					return;
				case ValueType.Numeric:
					writer.WriteStringValue("numeric");
					return;
				case ValueType.Number:
					writer.WriteStringValue("number");
					return;
				case ValueType.Long:
					writer.WriteStringValue("long");
					return;
				case ValueType.Ip:
					writer.WriteStringValue("ip");
					return;
				case ValueType.GeoPoint:
					writer.WriteStringValue("geo_point");
					return;
				case ValueType.Double:
					writer.WriteStringValue("double");
					return;
				case ValueType.DateNanos:
					writer.WriteStringValue("date_nanos");
					return;
				case ValueType.Date:
					writer.WriteStringValue("date");
					return;
				case ValueType.Boolean:
					writer.WriteStringValue("boolean");
					return;
			}

			writer.WriteNullValue();
		}
	}
}