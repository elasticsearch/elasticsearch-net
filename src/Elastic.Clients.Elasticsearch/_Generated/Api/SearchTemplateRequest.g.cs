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

public sealed partial class SearchTemplateRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If <c>false</c>, the request returns an error if any wildcard expression, index alias, or <c>_all</c> value targets only missing or closed indices.
	/// This behavior applies even if the request targets other open indices.
	/// For example, a request targeting <c>foo*,bar*</c> returns an error if an index starts with <c>foo</c> but no index starts with <c>bar</c>.
	/// </para>
	/// </summary>
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, network round-trips are minimized for cross-cluster search requests.
	/// </para>
	/// </summary>
	public bool? CcsMinimizeRoundtrips { get => Q<bool?>("ccs_minimize_roundtrips"); set => Q("ccs_minimize_roundtrips", value); }

	/// <summary>
	/// <para>
	/// Type of index that wildcard patterns can match.
	/// If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.
	/// Supports comma-separated values, such as <c>open,hidden</c>.
	/// Valid values are: <c>all</c>, <c>open</c>, <c>closed</c>, <c>hidden</c>, <c>none</c>.
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, specified concrete, expanded, or aliased indices are not included in the response when throttled.
	/// </para>
	/// </summary>
	public bool? IgnoreThrottled { get => Q<bool?>("ignore_throttled"); set => Q("ignore_throttled", value); }

	/// <summary>
	/// <para>
	/// If <c>false</c>, the request returns an error if it targets a missing or closed index.
	/// </para>
	/// </summary>
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>
	/// Specifies the node or shard the operation should be performed on.
	/// Random by default.
	/// </para>
	/// </summary>
	public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

	/// <summary>
	/// <para>
	/// If true, hits.total are rendered as an integer in the response.
	/// </para>
	/// </summary>
	public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

	/// <summary>
	/// <para>
	/// Custom value used to route operations to a specific shard.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>
	/// Specifies how long a consistent view of the index
	/// should be maintained for scrolled search.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Scroll { get => Q<Elastic.Clients.Elasticsearch.Duration?>("scroll"); set => Q("scroll", value); }

	/// <summary>
	/// <para>
	/// The type of the search operation.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.SearchType? SearchType { get => Q<Elastic.Clients.Elasticsearch.SearchType?>("search_type"); set => Q("search_type", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the response prefixes aggregation and suggester names with their respective types.
	/// </para>
	/// </summary>
	public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }
}

/// <summary>
/// <para>
/// Run a search with a search template.
/// </para>
/// </summary>
public sealed partial class SearchTemplateRequest : PlainRequest<SearchTemplateRequestParameters>
{
	[JsonConstructor]
	public SearchTemplateRequest()
	{
	}

	public SearchTemplateRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceSearchTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "search_template";

	/// <summary>
	/// <para>
	/// Comma-separated list of data streams, indices,
	/// and aliases to search. Supports wildcards (*).
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Indices? Indices { get => P<Elastic.Clients.Elasticsearch.Indices?>("index"); set => PO("index", value); }

	/// <summary>
	/// <para>
	/// If <c>false</c>, the request returns an error if any wildcard expression, index alias, or <c>_all</c> value targets only missing or closed indices.
	/// This behavior applies even if the request targets other open indices.
	/// For example, a request targeting <c>foo*,bar*</c> returns an error if an index starts with <c>foo</c> but no index starts with <c>bar</c>.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, network round-trips are minimized for cross-cluster search requests.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? CcsMinimizeRoundtrips { get => Q<bool?>("ccs_minimize_roundtrips"); set => Q("ccs_minimize_roundtrips", value); }

	/// <summary>
	/// <para>
	/// Type of index that wildcard patterns can match.
	/// If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.
	/// Supports comma-separated values, such as <c>open,hidden</c>.
	/// Valid values are: <c>all</c>, <c>open</c>, <c>closed</c>, <c>hidden</c>, <c>none</c>.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, specified concrete, expanded, or aliased indices are not included in the response when throttled.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? IgnoreThrottled { get => Q<bool?>("ignore_throttled"); set => Q("ignore_throttled", value); }

	/// <summary>
	/// <para>
	/// If <c>false</c>, the request returns an error if it targets a missing or closed index.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

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
	/// If true, hits.total are rendered as an integer in the response.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

	/// <summary>
	/// <para>
	/// Custom value used to route operations to a specific shard.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>
	/// Specifies how long a consistent view of the index
	/// should be maintained for scrolled search.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Scroll { get => Q<Elastic.Clients.Elasticsearch.Duration?>("scroll"); set => Q("scroll", value); }

	/// <summary>
	/// <para>
	/// The type of the search operation.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.SearchType? SearchType { get => Q<Elastic.Clients.Elasticsearch.SearchType?>("search_type"); set => Q("search_type", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the response prefixes aggregation and suggester names with their respective types.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }

	/// <summary>
	/// <para>
	/// If <c>true</c>, returns detailed information about score calculation as part of each hit.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("explain")]
	public bool? Explain { get; set; }

	/// <summary>
	/// <para>
	/// ID of the search template to use. If no source is specified,
	/// this parameter is required.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("id")]
	public Elastic.Clients.Elasticsearch.Id? Id { get; set; }

	/// <summary>
	/// <para>
	/// Key-value pairs used to replace Mustache variables in the template.
	/// The key is the variable name.
	/// The value is the variable value.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("params")]
	public IDictionary<string, object>? Params { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the query execution is profiled.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("profile")]
	public bool? Profile { get; set; }

	/// <summary>
	/// <para>
	/// An inline search template. Supports the same parameters as the search API's
	/// request body. Also supports Mustache variables. If no id is specified, this
	/// parameter is required.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("source")]
	public string? Source { get; set; }
}

/// <summary>
/// <para>
/// Run a search with a search template.
/// </para>
/// </summary>
public sealed partial class SearchTemplateRequestDescriptor<TDocument> : RequestDescriptor<SearchTemplateRequestDescriptor<TDocument>, SearchTemplateRequestParameters>
{
	internal SearchTemplateRequestDescriptor(Action<SearchTemplateRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public SearchTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	public SearchTemplateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceSearchTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "search_template";

	public SearchTemplateRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public SearchTemplateRequestDescriptor<TDocument> CcsMinimizeRoundtrips(bool? ccsMinimizeRoundtrips = true) => Qs("ccs_minimize_roundtrips", ccsMinimizeRoundtrips);
	public SearchTemplateRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public SearchTemplateRequestDescriptor<TDocument> IgnoreThrottled(bool? ignoreThrottled = true) => Qs("ignore_throttled", ignoreThrottled);
	public SearchTemplateRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public SearchTemplateRequestDescriptor<TDocument> Preference(string? preference) => Qs("preference", preference);
	public SearchTemplateRequestDescriptor<TDocument> RestTotalHitsAsInt(bool? restTotalHitsAsInt = true) => Qs("rest_total_hits_as_int", restTotalHitsAsInt);
	public SearchTemplateRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public SearchTemplateRequestDescriptor<TDocument> Scroll(Elastic.Clients.Elasticsearch.Duration? scroll) => Qs("scroll", scroll);
	public SearchTemplateRequestDescriptor<TDocument> SearchType(Elastic.Clients.Elasticsearch.SearchType? searchType) => Qs("search_type", searchType);
	public SearchTemplateRequestDescriptor<TDocument> TypedKeys(bool? typedKeys = true) => Qs("typed_keys", typedKeys);

	public SearchTemplateRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	private bool? ExplainValue { get; set; }
	private Elastic.Clients.Elasticsearch.Id? IdValue { get; set; }
	private IDictionary<string, object>? ParamsValue { get; set; }
	private bool? ProfileValue { get; set; }
	private string? SourceValue { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, returns detailed information about score calculation as part of each hit.
	/// </para>
	/// </summary>
	public SearchTemplateRequestDescriptor<TDocument> Explain(bool? explain = true)
	{
		ExplainValue = explain;
		return Self;
	}

	/// <summary>
	/// <para>
	/// ID of the search template to use. If no source is specified,
	/// this parameter is required.
	/// </para>
	/// </summary>
	public SearchTemplateRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id? id)
	{
		IdValue = id;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Key-value pairs used to replace Mustache variables in the template.
	/// The key is the variable name.
	/// The value is the variable value.
	/// </para>
	/// </summary>
	public SearchTemplateRequestDescriptor<TDocument> Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, the query execution is profiled.
	/// </para>
	/// </summary>
	public SearchTemplateRequestDescriptor<TDocument> Profile(bool? profile = true)
	{
		ProfileValue = profile;
		return Self;
	}

	/// <summary>
	/// <para>
	/// An inline search template. Supports the same parameters as the search API's
	/// request body. Also supports Mustache variables. If no id is specified, this
	/// parameter is required.
	/// </para>
	/// </summary>
	public SearchTemplateRequestDescriptor<TDocument> Source(string? source)
	{
		SourceValue = source;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ExplainValue.HasValue)
		{
			writer.WritePropertyName("explain");
			writer.WriteBooleanValue(ExplainValue.Value);
		}

		if (IdValue is not null)
		{
			writer.WritePropertyName("id");
			JsonSerializer.Serialize(writer, IdValue, options);
		}

		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (ProfileValue.HasValue)
		{
			writer.WritePropertyName("profile");
			writer.WriteBooleanValue(ProfileValue.Value);
		}

		if (!string.IsNullOrEmpty(SourceValue))
		{
			writer.WritePropertyName("source");
			writer.WriteStringValue(SourceValue);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Run a search with a search template.
/// </para>
/// </summary>
public sealed partial class SearchTemplateRequestDescriptor : RequestDescriptor<SearchTemplateRequestDescriptor, SearchTemplateRequestParameters>
{
	internal SearchTemplateRequestDescriptor(Action<SearchTemplateRequestDescriptor> configure) => configure.Invoke(this);

	public SearchTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	public SearchTemplateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceSearchTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "search_template";

	public SearchTemplateRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public SearchTemplateRequestDescriptor CcsMinimizeRoundtrips(bool? ccsMinimizeRoundtrips = true) => Qs("ccs_minimize_roundtrips", ccsMinimizeRoundtrips);
	public SearchTemplateRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public SearchTemplateRequestDescriptor IgnoreThrottled(bool? ignoreThrottled = true) => Qs("ignore_throttled", ignoreThrottled);
	public SearchTemplateRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public SearchTemplateRequestDescriptor Preference(string? preference) => Qs("preference", preference);
	public SearchTemplateRequestDescriptor RestTotalHitsAsInt(bool? restTotalHitsAsInt = true) => Qs("rest_total_hits_as_int", restTotalHitsAsInt);
	public SearchTemplateRequestDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public SearchTemplateRequestDescriptor Scroll(Elastic.Clients.Elasticsearch.Duration? scroll) => Qs("scroll", scroll);
	public SearchTemplateRequestDescriptor SearchType(Elastic.Clients.Elasticsearch.SearchType? searchType) => Qs("search_type", searchType);
	public SearchTemplateRequestDescriptor TypedKeys(bool? typedKeys = true) => Qs("typed_keys", typedKeys);

	public SearchTemplateRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	private bool? ExplainValue { get; set; }
	private Elastic.Clients.Elasticsearch.Id? IdValue { get; set; }
	private IDictionary<string, object>? ParamsValue { get; set; }
	private bool? ProfileValue { get; set; }
	private string? SourceValue { get; set; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, returns detailed information about score calculation as part of each hit.
	/// </para>
	/// </summary>
	public SearchTemplateRequestDescriptor Explain(bool? explain = true)
	{
		ExplainValue = explain;
		return Self;
	}

	/// <summary>
	/// <para>
	/// ID of the search template to use. If no source is specified,
	/// this parameter is required.
	/// </para>
	/// </summary>
	public SearchTemplateRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id? id)
	{
		IdValue = id;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Key-value pairs used to replace Mustache variables in the template.
	/// The key is the variable name.
	/// The value is the variable value.
	/// </para>
	/// </summary>
	public SearchTemplateRequestDescriptor Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// If <c>true</c>, the query execution is profiled.
	/// </para>
	/// </summary>
	public SearchTemplateRequestDescriptor Profile(bool? profile = true)
	{
		ProfileValue = profile;
		return Self;
	}

	/// <summary>
	/// <para>
	/// An inline search template. Supports the same parameters as the search API's
	/// request body. Also supports Mustache variables. If no id is specified, this
	/// parameter is required.
	/// </para>
	/// </summary>
	public SearchTemplateRequestDescriptor Source(string? source)
	{
		SourceValue = source;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ExplainValue.HasValue)
		{
			writer.WritePropertyName("explain");
			writer.WriteBooleanValue(ExplainValue.Value);
		}

		if (IdValue is not null)
		{
			writer.WritePropertyName("id");
			JsonSerializer.Serialize(writer, IdValue, options);
		}

		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (ProfileValue.HasValue)
		{
			writer.WritePropertyName("profile");
			writer.WriteBooleanValue(ProfileValue.Value);
		}

		if (!string.IsNullOrEmpty(SourceValue))
		{
			writer.WritePropertyName("source");
			writer.WriteStringValue(SourceValue);
		}

		writer.WriteEndObject();
	}
}