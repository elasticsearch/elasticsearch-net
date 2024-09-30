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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Xpack;

public sealed partial class XpackInfoRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If this param is used it must be set to true
	/// </para>
	/// </summary>
	public bool? AcceptEnterprise { get => Q<bool?>("accept_enterprise"); set => Q("accept_enterprise", value); }

	/// <summary>
	/// <para>
	/// A comma-separated list of the information categories to include in the response. For example, <c>build,license,features</c>.
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Xpack.XPackCategory>? Categories { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.Xpack.XPackCategory>?>("categories"); set => Q("categories", value); }
}

/// <summary>
/// <para>
/// Provides general information about the installed X-Pack features.
/// </para>
/// </summary>
public sealed partial class XpackInfoRequest : PlainRequest<XpackInfoRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.XpackInfo;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "xpack.info";

	/// <summary>
	/// <para>
	/// If this param is used it must be set to true
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? AcceptEnterprise { get => Q<bool?>("accept_enterprise"); set => Q("accept_enterprise", value); }

	/// <summary>
	/// <para>
	/// A comma-separated list of the information categories to include in the response. For example, <c>build,license,features</c>.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Xpack.XPackCategory>? Categories { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.Xpack.XPackCategory>?>("categories"); set => Q("categories", value); }
}

/// <summary>
/// <para>
/// Provides general information about the installed X-Pack features.
/// </para>
/// </summary>
public sealed partial class XpackInfoRequestDescriptor : RequestDescriptor<XpackInfoRequestDescriptor, XpackInfoRequestParameters>
{
	internal XpackInfoRequestDescriptor(Action<XpackInfoRequestDescriptor> configure) => configure.Invoke(this);

	public XpackInfoRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.XpackInfo;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "xpack.info";

	public XpackInfoRequestDescriptor AcceptEnterprise(bool? acceptEnterprise = true) => Qs("accept_enterprise", acceptEnterprise);
	public XpackInfoRequestDescriptor Categories(ICollection<Elastic.Clients.Elasticsearch.Serverless.Xpack.XPackCategory>? categories) => Qs("categories", categories);

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}