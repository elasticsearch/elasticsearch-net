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
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class PutAliasRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Period to wait for a connection to the master node.<br/>If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>Period to wait for a response.<br/>If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>Create or update an alias.<br/>Adds a data stream or index to an alias.</para>
/// </summary>
public sealed partial class PutAliasRequest : PlainRequest<PutAliasRequestParameters>
{
	public PutAliasRequest(Elastic.Clients.Elasticsearch.Serverless.Indices indices, Elastic.Clients.Elasticsearch.Serverless.Name name) : base(r => r.Required("index", indices).Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementPutAlias;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.put_alias";

	/// <summary>
	/// <para>Period to wait for a connection to the master node.<br/>If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>Period to wait for a response.<br/>If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>Query used to limit documents the alias can access.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("filter")]
	public Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? Filter { get; set; }

	/// <summary>
	/// <para>Value used to route indexing operations to a specific shard.<br/>If specified, this overwrites the `routing` value for indexing operations.<br/>Data stream aliases don’t support this parameter.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index_routing")]
	public Elastic.Clients.Elasticsearch.Serverless.Routing? IndexRouting { get; set; }

	/// <summary>
	/// <para>If `true`, sets the write index or data stream for the alias.<br/>If an alias points to multiple indices or data streams and `is_write_index` isn’t set, the alias rejects write requests.<br/>If an index alias points to one index and `is_write_index` isn’t set, the index automatically acts as the write index.<br/>Data stream aliases don’t automatically set a write data stream, even if the alias points to one data stream.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("is_write_index")]
	public bool? IsWriteIndex { get; set; }

	/// <summary>
	/// <para>Value used to route indexing and search operations to a specific shard.<br/>Data stream aliases don’t support this parameter.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("routing")]
	public Elastic.Clients.Elasticsearch.Serverless.Routing? Routing { get; set; }

	/// <summary>
	/// <para>Value used to route search operations to a specific shard.<br/>If specified, this overwrites the `routing` value for search operations.<br/>Data stream aliases don’t support this parameter.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("search_routing")]
	public Elastic.Clients.Elasticsearch.Serverless.Routing? SearchRouting { get; set; }
}

/// <summary>
/// <para>Create or update an alias.<br/>Adds a data stream or index to an alias.</para>
/// </summary>
public sealed partial class PutAliasRequestDescriptor<TDocument> : RequestDescriptor<PutAliasRequestDescriptor<TDocument>, PutAliasRequestParameters>
{
	internal PutAliasRequestDescriptor(Action<PutAliasRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public PutAliasRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Indices indices, Elastic.Clients.Elasticsearch.Serverless.Name name) : base(r => r.Required("index", indices).Required("name", name))
	{
	}

	public PutAliasRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Name name) : this(typeof(TDocument), name)
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementPutAlias;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.put_alias";

	public PutAliasRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public PutAliasRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout) => Qs("timeout", timeout);

	public PutAliasRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Serverless.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	public PutAliasRequestDescriptor<TDocument> Name(Elastic.Clients.Elasticsearch.Serverless.Name name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument> FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>> FilterDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Routing? IndexRoutingValue { get; set; }
	private bool? IsWriteIndexValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Routing? RoutingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Routing? SearchRoutingValue { get; set; }

	/// <summary>
	/// <para>Query used to limit documents the alias can access.</para>
	/// </summary>
	public PutAliasRequestDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterValue = filter;
		return Self;
	}

	public PutAliasRequestDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public PutAliasRequestDescriptor<TDocument> Filter(Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Value used to route indexing operations to a specific shard.<br/>If specified, this overwrites the `routing` value for indexing operations.<br/>Data stream aliases don’t support this parameter.</para>
	/// </summary>
	public PutAliasRequestDescriptor<TDocument> IndexRouting(Elastic.Clients.Elasticsearch.Serverless.Routing? indexRouting)
	{
		IndexRoutingValue = indexRouting;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, sets the write index or data stream for the alias.<br/>If an alias points to multiple indices or data streams and `is_write_index` isn’t set, the alias rejects write requests.<br/>If an index alias points to one index and `is_write_index` isn’t set, the index automatically acts as the write index.<br/>Data stream aliases don’t automatically set a write data stream, even if the alias points to one data stream.</para>
	/// </summary>
	public PutAliasRequestDescriptor<TDocument> IsWriteIndex(bool? isWriteIndex = true)
	{
		IsWriteIndexValue = isWriteIndex;
		return Self;
	}

	/// <summary>
	/// <para>Value used to route indexing and search operations to a specific shard.<br/>Data stream aliases don’t support this parameter.</para>
	/// </summary>
	public PutAliasRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Serverless.Routing? routing)
	{
		RoutingValue = routing;
		return Self;
	}

	/// <summary>
	/// <para>Value used to route search operations to a specific shard.<br/>If specified, this overwrites the `routing` value for search operations.<br/>Data stream aliases don’t support this parameter.</para>
	/// </summary>
	public PutAliasRequestDescriptor<TDocument> SearchRouting(Elastic.Clients.Elasticsearch.Serverless.Routing? searchRouting)
	{
		SearchRoutingValue = searchRouting;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>(FilterDescriptorAction), options);
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		if (IndexRoutingValue is not null)
		{
			writer.WritePropertyName("index_routing");
			JsonSerializer.Serialize(writer, IndexRoutingValue, options);
		}

		if (IsWriteIndexValue.HasValue)
		{
			writer.WritePropertyName("is_write_index");
			writer.WriteBooleanValue(IsWriteIndexValue.Value);
		}

		if (RoutingValue is not null)
		{
			writer.WritePropertyName("routing");
			JsonSerializer.Serialize(writer, RoutingValue, options);
		}

		if (SearchRoutingValue is not null)
		{
			writer.WritePropertyName("search_routing");
			JsonSerializer.Serialize(writer, SearchRoutingValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Create or update an alias.<br/>Adds a data stream or index to an alias.</para>
/// </summary>
public sealed partial class PutAliasRequestDescriptor : RequestDescriptor<PutAliasRequestDescriptor, PutAliasRequestParameters>
{
	internal PutAliasRequestDescriptor(Action<PutAliasRequestDescriptor> configure) => configure.Invoke(this);

	public PutAliasRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Indices indices, Elastic.Clients.Elasticsearch.Serverless.Name name) : base(r => r.Required("index", indices).Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementPutAlias;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.put_alias";

	public PutAliasRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public PutAliasRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout) => Qs("timeout", timeout);

	public PutAliasRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Serverless.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	public PutAliasRequestDescriptor Name(Elastic.Clients.Elasticsearch.Serverless.Name name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor> FilterDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Routing? IndexRoutingValue { get; set; }
	private bool? IsWriteIndexValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Routing? RoutingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Routing? SearchRoutingValue { get; set; }

	/// <summary>
	/// <para>Query used to limit documents the alias can access.</para>
	/// </summary>
	public PutAliasRequestDescriptor Filter(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterValue = filter;
		return Self;
	}

	public PutAliasRequestDescriptor Filter(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public PutAliasRequestDescriptor Filter(Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Value used to route indexing operations to a specific shard.<br/>If specified, this overwrites the `routing` value for indexing operations.<br/>Data stream aliases don’t support this parameter.</para>
	/// </summary>
	public PutAliasRequestDescriptor IndexRouting(Elastic.Clients.Elasticsearch.Serverless.Routing? indexRouting)
	{
		IndexRoutingValue = indexRouting;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, sets the write index or data stream for the alias.<br/>If an alias points to multiple indices or data streams and `is_write_index` isn’t set, the alias rejects write requests.<br/>If an index alias points to one index and `is_write_index` isn’t set, the index automatically acts as the write index.<br/>Data stream aliases don’t automatically set a write data stream, even if the alias points to one data stream.</para>
	/// </summary>
	public PutAliasRequestDescriptor IsWriteIndex(bool? isWriteIndex = true)
	{
		IsWriteIndexValue = isWriteIndex;
		return Self;
	}

	/// <summary>
	/// <para>Value used to route indexing and search operations to a specific shard.<br/>Data stream aliases don’t support this parameter.</para>
	/// </summary>
	public PutAliasRequestDescriptor Routing(Elastic.Clients.Elasticsearch.Serverless.Routing? routing)
	{
		RoutingValue = routing;
		return Self;
	}

	/// <summary>
	/// <para>Value used to route search operations to a specific shard.<br/>If specified, this overwrites the `routing` value for search operations.<br/>Data stream aliases don’t support this parameter.</para>
	/// </summary>
	public PutAliasRequestDescriptor SearchRouting(Elastic.Clients.Elasticsearch.Serverless.Routing? searchRouting)
	{
		SearchRoutingValue = searchRouting;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor(FilterDescriptorAction), options);
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		if (IndexRoutingValue is not null)
		{
			writer.WritePropertyName("index_routing");
			JsonSerializer.Serialize(writer, IndexRoutingValue, options);
		}

		if (IsWriteIndexValue.HasValue)
		{
			writer.WritePropertyName("is_write_index");
			writer.WriteBooleanValue(IsWriteIndexValue.Value);
		}

		if (RoutingValue is not null)
		{
			writer.WritePropertyName("routing");
			JsonSerializer.Serialize(writer, RoutingValue, options);
		}

		if (SearchRoutingValue is not null)
		{
			writer.WritePropertyName("search_routing");
			JsonSerializer.Serialize(writer, SearchRoutingValue, options);
		}

		writer.WriteEndObject();
	}
}