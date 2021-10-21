// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elastic.Transport;

// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Specification.SnapshotLifecycleManagementApi
{
	///<summary>Request options for DeleteSnapshotLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-delete-policy.html</para></summary>
	public class DeleteSnapshotLifecycleRequestParameters : RequestParameters<DeleteSnapshotLifecycleRequestParameters>
	{
	}

	///<summary>Request options for ExecuteSnapshotLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute-lifecycle.html</para></summary>
	public class ExecuteSnapshotLifecycleRequestParameters : RequestParameters<ExecuteSnapshotLifecycleRequestParameters>
	{
	}

	///<summary>Request options for ExecuteRetention <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute-retention.html</para></summary>
	public class ExecuteRetentionRequestParameters : RequestParameters<ExecuteRetentionRequestParameters>
	{
	}

	///<summary>Request options for GetSnapshotLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get-policy.html</para></summary>
	public class GetSnapshotLifecycleRequestParameters : RequestParameters<GetSnapshotLifecycleRequestParameters>
	{
	}

	///<summary>Request options for GetSnapshotLifecycleStats <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/slm-api-get-stats.html</para></summary>
	public class GetSnapshotLifecycleStatsRequestParameters : RequestParameters<GetSnapshotLifecycleStatsRequestParameters>
	{
	}

	///<summary>Request options for GetStatus <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get-status.html</para></summary>
	public class GetSnapshotLifecycleManagementStatusRequestParameters : RequestParameters<GetSnapshotLifecycleManagementStatusRequestParameters>
	{
	}

	///<summary>Request options for PutSnapshotLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-put-policy.html</para></summary>
	public class PutSnapshotLifecycleRequestParameters : RequestParameters<PutSnapshotLifecycleRequestParameters>
	{
	}

	///<summary>Request options for Start <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-start.html</para></summary>
	public class StartSnapshotLifecycleManagementRequestParameters : RequestParameters<StartSnapshotLifecycleManagementRequestParameters>
	{
	}

	///<summary>Request options for Stop <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-stop.html</para></summary>
	public class StopSnapshotLifecycleManagementRequestParameters : RequestParameters<StopSnapshotLifecycleManagementRequestParameters>
	{
	}
}