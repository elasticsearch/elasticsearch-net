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
using Elasticsearch.Net.Specification.SnapshotLifecycleManagementApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	///<summary>Descriptor for DeleteSnapshotLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-delete-policy.html</para></summary>
	public partial class DeleteSnapshotLifecycleDescriptor : RequestDescriptorBase<DeleteSnapshotLifecycleDescriptor, DeleteSnapshotLifecycleRequestParameters, IDeleteSnapshotLifecycleRequest>, IDeleteSnapshotLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementDeleteSnapshotLifecycle;
		///<summary>/_slm/policy/{policy_id}</summary>
		///<param name = "policyId">this parameter is required</param>
		public DeleteSnapshotLifecycleDescriptor(Id policyId): base(r => r.Required("policy_id", policyId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteSnapshotLifecycleDescriptor(): base()
		{
		}

		// values part of the url path
		Id IDeleteSnapshotLifecycleRequest.PolicyId => Self.RouteValues.Get<Id>("policy_id");
	// Request parameters
	}

	///<summary>Descriptor for ExecuteSnapshotLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute-lifecycle.html</para></summary>
	public partial class ExecuteSnapshotLifecycleDescriptor : RequestDescriptorBase<ExecuteSnapshotLifecycleDescriptor, ExecuteSnapshotLifecycleRequestParameters, IExecuteSnapshotLifecycleRequest>, IExecuteSnapshotLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementExecuteSnapshotLifecycle;
		///<summary>/_slm/policy/{policy_id}/_execute</summary>
		///<param name = "policyId">this parameter is required</param>
		public ExecuteSnapshotLifecycleDescriptor(Id policyId): base(r => r.Required("policy_id", policyId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected ExecuteSnapshotLifecycleDescriptor(): base()
		{
		}

		// values part of the url path
		Id IExecuteSnapshotLifecycleRequest.PolicyId => Self.RouteValues.Get<Id>("policy_id");
	// Request parameters
	}

	///<summary>Descriptor for ExecuteRetention <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute-retention.html</para></summary>
	public partial class ExecuteRetentionDescriptor : RequestDescriptorBase<ExecuteRetentionDescriptor, ExecuteRetentionRequestParameters, IExecuteRetentionRequest>, IExecuteRetentionRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementExecuteRetention;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for GetSnapshotLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get-policy.html</para></summary>
	public partial class GetSnapshotLifecycleDescriptor : RequestDescriptorBase<GetSnapshotLifecycleDescriptor, GetSnapshotLifecycleRequestParameters, IGetSnapshotLifecycleRequest>, IGetSnapshotLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementGetSnapshotLifecycle;
		///<summary>/_slm/policy/{policy_id}</summary>
		///<param name = "policyId">Optional, accepts null</param>
		public GetSnapshotLifecycleDescriptor(Ids policyId): base(r => r.Optional("policy_id", policyId))
		{
		}

		///<summary>/_slm/policy</summary>
		public GetSnapshotLifecycleDescriptor(): base()
		{
		}

		// values part of the url path
		Ids IGetSnapshotLifecycleRequest.PolicyId => Self.RouteValues.Get<Ids>("policy_id");
		///<summary>Comma-separated list of snapshot lifecycle policies to retrieve</summary>
		public GetSnapshotLifecycleDescriptor PolicyId(Ids policyId) => Assign(policyId, (a, v) => a.RouteValues.Optional("policy_id", v));
	// Request parameters
	}

	///<summary>Descriptor for GetSnapshotLifecycleStats <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/slm-api-get-stats.html</para></summary>
	public partial class GetSnapshotLifecycleStatsDescriptor : RequestDescriptorBase<GetSnapshotLifecycleStatsDescriptor, GetSnapshotLifecycleStatsRequestParameters, IGetSnapshotLifecycleStatsRequest>, IGetSnapshotLifecycleStatsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementGetSnapshotLifecycleStats;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for GetStatus <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get-status.html</para></summary>
	public partial class GetSnapshotLifecycleManagementStatusDescriptor : RequestDescriptorBase<GetSnapshotLifecycleManagementStatusDescriptor, GetSnapshotLifecycleManagementStatusRequestParameters, IGetSnapshotLifecycleManagementStatusRequest>, IGetSnapshotLifecycleManagementStatusRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementGetStatus;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for PutSnapshotLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-put-policy.html</para></summary>
	public partial class PutSnapshotLifecycleDescriptor : RequestDescriptorBase<PutSnapshotLifecycleDescriptor, PutSnapshotLifecycleRequestParameters, IPutSnapshotLifecycleRequest>, IPutSnapshotLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementPutSnapshotLifecycle;
		///<summary>/_slm/policy/{policy_id}</summary>
		///<param name = "policyId">this parameter is required</param>
		public PutSnapshotLifecycleDescriptor(Id policyId): base(r => r.Required("policy_id", policyId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PutSnapshotLifecycleDescriptor(): base()
		{
		}

		// values part of the url path
		Id IPutSnapshotLifecycleRequest.PolicyId => Self.RouteValues.Get<Id>("policy_id");
	// Request parameters
	}

	///<summary>Descriptor for Start <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-start.html</para></summary>
	public partial class StartSnapshotLifecycleManagementDescriptor : RequestDescriptorBase<StartSnapshotLifecycleManagementDescriptor, StartSnapshotLifecycleManagementRequestParameters, IStartSnapshotLifecycleManagementRequest>, IStartSnapshotLifecycleManagementRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementStart;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for Stop <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-stop.html</para></summary>
	public partial class StopSnapshotLifecycleManagementDescriptor : RequestDescriptorBase<StopSnapshotLifecycleManagementDescriptor, StopSnapshotLifecycleManagementRequestParameters, IStopSnapshotLifecycleManagementRequest>, IStopSnapshotLifecycleManagementRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementStop;
	// values part of the url path
	// Request parameters
	}
}
