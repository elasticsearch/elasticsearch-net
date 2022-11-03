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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl;
public sealed partial class FunctionScoreQuery : Query
{
	[JsonInclude]
	[JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	[JsonInclude]
	[JsonPropertyName("boost")]
	public float? Boost { get; set; }

	[JsonInclude]
	[JsonPropertyName("boost_mode")]
	public Elastic.Clients.Elasticsearch.QueryDsl.FunctionBoostMode? BoostMode { get; set; }

	[JsonInclude]
	[JsonPropertyName("functions")]
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.FunctionScoreContainer>? Functions { get; set; }

	[JsonInclude]
	[JsonPropertyName("max_boost")]
	public double? MaxBoost { get; set; }

	[JsonInclude]
	[JsonPropertyName("min_score")]
	public double? MinScore { get; set; }

	[JsonInclude]
	[JsonPropertyName("query")]
	public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Query { get; set; }

	[JsonInclude]
	[JsonPropertyName("score_mode")]
	public Elastic.Clients.Elasticsearch.QueryDsl.FunctionScoreMode? ScoreMode { get; set; }

	public static implicit operator QueryContainer(FunctionScoreQuery functionScoreQuery) => QueryContainer.FunctionScore(functionScoreQuery);
}

public sealed partial class FunctionScoreQueryDescriptor<TDocument> : SerializableDescriptor<FunctionScoreQueryDescriptor<TDocument>>
{
	internal FunctionScoreQueryDescriptor(Action<FunctionScoreQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
	public FunctionScoreQueryDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.FunctionScoreContainer>? FunctionsValue { get; set; }

	private FunctionScoreContainerDescriptor<TDocument> FunctionsDescriptor { get; set; }

	private Action<FunctionScoreContainerDescriptor<TDocument>> FunctionsDescriptorAction { get; set; }

	private Action<FunctionScoreContainerDescriptor<TDocument>>[] FunctionsDescriptorActions { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? QueryValue { get; set; }

	private QueryContainerDescriptor<TDocument> QueryDescriptor { get; set; }

	private Action<QueryContainerDescriptor<TDocument>> QueryDescriptorAction { get; set; }

	private string? QueryNameValue { get; set; }

	private float? BoostValue { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.FunctionBoostMode? BoostModeValue { get; set; }

	private double? MaxBoostValue { get; set; }

	private double? MinScoreValue { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.FunctionScoreMode? ScoreModeValue { get; set; }

	public FunctionScoreQueryDescriptor<TDocument> Functions(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.FunctionScoreContainer>? functions)
	{
		FunctionsDescriptor = null;
		FunctionsDescriptorAction = null;
		FunctionsDescriptorActions = null;
		FunctionsValue = functions;
		return Self;
	}

	public FunctionScoreQueryDescriptor<TDocument> Functions(FunctionScoreContainerDescriptor<TDocument> descriptor)
	{
		FunctionsValue = null;
		FunctionsDescriptorAction = null;
		FunctionsDescriptorActions = null;
		FunctionsDescriptor = descriptor;
		return Self;
	}

	public FunctionScoreQueryDescriptor<TDocument> Functions(Action<FunctionScoreContainerDescriptor<TDocument>> configure)
	{
		FunctionsValue = null;
		FunctionsDescriptor = null;
		FunctionsDescriptorActions = null;
		FunctionsDescriptorAction = configure;
		return Self;
	}

	public FunctionScoreQueryDescriptor<TDocument> Functions(params Action<FunctionScoreContainerDescriptor<TDocument>>[] configure)
	{
		FunctionsValue = null;
		FunctionsDescriptor = null;
		FunctionsDescriptorAction = null;
		FunctionsDescriptorActions = configure;
		return Self;
	}

	public FunctionScoreQueryDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public FunctionScoreQueryDescriptor<TDocument> Query(QueryContainerDescriptor<TDocument> descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public FunctionScoreQueryDescriptor<TDocument> Query(Action<QueryContainerDescriptor<TDocument>> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	public FunctionScoreQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public FunctionScoreQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public FunctionScoreQueryDescriptor<TDocument> BoostMode(Elastic.Clients.Elasticsearch.QueryDsl.FunctionBoostMode? boostMode)
	{
		BoostModeValue = boostMode;
		return Self;
	}

	public FunctionScoreQueryDescriptor<TDocument> MaxBoost(double? maxBoost)
	{
		MaxBoostValue = maxBoost;
		return Self;
	}

	public FunctionScoreQueryDescriptor<TDocument> MinScore(double? minScore)
	{
		MinScoreValue = minScore;
		return Self;
	}

	public FunctionScoreQueryDescriptor<TDocument> ScoreMode(Elastic.Clients.Elasticsearch.QueryDsl.FunctionScoreMode? scoreMode)
	{
		ScoreModeValue = scoreMode;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FunctionsDescriptor is not null)
		{
			writer.WritePropertyName("functions");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, FunctionsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (FunctionsDescriptorAction is not null)
		{
			writer.WritePropertyName("functions");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new FunctionScoreContainerDescriptor<TDocument>(FunctionsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (FunctionsDescriptorActions is not null)
		{
			writer.WritePropertyName("functions");
			writer.WriteStartArray();
			foreach (var action in FunctionsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new FunctionScoreContainerDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (FunctionsValue is not null)
		{
			writer.WritePropertyName("functions");
			JsonSerializer.Serialize(writer, FunctionsValue, options);
		}

		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new QueryContainerDescriptor<TDocument>(QueryDescriptorAction), options);
		}
		else if (QueryValue is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
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

		if (BoostModeValue is not null)
		{
			writer.WritePropertyName("boost_mode");
			JsonSerializer.Serialize(writer, BoostModeValue, options);
		}

		if (MaxBoostValue.HasValue)
		{
			writer.WritePropertyName("max_boost");
			writer.WriteNumberValue(MaxBoostValue.Value);
		}

		if (MinScoreValue.HasValue)
		{
			writer.WritePropertyName("min_score");
			writer.WriteNumberValue(MinScoreValue.Value);
		}

		if (ScoreModeValue is not null)
		{
			writer.WritePropertyName("score_mode");
			JsonSerializer.Serialize(writer, ScoreModeValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class FunctionScoreQueryDescriptor : SerializableDescriptor<FunctionScoreQueryDescriptor>
{
	internal FunctionScoreQueryDescriptor(Action<FunctionScoreQueryDescriptor> configure) => configure.Invoke(this);
	public FunctionScoreQueryDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.FunctionScoreContainer>? FunctionsValue { get; set; }

	private FunctionScoreContainerDescriptor FunctionsDescriptor { get; set; }

	private Action<FunctionScoreContainerDescriptor> FunctionsDescriptorAction { get; set; }

	private Action<FunctionScoreContainerDescriptor>[] FunctionsDescriptorActions { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? QueryValue { get; set; }

	private QueryContainerDescriptor QueryDescriptor { get; set; }

	private Action<QueryContainerDescriptor> QueryDescriptorAction { get; set; }

	private string? QueryNameValue { get; set; }

	private float? BoostValue { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.FunctionBoostMode? BoostModeValue { get; set; }

	private double? MaxBoostValue { get; set; }

	private double? MinScoreValue { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.FunctionScoreMode? ScoreModeValue { get; set; }

	public FunctionScoreQueryDescriptor Functions(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.FunctionScoreContainer>? functions)
	{
		FunctionsDescriptor = null;
		FunctionsDescriptorAction = null;
		FunctionsDescriptorActions = null;
		FunctionsValue = functions;
		return Self;
	}

	public FunctionScoreQueryDescriptor Functions(FunctionScoreContainerDescriptor descriptor)
	{
		FunctionsValue = null;
		FunctionsDescriptorAction = null;
		FunctionsDescriptorActions = null;
		FunctionsDescriptor = descriptor;
		return Self;
	}

	public FunctionScoreQueryDescriptor Functions(Action<FunctionScoreContainerDescriptor> configure)
	{
		FunctionsValue = null;
		FunctionsDescriptor = null;
		FunctionsDescriptorActions = null;
		FunctionsDescriptorAction = configure;
		return Self;
	}

	public FunctionScoreQueryDescriptor Functions(params Action<FunctionScoreContainerDescriptor>[] configure)
	{
		FunctionsValue = null;
		FunctionsDescriptor = null;
		FunctionsDescriptorAction = null;
		FunctionsDescriptorActions = configure;
		return Self;
	}

	public FunctionScoreQueryDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public FunctionScoreQueryDescriptor Query(QueryContainerDescriptor descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public FunctionScoreQueryDescriptor Query(Action<QueryContainerDescriptor> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	public FunctionScoreQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public FunctionScoreQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public FunctionScoreQueryDescriptor BoostMode(Elastic.Clients.Elasticsearch.QueryDsl.FunctionBoostMode? boostMode)
	{
		BoostModeValue = boostMode;
		return Self;
	}

	public FunctionScoreQueryDescriptor MaxBoost(double? maxBoost)
	{
		MaxBoostValue = maxBoost;
		return Self;
	}

	public FunctionScoreQueryDescriptor MinScore(double? minScore)
	{
		MinScoreValue = minScore;
		return Self;
	}

	public FunctionScoreQueryDescriptor ScoreMode(Elastic.Clients.Elasticsearch.QueryDsl.FunctionScoreMode? scoreMode)
	{
		ScoreModeValue = scoreMode;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FunctionsDescriptor is not null)
		{
			writer.WritePropertyName("functions");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, FunctionsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (FunctionsDescriptorAction is not null)
		{
			writer.WritePropertyName("functions");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new FunctionScoreContainerDescriptor(FunctionsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (FunctionsDescriptorActions is not null)
		{
			writer.WritePropertyName("functions");
			writer.WriteStartArray();
			foreach (var action in FunctionsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new FunctionScoreContainerDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (FunctionsValue is not null)
		{
			writer.WritePropertyName("functions");
			JsonSerializer.Serialize(writer, FunctionsValue, options);
		}

		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new QueryContainerDescriptor(QueryDescriptorAction), options);
		}
		else if (QueryValue is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
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

		if (BoostModeValue is not null)
		{
			writer.WritePropertyName("boost_mode");
			JsonSerializer.Serialize(writer, BoostModeValue, options);
		}

		if (MaxBoostValue.HasValue)
		{
			writer.WritePropertyName("max_boost");
			writer.WriteNumberValue(MaxBoostValue.Value);
		}

		if (MinScoreValue.HasValue)
		{
			writer.WritePropertyName("min_score");
			writer.WriteNumberValue(MinScoreValue.Value);
		}

		if (ScoreModeValue is not null)
		{
			writer.WritePropertyName("score_mode");
			JsonSerializer.Serialize(writer, ScoreModeValue, options);
		}

		writer.WriteEndObject();
	}
}