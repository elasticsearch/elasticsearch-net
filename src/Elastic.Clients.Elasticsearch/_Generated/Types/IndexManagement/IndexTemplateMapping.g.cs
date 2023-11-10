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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed partial class IndexTemplateMapping
{
	/// <summary>
	/// <para>Aliases to add.<br/>If the index template includes a `data_stream` object, these are data stream aliases.<br/>Otherwise, these are index aliases.<br/>Data stream aliases ignore the `index_routing`, `routing`, and `search_routing` options.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("aliases")]
	public IDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? Aliases { get; set; }
	[JsonInclude, JsonPropertyName("lifecycle")]
	public Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycle? Lifecycle { get; set; }

	/// <summary>
	/// <para>Mapping for fields in the index.<br/>If specified, this mapping can include field names, field data types, and mapping parameters.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("mappings")]
	public Elastic.Clients.Elasticsearch.Mapping.TypeMapping? Mappings { get; set; }

	/// <summary>
	/// <para>Configuration options for the index.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("settings")]
	public Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? Settings { get; set; }
}

public sealed partial class IndexTemplateMappingDescriptor<TDocument> : SerializableDescriptor<IndexTemplateMappingDescriptor<TDocument>>
{
	internal IndexTemplateMappingDescriptor(Action<IndexTemplateMappingDescriptor<TDocument>> configure) => configure.Invoke(this);

	public IndexTemplateMappingDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Mapping.TypeMapping? MappingsValue { get; set; }
	private Mapping.TypeMappingDescriptor<TDocument> MappingsDescriptor { get; set; }
	private Action<Mapping.TypeMappingDescriptor<TDocument>> MappingsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? SettingsValue { get; set; }
	private IndexSettingsDescriptor<TDocument> SettingsDescriptor { get; set; }
	private Action<IndexSettingsDescriptor<TDocument>> SettingsDescriptorAction { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? AliasesValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycle? LifecycleValue { get; set; }
	private DataStreamLifecycleDescriptor LifecycleDescriptor { get; set; }
	private Action<DataStreamLifecycleDescriptor> LifecycleDescriptorAction { get; set; }

	/// <summary>
	/// <para>Mapping for fields in the index.<br/>If specified, this mapping can include field names, field data types, and mapping parameters.</para>
	/// </summary>
	public IndexTemplateMappingDescriptor<TDocument> Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMapping? mappings)
	{
		MappingsDescriptor = null;
		MappingsDescriptorAction = null;
		MappingsValue = mappings;
		return Self;
	}

	public IndexTemplateMappingDescriptor<TDocument> Mappings(Mapping.TypeMappingDescriptor<TDocument> descriptor)
	{
		MappingsValue = null;
		MappingsDescriptorAction = null;
		MappingsDescriptor = descriptor;
		return Self;
	}

	public IndexTemplateMappingDescriptor<TDocument> Mappings(Action<Mapping.TypeMappingDescriptor<TDocument>> configure)
	{
		MappingsValue = null;
		MappingsDescriptor = null;
		MappingsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Configuration options for the index.</para>
	/// </summary>
	public IndexTemplateMappingDescriptor<TDocument> Settings(Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? settings)
	{
		SettingsDescriptor = null;
		SettingsDescriptorAction = null;
		SettingsValue = settings;
		return Self;
	}

	public IndexTemplateMappingDescriptor<TDocument> Settings(IndexSettingsDescriptor<TDocument> descriptor)
	{
		SettingsValue = null;
		SettingsDescriptorAction = null;
		SettingsDescriptor = descriptor;
		return Self;
	}

	public IndexTemplateMappingDescriptor<TDocument> Settings(Action<IndexSettingsDescriptor<TDocument>> configure)
	{
		SettingsValue = null;
		SettingsDescriptor = null;
		SettingsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Aliases to add.<br/>If the index template includes a `data_stream` object, these are data stream aliases.<br/>Otherwise, these are index aliases.<br/>Data stream aliases ignore the `index_routing`, `routing`, and `search_routing` options.</para>
	/// </summary>
	public IndexTemplateMappingDescriptor<TDocument> Aliases(Func<FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>, FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>> selector)
	{
		AliasesValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>());
		return Self;
	}

	public IndexTemplateMappingDescriptor<TDocument> Lifecycle(Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycle? lifecycle)
	{
		LifecycleDescriptor = null;
		LifecycleDescriptorAction = null;
		LifecycleValue = lifecycle;
		return Self;
	}

	public IndexTemplateMappingDescriptor<TDocument> Lifecycle(DataStreamLifecycleDescriptor descriptor)
	{
		LifecycleValue = null;
		LifecycleDescriptorAction = null;
		LifecycleDescriptor = descriptor;
		return Self;
	}

	public IndexTemplateMappingDescriptor<TDocument> Lifecycle(Action<DataStreamLifecycleDescriptor> configure)
	{
		LifecycleValue = null;
		LifecycleDescriptor = null;
		LifecycleDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
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

public sealed partial class IndexTemplateMappingDescriptor : SerializableDescriptor<IndexTemplateMappingDescriptor>
{
	internal IndexTemplateMappingDescriptor(Action<IndexTemplateMappingDescriptor> configure) => configure.Invoke(this);

	public IndexTemplateMappingDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Mapping.TypeMapping? MappingsValue { get; set; }
	private Mapping.TypeMappingDescriptor MappingsDescriptor { get; set; }
	private Action<Mapping.TypeMappingDescriptor> MappingsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? SettingsValue { get; set; }
	private IndexSettingsDescriptor SettingsDescriptor { get; set; }
	private Action<IndexSettingsDescriptor> SettingsDescriptorAction { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? AliasesValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycle? LifecycleValue { get; set; }
	private DataStreamLifecycleDescriptor LifecycleDescriptor { get; set; }
	private Action<DataStreamLifecycleDescriptor> LifecycleDescriptorAction { get; set; }

	/// <summary>
	/// <para>Mapping for fields in the index.<br/>If specified, this mapping can include field names, field data types, and mapping parameters.</para>
	/// </summary>
	public IndexTemplateMappingDescriptor Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMapping? mappings)
	{
		MappingsDescriptor = null;
		MappingsDescriptorAction = null;
		MappingsValue = mappings;
		return Self;
	}

	public IndexTemplateMappingDescriptor Mappings(Mapping.TypeMappingDescriptor descriptor)
	{
		MappingsValue = null;
		MappingsDescriptorAction = null;
		MappingsDescriptor = descriptor;
		return Self;
	}

	public IndexTemplateMappingDescriptor Mappings(Action<Mapping.TypeMappingDescriptor> configure)
	{
		MappingsValue = null;
		MappingsDescriptor = null;
		MappingsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Configuration options for the index.</para>
	/// </summary>
	public IndexTemplateMappingDescriptor Settings(Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? settings)
	{
		SettingsDescriptor = null;
		SettingsDescriptorAction = null;
		SettingsValue = settings;
		return Self;
	}

	public IndexTemplateMappingDescriptor Settings(IndexSettingsDescriptor descriptor)
	{
		SettingsValue = null;
		SettingsDescriptorAction = null;
		SettingsDescriptor = descriptor;
		return Self;
	}

	public IndexTemplateMappingDescriptor Settings(Action<IndexSettingsDescriptor> configure)
	{
		SettingsValue = null;
		SettingsDescriptor = null;
		SettingsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Aliases to add.<br/>If the index template includes a `data_stream` object, these are data stream aliases.<br/>Otherwise, these are index aliases.<br/>Data stream aliases ignore the `index_routing`, `routing`, and `search_routing` options.</para>
	/// </summary>
	public IndexTemplateMappingDescriptor Aliases(Func<FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>, FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>> selector)
	{
		AliasesValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>());
		return Self;
	}

	public IndexTemplateMappingDescriptor Lifecycle(Elastic.Clients.Elasticsearch.IndexManagement.DataStreamLifecycle? lifecycle)
	{
		LifecycleDescriptor = null;
		LifecycleDescriptorAction = null;
		LifecycleValue = lifecycle;
		return Self;
	}

	public IndexTemplateMappingDescriptor Lifecycle(DataStreamLifecycleDescriptor descriptor)
	{
		LifecycleValue = null;
		LifecycleDescriptorAction = null;
		LifecycleDescriptor = descriptor;
		return Self;
	}

	public IndexTemplateMappingDescriptor Lifecycle(Action<DataStreamLifecycleDescriptor> configure)
	{
		LifecycleValue = null;
		LifecycleDescriptor = null;
		LifecycleDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
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