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
namespace Elastic.Clients.Elasticsearch.Core.Search;
[JsonConverter(typeof(FieldSuggesterConverter))]
public sealed partial class FieldSuggester
{
	internal FieldSuggester(string variantName, object variant)
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

	public static FieldSuggester Completion(Elastic.Clients.Elasticsearch.Core.Search.CompletionSuggester completionSuggester) => new FieldSuggester("completion", completionSuggester);
	public static FieldSuggester Phrase(Elastic.Clients.Elasticsearch.Core.Search.PhraseSuggester phraseSuggester) => new FieldSuggester("phrase", phraseSuggester);
	public static FieldSuggester Term(Elastic.Clients.Elasticsearch.Core.Search.TermSuggester termSuggester) => new FieldSuggester("term", termSuggester);
	[JsonInclude, JsonPropertyName("prefix")]
	public string? Prefix { get; set; }

	[JsonInclude, JsonPropertyName("regex")]
	public string? Regex { get; set; }

	[JsonInclude, JsonPropertyName("text")]
	public string? Text { get; set; }
}

internal sealed partial class FieldSuggesterConverter : JsonConverter<FieldSuggester>
{
	public override FieldSuggester Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException("Expected start token.");
		}

		object? variantValue = default;
		string? variantNameValue = default;
		string? prefixValue = default;
		string? regexValue = default;
		string? textValue = default;
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
			if (propertyName == "prefix")
			{
				prefixValue = JsonSerializer.Deserialize<string?>(ref reader, options);
				continue;
			}

			if (propertyName == "regex")
			{
				regexValue = JsonSerializer.Deserialize<string?>(ref reader, options);
				continue;
			}

			if (propertyName == "text")
			{
				textValue = JsonSerializer.Deserialize<string?>(ref reader, options);
				continue;
			}

			if (propertyName == "completion")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Core.Search.CompletionSuggester?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "phrase")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Core.Search.PhraseSuggester?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "term")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Core.Search.TermSuggester?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			throw new JsonException($"Unknown property name '{propertyName}' received while deserializing the 'FieldSuggester' from the response.");
		}

		reader.Read();
		var result = new FieldSuggester(variantNameValue, variantValue);
		result.Prefix = prefixValue;
		result.Regex = regexValue;
		result.Text = textValue;
		return result;
	}

	public override void Write(Utf8JsonWriter writer, FieldSuggester value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(value.Prefix))
		{
			writer.WritePropertyName("prefix");
			writer.WriteStringValue(value.Prefix);
		}

		if (!string.IsNullOrEmpty(value.Regex))
		{
			writer.WritePropertyName("regex");
			writer.WriteStringValue(value.Regex);
		}

		if (!string.IsNullOrEmpty(value.Text))
		{
			writer.WritePropertyName("text");
			writer.WriteStringValue(value.Text);
		}

		writer.WritePropertyName(value.VariantName);
		switch (value.VariantName)
		{
			case "completion":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Core.Search.CompletionSuggester>(writer, (Elastic.Clients.Elasticsearch.Core.Search.CompletionSuggester)value.Variant, options);
				break;
			case "phrase":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Core.Search.PhraseSuggester>(writer, (Elastic.Clients.Elasticsearch.Core.Search.PhraseSuggester)value.Variant, options);
				break;
			case "term":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Core.Search.TermSuggester>(writer, (Elastic.Clients.Elasticsearch.Core.Search.TermSuggester)value.Variant, options);
				break;
		}

		writer.WriteEndObject();
	}
}

public sealed partial class FieldSuggesterDescriptor<TDocument> : SerializableDescriptor<FieldSuggesterDescriptor<TDocument>>
{
	internal FieldSuggesterDescriptor(Action<FieldSuggesterDescriptor<TDocument>> configure) => configure.Invoke(this);
	public FieldSuggesterDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }

	private string ContainedVariantName { get; set; }

	private object Variant { get; set; }

	private Descriptor Descriptor { get; set; }

	private FieldSuggesterDescriptor<TDocument> Set<T>(Action<T> descriptorAction, string variantName)
		where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private FieldSuggesterDescriptor<TDocument> Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	private string? PrefixValue { get; set; }

	private string? RegexValue { get; set; }

	private string? TextValue { get; set; }

	public FieldSuggesterDescriptor<TDocument> Prefix(string? prefix)
	{
		PrefixValue = prefix;
		return Self;
	}

	public FieldSuggesterDescriptor<TDocument> Regex(string? regex)
	{
		RegexValue = regex;
		return Self;
	}

	public FieldSuggesterDescriptor<TDocument> Text(string? text)
	{
		TextValue = text;
		return Self;
	}

	public FieldSuggesterDescriptor<TDocument> Completion(CompletionSuggester completionSuggester) => Set(completionSuggester, "completion");
	public FieldSuggesterDescriptor<TDocument> Completion(Action<CompletionSuggesterDescriptor<TDocument>> configure) => Set(configure, "completion");
	public FieldSuggesterDescriptor<TDocument> Phrase(PhraseSuggester phraseSuggester) => Set(phraseSuggester, "phrase");
	public FieldSuggesterDescriptor<TDocument> Phrase(Action<PhraseSuggesterDescriptor<TDocument>> configure) => Set(configure, "phrase");
	public FieldSuggesterDescriptor<TDocument> Term(TermSuggester termSuggester) => Set(termSuggester, "term");
	public FieldSuggesterDescriptor<TDocument> Term(Action<TermSuggesterDescriptor<TDocument>> configure) => Set(configure, "term");
	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (!ContainsVariant)
		{
			writer.WriteNullValue();
			return;
		}

		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(PrefixValue))
		{
			writer.WritePropertyName("prefix");
			writer.WriteStringValue(PrefixValue);
		}

		if (!string.IsNullOrEmpty(RegexValue))
		{
			writer.WritePropertyName("regex");
			writer.WriteStringValue(RegexValue);
		}

		if (!string.IsNullOrEmpty(TextValue))
		{
			writer.WritePropertyName("text");
			writer.WriteStringValue(TextValue);
		}

		writer.WritePropertyName(ContainedVariantName);
		if (Variant is not null)
		{
			JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
			writer.WriteEndObject();
			return;
		}

		JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		writer.WriteEndObject();
	}
}

public sealed partial class FieldSuggesterDescriptor : SerializableDescriptor<FieldSuggesterDescriptor>
{
	internal FieldSuggesterDescriptor(Action<FieldSuggesterDescriptor> configure) => configure.Invoke(this);
	public FieldSuggesterDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }

	private string ContainedVariantName { get; set; }

	private object Variant { get; set; }

	private Descriptor Descriptor { get; set; }

	private FieldSuggesterDescriptor Set<T>(Action<T> descriptorAction, string variantName)
		where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private FieldSuggesterDescriptor Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	private string? PrefixValue { get; set; }

	private string? RegexValue { get; set; }

	private string? TextValue { get; set; }

	public FieldSuggesterDescriptor Prefix(string? prefix)
	{
		PrefixValue = prefix;
		return Self;
	}

	public FieldSuggesterDescriptor Regex(string? regex)
	{
		RegexValue = regex;
		return Self;
	}

	public FieldSuggesterDescriptor Text(string? text)
	{
		TextValue = text;
		return Self;
	}

	public FieldSuggesterDescriptor Completion(CompletionSuggester completionSuggester) => Set(completionSuggester, "completion");
	public FieldSuggesterDescriptor Completion(Action<CompletionSuggesterDescriptor> configure) => Set(configure, "completion");
	public FieldSuggesterDescriptor Completion<TDocument>(Action<CompletionSuggesterDescriptor<TDocument>> configure) => Set(configure, "completion");
	public FieldSuggesterDescriptor Phrase(PhraseSuggester phraseSuggester) => Set(phraseSuggester, "phrase");
	public FieldSuggesterDescriptor Phrase(Action<PhraseSuggesterDescriptor> configure) => Set(configure, "phrase");
	public FieldSuggesterDescriptor Phrase<TDocument>(Action<PhraseSuggesterDescriptor<TDocument>> configure) => Set(configure, "phrase");
	public FieldSuggesterDescriptor Term(TermSuggester termSuggester) => Set(termSuggester, "term");
	public FieldSuggesterDescriptor Term(Action<TermSuggesterDescriptor> configure) => Set(configure, "term");
	public FieldSuggesterDescriptor Term<TDocument>(Action<TermSuggesterDescriptor<TDocument>> configure) => Set(configure, "term");
	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (!ContainsVariant)
		{
			writer.WriteNullValue();
			return;
		}

		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(PrefixValue))
		{
			writer.WritePropertyName("prefix");
			writer.WriteStringValue(PrefixValue);
		}

		if (!string.IsNullOrEmpty(RegexValue))
		{
			writer.WritePropertyName("regex");
			writer.WriteStringValue(RegexValue);
		}

		if (!string.IsNullOrEmpty(TextValue))
		{
			writer.WritePropertyName("text");
			writer.WriteStringValue(TextValue);
		}

		writer.WritePropertyName(ContainedVariantName);
		if (Variant is not null)
		{
			JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
			writer.WriteEndObject();
			return;
		}

		JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		writer.WriteEndObject();
	}
}