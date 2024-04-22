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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Rollup;

public sealed partial class RollupSearchRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Indicates whether hits.total should be rendered as an integer or an object in the rest search response</para>
	/// </summary>
	public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

	/// <summary>
	/// <para>Specify whether aggregation and suggester names should be prefixed by their respective types in the response</para>
	/// </summary>
	public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }
}

internal sealed partial class RollupSearchRequestConverter : JsonConverter<RollupSearchRequest>
{
	public override RollupSearchRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		var variant = new RollupSearchRequest();
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				var property = reader.GetString();
				if (property == "aggregations" || property == "aggs")
				{
					variant.Aggregations = JsonSerializer.Deserialize<IDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.Aggregation>?>(ref reader, options);
					continue;
				}

				if (property == "query")
				{
					variant.Query = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.Query?>(ref reader, options);
					continue;
				}

				if (property == "size")
				{
					variant.Size = JsonSerializer.Deserialize<int?>(ref reader, options);
					continue;
				}
			}
		}

		return variant;
	}

	public override void Write(Utf8JsonWriter writer, RollupSearchRequest value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (value.Aggregations is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, value.Aggregations, options);
		}

		if (value.Query is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, value.Query, options);
		}

		if (value.Size.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(value.Size.Value);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Enables searching rolled-up data using the standard Query DSL.</para>
/// </summary>
[JsonConverter(typeof(RollupSearchRequestConverter))]
public sealed partial class RollupSearchRequest : PlainRequest<RollupSearchRequestParameters>
{
	public RollupSearchRequest(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	public RollupSearchRequest()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.RollupRollupSearch;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "rollup.rollup_search";

	/// <summary>
	/// <para>Indicates whether hits.total should be rendered as an integer or an object in the rest search response</para>
	/// </summary>
	[JsonIgnore]
	public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

	/// <summary>
	/// <para>Specify whether aggregation and suggester names should be prefixed by their respective types in the response</para>
	/// </summary>
	[JsonIgnore]
	public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }

	/// <summary>
	/// <para>Specifies aggregations.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("aggregations")]
	public IDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.Aggregation>? Aggregations { get; set; }

	/// <summary>
	/// <para>Specifies a DSL query.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Query? Query { get; set; }

	/// <summary>
	/// <para>Must be zero if set, as rollups work on pre-aggregated data.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("size")]
	public int? Size { get; set; }
}

/// <summary>
/// <para>Enables searching rolled-up data using the standard Query DSL.</para>
/// </summary>
public sealed partial class RollupSearchRequestDescriptor<TDocument> : RequestDescriptor<RollupSearchRequestDescriptor<TDocument>, RollupSearchRequestParameters>
{
	internal RollupSearchRequestDescriptor(Action<RollupSearchRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public RollupSearchRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	public RollupSearchRequestDescriptor() : this(typeof(TDocument))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.RollupRollupSearch;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "rollup.rollup_search";

	public RollupSearchRequestDescriptor<TDocument> RestTotalHitsAsInt(bool? restTotalHitsAsInt = true) => Qs("rest_total_hits_as_int", restTotalHitsAsInt);
	public RollupSearchRequestDescriptor<TDocument> TypedKeys(bool? typedKeys = true) => Qs("typed_keys", typedKeys);

	public RollupSearchRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	private IDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument>> AggregationsValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Query? QueryValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> QueryDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> QueryDescriptorAction { get; set; }
	private int? SizeValue { get; set; }

	/// <summary>
	/// <para>Specifies aggregations.</para>
	/// </summary>
	public RollupSearchRequestDescriptor<TDocument> Aggregations(Func<FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument>>, FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument>>> selector)
	{
		AggregationsValue = selector?.Invoke(new FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor<TDocument>>());
		return Self;
	}

	/// <summary>
	/// <para>Specifies a DSL query.</para>
	/// </summary>
	public RollupSearchRequestDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.Query? query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public RollupSearchRequestDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public RollupSearchRequestDescriptor<TDocument> Query(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Must be zero if set, as rollups work on pre-aggregated data.</para>
	/// </summary>
	public RollupSearchRequestDescriptor<TDocument> Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AggregationsValue is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, AggregationsValue, options);
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

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Enables searching rolled-up data using the standard Query DSL.</para>
/// </summary>
public sealed partial class RollupSearchRequestDescriptor : RequestDescriptor<RollupSearchRequestDescriptor, RollupSearchRequestParameters>
{
	internal RollupSearchRequestDescriptor(Action<RollupSearchRequestDescriptor> configure) => configure.Invoke(this);

	public RollupSearchRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.RollupRollupSearch;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "rollup.rollup_search";

	public RollupSearchRequestDescriptor RestTotalHitsAsInt(bool? restTotalHitsAsInt = true) => Qs("rest_total_hits_as_int", restTotalHitsAsInt);
	public RollupSearchRequestDescriptor TypedKeys(bool? typedKeys = true) => Qs("typed_keys", typedKeys);

	public RollupSearchRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	private IDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor> AggregationsValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Query? QueryValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor QueryDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> QueryDescriptorAction { get; set; }
	private int? SizeValue { get; set; }

	/// <summary>
	/// <para>Specifies aggregations.</para>
	/// </summary>
	public RollupSearchRequestDescriptor Aggregations(Func<FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor>, FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor>> selector)
	{
		AggregationsValue = selector?.Invoke(new FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationDescriptor>());
		return Self;
	}

	/// <summary>
	/// <para>Specifies a DSL query.</para>
	/// </summary>
	public RollupSearchRequestDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.Query? query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public RollupSearchRequestDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public RollupSearchRequestDescriptor Query(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Must be zero if set, as rollups work on pre-aggregated data.</para>
	/// </summary>
	public RollupSearchRequestDescriptor Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AggregationsValue is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, AggregationsValue, options);
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

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		writer.WriteEndObject();
	}
}