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
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Xpack;

public sealed partial class Realm
{
	[JsonInclude, JsonPropertyName("available")]
	public bool Available { get; init; }
	[JsonInclude, JsonPropertyName("cache")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Xpack.RealmCache>? Cache { get; init; }
	[JsonInclude, JsonPropertyName("enabled")]
	public bool Enabled { get; init; }
	[JsonInclude, JsonPropertyName("has_authorization_realms")]
	public IReadOnlyCollection<bool>? HasAuthorizationRealms { get; init; }
	[JsonInclude, JsonPropertyName("has_default_username_pattern")]
	public IReadOnlyCollection<bool>? HasDefaultUsernamePattern { get; init; }
	[JsonInclude, JsonPropertyName("has_truststore")]
	public IReadOnlyCollection<bool>? HasTruststore { get; init; }
	[JsonInclude, JsonPropertyName("is_authentication_delegated")]
	public IReadOnlyCollection<bool>? IsAuthenticationDelegated { get; init; }
	[JsonInclude, JsonPropertyName("name")]
	public IReadOnlyCollection<string>? Name { get; init; }
	[JsonInclude, JsonPropertyName("order")]
	public IReadOnlyCollection<long>? Order { get; init; }
	[JsonInclude, JsonPropertyName("size")]
	public IReadOnlyCollection<long>? Size { get; init; }
}