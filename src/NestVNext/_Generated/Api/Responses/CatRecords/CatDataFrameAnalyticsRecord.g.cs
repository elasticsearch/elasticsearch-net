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

using System.Text.Json.Serialization;

#nullable restore
namespace Nest
{
	public class CatDataFrameAnalyticsRecord
	{
		[JsonInclude, JsonPropertyName("ae")]
		private string? _ae = default;
		[JsonInclude, JsonPropertyName("assignment_explanation")]
		private string? _assignment_explanation = default;
		[JsonInclude, JsonPropertyName("assignmentExplanation")]
		private string? _assignmentExplanation = default;
		[JsonInclude, JsonPropertyName("create_time")]
		private string? _create_time = default;
		[JsonInclude, JsonPropertyName("createTime")]
		private string? _createTime = default;
		[JsonInclude, JsonPropertyName("ct")]
		private string? _ct = default;
		[JsonInclude, JsonPropertyName("d")]
		private string? _d = default;
		[JsonInclude, JsonPropertyName("description")]
		private string? _description = default;
		[JsonInclude, JsonPropertyName("dest_index")]
		private string? _dest_index = default;
		[JsonInclude, JsonPropertyName("destIndex")]
		private string? _destIndex = default;
		[JsonInclude, JsonPropertyName("di")]
		private string? _di = default;
		[JsonInclude, JsonPropertyName("failure_reason")]
		private string? _failure_reason = default;
		[JsonInclude, JsonPropertyName("failureReason")]
		private string? _failureReason = default;
		[JsonInclude, JsonPropertyName("fr")]
		private string? _fr = default;
		[JsonInclude, JsonPropertyName("mml")]
		private string? _mml = default;
		[JsonInclude, JsonPropertyName("model_memory_limit")]
		private string? _model_memory_limit = default;
		[JsonInclude, JsonPropertyName("modelMemoryLimit")]
		private string? _modelMemoryLimit = default;
		[JsonInclude, JsonPropertyName("na")]
		private string? _na = default;
		[JsonInclude, JsonPropertyName("ne")]
		private string? _ne = default;
		[JsonInclude, JsonPropertyName("ni")]
		private string? _ni = default;
		[JsonInclude, JsonPropertyName("nn")]
		private string? _nn = default;
		[JsonInclude, JsonPropertyName("node.address")]
		private string? _node_address = default;
		[JsonInclude, JsonPropertyName("node.ephemeral_id")]
		private string? _node_ephemeral_id = default;
		[JsonInclude, JsonPropertyName("node.id")]
		private string? _node_id = default;
		[JsonInclude, JsonPropertyName("node.name")]
		private string? _node_name = default;
		[JsonInclude, JsonPropertyName("nodeAddress")]
		private string? _nodeAddress = default;
		[JsonInclude, JsonPropertyName("nodeEphemeralId")]
		private string? _nodeEphemeralId = default;
		[JsonInclude, JsonPropertyName("nodeId")]
		private string? _nodeId = default;
		[JsonInclude, JsonPropertyName("nodeName")]
		private string? _nodeName = default;
		[JsonInclude, JsonPropertyName("p")]
		private string? _p = default;
		[JsonInclude, JsonPropertyName("progress")]
		private string? _progress = default;
		[JsonInclude, JsonPropertyName("s")]
		private string? _s = default;
		[JsonInclude, JsonPropertyName("si")]
		private string? _si = default;
		[JsonInclude, JsonPropertyName("source_index")]
		private string? _source_index = default;
		[JsonInclude, JsonPropertyName("sourceIndex")]
		private string? _sourceIndex = default;
		[JsonInclude, JsonPropertyName("state")]
		private string? _state = default;
		[JsonInclude, JsonPropertyName("t")]
		private string? _t = default;
		[JsonInclude, JsonPropertyName("type")]
		private string? _type = default;
		[JsonInclude, JsonPropertyName("v")]
		private string? _v = default;
		[JsonInclude, JsonPropertyName("version")]
		private string? _version = default;
		public string? AssignmentExplanation => _assignment_explanation ?? _ae ?? _assignmentExplanation;
		public string? CreateTime => _create_time ?? _ct ?? _createTime;
		public string? Description => _d ?? _description;
		public string? DestIndex => _dest_index ?? _di ?? _destIndex;
		public string? FailureReason => _failure_reason ?? _fr ?? _failureReason;
		[JsonPropertyName("id")]
		public string Id
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		public string? ModelMemoryLimit => _model_memory_limit ?? _mml ?? _modelMemoryLimit;
		public string? NodeAddress => _node_address ?? _na ?? _nodeAddress;
		public string? NodeEphemeralId => _node_ephemeral_id ?? _ne ?? _nodeEphemeralId;
		public string? NodeId => _node_id ?? _ni ?? _nodeId;
		public string? NodeName => _node_name ?? _nn ?? _nodeName;
		public string? Progress => _p ?? _progress;
		public string? SourceIndex => _source_index ?? _si ?? _sourceIndex;
		public string? State => _s ?? _state;
		public string? Type => _t ?? _type;
		public string? Version => _v ?? _version;
	}
}