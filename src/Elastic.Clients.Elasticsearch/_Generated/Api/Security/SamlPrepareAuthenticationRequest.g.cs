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

public sealed partial class SamlPrepareAuthenticationRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Prepare SAML authentication.
/// </para>
/// <para>
/// Creates a SAML authentication request (<c>&lt;AuthnRequest></c>) as a URL string, based on the configuration of the respective SAML realm in Elasticsearch.
/// </para>
/// </summary>
public sealed partial class SamlPrepareAuthenticationRequest : PlainRequest<SamlPrepareAuthenticationRequestParameters>
{
	[JsonConstructor]
	internal SamlPrepareAuthenticationRequest()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecuritySamlPrepareAuthentication;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.saml_prepare_authentication";

	/// <summary>
	/// <para>
	/// The Assertion Consumer Service URL that matches the one of the SAML realms in Elasticsearch.
	/// The realm is used to generate the authentication request. You must specify either this parameter or the realm parameter.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("acs")]
	public string? Acs { get; set; }

	/// <summary>
	/// <para>
	/// The name of the SAML realm in Elasticsearch for which the configuration is used to generate the authentication request.
	/// You must specify either this parameter or the acs parameter.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("realm")]
	public string? Realm { get; set; }

	/// <summary>
	/// <para>
	/// A string that will be included in the redirect URL that this API returns as the RelayState query parameter.
	/// If the Authentication Request is signed, this value is used as part of the signature computation.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("relay_state")]
	public string? RelayState { get; set; }
}

/// <summary>
/// <para>
/// Prepare SAML authentication.
/// </para>
/// <para>
/// Creates a SAML authentication request (<c>&lt;AuthnRequest></c>) as a URL string, based on the configuration of the respective SAML realm in Elasticsearch.
/// </para>
/// </summary>
public sealed partial class SamlPrepareAuthenticationRequestDescriptor : RequestDescriptor<SamlPrepareAuthenticationRequestDescriptor, SamlPrepareAuthenticationRequestParameters>
{
	internal SamlPrepareAuthenticationRequestDescriptor(Action<SamlPrepareAuthenticationRequestDescriptor> configure) => configure.Invoke(this);

	public SamlPrepareAuthenticationRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecuritySamlPrepareAuthentication;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.saml_prepare_authentication";

	private string? AcsValue { get; set; }
	private string? RealmValue { get; set; }
	private string? RelayStateValue { get; set; }

	/// <summary>
	/// <para>
	/// The Assertion Consumer Service URL that matches the one of the SAML realms in Elasticsearch.
	/// The realm is used to generate the authentication request. You must specify either this parameter or the realm parameter.
	/// </para>
	/// </summary>
	public SamlPrepareAuthenticationRequestDescriptor Acs(string? acs)
	{
		AcsValue = acs;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The name of the SAML realm in Elasticsearch for which the configuration is used to generate the authentication request.
	/// You must specify either this parameter or the acs parameter.
	/// </para>
	/// </summary>
	public SamlPrepareAuthenticationRequestDescriptor Realm(string? realm)
	{
		RealmValue = realm;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A string that will be included in the redirect URL that this API returns as the RelayState query parameter.
	/// If the Authentication Request is signed, this value is used as part of the signature computation.
	/// </para>
	/// </summary>
	public SamlPrepareAuthenticationRequestDescriptor RelayState(string? relayState)
	{
		RelayStateValue = relayState;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(AcsValue))
		{
			writer.WritePropertyName("acs");
			writer.WriteStringValue(AcsValue);
		}

		if (!string.IsNullOrEmpty(RealmValue))
		{
			writer.WritePropertyName("realm");
			writer.WriteStringValue(RealmValue);
		}

		if (!string.IsNullOrEmpty(RelayStateValue))
		{
			writer.WritePropertyName("relay_state");
			writer.WriteStringValue(RelayStateValue);
		}

		writer.WriteEndObject();
	}
}