using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.XPack.Docs.En.RestApi.Security
{
	public class AuthenticatePage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line30()
		{
			// tag::55f4a15b84b724b9fbf2efd29a4da120[]
			var response0 = new SearchResponse<object>();
			// end::55f4a15b84b724b9fbf2efd29a4da120[]

			response0.MatchesExample(@"GET /_security/_authenticate");
		}
	}
}