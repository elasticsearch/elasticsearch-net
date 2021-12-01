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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndexPutTemplateRequestParameters : RequestParameters<IndexPutTemplateRequestParameters>
	{
		[JsonIgnore]
		public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public bool? IncludeTypeName { get => Q<bool?>("include_type_name"); set => Q("include_type_name", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	public partial class IndexPutTemplateRequest : PlainRequestBase<IndexPutTemplateRequestParameters>
	{
		public IndexPutTemplateRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementPutTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public bool? IncludeTypeName { get => Q<bool?>("include_type_name"); set => Q("include_type_name", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonInclude]
		[JsonPropertyName("aliases")]
		public Dictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? Aliases { get; set; }

		[JsonInclude]
		[JsonPropertyName("index_patterns")]
		public string? IndexPatterns { get; set; }

		[JsonInclude]
		[JsonPropertyName("mappings")]
		public Elastic.Clients.Elasticsearch.Mapping.TypeMapping? Mappings { get; set; }

		[JsonInclude]
		[JsonPropertyName("order")]
		public int? Order { get; set; }

		[JsonInclude]
		[JsonPropertyName("settings")]
		public Dictionary<string, object>? Settings { get; set; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public long? Version { get; set; }
	}

	public sealed partial class IndexPutTemplateRequestDescriptor : RequestDescriptorBase<IndexPutTemplateRequestDescriptor, IndexPutTemplateRequestParameters>
	{
		public IndexPutTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		public IndexPutTemplateRequestDescriptor()
		{
		}

		internal IndexPutTemplateRequestDescriptor(Action<IndexPutTemplateRequestDescriptor> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementPutTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		public IndexPutTemplateRequestDescriptor Create(bool? create) => Qs("create", create);
		public IndexPutTemplateRequestDescriptor FlatSettings(bool? flatSettings) => Qs("flat_settings", flatSettings);
		public IndexPutTemplateRequestDescriptor IncludeTypeName(bool? includeTypeName) => Qs("include_type_name", includeTypeName);
		public IndexPutTemplateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public IndexPutTemplateRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		internal Dictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? AliasesValue { get; private set; }

		internal string? IndexPatternsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Mapping.TypeMapping? MappingsValue { get; private set; }

		internal int? OrderValue { get; private set; }

		internal Dictionary<string, object>? SettingsValue { get; private set; }

		internal long? VersionValue { get; private set; }

		internal Mapping.TypeMappingDescriptor MappingsDescriptor { get; private set; }

		internal Action<Mapping.TypeMappingDescriptor> MappingsDescriptorAction { get; private set; }

		public IndexPutTemplateRequestDescriptor Aliases(Func<FluentDictionary<Elastic.Clients.Elasticsearch.IndexName?, Elastic.Clients.Elasticsearch.IndexManagement.Alias?>, FluentDictionary<Elastic.Clients.Elasticsearch.IndexName?, Elastic.Clients.Elasticsearch.IndexManagement.Alias?>> selector) => Assign(selector, (a, v) => a.AliasesValue = v?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.IndexName?, Elastic.Clients.Elasticsearch.IndexManagement.Alias?>()));
		public IndexPutTemplateRequestDescriptor IndexPatterns(string? indexPatterns) => Assign(indexPatterns, (a, v) => a.IndexPatternsValue = v);
		public IndexPutTemplateRequestDescriptor Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMapping? mappings)
		{
			MappingsDescriptor = null;
			MappingsDescriptorAction = null;
			return Assign(mappings, (a, v) => a.MappingsValue = v);
		}

		public IndexPutTemplateRequestDescriptor Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor descriptor)
		{
			MappingsValue = null;
			MappingsDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.MappingsDescriptor = v);
		}

		public IndexPutTemplateRequestDescriptor Mappings(Action<Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor> configure)
		{
			MappingsValue = null;
			MappingsDescriptorAction = null;
			return Assign(configure, (a, v) => a.MappingsDescriptorAction = v);
		}

		public IndexPutTemplateRequestDescriptor Order(int? order) => Assign(order, (a, v) => a.OrderValue = v);
		public IndexPutTemplateRequestDescriptor Settings(Func<FluentDictionary<string?, object?>, FluentDictionary<string?, object?>> selector) => Assign(selector, (a, v) => a.SettingsValue = v?.Invoke(new FluentDictionary<string?, object?>()));
		public IndexPutTemplateRequestDescriptor Version(long? version) => Assign(version, (a, v) => a.VersionValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (AliasesValue is not null)
			{
				writer.WritePropertyName("aliases");
				JsonSerializer.Serialize(writer, AliasesValue, options);
			}

			if (!string.IsNullOrEmpty(IndexPatternsValue))
			{
				writer.WritePropertyName("index_patterns");
				writer.WriteStringValue(IndexPatternsValue);
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

			if (OrderValue.HasValue)
			{
				writer.WritePropertyName("order");
				writer.WriteNumberValue(OrderValue.Value);
			}

			if (SettingsValue is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, SettingsValue, options);
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