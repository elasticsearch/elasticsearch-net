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
/// <para>Pass through configuration options</para>
/// </summary>
public sealed partial class PassThroughInferenceOptions
{
	/// <summary>
	/// <para>The field that is added to incoming documents to contain the inference prediction. Defaults to predicted_value.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("results_field")]
	public string? ResultsField { get; set; }

	/// <summary>
	/// <para>The tokenization options</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tokenization")]
	public Elastic.Clients.Elasticsearch.MachineLearning.TokenizationConfig? Tokenization { get; set; }
	[JsonInclude, JsonPropertyName("vocabulary")]
	public Elastic.Clients.Elasticsearch.MachineLearning.Vocabulary? Vocabulary { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.MachineLearning.InferenceConfigCreate(PassThroughInferenceOptions passThroughInferenceOptions) => Elastic.Clients.Elasticsearch.MachineLearning.InferenceConfigCreate.PassThrough(passThroughInferenceOptions);
}

/// <summary>
/// <para>Pass through configuration options</para>
/// </summary>
public sealed partial class PassThroughInferenceOptionsDescriptor : SerializableDescriptor<PassThroughInferenceOptionsDescriptor>
{
	internal PassThroughInferenceOptionsDescriptor(Action<PassThroughInferenceOptionsDescriptor> configure) => configure.Invoke(this);

	public PassThroughInferenceOptionsDescriptor() : base()
	{
	}

	private string? ResultsFieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.MachineLearning.TokenizationConfig? TokenizationValue { get; set; }
	private Elastic.Clients.Elasticsearch.MachineLearning.TokenizationConfigDescriptor TokenizationDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.MachineLearning.TokenizationConfigDescriptor> TokenizationDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.MachineLearning.Vocabulary? VocabularyValue { get; set; }
	private Elastic.Clients.Elasticsearch.MachineLearning.VocabularyDescriptor VocabularyDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.MachineLearning.VocabularyDescriptor> VocabularyDescriptorAction { get; set; }

	/// <summary>
	/// <para>The field that is added to incoming documents to contain the inference prediction. Defaults to predicted_value.</para>
	/// </summary>
	public PassThroughInferenceOptionsDescriptor ResultsField(string? resultsField)
	{
		ResultsFieldValue = resultsField;
		return Self;
	}

	/// <summary>
	/// <para>The tokenization options</para>
	/// </summary>
	public PassThroughInferenceOptionsDescriptor Tokenization(Elastic.Clients.Elasticsearch.MachineLearning.TokenizationConfig? tokenization)
	{
		TokenizationDescriptor = null;
		TokenizationDescriptorAction = null;
		TokenizationValue = tokenization;
		return Self;
	}

	public PassThroughInferenceOptionsDescriptor Tokenization(Elastic.Clients.Elasticsearch.MachineLearning.TokenizationConfigDescriptor descriptor)
	{
		TokenizationValue = null;
		TokenizationDescriptorAction = null;
		TokenizationDescriptor = descriptor;
		return Self;
	}

	public PassThroughInferenceOptionsDescriptor Tokenization(Action<Elastic.Clients.Elasticsearch.MachineLearning.TokenizationConfigDescriptor> configure)
	{
		TokenizationValue = null;
		TokenizationDescriptor = null;
		TokenizationDescriptorAction = configure;
		return Self;
	}

	public PassThroughInferenceOptionsDescriptor Vocabulary(Elastic.Clients.Elasticsearch.MachineLearning.Vocabulary? vocabulary)
	{
		VocabularyDescriptor = null;
		VocabularyDescriptorAction = null;
		VocabularyValue = vocabulary;
		return Self;
	}

	public PassThroughInferenceOptionsDescriptor Vocabulary(Elastic.Clients.Elasticsearch.MachineLearning.VocabularyDescriptor descriptor)
	{
		VocabularyValue = null;
		VocabularyDescriptorAction = null;
		VocabularyDescriptor = descriptor;
		return Self;
	}

	public PassThroughInferenceOptionsDescriptor Vocabulary(Action<Elastic.Clients.Elasticsearch.MachineLearning.VocabularyDescriptor> configure)
	{
		VocabularyValue = null;
		VocabularyDescriptor = null;
		VocabularyDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
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
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.MachineLearning.TokenizationConfigDescriptor(TokenizationDescriptorAction), options);
		}
		else if (TokenizationValue is not null)
		{
			writer.WritePropertyName("tokenization");
			JsonSerializer.Serialize(writer, TokenizationValue, options);
		}

		if (VocabularyDescriptor is not null)
		{
			writer.WritePropertyName("vocabulary");
			JsonSerializer.Serialize(writer, VocabularyDescriptor, options);
		}
		else if (VocabularyDescriptorAction is not null)
		{
			writer.WritePropertyName("vocabulary");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.MachineLearning.VocabularyDescriptor(VocabularyDescriptorAction), options);
		}
		else if (VocabularyValue is not null)
		{
			writer.WritePropertyName("vocabulary");
			JsonSerializer.Serialize(writer, VocabularyValue, options);
		}

		writer.WriteEndObject();
	}
}