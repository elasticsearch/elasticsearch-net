// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information
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
using System.Runtime.Serialization;
using Elastic.Transport;
using Elasticsearch.Net;
using Nest.Utf8Json;
using Elasticsearch.Net.Specification.LicenseApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	[InterfaceDataContract]
	public partial interface IDeleteLicenseRequest : IRequest<DeleteLicenseRequestParameters>
	{
	}

	///<summary>Request for Delete <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-license.html</para></summary>
	public partial class DeleteLicenseRequest : PlainRequestBase<DeleteLicenseRequestParameters>, IDeleteLicenseRequest
	{
		protected IDeleteLicenseRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LicenseDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	// values part of the url path
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IGetLicenseRequest : IRequest<GetLicenseRequestParameters>
	{
	}

	///<summary>Request for Get <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/get-license.html</para></summary>
	public partial class GetLicenseRequest : PlainRequestBase<GetLicenseRequestParameters>, IGetLicenseRequest
	{
		protected IGetLicenseRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LicenseGet;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		// values part of the url path
		// Request parameters
		///<summary>Supported for backwards compatibility with 7.x. If this param is used it must be set to true</summary>
		[Obsolete("Scheduled to be removed in 8.0, Deprecated as of: 8.0.0, reason: Supported for backwards compatibility with 7.x. If this param is used it must be set to true")]
		public bool? AcceptEnterprise
		{
			get => Q<bool? >("accept_enterprise");
			set => Q("accept_enterprise", value);
		}

		///<summary>Return local information, do not retrieve the state from master node (default: false)</summary>
		public bool? Local
		{
			get => Q<bool? >("local");
			set => Q("local", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IGetBasicLicenseStatusRequest : IRequest<GetBasicLicenseStatusRequestParameters>
	{
	}

	///<summary>Request for GetBasicStatus <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/get-basic-status.html</para></summary>
	public partial class GetBasicLicenseStatusRequest : PlainRequestBase<GetBasicLicenseStatusRequestParameters>, IGetBasicLicenseStatusRequest
	{
		protected IGetBasicLicenseStatusRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LicenseGetBasicStatus;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	// values part of the url path
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IGetTrialLicenseStatusRequest : IRequest<GetTrialLicenseStatusRequestParameters>
	{
	}

	///<summary>Request for GetTrialStatus <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/get-trial-status.html</para></summary>
	public partial class GetTrialLicenseStatusRequest : PlainRequestBase<GetTrialLicenseStatusRequestParameters>, IGetTrialLicenseStatusRequest
	{
		protected IGetTrialLicenseStatusRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LicenseGetTrialStatus;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	// values part of the url path
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IPostLicenseRequest : IRequest<PostLicenseRequestParameters>
	{
	}

	///<summary>Request for Post <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/update-license.html</para></summary>
	public partial class PostLicenseRequest : PlainRequestBase<PostLicenseRequestParameters>, IPostLicenseRequest
	{
		protected IPostLicenseRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LicensePost;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		// values part of the url path
		// Request parameters
		///<summary>whether the user has acknowledged acknowledge messages (default: false)</summary>
		public bool? Acknowledge
		{
			get => Q<bool? >("acknowledge");
			set => Q("acknowledge", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IStartBasicLicenseRequest : IRequest<StartBasicLicenseRequestParameters>
	{
	}

	///<summary>Request for StartBasic <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/start-basic.html</para></summary>
	public partial class StartBasicLicenseRequest : PlainRequestBase<StartBasicLicenseRequestParameters>, IStartBasicLicenseRequest
	{
		protected IStartBasicLicenseRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LicenseStartBasic;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		// values part of the url path
		// Request parameters
		///<summary>whether the user has acknowledged acknowledge messages (default: false)</summary>
		public bool? Acknowledge
		{
			get => Q<bool? >("acknowledge");
			set => Q("acknowledge", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IStartTrialLicenseRequest : IRequest<StartTrialLicenseRequestParameters>
	{
	}

	///<summary>Request for StartTrial <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/start-trial.html</para></summary>
	public partial class StartTrialLicenseRequest : PlainRequestBase<StartTrialLicenseRequestParameters>, IStartTrialLicenseRequest
	{
		protected IStartTrialLicenseRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LicenseStartTrial;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		// values part of the url path
		// Request parameters
		///<summary>whether the user has acknowledged acknowledge messages (default: false)</summary>
		public bool? Acknowledge
		{
			get => Q<bool? >("acknowledge");
			set => Q("acknowledge", value);
		}

		///<summary>The type of trial license to generate (default: "trial")</summary>
		public string TypeQueryString
		{
			get => Q<string>("type");
			set => Q("type", value);
		}
	}
}