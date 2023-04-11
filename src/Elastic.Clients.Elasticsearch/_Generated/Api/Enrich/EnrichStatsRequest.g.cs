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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Enrich;

public sealed class EnrichStatsRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Gets enrich coordinator statistics and information about enrich policies that are currently executing.</para>
/// </summary>
public sealed partial class EnrichStatsRequest : PlainRequest<EnrichStatsRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.EnrichStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;
}

/// <summary>
/// <para>Gets enrich coordinator statistics and information about enrich policies that are currently executing.</para>
/// </summary>
public sealed partial class EnrichStatsRequestDescriptor : RequestDescriptor<EnrichStatsRequestDescriptor, EnrichStatsRequestParameters>
{
	internal EnrichStatsRequestDescriptor(Action<EnrichStatsRequestDescriptor> configure) => configure.Invoke(this);

	public EnrichStatsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.EnrichStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}