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

namespace Examples.Mapping.Types
{
	public class ArrayPage : ExampleBase
	{
		[U]
		[Description("mapping/types/array.asciidoc:42")]
		public void Line42()
		{
			// tag::4d6997c70a1851f9151443c0d38b532e[]
			var indexResponse =
				client.Index(
					new
					{
						message = "some arrays in this document...",
						tags = new[] { "elasticsearch", "wow" },
						lists = new[]
						{
							new { name = "prog_list", description = "programming list" },
							new { name = "cool_list", description = "cool stuff list" },
						}
					}, i => i.Id(1).Index("my_index"));

			var indexResponse2 =
				client.Index(
					new
					{
						message = "no arrays in this document...",
						tags = "elasticsearch",
						lists = new { name = "prog_list", description = "programming list" }
					}, i => i.Id(2).Index("my_index"));

			var searchResponse = client.Search<object>(s => s
				.Index("my_index")
				.Query(q => q
					.Match(m => m
						.Field("tags")
						.Query("elasticsearch")
					)
				)
			);
			// end::4d6997c70a1851f9151443c0d38b532e[]

			indexResponse.MatchesExample(@"PUT my_index/_doc/1
			{
			  ""message"": ""some arrays in this document..."",
			  ""tags"":  [ ""elasticsearch"", ""wow"" ], \<1>
			  ""lists"": [ \<2>
			    {
			      ""name"": ""prog_list"",
			      ""description"": ""programming list""
			    },
			    {
			      ""name"": ""cool_list"",
			      ""description"": ""cool stuff list""
			    }
			  ]
			}");

			indexResponse2.MatchesExample(@"PUT my_index/_doc/2 \<3>
			{
			  ""message"": ""no arrays in this document..."",
			  ""tags"":  ""elasticsearch"",
			  ""lists"": {
			    ""name"": ""prog_list"",
			    ""description"": ""programming list""
			  }
			}");

			searchResponse.MatchesExample(@"GET my_index/_search
			{
			  ""query"": {
			    ""match"": {
			      ""tags"": ""elasticsearch"" \<4>
			    }
			  }
			}", e => e.ApplyBodyChanges(json => json["query"]["match"]["tags"].ToLongFormQuery()));
		}
	}
}
