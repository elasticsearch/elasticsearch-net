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

public sealed partial class UpdateAliasesRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node.
	/// If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a response.
	/// If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Create or update an alias.
/// Adds a data stream or index to an alias.
/// </para>
/// </summary>
public sealed partial class UpdateAliasesRequest : PlainRequest<UpdateAliasesRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementUpdateAliases;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.update_aliases";

	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node.
	/// If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a response.
	/// If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>
	/// Actions to perform.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("actions")]
	public ICollection<Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesAction>? Actions { get; set; }
}

/// <summary>
/// <para>
/// Create or update an alias.
/// Adds a data stream or index to an alias.
/// </para>
/// </summary>
public sealed partial class UpdateAliasesRequestDescriptor<TDocument> : RequestDescriptor<UpdateAliasesRequestDescriptor<TDocument>, UpdateAliasesRequestParameters>
{
	internal UpdateAliasesRequestDescriptor(Action<UpdateAliasesRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public UpdateAliasesRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementUpdateAliases;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.update_aliases";

	public UpdateAliasesRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public UpdateAliasesRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	private ICollection<Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesAction>? ActionsValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesActionDescriptor<TDocument> ActionsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesActionDescriptor<TDocument>> ActionsDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesActionDescriptor<TDocument>>[] ActionsDescriptorActions { get; set; }

	/// <summary>
	/// <para>
	/// Actions to perform.
	/// </para>
	/// </summary>
	public UpdateAliasesRequestDescriptor<TDocument> Actions(ICollection<Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesAction>? actions)
	{
		ActionsDescriptor = null;
		ActionsDescriptorAction = null;
		ActionsDescriptorActions = null;
		ActionsValue = actions;
		return Self;
	}

	public UpdateAliasesRequestDescriptor<TDocument> Actions(Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesActionDescriptor<TDocument> descriptor)
	{
		ActionsValue = null;
		ActionsDescriptorAction = null;
		ActionsDescriptorActions = null;
		ActionsDescriptor = descriptor;
		return Self;
	}

	public UpdateAliasesRequestDescriptor<TDocument> Actions(Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesActionDescriptor<TDocument>> configure)
	{
		ActionsValue = null;
		ActionsDescriptor = null;
		ActionsDescriptorActions = null;
		ActionsDescriptorAction = configure;
		return Self;
	}

	public UpdateAliasesRequestDescriptor<TDocument> Actions(params Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesActionDescriptor<TDocument>>[] configure)
	{
		ActionsValue = null;
		ActionsDescriptor = null;
		ActionsDescriptorAction = null;
		ActionsDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ActionsDescriptor is not null)
		{
			writer.WritePropertyName("actions");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, ActionsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (ActionsDescriptorAction is not null)
		{
			writer.WritePropertyName("actions");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesActionDescriptor<TDocument>(ActionsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (ActionsDescriptorActions is not null)
		{
			writer.WritePropertyName("actions");
			writer.WriteStartArray();
			foreach (var action in ActionsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesActionDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (ActionsValue is not null)
		{
			writer.WritePropertyName("actions");
			JsonSerializer.Serialize(writer, ActionsValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Create or update an alias.
/// Adds a data stream or index to an alias.
/// </para>
/// </summary>
public sealed partial class UpdateAliasesRequestDescriptor : RequestDescriptor<UpdateAliasesRequestDescriptor, UpdateAliasesRequestParameters>
{
	internal UpdateAliasesRequestDescriptor(Action<UpdateAliasesRequestDescriptor> configure) => configure.Invoke(this);

	public UpdateAliasesRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementUpdateAliases;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.update_aliases";

	public UpdateAliasesRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public UpdateAliasesRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	private ICollection<Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesAction>? ActionsValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesActionDescriptor ActionsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesActionDescriptor> ActionsDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesActionDescriptor>[] ActionsDescriptorActions { get; set; }

	/// <summary>
	/// <para>
	/// Actions to perform.
	/// </para>
	/// </summary>
	public UpdateAliasesRequestDescriptor Actions(ICollection<Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesAction>? actions)
	{
		ActionsDescriptor = null;
		ActionsDescriptorAction = null;
		ActionsDescriptorActions = null;
		ActionsValue = actions;
		return Self;
	}

	public UpdateAliasesRequestDescriptor Actions(Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesActionDescriptor descriptor)
	{
		ActionsValue = null;
		ActionsDescriptorAction = null;
		ActionsDescriptorActions = null;
		ActionsDescriptor = descriptor;
		return Self;
	}

	public UpdateAliasesRequestDescriptor Actions(Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesActionDescriptor> configure)
	{
		ActionsValue = null;
		ActionsDescriptor = null;
		ActionsDescriptorActions = null;
		ActionsDescriptorAction = configure;
		return Self;
	}

	public UpdateAliasesRequestDescriptor Actions(params Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesActionDescriptor>[] configure)
	{
		ActionsValue = null;
		ActionsDescriptor = null;
		ActionsDescriptorAction = null;
		ActionsDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ActionsDescriptor is not null)
		{
			writer.WritePropertyName("actions");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, ActionsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (ActionsDescriptorAction is not null)
		{
			writer.WritePropertyName("actions");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesActionDescriptor(ActionsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (ActionsDescriptorActions is not null)
		{
			writer.WritePropertyName("actions");
			writer.WriteStartArray();
			foreach (var action in ActionsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.IndexManagement.IndexUpdateAliasesActionDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (ActionsValue is not null)
		{
			writer.WritePropertyName("actions");
			JsonSerializer.Serialize(writer, ActionsValue, options);
		}

		writer.WriteEndObject();
	}
}