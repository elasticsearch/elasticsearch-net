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
	public partial class CsvProcessor : ProcessorBase, IProcessorVariant
	{
		[JsonInclude]
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		[JsonInclude]
		[JsonPropertyName("empty_value")]
		public object EmptyValue { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonInclude]
		[JsonPropertyName("quote")]
		public string? Quote { get; set; }

		[JsonInclude]
		[JsonPropertyName("separator")]
		public string? Separator { get; set; }

		[JsonInclude]
		[JsonPropertyName("target_fields")]
		public Elastic.Clients.Elasticsearch.Fields TargetFields { get; set; }

		[JsonInclude]
		[JsonPropertyName("trim")]
		public bool Trim { get; set; }
	}

	public sealed partial class CsvProcessorDescriptor<TDocument> : SerializableDescriptorBase<CsvProcessorDescriptor<TDocument>>
	{
		internal CsvProcessorDescriptor(Action<CsvProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);
		public CsvProcessorDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; set; }

		private ProcessorContainerDescriptor<TDocument> OnFailureDescriptor { get; set; }

		private Action<ProcessorContainerDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }

		private Action<ProcessorContainerDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }

		private string? DescriptionValue { get; set; }

		private object EmptyValueValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private string? IfValue { get; set; }

		private bool? IgnoreFailureValue { get; set; }

		private bool? IgnoreMissingValue { get; set; }

		private string? QuoteValue { get; set; }

		private string? SeparatorValue { get; set; }

		private string? TagValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields TargetFieldsValue { get; set; }

		private bool TrimValue { get; set; }

		public CsvProcessorDescriptor<TDocument> OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure)
		{
			OnFailureDescriptor = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = null;
			OnFailureValue = onFailure;
			return Self;
		}

		public CsvProcessorDescriptor<TDocument> OnFailure(ProcessorContainerDescriptor<TDocument> descriptor)
		{
			OnFailureValue = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = null;
			OnFailureDescriptor = descriptor;
			return Self;
		}

		public CsvProcessorDescriptor<TDocument> OnFailure(Action<ProcessorContainerDescriptor<TDocument>> configure)
		{
			OnFailureValue = null;
			OnFailureDescriptor = null;
			OnFailureDescriptorActions = null;
			OnFailureDescriptorAction = configure;
			return Self;
		}

		public CsvProcessorDescriptor<TDocument> OnFailure(params Action<ProcessorContainerDescriptor<TDocument>>[] configure)
		{
			OnFailureValue = null;
			OnFailureDescriptor = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = configure;
			return Self;
		}

		public CsvProcessorDescriptor<TDocument> Description(string? description)
		{
			DescriptionValue = description;
			return Self;
		}

		public CsvProcessorDescriptor<TDocument> EmptyValue(object emptyValue)
		{
			EmptyValueValue = emptyValue;
			return Self;
		}

		public CsvProcessorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public CsvProcessorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public CsvProcessorDescriptor<TDocument> If(string? ifValue)
		{
			IfValue = ifValue;
			return Self;
		}

		public CsvProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
		{
			IgnoreFailureValue = ignoreFailure;
			return Self;
		}

		public CsvProcessorDescriptor<TDocument> IgnoreMissing(bool? ignoreMissing = true)
		{
			IgnoreMissingValue = ignoreMissing;
			return Self;
		}

		public CsvProcessorDescriptor<TDocument> Quote(string? quote)
		{
			QuoteValue = quote;
			return Self;
		}

		public CsvProcessorDescriptor<TDocument> Separator(string? separator)
		{
			SeparatorValue = separator;
			return Self;
		}

		public CsvProcessorDescriptor<TDocument> Tag(string? tag)
		{
			TagValue = tag;
			return Self;
		}

		public CsvProcessorDescriptor<TDocument> TargetFields(Elastic.Clients.Elasticsearch.Fields targetFields)
		{
			TargetFieldsValue = targetFields;
			return Self;
		}

		public CsvProcessorDescriptor<TDocument> TargetFields<TValue>(Expression<Func<TDocument, TValue>> targetFields)
		{
			TargetFieldsValue = targetFields;
			return Self;
		}

		public CsvProcessorDescriptor<TDocument> Trim(bool trim = true)
		{
			TrimValue = trim;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (OnFailureDescriptor is not null)
			{
				writer.WritePropertyName("on_failure");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
				writer.WriteEndArray();
			}
			else if (OnFailureDescriptorAction is not null)
			{
				writer.WritePropertyName("on_failure");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, new ProcessorContainerDescriptor<TDocument>(OnFailureDescriptorAction), options);
				writer.WriteEndArray();
			}
			else if (OnFailureDescriptorActions is not null)
			{
				writer.WritePropertyName("on_failure");
				writer.WriteStartArray();
				foreach (var action in OnFailureDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new ProcessorContainerDescriptor<TDocument>(action), options);
				}

				writer.WriteEndArray();
			}
			else if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
			}

			if (!string.IsNullOrEmpty(DescriptionValue))
			{
				writer.WritePropertyName("description");
				writer.WriteStringValue(DescriptionValue);
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

			if (!string.IsNullOrEmpty(QuoteValue))
			{
				writer.WritePropertyName("quote");
				writer.WriteStringValue(QuoteValue);
			}

			if (!string.IsNullOrEmpty(SeparatorValue))
			{
				writer.WritePropertyName("separator");
				writer.WriteStringValue(SeparatorValue);
			}

			if (!string.IsNullOrEmpty(TagValue))
			{
				writer.WritePropertyName("tag");
				writer.WriteStringValue(TagValue);
			}

			writer.WritePropertyName("target_fields");
			JsonSerializer.Serialize(writer, TargetFieldsValue, options);
			writer.WritePropertyName("trim");
			writer.WriteBooleanValue(TrimValue);
			writer.WriteEndObject();
		}
	}

	public sealed partial class CsvProcessorDescriptor : SerializableDescriptorBase<CsvProcessorDescriptor>
	{
		internal CsvProcessorDescriptor(Action<CsvProcessorDescriptor> configure) => configure.Invoke(this);
		public CsvProcessorDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; set; }

		private ProcessorContainerDescriptor OnFailureDescriptor { get; set; }

		private Action<ProcessorContainerDescriptor> OnFailureDescriptorAction { get; set; }

		private Action<ProcessorContainerDescriptor>[] OnFailureDescriptorActions { get; set; }

		private string? DescriptionValue { get; set; }

		private object EmptyValueValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private string? IfValue { get; set; }

		private bool? IgnoreFailureValue { get; set; }

		private bool? IgnoreMissingValue { get; set; }

		private string? QuoteValue { get; set; }

		private string? SeparatorValue { get; set; }

		private string? TagValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields TargetFieldsValue { get; set; }

		private bool TrimValue { get; set; }

		public CsvProcessorDescriptor OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure)
		{
			OnFailureDescriptor = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = null;
			OnFailureValue = onFailure;
			return Self;
		}

		public CsvProcessorDescriptor OnFailure(ProcessorContainerDescriptor descriptor)
		{
			OnFailureValue = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = null;
			OnFailureDescriptor = descriptor;
			return Self;
		}

		public CsvProcessorDescriptor OnFailure(Action<ProcessorContainerDescriptor> configure)
		{
			OnFailureValue = null;
			OnFailureDescriptor = null;
			OnFailureDescriptorActions = null;
			OnFailureDescriptorAction = configure;
			return Self;
		}

		public CsvProcessorDescriptor OnFailure(params Action<ProcessorContainerDescriptor>[] configure)
		{
			OnFailureValue = null;
			OnFailureDescriptor = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = configure;
			return Self;
		}

		public CsvProcessorDescriptor Description(string? description)
		{
			DescriptionValue = description;
			return Self;
		}

		public CsvProcessorDescriptor EmptyValue(object emptyValue)
		{
			EmptyValueValue = emptyValue;
			return Self;
		}

		public CsvProcessorDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public CsvProcessorDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public CsvProcessorDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public CsvProcessorDescriptor If(string? ifValue)
		{
			IfValue = ifValue;
			return Self;
		}

		public CsvProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
		{
			IgnoreFailureValue = ignoreFailure;
			return Self;
		}

		public CsvProcessorDescriptor IgnoreMissing(bool? ignoreMissing = true)
		{
			IgnoreMissingValue = ignoreMissing;
			return Self;
		}

		public CsvProcessorDescriptor Quote(string? quote)
		{
			QuoteValue = quote;
			return Self;
		}

		public CsvProcessorDescriptor Separator(string? separator)
		{
			SeparatorValue = separator;
			return Self;
		}

		public CsvProcessorDescriptor Tag(string? tag)
		{
			TagValue = tag;
			return Self;
		}

		public CsvProcessorDescriptor TargetFields(Elastic.Clients.Elasticsearch.Fields targetFields)
		{
			TargetFieldsValue = targetFields;
			return Self;
		}

		public CsvProcessorDescriptor TargetFields<TDocument, TValue>(Expression<Func<TDocument, TValue>> targetFields)
		{
			TargetFieldsValue = targetFields;
			return Self;
		}

		public CsvProcessorDescriptor TargetFields<TDocument>(Expression<Func<TDocument, object>> targetFields)
		{
			TargetFieldsValue = targetFields;
			return Self;
		}

		public CsvProcessorDescriptor Trim(bool trim = true)
		{
			TrimValue = trim;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (OnFailureDescriptor is not null)
			{
				writer.WritePropertyName("on_failure");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
				writer.WriteEndArray();
			}
			else if (OnFailureDescriptorAction is not null)
			{
				writer.WritePropertyName("on_failure");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, new ProcessorContainerDescriptor(OnFailureDescriptorAction), options);
				writer.WriteEndArray();
			}
			else if (OnFailureDescriptorActions is not null)
			{
				writer.WritePropertyName("on_failure");
				writer.WriteStartArray();
				foreach (var action in OnFailureDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new ProcessorContainerDescriptor(action), options);
				}

				writer.WriteEndArray();
			}
			else if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
			}

			if (!string.IsNullOrEmpty(DescriptionValue))
			{
				writer.WritePropertyName("description");
				writer.WriteStringValue(DescriptionValue);
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

			if (!string.IsNullOrEmpty(QuoteValue))
			{
				writer.WritePropertyName("quote");
				writer.WriteStringValue(QuoteValue);
			}

			if (!string.IsNullOrEmpty(SeparatorValue))
			{
				writer.WritePropertyName("separator");
				writer.WriteStringValue(SeparatorValue);
			}

			if (!string.IsNullOrEmpty(TagValue))
			{
				writer.WritePropertyName("tag");
				writer.WriteStringValue(TagValue);
			}

			writer.WritePropertyName("target_fields");
			JsonSerializer.Serialize(writer, TargetFieldsValue, options);
			writer.WritePropertyName("trim");
			writer.WriteBooleanValue(TrimValue);
			writer.WriteEndObject();
		}
	}
}