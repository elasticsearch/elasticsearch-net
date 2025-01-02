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

namespace Elastic.Clients.Elasticsearch.QueryRules;

public sealed partial class PutRuleRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Create or update a query rule.
/// Create or update a query rule within a query ruleset.
/// </para>
/// </summary>
public sealed partial class PutRuleRequest : PlainRequest<PutRuleRequestParameters>
{
	public PutRuleRequest(Elastic.Clients.Elasticsearch.Id rulesetId, Elastic.Clients.Elasticsearch.Id ruleId) : base(r => r.Required("ruleset_id", rulesetId).Required("rule_id", ruleId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.QueryRulesPutRule;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "query_rules.put_rule";

	[JsonInclude, JsonPropertyName("actions")]
	public Elastic.Clients.Elasticsearch.QueryRules.QueryRuleActions Actions { get; set; }
	[JsonInclude, JsonPropertyName("criteria")]
	[SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.QueryRules.QueryRuleCriteria))]
	public ICollection<Elastic.Clients.Elasticsearch.QueryRules.QueryRuleCriteria> Criteria { get; set; }
	[JsonInclude, JsonPropertyName("priority")]
	public int? Priority { get; set; }
	[JsonInclude, JsonPropertyName("type")]
	public Elastic.Clients.Elasticsearch.QueryRules.QueryRuleType Type { get; set; }
}

/// <summary>
/// <para>
/// Create or update a query rule.
/// Create or update a query rule within a query ruleset.
/// </para>
/// </summary>
public sealed partial class PutRuleRequestDescriptor : RequestDescriptor<PutRuleRequestDescriptor, PutRuleRequestParameters>
{
	internal PutRuleRequestDescriptor(Action<PutRuleRequestDescriptor> configure) => configure.Invoke(this);

	public PutRuleRequestDescriptor(Elastic.Clients.Elasticsearch.Id rulesetId, Elastic.Clients.Elasticsearch.Id ruleId) : base(r => r.Required("ruleset_id", rulesetId).Required("rule_id", ruleId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.QueryRulesPutRule;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "query_rules.put_rule";

	public PutRuleRequestDescriptor RuleId(Elastic.Clients.Elasticsearch.Id ruleId)
	{
		RouteValues.Required("rule_id", ruleId);
		return Self;
	}

	public PutRuleRequestDescriptor RulesetId(Elastic.Clients.Elasticsearch.Id rulesetId)
	{
		RouteValues.Required("ruleset_id", rulesetId);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.QueryRules.QueryRuleActions ActionsValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryRules.QueryRuleActionsDescriptor ActionsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryRules.QueryRuleActionsDescriptor> ActionsDescriptorAction { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.QueryRules.QueryRuleCriteria> CriteriaValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryRules.QueryRuleCriteriaDescriptor CriteriaDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryRules.QueryRuleCriteriaDescriptor> CriteriaDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryRules.QueryRuleCriteriaDescriptor>[] CriteriaDescriptorActions { get; set; }
	private int? PriorityValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryRules.QueryRuleType TypeValue { get; set; }

	public PutRuleRequestDescriptor Actions(Elastic.Clients.Elasticsearch.QueryRules.QueryRuleActions actions)
	{
		ActionsDescriptor = null;
		ActionsDescriptorAction = null;
		ActionsValue = actions;
		return Self;
	}

	public PutRuleRequestDescriptor Actions(Elastic.Clients.Elasticsearch.QueryRules.QueryRuleActionsDescriptor descriptor)
	{
		ActionsValue = null;
		ActionsDescriptorAction = null;
		ActionsDescriptor = descriptor;
		return Self;
	}

	public PutRuleRequestDescriptor Actions(Action<Elastic.Clients.Elasticsearch.QueryRules.QueryRuleActionsDescriptor> configure)
	{
		ActionsValue = null;
		ActionsDescriptor = null;
		ActionsDescriptorAction = configure;
		return Self;
	}

	public PutRuleRequestDescriptor Criteria(ICollection<Elastic.Clients.Elasticsearch.QueryRules.QueryRuleCriteria> criteria)
	{
		CriteriaDescriptor = null;
		CriteriaDescriptorAction = null;
		CriteriaDescriptorActions = null;
		CriteriaValue = criteria;
		return Self;
	}

	public PutRuleRequestDescriptor Criteria(Elastic.Clients.Elasticsearch.QueryRules.QueryRuleCriteriaDescriptor descriptor)
	{
		CriteriaValue = null;
		CriteriaDescriptorAction = null;
		CriteriaDescriptorActions = null;
		CriteriaDescriptor = descriptor;
		return Self;
	}

	public PutRuleRequestDescriptor Criteria(Action<Elastic.Clients.Elasticsearch.QueryRules.QueryRuleCriteriaDescriptor> configure)
	{
		CriteriaValue = null;
		CriteriaDescriptor = null;
		CriteriaDescriptorActions = null;
		CriteriaDescriptorAction = configure;
		return Self;
	}

	public PutRuleRequestDescriptor Criteria(params Action<Elastic.Clients.Elasticsearch.QueryRules.QueryRuleCriteriaDescriptor>[] configure)
	{
		CriteriaValue = null;
		CriteriaDescriptor = null;
		CriteriaDescriptorAction = null;
		CriteriaDescriptorActions = configure;
		return Self;
	}

	public PutRuleRequestDescriptor Priority(int? priority)
	{
		PriorityValue = priority;
		return Self;
	}

	public PutRuleRequestDescriptor Type(Elastic.Clients.Elasticsearch.QueryRules.QueryRuleType type)
	{
		TypeValue = type;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ActionsDescriptor is not null)
		{
			writer.WritePropertyName("actions");
			JsonSerializer.Serialize(writer, ActionsDescriptor, options);
		}
		else if (ActionsDescriptorAction is not null)
		{
			writer.WritePropertyName("actions");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryRules.QueryRuleActionsDescriptor(ActionsDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("actions");
			JsonSerializer.Serialize(writer, ActionsValue, options);
		}

		if (CriteriaDescriptor is not null)
		{
			writer.WritePropertyName("criteria");
			JsonSerializer.Serialize(writer, CriteriaDescriptor, options);
		}
		else if (CriteriaDescriptorAction is not null)
		{
			writer.WritePropertyName("criteria");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryRules.QueryRuleCriteriaDescriptor(CriteriaDescriptorAction), options);
		}
		else if (CriteriaDescriptorActions is not null)
		{
			writer.WritePropertyName("criteria");
			if (CriteriaDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in CriteriaDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryRules.QueryRuleCriteriaDescriptor(action), options);
			}

			if (CriteriaDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else
		{
			writer.WritePropertyName("criteria");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryRules.QueryRuleCriteria>(CriteriaValue, writer, options);
		}

		if (PriorityValue.HasValue)
		{
			writer.WritePropertyName("priority");
			writer.WriteNumberValue(PriorityValue.Value);
		}

		writer.WritePropertyName("type");
		JsonSerializer.Serialize(writer, TypeValue, options);
		writer.WriteEndObject();
	}
}