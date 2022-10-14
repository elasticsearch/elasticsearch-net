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
using Elastic.Clients.Elasticsearch.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Core.Search;
[JsonConverter(typeof(BoundaryScannerConverter))]
public enum BoundaryScanner
{
	[EnumMember(Value = "word")]
	Word,
	[EnumMember(Value = "sentence")]
	Sentence,
	[EnumMember(Value = "chars")]
	Chars
}

internal sealed class BoundaryScannerConverter : JsonConverter<BoundaryScanner>
{
	public override BoundaryScanner Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "word":
				return BoundaryScanner.Word;
			case "sentence":
				return BoundaryScanner.Sentence;
			case "chars":
				return BoundaryScanner.Chars;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, BoundaryScanner value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case BoundaryScanner.Word:
				writer.WriteStringValue("word");
				return;
			case BoundaryScanner.Sentence:
				writer.WriteStringValue("sentence");
				return;
			case BoundaryScanner.Chars:
				writer.WriteStringValue("chars");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(HighlighterEncoderConverter))]
public enum HighlighterEncoder
{
	[EnumMember(Value = "html")]
	Html,
	[EnumMember(Value = "default")]
	Default
}

internal sealed class HighlighterEncoderConverter : JsonConverter<HighlighterEncoder>
{
	public override HighlighterEncoder Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "html":
				return HighlighterEncoder.Html;
			case "default":
				return HighlighterEncoder.Default;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, HighlighterEncoder value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case HighlighterEncoder.Html:
				writer.WriteStringValue("html");
				return;
			case HighlighterEncoder.Default:
				writer.WriteStringValue("default");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(HighlighterFragmenterConverter))]
public enum HighlighterFragmenter
{
	[EnumMember(Value = "span")]
	Span,
	[EnumMember(Value = "simple")]
	Simple
}

internal sealed class HighlighterFragmenterConverter : JsonConverter<HighlighterFragmenter>
{
	public override HighlighterFragmenter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "span":
				return HighlighterFragmenter.Span;
			case "simple":
				return HighlighterFragmenter.Simple;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, HighlighterFragmenter value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case HighlighterFragmenter.Span:
				writer.WriteStringValue("span");
				return;
			case HighlighterFragmenter.Simple:
				writer.WriteStringValue("simple");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(HighlighterOrderConverter))]
public enum HighlighterOrder
{
	[EnumMember(Value = "score")]
	Score
}

internal sealed class HighlighterOrderConverter : JsonConverter<HighlighterOrder>
{
	public override HighlighterOrder Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "score":
				return HighlighterOrder.Score;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, HighlighterOrder value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case HighlighterOrder.Score:
				writer.WriteStringValue("score");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(HighlighterTagsSchemaConverter))]
public enum HighlighterTagsSchema
{
	[EnumMember(Value = "styled")]
	Styled
}

internal sealed class HighlighterTagsSchemaConverter : JsonConverter<HighlighterTagsSchema>
{
	public override HighlighterTagsSchema Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "styled":
				return HighlighterTagsSchema.Styled;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, HighlighterTagsSchema value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case HighlighterTagsSchema.Styled:
				writer.WriteStringValue("styled");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(EnumStructConverter<HighlighterType>))]
public readonly partial struct HighlighterType
{
	public HighlighterType(string value) => Value = value;
	public readonly string Value { get; }

	public static HighlighterType Unified { get; } = new HighlighterType("unified");
	public static HighlighterType Plain { get; } = new HighlighterType("plain");
	public static HighlighterType FastVector { get; } = new HighlighterType("fvh");
	public override string ToString() => Value ?? string.Empty;
	public static implicit operator string(HighlighterType highlighterType) => highlighterType.Value;
	public static implicit operator HighlighterType(string value) => new(value);
	public override int GetHashCode() => Value.GetHashCode();
	public override bool Equals(object obj) => obj is HighlighterType other && this.Equals(other);
	public bool Equals(HighlighterType other) => Value == other.Value;
	public static bool operator ==(HighlighterType a, HighlighterType b) => a.Equals(b);
	public static bool operator !=(HighlighterType a, HighlighterType b) => !(a == b);
}

[JsonConverter(typeof(ScoreModeConverter))]
public enum ScoreMode
{
	[EnumMember(Value = "total")]
	Total,
	[EnumMember(Value = "multiply")]
	Multiply,
	[EnumMember(Value = "min")]
	Min,
	[EnumMember(Value = "max")]
	Max,
	[EnumMember(Value = "avg")]
	Avg
}

internal sealed class ScoreModeConverter : JsonConverter<ScoreMode>
{
	public override ScoreMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "total":
				return ScoreMode.Total;
			case "multiply":
				return ScoreMode.Multiply;
			case "min":
				return ScoreMode.Min;
			case "max":
				return ScoreMode.Max;
			case "avg":
				return ScoreMode.Avg;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, ScoreMode value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case ScoreMode.Total:
				writer.WriteStringValue("total");
				return;
			case ScoreMode.Multiply:
				writer.WriteStringValue("multiply");
				return;
			case ScoreMode.Min:
				writer.WriteStringValue("min");
				return;
			case ScoreMode.Max:
				writer.WriteStringValue("max");
				return;
			case ScoreMode.Avg:
				writer.WriteStringValue("avg");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(StringDistanceConverter))]
public enum StringDistance
{
	[EnumMember(Value = "ngram")]
	Ngram,
	[EnumMember(Value = "levenshtein")]
	Levenshtein,
	[EnumMember(Value = "jaro_winkler")]
	JaroWinkler,
	[EnumMember(Value = "internal")]
	Internal,
	[EnumMember(Value = "damerau_levenshtein")]
	DamerauLevenshtein
}

internal sealed class StringDistanceConverter : JsonConverter<StringDistance>
{
	public override StringDistance Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "ngram":
				return StringDistance.Ngram;
			case "levenshtein":
				return StringDistance.Levenshtein;
			case "jaro_winkler":
				return StringDistance.JaroWinkler;
			case "internal":
				return StringDistance.Internal;
			case "damerau_levenshtein":
				return StringDistance.DamerauLevenshtein;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, StringDistance value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case StringDistance.Ngram:
				writer.WriteStringValue("ngram");
				return;
			case StringDistance.Levenshtein:
				writer.WriteStringValue("levenshtein");
				return;
			case StringDistance.JaroWinkler:
				writer.WriteStringValue("jaro_winkler");
				return;
			case StringDistance.Internal:
				writer.WriteStringValue("internal");
				return;
			case StringDistance.DamerauLevenshtein:
				writer.WriteStringValue("damerau_levenshtein");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(SuggestSortConverter))]
public enum SuggestSort
{
	[EnumMember(Value = "score")]
	Score,
	[EnumMember(Value = "frequency")]
	Frequency
}

internal sealed class SuggestSortConverter : JsonConverter<SuggestSort>
{
	public override SuggestSort Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "score":
				return SuggestSort.Score;
			case "frequency":
				return SuggestSort.Frequency;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, SuggestSort value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case SuggestSort.Score:
				writer.WriteStringValue("score");
				return;
			case SuggestSort.Frequency:
				writer.WriteStringValue("frequency");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(TotalHitsRelationConverter))]
public enum TotalHitsRelation
{
	[EnumMember(Value = "gte")]
	Gte,
	[EnumMember(Value = "eq")]
	Eq
}

internal sealed class TotalHitsRelationConverter : JsonConverter<TotalHitsRelation>
{
	public override TotalHitsRelation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "gte":
				return TotalHitsRelation.Gte;
			case "eq":
				return TotalHitsRelation.Eq;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, TotalHitsRelation value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case TotalHitsRelation.Gte:
				writer.WriteStringValue("gte");
				return;
			case TotalHitsRelation.Eq:
				writer.WriteStringValue("eq");
				return;
		}

		writer.WriteNullValue();
	}
}