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

public sealed partial class BoolQuery : SearchQuery
{
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }
	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }
	[JsonInclude, JsonPropertyName("filter"), SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.QueryDsl.Query))]
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? Filter { get; set; }
	[JsonInclude, JsonPropertyName("minimum_should_match")]
	public Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }
	[JsonInclude, JsonPropertyName("must"), SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.QueryDsl.Query))]
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? Must { get; set; }
	[JsonInclude, JsonPropertyName("must_not"), SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.QueryDsl.Query))]
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? MustNot { get; set; }
	[JsonInclude, JsonPropertyName("should"), SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.QueryDsl.Query))]
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? Should { get; set; }

	public static implicit operator Query(BoolQuery boolQuery) => QueryDsl.Query.Bool(boolQuery);
}

public sealed partial class BoolQueryDescriptor<TDocument> : SerializableDescriptor<BoolQueryDescriptor<TDocument>>
{
	internal BoolQueryDescriptor(Action<BoolQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public BoolQueryDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? FilterValue { get; set; }
	private QueryDescriptor<TDocument> FilterDescriptor { get; set; }
	private Action<QueryDescriptor<TDocument>> FilterDescriptorAction { get; set; }
	private Action<QueryDescriptor<TDocument>>[] FilterDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? MustValue { get; set; }
	private QueryDescriptor<TDocument> MustDescriptor { get; set; }
	private Action<QueryDescriptor<TDocument>> MustDescriptorAction { get; set; }
	private Action<QueryDescriptor<TDocument>>[] MustDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? MustNotValue { get; set; }
	private QueryDescriptor<TDocument> MustNotDescriptor { get; set; }
	private Action<QueryDescriptor<TDocument>> MustNotDescriptorAction { get; set; }
	private Action<QueryDescriptor<TDocument>>[] MustNotDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? ShouldValue { get; set; }
	private QueryDescriptor<TDocument> ShouldDescriptor { get; set; }
	private Action<QueryDescriptor<TDocument>> ShouldDescriptorAction { get; set; }
	private Action<QueryDescriptor<TDocument>>[] ShouldDescriptorActions { get; set; }
	private string? QueryNameValue { get; set; }
	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }

	public BoolQueryDescriptor<TDocument> Filter(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Filter(QueryDescriptor<TDocument> descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Filter(Action<QueryDescriptor<TDocument>> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Filter(params Action<QueryDescriptor<TDocument>>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Must(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? must)
	{
		MustDescriptor = null;
		MustDescriptorAction = null;
		MustDescriptorActions = null;
		MustValue = must;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Must(QueryDescriptor<TDocument> descriptor)
	{
		MustValue = null;
		MustDescriptorAction = null;
		MustDescriptorActions = null;
		MustDescriptor = descriptor;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Must(Action<QueryDescriptor<TDocument>> configure)
	{
		MustValue = null;
		MustDescriptor = null;
		MustDescriptorActions = null;
		MustDescriptorAction = configure;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Must(params Action<QueryDescriptor<TDocument>>[] configure)
	{
		MustValue = null;
		MustDescriptor = null;
		MustDescriptorAction = null;
		MustDescriptorActions = configure;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> MustNot(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? mustNot)
	{
		MustNotDescriptor = null;
		MustNotDescriptorAction = null;
		MustNotDescriptorActions = null;
		MustNotValue = mustNot;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> MustNot(QueryDescriptor<TDocument> descriptor)
	{
		MustNotValue = null;
		MustNotDescriptorAction = null;
		MustNotDescriptorActions = null;
		MustNotDescriptor = descriptor;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> MustNot(Action<QueryDescriptor<TDocument>> configure)
	{
		MustNotValue = null;
		MustNotDescriptor = null;
		MustNotDescriptorActions = null;
		MustNotDescriptorAction = configure;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> MustNot(params Action<QueryDescriptor<TDocument>>[] configure)
	{
		MustNotValue = null;
		MustNotDescriptor = null;
		MustNotDescriptorAction = null;
		MustNotDescriptorActions = configure;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Should(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? should)
	{
		ShouldDescriptor = null;
		ShouldDescriptorAction = null;
		ShouldDescriptorActions = null;
		ShouldValue = should;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Should(QueryDescriptor<TDocument> descriptor)
	{
		ShouldValue = null;
		ShouldDescriptorAction = null;
		ShouldDescriptorActions = null;
		ShouldDescriptor = descriptor;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Should(Action<QueryDescriptor<TDocument>> configure)
	{
		ShouldValue = null;
		ShouldDescriptor = null;
		ShouldDescriptorActions = null;
		ShouldDescriptorAction = configure;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Should(params Action<QueryDescriptor<TDocument>>[] configure)
	{
		ShouldValue = null;
		ShouldDescriptor = null;
		ShouldDescriptorAction = null;
		ShouldDescriptorActions = configure;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
	{
		MinimumShouldMatchValue = minimumShouldMatch;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new QueryDescriptor<TDocument>(FilterDescriptorAction), options);
		}
		else if (FilterDescriptorActions is not null)
		{
			writer.WritePropertyName("filter");
			if (FilterDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in FilterDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new QueryDescriptor<TDocument>(action), options);
			}

			if (FilterDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(FilterValue, writer, options);
		}

		if (MustDescriptor is not null)
		{
			writer.WritePropertyName("must");
			JsonSerializer.Serialize(writer, MustDescriptor, options);
		}
		else if (MustDescriptorAction is not null)
		{
			writer.WritePropertyName("must");
			JsonSerializer.Serialize(writer, new QueryDescriptor<TDocument>(MustDescriptorAction), options);
		}
		else if (MustDescriptorActions is not null)
		{
			writer.WritePropertyName("must");
			if (MustDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in MustDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new QueryDescriptor<TDocument>(action), options);
			}

			if (MustDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (MustValue is not null)
		{
			writer.WritePropertyName("must");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(MustValue, writer, options);
		}

		if (MustNotDescriptor is not null)
		{
			writer.WritePropertyName("must_not");
			JsonSerializer.Serialize(writer, MustNotDescriptor, options);
		}
		else if (MustNotDescriptorAction is not null)
		{
			writer.WritePropertyName("must_not");
			JsonSerializer.Serialize(writer, new QueryDescriptor<TDocument>(MustNotDescriptorAction), options);
		}
		else if (MustNotDescriptorActions is not null)
		{
			writer.WritePropertyName("must_not");
			if (MustNotDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in MustNotDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new QueryDescriptor<TDocument>(action), options);
			}

			if (MustNotDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (MustNotValue is not null)
		{
			writer.WritePropertyName("must_not");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(MustNotValue, writer, options);
		}

		if (ShouldDescriptor is not null)
		{
			writer.WritePropertyName("should");
			JsonSerializer.Serialize(writer, ShouldDescriptor, options);
		}
		else if (ShouldDescriptorAction is not null)
		{
			writer.WritePropertyName("should");
			JsonSerializer.Serialize(writer, new QueryDescriptor<TDocument>(ShouldDescriptorAction), options);
		}
		else if (ShouldDescriptorActions is not null)
		{
			writer.WritePropertyName("should");
			if (ShouldDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in ShouldDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new QueryDescriptor<TDocument>(action), options);
			}

			if (ShouldDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (ShouldValue is not null)
		{
			writer.WritePropertyName("should");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(ShouldValue, writer, options);
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

		if (MinimumShouldMatchValue is not null)
		{
			writer.WritePropertyName("minimum_should_match");
			JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class BoolQueryDescriptor : SerializableDescriptor<BoolQueryDescriptor>
{
	internal BoolQueryDescriptor(Action<BoolQueryDescriptor> configure) => configure.Invoke(this);

	public BoolQueryDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? FilterValue { get; set; }
	private QueryDescriptor FilterDescriptor { get; set; }
	private Action<QueryDescriptor> FilterDescriptorAction { get; set; }
	private Action<QueryDescriptor>[] FilterDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? MustValue { get; set; }
	private QueryDescriptor MustDescriptor { get; set; }
	private Action<QueryDescriptor> MustDescriptorAction { get; set; }
	private Action<QueryDescriptor>[] MustDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? MustNotValue { get; set; }
	private QueryDescriptor MustNotDescriptor { get; set; }
	private Action<QueryDescriptor> MustNotDescriptorAction { get; set; }
	private Action<QueryDescriptor>[] MustNotDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? ShouldValue { get; set; }
	private QueryDescriptor ShouldDescriptor { get; set; }
	private Action<QueryDescriptor> ShouldDescriptorAction { get; set; }
	private Action<QueryDescriptor>[] ShouldDescriptorActions { get; set; }
	private string? QueryNameValue { get; set; }
	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }

	public BoolQueryDescriptor Filter(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public BoolQueryDescriptor Filter(QueryDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public BoolQueryDescriptor Filter(Action<QueryDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public BoolQueryDescriptor Filter(params Action<QueryDescriptor>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	public BoolQueryDescriptor Must(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? must)
	{
		MustDescriptor = null;
		MustDescriptorAction = null;
		MustDescriptorActions = null;
		MustValue = must;
		return Self;
	}

	public BoolQueryDescriptor Must(QueryDescriptor descriptor)
	{
		MustValue = null;
		MustDescriptorAction = null;
		MustDescriptorActions = null;
		MustDescriptor = descriptor;
		return Self;
	}

	public BoolQueryDescriptor Must(Action<QueryDescriptor> configure)
	{
		MustValue = null;
		MustDescriptor = null;
		MustDescriptorActions = null;
		MustDescriptorAction = configure;
		return Self;
	}

	public BoolQueryDescriptor Must(params Action<QueryDescriptor>[] configure)
	{
		MustValue = null;
		MustDescriptor = null;
		MustDescriptorAction = null;
		MustDescriptorActions = configure;
		return Self;
	}

	public BoolQueryDescriptor MustNot(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? mustNot)
	{
		MustNotDescriptor = null;
		MustNotDescriptorAction = null;
		MustNotDescriptorActions = null;
		MustNotValue = mustNot;
		return Self;
	}

	public BoolQueryDescriptor MustNot(QueryDescriptor descriptor)
	{
		MustNotValue = null;
		MustNotDescriptorAction = null;
		MustNotDescriptorActions = null;
		MustNotDescriptor = descriptor;
		return Self;
	}

	public BoolQueryDescriptor MustNot(Action<QueryDescriptor> configure)
	{
		MustNotValue = null;
		MustNotDescriptor = null;
		MustNotDescriptorActions = null;
		MustNotDescriptorAction = configure;
		return Self;
	}

	public BoolQueryDescriptor MustNot(params Action<QueryDescriptor>[] configure)
	{
		MustNotValue = null;
		MustNotDescriptor = null;
		MustNotDescriptorAction = null;
		MustNotDescriptorActions = configure;
		return Self;
	}

	public BoolQueryDescriptor Should(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? should)
	{
		ShouldDescriptor = null;
		ShouldDescriptorAction = null;
		ShouldDescriptorActions = null;
		ShouldValue = should;
		return Self;
	}

	public BoolQueryDescriptor Should(QueryDescriptor descriptor)
	{
		ShouldValue = null;
		ShouldDescriptorAction = null;
		ShouldDescriptorActions = null;
		ShouldDescriptor = descriptor;
		return Self;
	}

	public BoolQueryDescriptor Should(Action<QueryDescriptor> configure)
	{
		ShouldValue = null;
		ShouldDescriptor = null;
		ShouldDescriptorActions = null;
		ShouldDescriptorAction = configure;
		return Self;
	}

	public BoolQueryDescriptor Should(params Action<QueryDescriptor>[] configure)
	{
		ShouldValue = null;
		ShouldDescriptor = null;
		ShouldDescriptorAction = null;
		ShouldDescriptorActions = configure;
		return Self;
	}

	public BoolQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public BoolQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public BoolQueryDescriptor MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
	{
		MinimumShouldMatchValue = minimumShouldMatch;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new QueryDescriptor(FilterDescriptorAction), options);
		}
		else if (FilterDescriptorActions is not null)
		{
			writer.WritePropertyName("filter");
			if (FilterDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in FilterDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new QueryDescriptor(action), options);
			}

			if (FilterDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(FilterValue, writer, options);
		}

		if (MustDescriptor is not null)
		{
			writer.WritePropertyName("must");
			JsonSerializer.Serialize(writer, MustDescriptor, options);
		}
		else if (MustDescriptorAction is not null)
		{
			writer.WritePropertyName("must");
			JsonSerializer.Serialize(writer, new QueryDescriptor(MustDescriptorAction), options);
		}
		else if (MustDescriptorActions is not null)
		{
			writer.WritePropertyName("must");
			if (MustDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in MustDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new QueryDescriptor(action), options);
			}

			if (MustDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (MustValue is not null)
		{
			writer.WritePropertyName("must");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(MustValue, writer, options);
		}

		if (MustNotDescriptor is not null)
		{
			writer.WritePropertyName("must_not");
			JsonSerializer.Serialize(writer, MustNotDescriptor, options);
		}
		else if (MustNotDescriptorAction is not null)
		{
			writer.WritePropertyName("must_not");
			JsonSerializer.Serialize(writer, new QueryDescriptor(MustNotDescriptorAction), options);
		}
		else if (MustNotDescriptorActions is not null)
		{
			writer.WritePropertyName("must_not");
			if (MustNotDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in MustNotDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new QueryDescriptor(action), options);
			}

			if (MustNotDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (MustNotValue is not null)
		{
			writer.WritePropertyName("must_not");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(MustNotValue, writer, options);
		}

		if (ShouldDescriptor is not null)
		{
			writer.WritePropertyName("should");
			JsonSerializer.Serialize(writer, ShouldDescriptor, options);
		}
		else if (ShouldDescriptorAction is not null)
		{
			writer.WritePropertyName("should");
			JsonSerializer.Serialize(writer, new QueryDescriptor(ShouldDescriptorAction), options);
		}
		else if (ShouldDescriptorActions is not null)
		{
			writer.WritePropertyName("should");
			if (ShouldDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in ShouldDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new QueryDescriptor(action), options);
			}

			if (ShouldDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (ShouldValue is not null)
		{
			writer.WritePropertyName("should");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(ShouldValue, writer, options);
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

		if (MinimumShouldMatchValue is not null)
		{
			writer.WritePropertyName("minimum_should_match");
			JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
		}

		writer.WriteEndObject();
	}
}