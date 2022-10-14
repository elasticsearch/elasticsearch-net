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
namespace Elastic.Clients.Elasticsearch.QueryDsl;
public sealed partial class IdsQuery : Query
{
	[JsonInclude]
	[JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	[JsonInclude]
	[JsonPropertyName("boost")]
	public float? Boost { get; set; }

	[JsonInclude]
	[JsonPropertyName("values")]
	public Elastic.Clients.Elasticsearch.Ids? Values { get; set; }
}

public sealed partial class IdsQueryDescriptor : SerializableDescriptor<IdsQueryDescriptor>
{
	internal IdsQueryDescriptor(Action<IdsQueryDescriptor> configure) => configure.Invoke(this);
	public IdsQueryDescriptor() : base()
	{
	}

	private string? QueryNameValue { get; set; }

	private float? BoostValue { get; set; }

	private Elastic.Clients.Elasticsearch.Ids? ValuesValue { get; set; }

	public IdsQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public IdsQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public IdsQueryDescriptor Values(Elastic.Clients.Elasticsearch.Ids? values)
	{
		ValuesValue = values;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (ValuesValue is not null)
		{
			writer.WritePropertyName("values");
			JsonSerializer.Serialize(writer, ValuesValue, options);
		}

		writer.WriteEndObject();
	}
}