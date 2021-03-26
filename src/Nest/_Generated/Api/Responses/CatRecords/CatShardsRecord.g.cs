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

using System.Text.Json.Serialization;

#nullable restore
namespace Nest
{
	public class CatShardsRecord
	{
		[JsonInclude, JsonPropertyName("basi")]
		private string? _basi = default;
		[JsonInclude, JsonPropertyName("bati")]
		private string? _bati = default;
		[JsonInclude, JsonPropertyName("bto")]
		private string? _bto = default;
		[JsonInclude, JsonPropertyName("btsi")]
		private string? _btsi = default;
		[JsonInclude, JsonPropertyName("btti")]
		private string? _btti = default;
		[JsonInclude, JsonPropertyName("bulk.avg_size_in_bytes")]
		private string? _bulk_avg_size_in_bytes = default;
		[JsonInclude, JsonPropertyName("bulk.avg_time")]
		private string? _bulk_avg_time = default;
		[JsonInclude, JsonPropertyName("bulk.total_operations")]
		private string? _bulk_total_operations = default;
		[JsonInclude, JsonPropertyName("bulk.total_size_in_bytes")]
		private string? _bulk_total_size_in_bytes = default;
		[JsonInclude, JsonPropertyName("bulk.total_time")]
		private string? _bulk_total_time = default;
		[JsonInclude, JsonPropertyName("bulkAvgSizeInBytes")]
		private string? _bulkAvgSizeInBytes = default;
		[JsonInclude, JsonPropertyName("bulkAvgTime")]
		private string? _bulkAvgTime = default;
		[JsonInclude, JsonPropertyName("bulkTotalOperations")]
		private string? _bulkTotalOperations = default;
		[JsonInclude, JsonPropertyName("bulkTotalSizeInBytes")]
		private string? _bulkTotalSizeInBytes = default;
		[JsonInclude, JsonPropertyName("bulkTotalTime")]
		private string? _bulkTotalTime = default;
		[JsonInclude, JsonPropertyName("completion.size")]
		private string? _completion_size = default;
		[JsonInclude, JsonPropertyName("completionSize")]
		private string? _completionSize = default;
		[JsonInclude, JsonPropertyName("cs")]
		private string? _cs = default;
		[JsonInclude, JsonPropertyName("d")]
		private string? _d = default;
		[JsonInclude, JsonPropertyName("dataPath")]
		private string? _dataPath = default;
		[JsonInclude, JsonPropertyName("dc")]
		private string? _dc = default;
		[JsonInclude, JsonPropertyName("docs")]
		private string? _docs = default;
		[JsonInclude, JsonPropertyName("fe")]
		private string? _fe = default;
		[JsonInclude, JsonPropertyName("fielddata.evictions")]
		private string? _fielddata_evictions = default;
		[JsonInclude, JsonPropertyName("fielddata.memory_size")]
		private string? _fielddata_memory_size = default;
		[JsonInclude, JsonPropertyName("fielddataEvictions")]
		private string? _fielddataEvictions = default;
		[JsonInclude, JsonPropertyName("fielddataMemory")]
		private string? _fielddataMemory = default;
		[JsonInclude, JsonPropertyName("fixedBitsetMemory")]
		private string? _fixedBitsetMemory = default;
		[JsonInclude, JsonPropertyName("flush.total")]
		private string? _flush_total = default;
		[JsonInclude, JsonPropertyName("flush.total_time")]
		private string? _flush_total_time = default;
		[JsonInclude, JsonPropertyName("flushTotal")]
		private string? _flushTotal = default;
		[JsonInclude, JsonPropertyName("flushTotalTime")]
		private string? _flushTotalTime = default;
		[JsonInclude, JsonPropertyName("fm")]
		private string? _fm = default;
		[JsonInclude, JsonPropertyName("ft")]
		private string? _ft = default;
		[JsonInclude, JsonPropertyName("ftt")]
		private string? _ftt = default;
		[JsonInclude, JsonPropertyName("gc")]
		private string? _gc = default;
		[JsonInclude, JsonPropertyName("get.current")]
		private string? _get_current = default;
		[JsonInclude, JsonPropertyName("get.exists_time")]
		private string? _get_exists_time = default;
		[JsonInclude, JsonPropertyName("get.exists_total")]
		private string? _get_exists_total = default;
		[JsonInclude, JsonPropertyName("get.missing_time")]
		private string? _get_missing_time = default;
		[JsonInclude, JsonPropertyName("get.missing_total")]
		private string? _get_missing_total = default;
		[JsonInclude, JsonPropertyName("get.time")]
		private string? _get_time = default;
		[JsonInclude, JsonPropertyName("get.total")]
		private string? _get_total = default;
		[JsonInclude, JsonPropertyName("getCurrent")]
		private string? _getCurrent = default;
		[JsonInclude, JsonPropertyName("getExistsTime")]
		private string? _getExistsTime = default;
		[JsonInclude, JsonPropertyName("getExistsTotal")]
		private string? _getExistsTotal = default;
		[JsonInclude, JsonPropertyName("geti")]
		private string? _geti = default;
		[JsonInclude, JsonPropertyName("getMissingTime")]
		private string? _getMissingTime = default;
		[JsonInclude, JsonPropertyName("getMissingTotal")]
		private string? _getMissingTotal = default;
		[JsonInclude, JsonPropertyName("geto")]
		private string? _geto = default;
		[JsonInclude, JsonPropertyName("getTime")]
		private string? _getTime = default;
		[JsonInclude, JsonPropertyName("getTotal")]
		private string? _getTotal = default;
		[JsonInclude, JsonPropertyName("globalCheckpoint")]
		private string? _globalCheckpoint = default;
		[JsonInclude, JsonPropertyName("gmti")]
		private string? _gmti = default;
		[JsonInclude, JsonPropertyName("gmto")]
		private string? _gmto = default;
		[JsonInclude, JsonPropertyName("gti")]
		private string? _gti = default;
		[JsonInclude, JsonPropertyName("gto")]
		private string? _gto = default;
		[JsonInclude, JsonPropertyName("i")]
		private string? _i = default;
		[JsonInclude, JsonPropertyName("idc")]
		private string? _idc = default;
		[JsonInclude, JsonPropertyName("idti")]
		private string? _idti = default;
		[JsonInclude, JsonPropertyName("idto")]
		private string? _idto = default;
		[JsonInclude, JsonPropertyName("idx")]
		private string? _idx = default;
		[JsonInclude, JsonPropertyName("iic")]
		private string? _iic = default;
		[JsonInclude, JsonPropertyName("iif")]
		private string? _iif = default;
		[JsonInclude, JsonPropertyName("iiti")]
		private string? _iiti = default;
		[JsonInclude, JsonPropertyName("iito")]
		private string? _iito = default;
		[JsonInclude, JsonPropertyName("index")]
		private string? _index = default;
		[JsonInclude, JsonPropertyName("indexing.delete_current")]
		private string? _indexing_delete_current = default;
		[JsonInclude, JsonPropertyName("indexing.delete_time")]
		private string? _indexing_delete_time = default;
		[JsonInclude, JsonPropertyName("indexing.delete_total")]
		private string? _indexing_delete_total = default;
		[JsonInclude, JsonPropertyName("indexing.index_current")]
		private string? _indexing_index_current = default;
		[JsonInclude, JsonPropertyName("indexing.index_failed")]
		private string? _indexing_index_failed = default;
		[JsonInclude, JsonPropertyName("indexing.index_time")]
		private string? _indexing_index_time = default;
		[JsonInclude, JsonPropertyName("indexing.index_total")]
		private string? _indexing_index_total = default;
		[JsonInclude, JsonPropertyName("indexingDeleteCurrent")]
		private string? _indexingDeleteCurrent = default;
		[JsonInclude, JsonPropertyName("indexingDeleteTime")]
		private string? _indexingDeleteTime = default;
		[JsonInclude, JsonPropertyName("indexingDeleteTotal")]
		private string? _indexingDeleteTotal = default;
		[JsonInclude, JsonPropertyName("indexingIndexCurrent")]
		private string? _indexingIndexCurrent = default;
		[JsonInclude, JsonPropertyName("indexingIndexFailed")]
		private string? _indexingIndexFailed = default;
		[JsonInclude, JsonPropertyName("indexingIndexTime")]
		private string? _indexingIndexTime = default;
		[JsonInclude, JsonPropertyName("indexingIndexTotal")]
		private string? _indexingIndexTotal = default;
		[JsonInclude, JsonPropertyName("localCheckpoint")]
		private string? _localCheckpoint = default;
		[JsonInclude, JsonPropertyName("maxSeqNo")]
		private string? _maxSeqNo = default;
		[JsonInclude, JsonPropertyName("mc")]
		private string? _mc = default;
		[JsonInclude, JsonPropertyName("mcd")]
		private string? _mcd = default;
		[JsonInclude, JsonPropertyName("mcs")]
		private string? _mcs = default;
		[JsonInclude, JsonPropertyName("merges.current")]
		private string? _merges_current = default;
		[JsonInclude, JsonPropertyName("merges.current_docs")]
		private string? _merges_current_docs = default;
		[JsonInclude, JsonPropertyName("merges.current_size")]
		private string? _merges_current_size = default;
		[JsonInclude, JsonPropertyName("merges.total")]
		private string? _merges_total = default;
		[JsonInclude, JsonPropertyName("merges.total_docs")]
		private string? _merges_total_docs = default;
		[JsonInclude, JsonPropertyName("merges.total_size")]
		private string? _merges_total_size = default;
		[JsonInclude, JsonPropertyName("merges.total_time")]
		private string? _merges_total_time = default;
		[JsonInclude, JsonPropertyName("mergesCurrent")]
		private string? _mergesCurrent = default;
		[JsonInclude, JsonPropertyName("mergesCurrentDocs")]
		private string? _mergesCurrentDocs = default;
		[JsonInclude, JsonPropertyName("mergesCurrentSize")]
		private string? _mergesCurrentSize = default;
		[JsonInclude, JsonPropertyName("mergesTotal")]
		private string? _mergesTotal = default;
		[JsonInclude, JsonPropertyName("mergesTotalDocs")]
		private string? _mergesTotalDocs = default;
		[JsonInclude, JsonPropertyName("mergesTotalSize")]
		private string? _mergesTotalSize = default;
		[JsonInclude, JsonPropertyName("mergesTotalTime")]
		private string? _mergesTotalTime = default;
		[JsonInclude, JsonPropertyName("mt")]
		private string? _mt = default;
		[JsonInclude, JsonPropertyName("mtd")]
		private string? _mtd = default;
		[JsonInclude, JsonPropertyName("mts")]
		private string? _mts = default;
		[JsonInclude, JsonPropertyName("mtt")]
		private string? _mtt = default;
		[JsonInclude, JsonPropertyName("n")]
		private string? _n = default;
		[JsonInclude, JsonPropertyName("node")]
		private string? _node = default;
		[JsonInclude, JsonPropertyName("p")]
		private string? _p = default;
		[JsonInclude, JsonPropertyName("path.data")]
		private string? _path_data = default;
		[JsonInclude, JsonPropertyName("path.state")]
		private string? _path_state = default;
		[JsonInclude, JsonPropertyName("pd")]
		private string? _pd = default;
		[JsonInclude, JsonPropertyName("pr")]
		private string? _pr = default;
		[JsonInclude, JsonPropertyName("primaryOrReplica")]
		private string? _primaryOrReplica = default;
		[JsonInclude, JsonPropertyName("prirep")]
		private string? _prirep = default;
		[JsonInclude, JsonPropertyName("ps")]
		private string? _ps = default;
		[JsonInclude, JsonPropertyName("qce")]
		private string? _qce = default;
		[JsonInclude, JsonPropertyName("qcm")]
		private string? _qcm = default;
		[JsonInclude, JsonPropertyName("query_cache.evictions")]
		private string? _query_cache_evictions = default;
		[JsonInclude, JsonPropertyName("query_cache.memory_size")]
		private string? _query_cache_memory_size = default;
		[JsonInclude, JsonPropertyName("queryCacheEvictions")]
		private string? _queryCacheEvictions = default;
		[JsonInclude, JsonPropertyName("queryCacheMemory")]
		private string? _queryCacheMemory = default;
		[JsonInclude, JsonPropertyName("recoverysource.type")]
		private string? _recoverysource_type = default;
		[JsonInclude, JsonPropertyName("refresh.external_time")]
		private string? _refresh_external_time = default;
		[JsonInclude, JsonPropertyName("refresh.external_total")]
		private string? _refresh_external_total = default;
		[JsonInclude, JsonPropertyName("refresh.listeners")]
		private string? _refresh_listeners = default;
		[JsonInclude, JsonPropertyName("refreshListeners")]
		private string? _refreshListeners = default;
		[JsonInclude, JsonPropertyName("refreshTime")]
		private string? _refreshTime = default;
		[JsonInclude, JsonPropertyName("refreshTotal")]
		private string? _refreshTotal = default;
		[JsonInclude, JsonPropertyName("rli")]
		private string? _rli = default;
		[JsonInclude, JsonPropertyName("rs")]
		private string? _rs = default;
		[JsonInclude, JsonPropertyName("rti")]
		private string? _rti = default;
		[JsonInclude, JsonPropertyName("rto")]
		private string? _rto = default;
		[JsonInclude, JsonPropertyName("s")]
		private string? _s = default;
		[JsonInclude, JsonPropertyName("sc")]
		private string? _sc = default;
		[JsonInclude, JsonPropertyName("scc")]
		private string? _scc = default;
		[JsonInclude, JsonPropertyName("scti")]
		private string? _scti = default;
		[JsonInclude, JsonPropertyName("scto")]
		private string? _scto = default;
		[JsonInclude, JsonPropertyName("search.fetch_current")]
		private string? _search_fetch_current = default;
		[JsonInclude, JsonPropertyName("search.fetch_time")]
		private string? _search_fetch_time = default;
		[JsonInclude, JsonPropertyName("search.fetch_total")]
		private string? _search_fetch_total = default;
		[JsonInclude, JsonPropertyName("search.open_contexts")]
		private string? _search_open_contexts = default;
		[JsonInclude, JsonPropertyName("search.query_current")]
		private string? _search_query_current = default;
		[JsonInclude, JsonPropertyName("search.query_time")]
		private string? _search_query_time = default;
		[JsonInclude, JsonPropertyName("search.query_total")]
		private string? _search_query_total = default;
		[JsonInclude, JsonPropertyName("search.scroll_current")]
		private string? _search_scroll_current = default;
		[JsonInclude, JsonPropertyName("search.scroll_time")]
		private string? _search_scroll_time = default;
		[JsonInclude, JsonPropertyName("search.scroll_total")]
		private string? _search_scroll_total = default;
		[JsonInclude, JsonPropertyName("searchFetchCurrent")]
		private string? _searchFetchCurrent = default;
		[JsonInclude, JsonPropertyName("searchFetchTime")]
		private string? _searchFetchTime = default;
		[JsonInclude, JsonPropertyName("searchFetchTotal")]
		private string? _searchFetchTotal = default;
		[JsonInclude, JsonPropertyName("searchOpenContexts")]
		private string? _searchOpenContexts = default;
		[JsonInclude, JsonPropertyName("searchQueryCurrent")]
		private string? _searchQueryCurrent = default;
		[JsonInclude, JsonPropertyName("searchQueryTime")]
		private string? _searchQueryTime = default;
		[JsonInclude, JsonPropertyName("searchQueryTotal")]
		private string? _searchQueryTotal = default;
		[JsonInclude, JsonPropertyName("searchScrollCurrent")]
		private string? _searchScrollCurrent = default;
		[JsonInclude, JsonPropertyName("searchScrollTime")]
		private string? _searchScrollTime = default;
		[JsonInclude, JsonPropertyName("searchScrollTotal")]
		private string? _searchScrollTotal = default;
		[JsonInclude, JsonPropertyName("segments.count")]
		private string? _segments_count = default;
		[JsonInclude, JsonPropertyName("segments.fixed_bitset_memory")]
		private string? _segments_fixed_bitset_memory = default;
		[JsonInclude, JsonPropertyName("segments.index_writer_memory")]
		private string? _segments_index_writer_memory = default;
		[JsonInclude, JsonPropertyName("segments.memory")]
		private string? _segments_memory = default;
		[JsonInclude, JsonPropertyName("segments.version_map_memory")]
		private string? _segments_version_map_memory = default;
		[JsonInclude, JsonPropertyName("segmentsCount")]
		private string? _segmentsCount = default;
		[JsonInclude, JsonPropertyName("segmentsIndexWriterMemory")]
		private string? _segmentsIndexWriterMemory = default;
		[JsonInclude, JsonPropertyName("segmentsMemory")]
		private string? _segmentsMemory = default;
		[JsonInclude, JsonPropertyName("segmentsVersionMapMemory")]
		private string? _segmentsVersionMapMemory = default;
		[JsonInclude, JsonPropertyName("seq_no.global_checkpoint")]
		private string? _seq_no_global_checkpoint = default;
		[JsonInclude, JsonPropertyName("seq_no.local_checkpoint")]
		private string? _seq_no_local_checkpoint = default;
		[JsonInclude, JsonPropertyName("seq_no.max")]
		private string? _seq_no_max = default;
		[JsonInclude, JsonPropertyName("sfbm")]
		private string? _sfbm = default;
		[JsonInclude, JsonPropertyName("sfc")]
		private string? _sfc = default;
		[JsonInclude, JsonPropertyName("sfti")]
		private string? _sfti = default;
		[JsonInclude, JsonPropertyName("sfto")]
		private string? _sfto = default;
		[JsonInclude, JsonPropertyName("sh")]
		private string? _sh = default;
		[JsonInclude, JsonPropertyName("shard")]
		private string? _shard = default;
		[JsonInclude, JsonPropertyName("siwm")]
		private string? _siwm = default;
		[JsonInclude, JsonPropertyName("sm")]
		private string? _sm = default;
		[JsonInclude, JsonPropertyName("so")]
		private string? _so = default;
		[JsonInclude, JsonPropertyName("sqc")]
		private string? _sqc = default;
		[JsonInclude, JsonPropertyName("sqg")]
		private string? _sqg = default;
		[JsonInclude, JsonPropertyName("sql")]
		private string? _sql = default;
		[JsonInclude, JsonPropertyName("sqm")]
		private string? _sqm = default;
		[JsonInclude, JsonPropertyName("sqti")]
		private string? _sqti = default;
		[JsonInclude, JsonPropertyName("sqto")]
		private string? _sqto = default;
		[JsonInclude, JsonPropertyName("st")]
		private string? _st = default;
		[JsonInclude, JsonPropertyName("state")]
		private string? _state = default;
		[JsonInclude, JsonPropertyName("statsPath")]
		private string? _statsPath = default;
		[JsonInclude, JsonPropertyName("sto")]
		private string? _sto = default;
		[JsonInclude, JsonPropertyName("store")]
		private string? _store = default;
		[JsonInclude, JsonPropertyName("svmm")]
		private string? _svmm = default;
		[JsonInclude, JsonPropertyName("ua")]
		private string? _ua = default;
		[JsonInclude, JsonPropertyName("ud")]
		private string? _ud = default;
		[JsonInclude, JsonPropertyName("uf")]
		private string? _uf = default;
		[JsonInclude, JsonPropertyName("unassigned.at")]
		private string? _unassigned_at = default;
		[JsonInclude, JsonPropertyName("unassigned.details")]
		private string? _unassigned_details = default;
		[JsonInclude, JsonPropertyName("unassigned.for")]
		private string? _unassigned_for = default;
		[JsonInclude, JsonPropertyName("unassigned.reason")]
		private string? _unassigned_reason = default;
		[JsonInclude, JsonPropertyName("ur")]
		private string? _ur = default;
		[JsonInclude, JsonPropertyName("warmer.current")]
		private string? _warmer_current = default;
		[JsonInclude, JsonPropertyName("warmer.total")]
		private string? _warmer_total = default;
		[JsonInclude, JsonPropertyName("warmer.total_time")]
		private string? _warmer_total_time = default;
		[JsonInclude, JsonPropertyName("warmerCurrent")]
		private string? _warmerCurrent = default;
		[JsonInclude, JsonPropertyName("warmerTotal")]
		private string? _warmerTotal = default;
		[JsonInclude, JsonPropertyName("warmerTotalTime")]
		private string? _warmerTotalTime = default;
		[JsonInclude, JsonPropertyName("wc")]
		private string? _wc = default;
		[JsonInclude, JsonPropertyName("wto")]
		private string? _wto = default;
		[JsonInclude, JsonPropertyName("wtt")]
		private string? _wtt = default;
		public string? BulkAvgSizeInBytes => _bulk_avg_size_in_bytes ?? _basi ?? _bulkAvgSizeInBytes;
		public string? BulkAvgTime => _bulk_avg_time ?? _bati ?? _bulkAvgTime;
		public string? BulkTotalOperations => _bulk_total_operations ?? _bto ?? _bulkTotalOperations;
		public string? BulkTotalSizeInBytes => _bulk_total_size_in_bytes ?? _btsi ?? _bulkTotalSizeInBytes;
		public string? BulkTotalTime => _bulk_total_time ?? _btti ?? _bulkTotalTime;
		public string? CompletionSize => _completion_size ?? _cs ?? _completionSize;
		public string? Docs => _docs ?? _d ?? _dc;
		public string? FielddataEvictions => _fielddata_evictions ?? _fe ?? _fielddataEvictions;
		public string? FielddataMemorySize => _fielddata_memory_size ?? _fm ?? _fielddataMemory;
		public string? FlushTotal => _flush_total ?? _ft ?? _flushTotal;
		public string? FlushTotalTime => _flush_total_time ?? _ftt ?? _flushTotalTime;
		public string? GetCurrent => _get_current ?? _gc ?? _getCurrent;
		public string? GetExistsTime => _get_exists_time ?? _geti ?? _getExistsTime;
		public string? GetExistsTotal => _get_exists_total ?? _geto ?? _getExistsTotal;
		public string? GetMissingTime => _get_missing_time ?? _gmti ?? _getMissingTime;
		public string? GetMissingTotal => _get_missing_total ?? _gmto ?? _getMissingTotal;
		public string? GetTime => _get_time ?? _gti ?? _getTime;
		public string? GetTotal => _get_total ?? _gto ?? _getTotal;
		[JsonPropertyName("id")]
		public string? Id
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		public string? Index => _index ?? _i ?? _idx;
		public string? IndexingDeleteCurrent => _indexing_delete_current ?? _idc ?? _indexingDeleteCurrent;
		public string? IndexingDeleteTime => _indexing_delete_time ?? _idti ?? _indexingDeleteTime;
		public string? IndexingDeleteTotal => _indexing_delete_total ?? _idto ?? _indexingDeleteTotal;
		public string? IndexingIndexCurrent => _indexing_index_current ?? _iic ?? _indexingIndexCurrent;
		public string? IndexingIndexFailed => _indexing_index_failed ?? _iif ?? _indexingIndexFailed;
		public string? IndexingIndexTime => _indexing_index_time ?? _iiti ?? _indexingIndexTime;
		public string? IndexingIndexTotal => _indexing_index_total ?? _iito ?? _indexingIndexTotal;
		[JsonPropertyName("ip")]
		public string? Ip
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		public string? MergesCurrent => _merges_current ?? _mc ?? _mergesCurrent;
		public string? MergesCurrentDocs => _merges_current_docs ?? _mcd ?? _mergesCurrentDocs;
		public string? MergesCurrentSize => _merges_current_size ?? _mcs ?? _mergesCurrentSize;
		public string? MergesTotal => _merges_total ?? _mt ?? _mergesTotal;
		public string? MergesTotalDocs => _merges_total_docs ?? _mtd ?? _mergesTotalDocs;
		public string? MergesTotalSize => _merges_total_size ?? _mts ?? _mergesTotalSize;
		public string? MergesTotalTime => _merges_total_time ?? _mtt ?? _mergesTotalTime;
		public string? Node => _n ?? _node;
		public string? PathData => _path_data ?? _pd ?? _dataPath;
		public string? PathState => _path_state ?? _ps ?? _statsPath;
		public string? Prirep => _prirep ?? _primaryOrReplica ?? _p ?? _pr;
		public string? QueryCacheEvictions => _query_cache_evictions ?? _qce ?? _queryCacheEvictions;
		public string? QueryCacheMemorySize => _query_cache_memory_size ?? _qcm ?? _queryCacheMemory;
		public string? RecoverysourceType => _rs ?? _recoverysource_type;
		public string? RefreshExternalTime => _refresh_external_time ?? _rti ?? _refreshTime;
		public string? RefreshExternalTotal => _refresh_external_total ?? _rto ?? _refreshTotal;
		public string? RefreshListeners => _refresh_listeners ?? _rli ?? _refreshListeners;
		[JsonPropertyName("refresh.time")]
		public string? RefreshTime
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("refresh.total")]
		public string? RefreshTotal
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		public string? SearchFetchCurrent => _search_fetch_current ?? _sfc ?? _searchFetchCurrent;
		public string? SearchFetchTime => _search_fetch_time ?? _sfti ?? _searchFetchTime;
		public string? SearchFetchTotal => _search_fetch_total ?? _sfto ?? _searchFetchTotal;
		public string? SearchOpenContexts => _search_open_contexts ?? _so ?? _searchOpenContexts;
		public string? SearchQueryCurrent => _search_query_current ?? _sqc ?? _searchQueryCurrent;
		public string? SearchQueryTime => _search_query_time ?? _sqti ?? _searchQueryTime;
		public string? SearchQueryTotal => _search_query_total ?? _sqto ?? _searchQueryTotal;
		public string? SearchScrollCurrent => _search_scroll_current ?? _scc ?? _searchScrollCurrent;
		public string? SearchScrollTime => _search_scroll_time ?? _scti ?? _searchScrollTime;
		public string? SearchScrollTotal => _search_scroll_total ?? _scto ?? _searchScrollTotal;
		public string? SegmentsCount => _segments_count ?? _sc ?? _segmentsCount;
		public string? SegmentsFixedBitsetMemory => _segments_fixed_bitset_memory ?? _sfbm ?? _fixedBitsetMemory;
		public string? SegmentsIndexWriterMemory => _segments_index_writer_memory ?? _siwm ?? _segmentsIndexWriterMemory;
		public string? SegmentsMemory => _segments_memory ?? _sm ?? _segmentsMemory;
		public string? SegmentsVersionMapMemory => _segments_version_map_memory ?? _svmm ?? _segmentsVersionMapMemory;
		public string? SeqNoGlobalCheckpoint => _seq_no_global_checkpoint ?? _sqg ?? _globalCheckpoint;
		public string? SeqNoLocalCheckpoint => _seq_no_local_checkpoint ?? _sql ?? _localCheckpoint;
		public string? SeqNoMax => _seq_no_max ?? _sqm ?? _maxSeqNo;
		public string? Shard => _shard ?? _s ?? _sh;
		public string? State => _st ?? _state;
		public string? Store => _sto ?? _store;
		[JsonPropertyName("sync_id")]
		public string? SyncId
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		public string? UnassignedAt => _ua ?? _unassigned_at;
		public string? UnassignedDetails => _ud ?? _unassigned_details;
		public string? UnassignedFor => _uf ?? _unassigned_for;
		public string? UnassignedReason => _ur ?? _unassigned_reason;
		public string? WarmerCurrent => _warmer_current ?? _wc ?? _warmerCurrent;
		public string? WarmerTotal => _warmer_total ?? _wto ?? _warmerTotal;
		public string? WarmerTotalTime => _warmer_total_time ?? _wtt ?? _warmerTotalTime;
	}
}