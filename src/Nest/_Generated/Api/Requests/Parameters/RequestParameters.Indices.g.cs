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
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using System;
using System.Threading;
using System.Threading.Tasks;
using Elastic.Transport;

#nullable restore
namespace Nest
{
    public class AnalyzeRequestParameters : RequestParameters<AnalyzeRequestParameters>
    {
    }

    public class ClearCacheRequestParameters : RequestParameters<ClearCacheRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? Fielddata { get => Q<bool?>("fielddata"); set => Q("fielddata", value); }

        public Fields? Fields { get => Q<Fields?>("fields"); set => Q("fields", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public bool? Query { get => Q<bool?>("query"); set => Q("query", value); }

        public bool? Request { get => Q<bool?>("request"); set => Q("request", value); }
    }

    public class CloneIndexRequestParameters : RequestParameters<CloneIndexRequestParameters>
    {
        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }
    }

    public class CloseIndexRequestParameters : RequestParameters<CloseIndexRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }

        public string? WaitForActiveShards { get => Q<string?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
    }

    public class CreateIndexRequestParameters : RequestParameters<CreateIndexRequestParameters>
    {
        public bool? IncludeTypeName { get => Q<bool?>("include_type_name"); set => Q("include_type_name", value); }

        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }

        public string? WaitForActiveShards { get => Q<string?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
    }

    public class DeleteIndexRequestParameters : RequestParameters<DeleteIndexRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }
    }

    public class DeleteAliasRequestParameters : RequestParameters<DeleteAliasRequestParameters>
    {
        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }
    }

    public class DeleteIndexTemplateRequestParameters : RequestParameters<DeleteIndexTemplateRequestParameters>
    {
        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }
    }

    public class IndexExistsRequestParameters : RequestParameters<IndexExistsRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

        public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
    }

    public class AliasExistsRequestParameters : RequestParameters<AliasExistsRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
    }

    public class IndexTemplateExistsRequestParameters : RequestParameters<IndexTemplateExistsRequestParameters>
    {
        public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

        public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }
    }

    public class TypeExistsRequestParameters : RequestParameters<TypeExistsRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
    }

    public class FlushRequestParameters : RequestParameters<FlushRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public bool? WaitIfOngoing { get => Q<bool?>("wait_if_ongoing"); set => Q("wait_if_ongoing", value); }
    }

    public class ForceMergeRequestParameters : RequestParameters<ForceMergeRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? Flush { get => Q<bool?>("flush"); set => Q("flush", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public long? MaxNumSegments { get => Q<long?>("max_num_segments"); set => Q("max_num_segments", value); }

        public bool? OnlyExpungeDeletes { get => Q<bool?>("only_expunge_deletes"); set => Q("only_expunge_deletes", value); }
    }

    public class FreezeIndexRequestParameters : RequestParameters<FreezeIndexRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }
    }

    public class GetIndexRequestParameters : RequestParameters<GetIndexRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

        public bool? IncludeTypeName { get => Q<bool?>("include_type_name"); set => Q("include_type_name", value); }

        public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }
    }

    public class GetAliasRequestParameters : RequestParameters<GetAliasRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
    }

    public class GetFieldMappingRequestParameters : RequestParameters<GetFieldMappingRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

        public bool? IncludeTypeName { get => Q<bool?>("include_type_name"); set => Q("include_type_name", value); }

        public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
    }

    public class GetMappingRequestParameters : RequestParameters<GetMappingRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public bool? IncludeTypeName { get => Q<bool?>("include_type_name"); set => Q("include_type_name", value); }

        public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }
    }

    public class GetIndexSettingsRequestParameters : RequestParameters<GetIndexSettingsRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

        public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }
    }

    public class GetIndexTemplateRequestParameters : RequestParameters<GetIndexTemplateRequestParameters>
    {
        public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

        public bool? IncludeTypeName { get => Q<bool?>("include_type_name"); set => Q("include_type_name", value); }

        public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }
    }

    public class OpenIndexRequestParameters : RequestParameters<OpenIndexRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }

        public string? WaitForActiveShards { get => Q<string?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
    }

    public class PutAliasRequestParameters : RequestParameters<PutAliasRequestParameters>
    {
        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }
    }

    public class PutMappingRequestParameters : RequestParameters<PutMappingRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public bool? IncludeTypeName { get => Q<bool?>("include_type_name"); set => Q("include_type_name", value); }

        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }
    }

    public class UpdateIndexSettingsRequestParameters : RequestParameters<UpdateIndexSettingsRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public bool? PreserveExisting { get => Q<bool?>("preserve_existing"); set => Q("preserve_existing", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }
    }

    public class PutIndexTemplateRequestParameters : RequestParameters<PutIndexTemplateRequestParameters>
    {
        public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

        public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

        public bool? IncludeTypeName { get => Q<bool?>("include_type_name"); set => Q("include_type_name", value); }

        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }
    }

    public class RecoveryStatusRequestParameters : RequestParameters<RecoveryStatusRequestParameters>
    {
        public bool? ActiveOnly { get => Q<bool?>("active_only"); set => Q("active_only", value); }

        public bool? Detailed { get => Q<bool?>("detailed"); set => Q("detailed", value); }
    }

    public class RefreshRequestParameters : RequestParameters<RefreshRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }
    }

    public class ReloadSearchAnalyzersRequestParameters : RequestParameters<ReloadSearchAnalyzersRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }
    }

    public class RolloverIndexRequestParameters : RequestParameters<RolloverIndexRequestParameters>
    {
        public bool? DryRun { get => Q<bool?>("dry_run"); set => Q("dry_run", value); }

        public bool? IncludeTypeName { get => Q<bool?>("include_type_name"); set => Q("include_type_name", value); }

        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }

        public int? WaitForActiveShards { get => Q<int?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
    }

    public class SegmentsRequestParameters : RequestParameters<SegmentsRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public bool? Verbose { get => Q<bool?>("verbose"); set => Q("verbose", value); }
    }

    public class IndicesShardStoresRequestParameters : RequestParameters<IndicesShardStoresRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }
    }

    public class ShrinkIndexRequestParameters : RequestParameters<ShrinkIndexRequestParameters>
    {
        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }

        public string? WaitForActiveShards { get => Q<string?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
    }

    public class SplitIndexRequestParameters : RequestParameters<SplitIndexRequestParameters>
    {
        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }

        public string? WaitForActiveShards { get => Q<string?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
    }

    public class IndicesStatsRequestParameters : RequestParameters<IndicesStatsRequestParameters>
    {
        public Fields? CompletionFields { get => Q<Fields?>("completion_fields"); set => Q("completion_fields", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public Fields? FielddataFields { get => Q<Fields?>("fielddata_fields"); set => Q("fielddata_fields", value); }

        public Fields? Fields { get => Q<Fields?>("fields"); set => Q("fields", value); }

        public bool? ForbidClosedIndices { get => Q<bool?>("forbid_closed_indices"); set => Q("forbid_closed_indices", value); }

        public bool? IncludeSegmentFileSizes { get => Q<bool?>("include_segment_file_sizes"); set => Q("include_segment_file_sizes", value); }

        public bool? IncludeUnloadedSegments { get => Q<bool?>("include_unloaded_segments"); set => Q("include_unloaded_segments", value); }

        public Level? Level { get => Q<Level?>("level"); set => Q("level", value); }

        public Types? Types { get => Q<Types?>("types"); set => Q("types", value); }
    }

    public class UnfreezeIndexRequestParameters : RequestParameters<UnfreezeIndexRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }

        public string? WaitForActiveShards { get => Q<string?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
    }

    public class BulkAliasRequestParameters : RequestParameters<BulkAliasRequestParameters>
    {
        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }
    }

    public class ValidateQueryRequestParameters : RequestParameters<ValidateQueryRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public bool? AllShards { get => Q<bool?>("all_shards"); set => Q("all_shards", value); }

        public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

        public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

        public DefaultOperator? DefaultOperator { get => Q<DefaultOperator?>("default_operator"); set => Q("default_operator", value); }

        public string? Df { get => Q<string?>("df"); set => Q("df", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? Explain { get => Q<bool?>("explain"); set => Q("explain", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

        public string? QueryOnQueryString { get => Q<string?>("query_on_query_string"); set => Q("query_on_query_string", value); }

        public bool? Rewrite { get => Q<bool?>("rewrite"); set => Q("rewrite", value); }
    }
}