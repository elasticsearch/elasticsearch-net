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

internal sealed partial class KnnRetrieverConverter : System.Text.Json.Serialization.JsonConverter<KnnRetriever>
{
	private static readonly System.Text.Json.JsonEncodedText PropField = System.Text.Json.JsonEncodedText.Encode("field");
	private static readonly System.Text.Json.JsonEncodedText PropFilter = System.Text.Json.JsonEncodedText.Encode("filter");
	private static readonly System.Text.Json.JsonEncodedText Propk = System.Text.Json.JsonEncodedText.Encode("k");
	private static readonly System.Text.Json.JsonEncodedText PropMinScore = System.Text.Json.JsonEncodedText.Encode("min_score");
	private static readonly System.Text.Json.JsonEncodedText PropNumCandidates = System.Text.Json.JsonEncodedText.Encode("num_candidates");
	private static readonly System.Text.Json.JsonEncodedText PropQueryVector = System.Text.Json.JsonEncodedText.Encode("query_vector");
	private static readonly System.Text.Json.JsonEncodedText PropQueryVectorBuilder = System.Text.Json.JsonEncodedText.Encode("query_vector_builder");
	private static readonly System.Text.Json.JsonEncodedText PropSimilarity = System.Text.Json.JsonEncodedText.Encode("similarity");

	public override KnnRetriever Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<string> propField = default;
		LocalJsonValue<ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>?> propFilter = default;
		LocalJsonValue<int> propk = default;
		LocalJsonValue<float?> propMinScore = default;
		LocalJsonValue<int> propNumCandidates = default;
		LocalJsonValue<ICollection<float>?> propQueryVector = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.QueryVectorBuilder?> propQueryVectorBuilder = default;
		LocalJsonValue<float?> propSimilarity = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propField.TryReadProperty(ref reader, options, PropField, null))
			{
				continue;
			}

			if (propFilter.TryReadProperty(ref reader, options, PropFilter, static ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.QueryDsl.Query>(o, null)))
			{
				continue;
			}

			if (propk.TryReadProperty(ref reader, options, Propk, null))
			{
				continue;
			}

			if (propMinScore.TryReadProperty(ref reader, options, PropMinScore, null))
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
		return new KnnRetriever
		{
			Field = propField.Value
,
			Filter = propFilter.Value
,
			k = propk.Value
,
			MinScore = propMinScore.Value
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

	public override void Write(System.Text.Json.Utf8JsonWriter writer, KnnRetriever value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropField, value.Field, null, null);
		writer.WriteProperty(options, PropFilter, value.Filter, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? v) => w.WriteSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.QueryDsl.Query>(o, v, null));
		writer.WriteProperty(options, Propk, value.k, null, null);
		writer.WriteProperty(options, PropMinScore, value.MinScore, null, null);
		writer.WriteProperty(options, PropNumCandidates, value.NumCandidates, null, null);
		writer.WriteProperty(options, PropQueryVector, value.QueryVector, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<float>? v) => w.WriteCollectionValue<float>(o, v, null));
		writer.WriteProperty(options, PropQueryVectorBuilder, value.QueryVectorBuilder, null, null);
		writer.WriteProperty(options, PropSimilarity, value.Similarity, null, null);
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(KnnRetrieverConverter))]
public sealed partial class KnnRetriever
{
	/// <summary>
	/// <para>
	/// The name of the vector field to search against.
	/// </para>
	/// </summary>
	public string Field { get; set; }

	/// <summary>
	/// <para>
	/// Query to filter the documents that can match.
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? Filter { get; set; }

	/// <summary>
	/// <para>
	/// Number of nearest neighbors to return as top hits.
	/// </para>
	/// </summary>
	public int k { get; set; }

	/// <summary>
	/// <para>
	/// Minimum _score for matching documents. Documents with a lower _score are not included in the top documents.
	/// </para>
	/// </summary>
	public float? MinScore { get; set; }

	/// <summary>
	/// <para>
	/// Number of nearest neighbor candidates to consider per shard.
	/// </para>
	/// </summary>
	public int NumCandidates { get; set; }

	/// <summary>
	/// <para>
	/// Query vector. Must have the same number of dimensions as the vector field you are searching against. You must provide a query_vector_builder or query_vector, but not both.
	/// </para>
	/// </summary>
	public ICollection<float>? QueryVector { get; set; }

	/// <summary>
	/// <para>
	/// Defines a model to build a query vector.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.QueryVectorBuilder? QueryVectorBuilder { get; set; }

	/// <summary>
	/// <para>
	/// The minimum similarity required for a document to be considered a match.
	/// </para>
	/// </summary>
	public float? Similarity { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Retriever(KnnRetriever knnRetriever) => Elastic.Clients.Elasticsearch.Retriever.Knn(knnRetriever);
}

public sealed partial class KnnRetrieverDescriptor<TDocument> : SerializableDescriptor<KnnRetrieverDescriptor<TDocument>>
{
	internal KnnRetrieverDescriptor(Action<KnnRetrieverDescriptor<TDocument>> configure) => configure.Invoke(this);

	public KnnRetrieverDescriptor() : base()
	{
	}

	private string FieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> FilterDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] FilterDescriptorActions { get; set; }
	private int kValue { get; set; }
	private float? MinScoreValue { get; set; }
	private int NumCandidatesValue { get; set; }
	private ICollection<float>? QueryVectorValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryVectorBuilder? QueryVectorBuilderValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor QueryVectorBuilderDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor> QueryVectorBuilderDescriptorAction { get; set; }
	private float? SimilarityValue { get; set; }

	/// <summary>
	/// <para>
	/// The name of the vector field to search against.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor<TDocument> Field(string field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Query to filter the documents that can match.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor<TDocument> Filter(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public KnnRetrieverDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public KnnRetrieverDescriptor<TDocument> Filter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public KnnRetrieverDescriptor<TDocument> Filter(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Number of nearest neighbors to return as top hits.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor<TDocument> k(int k)
	{
		kValue = k;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Minimum _score for matching documents. Documents with a lower _score are not included in the top documents.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor<TDocument> MinScore(float? minScore)
	{
		MinScoreValue = minScore;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Number of nearest neighbor candidates to consider per shard.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor<TDocument> NumCandidates(int numCandidates)
	{
		NumCandidatesValue = numCandidates;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Query vector. Must have the same number of dimensions as the vector field you are searching against. You must provide a query_vector_builder or query_vector, but not both.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor<TDocument> QueryVector(ICollection<float>? queryVector)
	{
		QueryVectorValue = queryVector;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines a model to build a query vector.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor<TDocument> QueryVectorBuilder(Elastic.Clients.Elasticsearch.QueryVectorBuilder? queryVectorBuilder)
	{
		QueryVectorBuilderDescriptor = null;
		QueryVectorBuilderDescriptorAction = null;
		QueryVectorBuilderValue = queryVectorBuilder;
		return Self;
	}

	public KnnRetrieverDescriptor<TDocument> QueryVectorBuilder(Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor descriptor)
	{
		QueryVectorBuilderValue = null;
		QueryVectorBuilderDescriptorAction = null;
		QueryVectorBuilderDescriptor = descriptor;
		return Self;
	}

	public KnnRetrieverDescriptor<TDocument> QueryVectorBuilder(Action<Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor> configure)
	{
		QueryVectorBuilderValue = null;
		QueryVectorBuilderDescriptor = null;
		QueryVectorBuilderDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The minimum similarity required for a document to be considered a match.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor<TDocument> Similarity(float? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("field");
		writer.WriteStringValue(FieldValue);
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

		writer.WritePropertyName("k");
		writer.WriteNumberValue(kValue);
		if (MinScoreValue.HasValue)
		{
			writer.WritePropertyName("min_score");
			writer.WriteNumberValue(MinScoreValue.Value);
		}

		writer.WritePropertyName("num_candidates");
		writer.WriteNumberValue(NumCandidatesValue);
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

public sealed partial class KnnRetrieverDescriptor : SerializableDescriptor<KnnRetrieverDescriptor>
{
	internal KnnRetrieverDescriptor(Action<KnnRetrieverDescriptor> configure) => configure.Invoke(this);

	public KnnRetrieverDescriptor() : base()
	{
	}

	private string FieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> FilterDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] FilterDescriptorActions { get; set; }
	private int kValue { get; set; }
	private float? MinScoreValue { get; set; }
	private int NumCandidatesValue { get; set; }
	private ICollection<float>? QueryVectorValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryVectorBuilder? QueryVectorBuilderValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor QueryVectorBuilderDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor> QueryVectorBuilderDescriptorAction { get; set; }
	private float? SimilarityValue { get; set; }

	/// <summary>
	/// <para>
	/// The name of the vector field to search against.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor Field(string field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Query to filter the documents that can match.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor Filter(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public KnnRetrieverDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public KnnRetrieverDescriptor Filter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public KnnRetrieverDescriptor Filter(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Number of nearest neighbors to return as top hits.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor k(int k)
	{
		kValue = k;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Minimum _score for matching documents. Documents with a lower _score are not included in the top documents.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor MinScore(float? minScore)
	{
		MinScoreValue = minScore;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Number of nearest neighbor candidates to consider per shard.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor NumCandidates(int numCandidates)
	{
		NumCandidatesValue = numCandidates;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Query vector. Must have the same number of dimensions as the vector field you are searching against. You must provide a query_vector_builder or query_vector, but not both.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor QueryVector(ICollection<float>? queryVector)
	{
		QueryVectorValue = queryVector;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Defines a model to build a query vector.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor QueryVectorBuilder(Elastic.Clients.Elasticsearch.QueryVectorBuilder? queryVectorBuilder)
	{
		QueryVectorBuilderDescriptor = null;
		QueryVectorBuilderDescriptorAction = null;
		QueryVectorBuilderValue = queryVectorBuilder;
		return Self;
	}

	public KnnRetrieverDescriptor QueryVectorBuilder(Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor descriptor)
	{
		QueryVectorBuilderValue = null;
		QueryVectorBuilderDescriptorAction = null;
		QueryVectorBuilderDescriptor = descriptor;
		return Self;
	}

	public KnnRetrieverDescriptor QueryVectorBuilder(Action<Elastic.Clients.Elasticsearch.QueryVectorBuilderDescriptor> configure)
	{
		QueryVectorBuilderValue = null;
		QueryVectorBuilderDescriptor = null;
		QueryVectorBuilderDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The minimum similarity required for a document to be considered a match.
	/// </para>
	/// </summary>
	public KnnRetrieverDescriptor Similarity(float? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("field");
		writer.WriteStringValue(FieldValue);
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

		writer.WritePropertyName("k");
		writer.WriteNumberValue(kValue);
		if (MinScoreValue.HasValue)
		{
			writer.WritePropertyName("min_score");
			writer.WriteNumberValue(MinScoreValue.Value);
		}

		writer.WritePropertyName("num_candidates");
		writer.WriteNumberValue(NumCandidatesValue);
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