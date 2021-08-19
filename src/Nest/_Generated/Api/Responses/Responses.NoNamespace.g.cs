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

using OneOf;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest
{
	public partial class ClearScrollResponse : ResponseBase
	{
		[JsonPropertyName("num_freed")]
		public int NumFreed
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("succeeded")]
		public bool Succeeded
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClosePointInTimeResponse : ResponseBase
	{
		[JsonPropertyName("num_freed")]
		public int NumFreed
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("succeeded")]
		public bool Succeeded
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class CountResponse : ResponseBase
	{
		[JsonPropertyName("count")]
		public long Count
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_shards")]
		public Nest.ShardStatistics Shards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class CreateResponse : WriteResponseBase
	{
	}

	public partial class DeleteResponse : WriteResponseBase
	{
	}

	public partial class DeleteByQueryResponse : ResponseBase
	{
		[JsonPropertyName("batches")]
		public long? Batches
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("deleted")]
		public long? Deleted
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("failures")]
		public IReadOnlyCollection<Nest.BulkIndexByScrollFailure>? Failures
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("noops")]
		public long? Noops
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("requests_per_second")]
		public float? RequestsPerSecond
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("retries")]
		public Nest.Retries? Retries
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("slice_id")]
		public int? SliceId
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("task")]
		public Nest.TaskId? Task
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("throttled_millis")]
		public long? ThrottledMillis
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("throttled_until_millis")]
		public long? ThrottledUntilMillis
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("timed_out")]
		public bool? TimedOut
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("took")]
		public long? Took
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total")]
		public long? Total
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("version_conflicts")]
		public long? VersionConflicts
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ExistsResponse : ExistsResponseBase
	{
	}

	public partial class ExistsSourceResponse : ResponseBase
	{
	}

	public partial class ExplainResponse<TDocument> : ResponseBase
	{
		[JsonPropertyName("explanation")]
		public Nest.Global.Explain.ExplanationDetail? Explanation
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("get")]
		public Nest.InlineGet<TDocument>? Get
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_id")]
		public Nest.Id Id
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_index")]
		public Nest.IndexName Index
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("matched")]
		public bool Matched
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_type")]
		public Nest.DocType? Type
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class FieldCapsResponse : ResponseBase
	{
		[JsonPropertyName("fields")]
		public Dictionary<Nest.Field, Dictionary<string, Nest.Global.FieldCaps.FieldCapability>> Fields
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("indices")]
		public Nest.Indices Indices
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class GetResponse<TDocument> : ResponseBase
	{
		[JsonPropertyName("fields")]
		public Dictionary<string, object>? Fields
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("found")]
		public bool Found
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_id")]
		public Nest.Id Id
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_index")]
		public Nest.IndexName Index
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_primary_term")]
		public long? PrimaryTerm
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_routing")]
		public string? Routing
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_seq_no")]
		public Nest.SequenceNumber? SeqNo
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_source")]
		public TDocument? Source
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_type")]
		public Nest.DocType? Type
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_version")]
		public Nest.VersionNumber? Version
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class GetScriptResponse : ResponseBase
	{
		[JsonPropertyName("found")]
		public bool Found
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_id")]
		public Nest.Id Id
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("script")]
		public Nest.StoredScript? Script
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class GetScriptContextResponse : ResponseBase
	{
		[JsonPropertyName("contexts")]
		public IReadOnlyCollection<Nest.Global.GetScriptContext.Context> Contexts
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class GetScriptLanguagesResponse : ResponseBase
	{
		[JsonPropertyName("language_contexts")]
		public IReadOnlyCollection<Nest.Global.GetScriptLanguages.LanguageContext> LanguageContexts
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("types_allowed")]
		public IReadOnlyCollection<string> TypesAllowed
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class IndexResponse : WriteResponseBase
	{
	}

	public partial class InfoResponse : ResponseBase
	{
		[JsonPropertyName("cluster_name")]
		public Nest.Name ClusterName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("cluster_uuid")]
		public Nest.Uuid ClusterUuid
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("name")]
		public Nest.Name Name
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("tagline")]
		public string Tagline
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("version")]
		public Nest.ElasticsearchVersionInfo Version
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class OpenPointInTimeResponse : ResponseBase
	{
		[JsonPropertyName("id")]
		public Nest.Id Id
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class PingResponse : ResponseBase
	{
	}

	public partial class PutScriptResponse : AcknowledgedResponseBase
	{
	}

	public partial class ReindexResponse : ResponseBase
	{
		[JsonPropertyName("batches")]
		public long? Batches
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("created")]
		public long? Created
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("deleted")]
		public long? Deleted
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("failures")]
		public IReadOnlyCollection<Nest.BulkIndexByScrollFailure>? Failures
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("noops")]
		public long? Noops
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("requests_per_second")]
		public long? RequestsPerSecond
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("retries")]
		public Nest.Retries? Retries
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("slice_id")]
		public int? SliceId
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("task")]
		public Nest.TaskId? Task
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("throttled_millis")]
		public Nest.EpochMillis? ThrottledMillis
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("throttled_until_millis")]
		public Nest.EpochMillis? ThrottledUntilMillis
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("timed_out")]
		public bool? TimedOut
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("took")]
		public Nest.Time? Took
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total")]
		public long? Total
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("updated")]
		public long? Updated
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("version_conflicts")]
		public long? VersionConflicts
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ReindexRethrottleResponse : ResponseBase
	{
		[JsonPropertyName("nodes")]
		public Dictionary<string, Nest.Global.ReindexRethrottle.ReindexNode> Nodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class RenderSearchTemplateResponse : ResponseBase
	{
		[JsonPropertyName("template_output")]
		public Dictionary<string, object> TemplateOutput
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ScrollResponse<TDocument> : ResponseBase
	{
	}

	public partial class SearchResponse<TDocument> : ResponseBase
	{
		[JsonPropertyName("aggregations")]
		public Dictionary<Nest.AggregateName, Nest.Aggregations.Aggregate>? Aggregations
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_clusters")]
		public Nest.ClusterStatistics? Clusters
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("documents")]
		public IReadOnlyCollection<TDocument>? Documents
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("fields")]
		public Dictionary<string, object>? Fields
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("hits")]
		public Nest.Global.Search.HitsMetadata<TDocument> Hits
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("max_score")]
		public double? MaxScore
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("num_reduce_phases")]
		public long? NumReducePhases
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("pit_id")]
		public Nest.Id? PitId
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("profile")]
		public Nest.Global.Search.Profile? Profile
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_scroll_id")]
		public Nest.ScrollId? ScrollId
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_shards")]
		public Nest.ShardStatistics Shards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("suggest")]
		public Dictionary<Nest.SuggestionName, IReadOnlyCollection<Nest.Global.Search.Suggest<TDocument>>>? Suggest
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("terminated_early")]
		public bool? TerminatedEarly
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("timed_out")]
		public bool TimedOut
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("took")]
		public long Took
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class SearchShardsResponse : ResponseBase
	{
		[JsonPropertyName("indices")]
		public Dictionary<Nest.IndexName, Nest.Global.SearchShards.ShardStoreIndex> Indices
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Dictionary<string, Nest.NodeAttributes> Nodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("shards")]
		public IReadOnlyCollection<IReadOnlyCollection<Nest.NodeShard>> Shards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class SearchTemplateResponse<TDocument> : ResponseBase
	{
		[JsonPropertyName("hits")]
		public Nest.Global.Search.HitsMetadata<TDocument> Hits
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_shards")]
		public Nest.ShardStatistics Shards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("timed_out")]
		public bool TimedOut
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("took")]
		public int Took
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class TermsEnumResponse : ResponseBase
	{
		[JsonPropertyName("complete")]
		public bool Complete
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_shards")]
		public Nest.ShardStatistics Shards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("terms")]
		public IReadOnlyCollection<string> Terms
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class TermvectorsResponse : ResponseBase
	{
		[JsonPropertyName("found")]
		public bool Found
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_id")]
		public Nest.Id Id
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_index")]
		public Nest.IndexName Index
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("term_vectors")]
		public Dictionary<Nest.Field, Nest.Global.Termvectors.TermVector>? TermVectors
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("took")]
		public long Took
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_type")]
		public Nest.DocType? Type
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_version")]
		public Nest.VersionNumber Version
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class UpdateResponse<TDocument> : WriteResponseBase
	{
		[JsonPropertyName("get")]
		public Nest.InlineGet<TDocument>? Get
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}
}