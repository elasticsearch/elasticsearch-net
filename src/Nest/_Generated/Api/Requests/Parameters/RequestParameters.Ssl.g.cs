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
// ------------------------------------------------

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Nest.Ssl
{
	public class AuthenticateRequestParameters : RequestParameters<AuthenticateRequestParameters>
	{
	}

	public class ChangePasswordRequestParameters : RequestParameters<ChangePasswordRequestParameters>
	{
		[JsonIgnore]
		public Nest.Refresh? Refresh { get => Q<Nest.Refresh?>("refresh"); set => Q("refresh", value); }
	}

	public class ClearApiKeyCacheRequestParameters : RequestParameters<ClearApiKeyCacheRequestParameters>
	{
	}

	public class ClearCachedPrivilegesRequestParameters : RequestParameters<ClearCachedPrivilegesRequestParameters>
	{
	}

	public class ClearCachedRealmsRequestParameters : RequestParameters<ClearCachedRealmsRequestParameters>
	{
		[JsonIgnore]
		public IEnumerable<string>? Usernames { get => Q<IEnumerable<string>?>("usernames"); set => Q("usernames", value); }
	}

	public class ClearCachedRolesRequestParameters : RequestParameters<ClearCachedRolesRequestParameters>
	{
	}

	public class ClearCachedServiceTokensRequestParameters : RequestParameters<ClearCachedServiceTokensRequestParameters>
	{
	}

	public class CreateApiKeyRequestParameters : RequestParameters<CreateApiKeyRequestParameters>
	{
		[JsonIgnore]
		public Nest.Refresh? Refresh { get => Q<Nest.Refresh?>("refresh"); set => Q("refresh", value); }
	}

	public class CreateServiceTokenRequestParameters : RequestParameters<CreateServiceTokenRequestParameters>
	{
	}

	public class DeletePrivilegesRequestParameters : RequestParameters<DeletePrivilegesRequestParameters>
	{
		[JsonIgnore]
		public Nest.Refresh? Refresh { get => Q<Nest.Refresh?>("refresh"); set => Q("refresh", value); }
	}

	public class DeleteRoleRequestParameters : RequestParameters<DeleteRoleRequestParameters>
	{
		[JsonIgnore]
		public Nest.Refresh? Refresh { get => Q<Nest.Refresh?>("refresh"); set => Q("refresh", value); }
	}

	public class DeleteRoleMappingRequestParameters : RequestParameters<DeleteRoleMappingRequestParameters>
	{
		[JsonIgnore]
		public Nest.Refresh? Refresh { get => Q<Nest.Refresh?>("refresh"); set => Q("refresh", value); }
	}

	public class DeleteServiceTokenRequestParameters : RequestParameters<DeleteServiceTokenRequestParameters>
	{
		[JsonIgnore]
		public Nest.Refresh? Refresh { get => Q<Nest.Refresh?>("refresh"); set => Q("refresh", value); }
	}

	public class DeleteUserRequestParameters : RequestParameters<DeleteUserRequestParameters>
	{
		[JsonIgnore]
		public Nest.Refresh? Refresh { get => Q<Nest.Refresh?>("refresh"); set => Q("refresh", value); }
	}

	public class DisableUserRequestParameters : RequestParameters<DisableUserRequestParameters>
	{
		[JsonIgnore]
		public Nest.Refresh? Refresh { get => Q<Nest.Refresh?>("refresh"); set => Q("refresh", value); }
	}

	public class EnableUserRequestParameters : RequestParameters<EnableUserRequestParameters>
	{
		[JsonIgnore]
		public Nest.Refresh? Refresh { get => Q<Nest.Refresh?>("refresh"); set => Q("refresh", value); }
	}

	public class GetApiKeyRequestParameters : RequestParameters<GetApiKeyRequestParameters>
	{
		[JsonIgnore]
		public Nest.Id? Id { get => Q<Nest.Id?>("id"); set => Q("id", value); }

		[JsonIgnore]
		public Nest.Name? Name { get => Q<Nest.Name?>("name"); set => Q("name", value); }

		[JsonIgnore]
		public bool? Owner { get => Q<bool?>("owner"); set => Q("owner", value); }

		[JsonIgnore]
		public Nest.Name? RealmName { get => Q<Nest.Name?>("realm_name"); set => Q("realm_name", value); }

		[JsonIgnore]
		public Nest.Username? Username { get => Q<Nest.Username?>("username"); set => Q("username", value); }
	}

	public class GetBuiltinPrivilegesRequestParameters : RequestParameters<GetBuiltinPrivilegesRequestParameters>
	{
	}

	public class GetPrivilegesRequestParameters : RequestParameters<GetPrivilegesRequestParameters>
	{
	}

	public class GetRoleRequestParameters : RequestParameters<GetRoleRequestParameters>
	{
	}

	public class GetRoleMappingRequestParameters : RequestParameters<GetRoleMappingRequestParameters>
	{
	}

	public class GetServiceAccountsRequestParameters : RequestParameters<GetServiceAccountsRequestParameters>
	{
	}

	public class GetServiceCredentialsRequestParameters : RequestParameters<GetServiceCredentialsRequestParameters>
	{
	}

	public class GetTokenRequestParameters : RequestParameters<GetTokenRequestParameters>
	{
	}

	public class GetUserRequestParameters : RequestParameters<GetUserRequestParameters>
	{
	}

	public class GetUserPrivilegesRequestParameters : RequestParameters<GetUserPrivilegesRequestParameters>
	{
		[JsonIgnore]
		public Nest.Name? Application { get => Q<Nest.Name?>("application"); set => Q("application", value); }

		[JsonIgnore]
		public Nest.Name? Priviledge { get => Q<Nest.Name?>("priviledge"); set => Q("priviledge", value); }
	}

	public class GrantApiKeyRequestParameters : RequestParameters<GrantApiKeyRequestParameters>
	{
	}

	public class HasPrivilegesRequestParameters : RequestParameters<HasPrivilegesRequestParameters>
	{
	}

	public class InvalidateApiKeyRequestParameters : RequestParameters<InvalidateApiKeyRequestParameters>
	{
	}

	public class InvalidateTokenRequestParameters : RequestParameters<InvalidateTokenRequestParameters>
	{
	}

	public class PutPrivilegesRequestParameters : RequestParameters<PutPrivilegesRequestParameters>
	{
		[JsonIgnore]
		public Nest.Refresh? Refresh { get => Q<Nest.Refresh?>("refresh"); set => Q("refresh", value); }
	}

	public class PutRoleRequestParameters : RequestParameters<PutRoleRequestParameters>
	{
		[JsonIgnore]
		public Nest.Refresh? Refresh { get => Q<Nest.Refresh?>("refresh"); set => Q("refresh", value); }
	}

	public class PutRoleMappingRequestParameters : RequestParameters<PutRoleMappingRequestParameters>
	{
		[JsonIgnore]
		public Nest.Refresh? Refresh { get => Q<Nest.Refresh?>("refresh"); set => Q("refresh", value); }
	}

	public class PutUserRequestParameters : RequestParameters<PutUserRequestParameters>
	{
		[JsonIgnore]
		public Nest.Refresh? Refresh { get => Q<Nest.Refresh?>("refresh"); set => Q("refresh", value); }
	}

	public class CertificatesRequestParameters : RequestParameters<CertificatesRequestParameters>
	{
	}
}