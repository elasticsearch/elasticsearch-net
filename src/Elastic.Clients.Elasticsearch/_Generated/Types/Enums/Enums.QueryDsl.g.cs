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
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	[JsonConverter(typeof(ChildScoreModeConverter))]
	public enum ChildScoreMode
	{
		Sum,
		None,
		Min,
		Max,
		Avg
	}

	public class ChildScoreModeConverter : JsonConverter<ChildScoreMode>
	{
		public override ChildScoreMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "sum":
					return ChildScoreMode.Sum;
				case "none":
					return ChildScoreMode.None;
				case "min":
					return ChildScoreMode.Min;
				case "max":
					return ChildScoreMode.Max;
				case "avg":
					return ChildScoreMode.Avg;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, ChildScoreMode value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case ChildScoreMode.Sum:
					writer.WriteStringValue("sum");
					return;
				case ChildScoreMode.None:
					writer.WriteStringValue("none");
					return;
				case ChildScoreMode.Min:
					writer.WriteStringValue("min");
					return;
				case ChildScoreMode.Max:
					writer.WriteStringValue("max");
					return;
				case ChildScoreMode.Avg:
					writer.WriteStringValue("avg");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(CombinedFieldsOperatorConverter))]
	public enum CombinedFieldsOperator
	{
		Or,
		And
	}

	public class CombinedFieldsOperatorConverter : JsonConverter<CombinedFieldsOperator>
	{
		public override CombinedFieldsOperator Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "or":
					return CombinedFieldsOperator.Or;
				case "and":
					return CombinedFieldsOperator.And;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, CombinedFieldsOperator value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case CombinedFieldsOperator.Or:
					writer.WriteStringValue("or");
					return;
				case CombinedFieldsOperator.And:
					writer.WriteStringValue("and");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(CombinedFieldsZeroTermsConverter))]
	public enum CombinedFieldsZeroTerms
	{
		None,
		All
	}

	public class CombinedFieldsZeroTermsConverter : JsonConverter<CombinedFieldsZeroTerms>
	{
		public override CombinedFieldsZeroTerms Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "none":
					return CombinedFieldsZeroTerms.None;
				case "all":
					return CombinedFieldsZeroTerms.All;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, CombinedFieldsZeroTerms value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case CombinedFieldsZeroTerms.None:
					writer.WriteStringValue("none");
					return;
				case CombinedFieldsZeroTerms.All:
					writer.WriteStringValue("all");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(FieldValueFactorModifierConverter))]
	public enum FieldValueFactorModifier
	{
		Square,
		Sqrt,
		Reciprocal,
		None,
		Log2p,
		Log1p,
		Log,
		Ln2p,
		Ln1p,
		Ln
	}

	public class FieldValueFactorModifierConverter : JsonConverter<FieldValueFactorModifier>
	{
		public override FieldValueFactorModifier Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "square":
					return FieldValueFactorModifier.Square;
				case "sqrt":
					return FieldValueFactorModifier.Sqrt;
				case "reciprocal":
					return FieldValueFactorModifier.Reciprocal;
				case "none":
					return FieldValueFactorModifier.None;
				case "log2p":
					return FieldValueFactorModifier.Log2p;
				case "log1p":
					return FieldValueFactorModifier.Log1p;
				case "log":
					return FieldValueFactorModifier.Log;
				case "ln2p":
					return FieldValueFactorModifier.Ln2p;
				case "ln1p":
					return FieldValueFactorModifier.Ln1p;
				case "ln":
					return FieldValueFactorModifier.Ln;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, FieldValueFactorModifier value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case FieldValueFactorModifier.Square:
					writer.WriteStringValue("square");
					return;
				case FieldValueFactorModifier.Sqrt:
					writer.WriteStringValue("sqrt");
					return;
				case FieldValueFactorModifier.Reciprocal:
					writer.WriteStringValue("reciprocal");
					return;
				case FieldValueFactorModifier.None:
					writer.WriteStringValue("none");
					return;
				case FieldValueFactorModifier.Log2p:
					writer.WriteStringValue("log2p");
					return;
				case FieldValueFactorModifier.Log1p:
					writer.WriteStringValue("log1p");
					return;
				case FieldValueFactorModifier.Log:
					writer.WriteStringValue("log");
					return;
				case FieldValueFactorModifier.Ln2p:
					writer.WriteStringValue("ln2p");
					return;
				case FieldValueFactorModifier.Ln1p:
					writer.WriteStringValue("ln1p");
					return;
				case FieldValueFactorModifier.Ln:
					writer.WriteStringValue("ln");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(FunctionBoostModeConverter))]
	public enum FunctionBoostMode
	{
		Sum,
		Replace,
		Multiply,
		Min,
		Max,
		Avg
	}

	public class FunctionBoostModeConverter : JsonConverter<FunctionBoostMode>
	{
		public override FunctionBoostMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "sum":
					return FunctionBoostMode.Sum;
				case "replace":
					return FunctionBoostMode.Replace;
				case "multiply":
					return FunctionBoostMode.Multiply;
				case "min":
					return FunctionBoostMode.Min;
				case "max":
					return FunctionBoostMode.Max;
				case "avg":
					return FunctionBoostMode.Avg;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, FunctionBoostMode value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case FunctionBoostMode.Sum:
					writer.WriteStringValue("sum");
					return;
				case FunctionBoostMode.Replace:
					writer.WriteStringValue("replace");
					return;
				case FunctionBoostMode.Multiply:
					writer.WriteStringValue("multiply");
					return;
				case FunctionBoostMode.Min:
					writer.WriteStringValue("min");
					return;
				case FunctionBoostMode.Max:
					writer.WriteStringValue("max");
					return;
				case FunctionBoostMode.Avg:
					writer.WriteStringValue("avg");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(FunctionScoreModeConverter))]
	public enum FunctionScoreMode
	{
		Sum,
		Multiply,
		Min,
		Max,
		First,
		Avg
	}

	public class FunctionScoreModeConverter : JsonConverter<FunctionScoreMode>
	{
		public override FunctionScoreMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "sum":
					return FunctionScoreMode.Sum;
				case "multiply":
					return FunctionScoreMode.Multiply;
				case "min":
					return FunctionScoreMode.Min;
				case "max":
					return FunctionScoreMode.Max;
				case "first":
					return FunctionScoreMode.First;
				case "avg":
					return FunctionScoreMode.Avg;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, FunctionScoreMode value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case FunctionScoreMode.Sum:
					writer.WriteStringValue("sum");
					return;
				case FunctionScoreMode.Multiply:
					writer.WriteStringValue("multiply");
					return;
				case FunctionScoreMode.Min:
					writer.WriteStringValue("min");
					return;
				case FunctionScoreMode.Max:
					writer.WriteStringValue("max");
					return;
				case FunctionScoreMode.First:
					writer.WriteStringValue("first");
					return;
				case FunctionScoreMode.Avg:
					writer.WriteStringValue("avg");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(GeoValidationMethodConverter))]
	public enum GeoValidationMethod
	{
		Strict,
		IgnoreMalformed,
		Coerce
	}

	public class GeoValidationMethodConverter : JsonConverter<GeoValidationMethod>
	{
		public override GeoValidationMethod Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "strict":
					return GeoValidationMethod.Strict;
				case "ignore_malformed":
					return GeoValidationMethod.IgnoreMalformed;
				case "coerce":
					return GeoValidationMethod.Coerce;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, GeoValidationMethod value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case GeoValidationMethod.Strict:
					writer.WriteStringValue("strict");
					return;
				case GeoValidationMethod.IgnoreMalformed:
					writer.WriteStringValue("ignore_malformed");
					return;
				case GeoValidationMethod.Coerce:
					writer.WriteStringValue("coerce");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(MultiValueModeConverter))]
	public enum MultiValueMode
	{
		Sum,
		Min,
		Max,
		Avg
	}

	public class MultiValueModeConverter : JsonConverter<MultiValueMode>
	{
		public override MultiValueMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "sum":
					return MultiValueMode.Sum;
				case "min":
					return MultiValueMode.Min;
				case "max":
					return MultiValueMode.Max;
				case "avg":
					return MultiValueMode.Avg;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, MultiValueMode value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case MultiValueMode.Sum:
					writer.WriteStringValue("sum");
					return;
				case MultiValueMode.Min:
					writer.WriteStringValue("min");
					return;
				case MultiValueMode.Max:
					writer.WriteStringValue("max");
					return;
				case MultiValueMode.Avg:
					writer.WriteStringValue("avg");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(NestedScoreModeConverter))]
	public enum NestedScoreMode
	{
		Sum,
		None,
		Min,
		Max,
		Avg
	}

	public class NestedScoreModeConverter : JsonConverter<NestedScoreMode>
	{
		public override NestedScoreMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "sum":
					return NestedScoreMode.Sum;
				case "none":
					return NestedScoreMode.None;
				case "min":
					return NestedScoreMode.Min;
				case "max":
					return NestedScoreMode.Max;
				case "avg":
					return NestedScoreMode.Avg;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, NestedScoreMode value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case NestedScoreMode.Sum:
					writer.WriteStringValue("sum");
					return;
				case NestedScoreMode.None:
					writer.WriteStringValue("none");
					return;
				case NestedScoreMode.Min:
					writer.WriteStringValue("min");
					return;
				case NestedScoreMode.Max:
					writer.WriteStringValue("max");
					return;
				case NestedScoreMode.Avg:
					writer.WriteStringValue("avg");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(OperatorConverter))]
	public enum Operator
	{
		Or,
		And
	}

	public class OperatorConverter : JsonConverter<Operator>
	{
		public override Operator Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "or":
					return Operator.Or;
				case "and":
					return Operator.And;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, Operator value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case Operator.Or:
					writer.WriteStringValue("or");
					return;
				case Operator.And:
					writer.WriteStringValue("and");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(RangeRelationConverter))]
	public enum RangeRelation
	{
		Within,
		Intersects,
		Contains
	}

	public class RangeRelationConverter : JsonConverter<RangeRelation>
	{
		public override RangeRelation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "within":
					return RangeRelation.Within;
				case "intersects":
					return RangeRelation.Intersects;
				case "contains":
					return RangeRelation.Contains;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, RangeRelation value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case RangeRelation.Within:
					writer.WriteStringValue("within");
					return;
				case RangeRelation.Intersects:
					writer.WriteStringValue("intersects");
					return;
				case RangeRelation.Contains:
					writer.WriteStringValue("contains");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(SimpleQueryStringFlagsConverter))]
	public enum SimpleQueryStringFlags
	{
		Whitespace,
		Slop,
		Prefix,
		Precedence,
		Phrase,
		Or,
		Not,
		None,
		Near,
		Fuzzy,
		Escape,
		And,
		All
	}

	public class SimpleQueryStringFlagsConverter : JsonConverter<SimpleQueryStringFlags>
	{
		public override SimpleQueryStringFlags Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "WHITESPACE":
					return SimpleQueryStringFlags.Whitespace;
				case "SLOP":
					return SimpleQueryStringFlags.Slop;
				case "PREFIX":
					return SimpleQueryStringFlags.Prefix;
				case "PRECEDENCE":
					return SimpleQueryStringFlags.Precedence;
				case "PHRASE":
					return SimpleQueryStringFlags.Phrase;
				case "OR":
					return SimpleQueryStringFlags.Or;
				case "NOT":
					return SimpleQueryStringFlags.Not;
				case "NONE":
					return SimpleQueryStringFlags.None;
				case "NEAR":
					return SimpleQueryStringFlags.Near;
				case "FUZZY":
					return SimpleQueryStringFlags.Fuzzy;
				case "ESCAPE":
					return SimpleQueryStringFlags.Escape;
				case "AND":
					return SimpleQueryStringFlags.And;
				case "ALL":
					return SimpleQueryStringFlags.All;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, SimpleQueryStringFlags value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case SimpleQueryStringFlags.Whitespace:
					writer.WriteStringValue("WHITESPACE");
					return;
				case SimpleQueryStringFlags.Slop:
					writer.WriteStringValue("SLOP");
					return;
				case SimpleQueryStringFlags.Prefix:
					writer.WriteStringValue("PREFIX");
					return;
				case SimpleQueryStringFlags.Precedence:
					writer.WriteStringValue("PRECEDENCE");
					return;
				case SimpleQueryStringFlags.Phrase:
					writer.WriteStringValue("PHRASE");
					return;
				case SimpleQueryStringFlags.Or:
					writer.WriteStringValue("OR");
					return;
				case SimpleQueryStringFlags.Not:
					writer.WriteStringValue("NOT");
					return;
				case SimpleQueryStringFlags.None:
					writer.WriteStringValue("NONE");
					return;
				case SimpleQueryStringFlags.Near:
					writer.WriteStringValue("NEAR");
					return;
				case SimpleQueryStringFlags.Fuzzy:
					writer.WriteStringValue("FUZZY");
					return;
				case SimpleQueryStringFlags.Escape:
					writer.WriteStringValue("ESCAPE");
					return;
				case SimpleQueryStringFlags.And:
					writer.WriteStringValue("AND");
					return;
				case SimpleQueryStringFlags.All:
					writer.WriteStringValue("ALL");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(TextQueryTypeConverter))]
	public enum TextQueryType
	{
		PhrasePrefix,
		Phrase,
		MostFields,
		CrossFields,
		BoolPrefix,
		BestFields
	}

	public class TextQueryTypeConverter : JsonConverter<TextQueryType>
	{
		public override TextQueryType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "phrase_prefix":
					return TextQueryType.PhrasePrefix;
				case "phrase":
					return TextQueryType.Phrase;
				case "most_fields":
					return TextQueryType.MostFields;
				case "cross_fields":
					return TextQueryType.CrossFields;
				case "bool_prefix":
					return TextQueryType.BoolPrefix;
				case "best_fields":
					return TextQueryType.BestFields;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, TextQueryType value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case TextQueryType.PhrasePrefix:
					writer.WriteStringValue("phrase_prefix");
					return;
				case TextQueryType.Phrase:
					writer.WriteStringValue("phrase");
					return;
				case TextQueryType.MostFields:
					writer.WriteStringValue("most_fields");
					return;
				case TextQueryType.CrossFields:
					writer.WriteStringValue("cross_fields");
					return;
				case TextQueryType.BoolPrefix:
					writer.WriteStringValue("bool_prefix");
					return;
				case TextQueryType.BestFields:
					writer.WriteStringValue("best_fields");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(ZeroTermsQueryConverter))]
	public enum ZeroTermsQuery
	{
		None,
		All
	}

	public class ZeroTermsQueryConverter : JsonConverter<ZeroTermsQuery>
	{
		public override ZeroTermsQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "none":
					return ZeroTermsQuery.None;
				case "all":
					return ZeroTermsQuery.All;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, ZeroTermsQuery value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case ZeroTermsQuery.None:
					writer.WriteStringValue("none");
					return;
				case ZeroTermsQuery.All:
					writer.WriteStringValue("all");
					return;
			}

			writer.WriteNullValue();
		}
	}
}