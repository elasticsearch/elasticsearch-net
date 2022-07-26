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
	public sealed class SecurityGetRoleRequestParameters : RequestParameters<SecurityGetRoleRequestParameters>
	{
	}

	public sealed partial class SecurityGetRoleRequest : PlainRequestBase<SecurityGetRoleRequestParameters>
	{
		public SecurityGetRoleRequest()
		{
		}

		public SecurityGetRoleRequest(Elastic.Clients.Elasticsearch.Names? name) : base(r => r.Optional("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetRole;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public sealed partial class SecurityGetRoleRequestDescriptor : RequestDescriptorBase<SecurityGetRoleRequestDescriptor, SecurityGetRoleRequestParameters>
	{
		internal SecurityGetRoleRequestDescriptor(Action<SecurityGetRoleRequestDescriptor> configure) => configure.Invoke(this);
		public SecurityGetRoleRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetRole;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public SecurityGetRoleRequestDescriptor Name(Elastic.Clients.Elasticsearch.Names? name)
		{
			RouteValues.Optional("name", name);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}