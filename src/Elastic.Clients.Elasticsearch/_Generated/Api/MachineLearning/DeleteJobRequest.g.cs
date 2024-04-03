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

public sealed partial class DeleteJobRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Specifies whether annotations that have been added by the<br/>user should be deleted along with any auto-generated annotations when the job is<br/>reset.</para>
	/// </summary>
	public bool? DeleteUserAnnotations { get => Q<bool?>("delete_user_annotations"); set => Q("delete_user_annotations", value); }

	/// <summary>
	/// <para>Use to forcefully delete an opened job; this method is quicker than<br/>closing and deleting the job.</para>
	/// </summary>
	public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }

	/// <summary>
	/// <para>Specifies whether the request should return immediately or wait until the<br/>job deletion completes.</para>
	/// </summary>
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
}

/// <summary>
/// <para>Deletes an anomaly detection job.</para>
/// <para>All job configuration, model state and results are deleted.<br/>It is not currently possible to delete multiple jobs using wildcards or a<br/>comma separated list. If you delete a job that has a datafeed, the request<br/>first tries to delete the datafeed. This behavior is equivalent to calling<br/>the delete datafeed API with the same timeout and force parameters as the<br/>delete job request.</para>
/// </summary>
public sealed partial class DeleteJobRequest : PlainRequest<DeleteJobRequestParameters>
{
	public DeleteJobRequest(Elastic.Clients.Elasticsearch.Id jobId) : base(r => r.Required("job_id", jobId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningDeleteJob;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.delete_job";

	/// <summary>
	/// <para>Specifies whether annotations that have been added by the<br/>user should be deleted along with any auto-generated annotations when the job is<br/>reset.</para>
	/// </summary>
	[JsonIgnore]
	public bool? DeleteUserAnnotations { get => Q<bool?>("delete_user_annotations"); set => Q("delete_user_annotations", value); }

	/// <summary>
	/// <para>Use to forcefully delete an opened job; this method is quicker than<br/>closing and deleting the job.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }

	/// <summary>
	/// <para>Specifies whether the request should return immediately or wait until the<br/>job deletion completes.</para>
	/// </summary>
	[JsonIgnore]
	public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
}

/// <summary>
/// <para>Deletes an anomaly detection job.</para>
/// <para>All job configuration, model state and results are deleted.<br/>It is not currently possible to delete multiple jobs using wildcards or a<br/>comma separated list. If you delete a job that has a datafeed, the request<br/>first tries to delete the datafeed. This behavior is equivalent to calling<br/>the delete datafeed API with the same timeout and force parameters as the<br/>delete job request.</para>
/// </summary>
public sealed partial class DeleteJobRequestDescriptor : RequestDescriptor<DeleteJobRequestDescriptor, DeleteJobRequestParameters>
{
	internal DeleteJobRequestDescriptor(Action<DeleteJobRequestDescriptor> configure) => configure.Invoke(this);

	public DeleteJobRequestDescriptor(Elastic.Clients.Elasticsearch.Id jobId) : base(r => r.Required("job_id", jobId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningDeleteJob;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.delete_job";

	public DeleteJobRequestDescriptor DeleteUserAnnotations(bool? deleteUserAnnotations = true) => Qs("delete_user_annotations", deleteUserAnnotations);
	public DeleteJobRequestDescriptor Force(bool? force = true) => Qs("force", force);
	public DeleteJobRequestDescriptor WaitForCompletion(bool? waitForCompletion = true) => Qs("wait_for_completion", waitForCompletion);

	public DeleteJobRequestDescriptor JobId(Elastic.Clients.Elasticsearch.Id jobId)
	{
		RouteValues.Required("job_id", jobId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}