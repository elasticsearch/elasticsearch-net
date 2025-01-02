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

namespace Elastic.Clients.Elasticsearch.LicenseManagement;

public sealed partial class PostStartBasicRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// whether the user has acknowledged acknowledge messages (default: false)
	/// </para>
	/// </summary>
	public bool? Acknowledge { get => Q<bool?>("acknowledge"); set => Q("acknowledge", value); }
}

/// <summary>
/// <para>
/// Start a basic license.
/// Start an indefinite basic license, which gives access to all the basic features.
/// </para>
/// <para>
/// NOTE: In order to start a basic license, you must not currently have a basic license.
/// </para>
/// <para>
/// If the basic license does not support all of the features that are available with your current license, however, you are notified in the response.
/// You must then re-submit the API request with the <c>acknowledge</c> parameter set to <c>true</c>.
/// </para>
/// <para>
/// To check the status of your basic license, use the get basic license API.
/// </para>
/// </summary>
public sealed partial class PostStartBasicRequest : PlainRequest<PostStartBasicRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.LicenseManagementPostStartBasic;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "license.post_start_basic";

	/// <summary>
	/// <para>
	/// whether the user has acknowledged acknowledge messages (default: false)
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? Acknowledge { get => Q<bool?>("acknowledge"); set => Q("acknowledge", value); }
}

/// <summary>
/// <para>
/// Start a basic license.
/// Start an indefinite basic license, which gives access to all the basic features.
/// </para>
/// <para>
/// NOTE: In order to start a basic license, you must not currently have a basic license.
/// </para>
/// <para>
/// If the basic license does not support all of the features that are available with your current license, however, you are notified in the response.
/// You must then re-submit the API request with the <c>acknowledge</c> parameter set to <c>true</c>.
/// </para>
/// <para>
/// To check the status of your basic license, use the get basic license API.
/// </para>
/// </summary>
public sealed partial class PostStartBasicRequestDescriptor : RequestDescriptor<PostStartBasicRequestDescriptor, PostStartBasicRequestParameters>
{
	internal PostStartBasicRequestDescriptor(Action<PostStartBasicRequestDescriptor> configure) => configure.Invoke(this);

	public PostStartBasicRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.LicenseManagementPostStartBasic;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "license.post_start_basic";

	public PostStartBasicRequestDescriptor Acknowledge(bool? acknowledge = true) => Qs("acknowledge", acknowledge);

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}