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

public sealed partial class HasParentQuery
{
	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }

	/// <summary>
	/// <para>Indicates whether to ignore an unmapped `parent_type` and not return any documents instead of an error.<br/>You can use this parameter to query multiple indices that may not contain the `parent_type`.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ignore_unmapped")]
	public bool? IgnoreUnmapped { get; set; }

	/// <summary>
	/// <para>If defined, each search hit will contain inner hits.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("inner_hits")]
	public Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits? InnerHits { get; set; }

	/// <summary>
	/// <para>Name of the parent relationship mapped for the `join` field.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("parent_type")]
	public string ParentType { get; set; }

	/// <summary>
	/// <para>Query you wish to run on parent documents of the `parent_type` field.<br/>If a parent document matches the search, the query returns its child documents.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query")]
	public Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query Query { get; set; }
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	/// <summary>
	/// <para>Indicates whether the relevance score of a matching parent document is aggregated into its child documents.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("score")]
	public bool? Score { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query(HasParentQuery hasParentQuery) => Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query.HasParent(hasParentQuery);
}

public sealed partial class HasParentQueryDescriptor<TDocument> : SerializableDescriptor<HasParentQueryDescriptor<TDocument>>
{
	internal HasParentQueryDescriptor(Action<HasParentQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public HasParentQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private bool? IgnoreUnmappedValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits? InnerHitsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor<TDocument> InnerHitsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor<TDocument>> InnerHitsDescriptorAction { get; set; }
	private string ParentTypeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query QueryValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument> QueryDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>> QueryDescriptorAction { get; set; }
	private string? QueryNameValue { get; set; }
	private bool? ScoreValue { get; set; }

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public HasParentQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>Indicates whether to ignore an unmapped `parent_type` and not return any documents instead of an error.<br/>You can use this parameter to query multiple indices that may not contain the `parent_type`.</para>
	/// </summary>
	public HasParentQueryDescriptor<TDocument> IgnoreUnmapped(bool? ignoreUnmapped = true)
	{
		IgnoreUnmappedValue = ignoreUnmapped;
		return Self;
	}

	/// <summary>
	/// <para>If defined, each search hit will contain inner hits.</para>
	/// </summary>
	public HasParentQueryDescriptor<TDocument> InnerHits(Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits? innerHits)
	{
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = null;
		InnerHitsValue = innerHits;
		return Self;
	}

	public HasParentQueryDescriptor<TDocument> InnerHits(Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor<TDocument> descriptor)
	{
		InnerHitsValue = null;
		InnerHitsDescriptorAction = null;
		InnerHitsDescriptor = descriptor;
		return Self;
	}

	public HasParentQueryDescriptor<TDocument> InnerHits(Action<Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor<TDocument>> configure)
	{
		InnerHitsValue = null;
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Name of the parent relationship mapped for the `join` field.</para>
	/// </summary>
	public HasParentQueryDescriptor<TDocument> ParentType(string parentType)
	{
		ParentTypeValue = parentType;
		return Self;
	}

	/// <summary>
	/// <para>Query you wish to run on parent documents of the `parent_type` field.<br/>If a parent document matches the search, the query returns its child documents.</para>
	/// </summary>
	public HasParentQueryDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public HasParentQueryDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public HasParentQueryDescriptor<TDocument> Query(Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	public HasParentQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	/// <summary>
	/// <para>Indicates whether the relevance score of a matching parent document is aggregated into its child documents.</para>
	/// </summary>
	public HasParentQueryDescriptor<TDocument> Score(bool? score = true)
	{
		ScoreValue = score;
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

		if (IgnoreUnmappedValue.HasValue)
		{
			writer.WritePropertyName("ignore_unmapped");
			writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
		}

		if (InnerHitsDescriptor is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsDescriptor, options);
		}
		else if (InnerHitsDescriptorAction is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor<TDocument>(InnerHitsDescriptorAction), options);
		}
		else if (InnerHitsValue is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsValue, options);
		}

		writer.WritePropertyName("parent_type");
		writer.WriteStringValue(ParentTypeValue);
		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>(QueryDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (ScoreValue.HasValue)
		{
			writer.WritePropertyName("score");
			writer.WriteBooleanValue(ScoreValue.Value);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class HasParentQueryDescriptor : SerializableDescriptor<HasParentQueryDescriptor>
{
	internal HasParentQueryDescriptor(Action<HasParentQueryDescriptor> configure) => configure.Invoke(this);

	public HasParentQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private bool? IgnoreUnmappedValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits? InnerHitsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor InnerHitsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor> InnerHitsDescriptorAction { get; set; }
	private string ParentTypeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query QueryValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor QueryDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor> QueryDescriptorAction { get; set; }
	private string? QueryNameValue { get; set; }
	private bool? ScoreValue { get; set; }

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public HasParentQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>Indicates whether to ignore an unmapped `parent_type` and not return any documents instead of an error.<br/>You can use this parameter to query multiple indices that may not contain the `parent_type`.</para>
	/// </summary>
	public HasParentQueryDescriptor IgnoreUnmapped(bool? ignoreUnmapped = true)
	{
		IgnoreUnmappedValue = ignoreUnmapped;
		return Self;
	}

	/// <summary>
	/// <para>If defined, each search hit will contain inner hits.</para>
	/// </summary>
	public HasParentQueryDescriptor InnerHits(Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits? innerHits)
	{
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = null;
		InnerHitsValue = innerHits;
		return Self;
	}

	public HasParentQueryDescriptor InnerHits(Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor descriptor)
	{
		InnerHitsValue = null;
		InnerHitsDescriptorAction = null;
		InnerHitsDescriptor = descriptor;
		return Self;
	}

	public HasParentQueryDescriptor InnerHits(Action<Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor> configure)
	{
		InnerHitsValue = null;
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Name of the parent relationship mapped for the `join` field.</para>
	/// </summary>
	public HasParentQueryDescriptor ParentType(string parentType)
	{
		ParentTypeValue = parentType;
		return Self;
	}

	/// <summary>
	/// <para>Query you wish to run on parent documents of the `parent_type` field.<br/>If a parent document matches the search, the query returns its child documents.</para>
	/// </summary>
	public HasParentQueryDescriptor Query(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public HasParentQueryDescriptor Query(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public HasParentQueryDescriptor Query(Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	public HasParentQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	/// <summary>
	/// <para>Indicates whether the relevance score of a matching parent document is aggregated into its child documents.</para>
	/// </summary>
	public HasParentQueryDescriptor Score(bool? score = true)
	{
		ScoreValue = score;
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

		if (IgnoreUnmappedValue.HasValue)
		{
			writer.WritePropertyName("ignore_unmapped");
			writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
		}

		if (InnerHitsDescriptor is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsDescriptor, options);
		}
		else if (InnerHitsDescriptorAction is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor(InnerHitsDescriptorAction), options);
		}
		else if (InnerHitsValue is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsValue, options);
		}

		writer.WritePropertyName("parent_type");
		writer.WriteStringValue(ParentTypeValue);
		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor(QueryDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (ScoreValue.HasValue)
		{
			writer.WritePropertyName("score");
			writer.WriteBooleanValue(ScoreValue.Value);
		}

		writer.WriteEndObject();
	}
}