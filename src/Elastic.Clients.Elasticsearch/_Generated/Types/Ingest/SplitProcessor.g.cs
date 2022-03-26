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
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public partial class SplitProcessor : Ingest.ProcessorBase, IProcessorContainerVariant
	{
		[JsonIgnore]
		string Ingest.IProcessorContainerVariant.ProcessorContainerVariantName => "split";
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonInclude]
		[JsonPropertyName("preserve_trailing")]
		public bool? PreserveTrailing { get; set; }

		[JsonInclude]
		[JsonPropertyName("separator")]
		public string Separator { get; set; }

		[JsonInclude]
		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }
	}

	public sealed partial class SplitProcessorDescriptor<TDocument> : DescriptorBase<SplitProcessorDescriptor<TDocument>>
	{
		internal SplitProcessorDescriptor(Action<SplitProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);
		public SplitProcessorDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private string? IfValue { get; set; }

		private bool? IgnoreFailureValue { get; set; }

		private bool? IgnoreMissingValue { get; set; }

		private bool? PreserveTrailingValue { get; set; }

		private string SeparatorValue { get; set; }

		private string? TagValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? TargetFieldValue { get; set; }

		public SplitProcessorDescriptor<TDocument> OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure)
		{
			OnFailureValue = onFailure;
			return Self;
		}

		public SplitProcessorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public SplitProcessorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public SplitProcessorDescriptor<TDocument> If(string? ifValue)
		{
			IfValue = ifValue;
			return Self;
		}

		public SplitProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
		{
			IgnoreFailureValue = ignoreFailure;
			return Self;
		}

		public SplitProcessorDescriptor<TDocument> IgnoreMissing(bool? ignoreMissing = true)
		{
			IgnoreMissingValue = ignoreMissing;
			return Self;
		}

		public SplitProcessorDescriptor<TDocument> PreserveTrailing(bool? preserveTrailing = true)
		{
			PreserveTrailingValue = preserveTrailing;
			return Self;
		}

		public SplitProcessorDescriptor<TDocument> Separator(string separator)
		{
			SeparatorValue = separator;
			return Self;
		}

		public SplitProcessorDescriptor<TDocument> Tag(string? tag)
		{
			TagValue = tag;
			return Self;
		}

		public SplitProcessorDescriptor<TDocument> TargetField(Elastic.Clients.Elasticsearch.Field? targetField)
		{
			TargetFieldValue = targetField;
			return Self;
		}

		public SplitProcessorDescriptor<TDocument> TargetField<TValue>(Expression<Func<TDocument, TValue>> targetField)
		{
			TargetFieldValue = targetField;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (!string.IsNullOrEmpty(IfValue))
			{
				writer.WritePropertyName("if");
				writer.WriteStringValue(IfValue);
			}

			if (IgnoreFailureValue.HasValue)
			{
				writer.WritePropertyName("ignore_failure");
				writer.WriteBooleanValue(IgnoreFailureValue.Value);
			}

			if (IgnoreMissingValue.HasValue)
			{
				writer.WritePropertyName("ignore_missing");
				writer.WriteBooleanValue(IgnoreMissingValue.Value);
			}

			if (PreserveTrailingValue.HasValue)
			{
				writer.WritePropertyName("preserve_trailing");
				writer.WriteBooleanValue(PreserveTrailingValue.Value);
			}

			writer.WritePropertyName("separator");
			writer.WriteStringValue(SeparatorValue);
			if (!string.IsNullOrEmpty(TagValue))
			{
				writer.WritePropertyName("tag");
				writer.WriteStringValue(TagValue);
			}

			if (TargetFieldValue is not null)
			{
				writer.WritePropertyName("target_field");
				JsonSerializer.Serialize(writer, TargetFieldValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class SplitProcessorDescriptor : DescriptorBase<SplitProcessorDescriptor>
	{
		internal SplitProcessorDescriptor(Action<SplitProcessorDescriptor> configure) => configure.Invoke(this);
		public SplitProcessorDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private string? IfValue { get; set; }

		private bool? IgnoreFailureValue { get; set; }

		private bool? IgnoreMissingValue { get; set; }

		private bool? PreserveTrailingValue { get; set; }

		private string SeparatorValue { get; set; }

		private string? TagValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? TargetFieldValue { get; set; }

		public SplitProcessorDescriptor OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure)
		{
			OnFailureValue = onFailure;
			return Self;
		}

		public SplitProcessorDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public SplitProcessorDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public SplitProcessorDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public SplitProcessorDescriptor If(string? ifValue)
		{
			IfValue = ifValue;
			return Self;
		}

		public SplitProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
		{
			IgnoreFailureValue = ignoreFailure;
			return Self;
		}

		public SplitProcessorDescriptor IgnoreMissing(bool? ignoreMissing = true)
		{
			IgnoreMissingValue = ignoreMissing;
			return Self;
		}

		public SplitProcessorDescriptor PreserveTrailing(bool? preserveTrailing = true)
		{
			PreserveTrailingValue = preserveTrailing;
			return Self;
		}

		public SplitProcessorDescriptor Separator(string separator)
		{
			SeparatorValue = separator;
			return Self;
		}

		public SplitProcessorDescriptor Tag(string? tag)
		{
			TagValue = tag;
			return Self;
		}

		public SplitProcessorDescriptor TargetField(Elastic.Clients.Elasticsearch.Field? targetField)
		{
			TargetFieldValue = targetField;
			return Self;
		}

		public SplitProcessorDescriptor TargetField<TDocument, TValue>(Expression<Func<TDocument, TValue>> targetField)
		{
			TargetFieldValue = targetField;
			return Self;
		}

		public SplitProcessorDescriptor TargetField<TDocument>(Expression<Func<TDocument, object>> targetField)
		{
			TargetFieldValue = targetField;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (!string.IsNullOrEmpty(IfValue))
			{
				writer.WritePropertyName("if");
				writer.WriteStringValue(IfValue);
			}

			if (IgnoreFailureValue.HasValue)
			{
				writer.WritePropertyName("ignore_failure");
				writer.WriteBooleanValue(IgnoreFailureValue.Value);
			}

			if (IgnoreMissingValue.HasValue)
			{
				writer.WritePropertyName("ignore_missing");
				writer.WriteBooleanValue(IgnoreMissingValue.Value);
			}

			if (PreserveTrailingValue.HasValue)
			{
				writer.WritePropertyName("preserve_trailing");
				writer.WriteBooleanValue(PreserveTrailingValue.Value);
			}

			writer.WritePropertyName("separator");
			writer.WriteStringValue(SeparatorValue);
			if (!string.IsNullOrEmpty(TagValue))
			{
				writer.WritePropertyName("tag");
				writer.WriteStringValue(TagValue);
			}

			if (TargetFieldValue is not null)
			{
				writer.WritePropertyName("target_field");
				JsonSerializer.Serialize(writer, TargetFieldValue, options);
			}

			writer.WriteEndObject();
		}
	}
}