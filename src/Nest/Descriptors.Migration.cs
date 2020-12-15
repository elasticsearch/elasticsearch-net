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
using Elasticsearch.Net;
using Nest.Utf8Json;
using Elasticsearch.Net.Specification.MigrationApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	///<summary>Descriptor for DeprecationInfo <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/migration-api-deprecation.html</para></summary>
	public partial class DeprecationInfoDescriptor : RequestDescriptorBase<DeprecationInfoDescriptor, DeprecationInfoRequestParameters, IDeprecationInfoRequest>, IDeprecationInfoRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.MigrationDeprecationInfo;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_migration/deprecations</summary>
		public DeprecationInfoDescriptor(): base()
		{
		}

		///<summary>/{index}/_migration/deprecations</summary>
		///<param name = "index">Optional, accepts null</param>
		public DeprecationInfoDescriptor(IndexName index): base(r => r.Optional("index", index))
		{
		}

		// values part of the url path
		IndexName IDeprecationInfoRequest.Index => Self.RouteValues.Get<IndexName>("index");
		///<summary>Index pattern</summary>
		public DeprecationInfoDescriptor Index(IndexName index) => Assign(index, (a, v) => a.RouteValues.Optional("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public DeprecationInfoDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Optional("index", (IndexName)v));
	// Request parameters
	}
}