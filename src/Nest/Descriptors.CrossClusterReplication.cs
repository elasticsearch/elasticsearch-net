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
using Elastic.Transport.Utf8Json;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
using Elasticsearch.Net.Specification.CrossClusterReplicationApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	///<summary>Descriptor for DeleteAutoFollowPattern <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-delete-auto-follow-pattern.html</para></summary>
	public partial class DeleteAutoFollowPatternDescriptor : RequestDescriptorBase<DeleteAutoFollowPatternDescriptor, DeleteAutoFollowPatternRequestParameters, IDeleteAutoFollowPatternRequest>, IDeleteAutoFollowPatternRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationDeleteAutoFollowPattern;
		///<summary>/_ccr/auto_follow/{name}</summary>
		///<param name = "name">this parameter is required</param>
		public DeleteAutoFollowPatternDescriptor(Name name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteAutoFollowPatternDescriptor(): base()
		{
		}

		// values part of the url path
		Name IDeleteAutoFollowPatternRequest.Name => Self.RouteValues.Get<Name>("name");
	// Request parameters
	}

	///<summary>Descriptor for CreateFollowIndex <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-follow.html</para></summary>
	public partial class CreateFollowIndexDescriptor : RequestDescriptorBase<CreateFollowIndexDescriptor, CreateFollowIndexRequestParameters, ICreateFollowIndexRequest>, ICreateFollowIndexRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationCreateFollowIndex;
		///<summary>/{index}/_ccr/follow</summary>
		///<param name = "index">this parameter is required</param>
		public CreateFollowIndexDescriptor(IndexName index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected CreateFollowIndexDescriptor(): base()
		{
		}

		// values part of the url path
		IndexName ICreateFollowIndexRequest.Index => Self.RouteValues.Get<IndexName>("index");
		///<summary>The name of the follower index</summary>
		public CreateFollowIndexDescriptor Index(IndexName index) => Assign(index, (a, v) => a.RouteValues.Required("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public CreateFollowIndexDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Required("index", (IndexName)v));
		// Request parameters
		///<summary>Sets the number of shard copies that must be active before returning. Defaults to 0. Set to `all` for all shard copies, otherwise set to any non-negative value less than or equal to the total number of copies for the shard (number of replicas + 1)</summary>
		public CreateFollowIndexDescriptor WaitForActiveShards(string waitforactiveshards) => Qs("wait_for_active_shards", waitforactiveshards);
	}

	///<summary>Descriptor for FollowInfo <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-info.html</para></summary>
	public partial class FollowInfoDescriptor : RequestDescriptorBase<FollowInfoDescriptor, FollowInfoRequestParameters, IFollowInfoRequest>, IFollowInfoRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationFollowInfo;
		///<summary>/{index}/_ccr/info</summary>
		///<param name = "index">this parameter is required</param>
		public FollowInfoDescriptor(Indices index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected FollowInfoDescriptor(): base()
		{
		}

		// values part of the url path
		Indices IFollowInfoRequest.Index => Self.RouteValues.Get<Indices>("index");
		///<summary>A comma-separated list of index patterns; use `_all` to perform the operation on all indices</summary>
		public FollowInfoDescriptor Index(Indices index) => Assign(index, (a, v) => a.RouteValues.Required("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public FollowInfoDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Required("index", (Indices)v));
		///<summary>A shortcut into calling Index(Indices.All)</summary>
		public FollowInfoDescriptor AllIndices() => Index(Indices.All);
	// Request parameters
	}

	///<summary>Descriptor for FollowIndexStats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-stats.html</para></summary>
	public partial class FollowIndexStatsDescriptor : RequestDescriptorBase<FollowIndexStatsDescriptor, FollowIndexStatsRequestParameters, IFollowIndexStatsRequest>, IFollowIndexStatsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationFollowIndexStats;
		///<summary>/{index}/_ccr/stats</summary>
		///<param name = "index">this parameter is required</param>
		public FollowIndexStatsDescriptor(Indices index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected FollowIndexStatsDescriptor(): base()
		{
		}

		// values part of the url path
		Indices IFollowIndexStatsRequest.Index => Self.RouteValues.Get<Indices>("index");
		///<summary>A comma-separated list of index patterns; use `_all` to perform the operation on all indices</summary>
		public FollowIndexStatsDescriptor Index(Indices index) => Assign(index, (a, v) => a.RouteValues.Required("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public FollowIndexStatsDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Required("index", (Indices)v));
		///<summary>A shortcut into calling Index(Indices.All)</summary>
		public FollowIndexStatsDescriptor AllIndices() => Index(Indices.All);
	// Request parameters
	}

	///<summary>Descriptor for ForgetFollowerIndex <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-forget-follower.html</para></summary>
	public partial class ForgetFollowerIndexDescriptor : RequestDescriptorBase<ForgetFollowerIndexDescriptor, ForgetFollowerIndexRequestParameters, IForgetFollowerIndexRequest>, IForgetFollowerIndexRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationForgetFollowerIndex;
		///<summary>/{index}/_ccr/forget_follower</summary>
		///<param name = "index">this parameter is required</param>
		public ForgetFollowerIndexDescriptor(IndexName index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected ForgetFollowerIndexDescriptor(): base()
		{
		}

		// values part of the url path
		IndexName IForgetFollowerIndexRequest.Index => Self.RouteValues.Get<IndexName>("index");
		///<summary>the name of the leader index for which specified follower retention leases should be removed</summary>
		public ForgetFollowerIndexDescriptor Index(IndexName index) => Assign(index, (a, v) => a.RouteValues.Required("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public ForgetFollowerIndexDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Required("index", (IndexName)v));
	// Request parameters
	}

	///<summary>Descriptor for GetAutoFollowPattern <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-auto-follow-pattern.html</para></summary>
	public partial class GetAutoFollowPatternDescriptor : RequestDescriptorBase<GetAutoFollowPatternDescriptor, GetAutoFollowPatternRequestParameters, IGetAutoFollowPatternRequest>, IGetAutoFollowPatternRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationGetAutoFollowPattern;
		///<summary>/_ccr/auto_follow</summary>
		public GetAutoFollowPatternDescriptor(): base()
		{
		}

		///<summary>/_ccr/auto_follow/{name}</summary>
		///<param name = "name">Optional, accepts null</param>
		public GetAutoFollowPatternDescriptor(Name name): base(r => r.Optional("name", name))
		{
		}

		// values part of the url path
		Name IGetAutoFollowPatternRequest.Name => Self.RouteValues.Get<Name>("name");
		///<summary>The name of the auto follow pattern.</summary>
		public GetAutoFollowPatternDescriptor Name(Name name) => Assign(name, (a, v) => a.RouteValues.Optional("name", v));
	// Request parameters
	}

	///<summary>Descriptor for PauseAutoFollowPattern <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-pause-auto-follow-pattern.html</para></summary>
	public partial class PauseAutoFollowPatternDescriptor : RequestDescriptorBase<PauseAutoFollowPatternDescriptor, PauseAutoFollowPatternRequestParameters, IPauseAutoFollowPatternRequest>, IPauseAutoFollowPatternRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationPauseAutoFollowPattern;
		///<summary>/_ccr/auto_follow/{name}/pause</summary>
		///<param name = "name">this parameter is required</param>
		public PauseAutoFollowPatternDescriptor(Name name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PauseAutoFollowPatternDescriptor(): base()
		{
		}

		// values part of the url path
		Name IPauseAutoFollowPatternRequest.Name => Self.RouteValues.Get<Name>("name");
	// Request parameters
	}

	///<summary>Descriptor for PauseFollowIndex <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-pause-follow.html</para></summary>
	public partial class PauseFollowIndexDescriptor : RequestDescriptorBase<PauseFollowIndexDescriptor, PauseFollowIndexRequestParameters, IPauseFollowIndexRequest>, IPauseFollowIndexRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationPauseFollowIndex;
		///<summary>/{index}/_ccr/pause_follow</summary>
		///<param name = "index">this parameter is required</param>
		public PauseFollowIndexDescriptor(IndexName index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PauseFollowIndexDescriptor(): base()
		{
		}

		// values part of the url path
		IndexName IPauseFollowIndexRequest.Index => Self.RouteValues.Get<IndexName>("index");
		///<summary>The name of the follower index that should pause following its leader index.</summary>
		public PauseFollowIndexDescriptor Index(IndexName index) => Assign(index, (a, v) => a.RouteValues.Required("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public PauseFollowIndexDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Required("index", (IndexName)v));
	// Request parameters
	}

	///<summary>Descriptor for CreateAutoFollowPattern <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-auto-follow-pattern.html</para></summary>
	public partial class CreateAutoFollowPatternDescriptor : RequestDescriptorBase<CreateAutoFollowPatternDescriptor, CreateAutoFollowPatternRequestParameters, ICreateAutoFollowPatternRequest>, ICreateAutoFollowPatternRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationCreateAutoFollowPattern;
		///<summary>/_ccr/auto_follow/{name}</summary>
		///<param name = "name">this parameter is required</param>
		public CreateAutoFollowPatternDescriptor(Name name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected CreateAutoFollowPatternDescriptor(): base()
		{
		}

		// values part of the url path
		Name ICreateAutoFollowPatternRequest.Name => Self.RouteValues.Get<Name>("name");
	// Request parameters
	}

	///<summary>Descriptor for ResumeAutoFollowPattern <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-resume-auto-follow-pattern.html</para></summary>
	public partial class ResumeAutoFollowPatternDescriptor : RequestDescriptorBase<ResumeAutoFollowPatternDescriptor, ResumeAutoFollowPatternRequestParameters, IResumeAutoFollowPatternRequest>, IResumeAutoFollowPatternRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationResumeAutoFollowPattern;
		///<summary>/_ccr/auto_follow/{name}/resume</summary>
		///<param name = "name">this parameter is required</param>
		public ResumeAutoFollowPatternDescriptor(Name name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected ResumeAutoFollowPatternDescriptor(): base()
		{
		}

		// values part of the url path
		Name IResumeAutoFollowPatternRequest.Name => Self.RouteValues.Get<Name>("name");
	// Request parameters
	}

	///<summary>Descriptor for ResumeFollowIndex <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-resume-follow.html</para></summary>
	public partial class ResumeFollowIndexDescriptor : RequestDescriptorBase<ResumeFollowIndexDescriptor, ResumeFollowIndexRequestParameters, IResumeFollowIndexRequest>, IResumeFollowIndexRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationResumeFollowIndex;
		///<summary>/{index}/_ccr/resume_follow</summary>
		///<param name = "index">this parameter is required</param>
		public ResumeFollowIndexDescriptor(IndexName index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected ResumeFollowIndexDescriptor(): base()
		{
		}

		// values part of the url path
		IndexName IResumeFollowIndexRequest.Index => Self.RouteValues.Get<IndexName>("index");
		///<summary>The name of the follow index to resume following.</summary>
		public ResumeFollowIndexDescriptor Index(IndexName index) => Assign(index, (a, v) => a.RouteValues.Required("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public ResumeFollowIndexDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Required("index", (IndexName)v));
	// Request parameters
	}

	///<summary>Descriptor for Stats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-stats.html</para></summary>
	public partial class CcrStatsDescriptor : RequestDescriptorBase<CcrStatsDescriptor, CcrStatsRequestParameters, ICcrStatsRequest>, ICcrStatsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationStats;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for UnfollowIndex <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-unfollow.html</para></summary>
	public partial class UnfollowIndexDescriptor : RequestDescriptorBase<UnfollowIndexDescriptor, UnfollowIndexRequestParameters, IUnfollowIndexRequest>, IUnfollowIndexRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationUnfollowIndex;
		///<summary>/{index}/_ccr/unfollow</summary>
		///<param name = "index">this parameter is required</param>
		public UnfollowIndexDescriptor(IndexName index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected UnfollowIndexDescriptor(): base()
		{
		}

		// values part of the url path
		IndexName IUnfollowIndexRequest.Index => Self.RouteValues.Get<IndexName>("index");
		///<summary>The name of the follower index that should be turned into a regular index.</summary>
		public UnfollowIndexDescriptor Index(IndexName index) => Assign(index, (a, v) => a.RouteValues.Required("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public UnfollowIndexDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Required("index", (IndexName)v));
	// Request parameters
	}
}
