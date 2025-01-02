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

namespace Elastic.Clients.Elasticsearch.TransformManagement;

public sealed partial class UpgradeTransformsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// When true, the request checks for updates but does not run them.
	/// </para>
	/// </summary>
	public bool? DryRun { get => Q<bool?>("dry_run"); set => Q("dry_run", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a response. If no response is received before the timeout expires, the request fails and
	/// returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Upgrade all transforms.
/// Transforms are compatible across minor versions and between supported major versions.
/// However, over time, the format of transform configuration information may change.
/// This API identifies transforms that have a legacy configuration format and upgrades them to the latest version.
/// It also cleans up the internal data structures that store the transform state and checkpoints.
/// The upgrade does not affect the source and destination indices.
/// The upgrade also does not affect the roles that transforms use when Elasticsearch security features are enabled; the role used to read source data and write to the destination index remains unchanged.
/// </para>
/// <para>
/// If a transform upgrade step fails, the upgrade stops and an error is returned about the underlying issue.
/// Resolve the issue then re-run the process again.
/// A summary is returned when the upgrade is finished.
/// </para>
/// <para>
/// To ensure continuous transforms remain running during a major version upgrade of the cluster – for example, from 7.16 to 8.0 – it is recommended to upgrade transforms before upgrading the cluster.
/// You may want to perform a recent cluster backup prior to the upgrade.
/// </para>
/// </summary>
public sealed partial class UpgradeTransformsRequest : PlainRequest<UpgradeTransformsRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.TransformManagementUpgradeTransforms;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "transform.upgrade_transforms";

	/// <summary>
	/// <para>
	/// When true, the request checks for updates but does not run them.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? DryRun { get => Q<bool?>("dry_run"); set => Q("dry_run", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a response. If no response is received before the timeout expires, the request fails and
	/// returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Upgrade all transforms.
/// Transforms are compatible across minor versions and between supported major versions.
/// However, over time, the format of transform configuration information may change.
/// This API identifies transforms that have a legacy configuration format and upgrades them to the latest version.
/// It also cleans up the internal data structures that store the transform state and checkpoints.
/// The upgrade does not affect the source and destination indices.
/// The upgrade also does not affect the roles that transforms use when Elasticsearch security features are enabled; the role used to read source data and write to the destination index remains unchanged.
/// </para>
/// <para>
/// If a transform upgrade step fails, the upgrade stops and an error is returned about the underlying issue.
/// Resolve the issue then re-run the process again.
/// A summary is returned when the upgrade is finished.
/// </para>
/// <para>
/// To ensure continuous transforms remain running during a major version upgrade of the cluster – for example, from 7.16 to 8.0 – it is recommended to upgrade transforms before upgrading the cluster.
/// You may want to perform a recent cluster backup prior to the upgrade.
/// </para>
/// </summary>
public sealed partial class UpgradeTransformsRequestDescriptor : RequestDescriptor<UpgradeTransformsRequestDescriptor, UpgradeTransformsRequestParameters>
{
	internal UpgradeTransformsRequestDescriptor(Action<UpgradeTransformsRequestDescriptor> configure) => configure.Invoke(this);

	public UpgradeTransformsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.TransformManagementUpgradeTransforms;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "transform.upgrade_transforms";

	public UpgradeTransformsRequestDescriptor DryRun(bool? dryRun = true) => Qs("dry_run", dryRun);
	public UpgradeTransformsRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}