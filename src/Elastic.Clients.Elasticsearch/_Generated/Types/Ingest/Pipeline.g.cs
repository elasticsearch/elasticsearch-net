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

public sealed partial class Pipeline
{
	/// <summary>
	/// <para>Description of the ingest pipeline.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// <para>Arbitrary metadata about the ingest pipeline. This map is not automatically generated by Elasticsearch.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_meta")]
	public IDictionary<string, object>? Meta { get; set; }

	/// <summary>
	/// <para>Processors to run immediately after a processor failure.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("on_failure")]
	public ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailure { get; set; }

	/// <summary>
	/// <para>Processors used to perform transformations on documents before indexing.<br/>Processors run sequentially in the order specified.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("processors")]
	public ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? Processors { get; set; }

	/// <summary>
	/// <para>Version number used by external systems to track ingest pipelines.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("version")]
	public long? Version { get; set; }
}

public sealed partial class PipelineDescriptor<TDocument> : SerializableDescriptor<PipelineDescriptor<TDocument>>
{
	internal PipelineDescriptor(Action<PipelineDescriptor<TDocument>> configure) => configure.Invoke(this);

	public PipelineDescriptor() : base()
	{
	}

	private string? DescriptionValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument> OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? ProcessorsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument> ProcessorsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>> ProcessorsDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>>[] ProcessorsDescriptorActions { get; set; }
	private long? VersionValue { get; set; }

	/// <summary>
	/// <para>Description of the ingest pipeline.</para>
	/// </summary>
	public PipelineDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>Arbitrary metadata about the ingest pipeline. This map is not automatically generated by Elasticsearch.</para>
	/// </summary>
	public PipelineDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>Processors to run immediately after a processor failure.</para>
	/// </summary>
	public PipelineDescriptor<TDocument> OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public PipelineDescriptor<TDocument> OnFailure(Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument> descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public PipelineDescriptor<TDocument> OnFailure(Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public PipelineDescriptor<TDocument> OnFailure(params Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Processors used to perform transformations on documents before indexing.<br/>Processors run sequentially in the order specified.</para>
	/// </summary>
	public PipelineDescriptor<TDocument> Processors(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? processors)
	{
		ProcessorsDescriptor = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = null;
		ProcessorsValue = processors;
		return Self;
	}

	public PipelineDescriptor<TDocument> Processors(Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument> descriptor)
	{
		ProcessorsValue = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = null;
		ProcessorsDescriptor = descriptor;
		return Self;
	}

	public PipelineDescriptor<TDocument> Processors(Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>> configure)
	{
		ProcessorsValue = null;
		ProcessorsDescriptor = null;
		ProcessorsDescriptorActions = null;
		ProcessorsDescriptorAction = configure;
		return Self;
	}

	public PipelineDescriptor<TDocument> Processors(params Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>>[] configure)
	{
		ProcessorsValue = null;
		ProcessorsDescriptor = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Version number used by external systems to track ingest pipelines.</para>
	/// </summary>
	public PipelineDescriptor<TDocument> Version(long? version)
	{
		VersionValue = version;
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

		if (MetaValue is not null)
		{
			writer.WritePropertyName("_meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
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

		if (ProcessorsDescriptor is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, ProcessorsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (ProcessorsDescriptorAction is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>(ProcessorsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (ProcessorsDescriptorActions is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			foreach (var action in ProcessorsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (ProcessorsValue is not null)
		{
			writer.WritePropertyName("processors");
			JsonSerializer.Serialize(writer, ProcessorsValue, options);
		}

		if (VersionValue.HasValue)
		{
			writer.WritePropertyName("version");
			writer.WriteNumberValue(VersionValue.Value);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class PipelineDescriptor : SerializableDescriptor<PipelineDescriptor>
{
	internal PipelineDescriptor(Action<PipelineDescriptor> configure) => configure.Invoke(this);

	public PipelineDescriptor() : base()
	{
	}

	private string? DescriptionValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor>[] OnFailureDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? ProcessorsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor ProcessorsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor> ProcessorsDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor>[] ProcessorsDescriptorActions { get; set; }
	private long? VersionValue { get; set; }

	/// <summary>
	/// <para>Description of the ingest pipeline.</para>
	/// </summary>
	public PipelineDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>Arbitrary metadata about the ingest pipeline. This map is not automatically generated by Elasticsearch.</para>
	/// </summary>
	public PipelineDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>Processors to run immediately after a processor failure.</para>
	/// </summary>
	public PipelineDescriptor OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public PipelineDescriptor OnFailure(Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public PipelineDescriptor OnFailure(Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public PipelineDescriptor OnFailure(params Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Processors used to perform transformations on documents before indexing.<br/>Processors run sequentially in the order specified.</para>
	/// </summary>
	public PipelineDescriptor Processors(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? processors)
	{
		ProcessorsDescriptor = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = null;
		ProcessorsValue = processors;
		return Self;
	}

	public PipelineDescriptor Processors(Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor descriptor)
	{
		ProcessorsValue = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = null;
		ProcessorsDescriptor = descriptor;
		return Self;
	}

	public PipelineDescriptor Processors(Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor> configure)
	{
		ProcessorsValue = null;
		ProcessorsDescriptor = null;
		ProcessorsDescriptorActions = null;
		ProcessorsDescriptorAction = configure;
		return Self;
	}

	public PipelineDescriptor Processors(params Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor>[] configure)
	{
		ProcessorsValue = null;
		ProcessorsDescriptor = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Version number used by external systems to track ingest pipelines.</para>
	/// </summary>
	public PipelineDescriptor Version(long? version)
	{
		VersionValue = version;
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

		if (MetaValue is not null)
		{
			writer.WritePropertyName("_meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
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

		if (ProcessorsDescriptor is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, ProcessorsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (ProcessorsDescriptorAction is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor(ProcessorsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (ProcessorsDescriptorActions is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			foreach (var action in ProcessorsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (ProcessorsValue is not null)
		{
			writer.WritePropertyName("processors");
			JsonSerializer.Serialize(writer, ProcessorsValue, options);
		}

		if (VersionValue.HasValue)
		{
			writer.WritePropertyName("version");
			writer.WriteNumberValue(VersionValue.Value);
		}

		writer.WriteEndObject();
	}
}