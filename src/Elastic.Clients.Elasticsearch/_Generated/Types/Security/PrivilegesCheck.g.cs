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

namespace Elastic.Clients.Elasticsearch.Security;

public sealed partial class PrivilegesCheck
{
	[JsonInclude, JsonPropertyName("application")]
	public ICollection<Elastic.Clients.Elasticsearch.Security.ApplicationPrivilegesCheck>? Application { get; set; }

	/// <summary>
	/// <para>
	/// A list of the cluster privileges that you want to check.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("cluster")]
	public ICollection<Elastic.Clients.Elasticsearch.Security.ClusterPrivilege>? Cluster { get; set; }
	[JsonInclude, JsonPropertyName("index")]
	public ICollection<Elastic.Clients.Elasticsearch.Security.IndexPrivilegesCheck>? Index { get; set; }
}

public sealed partial class PrivilegesCheckDescriptor : SerializableDescriptor<PrivilegesCheckDescriptor>
{
	internal PrivilegesCheckDescriptor(Action<PrivilegesCheckDescriptor> configure) => configure.Invoke(this);

	public PrivilegesCheckDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.Security.ApplicationPrivilegesCheck>? ApplicationValue { get; set; }
	private Elastic.Clients.Elasticsearch.Security.ApplicationPrivilegesCheckDescriptor ApplicationDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Security.ApplicationPrivilegesCheckDescriptor> ApplicationDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Security.ApplicationPrivilegesCheckDescriptor>[] ApplicationDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Security.ClusterPrivilege>? ClusterValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Security.IndexPrivilegesCheck>? IndexValue { get; set; }
	private Elastic.Clients.Elasticsearch.Security.IndexPrivilegesCheckDescriptor IndexDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Security.IndexPrivilegesCheckDescriptor> IndexDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Security.IndexPrivilegesCheckDescriptor>[] IndexDescriptorActions { get; set; }

	public PrivilegesCheckDescriptor Application(ICollection<Elastic.Clients.Elasticsearch.Security.ApplicationPrivilegesCheck>? application)
	{
		ApplicationDescriptor = null;
		ApplicationDescriptorAction = null;
		ApplicationDescriptorActions = null;
		ApplicationValue = application;
		return Self;
	}

	public PrivilegesCheckDescriptor Application(Elastic.Clients.Elasticsearch.Security.ApplicationPrivilegesCheckDescriptor descriptor)
	{
		ApplicationValue = null;
		ApplicationDescriptorAction = null;
		ApplicationDescriptorActions = null;
		ApplicationDescriptor = descriptor;
		return Self;
	}

	public PrivilegesCheckDescriptor Application(Action<Elastic.Clients.Elasticsearch.Security.ApplicationPrivilegesCheckDescriptor> configure)
	{
		ApplicationValue = null;
		ApplicationDescriptor = null;
		ApplicationDescriptorActions = null;
		ApplicationDescriptorAction = configure;
		return Self;
	}

	public PrivilegesCheckDescriptor Application(params Action<Elastic.Clients.Elasticsearch.Security.ApplicationPrivilegesCheckDescriptor>[] configure)
	{
		ApplicationValue = null;
		ApplicationDescriptor = null;
		ApplicationDescriptorAction = null;
		ApplicationDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A list of the cluster privileges that you want to check.
	/// </para>
	/// </summary>
	public PrivilegesCheckDescriptor Cluster(ICollection<Elastic.Clients.Elasticsearch.Security.ClusterPrivilege>? cluster)
	{
		ClusterValue = cluster;
		return Self;
	}

	public PrivilegesCheckDescriptor Index(ICollection<Elastic.Clients.Elasticsearch.Security.IndexPrivilegesCheck>? index)
	{
		IndexDescriptor = null;
		IndexDescriptorAction = null;
		IndexDescriptorActions = null;
		IndexValue = index;
		return Self;
	}

	public PrivilegesCheckDescriptor Index(Elastic.Clients.Elasticsearch.Security.IndexPrivilegesCheckDescriptor descriptor)
	{
		IndexValue = null;
		IndexDescriptorAction = null;
		IndexDescriptorActions = null;
		IndexDescriptor = descriptor;
		return Self;
	}

	public PrivilegesCheckDescriptor Index(Action<Elastic.Clients.Elasticsearch.Security.IndexPrivilegesCheckDescriptor> configure)
	{
		IndexValue = null;
		IndexDescriptor = null;
		IndexDescriptorActions = null;
		IndexDescriptorAction = configure;
		return Self;
	}

	public PrivilegesCheckDescriptor Index(params Action<Elastic.Clients.Elasticsearch.Security.IndexPrivilegesCheckDescriptor>[] configure)
	{
		IndexValue = null;
		IndexDescriptor = null;
		IndexDescriptorAction = null;
		IndexDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ApplicationDescriptor is not null)
		{
			writer.WritePropertyName("application");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, ApplicationDescriptor, options);
			writer.WriteEndArray();
		}
		else if (ApplicationDescriptorAction is not null)
		{
			writer.WritePropertyName("application");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Security.ApplicationPrivilegesCheckDescriptor(ApplicationDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (ApplicationDescriptorActions is not null)
		{
			writer.WritePropertyName("application");
			writer.WriteStartArray();
			foreach (var action in ApplicationDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Security.ApplicationPrivilegesCheckDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (ApplicationValue is not null)
		{
			writer.WritePropertyName("application");
			JsonSerializer.Serialize(writer, ApplicationValue, options);
		}

		if (ClusterValue is not null)
		{
			writer.WritePropertyName("cluster");
			JsonSerializer.Serialize(writer, ClusterValue, options);
		}

		if (IndexDescriptor is not null)
		{
			writer.WritePropertyName("index");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, IndexDescriptor, options);
			writer.WriteEndArray();
		}
		else if (IndexDescriptorAction is not null)
		{
			writer.WritePropertyName("index");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Security.IndexPrivilegesCheckDescriptor(IndexDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (IndexDescriptorActions is not null)
		{
			writer.WritePropertyName("index");
			writer.WriteStartArray();
			foreach (var action in IndexDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Security.IndexPrivilegesCheckDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (IndexValue is not null)
		{
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		writer.WriteEndObject();
	}
}