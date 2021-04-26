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
	public class HistogramPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("mapping/types/histogram.asciidoc:77")]
		public void Line77()
		{
			// tag::fc3f5f40fa283559ca615cd0eb0a1755[]
			var response0 = new SearchResponse<object>();
			// end::fc3f5f40fa283559ca615cd0eb0a1755[]

			response0.MatchesExample(@"PUT my_index
			{
			  ""mappings"" : {
			    ""properties"" : {
			      ""my_histogram"" : {
			        ""type"" : ""histogram""
			      },
			      ""my_text"" : {
			        ""type"" : ""keyword""
			      }
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		[Description("mapping/types/histogram.asciidoc:97")]
		public void Line97()
		{
			// tag::09774dd1a8613672844caadb2bc8dc1e[]
			var response0 = new SearchResponse<object>();

			var response1 = new SearchResponse<object>();
			// end::09774dd1a8613672844caadb2bc8dc1e[]

			response0.MatchesExample(@"PUT my_index/_doc/1
			{
			  ""my_text"" : ""histogram_1"",
			  ""my_histogram"" : {
			      ""values"" : [0.1, 0.2, 0.3, 0.4, 0.5], <1>
			      ""counts"" : [3, 7, 23, 12, 6] <2>
			   }
			}");

			response1.MatchesExample(@"PUT my_index/_doc/2
			{
			  ""my_text"" : ""histogram_2"",
			  ""my_histogram"" : {
			      ""values"" : [0.1, 0.25, 0.35, 0.4, 0.45, 0.5], <1>
			      ""counts"" : [8, 17, 8, 7, 6, 2] <2>
			   }
			}");
		}
	}
}
