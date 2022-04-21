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
	public sealed class SecurityGetTokenRequestParameters : RequestParameters<SecurityGetTokenRequestParameters>
	{
	}

	public partial class SecurityGetTokenRequest : PlainRequestBase<SecurityGetTokenRequestParameters>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetToken;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonInclude]
		[JsonPropertyName("grant_type")]
		public Elastic.Clients.Elasticsearch.Security.AccessTokenGrantType? GrantType { get; set; }

		[JsonInclude]
		[JsonPropertyName("scope")]
		public string? Scope { get; set; }

		[JsonInclude]
		[JsonPropertyName("password")]
		public string? Password { get; set; }

		[JsonInclude]
		[JsonPropertyName("kerberos_ticket")]
		public string? KerberosTicket { get; set; }

		[JsonInclude]
		[JsonPropertyName("refresh_token")]
		public string? RefreshToken { get; set; }

		[JsonInclude]
		[JsonPropertyName("username")]
		public Elastic.Clients.Elasticsearch.Username? Username { get; set; }
	}

	public sealed partial class SecurityGetTokenRequestDescriptor : RequestDescriptorBase<SecurityGetTokenRequestDescriptor, SecurityGetTokenRequestParameters>
	{
		internal SecurityGetTokenRequestDescriptor(Action<SecurityGetTokenRequestDescriptor> configure) => configure.Invoke(this);
		public SecurityGetTokenRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetToken;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		private Elastic.Clients.Elasticsearch.Security.AccessTokenGrantType? GrantTypeValue { get; set; }

		private string? KerberosTicketValue { get; set; }

		private string? PasswordValue { get; set; }

		private string? RefreshTokenValue { get; set; }

		private string? ScopeValue { get; set; }

		private Elastic.Clients.Elasticsearch.Username? UsernameValue { get; set; }

		public SecurityGetTokenRequestDescriptor GrantType(Elastic.Clients.Elasticsearch.Security.AccessTokenGrantType? grantType)
		{
			GrantTypeValue = grantType;
			return Self;
		}

		public SecurityGetTokenRequestDescriptor KerberosTicket(string? kerberosTicket)
		{
			KerberosTicketValue = kerberosTicket;
			return Self;
		}

		public SecurityGetTokenRequestDescriptor Password(string? password)
		{
			PasswordValue = password;
			return Self;
		}

		public SecurityGetTokenRequestDescriptor RefreshToken(string? refreshToken)
		{
			RefreshTokenValue = refreshToken;
			return Self;
		}

		public SecurityGetTokenRequestDescriptor Scope(string? scope)
		{
			ScopeValue = scope;
			return Self;
		}

		public SecurityGetTokenRequestDescriptor Username(Elastic.Clients.Elasticsearch.Username? username)
		{
			UsernameValue = username;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (GrantTypeValue is not null)
			{
				writer.WritePropertyName("grant_type");
				JsonSerializer.Serialize(writer, GrantTypeValue, options);
			}

			if (!string.IsNullOrEmpty(KerberosTicketValue))
			{
				writer.WritePropertyName("kerberos_ticket");
				writer.WriteStringValue(KerberosTicketValue);
			}

			if (PasswordValue is not null)
			{
				writer.WritePropertyName("password");
				JsonSerializer.Serialize(writer, PasswordValue, options);
			}

			if (!string.IsNullOrEmpty(RefreshTokenValue))
			{
				writer.WritePropertyName("refresh_token");
				writer.WriteStringValue(RefreshTokenValue);
			}

			if (!string.IsNullOrEmpty(ScopeValue))
			{
				writer.WritePropertyName("scope");
				writer.WriteStringValue(ScopeValue);
			}

			if (UsernameValue is not null)
			{
				writer.WritePropertyName("username");
				JsonSerializer.Serialize(writer, UsernameValue, options);
			}

			writer.WriteEndObject();
		}
	}
}