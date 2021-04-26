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
using System.Linq;
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using FluentAssertions;
using Nest;
using Tests.Domain;

namespace Tests.QueryDsl.BoolDsl.Operators
{
	public class OrOperatorOnManualBoolsTests : OperatorUsageBase
	{
		[U] public void CombindingTwoBools()
		{
			var queries = new QueryContainer[] { Query };
			ReturnsBool(
				new BoolQuery { Must = queries, Should = queries }
				|| new BoolQuery { MustNot = queries, Should = queries }
				, q => q.Bool(b => b.Must(c => c.Query()).Should(c => c.Query()))
					|| q.Bool(b => b.MustNot(c => c.Query()).Should(c => c.Query()))
				, b =>
				{
					b.Should.Should().NotBeEmpty().And.HaveCount(2);
					var first = (IQueryContainer)b.Should.First();
					var last = (IQueryContainer)b.Should.Last();
					first.Bool.Should().NotBeNull();
					last.Bool.Should().NotBeNull();

					var firstBool = first.Bool;
					var lastBool = last.Bool;

					firstBool.Should.Should().NotBeEmpty().And.HaveCount(1);
					firstBool.Must.Should().NotBeEmpty().And.HaveCount(1);

					lastBool.Should.Should().NotBeEmpty().And.HaveCount(1);
					lastBool.MustNot.Should().NotBeEmpty().And.HaveCount(1);
				});
		}

		protected void CombineBothWays(
			QueryContainer ois1,
			QueryContainer ois2,
			Func<QueryContainerDescriptor<Project>, QueryContainer> lambda1,
			Func<QueryContainerDescriptor<Project>, QueryContainer> lambda2,
			Action<IQueryContainer> assertLeft,
			Action<IQueryContainer> assertRight,
			Action<IBoolQuery> assertContainer = null
		)
		{
			var oisLeft = ois1 || ois2;
			Func<QueryContainerDescriptor<Project>, QueryContainer> lambdaLeft = (s) => lambda1(s) || lambda2(s);

			ReturnsBool(oisLeft, lambdaLeft, b =>
			{
				var left = (IQueryContainer)b.Should.First();
				var right = (IQueryContainer)b.Should.Last();
				assertLeft(left);
				assertRight(right);
				assertContainer?.Invoke(b);
			});

			var oisRight = ois2 || ois1;
			Func<QueryContainerDescriptor<Project>, QueryContainer> lambdaRight = (s) => lambda2(s) || lambda1(s);

			ReturnsBool(oisRight, lambdaRight, b =>
			{
				var left = (IQueryContainer)b.Should.First();
				var right = (IQueryContainer)b.Should.Last();
				assertRight(left);
				assertLeft(right);
				assertContainer?.Invoke(b);
			});
		}

		[U] public void OrIntoBoolWithMustAndShould()
		{
			var queries = new QueryContainer[] { Query };
			CombineBothWays(
				new BoolQuery { Must = queries, Should = queries }, Query
				, q => q.Bool(b => b.Must(c => c.Query()).Should(c => c.Query())), q => q.Query()
				, l => l.Bool.Should().NotBeNull()
				, r => r.Term.Should().NotBeNull()
				, b => b.Should.Should().NotBeEmpty().And.HaveCount(2)
			);
		}

		[U] public void OrIntoBoolWithMustAndMustNot()
		{
			var queries = new QueryContainer[] { Query };
			CombineBothWays(
				new BoolQuery { Must = queries, MustNot = queries }, Query
				, q => q.Bool(b => b.Must(c => c.Query()).MustNot(c => c.Query())), q => q.Query()
				, l => l.Bool.Should().NotBeNull()
				, r => r.Term.Should().NotBeNull()
				, b => { b.Should.Should().NotBeEmpty().And.HaveCount(2); }
			);
		}

		[U] public void OrIntoBoolWithMust()
		{
			var queries = new QueryContainer[] { Query };
			CombineBothWays(
				new BoolQuery { Must = queries }, Query
				, q => q.Bool(b => b.Must(c => c.Query())), q => q.Query()
				, l => l.Bool.Should().NotBeNull()
				, r => r.Term.Should().NotBeNull()
				, b => { b.Should.Should().NotBeEmpty().And.HaveCount(2); }
			);
		}

		[U] public void OrIntoBoolWithShould()
		{
			var queries = new QueryContainer[] { Query };
			CombineBothWays(
				new BoolQuery { Should = queries }, Query
				, q => q.Bool(b => b.Should(c => c.Query())), q => q.Query()
				, l => l.Term.Should().NotBeNull()
				, r => r.Term.Should().NotBeNull()
				, b => b.Should.Should().NotBeEmpty().And.HaveCount(2)
			);
		}

		[U] public void OrIntoNamedBool()
		{
			var queries = new QueryContainer[] { Query };
			CombineBothWays(
				new BoolQuery { Should = queries, Name = "name" }, Query
				, q => q.Bool(b => b.Should(c => c.Query()).Name("name")), q => q.Query()
				, l =>
				{
					l.Bool.Should().NotBeNull();
					l.Bool.Should.Should().NotBeNullOrEmpty();
					l.Bool.Name.Should().Be("name");
				}
				, r => r.Term.Should().NotBeNull()
				, b => b.Should.Should().NotBeEmpty().And.HaveCount(2)
			);
		}
	}
}
