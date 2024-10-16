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

#nullable restore

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Security;

public sealed partial class SamlLogoutRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Submits a request to invalidate an access token and refresh token.
/// </para>
/// </summary>
public sealed partial class SamlLogoutRequest : PlainRequest<SamlLogoutRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.SecuritySamlLogout;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.saml_logout";

	/// <summary>
	/// <para>
	/// The refresh token that was returned as a response to calling the SAML authenticate API.
	/// Alternatively, the most recent refresh token that was received after refreshing the original access token.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("refresh_token")]
	public string? RefreshToken { get; set; }

	/// <summary>
	/// <para>
	/// The access token that was returned as a response to calling the SAML authenticate API.
	/// Alternatively, the most recent token that was received after refreshing the original one by using a refresh_token.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("token")]
	public string Token { get; set; }
}

/// <summary>
/// <para>
/// Submits a request to invalidate an access token and refresh token.
/// </para>
/// </summary>
public sealed partial class SamlLogoutRequestDescriptor : RequestDescriptor<SamlLogoutRequestDescriptor, SamlLogoutRequestParameters>
{
	internal SamlLogoutRequestDescriptor(Action<SamlLogoutRequestDescriptor> configure) => configure.Invoke(this);

	public SamlLogoutRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecuritySamlLogout;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.saml_logout";

	private string? RefreshTokenValue { get; set; }
	private string TokenValue { get; set; }

	/// <summary>
	/// <para>
	/// The refresh token that was returned as a response to calling the SAML authenticate API.
	/// Alternatively, the most recent refresh token that was received after refreshing the original access token.
	/// </para>
	/// </summary>
	public SamlLogoutRequestDescriptor RefreshToken(string? refreshToken)
	{
		RefreshTokenValue = refreshToken;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The access token that was returned as a response to calling the SAML authenticate API.
	/// Alternatively, the most recent token that was received after refreshing the original one by using a refresh_token.
	/// </para>
	/// </summary>
	public SamlLogoutRequestDescriptor Token(string token)
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