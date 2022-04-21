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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public sealed class ClusterPutComponentTemplateRequestParameters : RequestParameters<ClusterPutComponentTemplateRequestParameters>
	{
		[JsonIgnore]
		public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }
	}

	public partial class ClusterPutComponentTemplateRequest : PlainRequestBase<ClusterPutComponentTemplateRequestParameters>
	{
		public ClusterPutComponentTemplateRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPutComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonInclude]
		[JsonPropertyName("template")]
		public Elastic.Clients.Elasticsearch.IndexManagement.IndexState Template { get; set; }

		[JsonInclude]
		[JsonPropertyName("aliases")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.IndexManagement.AliasDefinition>? Aliases { get; set; }

		[JsonInclude]
		[JsonPropertyName("mappings")]
		public Elastic.Clients.Elasticsearch.Mapping.TypeMapping? Mappings { get; set; }

		[JsonInclude]
		[JsonPropertyName("settings")]
		public Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? Settings { get; set; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public long? Version { get; set; }

		[JsonInclude]
		[JsonPropertyName("_meta")]
		public Dictionary<string, object>? Meta { get; set; }
	}

	public sealed partial class ClusterPutComponentTemplateRequestDescriptor<TDocument> : RequestDescriptorBase<ClusterPutComponentTemplateRequestDescriptor<TDocument>, ClusterPutComponentTemplateRequestParameters>
	{
		internal ClusterPutComponentTemplateRequestDescriptor(Action<ClusterPutComponentTemplateRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public ClusterPutComponentTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal ClusterPutComponentTemplateRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPutComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		public ClusterPutComponentTemplateRequestDescriptor<TDocument> Create(bool? create = true) => Qs("create", create);
		public ClusterPutComponentTemplateRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public ClusterPutComponentTemplateRequestDescriptor<TDocument> Name(Elastic.Clients.Elasticsearch.Name name)
		{
			RouteValues.Required("name", name);
			return Self;
		}

		private Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? SettingsValue { get; set; }

		private IndexManagement.IndexSettingsDescriptor<TDocument> SettingsDescriptor { get; set; }

		private Action<IndexManagement.IndexSettingsDescriptor<TDocument>> SettingsDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.IndexManagement.IndexState TemplateValue { get; set; }

		private IndexManagement.IndexStateDescriptor<TDocument> TemplateDescriptor { get; set; }

		private Action<IndexManagement.IndexStateDescriptor<TDocument>> TemplateDescriptorAction { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private Dictionary<string, Elastic.Clients.Elasticsearch.IndexManagement.AliasDefinition>? AliasesValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.TypeMapping? MappingsValue { get; set; }

		private Mapping.TypeMappingDescriptor MappingsDescriptor { get; set; }

		private Action<Mapping.TypeMappingDescriptor> MappingsDescriptorAction { get; set; }

		private long? VersionValue { get; set; }

		public ClusterPutComponentTemplateRequestDescriptor<TDocument> Settings(Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? settings)
		{
			SettingsDescriptor = null;
			SettingsDescriptorAction = null;
			SettingsValue = settings;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor<TDocument> Settings(IndexManagement.IndexSettingsDescriptor<TDocument> descriptor)
		{
			SettingsValue = null;
			SettingsDescriptorAction = null;
			SettingsDescriptor = descriptor;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor<TDocument> Settings(Action<IndexManagement.IndexSettingsDescriptor<TDocument>> configure)
		{
			SettingsValue = null;
			SettingsDescriptorAction = null;
			SettingsDescriptorAction = configure;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor<TDocument> Template(Elastic.Clients.Elasticsearch.IndexManagement.IndexState template)
		{
			TemplateDescriptor = null;
			TemplateDescriptorAction = null;
			TemplateValue = template;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor<TDocument> Template(IndexManagement.IndexStateDescriptor<TDocument> descriptor)
		{
			TemplateValue = null;
			TemplateDescriptorAction = null;
			TemplateDescriptor = descriptor;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor<TDocument> Template(Action<IndexManagement.IndexStateDescriptor<TDocument>> configure)
		{
			TemplateValue = null;
			TemplateDescriptorAction = null;
			TemplateDescriptorAction = configure;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor<TDocument> Aliases(Func<FluentDictionary<string, Elastic.Clients.Elasticsearch.IndexManagement.AliasDefinition>, FluentDictionary<string, Elastic.Clients.Elasticsearch.IndexManagement.AliasDefinition>> selector)
		{
			AliasesValue = selector?.Invoke(new FluentDictionary<string, Elastic.Clients.Elasticsearch.IndexManagement.AliasDefinition>());
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor<TDocument> Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMapping? mappings)
		{
			MappingsDescriptor = null;
			MappingsDescriptorAction = null;
			MappingsValue = mappings;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor<TDocument> Mappings(Mapping.TypeMappingDescriptor descriptor)
		{
			MappingsValue = null;
			MappingsDescriptorAction = null;
			MappingsDescriptor = descriptor;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor<TDocument> Mappings(Action<Mapping.TypeMappingDescriptor> configure)
		{
			MappingsValue = null;
			MappingsDescriptorAction = null;
			MappingsDescriptorAction = configure;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor<TDocument> Version(long? version)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (SettingsDescriptor is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, SettingsDescriptor, options);
			}
			else if (SettingsDescriptorAction is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, new IndexManagement.IndexSettingsDescriptor<TDocument>(SettingsDescriptorAction), options);
			}
			else if (SettingsValue is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, SettingsValue, options);
			}

			if (TemplateDescriptor is not null)
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, TemplateDescriptor, options);
			}
			else if (TemplateDescriptorAction is not null)
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, new IndexManagement.IndexStateDescriptor<TDocument>(TemplateDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, TemplateValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("_meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (AliasesValue is not null)
			{
				writer.WritePropertyName("aliases");
				JsonSerializer.Serialize(writer, AliasesValue, options);
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

			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class ClusterPutComponentTemplateRequestDescriptor : RequestDescriptorBase<ClusterPutComponentTemplateRequestDescriptor, ClusterPutComponentTemplateRequestParameters>
	{
		internal ClusterPutComponentTemplateRequestDescriptor(Action<ClusterPutComponentTemplateRequestDescriptor> configure) => configure.Invoke(this);
		public ClusterPutComponentTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal ClusterPutComponentTemplateRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPutComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		public ClusterPutComponentTemplateRequestDescriptor Create(bool? create = true) => Qs("create", create);
		public ClusterPutComponentTemplateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public ClusterPutComponentTemplateRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name name)
		{
			RouteValues.Required("name", name);
			return Self;
		}

		private Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? SettingsValue { get; set; }

		private IndexManagement.IndexSettingsDescriptor SettingsDescriptor { get; set; }

		private Action<IndexManagement.IndexSettingsDescriptor> SettingsDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.IndexManagement.IndexState TemplateValue { get; set; }

		private IndexManagement.IndexStateDescriptor TemplateDescriptor { get; set; }

		private Action<IndexManagement.IndexStateDescriptor> TemplateDescriptorAction { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private Dictionary<string, Elastic.Clients.Elasticsearch.IndexManagement.AliasDefinition>? AliasesValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.TypeMapping? MappingsValue { get; set; }

		private Mapping.TypeMappingDescriptor MappingsDescriptor { get; set; }

		private Action<Mapping.TypeMappingDescriptor> MappingsDescriptorAction { get; set; }

		private long? VersionValue { get; set; }

		public ClusterPutComponentTemplateRequestDescriptor Settings(Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? settings)
		{
			SettingsDescriptor = null;
			SettingsDescriptorAction = null;
			SettingsValue = settings;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor Settings(IndexManagement.IndexSettingsDescriptor descriptor)
		{
			SettingsValue = null;
			SettingsDescriptorAction = null;
			SettingsDescriptor = descriptor;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor Settings(Action<IndexManagement.IndexSettingsDescriptor> configure)
		{
			SettingsValue = null;
			SettingsDescriptorAction = null;
			SettingsDescriptorAction = configure;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor Template(Elastic.Clients.Elasticsearch.IndexManagement.IndexState template)
		{
			TemplateDescriptor = null;
			TemplateDescriptorAction = null;
			TemplateValue = template;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor Template(IndexManagement.IndexStateDescriptor descriptor)
		{
			TemplateValue = null;
			TemplateDescriptorAction = null;
			TemplateDescriptor = descriptor;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor Template(Action<IndexManagement.IndexStateDescriptor> configure)
		{
			TemplateValue = null;
			TemplateDescriptorAction = null;
			TemplateDescriptorAction = configure;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor Aliases(Func<FluentDictionary<string, Elastic.Clients.Elasticsearch.IndexManagement.AliasDefinition>, FluentDictionary<string, Elastic.Clients.Elasticsearch.IndexManagement.AliasDefinition>> selector)
		{
			AliasesValue = selector?.Invoke(new FluentDictionary<string, Elastic.Clients.Elasticsearch.IndexManagement.AliasDefinition>());
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMapping? mappings)
		{
			MappingsDescriptor = null;
			MappingsDescriptorAction = null;
			MappingsValue = mappings;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor Mappings(Mapping.TypeMappingDescriptor descriptor)
		{
			MappingsValue = null;
			MappingsDescriptorAction = null;
			MappingsDescriptor = descriptor;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor Mappings(Action<Mapping.TypeMappingDescriptor> configure)
		{
			MappingsValue = null;
			MappingsDescriptorAction = null;
			MappingsDescriptorAction = configure;
			return Self;
		}

		public ClusterPutComponentTemplateRequestDescriptor Version(long? version)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (SettingsDescriptor is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, SettingsDescriptor, options);
			}
			else if (SettingsDescriptorAction is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, new IndexManagement.IndexSettingsDescriptor(SettingsDescriptorAction), options);
			}
			else if (SettingsValue is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, SettingsValue, options);
			}

			if (TemplateDescriptor is not null)
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, TemplateDescriptor, options);
			}
			else if (TemplateDescriptorAction is not null)
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, new IndexManagement.IndexStateDescriptor(TemplateDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, TemplateValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("_meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (AliasesValue is not null)
			{
				writer.WritePropertyName("aliases");
				JsonSerializer.Serialize(writer, AliasesValue, options);
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

			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			writer.WriteEndObject();
		}
	}
}