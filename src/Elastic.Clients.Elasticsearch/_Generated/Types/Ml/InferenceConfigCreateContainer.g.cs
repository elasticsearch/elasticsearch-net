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
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public interface IInferenceConfigCreateVariant
	{
		string InferenceConfigCreateVariantName { get; }
	}

	[JsonConverter(typeof(InferenceConfigCreateContainerConverter))]
	public partial class InferenceConfigCreateContainer
	{
		public InferenceConfigCreateContainer(IInferenceConfigCreateVariant variant) => Variant = variant ?? throw new ArgumentNullException(nameof(variant));
		internal IInferenceConfigCreateVariant Variant { get; }

		internal string VariantName => Variant.InferenceConfigCreateVariantName;
	}

	internal sealed class InferenceConfigCreateContainerConverter : JsonConverter<InferenceConfigCreateContainer>
	{
		public override InferenceConfigCreateContainer Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var readerCopy = reader;
			readerCopy.Read();
			if (readerCopy.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException();
			}

			var propertyName = readerCopy.GetString();
			if (propertyName == "classification")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.ClassificationInferenceOptions?>(ref reader, options);
				return new InferenceConfigCreateContainer(variant);
			}

			if (propertyName == "fill_mask")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.FillMaskInferenceOptions?>(ref reader, options);
				return new InferenceConfigCreateContainer(variant);
			}

			if (propertyName == "ner")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.NerInferenceOptions?>(ref reader, options);
				return new InferenceConfigCreateContainer(variant);
			}

			if (propertyName == "pass_through")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.PassThroughInferenceOptions?>(ref reader, options);
				return new InferenceConfigCreateContainer(variant);
			}

			if (propertyName == "question_answering")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.QuestionAnsweringInferenceOptions?>(ref reader, options);
				return new InferenceConfigCreateContainer(variant);
			}

			if (propertyName == "regression")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.RegressionInferenceOptions?>(ref reader, options);
				return new InferenceConfigCreateContainer(variant);
			}

			if (propertyName == "text_classification")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.TextClassificationInferenceOptions?>(ref reader, options);
				return new InferenceConfigCreateContainer(variant);
			}

			if (propertyName == "text_embedding")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.TextEmbeddingInferenceOptions?>(ref reader, options);
				return new InferenceConfigCreateContainer(variant);
			}

			if (propertyName == "zero_shot_classification")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.ZeroShotClassificationInferenceOptions?>(ref reader, options);
				return new InferenceConfigCreateContainer(variant);
			}

			throw new JsonException();
		}

		public override void Write(Utf8JsonWriter writer, InferenceConfigCreateContainer value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName(value.Variant.InferenceConfigCreateVariantName);
			switch (value.VariantName)
			{
				case "classification":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.ClassificationInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.ClassificationInferenceOptions)value.Variant, options);
					break;
				case "fill_mask":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.FillMaskInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.FillMaskInferenceOptions)value.Variant, options);
					break;
				case "ner":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.NerInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.NerInferenceOptions)value.Variant, options);
					break;
				case "pass_through":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.PassThroughInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.PassThroughInferenceOptions)value.Variant, options);
					break;
				case "question_answering":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.QuestionAnsweringInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.QuestionAnsweringInferenceOptions)value.Variant, options);
					break;
				case "regression":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.RegressionInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.RegressionInferenceOptions)value.Variant, options);
					break;
				case "text_classification":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.TextClassificationInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.TextClassificationInferenceOptions)value.Variant, options);
					break;
				case "text_embedding":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.TextEmbeddingInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.TextEmbeddingInferenceOptions)value.Variant, options);
					break;
				case "zero_shot_classification":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.ZeroShotClassificationInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.ZeroShotClassificationInferenceOptions)value.Variant, options);
					break;
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class InferenceConfigCreateContainerDescriptor<TDocument> : SerializableDescriptorBase<InferenceConfigCreateContainerDescriptor<TDocument>>
	{
		internal InferenceConfigCreateContainerDescriptor(Action<InferenceConfigCreateContainerDescriptor<TDocument>> configure) => configure.Invoke(this);
		public InferenceConfigCreateContainerDescriptor() : base()
		{
		}

		internal bool ContainsVariant { get; private set; }

		internal string ContainedVariantName { get; private set; }

		internal InferenceConfigCreateContainer Container { get; private set; }

		internal Descriptor Descriptor { get; private set; }

		internal Type DescriptorType { get; private set; }

		private void Set<T>(Action<T> descriptorAction, string variantName)
			where T : Descriptor, new()
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			ContainedVariantName = variantName;
			ContainsVariant = true;
			DescriptorType = typeof(T);
			var descriptor = new T();
			descriptorAction?.Invoke(descriptor);
			Descriptor = descriptor;
		}

		private void Set(IInferenceConfigCreateVariant variant, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			Container = new InferenceConfigCreateContainer(variant);
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (!ContainsVariant)
			{
				writer.WriteNullValue();
				return;
			}

			if (Container is not null)
			{
				JsonSerializer.Serialize(writer, Container, options);
				return;
			}

			writer.WriteStartObject();
			writer.WritePropertyName(ContainedVariantName);
			JsonSerializer.Serialize(writer, Descriptor, DescriptorType, options);
			writer.WriteEndObject();
		}

		public void Classification(ClassificationInferenceOptions variant) => Set(variant, "classification");
		public void Classification(Action<ClassificationInferenceOptionsDescriptor> configure) => Set(configure, "classification");
		public void FillMask(FillMaskInferenceOptions variant) => Set(variant, "fill_mask");
		public void FillMask(Action<FillMaskInferenceOptionsDescriptor> configure) => Set(configure, "fill_mask");
		public void Ner(NerInferenceOptions variant) => Set(variant, "ner");
		public void Ner(Action<NerInferenceOptionsDescriptor> configure) => Set(configure, "ner");
		public void PassThrough(PassThroughInferenceOptions variant) => Set(variant, "pass_through");
		public void PassThrough(Action<PassThroughInferenceOptionsDescriptor> configure) => Set(configure, "pass_through");
		public void QuestionAnswering(QuestionAnsweringInferenceOptions variant) => Set(variant, "question_answering");
		public void QuestionAnswering(Action<QuestionAnsweringInferenceOptionsDescriptor> configure) => Set(configure, "question_answering");
		public void Regression(RegressionInferenceOptions variant) => Set(variant, "regression");
		public void Regression(Action<RegressionInferenceOptionsDescriptor<TDocument>> configure) => Set(configure, "regression");
		public void TextClassification(TextClassificationInferenceOptions variant) => Set(variant, "text_classification");
		public void TextClassification(Action<TextClassificationInferenceOptionsDescriptor> configure) => Set(configure, "text_classification");
		public void TextEmbedding(TextEmbeddingInferenceOptions variant) => Set(variant, "text_embedding");
		public void TextEmbedding(Action<TextEmbeddingInferenceOptionsDescriptor> configure) => Set(configure, "text_embedding");
		public void ZeroShotClassification(ZeroShotClassificationInferenceOptions variant) => Set(variant, "zero_shot_classification");
		public void ZeroShotClassification(Action<ZeroShotClassificationInferenceOptionsDescriptor> configure) => Set(configure, "zero_shot_classification");
	}

	public sealed partial class InferenceConfigCreateContainerDescriptor : SerializableDescriptorBase<InferenceConfigCreateContainerDescriptor>
	{
		internal InferenceConfigCreateContainerDescriptor(Action<InferenceConfigCreateContainerDescriptor> configure) => configure.Invoke(this);
		public InferenceConfigCreateContainerDescriptor() : base()
		{
		}

		internal bool ContainsVariant { get; private set; }

		internal string ContainedVariantName { get; private set; }

		internal InferenceConfigCreateContainer Container { get; private set; }

		internal Descriptor Descriptor { get; private set; }

		internal Type DescriptorType { get; private set; }

		private void Set<T>(Action<T> descriptorAction, string variantName)
			where T : Descriptor, new()
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			ContainedVariantName = variantName;
			ContainsVariant = true;
			DescriptorType = typeof(T);
			var descriptor = new T();
			descriptorAction?.Invoke(descriptor);
			Descriptor = descriptor;
		}

		private void Set(IInferenceConfigCreateVariant variant, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			Container = new InferenceConfigCreateContainer(variant);
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (!ContainsVariant)
			{
				writer.WriteNullValue();
				return;
			}

			if (Container is not null)
			{
				JsonSerializer.Serialize(writer, Container, options);
				return;
			}

			writer.WriteStartObject();
			writer.WritePropertyName(ContainedVariantName);
			JsonSerializer.Serialize(writer, Descriptor, DescriptorType, options);
			writer.WriteEndObject();
		}

		public void Classification(ClassificationInferenceOptions variant) => Set(variant, "classification");
		public void Classification(Action<ClassificationInferenceOptionsDescriptor> configure) => Set(configure, "classification");
		public void FillMask(FillMaskInferenceOptions variant) => Set(variant, "fill_mask");
		public void FillMask(Action<FillMaskInferenceOptionsDescriptor> configure) => Set(configure, "fill_mask");
		public void Ner(NerInferenceOptions variant) => Set(variant, "ner");
		public void Ner(Action<NerInferenceOptionsDescriptor> configure) => Set(configure, "ner");
		public void PassThrough(PassThroughInferenceOptions variant) => Set(variant, "pass_through");
		public void PassThrough(Action<PassThroughInferenceOptionsDescriptor> configure) => Set(configure, "pass_through");
		public void QuestionAnswering(QuestionAnsweringInferenceOptions variant) => Set(variant, "question_answering");
		public void QuestionAnswering(Action<QuestionAnsweringInferenceOptionsDescriptor> configure) => Set(configure, "question_answering");
		public void Regression(RegressionInferenceOptions variant) => Set(variant, "regression");
		public void Regression(Action<RegressionInferenceOptionsDescriptor> configure) => Set(configure, "regression");
		public void Regression<TDocument>(Action<RegressionInferenceOptionsDescriptor<TDocument>> configure) => Set(configure, "regression");
		public void TextClassification(TextClassificationInferenceOptions variant) => Set(variant, "text_classification");
		public void TextClassification(Action<TextClassificationInferenceOptionsDescriptor> configure) => Set(configure, "text_classification");
		public void TextEmbedding(TextEmbeddingInferenceOptions variant) => Set(variant, "text_embedding");
		public void TextEmbedding(Action<TextEmbeddingInferenceOptionsDescriptor> configure) => Set(configure, "text_embedding");
		public void ZeroShotClassification(ZeroShotClassificationInferenceOptions variant) => Set(variant, "zero_shot_classification");
		public void ZeroShotClassification(Action<ZeroShotClassificationInferenceOptionsDescriptor> configure) => Set(configure, "zero_shot_classification");
	}
}