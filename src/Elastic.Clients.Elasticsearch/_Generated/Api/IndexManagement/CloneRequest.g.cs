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
namespace Elastic.Clients.Elasticsearch.IndexManagement;
public sealed class CloneRequestParameters : RequestParameters<CloneRequestParameters>
{
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
}

public sealed partial class CloneRequest : PlainRequest<CloneRequestParameters>
{
	public CloneRequest(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Name target) : base(r => r.Required("index", index).Required("target", target))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementClone;
	internal override HttpMethod HttpMethod => HttpMethod.PUT;
	internal override bool SupportsBody => true;
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

	[JsonInclude]
	[JsonPropertyName("aliases")]
	public Dictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? Aliases { get; set; }

	[JsonInclude]
	[JsonPropertyName("settings")]
	public Dictionary<string, object>? Settings { get; set; }
}

public sealed partial class CloneRequestDescriptor<TDocument> : RequestDescriptor<CloneRequestDescriptor<TDocument>, CloneRequestParameters>
{
	internal CloneRequestDescriptor(Action<CloneRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public CloneRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Name target) : base(r => r.Required("index", index).Required("target", target))
	{
	}

	internal CloneRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementClone;
	internal override HttpMethod HttpMethod => HttpMethod.PUT;
	internal override bool SupportsBody => true;
	public CloneRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public CloneRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public CloneRequestDescriptor<TDocument> WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
	public CloneRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName index)
	{
		RouteValues.Required("index", index);
		return Self;
	}

	public CloneRequestDescriptor<TDocument> Target(Elastic.Clients.Elasticsearch.Name target)
	{
		RouteValues.Required("target", target);
		return Self;
	}

	private Dictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? AliasesValue { get; set; }

	private Dictionary<string, object>? SettingsValue { get; set; }

	public CloneRequestDescriptor<TDocument> Aliases(Func<FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>, FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>> selector)
	{
		AliasesValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>());
		return Self;
	}

	public CloneRequestDescriptor<TDocument> Settings(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
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

		if (SettingsValue is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class CloneRequestDescriptor : RequestDescriptor<CloneRequestDescriptor, CloneRequestParameters>
{
	internal CloneRequestDescriptor(Action<CloneRequestDescriptor> configure) => configure.Invoke(this);
	public CloneRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Name target) : base(r => r.Required("index", index).Required("target", target))
	{
	}

	internal CloneRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementClone;
	internal override HttpMethod HttpMethod => HttpMethod.PUT;
	internal override bool SupportsBody => true;
	public CloneRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public CloneRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public CloneRequestDescriptor WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
	public CloneRequestDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index)
	{
		RouteValues.Required("index", index);
		return Self;
	}

	public CloneRequestDescriptor Target(Elastic.Clients.Elasticsearch.Name target)
	{
		RouteValues.Required("target", target);
		return Self;
	}

	private Dictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? AliasesValue { get; set; }

	private Dictionary<string, object>? SettingsValue { get; set; }

	public CloneRequestDescriptor Aliases(Func<FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>, FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>> selector)
	{
		AliasesValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>());
		return Self;
	}

	public CloneRequestDescriptor Settings(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
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

		if (SettingsValue is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsValue, options);
		}

		writer.WriteEndObject();
	}
}