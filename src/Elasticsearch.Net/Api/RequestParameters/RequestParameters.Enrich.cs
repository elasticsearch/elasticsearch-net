// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//
// This file is automatically generated
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elastic.Transport;

// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Specification.EnrichApi
{
	///<summary>Request options for DeletePolicy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/delete-enrich-policy-api.html</para></summary>
	public class DeleteEnrichPolicyRequestParameters : RequestParameters<DeleteEnrichPolicyRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for ExecutePolicy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/execute-enrich-policy-api.html</para></summary>
	public class ExecuteEnrichPolicyRequestParameters : RequestParameters<ExecuteEnrichPolicyRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => false;
		///<summary>Should the request should block until the execution is complete.</summary>
		public bool? WaitForCompletion
		{
			get => Q<bool? >("wait_for_completion");
			set => Q("wait_for_completion", value);
		}
	}

	///<summary>Request options for GetPolicy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/enrich-get-policy.html</para></summary>
	public class GetEnrichPolicyRequestParameters : RequestParameters<GetEnrichPolicyRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for PutPolicy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/put-enrich-policy-api.html</para></summary>
	public class PutEnrichPolicyRequestParameters : RequestParameters<PutEnrichPolicyRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
	}

	///<summary>Request options for Stats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/enrich-stats-api.html</para></summary>
	public class EnrichStatsRequestParameters : RequestParameters<EnrichStatsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
	}
}
