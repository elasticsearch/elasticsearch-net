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

namespace Elastic.Clients.Elasticsearch.Serverless.Sql;

public partial class SqlNamespacedClient : NamespacedClientProxy
{
	/// <summary>
	/// <para>
	/// Initializes a new instance of the <see cref="SqlNamespacedClient"/> class for mocking.
	/// </para>
	/// </summary>
	protected SqlNamespacedClient() : base()
	{
	}

	internal SqlNamespacedClient(ElasticsearchClient client) : base(client)
	{
	}

	/// <summary>
	/// <para>
	/// Clear an SQL search cursor.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/clear-sql-cursor-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ClearCursorResponse> ClearCursorAsync(ClearCursorRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<ClearCursorRequest, ClearCursorResponse, ClearCursorRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Clear an SQL search cursor.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/clear-sql-cursor-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ClearCursorResponse> ClearCursorAsync(ClearCursorRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<ClearCursorRequestDescriptor, ClearCursorResponse, ClearCursorRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Clear an SQL search cursor.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/clear-sql-cursor-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ClearCursorResponse> ClearCursorAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new ClearCursorRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<ClearCursorRequestDescriptor, ClearCursorResponse, ClearCursorRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Clear an SQL search cursor.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/clear-sql-cursor-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ClearCursorResponse> ClearCursorAsync(Action<ClearCursorRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new ClearCursorRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<ClearCursorRequestDescriptor, ClearCursorResponse, ClearCursorRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Delete an async SQL search.
	/// Delete an async SQL search or a stored synchronous SQL search.
	/// If the search is still running, the API cancels it.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncResponse> DeleteAsyncAsync(DeleteAsyncRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<DeleteAsyncRequest, DeleteAsyncResponse, DeleteAsyncRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Delete an async SQL search.
	/// Delete an async SQL search or a stored synchronous SQL search.
	/// If the search is still running, the API cancels it.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncResponse> DeleteAsyncAsync<TDocument>(DeleteAsyncRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncRequestDescriptor<TDocument>, DeleteAsyncResponse, DeleteAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Delete an async SQL search.
	/// Delete an async SQL search or a stored synchronous SQL search.
	/// If the search is still running, the API cancels it.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncResponse> DeleteAsyncAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteAsyncRequestDescriptor<TDocument>(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncRequestDescriptor<TDocument>, DeleteAsyncResponse, DeleteAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Delete an async SQL search.
	/// Delete an async SQL search or a stored synchronous SQL search.
	/// If the search is still running, the API cancels it.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncResponse> DeleteAsyncAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<DeleteAsyncRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteAsyncRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncRequestDescriptor<TDocument>, DeleteAsyncResponse, DeleteAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Delete an async SQL search.
	/// Delete an async SQL search or a stored synchronous SQL search.
	/// If the search is still running, the API cancels it.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncResponse> DeleteAsyncAsync(DeleteAsyncRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncRequestDescriptor, DeleteAsyncResponse, DeleteAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Delete an async SQL search.
	/// Delete an async SQL search or a stored synchronous SQL search.
	/// If the search is still running, the API cancels it.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncResponse> DeleteAsyncAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteAsyncRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncRequestDescriptor, DeleteAsyncResponse, DeleteAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Delete an async SQL search.
	/// Delete an async SQL search or a stored synchronous SQL search.
	/// If the search is still running, the API cancels it.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncResponse> DeleteAsyncAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<DeleteAsyncRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteAsyncRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncRequestDescriptor, DeleteAsyncResponse, DeleteAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get async SQL search results.
	/// Get the current status and available results for an async SQL search or stored synchronous SQL search.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncResponse> GetAsyncAsync(GetAsyncRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetAsyncRequest, GetAsyncResponse, GetAsyncRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get async SQL search results.
	/// Get the current status and available results for an async SQL search or stored synchronous SQL search.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncResponse> GetAsyncAsync<TDocument>(GetAsyncRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncRequestDescriptor<TDocument>, GetAsyncResponse, GetAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get async SQL search results.
	/// Get the current status and available results for an async SQL search or stored synchronous SQL search.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncResponse> GetAsyncAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncRequestDescriptor<TDocument>(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncRequestDescriptor<TDocument>, GetAsyncResponse, GetAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get async SQL search results.
	/// Get the current status and available results for an async SQL search or stored synchronous SQL search.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncResponse> GetAsyncAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetAsyncRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncRequestDescriptor<TDocument>, GetAsyncResponse, GetAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get async SQL search results.
	/// Get the current status and available results for an async SQL search or stored synchronous SQL search.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncResponse> GetAsyncAsync(GetAsyncRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncRequestDescriptor, GetAsyncResponse, GetAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get async SQL search results.
	/// Get the current status and available results for an async SQL search or stored synchronous SQL search.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncResponse> GetAsyncAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncRequestDescriptor, GetAsyncResponse, GetAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get async SQL search results.
	/// Get the current status and available results for an async SQL search or stored synchronous SQL search.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncResponse> GetAsyncAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetAsyncRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncRequestDescriptor, GetAsyncResponse, GetAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get the async SQL search status.
	/// Get the current status of an async SQL search or a stored synchronous SQL search.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncStatusResponse> GetAsyncStatusAsync(GetAsyncStatusRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetAsyncStatusRequest, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get the async SQL search status.
	/// Get the current status of an async SQL search or a stored synchronous SQL search.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncStatusResponse> GetAsyncStatusAsync<TDocument>(GetAsyncStatusRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncStatusRequestDescriptor<TDocument>, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get the async SQL search status.
	/// Get the current status of an async SQL search or a stored synchronous SQL search.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncStatusResponse> GetAsyncStatusAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncStatusRequestDescriptor<TDocument>(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncStatusRequestDescriptor<TDocument>, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get the async SQL search status.
	/// Get the current status of an async SQL search or a stored synchronous SQL search.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncStatusResponse> GetAsyncStatusAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetAsyncStatusRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncStatusRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncStatusRequestDescriptor<TDocument>, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get the async SQL search status.
	/// Get the current status of an async SQL search or a stored synchronous SQL search.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncStatusResponse> GetAsyncStatusAsync(GetAsyncStatusRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncStatusRequestDescriptor, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get the async SQL search status.
	/// Get the current status of an async SQL search or a stored synchronous SQL search.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncStatusResponse> GetAsyncStatusAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncStatusRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncStatusRequestDescriptor, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get the async SQL search status.
	/// Get the current status of an async SQL search or a stored synchronous SQL search.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncStatusResponse> GetAsyncStatusAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetAsyncStatusRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncStatusRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncStatusRequestDescriptor, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get SQL search results.
	/// Run an SQL request.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<QueryResponse> QueryAsync(QueryRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<QueryRequest, QueryResponse, QueryRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get SQL search results.
	/// Run an SQL request.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<QueryResponse> QueryAsync<TDocument>(QueryRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<QueryRequestDescriptor<TDocument>, QueryResponse, QueryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get SQL search results.
	/// Run an SQL request.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<QueryResponse> QueryAsync<TDocument>(CancellationToken cancellationToken = default)
	{
		var descriptor = new QueryRequestDescriptor<TDocument>();
		descriptor.BeforeRequest();
		return DoRequestAsync<QueryRequestDescriptor<TDocument>, QueryResponse, QueryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get SQL search results.
	/// Run an SQL request.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<QueryResponse> QueryAsync<TDocument>(Action<QueryRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new QueryRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<QueryRequestDescriptor<TDocument>, QueryResponse, QueryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get SQL search results.
	/// Run an SQL request.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<QueryResponse> QueryAsync(QueryRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<QueryRequestDescriptor, QueryResponse, QueryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get SQL search results.
	/// Run an SQL request.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<QueryResponse> QueryAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new QueryRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<QueryRequestDescriptor, QueryResponse, QueryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get SQL search results.
	/// Run an SQL request.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<QueryResponse> QueryAsync(Action<QueryRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new QueryRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<QueryRequestDescriptor, QueryResponse, QueryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Translate SQL into Elasticsearch queries.
	/// Translate an SQL search into a search API request containing Query DSL.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<TranslateResponse> TranslateAsync(TranslateRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<TranslateRequest, TranslateResponse, TranslateRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Translate SQL into Elasticsearch queries.
	/// Translate an SQL search into a search API request containing Query DSL.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<TranslateResponse> TranslateAsync<TDocument>(TranslateRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<TranslateRequestDescriptor<TDocument>, TranslateResponse, TranslateRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Translate SQL into Elasticsearch queries.
	/// Translate an SQL search into a search API request containing Query DSL.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<TranslateResponse> TranslateAsync<TDocument>(CancellationToken cancellationToken = default)
	{
		var descriptor = new TranslateRequestDescriptor<TDocument>();
		descriptor.BeforeRequest();
		return DoRequestAsync<TranslateRequestDescriptor<TDocument>, TranslateResponse, TranslateRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Translate SQL into Elasticsearch queries.
	/// Translate an SQL search into a search API request containing Query DSL.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<TranslateResponse> TranslateAsync<TDocument>(Action<TranslateRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new TranslateRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<TranslateRequestDescriptor<TDocument>, TranslateResponse, TranslateRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Translate SQL into Elasticsearch queries.
	/// Translate an SQL search into a search API request containing Query DSL.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<TranslateResponse> TranslateAsync(TranslateRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<TranslateRequestDescriptor, TranslateResponse, TranslateRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Translate SQL into Elasticsearch queries.
	/// Translate an SQL search into a search API request containing Query DSL.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<TranslateResponse> TranslateAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new TranslateRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<TranslateRequestDescriptor, TranslateResponse, TranslateRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Translate SQL into Elasticsearch queries.
	/// Translate an SQL search into a search API request containing Query DSL.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<TranslateResponse> TranslateAsync(Action<TranslateRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new TranslateRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<TranslateRequestDescriptor, TranslateResponse, TranslateRequestParameters>(descriptor, cancellationToken);
	}
}