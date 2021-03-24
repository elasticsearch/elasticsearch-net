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
	public class DeleteAutoFollowPatternDescriptor : RequestDescriptorBase<DeleteAutoFollowPatternDescriptor, DeleteAutoFollowPatternRequestParameters, IDeleteAutoFollowPatternRequest>, IDeleteAutoFollowPatternRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationDeleteAutoFollowPattern;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public class CreateFollowIndexDescriptor : RequestDescriptorBase<CreateFollowIndexDescriptor, CreateFollowIndexRequestParameters, ICreateFollowIndexRequest>, ICreateFollowIndexRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationFollow;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
	}

	public class FollowInfoDescriptor : RequestDescriptorBase<FollowInfoDescriptor, FollowInfoRequestParameters, IFollowInfoRequest>, IFollowInfoRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationFollowInfo;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class FollowIndexStatsDescriptor : RequestDescriptorBase<FollowIndexStatsDescriptor, FollowIndexStatsRequestParameters, IFollowIndexStatsRequest>, IFollowIndexStatsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationFollowStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class ForgetFollowerIndexDescriptor : RequestDescriptorBase<ForgetFollowerIndexDescriptor, ForgetFollowerIndexRequestParameters, IForgetFollowerIndexRequest>, IForgetFollowerIndexRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationForgetFollower;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public class GetAutoFollowPatternDescriptor : RequestDescriptorBase<GetAutoFollowPatternDescriptor, GetAutoFollowPatternRequestParameters, IGetAutoFollowPatternRequest>, IGetAutoFollowPatternRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationGetAutoFollowPattern;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class PauseAutoFollowPatternDescriptor : RequestDescriptorBase<PauseAutoFollowPatternDescriptor, PauseAutoFollowPatternRequestParameters, IPauseAutoFollowPatternRequest>, IPauseAutoFollowPatternRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationPauseAutoFollowPattern;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public class PauseFollowIndexDescriptor : RequestDescriptorBase<PauseFollowIndexDescriptor, PauseFollowIndexRequestParameters, IPauseFollowIndexRequest>, IPauseFollowIndexRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationPauseFollow;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public class CreateAutoFollowPatternDescriptor : RequestDescriptorBase<CreateAutoFollowPatternDescriptor, CreateAutoFollowPatternRequestParameters, ICreateAutoFollowPatternRequest>, ICreateAutoFollowPatternRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationPutAutoFollowPattern;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
	}

	public class ResumeAutoFollowPatternDescriptor : RequestDescriptorBase<ResumeAutoFollowPatternDescriptor, ResumeAutoFollowPatternRequestParameters, IResumeAutoFollowPatternRequest>, IResumeAutoFollowPatternRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationResumeAutoFollowPattern;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public class ResumeFollowIndexDescriptor : RequestDescriptorBase<ResumeFollowIndexDescriptor, ResumeFollowIndexRequestParameters, IResumeFollowIndexRequest>, IResumeFollowIndexRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationResumeFollow;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public class CcrStatsDescriptor : RequestDescriptorBase<CcrStatsDescriptor, CcrStatsRequestParameters, ICcrStatsRequest>, ICcrStatsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class UnfollowIndexDescriptor : RequestDescriptorBase<UnfollowIndexDescriptor, UnfollowIndexRequestParameters, IUnfollowIndexRequest>, IUnfollowIndexRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationUnfollow;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}
}