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
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Elastic.Clients.Elasticsearch.Serverless;

public sealed class MultiSearchTemplateRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Indicates whether network round-trips should be minimized as part of cross-cluster search requests execution</para>
	/// </summary>
	public bool? CcsMinimizeRoundtrips { get => Q<bool?>("ccs_minimize_roundtrips"); set => Q("ccs_minimize_roundtrips", value); }

	/// <summary>
	/// <para>Controls the maximum number of concurrent searches the multi search api will execute</para>
	/// </summary>
	public long? MaxConcurrentSearches { get => Q<long?>("max_concurrent_searches"); set => Q("max_concurrent_searches", value); }

	/// <summary>
	/// <para>Search operation type</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.SearchType? SearchType { get => Q<Elastic.Clients.Elasticsearch.Serverless.SearchType?>("search_type"); set => Q("search_type", value); }

	/// <summary>
	/// <para>Indicates whether hits.total should be rendered as an integer or an object in the rest search response</para>
	/// </summary>
	public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

	/// <summary>
	/// <para>Specify whether aggregation and suggester names should be prefixed by their respective types in the response</para>
	/// </summary>
	public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }
}

/// <summary>
/// <para>Runs multiple templated searches with a single request.</para>
/// </summary>
public sealed partial class MultiSearchTemplateRequest : PlainRequest<MultiSearchTemplateRequestParameters>, IStreamSerializable
{
	public MultiSearchTemplateRequest()
	{
	}

	public MultiSearchTemplateRequest(Elastic.Clients.Elasticsearch.Serverless.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceMsearchTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "msearch_template";

	/// <summary>
	/// <para>Indicates whether network round-trips should be minimized as part of cross-cluster search requests execution</para>
	/// </summary>
	[JsonIgnore]
	public bool? CcsMinimizeRoundtrips { get => Q<bool?>("ccs_minimize_roundtrips"); set => Q("ccs_minimize_roundtrips", value); }

	/// <summary>
	/// <para>Controls the maximum number of concurrent searches the multi search api will execute</para>
	/// </summary>
	[JsonIgnore]
	public long? MaxConcurrentSearches { get => Q<long?>("max_concurrent_searches"); set => Q("max_concurrent_searches", value); }

	/// <summary>
	/// <para>Search operation type</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.SearchType? SearchType { get => Q<Elastic.Clients.Elasticsearch.Serverless.SearchType?>("search_type"); set => Q("search_type", value); }

	/// <summary>
	/// <para>Indicates whether hits.total should be rendered as an integer or an object in the rest search response</para>
	/// </summary>
	[JsonIgnore]
	public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

	/// <summary>
	/// <para>Specify whether aggregation and suggester names should be prefixed by their respective types in the response</para>
	/// </summary>
	[JsonIgnore]
	public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }
	public List<Core.MSearchTemplate.SearchTemplateRequestItem> SearchTemplates { get; set; }

	void IStreamSerializable.Serialize(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (SearchTemplates is null)
			return;
		foreach (var item in SearchTemplates)
		{
			if (item is IStreamSerializable serializable)
				serializable.Serialize(stream, settings, formatting);
		}
	}

	async Task IStreamSerializable.SerializeAsync(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (SearchTemplates is null)
			return;
		foreach (var item in SearchTemplates)
		{
			if (item is IStreamSerializable serializable)
				await serializable.SerializeAsync(stream, settings, formatting).ConfigureAwait(false);
		}
	}
}

/// <summary>
/// <para>Runs multiple templated searches with a single request.</para>
/// </summary>
public sealed partial class MultiSearchTemplateRequestDescriptor<TDocument> : RequestDescriptor<MultiSearchTemplateRequestDescriptor<TDocument>, MultiSearchTemplateRequestParameters>, IStreamSerializable
{
	internal MultiSearchTemplateRequestDescriptor(Action<MultiSearchTemplateRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public MultiSearchTemplateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceMsearchTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "msearch_template";

	public MultiSearchTemplateRequestDescriptor<TDocument> CcsMinimizeRoundtrips(bool? ccsMinimizeRoundtrips = true) => Qs("ccs_minimize_roundtrips", ccsMinimizeRoundtrips);
	public MultiSearchTemplateRequestDescriptor<TDocument> MaxConcurrentSearches(long? maxConcurrentSearches) => Qs("max_concurrent_searches", maxConcurrentSearches);
	public MultiSearchTemplateRequestDescriptor<TDocument> RestTotalHitsAsInt(bool? restTotalHitsAsInt = true) => Qs("rest_total_hits_as_int", restTotalHitsAsInt);
	public MultiSearchTemplateRequestDescriptor<TDocument> SearchType(Elastic.Clients.Elasticsearch.Serverless.SearchType? searchType) => Qs("search_type", searchType);
	public MultiSearchTemplateRequestDescriptor<TDocument> TypedKeys(bool? typedKeys = true) => Qs("typed_keys", typedKeys);

	public MultiSearchTemplateRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Serverless.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}

	List<Core.MSearchTemplate.SearchTemplateRequestItem> _items = new();

	void IStreamSerializable.Serialize(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (_items is null)
			return;
		foreach (var item in _items)
		{
			if (item is IStreamSerializable serializable)
				serializable.Serialize(stream, settings, formatting);
		}
	}

	async Task IStreamSerializable.SerializeAsync(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (_items is null)
			return;
		foreach (var item in _items)
		{
			if (item is IStreamSerializable serializable)
				await serializable.SerializeAsync(stream, settings, formatting).ConfigureAwait(false);
		}
	}

	public MultiSearchTemplateRequestDescriptor<TDocument> Add(Core.MSearchTemplate.SearchTemplateRequestItem item)
	{
		_items.Add(item);
		return this;
	}
}

/// <summary>
/// <para>Runs multiple templated searches with a single request.</para>
/// </summary>
public sealed partial class MultiSearchTemplateRequestDescriptor : RequestDescriptor<MultiSearchTemplateRequestDescriptor, MultiSearchTemplateRequestParameters>, IStreamSerializable
{
	internal MultiSearchTemplateRequestDescriptor(Action<MultiSearchTemplateRequestDescriptor> configure) => configure.Invoke(this);

	public MultiSearchTemplateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceMsearchTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "msearch_template";

	public MultiSearchTemplateRequestDescriptor CcsMinimizeRoundtrips(bool? ccsMinimizeRoundtrips = true) => Qs("ccs_minimize_roundtrips", ccsMinimizeRoundtrips);
	public MultiSearchTemplateRequestDescriptor MaxConcurrentSearches(long? maxConcurrentSearches) => Qs("max_concurrent_searches", maxConcurrentSearches);
	public MultiSearchTemplateRequestDescriptor RestTotalHitsAsInt(bool? restTotalHitsAsInt = true) => Qs("rest_total_hits_as_int", restTotalHitsAsInt);
	public MultiSearchTemplateRequestDescriptor SearchType(Elastic.Clients.Elasticsearch.Serverless.SearchType? searchType) => Qs("search_type", searchType);
	public MultiSearchTemplateRequestDescriptor TypedKeys(bool? typedKeys = true) => Qs("typed_keys", typedKeys);

	public MultiSearchTemplateRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Serverless.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}

	List<Core.MSearchTemplate.SearchTemplateRequestItem> _items = new();

	void IStreamSerializable.Serialize(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (_items is null)
			return;
		foreach (var item in _items)
		{
			if (item is IStreamSerializable serializable)
				serializable.Serialize(stream, settings, formatting);
		}
	}

	async Task IStreamSerializable.SerializeAsync(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (_items is null)
			return;
		foreach (var item in _items)
		{
			if (item is IStreamSerializable serializable)
				await serializable.SerializeAsync(stream, settings, formatting).ConfigureAwait(false);
		}
	}

	public MultiSearchTemplateRequestDescriptor Add(Core.MSearchTemplate.SearchTemplateRequestItem item)
	{
		_items.Add(item);
		return this;
	}
}