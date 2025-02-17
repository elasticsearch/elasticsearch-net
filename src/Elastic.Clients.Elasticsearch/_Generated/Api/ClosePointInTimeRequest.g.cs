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

namespace Elastic.Clients.Elasticsearch;

public sealed partial class ClosePointInTimeRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Close a point in time.
/// </para>
/// <para>
/// A point in time must be opened explicitly before being used in search requests.
/// The <c>keep_alive</c> parameter tells Elasticsearch how long it should persist.
/// A point in time is automatically closed when the <c>keep_alive</c> period has elapsed.
/// However, keeping points in time has a cost; close them as soon as they are no longer required for search requests.
/// </para>
/// </summary>
public sealed partial class ClosePointInTimeRequest : PlainRequest<ClosePointInTimeRequestParameters>
{
	[JsonConstructor]
	internal ClosePointInTimeRequest()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceClosePointInTime;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => true;

	internal override string OperationName => "close_point_in_time";

	/// <summary>
	/// <para>
	/// The ID of the point-in-time.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("id")]
	public Elastic.Clients.Elasticsearch.Id Id { get; set; }
}

/// <summary>
/// <para>
/// Close a point in time.
/// </para>
/// <para>
/// A point in time must be opened explicitly before being used in search requests.
/// The <c>keep_alive</c> parameter tells Elasticsearch how long it should persist.
/// A point in time is automatically closed when the <c>keep_alive</c> period has elapsed.
/// However, keeping points in time has a cost; close them as soon as they are no longer required for search requests.
/// </para>
/// </summary>
public sealed partial class ClosePointInTimeRequestDescriptor : RequestDescriptor<ClosePointInTimeRequestDescriptor, ClosePointInTimeRequestParameters>
{
	internal ClosePointInTimeRequestDescriptor(Action<ClosePointInTimeRequestDescriptor> configure) => configure.Invoke(this);

	public ClosePointInTimeRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceClosePointInTime;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => true;

	internal override string OperationName => "close_point_in_time";

	private Elastic.Clients.Elasticsearch.Id IdValue { get; set; }

	/// <summary>
	/// <para>
	/// The ID of the point-in-time.
	/// </para>
	/// </summary>
	public ClosePointInTimeRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		IdValue = id;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("id");
		JsonSerializer.Serialize(writer, IdValue, options);
		writer.WriteEndObject();
	}
}