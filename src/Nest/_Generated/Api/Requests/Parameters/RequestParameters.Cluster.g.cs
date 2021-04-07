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
    public class ClusterAllocationExplainRequestParameters : RequestParameters<ClusterAllocationExplainRequestParameters>
    {
        public bool? IncludeDiskInfo { get => Q<bool?>("include_disk_info"); set => Q("include_disk_info", value); }

        public bool? IncludeYesDecisions { get => Q<bool?>("include_yes_decisions"); set => Q("include_yes_decisions", value); }
    }

    public class ClusterHealthRequestParameters : RequestParameters<ClusterHealthRequestParameters>
    {
        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public Level? Level { get => Q<Level?>("level"); set => Q("level", value); }

        public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }

        public WaitForActiveShards? WaitForActiveShards { get => Q<WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

        public WaitForEvents? WaitForEvents { get => Q<WaitForEvents?>("wait_for_events"); set => Q("wait_for_events", value); }

        public string? WaitForNodes { get => Q<string?>("wait_for_nodes"); set => Q("wait_for_nodes", value); }

        public bool? WaitForNoInitializingShards { get => Q<bool?>("wait_for_no_initializing_shards"); set => Q("wait_for_no_initializing_shards", value); }

        public bool? WaitForNoRelocatingShards { get => Q<bool?>("wait_for_no_relocating_shards"); set => Q("wait_for_no_relocating_shards", value); }

        public WaitForStatus? WaitForStatus { get => Q<WaitForStatus?>("wait_for_status"); set => Q("wait_for_status", value); }
    }
}