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

public sealed partial class UserAgentProcessor
{
	/// <summary>
	/// <para>Description of the processor.<br/>Useful for describing the purpose of the processor or its configuration.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// <para>The field containing the user agent string.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field Field { get; set; }

	/// <summary>
	/// <para>Conditionally execute the processor.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("if")]
	public string? If { get; set; }

	/// <summary>
	/// <para>Ignore failures for the processor.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ignore_failure")]
	public bool? IgnoreFailure { get; set; }

	/// <summary>
	/// <para>If `true` and `field` does not exist, the processor quietly exits without modifying the document.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ignore_missing")]
	public bool? IgnoreMissing { get; set; }

	/// <summary>
	/// <para>Handle failures for the processor.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("on_failure")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailure { get; set; }
	[JsonInclude, JsonPropertyName("options")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.UserAgentProperty>? Options { get; set; }

	/// <summary>
	/// <para>The name of the file in the `config/ingest-user-agent` directory containing the regular expressions for parsing the user agent string. Both the directory and the file have to be created before starting Elasticsearch. If not specified, ingest-user-agent will use the `regexes.yaml` from uap-core it ships with.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("regex_file")]
	public string? RegexFile { get; set; }

	/// <summary>
	/// <para>Identifier for the processor.<br/>Useful for debugging and metrics.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tag")]
	public string? Tag { get; set; }

	/// <summary>
	/// <para>The field that will be filled with the user agent details.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("target_field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field? TargetField { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor(UserAgentProcessor userAgentProcessor) => Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor.UserAgent(userAgentProcessor);
}

public sealed partial class UserAgentProcessorDescriptor<TDocument> : SerializableDescriptor<UserAgentProcessorDescriptor<TDocument>>
{
	internal UserAgentProcessorDescriptor(Action<UserAgentProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);

	public UserAgentProcessorDescriptor() : base()
	{
	}

	private string? DescriptionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private bool? IgnoreMissingValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument> OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.UserAgentProperty>? OptionsValue { get; set; }
	private string? RegexFileValue { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? TargetFieldValue { get; set; }

	/// <summary>
	/// <para>Description of the processor.<br/>Useful for describing the purpose of the processor or its configuration.</para>
	/// </summary>
	public UserAgentProcessorDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>The field containing the user agent string.</para>
	/// </summary>
	public UserAgentProcessorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field containing the user agent string.</para>
	/// </summary>
	public UserAgentProcessorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field containing the user agent string.</para>
	/// </summary>
	public UserAgentProcessorDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Conditionally execute the processor.</para>
	/// </summary>
	public UserAgentProcessorDescriptor<TDocument> If(string? value)
	{
		IfValue = value;
		return Self;
	}

	/// <summary>
	/// <para>Ignore failures for the processor.</para>
	/// </summary>
	public UserAgentProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>If `true` and `field` does not exist, the processor quietly exits without modifying the document.</para>
	/// </summary>
	public UserAgentProcessorDescriptor<TDocument> IgnoreMissing(bool? ignoreMissing = true)
	{
		IgnoreMissingValue = ignoreMissing;
		return Self;
	}

	/// <summary>
	/// <para>Handle failures for the processor.</para>
	/// </summary>
	public UserAgentProcessorDescriptor<TDocument> OnFailure(ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public UserAgentProcessorDescriptor<TDocument> OnFailure(Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument> descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public UserAgentProcessorDescriptor<TDocument> OnFailure(Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public UserAgentProcessorDescriptor<TDocument> OnFailure(params Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	public UserAgentProcessorDescriptor<TDocument> Options(ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.UserAgentProperty>? options)
	{
		OptionsValue = options;
		return Self;
	}

	/// <summary>
	/// <para>The name of the file in the `config/ingest-user-agent` directory containing the regular expressions for parsing the user agent string. Both the directory and the file have to be created before starting Elasticsearch. If not specified, ingest-user-agent will use the `regexes.yaml` from uap-core it ships with.</para>
	/// </summary>
	public UserAgentProcessorDescriptor<TDocument> RegexFile(string? regexFile)
	{
		RegexFileValue = regexFile;
		return Self;
	}

	/// <summary>
	/// <para>Identifier for the processor.<br/>Useful for debugging and metrics.</para>
	/// </summary>
	public UserAgentProcessorDescriptor<TDocument> Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>The field that will be filled with the user agent details.</para>
	/// </summary>
	public UserAgentProcessorDescriptor<TDocument> TargetField(Elastic.Clients.Elasticsearch.Serverless.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field that will be filled with the user agent details.</para>
	/// </summary>
	public UserAgentProcessorDescriptor<TDocument> TargetField<TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field that will be filled with the user agent details.</para>
	/// </summary>
	public UserAgentProcessorDescriptor<TDocument> TargetField(Expression<Func<TDocument, object>> targetField)
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

		if (IgnoreMissingValue.HasValue)
		{
			writer.WritePropertyName("ignore_missing");
			writer.WriteBooleanValue(IgnoreMissingValue.Value);
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
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (OptionsValue is not null)
		{
			writer.WritePropertyName("options");
			JsonSerializer.Serialize(writer, OptionsValue, options);
		}

		if (!string.IsNullOrEmpty(RegexFileValue))
		{
			writer.WritePropertyName("regex_file");
			writer.WriteStringValue(RegexFileValue);
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

public sealed partial class UserAgentProcessorDescriptor : SerializableDescriptor<UserAgentProcessorDescriptor>
{
	internal UserAgentProcessorDescriptor(Action<UserAgentProcessorDescriptor> configure) => configure.Invoke(this);

	public UserAgentProcessorDescriptor() : base()
	{
	}

	private string? DescriptionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private bool? IgnoreMissingValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor>[] OnFailureDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.UserAgentProperty>? OptionsValue { get; set; }
	private string? RegexFileValue { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? TargetFieldValue { get; set; }

	/// <summary>
	/// <para>Description of the processor.<br/>Useful for describing the purpose of the processor or its configuration.</para>
	/// </summary>
	public UserAgentProcessorDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>The field containing the user agent string.</para>
	/// </summary>
	public UserAgentProcessorDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field containing the user agent string.</para>
	/// </summary>
	public UserAgentProcessorDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field containing the user agent string.</para>
	/// </summary>
	public UserAgentProcessorDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Conditionally execute the processor.</para>
	/// </summary>
	public UserAgentProcessorDescriptor If(string? value)
	{
		IfValue = value;
		return Self;
	}

	/// <summary>
	/// <para>Ignore failures for the processor.</para>
	/// </summary>
	public UserAgentProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>If `true` and `field` does not exist, the processor quietly exits without modifying the document.</para>
	/// </summary>
	public UserAgentProcessorDescriptor IgnoreMissing(bool? ignoreMissing = true)
	{
		IgnoreMissingValue = ignoreMissing;
		return Self;
	}

	/// <summary>
	/// <para>Handle failures for the processor.</para>
	/// </summary>
	public UserAgentProcessorDescriptor OnFailure(ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public UserAgentProcessorDescriptor OnFailure(Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public UserAgentProcessorDescriptor OnFailure(Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public UserAgentProcessorDescriptor OnFailure(params Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	public UserAgentProcessorDescriptor Options(ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.UserAgentProperty>? options)
	{
		OptionsValue = options;
		return Self;
	}

	/// <summary>
	/// <para>The name of the file in the `config/ingest-user-agent` directory containing the regular expressions for parsing the user agent string. Both the directory and the file have to be created before starting Elasticsearch. If not specified, ingest-user-agent will use the `regexes.yaml` from uap-core it ships with.</para>
	/// </summary>
	public UserAgentProcessorDescriptor RegexFile(string? regexFile)
	{
		RegexFileValue = regexFile;
		return Self;
	}

	/// <summary>
	/// <para>Identifier for the processor.<br/>Useful for debugging and metrics.</para>
	/// </summary>
	public UserAgentProcessorDescriptor Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>The field that will be filled with the user agent details.</para>
	/// </summary>
	public UserAgentProcessorDescriptor TargetField(Elastic.Clients.Elasticsearch.Serverless.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field that will be filled with the user agent details.</para>
	/// </summary>
	public UserAgentProcessorDescriptor TargetField<TDocument, TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field that will be filled with the user agent details.</para>
	/// </summary>
	public UserAgentProcessorDescriptor TargetField<TDocument>(Expression<Func<TDocument, object>> targetField)
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

		if (IgnoreMissingValue.HasValue)
		{
			writer.WritePropertyName("ignore_missing");
			writer.WriteBooleanValue(IgnoreMissingValue.Value);
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
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (OptionsValue is not null)
		{
			writer.WritePropertyName("options");
			JsonSerializer.Serialize(writer, OptionsValue, options);
		}

		if (!string.IsNullOrEmpty(RegexFileValue))
		{
			writer.WritePropertyName("regex_file");
			writer.WriteStringValue(RegexFileValue);
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