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

public sealed partial class RolloverRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If <c>true</c>, checks whether the current index satisfies the specified conditions but does not perform a rollover.
	/// </para>
	/// </summary>
	public bool? DryRun { get => Q<bool?>("dry_run"); set => Q("dry_run", value); }

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

	/// <summary>
	/// <para>
	/// The number of shard copies that must be active before proceeding with the operation.
	/// Set to all or any positive integer up to the total number of shards in the index (<c>number_of_replicas+1</c>).
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
}

/// <summary>
/// <para>
/// Roll over to a new index.
/// Creates a new index for a data stream or index alias.
/// </para>
/// </summary>
public sealed partial class RolloverRequest : PlainRequest<RolloverRequestParameters>
{
	public RolloverRequest(Elastic.Clients.Elasticsearch.IndexAlias alias) : base(r => r.Required("alias", alias))
	{
	}

	public RolloverRequest(Elastic.Clients.Elasticsearch.IndexAlias alias, Elastic.Clients.Elasticsearch.IndexName? newIndex) : base(r => r.Required("alias", alias).Optional("new_index", newIndex))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementRollover;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.rollover";

	/// <summary>
	/// <para>
	/// If <c>true</c>, checks whether the current index satisfies the specified conditions but does not perform a rollover.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? DryRun { get => Q<bool?>("dry_run"); set => Q("dry_run", value); }

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
	/// The number of shard copies that must be active before proceeding with the operation.
	/// Set to all or any positive integer up to the total number of shards in the index (<c>number_of_replicas+1</c>).
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

	/// <summary>
	/// <para>
	/// Aliases for the target index.
	/// Data streams do not support this parameter.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("aliases")]
	public IDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? Aliases { get; set; }

	/// <summary>
	/// <para>
	/// Conditions for the rollover.
	/// If specified, Elasticsearch only performs the rollover if the current index satisfies these conditions.
	/// If this parameter is not specified, Elasticsearch performs the rollover unconditionally.
	/// If conditions are specified, at least one of them must be a <c>max_*</c> condition.
	/// The index will rollover if any <c>max_*</c> condition is satisfied and all <c>min_*</c> conditions are satisfied.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("conditions")]
	public Elastic.Clients.Elasticsearch.IndexManagement.RolloverConditions? Conditions { get; set; }

	/// <summary>
	/// <para>
	/// Mapping for fields in the index.
	/// If specified, this mapping can include field names, field data types, and mapping paramaters.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("mappings")]
	public Elastic.Clients.Elasticsearch.Mapping.TypeMapping? Mappings { get; set; }

	/// <summary>
	/// <para>
	/// Configuration options for the index.
	/// Data streams do not support this parameter.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("settings")]
	public IDictionary<string, object>? Settings { get; set; }
}

/// <summary>
/// <para>
/// Roll over to a new index.
/// Creates a new index for a data stream or index alias.
/// </para>
/// </summary>
public sealed partial class RolloverRequestDescriptor<TDocument> : RequestDescriptor<RolloverRequestDescriptor<TDocument>, RolloverRequestParameters>
{
	internal RolloverRequestDescriptor(Action<RolloverRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public RolloverRequestDescriptor(Elastic.Clients.Elasticsearch.IndexAlias alias, Elastic.Clients.Elasticsearch.IndexName? newIndex) : base(r => r.Required("alias", alias).Optional("new_index", newIndex))
	{
	}

	public RolloverRequestDescriptor(Elastic.Clients.Elasticsearch.IndexAlias alias) : this(alias, typeof(TDocument))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementRollover;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.rollover";

	public RolloverRequestDescriptor<TDocument> DryRun(bool? dryRun = true) => Qs("dry_run", dryRun);
	public RolloverRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public RolloverRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public RolloverRequestDescriptor<TDocument> WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);

	public RolloverRequestDescriptor<TDocument> Alias(Elastic.Clients.Elasticsearch.IndexAlias alias)
	{
		RouteValues.Required("alias", alias);
		return Self;
	}

	public RolloverRequestDescriptor<TDocument> NewIndex(Elastic.Clients.Elasticsearch.IndexName? newIndex)
	{
		RouteValues.Optional("new_index", newIndex);
		return Self;
	}

	private IDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.AliasDescriptor<TDocument>> AliasesValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.RolloverConditions? ConditionsValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.RolloverConditionsDescriptor ConditionsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.IndexManagement.RolloverConditionsDescriptor> ConditionsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.TypeMapping? MappingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor<TDocument> MappingsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor<TDocument>> MappingsDescriptorAction { get; set; }
	private IDictionary<string, object>? SettingsValue { get; set; }

	/// <summary>
	/// <para>
	/// Aliases for the target index.
	/// Data streams do not support this parameter.
	/// </para>
	/// </summary>
	public RolloverRequestDescriptor<TDocument> Aliases(Func<FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.AliasDescriptor<TDocument>>, FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.AliasDescriptor<TDocument>>> selector)
	{
		AliasesValue = selector?.Invoke(new FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.AliasDescriptor<TDocument>>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// Conditions for the rollover.
	/// If specified, Elasticsearch only performs the rollover if the current index satisfies these conditions.
	/// If this parameter is not specified, Elasticsearch performs the rollover unconditionally.
	/// If conditions are specified, at least one of them must be a <c>max_*</c> condition.
	/// The index will rollover if any <c>max_*</c> condition is satisfied and all <c>min_*</c> conditions are satisfied.
	/// </para>
	/// </summary>
	public RolloverRequestDescriptor<TDocument> Conditions(Elastic.Clients.Elasticsearch.IndexManagement.RolloverConditions? conditions)
	{
		ConditionsDescriptor = null;
		ConditionsDescriptorAction = null;
		ConditionsValue = conditions;
		return Self;
	}

	public RolloverRequestDescriptor<TDocument> Conditions(Elastic.Clients.Elasticsearch.IndexManagement.RolloverConditionsDescriptor descriptor)
	{
		ConditionsValue = null;
		ConditionsDescriptorAction = null;
		ConditionsDescriptor = descriptor;
		return Self;
	}

	public RolloverRequestDescriptor<TDocument> Conditions(Action<Elastic.Clients.Elasticsearch.IndexManagement.RolloverConditionsDescriptor> configure)
	{
		ConditionsValue = null;
		ConditionsDescriptor = null;
		ConditionsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Mapping for fields in the index.
	/// If specified, this mapping can include field names, field data types, and mapping paramaters.
	/// </para>
	/// </summary>
	public RolloverRequestDescriptor<TDocument> Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMapping? mappings)
	{
		MappingsDescriptor = null;
		MappingsDescriptorAction = null;
		MappingsValue = mappings;
		return Self;
	}

	public RolloverRequestDescriptor<TDocument> Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor<TDocument> descriptor)
	{
		MappingsValue = null;
		MappingsDescriptorAction = null;
		MappingsDescriptor = descriptor;
		return Self;
	}

	public RolloverRequestDescriptor<TDocument> Mappings(Action<Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor<TDocument>> configure)
	{
		MappingsValue = null;
		MappingsDescriptor = null;
		MappingsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Configuration options for the index.
	/// Data streams do not support this parameter.
	/// </para>
	/// </summary>
	public RolloverRequestDescriptor<TDocument> Settings(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		SettingsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AliasesValue is not null)
		{
			writer.WritePropertyName("aliases");
			JsonSerializer.Serialize(writer, AliasesValue, options);
		}

		if (ConditionsDescriptor is not null)
		{
			writer.WritePropertyName("conditions");
			JsonSerializer.Serialize(writer, ConditionsDescriptor, options);
		}
		else if (ConditionsDescriptorAction is not null)
		{
			writer.WritePropertyName("conditions");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.IndexManagement.RolloverConditionsDescriptor(ConditionsDescriptorAction), options);
		}
		else if (ConditionsValue is not null)
		{
			writer.WritePropertyName("conditions");
			JsonSerializer.Serialize(writer, ConditionsValue, options);
		}

		if (MappingsDescriptor is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, MappingsDescriptor, options);
		}
		else if (MappingsDescriptorAction is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor<TDocument>(MappingsDescriptorAction), options);
		}
		else if (MappingsValue is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, MappingsValue, options);
		}

		if (SettingsValue is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Roll over to a new index.
/// Creates a new index for a data stream or index alias.
/// </para>
/// </summary>
public sealed partial class RolloverRequestDescriptor : RequestDescriptor<RolloverRequestDescriptor, RolloverRequestParameters>
{
	internal RolloverRequestDescriptor(Action<RolloverRequestDescriptor> configure) => configure.Invoke(this);

	public RolloverRequestDescriptor(Elastic.Clients.Elasticsearch.IndexAlias alias, Elastic.Clients.Elasticsearch.IndexName? newIndex) : base(r => r.Required("alias", alias).Optional("new_index", newIndex))
	{
	}

	public RolloverRequestDescriptor(Elastic.Clients.Elasticsearch.IndexAlias alias) : base(r => r.Required("alias", alias))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementRollover;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "indices.rollover";

	public RolloverRequestDescriptor DryRun(bool? dryRun = true) => Qs("dry_run", dryRun);
	public RolloverRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public RolloverRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public RolloverRequestDescriptor WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);

	public RolloverRequestDescriptor Alias(Elastic.Clients.Elasticsearch.IndexAlias alias)
	{
		RouteValues.Required("alias", alias);
		return Self;
	}

	public RolloverRequestDescriptor NewIndex(Elastic.Clients.Elasticsearch.IndexName? newIndex)
	{
		RouteValues.Optional("new_index", newIndex);
		return Self;
	}

	private IDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.AliasDescriptor> AliasesValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.RolloverConditions? ConditionsValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexManagement.RolloverConditionsDescriptor ConditionsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.IndexManagement.RolloverConditionsDescriptor> ConditionsDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.TypeMapping? MappingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor MappingsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor> MappingsDescriptorAction { get; set; }
	private IDictionary<string, object>? SettingsValue { get; set; }

	/// <summary>
	/// <para>
	/// Aliases for the target index.
	/// Data streams do not support this parameter.
	/// </para>
	/// </summary>
	public RolloverRequestDescriptor Aliases(Func<FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.AliasDescriptor>, FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.AliasDescriptor>> selector)
	{
		AliasesValue = selector?.Invoke(new FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.AliasDescriptor>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// Conditions for the rollover.
	/// If specified, Elasticsearch only performs the rollover if the current index satisfies these conditions.
	/// If this parameter is not specified, Elasticsearch performs the rollover unconditionally.
	/// If conditions are specified, at least one of them must be a <c>max_*</c> condition.
	/// The index will rollover if any <c>max_*</c> condition is satisfied and all <c>min_*</c> conditions are satisfied.
	/// </para>
	/// </summary>
	public RolloverRequestDescriptor Conditions(Elastic.Clients.Elasticsearch.IndexManagement.RolloverConditions? conditions)
	{
		ConditionsDescriptor = null;
		ConditionsDescriptorAction = null;
		ConditionsValue = conditions;
		return Self;
	}

	public RolloverRequestDescriptor Conditions(Elastic.Clients.Elasticsearch.IndexManagement.RolloverConditionsDescriptor descriptor)
	{
		ConditionsValue = null;
		ConditionsDescriptorAction = null;
		ConditionsDescriptor = descriptor;
		return Self;
	}

	public RolloverRequestDescriptor Conditions(Action<Elastic.Clients.Elasticsearch.IndexManagement.RolloverConditionsDescriptor> configure)
	{
		ConditionsValue = null;
		ConditionsDescriptor = null;
		ConditionsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Mapping for fields in the index.
	/// If specified, this mapping can include field names, field data types, and mapping paramaters.
	/// </para>
	/// </summary>
	public RolloverRequestDescriptor Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMapping? mappings)
	{
		MappingsDescriptor = null;
		MappingsDescriptorAction = null;
		MappingsValue = mappings;
		return Self;
	}

	public RolloverRequestDescriptor Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor descriptor)
	{
		MappingsValue = null;
		MappingsDescriptorAction = null;
		MappingsDescriptor = descriptor;
		return Self;
	}

	public RolloverRequestDescriptor Mappings(Action<Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor> configure)
	{
		MappingsValue = null;
		MappingsDescriptor = null;
		MappingsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Configuration options for the index.
	/// Data streams do not support this parameter.
	/// </para>
	/// </summary>
	public RolloverRequestDescriptor Settings(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		SettingsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AliasesValue is not null)
		{
			writer.WritePropertyName("aliases");
			JsonSerializer.Serialize(writer, AliasesValue, options);
		}

		if (ConditionsDescriptor is not null)
		{
			writer.WritePropertyName("conditions");
			JsonSerializer.Serialize(writer, ConditionsDescriptor, options);
		}
		else if (ConditionsDescriptorAction is not null)
		{
			writer.WritePropertyName("conditions");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.IndexManagement.RolloverConditionsDescriptor(ConditionsDescriptorAction), options);
		}
		else if (ConditionsValue is not null)
		{
			writer.WritePropertyName("conditions");
			JsonSerializer.Serialize(writer, ConditionsValue, options);
		}

		if (MappingsDescriptor is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, MappingsDescriptor, options);
		}
		else if (MappingsDescriptorAction is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor(MappingsDescriptorAction), options);
		}
		else if (MappingsValue is not null)
		{
			writer.WritePropertyName("mappings");
			JsonSerializer.Serialize(writer, MappingsValue, options);
		}

		if (SettingsValue is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsValue, options);
		}

		writer.WriteEndObject();
	}
}