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
namespace Elasticsearch.Net.Specification.EqlApi
{
	///<summary>
	/// Eql APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticLowLevelClient.Eql"/> property
	/// on <see cref = "IElasticLowLevelClient"/>.
	///</para>
	///</summary>
	public class LowLevelEqlNamespace : NamespacedClientProxy
	{
		internal LowLevelEqlNamespace(ElasticLowLevelClient client): base(client)
		{
		}

		///<summary>DELETE on /_eql/search/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</para></summary>
		///<param name = "id">The async search ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Delete<TResponse>(string id, DeleteRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(DELETE, Url($"_eql/search/{id:id}"), null, RequestParams(requestParameters));
		///<summary>DELETE on /_eql/search/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</para></summary>
		///<param name = "id">The async search ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("eql.delete", "id")]
		public Task<TResponse> DeleteAsync<TResponse>(string id, DeleteRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(DELETE, Url($"_eql/search/{id:id}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_eql/search/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</para></summary>
		///<param name = "id">The async search ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Get<TResponse>(string id, GetRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(GET, Url($"_eql/search/{id:id}"), null, RequestParams(requestParameters));
		///<summary>GET on /_eql/search/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</para></summary>
		///<param name = "id">The async search ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("eql.get", "id")]
		public Task<TResponse> GetAsync<TResponse>(string id, GetRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_eql/search/{id:id}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_eql/search/status/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</para></summary>
		///<param name = "id">The async search ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetStatus<TResponse>(string id, GetStatusRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(GET, Url($"_eql/search/status/{id:id}"), null, RequestParams(requestParameters));
		///<summary>GET on /_eql/search/status/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</para></summary>
		///<param name = "id">The async search ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("eql.get_status", "id")]
		public Task<TResponse> GetStatusAsync<TResponse>(string id, GetStatusRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_eql/search/status/{id:id}"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_eql/search <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</para></summary>
		///<param name = "index">The name of the index to scope the operation</param>
		///<param name = "body">Eql request body. Use the `query` to limit the query scope.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Search<TResponse>(string index, PostData body, SearchRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/_eql/search"), body, RequestParams(requestParameters));
		///<summary>POST on /{index}/_eql/search <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html</para></summary>
		///<param name = "index">The name of the index to scope the operation</param>
		///<param name = "body">Eql request body. Use the `query` to limit the query scope.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("eql.search", "index, body")]
		public Task<TResponse> SearchAsync<TResponse>(string index, PostData body, SearchRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/_eql/search"), ctx, body, RequestParams(requestParameters));
	}
}