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
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;
using Elastic.Transport;
using static Elastic.Transport.HttpMethod;

// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable once CheckNamespace
// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable RedundantExtendsListEntry
namespace Elasticsearch.Net.Specification.WatcherApi
{
	///<summary>
	/// Watcher APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticLowLevelClient.Watcher"/> property
	/// on <see cref = "IElasticLowLevelClient"/>.
	///</para>
	///</summary>
	public class LowLevelWatcherNamespace : NamespacedClientProxy
	{
		internal LowLevelWatcherNamespace(ElasticLowLevelClient client): base(client)
		{
		}

		///<summary>PUT on /_watcher/watch/{watch_id}/_ack <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-ack-watch.html</para></summary>
		///<param name = "watchId">Watch ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Acknowledge<TResponse>(string watchId, AcknowledgeWatchRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(PUT, Url($"_watcher/watch/{watchId:watchId}/_ack"), null, RequestParams(requestParameters));
		///<summary>PUT on /_watcher/watch/{watch_id}/_ack <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-ack-watch.html</para></summary>
		///<param name = "watchId">Watch ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("watcher.ack_watch", "watch_id")]
		public Task<TResponse> AcknowledgeAsync<TResponse>(string watchId, AcknowledgeWatchRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_watcher/watch/{watchId:watchId}/_ack"), ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /_watcher/watch/{watch_id}/_ack/{action_id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-ack-watch.html</para></summary>
		///<param name = "watchId">Watch ID</param>
		///<param name = "actionId">A comma-separated list of the action ids to be acked</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Acknowledge<TResponse>(string watchId, string actionId, AcknowledgeWatchRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(PUT, Url($"_watcher/watch/{watchId:watchId}/_ack/{actionId:actionId}"), null, RequestParams(requestParameters));
		///<summary>PUT on /_watcher/watch/{watch_id}/_ack/{action_id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-ack-watch.html</para></summary>
		///<param name = "watchId">Watch ID</param>
		///<param name = "actionId">A comma-separated list of the action ids to be acked</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("watcher.ack_watch", "watch_id, action_id")]
		public Task<TResponse> AcknowledgeAsync<TResponse>(string watchId, string actionId, AcknowledgeWatchRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_watcher/watch/{watchId:watchId}/_ack/{actionId:actionId}"), ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /_watcher/watch/{watch_id}/_activate <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-activate-watch.html</para></summary>
		///<param name = "watchId">Watch ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Activate<TResponse>(string watchId, ActivateWatchRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(PUT, Url($"_watcher/watch/{watchId:watchId}/_activate"), null, RequestParams(requestParameters));
		///<summary>PUT on /_watcher/watch/{watch_id}/_activate <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-activate-watch.html</para></summary>
		///<param name = "watchId">Watch ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("watcher.activate_watch", "watch_id")]
		public Task<TResponse> ActivateAsync<TResponse>(string watchId, ActivateWatchRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_watcher/watch/{watchId:watchId}/_activate"), ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /_watcher/watch/{watch_id}/_deactivate <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-deactivate-watch.html</para></summary>
		///<param name = "watchId">Watch ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Deactivate<TResponse>(string watchId, DeactivateWatchRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(PUT, Url($"_watcher/watch/{watchId:watchId}/_deactivate"), null, RequestParams(requestParameters));
		///<summary>PUT on /_watcher/watch/{watch_id}/_deactivate <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-deactivate-watch.html</para></summary>
		///<param name = "watchId">Watch ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("watcher.deactivate_watch", "watch_id")]
		public Task<TResponse> DeactivateAsync<TResponse>(string watchId, DeactivateWatchRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_watcher/watch/{watchId:watchId}/_deactivate"), ctx, null, RequestParams(requestParameters));
		///<summary>DELETE on /_watcher/watch/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-delete-watch.html</para></summary>
		///<param name = "id">Watch ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Delete<TResponse>(string id, DeleteWatchRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(DELETE, Url($"_watcher/watch/{id:id}"), null, RequestParams(requestParameters));
		///<summary>DELETE on /_watcher/watch/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-delete-watch.html</para></summary>
		///<param name = "id">Watch ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("watcher.delete_watch", "id")]
		public Task<TResponse> DeleteAsync<TResponse>(string id, DeleteWatchRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(DELETE, Url($"_watcher/watch/{id:id}"), ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /_watcher/watch/{id}/_execute <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-execute-watch.html</para></summary>
		///<param name = "id">Watch ID</param>
		///<param name = "body">Execution control</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Execute<TResponse>(string id, PostData body, ExecuteWatchRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(PUT, Url($"_watcher/watch/{id:id}/_execute"), body, RequestParams(requestParameters));
		///<summary>PUT on /_watcher/watch/{id}/_execute <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-execute-watch.html</para></summary>
		///<param name = "id">Watch ID</param>
		///<param name = "body">Execution control</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("watcher.execute_watch", "id, body")]
		public Task<TResponse> ExecuteAsync<TResponse>(string id, PostData body, ExecuteWatchRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_watcher/watch/{id:id}/_execute"), ctx, body, RequestParams(requestParameters));
		///<summary>PUT on /_watcher/watch/_execute <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-execute-watch.html</para></summary>
		///<param name = "body">Execution control</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Execute<TResponse>(PostData body, ExecuteWatchRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(PUT, "_watcher/watch/_execute", body, RequestParams(requestParameters));
		///<summary>PUT on /_watcher/watch/_execute <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-execute-watch.html</para></summary>
		///<param name = "body">Execution control</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("watcher.execute_watch", "body")]
		public Task<TResponse> ExecuteAsync<TResponse>(PostData body, ExecuteWatchRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(PUT, "_watcher/watch/_execute", ctx, body, RequestParams(requestParameters));
		///<summary>GET on /_watcher/watch/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-get-watch.html</para></summary>
		///<param name = "id">Watch ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Get<TResponse>(string id, GetWatchRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(GET, Url($"_watcher/watch/{id:id}"), null, RequestParams(requestParameters));
		///<summary>GET on /_watcher/watch/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-get-watch.html</para></summary>
		///<param name = "id">Watch ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("watcher.get_watch", "id")]
		public Task<TResponse> GetAsync<TResponse>(string id, GetWatchRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_watcher/watch/{id:id}"), ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /_watcher/watch/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-put-watch.html</para></summary>
		///<param name = "id">Watch ID</param>
		///<param name = "body">The watch</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Put<TResponse>(string id, PostData body, PutWatchRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(PUT, Url($"_watcher/watch/{id:id}"), body, RequestParams(requestParameters));
		///<summary>PUT on /_watcher/watch/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-put-watch.html</para></summary>
		///<param name = "id">Watch ID</param>
		///<param name = "body">The watch</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("watcher.put_watch", "id, body")]
		public Task<TResponse> PutAsync<TResponse>(string id, PostData body, PutWatchRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_watcher/watch/{id:id}"), ctx, body, RequestParams(requestParameters));
		///<summary>POST on /_watcher/_query/watches <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-query-watches.html</para></summary>
		///<param name = "body">From, size, query, sort and search_after</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse QueryWatches<TResponse>(PostData body, QueryWatchesRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(POST, "_watcher/_query/watches", body, RequestParams(requestParameters));
		///<summary>POST on /_watcher/_query/watches <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-query-watches.html</para></summary>
		///<param name = "body">From, size, query, sort and search_after</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("watcher.query_watches", "body")]
		public Task<TResponse> QueryWatchesAsync<TResponse>(PostData body, QueryWatchesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(POST, "_watcher/_query/watches", ctx, body, RequestParams(requestParameters));
		///<summary>POST on /_watcher/_start <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-start.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Start<TResponse>(StartWatcherRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(POST, "_watcher/_start", null, RequestParams(requestParameters));
		///<summary>POST on /_watcher/_start <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-start.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("watcher.start", "")]
		public Task<TResponse> StartAsync<TResponse>(StartWatcherRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(POST, "_watcher/_start", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_watcher/stats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stats.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Stats<TResponse>(WatcherStatsRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(GET, "_watcher/stats", null, RequestParams(requestParameters));
		///<summary>GET on /_watcher/stats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stats.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("watcher.stats", "")]
		public Task<TResponse> StatsAsync<TResponse>(WatcherStatsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(GET, "_watcher/stats", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_watcher/stats/{metric} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stats.html</para></summary>
		///<param name = "metric">Controls what additional stat metrics should be include in the response</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Stats<TResponse>(string metric, WatcherStatsRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(GET, Url($"_watcher/stats/{metric:metric}"), null, RequestParams(requestParameters));
		///<summary>GET on /_watcher/stats/{metric} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stats.html</para></summary>
		///<param name = "metric">Controls what additional stat metrics should be include in the response</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("watcher.stats", "metric")]
		public Task<TResponse> StatsAsync<TResponse>(string metric, WatcherStatsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_watcher/stats/{metric:metric}"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_watcher/_stop <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stop.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Stop<TResponse>(StopWatcherRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(POST, "_watcher/_stop", null, RequestParams(requestParameters));
		///<summary>POST on /_watcher/_stop <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/watcher-api-stop.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("watcher.stop", "")]
		public Task<TResponse> StopAsync<TResponse>(StopWatcherRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(POST, "_watcher/_stop", ctx, null, RequestParams(requestParameters));
	}
}