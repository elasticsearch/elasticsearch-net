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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public sealed partial class KnnQuery
	{
		[JsonInclude]
		[JsonPropertyName("boost")]
		public float? Boost { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("filter")]
		public IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer>? Filter { get; set; }

		[JsonInclude]
		[JsonPropertyName("k")]
		public long k { get; set; }

		[JsonInclude]
		[JsonPropertyName("num_candidates")]
		public long NumCandidates { get; set; }

		[JsonInclude]
		[JsonPropertyName("query_vector")]
		public IEnumerable<double> QueryVector { get; set; }
	}

	public sealed partial class KnnQueryDescriptor<TDocument> : SerializableDescriptorBase<KnnQueryDescriptor<TDocument>>
	{
		internal KnnQueryDescriptor(Action<KnnQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public KnnQueryDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer>? FilterValue { get; set; }

		private QueryDsl.QueryContainerDescriptor<TDocument> FilterDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor<TDocument>> FilterDescriptorAction { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor<TDocument>>[] FilterDescriptorActions { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private long kValue { get; set; }

		private long NumCandidatesValue { get; set; }

		private IEnumerable<double> QueryVectorValue { get; set; }

		public KnnQueryDescriptor<TDocument> Filter(IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer>? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterDescriptorActions = null;
			FilterValue = filter;
			return Self;
		}

		public KnnQueryDescriptor<TDocument> Filter(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptorActions = null;
			FilterDescriptor = descriptor;
			return Self;
		}

		public KnnQueryDescriptor<TDocument> Filter(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			FilterValue = null;
			FilterDescriptor = null;
			FilterDescriptorActions = null;
			FilterDescriptorAction = configure;
			return Self;
		}

		public KnnQueryDescriptor<TDocument> Filter(params Action<QueryDsl.QueryContainerDescriptor<TDocument>>[] configure)
		{
			FilterValue = null;
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterDescriptorActions = configure;
			return Self;
		}

		public KnnQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public KnnQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public KnnQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public KnnQueryDescriptor<TDocument> k(long k)
		{
			kValue = k;
			return Self;
		}

		public KnnQueryDescriptor<TDocument> NumCandidates(long numCandidates)
		{
			NumCandidatesValue = numCandidates;
			return Self;
		}

		public KnnQueryDescriptor<TDocument> QueryVector(IEnumerable<double> queryVector)
		{
			QueryVectorValue = queryVector;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FilterDescriptor is not null)
			{
				writer.WritePropertyName("filter");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, FilterDescriptor, options);
				writer.WriteEndArray();
			}
			else if (FilterDescriptorAction is not null)
			{
				writer.WritePropertyName("filter");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(FilterDescriptorAction), options);
				writer.WriteEndArray();
			}
			else if (FilterDescriptorActions is not null)
			{
				writer.WritePropertyName("filter");
				writer.WriteStartArray();
				foreach (var action in FilterDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(action), options);
				}

				writer.WriteEndArray();
			}
			else if (FilterValue is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterValue, options);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			writer.WritePropertyName("k");
			writer.WriteNumberValue(kValue);
			writer.WritePropertyName("num_candidates");
			writer.WriteNumberValue(NumCandidatesValue);
			writer.WritePropertyName("query_vector");
			JsonSerializer.Serialize(writer, QueryVectorValue, options);
			writer.WriteEndObject();
		}
	}

	public sealed partial class KnnQueryDescriptor : SerializableDescriptorBase<KnnQueryDescriptor>
	{
		internal KnnQueryDescriptor(Action<KnnQueryDescriptor> configure) => configure.Invoke(this);
		public KnnQueryDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer>? FilterValue { get; set; }

		private QueryDsl.QueryContainerDescriptor FilterDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor> FilterDescriptorAction { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor>[] FilterDescriptorActions { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private long kValue { get; set; }

		private long NumCandidatesValue { get; set; }

		private IEnumerable<double> QueryVectorValue { get; set; }

		public KnnQueryDescriptor Filter(IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer>? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterDescriptorActions = null;
			FilterValue = filter;
			return Self;
		}

		public KnnQueryDescriptor Filter(QueryDsl.QueryContainerDescriptor descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptorActions = null;
			FilterDescriptor = descriptor;
			return Self;
		}

		public KnnQueryDescriptor Filter(Action<QueryDsl.QueryContainerDescriptor> configure)
		{
			FilterValue = null;
			FilterDescriptor = null;
			FilterDescriptorActions = null;
			FilterDescriptorAction = configure;
			return Self;
		}

		public KnnQueryDescriptor Filter(params Action<QueryDsl.QueryContainerDescriptor>[] configure)
		{
			FilterValue = null;
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterDescriptorActions = configure;
			return Self;
		}

		public KnnQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public KnnQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public KnnQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public KnnQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public KnnQueryDescriptor k(long k)
		{
			kValue = k;
			return Self;
		}

		public KnnQueryDescriptor NumCandidates(long numCandidates)
		{
			NumCandidatesValue = numCandidates;
			return Self;
		}

		public KnnQueryDescriptor QueryVector(IEnumerable<double> queryVector)
		{
			QueryVectorValue = queryVector;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FilterDescriptor is not null)
			{
				writer.WritePropertyName("filter");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, FilterDescriptor, options);
				writer.WriteEndArray();
			}
			else if (FilterDescriptorAction is not null)
			{
				writer.WritePropertyName("filter");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor(FilterDescriptorAction), options);
				writer.WriteEndArray();
			}
			else if (FilterDescriptorActions is not null)
			{
				writer.WritePropertyName("filter");
				writer.WriteStartArray();
				foreach (var action in FilterDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor(action), options);
				}

				writer.WriteEndArray();
			}
			else if (FilterValue is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterValue, options);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			writer.WritePropertyName("k");
			writer.WriteNumberValue(kValue);
			writer.WritePropertyName("num_candidates");
			writer.WriteNumberValue(NumCandidatesValue);
			writer.WritePropertyName("query_vector");
			JsonSerializer.Serialize(writer, QueryVectorValue, options);
			writer.WriteEndObject();
		}
	}
}