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
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class IndexRoutingRebalance
{
	[JsonInclude, JsonPropertyName("enable")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexRoutingRebalanceOptions Enable { get; set; }
}

public sealed partial class IndexRoutingRebalanceDescriptor : SerializableDescriptor<IndexRoutingRebalanceDescriptor>
{
	internal IndexRoutingRebalanceDescriptor(Action<IndexRoutingRebalanceDescriptor> configure) => configure.Invoke(this);

	public IndexRoutingRebalanceDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexRoutingRebalanceOptions EnableValue { get; set; }

	public IndexRoutingRebalanceDescriptor Enable(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexRoutingRebalanceOptions enable)
	{
		EnableValue = enable;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("enable");
		JsonSerializer.Serialize(writer, EnableValue, options);
		writer.WriteEndObject();
	}
}