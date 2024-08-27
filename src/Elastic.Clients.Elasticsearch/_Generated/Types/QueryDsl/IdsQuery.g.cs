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

namespace Elastic.Clients.Elasticsearch.QueryDsl;

public sealed partial class IdsQuery
{
	/// <summary>
	/// <para>
	/// Floating point number used to decrease or increase the relevance scores of the query.
	/// Boost values are relative to the default value of 1.0.
	/// A boost value between 0 and 1.0 decreases the relevance score.
	/// A value greater than 1.0 increases the relevance score.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	/// <summary>
	/// <para>
	/// An array of document IDs.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("values")]
	public Elastic.Clients.Elasticsearch.Ids? Values { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.QueryDsl.Query(IdsQuery idsQuery) => Elastic.Clients.Elasticsearch.QueryDsl.Query.Ids(idsQuery);
	public static implicit operator Elastic.Clients.Elasticsearch.Security.ApiKeyQuery(IdsQuery idsQuery) => Elastic.Clients.Elasticsearch.Security.ApiKeyQuery.Ids(idsQuery);
	public static implicit operator Elastic.Clients.Elasticsearch.Security.UserQuery(IdsQuery idsQuery) => Elastic.Clients.Elasticsearch.Security.UserQuery.Ids(idsQuery);
}

public sealed partial class IdsQueryDescriptor : SerializableDescriptor<IdsQueryDescriptor>
{
	internal IdsQueryDescriptor(Action<IdsQueryDescriptor> configure) => configure.Invoke(this);

	public IdsQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private string? QueryNameValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ids? ValuesValue { get; set; }

	/// <summary>
	/// <para>
	/// Floating point number used to decrease or increase the relevance scores of the query.
	/// Boost values are relative to the default value of 1.0.
	/// A boost value between 0 and 1.0 decreases the relevance score.
	/// A value greater than 1.0 increases the relevance score.
	/// </para>
	/// </summary>
	public IdsQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public IdsQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	/// <summary>
	/// <para>
	/// An array of document IDs.
	/// </para>
	/// </summary>
	public IdsQueryDescriptor Values(Elastic.Clients.Elasticsearch.Ids? values)
	{
		ValuesValue = values;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (ValuesValue is not null)
		{
			writer.WritePropertyName("values");
			JsonSerializer.Serialize(writer, ValuesValue, options);
		}

		writer.WriteEndObject();
	}
}