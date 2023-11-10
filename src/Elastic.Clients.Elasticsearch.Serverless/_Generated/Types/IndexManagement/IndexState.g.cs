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

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class IndexState
{
	[JsonInclude, JsonPropertyName("aliases")]
	public IDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.Alias>? Aliases { get; set; }
	[JsonInclude, JsonPropertyName("data_stream")]
	public Elastic.Clients.Elasticsearch.Serverless.DataStreamName? DataStream { get; set; }

	/// <summary>
	/// <para>Default settings, included when the request's `include_default` is `true`.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("defaults")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettings? Defaults { get; set; }

	/// <summary>
	/// <para>Data lifecycle applicable if this is a data stream.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("lifecycle")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamLifecycle? Lifecycle { get; set; }
	[JsonInclude, JsonPropertyName("mappings")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMapping? Mappings { get; set; }
	[JsonInclude, JsonPropertyName("settings")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettings? Settings { get; set; }
}

public sealed partial class IndexStateDescriptor<TDocument> : SerializableDescriptor<IndexStateDescriptor<TDocument>>
{
	internal IndexStateDescriptor(Action<IndexStateDescriptor<TDocument>> configure) => configure.Invoke(this);

	public IndexStateDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettings? DefaultsValue { get; set; }
	private IndexSettingsDescriptor<TDocument> DefaultsDescriptor { get; set; }
	private Action<IndexSettingsDescriptor<TDocument>> DefaultsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMapping? MappingsValue { get; set; }
	private Mapping.TypeMappingDescriptor<TDocument> MappingsDescriptor { get; set; }
	private Action<Mapping.TypeMappingDescriptor<TDocument>> MappingsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettings? SettingsValue { get; set; }
	private IndexSettingsDescriptor<TDocument> SettingsDescriptor { get; set; }
	private Action<IndexSettingsDescriptor<TDocument>> SettingsDescriptorAction { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.Alias>? AliasesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.DataStreamName? DataStreamValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamLifecycle? LifecycleValue { get; set; }
	private DataStreamLifecycleDescriptor LifecycleDescriptor { get; set; }
	private Action<DataStreamLifecycleDescriptor> LifecycleDescriptorAction { get; set; }

	/// <summary>
	/// <para>Default settings, included when the request's `include_default` is `true`.</para>
	/// </summary>
	public IndexStateDescriptor<TDocument> Defaults(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettings? defaults)
	{
		DefaultsDescriptor = null;
		DefaultsDescriptorAction = null;
		DefaultsValue = defaults;
		return Self;
	}

	public IndexStateDescriptor<TDocument> Defaults(IndexSettingsDescriptor<TDocument> descriptor)
	{
		DefaultsValue = null;
		DefaultsDescriptorAction = null;
		DefaultsDescriptor = descriptor;
		return Self;
	}

	public IndexStateDescriptor<TDocument> Defaults(Action<IndexSettingsDescriptor<TDocument>> configure)
	{
		DefaultsValue = null;
		DefaultsDescriptor = null;
		DefaultsDescriptorAction = configure;
		return Self;
	}

	public IndexStateDescriptor<TDocument> Mappings(Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMapping? mappings)
	{
		MappingsDescriptor = null;
		MappingsDescriptorAction = null;
		MappingsValue = mappings;
		return Self;
	}

	public IndexStateDescriptor<TDocument> Mappings(Mapping.TypeMappingDescriptor<TDocument> descriptor)
	{
		MappingsValue = null;
		MappingsDescriptorAction = null;
		MappingsDescriptor = descriptor;
		return Self;
	}

	public IndexStateDescriptor<TDocument> Mappings(Action<Mapping.TypeMappingDescriptor<TDocument>> configure)
	{
		MappingsValue = null;
		MappingsDescriptor = null;
		MappingsDescriptorAction = configure;
		return Self;
	}

	public IndexStateDescriptor<TDocument> Settings(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettings? settings)
	{
		SettingsDescriptor = null;
		SettingsDescriptorAction = null;
		SettingsValue = settings;
		return Self;
	}

	public IndexStateDescriptor<TDocument> Settings(IndexSettingsDescriptor<TDocument> descriptor)
	{
		SettingsValue = null;
		SettingsDescriptorAction = null;
		SettingsDescriptor = descriptor;
		return Self;
	}

	public IndexStateDescriptor<TDocument> Settings(Action<IndexSettingsDescriptor<TDocument>> configure)
	{
		SettingsValue = null;
		SettingsDescriptor = null;
		SettingsDescriptorAction = configure;
		return Self;
	}

	public IndexStateDescriptor<TDocument> Aliases(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.Alias>, FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.Alias>> selector)
	{
		AliasesValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.Alias>());
		return Self;
	}

	public IndexStateDescriptor<TDocument> DataStream(Elastic.Clients.Elasticsearch.Serverless.DataStreamName? dataStream)
	{
		DataStreamValue = dataStream;
		return Self;
	}

	/// <summary>
	/// <para>Data lifecycle applicable if this is a data stream.</para>
	/// </summary>
	public IndexStateDescriptor<TDocument> Lifecycle(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamLifecycle? lifecycle)
	{
		LifecycleDescriptor = null;
		LifecycleDescriptorAction = null;
		LifecycleValue = lifecycle;
		return Self;
	}

	public IndexStateDescriptor<TDocument> Lifecycle(DataStreamLifecycleDescriptor descriptor)
	{
		LifecycleValue = null;
		LifecycleDescriptorAction = null;
		LifecycleDescriptor = descriptor;
		return Self;
	}

	public IndexStateDescriptor<TDocument> Lifecycle(Action<DataStreamLifecycleDescriptor> configure)
	{
		LifecycleValue = null;
		LifecycleDescriptor = null;
		LifecycleDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DefaultsDescriptor is not null)
		{
			writer.WritePropertyName("defaults");
			JsonSerializer.Serialize(writer, DefaultsDescriptor, options);
		}
		else if (DefaultsDescriptorAction is not null)
		{
			writer.WritePropertyName("defaults");
			JsonSerializer.Serialize(writer, new IndexSettingsDescriptor<TDocument>(DefaultsDescriptorAction), options);
		}
		else if (DefaultsValue is not null)
		{
			writer.WritePropertyName("defaults");
			JsonSerializer.Serialize(writer, DefaultsValue, options);
		}

		if (MappingsDescriptor is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, MappingsDescriptor, options);
		}
		else if (MappingsDescriptorAction is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, new Mapping.TypeMappingDescriptor<TDocument>(MappingsDescriptorAction), options);
		}
		else if (MappingsValue is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, MappingsValue, options);
		}

		if (SettingsDescriptor is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsDescriptor, options);
		}
		else if (SettingsDescriptorAction is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, new IndexSettingsDescriptor<TDocument>(SettingsDescriptorAction), options);
		}
		else if (SettingsValue is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsValue, options);
		}

		if (AliasesValue is not null)
		{
			writer.WritePropertyName("aliases");
			JsonSerializer.Serialize(writer, AliasesValue, options);
		}

		if (DataStreamValue is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, DataStreamValue, options);
		}

		if (LifecycleDescriptor is not null)
		{
			writer.WritePropertyName("lifecycle");
			JsonSerializer.Serialize(writer, LifecycleDescriptor, options);
		}
		else if (LifecycleDescriptorAction is not null)
		{
			writer.WritePropertyName("lifecycle");
			JsonSerializer.Serialize(writer, new DataStreamLifecycleDescriptor(LifecycleDescriptorAction), options);
		}
		else if (LifecycleValue is not null)
		{
			writer.WritePropertyName("lifecycle");
			JsonSerializer.Serialize(writer, LifecycleValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class IndexStateDescriptor : SerializableDescriptor<IndexStateDescriptor>
{
	internal IndexStateDescriptor(Action<IndexStateDescriptor> configure) => configure.Invoke(this);

	public IndexStateDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettings? DefaultsValue { get; set; }
	private IndexSettingsDescriptor DefaultsDescriptor { get; set; }
	private Action<IndexSettingsDescriptor> DefaultsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMapping? MappingsValue { get; set; }
	private Mapping.TypeMappingDescriptor MappingsDescriptor { get; set; }
	private Action<Mapping.TypeMappingDescriptor> MappingsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettings? SettingsValue { get; set; }
	private IndexSettingsDescriptor SettingsDescriptor { get; set; }
	private Action<IndexSettingsDescriptor> SettingsDescriptorAction { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.Alias>? AliasesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.DataStreamName? DataStreamValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamLifecycle? LifecycleValue { get; set; }
	private DataStreamLifecycleDescriptor LifecycleDescriptor { get; set; }
	private Action<DataStreamLifecycleDescriptor> LifecycleDescriptorAction { get; set; }

	/// <summary>
	/// <para>Default settings, included when the request's `include_default` is `true`.</para>
	/// </summary>
	public IndexStateDescriptor Defaults(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettings? defaults)
	{
		DefaultsDescriptor = null;
		DefaultsDescriptorAction = null;
		DefaultsValue = defaults;
		return Self;
	}

	public IndexStateDescriptor Defaults(IndexSettingsDescriptor descriptor)
	{
		DefaultsValue = null;
		DefaultsDescriptorAction = null;
		DefaultsDescriptor = descriptor;
		return Self;
	}

	public IndexStateDescriptor Defaults(Action<IndexSettingsDescriptor> configure)
	{
		DefaultsValue = null;
		DefaultsDescriptor = null;
		DefaultsDescriptorAction = configure;
		return Self;
	}

	public IndexStateDescriptor Mappings(Elastic.Clients.Elasticsearch.Serverless.Mapping.TypeMapping? mappings)
	{
		MappingsDescriptor = null;
		MappingsDescriptorAction = null;
		MappingsValue = mappings;
		return Self;
	}

	public IndexStateDescriptor Mappings(Mapping.TypeMappingDescriptor descriptor)
	{
		MappingsValue = null;
		MappingsDescriptorAction = null;
		MappingsDescriptor = descriptor;
		return Self;
	}

	public IndexStateDescriptor Mappings(Action<Mapping.TypeMappingDescriptor> configure)
	{
		MappingsValue = null;
		MappingsDescriptor = null;
		MappingsDescriptorAction = configure;
		return Self;
	}

	public IndexStateDescriptor Settings(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettings? settings)
	{
		SettingsDescriptor = null;
		SettingsDescriptorAction = null;
		SettingsValue = settings;
		return Self;
	}

	public IndexStateDescriptor Settings(IndexSettingsDescriptor descriptor)
	{
		SettingsValue = null;
		SettingsDescriptorAction = null;
		SettingsDescriptor = descriptor;
		return Self;
	}

	public IndexStateDescriptor Settings(Action<IndexSettingsDescriptor> configure)
	{
		SettingsValue = null;
		SettingsDescriptor = null;
		SettingsDescriptorAction = configure;
		return Self;
	}

	public IndexStateDescriptor Aliases(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.Alias>, FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.Alias>> selector)
	{
		AliasesValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Serverless.IndexName, Elastic.Clients.Elasticsearch.Serverless.IndexManagement.Alias>());
		return Self;
	}

	public IndexStateDescriptor DataStream(Elastic.Clients.Elasticsearch.Serverless.DataStreamName? dataStream)
	{
		DataStreamValue = dataStream;
		return Self;
	}

	/// <summary>
	/// <para>Data lifecycle applicable if this is a data stream.</para>
	/// </summary>
	public IndexStateDescriptor Lifecycle(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamLifecycle? lifecycle)
	{
		LifecycleDescriptor = null;
		LifecycleDescriptorAction = null;
		LifecycleValue = lifecycle;
		return Self;
	}

	public IndexStateDescriptor Lifecycle(DataStreamLifecycleDescriptor descriptor)
	{
		LifecycleValue = null;
		LifecycleDescriptorAction = null;
		LifecycleDescriptor = descriptor;
		return Self;
	}

	public IndexStateDescriptor Lifecycle(Action<DataStreamLifecycleDescriptor> configure)
	{
		LifecycleValue = null;
		LifecycleDescriptor = null;
		LifecycleDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DefaultsDescriptor is not null)
		{
			writer.WritePropertyName("defaults");
			JsonSerializer.Serialize(writer, DefaultsDescriptor, options);
		}
		else if (DefaultsDescriptorAction is not null)
		{
			writer.WritePropertyName("defaults");
			JsonSerializer.Serialize(writer, new IndexSettingsDescriptor(DefaultsDescriptorAction), options);
		}
		else if (DefaultsValue is not null)
		{
			writer.WritePropertyName("defaults");
			JsonSerializer.Serialize(writer, DefaultsValue, options);
		}

		if (MappingsDescriptor is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, MappingsDescriptor, options);
		}
		else if (MappingsDescriptorAction is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, new Mapping.TypeMappingDescriptor(MappingsDescriptorAction), options);
		}
		else if (MappingsValue is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, MappingsValue, options);
		}

		if (SettingsDescriptor is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsDescriptor, options);
		}
		else if (SettingsDescriptorAction is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, new IndexSettingsDescriptor(SettingsDescriptorAction), options);
		}
		else if (SettingsValue is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsValue, options);
		}

		if (AliasesValue is not null)
		{
			writer.WritePropertyName("aliases");
			JsonSerializer.Serialize(writer, AliasesValue, options);
		}

		if (DataStreamValue is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, DataStreamValue, options);
		}

		if (LifecycleDescriptor is not null)
		{
			writer.WritePropertyName("lifecycle");
			JsonSerializer.Serialize(writer, LifecycleDescriptor, options);
		}
		else if (LifecycleDescriptorAction is not null)
		{
			writer.WritePropertyName("lifecycle");
			JsonSerializer.Serialize(writer, new DataStreamLifecycleDescriptor(LifecycleDescriptorAction), options);
		}
		else if (LifecycleValue is not null)
		{
			writer.WritePropertyName("lifecycle");
			JsonSerializer.Serialize(writer, LifecycleValue, options);
		}

		writer.WriteEndObject();
	}
}