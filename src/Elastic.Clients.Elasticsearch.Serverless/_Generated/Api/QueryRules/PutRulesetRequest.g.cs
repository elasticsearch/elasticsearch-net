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

public sealed partial class PutRulesetRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Create or update a query ruleset.
/// </para>
/// </summary>
public sealed partial class PutRulesetRequest : PlainRequest<PutRulesetRequestParameters>
{
	public PutRulesetRequest(Elastic.Clients.Elasticsearch.Serverless.Id rulesetId) : base(r => r.Required("ruleset_id", rulesetId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.QueryRulesPutRuleset;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "query_rules.put_ruleset";

	[JsonInclude, JsonPropertyName("rules")]
	[SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.Serverless.QueryRules.QueryRule))]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.QueryRules.QueryRule> Rules { get; set; }
}

/// <summary>
/// <para>
/// Create or update a query ruleset.
/// </para>
/// </summary>
public sealed partial class PutRulesetRequestDescriptor : RequestDescriptor<PutRulesetRequestDescriptor, PutRulesetRequestParameters>
{
	internal PutRulesetRequestDescriptor(Action<PutRulesetRequestDescriptor> configure) => configure.Invoke(this);

	public PutRulesetRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id rulesetId) : base(r => r.Required("ruleset_id", rulesetId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.QueryRulesPutRuleset;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "query_rules.put_ruleset";

	public PutRulesetRequestDescriptor RulesetId(Elastic.Clients.Elasticsearch.Serverless.Id rulesetId)
	{
		RouteValues.Required("ruleset_id", rulesetId);
		return Self;
	}

	private ICollection<Elastic.Clients.Elasticsearch.Serverless.QueryRules.QueryRule> RulesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryRules.QueryRuleDescriptor RulesDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryRules.QueryRuleDescriptor> RulesDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryRules.QueryRuleDescriptor>[] RulesDescriptorActions { get; set; }

	public PutRulesetRequestDescriptor Rules(ICollection<Elastic.Clients.Elasticsearch.Serverless.QueryRules.QueryRule> rules)
	{
		RulesDescriptor = null;
		RulesDescriptorAction = null;
		RulesDescriptorActions = null;
		RulesValue = rules;
		return Self;
	}

	public PutRulesetRequestDescriptor Rules(Elastic.Clients.Elasticsearch.Serverless.QueryRules.QueryRuleDescriptor descriptor)
	{
		RulesValue = null;
		RulesDescriptorAction = null;
		RulesDescriptorActions = null;
		RulesDescriptor = descriptor;
		return Self;
	}

	public PutRulesetRequestDescriptor Rules(Action<Elastic.Clients.Elasticsearch.Serverless.QueryRules.QueryRuleDescriptor> configure)
	{
		RulesValue = null;
		RulesDescriptor = null;
		RulesDescriptorActions = null;
		RulesDescriptorAction = configure;
		return Self;
	}

	public PutRulesetRequestDescriptor Rules(params Action<Elastic.Clients.Elasticsearch.Serverless.QueryRules.QueryRuleDescriptor>[] configure)
	{
		RulesValue = null;
		RulesDescriptor = null;
		RulesDescriptorAction = null;
		RulesDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (RulesDescriptor is not null)
		{
			writer.WritePropertyName("rules");
			JsonSerializer.Serialize(writer, RulesDescriptor, options);
		}
		else if (RulesDescriptorAction is not null)
		{
			writer.WritePropertyName("rules");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryRules.QueryRuleDescriptor(RulesDescriptorAction), options);
		}
		else if (RulesDescriptorActions is not null)
		{
			writer.WritePropertyName("rules");
			if (RulesDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in RulesDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryRules.QueryRuleDescriptor(action), options);
			}

			if (RulesDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else
		{
			writer.WritePropertyName("rules");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.Serverless.QueryRules.QueryRule>(RulesValue, writer, options);
		}

		writer.WriteEndObject();
	}
}