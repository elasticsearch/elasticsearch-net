using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

//This file contains all the typed querystring parameters that are generated of the client spec.
//This file is automatically generated from https://github.com/elastic/elasticsearch/tree/master/rest-api-spec
// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Api.Graph
{
	///<summary>Request options for Explore<pre>https://www.elastic.co/guide/en/elasticsearch/reference/current/graph-explore-api.html</pre></summary>
	public class GraphExploreRequestParameters : RequestParameters<GraphExploreRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		///<summary>Specific routing value</summary>
		public string Routing
		{
			get => Q<string>("routing");
			set => Q("routing", value);
		}

		///<summary>Explicit operation timeout</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}
}