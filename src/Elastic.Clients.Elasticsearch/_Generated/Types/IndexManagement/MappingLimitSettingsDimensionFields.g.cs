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
public sealed partial class MappingLimitSettingsDimensionFields
{
	[JsonInclude, JsonPropertyName("limit")]
	public int? Limit { get; set; }
}

public sealed partial class MappingLimitSettingsDimensionFieldsDescriptor : SerializableDescriptor<MappingLimitSettingsDimensionFieldsDescriptor>
{
	internal MappingLimitSettingsDimensionFieldsDescriptor(Action<MappingLimitSettingsDimensionFieldsDescriptor> configure) => configure.Invoke(this);
	public MappingLimitSettingsDimensionFieldsDescriptor() : base()
	{
	}

	private int? LimitValue { get; set; }

	public MappingLimitSettingsDimensionFieldsDescriptor Limit(int? limit)
	{
		LimitValue = limit;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (LimitValue.HasValue)
		{
			writer.WritePropertyName("limit");
			writer.WriteNumberValue(LimitValue.Value);
		}

		writer.WriteEndObject();
	}
}