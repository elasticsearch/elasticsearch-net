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

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Elastic.Clients.Elasticsearch.Serverless.Eql;

public partial class EqlNamespacedClient : NamespacedClientProxy
{
	/// <summary>
	/// <para>Initializes a new instance of the <see cref="EqlNamespacedClient"/> class for mocking.</para>
	/// </summary>
	protected EqlNamespacedClient() : base()
	{
	}

	internal EqlNamespacedClient(ElasticsearchClient client) : base(client)
	{
	}

	/// <summary>
	/// <para>Deletes an async EQL search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual EqlDeleteResponse Delete(EqlDeleteRequest request)
	{
		request.BeforeRequest();
		return DoRequest<EqlDeleteRequest, EqlDeleteResponse, EqlDeleteRequestParameters>(request);
	}

	/// <summary>
	/// <para>Deletes an async EQL search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EqlDeleteResponse> DeleteAsync(EqlDeleteRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<EqlDeleteRequest, EqlDeleteResponse, EqlDeleteRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async EQL search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EqlDeleteResponse> DeleteAsync<TDocument>(EqlDeleteRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<EqlDeleteRequestDescriptor, EqlDeleteResponse, EqlDeleteRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async EQL search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EqlDeleteResponse> DeleteAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new EqlDeleteRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<EqlDeleteRequestDescriptor, EqlDeleteResponse, EqlDeleteRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async EQL search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EqlDeleteResponse> DeleteAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<EqlDeleteRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new EqlDeleteRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<EqlDeleteRequestDescriptor, EqlDeleteResponse, EqlDeleteRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async EQL search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EqlDeleteResponse> DeleteAsync(EqlDeleteRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<EqlDeleteRequestDescriptor, EqlDeleteResponse, EqlDeleteRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async EQL search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EqlDeleteResponse> DeleteAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new EqlDeleteRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<EqlDeleteRequestDescriptor, EqlDeleteResponse, EqlDeleteRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async EQL search by ID. If the search is still running, the search request will be cancelled. Otherwise, the saved search results are deleted.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EqlDeleteResponse> DeleteAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<EqlDeleteRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new EqlDeleteRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<EqlDeleteRequestDescriptor, EqlDeleteResponse, EqlDeleteRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns async results from previously executed Event Query Language (EQL) search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/get-async-eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual EqlGetResponse<TEvent> Get<TEvent>(EqlGetRequest request)
	{
		request.BeforeRequest();
		return DoRequest<EqlGetRequest, EqlGetResponse<TEvent>, EqlGetRequestParameters>(request);
	}

	/// <summary>
	/// <para>Returns async results from previously executed Event Query Language (EQL) search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/get-async-eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EqlGetResponse<TEvent>> GetAsync<TEvent>(EqlGetRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<EqlGetRequest, EqlGetResponse<TEvent>, EqlGetRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Returns async results from previously executed Event Query Language (EQL) search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/get-async-eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EqlGetResponse<TEvent>> GetAsync<TEvent>(EqlGetRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<EqlGetRequestDescriptor, EqlGetResponse<TEvent>, EqlGetRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns async results from previously executed Event Query Language (EQL) search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/get-async-eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EqlGetResponse<TEvent>> GetAsync<TEvent>(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new EqlGetRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<EqlGetRequestDescriptor, EqlGetResponse<TEvent>, EqlGetRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns async results from previously executed Event Query Language (EQL) search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/get-async-eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EqlGetResponse<TEvent>> GetAsync<TEvent>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<EqlGetRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new EqlGetRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<EqlGetRequestDescriptor, EqlGetResponse<TEvent>, EqlGetRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the status of a previously submitted async or stored Event Query Language (EQL) search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/get-async-eql-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetEqlStatusResponse GetStatus(GetEqlStatusRequest request)
	{
		request.BeforeRequest();
		return DoRequest<GetEqlStatusRequest, GetEqlStatusResponse, GetEqlStatusRequestParameters>(request);
	}

	/// <summary>
	/// <para>Returns the status of a previously submitted async or stored Event Query Language (EQL) search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/get-async-eql-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetEqlStatusResponse> GetStatusAsync(GetEqlStatusRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetEqlStatusRequest, GetEqlStatusResponse, GetEqlStatusRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the status of a previously submitted async or stored Event Query Language (EQL) search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/get-async-eql-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetEqlStatusResponse> GetStatusAsync<TDocument>(GetEqlStatusRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetEqlStatusRequestDescriptor, GetEqlStatusResponse, GetEqlStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the status of a previously submitted async or stored Event Query Language (EQL) search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/get-async-eql-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetEqlStatusResponse> GetStatusAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetEqlStatusRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetEqlStatusRequestDescriptor, GetEqlStatusResponse, GetEqlStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the status of a previously submitted async or stored Event Query Language (EQL) search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/get-async-eql-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetEqlStatusResponse> GetStatusAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetEqlStatusRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetEqlStatusRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetEqlStatusRequestDescriptor, GetEqlStatusResponse, GetEqlStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the status of a previously submitted async or stored Event Query Language (EQL) search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/get-async-eql-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetEqlStatusResponse> GetStatusAsync(GetEqlStatusRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetEqlStatusRequestDescriptor, GetEqlStatusResponse, GetEqlStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the status of a previously submitted async or stored Event Query Language (EQL) search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/get-async-eql-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetEqlStatusResponse> GetStatusAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetEqlStatusRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetEqlStatusRequestDescriptor, GetEqlStatusResponse, GetEqlStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the status of a previously submitted async or stored Event Query Language (EQL) search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/get-async-eql-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetEqlStatusResponse> GetStatusAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetEqlStatusRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetEqlStatusRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetEqlStatusRequestDescriptor, GetEqlStatusResponse, GetEqlStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns results matching a query expressed in Event Query Language (EQL)</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual EqlSearchResponse<TEvent> Search<TEvent>(EqlSearchRequest request)
	{
		request.BeforeRequest();
		return DoRequest<EqlSearchRequest, EqlSearchResponse<TEvent>, EqlSearchRequestParameters>(request);
	}

	/// <summary>
	/// <para>Returns results matching a query expressed in Event Query Language (EQL)</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EqlSearchResponse<TEvent>> SearchAsync<TEvent>(EqlSearchRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<EqlSearchRequest, EqlSearchResponse<TEvent>, EqlSearchRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Returns results matching a query expressed in Event Query Language (EQL)</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EqlSearchResponse<TEvent>> SearchAsync<TEvent>(EqlSearchRequestDescriptor<TEvent> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<EqlSearchRequestDescriptor<TEvent>, EqlSearchResponse<TEvent>, EqlSearchRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns results matching a query expressed in Event Query Language (EQL)</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EqlSearchResponse<TEvent>> SearchAsync<TEvent>(Elastic.Clients.Elasticsearch.Serverless.Indices indices, CancellationToken cancellationToken = default)
	{
		var descriptor = new EqlSearchRequestDescriptor<TEvent>(indices);
		descriptor.BeforeRequest();
		return DoRequestAsync<EqlSearchRequestDescriptor<TEvent>, EqlSearchResponse<TEvent>, EqlSearchRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns results matching a query expressed in Event Query Language (EQL)</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/eql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<EqlSearchResponse<TEvent>> SearchAsync<TEvent>(Elastic.Clients.Elasticsearch.Serverless.Indices indices, Action<EqlSearchRequestDescriptor<TEvent>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new EqlSearchRequestDescriptor<TEvent>(indices);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<EqlSearchRequestDescriptor<TEvent>, EqlSearchResponse<TEvent>, EqlSearchRequestParameters>(descriptor, cancellationToken);
	}
}