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

namespace Elastic.Clients.Elasticsearch.Serverless.Core.FieldCaps;

public sealed partial class FieldCapability
{
	/// <summary>
	/// <para>Whether this field can be aggregated on all indices.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("aggregatable")]
	public bool Aggregatable { get; init; }

	/// <summary>
	/// <para>The list of indices where this field has the same type family, or null if all indices have the same type family for the field.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("indices")]
	public Elastic.Clients.Elasticsearch.Serverless.Indices? Indices { get; init; }

	/// <summary>
	/// <para>Merged metadata across all indices as a map of string keys to arrays of values. A value length of 1 indicates that all indices had the same value for this key, while a length of 2 or more indicates that not all indices had the same value for this key.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("meta")]
	public IReadOnlyDictionary<string, object>? Meta { get; init; }

	/// <summary>
	/// <para>Whether this field is registered as a metadata field.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("metadata_field")]
	public bool? MetadataField { get; init; }

	/// <summary>
	/// <para>The list of indices where this field is present if these indices<br/>don’t have the same `time_series_metric` value for this field.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("metric_conflicts_indices")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.IndexName>? MetricConflictsIndices { get; init; }

	/// <summary>
	/// <para>The list of indices where this field is not aggregatable, or null if all indices have the same definition for the field.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("non_aggregatable_indices")]
	public Elastic.Clients.Elasticsearch.Serverless.Indices? NonAggregatableIndices { get; init; }

	/// <summary>
	/// <para>If this list is present in response then some indices have the<br/>field marked as a dimension and other indices, the ones in this list, do not.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("non_dimension_indices")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.IndexName>? NonDimensionIndices { get; init; }

	/// <summary>
	/// <para>The list of indices where this field is not searchable, or null if all indices have the same definition for the field.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("non_searchable_indices")]
	public Elastic.Clients.Elasticsearch.Serverless.Indices? NonSearchableIndices { get; init; }

	/// <summary>
	/// <para>Whether this field is indexed for search on all indices.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("searchable")]
	public bool Searchable { get; init; }

	/// <summary>
	/// <para>Whether this field is used as a time series dimension.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("time_series_dimension")]
	public bool? TimeSeriesDimension { get; init; }

	/// <summary>
	/// <para>Contains metric type if this fields is used as a time series<br/>metrics, absent if the field is not used as metric.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("time_series_metric")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.TimeSeriesMetricType? TimeSeriesMetric { get; init; }
	[JsonInclude, JsonPropertyName("type")]
	public string Type { get; init; }
}