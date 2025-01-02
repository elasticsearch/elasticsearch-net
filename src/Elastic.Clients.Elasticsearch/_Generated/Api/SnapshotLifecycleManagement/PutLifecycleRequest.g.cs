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

namespace Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement;

public sealed partial class PutLifecycleRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a response. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Create or update a policy.
/// Create or update a snapshot lifecycle policy.
/// If the policy already exists, this request increments the policy version.
/// Only the latest version of a policy is stored.
/// </para>
/// </summary>
public sealed partial class PutLifecycleRequest : PlainRequest<PutLifecycleRequestParameters>
{
	public PutLifecycleRequest(Elastic.Clients.Elasticsearch.Name policyId) : base(r => r.Required("policy_id", policyId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotLifecycleManagementPutLifecycle;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "slm.put_lifecycle";

	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a response. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>
	/// Configuration for each snapshot created by the policy.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("config")]
	public Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement.SlmConfiguration? Config { get; set; }

	/// <summary>
	/// <para>
	/// Name automatically assigned to each snapshot created by the policy. Date math is supported. To prevent conflicting snapshot names, a UUID is automatically appended to each snapshot name.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("name")]
	public Elastic.Clients.Elasticsearch.Name? Name { get; set; }

	/// <summary>
	/// <para>
	/// Repository used to store snapshots created by this policy. This repository must exist prior to the policy’s creation. You can create a repository using the snapshot repository API.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("repository")]
	public string? Repository { get; set; }

	/// <summary>
	/// <para>
	/// Retention rules used to retain and delete snapshots created by the policy.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("retention")]
	public Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement.Retention? Retention { get; set; }

	/// <summary>
	/// <para>
	/// Periodic or absolute schedule at which the policy creates snapshots. SLM applies schedule changes immediately.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("schedule")]
	public string? Schedule { get; set; }
}

/// <summary>
/// <para>
/// Create or update a policy.
/// Create or update a snapshot lifecycle policy.
/// If the policy already exists, this request increments the policy version.
/// Only the latest version of a policy is stored.
/// </para>
/// </summary>
public sealed partial class PutLifecycleRequestDescriptor : RequestDescriptor<PutLifecycleRequestDescriptor, PutLifecycleRequestParameters>
{
	internal PutLifecycleRequestDescriptor(Action<PutLifecycleRequestDescriptor> configure) => configure.Invoke(this);

	public PutLifecycleRequestDescriptor(Elastic.Clients.Elasticsearch.Name policyId) : base(r => r.Required("policy_id", policyId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotLifecycleManagementPutLifecycle;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "slm.put_lifecycle";

	public PutLifecycleRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public PutLifecycleRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	public PutLifecycleRequestDescriptor PolicyId(Elastic.Clients.Elasticsearch.Name policyId)
	{
		RouteValues.Required("policy_id", policyId);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement.SlmConfiguration? ConfigValue { get; set; }
	private Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement.SlmConfigurationDescriptor ConfigDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement.SlmConfigurationDescriptor> ConfigDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Name? NameValue { get; set; }
	private string? RepositoryValue { get; set; }
	private Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement.Retention? RetentionValue { get; set; }
	private Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement.RetentionDescriptor RetentionDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement.RetentionDescriptor> RetentionDescriptorAction { get; set; }
	private string? ScheduleValue { get; set; }

	/// <summary>
	/// <para>
	/// Configuration for each snapshot created by the policy.
	/// </para>
	/// </summary>
	public PutLifecycleRequestDescriptor Config(Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement.SlmConfiguration? config)
	{
		ConfigDescriptor = null;
		ConfigDescriptorAction = null;
		ConfigValue = config;
		return Self;
	}

	public PutLifecycleRequestDescriptor Config(Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement.SlmConfigurationDescriptor descriptor)
	{
		ConfigValue = null;
		ConfigDescriptorAction = null;
		ConfigDescriptor = descriptor;
		return Self;
	}

	public PutLifecycleRequestDescriptor Config(Action<Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement.SlmConfigurationDescriptor> configure)
	{
		ConfigValue = null;
		ConfigDescriptor = null;
		ConfigDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Name automatically assigned to each snapshot created by the policy. Date math is supported. To prevent conflicting snapshot names, a UUID is automatically appended to each snapshot name.
	/// </para>
	/// </summary>
	public PutLifecycleRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name? name)
	{
		NameValue = name;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Repository used to store snapshots created by this policy. This repository must exist prior to the policy’s creation. You can create a repository using the snapshot repository API.
	/// </para>
	/// </summary>
	public PutLifecycleRequestDescriptor Repository(string? repository)
	{
		RepositoryValue = repository;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Retention rules used to retain and delete snapshots created by the policy.
	/// </para>
	/// </summary>
	public PutLifecycleRequestDescriptor Retention(Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement.Retention? retention)
	{
		RetentionDescriptor = null;
		RetentionDescriptorAction = null;
		RetentionValue = retention;
		return Self;
	}

	public PutLifecycleRequestDescriptor Retention(Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement.RetentionDescriptor descriptor)
	{
		RetentionValue = null;
		RetentionDescriptorAction = null;
		RetentionDescriptor = descriptor;
		return Self;
	}

	public PutLifecycleRequestDescriptor Retention(Action<Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement.RetentionDescriptor> configure)
	{
		RetentionValue = null;
		RetentionDescriptor = null;
		RetentionDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Periodic or absolute schedule at which the policy creates snapshots. SLM applies schedule changes immediately.
	/// </para>
	/// </summary>
	public PutLifecycleRequestDescriptor Schedule(string? schedule)
	{
		ScheduleValue = schedule;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ConfigDescriptor is not null)
		{
			writer.WritePropertyName("config");
			JsonSerializer.Serialize(writer, ConfigDescriptor, options);
		}
		else if (ConfigDescriptorAction is not null)
		{
			writer.WritePropertyName("config");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement.SlmConfigurationDescriptor(ConfigDescriptorAction), options);
		}
		else if (ConfigValue is not null)
		{
			writer.WritePropertyName("config");
			JsonSerializer.Serialize(writer, ConfigValue, options);
		}

		if (NameValue is not null)
		{
			writer.WritePropertyName("name");
			JsonSerializer.Serialize(writer, NameValue, options);
		}

		if (!string.IsNullOrEmpty(RepositoryValue))
		{
			writer.WritePropertyName("repository");
			writer.WriteStringValue(RepositoryValue);
		}

		if (RetentionDescriptor is not null)
		{
			writer.WritePropertyName("retention");
			JsonSerializer.Serialize(writer, RetentionDescriptor, options);
		}
		else if (RetentionDescriptorAction is not null)
		{
			writer.WritePropertyName("retention");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement.RetentionDescriptor(RetentionDescriptorAction), options);
		}
		else if (RetentionValue is not null)
		{
			writer.WritePropertyName("retention");
			JsonSerializer.Serialize(writer, RetentionValue, options);
		}

		if (!string.IsNullOrEmpty(ScheduleValue))
		{
			writer.WritePropertyName("schedule");
			writer.WriteStringValue(ScheduleValue);
		}

		writer.WriteEndObject();
	}
}