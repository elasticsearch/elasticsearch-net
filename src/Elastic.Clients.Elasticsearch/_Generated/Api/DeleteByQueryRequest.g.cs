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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public class DeleteByQueryRequestParameters : RequestParameters<DeleteByQueryRequestParameters>
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
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

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
		public long? RequestsPerSecond { get => Q<long?>("requests_per_second"); set => Q("requests_per_second", value); }

		[JsonIgnore]
		public string? Routing { get => Q<string?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Scroll { get => Q<Elastic.Clients.Elasticsearch.Time?>("scroll"); set => Q("scroll", value); }

		[JsonIgnore]
		public long? ScrollSize { get => Q<long?>("scroll_size"); set => Q("scroll_size", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? SearchTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("search_timeout"); set => Q("search_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.SearchType? SearchType { get => Q<Elastic.Clients.Elasticsearch.SearchType?>("search_type"); set => Q("search_type", value); }

		[JsonIgnore]
		public long? Slices { get => Q<long?>("slices"); set => Q("slices", value); }

		[JsonIgnore]
		public IEnumerable<string>? Sort { get => Q<IEnumerable<string>?>("sort"); set => Q("sort", value); }

		[JsonIgnore]
		public IEnumerable<string>? Stats { get => Q<IEnumerable<string>?>("stats"); set => Q("stats", value); }

		[JsonIgnore]
		public long? TerminateAfter { get => Q<long?>("terminate_after"); set => Q("terminate_after", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public bool? Version { get => Q<bool?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
	}

	public partial class DeleteByQueryRequest : PlainRequestBase<DeleteByQueryRequestParameters>
	{
		public DeleteByQueryRequest(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceDeleteByQuery;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
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
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

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
		public long? RequestsPerSecond { get => Q<long?>("requests_per_second"); set => Q("requests_per_second", value); }

		[JsonIgnore]
		public string? Routing { get => Q<string?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Scroll { get => Q<Elastic.Clients.Elasticsearch.Time?>("scroll"); set => Q("scroll", value); }

		[JsonIgnore]
		public long? ScrollSize { get => Q<long?>("scroll_size"); set => Q("scroll_size", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? SearchTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("search_timeout"); set => Q("search_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.SearchType? SearchType { get => Q<Elastic.Clients.Elasticsearch.SearchType?>("search_type"); set => Q("search_type", value); }

		[JsonIgnore]
		public long? Slices { get => Q<long?>("slices"); set => Q("slices", value); }

		[JsonIgnore]
		public IEnumerable<string>? Sort { get => Q<IEnumerable<string>?>("sort"); set => Q("sort", value); }

		[JsonIgnore]
		public IEnumerable<string>? Stats { get => Q<IEnumerable<string>?>("stats"); set => Q("stats", value); }

		[JsonIgnore]
		public long? TerminateAfter { get => Q<long?>("terminate_after"); set => Q("terminate_after", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

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
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("slice")]
		public Elastic.Clients.Elasticsearch.SlicedScroll? Slice { get; set; }
	}

	public sealed partial class DeleteByQueryRequestDescriptor<T> : RequestDescriptorBase<DeleteByQueryRequestDescriptor<T>, DeleteByQueryRequestParameters>
	{
		public DeleteByQueryRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
		{
		}

		public DeleteByQueryRequestDescriptor()
		{
		}

		internal DeleteByQueryRequestDescriptor(Action<DeleteByQueryRequestDescriptor<T>> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceDeleteByQuery;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public DeleteByQueryRequestDescriptor<T> AllowNoIndices(bool? allowNoIndices) => Qs("allow_no_indices", allowNoIndices);
		public DeleteByQueryRequestDescriptor<T> Analyzer(string? analyzer) => Qs("analyzer", analyzer);
		public DeleteByQueryRequestDescriptor<T> AnalyzeWildcard(bool? analyzeWildcard) => Qs("analyze_wildcard", analyzeWildcard);
		public DeleteByQueryRequestDescriptor<T> Conflicts(Elastic.Clients.Elasticsearch.Conflicts? conflicts) => Qs("conflicts", conflicts);
		public DeleteByQueryRequestDescriptor<T> DefaultOperator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? defaultOperator) => Qs("default_operator", defaultOperator);
		public DeleteByQueryRequestDescriptor<T> Df(string? df) => Qs("df", df);
		public DeleteByQueryRequestDescriptor<T> ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public DeleteByQueryRequestDescriptor<T> From(long? from) => Qs("from", from);
		public DeleteByQueryRequestDescriptor<T> IgnoreUnavailable(bool? ignoreUnavailable) => Qs("ignore_unavailable", ignoreUnavailable);
		public DeleteByQueryRequestDescriptor<T> Lenient(bool? lenient) => Qs("lenient", lenient);
		public DeleteByQueryRequestDescriptor<T> Preference(string? preference) => Qs("preference", preference);
		public DeleteByQueryRequestDescriptor<T> Refresh(bool? refresh) => Qs("refresh", refresh);
		public DeleteByQueryRequestDescriptor<T> RequestCache(bool? requestCache) => Qs("request_cache", requestCache);
		public DeleteByQueryRequestDescriptor<T> RequestsPerSecond(long? requestsPerSecond) => Qs("requests_per_second", requestsPerSecond);
		public DeleteByQueryRequestDescriptor<T> Routing(string? routing) => Qs("routing", routing);
		public DeleteByQueryRequestDescriptor<T> QueryLuceneSyntax(string? q) => Qs("q", q);
		public DeleteByQueryRequestDescriptor<T> Scroll(Elastic.Clients.Elasticsearch.Time? scroll) => Qs("scroll", scroll);
		public DeleteByQueryRequestDescriptor<T> ScrollSize(long? scrollSize) => Qs("scroll_size", scrollSize);
		public DeleteByQueryRequestDescriptor<T> SearchTimeout(Elastic.Clients.Elasticsearch.Time? searchTimeout) => Qs("search_timeout", searchTimeout);
		public DeleteByQueryRequestDescriptor<T> SearchType(Elastic.Clients.Elasticsearch.SearchType? searchType) => Qs("search_type", searchType);
		public DeleteByQueryRequestDescriptor<T> Slices(long? slices) => Qs("slices", slices);
		public DeleteByQueryRequestDescriptor<T> Sort(IEnumerable<string>? sort) => Qs("sort", sort);
		public DeleteByQueryRequestDescriptor<T> Stats(IEnumerable<string>? stats) => Qs("stats", stats);
		public DeleteByQueryRequestDescriptor<T> TerminateAfter(long? terminateAfter) => Qs("terminate_after", terminateAfter);
		public DeleteByQueryRequestDescriptor<T> Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public DeleteByQueryRequestDescriptor<T> Version(bool? version) => Qs("version", version);
		public DeleteByQueryRequestDescriptor<T> WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
		public DeleteByQueryRequestDescriptor<T> WaitForCompletion(bool? waitForCompletion) => Qs("wait_for_completion", waitForCompletion);
		internal long? MaxDocsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? QueryValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.SlicedScroll? SliceValue { get; private set; }

		internal QueryDsl.QueryContainerDescriptor<T> QueryDescriptor { get; private set; }

		internal SlicedScrollDescriptor<T> SliceDescriptor { get; private set; }

		internal Action<QueryDsl.QueryContainerDescriptor<T>> QueryDescriptorAction { get; private set; }

		internal Action<SlicedScrollDescriptor<T>> SliceDescriptorAction { get; private set; }

		public DeleteByQueryRequestDescriptor<T> MaxDocs(long? maxDocs) => Assign(maxDocs, (a, v) => a.MaxDocsValue = v);
		public DeleteByQueryRequestDescriptor<T> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			return Assign(query, (a, v) => a.QueryValue = v);
		}

		public DeleteByQueryRequestDescriptor<T> Query(QueryDsl.QueryContainerDescriptor<T> descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.QueryDescriptor = v);
		}

		public DeleteByQueryRequestDescriptor<T> Query(Action<QueryDsl.QueryContainerDescriptor<T>> configure)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			return Assign(configure, (a, v) => a.QueryDescriptorAction = v);
		}

		public DeleteByQueryRequestDescriptor<T> Slice(Elastic.Clients.Elasticsearch.SlicedScroll? slice)
		{
			SliceDescriptor = null;
			SliceDescriptorAction = null;
			return Assign(slice, (a, v) => a.SliceValue = v);
		}

		public DeleteByQueryRequestDescriptor<T> Slice(SlicedScrollDescriptor<T> descriptor)
		{
			SliceValue = null;
			SliceDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.SliceDescriptor = v);
		}

		public DeleteByQueryRequestDescriptor<T> Slice(Action<SlicedScrollDescriptor<T>> configure)
		{
			SliceValue = null;
			SliceDescriptorAction = null;
			return Assign(configure, (a, v) => a.SliceDescriptorAction = v);
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (MaxDocsValue.HasValue)
			{
				writer.WritePropertyName("max_docs");
				writer.WriteNumberValue(MaxDocsValue.Value);
			}

			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<T>(QueryDescriptorAction), options);
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
				JsonSerializer.Serialize(writer, new SlicedScrollDescriptor<T>(SliceDescriptorAction), options);
			}
			else if (SliceValue is not null)
			{
				writer.WritePropertyName("slice");
				JsonSerializer.Serialize(writer, SliceValue, options);
			}

			writer.WriteEndObject();
		}
	}
}