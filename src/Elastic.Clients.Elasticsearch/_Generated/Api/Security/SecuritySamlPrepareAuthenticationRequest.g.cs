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
	public sealed class SecuritySamlPrepareAuthenticationRequestParameters : RequestParameters<SecuritySamlPrepareAuthenticationRequestParameters>
	{
	}

	public sealed partial class SecuritySamlPrepareAuthenticationRequest : PlainRequestBase<SecuritySamlPrepareAuthenticationRequestParameters>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecuritySamlPrepareAuthentication;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonInclude]
		[JsonPropertyName("acs")]
		public string? Acs { get; set; }

		[JsonInclude]
		[JsonPropertyName("realm")]
		public string? Realm { get; set; }

		[JsonInclude]
		[JsonPropertyName("relay_state")]
		public string? RelayState { get; set; }
	}

	public sealed partial class SecuritySamlPrepareAuthenticationRequestDescriptor : RequestDescriptorBase<SecuritySamlPrepareAuthenticationRequestDescriptor, SecuritySamlPrepareAuthenticationRequestParameters>
	{
		internal SecuritySamlPrepareAuthenticationRequestDescriptor(Action<SecuritySamlPrepareAuthenticationRequestDescriptor> configure) => configure.Invoke(this);
		public SecuritySamlPrepareAuthenticationRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecuritySamlPrepareAuthentication;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		private string? AcsValue { get; set; }

		private string? RealmValue { get; set; }

		private string? RelayStateValue { get; set; }

		public SecuritySamlPrepareAuthenticationRequestDescriptor Acs(string? acs)
		{
			AcsValue = acs;
			return Self;
		}

		public SecuritySamlPrepareAuthenticationRequestDescriptor Realm(string? realm)
		{
			RealmValue = realm;
			return Self;
		}

		public SecuritySamlPrepareAuthenticationRequestDescriptor RelayState(string? relayState)
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
}