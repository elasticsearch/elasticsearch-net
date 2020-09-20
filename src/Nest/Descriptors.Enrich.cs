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
using Elasticsearch.Net.Specification.EnrichApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	///<summary>Descriptor for DeletePolicy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/delete-enrich-policy-api.html</para></summary>
	public partial class DeleteEnrichPolicyDescriptor : RequestDescriptorBase<DeleteEnrichPolicyDescriptor, DeleteEnrichPolicyRequestParameters, IDeleteEnrichPolicyRequest>, IDeleteEnrichPolicyRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.EnrichDeletePolicy;
		///<summary>/_enrich/policy/{name}</summary>
		///<param name = "name">this parameter is required</param>
		public DeleteEnrichPolicyDescriptor(Name name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteEnrichPolicyDescriptor(): base()
		{
		}

		// values part of the url path
		Name IDeleteEnrichPolicyRequest.Name => Self.RouteValues.Get<Name>("name");
	// Request parameters
	}

	///<summary>Descriptor for ExecutePolicy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/execute-enrich-policy-api.html</para></summary>
	public partial class ExecuteEnrichPolicyDescriptor : RequestDescriptorBase<ExecuteEnrichPolicyDescriptor, ExecuteEnrichPolicyRequestParameters, IExecuteEnrichPolicyRequest>, IExecuteEnrichPolicyRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.EnrichExecutePolicy;
		///<summary>/_enrich/policy/{name}/_execute</summary>
		///<param name = "name">this parameter is required</param>
		public ExecuteEnrichPolicyDescriptor(Name name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected ExecuteEnrichPolicyDescriptor(): base()
		{
		}

		// values part of the url path
		Name IExecuteEnrichPolicyRequest.Name => Self.RouteValues.Get<Name>("name");
		// Request parameters
		///<summary>Should the request should block until the execution is complete.</summary>
		public ExecuteEnrichPolicyDescriptor WaitForCompletion(bool? waitforcompletion = true) => Qs("wait_for_completion", waitforcompletion);
	}

	///<summary>Descriptor for GetPolicy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/enrich-get-policy.html</para></summary>
	public partial class GetEnrichPolicyDescriptor : RequestDescriptorBase<GetEnrichPolicyDescriptor, GetEnrichPolicyRequestParameters, IGetEnrichPolicyRequest>, IGetEnrichPolicyRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.EnrichGetPolicy;
		///<summary>/_enrich/policy/{name}</summary>
		///<param name = "name">Optional, accepts null</param>
		public GetEnrichPolicyDescriptor(Names name): base(r => r.Optional("name", name))
		{
		}

		///<summary>/_enrich/policy</summary>
		public GetEnrichPolicyDescriptor(): base()
		{
		}

		// values part of the url path
		Names IGetEnrichPolicyRequest.Name => Self.RouteValues.Get<Names>("name");
		///<summary>A comma-separated list of enrich policy names</summary>
		public GetEnrichPolicyDescriptor Name(Names name) => Assign(name, (a, v) => a.RouteValues.Optional("name", v));
	// Request parameters
	}

	///<summary>Descriptor for PutPolicy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/put-enrich-policy-api.html</para></summary>
	public partial class PutEnrichPolicyDescriptor<TDocument> : RequestDescriptorBase<PutEnrichPolicyDescriptor<TDocument>, PutEnrichPolicyRequestParameters, IPutEnrichPolicyRequest>, IPutEnrichPolicyRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.EnrichPutPolicy;
		///<summary>/_enrich/policy/{name}</summary>
		///<param name = "name">this parameter is required</param>
		public PutEnrichPolicyDescriptor(Name name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PutEnrichPolicyDescriptor(): base()
		{
		}

		// values part of the url path
		Name IPutEnrichPolicyRequest.Name => Self.RouteValues.Get<Name>("name");
	// Request parameters
	}

	///<summary>Descriptor for Stats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/enrich-stats-api.html</para></summary>
	public partial class EnrichStatsDescriptor : RequestDescriptorBase<EnrichStatsDescriptor, EnrichStatsRequestParameters, IEnrichStatsRequest>, IEnrichStatsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.EnrichStats;
	// values part of the url path
	// Request parameters
	}
}
