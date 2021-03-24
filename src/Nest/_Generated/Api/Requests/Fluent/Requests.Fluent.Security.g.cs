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
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------

using Elastic.Transport;

#nullable restore
namespace Nest
{
	public class AuthenticateDescriptor : RequestDescriptorBase<AuthenticateDescriptor, AuthenticateRequestParameters, IAuthenticateRequest>, IAuthenticateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityAuthenticate;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class ChangePasswordDescriptor : RequestDescriptorBase<ChangePasswordDescriptor, ChangePasswordRequestParameters, IChangePasswordRequest>, IChangePasswordRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityChangePassword;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
	}

	public class ClearApiKeyCacheDescriptor : RequestDescriptorBase<ClearApiKeyCacheDescriptor, ClearApiKeyCacheRequestParameters, IClearApiKeyCacheRequest>, IClearApiKeyCacheRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityClearApiKeyCache;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public class ClearCachedRealmsDescriptor : RequestDescriptorBase<ClearCachedRealmsDescriptor, ClearCachedRealmsRequestParameters, IClearCachedRealmsRequest>, IClearCachedRealmsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityClearCachedRealms;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public class ClearCachedRolesDescriptor : RequestDescriptorBase<ClearCachedRolesDescriptor, ClearCachedRolesRequestParameters, IClearCachedRolesRequest>, IClearCachedRolesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityClearCachedRoles;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public class CreateApiKeyDescriptor : RequestDescriptorBase<CreateApiKeyDescriptor, CreateApiKeyRequestParameters, ICreateApiKeyRequest>, ICreateApiKeyRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityCreateApiKey;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
	}

	public class DeletePrivilegesDescriptor : RequestDescriptorBase<DeletePrivilegesDescriptor, DeletePrivilegesRequestParameters, IDeletePrivilegesRequest>, IDeletePrivilegesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityDeletePrivileges;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public class DeleteRoleDescriptor : RequestDescriptorBase<DeleteRoleDescriptor, DeleteRoleRequestParameters, IDeleteRoleRequest>, IDeleteRoleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityDeleteRole;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public class DeleteRoleMappingDescriptor : RequestDescriptorBase<DeleteRoleMappingDescriptor, DeleteRoleMappingRequestParameters, IDeleteRoleMappingRequest>, IDeleteRoleMappingRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityDeleteRoleMapping;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public class DeleteUserDescriptor : RequestDescriptorBase<DeleteUserDescriptor, DeleteUserRequestParameters, IDeleteUserRequest>, IDeleteUserRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityDeleteUser;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public class DisableUserDescriptor : RequestDescriptorBase<DisableUserDescriptor, DisableUserRequestParameters, IDisableUserRequest>, IDisableUserRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityDisableUser;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
	}

	public class EnableUserDescriptor : RequestDescriptorBase<EnableUserDescriptor, EnableUserRequestParameters, IEnableUserRequest>, IEnableUserRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityEnableUser;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
	}

	public class GetApiKeyDescriptor : RequestDescriptorBase<GetApiKeyDescriptor, GetApiKeyRequestParameters, IGetApiKeyRequest>, IGetApiKeyRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetApiKey;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class GetBuiltinPrivilegesDescriptor : RequestDescriptorBase<GetBuiltinPrivilegesDescriptor, GetBuiltinPrivilegesRequestParameters, IGetBuiltinPrivilegesRequest>, IGetBuiltinPrivilegesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetBuiltinPrivileges;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class GetPrivilegesDescriptor : RequestDescriptorBase<GetPrivilegesDescriptor, GetPrivilegesRequestParameters, IGetPrivilegesRequest>, IGetPrivilegesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetPrivileges;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class GetRoleDescriptor : RequestDescriptorBase<GetRoleDescriptor, GetRoleRequestParameters, IGetRoleRequest>, IGetRoleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetRole;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class GetRoleMappingDescriptor : RequestDescriptorBase<GetRoleMappingDescriptor, GetRoleMappingRequestParameters, IGetRoleMappingRequest>, IGetRoleMappingRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetRoleMapping;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class GetUserAccessTokenDescriptor : RequestDescriptorBase<GetUserAccessTokenDescriptor, GetUserAccessTokenRequestParameters, IGetUserAccessTokenRequest>, IGetUserAccessTokenRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetToken;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public class GetUserDescriptor : RequestDescriptorBase<GetUserDescriptor, GetUserRequestParameters, IGetUserRequest>, IGetUserRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetUser;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class GetUserPrivilegesDescriptor : RequestDescriptorBase<GetUserPrivilegesDescriptor, GetUserPrivilegesRequestParameters, IGetUserPrivilegesRequest>, IGetUserPrivilegesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetUserPrivileges;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class GrantApiKeyDescriptor : RequestDescriptorBase<GrantApiKeyDescriptor, GrantApiKeyRequestParameters, IGrantApiKeyRequest>, IGrantApiKeyRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGrantApiKey;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public class HasPrivilegesDescriptor : RequestDescriptorBase<HasPrivilegesDescriptor, HasPrivilegesRequestParameters, IHasPrivilegesRequest>, IHasPrivilegesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityHasPrivileges;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public class InvalidateApiKeyDescriptor : RequestDescriptorBase<InvalidateApiKeyDescriptor, InvalidateApiKeyRequestParameters, IInvalidateApiKeyRequest>, IInvalidateApiKeyRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityInvalidateApiKey;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public class InvalidateUserAccessTokenDescriptor : RequestDescriptorBase<InvalidateUserAccessTokenDescriptor, InvalidateUserAccessTokenRequestParameters, IInvalidateUserAccessTokenRequest>, IInvalidateUserAccessTokenRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityInvalidateToken;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public class PutPrivilegesDescriptor : RequestDescriptorBase<PutPrivilegesDescriptor, PutPrivilegesRequestParameters, IPutPrivilegesRequest>, IPutPrivilegesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityPutPrivileges;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
	}

	public class PutRoleDescriptor : RequestDescriptorBase<PutRoleDescriptor, PutRoleRequestParameters, IPutRoleRequest>, IPutRoleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityPutRole;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
	}

	public class PutRoleMappingDescriptor : RequestDescriptorBase<PutRoleMappingDescriptor, PutRoleMappingRequestParameters, IPutRoleMappingRequest>, IPutRoleMappingRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityPutRoleMapping;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
	}

	public class PutUserDescriptor : RequestDescriptorBase<PutUserDescriptor, PutUserRequestParameters, IPutUserRequest>, IPutUserRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityPutUser;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
	}

	public class GetCertificatesDescriptor : RequestDescriptorBase<GetCertificatesDescriptor, GetCertificatesRequestParameters, IGetCertificatesRequest>, IGetCertificatesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityCertificates;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}
}