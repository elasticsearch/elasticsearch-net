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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Nest
{
	public class ClearScrollRequestParameters : RequestParameters<ClearScrollRequestParameters>
	{
	}

	public class ClosePointInTimeRequestParameters : RequestParameters<ClosePointInTimeRequestParameters>
	{
	}

	public class CountRequestParameters : RequestParameters<CountRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

		[JsonIgnore]
		public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

		[JsonIgnore]
		public Nest.DefaultOperator? DefaultOperator { get => Q<Nest.DefaultOperator?>("default_operator"); set => Q("default_operator", value); }

		[JsonIgnore]
		public string? Df { get => Q<string?>("df"); set => Q("df", value); }

		[JsonIgnore]
		public Nest.ExpandWildcards? ExpandWildcards { get => Q<Nest.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? IgnoreThrottled { get => Q<bool?>("ignore_throttled"); set => Q("ignore_throttled", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

		[JsonIgnore]
		public double? MinScore { get => Q<double?>("min_score"); set => Q("min_score", value); }

		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public string? QueryOnQueryString { get => Q<string?>("query_on_query_string"); set => Q("query_on_query_string", value); }

		[JsonIgnore]
		public Nest.Routing? Routing { get => Q<Nest.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public long? TerminateAfter { get => Q<long?>("terminate_after"); set => Q("terminate_after", value); }

		[JsonIgnore]
		public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }
	}

	public class CreateRequestParameters : RequestParameters<CreateRequestParameters>
	{
		[JsonIgnore]
		public string? Pipeline { get => Q<string?>("pipeline"); set => Q("pipeline", value); }

		[JsonIgnore]
		public Nest.Refresh? Refresh { get => Q<Nest.Refresh?>("refresh"); set => Q("refresh", value); }

		[JsonIgnore]
		public Nest.Routing? Routing { get => Q<Nest.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Nest.VersionNumber? Version { get => Q<Nest.VersionNumber?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Nest.VersionType? VersionType { get => Q<Nest.VersionType?>("version_type"); set => Q("version_type", value); }

		[JsonIgnore]
		public Nest.WaitForActiveShards? WaitForActiveShards { get => Q<Nest.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
	}

	public class DeleteRequestParameters : RequestParameters<DeleteRequestParameters>
	{
		[JsonIgnore]
		public long? IfPrimaryTerm { get => Q<long?>("if_primary_term"); set => Q("if_primary_term", value); }

		[JsonIgnore]
		public Nest.SequenceNumber? IfSeqNo { get => Q<Nest.SequenceNumber?>("if_seq_no"); set => Q("if_seq_no", value); }

		[JsonIgnore]
		public Nest.Refresh? Refresh { get => Q<Nest.Refresh?>("refresh"); set => Q("refresh", value); }

		[JsonIgnore]
		public Nest.Routing? Routing { get => Q<Nest.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Nest.VersionNumber? Version { get => Q<Nest.VersionNumber?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Nest.VersionType? VersionType { get => Q<Nest.VersionType?>("version_type"); set => Q("version_type", value); }

		[JsonIgnore]
		public Nest.WaitForActiveShards? WaitForActiveShards { get => Q<Nest.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
	}

	public class DeleteByQueryRequestParameters : RequestParameters<DeleteByQueryRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

		[JsonIgnore]
		public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

		[JsonIgnore]
		public Nest.Conflicts? Conflicts { get => Q<Nest.Conflicts?>("conflicts"); set => Q("conflicts", value); }

		[JsonIgnore]
		public Nest.DefaultOperator? DefaultOperator { get => Q<Nest.DefaultOperator?>("default_operator"); set => Q("default_operator", value); }

		[JsonIgnore]
		public string? Df { get => Q<string?>("df"); set => Q("df", value); }

		[JsonIgnore]
		public Nest.ExpandWildcards? ExpandWildcards { get => Q<Nest.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public long? From { get => Q<long?>("from"); set => Q("from", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

		[JsonIgnore]
		public long? MaxDocs { get => Q<long?>("max_docs"); set => Q("max_docs", value); }

		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

		[JsonIgnore]
		public bool? RequestCache { get => Q<bool?>("request_cache"); set => Q("request_cache", value); }

		[JsonIgnore]
		public long? RequestsPerSecond { get => Q<long?>("requests_per_second"); set => Q("requests_per_second", value); }

		[JsonIgnore]
		public Nest.Routing? Routing { get => Q<Nest.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }

		[JsonIgnore]
		public Nest.Time? Scroll { get => Q<Nest.Time?>("scroll"); set => Q("scroll", value); }

		[JsonIgnore]
		public long? ScrollSize { get => Q<long?>("scroll_size"); set => Q("scroll_size", value); }

		[JsonIgnore]
		public Nest.Time? SearchTimeout { get => Q<Nest.Time?>("search_timeout"); set => Q("search_timeout", value); }

		[JsonIgnore]
		public Nest.SearchType? SearchType { get => Q<Nest.SearchType?>("search_type"); set => Q("search_type", value); }

		[JsonIgnore]
		public long? Size { get => Q<long?>("size"); set => Q("size", value); }

		[JsonIgnore]
		public long? Slices { get => Q<long?>("slices"); set => Q("slices", value); }

		[JsonIgnore]
		public IEnumerable<string>? Sort { get => Q<IEnumerable<string>?>("sort"); set => Q("sort", value); }

		[JsonIgnore]
		public Union<bool, Nest.Fields>? Source { get => Q<Union<bool, Nest.Fields>?>("_source"); set => Q("_source", value); }

		[JsonIgnore]
		public Nest.Fields? SourceExcludes { get => Q<Nest.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

		[JsonIgnore]
		public Nest.Fields? SourceIncludes { get => Q<Nest.Fields?>("_source_includes"); set => Q("_source_includes", value); }

		[JsonIgnore]
		public IEnumerable<string>? Stats { get => Q<IEnumerable<string>?>("stats"); set => Q("stats", value); }

		[JsonIgnore]
		public long? TerminateAfter { get => Q<long?>("terminate_after"); set => Q("terminate_after", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public bool? Version { get => Q<bool?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Nest.WaitForActiveShards? WaitForActiveShards { get => Q<Nest.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
	}

	public class ExistsRequestParameters : RequestParameters<ExistsRequestParameters>
	{
		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public bool? Realtime { get => Q<bool?>("realtime"); set => Q("realtime", value); }

		[JsonIgnore]
		public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

		[JsonIgnore]
		public Nest.Routing? Routing { get => Q<Nest.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public bool? SourceEnabled { get => Q<bool?>("source_enabled"); set => Q("source_enabled", value); }

		[JsonIgnore]
		public Nest.Fields? SourceExcludes { get => Q<Nest.Fields?>("source_excludes"); set => Q("source_excludes", value); }

		[JsonIgnore]
		public Nest.Fields? SourceIncludes { get => Q<Nest.Fields?>("source_includes"); set => Q("source_includes", value); }

		[JsonIgnore]
		public Nest.Fields? StoredFields { get => Q<Nest.Fields?>("stored_fields"); set => Q("stored_fields", value); }

		[JsonIgnore]
		public Nest.VersionNumber? Version { get => Q<Nest.VersionNumber?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Nest.VersionType? VersionType { get => Q<Nest.VersionType?>("version_type"); set => Q("version_type", value); }
	}

	public class ExistsSourceRequestParameters : RequestParameters<ExistsSourceRequestParameters>
	{
		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public bool? Realtime { get => Q<bool?>("realtime"); set => Q("realtime", value); }

		[JsonIgnore]
		public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

		[JsonIgnore]
		public Nest.Routing? Routing { get => Q<Nest.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public bool? SourceEnabled { get => Q<bool?>("source_enabled"); set => Q("source_enabled", value); }

		[JsonIgnore]
		public Nest.Fields? SourceExcludes { get => Q<Nest.Fields?>("source_excludes"); set => Q("source_excludes", value); }

		[JsonIgnore]
		public Nest.Fields? SourceIncludes { get => Q<Nest.Fields?>("source_includes"); set => Q("source_includes", value); }

		[JsonIgnore]
		public Nest.VersionNumber? Version { get => Q<Nest.VersionNumber?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Nest.VersionType? VersionType { get => Q<Nest.VersionType?>("version_type"); set => Q("version_type", value); }
	}

	public class ExplainRequestParameters : RequestParameters<ExplainRequestParameters>
	{
		[JsonIgnore]
		public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

		[JsonIgnore]
		public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

		[JsonIgnore]
		public Nest.DefaultOperator? DefaultOperator { get => Q<Nest.DefaultOperator?>("default_operator"); set => Q("default_operator", value); }

		[JsonIgnore]
		public string? Df { get => Q<string?>("df"); set => Q("df", value); }

		[JsonIgnore]
		public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public string? QueryOnQueryString { get => Q<string?>("query_on_query_string"); set => Q("query_on_query_string", value); }

		[JsonIgnore]
		public Nest.Routing? Routing { get => Q<Nest.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Union<bool, Nest.Fields>? Source { get => Q<Union<bool, Nest.Fields>?>("_source"); set => Q("_source", value); }

		[JsonIgnore]
		public Nest.Fields? SourceExcludes { get => Q<Nest.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

		[JsonIgnore]
		public Nest.Fields? SourceIncludes { get => Q<Nest.Fields?>("_source_includes"); set => Q("_source_includes", value); }

		[JsonIgnore]
		public Nest.Fields? StoredFields { get => Q<Nest.Fields?>("stored_fields"); set => Q("stored_fields", value); }

		[JsonIgnore]
		public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }
	}

	public class FieldCapsRequestParameters : RequestParameters<FieldCapsRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Nest.ExpandWildcards? ExpandWildcards { get => Q<Nest.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public Nest.Fields? Fields { get => Q<Nest.Fields?>("fields"); set => Q("fields", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? IncludeUnmapped { get => Q<bool?>("include_unmapped"); set => Q("include_unmapped", value); }
	}

	public class GetRequestParameters : RequestParameters<GetRequestParameters>
	{
		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public bool? Realtime { get => Q<bool?>("realtime"); set => Q("realtime", value); }

		[JsonIgnore]
		public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

		[JsonIgnore]
		public Nest.Routing? Routing { get => Q<Nest.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public bool? SourceEnabled { get => Q<bool?>("source_enabled"); set => Q("source_enabled", value); }

		[JsonIgnore]
		public Nest.Fields? SourceExcludes { get => Q<Nest.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

		[JsonIgnore]
		public Nest.Fields? SourceIncludes { get => Q<Nest.Fields?>("_source_includes"); set => Q("_source_includes", value); }

		[JsonIgnore]
		public Nest.Fields? StoredFields { get => Q<Nest.Fields?>("stored_fields"); set => Q("stored_fields", value); }

		[JsonIgnore]
		public Nest.VersionNumber? Version { get => Q<Nest.VersionNumber?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Nest.VersionType? VersionType { get => Q<Nest.VersionType?>("version_type"); set => Q("version_type", value); }

		[JsonIgnore]
		public Union<bool, Nest.Fields>? Source { get => Q<Union<bool, Nest.Fields>?>("_source"); set => Q("_source", value); }
	}

	public class GetScriptRequestParameters : RequestParameters<GetScriptRequestParameters>
	{
		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }
	}

	public class GetScriptContextRequestParameters : RequestParameters<GetScriptContextRequestParameters>
	{
	}

	public class GetScriptLanguagesRequestParameters : RequestParameters<GetScriptLanguagesRequestParameters>
	{
	}

	public class IndexRequestParameters : RequestParameters<IndexRequestParameters>
	{
		[JsonIgnore]
		public long? IfPrimaryTerm { get => Q<long?>("if_primary_term"); set => Q("if_primary_term", value); }

		[JsonIgnore]
		public Nest.SequenceNumber? IfSeqNo { get => Q<Nest.SequenceNumber?>("if_seq_no"); set => Q("if_seq_no", value); }

		[JsonIgnore]
		public Nest.OpType? OpType { get => Q<Nest.OpType?>("op_type"); set => Q("op_type", value); }

		[JsonIgnore]
		public string? Pipeline { get => Q<string?>("pipeline"); set => Q("pipeline", value); }

		[JsonIgnore]
		public Nest.Refresh? Refresh { get => Q<Nest.Refresh?>("refresh"); set => Q("refresh", value); }

		[JsonIgnore]
		public Nest.Routing? Routing { get => Q<Nest.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Nest.VersionNumber? Version { get => Q<Nest.VersionNumber?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Nest.VersionType? VersionType { get => Q<Nest.VersionType?>("version_type"); set => Q("version_type", value); }

		[JsonIgnore]
		public Nest.WaitForActiveShards? WaitForActiveShards { get => Q<Nest.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

		[JsonIgnore]
		public bool? RequireAlias { get => Q<bool?>("require_alias"); set => Q("require_alias", value); }
	}

	public class InfoRequestParameters : RequestParameters<InfoRequestParameters>
	{
	}

	public class OpenPointInTimeRequestParameters : RequestParameters<OpenPointInTimeRequestParameters>
	{
		[JsonIgnore]
		public Nest.Time? KeepAlive { get => Q<Nest.Time?>("keep_alive"); set => Q("keep_alive", value); }
	}

	public class PingRequestParameters : RequestParameters<PingRequestParameters>
	{
	}

	public class PutScriptRequestParameters : RequestParameters<PutScriptRequestParameters>
	{
		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}

	public class ReindexRequestParameters : RequestParameters<ReindexRequestParameters>
	{
		[JsonIgnore]
		public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

		[JsonIgnore]
		public long? RequestsPerSecond { get => Q<long?>("requests_per_second"); set => Q("requests_per_second", value); }

		[JsonIgnore]
		public Nest.Time? Scroll { get => Q<Nest.Time?>("scroll"); set => Q("scroll", value); }

		[JsonIgnore]
		public long? Slices { get => Q<long?>("slices"); set => Q("slices", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Nest.WaitForActiveShards? WaitForActiveShards { get => Q<Nest.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }

		[JsonIgnore]
		public bool? RequireAlias { get => Q<bool?>("require_alias"); set => Q("require_alias", value); }
	}

	public class ReindexRethrottleRequestParameters : RequestParameters<ReindexRethrottleRequestParameters>
	{
		[JsonIgnore]
		public long? RequestsPerSecond { get => Q<long?>("requests_per_second"); set => Q("requests_per_second", value); }
	}

	public class ScrollRequestParameters : RequestParameters<ScrollRequestParameters>
	{
		[JsonIgnore]
		public Nest.Time? Scroll { get => Q<Nest.Time?>("scroll"); set => Q("scroll", value); }

		[JsonIgnore]
		public Nest.ScrollId? ScrollId { get => Q<Nest.ScrollId?>("scroll_id"); set => Q("scroll_id", value); }

		[JsonIgnore]
		public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

		[JsonIgnore]
		public bool? TotalHitsAsInteger { get => Q<bool?>("total_hits_as_integer"); set => Q("total_hits_as_integer", value); }
	}

	public class SearchRequestParameters : RequestParameters<SearchRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public bool? AllowPartialSearchResults { get => Q<bool?>("allow_partial_search_results"); set => Q("allow_partial_search_results", value); }

		[JsonIgnore]
		public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

		[JsonIgnore]
		public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

		[JsonIgnore]
		public long? BatchedReduceSize { get => Q<long?>("batched_reduce_size"); set => Q("batched_reduce_size", value); }

		[JsonIgnore]
		public bool? CcsMinimizeRoundtrips { get => Q<bool?>("ccs_minimize_roundtrips"); set => Q("ccs_minimize_roundtrips", value); }

		[JsonIgnore]
		public Nest.DefaultOperator? DefaultOperator { get => Q<Nest.DefaultOperator?>("default_operator"); set => Q("default_operator", value); }

		[JsonIgnore]
		public string? Df { get => Q<string?>("df"); set => Q("df", value); }

		[JsonIgnore]
		public Nest.Fields? DocvalueFields { get => Q<Nest.Fields?>("docvalue_fields"); set => Q("docvalue_fields", value); }

		[JsonIgnore]
		public Nest.ExpandWildcards? ExpandWildcards { get => Q<Nest.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? Explain { get => Q<bool?>("explain"); set => Q("explain", value); }

		[JsonIgnore]
		public bool? IgnoreThrottled { get => Q<bool?>("ignore_throttled"); set => Q("ignore_throttled", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

		[JsonIgnore]
		public long? MaxConcurrentShardRequests { get => Q<long?>("max_concurrent_shard_requests"); set => Q("max_concurrent_shard_requests", value); }

		[JsonIgnore]
		public Nest.VersionString? MinCompatibleShardNode { get => Q<Nest.VersionString?>("min_compatible_shard_node"); set => Q("min_compatible_shard_node", value); }

		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public long? PreFilterShardSize { get => Q<long?>("pre_filter_shard_size"); set => Q("pre_filter_shard_size", value); }

		[JsonIgnore]
		public bool? RequestCache { get => Q<bool?>("request_cache"); set => Q("request_cache", value); }

		[JsonIgnore]
		public Nest.Routing? Routing { get => Q<Nest.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Nest.Time? Scroll { get => Q<Nest.Time?>("scroll"); set => Q("scroll", value); }

		[JsonIgnore]
		public Nest.SearchType? SearchType { get => Q<Nest.SearchType?>("search_type"); set => Q("search_type", value); }

		[JsonIgnore]
		public IEnumerable<string>? Stats { get => Q<IEnumerable<string>?>("stats"); set => Q("stats", value); }

		[JsonIgnore]
		public Nest.Fields? StoredFields { get => Q<Nest.Fields?>("stored_fields"); set => Q("stored_fields", value); }

		[JsonIgnore]
		public Nest.Field? SuggestField { get => Q<Nest.Field?>("suggest_field"); set => Q("suggest_field", value); }

		[JsonIgnore]
		public Nest.SuggestMode? SuggestMode { get => Q<Nest.SuggestMode?>("suggest_mode"); set => Q("suggest_mode", value); }

		[JsonIgnore]
		public long? SuggestSize { get => Q<long?>("suggest_size"); set => Q("suggest_size", value); }

		[JsonIgnore]
		public string? SuggestText { get => Q<string?>("suggest_text"); set => Q("suggest_text", value); }

		[JsonIgnore]
		public long? TerminateAfter { get => Q<long?>("terminate_after"); set => Q("terminate_after", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Union<bool, int>? TrackTotalHits { get => Q<Union<bool, int>?>("track_total_hits"); set => Q("track_total_hits", value); }

		[JsonIgnore]
		public bool? TrackScores { get => Q<bool?>("track_scores"); set => Q("track_scores", value); }

		[JsonIgnore]
		public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }

		[JsonIgnore]
		public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

		[JsonIgnore]
		public bool? Version { get => Q<bool?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Union<bool, Nest.Fields>? Source { get => Q<Union<bool, Nest.Fields>?>("_source"); set => Q("_source", value); }

		[JsonIgnore]
		public Nest.Fields? SourceExcludes { get => Q<Nest.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

		[JsonIgnore]
		public Nest.Fields? SourceIncludes { get => Q<Nest.Fields?>("_source_includes"); set => Q("_source_includes", value); }

		[JsonIgnore]
		public bool? SeqNoPrimaryTerm { get => Q<bool?>("seq_no_primary_term"); set => Q("seq_no_primary_term", value); }

		[JsonIgnore]
		public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }

		[JsonIgnore]
		public int? Size { get => Q<int?>("size"); set => Q("size", value); }

		[JsonIgnore]
		public int? From { get => Q<int?>("from"); set => Q("from", value); }
	}

	public class SearchShardsRequestParameters : RequestParameters<SearchShardsRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Nest.ExpandWildcards? ExpandWildcards { get => Q<Nest.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public Nest.Routing? Routing { get => Q<Nest.Routing?>("routing"); set => Q("routing", value); }
	}

	public class SearchTemplateRequestParameters : RequestParameters<SearchTemplateRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public bool? CcsMinimizeRoundtrips { get => Q<bool?>("ccs_minimize_roundtrips"); set => Q("ccs_minimize_roundtrips", value); }

		[JsonIgnore]
		public Nest.ExpandWildcards? ExpandWildcards { get => Q<Nest.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? Explain { get => Q<bool?>("explain"); set => Q("explain", value); }

		[JsonIgnore]
		public bool? IgnoreThrottled { get => Q<bool?>("ignore_throttled"); set => Q("ignore_throttled", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public bool? Profile { get => Q<bool?>("profile"); set => Q("profile", value); }

		[JsonIgnore]
		public Nest.Routing? Routing { get => Q<Nest.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Nest.Time? Scroll { get => Q<Nest.Time?>("scroll"); set => Q("scroll", value); }

		[JsonIgnore]
		public Nest.SearchType? SearchType { get => Q<Nest.SearchType?>("search_type"); set => Q("search_type", value); }

		[JsonIgnore]
		public bool? TotalHitsAsInteger { get => Q<bool?>("total_hits_as_integer"); set => Q("total_hits_as_integer", value); }

		[JsonIgnore]
		public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }
	}

	public class TermsEnumRequestParameters : RequestParameters<TermsEnumRequestParameters>
	{
	}

	public class TermvectorsRequestParameters : RequestParameters<TermvectorsRequestParameters>
	{
		[JsonIgnore]
		public Nest.Fields? Fields { get => Q<Nest.Fields?>("fields"); set => Q("fields", value); }

		[JsonIgnore]
		public bool? FieldStatistics { get => Q<bool?>("field_statistics"); set => Q("field_statistics", value); }

		[JsonIgnore]
		public bool? Offsets { get => Q<bool?>("offsets"); set => Q("offsets", value); }

		[JsonIgnore]
		public bool? Payloads { get => Q<bool?>("payloads"); set => Q("payloads", value); }

		[JsonIgnore]
		public bool? Positions { get => Q<bool?>("positions"); set => Q("positions", value); }

		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public bool? Realtime { get => Q<bool?>("realtime"); set => Q("realtime", value); }

		[JsonIgnore]
		public Nest.Routing? Routing { get => Q<Nest.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public bool? TermStatistics { get => Q<bool?>("term_statistics"); set => Q("term_statistics", value); }

		[JsonIgnore]
		public Nest.VersionNumber? Version { get => Q<Nest.VersionNumber?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Nest.VersionType? VersionType { get => Q<Nest.VersionType?>("version_type"); set => Q("version_type", value); }
	}
}