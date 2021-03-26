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
	public class CatHealthRecord
	{
		[JsonInclude, JsonPropertyName("active_shards_percent")]
		private string? _active_shards_percent = default;
		[JsonInclude, JsonPropertyName("activeShardsPercent")]
		private string? _activeShardsPercent = default;
		[JsonInclude, JsonPropertyName("asp")]
		private string? _asp = default;
		[JsonInclude, JsonPropertyName("cl")]
		private string? _cl = default;
		[JsonInclude, JsonPropertyName("cluster")]
		private string? _cluster = default;
		[JsonInclude, JsonPropertyName("epoch")]
		private EpochMillis? _epoch = default;
		[JsonInclude, JsonPropertyName("hhmmss")]
		private DateString? _hhmmss = default;
		[JsonInclude, JsonPropertyName("hms")]
		private DateString? _hms = default;
		[JsonInclude, JsonPropertyName("i")]
		private string? _i = default;
		[JsonInclude, JsonPropertyName("init")]
		private string? _init = default;
		[JsonInclude, JsonPropertyName("max_task_wait_time")]
		private string? _max_task_wait_time = default;
		[JsonInclude, JsonPropertyName("maxTaskWaitTime")]
		private string? _maxTaskWaitTime = default;
		[JsonInclude, JsonPropertyName("mtwt")]
		private string? _mtwt = default;
		[JsonInclude, JsonPropertyName("nd")]
		private string? _nd = default;
		[JsonInclude, JsonPropertyName("node.data")]
		private string? _node_data = default;
		[JsonInclude, JsonPropertyName("node.total")]
		private string? _node_total = default;
		[JsonInclude, JsonPropertyName("nodeData")]
		private string? _nodeData = default;
		[JsonInclude, JsonPropertyName("nodeTotal")]
		private string? _nodeTotal = default;
		[JsonInclude, JsonPropertyName("nt")]
		private string? _nt = default;
		[JsonInclude, JsonPropertyName("p")]
		private string? _p = default;
		[JsonInclude, JsonPropertyName("pending_tasks")]
		private string? _pending_tasks = default;
		[JsonInclude, JsonPropertyName("pendingTasks")]
		private string? _pendingTasks = default;
		[JsonInclude, JsonPropertyName("pri")]
		private string? _pri = default;
		[JsonInclude, JsonPropertyName("pt")]
		private string? _pt = default;
		[JsonInclude, JsonPropertyName("r")]
		private string? _r = default;
		[JsonInclude, JsonPropertyName("relo")]
		private string? _relo = default;
		[JsonInclude, JsonPropertyName("sh")]
		private string? _sh = default;
		[JsonInclude, JsonPropertyName("shards")]
		private string? _shards = default;
		[JsonInclude, JsonPropertyName("shards.initializing")]
		private string? _shards_initializing = default;
		[JsonInclude, JsonPropertyName("shards.primary")]
		private string? _shards_primary = default;
		[JsonInclude, JsonPropertyName("shards.relocating")]
		private string? _shards_relocating = default;
		[JsonInclude, JsonPropertyName("shards.total")]
		private string? _shards_total = default;
		[JsonInclude, JsonPropertyName("shards.unassigned")]
		private string? _shards_unassigned = default;
		[JsonInclude, JsonPropertyName("shardsInitializing")]
		private string? _shardsInitializing = default;
		[JsonInclude, JsonPropertyName("shardsPrimary")]
		private string? _shardsPrimary = default;
		[JsonInclude, JsonPropertyName("shardsRelocating")]
		private string? _shardsRelocating = default;
		[JsonInclude, JsonPropertyName("shardsTotal")]
		private string? _shardsTotal = default;
		[JsonInclude, JsonPropertyName("shardsUnassigned")]
		private string? _shardsUnassigned = default;
		[JsonInclude, JsonPropertyName("st")]
		private string? _st = default;
		[JsonInclude, JsonPropertyName("status")]
		private string? _status = default;
		[JsonInclude, JsonPropertyName("t")]
		private string? _t = default;
		[JsonInclude, JsonPropertyName("time")]
		private EpochMillis? _time = default;
		[JsonInclude, JsonPropertyName("timestamp")]
		private DateString? _timestamp = default;
		[JsonInclude, JsonPropertyName("ts")]
		private DateString? _ts = default;
		[JsonInclude, JsonPropertyName("u")]
		private string? _u = default;
		[JsonInclude, JsonPropertyName("unassign")]
		private string? _unassign = default;
		public string? ActiveShardsPercent => _active_shards_percent ?? _asp ?? _activeShardsPercent;
		public string? Cluster => _cl ?? _cluster;
		public EpochMillis? Epoch => _time ?? _epoch;
		public string? Init => _init ?? _shardsInitializing ?? _i ?? _shards_initializing;
		public string? MaxTaskWaitTime => _max_task_wait_time ?? _mtwt ?? _maxTaskWaitTime;
		public string? NodeData => _node_data ?? _nd ?? _nodeData;
		public string? NodeTotal => _node_total ?? _nt ?? _nodeTotal;
		public string? PendingTasks => _pending_tasks ?? _pt ?? _pendingTasks;
		public string? Pri => _pri ?? _shardsPrimary ?? _p ?? _shards_primary;
		public string? Relo => _relo ?? _shardsRelocating ?? _r ?? _shards_relocating;
		public string? Shards => _shards ?? _shardsTotal ?? _shards_total ?? _t ?? _sh;
		public string? Status => _st ?? _status;
		public DateString? Timestamp => _timestamp ?? _hhmmss ?? _ts ?? _hms;
		public string? Unassign => _unassign ?? _shardsUnassigned ?? _u ?? _shards_unassigned;
	}
}