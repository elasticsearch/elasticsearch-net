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
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.QueryRules;

public sealed partial class GetRuleRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Get a query rule.
/// Get details about a query rule within a query ruleset.
/// </para>
/// </summary>
public sealed partial class GetRuleRequest : PlainRequest<GetRuleRequestParameters>
{
	public GetRuleRequest(Elastic.Clients.Elasticsearch.Serverless.Id rulesetId, Elastic.Clients.Elasticsearch.Serverless.Id ruleId) : base(r => r.Required("ruleset_id", rulesetId).Required("rule_id", ruleId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.QueryRulesGetRule;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "query_rules.get_rule";
}

/// <summary>
/// <para>
/// Get a query rule.
/// Get details about a query rule within a query ruleset.
/// </para>
/// </summary>
public sealed partial class GetRuleRequestDescriptor : RequestDescriptor<GetRuleRequestDescriptor, GetRuleRequestParameters>
{
	internal GetRuleRequestDescriptor(Action<GetRuleRequestDescriptor> configure) => configure.Invoke(this);

	public GetRuleRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id rulesetId, Elastic.Clients.Elasticsearch.Serverless.Id ruleId) : base(r => r.Required("ruleset_id", rulesetId).Required("rule_id", ruleId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.QueryRulesGetRule;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "query_rules.get_rule";

	public GetRuleRequestDescriptor RuleId(Elastic.Clients.Elasticsearch.Serverless.Id ruleId)
	{
		RouteValues.Required("rule_id", ruleId);
		return Self;
	}

	public GetRuleRequestDescriptor RulesetId(Elastic.Clients.Elasticsearch.Serverless.Id rulesetId)
	{
		RouteValues.Required("ruleset_id", rulesetId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}