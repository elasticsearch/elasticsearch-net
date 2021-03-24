// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------

using Elastic.Transport;

#nullable restore
namespace Nest
{
	public class DeleteAutoscalingPolicyDescriptor : RequestDescriptorBase<DeleteAutoscalingPolicyDescriptor, DeleteAutoscalingPolicyRequestParameters, IDeleteAutoscalingPolicyRequest>, IDeleteAutoscalingPolicyRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AutoscalingDeleteAutoscalingPolicy;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public class GetAutoscalingCapacityDescriptor : RequestDescriptorBase<GetAutoscalingCapacityDescriptor, GetAutoscalingCapacityRequestParameters, IGetAutoscalingCapacityRequest>, IGetAutoscalingCapacityRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AutoscalingGetAutoscalingCapacity;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class GetAutoscalingPolicyDescriptor : RequestDescriptorBase<GetAutoscalingPolicyDescriptor, GetAutoscalingPolicyRequestParameters, IGetAutoscalingPolicyRequest>, IGetAutoscalingPolicyRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AutoscalingGetAutoscalingPolicy;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class PutAutoscalingPolicyDescriptor : RequestDescriptorBase<PutAutoscalingPolicyDescriptor, PutAutoscalingPolicyRequestParameters, IPutAutoscalingPolicyRequest>, IPutAutoscalingPolicyRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AutoscalingPutAutoscalingPolicy;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
	}
}