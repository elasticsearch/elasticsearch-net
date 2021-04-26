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

namespace Examples.Cluster
{
	public class ReroutePage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("cluster/reroute.asciidoc:185")]
		public void Line185()
		{
			// tag::c5488b3888749d3d5b9808ab28d384eb[]
			var response0 = new SearchResponse<object>();
			// end::c5488b3888749d3d5b9808ab28d384eb[]

			response0.MatchesExample(@"POST /_cluster/reroute
			{
			    ""commands"" : [
			        {
			            ""move"" : {
			                ""index"" : ""test"", ""shard"" : 0,
			                ""from_node"" : ""node1"", ""to_node"" : ""node2""
			            }
			        },
			        {
			          ""allocate_replica"" : {
			                ""index"" : ""test"", ""shard"" : 1,
			                ""node"" : ""node3""
			          }
			        }
			    ]
			}");
		}
	}
}
