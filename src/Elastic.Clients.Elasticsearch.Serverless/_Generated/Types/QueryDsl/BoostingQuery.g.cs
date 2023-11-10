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

namespace Elastic.Clients.Elasticsearch.Serverless.QueryDsl;

public sealed partial class BoostingQuery : SearchQuery
{
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }
	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }

	/// <summary>
	/// <para>Query used to decrease the relevance score of matching documents.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("negative")]
	public Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query Negative { get; set; }

	/// <summary>
	/// <para>Floating point number between 0 and 1.0 used to decrease the relevance scores of documents matching the `negative` query.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("negative_boost")]
	public double NegativeBoost { get; set; }

	/// <summary>
	/// <para>Any returned documents must match this query.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("positive")]
	public Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query Positive { get; set; }

	public static implicit operator Query(BoostingQuery boostingQuery) => QueryDsl.Query.Boosting(boostingQuery);

	internal override void InternalWrapInContainer(Query container) => container.WrapVariant("boosting", this);
}

public sealed partial class BoostingQueryDescriptor<TDocument> : SerializableDescriptor<BoostingQueryDescriptor<TDocument>>
{
	internal BoostingQueryDescriptor(Action<BoostingQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public BoostingQueryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query NegativeValue { get; set; }
	private QueryDescriptor<TDocument> NegativeDescriptor { get; set; }
	private Action<QueryDescriptor<TDocument>> NegativeDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query PositiveValue { get; set; }
	private QueryDescriptor<TDocument> PositiveDescriptor { get; set; }
	private Action<QueryDescriptor<TDocument>> PositiveDescriptorAction { get; set; }
	private string? QueryNameValue { get; set; }
	private float? BoostValue { get; set; }
	private double NegativeBoostValue { get; set; }

	/// <summary>
	/// <para>Query used to decrease the relevance score of matching documents.</para>
	/// </summary>
	public BoostingQueryDescriptor<TDocument> Negative(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query negative)
	{
		NegativeDescriptor = null;
		NegativeDescriptorAction = null;
		NegativeValue = negative;
		return Self;
	}

	public BoostingQueryDescriptor<TDocument> Negative(QueryDescriptor<TDocument> descriptor)
	{
		NegativeValue = null;
		NegativeDescriptorAction = null;
		NegativeDescriptor = descriptor;
		return Self;
	}

	public BoostingQueryDescriptor<TDocument> Negative(Action<QueryDescriptor<TDocument>> configure)
	{
		NegativeValue = null;
		NegativeDescriptor = null;
		NegativeDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Any returned documents must match this query.</para>
	/// </summary>
	public BoostingQueryDescriptor<TDocument> Positive(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query positive)
	{
		PositiveDescriptor = null;
		PositiveDescriptorAction = null;
		PositiveValue = positive;
		return Self;
	}

	public BoostingQueryDescriptor<TDocument> Positive(QueryDescriptor<TDocument> descriptor)
	{
		PositiveValue = null;
		PositiveDescriptorAction = null;
		PositiveDescriptor = descriptor;
		return Self;
	}

	public BoostingQueryDescriptor<TDocument> Positive(Action<QueryDescriptor<TDocument>> configure)
	{
		PositiveValue = null;
		PositiveDescriptor = null;
		PositiveDescriptorAction = configure;
		return Self;
	}

	public BoostingQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public BoostingQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>Floating point number between 0 and 1.0 used to decrease the relevance scores of documents matching the `negative` query.</para>
	/// </summary>
	public BoostingQueryDescriptor<TDocument> NegativeBoost(double negativeBoost)
	{
		NegativeBoostValue = negativeBoost;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (NegativeDescriptor is not null)
		{
			writer.WritePropertyName("negative");
			JsonSerializer.Serialize(writer, NegativeDescriptor, options);
		}
		else if (NegativeDescriptorAction is not null)
		{
			writer.WritePropertyName("negative");
			JsonSerializer.Serialize(writer, new QueryDescriptor<TDocument>(NegativeDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("negative");
			JsonSerializer.Serialize(writer, NegativeValue, options);
		}

		if (PositiveDescriptor is not null)
		{
			writer.WritePropertyName("positive");
			JsonSerializer.Serialize(writer, PositiveDescriptor, options);
		}
		else if (PositiveDescriptorAction is not null)
		{
			writer.WritePropertyName("positive");
			JsonSerializer.Serialize(writer, new QueryDescriptor<TDocument>(PositiveDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("positive");
			JsonSerializer.Serialize(writer, PositiveValue, options);
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

		writer.WritePropertyName("negative_boost");
		writer.WriteNumberValue(NegativeBoostValue);
		writer.WriteEndObject();
	}
}

public sealed partial class BoostingQueryDescriptor : SerializableDescriptor<BoostingQueryDescriptor>
{
	internal BoostingQueryDescriptor(Action<BoostingQueryDescriptor> configure) => configure.Invoke(this);

	public BoostingQueryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query NegativeValue { get; set; }
	private QueryDescriptor NegativeDescriptor { get; set; }
	private Action<QueryDescriptor> NegativeDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query PositiveValue { get; set; }
	private QueryDescriptor PositiveDescriptor { get; set; }
	private Action<QueryDescriptor> PositiveDescriptorAction { get; set; }
	private string? QueryNameValue { get; set; }
	private float? BoostValue { get; set; }
	private double NegativeBoostValue { get; set; }

	/// <summary>
	/// <para>Query used to decrease the relevance score of matching documents.</para>
	/// </summary>
	public BoostingQueryDescriptor Negative(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query negative)
	{
		NegativeDescriptor = null;
		NegativeDescriptorAction = null;
		NegativeValue = negative;
		return Self;
	}

	public BoostingQueryDescriptor Negative(QueryDescriptor descriptor)
	{
		NegativeValue = null;
		NegativeDescriptorAction = null;
		NegativeDescriptor = descriptor;
		return Self;
	}

	public BoostingQueryDescriptor Negative(Action<QueryDescriptor> configure)
	{
		NegativeValue = null;
		NegativeDescriptor = null;
		NegativeDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Any returned documents must match this query.</para>
	/// </summary>
	public BoostingQueryDescriptor Positive(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query positive)
	{
		PositiveDescriptor = null;
		PositiveDescriptorAction = null;
		PositiveValue = positive;
		return Self;
	}

	public BoostingQueryDescriptor Positive(QueryDescriptor descriptor)
	{
		PositiveValue = null;
		PositiveDescriptorAction = null;
		PositiveDescriptor = descriptor;
		return Self;
	}

	public BoostingQueryDescriptor Positive(Action<QueryDescriptor> configure)
	{
		PositiveValue = null;
		PositiveDescriptor = null;
		PositiveDescriptorAction = configure;
		return Self;
	}

	public BoostingQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public BoostingQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>Floating point number between 0 and 1.0 used to decrease the relevance scores of documents matching the `negative` query.</para>
	/// </summary>
	public BoostingQueryDescriptor NegativeBoost(double negativeBoost)
	{
		NegativeBoostValue = negativeBoost;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (NegativeDescriptor is not null)
		{
			writer.WritePropertyName("negative");
			JsonSerializer.Serialize(writer, NegativeDescriptor, options);
		}
		else if (NegativeDescriptorAction is not null)
		{
			writer.WritePropertyName("negative");
			JsonSerializer.Serialize(writer, new QueryDescriptor(NegativeDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("negative");
			JsonSerializer.Serialize(writer, NegativeValue, options);
		}

		if (PositiveDescriptor is not null)
		{
			writer.WritePropertyName("positive");
			JsonSerializer.Serialize(writer, PositiveDescriptor, options);
		}
		else if (PositiveDescriptorAction is not null)
		{
			writer.WritePropertyName("positive");
			JsonSerializer.Serialize(writer, new QueryDescriptor(PositiveDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("positive");
			JsonSerializer.Serialize(writer, PositiveValue, options);
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

		writer.WritePropertyName("negative_boost");
		writer.WriteNumberValue(NegativeBoostValue);
		writer.WriteEndObject();
	}
}