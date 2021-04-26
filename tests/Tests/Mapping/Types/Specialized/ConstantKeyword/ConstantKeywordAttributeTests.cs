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

namespace Tests.Mapping.Types.Specialized.ConstantKeyword
{
	public class ConstantKeywordTest
	{
		[ConstantKeyword(Value = "constant_string")]
		public string ConstantString { get; set; }

		[ConstantKeyword(Value = 42)]
		public int ConstantInt { get; set; }
	}

	[SkipVersion("<7.7.0", "introduced in 7.7.0")]
	public class ConstantKeywordAttributeTests : AttributeTestsBase<ConstantKeywordTest>
	{
		protected override object ExpectJson => new
		{
			properties = new
			{
				constantString = new
				{
					type = "constant_keyword",
					value = "constant_string"
				},
				constantInt = new
				{
					type = "constant_keyword",
					value = 42
				}
			}
		};
	}
}
