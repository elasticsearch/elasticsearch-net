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

namespace Elastic.Clients.Elasticsearch;

internal sealed partial class StandardRetrieverConverter : System.Text.Json.Serialization.JsonConverter<StandardRetriever>
{
	private static readonly System.Text.Json.JsonEncodedText PropCollapse = System.Text.Json.JsonEncodedText.Encode("collapse");
	private static readonly System.Text.Json.JsonEncodedText PropFilter = System.Text.Json.JsonEncodedText.Encode("filter");
	private static readonly System.Text.Json.JsonEncodedText PropMinScore = System.Text.Json.JsonEncodedText.Encode("min_score");
	private static readonly System.Text.Json.JsonEncodedText PropQuery = System.Text.Json.JsonEncodedText.Encode("query");
	private static readonly System.Text.Json.JsonEncodedText PropSearchAfter = System.Text.Json.JsonEncodedText.Encode("search_after");
	private static readonly System.Text.Json.JsonEncodedText PropSort = System.Text.Json.JsonEncodedText.Encode("sort");
	private static readonly System.Text.Json.JsonEncodedText PropTerminateAfter = System.Text.Json.JsonEncodedText.Encode("terminate_after");

	public override StandardRetriever Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<Elastic.Clients.Elasticsearch.Core.Search.FieldCollapse?> propCollapse = default;
		LocalJsonValue<ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>?> propFilter = default;
		LocalJsonValue<float?> propMinScore = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.QueryDsl.Query?> propQuery = default;
		LocalJsonValue<ICollection<Elastic.Clients.Elasticsearch.FieldValue>?> propSearchAfter = default;
		LocalJsonValue<ICollection<Elastic.Clients.Elasticsearch.SortOptions>?> propSort = default;
		LocalJsonValue<int?> propTerminateAfter = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propCollapse.TryReadProperty(ref reader, options, PropCollapse, null))
			{
				continue;
			}

			if (propFilter.TryReadProperty(ref reader, options, PropFilter, static ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.QueryDsl.Query>(o, null)))
			{
				continue;
			}

			if (propMinScore.TryReadProperty(ref reader, options, PropMinScore, null))
			{
				continue;
			}

			if (propQuery.TryReadProperty(ref reader, options, PropQuery, null))
			{
				continue;
			}

			if (propSearchAfter.TryReadProperty(ref reader, options, PropSearchAfter, static ICollection<Elastic.Clients.Elasticsearch.FieldValue>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadCollectionValue<Elastic.Clients.Elasticsearch.FieldValue>(o, null)))
			{
				continue;
			}

			if (propSort.TryReadProperty(ref reader, options, PropSort, static ICollection<Elastic.Clients.Elasticsearch.SortOptions>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.SortOptions>(o, null)))
			{
				continue;
			}

			if (propTerminateAfter.TryReadProperty(ref reader, options, PropTerminateAfter, null))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new StandardRetriever
		{
			Collapse = propCollapse.Value
,
			Filter = propFilter.Value
,
			MinScore = propMinScore.Value
,
			Query = propQuery.Value
,
			SearchAfter = propSearchAfter.Value
,
			Sort = propSort.Value
,
			TerminateAfter = propTerminateAfter.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, StandardRetriever value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropCollapse, value.Collapse, null, null);
		writer.WriteProperty(options, PropFilter, value.Filter, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? v) => w.WriteSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.QueryDsl.Query>(o, v, null));
		writer.WriteProperty(options, PropMinScore, value.MinScore, null, null);
		writer.WriteProperty(options, PropQuery, value.Query, null, null);
		writer.WriteProperty(options, PropSearchAfter, value.SearchAfter, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<Elastic.Clients.Elasticsearch.FieldValue>? v) => w.WriteCollectionValue<Elastic.Clients.Elasticsearch.FieldValue>(o, v, null));
		writer.WriteProperty(options, PropSort, value.Sort, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<Elastic.Clients.Elasticsearch.SortOptions>? v) => w.WriteSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.SortOptions>(o, v, null));
		writer.WriteProperty(options, PropTerminateAfter, value.TerminateAfter, null, null);
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(StandardRetrieverConverter))]
public sealed partial class StandardRetriever
{
	/// <summary>
	/// <para>
	/// Collapses the top documents by a specified key into a single top document per key.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Core.Search.FieldCollapse? Collapse { get; set; }

	/// <summary>
	/// <para>
	/// Query to filter the documents that can match.
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? Filter { get; set; }

	/// <summary>
	/// <para>
	/// Minimum _score for matching documents. Documents with a lower _score are not included in the top documents.
	/// </para>
	/// </summary>
	public float? MinScore { get; set; }

	/// <summary>
	/// <para>
	/// Defines a query to retrieve a set of top documents.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.QueryDsl.Query? Query { get; set; }

	/// <summary>
	/// <para>
	/// Defines a search after object parameter used for pagination.
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.FieldValue>? SearchAfter { get; set; }

	/// <summary>
	/// <para>
	/// A sort object that that specifies the order of matching documents.
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.SortOptions>? Sort { get; set; }

	/// <summary>
	/// <para>
	/// Maximum number of documents to collect for each shard.
	/// </para>
	/// </summary>
	public int? TerminateAfter { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Retriever(StandardRetriever standardRetriever) => Elastic.Clients.Elasticsearch.Retriever.Standard(standardRetriever);
}

public sealed partial class StandardRetrieverDescriptor<TDocument> : SerializableDescriptor<StandardRetrieverDescriptor<TDocument>>
{
	internal StandardRetrieverDescriptor(Action<StandardRetrieverDescriptor<TDocument>> configure) => configure.Invoke(this);

	public StandardRetrieverDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Core.Search.FieldCollapse? CollapseValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor<TDocument> CollapseDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor<TDocument>> CollapseDescriptorAction { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> FilterDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] FilterDescriptorActions { get; set; }
	private float? MinScoreValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Query? QueryValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> QueryDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> QueryDescriptorAction { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.FieldValue>? SearchAfterValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.SortOptions>? SortValue { get; set; }
	private Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument> SortDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>> SortDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>>[] SortDescriptorActions { get; set; }
	private int? TerminateAfterValue { get; set; }

	/// <summary>
	/// <para>
	/// Collapses the top documents by a specified key into a single top document per key.
	/// </para>
	/// </summary>
	public StandardRetrieverDescriptor<TDocument> Collapse(Elastic.Clients.Elasticsearch.Core.Search.FieldCollapse? collapse)
	{
		CollapseDescriptor = null;
		CollapseDescriptorAction = null;
		CollapseValue = collapse;
		return Self;
	}

	public StandardRetrieverDescriptor<TDocument> Collapse(Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor<TDocument> descriptor)
	{
		CollapseValue = null;
		CollapseDescriptorAction = null;
		CollapseDescriptor = descriptor;
		return Self;
	}

	public StandardRetrieverDescriptor<TDocument> Collapse(Action<Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor<TDocument>> configure)
	{
		CollapseValue = null;
		CollapseDescriptor = null;
		CollapseDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Query to filter the documents that can match.
	/// </para>
	/// </summary>
	public StandardRetrieverDescriptor<TDocument> Filter(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public StandardRetrieverDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public StandardRetrieverDescriptor<TDocument> Filter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public StandardRetrieverDescriptor<TDocument> Filter(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Minimum _score for matching documents. Documents with a lower _score are not included in the top documents.
	/// </para>
	/// </summary>
	public StandardRetrieverDescriptor<TDocument> MinScore(float? minScore)
	{
		MinScoreValue = minScore;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines a query to retrieve a set of top documents.
	/// </para>
	/// </summary>
	public StandardRetrieverDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.Query? query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public StandardRetrieverDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public StandardRetrieverDescriptor<TDocument> Query(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines a search after object parameter used for pagination.
	/// </para>
	/// </summary>
	public StandardRetrieverDescriptor<TDocument> SearchAfter(ICollection<Elastic.Clients.Elasticsearch.FieldValue>? searchAfter)
	{
		SearchAfterValue = searchAfter;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A sort object that that specifies the order of matching documents.
	/// </para>
	/// </summary>
	public StandardRetrieverDescriptor<TDocument> Sort(ICollection<Elastic.Clients.Elasticsearch.SortOptions>? sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortValue = sort;
		return Self;
	}

	public StandardRetrieverDescriptor<TDocument> Sort(Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument> descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public StandardRetrieverDescriptor<TDocument> Sort(Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorActions = null;
		SortDescriptorAction = configure;
		return Self;
	}

	public StandardRetrieverDescriptor<TDocument> Sort(params Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>>[] configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Maximum number of documents to collect for each shard.
	/// </para>
	/// </summary>
	public StandardRetrieverDescriptor<TDocument> TerminateAfter(int? terminateAfter)
	{
		TerminateAfterValue = terminateAfter;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (CollapseDescriptor is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, CollapseDescriptor, options);
		}
		else if (CollapseDescriptorAction is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor<TDocument>(CollapseDescriptorAction), options);
		}
		else if (CollapseValue is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, CollapseValue, options);
		}

		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(FilterDescriptorAction), options);
		}
		else if (FilterDescriptorActions is not null)
		{
			writer.WritePropertyName("filter");
			if (FilterDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in FilterDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(action), options);
			}

			if (FilterDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(FilterValue, writer, options);
		}

		if (MinScoreValue.HasValue)
		{
			writer.WritePropertyName("min_score");
			writer.WriteNumberValue(MinScoreValue.Value);
		}

		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(QueryDescriptorAction), options);
		}
		else if (QueryValue is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (SearchAfterValue is not null)
		{
			writer.WritePropertyName("search_after");
			JsonSerializer.Serialize(writer, SearchAfterValue, options);
		}

		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>(SortDescriptorAction), options);
		}
		else if (SortDescriptorActions is not null)
		{
			writer.WritePropertyName("sort");
			if (SortDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in SortDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>(action), options);
			}

			if (SortDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (SortValue is not null)
		{
			writer.WritePropertyName("sort");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.SortOptions>(SortValue, writer, options);
		}

		if (TerminateAfterValue.HasValue)
		{
			writer.WritePropertyName("terminate_after");
			writer.WriteNumberValue(TerminateAfterValue.Value);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class StandardRetrieverDescriptor : SerializableDescriptor<StandardRetrieverDescriptor>
{
	internal StandardRetrieverDescriptor(Action<StandardRetrieverDescriptor> configure) => configure.Invoke(this);

	public StandardRetrieverDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Core.Search.FieldCollapse? CollapseValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor CollapseDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor> CollapseDescriptorAction { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> FilterDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] FilterDescriptorActions { get; set; }
	private float? MinScoreValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Query? QueryValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor QueryDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> QueryDescriptorAction { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.FieldValue>? SearchAfterValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.SortOptions>? SortValue { get; set; }
	private Elastic.Clients.Elasticsearch.SortOptionsDescriptor SortDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor> SortDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor>[] SortDescriptorActions { get; set; }
	private int? TerminateAfterValue { get; set; }

	/// <summary>
	/// <para>
	/// Collapses the top documents by a specified key into a single top document per key.
	/// </para>
	/// </summary>
	public StandardRetrieverDescriptor Collapse(Elastic.Clients.Elasticsearch.Core.Search.FieldCollapse? collapse)
	{
		CollapseDescriptor = null;
		CollapseDescriptorAction = null;
		CollapseValue = collapse;
		return Self;
	}

	public StandardRetrieverDescriptor Collapse(Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor descriptor)
	{
		CollapseValue = null;
		CollapseDescriptorAction = null;
		CollapseDescriptor = descriptor;
		return Self;
	}

	public StandardRetrieverDescriptor Collapse(Action<Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor> configure)
	{
		CollapseValue = null;
		CollapseDescriptor = null;
		CollapseDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Query to filter the documents that can match.
	/// </para>
	/// </summary>
	public StandardRetrieverDescriptor Filter(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public StandardRetrieverDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public StandardRetrieverDescriptor Filter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public StandardRetrieverDescriptor Filter(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Minimum _score for matching documents. Documents with a lower _score are not included in the top documents.
	/// </para>
	/// </summary>
	public StandardRetrieverDescriptor MinScore(float? minScore)
	{
		MinScoreValue = minScore;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines a query to retrieve a set of top documents.
	/// </para>
	/// </summary>
	public StandardRetrieverDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.Query? query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public StandardRetrieverDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public StandardRetrieverDescriptor Query(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines a search after object parameter used for pagination.
	/// </para>
	/// </summary>
	public StandardRetrieverDescriptor SearchAfter(ICollection<Elastic.Clients.Elasticsearch.FieldValue>? searchAfter)
	{
		SearchAfterValue = searchAfter;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A sort object that that specifies the order of matching documents.
	/// </para>
	/// </summary>
	public StandardRetrieverDescriptor Sort(ICollection<Elastic.Clients.Elasticsearch.SortOptions>? sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortValue = sort;
		return Self;
	}

	public StandardRetrieverDescriptor Sort(Elastic.Clients.Elasticsearch.SortOptionsDescriptor descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public StandardRetrieverDescriptor Sort(Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorActions = null;
		SortDescriptorAction = configure;
		return Self;
	}

	public StandardRetrieverDescriptor Sort(params Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor>[] configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Maximum number of documents to collect for each shard.
	/// </para>
	/// </summary>
	public StandardRetrieverDescriptor TerminateAfter(int? terminateAfter)
	{
		TerminateAfterValue = terminateAfter;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (CollapseDescriptor is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, CollapseDescriptor, options);
		}
		else if (CollapseDescriptorAction is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Core.Search.FieldCollapseDescriptor(CollapseDescriptorAction), options);
		}
		else if (CollapseValue is not null)
		{
			writer.WritePropertyName("collapse");
			JsonSerializer.Serialize(writer, CollapseValue, options);
		}

		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(FilterDescriptorAction), options);
		}
		else if (FilterDescriptorActions is not null)
		{
			writer.WritePropertyName("filter");
			if (FilterDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in FilterDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(action), options);
			}

			if (FilterDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(FilterValue, writer, options);
		}

		if (MinScoreValue.HasValue)
		{
			writer.WritePropertyName("min_score");
			writer.WriteNumberValue(MinScoreValue.Value);
		}

		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(QueryDescriptorAction), options);
		}
		else if (QueryValue is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (SearchAfterValue is not null)
		{
			writer.WritePropertyName("search_after");
			JsonSerializer.Serialize(writer, SearchAfterValue, options);
		}

		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.SortOptionsDescriptor(SortDescriptorAction), options);
		}
		else if (SortDescriptorActions is not null)
		{
			writer.WritePropertyName("sort");
			if (SortDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in SortDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.SortOptionsDescriptor(action), options);
			}

			if (SortDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (SortValue is not null)
		{
			writer.WritePropertyName("sort");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.SortOptions>(SortValue, writer, options);
		}

		if (TerminateAfterValue.HasValue)
		{
			writer.WritePropertyName("terminate_after");
			writer.WriteNumberValue(TerminateAfterValue.Value);
		}

		writer.WriteEndObject();
	}
}