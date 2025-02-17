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
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.MachineLearning;

/// <summary>
/// <para>
/// Tokenization options stored in inference configuration
/// </para>
/// </summary>
[JsonConverter(typeof(TokenizationConfigConverter))]
public sealed partial class TokenizationConfig
{
	internal TokenizationConfig(string variantName, object variant)
	{
		if (variantName is null)
			throw new ArgumentNullException(nameof(variantName));
		if (variant is null)
			throw new ArgumentNullException(nameof(variant));
		if (string.IsNullOrWhiteSpace(variantName))
			throw new ArgumentException("Variant name must not be empty or whitespace.");
		VariantName = variantName;
		Variant = variant;
	}

	internal object Variant { get; }
	internal string VariantName { get; }

	public static TokenizationConfig Bert(Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig nlpBertTokenizationConfig) => new TokenizationConfig("bert", nlpBertTokenizationConfig);
	public static TokenizationConfig BertJa(Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig nlpBertTokenizationConfig) => new TokenizationConfig("bert_ja", nlpBertTokenizationConfig);
	public static TokenizationConfig Mpnet(Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig nlpBertTokenizationConfig) => new TokenizationConfig("mpnet", nlpBertTokenizationConfig);
	public static TokenizationConfig Roberta(Elastic.Clients.Elasticsearch.MachineLearning.NlpRobertaTokenizationConfig nlpRobertaTokenizationConfig) => new TokenizationConfig("roberta", nlpRobertaTokenizationConfig);

	public bool TryGet<T>([NotNullWhen(true)] out T? result) where T : class
	{
		result = default;
		if (Variant is T variant)
		{
			result = variant;
			return true;
		}

		return false;
	}
}

internal sealed partial class TokenizationConfigConverter : JsonConverter<TokenizationConfig>
{
	public override TokenizationConfig Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException("Expected start token.");
		}

		object? variantValue = default;
		string? variantNameValue = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException("Expected a property name token.");
			}

			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException("Expected a property name token representing the name of an Elasticsearch field.");
			}

			var propertyName = reader.GetString();
			reader.Read();
			if (propertyName == "bert")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "bert_ja")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "mpnet")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "roberta")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.MachineLearning.NlpRobertaTokenizationConfig?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			throw new JsonException($"Unknown property name '{propertyName}' received while deserializing the 'TokenizationConfig' from the response.");
		}

		var result = new TokenizationConfig(variantNameValue, variantValue);
		return result;
	}

	public override void Write(Utf8JsonWriter writer, TokenizationConfig value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (value.VariantName is not null && value.Variant is not null)
		{
			writer.WritePropertyName(value.VariantName);
			switch (value.VariantName)
			{
				case "bert":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig>(writer, (Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig)value.Variant, options);
					break;
				case "bert_ja":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig>(writer, (Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig)value.Variant, options);
					break;
				case "mpnet":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig>(writer, (Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig)value.Variant, options);
					break;
				case "roberta":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.MachineLearning.NlpRobertaTokenizationConfig>(writer, (Elastic.Clients.Elasticsearch.MachineLearning.NlpRobertaTokenizationConfig)value.Variant, options);
					break;
			}
		}

		writer.WriteEndObject();
	}
}

public sealed partial class TokenizationConfigDescriptor<TDocument> : SerializableDescriptor<TokenizationConfigDescriptor<TDocument>>
{
	internal TokenizationConfigDescriptor(Action<TokenizationConfigDescriptor<TDocument>> configure) => configure.Invoke(this);

	public TokenizationConfigDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private TokenizationConfigDescriptor<TDocument> Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private TokenizationConfigDescriptor<TDocument> Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public TokenizationConfigDescriptor<TDocument> Bert(Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig nlpBertTokenizationConfig) => Set(nlpBertTokenizationConfig, "bert");
	public TokenizationConfigDescriptor<TDocument> Bert(Action<Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfigDescriptor> configure) => Set(configure, "bert");
	public TokenizationConfigDescriptor<TDocument> BertJa(Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig nlpBertTokenizationConfig) => Set(nlpBertTokenizationConfig, "bert_ja");
	public TokenizationConfigDescriptor<TDocument> BertJa(Action<Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfigDescriptor> configure) => Set(configure, "bert_ja");
	public TokenizationConfigDescriptor<TDocument> Mpnet(Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig nlpBertTokenizationConfig) => Set(nlpBertTokenizationConfig, "mpnet");
	public TokenizationConfigDescriptor<TDocument> Mpnet(Action<Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfigDescriptor> configure) => Set(configure, "mpnet");
	public TokenizationConfigDescriptor<TDocument> Roberta(Elastic.Clients.Elasticsearch.MachineLearning.NlpRobertaTokenizationConfig nlpRobertaTokenizationConfig) => Set(nlpRobertaTokenizationConfig, "roberta");
	public TokenizationConfigDescriptor<TDocument> Roberta(Action<Elastic.Clients.Elasticsearch.MachineLearning.NlpRobertaTokenizationConfigDescriptor> configure) => Set(configure, "roberta");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(ContainedVariantName))
		{
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
				writer.WriteEndObject();
				return;
			}

			JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class TokenizationConfigDescriptor : SerializableDescriptor<TokenizationConfigDescriptor>
{
	internal TokenizationConfigDescriptor(Action<TokenizationConfigDescriptor> configure) => configure.Invoke(this);

	public TokenizationConfigDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private TokenizationConfigDescriptor Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private TokenizationConfigDescriptor Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public TokenizationConfigDescriptor Bert(Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig nlpBertTokenizationConfig) => Set(nlpBertTokenizationConfig, "bert");
	public TokenizationConfigDescriptor Bert(Action<Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfigDescriptor> configure) => Set(configure, "bert");
	public TokenizationConfigDescriptor BertJa(Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig nlpBertTokenizationConfig) => Set(nlpBertTokenizationConfig, "bert_ja");
	public TokenizationConfigDescriptor BertJa(Action<Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfigDescriptor> configure) => Set(configure, "bert_ja");
	public TokenizationConfigDescriptor Mpnet(Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfig nlpBertTokenizationConfig) => Set(nlpBertTokenizationConfig, "mpnet");
	public TokenizationConfigDescriptor Mpnet(Action<Elastic.Clients.Elasticsearch.MachineLearning.NlpBertTokenizationConfigDescriptor> configure) => Set(configure, "mpnet");
	public TokenizationConfigDescriptor Roberta(Elastic.Clients.Elasticsearch.MachineLearning.NlpRobertaTokenizationConfig nlpRobertaTokenizationConfig) => Set(nlpRobertaTokenizationConfig, "roberta");
	public TokenizationConfigDescriptor Roberta(Action<Elastic.Clients.Elasticsearch.MachineLearning.NlpRobertaTokenizationConfigDescriptor> configure) => Set(configure, "roberta");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(ContainedVariantName))
		{
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
				writer.WriteEndObject();
				return;
			}

			JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		}

		writer.WriteEndObject();
	}
}