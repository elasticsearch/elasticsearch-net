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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml;
public sealed partial class FillMaskInferenceOptions
{
	[JsonInclude]
	[JsonPropertyName("num_top_classes")]
	public int? NumTopClasses { get; set; }

	[JsonInclude]
	[JsonPropertyName("results_field")]
	public string? ResultsField { get; set; }

	[JsonInclude]
	[JsonPropertyName("tokenization")]
	public Elastic.Clients.Elasticsearch.Ml.TokenizationConfig? Tokenization { get; set; }

	public static implicit operator InferenceConfigCreate(FillMaskInferenceOptions fillMaskInferenceOptions) => Ml.InferenceConfigCreate.FillMask(fillMaskInferenceOptions);
}

public sealed partial class FillMaskInferenceOptionsDescriptor : SerializableDescriptor<FillMaskInferenceOptionsDescriptor>
{
	internal FillMaskInferenceOptionsDescriptor(Action<FillMaskInferenceOptionsDescriptor> configure) => configure.Invoke(this);
	public FillMaskInferenceOptionsDescriptor() : base()
	{
	}

	private int? NumTopClassesValue { get; set; }

	private string? ResultsFieldValue { get; set; }

	private Elastic.Clients.Elasticsearch.Ml.TokenizationConfig? TokenizationValue { get; set; }

	private TokenizationConfigDescriptor TokenizationDescriptor { get; set; }

	private Action<TokenizationConfigDescriptor> TokenizationDescriptorAction { get; set; }

	public FillMaskInferenceOptionsDescriptor NumTopClasses(int? numTopClasses)
	{
		NumTopClassesValue = numTopClasses;
		return Self;
	}

	public FillMaskInferenceOptionsDescriptor ResultsField(string? resultsField)
	{
		ResultsFieldValue = resultsField;
		return Self;
	}

	public FillMaskInferenceOptionsDescriptor Tokenization(Elastic.Clients.Elasticsearch.Ml.TokenizationConfig? tokenization)
	{
		TokenizationDescriptor = null;
		TokenizationDescriptorAction = null;
		TokenizationValue = tokenization;
		return Self;
	}

	public FillMaskInferenceOptionsDescriptor Tokenization(TokenizationConfigDescriptor descriptor)
	{
		TokenizationValue = null;
		TokenizationDescriptorAction = null;
		TokenizationDescriptor = descriptor;
		return Self;
	}

	public FillMaskInferenceOptionsDescriptor Tokenization(Action<TokenizationConfigDescriptor> configure)
	{
		TokenizationValue = null;
		TokenizationDescriptor = null;
		TokenizationDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (NumTopClassesValue.HasValue)
		{
			writer.WritePropertyName("num_top_classes");
			writer.WriteNumberValue(NumTopClassesValue.Value);
		}

		if (!string.IsNullOrEmpty(ResultsFieldValue))
		{
			writer.WritePropertyName("results_field");
			writer.WriteStringValue(ResultsFieldValue);
		}

		if (TokenizationDescriptor is not null)
		{
			writer.WritePropertyName("tokenization");
			JsonSerializer.Serialize(writer, TokenizationDescriptor, options);
		}
		else if (TokenizationDescriptorAction is not null)
		{
			writer.WritePropertyName("tokenization");
			JsonSerializer.Serialize(writer, new TokenizationConfigDescriptor(TokenizationDescriptorAction), options);
		}
		else if (TokenizationValue is not null)
		{
			writer.WritePropertyName("tokenization");
			JsonSerializer.Serialize(writer, TokenizationValue, options);
		}

		writer.WriteEndObject();
	}
}