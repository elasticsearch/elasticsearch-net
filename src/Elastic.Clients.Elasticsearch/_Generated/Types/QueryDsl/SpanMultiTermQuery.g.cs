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

public sealed partial class SpanMultiTermQuery : SearchQuery
{
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }
	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }

	/// <summary>
	/// <para>Should be a multi term query (one of wildcard, fuzzy, prefix, range or regexp query)</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("match")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Query Match { get; set; }
}

public sealed partial class SpanMultiTermQueryDescriptor<TDocument> : SerializableDescriptor<SpanMultiTermQueryDescriptor<TDocument>>
{
	internal SpanMultiTermQueryDescriptor(Action<SpanMultiTermQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public SpanMultiTermQueryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.Query MatchValue { get; set; }
	private QueryDescriptor<TDocument> MatchDescriptor { get; set; }
	private Action<QueryDescriptor<TDocument>> MatchDescriptorAction { get; set; }
	private string? QueryNameValue { get; set; }
	private float? BoostValue { get; set; }

	/// <summary>
	/// <para>Should be a multi term query (one of wildcard, fuzzy, prefix, range or regexp query)</para>
	/// </summary>
	public SpanMultiTermQueryDescriptor<TDocument> Match(Elastic.Clients.Elasticsearch.QueryDsl.Query match)
	{
		MatchDescriptor = null;
		MatchDescriptorAction = null;
		MatchValue = match;
		return Self;
	}

	public SpanMultiTermQueryDescriptor<TDocument> Match(QueryDescriptor<TDocument> descriptor)
	{
		MatchValue = null;
		MatchDescriptorAction = null;
		MatchDescriptor = descriptor;
		return Self;
	}

	public SpanMultiTermQueryDescriptor<TDocument> Match(Action<QueryDescriptor<TDocument>> configure)
	{
		MatchValue = null;
		MatchDescriptor = null;
		MatchDescriptorAction = configure;
		return Self;
	}

	public SpanMultiTermQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public SpanMultiTermQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (MatchDescriptor is not null)
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, MatchDescriptor, options);
		}
		else if (MatchDescriptorAction is not null)
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, new QueryDescriptor<TDocument>(MatchDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, MatchValue, options);
		}

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

		writer.WriteEndObject();
	}
}

public sealed partial class SpanMultiTermQueryDescriptor : SerializableDescriptor<SpanMultiTermQueryDescriptor>
{
	internal SpanMultiTermQueryDescriptor(Action<SpanMultiTermQueryDescriptor> configure) => configure.Invoke(this);

	public SpanMultiTermQueryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.Query MatchValue { get; set; }
	private QueryDescriptor MatchDescriptor { get; set; }
	private Action<QueryDescriptor> MatchDescriptorAction { get; set; }
	private string? QueryNameValue { get; set; }
	private float? BoostValue { get; set; }

	/// <summary>
	/// <para>Should be a multi term query (one of wildcard, fuzzy, prefix, range or regexp query)</para>
	/// </summary>
	public SpanMultiTermQueryDescriptor Match(Elastic.Clients.Elasticsearch.QueryDsl.Query match)
	{
		MatchDescriptor = null;
		MatchDescriptorAction = null;
		MatchValue = match;
		return Self;
	}

	public SpanMultiTermQueryDescriptor Match(QueryDescriptor descriptor)
	{
		MatchValue = null;
		MatchDescriptorAction = null;
		MatchDescriptor = descriptor;
		return Self;
	}

	public SpanMultiTermQueryDescriptor Match(Action<QueryDescriptor> configure)
	{
		MatchValue = null;
		MatchDescriptor = null;
		MatchDescriptorAction = configure;
		return Self;
	}

	public SpanMultiTermQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public SpanMultiTermQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (MatchDescriptor is not null)
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, MatchDescriptor, options);
		}
		else if (MatchDescriptorAction is not null)
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, new QueryDescriptor(MatchDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, MatchValue, options);
		}

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

		writer.WriteEndObject();
	}
}