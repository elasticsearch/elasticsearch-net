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

namespace Elastic.Clients.Elasticsearch.Core.Search;

[JsonConverter(typeof(BoundaryScannerConverter))]
public enum BoundaryScanner
{
	/// <summary>
	/// <para>
	/// Break highlighted fragments at the next word boundary, as determined by Java’s <c>BreakIterator</c>.
	/// You can specify the locale to use with <c>boundary_scanner_locale</c>.
	/// </para>
	/// </summary>
	[EnumMember(Value = "word")]
	Word,
	/// <summary>
	/// <para>
	/// Break highlighted fragments at the next sentence boundary, as determined by Java’s <c>BreakIterator</c>.
	/// You can specify the locale to use with <c>boundary_scanner_locale</c>.
	/// When used with the <c>unified</c> highlighter, the <c>sentence</c> scanner splits sentences bigger than <c>fragment_size</c> at the first word boundary next to fragment_size.
	/// You can set <c>fragment_size</c> to <c>0</c> to never split any sentence.
	/// </para>
	/// </summary>
	[EnumMember(Value = "sentence")]
	Sentence,
	/// <summary>
	/// <para>
	/// Use the characters specified by <c>boundary_chars</c> as highlighting boundaries.
	/// The <c>boundary_max_scan</c> setting controls how far to scan for boundary characters.
	/// Only valid for the <c>fvh</c> highlighter.
	/// </para>
	/// </summary>
	[EnumMember(Value = "chars")]
	Chars
}

internal sealed partial class BoundaryScannerConverter : System.Text.Json.Serialization.JsonConverter<BoundaryScanner>
{
	private static readonly System.Text.Json.JsonEncodedText MemberWord = System.Text.Json.JsonEncodedText.Encode("word");
	private static readonly System.Text.Json.JsonEncodedText MemberSentence = System.Text.Json.JsonEncodedText.Encode("sentence");
	private static readonly System.Text.Json.JsonEncodedText MemberChars = System.Text.Json.JsonEncodedText.Encode("chars");

	public override BoundaryScanner Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.String);
		if (reader.ValueTextEquals(MemberWord))
		{
			return BoundaryScanner.Word;
		}

		if (reader.ValueTextEquals(MemberSentence))
		{
			return BoundaryScanner.Sentence;
		}

		if (reader.ValueTextEquals(MemberChars))
		{
			return BoundaryScanner.Chars;
		}

		var value = reader.GetString()!;
		if (string.Equals(value, MemberWord.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return BoundaryScanner.Word;
		}

		if (string.Equals(value, MemberSentence.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return BoundaryScanner.Sentence;
		}

		if (string.Equals(value, MemberChars.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return BoundaryScanner.Chars;
		}

		throw new System.Text.Json.JsonException($"Unknown member '{value}' for enum '{nameof(BoundaryScanner)}'.");
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, BoundaryScanner value, System.Text.Json.JsonSerializerOptions options)
	{
		switch (value)
		{
			case BoundaryScanner.Word:
				writer.WriteStringValue(MemberWord);
				break;
			case BoundaryScanner.Sentence:
				writer.WriteStringValue(MemberSentence);
				break;
			case BoundaryScanner.Chars:
				writer.WriteStringValue(MemberChars);
				break;
			default:
				throw new System.Text.Json.JsonException($"Invalid value '{value}' for enum '{nameof(BoundaryScanner)}'.");
		}
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

internal sealed partial class HighlighterEncoderConverter : System.Text.Json.Serialization.JsonConverter<HighlighterEncoder>
{
	private static readonly System.Text.Json.JsonEncodedText MemberHtml = System.Text.Json.JsonEncodedText.Encode("html");
	private static readonly System.Text.Json.JsonEncodedText MemberDefault = System.Text.Json.JsonEncodedText.Encode("default");

	public override HighlighterEncoder Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.String);
		if (reader.ValueTextEquals(MemberHtml))
		{
			return HighlighterEncoder.Html;
		}

		if (reader.ValueTextEquals(MemberDefault))
		{
			return HighlighterEncoder.Default;
		}

		var value = reader.GetString()!;
		if (string.Equals(value, MemberHtml.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return HighlighterEncoder.Html;
		}

		if (string.Equals(value, MemberDefault.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return HighlighterEncoder.Default;
		}

		throw new System.Text.Json.JsonException($"Unknown member '{value}' for enum '{nameof(HighlighterEncoder)}'.");
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, HighlighterEncoder value, System.Text.Json.JsonSerializerOptions options)
	{
		switch (value)
		{
			case HighlighterEncoder.Html:
				writer.WriteStringValue(MemberHtml);
				break;
			case HighlighterEncoder.Default:
				writer.WriteStringValue(MemberDefault);
				break;
			default:
				throw new System.Text.Json.JsonException($"Invalid value '{value}' for enum '{nameof(HighlighterEncoder)}'.");
		}
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

internal sealed partial class HighlighterFragmenterConverter : System.Text.Json.Serialization.JsonConverter<HighlighterFragmenter>
{
	private static readonly System.Text.Json.JsonEncodedText MemberSpan = System.Text.Json.JsonEncodedText.Encode("span");
	private static readonly System.Text.Json.JsonEncodedText MemberSimple = System.Text.Json.JsonEncodedText.Encode("simple");

	public override HighlighterFragmenter Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.String);
		if (reader.ValueTextEquals(MemberSpan))
		{
			return HighlighterFragmenter.Span;
		}

		if (reader.ValueTextEquals(MemberSimple))
		{
			return HighlighterFragmenter.Simple;
		}

		var value = reader.GetString()!;
		if (string.Equals(value, MemberSpan.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return HighlighterFragmenter.Span;
		}

		if (string.Equals(value, MemberSimple.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return HighlighterFragmenter.Simple;
		}

		throw new System.Text.Json.JsonException($"Unknown member '{value}' for enum '{nameof(HighlighterFragmenter)}'.");
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, HighlighterFragmenter value, System.Text.Json.JsonSerializerOptions options)
	{
		switch (value)
		{
			case HighlighterFragmenter.Span:
				writer.WriteStringValue(MemberSpan);
				break;
			case HighlighterFragmenter.Simple:
				writer.WriteStringValue(MemberSimple);
				break;
			default:
				throw new System.Text.Json.JsonException($"Invalid value '{value}' for enum '{nameof(HighlighterFragmenter)}'.");
		}
	}
}

[JsonConverter(typeof(HighlighterOrderConverter))]
public enum HighlighterOrder
{
	[EnumMember(Value = "score")]
	Score
}

internal sealed partial class HighlighterOrderConverter : System.Text.Json.Serialization.JsonConverter<HighlighterOrder>
{
	private static readonly System.Text.Json.JsonEncodedText MemberScore = System.Text.Json.JsonEncodedText.Encode("score");

	public override HighlighterOrder Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.String);
		if (reader.ValueTextEquals(MemberScore))
		{
			return HighlighterOrder.Score;
		}

		var value = reader.GetString()!;
		if (string.Equals(value, MemberScore.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return HighlighterOrder.Score;
		}

		throw new System.Text.Json.JsonException($"Unknown member '{value}' for enum '{nameof(HighlighterOrder)}'.");
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, HighlighterOrder value, System.Text.Json.JsonSerializerOptions options)
	{
		switch (value)
		{
			case HighlighterOrder.Score:
				writer.WriteStringValue(MemberScore);
				break;
			default:
				throw new System.Text.Json.JsonException($"Invalid value '{value}' for enum '{nameof(HighlighterOrder)}'.");
		}
	}
}

[JsonConverter(typeof(HighlighterTagsSchemaConverter))]
public enum HighlighterTagsSchema
{
	[EnumMember(Value = "styled")]
	Styled
}

internal sealed partial class HighlighterTagsSchemaConverter : System.Text.Json.Serialization.JsonConverter<HighlighterTagsSchema>
{
	private static readonly System.Text.Json.JsonEncodedText MemberStyled = System.Text.Json.JsonEncodedText.Encode("styled");

	public override HighlighterTagsSchema Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.String);
		if (reader.ValueTextEquals(MemberStyled))
		{
			return HighlighterTagsSchema.Styled;
		}

		var value = reader.GetString()!;
		if (string.Equals(value, MemberStyled.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return HighlighterTagsSchema.Styled;
		}

		throw new System.Text.Json.JsonException($"Unknown member '{value}' for enum '{nameof(HighlighterTagsSchema)}'.");
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, HighlighterTagsSchema value, System.Text.Json.JsonSerializerOptions options)
	{
		switch (value)
		{
			case HighlighterTagsSchema.Styled:
				writer.WriteStringValue(MemberStyled);
				break;
			default:
				throw new System.Text.Json.JsonException($"Invalid value '{value}' for enum '{nameof(HighlighterTagsSchema)}'.");
		}
	}
}

[JsonConverter(typeof(EnumStructConverter<HighlighterType>))]
public readonly partial struct HighlighterType : IEnumStruct<HighlighterType>
{
	public HighlighterType(string value) => Value = value;
#if NET7_0_OR_GREATER
	static HighlighterType IEnumStruct<HighlighterType>.Create(string value) => value;
#else
	HighlighterType IEnumStruct<HighlighterType>.Create(string value) => value;
#endif
	public readonly string Value { get; }

	/// <summary>
	/// <para>
	/// The unified highlighter uses the Lucene Unified Highlighter.
	/// </para>
	/// </summary>
	public static HighlighterType Unified { get; } = new HighlighterType("unified");

	/// <summary>
	/// <para>
	/// The <c>plain</c> highlighter uses the standard Lucene highlighter
	/// </para>
	/// </summary>
	public static HighlighterType Plain { get; } = new HighlighterType("plain");

	/// <summary>
	/// <para>
	/// The fvh highlighter uses the Lucene Fast Vector highlighter.
	/// </para>
	/// </summary>
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
	/// <summary>
	/// <para>
	/// Add the original score and the rescore query score.
	/// </para>
	/// </summary>
	[EnumMember(Value = "total")]
	Total,
	/// <summary>
	/// <para>
	/// Multiply the original score by the rescore query score.
	/// Useful for <c>function</c> query rescores.
	/// </para>
	/// </summary>
	[EnumMember(Value = "multiply")]
	Multiply,
	/// <summary>
	/// <para>
	/// Take the min of the original score and the rescore query score.
	/// </para>
	/// </summary>
	[EnumMember(Value = "min")]
	Min,
	/// <summary>
	/// <para>
	/// Take the max of original score and the rescore query score.
	/// </para>
	/// </summary>
	[EnumMember(Value = "max")]
	Max,
	/// <summary>
	/// <para>
	/// Average the original score and the rescore query score.
	/// </para>
	/// </summary>
	[EnumMember(Value = "avg")]
	Avg
}

internal sealed partial class ScoreModeConverter : System.Text.Json.Serialization.JsonConverter<ScoreMode>
{
	private static readonly System.Text.Json.JsonEncodedText MemberTotal = System.Text.Json.JsonEncodedText.Encode("total");
	private static readonly System.Text.Json.JsonEncodedText MemberMultiply = System.Text.Json.JsonEncodedText.Encode("multiply");
	private static readonly System.Text.Json.JsonEncodedText MemberMin = System.Text.Json.JsonEncodedText.Encode("min");
	private static readonly System.Text.Json.JsonEncodedText MemberMax = System.Text.Json.JsonEncodedText.Encode("max");
	private static readonly System.Text.Json.JsonEncodedText MemberAvg = System.Text.Json.JsonEncodedText.Encode("avg");

	public override ScoreMode Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.String);
		if (reader.ValueTextEquals(MemberTotal))
		{
			return ScoreMode.Total;
		}

		if (reader.ValueTextEquals(MemberMultiply))
		{
			return ScoreMode.Multiply;
		}

		if (reader.ValueTextEquals(MemberMin))
		{
			return ScoreMode.Min;
		}

		if (reader.ValueTextEquals(MemberMax))
		{
			return ScoreMode.Max;
		}

		if (reader.ValueTextEquals(MemberAvg))
		{
			return ScoreMode.Avg;
		}

		var value = reader.GetString()!;
		if (string.Equals(value, MemberTotal.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return ScoreMode.Total;
		}

		if (string.Equals(value, MemberMultiply.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return ScoreMode.Multiply;
		}

		if (string.Equals(value, MemberMin.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return ScoreMode.Min;
		}

		if (string.Equals(value, MemberMax.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return ScoreMode.Max;
		}

		if (string.Equals(value, MemberAvg.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return ScoreMode.Avg;
		}

		throw new System.Text.Json.JsonException($"Unknown member '{value}' for enum '{nameof(ScoreMode)}'.");
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, ScoreMode value, System.Text.Json.JsonSerializerOptions options)
	{
		switch (value)
		{
			case ScoreMode.Total:
				writer.WriteStringValue(MemberTotal);
				break;
			case ScoreMode.Multiply:
				writer.WriteStringValue(MemberMultiply);
				break;
			case ScoreMode.Min:
				writer.WriteStringValue(MemberMin);
				break;
			case ScoreMode.Max:
				writer.WriteStringValue(MemberMax);
				break;
			case ScoreMode.Avg:
				writer.WriteStringValue(MemberAvg);
				break;
			default:
				throw new System.Text.Json.JsonException($"Invalid value '{value}' for enum '{nameof(ScoreMode)}'.");
		}
	}
}

[JsonConverter(typeof(StringDistanceConverter))]
public enum StringDistance
{
	/// <summary>
	/// <para>
	/// String distance algorithm based on character n-grams.
	/// </para>
	/// </summary>
	[EnumMember(Value = "ngram")]
	Ngram,
	/// <summary>
	/// <para>
	/// String distance algorithm based on the Levenshtein edit distance algorithm.
	/// </para>
	/// </summary>
	[EnumMember(Value = "levenshtein")]
	Levenshtein,
	/// <summary>
	/// <para>
	/// String distance algorithm based on Jaro-Winkler algorithm.
	/// </para>
	/// </summary>
	[EnumMember(Value = "jaro_winkler")]
	JaroWinkler,
	/// <summary>
	/// <para>
	/// Based on the Damerau-Levenshtein algorithm, but highly optimized for comparing string distance for terms inside the index.
	/// </para>
	/// </summary>
	[EnumMember(Value = "internal")]
	Internal,
	/// <summary>
	/// <para>
	/// String distance algorithm based on Damerau-Levenshtein algorithm.
	/// </para>
	/// </summary>
	[EnumMember(Value = "damerau_levenshtein")]
	DamerauLevenshtein
}

internal sealed partial class StringDistanceConverter : System.Text.Json.Serialization.JsonConverter<StringDistance>
{
	private static readonly System.Text.Json.JsonEncodedText MemberNgram = System.Text.Json.JsonEncodedText.Encode("ngram");
	private static readonly System.Text.Json.JsonEncodedText MemberLevenshtein = System.Text.Json.JsonEncodedText.Encode("levenshtein");
	private static readonly System.Text.Json.JsonEncodedText MemberJaroWinkler = System.Text.Json.JsonEncodedText.Encode("jaro_winkler");
	private static readonly System.Text.Json.JsonEncodedText MemberInternal = System.Text.Json.JsonEncodedText.Encode("internal");
	private static readonly System.Text.Json.JsonEncodedText MemberDamerauLevenshtein = System.Text.Json.JsonEncodedText.Encode("damerau_levenshtein");

	public override StringDistance Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.String);
		if (reader.ValueTextEquals(MemberNgram))
		{
			return StringDistance.Ngram;
		}

		if (reader.ValueTextEquals(MemberLevenshtein))
		{
			return StringDistance.Levenshtein;
		}

		if (reader.ValueTextEquals(MemberJaroWinkler))
		{
			return StringDistance.JaroWinkler;
		}

		if (reader.ValueTextEquals(MemberInternal))
		{
			return StringDistance.Internal;
		}

		if (reader.ValueTextEquals(MemberDamerauLevenshtein))
		{
			return StringDistance.DamerauLevenshtein;
		}

		var value = reader.GetString()!;
		if (string.Equals(value, MemberNgram.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return StringDistance.Ngram;
		}

		if (string.Equals(value, MemberLevenshtein.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return StringDistance.Levenshtein;
		}

		if (string.Equals(value, MemberJaroWinkler.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return StringDistance.JaroWinkler;
		}

		if (string.Equals(value, MemberInternal.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return StringDistance.Internal;
		}

		if (string.Equals(value, MemberDamerauLevenshtein.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return StringDistance.DamerauLevenshtein;
		}

		throw new System.Text.Json.JsonException($"Unknown member '{value}' for enum '{nameof(StringDistance)}'.");
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, StringDistance value, System.Text.Json.JsonSerializerOptions options)
	{
		switch (value)
		{
			case StringDistance.Ngram:
				writer.WriteStringValue(MemberNgram);
				break;
			case StringDistance.Levenshtein:
				writer.WriteStringValue(MemberLevenshtein);
				break;
			case StringDistance.JaroWinkler:
				writer.WriteStringValue(MemberJaroWinkler);
				break;
			case StringDistance.Internal:
				writer.WriteStringValue(MemberInternal);
				break;
			case StringDistance.DamerauLevenshtein:
				writer.WriteStringValue(MemberDamerauLevenshtein);
				break;
			default:
				throw new System.Text.Json.JsonException($"Invalid value '{value}' for enum '{nameof(StringDistance)}'.");
		}
	}
}

[JsonConverter(typeof(SuggestSortConverter))]
public enum SuggestSort
{
	/// <summary>
	/// <para>
	/// Sort by score first, then document frequency and then the term itself.
	/// </para>
	/// </summary>
	[EnumMember(Value = "score")]
	Score,
	/// <summary>
	/// <para>
	/// Sort by document frequency first, then similarity score and then the term itself.
	/// </para>
	/// </summary>
	[EnumMember(Value = "frequency")]
	Frequency
}

internal sealed partial class SuggestSortConverter : System.Text.Json.Serialization.JsonConverter<SuggestSort>
{
	private static readonly System.Text.Json.JsonEncodedText MemberScore = System.Text.Json.JsonEncodedText.Encode("score");
	private static readonly System.Text.Json.JsonEncodedText MemberFrequency = System.Text.Json.JsonEncodedText.Encode("frequency");

	public override SuggestSort Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.String);
		if (reader.ValueTextEquals(MemberScore))
		{
			return SuggestSort.Score;
		}

		if (reader.ValueTextEquals(MemberFrequency))
		{
			return SuggestSort.Frequency;
		}

		var value = reader.GetString()!;
		if (string.Equals(value, MemberScore.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return SuggestSort.Score;
		}

		if (string.Equals(value, MemberFrequency.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return SuggestSort.Frequency;
		}

		throw new System.Text.Json.JsonException($"Unknown member '{value}' for enum '{nameof(SuggestSort)}'.");
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, SuggestSort value, System.Text.Json.JsonSerializerOptions options)
	{
		switch (value)
		{
			case SuggestSort.Score:
				writer.WriteStringValue(MemberScore);
				break;
			case SuggestSort.Frequency:
				writer.WriteStringValue(MemberFrequency);
				break;
			default:
				throw new System.Text.Json.JsonException($"Invalid value '{value}' for enum '{nameof(SuggestSort)}'.");
		}
	}
}

[JsonConverter(typeof(TotalHitsRelationConverter))]
public enum TotalHitsRelation
{
	/// <summary>
	/// <para>
	/// Lower bound, including returned events or sequences
	/// </para>
	/// </summary>
	[EnumMember(Value = "gte")]
	Gte,
	/// <summary>
	/// <para>
	/// Accurate
	/// </para>
	/// </summary>
	[EnumMember(Value = "eq")]
	Eq
}

internal sealed partial class TotalHitsRelationConverter : System.Text.Json.Serialization.JsonConverter<TotalHitsRelation>
{
	private static readonly System.Text.Json.JsonEncodedText MemberGte = System.Text.Json.JsonEncodedText.Encode("gte");
	private static readonly System.Text.Json.JsonEncodedText MemberEq = System.Text.Json.JsonEncodedText.Encode("eq");

	public override TotalHitsRelation Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.String);
		if (reader.ValueTextEquals(MemberGte))
		{
			return TotalHitsRelation.Gte;
		}

		if (reader.ValueTextEquals(MemberEq))
		{
			return TotalHitsRelation.Eq;
		}

		var value = reader.GetString()!;
		if (string.Equals(value, MemberGte.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return TotalHitsRelation.Gte;
		}

		if (string.Equals(value, MemberEq.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return TotalHitsRelation.Eq;
		}

		throw new System.Text.Json.JsonException($"Unknown member '{value}' for enum '{nameof(TotalHitsRelation)}'.");
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, TotalHitsRelation value, System.Text.Json.JsonSerializerOptions options)
	{
		switch (value)
		{
			case TotalHitsRelation.Gte:
				writer.WriteStringValue(MemberGte);
				break;
			case TotalHitsRelation.Eq:
				writer.WriteStringValue(MemberEq);
				break;
			default:
				throw new System.Text.Json.JsonException($"Invalid value '{value}' for enum '{nameof(TotalHitsRelation)}'.");
		}
	}
}