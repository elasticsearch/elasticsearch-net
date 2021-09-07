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

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster.Stats
{
	public partial class CharFilterTypes
	{
		[JsonPropertyName("analyzer_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypes> AnalyzerTypes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("built_in_analyzers")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypes> BuiltInAnalyzers
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("built_in_char_filters")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypes> BuiltInCharFilters
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("built_in_filters")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypes> BuiltInFilters
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("built_in_tokenizers")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypes> BuiltInTokenizers
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("filter_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypes> FilterTypes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("tokenizer_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypes> TokenizerTypes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterFileSystem
	{
		[JsonPropertyName("available_in_bytes")]
		public long AvailableInBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("free_in_bytes")]
		public long FreeInBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total_in_bytes")]
		public long TotalInBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterIndices
	{
		[JsonPropertyName("analysis")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.CharFilterTypes Analysis
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("completion")]
		public Elastic.Clients.Elasticsearch.CompletionStats Completion
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("count")]
		public long Count
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("docs")]
		public Elastic.Clients.Elasticsearch.DocStats Docs
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("fielddata")]
		public Elastic.Clients.Elasticsearch.FielddataStats Fielddata
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("mappings")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypesMappings Mappings
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("query_cache")]
		public Elastic.Clients.Elasticsearch.QueryCacheStats QueryCache
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("segments")]
		public Elastic.Clients.Elasticsearch.SegmentsStats Segments
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("shards")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterIndicesShards Shards
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("store")]
		public Elastic.Clients.Elasticsearch.StoreStats Store
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("versions")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.IndicesVersions>? Versions
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterIndicesShards
	{
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterIndicesShardsIndex? Index
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("primaries")]
		public double? Primaries
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("replication")]
		public double? Replication
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total")]
		public double? Total
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterIndicesShardsIndex
	{
		[JsonPropertyName("primaries")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterShardMetrics Primaries
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("replication")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterShardMetrics Replication
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("shards")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterShardMetrics Shards
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterIngest
	{
		[JsonPropertyName("number_of_pipelines")]
		public int NumberOfPipelines
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("processor_stats")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterProcessor> ProcessorStats
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterJvm
	{
		[JsonPropertyName("max_uptime_in_millis")]
		public long MaxUptimeInMillis
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("mem")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterJvmMemory Mem
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("threads")]
		public long Threads
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("versions")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterJvmVersion> Versions
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterJvmMemory
	{
		[JsonPropertyName("heap_max_in_bytes")]
		public long HeapMaxInBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("heap_used_in_bytes")]
		public long HeapUsedInBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterJvmVersion
	{
		[JsonPropertyName("bundled_jdk")]
		public bool BundledJdk
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("count")]
		public int Count
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("using_bundled_jdk")]
		public bool UsingBundledJdk
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("version")]
		public Elastic.Clients.Elasticsearch.VersionString Version
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("vm_name")]
		public string VmName
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("vm_vendor")]
		public string VmVendor
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("vm_version")]
		public Elastic.Clients.Elasticsearch.VersionString VmVersion
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterNetworkTypes
	{
		[JsonPropertyName("http_types")]
		public Dictionary<string, int> HttpTypes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("transport_types")]
		public Dictionary<string, int> TransportTypes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterNodeCount
	{
		[JsonPropertyName("coordinating_only")]
		public int CoordinatingOnly
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data")]
		public int Data
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_cold")]
		public int DataCold
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_content")]
		public int DataContent
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_frozen")]
		public int? DataFrozen
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_hot")]
		public int DataHot
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_warm")]
		public int DataWarm
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("ingest")]
		public int Ingest
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("master")]
		public int Master
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("ml")]
		public int Ml
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("remote_cluster_client")]
		public int RemoteClusterClient
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total")]
		public int Total
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("transform")]
		public int Transform
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("voting_only")]
		public int VotingOnly
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterNodes
	{
		[JsonPropertyName("count")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterNodeCount Count
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("discovery_types")]
		public Dictionary<string, int> DiscoveryTypes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("fs")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterFileSystem Fs
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("ingest")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterIngest Ingest
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("jvm")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterJvm Jvm
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("network_types")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterNetworkTypes NetworkTypes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("os")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterOperatingSystem Os
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("packaging_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.NodePackagingType> PackagingTypes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("plugins")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.PluginStats> Plugins
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("process")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterProcess Process
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("versions")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.VersionString> Versions
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterOperatingSystem
	{
		[JsonPropertyName("allocated_processors")]
		public int AllocatedProcessors
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("architectures")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterOperatingSystemArchitecture>? Architectures
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("available_processors")]
		public int AvailableProcessors
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("mem")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.OperatingSystemMemoryInfo Mem
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("names")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterOperatingSystemName> Names
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("pretty_names")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterOperatingSystemName> PrettyNames
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterOperatingSystemArchitecture
	{
		[JsonPropertyName("arch")]
		public string Arch
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("count")]
		public int Count
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterOperatingSystemName
	{
		[JsonPropertyName("count")]
		public int Count
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterProcess
	{
		[JsonPropertyName("cpu")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterProcessCpu Cpu
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("open_file_descriptors")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterProcessOpenFileDescriptors OpenFileDescriptors
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterProcessCpu
	{
		[JsonPropertyName("percent")]
		public int Percent
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterProcessOpenFileDescriptors
	{
		[JsonPropertyName("avg")]
		public long Avg
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("max")]
		public long Max
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("min")]
		public long Min
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterProcessor
	{
		[JsonPropertyName("count")]
		public long Count
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("current")]
		public long Current
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("failed")]
		public long Failed
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("time_in_millis")]
		public long TimeInMillis
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterShardMetrics
	{
		[JsonPropertyName("avg")]
		public double Avg
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("max")]
		public double Max
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("min")]
		public double Min
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class FieldTypes
	{
		[JsonPropertyName("count")]
		public int Count
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("index_count")]
		public int IndexCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("script_count")]
		public int? ScriptCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class FieldTypesMappings
	{
		[JsonPropertyName("field_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypes> FieldTypes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("runtime_field_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.RuntimeFieldTypes>? RuntimeFieldTypes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class IndicesVersions
	{
		[JsonPropertyName("index_count")]
		public int IndexCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("primary_shard_count")]
		public int PrimaryShardCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total_primary_bytes")]
		public long TotalPrimaryBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("version")]
		public Elastic.Clients.Elasticsearch.VersionString Version
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NodePackagingType
	{
		[JsonPropertyName("count")]
		public int Count
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("flavor")]
		public string Flavor
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("type")]
		public string Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class OperatingSystemMemoryInfo
	{
		[JsonPropertyName("free_in_bytes")]
		public long FreeInBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("free_percent")]
		public int FreePercent
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total_in_bytes")]
		public long TotalInBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("used_in_bytes")]
		public long UsedInBytes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("used_percent")]
		public int UsedPercent
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class RuntimeFieldTypes
	{
		[JsonPropertyName("chars_max")]
		public int CharsMax
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("chars_total")]
		public int CharsTotal
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("count")]
		public int Count
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("doc_max")]
		public int DocMax
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("doc_total")]
		public int DocTotal
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("index_count")]
		public int IndexCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("lang")]
		public IReadOnlyCollection<string> Lang
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("lines_max")]
		public int LinesMax
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("lines_total")]
		public int LinesTotal
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("scriptless_count")]
		public int ScriptlessCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("shadowed_count")]
		public int ShadowedCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("source_max")]
		public int SourceMax
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("source_total")]
		public int SourceTotal
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}
}