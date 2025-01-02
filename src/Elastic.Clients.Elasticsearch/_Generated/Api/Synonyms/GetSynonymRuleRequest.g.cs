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

namespace Elastic.Clients.Elasticsearch.Synonyms;

public sealed partial class GetSynonymRuleRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Get a synonym rule.
/// Get a synonym rule from a synonym set.
/// </para>
/// </summary>
public sealed partial class GetSynonymRuleRequest : PlainRequest<GetSynonymRuleRequestParameters>
{
	public GetSynonymRuleRequest(Elastic.Clients.Elasticsearch.Id setId, Elastic.Clients.Elasticsearch.Id ruleId) : base(r => r.Required("set_id", setId).Required("rule_id", ruleId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SynonymsGetSynonymRule;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "synonyms.get_synonym_rule";
}

/// <summary>
/// <para>
/// Get a synonym rule.
/// Get a synonym rule from a synonym set.
/// </para>
/// </summary>
public sealed partial class GetSynonymRuleRequestDescriptor : RequestDescriptor<GetSynonymRuleRequestDescriptor, GetSynonymRuleRequestParameters>
{
	internal GetSynonymRuleRequestDescriptor(Action<GetSynonymRuleRequestDescriptor> configure) => configure.Invoke(this);

	public GetSynonymRuleRequestDescriptor(Elastic.Clients.Elasticsearch.Id setId, Elastic.Clients.Elasticsearch.Id ruleId) : base(r => r.Required("set_id", setId).Required("rule_id", ruleId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SynonymsGetSynonymRule;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "synonyms.get_synonym_rule";

	public GetSynonymRuleRequestDescriptor RuleId(Elastic.Clients.Elasticsearch.Id ruleId)
	{
		RouteValues.Required("rule_id", ruleId);
		return Self;
	}

	public GetSynonymRuleRequestDescriptor SetId(Elastic.Clients.Elasticsearch.Id setId)
	{
		RouteValues.Required("set_id", setId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}