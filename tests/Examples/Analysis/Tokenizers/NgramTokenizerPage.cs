using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.Analysis.Tokenizers
{
	public class NgramTokenizerPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line21()
		{
			// tag::39963032d423e2f20f53c4621b6ca3c6[]
			var response0 = new SearchResponse<object>();
			// end::39963032d423e2f20f53c4621b6ca3c6[]

			response0.MatchesExample(@"POST _analyze
			{
			  ""tokenizer"": ""ngram"",
			  ""text"": ""Quick Fox""
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line217()
		{
			// tag::9efcafd1f28490fd658d88df7d93c66c[]
			var response0 = new SearchResponse<object>();

			var response1 = new SearchResponse<object>();
			// end::9efcafd1f28490fd658d88df7d93c66c[]

			response0.MatchesExample(@"PUT my_index
			{
			  ""settings"": {
			    ""analysis"": {
			      ""analyzer"": {
			        ""my_analyzer"": {
			          ""tokenizer"": ""my_tokenizer""
			        }
			      },
			      ""tokenizer"": {
			        ""my_tokenizer"": {
			          ""type"": ""ngram"",
			          ""min_gram"": 3,
			          ""max_gram"": 3,
			          ""token_chars"": [
			            ""letter"",
			            ""digit""
			          ]
			        }
			      }
			    }
			  }
			}");

			response1.MatchesExample(@"POST my_index/_analyze
			{
			  ""analyzer"": ""my_analyzer"",
			  ""text"": ""2 Quick Foxes.""
			}");
		}
	}
}