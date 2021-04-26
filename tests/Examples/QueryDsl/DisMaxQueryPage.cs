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

using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.QueryDsl
{
	public class DisMaxQueryPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("query-dsl/dis-max-query.asciidoc:18")]
		public void Line18()
		{
			// tag::fcf5a593cfe8809d98a5239ad9c82038[]
			var response0 = new SearchResponse<object>();
			// end::fcf5a593cfe8809d98a5239ad9c82038[]

			response0.MatchesExample(@"GET /_search
			{
			    ""query"": {
			        ""dis_max"" : {
			            ""queries"" : [
			                { ""term"" : { ""title"" : ""Quick pets"" }},
			                { ""term"" : { ""body"" : ""Quick pets"" }}
			            ],
			            ""tie_breaker"" : 0.7
			        }
			    }
			}");
		}
	}
}
