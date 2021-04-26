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

namespace Examples.Analysis.Analyzers
{
	public class KeywordAnalyzerPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("analysis/analyzers/keyword-analyzer.asciidoc:14")]
		public void Line14()
		{
			// tag::19ee488226d357d1576e7d3ae7a4693f[]
			var response0 = new SearchResponse<object>();
			// end::19ee488226d357d1576e7d3ae7a4693f[]

			response0.MatchesExample(@"POST _analyze
			{
			  ""analyzer"": ""keyword"",
			  ""text"": ""The 2 QUICK Brown-Foxes jumped over the lazy dog's bone.""
			}");
		}

		[U(Skip = "Example not implemented")]
		[Description("analysis/analyzers/keyword-analyzer.asciidoc:71")]
		public void Line71()
		{
			// tag::c1efc5cfcb3c29711bfe118f1baa28b0[]
			var response0 = new SearchResponse<object>();
			// end::c1efc5cfcb3c29711bfe118f1baa28b0[]

			response0.MatchesExample(@"PUT /keyword_example
			{
			  ""settings"": {
			    ""analysis"": {
			      ""analyzer"": {
			        ""rebuilt_keyword"": {
			          ""tokenizer"": ""keyword"",
			          ""filter"": [         \<1>
			          ]
			        }
			      }
			    }
			  }
			}");
		}
	}
}
