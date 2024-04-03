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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Core.HealthReport;

public sealed partial class DiskIndicatorDetails
{
	[JsonInclude, JsonPropertyName("indices_with_readonly_block")]
	public long IndicesWithReadonlyBlock { get; init; }
	[JsonInclude, JsonPropertyName("nodes_over_flood_stage_watermark")]
	public long NodesOverFloodStageWatermark { get; init; }
	[JsonInclude, JsonPropertyName("nodes_over_high_watermark")]
	public long NodesOverHighWatermark { get; init; }
	[JsonInclude, JsonPropertyName("nodes_with_enough_disk_space")]
	public long NodesWithEnoughDiskSpace { get; init; }
	[JsonInclude, JsonPropertyName("nodes_with_unknown_disk_status")]
	public long NodesWithUnknownDiskStatus { get; init; }
}