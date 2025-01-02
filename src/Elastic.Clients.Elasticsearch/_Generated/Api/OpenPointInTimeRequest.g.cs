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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch;

public sealed partial class OpenPointInTimeRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If <c>false</c>, creating a point in time request when a shard is missing or unavailable will throw an exception.
	/// If <c>true</c>, the point in time will contain all the shards that are available at the time of the request.
	/// </para>
	/// </summary>
	public bool? AllowPartialSearchResults { get => Q<bool?>("allow_partial_search_results"); set => Q("allow_partial_search_results", value); }

	/// <summary>
	/// <para>
	/// Type of index that wildcard patterns can match.
	/// If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.
	/// Supports comma-separated values, such as <c>open,hidden</c>. Valid values are: <c>all</c>, <c>open</c>, <c>closed</c>, <c>hidden</c>, <c>none</c>.
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>
	/// If <c>false</c>, the request returns an error if it targets a missing or closed index.
	/// </para>
	/// </summary>
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>
	/// Extends the time to live of the corresponding point in time.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration KeepAlive { get => Q<Elastic.Clients.Elasticsearch.Duration>("keep_alive"); set => Q("keep_alive", value); }

	/// <summary>
	/// <para>
	/// Specifies the node or shard the operation should be performed on.
	/// Random by default.
	/// </para>
	/// </summary>
	public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

	/// <summary>
	/// <para>
	/// Custom value used to route operations to a specific shard.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }
}

/// <summary>
/// <para>
/// Open a point in time.
/// </para>
/// <para>
/// A search request by default runs against the most recent visible data of the target indices,
/// which is called point in time. Elasticsearch pit (point in time) is a lightweight view into the
/// state of the data as it existed when initiated. In some cases, it’s preferred to perform multiple
/// search requests using the same point in time. For example, if refreshes happen between
/// <c>search_after</c> requests, then the results of those requests might not be consistent as changes happening
/// between searches are only visible to the more recent point in time.
/// </para>
/// <para>
/// A point in time must be opened explicitly before being used in search requests.
/// The <c>keep_alive</c> parameter tells Elasticsearch how long it should persist.
/// </para>
/// </summary>
public sealed partial class OpenPointInTimeRequest : PlainRequest<OpenPointInTimeRequestParameters>
{
	public OpenPointInTimeRequest(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceOpenPointInTime;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "open_point_in_time";

	/// <summary>
	/// <para>
	/// If <c>false</c>, creating a point in time request when a shard is missing or unavailable will throw an exception.
	/// If <c>true</c>, the point in time will contain all the shards that are available at the time of the request.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? AllowPartialSearchResults { get => Q<bool?>("allow_partial_search_results"); set => Q("allow_partial_search_results", value); }

	/// <summary>
	/// <para>
	/// Type of index that wildcard patterns can match.
	/// If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.
	/// Supports comma-separated values, such as <c>open,hidden</c>. Valid values are: <c>all</c>, <c>open</c>, <c>closed</c>, <c>hidden</c>, <c>none</c>.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>
	/// If <c>false</c>, the request returns an error if it targets a missing or closed index.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>
	/// Extends the time to live of the corresponding point in time.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration KeepAlive { get => Q<Elastic.Clients.Elasticsearch.Duration>("keep_alive"); set => Q("keep_alive", value); }

	/// <summary>
	/// <para>
	/// Specifies the node or shard the operation should be performed on.
	/// Random by default.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

	/// <summary>
	/// <para>
	/// Custom value used to route operations to a specific shard.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>
	/// Allows to filter indices if the provided query rewrites to <c>match_none</c> on every shard.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index_filter")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Query? IndexFilter { get; set; }
}

/// <summary>
/// <para>
/// Open a point in time.
/// </para>
/// <para>
/// A search request by default runs against the most recent visible data of the target indices,
/// which is called point in time. Elasticsearch pit (point in time) is a lightweight view into the
/// state of the data as it existed when initiated. In some cases, it’s preferred to perform multiple
/// search requests using the same point in time. For example, if refreshes happen between
/// <c>search_after</c> requests, then the results of those requests might not be consistent as changes happening
/// between searches are only visible to the more recent point in time.
/// </para>
/// <para>
/// A point in time must be opened explicitly before being used in search requests.
/// The <c>keep_alive</c> parameter tells Elasticsearch how long it should persist.
/// </para>
/// </summary>
public sealed partial class OpenPointInTimeRequestDescriptor<TDocument> : RequestDescriptor<OpenPointInTimeRequestDescriptor<TDocument>, OpenPointInTimeRequestParameters>
{
	internal OpenPointInTimeRequestDescriptor(Action<OpenPointInTimeRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public OpenPointInTimeRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	public OpenPointInTimeRequestDescriptor() : this(typeof(TDocument))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceOpenPointInTime;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "open_point_in_time";

	public OpenPointInTimeRequestDescriptor<TDocument> AllowPartialSearchResults(bool? allowPartialSearchResults = true) => Qs("allow_partial_search_results", allowPartialSearchResults);
	public OpenPointInTimeRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public OpenPointInTimeRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public OpenPointInTimeRequestDescriptor<TDocument> KeepAlive(Elastic.Clients.Elasticsearch.Duration keepAlive) => Qs("keep_alive", keepAlive);
	public OpenPointInTimeRequestDescriptor<TDocument> Preference(string? preference) => Qs("preference", preference);
	public OpenPointInTimeRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);

	public OpenPointInTimeRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.Query? IndexFilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> IndexFilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> IndexFilterDescriptorAction { get; set; }

	/// <summary>
	/// <para>
	/// Allows to filter indices if the provided query rewrites to <c>match_none</c> on every shard.
	/// </para>
	/// </summary>
	public OpenPointInTimeRequestDescriptor<TDocument> IndexFilter(Elastic.Clients.Elasticsearch.QueryDsl.Query? indexFilter)
	{
		IndexFilterDescriptor = null;
		IndexFilterDescriptorAction = null;
		IndexFilterValue = indexFilter;
		return Self;
	}

	public OpenPointInTimeRequestDescriptor<TDocument> IndexFilter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		IndexFilterValue = null;
		IndexFilterDescriptorAction = null;
		IndexFilterDescriptor = descriptor;
		return Self;
	}

	public OpenPointInTimeRequestDescriptor<TDocument> IndexFilter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		IndexFilterValue = null;
		IndexFilterDescriptor = null;
		IndexFilterDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IndexFilterDescriptor is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, IndexFilterDescriptor, options);
		}
		else if (IndexFilterDescriptorAction is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(IndexFilterDescriptorAction), options);
		}
		else if (IndexFilterValue is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, IndexFilterValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Open a point in time.
/// </para>
/// <para>
/// A search request by default runs against the most recent visible data of the target indices,
/// which is called point in time. Elasticsearch pit (point in time) is a lightweight view into the
/// state of the data as it existed when initiated. In some cases, it’s preferred to perform multiple
/// search requests using the same point in time. For example, if refreshes happen between
/// <c>search_after</c> requests, then the results of those requests might not be consistent as changes happening
/// between searches are only visible to the more recent point in time.
/// </para>
/// <para>
/// A point in time must be opened explicitly before being used in search requests.
/// The <c>keep_alive</c> parameter tells Elasticsearch how long it should persist.
/// </para>
/// </summary>
public sealed partial class OpenPointInTimeRequestDescriptor : RequestDescriptor<OpenPointInTimeRequestDescriptor, OpenPointInTimeRequestParameters>
{
	internal OpenPointInTimeRequestDescriptor(Action<OpenPointInTimeRequestDescriptor> configure) => configure.Invoke(this);

	public OpenPointInTimeRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceOpenPointInTime;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "open_point_in_time";

	public OpenPointInTimeRequestDescriptor AllowPartialSearchResults(bool? allowPartialSearchResults = true) => Qs("allow_partial_search_results", allowPartialSearchResults);
	public OpenPointInTimeRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public OpenPointInTimeRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public OpenPointInTimeRequestDescriptor KeepAlive(Elastic.Clients.Elasticsearch.Duration keepAlive) => Qs("keep_alive", keepAlive);
	public OpenPointInTimeRequestDescriptor Preference(string? preference) => Qs("preference", preference);
	public OpenPointInTimeRequestDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);

	public OpenPointInTimeRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.Query? IndexFilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor IndexFilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> IndexFilterDescriptorAction { get; set; }

	/// <summary>
	/// <para>
	/// Allows to filter indices if the provided query rewrites to <c>match_none</c> on every shard.
	/// </para>
	/// </summary>
	public OpenPointInTimeRequestDescriptor IndexFilter(Elastic.Clients.Elasticsearch.QueryDsl.Query? indexFilter)
	{
		IndexFilterDescriptor = null;
		IndexFilterDescriptorAction = null;
		IndexFilterValue = indexFilter;
		return Self;
	}

	public OpenPointInTimeRequestDescriptor IndexFilter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor descriptor)
	{
		IndexFilterValue = null;
		IndexFilterDescriptorAction = null;
		IndexFilterDescriptor = descriptor;
		return Self;
	}

	public OpenPointInTimeRequestDescriptor IndexFilter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> configure)
	{
		IndexFilterValue = null;
		IndexFilterDescriptor = null;
		IndexFilterDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IndexFilterDescriptor is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, IndexFilterDescriptor, options);
		}
		else if (IndexFilterDescriptorAction is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(IndexFilterDescriptorAction), options);
		}
		else if (IndexFilterValue is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, IndexFilterValue, options);
		}

		writer.WriteEndObject();
	}
}