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

using System;
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Elasticsearch.Net;
using FluentAssertions;
using Nest;
using Tests.Core.Extensions;
using Tests.Framework.EndpointTests.TestState;

namespace Tests.XPack.MachineLearning.DeleteCalendarJob
{
	[SkipVersion("<6.4.0", "Calendar functions for machine learning introduced in 6.4.0")]
	public class DeleteCalendarJobApiTests : MachineLearningIntegrationTestBase<DeleteCalendarJobResponse, IDeleteCalendarJobRequest, DeleteCalendarJobDescriptor, DeleteCalendarJobRequest>
	{
		public DeleteCalendarJobApiTests(MachineLearningCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override void IntegrationSetup(IElasticClient client, CallUniqueValues values)
		{
			foreach (var callUniqueValue in values)
			{
				PutJob(client, callUniqueValue.Value + "_job");
				PutCalendar(client, callUniqueValue.Value + "_calendar");
				PutCalendarJob(client, callUniqueValue.Value + "_calendar", callUniqueValue.Value + "_job");
			}
		}


		protected override bool ExpectIsValid => true;

		protected override object ExpectJson => null;

		protected override int ExpectStatusCode => 200;

		protected override Func<DeleteCalendarJobDescriptor, IDeleteCalendarJobRequest> Fluent => f => f;

		protected override HttpMethod HttpMethod => HttpMethod.DELETE;

		protected override DeleteCalendarJobRequest Initializer => new DeleteCalendarJobRequest(CallIsolatedValue + "_calendar",CallIsolatedValue + "_job");

		protected override bool SupportsDeserialization => false;
		protected override string UrlPath => $"_ml/calendars/{CallIsolatedValue}_calendar/jobs/{CallIsolatedValue}_job";

		protected override LazyResponses ClientUsage() => Calls(
			(client, f) => client.MachineLearning.DeleteCalendarJob(CallIsolatedValue + "_calendar",CallIsolatedValue + "_job", f),
			(client, f) => client.MachineLearning.DeleteCalendarJobAsync(CallIsolatedValue + "_calendar",CallIsolatedValue + "_job", f),
			(client, r) => client.MachineLearning.DeleteCalendarJob(r),
			(client, r) => client.MachineLearning.DeleteCalendarJobAsync(r)
		);

		protected override DeleteCalendarJobDescriptor NewDescriptor() => new DeleteCalendarJobDescriptor(CallIsolatedValue + "_calendar",CallIsolatedValue + "_job");

		protected override void ExpectResponse(DeleteCalendarJobResponse response)
		{
			response.ShouldBeValid();

			response.CalendarId.Should().Be(CallIsolatedValue + "_calendar");

			response.JobIds.Should().NotBeNull();

			response.JobIds.Should().BeEmpty();

			response.Description.Should().Be("Planned outages");
		}
	}
}
