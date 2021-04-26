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
using Elastic.Transport;
using Elasticsearch.Net;
using Nest.Utf8Json;
using Elasticsearch.Net.Specification.WatcherApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	[InterfaceDataContract]
	public partial interface IAcknowledgeWatchRequest : IRequest<AcknowledgeWatchRequestParameters>
	{
		[IgnoreDataMember]
		Id WatchId
		{
			get;
		}

		[IgnoreDataMember]
		Ids ActionId
		{
			get;
		}
	}

	///<summary>Request for Acknowledge <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-ack-watch.html</para></summary>
	public partial class AcknowledgeWatchRequest : PlainRequestBase<AcknowledgeWatchRequestParameters>, IAcknowledgeWatchRequest
	{
		protected IAcknowledgeWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherAcknowledge;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_watcher/watch/{watch_id}/_ack</summary>
		///<param name = "watchId">this parameter is required</param>
		public AcknowledgeWatchRequest(Id watchId): base(r => r.Required("watch_id", watchId))
		{
		}

		///<summary>/_watcher/watch/{watch_id}/_ack/{action_id}</summary>
		///<param name = "watchId">this parameter is required</param>
		///<param name = "actionId">Optional, accepts null</param>
		public AcknowledgeWatchRequest(Id watchId, Ids actionId): base(r => r.Required("watch_id", watchId).Optional("action_id", actionId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected AcknowledgeWatchRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IAcknowledgeWatchRequest.WatchId => Self.RouteValues.Get<Id>("watch_id");
		[IgnoreDataMember]
		Ids IAcknowledgeWatchRequest.ActionId => Self.RouteValues.Get<Ids>("action_id");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IActivateWatchRequest : IRequest<ActivateWatchRequestParameters>
	{
		[IgnoreDataMember]
		Id WatchId
		{
			get;
		}
	}

	///<summary>Request for Activate <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-activate-watch.html</para></summary>
	public partial class ActivateWatchRequest : PlainRequestBase<ActivateWatchRequestParameters>, IActivateWatchRequest
	{
		protected IActivateWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherActivate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_watcher/watch/{watch_id}/_activate</summary>
		///<param name = "watchId">this parameter is required</param>
		public ActivateWatchRequest(Id watchId): base(r => r.Required("watch_id", watchId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected ActivateWatchRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IActivateWatchRequest.WatchId => Self.RouteValues.Get<Id>("watch_id");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IDeactivateWatchRequest : IRequest<DeactivateWatchRequestParameters>
	{
		[IgnoreDataMember]
		Id WatchId
		{
			get;
		}
	}

	///<summary>Request for Deactivate <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-deactivate-watch.html</para></summary>
	public partial class DeactivateWatchRequest : PlainRequestBase<DeactivateWatchRequestParameters>, IDeactivateWatchRequest
	{
		protected IDeactivateWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherDeactivate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_watcher/watch/{watch_id}/_deactivate</summary>
		///<param name = "watchId">this parameter is required</param>
		public DeactivateWatchRequest(Id watchId): base(r => r.Required("watch_id", watchId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeactivateWatchRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IDeactivateWatchRequest.WatchId => Self.RouteValues.Get<Id>("watch_id");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IDeleteWatchRequest : IRequest<DeleteWatchRequestParameters>
	{
		[IgnoreDataMember]
		Id Id
		{
			get;
		}
	}

	///<summary>Request for Delete <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-delete-watch.html</para></summary>
	public partial class DeleteWatchRequest : PlainRequestBase<DeleteWatchRequestParameters>, IDeleteWatchRequest
	{
		protected IDeleteWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_watcher/watch/{id}</summary>
		///<param name = "id">this parameter is required</param>
		public DeleteWatchRequest(Id id): base(r => r.Required("id", id))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteWatchRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IDeleteWatchRequest.Id => Self.RouteValues.Get<Id>("id");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IExecuteWatchRequest : IRequest<ExecuteWatchRequestParameters>
	{
		[IgnoreDataMember]
		Id Id
		{
			get;
		}
	}

	///<summary>Request for Execute <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-execute-watch.html</para></summary>
	public partial class ExecuteWatchRequest : PlainRequestBase<ExecuteWatchRequestParameters>, IExecuteWatchRequest
	{
		protected IExecuteWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherExecute;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		///<summary>/_watcher/watch/{id}/_execute</summary>
		///<param name = "id">Optional, accepts null</param>
		public ExecuteWatchRequest(Id id): base(r => r.Optional("id", id))
		{
		}

		///<summary>/_watcher/watch/_execute</summary>
		public ExecuteWatchRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IExecuteWatchRequest.Id => Self.RouteValues.Get<Id>("id");
		// Request parameters
		///<summary>indicates whether the watch should execute in debug mode</summary>
		public bool? Debug
		{
			get => Q<bool? >("debug");
			set => Q("debug", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IGetWatchRequest : IRequest<GetWatchRequestParameters>
	{
		[IgnoreDataMember]
		Id Id
		{
			get;
		}
	}

	///<summary>Request for Get <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-get-watch.html</para></summary>
	public partial class GetWatchRequest : PlainRequestBase<GetWatchRequestParameters>, IGetWatchRequest
	{
		protected IGetWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherGet;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_watcher/watch/{id}</summary>
		///<param name = "id">this parameter is required</param>
		public GetWatchRequest(Id id): base(r => r.Required("id", id))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected GetWatchRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IGetWatchRequest.Id => Self.RouteValues.Get<Id>("id");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IPutWatchRequest : IRequest<PutWatchRequestParameters>
	{
		[IgnoreDataMember]
		Id Id
		{
			get;
		}
	}

	///<summary>Request for Put <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-put-watch.html</para></summary>
	public partial class PutWatchRequest : PlainRequestBase<PutWatchRequestParameters>, IPutWatchRequest
	{
		protected IPutWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherPut;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		///<summary>/_watcher/watch/{id}</summary>
		///<param name = "id">this parameter is required</param>
		public PutWatchRequest(Id id): base(r => r.Required("id", id))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PutWatchRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IPutWatchRequest.Id => Self.RouteValues.Get<Id>("id");
		// Request parameters
		///<summary>Specify whether the watch is in/active by default</summary>
		public bool? Active
		{
			get => Q<bool? >("active");
			set => Q("active", value);
		}

		///<summary>only update the watch if the last operation that has changed the watch has the specified primary term</summary>
		public long? IfPrimaryTerm
		{
			get => Q<long? >("if_primary_term");
			set => Q("if_primary_term", value);
		}

		///<summary>only update the watch if the last operation that has changed the watch has the specified sequence number</summary>
		public long? IfSequenceNumber
		{
			get => Q<long? >("if_seq_no");
			set => Q("if_seq_no", value);
		}

		///<summary>Explicit version number for concurrency control</summary>
		public long? Version
		{
			get => Q<long? >("version");
			set => Q("version", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IStartWatcherRequest : IRequest<StartWatcherRequestParameters>
	{
	}

	///<summary>Request for Start <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-start.html</para></summary>
	public partial class StartWatcherRequest : PlainRequestBase<StartWatcherRequestParameters>, IStartWatcherRequest
	{
		protected IStartWatcherRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherStart;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	// values part of the url path
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IWatcherStatsRequest : IRequest<WatcherStatsRequestParameters>
	{
		[IgnoreDataMember]
		Metrics Metric
		{
			get;
		}
	}

	///<summary>Request for Stats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stats.html</para></summary>
	public partial class WatcherStatsRequest : PlainRequestBase<WatcherStatsRequestParameters>, IWatcherStatsRequest
	{
		protected IWatcherStatsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_watcher/stats</summary>
		public WatcherStatsRequest(): base()
		{
		}

		///<summary>/_watcher/stats/{metric}</summary>
		///<param name = "metric">Optional, accepts null</param>
		public WatcherStatsRequest(Metrics metric): base(r => r.Optional("metric", metric))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Metrics IWatcherStatsRequest.Metric => Self.RouteValues.Get<Metrics>("metric");
		// Request parameters
		///<summary>Emits stack traces of currently running watches</summary>
		public bool? EmitStacktraces
		{
			get => Q<bool? >("emit_stacktraces");
			set => Q("emit_stacktraces", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IStopWatcherRequest : IRequest<StopWatcherRequestParameters>
	{
	}

	///<summary>Request for Stop <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stop.html</para></summary>
	public partial class StopWatcherRequest : PlainRequestBase<StopWatcherRequestParameters>, IStopWatcherRequest
	{
		protected IStopWatcherRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherStop;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	// values part of the url path
	// Request parameters
	}
}