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

namespace Elastic.Clients.Elasticsearch.IndexLifecycleManagement;

public sealed partial class SetPriorityAction
{
	[JsonInclude, JsonPropertyName("priority")]
	public int? Priority { get; set; }
}

public sealed partial class SetPriorityActionDescriptor : SerializableDescriptor<SetPriorityActionDescriptor>
{
	internal SetPriorityActionDescriptor(Action<SetPriorityActionDescriptor> configure) => configure.Invoke(this);

	public SetPriorityActionDescriptor() : base()
	{
	}

	private int? PriorityValue { get; set; }

	public SetPriorityActionDescriptor Priority(int? priority)
	{
		PriorityValue = priority;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (PriorityValue.HasValue)
		{
			writer.WritePropertyName("priority");
			writer.WriteNumberValue(PriorityValue.Value);
		}

		writer.WriteEndObject();
	}
}