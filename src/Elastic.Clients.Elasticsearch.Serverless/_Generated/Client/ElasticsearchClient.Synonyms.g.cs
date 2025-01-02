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

namespace Elastic.Clients.Elasticsearch.Serverless.Synonyms;

public partial class SynonymsNamespacedClient : NamespacedClientProxy
{
	/// <summary>
	/// <para>
	/// Initializes a new instance of the <see cref="SynonymsNamespacedClient"/> class for mocking.
	/// </para>
	/// </summary>
	protected SynonymsNamespacedClient() : base()
	{
	}

	internal SynonymsNamespacedClient(ElasticsearchClient client) : base(client)
	{
	}

	/// <summary>
	/// <para>
	/// Delete a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteSynonymResponse> DeleteSynonymAsync(DeleteSynonymRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<DeleteSynonymRequest, DeleteSynonymResponse, DeleteSynonymRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Delete a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteSynonymResponse> DeleteSynonymAsync<TDocument>(DeleteSynonymRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteSynonymRequestDescriptor<TDocument>, DeleteSynonymResponse, DeleteSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Delete a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteSynonymResponse> DeleteSynonymAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteSynonymRequestDescriptor<TDocument>(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteSynonymRequestDescriptor<TDocument>, DeleteSynonymResponse, DeleteSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Delete a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteSynonymResponse> DeleteSynonymAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<DeleteSynonymRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteSynonymRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteSynonymRequestDescriptor<TDocument>, DeleteSynonymResponse, DeleteSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Delete a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteSynonymResponse> DeleteSynonymAsync(DeleteSynonymRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteSynonymRequestDescriptor, DeleteSynonymResponse, DeleteSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Delete a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteSynonymResponse> DeleteSynonymAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteSynonymRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteSynonymRequestDescriptor, DeleteSynonymResponse, DeleteSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Delete a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteSynonymResponse> DeleteSynonymAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<DeleteSynonymRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteSynonymRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteSynonymRequestDescriptor, DeleteSynonymResponse, DeleteSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Delete a synonym rule.
	/// Delete a synonym rule from a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-synonym-rule.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteSynonymRuleResponse> DeleteSynonymRuleAsync(DeleteSynonymRuleRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<DeleteSynonymRuleRequest, DeleteSynonymRuleResponse, DeleteSynonymRuleRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Delete a synonym rule.
	/// Delete a synonym rule from a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-synonym-rule.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteSynonymRuleResponse> DeleteSynonymRuleAsync(DeleteSynonymRuleRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteSynonymRuleRequestDescriptor, DeleteSynonymRuleResponse, DeleteSynonymRuleRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Delete a synonym rule.
	/// Delete a synonym rule from a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-synonym-rule.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteSynonymRuleResponse> DeleteSynonymRuleAsync(Elastic.Clients.Elasticsearch.Serverless.Id setId, Elastic.Clients.Elasticsearch.Serverless.Id ruleId, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteSynonymRuleRequestDescriptor(setId, ruleId);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteSynonymRuleRequestDescriptor, DeleteSynonymRuleResponse, DeleteSynonymRuleRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Delete a synonym rule.
	/// Delete a synonym rule from a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-synonym-rule.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteSynonymRuleResponse> DeleteSynonymRuleAsync(Elastic.Clients.Elasticsearch.Serverless.Id setId, Elastic.Clients.Elasticsearch.Serverless.Id ruleId, Action<DeleteSynonymRuleRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteSynonymRuleRequestDescriptor(setId, ruleId);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteSynonymRuleRequestDescriptor, DeleteSynonymRuleResponse, DeleteSynonymRuleRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSynonymResponse> GetSynonymAsync(GetSynonymRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetSynonymRequest, GetSynonymResponse, GetSynonymRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSynonymResponse> GetSynonymAsync<TDocument>(GetSynonymRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetSynonymRequestDescriptor<TDocument>, GetSynonymResponse, GetSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSynonymResponse> GetSynonymAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetSynonymRequestDescriptor<TDocument>(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetSynonymRequestDescriptor<TDocument>, GetSynonymResponse, GetSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSynonymResponse> GetSynonymAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetSynonymRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetSynonymRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetSynonymRequestDescriptor<TDocument>, GetSynonymResponse, GetSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSynonymResponse> GetSynonymAsync(GetSynonymRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetSynonymRequestDescriptor, GetSynonymResponse, GetSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSynonymResponse> GetSynonymAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetSynonymRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetSynonymRequestDescriptor, GetSynonymResponse, GetSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSynonymResponse> GetSynonymAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetSynonymRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetSynonymRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetSynonymRequestDescriptor, GetSynonymResponse, GetSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get a synonym rule.
	/// Get a synonym rule from a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-synonym-rule.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSynonymRuleResponse> GetSynonymRuleAsync(GetSynonymRuleRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetSynonymRuleRequest, GetSynonymRuleResponse, GetSynonymRuleRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get a synonym rule.
	/// Get a synonym rule from a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-synonym-rule.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSynonymRuleResponse> GetSynonymRuleAsync(GetSynonymRuleRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetSynonymRuleRequestDescriptor, GetSynonymRuleResponse, GetSynonymRuleRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get a synonym rule.
	/// Get a synonym rule from a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-synonym-rule.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSynonymRuleResponse> GetSynonymRuleAsync(Elastic.Clients.Elasticsearch.Serverless.Id setId, Elastic.Clients.Elasticsearch.Serverless.Id ruleId, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetSynonymRuleRequestDescriptor(setId, ruleId);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetSynonymRuleRequestDescriptor, GetSynonymRuleResponse, GetSynonymRuleRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get a synonym rule.
	/// Get a synonym rule from a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-synonym-rule.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSynonymRuleResponse> GetSynonymRuleAsync(Elastic.Clients.Elasticsearch.Serverless.Id setId, Elastic.Clients.Elasticsearch.Serverless.Id ruleId, Action<GetSynonymRuleRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetSynonymRuleRequestDescriptor(setId, ruleId);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetSynonymRuleRequestDescriptor, GetSynonymRuleResponse, GetSynonymRuleRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get all synonym sets.
	/// Get a summary of all defined synonym sets.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/list-synonyms-sets.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSynonymsSetsResponse> GetSynonymsSetsAsync(GetSynonymsSetsRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetSynonymsSetsRequest, GetSynonymsSetsResponse, GetSynonymsSetsRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get all synonym sets.
	/// Get a summary of all defined synonym sets.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/list-synonyms-sets.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSynonymsSetsResponse> GetSynonymsSetsAsync(GetSynonymsSetsRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetSynonymsSetsRequestDescriptor, GetSynonymsSetsResponse, GetSynonymsSetsRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get all synonym sets.
	/// Get a summary of all defined synonym sets.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/list-synonyms-sets.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSynonymsSetsResponse> GetSynonymsSetsAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new GetSynonymsSetsRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<GetSynonymsSetsRequestDescriptor, GetSynonymsSetsResponse, GetSynonymsSetsRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Get all synonym sets.
	/// Get a summary of all defined synonym sets.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/list-synonyms-sets.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSynonymsSetsResponse> GetSynonymsSetsAsync(Action<GetSynonymsSetsRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetSynonymsSetsRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetSynonymsSetsRequestDescriptor, GetSynonymsSetsResponse, GetSynonymsSetsRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Create or update a synonym set.
	/// Synonyms sets are limited to a maximum of 10,000 synonym rules per set.
	/// If you need to manage more synonym rules, you can create multiple synonym sets.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/put-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutSynonymResponse> PutSynonymAsync(PutSynonymRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<PutSynonymRequest, PutSynonymResponse, PutSynonymRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Create or update a synonym set.
	/// Synonyms sets are limited to a maximum of 10,000 synonym rules per set.
	/// If you need to manage more synonym rules, you can create multiple synonym sets.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/put-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutSynonymResponse> PutSynonymAsync<TDocument>(PutSynonymRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<PutSynonymRequestDescriptor<TDocument>, PutSynonymResponse, PutSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Create or update a synonym set.
	/// Synonyms sets are limited to a maximum of 10,000 synonym rules per set.
	/// If you need to manage more synonym rules, you can create multiple synonym sets.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/put-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutSynonymResponse> PutSynonymAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new PutSynonymRequestDescriptor<TDocument>(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<PutSynonymRequestDescriptor<TDocument>, PutSynonymResponse, PutSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Create or update a synonym set.
	/// Synonyms sets are limited to a maximum of 10,000 synonym rules per set.
	/// If you need to manage more synonym rules, you can create multiple synonym sets.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/put-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutSynonymResponse> PutSynonymAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<PutSynonymRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new PutSynonymRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<PutSynonymRequestDescriptor<TDocument>, PutSynonymResponse, PutSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Create or update a synonym set.
	/// Synonyms sets are limited to a maximum of 10,000 synonym rules per set.
	/// If you need to manage more synonym rules, you can create multiple synonym sets.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/put-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutSynonymResponse> PutSynonymAsync(PutSynonymRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<PutSynonymRequestDescriptor, PutSynonymResponse, PutSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Create or update a synonym set.
	/// Synonyms sets are limited to a maximum of 10,000 synonym rules per set.
	/// If you need to manage more synonym rules, you can create multiple synonym sets.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/put-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutSynonymResponse> PutSynonymAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new PutSynonymRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<PutSynonymRequestDescriptor, PutSynonymResponse, PutSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Create or update a synonym set.
	/// Synonyms sets are limited to a maximum of 10,000 synonym rules per set.
	/// If you need to manage more synonym rules, you can create multiple synonym sets.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/put-synonyms-set.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutSynonymResponse> PutSynonymAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<PutSynonymRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new PutSynonymRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<PutSynonymRequestDescriptor, PutSynonymResponse, PutSynonymRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Create or update a synonym rule.
	/// Create or update a synonym rule in a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/put-synonym-rule.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutSynonymRuleResponse> PutSynonymRuleAsync(PutSynonymRuleRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<PutSynonymRuleRequest, PutSynonymRuleResponse, PutSynonymRuleRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Create or update a synonym rule.
	/// Create or update a synonym rule in a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/put-synonym-rule.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutSynonymRuleResponse> PutSynonymRuleAsync(PutSynonymRuleRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<PutSynonymRuleRequestDescriptor, PutSynonymRuleResponse, PutSynonymRuleRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Create or update a synonym rule.
	/// Create or update a synonym rule in a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/put-synonym-rule.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutSynonymRuleResponse> PutSynonymRuleAsync(Elastic.Clients.Elasticsearch.Serverless.Id setId, Elastic.Clients.Elasticsearch.Serverless.Id ruleId, CancellationToken cancellationToken = default)
	{
		var descriptor = new PutSynonymRuleRequestDescriptor(setId, ruleId);
		descriptor.BeforeRequest();
		return DoRequestAsync<PutSynonymRuleRequestDescriptor, PutSynonymRuleResponse, PutSynonymRuleRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Create or update a synonym rule.
	/// Create or update a synonym rule in a synonym set.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/put-synonym-rule.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutSynonymRuleResponse> PutSynonymRuleAsync(Elastic.Clients.Elasticsearch.Serverless.Id setId, Elastic.Clients.Elasticsearch.Serverless.Id ruleId, Action<PutSynonymRuleRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new PutSynonymRuleRequestDescriptor(setId, ruleId);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<PutSynonymRuleRequestDescriptor, PutSynonymRuleResponse, PutSynonymRuleRequestParameters>(descriptor, cancellationToken);
	}
}