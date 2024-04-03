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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class SetUpgradeModeRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>When `true`, it enables `upgrade_mode` which temporarily halts all job<br/>and datafeed tasks and prohibits new job and datafeed tasks from<br/>starting.</para>
	/// </summary>
	public bool? Enabled { get => Q<bool?>("enabled"); set => Q("enabled", value); }

	/// <summary>
	/// <para>The time to wait for the request to be completed.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>Sets a cluster wide upgrade_mode setting that prepares machine learning<br/>indices for an upgrade.<br/>When upgrading your cluster, in some circumstances you must restart your<br/>nodes and reindex your machine learning indices. In those circumstances,<br/>there must be no machine learning jobs running. You can close the machine<br/>learning jobs, do the upgrade, then open all the jobs again. Alternatively,<br/>you can use this API to temporarily halt tasks associated with the jobs and<br/>datafeeds and prevent new jobs from opening. You can also use this API<br/>during upgrades that do not require you to reindex your machine learning<br/>indices, though stopping jobs is not a requirement in that case.<br/>You can see the current value for the upgrade_mode setting by using the get<br/>machine learning info API.</para>
/// </summary>
public sealed partial class SetUpgradeModeRequest : PlainRequest<SetUpgradeModeRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningSetUpgradeMode;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.set_upgrade_mode";

	/// <summary>
	/// <para>When `true`, it enables `upgrade_mode` which temporarily halts all job<br/>and datafeed tasks and prohibits new job and datafeed tasks from<br/>starting.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Enabled { get => Q<bool?>("enabled"); set => Q("enabled", value); }

	/// <summary>
	/// <para>The time to wait for the request to be completed.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>Sets a cluster wide upgrade_mode setting that prepares machine learning<br/>indices for an upgrade.<br/>When upgrading your cluster, in some circumstances you must restart your<br/>nodes and reindex your machine learning indices. In those circumstances,<br/>there must be no machine learning jobs running. You can close the machine<br/>learning jobs, do the upgrade, then open all the jobs again. Alternatively,<br/>you can use this API to temporarily halt tasks associated with the jobs and<br/>datafeeds and prevent new jobs from opening. You can also use this API<br/>during upgrades that do not require you to reindex your machine learning<br/>indices, though stopping jobs is not a requirement in that case.<br/>You can see the current value for the upgrade_mode setting by using the get<br/>machine learning info API.</para>
/// </summary>
public sealed partial class SetUpgradeModeRequestDescriptor : RequestDescriptor<SetUpgradeModeRequestDescriptor, SetUpgradeModeRequestParameters>
{
	internal SetUpgradeModeRequestDescriptor(Action<SetUpgradeModeRequestDescriptor> configure) => configure.Invoke(this);

	public SetUpgradeModeRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningSetUpgradeMode;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.set_upgrade_mode";

	public SetUpgradeModeRequestDescriptor Enabled(bool? enabled = true) => Qs("enabled", enabled);
	public SetUpgradeModeRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}