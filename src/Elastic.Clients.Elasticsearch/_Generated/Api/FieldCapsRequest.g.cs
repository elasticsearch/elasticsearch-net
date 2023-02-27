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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch;
public sealed class FieldCapsRequestParameters : RequestParameters
{
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fields"); set => Q("fields", value); }

	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	[JsonIgnore]
	public bool? IncludeUnmapped { get => Q<bool?>("include_unmapped"); set => Q("include_unmapped", value); }

	[JsonIgnore]
	public string? Filters { get => Q<string?>("filters"); set => Q("filters", value); }

	[JsonIgnore]
	public ICollection<string>? Types { get => Q<ICollection<string>?>("types"); set => Q("types", value); }
}

public sealed partial class FieldCapsRequest : PlainRequest<FieldCapsRequestParameters>
{
	public FieldCapsRequest()
	{
	}

	public FieldCapsRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceFieldCaps;
	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;
	internal override bool SupportsBody => true;
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fields"); set => Q("fields", value); }

	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	[JsonIgnore]
	public bool? IncludeUnmapped { get => Q<bool?>("include_unmapped"); set => Q("include_unmapped", value); }

	[JsonIgnore]
	public string? Filters { get => Q<string?>("filters"); set => Q("filters", value); }

	[JsonIgnore]
	public ICollection<string>? Types { get => Q<ICollection<string>?>("types"); set => Q("types", value); }

	[JsonInclude, JsonPropertyName("index_filter")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Query? IndexFilter { get; set; }

	[JsonInclude, JsonPropertyName("runtime_mappings")]
	public IDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>? RuntimeMappings { get; set; }
}

public sealed partial class FieldCapsRequestDescriptor<TDocument> : RequestDescriptor<FieldCapsRequestDescriptor<TDocument>, FieldCapsRequestParameters>
{
	internal FieldCapsRequestDescriptor(Action<FieldCapsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public FieldCapsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceFieldCaps;
	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;
	internal override bool SupportsBody => true;
	public FieldCapsRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public FieldCapsRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public FieldCapsRequestDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields? fields) => Qs("fields", fields);
	public FieldCapsRequestDescriptor<TDocument> Filters(string? filters) => Qs("filters", filters);
	public FieldCapsRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public FieldCapsRequestDescriptor<TDocument> IncludeUnmapped(bool? includeUnmapped = true) => Qs("include_unmapped", includeUnmapped);
	public FieldCapsRequestDescriptor<TDocument> Types(ICollection<string>? types) => Qs("types", types);
	public FieldCapsRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.Query? IndexFilterValue { get; set; }

	private QueryDsl.QueryDescriptor<TDocument> IndexFilterDescriptor { get; set; }

	private Action<QueryDsl.QueryDescriptor<TDocument>> IndexFilterDescriptorAction { get; set; }

	private IDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>? RuntimeMappingsValue { get; set; }

	public FieldCapsRequestDescriptor<TDocument> IndexFilter(Elastic.Clients.Elasticsearch.QueryDsl.Query? indexFilter)
	{
		IndexFilterDescriptor = null;
		IndexFilterDescriptorAction = null;
		IndexFilterValue = indexFilter;
		return Self;
	}

	public FieldCapsRequestDescriptor<TDocument> IndexFilter(QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		IndexFilterValue = null;
		IndexFilterDescriptorAction = null;
		IndexFilterDescriptor = descriptor;
		return Self;
	}

	public FieldCapsRequestDescriptor<TDocument> IndexFilter(Action<QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		IndexFilterValue = null;
		IndexFilterDescriptor = null;
		IndexFilterDescriptorAction = configure;
		return Self;
	}

	public FieldCapsRequestDescriptor<TDocument> RuntimeMappings(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>> selector)
	{
		RuntimeMappingsValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IndexFilterDescriptor is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, IndexFilterDescriptor, options);
		}
		else if (IndexFilterDescriptorAction is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, new QueryDsl.QueryDescriptor<TDocument>(IndexFilterDescriptorAction), options);
		}
		else if (IndexFilterValue is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, IndexFilterValue, options);
		}

		if (RuntimeMappingsValue is not null)
		{
			writer.WritePropertyName("runtime_mappings");
			JsonSerializer.Serialize(writer, RuntimeMappingsValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class FieldCapsRequestDescriptor : RequestDescriptor<FieldCapsRequestDescriptor, FieldCapsRequestParameters>
{
	internal FieldCapsRequestDescriptor(Action<FieldCapsRequestDescriptor> configure) => configure.Invoke(this);
	public FieldCapsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceFieldCaps;
	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;
	internal override bool SupportsBody => true;
	public FieldCapsRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public FieldCapsRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public FieldCapsRequestDescriptor Fields(Elastic.Clients.Elasticsearch.Fields? fields) => Qs("fields", fields);
	public FieldCapsRequestDescriptor Filters(string? filters) => Qs("filters", filters);
	public FieldCapsRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public FieldCapsRequestDescriptor IncludeUnmapped(bool? includeUnmapped = true) => Qs("include_unmapped", includeUnmapped);
	public FieldCapsRequestDescriptor Types(ICollection<string>? types) => Qs("types", types);
	public FieldCapsRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.Query? IndexFilterValue { get; set; }

	private QueryDsl.QueryDescriptor IndexFilterDescriptor { get; set; }

	private Action<QueryDsl.QueryDescriptor> IndexFilterDescriptorAction { get; set; }

	private IDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>? RuntimeMappingsValue { get; set; }

	public FieldCapsRequestDescriptor IndexFilter(Elastic.Clients.Elasticsearch.QueryDsl.Query? indexFilter)
	{
		IndexFilterDescriptor = null;
		IndexFilterDescriptorAction = null;
		IndexFilterValue = indexFilter;
		return Self;
	}

	public FieldCapsRequestDescriptor IndexFilter(QueryDsl.QueryDescriptor descriptor)
	{
		IndexFilterValue = null;
		IndexFilterDescriptorAction = null;
		IndexFilterDescriptor = descriptor;
		return Self;
	}

	public FieldCapsRequestDescriptor IndexFilter(Action<QueryDsl.QueryDescriptor> configure)
	{
		IndexFilterValue = null;
		IndexFilterDescriptor = null;
		IndexFilterDescriptorAction = configure;
		return Self;
	}

	public FieldCapsRequestDescriptor RuntimeMappings(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>> selector)
	{
		RuntimeMappingsValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IndexFilterDescriptor is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, IndexFilterDescriptor, options);
		}
		else if (IndexFilterDescriptorAction is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, new QueryDsl.QueryDescriptor(IndexFilterDescriptorAction), options);
		}
		else if (IndexFilterValue is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, IndexFilterValue, options);
		}

		if (RuntimeMappingsValue is not null)
		{
			writer.WritePropertyName("runtime_mappings");
			JsonSerializer.Serialize(writer, RuntimeMappingsValue, options);
		}

		writer.WriteEndObject();
	}
}