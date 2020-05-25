// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System;
using System.Text;
using Elastic.Xunit.XunitPlumbing;
using FluentAssertions;
using Nest;
using Tests.Core.Client;

namespace Tests.Reproduce
{
	public class GithubIssue4703
	{
		[U]
		public void NullableValueTupleDoesNotThrow()
		{
			Func<IndexResponse> action = () =>
				TestClient.DefaultInMemoryClient.Index(
					new ExampleDoc
					{
						tupleNullable = ("somestring", 42),
					}, i => i.Index("index"));

			var a = action.Should().NotThrow();
			var response = a.Subject;

			var json = Encoding.UTF8.GetString(response.ApiCall.RequestBodyInBytes);
			json.Should().Be(@"{""tupleNullable"":{""item1"":""somestring"",""item2"":42}}");
		}
	}

	public class ExampleDoc
	{
		public (string info, int number)? tupleNullable { get; set; }
	}
}
