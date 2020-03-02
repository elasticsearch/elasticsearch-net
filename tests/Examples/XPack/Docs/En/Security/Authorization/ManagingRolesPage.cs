using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.XPack.Docs.En.Security.Authorization
{
	public class ManagingRolesPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line158()
		{
			// tag::d3e5edac5b461020017fd9d8ec7a91fa[]
			var response0 = new SearchResponse<object>();
			// end::d3e5edac5b461020017fd9d8ec7a91fa[]

			response0.MatchesExample(@"POST /_security/role/clicks_admin
			{
			  ""run_as"": [ ""clicks_watcher_1"" ],
			  ""cluster"": [ ""monitor"" ],
			  ""indices"": [
			    {
			      ""names"": [ ""events-*"" ],
			      ""privileges"": [ ""read"" ],
			      ""field_security"" : {
			        ""grant"" : [ ""category"", ""@timestamp"", ""message"" ]
			      },
			      ""query"": ""{\""match\"": {\""category\"": \""click\""}}""
			    }
			  ]
			}");
		}
	}
}