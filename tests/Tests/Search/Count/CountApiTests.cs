// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System;
using Elastic.Clients.Elasticsearch.QueryDsl;
using Tests.Core.ManagedElasticsearch.Clusters;
using Tests.Domain;
using Tests.Framework.EndpointTests;
using Tests.Framework.EndpointTests.TestState;

namespace Tests.Search.Count
{
	public class CountApiTests
		: ApiIntegrationTestBase<ReadOnlyCluster, CountResponse, CountRequestDescriptor<Project>, CountRequest<Project>>
	{
		public CountApiTests(ReadOnlyCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override bool ExpectIsValid => true;

		protected override object ExpectJson => new
		{
			query = new
			{
				match = new
				{
					name = new
					{
						query = "NEST"
					}
				}
			}
		};

		protected override int ExpectStatusCode => 200;

		protected override Action<CountRequestDescriptor<Project>> Fluent => c => c
			.Query(new QueryContainer(new MatchQuery
			{
				Field = "name",
				Query = "NEST"
			}));

		protected override HttpMethod HttpMethod => HttpMethod.POST;

		protected override CountRequest<Project> Initializer => new()
		{
			Query = new QueryContainer(new MatchQuery
			{
				Field = "name",
				Query = "NEST"
			})
		};

		protected override string ExpectedUrlPathAndQuery => "/project/_count";

		protected override LazyResponses ClientUsage() => Calls(
			(c, f) => c.Count(f),
			(c, f) => c.CountAsync(f),
			(c, r) => c.Count(r),
			(c, r) => c.CountAsync(r)
		);
	}	

	public class CountApi_FluentMatch_ApiTests
		: ApiIntegrationTestBase<ReadOnlyCluster, CountResponse, CountRequestDescriptor<Project>, CountRequest<Project>>
	{
		public CountApi_FluentMatch_ApiTests(ReadOnlyCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override bool ExpectIsValid => true;

		protected override object ExpectJson => new
		{
			query = new
			{
				match = new
				{
					name = new
					{
						query = "NEST"
					}
				}
			}
		};

		protected override int ExpectStatusCode => 200;

		protected override Action<CountRequestDescriptor<Project>> Fluent => c => c
			.Query(q => q
				.Match(m => m
					.Field("name")
					.Query("NEST")));

		protected override HttpMethod HttpMethod => HttpMethod.POST;

		protected override CountRequest<Project> Initializer => new()
		{
			Query = new QueryContainer(new MatchQuery
			{
				Field = "name",
				Query = "NEST"
			})
		};

		protected override string ExpectedUrlPathAndQuery => "/project/_count";

		protected override LazyResponses ClientUsage() => Calls(
			(c, f) => c.Count(f),
			(c, f) => c.CountAsync(f),
			(c, r) => c.Count(r),
			(c, r) => c.CountAsync(r)
		);
	}
}