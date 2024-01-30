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

public sealed partial class RerouteProcessor
{
	/// <summary>
	/// <para>Field references or a static value for the dataset part of the data stream name.<br/>In addition to the criteria for index names, cannot contain - and must be no longer than 100 characters.<br/>Example values are nginx.access and nginx.error.</para>
	/// <para>Supports field references with a mustache-like syntax (denoted as {{double}} or {{{triple}}} curly braces).<br/>When resolving field references, the processor replaces invalid characters with _. Uses the <dataset> part<br/>of the index name as a fallback if all field references resolve to a null, missing, or non-string value.</para>
	/// <para>default {{data_stream.dataset}}</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("dataset")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public ICollection<string>? Dataset { get; set; }
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// <para>A static value for the target. Can’t be set when the dataset or namespace option is set.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("destination")]
	public string? Destination { get; set; }
	[JsonInclude, JsonPropertyName("if")]
	public string? If { get; set; }
	[JsonInclude, JsonPropertyName("ignore_failure")]
	public bool? IgnoreFailure { get; set; }

	/// <summary>
	/// <para>Field references or a static value for the namespace part of the data stream name. See the criteria for<br/>index names for allowed characters. Must be no longer than 100 characters.</para>
	/// <para>Supports field references with a mustache-like syntax (denoted as {{double}} or {{{triple}}} curly braces).<br/>When resolving field references, the processor replaces invalid characters with _. Uses the <namespace> part<br/>of the index name as a fallback if all field references resolve to a null, missing, or non-string value.</para>
	/// <para>default {{data_stream.namespace}}</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("namespace")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public ICollection<string>? Namespace { get; set; }
	[JsonInclude, JsonPropertyName("on_failure")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailure { get; set; }
	[JsonInclude, JsonPropertyName("tag")]
	public string? Tag { get; set; }

	public static implicit operator Processor(RerouteProcessor rerouteProcessor) => Ingest.Processor.Reroute(rerouteProcessor);
}

public sealed partial class RerouteProcessorDescriptor<TDocument> : SerializableDescriptor<RerouteProcessorDescriptor<TDocument>>
{
	internal RerouteProcessorDescriptor(Action<RerouteProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);

	public RerouteProcessorDescriptor() : base()
	{
	}

	private ICollection<string>? DatasetValue { get; set; }
	private string? DescriptionValue { get; set; }
	private string? DestinationValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private ICollection<string>? NamespaceValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailureValue { get; set; }
	private ProcessorDescriptor<TDocument> OnFailureDescriptor { get; set; }
	private Action<ProcessorDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }
	private Action<ProcessorDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }
	private string? TagValue { get; set; }

	/// <summary>
	/// <para>Field references or a static value for the dataset part of the data stream name.<br/>In addition to the criteria for index names, cannot contain - and must be no longer than 100 characters.<br/>Example values are nginx.access and nginx.error.</para>
	/// <para>Supports field references with a mustache-like syntax (denoted as {{double}} or {{{triple}}} curly braces).<br/>When resolving field references, the processor replaces invalid characters with _. Uses the <dataset> part<br/>of the index name as a fallback if all field references resolve to a null, missing, or non-string value.</para>
	/// <para>default {{data_stream.dataset}}</para>
	/// </summary>
	public RerouteProcessorDescriptor<TDocument> Dataset(ICollection<string>? dataset)
	{
		DatasetValue = dataset;
		return Self;
	}

	public RerouteProcessorDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>A static value for the target. Can’t be set when the dataset or namespace option is set.</para>
	/// </summary>
	public RerouteProcessorDescriptor<TDocument> Destination(string? destination)
	{
		DestinationValue = destination;
		return Self;
	}

	public RerouteProcessorDescriptor<TDocument> If(string? ifValue)
	{
		IfValue = ifValue;
		return Self;
	}

	public RerouteProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>Field references or a static value for the namespace part of the data stream name. See the criteria for<br/>index names for allowed characters. Must be no longer than 100 characters.</para>
	/// <para>Supports field references with a mustache-like syntax (denoted as {{double}} or {{{triple}}} curly braces).<br/>When resolving field references, the processor replaces invalid characters with _. Uses the <namespace> part<br/>of the index name as a fallback if all field references resolve to a null, missing, or non-string value.</para>
	/// <para>default {{data_stream.namespace}}</para>
	/// </summary>
	public RerouteProcessorDescriptor<TDocument> Namespace(ICollection<string>? @namespace)
	{
		NamespaceValue = @namespace;
		return Self;
	}

	public RerouteProcessorDescriptor<TDocument> OnFailure(ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public RerouteProcessorDescriptor<TDocument> OnFailure(ProcessorDescriptor<TDocument> descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public RerouteProcessorDescriptor<TDocument> OnFailure(Action<ProcessorDescriptor<TDocument>> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public RerouteProcessorDescriptor<TDocument> OnFailure(params Action<ProcessorDescriptor<TDocument>>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	public RerouteProcessorDescriptor<TDocument> Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DatasetValue is not null)
		{
			writer.WritePropertyName("dataset");
			SingleOrManySerializationHelper.Serialize<string>(DatasetValue, writer, options);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		if (!string.IsNullOrEmpty(DestinationValue))
		{
			writer.WritePropertyName("destination");
			writer.WriteStringValue(DestinationValue);
		}

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

		if (NamespaceValue is not null)
		{
			writer.WritePropertyName("namespace");
			SingleOrManySerializationHelper.Serialize<string>(NamespaceValue, writer, options);
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

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class RerouteProcessorDescriptor : SerializableDescriptor<RerouteProcessorDescriptor>
{
	internal RerouteProcessorDescriptor(Action<RerouteProcessorDescriptor> configure) => configure.Invoke(this);

	public RerouteProcessorDescriptor() : base()
	{
	}

	private ICollection<string>? DatasetValue { get; set; }
	private string? DescriptionValue { get; set; }
	private string? DestinationValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private ICollection<string>? NamespaceValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailureValue { get; set; }
	private ProcessorDescriptor OnFailureDescriptor { get; set; }
	private Action<ProcessorDescriptor> OnFailureDescriptorAction { get; set; }
	private Action<ProcessorDescriptor>[] OnFailureDescriptorActions { get; set; }
	private string? TagValue { get; set; }

	/// <summary>
	/// <para>Field references or a static value for the dataset part of the data stream name.<br/>In addition to the criteria for index names, cannot contain - and must be no longer than 100 characters.<br/>Example values are nginx.access and nginx.error.</para>
	/// <para>Supports field references with a mustache-like syntax (denoted as {{double}} or {{{triple}}} curly braces).<br/>When resolving field references, the processor replaces invalid characters with _. Uses the <dataset> part<br/>of the index name as a fallback if all field references resolve to a null, missing, or non-string value.</para>
	/// <para>default {{data_stream.dataset}}</para>
	/// </summary>
	public RerouteProcessorDescriptor Dataset(ICollection<string>? dataset)
	{
		DatasetValue = dataset;
		return Self;
	}

	public RerouteProcessorDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>A static value for the target. Can’t be set when the dataset or namespace option is set.</para>
	/// </summary>
	public RerouteProcessorDescriptor Destination(string? destination)
	{
		DestinationValue = destination;
		return Self;
	}

	public RerouteProcessorDescriptor If(string? ifValue)
	{
		IfValue = ifValue;
		return Self;
	}

	public RerouteProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>Field references or a static value for the namespace part of the data stream name. See the criteria for<br/>index names for allowed characters. Must be no longer than 100 characters.</para>
	/// <para>Supports field references with a mustache-like syntax (denoted as {{double}} or {{{triple}}} curly braces).<br/>When resolving field references, the processor replaces invalid characters with _. Uses the <namespace> part<br/>of the index name as a fallback if all field references resolve to a null, missing, or non-string value.</para>
	/// <para>default {{data_stream.namespace}}</para>
	/// </summary>
	public RerouteProcessorDescriptor Namespace(ICollection<string>? @namespace)
	{
		NamespaceValue = @namespace;
		return Self;
	}

	public RerouteProcessorDescriptor OnFailure(ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public RerouteProcessorDescriptor OnFailure(ProcessorDescriptor descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public RerouteProcessorDescriptor OnFailure(Action<ProcessorDescriptor> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public RerouteProcessorDescriptor OnFailure(params Action<ProcessorDescriptor>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	public RerouteProcessorDescriptor Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DatasetValue is not null)
		{
			writer.WritePropertyName("dataset");
			SingleOrManySerializationHelper.Serialize<string>(DatasetValue, writer, options);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		if (!string.IsNullOrEmpty(DestinationValue))
		{
			writer.WritePropertyName("destination");
			writer.WriteStringValue(DestinationValue);
		}

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

		if (NamespaceValue is not null)
		{
			writer.WritePropertyName("namespace");
			SingleOrManySerializationHelper.Serialize<string>(NamespaceValue, writer, options);
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

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		writer.WriteEndObject();
	}
}
