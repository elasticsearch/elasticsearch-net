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

#nullable restore

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using Elastic.Transport;
using Elastic.Clients.Elasticsearch.Serialization;

namespace Elastic.Clients.Elasticsearch.Cluster;

[JsonConverter(typeof(AllocationExplainDecisionConverter))]
public enum AllocationExplainDecision
{
	[EnumMember(Value = "YES")]
	Yes,
	[EnumMember(Value = "THROTTLE")]
	Throttle,
	[EnumMember(Value = "NO")]
	No,
	[EnumMember(Value = "ALWAYS")]
	Always
}

internal sealed class AllocationExplainDecisionConverter : JsonConverter<AllocationExplainDecision>
{
	public override AllocationExplainDecision Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "YES":
				return AllocationExplainDecision.Yes;
			case "THROTTLE":
				return AllocationExplainDecision.Throttle;
			case "NO":
				return AllocationExplainDecision.No;
			case "ALWAYS":
				return AllocationExplainDecision.Always;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, AllocationExplainDecision value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case AllocationExplainDecision.Yes:
				writer.WriteStringValue("YES");
				return;
			case AllocationExplainDecision.Throttle:
				writer.WriteStringValue("THROTTLE");
				return;
			case AllocationExplainDecision.No:
				writer.WriteStringValue("NO");
				return;
			case AllocationExplainDecision.Always:
				writer.WriteStringValue("ALWAYS");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(DecisionConverter))]
public enum Decision
{
	[EnumMember(Value = "yes")]
	Yes,
	[EnumMember(Value = "worse_balance")]
	WorseBalance,
	[EnumMember(Value = "throttled")]
	Throttled,
	[EnumMember(Value = "no_valid_shard_copy")]
	NoValidShardCopy,
	[EnumMember(Value = "no_attempt")]
	NoAttempt,
	[EnumMember(Value = "no")]
	No,
	[EnumMember(Value = "awaiting_info")]
	AwaitingInfo,
	[EnumMember(Value = "allocation_delayed")]
	AllocationDelayed
}

internal sealed class DecisionConverter : JsonConverter<Decision>
{
	public override Decision Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "yes":
				return Decision.Yes;
			case "worse_balance":
				return Decision.WorseBalance;
			case "throttled":
				return Decision.Throttled;
			case "no_valid_shard_copy":
				return Decision.NoValidShardCopy;
			case "no_attempt":
				return Decision.NoAttempt;
			case "no":
				return Decision.No;
			case "awaiting_info":
				return Decision.AwaitingInfo;
			case "allocation_delayed":
				return Decision.AllocationDelayed;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, Decision value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case Decision.Yes:
				writer.WriteStringValue("yes");
				return;
			case Decision.WorseBalance:
				writer.WriteStringValue("worse_balance");
				return;
			case Decision.Throttled:
				writer.WriteStringValue("throttled");
				return;
			case Decision.NoValidShardCopy:
				writer.WriteStringValue("no_valid_shard_copy");
				return;
			case Decision.NoAttempt:
				writer.WriteStringValue("no_attempt");
				return;
			case Decision.No:
				writer.WriteStringValue("no");
				return;
			case Decision.AwaitingInfo:
				writer.WriteStringValue("awaiting_info");
				return;
			case Decision.AllocationDelayed:
				writer.WriteStringValue("allocation_delayed");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(UnassignedInformationReasonConverter))]
public enum UnassignedInformationReason
{
	[EnumMember(Value = "REROUTE_CANCELLED")]
	RerouteCancelled,
	[EnumMember(Value = "REPLICA_ADDED")]
	ReplicaAdded,
	[EnumMember(Value = "REINITIALIZED")]
	Reinitialized,
	[EnumMember(Value = "REALLOCATED_REPLICA")]
	ReallocatedReplica,
	[EnumMember(Value = "PRIMARY_FAILED")]
	PrimaryFailed,
	[EnumMember(Value = "NODE_LEFT")]
	NodeLeft,
	[EnumMember(Value = "NEW_INDEX_RESTORED")]
	NewIndexRestored,
	[EnumMember(Value = "MANUAL_ALLOCATION")]
	ManualAllocation,
	[EnumMember(Value = "INDEX_REOPENED")]
	IndexReopened,
	[EnumMember(Value = "INDEX_CREATED")]
	IndexCreated,
	[EnumMember(Value = "FORCED_EMPTY_PRIMARY")]
	ForcedEmptyPrimary,
	[EnumMember(Value = "EXISTING_INDEX_RESTORED")]
	ExistingIndexRestored,
	[EnumMember(Value = "DANGLING_INDEX_IMPORTED")]
	DanglingIndexImported,
	[EnumMember(Value = "CLUSTER_RECOVERED")]
	ClusterRecovered,
	[EnumMember(Value = "ALLOCATION_FAILED")]
	AllocationFailed
}

internal sealed class UnassignedInformationReasonConverter : JsonConverter<UnassignedInformationReason>
{
	public override UnassignedInformationReason Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "REROUTE_CANCELLED":
				return UnassignedInformationReason.RerouteCancelled;
			case "REPLICA_ADDED":
				return UnassignedInformationReason.ReplicaAdded;
			case "REINITIALIZED":
				return UnassignedInformationReason.Reinitialized;
			case "REALLOCATED_REPLICA":
				return UnassignedInformationReason.ReallocatedReplica;
			case "PRIMARY_FAILED":
				return UnassignedInformationReason.PrimaryFailed;
			case "NODE_LEFT":
				return UnassignedInformationReason.NodeLeft;
			case "NEW_INDEX_RESTORED":
				return UnassignedInformationReason.NewIndexRestored;
			case "MANUAL_ALLOCATION":
				return UnassignedInformationReason.ManualAllocation;
			case "INDEX_REOPENED":
				return UnassignedInformationReason.IndexReopened;
			case "INDEX_CREATED":
				return UnassignedInformationReason.IndexCreated;
			case "FORCED_EMPTY_PRIMARY":
				return UnassignedInformationReason.ForcedEmptyPrimary;
			case "EXISTING_INDEX_RESTORED":
				return UnassignedInformationReason.ExistingIndexRestored;
			case "DANGLING_INDEX_IMPORTED":
				return UnassignedInformationReason.DanglingIndexImported;
			case "CLUSTER_RECOVERED":
				return UnassignedInformationReason.ClusterRecovered;
			case "ALLOCATION_FAILED":
				return UnassignedInformationReason.AllocationFailed;
		}

		ThrowHelper.ThrowJsonException(); return default;
	}

	public override void Write(Utf8JsonWriter writer, UnassignedInformationReason value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case UnassignedInformationReason.RerouteCancelled:
				writer.WriteStringValue("REROUTE_CANCELLED");
				return;
			case UnassignedInformationReason.ReplicaAdded:
				writer.WriteStringValue("REPLICA_ADDED");
				return;
			case UnassignedInformationReason.Reinitialized:
				writer.WriteStringValue("REINITIALIZED");
				return;
			case UnassignedInformationReason.ReallocatedReplica:
				writer.WriteStringValue("REALLOCATED_REPLICA");
				return;
			case UnassignedInformationReason.PrimaryFailed:
				writer.WriteStringValue("PRIMARY_FAILED");
				return;
			case UnassignedInformationReason.NodeLeft:
				writer.WriteStringValue("NODE_LEFT");
				return;
			case UnassignedInformationReason.NewIndexRestored:
				writer.WriteStringValue("NEW_INDEX_RESTORED");
				return;
			case UnassignedInformationReason.ManualAllocation:
				writer.WriteStringValue("MANUAL_ALLOCATION");
				return;
			case UnassignedInformationReason.IndexReopened:
				writer.WriteStringValue("INDEX_REOPENED");
				return;
			case UnassignedInformationReason.IndexCreated:
				writer.WriteStringValue("INDEX_CREATED");
				return;
			case UnassignedInformationReason.ForcedEmptyPrimary:
				writer.WriteStringValue("FORCED_EMPTY_PRIMARY");
				return;
			case UnassignedInformationReason.ExistingIndexRestored:
				writer.WriteStringValue("EXISTING_INDEX_RESTORED");
				return;
			case UnassignedInformationReason.DanglingIndexImported:
				writer.WriteStringValue("DANGLING_INDEX_IMPORTED");
				return;
			case UnassignedInformationReason.ClusterRecovered:
				writer.WriteStringValue("CLUSTER_RECOVERED");
				return;
			case UnassignedInformationReason.AllocationFailed:
				writer.WriteStringValue("ALLOCATION_FAILED");
				return;
		}

		writer.WriteNullValue();
	}
}