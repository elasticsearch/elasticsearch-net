using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.Docs
{
	public class RefreshPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line87()
		{
			// tag::92d343eb755971c44a939d0660bf5ac2[]
			var response0 = new SearchResponse<object>();

			var response1 = new SearchResponse<object>();
			// end::92d343eb755971c44a939d0660bf5ac2[]

			response0.MatchesExample(@"PUT /test/_doc/1?refresh
			{""test"": ""test""}");

			response1.MatchesExample(@"PUT /test/_doc/2?refresh=true
			{""test"": ""test""}");
		}

		[U(Skip = "Example not implemented")]
		public void Line99()
		{
			// tag::1070e59ba144cdf309fd9b2591612b95[]
			var response0 = new SearchResponse<object>();

			var response1 = new SearchResponse<object>();
			// end::1070e59ba144cdf309fd9b2591612b95[]

			response0.MatchesExample(@"PUT /test/_doc/3
			{""test"": ""test""}");

			response1.MatchesExample(@"PUT /test/_doc/4?refresh=false
			{""test"": ""test""}");
		}

		[U(Skip = "Example not implemented")]
		public void Line110()
		{
			// tag::e4b2b5e0aaedf3cbbcde3d61eb1f13fc[]
			var response0 = new SearchResponse<object>();
			// end::e4b2b5e0aaedf3cbbcde3d61eb1f13fc[]

			response0.MatchesExample(@"PUT /test/_doc/4?refresh=wait_for
			{""test"": ""test""}");
		}
	}
}