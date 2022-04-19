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
//
// ------------------------------------------------

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Security
{
	public class SecurityClearCachedRolesRequestParameters : RequestParameters<SecurityClearCachedRolesRequestParameters>
	{
	}

	public partial class SecurityClearCachedRolesRequest : PlainRequestBase<SecurityClearCachedRolesRequestParameters>
	{
		public SecurityClearCachedRolesRequest(Elastic.Clients.Elasticsearch.Names name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityClearCachedRoles;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public sealed partial class SecurityClearCachedRolesRequestDescriptor : RequestDescriptorBase<SecurityClearCachedRolesRequestDescriptor, SecurityClearCachedRolesRequestParameters>
	{
		internal SecurityClearCachedRolesRequestDescriptor(Action<SecurityClearCachedRolesRequestDescriptor> configure) => configure.Invoke(this);
		public SecurityClearCachedRolesRequestDescriptor(Elastic.Clients.Elasticsearch.Names name) : base(r => r.Required("name", name))
		{
		}

		internal SecurityClearCachedRolesRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityClearCachedRoles;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public SecurityClearCachedRolesRequestDescriptor Name(Elastic.Clients.Elasticsearch.Names name)
		{
			RouteValues.Required("name", name);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}