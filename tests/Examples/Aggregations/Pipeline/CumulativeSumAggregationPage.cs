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

namespace Examples.Aggregations.Pipeline
{
	public class CumulativeSumAggregationPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("aggregations/pipeline/cumulative-sum-aggregation.asciidoc:35")]
		public void Line35()
		{
			// tag::1ae73d3fcc39bef9ddc654bb82d5d239[]
			var response0 = new SearchResponse<object>();
			// end::1ae73d3fcc39bef9ddc654bb82d5d239[]

			response0.MatchesExample(@"POST /sales/_search
			{
			    ""size"": 0,
			    ""aggs"" : {
			        ""sales_per_month"" : {
			            ""date_histogram"" : {
			                ""field"" : ""date"",
			                ""calendar_interval"" : ""month""
			            },
			            ""aggs"": {
			                ""sales"": {
			                    ""sum"": {
			                        ""field"": ""price""
			                    }
			                },
			                ""cumulative_sales"": {
			                    ""cumulative_sum"": {
			                        ""buckets_path"": ""sales"" \<1>
			                    }
			                }
			            }
			        }
			    }
			}");
		}
	}
}
