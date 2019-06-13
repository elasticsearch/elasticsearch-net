﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;

namespace Nest
{
	public static partial class ElasticClientExtensions
	{
		/// <summary>
		/// Adds or updates a typed JSON document in a specific index, making it searchable.
		/// <para> </para>
		/// <a href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/docs-index_.html">http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/docs-index_.html</a>
		/// </summary>
		/// <typeparam name="TDocument">The document type used to infer the default index, type and id</typeparam>
		/// <param name="document">
		/// The document to be indexed. Id will be inferred from (in order):
		/// <para>1. Id property set up on <see cref="ConnectionSettings" /> for <typeparamref name="TDocument" /></para>
		/// <para>
		/// 2. <see cref="ElasticsearchTypeAttribute.IdProperty" /> property on <see cref="ElasticsearchTypeAttribute" /> applied to
		/// <typeparamref name="TDocument" />
		/// </para>
		/// <para>3. A property named Id on <typeparamref name="TDocument" /></para>
		/// </param>
		/// <param name="selector">Optionally further describe the index operation i.e override type, index, id</param>
		public static IndexResponse IndexDocument<TDocument>(this IElasticClient client,TDocument document) where TDocument : class;

		public static IndexResponse Index<TDocument>(this IElasticClient client,TDocument document, Func<IndexDescriptor<TDocument>, IIndexRequest<TDocument>> selector) where TDocument : class;

		/// <inheritdoc />
		public static IndexResponse Index<TDocument>(this IElasticClient client,IIndexRequest<TDocument> request) where TDocument : class;

		public static Task<IndexResponse> IndexDocumentAsync<T>(this IElasticClient client,T document, CancellationToken ct = default)
			where T : class;

		/// <inheritdoc />
		public static Task<IndexResponse> IndexAsync<TDocument>(this IElasticClient client,
			TDocument document,
			Func<IndexDescriptor<TDocument>, IIndexRequest<TDocument>> selector,
			CancellationToken ct = default
		) where TDocument : class;

		/// <inheritdoc />
		public static Task<IndexResponse> IndexAsync<TDocument>(this IElasticClient client,IIndexRequest<TDocument> request, CancellationToken ct = default)
			where TDocument : class;
	}

}
