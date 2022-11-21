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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch;
public sealed class DeleteByQueryRequestParameters : RequestParameters
{
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	[JsonIgnore]
	public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

	[JsonIgnore]
	public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Conflicts? Conflicts { get => Q<Elastic.Clients.Elasticsearch.Conflicts?>("conflicts"); set => Q("conflicts", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperator { get => Q<Elastic.Clients.Elasticsearch.QueryDsl.Operator?>("default_operator"); set => Q("default_operator", value); }

	[JsonIgnore]
	public string? Df { get => Q<string?>("df"); set => Q("df", value); }

	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public long? From { get => Q<long?>("from"); set => Q("from", value); }

	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	[JsonIgnore]
	public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

	[JsonIgnore]
	public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

	[JsonIgnore]
	public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

	[JsonIgnore]
	public bool? RequestCache { get => Q<bool?>("request_cache"); set => Q("request_cache", value); }

	[JsonIgnore]
	public float? RequestsPerSecond { get => Q<float?>("requests_per_second"); set => Q("requests_per_second", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	[JsonIgnore]
	public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Scroll { get => Q<Elastic.Clients.Elasticsearch.Duration?>("scroll"); set => Q("scroll", value); }

	[JsonIgnore]
	public long? ScrollSize { get => Q<long?>("scroll_size"); set => Q("scroll_size", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? SearchTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("search_timeout"); set => Q("search_timeout", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.SearchType? SearchType { get => Q<Elastic.Clients.Elasticsearch.SearchType?>("search_type"); set => Q("search_type", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Slices? Slices { get => Q<Elastic.Clients.Elasticsearch.Slices?>("slices"); set => Q("slices", value); }

	[JsonIgnore]
	public ICollection<string>? Sort { get => Q<ICollection<string>?>("sort"); set => Q("sort", value); }

	[JsonIgnore]
	public ICollection<string>? Stats { get => Q<ICollection<string>?>("stats"); set => Q("stats", value); }

	[JsonIgnore]
	public long? TerminateAfter { get => Q<long?>("terminate_after"); set => Q("terminate_after", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	[JsonIgnore]
	public bool? Version { get => Q<bool?>("version"); set => Q("version", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

	[JsonIgnore]
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
}

public sealed partial class DeleteByQueryRequest : PlainRequest<DeleteByQueryRequestParameters>
{
	public DeleteByQueryRequest(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceDeleteByQuery;
	internal override HttpMethod HttpMethod => HttpMethod.POST;
	internal override bool SupportsBody => true;
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	[JsonIgnore]
	public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

	[JsonIgnore]
	public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Conflicts? Conflicts { get => Q<Elastic.Clients.Elasticsearch.Conflicts?>("conflicts"); set => Q("conflicts", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperator { get => Q<Elastic.Clients.Elasticsearch.QueryDsl.Operator?>("default_operator"); set => Q("default_operator", value); }

	[JsonIgnore]
	public string? Df { get => Q<string?>("df"); set => Q("df", value); }

	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public long? From { get => Q<long?>("from"); set => Q("from", value); }

	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	[JsonIgnore]
	public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

	[JsonIgnore]
	public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

	[JsonIgnore]
	public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

	[JsonIgnore]
	public bool? RequestCache { get => Q<bool?>("request_cache"); set => Q("request_cache", value); }

	[JsonIgnore]
	public float? RequestsPerSecond { get => Q<float?>("requests_per_second"); set => Q("requests_per_second", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	[JsonIgnore]
	public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Scroll { get => Q<Elastic.Clients.Elasticsearch.Duration?>("scroll"); set => Q("scroll", value); }

	[JsonIgnore]
	public long? ScrollSize { get => Q<long?>("scroll_size"); set => Q("scroll_size", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? SearchTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("search_timeout"); set => Q("search_timeout", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.SearchType? SearchType { get => Q<Elastic.Clients.Elasticsearch.SearchType?>("search_type"); set => Q("search_type", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Slices? Slices { get => Q<Elastic.Clients.Elasticsearch.Slices?>("slices"); set => Q("slices", value); }

	[JsonIgnore]
	public ICollection<string>? Sort { get => Q<ICollection<string>?>("sort"); set => Q("sort", value); }

	[JsonIgnore]
	public ICollection<string>? Stats { get => Q<ICollection<string>?>("stats"); set => Q("stats", value); }

	[JsonIgnore]
	public long? TerminateAfter { get => Q<long?>("terminate_after"); set => Q("terminate_after", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }

	[JsonIgnore]
	public bool? Version { get => Q<bool?>("version"); set => Q("version", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

	[JsonIgnore]
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }

	[JsonInclude]
	[JsonPropertyName("max_docs")]
	public long? MaxDocs { get; set; }

	[JsonInclude]
	[JsonPropertyName("query")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Query? Query { get; set; }

	[JsonInclude]
	[JsonPropertyName("slice")]
	public Elastic.Clients.Elasticsearch.SlicedScroll? Slice { get; set; }
}

public sealed partial class DeleteByQueryRequestDescriptor<TDocument> : RequestDescriptor<DeleteByQueryRequestDescriptor<TDocument>, DeleteByQueryRequestParameters>
{
	internal DeleteByQueryRequestDescriptor(Action<DeleteByQueryRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public DeleteByQueryRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal DeleteByQueryRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceDeleteByQuery;
	internal override HttpMethod HttpMethod => HttpMethod.POST;
	internal override bool SupportsBody => true;
	public DeleteByQueryRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public DeleteByQueryRequestDescriptor<TDocument> AnalyzeWildcard(bool? analyzeWildcard = true) => Qs("analyze_wildcard", analyzeWildcard);
	public DeleteByQueryRequestDescriptor<TDocument> Analyzer(string? analyzer) => Qs("analyzer", analyzer);
	public DeleteByQueryRequestDescriptor<TDocument> Conflicts(Elastic.Clients.Elasticsearch.Conflicts? conflicts) => Qs("conflicts", conflicts);
	public DeleteByQueryRequestDescriptor<TDocument> DefaultOperator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? defaultOperator) => Qs("default_operator", defaultOperator);
	public DeleteByQueryRequestDescriptor<TDocument> Df(string? df) => Qs("df", df);
	public DeleteByQueryRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public DeleteByQueryRequestDescriptor<TDocument> From(long? from) => Qs("from", from);
	public DeleteByQueryRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public DeleteByQueryRequestDescriptor<TDocument> Lenient(bool? lenient = true) => Qs("lenient", lenient);
	public DeleteByQueryRequestDescriptor<TDocument> Preference(string? preference) => Qs("preference", preference);
	public DeleteByQueryRequestDescriptor<TDocument> QueryLuceneSyntax(string? q) => Qs("q", q);
	public DeleteByQueryRequestDescriptor<TDocument> Refresh(bool? refresh = true) => Qs("refresh", refresh);
	public DeleteByQueryRequestDescriptor<TDocument> RequestCache(bool? requestCache = true) => Qs("request_cache", requestCache);
	public DeleteByQueryRequestDescriptor<TDocument> RequestsPerSecond(float? requestsPerSecond) => Qs("requests_per_second", requestsPerSecond);
	public DeleteByQueryRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public DeleteByQueryRequestDescriptor<TDocument> Scroll(Elastic.Clients.Elasticsearch.Duration? scroll) => Qs("scroll", scroll);
	public DeleteByQueryRequestDescriptor<TDocument> ScrollSize(long? scrollSize) => Qs("scroll_size", scrollSize);
	public DeleteByQueryRequestDescriptor<TDocument> SearchTimeout(Elastic.Clients.Elasticsearch.Duration? searchTimeout) => Qs("search_timeout", searchTimeout);
	public DeleteByQueryRequestDescriptor<TDocument> SearchType(Elastic.Clients.Elasticsearch.SearchType? searchType) => Qs("search_type", searchType);
	public DeleteByQueryRequestDescriptor<TDocument> Slices(Elastic.Clients.Elasticsearch.Slices? slices) => Qs("slices", slices);
	public DeleteByQueryRequestDescriptor<TDocument> Sort(ICollection<string>? sort) => Qs("sort", sort);
	public DeleteByQueryRequestDescriptor<TDocument> Stats(ICollection<string>? stats) => Qs("stats", stats);
	public DeleteByQueryRequestDescriptor<TDocument> TerminateAfter(long? terminateAfter) => Qs("terminate_after", terminateAfter);
	public DeleteByQueryRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public DeleteByQueryRequestDescriptor<TDocument> Version(bool? version = true) => Qs("version", version);
	public DeleteByQueryRequestDescriptor<TDocument> WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
	public DeleteByQueryRequestDescriptor<TDocument> WaitForCompletion(bool? waitForCompletion = true) => Qs("wait_for_completion", waitForCompletion);
	public DeleteByQueryRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.Query? QueryValue { get; set; }

	private QueryDsl.QueryDescriptor<TDocument> QueryDescriptor { get; set; }

	private Action<QueryDsl.QueryDescriptor<TDocument>> QueryDescriptorAction { get; set; }

	private Elastic.Clients.Elasticsearch.SlicedScroll? SliceValue { get; set; }

	private SlicedScrollDescriptor<TDocument> SliceDescriptor { get; set; }

	private Action<SlicedScrollDescriptor<TDocument>> SliceDescriptorAction { get; set; }

	private long? MaxDocsValue { get; set; }

	public DeleteByQueryRequestDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.Query? query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public DeleteByQueryRequestDescriptor<TDocument> Query(QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public DeleteByQueryRequestDescriptor<TDocument> Query(Action<QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	public DeleteByQueryRequestDescriptor<TDocument> Slice(Elastic.Clients.Elasticsearch.SlicedScroll? slice)
	{
		SliceDescriptor = null;
		SliceDescriptorAction = null;
		SliceValue = slice;
		return Self;
	}

	public DeleteByQueryRequestDescriptor<TDocument> Slice(SlicedScrollDescriptor<TDocument> descriptor)
	{
		SliceValue = null;
		SliceDescriptorAction = null;
		SliceDescriptor = descriptor;
		return Self;
	}

	public DeleteByQueryRequestDescriptor<TDocument> Slice(Action<SlicedScrollDescriptor<TDocument>> configure)
	{
		SliceValue = null;
		SliceDescriptor = null;
		SliceDescriptorAction = configure;
		return Self;
	}

	public DeleteByQueryRequestDescriptor<TDocument> MaxDocs(long? maxDocs)
	{
		MaxDocsValue = maxDocs;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new QueryDsl.QueryDescriptor<TDocument>(QueryDescriptorAction), options);
		}
		else if (QueryValue is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (SliceDescriptor is not null)
		{
			writer.WritePropertyName("slice");
			JsonSerializer.Serialize(writer, SliceDescriptor, options);
		}
		else if (SliceDescriptorAction is not null)
		{
			writer.WritePropertyName("slice");
			JsonSerializer.Serialize(writer, new SlicedScrollDescriptor<TDocument>(SliceDescriptorAction), options);
		}
		else if (SliceValue is not null)
		{
			writer.WritePropertyName("slice");
			JsonSerializer.Serialize(writer, SliceValue, options);
		}

		if (MaxDocsValue.HasValue)
		{
			writer.WritePropertyName("max_docs");
			writer.WriteNumberValue(MaxDocsValue.Value);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class DeleteByQueryRequestDescriptor : RequestDescriptor<DeleteByQueryRequestDescriptor, DeleteByQueryRequestParameters>
{
	internal DeleteByQueryRequestDescriptor(Action<DeleteByQueryRequestDescriptor> configure) => configure.Invoke(this);
	public DeleteByQueryRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal DeleteByQueryRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceDeleteByQuery;
	internal override HttpMethod HttpMethod => HttpMethod.POST;
	internal override bool SupportsBody => true;
	public DeleteByQueryRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public DeleteByQueryRequestDescriptor AnalyzeWildcard(bool? analyzeWildcard = true) => Qs("analyze_wildcard", analyzeWildcard);
	public DeleteByQueryRequestDescriptor Analyzer(string? analyzer) => Qs("analyzer", analyzer);
	public DeleteByQueryRequestDescriptor Conflicts(Elastic.Clients.Elasticsearch.Conflicts? conflicts) => Qs("conflicts", conflicts);
	public DeleteByQueryRequestDescriptor DefaultOperator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? defaultOperator) => Qs("default_operator", defaultOperator);
	public DeleteByQueryRequestDescriptor Df(string? df) => Qs("df", df);
	public DeleteByQueryRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public DeleteByQueryRequestDescriptor From(long? from) => Qs("from", from);
	public DeleteByQueryRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public DeleteByQueryRequestDescriptor Lenient(bool? lenient = true) => Qs("lenient", lenient);
	public DeleteByQueryRequestDescriptor Preference(string? preference) => Qs("preference", preference);
	public DeleteByQueryRequestDescriptor QueryLuceneSyntax(string? q) => Qs("q", q);
	public DeleteByQueryRequestDescriptor Refresh(bool? refresh = true) => Qs("refresh", refresh);
	public DeleteByQueryRequestDescriptor RequestCache(bool? requestCache = true) => Qs("request_cache", requestCache);
	public DeleteByQueryRequestDescriptor RequestsPerSecond(float? requestsPerSecond) => Qs("requests_per_second", requestsPerSecond);
	public DeleteByQueryRequestDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public DeleteByQueryRequestDescriptor Scroll(Elastic.Clients.Elasticsearch.Duration? scroll) => Qs("scroll", scroll);
	public DeleteByQueryRequestDescriptor ScrollSize(long? scrollSize) => Qs("scroll_size", scrollSize);
	public DeleteByQueryRequestDescriptor SearchTimeout(Elastic.Clients.Elasticsearch.Duration? searchTimeout) => Qs("search_timeout", searchTimeout);
	public DeleteByQueryRequestDescriptor SearchType(Elastic.Clients.Elasticsearch.SearchType? searchType) => Qs("search_type", searchType);
	public DeleteByQueryRequestDescriptor Slices(Elastic.Clients.Elasticsearch.Slices? slices) => Qs("slices", slices);
	public DeleteByQueryRequestDescriptor Sort(ICollection<string>? sort) => Qs("sort", sort);
	public DeleteByQueryRequestDescriptor Stats(ICollection<string>? stats) => Qs("stats", stats);
	public DeleteByQueryRequestDescriptor TerminateAfter(long? terminateAfter) => Qs("terminate_after", terminateAfter);
	public DeleteByQueryRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
	public DeleteByQueryRequestDescriptor Version(bool? version = true) => Qs("version", version);
	public DeleteByQueryRequestDescriptor WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
	public DeleteByQueryRequestDescriptor WaitForCompletion(bool? waitForCompletion = true) => Qs("wait_for_completion", waitForCompletion);
	public DeleteByQueryRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.Query? QueryValue { get; set; }

	private QueryDsl.QueryDescriptor QueryDescriptor { get; set; }

	private Action<QueryDsl.QueryDescriptor> QueryDescriptorAction { get; set; }

	private Elastic.Clients.Elasticsearch.SlicedScroll? SliceValue { get; set; }

	private SlicedScrollDescriptor SliceDescriptor { get; set; }

	private Action<SlicedScrollDescriptor> SliceDescriptorAction { get; set; }

	private long? MaxDocsValue { get; set; }

	public DeleteByQueryRequestDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.Query? query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public DeleteByQueryRequestDescriptor Query(QueryDsl.QueryDescriptor descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public DeleteByQueryRequestDescriptor Query(Action<QueryDsl.QueryDescriptor> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	public DeleteByQueryRequestDescriptor Slice(Elastic.Clients.Elasticsearch.SlicedScroll? slice)
	{
		SliceDescriptor = null;
		SliceDescriptorAction = null;
		SliceValue = slice;
		return Self;
	}

	public DeleteByQueryRequestDescriptor Slice(SlicedScrollDescriptor descriptor)
	{
		SliceValue = null;
		SliceDescriptorAction = null;
		SliceDescriptor = descriptor;
		return Self;
	}

	public DeleteByQueryRequestDescriptor Slice(Action<SlicedScrollDescriptor> configure)
	{
		SliceValue = null;
		SliceDescriptor = null;
		SliceDescriptorAction = configure;
		return Self;
	}

	public DeleteByQueryRequestDescriptor MaxDocs(long? maxDocs)
	{
		MaxDocsValue = maxDocs;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new QueryDsl.QueryDescriptor(QueryDescriptorAction), options);
		}
		else if (QueryValue is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (SliceDescriptor is not null)
		{
			writer.WritePropertyName("slice");
			JsonSerializer.Serialize(writer, SliceDescriptor, options);
		}
		else if (SliceDescriptorAction is not null)
		{
			writer.WritePropertyName("slice");
			JsonSerializer.Serialize(writer, new SlicedScrollDescriptor(SliceDescriptorAction), options);
		}
		else if (SliceValue is not null)
		{
			writer.WritePropertyName("slice");
			JsonSerializer.Serialize(writer, SliceValue, options);
		}

		if (MaxDocsValue.HasValue)
		{
			writer.WritePropertyName("max_docs");
			writer.WriteNumberValue(MaxDocsValue.Value);
		}

		writer.WriteEndObject();
	}
}