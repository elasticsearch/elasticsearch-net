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

namespace Elastic.Clients.Elasticsearch.Aggregations;

[JsonConverter(typeof(InferenceConfigConverter))]
public sealed partial class InferenceConfig
{
	internal InferenceConfig(string variantName, object variant)
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

	public static InferenceConfig Classification(Elastic.Clients.Elasticsearch.Ml.ClassificationInferenceOptions classificationInferenceOptions) => new InferenceConfig("classification", classificationInferenceOptions);
	public static InferenceConfig Regression(Elastic.Clients.Elasticsearch.Ml.RegressionInferenceOptions regressionInferenceOptions) => new InferenceConfig("regression", regressionInferenceOptions);
}

internal sealed partial class InferenceConfigConverter : JsonConverter<InferenceConfig>
{
	public override InferenceConfig Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException("Expected start token.");
		}

		reader.Read();
		if (reader.TokenType != JsonTokenType.PropertyName)
		{
			throw new JsonException("Expected a property name token representing the variant held within this container.");
		}

		var propertyName = reader.GetString();
		reader.Read();
		if (propertyName == "classification")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.ClassificationInferenceOptions?>(ref reader, options);
			reader.Read();
			return new InferenceConfig(propertyName, variant);
		}

		if (propertyName == "regression")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.RegressionInferenceOptions?>(ref reader, options);
			reader.Read();
			return new InferenceConfig(propertyName, variant);
		}

		throw new JsonException();
	}

	public override void Write(Utf8JsonWriter writer, InferenceConfig value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (value.VariantName is not null & value.Variant is not null)
		{
			writer.WritePropertyName(value.VariantName);
			switch (value.VariantName)
			{
				case "classification":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.ClassificationInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.ClassificationInferenceOptions)value.Variant, options);
					break;
				case "regression":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.RegressionInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.RegressionInferenceOptions)value.Variant, options);
					break;
			}
		}

		writer.WriteEndObject();
	}
}

public sealed partial class InferenceConfigDescriptor<TDocument> : SerializableDescriptor<InferenceConfigDescriptor<TDocument>>
{
	internal InferenceConfigDescriptor(Action<InferenceConfigDescriptor<TDocument>> configure) => configure.Invoke(this);

	public InferenceConfigDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private InferenceConfigDescriptor<TDocument> Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private InferenceConfigDescriptor<TDocument> Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public InferenceConfigDescriptor<TDocument> Classification(Ml.ClassificationInferenceOptions classificationInferenceOptions) => Set(classificationInferenceOptions, "classification");
	public InferenceConfigDescriptor<TDocument> Classification(Action<Ml.ClassificationInferenceOptionsDescriptor> configure) => Set(configure, "classification");
	public InferenceConfigDescriptor<TDocument> Regression(Ml.RegressionInferenceOptions regressionInferenceOptions) => Set(regressionInferenceOptions, "regression");
	public InferenceConfigDescriptor<TDocument> Regression(Action<Ml.RegressionInferenceOptionsDescriptor<TDocument>> configure) => Set(configure, "regression");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (!ContainsVariant)
		{
			writer.WriteNullValue();
			return;
		}

		writer.WriteStartObject();
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

public sealed partial class InferenceConfigDescriptor : SerializableDescriptor<InferenceConfigDescriptor>
{
	internal InferenceConfigDescriptor(Action<InferenceConfigDescriptor> configure) => configure.Invoke(this);

	public InferenceConfigDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private InferenceConfigDescriptor Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private InferenceConfigDescriptor Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public InferenceConfigDescriptor Classification(Ml.ClassificationInferenceOptions classificationInferenceOptions) => Set(classificationInferenceOptions, "classification");
	public InferenceConfigDescriptor Classification(Action<Ml.ClassificationInferenceOptionsDescriptor> configure) => Set(configure, "classification");
	public InferenceConfigDescriptor Regression(Ml.RegressionInferenceOptions regressionInferenceOptions) => Set(regressionInferenceOptions, "regression");
	public InferenceConfigDescriptor Regression(Action<Ml.RegressionInferenceOptionsDescriptor> configure) => Set(configure, "regression");
	public InferenceConfigDescriptor Regression<TDocument>(Action<Ml.RegressionInferenceOptionsDescriptor<TDocument>> configure) => Set(configure, "regression");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (!ContainsVariant)
		{
			writer.WriteNullValue();
			return;
		}

		writer.WriteStartObject();
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