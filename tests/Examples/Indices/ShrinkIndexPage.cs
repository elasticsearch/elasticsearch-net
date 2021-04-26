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

namespace Examples.Indices
{
	public class ShrinkIndexPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("indices/shrink-index.asciidoc:11")]
		public void Line11()
		{
			// tag::36897f18b6b4631a03ba37f3baa00907[]
			var response0 = new SearchResponse<object>();
			// end::36897f18b6b4631a03ba37f3baa00907[]

			response0.MatchesExample(@"POST /twitter/_shrink/shrunk-twitter-index");
		}

		[U(Skip = "Example not implemented")]
		[Description("indices/shrink-index.asciidoc:37")]
		public void Line37()
		{
			// tag::5e93f806cfd459149222b443b7992a51[]
			var response0 = new SearchResponse<object>();
			// end::5e93f806cfd459149222b443b7992a51[]

			response0.MatchesExample(@"PUT /my_source_index/_settings
			{
			  ""settings"": {
			    ""index.routing.allocation.require._name"": ""shrink_node_name"", \<1>
			    ""index.blocks.write"": true \<2>
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		[Description("indices/shrink-index.asciidoc:103")]
		public void Line103()
		{
			// tag::f3594de7ef39ab09b0bb12c1e76bfe6b[]
			var response0 = new SearchResponse<object>();
			// end::f3594de7ef39ab09b0bb12c1e76bfe6b[]

			response0.MatchesExample(@"POST /my_source_index/_shrink/my_target_index
			{
			  ""settings"": {
			    ""index.routing.allocation.require._name"": null, <1>
			    ""index.blocks.write"": null <2>
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		[Description("indices/shrink-index.asciidoc:146")]
		public void Line146()
		{
			// tag::76c167d8ab305cb43b594f140c902dfe[]
			var response0 = new SearchResponse<object>();
			// end::76c167d8ab305cb43b594f140c902dfe[]

			response0.MatchesExample(@"POST /my_source_index/_shrink/my_target_index
			{
			  ""settings"": {
			    ""index.number_of_replicas"": 1,
			    ""index.number_of_shards"": 1, <1>
			    ""index.codec"": ""best_compression"" <2>
			  },
			  ""aliases"": {
			    ""my_search_indices"": {}
			  }
			}");
		}
	}
}
