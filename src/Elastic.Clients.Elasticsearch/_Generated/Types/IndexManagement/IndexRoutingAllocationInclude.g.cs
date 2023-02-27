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
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement;
public sealed partial class IndexRoutingAllocationInclude
{
	[JsonInclude, JsonPropertyName("_id")]
	public Elastic.Clients.Elasticsearch.Id? Id { get; set; }

	[JsonInclude, JsonPropertyName("_tier_preference")]
	public string? TierPreference { get; set; }
}

public sealed partial class IndexRoutingAllocationIncludeDescriptor : SerializableDescriptor<IndexRoutingAllocationIncludeDescriptor>
{
	internal IndexRoutingAllocationIncludeDescriptor(Action<IndexRoutingAllocationIncludeDescriptor> configure) => configure.Invoke(this);
	public IndexRoutingAllocationIncludeDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Id? IdValue { get; set; }

	private string? TierPreferenceValue { get; set; }

	public IndexRoutingAllocationIncludeDescriptor Id(Elastic.Clients.Elasticsearch.Id? id)
	{
		IdValue = id;
		return Self;
	}

	public IndexRoutingAllocationIncludeDescriptor TierPreference(string? tierPreference)
	{
		TierPreferenceValue = tierPreference;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IdValue is not null)
		{
			writer.WritePropertyName("_id");
			JsonSerializer.Serialize(writer, IdValue, options);
		}

		if (!string.IsNullOrEmpty(TierPreferenceValue))
		{
			writer.WritePropertyName("_tier_preference");
			writer.WriteStringValue(TierPreferenceValue);
		}

		writer.WriteEndObject();
	}
}