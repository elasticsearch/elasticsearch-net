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

using OneOf;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Security
{
	public partial class AuthenticateResponse : ResponseBase
	{
		[JsonPropertyName("authentication_realm")]
		public Elastic.Clients.Elasticsearch.Security.RealmInfo AuthenticationRealm
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("authentication_type")]
		public string AuthenticationType
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("email")]
		public string? Email
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("enabled")]
		public bool Enabled
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("full_name")]
		public Elastic.Clients.Elasticsearch.Name? FullName
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("lookup_realm")]
		public Elastic.Clients.Elasticsearch.Security.RealmInfo LookupRealm
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("metadata")]
		public Elastic.Clients.Elasticsearch.Metadata Metadata
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("roles")]
		public IReadOnlyCollection<string> Roles
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("token")]
		public Elastic.Clients.Elasticsearch.Security.Authenticate.Token? Token
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("username")]
		public Elastic.Clients.Elasticsearch.Username Username
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ChangePasswordResponse : ResponseBase
	{
	}

	public partial class ClearApiKeyCacheResponse : ResponseBase
	{
		[JsonPropertyName("cluster_name")]
		public Elastic.Clients.Elasticsearch.Name ClusterName
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_nodes")]
		public Elastic.Clients.Elasticsearch.NodeStatistics node_stats
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Security.ClusterNode> Nodes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClearCachedPrivilegesResponse : ResponseBase
	{
		[JsonPropertyName("cluster_name")]
		public Elastic.Clients.Elasticsearch.Name ClusterName
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_nodes")]
		public Elastic.Clients.Elasticsearch.NodeStatistics node_stats
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Security.ClusterNode> Nodes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClearCachedRealmsResponse : ResponseBase
	{
		[JsonPropertyName("cluster_name")]
		public Elastic.Clients.Elasticsearch.Name ClusterName
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_nodes")]
		public Elastic.Clients.Elasticsearch.NodeStatistics node_stats
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Security.ClusterNode> Nodes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClearCachedRolesResponse : ResponseBase
	{
		[JsonPropertyName("cluster_name")]
		public Elastic.Clients.Elasticsearch.Name ClusterName
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_nodes")]
		public Elastic.Clients.Elasticsearch.NodeStatistics node_stats
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Security.ClusterNode> Nodes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClearCachedServiceTokensResponse : ResponseBase
	{
		[JsonPropertyName("cluster_name")]
		public Elastic.Clients.Elasticsearch.Name ClusterName
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_nodes")]
		public Elastic.Clients.Elasticsearch.NodeStatistics node_stats
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Security.ClusterNode> Nodes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class CreateApiKeyResponse : ResponseBase
	{
		[JsonPropertyName("api_key")]
		public string ApiKey
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("expiration")]
		public long? Expiration
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("id")]
		public Elastic.Clients.Elasticsearch.Id Id
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class CreateServiceTokenResponse : ResponseBase
	{
		[JsonPropertyName("created")]
		public bool Created
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("token")]
		public Elastic.Clients.Elasticsearch.Security.CreateServiceToken.Token Token
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class DeletePrivilegesResponse : DictionaryResponseBase<string, Dictionary<string, Elastic.Clients.Elasticsearch.Security.DeletePrivileges.FoundStatus>>
	{
	}

	public partial class DeleteRoleMappingResponse : ResponseBase
	{
		[JsonPropertyName("found")]
		public bool Found
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class DeleteRoleResponse : ResponseBase
	{
		[JsonPropertyName("found")]
		public bool Found
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class DeleteServiceTokenResponse : ResponseBase
	{
		[JsonPropertyName("found")]
		public bool Found
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class DeleteUserResponse : ResponseBase
	{
		[JsonPropertyName("found")]
		public bool Found
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class DisableUserResponse : ResponseBase
	{
	}

	public partial class EnableUserResponse : ResponseBase
	{
	}

	public partial class GetApiKeyResponse : ResponseBase
	{
		[JsonPropertyName("api_keys")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Security.GetApiKey.ApiKey> ApiKeys
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class GetBuiltinPrivilegesResponse : ResponseBase
	{
		[JsonPropertyName("cluster")]
		public IReadOnlyCollection<string> Cluster
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.Indices Index
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class GetPrivilegesResponse : DictionaryResponseBase<string, Dictionary<string, Elastic.Clients.Elasticsearch.Security.PutPrivileges.Actions>>
	{
	}

	public partial class GetRoleMappingResponse : DictionaryResponseBase<string, Elastic.Clients.Elasticsearch.Security.RoleMapping>
	{
	}

	public partial class GetRoleResponse : DictionaryResponseBase<string, Elastic.Clients.Elasticsearch.Security.GetRole.Role>
	{
	}

	public partial class GetServiceAccountsResponse : DictionaryResponseBase<string, Elastic.Clients.Elasticsearch.Security.GetServiceAccounts.RoleDescriptorWrapper>
	{
	}

	public partial class GetServiceCredentialsResponse : ResponseBase
	{
		[JsonPropertyName("count")]
		public int Count
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes_credentials")]
		public Elastic.Clients.Elasticsearch.Security.GetServiceCredentials.NodesCredentials NodesCredentials
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("service_account")]
		public string ServiceAccount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("tokens")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Metadata> Tokens
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class GetTokenResponse : ResponseBase
	{
		[JsonPropertyName("access_token")]
		public string AccessToken
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("authentication")]
		public Elastic.Clients.Elasticsearch.Security.GetToken.AuthenticatedUser Authentication
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("expires_in")]
		public long ExpiresIn
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("kerberos_authentication_response_token")]
		public string? KerberosAuthenticationResponseToken
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("refresh_token")]
		public string RefreshToken
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("scope")]
		public string? Scope
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("type")]
		public string Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class GetUserPrivilegesResponse : ResponseBase
	{
		[JsonPropertyName("applications")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Security.ApplicationPrivileges> Applications
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("cluster")]
		public IReadOnlyCollection<string> Cluster
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("global")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Security.GlobalPrivilege> Global
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("indices")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Security.IndicesPrivileges> Indices
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("run_as")]
		public IReadOnlyCollection<string> RunAs
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class GetUserResponse : DictionaryResponseBase<string, Elastic.Clients.Elasticsearch.Security.User>
	{
	}

	public partial class GrantApiKeyResponse : ResponseBase
	{
		[JsonPropertyName("api_key")]
		public string ApiKey
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("expiration")]
		public Elastic.Clients.Elasticsearch.EpochMillis? Expiration
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("id")]
		public Elastic.Clients.Elasticsearch.Id Id
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class HasPrivilegesResponse : ResponseBase
	{
		[JsonPropertyName("application")]
		public Elastic.Clients.Elasticsearch.Security.HasPrivileges.ApplicationsPrivileges Application
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("cluster")]
		public Dictionary<string, bool> Cluster
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("has_all_requested")]
		public bool HasAllRequested
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("index")]
		public Dictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.Security.HasPrivileges.Privileges> Index
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("username")]
		public Elastic.Clients.Elasticsearch.Username Username
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class InvalidateApiKeyResponse : ResponseBase
	{
		[JsonPropertyName("error_count")]
		public int ErrorCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("error_details")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.ErrorCause>? ErrorDetails
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("invalidated_api_keys")]
		public IReadOnlyCollection<string> InvalidatedApiKeys
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("previously_invalidated_api_keys")]
		public IReadOnlyCollection<string> PreviouslyInvalidatedApiKeys
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class InvalidateTokenResponse : ResponseBase
	{
		[JsonPropertyName("error_count")]
		public long ErrorCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("error_details")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.ErrorCause>? ErrorDetails
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("invalidated_tokens")]
		public long InvalidatedTokens
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("previously_invalidated_tokens")]
		public long PreviouslyInvalidatedTokens
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class PutPrivilegesResponse : DictionaryResponseBase<string, Dictionary<string, Elastic.Clients.Elasticsearch.Security.CreatedStatus>>
	{
	}

	public partial class PutRoleMappingResponse : ResponseBase
	{
		[JsonPropertyName("created")]
		public bool? Created
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("role_mapping")]
		public Elastic.Clients.Elasticsearch.Security.CreatedStatus RoleMapping
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class PutRoleResponse : ResponseBase
	{
		[JsonPropertyName("role")]
		public Elastic.Clients.Elasticsearch.Security.CreatedStatus Role
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class PutUserResponse : ResponseBase
	{
		[JsonPropertyName("created")]
		public bool Created
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}
}