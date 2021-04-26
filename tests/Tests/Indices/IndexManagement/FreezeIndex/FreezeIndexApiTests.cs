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

using Elastic.Transport;
using FluentAssertions;
using Nest;
using Tests.Core.ManagedElasticsearch.Clusters;
using Tests.Framework.EndpointTests;
using Tests.Framework.EndpointTests.TestState;

namespace Tests.Indices.IndexManagement.FreezeIndex
{
	public class FreezeIndexApiTests
		: ApiIntegrationAgainstNewIndexTestBase
			<WritableCluster, FreezeIndexResponse, IFreezeIndexRequest, FreezeIndexDescriptor, FreezeIndexRequest>
	{
		public FreezeIndexApiTests(WritableCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override bool ExpectIsValid => true;
		protected override int ExpectStatusCode => 200;
		protected override HttpMethod HttpMethod => HttpMethod.POST;

		protected override FreezeIndexRequest Initializer => new FreezeIndexRequest(CallIsolatedValue);
		protected override string UrlPath => $"/{CallIsolatedValue}/_freeze";

		protected override LazyResponses ClientUsage() => Calls(
			(client, f) => client.Indices.Freeze(CallIsolatedValue),
			(client, f) => client.Indices.FreezeAsync(CallIsolatedValue),
			(client, r) => client.Indices.Freeze(r),
			(client, r) => client.Indices.FreezeAsync(r)
		);

		protected override void ExpectResponse(FreezeIndexResponse response) => response.Acknowledged.Should().BeTrue();
	}
}
