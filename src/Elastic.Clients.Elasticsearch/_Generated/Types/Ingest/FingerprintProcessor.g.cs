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

namespace Elastic.Clients.Elasticsearch.Ingest;

public sealed partial class FingerprintProcessor
{
	/// <summary>
	/// <para>
	/// Description of the processor.
	/// Useful for describing the purpose of the processor or its configuration.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// <para>
	/// Array of fields to include in the fingerprint. For objects, the processor
	/// hashes both the field key and value. For other fields, the processor hashes
	/// only the field value.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fields")]
	[JsonConverter(typeof(SingleOrManyFieldsConverter))]
	public Elastic.Clients.Elasticsearch.Fields Fields { get; set; }

	/// <summary>
	/// <para>
	/// Conditionally execute the processor.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("if")]
	public string? If { get; set; }

	/// <summary>
	/// <para>
	/// Ignore failures for the processor.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ignore_failure")]
	public bool? IgnoreFailure { get; set; }

	/// <summary>
	/// <para>
	/// If true, the processor ignores any missing fields. If all fields are
	/// missing, the processor silently exits without modifying the document.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ignore_missing")]
	public bool? IgnoreMissing { get; set; }

	/// <summary>
	/// <para>
	/// The hash method used to compute the fingerprint. Must be one of MD5, SHA-1,
	/// SHA-256, SHA-512, or MurmurHash3.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("method")]
	public Elastic.Clients.Elasticsearch.Ingest.FingerprintDigest? Method { get; set; }

	/// <summary>
	/// <para>
	/// Handle failures for the processor.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("on_failure")]
	public ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailure { get; set; }

	/// <summary>
	/// <para>
	/// Salt value for the hash function.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("salt")]
	public string? Salt { get; set; }

	/// <summary>
	/// <para>
	/// Identifier for the processor.
	/// Useful for debugging and metrics.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tag")]
	public string? Tag { get; set; }

	/// <summary>
	/// <para>
	/// Output field for the fingerprint.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("target_field")]
	public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Ingest.Processor(FingerprintProcessor fingerprintProcessor) => Elastic.Clients.Elasticsearch.Ingest.Processor.Fingerprint(fingerprintProcessor);
}

public sealed partial class FingerprintProcessorDescriptor<TDocument> : SerializableDescriptor<FingerprintProcessorDescriptor<TDocument>>
{
	internal FingerprintProcessorDescriptor(Action<FingerprintProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);

	public FingerprintProcessorDescriptor() : base()
	{
	}

	private string? DescriptionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields FieldsValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private bool? IgnoreMissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.FingerprintDigest? MethodValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument> OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }
	private string? SaltValue { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? TargetFieldValue { get; set; }

	/// <summary>
	/// <para>
	/// Description of the processor.
	/// Useful for describing the purpose of the processor or its configuration.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Array of fields to include in the fingerprint. For objects, the processor
	/// hashes both the field key and value. For other fields, the processor hashes
	/// only the field value.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Conditionally execute the processor.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor<TDocument> If(string? value)
	{
		IfValue = value;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Ignore failures for the processor.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If true, the processor ignores any missing fields. If all fields are
	/// missing, the processor silently exits without modifying the document.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor<TDocument> IgnoreMissing(bool? ignoreMissing = true)
	{
		IgnoreMissingValue = ignoreMissing;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The hash method used to compute the fingerprint. Must be one of MD5, SHA-1,
	/// SHA-256, SHA-512, or MurmurHash3.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor<TDocument> Method(Elastic.Clients.Elasticsearch.Ingest.FingerprintDigest? method)
	{
		MethodValue = method;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Handle failures for the processor.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor<TDocument> OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public FingerprintProcessorDescriptor<TDocument> OnFailure(Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument> descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public FingerprintProcessorDescriptor<TDocument> OnFailure(Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public FingerprintProcessorDescriptor<TDocument> OnFailure(params Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Salt value for the hash function.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor<TDocument> Salt(string? salt)
	{
		SaltValue = salt;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Identifier for the processor.
	/// Useful for debugging and metrics.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor<TDocument> Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Output field for the fingerprint.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor<TDocument> TargetField(Elastic.Clients.Elasticsearch.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Output field for the fingerprint.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor<TDocument> TargetField<TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Output field for the fingerprint.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor<TDocument> TargetField(Expression<Func<TDocument, object>> targetField)
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

		writer.WritePropertyName("fields");
		JsonSerializer.Serialize(writer, FieldsValue, options);
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

		if (MethodValue is not null)
		{
			writer.WritePropertyName("method");
			JsonSerializer.Serialize(writer, MethodValue, options);
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
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (!string.IsNullOrEmpty(SaltValue))
		{
			writer.WritePropertyName("salt");
			writer.WriteStringValue(SaltValue);
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

public sealed partial class FingerprintProcessorDescriptor : SerializableDescriptor<FingerprintProcessorDescriptor>
{
	internal FingerprintProcessorDescriptor(Action<FingerprintProcessorDescriptor> configure) => configure.Invoke(this);

	public FingerprintProcessorDescriptor() : base()
	{
	}

	private string? DescriptionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields FieldsValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private bool? IgnoreMissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.FingerprintDigest? MethodValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor>[] OnFailureDescriptorActions { get; set; }
	private string? SaltValue { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? TargetFieldValue { get; set; }

	/// <summary>
	/// <para>
	/// Description of the processor.
	/// Useful for describing the purpose of the processor or its configuration.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Array of fields to include in the fingerprint. For objects, the processor
	/// hashes both the field key and value. For other fields, the processor hashes
	/// only the field value.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor Fields(Elastic.Clients.Elasticsearch.Fields fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Conditionally execute the processor.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor If(string? value)
	{
		IfValue = value;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Ignore failures for the processor.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If true, the processor ignores any missing fields. If all fields are
	/// missing, the processor silently exits without modifying the document.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor IgnoreMissing(bool? ignoreMissing = true)
	{
		IgnoreMissingValue = ignoreMissing;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The hash method used to compute the fingerprint. Must be one of MD5, SHA-1,
	/// SHA-256, SHA-512, or MurmurHash3.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor Method(Elastic.Clients.Elasticsearch.Ingest.FingerprintDigest? method)
	{
		MethodValue = method;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Handle failures for the processor.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public FingerprintProcessorDescriptor OnFailure(Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public FingerprintProcessorDescriptor OnFailure(Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public FingerprintProcessorDescriptor OnFailure(params Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Salt value for the hash function.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor Salt(string? salt)
	{
		SaltValue = salt;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Identifier for the processor.
	/// Useful for debugging and metrics.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Output field for the fingerprint.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor TargetField(Elastic.Clients.Elasticsearch.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Output field for the fingerprint.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor TargetField<TDocument, TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Output field for the fingerprint.
	/// </para>
	/// </summary>
	public FingerprintProcessorDescriptor TargetField<TDocument>(Expression<Func<TDocument, object>> targetField)
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

		writer.WritePropertyName("fields");
		JsonSerializer.Serialize(writer, FieldsValue, options);
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

		if (MethodValue is not null)
		{
			writer.WritePropertyName("method");
			JsonSerializer.Serialize(writer, MethodValue, options);
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
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (!string.IsNullOrEmpty(SaltValue))
		{
			writer.WritePropertyName("salt");
			writer.WriteStringValue(SaltValue);
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