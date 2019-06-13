﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;

namespace Nest
{
	public static partial class ElasticClientExtensions
	{
		/// <summary>
		/// APIs in elasticsearch accept an index name when working against a specific index, and several indices when applicable.
		/// <para>
		/// The index aliases API allow to alias an index with a name, with all APIs automatically converting the alias name to the
		/// actual index name.
		/// </para>
		/// <para>
		/// An alias can also be mapped to more than one index, and when specifying it, the alias
		/// will automatically expand to the aliases indices.i
		/// </para>
		/// <para>
		/// An alias can also be associated with a filter that will
		/// automatically be applied when searching, and routing values.
		/// </para>
		/// <para> </para>
		/// http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/indices-aliases.html
		/// </summary>
		/// <param name="selector">A descriptor that describes the parameters for the alias operation</param>
		public static BulkAliasResponse Alias(this IElasticClient client,Func<BulkAliasDescriptor, IBulkAliasRequest> selector);

		/// <inheritdoc />
		public static BulkAliasResponse Alias(this IElasticClient client,IBulkAliasRequest request);

		/// <inheritdoc />
		public static Task<BulkAliasResponse> AliasAsync(this IElasticClient client,Func<BulkAliasDescriptor, IBulkAliasRequest> selector,
			CancellationToken ct = default
		);

		/// <inheritdoc />
		public static Task<BulkAliasResponse> AliasAsync(this IElasticClient client,IBulkAliasRequest request, CancellationToken ct = default);
	}
}
