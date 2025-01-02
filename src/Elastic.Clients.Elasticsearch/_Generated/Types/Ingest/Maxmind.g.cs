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

namespace Elastic.Clients.Elasticsearch.Ingest;

public sealed partial class Maxmind
{
	[JsonInclude, JsonPropertyName("account_id")]
	public Elastic.Clients.Elasticsearch.Id AccountId { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Ingest.DatabaseConfiguration(Maxmind maxmind) => Elastic.Clients.Elasticsearch.Ingest.DatabaseConfiguration.Maxmind(maxmind);
	public static implicit operator Elastic.Clients.Elasticsearch.Ingest.DatabaseConfigurationFull(Maxmind maxmind) => Elastic.Clients.Elasticsearch.Ingest.DatabaseConfigurationFull.Maxmind(maxmind);
}

public sealed partial class MaxmindDescriptor : SerializableDescriptor<MaxmindDescriptor>
{
	internal MaxmindDescriptor(Action<MaxmindDescriptor> configure) => configure.Invoke(this);

	public MaxmindDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Id AccountIdValue { get; set; }

	public MaxmindDescriptor AccountId(Elastic.Clients.Elasticsearch.Id accountId)
	{
		AccountIdValue = accountId;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("account_id");
		JsonSerializer.Serialize(writer, AccountIdValue, options);
		writer.WriteEndObject();
	}
}