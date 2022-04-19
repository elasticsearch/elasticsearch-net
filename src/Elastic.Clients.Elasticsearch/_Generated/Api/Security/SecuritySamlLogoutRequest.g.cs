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
	public class SecuritySamlLogoutRequestParameters : RequestParameters<SecuritySamlLogoutRequestParameters>
	{
	}

	public partial class SecuritySamlLogoutRequest : PlainRequestBase<SecuritySamlLogoutRequestParameters>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecuritySamlLogout;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonInclude]
		[JsonPropertyName("token")]
		public string Token { get; set; }

		[JsonInclude]
		[JsonPropertyName("refresh_token")]
		public string? RefreshToken { get; set; }
	}

	public sealed partial class SecuritySamlLogoutRequestDescriptor : RequestDescriptorBase<SecuritySamlLogoutRequestDescriptor, SecuritySamlLogoutRequestParameters>
	{
		internal SecuritySamlLogoutRequestDescriptor(Action<SecuritySamlLogoutRequestDescriptor> configure) => configure.Invoke(this);
		public SecuritySamlLogoutRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecuritySamlLogout;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		private string? RefreshTokenValue { get; set; }

		private string TokenValue { get; set; }

		public SecuritySamlLogoutRequestDescriptor RefreshToken(string? refreshToken)
		{
			RefreshTokenValue = refreshToken;
			return Self;
		}

		public SecuritySamlLogoutRequestDescriptor Token(string token)
		{
			TokenValue = token;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(RefreshTokenValue))
			{
				writer.WritePropertyName("refresh_token");
				writer.WriteStringValue(RefreshTokenValue);
			}

			writer.WritePropertyName("token");
			writer.WriteStringValue(TokenValue);
			writer.WriteEndObject();
		}
	}
}