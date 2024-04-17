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

namespace Elastic.Clients.Elasticsearch.TextStructure;

public partial class TextStructureNamespacedClient : NamespacedClientProxy
{
	/// <summary>
	/// <para>Initializes a new instance of the <see cref="TextStructureNamespacedClient"/> class for mocking.</para>
	/// </summary>
	protected TextStructureNamespacedClient() : base()
	{
	}

	internal TextStructureNamespacedClient(ElasticsearchClient client) : base(client)
	{
	}

	/// <summary>
	/// <para>Tests a Grok pattern on some text.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/test-grok-pattern.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual TestGrokPatternResponse TestGrokPattern(TestGrokPatternRequest request)
	{
		request.BeforeRequest();
		return DoRequest<TestGrokPatternRequest, TestGrokPatternResponse, TestGrokPatternRequestParameters>(request);
	}

	/// <summary>
	/// <para>Tests a Grok pattern on some text.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/test-grok-pattern.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<TestGrokPatternResponse> TestGrokPatternAsync(TestGrokPatternRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<TestGrokPatternRequest, TestGrokPatternResponse, TestGrokPatternRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Tests a Grok pattern on some text.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/test-grok-pattern.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual TestGrokPatternResponse TestGrokPattern(TestGrokPatternRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<TestGrokPatternRequestDescriptor, TestGrokPatternResponse, TestGrokPatternRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Tests a Grok pattern on some text.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/test-grok-pattern.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual TestGrokPatternResponse TestGrokPattern()
	{
		var descriptor = new TestGrokPatternRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequest<TestGrokPatternRequestDescriptor, TestGrokPatternResponse, TestGrokPatternRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Tests a Grok pattern on some text.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/test-grok-pattern.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual TestGrokPatternResponse TestGrokPattern(Action<TestGrokPatternRequestDescriptor> configureRequest)
	{
		var descriptor = new TestGrokPatternRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<TestGrokPatternRequestDescriptor, TestGrokPatternResponse, TestGrokPatternRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Tests a Grok pattern on some text.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/test-grok-pattern.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<TestGrokPatternResponse> TestGrokPatternAsync(TestGrokPatternRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<TestGrokPatternRequestDescriptor, TestGrokPatternResponse, TestGrokPatternRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Tests a Grok pattern on some text.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/test-grok-pattern.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<TestGrokPatternResponse> TestGrokPatternAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new TestGrokPatternRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<TestGrokPatternRequestDescriptor, TestGrokPatternResponse, TestGrokPatternRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Tests a Grok pattern on some text.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/test-grok-pattern.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<TestGrokPatternResponse> TestGrokPatternAsync(Action<TestGrokPatternRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new TestGrokPatternRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<TestGrokPatternRequestDescriptor, TestGrokPatternResponse, TestGrokPatternRequestParameters>(descriptor, cancellationToken);
	}
}