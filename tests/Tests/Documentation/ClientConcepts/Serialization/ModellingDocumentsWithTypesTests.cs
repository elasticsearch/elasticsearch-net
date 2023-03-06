// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

#pragma warning disable IDE0005
//tag::usings
using System.Threading.Tasks;
using Elastic.Clients.Elasticsearch;
//end::usings
#pragma warning restore IDE0005
using System.Text;
using VerifyXunit;

namespace Tests.Documentation.Serialization;

//tag::my-document-poco
public class MyDocument
{
	public string StringProperty { get; set; }
}
//end::my-document-poco

[UsesVerify]
public class ModellingDocumentsWithTypesTests : DocumentationTestBase
{
	[U]
	public async Task IndexMyDocument()
	{
		//tag::index-my-document
		var document = new MyDocument
		{
			StringProperty = "value"
		};

		var indexResponse = await Client
			.IndexAsync(document, "my-index-name");
		//end::index-my-document

		var requestJson = Encoding.UTF8.GetString(indexResponse.ApiCallDetails.RequestBodyInBytes);
		await Verifier.Verify(requestJson);
	}
}
