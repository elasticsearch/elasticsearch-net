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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed partial class SimulateTemplateRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If true, the template passed in the body is only used if no existing templates match the same index patterns. If false, the simulation uses the template with the highest priority. Note that the template is not permanently added or updated in either case; it is only used for the simulation.
	/// </para>
	/// </summary>
	public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

	/// <summary>
	/// <para>
	/// If true, returns all relevant default configurations for the index template.
	/// </para>
	/// </summary>
	public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>
/// Simulate an index template.
/// Returns the index configuration that would be applied by a particular index template.
/// </para>
/// </summary>
public sealed partial class SimulateTemplateRequest : PlainRequest<SimulateTemplateRequestParameters>
{
	[JsonConstructor]
	public SimulateTemplateRequest()
	{
	}

	public SimulateTemplateRequest(Elastic.Clients.Elasticsearch.Name? name) : base(r => r.Optional("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementSimulateTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.simulate_template";

	/// <summary>
	/// <para>
	/// Name of the index template to simulate. To test a template configuration before you add it to the cluster, omit
	/// this parameter and specify the template configuration in the request body.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Name? Name { get => P<Elastic.Clients.Elasticsearch.Name?>("name"); set => PO("name", value); }

	/// <summary>
	/// <para>
	/// If true, the template passed in the body is only used if no existing templates match the same index patterns. If false, the simulation uses the template with the highest priority. Note that the template is not permanently added or updated in either case; it is only used for the simulation.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

	/// <summary>
	/// <para>
	/// If true, returns all relevant default configurations for the index template.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// This setting overrides the value of the <c>action.auto_create_index</c> cluster setting.
	/// If set to <c>true</c> in a template, then indices can be automatically created using that template even if auto-creation of indices is disabled via <c>actions.auto_create_index</c>.
	/// If set to <c>false</c>, then indices or data streams matching the template must always be explicitly created, and may never be automatically created.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("allow_auto_create")]
	public bool? AllowAutoCreate { get; set; }

	/// <summary>
	/// <para>
	/// An ordered list of component template names.
	/// Component templates are merged in the order specified, meaning that the last component template specified has the highest precedence.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("composed_of")]
	public ICollection<Elastic.Clients.Elasticsearch.Name>? ComposedOf { get; set; }

	/// <summary>
	/// <para>
	/// If this object is included, the template is used to create data streams and their backing indices.
	/// Supports an empty object.
	/// Data streams require a matching index template with a <c>data_stream</c> object.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("data_stream")]
	public Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibility? DataStream { get; set; }

	/// <summary>
	/// <para>
	/// Marks this index template as deprecated. When creating or updating a non-deprecated index template
	/// that uses deprecated components, Elasticsearch will emit a deprecation warning.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("deprecated")]
	public bool? Deprecated { get; set; }

	/// <summary>
	/// <para>
	/// The configuration option ignore_missing_component_templates can be used when an index template
	/// references a component template that might not exist
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ignore_missing_component_templates")]
	public ICollection<string>? IgnoreMissingComponentTemplates { get; set; }

	/// <summary>
	/// <para>
	/// Array of wildcard (<c>*</c>) expressions used to match the names of data streams and indices during creation.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index_patterns")]
	public Elastic.Clients.Elasticsearch.Indices? IndexPatterns { get; set; }

	/// <summary>
	/// <para>
	/// Optional user metadata about the index template.
	/// May have any contents.
	/// This map is not automatically generated by Elasticsearch.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_meta")]
	public IDictionary<string, object>? Meta { get; set; }

	/// <summary>
	/// <para>
	/// Priority to determine index template precedence when a new data stream or index is created.
	/// The index template with the highest priority is chosen.
	/// If no priority is specified the template is treated as though it is of priority 0 (lowest priority).
	/// This number is not automatically generated by Elasticsearch.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("priority")]
	public long? Priority { get; set; }

	/// <summary>
	/// <para>
	/// Template to be applied.
	/// It may optionally include an <c>aliases</c>, <c>mappings</c>, or <c>settings</c> configuration.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("template")]
	public Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? Template { get; set; }

	/// <summary>
	/// <para>
	/// Version number used to manage index templates externally.
	/// This number is not automatically generated by Elasticsearch.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("version")]
	public long? Version { get; set; }
}

/// <summary>
/// <para>
/// Simulate an index template.
/// Returns the index configuration that would be applied by a particular index template.
/// </para>
/// </summary>
public sealed partial class SimulateTemplateRequestDescriptor<TDocument> : RequestDescriptor<SimulateTemplateRequestDescriptor<TDocument>, SimulateTemplateRequestParameters>
{
	internal SimulateTemplateRequestDescriptor(Action<SimulateTemplateRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public SimulateTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name? name) : base(r => r.Optional("name", name))
	{
	}

	public SimulateTemplateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementSimulateTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.simulate_template";

	public SimulateTemplateRequestDescriptor<TDocument> Create(bool? create = true) => Qs("create", create);
	public SimulateTemplateRequestDescriptor<TDocument> IncludeDefaults(bool? includeDefaults = true) => Qs("include_defaults", includeDefaults);
	public SimulateTemplateRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);

	public SimulateTemplateRequestDescriptor<TDocument> Name(Elastic.Clients.Elasticsearch.Name? name)
	{
		RouteValues.Optional("name", name);
		return Self;
	}

	private bool? AllowAutoCreateValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Name>? ComposedOfValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibility? DataStreamValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibilityDescriptor DataStreamDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibilityDescriptor> DataStreamDescriptorAction { get; set; }
	private bool? DeprecatedValue { get; set; }
	private ICollection<string>? IgnoreMissingComponentTemplatesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Indices? IndexPatternsValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private long? PriorityValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? TemplateValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMappingDescriptor<TDocument> TemplateDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMappingDescriptor<TDocument>> TemplateDescriptorAction { get; set; }
	private long? VersionValue { get; set; }

	/// <summary>
	/// <para>
	/// This setting overrides the value of the <c>action.auto_create_index</c> cluster setting.
	/// If set to <c>true</c> in a template, then indices can be automatically created using that template even if auto-creation of indices is disabled via <c>actions.auto_create_index</c>.
	/// If set to <c>false</c>, then indices or data streams matching the template must always be explicitly created, and may never be automatically created.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor<TDocument> AllowAutoCreate(bool? allowAutoCreate = true)
	{
		AllowAutoCreateValue = allowAutoCreate;
		return Self;
	}

	/// <summary>
	/// <para>
	/// An ordered list of component template names.
	/// Component templates are merged in the order specified, meaning that the last component template specified has the highest precedence.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor<TDocument> ComposedOf(ICollection<Elastic.Clients.Elasticsearch.Name>? composedOf)
	{
		ComposedOfValue = composedOf;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If this object is included, the template is used to create data streams and their backing indices.
	/// Supports an empty object.
	/// Data streams require a matching index template with a <c>data_stream</c> object.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor<TDocument> DataStream(Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibility? dataStream)
	{
		DataStreamDescriptor = null;
		DataStreamDescriptorAction = null;
		DataStreamValue = dataStream;
		return Self;
	}

	public SimulateTemplateRequestDescriptor<TDocument> DataStream(Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibilityDescriptor descriptor)
	{
		DataStreamValue = null;
		DataStreamDescriptorAction = null;
		DataStreamDescriptor = descriptor;
		return Self;
	}

	public SimulateTemplateRequestDescriptor<TDocument> DataStream(Action<Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibilityDescriptor> configure)
	{
		DataStreamValue = null;
		DataStreamDescriptor = null;
		DataStreamDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Marks this index template as deprecated. When creating or updating a non-deprecated index template
	/// that uses deprecated components, Elasticsearch will emit a deprecation warning.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor<TDocument> Deprecated(bool? deprecated = true)
	{
		DeprecatedValue = deprecated;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The configuration option ignore_missing_component_templates can be used when an index template
	/// references a component template that might not exist
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor<TDocument> IgnoreMissingComponentTemplates(ICollection<string>? ignoreMissingComponentTemplates)
	{
		IgnoreMissingComponentTemplatesValue = ignoreMissingComponentTemplates;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Array of wildcard (<c>*</c>) expressions used to match the names of data streams and indices during creation.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor<TDocument> IndexPatterns(Elastic.Clients.Elasticsearch.Indices? indexPatterns)
	{
		IndexPatternsValue = indexPatterns;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Optional user metadata about the index template.
	/// May have any contents.
	/// This map is not automatically generated by Elasticsearch.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// Priority to determine index template precedence when a new data stream or index is created.
	/// The index template with the highest priority is chosen.
	/// If no priority is specified the template is treated as though it is of priority 0 (lowest priority).
	/// This number is not automatically generated by Elasticsearch.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor<TDocument> Priority(long? priority)
	{
		PriorityValue = priority;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Template to be applied.
	/// It may optionally include an <c>aliases</c>, <c>mappings</c>, or <c>settings</c> configuration.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor<TDocument> Template(Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? template)
	{
		TemplateDescriptor = null;
		TemplateDescriptorAction = null;
		TemplateValue = template;
		return Self;
	}

	public SimulateTemplateRequestDescriptor<TDocument> Template(Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMappingDescriptor<TDocument> descriptor)
	{
		TemplateValue = null;
		TemplateDescriptorAction = null;
		TemplateDescriptor = descriptor;
		return Self;
	}

	public SimulateTemplateRequestDescriptor<TDocument> Template(Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMappingDescriptor<TDocument>> configure)
	{
		TemplateValue = null;
		TemplateDescriptor = null;
		TemplateDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Version number used to manage index templates externally.
	/// This number is not automatically generated by Elasticsearch.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor<TDocument> Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AllowAutoCreateValue.HasValue)
		{
			writer.WritePropertyName("allow_auto_create");
			writer.WriteBooleanValue(AllowAutoCreateValue.Value);
		}

		if (ComposedOfValue is not null)
		{
			writer.WritePropertyName("composed_of");
			JsonSerializer.Serialize(writer, ComposedOfValue, options);
		}

		if (DataStreamDescriptor is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, DataStreamDescriptor, options);
		}
		else if (DataStreamDescriptorAction is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibilityDescriptor(DataStreamDescriptorAction), options);
		}
		else if (DataStreamValue is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, DataStreamValue, options);
		}

		if (DeprecatedValue.HasValue)
		{
			writer.WritePropertyName("deprecated");
			writer.WriteBooleanValue(DeprecatedValue.Value);
		}

		if (IgnoreMissingComponentTemplatesValue is not null)
		{
			writer.WritePropertyName("ignore_missing_component_templates");
			JsonSerializer.Serialize(writer, IgnoreMissingComponentTemplatesValue, options);
		}

		if (IndexPatternsValue is not null)
		{
			writer.WritePropertyName("index_patterns");
			JsonSerializer.Serialize(writer, IndexPatternsValue, options);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("_meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (PriorityValue.HasValue)
		{
			writer.WritePropertyName("priority");
			writer.WriteNumberValue(PriorityValue.Value);
		}

		if (TemplateDescriptor is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, TemplateDescriptor, options);
		}
		else if (TemplateDescriptorAction is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMappingDescriptor<TDocument>(TemplateDescriptorAction), options);
		}
		else if (TemplateValue is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, TemplateValue, options);
		}

		if (VersionValue.HasValue)
		{
			writer.WritePropertyName("version");
			writer.WriteNumberValue(VersionValue.Value);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Simulate an index template.
/// Returns the index configuration that would be applied by a particular index template.
/// </para>
/// </summary>
public sealed partial class SimulateTemplateRequestDescriptor : RequestDescriptor<SimulateTemplateRequestDescriptor, SimulateTemplateRequestParameters>
{
	internal SimulateTemplateRequestDescriptor(Action<SimulateTemplateRequestDescriptor> configure) => configure.Invoke(this);

	public SimulateTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name? name) : base(r => r.Optional("name", name))
	{
	}

	public SimulateTemplateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementSimulateTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.simulate_template";

	public SimulateTemplateRequestDescriptor Create(bool? create = true) => Qs("create", create);
	public SimulateTemplateRequestDescriptor IncludeDefaults(bool? includeDefaults = true) => Qs("include_defaults", includeDefaults);
	public SimulateTemplateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);

	public SimulateTemplateRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name? name)
	{
		RouteValues.Optional("name", name);
		return Self;
	}

	private bool? AllowAutoCreateValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Name>? ComposedOfValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibility? DataStreamValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibilityDescriptor DataStreamDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibilityDescriptor> DataStreamDescriptorAction { get; set; }
	private bool? DeprecatedValue { get; set; }
	private ICollection<string>? IgnoreMissingComponentTemplatesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Indices? IndexPatternsValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private long? PriorityValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? TemplateValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMappingDescriptor TemplateDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMappingDescriptor> TemplateDescriptorAction { get; set; }
	private long? VersionValue { get; set; }

	/// <summary>
	/// <para>
	/// This setting overrides the value of the <c>action.auto_create_index</c> cluster setting.
	/// If set to <c>true</c> in a template, then indices can be automatically created using that template even if auto-creation of indices is disabled via <c>actions.auto_create_index</c>.
	/// If set to <c>false</c>, then indices or data streams matching the template must always be explicitly created, and may never be automatically created.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor AllowAutoCreate(bool? allowAutoCreate = true)
	{
		AllowAutoCreateValue = allowAutoCreate;
		return Self;
	}

	/// <summary>
	/// <para>
	/// An ordered list of component template names.
	/// Component templates are merged in the order specified, meaning that the last component template specified has the highest precedence.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor ComposedOf(ICollection<Elastic.Clients.Elasticsearch.Name>? composedOf)
	{
		ComposedOfValue = composedOf;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If this object is included, the template is used to create data streams and their backing indices.
	/// Supports an empty object.
	/// Data streams require a matching index template with a <c>data_stream</c> object.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor DataStream(Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibility? dataStream)
	{
		DataStreamDescriptor = null;
		DataStreamDescriptorAction = null;
		DataStreamValue = dataStream;
		return Self;
	}

	public SimulateTemplateRequestDescriptor DataStream(Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibilityDescriptor descriptor)
	{
		DataStreamValue = null;
		DataStreamDescriptorAction = null;
		DataStreamDescriptor = descriptor;
		return Self;
	}

	public SimulateTemplateRequestDescriptor DataStream(Action<Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibilityDescriptor> configure)
	{
		DataStreamValue = null;
		DataStreamDescriptor = null;
		DataStreamDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Marks this index template as deprecated. When creating or updating a non-deprecated index template
	/// that uses deprecated components, Elasticsearch will emit a deprecation warning.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor Deprecated(bool? deprecated = true)
	{
		DeprecatedValue = deprecated;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The configuration option ignore_missing_component_templates can be used when an index template
	/// references a component template that might not exist
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor IgnoreMissingComponentTemplates(ICollection<string>? ignoreMissingComponentTemplates)
	{
		IgnoreMissingComponentTemplatesValue = ignoreMissingComponentTemplates;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Array of wildcard (<c>*</c>) expressions used to match the names of data streams and indices during creation.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor IndexPatterns(Elastic.Clients.Elasticsearch.Indices? indexPatterns)
	{
		IndexPatternsValue = indexPatterns;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Optional user metadata about the index template.
	/// May have any contents.
	/// This map is not automatically generated by Elasticsearch.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// Priority to determine index template precedence when a new data stream or index is created.
	/// The index template with the highest priority is chosen.
	/// If no priority is specified the template is treated as though it is of priority 0 (lowest priority).
	/// This number is not automatically generated by Elasticsearch.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor Priority(long? priority)
	{
		PriorityValue = priority;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Template to be applied.
	/// It may optionally include an <c>aliases</c>, <c>mappings</c>, or <c>settings</c> configuration.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor Template(Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? template)
	{
		TemplateDescriptor = null;
		TemplateDescriptorAction = null;
		TemplateValue = template;
		return Self;
	}

	public SimulateTemplateRequestDescriptor Template(Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMappingDescriptor descriptor)
	{
		TemplateValue = null;
		TemplateDescriptorAction = null;
		TemplateDescriptor = descriptor;
		return Self;
	}

	public SimulateTemplateRequestDescriptor Template(Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMappingDescriptor> configure)
	{
		TemplateValue = null;
		TemplateDescriptor = null;
		TemplateDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Version number used to manage index templates externally.
	/// This number is not automatically generated by Elasticsearch.
	/// </para>
	/// </summary>
	public SimulateTemplateRequestDescriptor Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AllowAutoCreateValue.HasValue)
		{
			writer.WritePropertyName("allow_auto_create");
			writer.WriteBooleanValue(AllowAutoCreateValue.Value);
		}

		if (ComposedOfValue is not null)
		{
			writer.WritePropertyName("composed_of");
			JsonSerializer.Serialize(writer, ComposedOfValue, options);
		}

		if (DataStreamDescriptor is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, DataStreamDescriptor, options);
		}
		else if (DataStreamDescriptorAction is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.IndexManagement.DataStreamVisibilityDescriptor(DataStreamDescriptorAction), options);
		}
		else if (DataStreamValue is not null)
		{
			writer.WritePropertyName("data_stream");
			JsonSerializer.Serialize(writer, DataStreamValue, options);
		}

		if (DeprecatedValue.HasValue)
		{
			writer.WritePropertyName("deprecated");
			writer.WriteBooleanValue(DeprecatedValue.Value);
		}

		if (IgnoreMissingComponentTemplatesValue is not null)
		{
			writer.WritePropertyName("ignore_missing_component_templates");
			JsonSerializer.Serialize(writer, IgnoreMissingComponentTemplatesValue, options);
		}

		if (IndexPatternsValue is not null)
		{
			writer.WritePropertyName("index_patterns");
			JsonSerializer.Serialize(writer, IndexPatternsValue, options);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("_meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (PriorityValue.HasValue)
		{
			writer.WritePropertyName("priority");
			writer.WriteNumberValue(PriorityValue.Value);
		}

		if (TemplateDescriptor is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, TemplateDescriptor, options);
		}
		else if (TemplateDescriptorAction is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMappingDescriptor(TemplateDescriptorAction), options);
		}
		else if (TemplateValue is not null)
		{
			writer.WritePropertyName("template");
			JsonSerializer.Serialize(writer, TemplateValue, options);
		}

		if (VersionValue.HasValue)
		{
			writer.WritePropertyName("version");
			writer.WriteNumberValue(VersionValue.Value);
		}

		writer.WriteEndObject();
	}
}