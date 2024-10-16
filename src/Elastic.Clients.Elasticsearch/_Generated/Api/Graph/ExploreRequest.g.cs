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

namespace Elastic.Clients.Elasticsearch.Graph;

public sealed partial class ExploreRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Custom value used to route operations to a specific shard.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>
	/// Specifies the period of time to wait for a response from each shard.
	/// If no response is received before the timeout expires, the request fails and returns an error.
	/// Defaults to no timeout.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Extracts and summarizes information about the documents and terms in an Elasticsearch data stream or index.
/// </para>
/// </summary>
public sealed partial class ExploreRequest : PlainRequest<ExploreRequestParameters>
{
	public ExploreRequest(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.GraphExplore;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "graph.explore";

	/// <summary>
	/// <para>
	/// Custom value used to route operations to a specific shard.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>
	/// Specifies the period of time to wait for a response from each shard.
	/// If no response is received before the timeout expires, the request fails and returns an error.
	/// Defaults to no timeout.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>
	/// Specifies or more fields from which you want to extract terms that are associated with the specified vertices.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("connections")]
	public Elastic.Clients.Elasticsearch.Graph.Hop? Connections { get; set; }

	/// <summary>
	/// <para>
	/// Direct the Graph API how to build the graph.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("controls")]
	public Elastic.Clients.Elasticsearch.Graph.ExploreControls? Controls { get; set; }

	/// <summary>
	/// <para>
	/// A seed query that identifies the documents of interest. Can be any valid Elasticsearch query.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Query? Query { get; set; }

	/// <summary>
	/// <para>
	/// Specifies one or more fields that contain the terms you want to include in the graph as vertices.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("vertices")]
	public ICollection<Elastic.Clients.Elasticsearch.Graph.VertexDefinition>? Vertices { get; set; }
}

/// <summary>
/// <para>
/// Extracts and summarizes information about the documents and terms in an Elasticsearch data stream or index.
/// </para>
/// </summary>
public sealed partial class ExploreRequestDescriptor<TDocument> : RequestDescriptor<ExploreRequestDescriptor<TDocument>, ExploreRequestParameters>
{
	internal ExploreRequestDescriptor(Action<ExploreRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public ExploreRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	public ExploreRequestDescriptor() : this(typeof(TDocument))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.GraphExplore;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "graph.explore";

	public ExploreRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public ExploreRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	public ExploreRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Graph.Hop? ConnectionsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Graph.HopDescriptor<TDocument> ConnectionsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Graph.HopDescriptor<TDocument>> ConnectionsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Graph.ExploreControls? ControlsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Graph.ExploreControlsDescriptor<TDocument> ControlsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Graph.ExploreControlsDescriptor<TDocument>> ControlsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Query? QueryValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> QueryDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> QueryDescriptorAction { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Graph.VertexDefinition>? VerticesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Graph.VertexDefinitionDescriptor<TDocument> VerticesDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Graph.VertexDefinitionDescriptor<TDocument>> VerticesDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Graph.VertexDefinitionDescriptor<TDocument>>[] VerticesDescriptorActions { get; set; }

	/// <summary>
	/// <para>
	/// Specifies or more fields from which you want to extract terms that are associated with the specified vertices.
	/// </para>
	/// </summary>
	public ExploreRequestDescriptor<TDocument> Connections(Elastic.Clients.Elasticsearch.Graph.Hop? connections)
	{
		ConnectionsDescriptor = null;
		ConnectionsDescriptorAction = null;
		ConnectionsValue = connections;
		return Self;
	}

	public ExploreRequestDescriptor<TDocument> Connections(Elastic.Clients.Elasticsearch.Graph.HopDescriptor<TDocument> descriptor)
	{
		ConnectionsValue = null;
		ConnectionsDescriptorAction = null;
		ConnectionsDescriptor = descriptor;
		return Self;
	}

	public ExploreRequestDescriptor<TDocument> Connections(Action<Elastic.Clients.Elasticsearch.Graph.HopDescriptor<TDocument>> configure)
	{
		ConnectionsValue = null;
		ConnectionsDescriptor = null;
		ConnectionsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Direct the Graph API how to build the graph.
	/// </para>
	/// </summary>
	public ExploreRequestDescriptor<TDocument> Controls(Elastic.Clients.Elasticsearch.Graph.ExploreControls? controls)
	{
		ControlsDescriptor = null;
		ControlsDescriptorAction = null;
		ControlsValue = controls;
		return Self;
	}

	public ExploreRequestDescriptor<TDocument> Controls(Elastic.Clients.Elasticsearch.Graph.ExploreControlsDescriptor<TDocument> descriptor)
	{
		ControlsValue = null;
		ControlsDescriptorAction = null;
		ControlsDescriptor = descriptor;
		return Self;
	}

	public ExploreRequestDescriptor<TDocument> Controls(Action<Elastic.Clients.Elasticsearch.Graph.ExploreControlsDescriptor<TDocument>> configure)
	{
		ControlsValue = null;
		ControlsDescriptor = null;
		ControlsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A seed query that identifies the documents of interest. Can be any valid Elasticsearch query.
	/// </para>
	/// </summary>
	public ExploreRequestDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.Query? query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public ExploreRequestDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public ExploreRequestDescriptor<TDocument> Query(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Specifies one or more fields that contain the terms you want to include in the graph as vertices.
	/// </para>
	/// </summary>
	public ExploreRequestDescriptor<TDocument> Vertices(ICollection<Elastic.Clients.Elasticsearch.Graph.VertexDefinition>? vertices)
	{
		VerticesDescriptor = null;
		VerticesDescriptorAction = null;
		VerticesDescriptorActions = null;
		VerticesValue = vertices;
		return Self;
	}

	public ExploreRequestDescriptor<TDocument> Vertices(Elastic.Clients.Elasticsearch.Graph.VertexDefinitionDescriptor<TDocument> descriptor)
	{
		VerticesValue = null;
		VerticesDescriptorAction = null;
		VerticesDescriptorActions = null;
		VerticesDescriptor = descriptor;
		return Self;
	}

	public ExploreRequestDescriptor<TDocument> Vertices(Action<Elastic.Clients.Elasticsearch.Graph.VertexDefinitionDescriptor<TDocument>> configure)
	{
		VerticesValue = null;
		VerticesDescriptor = null;
		VerticesDescriptorActions = null;
		VerticesDescriptorAction = configure;
		return Self;
	}

	public ExploreRequestDescriptor<TDocument> Vertices(params Action<Elastic.Clients.Elasticsearch.Graph.VertexDefinitionDescriptor<TDocument>>[] configure)
	{
		VerticesValue = null;
		VerticesDescriptor = null;
		VerticesDescriptorAction = null;
		VerticesDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ConnectionsDescriptor is not null)
		{
			writer.WritePropertyName("connections");
			JsonSerializer.Serialize(writer, ConnectionsDescriptor, options);
		}
		else if (ConnectionsDescriptorAction is not null)
		{
			writer.WritePropertyName("connections");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Graph.HopDescriptor<TDocument>(ConnectionsDescriptorAction), options);
		}
		else if (ConnectionsValue is not null)
		{
			writer.WritePropertyName("connections");
			JsonSerializer.Serialize(writer, ConnectionsValue, options);
		}

		if (ControlsDescriptor is not null)
		{
			writer.WritePropertyName("controls");
			JsonSerializer.Serialize(writer, ControlsDescriptor, options);
		}
		else if (ControlsDescriptorAction is not null)
		{
			writer.WritePropertyName("controls");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Graph.ExploreControlsDescriptor<TDocument>(ControlsDescriptorAction), options);
		}
		else if (ControlsValue is not null)
		{
			writer.WritePropertyName("controls");
			JsonSerializer.Serialize(writer, ControlsValue, options);
		}

		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(QueryDescriptorAction), options);
		}
		else if (QueryValue is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (VerticesDescriptor is not null)
		{
			writer.WritePropertyName("vertices");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, VerticesDescriptor, options);
			writer.WriteEndArray();
		}
		else if (VerticesDescriptorAction is not null)
		{
			writer.WritePropertyName("vertices");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Graph.VertexDefinitionDescriptor<TDocument>(VerticesDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (VerticesDescriptorActions is not null)
		{
			writer.WritePropertyName("vertices");
			writer.WriteStartArray();
			foreach (var action in VerticesDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Graph.VertexDefinitionDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (VerticesValue is not null)
		{
			writer.WritePropertyName("vertices");
			JsonSerializer.Serialize(writer, VerticesValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Extracts and summarizes information about the documents and terms in an Elasticsearch data stream or index.
/// </para>
/// </summary>
public sealed partial class ExploreRequestDescriptor : RequestDescriptor<ExploreRequestDescriptor, ExploreRequestParameters>
{
	internal ExploreRequestDescriptor(Action<ExploreRequestDescriptor> configure) => configure.Invoke(this);

	public ExploreRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.GraphExplore;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "graph.explore";

	public ExploreRequestDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public ExploreRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	public ExploreRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Graph.Hop? ConnectionsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Graph.HopDescriptor ConnectionsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Graph.HopDescriptor> ConnectionsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Graph.ExploreControls? ControlsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Graph.ExploreControlsDescriptor ControlsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Graph.ExploreControlsDescriptor> ControlsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Query? QueryValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor QueryDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> QueryDescriptorAction { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Graph.VertexDefinition>? VerticesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Graph.VertexDefinitionDescriptor VerticesDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Graph.VertexDefinitionDescriptor> VerticesDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Graph.VertexDefinitionDescriptor>[] VerticesDescriptorActions { get; set; }

	/// <summary>
	/// <para>
	/// Specifies or more fields from which you want to extract terms that are associated with the specified vertices.
	/// </para>
	/// </summary>
	public ExploreRequestDescriptor Connections(Elastic.Clients.Elasticsearch.Graph.Hop? connections)
	{
		ConnectionsDescriptor = null;
		ConnectionsDescriptorAction = null;
		ConnectionsValue = connections;
		return Self;
	}

	public ExploreRequestDescriptor Connections(Elastic.Clients.Elasticsearch.Graph.HopDescriptor descriptor)
	{
		ConnectionsValue = null;
		ConnectionsDescriptorAction = null;
		ConnectionsDescriptor = descriptor;
		return Self;
	}

	public ExploreRequestDescriptor Connections(Action<Elastic.Clients.Elasticsearch.Graph.HopDescriptor> configure)
	{
		ConnectionsValue = null;
		ConnectionsDescriptor = null;
		ConnectionsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Direct the Graph API how to build the graph.
	/// </para>
	/// </summary>
	public ExploreRequestDescriptor Controls(Elastic.Clients.Elasticsearch.Graph.ExploreControls? controls)
	{
		ControlsDescriptor = null;
		ControlsDescriptorAction = null;
		ControlsValue = controls;
		return Self;
	}

	public ExploreRequestDescriptor Controls(Elastic.Clients.Elasticsearch.Graph.ExploreControlsDescriptor descriptor)
	{
		ControlsValue = null;
		ControlsDescriptorAction = null;
		ControlsDescriptor = descriptor;
		return Self;
	}

	public ExploreRequestDescriptor Controls(Action<Elastic.Clients.Elasticsearch.Graph.ExploreControlsDescriptor> configure)
	{
		ControlsValue = null;
		ControlsDescriptor = null;
		ControlsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A seed query that identifies the documents of interest. Can be any valid Elasticsearch query.
	/// </para>
	/// </summary>
	public ExploreRequestDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.Query? query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public ExploreRequestDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public ExploreRequestDescriptor Query(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Specifies one or more fields that contain the terms you want to include in the graph as vertices.
	/// </para>
	/// </summary>
	public ExploreRequestDescriptor Vertices(ICollection<Elastic.Clients.Elasticsearch.Graph.VertexDefinition>? vertices)
	{
		VerticesDescriptor = null;
		VerticesDescriptorAction = null;
		VerticesDescriptorActions = null;
		VerticesValue = vertices;
		return Self;
	}

	public ExploreRequestDescriptor Vertices(Elastic.Clients.Elasticsearch.Graph.VertexDefinitionDescriptor descriptor)
	{
		VerticesValue = null;
		VerticesDescriptorAction = null;
		VerticesDescriptorActions = null;
		VerticesDescriptor = descriptor;
		return Self;
	}

	public ExploreRequestDescriptor Vertices(Action<Elastic.Clients.Elasticsearch.Graph.VertexDefinitionDescriptor> configure)
	{
		VerticesValue = null;
		VerticesDescriptor = null;
		VerticesDescriptorActions = null;
		VerticesDescriptorAction = configure;
		return Self;
	}

	public ExploreRequestDescriptor Vertices(params Action<Elastic.Clients.Elasticsearch.Graph.VertexDefinitionDescriptor>[] configure)
	{
		VerticesValue = null;
		VerticesDescriptor = null;
		VerticesDescriptorAction = null;
		VerticesDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ConnectionsDescriptor is not null)
		{
			writer.WritePropertyName("connections");
			JsonSerializer.Serialize(writer, ConnectionsDescriptor, options);
		}
		else if (ConnectionsDescriptorAction is not null)
		{
			writer.WritePropertyName("connections");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Graph.HopDescriptor(ConnectionsDescriptorAction), options);
		}
		else if (ConnectionsValue is not null)
		{
			writer.WritePropertyName("connections");
			JsonSerializer.Serialize(writer, ConnectionsValue, options);
		}

		if (ControlsDescriptor is not null)
		{
			writer.WritePropertyName("controls");
			JsonSerializer.Serialize(writer, ControlsDescriptor, options);
		}
		else if (ControlsDescriptorAction is not null)
		{
			writer.WritePropertyName("controls");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Graph.ExploreControlsDescriptor(ControlsDescriptorAction), options);
		}
		else if (ControlsValue is not null)
		{
			writer.WritePropertyName("controls");
			JsonSerializer.Serialize(writer, ControlsValue, options);
		}

		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(QueryDescriptorAction), options);
		}
		else if (QueryValue is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (VerticesDescriptor is not null)
		{
			writer.WritePropertyName("vertices");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, VerticesDescriptor, options);
			writer.WriteEndArray();
		}
		else if (VerticesDescriptorAction is not null)
		{
			writer.WritePropertyName("vertices");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Graph.VertexDefinitionDescriptor(VerticesDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (VerticesDescriptorActions is not null)
		{
			writer.WritePropertyName("vertices");
			writer.WriteStartArray();
			foreach (var action in VerticesDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Graph.VertexDefinitionDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (VerticesValue is not null)
		{
			writer.WritePropertyName("vertices");
			JsonSerializer.Serialize(writer, VerticesValue, options);
		}

		writer.WriteEndObject();
	}
}