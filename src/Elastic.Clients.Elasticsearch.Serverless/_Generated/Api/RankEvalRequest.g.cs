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
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless;

public sealed partial class RankEvalRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If `false`, the request returns an error if any wildcard expression, index alias, or `_all` value targets only missing or closed indices. This behavior applies even if the request targets other open indices. For example, a request targeting `foo*,bar*` returns an error if an index starts with `foo` but no index starts with `bar`.</para>
	/// </summary>
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>Whether to expand wildcard expression to concrete indices that are open, closed or both.</para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>If `true`, missing or closed indices are not included in the response.</para>
	/// </summary>
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>Search operation type</para>
	/// </summary>
	public string? SearchType { get => Q<string?>("search_type"); set => Q("search_type", value); }
}

/// <summary>
/// <para>Enables you to evaluate the quality of ranked search results over a set of typical search queries.</para>
/// </summary>
public sealed partial class RankEvalRequest : PlainRequest<RankEvalRequestParameters>
{
	public RankEvalRequest()
	{
	}

	public RankEvalRequest(Elastic.Clients.Elasticsearch.Serverless.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceRankEval;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "rank_eval";

	/// <summary>
	/// <para>If `false`, the request returns an error if any wildcard expression, index alias, or `_all` value targets only missing or closed indices. This behavior applies even if the request targets other open indices. For example, a request targeting `foo*,bar*` returns an error if an index starts with `foo` but no index starts with `bar`.</para>
	/// </summary>
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>Whether to expand wildcard expression to concrete indices that are open, closed or both.</para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>If `true`, missing or closed indices are not included in the response.</para>
	/// </summary>
	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>Search operation type</para>
	/// </summary>
	[JsonIgnore]
	public string? SearchType { get => Q<string?>("search_type"); set => Q("search_type", value); }

	/// <summary>
	/// <para>Definition of the evaluation metric to calculate.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("metric")]
	public Elastic.Clients.Elasticsearch.Serverless.Core.RankEval.RankEvalMetric? Metric { get; set; }

	/// <summary>
	/// <para>A set of typical search requests, together with their provided ratings.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("requests")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Core.RankEval.RankEvalRequestItem> Requests { get; set; }
}

/// <summary>
/// <para>Enables you to evaluate the quality of ranked search results over a set of typical search queries.</para>
/// </summary>
public sealed partial class RankEvalRequestDescriptor<TDocument> : RequestDescriptor<RankEvalRequestDescriptor<TDocument>, RankEvalRequestParameters>
{
	internal RankEvalRequestDescriptor(Action<RankEvalRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public RankEvalRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceRankEval;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "rank_eval";

	public RankEvalRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public RankEvalRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public RankEvalRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public RankEvalRequestDescriptor<TDocument> SearchType(string? searchType) => Qs("search_type", searchType);

	public RankEvalRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Serverless.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Serverless.Core.RankEval.RankEvalMetric? MetricValue { get; set; }
	private Core.RankEval.RankEvalMetricDescriptor MetricDescriptor { get; set; }
	private Action<Core.RankEval.RankEvalMetricDescriptor> MetricDescriptorAction { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Core.RankEval.RankEvalRequestItem> RequestsValue { get; set; }
	private Core.RankEval.RankEvalRequestItemDescriptor<TDocument> RequestsDescriptor { get; set; }
	private Action<Core.RankEval.RankEvalRequestItemDescriptor<TDocument>> RequestsDescriptorAction { get; set; }
	private Action<Core.RankEval.RankEvalRequestItemDescriptor<TDocument>>[] RequestsDescriptorActions { get; set; }

	/// <summary>
	/// <para>Definition of the evaluation metric to calculate.</para>
	/// </summary>
	public RankEvalRequestDescriptor<TDocument> Metric(Elastic.Clients.Elasticsearch.Serverless.Core.RankEval.RankEvalMetric? metric)
	{
		MetricDescriptor = null;
		MetricDescriptorAction = null;
		MetricValue = metric;
		return Self;
	}

	public RankEvalRequestDescriptor<TDocument> Metric(Core.RankEval.RankEvalMetricDescriptor descriptor)
	{
		MetricValue = null;
		MetricDescriptorAction = null;
		MetricDescriptor = descriptor;
		return Self;
	}

	public RankEvalRequestDescriptor<TDocument> Metric(Action<Core.RankEval.RankEvalMetricDescriptor> configure)
	{
		MetricValue = null;
		MetricDescriptor = null;
		MetricDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>A set of typical search requests, together with their provided ratings.</para>
	/// </summary>
	public RankEvalRequestDescriptor<TDocument> Requests(ICollection<Elastic.Clients.Elasticsearch.Serverless.Core.RankEval.RankEvalRequestItem> requests)
	{
		RequestsDescriptor = null;
		RequestsDescriptorAction = null;
		RequestsDescriptorActions = null;
		RequestsValue = requests;
		return Self;
	}

	public RankEvalRequestDescriptor<TDocument> Requests(Core.RankEval.RankEvalRequestItemDescriptor<TDocument> descriptor)
	{
		RequestsValue = null;
		RequestsDescriptorAction = null;
		RequestsDescriptorActions = null;
		RequestsDescriptor = descriptor;
		return Self;
	}

	public RankEvalRequestDescriptor<TDocument> Requests(Action<Core.RankEval.RankEvalRequestItemDescriptor<TDocument>> configure)
	{
		RequestsValue = null;
		RequestsDescriptor = null;
		RequestsDescriptorActions = null;
		RequestsDescriptorAction = configure;
		return Self;
	}

	public RankEvalRequestDescriptor<TDocument> Requests(params Action<Core.RankEval.RankEvalRequestItemDescriptor<TDocument>>[] configure)
	{
		RequestsValue = null;
		RequestsDescriptor = null;
		RequestsDescriptorAction = null;
		RequestsDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (MetricDescriptor is not null)
		{
			writer.WritePropertyName("metric");
			JsonSerializer.Serialize(writer, MetricDescriptor, options);
		}
		else if (MetricDescriptorAction is not null)
		{
			writer.WritePropertyName("metric");
			JsonSerializer.Serialize(writer, new Core.RankEval.RankEvalMetricDescriptor(MetricDescriptorAction), options);
		}
		else if (MetricValue is not null)
		{
			writer.WritePropertyName("metric");
			JsonSerializer.Serialize(writer, MetricValue, options);
		}

		if (RequestsDescriptor is not null)
		{
			writer.WritePropertyName("requests");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, RequestsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (RequestsDescriptorAction is not null)
		{
			writer.WritePropertyName("requests");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Core.RankEval.RankEvalRequestItemDescriptor<TDocument>(RequestsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (RequestsDescriptorActions is not null)
		{
			writer.WritePropertyName("requests");
			writer.WriteStartArray();
			foreach (var action in RequestsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Core.RankEval.RankEvalRequestItemDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else
		{
			writer.WritePropertyName("requests");
			JsonSerializer.Serialize(writer, RequestsValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Enables you to evaluate the quality of ranked search results over a set of typical search queries.</para>
/// </summary>
public sealed partial class RankEvalRequestDescriptor : RequestDescriptor<RankEvalRequestDescriptor, RankEvalRequestParameters>
{
	internal RankEvalRequestDescriptor(Action<RankEvalRequestDescriptor> configure) => configure.Invoke(this);

	public RankEvalRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceRankEval;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "rank_eval";

	public RankEvalRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public RankEvalRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public RankEvalRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public RankEvalRequestDescriptor SearchType(string? searchType) => Qs("search_type", searchType);

	public RankEvalRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Serverless.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Serverless.Core.RankEval.RankEvalMetric? MetricValue { get; set; }
	private Core.RankEval.RankEvalMetricDescriptor MetricDescriptor { get; set; }
	private Action<Core.RankEval.RankEvalMetricDescriptor> MetricDescriptorAction { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Core.RankEval.RankEvalRequestItem> RequestsValue { get; set; }
	private Core.RankEval.RankEvalRequestItemDescriptor RequestsDescriptor { get; set; }
	private Action<Core.RankEval.RankEvalRequestItemDescriptor> RequestsDescriptorAction { get; set; }
	private Action<Core.RankEval.RankEvalRequestItemDescriptor>[] RequestsDescriptorActions { get; set; }

	/// <summary>
	/// <para>Definition of the evaluation metric to calculate.</para>
	/// </summary>
	public RankEvalRequestDescriptor Metric(Elastic.Clients.Elasticsearch.Serverless.Core.RankEval.RankEvalMetric? metric)
	{
		MetricDescriptor = null;
		MetricDescriptorAction = null;
		MetricValue = metric;
		return Self;
	}

	public RankEvalRequestDescriptor Metric(Core.RankEval.RankEvalMetricDescriptor descriptor)
	{
		MetricValue = null;
		MetricDescriptorAction = null;
		MetricDescriptor = descriptor;
		return Self;
	}

	public RankEvalRequestDescriptor Metric(Action<Core.RankEval.RankEvalMetricDescriptor> configure)
	{
		MetricValue = null;
		MetricDescriptor = null;
		MetricDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>A set of typical search requests, together with their provided ratings.</para>
	/// </summary>
	public RankEvalRequestDescriptor Requests(ICollection<Elastic.Clients.Elasticsearch.Serverless.Core.RankEval.RankEvalRequestItem> requests)
	{
		RequestsDescriptor = null;
		RequestsDescriptorAction = null;
		RequestsDescriptorActions = null;
		RequestsValue = requests;
		return Self;
	}

	public RankEvalRequestDescriptor Requests(Core.RankEval.RankEvalRequestItemDescriptor descriptor)
	{
		RequestsValue = null;
		RequestsDescriptorAction = null;
		RequestsDescriptorActions = null;
		RequestsDescriptor = descriptor;
		return Self;
	}

	public RankEvalRequestDescriptor Requests(Action<Core.RankEval.RankEvalRequestItemDescriptor> configure)
	{
		RequestsValue = null;
		RequestsDescriptor = null;
		RequestsDescriptorActions = null;
		RequestsDescriptorAction = configure;
		return Self;
	}

	public RankEvalRequestDescriptor Requests(params Action<Core.RankEval.RankEvalRequestItemDescriptor>[] configure)
	{
		RequestsValue = null;
		RequestsDescriptor = null;
		RequestsDescriptorAction = null;
		RequestsDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (MetricDescriptor is not null)
		{
			writer.WritePropertyName("metric");
			JsonSerializer.Serialize(writer, MetricDescriptor, options);
		}
		else if (MetricDescriptorAction is not null)
		{
			writer.WritePropertyName("metric");
			JsonSerializer.Serialize(writer, new Core.RankEval.RankEvalMetricDescriptor(MetricDescriptorAction), options);
		}
		else if (MetricValue is not null)
		{
			writer.WritePropertyName("metric");
			JsonSerializer.Serialize(writer, MetricValue, options);
		}

		if (RequestsDescriptor is not null)
		{
			writer.WritePropertyName("requests");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, RequestsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (RequestsDescriptorAction is not null)
		{
			writer.WritePropertyName("requests");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Core.RankEval.RankEvalRequestItemDescriptor(RequestsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (RequestsDescriptorActions is not null)
		{
			writer.WritePropertyName("requests");
			writer.WriteStartArray();
			foreach (var action in RequestsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Core.RankEval.RankEvalRequestItemDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else
		{
			writer.WritePropertyName("requests");
			JsonSerializer.Serialize(writer, RequestsValue, options);
		}

		writer.WriteEndObject();
	}
}