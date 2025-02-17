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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class MlInfoRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Get machine learning information.
/// Get defaults and limits used by machine learning.
/// This endpoint is designed to be used by a user interface that needs to fully
/// understand machine learning configurations where some options are not
/// specified, meaning that the defaults should be used. This endpoint may be
/// used to find out what those defaults are. It also provides information about
/// the maximum size of machine learning jobs that could run in the current
/// cluster configuration.
/// </para>
/// </summary>
public sealed partial class MlInfoRequest : PlainRequest<MlInfoRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningInfo;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.info";
}

/// <summary>
/// <para>
/// Get machine learning information.
/// Get defaults and limits used by machine learning.
/// This endpoint is designed to be used by a user interface that needs to fully
/// understand machine learning configurations where some options are not
/// specified, meaning that the defaults should be used. This endpoint may be
/// used to find out what those defaults are. It also provides information about
/// the maximum size of machine learning jobs that could run in the current
/// cluster configuration.
/// </para>
/// </summary>
public sealed partial class MlInfoRequestDescriptor : RequestDescriptor<MlInfoRequestDescriptor, MlInfoRequestParameters>
{
	internal MlInfoRequestDescriptor(Action<MlInfoRequestDescriptor> configure) => configure.Invoke(this);

	public MlInfoRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningInfo;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.info";

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}