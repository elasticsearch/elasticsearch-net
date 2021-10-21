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
using Elasticsearch.Net.Specification.MigrationApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	[InterfaceDataContract]
	public partial interface IDeprecationInfoRequest : IRequest<DeprecationInfoRequestParameters>
	{
		[IgnoreDataMember]
		IndexName Index
		{
			get;
		}
	}

	///<summary>Request for DeprecationInfo <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-deprecation.html</para></summary>
	public partial class DeprecationInfoRequest : PlainRequestBase<DeprecationInfoRequestParameters>, IDeprecationInfoRequest
	{
		protected IDeprecationInfoRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.MigrationDeprecationInfo;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_migration/deprecations</summary>
		public DeprecationInfoRequest(): base()
		{
		}

		///<summary>/{index}/_migration/deprecations</summary>
		///<param name = "index">Optional, accepts null</param>
		public DeprecationInfoRequest(IndexName index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		IndexName IDeprecationInfoRequest.Index => Self.RouteValues.Get<IndexName>("index");
	// Request parameters
	}
}