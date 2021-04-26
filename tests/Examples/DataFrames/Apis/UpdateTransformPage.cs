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

namespace Examples.DataFrames.Apis
{
	public class UpdateTransformPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line125()
		{
			// tag::f61fdfcbebde925d253f455e23f4bf25[]
			var response0 = new SearchResponse<object>();
			// end::f61fdfcbebde925d253f455e23f4bf25[]

			response0.MatchesExample(@"POST _data_frame/transforms/simple-kibana-ecomm-pivot/_update
			{
			  ""source"": {
			    ""index"": ""kibana_sample_data_ecommerce"",
			    ""query"": {
			      ""term"": {
			        ""geoip.continent_name"": {
			          ""value"": ""Asia""
			        }
			      }
			    }
			  },
			  ""description"": ""Maximum priced ecommerce data by customer_id in Asia"",
			  ""dest"": {
			    ""index"": ""kibana_sample_data_ecommerce_transform_v2"",
			    ""pipeline"": ""add_timestamp_pipeline""
			  },
			  ""frequency"": ""15m"",
			  ""sync"": {
			    ""time"": {
			      ""field"": ""order_date"",
			      ""delay"": ""120s""
			    }
			  }
			}");
		}
	}
}
