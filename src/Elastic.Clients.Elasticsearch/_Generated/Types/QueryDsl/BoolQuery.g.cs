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

public sealed partial class BoolQuery
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

	/// <summary>
	/// <para>
	/// The clause (query) must appear in matching documents.
	/// However, unlike <c>must</c>, the score of the query will be ignored.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("filter")]
	[SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.QueryDsl.Query))]
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? Filter { get; set; }

	/// <summary>
	/// <para>
	/// Specifies the number or percentage of <c>should</c> clauses returned documents must match.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("minimum_should_match")]
	public Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

	/// <summary>
	/// <para>
	/// The clause (query) must appear in matching documents and will contribute to the score.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("must")]
	[SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.QueryDsl.Query))]
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? Must { get; set; }

	/// <summary>
	/// <para>
	/// The clause (query) must not appear in the matching documents.
	/// Because scoring is ignored, a score of <c>0</c> is returned for all documents.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("must_not")]
	[SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.QueryDsl.Query))]
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? MustNot { get; set; }
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	/// <summary>
	/// <para>
	/// The clause (query) should appear in the matching document.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("should")]
	[SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.QueryDsl.Query))]
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? Should { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.QueryDsl.Query(BoolQuery boolQuery) => Elastic.Clients.Elasticsearch.QueryDsl.Query.Bool(boolQuery);
	public static implicit operator Elastic.Clients.Elasticsearch.Security.ApiKeyQuery(BoolQuery boolQuery) => Elastic.Clients.Elasticsearch.Security.ApiKeyQuery.Bool(boolQuery);
	public static implicit operator Elastic.Clients.Elasticsearch.Security.RoleQuery(BoolQuery boolQuery) => Elastic.Clients.Elasticsearch.Security.RoleQuery.Bool(boolQuery);
	public static implicit operator Elastic.Clients.Elasticsearch.Security.UserQuery(BoolQuery boolQuery) => Elastic.Clients.Elasticsearch.Security.UserQuery.Bool(boolQuery);
}

public sealed partial class BoolQueryDescriptor<TDocument> : SerializableDescriptor<BoolQueryDescriptor<TDocument>>
{
	internal BoolQueryDescriptor(Action<BoolQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public BoolQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> FilterDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] FilterDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? MustValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> MustDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> MustDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] MustDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? MustNotValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> MustNotDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> MustNotDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] MustNotDescriptorActions { get; set; }
	private string? QueryNameValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? ShouldValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> ShouldDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> ShouldDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] ShouldDescriptorActions { get; set; }

	/// <summary>
	/// <para>
	/// Floating point number used to decrease or increase the relevance scores of the query.
	/// Boost values are relative to the default value of 1.0.
	/// A boost value between 0 and 1.0 decreases the relevance score.
	/// A value greater than 1.0 increases the relevance score.
	/// </para>
	/// </summary>
	public BoolQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The clause (query) must appear in matching documents.
	/// However, unlike <c>must</c>, the score of the query will be ignored.
	/// </para>
	/// </summary>
	public BoolQueryDescriptor<TDocument> Filter(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Filter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Filter(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Specifies the number or percentage of <c>should</c> clauses returned documents must match.
	/// </para>
	/// </summary>
	public BoolQueryDescriptor<TDocument> MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
	{
		MinimumShouldMatchValue = minimumShouldMatch;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The clause (query) must appear in matching documents and will contribute to the score.
	/// </para>
	/// </summary>
	public BoolQueryDescriptor<TDocument> Must(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? must)
	{
		MustDescriptor = null;
		MustDescriptorAction = null;
		MustDescriptorActions = null;
		MustValue = must;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Must(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		MustValue = null;
		MustDescriptorAction = null;
		MustDescriptorActions = null;
		MustDescriptor = descriptor;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Must(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		MustValue = null;
		MustDescriptor = null;
		MustDescriptorActions = null;
		MustDescriptorAction = configure;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Must(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] configure)
	{
		MustValue = null;
		MustDescriptor = null;
		MustDescriptorAction = null;
		MustDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The clause (query) must not appear in the matching documents.
	/// Because scoring is ignored, a score of <c>0</c> is returned for all documents.
	/// </para>
	/// </summary>
	public BoolQueryDescriptor<TDocument> MustNot(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? mustNot)
	{
		MustNotDescriptor = null;
		MustNotDescriptorAction = null;
		MustNotDescriptorActions = null;
		MustNotValue = mustNot;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> MustNot(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		MustNotValue = null;
		MustNotDescriptorAction = null;
		MustNotDescriptorActions = null;
		MustNotDescriptor = descriptor;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> MustNot(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		MustNotValue = null;
		MustNotDescriptor = null;
		MustNotDescriptorActions = null;
		MustNotDescriptorAction = configure;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> MustNot(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] configure)
	{
		MustNotValue = null;
		MustNotDescriptor = null;
		MustNotDescriptorAction = null;
		MustNotDescriptorActions = configure;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The clause (query) should appear in the matching document.
	/// </para>
	/// </summary>
	public BoolQueryDescriptor<TDocument> Should(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? should)
	{
		ShouldDescriptor = null;
		ShouldDescriptorAction = null;
		ShouldDescriptorActions = null;
		ShouldValue = should;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Should(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		ShouldValue = null;
		ShouldDescriptorAction = null;
		ShouldDescriptorActions = null;
		ShouldDescriptor = descriptor;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Should(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		ShouldValue = null;
		ShouldDescriptor = null;
		ShouldDescriptorActions = null;
		ShouldDescriptorAction = configure;
		return Self;
	}

	public BoolQueryDescriptor<TDocument> Should(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] configure)
	{
		ShouldValue = null;
		ShouldDescriptor = null;
		ShouldDescriptorAction = null;
		ShouldDescriptorActions = configure;
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

		if (MinimumShouldMatchValue is not null)
		{
			writer.WritePropertyName("minimum_should_match");
			JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
		}

		if (MustDescriptor is not null)
		{
			writer.WritePropertyName("must");
			JsonSerializer.Serialize(writer, MustDescriptor, options);
		}
		else if (MustDescriptorAction is not null)
		{
			writer.WritePropertyName("must");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(MustDescriptorAction), options);
		}
		else if (MustDescriptorActions is not null)
		{
			writer.WritePropertyName("must");
			if (MustDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in MustDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(action), options);
			}

			if (MustDescriptorActions.Length != 1)
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
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(MustNotDescriptorAction), options);
		}
		else if (MustNotDescriptorActions is not null)
		{
			writer.WritePropertyName("must_not");
			if (MustNotDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in MustNotDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(action), options);
			}

			if (MustNotDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (MustNotValue is not null)
		{
			writer.WritePropertyName("must_not");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(MustNotValue, writer, options);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (ShouldDescriptor is not null)
		{
			writer.WritePropertyName("should");
			JsonSerializer.Serialize(writer, ShouldDescriptor, options);
		}
		else if (ShouldDescriptorAction is not null)
		{
			writer.WritePropertyName("should");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(ShouldDescriptorAction), options);
		}
		else if (ShouldDescriptorActions is not null)
		{
			writer.WritePropertyName("should");
			if (ShouldDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in ShouldDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(action), options);
			}

			if (ShouldDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (ShouldValue is not null)
		{
			writer.WritePropertyName("should");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(ShouldValue, writer, options);
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

	private float? BoostValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> FilterDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] FilterDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? MustValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor MustDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> MustDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] MustDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? MustNotValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor MustNotDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> MustNotDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] MustNotDescriptorActions { get; set; }
	private string? QueryNameValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? ShouldValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor ShouldDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> ShouldDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] ShouldDescriptorActions { get; set; }

	/// <summary>
	/// <para>
	/// Floating point number used to decrease or increase the relevance scores of the query.
	/// Boost values are relative to the default value of 1.0.
	/// A boost value between 0 and 1.0 decreases the relevance score.
	/// A value greater than 1.0 increases the relevance score.
	/// </para>
	/// </summary>
	public BoolQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The clause (query) must appear in matching documents.
	/// However, unlike <c>must</c>, the score of the query will be ignored.
	/// </para>
	/// </summary>
	public BoolQueryDescriptor Filter(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public BoolQueryDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public BoolQueryDescriptor Filter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public BoolQueryDescriptor Filter(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Specifies the number or percentage of <c>should</c> clauses returned documents must match.
	/// </para>
	/// </summary>
	public BoolQueryDescriptor MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
	{
		MinimumShouldMatchValue = minimumShouldMatch;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The clause (query) must appear in matching documents and will contribute to the score.
	/// </para>
	/// </summary>
	public BoolQueryDescriptor Must(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? must)
	{
		MustDescriptor = null;
		MustDescriptorAction = null;
		MustDescriptorActions = null;
		MustValue = must;
		return Self;
	}

	public BoolQueryDescriptor Must(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor descriptor)
	{
		MustValue = null;
		MustDescriptorAction = null;
		MustDescriptorActions = null;
		MustDescriptor = descriptor;
		return Self;
	}

	public BoolQueryDescriptor Must(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> configure)
	{
		MustValue = null;
		MustDescriptor = null;
		MustDescriptorActions = null;
		MustDescriptorAction = configure;
		return Self;
	}

	public BoolQueryDescriptor Must(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] configure)
	{
		MustValue = null;
		MustDescriptor = null;
		MustDescriptorAction = null;
		MustDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The clause (query) must not appear in the matching documents.
	/// Because scoring is ignored, a score of <c>0</c> is returned for all documents.
	/// </para>
	/// </summary>
	public BoolQueryDescriptor MustNot(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? mustNot)
	{
		MustNotDescriptor = null;
		MustNotDescriptorAction = null;
		MustNotDescriptorActions = null;
		MustNotValue = mustNot;
		return Self;
	}

	public BoolQueryDescriptor MustNot(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor descriptor)
	{
		MustNotValue = null;
		MustNotDescriptorAction = null;
		MustNotDescriptorActions = null;
		MustNotDescriptor = descriptor;
		return Self;
	}

	public BoolQueryDescriptor MustNot(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> configure)
	{
		MustNotValue = null;
		MustNotDescriptor = null;
		MustNotDescriptorActions = null;
		MustNotDescriptorAction = configure;
		return Self;
	}

	public BoolQueryDescriptor MustNot(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] configure)
	{
		MustNotValue = null;
		MustNotDescriptor = null;
		MustNotDescriptorAction = null;
		MustNotDescriptorActions = configure;
		return Self;
	}

	public BoolQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The clause (query) should appear in the matching document.
	/// </para>
	/// </summary>
	public BoolQueryDescriptor Should(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? should)
	{
		ShouldDescriptor = null;
		ShouldDescriptorAction = null;
		ShouldDescriptorActions = null;
		ShouldValue = should;
		return Self;
	}

	public BoolQueryDescriptor Should(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor descriptor)
	{
		ShouldValue = null;
		ShouldDescriptorAction = null;
		ShouldDescriptorActions = null;
		ShouldDescriptor = descriptor;
		return Self;
	}

	public BoolQueryDescriptor Should(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> configure)
	{
		ShouldValue = null;
		ShouldDescriptor = null;
		ShouldDescriptorActions = null;
		ShouldDescriptorAction = configure;
		return Self;
	}

	public BoolQueryDescriptor Should(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] configure)
	{
		ShouldValue = null;
		ShouldDescriptor = null;
		ShouldDescriptorAction = null;
		ShouldDescriptorActions = configure;
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

		if (MinimumShouldMatchValue is not null)
		{
			writer.WritePropertyName("minimum_should_match");
			JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
		}

		if (MustDescriptor is not null)
		{
			writer.WritePropertyName("must");
			JsonSerializer.Serialize(writer, MustDescriptor, options);
		}
		else if (MustDescriptorAction is not null)
		{
			writer.WritePropertyName("must");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(MustDescriptorAction), options);
		}
		else if (MustDescriptorActions is not null)
		{
			writer.WritePropertyName("must");
			if (MustDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in MustDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(action), options);
			}

			if (MustDescriptorActions.Length != 1)
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
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(MustNotDescriptorAction), options);
		}
		else if (MustNotDescriptorActions is not null)
		{
			writer.WritePropertyName("must_not");
			if (MustNotDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in MustNotDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(action), options);
			}

			if (MustNotDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (MustNotValue is not null)
		{
			writer.WritePropertyName("must_not");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(MustNotValue, writer, options);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (ShouldDescriptor is not null)
		{
			writer.WritePropertyName("should");
			JsonSerializer.Serialize(writer, ShouldDescriptor, options);
		}
		else if (ShouldDescriptorAction is not null)
		{
			writer.WritePropertyName("should");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(ShouldDescriptorAction), options);
		}
		else if (ShouldDescriptorActions is not null)
		{
			writer.WritePropertyName("should");
			if (ShouldDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in ShouldDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(action), options);
			}

			if (ShouldDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (ShouldValue is not null)
		{
			writer.WritePropertyName("should");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(ShouldValue, writer, options);
		}

		writer.WriteEndObject();
	}
}