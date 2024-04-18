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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class TotalFeatureImportanceStatistics
{
	/// <summary>
	/// <para>The maximum importance value across all the training data for this feature.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("max")]
	public int Max { get; init; }

	/// <summary>
	/// <para>The average magnitude of this feature across all the training data. This value is the average of the absolute values of the importance for this feature.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("mean_magnitude")]
	public double MeanMagnitude { get; init; }

	/// <summary>
	/// <para>The minimum importance value across all the training data for this feature.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("min")]
	public int Min { get; init; }
}