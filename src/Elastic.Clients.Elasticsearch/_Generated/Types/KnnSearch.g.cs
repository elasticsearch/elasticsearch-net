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

internal sealed partial class KnnSearchConverter : System.Text.Json.Serialization.JsonConverter<KnnSearch>
{
	private static readonly System.Text.Json.JsonEncodedText PropBoost = System.Text.Json.JsonEncodedText.Encode("boost");
	private static readonly System.Text.Json.JsonEncodedText PropField = System.Text.Json.JsonEncodedText.Encode("field");
	private static readonly System.Text.Json.JsonEncodedText PropFilter = System.Text.Json.JsonEncodedText.Encode("filter");
	private static readonly System.Text.Json.JsonEncodedText PropInnerHits = System.Text.Json.JsonEncodedText.Encode("inner_hits");
	private static readonly System.Text.Json.JsonEncodedText Propk = System.Text.Json.JsonEncodedText.Encode("k");
	private static readonly System.Text.Json.JsonEncodedText PropNumCandidates = System.Text.Json.JsonEncodedText.Encode("num_candidates");
	private static readonly System.Text.Json.JsonEncodedText PropQueryVector = System.Text.Json.JsonEncodedText.Encode("query_vector");
	private static readonly System.Text.Json.JsonEncodedText PropQueryVectorBuilder = System.Text.Json.JsonEncodedText.Encode("query_vector_builder");
	private static readonly System.Text.Json.JsonEncodedText PropSimilarity = System.Text.Json.JsonEncodedText.Encode("similarity");

	public override KnnSearch Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<float?> propBoost = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.Field> propField = default;
		LocalJsonValue<ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>?> propFilter = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.Core.Search.InnerHits?> propInnerHits = default;
		LocalJsonValue<int?> propk = default;
		LocalJsonValue<int?> propNumCandidates = default;
		LocalJsonValue<ICollection<float>?> propQueryVector = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.QueryVectorBuilder?> propQueryVectorBuilder = default;
		LocalJsonValue<float?> propSimilarity = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propBoost.TryReadProperty(ref reader, options, PropBoost, null))
			{
				continue;
			}

			if (propField.TryReadProperty(ref reader, options, PropField, null))
			{
				continue;
			}

			if (propFilter.TryReadProperty(ref reader, options, PropFilter, static ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.QueryDsl.Query>(o, null)))
			{
				continue;
			}

			if (propInnerHits.TryReadProperty(ref reader, options, PropInnerHits, null))
			{
				continue;
			}

			if (propk.TryReadProperty(ref reader, options, Propk, null))
			{
				continue;
			}

			if (propNumCandidates.TryReadProperty(ref reader, options, PropNumCandidates, null))
			{
				continue;
			}

			if (propQueryVector.TryReadProperty(ref reader, options, PropQueryVector, static ICollection<float>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadCollectionValue<float>(o, null)))
			{
				continue;
			}

			if (propQueryVectorBuilder.TryReadProperty(ref reader, options, PropQueryVectorBuilder, null))
			{
				continue;
			}

			if (propSimilarity.TryReadProperty(ref reader, options, PropSimilarity, null))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new KnnSearch
		{
			Boost = propBoost.Value
,
			Field = propField.Value
,
			Filter = propFilter.Value
,
			InnerHits = propInnerHits.Value
,
			k = propk.Value
,
			NumCandidates = propNumCandidates.Value
,
			QueryVector = propQueryVector.Value
,
			QueryVectorBuilder = propQueryVectorBuilder.Value
,
			Similarity = propSimilarity.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, KnnSearch value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropBoost, value.Boost, null, null);
		writer.WriteProperty(options, PropField, value.Field, null, null);
		writer.WriteProperty(options, PropFilter, value.Filter, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? v) => w.WriteSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.QueryDsl.Query>(o, v, null));
		writer.WriteProperty(options, PropInnerHits, value.InnerHits, null, null);
		writer.WriteProperty(options, Propk, value.k, null, null);
		writer.WriteProperty(options, PropNumCandidates, value.NumCandidates, null, null);
		writer.WriteProperty(options, PropQueryVector, value.QueryVector, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<float>? v) => w.WriteCollectionValue<float>(o, v, null));
		writer.WriteProperty(options, PropQueryVectorBuilder, value.QueryVectorBuilder, null, null);
		writer.WriteProperty(options, PropSimilarity, value.Similarity, null, null);
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(KnnSearchConverter))]
public sealed partial class KnnSearch
{
	/// <summary>
	/// <para>
	/// Boost value to apply to kNN scores
	/// </para>
	/// </summary>
	public float? Boost { get; set; }

	/// <summary>
	/// <para>
	/// The name of the vector field to search against
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	/// <summary>
	/// <para>
	/// Filters for the kNN search query
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? Filter { get; set; }

	/// <summary>
	/// <para>
	/// If defined, each search hit will contain inner hits.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Core.Search.InnerHits? InnerHits { get; set; }

	/// <summary>
	/// <para>
	/// The final number of nearest neighbors to return as top hits
	/// </para>
	/// </summary>
	public int? k { get; set; }

	/// <summary>
	/// <para>
	/// The number of nearest neighbor candidates to consider per shard
	/// </para>
	/// </summary>
	public int? NumCandidates { get; set; }

	/// <summary>
	/// <para>
	/// The query vector
	/// </para>
	/// </summary>
	public ICollection<float>? QueryVector { get; set; }

	/// <summary>
	/// <para>
	/// The query vector builder. You must provide a query_vector_builder or query_vector, but not both.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.QueryVectorBuilder? QueryVectorBuilder { get; set; }

	/// <summary>
	/// <para>
	/// The minimum similarity for a vector to be considered a match
	/// </para>
	/// </summary>
	public float? Similarity { get; set; }
}

public sealed partial class KnnSearchDescriptor<TDocument> : SerializableDescriptor<KnnSearchDescriptor<TDocument>>
{
	internal KnnSearchDescriptor(Action<KnnSearchDescriptor<TDocument>> configure) => configure.Invoke(this);

	public KnnSearchDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> FilterDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] FilterDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.InnerHits? InnerHitsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.InnerHitsDescriptor<TDocument> InnerHitsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Core.Search.InnerHitsDescriptor<TDocument>> InnerHitsDescriptorAction { get; set; }
	private int? kValue { get; set; }
	private int? NumCandidatesValue { get; set; }
	private ICollection<float>? QueryVectorValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryVectorBuilder? QueryVectorBuilderValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor QueryVectorBuilderDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor> QueryVectorBuilderDescriptorAction { get; set; }
	private float? SimilarityValue { get; set; }

	/// <summary>
	/// <para>
	/// Boost value to apply to kNN scores
	/// </para>
	/// </summary>
	public KnnSearchDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The name of the vector field to search against
	/// </para>
	/// </summary>
	public KnnSearchDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The name of the vector field to search against
	/// </para>
	/// </summary>
	public KnnSearchDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The name of the vector field to search against
	/// </para>
	/// </summary>
	public KnnSearchDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Filters for the kNN search query
	/// </para>
	/// </summary>
	public KnnSearchDescriptor<TDocument> Filter(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public KnnSearchDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public KnnSearchDescriptor<TDocument> Filter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public KnnSearchDescriptor<TDocument> Filter(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If defined, each search hit will contain inner hits.
	/// </para>
	/// </summary>
	public KnnSearchDescriptor<TDocument> InnerHits(Elastic.Clients.Elasticsearch.Core.Search.InnerHits? innerHits)
	{
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = null;
		InnerHitsValue = innerHits;
		return Self;
	}

	public KnnSearchDescriptor<TDocument> InnerHits(Elastic.Clients.Elasticsearch.Core.Search.InnerHitsDescriptor<TDocument> descriptor)
	{
		InnerHitsValue = null;
		InnerHitsDescriptorAction = null;
		InnerHitsDescriptor = descriptor;
		return Self;
	}

	public KnnSearchDescriptor<TDocument> InnerHits(Action<Elastic.Clients.Elasticsearch.Core.Search.InnerHitsDescriptor<TDocument>> configure)
	{
		InnerHitsValue = null;
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The final number of nearest neighbors to return as top hits
	/// </para>
	/// </summary>
	public KnnSearchDescriptor<TDocument> k(int? k)
	{
		kValue = k;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The number of nearest neighbor candidates to consider per shard
	/// </para>
	/// </summary>
	public KnnSearchDescriptor<TDocument> NumCandidates(int? numCandidates)
	{
		NumCandidatesValue = numCandidates;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The query vector
	/// </para>
	/// </summary>
	public KnnSearchDescriptor<TDocument> QueryVector(ICollection<float>? queryVector)
	{
		QueryVectorValue = queryVector;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The query vector builder. You must provide a query_vector_builder or query_vector, but not both.
	/// </para>
	/// </summary>
	public KnnSearchDescriptor<TDocument> QueryVectorBuilder(Elastic.Clients.Elasticsearch.QueryVectorBuilder? queryVectorBuilder)
	{
		QueryVectorBuilderDescriptor = null;
		QueryVectorBuilderDescriptorAction = null;
		QueryVectorBuilderValue = queryVectorBuilder;
		return Self;
	}

	public KnnSearchDescriptor<TDocument> QueryVectorBuilder(Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor descriptor)
	{
		QueryVectorBuilderValue = null;
		QueryVectorBuilderDescriptorAction = null;
		QueryVectorBuilderDescriptor = descriptor;
		return Self;
	}

	public KnnSearchDescriptor<TDocument> QueryVectorBuilder(Action<Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor> configure)
	{
		QueryVectorBuilderValue = null;
		QueryVectorBuilderDescriptor = null;
		QueryVectorBuilderDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The minimum similarity for a vector to be considered a match
	/// </para>
	/// </summary>
	public KnnSearchDescriptor<TDocument> Similarity(float? similarity)
	{
		SimilarityValue = similarity;
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

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
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

		if (InnerHitsDescriptor is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsDescriptor, options);
		}
		else if (InnerHitsDescriptorAction is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Core.Search.InnerHitsDescriptor<TDocument>(InnerHitsDescriptorAction), options);
		}
		else if (InnerHitsValue is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsValue, options);
		}

		if (kValue.HasValue)
		{
			writer.WritePropertyName("k");
			writer.WriteNumberValue(kValue.Value);
		}

		if (NumCandidatesValue.HasValue)
		{
			writer.WritePropertyName("num_candidates");
			writer.WriteNumberValue(NumCandidatesValue.Value);
		}

		if (QueryVectorValue is not null)
		{
			writer.WritePropertyName("query_vector");
			JsonSerializer.Serialize(writer, QueryVectorValue, options);
		}

		if (QueryVectorBuilderDescriptor is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, QueryVectorBuilderDescriptor, options);
		}
		else if (QueryVectorBuilderDescriptorAction is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor(QueryVectorBuilderDescriptorAction), options);
		}
		else if (QueryVectorBuilderValue is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, QueryVectorBuilderValue, options);
		}

		if (SimilarityValue.HasValue)
		{
			writer.WritePropertyName("similarity");
			writer.WriteNumberValue(SimilarityValue.Value);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class KnnSearchDescriptor : SerializableDescriptor<KnnSearchDescriptor>
{
	internal KnnSearchDescriptor(Action<KnnSearchDescriptor> configure) => configure.Invoke(this);

	public KnnSearchDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> FilterDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] FilterDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.InnerHits? InnerHitsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.InnerHitsDescriptor InnerHitsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Core.Search.InnerHitsDescriptor> InnerHitsDescriptorAction { get; set; }
	private int? kValue { get; set; }
	private int? NumCandidatesValue { get; set; }
	private ICollection<float>? QueryVectorValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryVectorBuilder? QueryVectorBuilderValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor QueryVectorBuilderDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor> QueryVectorBuilderDescriptorAction { get; set; }
	private float? SimilarityValue { get; set; }

	/// <summary>
	/// <para>
	/// Boost value to apply to kNN scores
	/// </para>
	/// </summary>
	public KnnSearchDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The name of the vector field to search against
	/// </para>
	/// </summary>
	public KnnSearchDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The name of the vector field to search against
	/// </para>
	/// </summary>
	public KnnSearchDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The name of the vector field to search against
	/// </para>
	/// </summary>
	public KnnSearchDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Filters for the kNN search query
	/// </para>
	/// </summary>
	public KnnSearchDescriptor Filter(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public KnnSearchDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public KnnSearchDescriptor Filter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public KnnSearchDescriptor Filter(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// If defined, each search hit will contain inner hits.
	/// </para>
	/// </summary>
	public KnnSearchDescriptor InnerHits(Elastic.Clients.Elasticsearch.Core.Search.InnerHits? innerHits)
	{
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = null;
		InnerHitsValue = innerHits;
		return Self;
	}

	public KnnSearchDescriptor InnerHits(Elastic.Clients.Elasticsearch.Core.Search.InnerHitsDescriptor descriptor)
	{
		InnerHitsValue = null;
		InnerHitsDescriptorAction = null;
		InnerHitsDescriptor = descriptor;
		return Self;
	}

	public KnnSearchDescriptor InnerHits(Action<Elastic.Clients.Elasticsearch.Core.Search.InnerHitsDescriptor> configure)
	{
		InnerHitsValue = null;
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The final number of nearest neighbors to return as top hits
	/// </para>
	/// </summary>
	public KnnSearchDescriptor k(int? k)
	{
		kValue = k;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The number of nearest neighbor candidates to consider per shard
	/// </para>
	/// </summary>
	public KnnSearchDescriptor NumCandidates(int? numCandidates)
	{
		NumCandidatesValue = numCandidates;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The query vector
	/// </para>
	/// </summary>
	public KnnSearchDescriptor QueryVector(ICollection<float>? queryVector)
	{
		QueryVectorValue = queryVector;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The query vector builder. You must provide a query_vector_builder or query_vector, but not both.
	/// </para>
	/// </summary>
	public KnnSearchDescriptor QueryVectorBuilder(Elastic.Clients.Elasticsearch.QueryVectorBuilder? queryVectorBuilder)
	{
		QueryVectorBuilderDescriptor = null;
		QueryVectorBuilderDescriptorAction = null;
		QueryVectorBuilderValue = queryVectorBuilder;
		return Self;
	}

	public KnnSearchDescriptor QueryVectorBuilder(Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor descriptor)
	{
		QueryVectorBuilderValue = null;
		QueryVectorBuilderDescriptorAction = null;
		QueryVectorBuilderDescriptor = descriptor;
		return Self;
	}

	public KnnSearchDescriptor QueryVectorBuilder(Action<Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor> configure)
	{
		QueryVectorBuilderValue = null;
		QueryVectorBuilderDescriptor = null;
		QueryVectorBuilderDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The minimum similarity for a vector to be considered a match
	/// </para>
	/// </summary>
	public KnnSearchDescriptor Similarity(float? similarity)
	{
		SimilarityValue = similarity;
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

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
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

		if (InnerHitsDescriptor is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsDescriptor, options);
		}
		else if (InnerHitsDescriptorAction is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Core.Search.InnerHitsDescriptor(InnerHitsDescriptorAction), options);
		}
		else if (InnerHitsValue is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsValue, options);
		}

		if (kValue.HasValue)
		{
			writer.WritePropertyName("k");
			writer.WriteNumberValue(kValue.Value);
		}

		if (NumCandidatesValue.HasValue)
		{
			writer.WritePropertyName("num_candidates");
			writer.WriteNumberValue(NumCandidatesValue.Value);
		}

		if (QueryVectorValue is not null)
		{
			writer.WritePropertyName("query_vector");
			JsonSerializer.Serialize(writer, QueryVectorValue, options);
		}

		if (QueryVectorBuilderDescriptor is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, QueryVectorBuilderDescriptor, options);
		}
		else if (QueryVectorBuilderDescriptorAction is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor(QueryVectorBuilderDescriptorAction), options);
		}
		else if (QueryVectorBuilderValue is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, QueryVectorBuilderValue, options);
		}

		if (SimilarityValue.HasValue)
		{
			writer.WritePropertyName("similarity");
			writer.WriteNumberValue(SimilarityValue.Value);
		}

		writer.WriteEndObject();
	}
}