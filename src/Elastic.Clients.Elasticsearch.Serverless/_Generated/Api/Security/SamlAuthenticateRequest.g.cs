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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Security;

public sealed partial class SamlAuthenticateRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Submits a SAML Response message to Elasticsearch for consumption.
/// </para>
/// </summary>
public sealed partial class SamlAuthenticateRequest : PlainRequest<SamlAuthenticateRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.SecuritySamlAuthenticate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.saml_authenticate";

	/// <summary>
	/// <para>
	/// The SAML response as it was sent by the user’s browser, usually a Base64 encoded XML document.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("content")]
	public string Content { get; set; }

	/// <summary>
	/// <para>
	/// A json array with all the valid SAML Request Ids that the caller of the API has for the current user.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ids")]
	public Elastic.Clients.Elasticsearch.Serverless.Ids Ids { get; set; }

	/// <summary>
	/// <para>
	/// The name of the realm that should authenticate the SAML response. Useful in cases where many SAML realms are defined.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("realm")]
	public string? Realm { get; set; }
}

/// <summary>
/// <para>
/// Submits a SAML Response message to Elasticsearch for consumption.
/// </para>
/// </summary>
public sealed partial class SamlAuthenticateRequestDescriptor : RequestDescriptor<SamlAuthenticateRequestDescriptor, SamlAuthenticateRequestParameters>
{
	internal SamlAuthenticateRequestDescriptor(Action<SamlAuthenticateRequestDescriptor> configure) => configure.Invoke(this);

	public SamlAuthenticateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecuritySamlAuthenticate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.saml_authenticate";

	private string ContentValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Ids IdsValue { get; set; }
	private string? RealmValue { get; set; }

	/// <summary>
	/// <para>
	/// The SAML response as it was sent by the user’s browser, usually a Base64 encoded XML document.
	/// </para>
	/// </summary>
	public SamlAuthenticateRequestDescriptor Content(string content)
	{
		ContentValue = content;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A json array with all the valid SAML Request Ids that the caller of the API has for the current user.
	/// </para>
	/// </summary>
	public SamlAuthenticateRequestDescriptor Ids(Elastic.Clients.Elasticsearch.Serverless.Ids ids)
	{
		IdsValue = ids;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The name of the realm that should authenticate the SAML response. Useful in cases where many SAML realms are defined.
	/// </para>
	/// </summary>
	public SamlAuthenticateRequestDescriptor Realm(string? realm)
	{
		RealmValue = realm;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("content");
		writer.WriteStringValue(ContentValue);
		writer.WritePropertyName("ids");
		JsonSerializer.Serialize(writer, IdsValue, options);
		if (!string.IsNullOrEmpty(RealmValue))
		{
			writer.WritePropertyName("realm");
			writer.WriteStringValue(RealmValue);
		}

		writer.WriteEndObject();
	}
}