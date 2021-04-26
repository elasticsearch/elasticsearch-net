/*
 * Licensed to Elasticsearch B.V. under one or more contributor
 * license agreements. See the NOTICE file distributed with
 * this work for additional information regarding copyright
 * ownership. Elasticsearch B.V. licenses this file to you under
 * the Apache License, Version 2.0 (the "License"); you may
 * not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
using Elasticsearch.Net.Specification.AsyncSearchApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	[InterfaceDataContract]
	public partial interface IAsyncSearchDeleteRequest : IRequest<AsyncSearchDeleteRequestParameters>
	{
		[IgnoreDataMember]
		Id Id
		{
			get;
		}
	}

	///<summary>Request for Delete <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/async-search.html</para></summary>
	public partial class AsyncSearchDeleteRequest : PlainRequestBase<AsyncSearchDeleteRequestParameters>, IAsyncSearchDeleteRequest
	{
		protected IAsyncSearchDeleteRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AsyncSearchDelete;
		///<summary>/_async_search/{id}</summary>
		///<param name = "id">this parameter is required</param>
		public AsyncSearchDeleteRequest(Id id): base(r => r.Required("id", id))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected AsyncSearchDeleteRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IAsyncSearchDeleteRequest.Id => Self.RouteValues.Get<Id>("id");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IAsyncSearchGetRequest : IRequest<AsyncSearchGetRequestParameters>
	{
		[IgnoreDataMember]
		Id Id
		{
			get;
		}
	}

	///<summary>Request for Get <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/async-search.html</para></summary>
	public partial class AsyncSearchGetRequest : PlainRequestBase<AsyncSearchGetRequestParameters>, IAsyncSearchGetRequest
	{
		protected IAsyncSearchGetRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AsyncSearchGet;
		///<summary>/_async_search/{id}</summary>
		///<param name = "id">this parameter is required</param>
		public AsyncSearchGetRequest(Id id): base(r => r.Required("id", id))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected AsyncSearchGetRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IAsyncSearchGetRequest.Id => Self.RouteValues.Get<Id>("id");
		// Request parameters
		///<summary>Specify the time interval in which the results (partial or final) for this search will be available</summary>
		public Time KeepAlive
		{
			get => Q<Time>("keep_alive");
			set => Q("keep_alive", value);
		}

		///<summary>Specify whether aggregation and suggester names should be prefixed by their respective types in the response</summary>
		public bool? TypedKeys
		{
			get => Q<bool? >("typed_keys");
			set => Q("typed_keys", value);
		}

		///<summary>Specify the time that the request should block waiting for the final response</summary>
		public Time WaitForCompletionTimeout
		{
			get => Q<Time>("wait_for_completion_timeout");
			set => Q("wait_for_completion_timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IAsyncSearchStatusRequest : IRequest<AsyncSearchStatusRequestParameters>
	{
		[IgnoreDataMember]
		Id Id
		{
			get;
		}
	}

	///<summary>Request for Status <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/async-search.html</para></summary>
	public partial class AsyncSearchStatusRequest : PlainRequestBase<AsyncSearchStatusRequestParameters>, IAsyncSearchStatusRequest
	{
		protected IAsyncSearchStatusRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AsyncSearchStatus;
		///<summary>/_async_search/status/{id}</summary>
		///<param name = "id">this parameter is required</param>
		public AsyncSearchStatusRequest(Id id): base(r => r.Required("id", id))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected AsyncSearchStatusRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IAsyncSearchStatusRequest.Id => Self.RouteValues.Get<Id>("id");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IAsyncSearchSubmitRequest : IRequest<AsyncSearchSubmitRequestParameters>
	{
		[IgnoreDataMember]
		Indices Index
		{
			get;
		}

		[DataMember(Name = "docvalue_fields")]
		Fields DocValueFields
		{
			get;
			set;
		}

		[DataMember(Name = "stored_fields")]
		Fields StoredFields
		{
			get;
			set;
		}

		[DataMember(Name = "track_total_hits")]
		bool? TrackTotalHits
		{
			get;
			set;
		}
	}

	public partial interface IAsyncSearchSubmitRequest<TInferDocument> : IAsyncSearchSubmitRequest
	{
	}

	///<summary>Request for Submit <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/async-search.html</para></summary>
	public partial class AsyncSearchSubmitRequest : PlainRequestBase<AsyncSearchSubmitRequestParameters>, IAsyncSearchSubmitRequest
	{
		protected IAsyncSearchSubmitRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AsyncSearchSubmit;
		///<summary>/_async_search</summary>
		public AsyncSearchSubmitRequest(): base()
		{
		}

		///<summary>/{index}/_async_search</summary>
		///<param name = "index">Optional, accepts null</param>
		public AsyncSearchSubmitRequest(Indices index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Indices IAsyncSearchSubmitRequest.Index => Self.RouteValues.Get<Indices>("index");
		// Request parameters
		///<summary>
		/// Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have
		/// been specified)
		///</summary>
		public bool? AllowNoIndices
		{
			get => Q<bool? >("allow_no_indices");
			set => Q("allow_no_indices", value);
		}

		///<summary>Indicate if an error should be returned if there is a partial search failure or timeout</summary>
		public bool? AllowPartialSearchResults
		{
			get => Q<bool? >("allow_partial_search_results");
			set => Q("allow_partial_search_results", value);
		}

		///<summary>Specify whether wildcard and prefix queries should be analyzed (default: false)</summary>
		public bool? AnalyzeWildcard
		{
			get => Q<bool? >("analyze_wildcard");
			set => Q("analyze_wildcard", value);
		}

		///<summary>The analyzer to use for the query string</summary>
		public string Analyzer
		{
			get => Q<string>("analyzer");
			set => Q("analyzer", value);
		}

		///<summary>
		/// The number of shard results that should be reduced at once on the coordinating node. This value should be used as the granularity at which
		/// progress results will be made available.
		///</summary>
		public long? BatchedReduceSize
		{
			get => Q<long? >("batched_reduce_size");
			set => Q("batched_reduce_size", value);
		}

		///<summary>The default operator for query string query (AND or OR)</summary>
		public DefaultOperator? DefaultOperator
		{
			get => Q<DefaultOperator? >("default_operator");
			set => Q("default_operator", value);
		}

		///<summary>The field to use as default where no field prefix is given in the query string</summary>
		public string Df
		{
			get => Q<string>("df");
			set => Q("df", value);
		}

		///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
		public ExpandWildcards? ExpandWildcards
		{
			get => Q<ExpandWildcards? >("expand_wildcards");
			set => Q("expand_wildcards", value);
		}

		///<summary>Whether specified concrete, expanded or aliased indices should be ignored when throttled</summary>
		public bool? IgnoreThrottled
		{
			get => Q<bool? >("ignore_throttled");
			set => Q("ignore_throttled", value);
		}

		///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Update the time interval in which the results (partial or final) for this search will be available</summary>
		public Time KeepAlive
		{
			get => Q<Time>("keep_alive");
			set => Q("keep_alive", value);
		}

		///<summary>
		/// Control whether the response should be stored in the cluster if it completed within the provided [wait_for_completion] time (default:
		/// false)
		///</summary>
		public bool? KeepOnCompletion
		{
			get => Q<bool? >("keep_on_completion");
			set => Q("keep_on_completion", value);
		}

		///<summary>Specify whether format-based query failures (such as providing text to a numeric field) should be ignored</summary>
		public bool? Lenient
		{
			get => Q<bool? >("lenient");
			set => Q("lenient", value);
		}

		///<summary>
		/// The number of concurrent shard requests per node this search executes concurrently. This value should be used to limit the impact of the
		/// search on the cluster in order to limit the number of concurrent shard requests
		///</summary>
		public long? MaxConcurrentShardRequests
		{
			get => Q<long? >("max_concurrent_shard_requests");
			set => Q("max_concurrent_shard_requests", value);
		}

		///<summary>Specify the node or shard the operation should be performed on (default: random)</summary>
		public string Preference
		{
			get => Q<string>("preference");
			set => Q("preference", value);
		}

		///<summary>Query in the Lucene query string syntax</summary>
		public string QueryOnQueryString
		{
			get => Q<string>("q");
			set => Q("q", value);
		}

		///<summary>Specify if request cache should be used for this request or not, defaults to true</summary>
		public bool? RequestCache
		{
			get => Q<bool? >("request_cache");
			set => Q("request_cache", value);
		}

		///<summary>
		/// A document is routed to a particular shard in an index using the following formula
		/// <para> shard_num = hash(_routing) % num_primary_shards</para>
		/// <para>Elasticsearch will use the document id if not provided. </para>
		/// <para>For requests that are constructed from/for a document NEST will automatically infer the routing key
		/// if that document has a <see cref = "Nest.JoinField"/> or a routing mapping on for its type exists on <see cref = "Nest.ConnectionSettings"
		////></para>
		///</summary>
		public Routing Routing
		{
			get => Q<Routing>("routing");
			set => Q("routing", value);
		}

		///<summary>Search operation type</summary>
		public SearchType? SearchType
		{
			get => Q<SearchType? >("search_type");
			set => Q("search_type", value);
		}

		///<summary>Specify whether to return sequence number and primary term of the last modification of each hit</summary>
		public bool? SequenceNumberPrimaryTerm
		{
			get => Q<bool? >("seq_no_primary_term");
			set => Q("seq_no_primary_term", value);
		}

		///<summary>Specific 'tag' of the request for logging and statistical purposes</summary>
		public string[] Stats
		{
			get => Q<string[]>("stats");
			set => Q("stats", value);
		}

		///<summary>Specify which field to use for suggestions</summary>
		public Field SuggestField
		{
			get => Q<Field>("suggest_field");
			set => Q("suggest_field", value);
		}

		///<summary>Specify suggest mode</summary>
		public SuggestMode? SuggestMode
		{
			get => Q<SuggestMode? >("suggest_mode");
			set => Q("suggest_mode", value);
		}

		///<summary>How many suggestions to return in response</summary>
		public long? SuggestSize
		{
			get => Q<long? >("suggest_size");
			set => Q("suggest_size", value);
		}

		///<summary>The source text for which the suggestions should be returned</summary>
		public string SuggestText
		{
			get => Q<string>("suggest_text");
			set => Q("suggest_text", value);
		}

		///<summary>Specify whether aggregation and suggester names should be prefixed by their respective types in the response</summary>
		public bool? TypedKeys
		{
			get => Q<bool? >("typed_keys");
			set => Q("typed_keys", value);
		}

		///<summary>Specify the time that the request should block waiting for the final response</summary>
		public Time WaitForCompletionTimeout
		{
			get => Q<Time>("wait_for_completion_timeout");
			set => Q("wait_for_completion_timeout", value);
		}
	}

	public partial class AsyncSearchSubmitRequest<TInferDocument> : AsyncSearchSubmitRequest, IAsyncSearchSubmitRequest<TInferDocument>
	{
		protected IAsyncSearchSubmitRequest<TInferDocument> TypedSelf => this;
		///<summary>/{index}/_async_search</summary>
		public AsyncSearchSubmitRequest(): base(typeof(TInferDocument))
		{
		}

		///<summary>/{index}/_async_search</summary>
		///<param name = "index">Optional, accepts null</param>
		public AsyncSearchSubmitRequest(Indices index): base(index)
		{
		}
	}
}