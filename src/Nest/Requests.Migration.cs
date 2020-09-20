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
using Elastic.Transport.Utf8Json;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
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
