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

namespace Elastic.Clients.Elasticsearch.LicenseManagement;

public partial class LicenseManagementNamespacedClient : NamespacedClientProxy
{
	/// <summary>
	/// <para>Initializes a new instance of the <see cref="LicenseManagementNamespacedClient"/> class for mocking.</para>
	/// </summary>
	protected LicenseManagementNamespacedClient() : base()
	{
	}

	internal LicenseManagementNamespacedClient(ElasticsearchClient client) : base(client)
	{
	}

	/// <summary>
	/// <para>Deletes licensing information for the cluster</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual DeleteLicenseResponse Delete(DeleteLicenseRequest request)
	{
		request.BeforeRequest();
		return DoRequest<DeleteLicenseRequest, DeleteLicenseResponse, DeleteLicenseRequestParameters>(request);
	}

	/// <summary>
	/// <para>Deletes licensing information for the cluster</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteLicenseResponse> DeleteAsync(DeleteLicenseRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<DeleteLicenseRequest, DeleteLicenseResponse, DeleteLicenseRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes licensing information for the cluster</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual DeleteLicenseResponse Delete()
	{
		var descriptor = new DeleteLicenseRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequest<DeleteLicenseRequestDescriptor, DeleteLicenseResponse, DeleteLicenseRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Deletes licensing information for the cluster</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual DeleteLicenseResponse Delete(DeleteLicenseRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<DeleteLicenseRequestDescriptor, DeleteLicenseResponse, DeleteLicenseRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Deletes licensing information for the cluster</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual DeleteLicenseResponse Delete(Action<DeleteLicenseRequestDescriptor> configureRequest)
	{
		var descriptor = new DeleteLicenseRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<DeleteLicenseRequestDescriptor, DeleteLicenseResponse, DeleteLicenseRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Deletes licensing information for the cluster</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteLicenseResponse> DeleteAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteLicenseRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteLicenseRequestDescriptor, DeleteLicenseResponse, DeleteLicenseRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes licensing information for the cluster</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteLicenseResponse> DeleteAsync(DeleteLicenseRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteLicenseRequestDescriptor, DeleteLicenseResponse, DeleteLicenseRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes licensing information for the cluster</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteLicenseResponse> DeleteAsync(Action<DeleteLicenseRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteLicenseRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteLicenseRequestDescriptor, DeleteLicenseResponse, DeleteLicenseRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves licensing information for the cluster</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetLicenseResponse Get(GetLicenseRequest request)
	{
		request.BeforeRequest();
		return DoRequest<GetLicenseRequest, GetLicenseResponse, GetLicenseRequestParameters>(request);
	}

	/// <summary>
	/// <para>Retrieves licensing information for the cluster</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetLicenseResponse> GetAsync(GetLicenseRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetLicenseRequest, GetLicenseResponse, GetLicenseRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves licensing information for the cluster</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual GetLicenseResponse Get()
	{
		var descriptor = new GetLicenseRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequest<GetLicenseRequestDescriptor, GetLicenseResponse, GetLicenseRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Retrieves licensing information for the cluster</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual GetLicenseResponse Get(GetLicenseRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<GetLicenseRequestDescriptor, GetLicenseResponse, GetLicenseRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Retrieves licensing information for the cluster</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual GetLicenseResponse Get(Action<GetLicenseRequestDescriptor> configureRequest)
	{
		var descriptor = new GetLicenseRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<GetLicenseRequestDescriptor, GetLicenseResponse, GetLicenseRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Retrieves licensing information for the cluster</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetLicenseResponse> GetAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new GetLicenseRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<GetLicenseRequestDescriptor, GetLicenseResponse, GetLicenseRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves licensing information for the cluster</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetLicenseResponse> GetAsync(GetLicenseRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetLicenseRequestDescriptor, GetLicenseResponse, GetLicenseRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves licensing information for the cluster</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetLicenseResponse> GetAsync(Action<GetLicenseRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetLicenseRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetLicenseRequestDescriptor, GetLicenseResponse, GetLicenseRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves information about the status of the basic license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-basic-status.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetBasicStatusResponse GetBasicStatus(GetBasicStatusRequest request)
	{
		request.BeforeRequest();
		return DoRequest<GetBasicStatusRequest, GetBasicStatusResponse, GetBasicStatusRequestParameters>(request);
	}

	/// <summary>
	/// <para>Retrieves information about the status of the basic license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-basic-status.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetBasicStatusResponse> GetBasicStatusAsync(GetBasicStatusRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetBasicStatusRequest, GetBasicStatusResponse, GetBasicStatusRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves information about the status of the basic license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-basic-status.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual GetBasicStatusResponse GetBasicStatus()
	{
		var descriptor = new GetBasicStatusRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequest<GetBasicStatusRequestDescriptor, GetBasicStatusResponse, GetBasicStatusRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Retrieves information about the status of the basic license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-basic-status.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual GetBasicStatusResponse GetBasicStatus(GetBasicStatusRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<GetBasicStatusRequestDescriptor, GetBasicStatusResponse, GetBasicStatusRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Retrieves information about the status of the basic license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-basic-status.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual GetBasicStatusResponse GetBasicStatus(Action<GetBasicStatusRequestDescriptor> configureRequest)
	{
		var descriptor = new GetBasicStatusRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<GetBasicStatusRequestDescriptor, GetBasicStatusResponse, GetBasicStatusRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Retrieves information about the status of the basic license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-basic-status.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetBasicStatusResponse> GetBasicStatusAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new GetBasicStatusRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<GetBasicStatusRequestDescriptor, GetBasicStatusResponse, GetBasicStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves information about the status of the basic license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-basic-status.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetBasicStatusResponse> GetBasicStatusAsync(GetBasicStatusRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetBasicStatusRequestDescriptor, GetBasicStatusResponse, GetBasicStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves information about the status of the basic license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-basic-status.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetBasicStatusResponse> GetBasicStatusAsync(Action<GetBasicStatusRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetBasicStatusRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetBasicStatusRequestDescriptor, GetBasicStatusResponse, GetBasicStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves information about the status of the trial license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-trial-status.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetTrialStatusResponse GetTrialStatus(GetTrialStatusRequest request)
	{
		request.BeforeRequest();
		return DoRequest<GetTrialStatusRequest, GetTrialStatusResponse, GetTrialStatusRequestParameters>(request);
	}

	/// <summary>
	/// <para>Retrieves information about the status of the trial license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-trial-status.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetTrialStatusResponse> GetTrialStatusAsync(GetTrialStatusRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetTrialStatusRequest, GetTrialStatusResponse, GetTrialStatusRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves information about the status of the trial license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-trial-status.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual GetTrialStatusResponse GetTrialStatus()
	{
		var descriptor = new GetTrialStatusRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequest<GetTrialStatusRequestDescriptor, GetTrialStatusResponse, GetTrialStatusRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Retrieves information about the status of the trial license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-trial-status.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual GetTrialStatusResponse GetTrialStatus(GetTrialStatusRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<GetTrialStatusRequestDescriptor, GetTrialStatusResponse, GetTrialStatusRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Retrieves information about the status of the trial license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-trial-status.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual GetTrialStatusResponse GetTrialStatus(Action<GetTrialStatusRequestDescriptor> configureRequest)
	{
		var descriptor = new GetTrialStatusRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<GetTrialStatusRequestDescriptor, GetTrialStatusResponse, GetTrialStatusRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Retrieves information about the status of the trial license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-trial-status.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetTrialStatusResponse> GetTrialStatusAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new GetTrialStatusRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<GetTrialStatusRequestDescriptor, GetTrialStatusResponse, GetTrialStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves information about the status of the trial license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-trial-status.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetTrialStatusResponse> GetTrialStatusAsync(GetTrialStatusRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetTrialStatusRequestDescriptor, GetTrialStatusResponse, GetTrialStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Retrieves information about the status of the trial license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-trial-status.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetTrialStatusResponse> GetTrialStatusAsync(Action<GetTrialStatusRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetTrialStatusRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetTrialStatusRequestDescriptor, GetTrialStatusResponse, GetTrialStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Updates the license for the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/update-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual PostResponse Post(PostRequest request)
	{
		request.BeforeRequest();
		return DoRequest<PostRequest, PostResponse, PostRequestParameters>(request);
	}

	/// <summary>
	/// <para>Updates the license for the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/update-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PostResponse> PostAsync(PostRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<PostRequest, PostResponse, PostRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Updates the license for the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/update-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual PostResponse Post()
	{
		var descriptor = new PostRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequest<PostRequestDescriptor, PostResponse, PostRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Updates the license for the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/update-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual PostResponse Post(PostRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<PostRequestDescriptor, PostResponse, PostRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Updates the license for the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/update-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual PostResponse Post(Action<PostRequestDescriptor> configureRequest)
	{
		var descriptor = new PostRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<PostRequestDescriptor, PostResponse, PostRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Updates the license for the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/update-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PostResponse> PostAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new PostRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<PostRequestDescriptor, PostResponse, PostRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Updates the license for the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/update-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PostResponse> PostAsync(PostRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<PostRequestDescriptor, PostResponse, PostRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Updates the license for the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/update-license.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PostResponse> PostAsync(Action<PostRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new PostRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<PostRequestDescriptor, PostResponse, PostRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Starts an indefinite basic license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/start-basic.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual PostStartBasicResponse PostStartBasic(PostStartBasicRequest request)
	{
		request.BeforeRequest();
		return DoRequest<PostStartBasicRequest, PostStartBasicResponse, PostStartBasicRequestParameters>(request);
	}

	/// <summary>
	/// <para>Starts an indefinite basic license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/start-basic.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PostStartBasicResponse> PostStartBasicAsync(PostStartBasicRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<PostStartBasicRequest, PostStartBasicResponse, PostStartBasicRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Starts an indefinite basic license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/start-basic.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual PostStartBasicResponse PostStartBasic()
	{
		var descriptor = new PostStartBasicRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequest<PostStartBasicRequestDescriptor, PostStartBasicResponse, PostStartBasicRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Starts an indefinite basic license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/start-basic.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual PostStartBasicResponse PostStartBasic(PostStartBasicRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<PostStartBasicRequestDescriptor, PostStartBasicResponse, PostStartBasicRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Starts an indefinite basic license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/start-basic.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual PostStartBasicResponse PostStartBasic(Action<PostStartBasicRequestDescriptor> configureRequest)
	{
		var descriptor = new PostStartBasicRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<PostStartBasicRequestDescriptor, PostStartBasicResponse, PostStartBasicRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Starts an indefinite basic license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/start-basic.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PostStartBasicResponse> PostStartBasicAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new PostStartBasicRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<PostStartBasicRequestDescriptor, PostStartBasicResponse, PostStartBasicRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Starts an indefinite basic license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/start-basic.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PostStartBasicResponse> PostStartBasicAsync(PostStartBasicRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<PostStartBasicRequestDescriptor, PostStartBasicResponse, PostStartBasicRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Starts an indefinite basic license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/start-basic.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PostStartBasicResponse> PostStartBasicAsync(Action<PostStartBasicRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new PostStartBasicRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<PostStartBasicRequestDescriptor, PostStartBasicResponse, PostStartBasicRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>starts a limited time trial license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/start-trial.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual PostStartTrialResponse PostStartTrial(PostStartTrialRequest request)
	{
		request.BeforeRequest();
		return DoRequest<PostStartTrialRequest, PostStartTrialResponse, PostStartTrialRequestParameters>(request);
	}

	/// <summary>
	/// <para>starts a limited time trial license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/start-trial.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PostStartTrialResponse> PostStartTrialAsync(PostStartTrialRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<PostStartTrialRequest, PostStartTrialResponse, PostStartTrialRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>starts a limited time trial license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/start-trial.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual PostStartTrialResponse PostStartTrial()
	{
		var descriptor = new PostStartTrialRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequest<PostStartTrialRequestDescriptor, PostStartTrialResponse, PostStartTrialRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>starts a limited time trial license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/start-trial.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual PostStartTrialResponse PostStartTrial(PostStartTrialRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<PostStartTrialRequestDescriptor, PostStartTrialResponse, PostStartTrialRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>starts a limited time trial license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/start-trial.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual PostStartTrialResponse PostStartTrial(Action<PostStartTrialRequestDescriptor> configureRequest)
	{
		var descriptor = new PostStartTrialRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<PostStartTrialRequestDescriptor, PostStartTrialResponse, PostStartTrialRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>starts a limited time trial license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/start-trial.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PostStartTrialResponse> PostStartTrialAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new PostStartTrialRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<PostStartTrialRequestDescriptor, PostStartTrialResponse, PostStartTrialRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>starts a limited time trial license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/start-trial.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PostStartTrialResponse> PostStartTrialAsync(PostStartTrialRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<PostStartTrialRequestDescriptor, PostStartTrialResponse, PostStartTrialRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>starts a limited time trial license.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/start-trial.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PostStartTrialResponse> PostStartTrialAsync(Action<PostStartTrialRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new PostStartTrialRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<PostStartTrialRequestDescriptor, PostStartTrialResponse, PostStartTrialRequestParameters>(descriptor, cancellationToken);
	}
}