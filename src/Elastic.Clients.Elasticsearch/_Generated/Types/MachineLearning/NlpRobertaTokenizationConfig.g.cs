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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.MachineLearning;

/// <summary>
/// <para>
/// RoBERTa tokenization configuration options
/// </para>
/// </summary>
public sealed partial class NlpRobertaTokenizationConfig
{
	/// <summary>
	/// <para>
	/// Should the tokenizer prefix input with a space character
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("add_prefix_space")]
	public bool? AddPrefixSpace { get; set; }

	/// <summary>
	/// <para>
	/// Should the tokenizer lower case the text
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("do_lower_case")]
	public bool? DoLowerCase { get; set; }

	/// <summary>
	/// <para>
	/// Maximum input sequence length for the model
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("max_sequence_length")]
	public int? MaxSequenceLength { get; set; }

	/// <summary>
	/// <para>
	/// Tokenization spanning options. Special value of -1 indicates no spanning takes place
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("span")]
	public int? Span { get; set; }

	/// <summary>
	/// <para>
	/// Should tokenization input be automatically truncated before sending to the model for inference
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("truncate")]
	public Elastic.Clients.Elasticsearch.MachineLearning.TokenizationTruncate? Truncate { get; set; }

	/// <summary>
	/// <para>
	/// Is tokenization completed with special tokens
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("with_special_tokens")]
	public bool? WithSpecialTokens { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.MachineLearning.TokenizationConfig(NlpRobertaTokenizationConfig nlpRobertaTokenizationConfig) => Elastic.Clients.Elasticsearch.MachineLearning.TokenizationConfig.Roberta(nlpRobertaTokenizationConfig);
}

/// <summary>
/// <para>
/// RoBERTa tokenization configuration options
/// </para>
/// </summary>
public sealed partial class NlpRobertaTokenizationConfigDescriptor : SerializableDescriptor<NlpRobertaTokenizationConfigDescriptor>
{
	internal NlpRobertaTokenizationConfigDescriptor(Action<NlpRobertaTokenizationConfigDescriptor> configure) => configure.Invoke(this);

	public NlpRobertaTokenizationConfigDescriptor() : base()
	{
	}

	private bool? AddPrefixSpaceValue { get; set; }
	private bool? DoLowerCaseValue { get; set; }
	private int? MaxSequenceLengthValue { get; set; }
	private int? SpanValue { get; set; }
	private Elastic.Clients.Elasticsearch.MachineLearning.TokenizationTruncate? TruncateValue { get; set; }
	private bool? WithSpecialTokensValue { get; set; }

	/// <summary>
	/// <para>
	/// Should the tokenizer prefix input with a space character
	/// </para>
	/// </summary>
	public NlpRobertaTokenizationConfigDescriptor AddPrefixSpace(bool? addPrefixSpace = true)
	{
		AddPrefixSpaceValue = addPrefixSpace;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Should the tokenizer lower case the text
	/// </para>
	/// </summary>
	public NlpRobertaTokenizationConfigDescriptor DoLowerCase(bool? doLowerCase = true)
	{
		DoLowerCaseValue = doLowerCase;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Maximum input sequence length for the model
	/// </para>
	/// </summary>
	public NlpRobertaTokenizationConfigDescriptor MaxSequenceLength(int? maxSequenceLength)
	{
		MaxSequenceLengthValue = maxSequenceLength;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Tokenization spanning options. Special value of -1 indicates no spanning takes place
	/// </para>
	/// </summary>
	public NlpRobertaTokenizationConfigDescriptor Span(int? span)
	{
		SpanValue = span;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Should tokenization input be automatically truncated before sending to the model for inference
	/// </para>
	/// </summary>
	public NlpRobertaTokenizationConfigDescriptor Truncate(Elastic.Clients.Elasticsearch.MachineLearning.TokenizationTruncate? truncate)
	{
		TruncateValue = truncate;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Is tokenization completed with special tokens
	/// </para>
	/// </summary>
	public NlpRobertaTokenizationConfigDescriptor WithSpecialTokens(bool? withSpecialTokens = true)
	{
		WithSpecialTokensValue = withSpecialTokens;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AddPrefixSpaceValue.HasValue)
		{
			writer.WritePropertyName("add_prefix_space");
			writer.WriteBooleanValue(AddPrefixSpaceValue.Value);
		}

		if (DoLowerCaseValue.HasValue)
		{
			writer.WritePropertyName("do_lower_case");
			writer.WriteBooleanValue(DoLowerCaseValue.Value);
		}

		if (MaxSequenceLengthValue.HasValue)
		{
			writer.WritePropertyName("max_sequence_length");
			writer.WriteNumberValue(MaxSequenceLengthValue.Value);
		}

		if (SpanValue.HasValue)
		{
			writer.WritePropertyName("span");
			writer.WriteNumberValue(SpanValue.Value);
		}

		if (TruncateValue is not null)
		{
			writer.WritePropertyName("truncate");
			JsonSerializer.Serialize(writer, TruncateValue, options);
		}

		if (WithSpecialTokensValue.HasValue)
		{
			writer.WritePropertyName("with_special_tokens");
			writer.WriteBooleanValue(WithSpecialTokensValue.Value);
		}

		writer.WriteEndObject();
	}
}