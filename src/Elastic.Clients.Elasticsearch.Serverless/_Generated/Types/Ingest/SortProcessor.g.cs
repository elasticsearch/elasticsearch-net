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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Ingest;

public sealed partial class SortProcessor
{
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// <para>The field to be sorted.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field Field { get; set; }
	[JsonInclude, JsonPropertyName("if")]
	public string? If { get; set; }
	[JsonInclude, JsonPropertyName("ignore_failure")]
	public bool? IgnoreFailure { get; set; }
	[JsonInclude, JsonPropertyName("on_failure")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailure { get; set; }

	/// <summary>
	/// <para>The sort order to use.<br/>Accepts `"asc"` or `"desc"`.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("order")]
	public Elastic.Clients.Elasticsearch.Serverless.SortOrder? Order { get; set; }
	[JsonInclude, JsonPropertyName("tag")]
	public string? Tag { get; set; }

	/// <summary>
	/// <para>The field to assign the sorted value to.<br/>By default, the field is updated in-place.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("target_field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field? TargetField { get; set; }

	public static implicit operator Processor(SortProcessor sortProcessor) => Ingest.Processor.Sort(sortProcessor);
}

public sealed partial class SortProcessorDescriptor<TDocument> : SerializableDescriptor<SortProcessorDescriptor<TDocument>>
{
	internal SortProcessorDescriptor(Action<SortProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);

	public SortProcessorDescriptor() : base()
	{
	}

	private string? DescriptionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailureValue { get; set; }
	private ProcessorDescriptor<TDocument> OnFailureDescriptor { get; set; }
	private Action<ProcessorDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }
	private Action<ProcessorDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.SortOrder? OrderValue { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? TargetFieldValue { get; set; }

	public SortProcessorDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>The field to be sorted.</para>
	/// </summary>
	public SortProcessorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to be sorted.</para>
	/// </summary>
	public SortProcessorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public SortProcessorDescriptor<TDocument> If(string? ifValue)
	{
		IfValue = ifValue;
		return Self;
	}

	public SortProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	public SortProcessorDescriptor<TDocument> OnFailure(ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public SortProcessorDescriptor<TDocument> OnFailure(ProcessorDescriptor<TDocument> descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public SortProcessorDescriptor<TDocument> OnFailure(Action<ProcessorDescriptor<TDocument>> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public SortProcessorDescriptor<TDocument> OnFailure(params Action<ProcessorDescriptor<TDocument>>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>The sort order to use.<br/>Accepts `"asc"` or `"desc"`.</para>
	/// </summary>
	public SortProcessorDescriptor<TDocument> Order(Elastic.Clients.Elasticsearch.Serverless.SortOrder? order)
	{
		OrderValue = order;
		return Self;
	}

	public SortProcessorDescriptor<TDocument> Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>The field to assign the sorted value to.<br/>By default, the field is updated in-place.</para>
	/// </summary>
	public SortProcessorDescriptor<TDocument> TargetField(Elastic.Clients.Elasticsearch.Serverless.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field to assign the sorted value to.<br/>By default, the field is updated in-place.</para>
	/// </summary>
	public SortProcessorDescriptor<TDocument> TargetField<TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
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
			JsonSerializer.Serialize(writer, new ProcessorDescriptor<TDocument>(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new ProcessorDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			JsonSerializer.Serialize(writer, OrderValue, options);
		}

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

public sealed partial class SortProcessorDescriptor : SerializableDescriptor<SortProcessorDescriptor>
{
	internal SortProcessorDescriptor(Action<SortProcessorDescriptor> configure) => configure.Invoke(this);

	public SortProcessorDescriptor() : base()
	{
	}

	private string? DescriptionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailureValue { get; set; }
	private ProcessorDescriptor OnFailureDescriptor { get; set; }
	private Action<ProcessorDescriptor> OnFailureDescriptorAction { get; set; }
	private Action<ProcessorDescriptor>[] OnFailureDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.SortOrder? OrderValue { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? TargetFieldValue { get; set; }

	public SortProcessorDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>The field to be sorted.</para>
	/// </summary>
	public SortProcessorDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to be sorted.</para>
	/// </summary>
	public SortProcessorDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to be sorted.</para>
	/// </summary>
	public SortProcessorDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public SortProcessorDescriptor If(string? ifValue)
	{
		IfValue = ifValue;
		return Self;
	}

	public SortProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	public SortProcessorDescriptor OnFailure(ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public SortProcessorDescriptor OnFailure(ProcessorDescriptor descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public SortProcessorDescriptor OnFailure(Action<ProcessorDescriptor> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public SortProcessorDescriptor OnFailure(params Action<ProcessorDescriptor>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>The sort order to use.<br/>Accepts `"asc"` or `"desc"`.</para>
	/// </summary>
	public SortProcessorDescriptor Order(Elastic.Clients.Elasticsearch.Serverless.SortOrder? order)
	{
		OrderValue = order;
		return Self;
	}

	public SortProcessorDescriptor Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>The field to assign the sorted value to.<br/>By default, the field is updated in-place.</para>
	/// </summary>
	public SortProcessorDescriptor TargetField(Elastic.Clients.Elasticsearch.Serverless.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field to assign the sorted value to.<br/>By default, the field is updated in-place.</para>
	/// </summary>
	public SortProcessorDescriptor TargetField<TDocument, TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field to assign the sorted value to.<br/>By default, the field is updated in-place.</para>
	/// </summary>
	public SortProcessorDescriptor TargetField<TDocument>(Expression<Func<TDocument, object>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
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
			JsonSerializer.Serialize(writer, new ProcessorDescriptor(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new ProcessorDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			JsonSerializer.Serialize(writer, OrderValue, options);
		}

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