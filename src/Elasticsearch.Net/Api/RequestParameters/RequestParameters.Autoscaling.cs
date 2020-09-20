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
namespace Elasticsearch.Net.Specification.AutoscalingApi
{
	///<summary>Request options for DeletePolicy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/autoscaling-delete-autoscaling-policy.html</para></summary>
	public class DeleteAutoscalingPolicyRequestParameters : RequestParameters<DeleteAutoscalingPolicyRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for GetDecision <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/autoscaling-get-autoscaling-decision.html</para></summary>
	public class GetAutoscalingDecisionRequestParameters : RequestParameters<GetAutoscalingDecisionRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for GetPolicy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/autoscaling-get-autoscaling-policy.html</para></summary>
	public class GetAutoscalingPolicyRequestParameters : RequestParameters<GetAutoscalingPolicyRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
	}

	///<summary>Request options for PutPolicy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/autoscaling-put-autoscaling-policy.html</para></summary>
	public class PutAutoscalingPolicyRequestParameters : RequestParameters<PutAutoscalingPolicyRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
	}
}
