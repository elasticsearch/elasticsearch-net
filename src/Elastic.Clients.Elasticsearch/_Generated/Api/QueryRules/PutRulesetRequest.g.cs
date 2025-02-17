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

public sealed partial class PutRulesetRequestParameters : RequestParameters
{
}

internal sealed partial class PutRulesetRequestConverter : System.Text.Json.Serialization.JsonConverter<PutRulesetRequest>
{
	private static readonly System.Text.Json.JsonEncodedText PropRules = System.Text.Json.JsonEncodedText.Encode("rules");

	public override PutRulesetRequest Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<ICollection<Elastic.Clients.Elasticsearch.QueryRules.QueryRule>> propRules = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propRules.TryReadProperty(ref reader, options, PropRules, static ICollection<Elastic.Clients.Elasticsearch.QueryRules.QueryRule> (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.QueryRules.QueryRule>(o, null)!))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new PutRulesetRequest
		{
			Rules = propRules.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, PutRulesetRequest value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropRules, value.Rules, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<Elastic.Clients.Elasticsearch.QueryRules.QueryRule> v) => w.WriteSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.QueryRules.QueryRule>(o, v, null));
		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>
/// Create or update a query ruleset.
/// </para>
/// </summary>
[JsonConverter(typeof(PutRulesetRequestConverter))]
public sealed partial class PutRulesetRequest : PlainRequest<PutRulesetRequestParameters>
{
	public PutRulesetRequest(Elastic.Clients.Elasticsearch.Id rulesetId) : base(r => r.Required("ruleset_id", rulesetId))
	{
	}

	[JsonConstructor]
	internal PutRulesetRequest()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.QueryRulesPutRuleset;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "query_rules.put_ruleset";

	/// <summary>
	/// <para>
	/// The unique identifier of the query ruleset to be created or updated
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Id RulesetId { get => P<Elastic.Clients.Elasticsearch.Id>("ruleset_id"); set => PR("ruleset_id", value); }
	public ICollection<Elastic.Clients.Elasticsearch.QueryRules.QueryRule> Rules { get; set; }
}

/// <summary>
/// <para>
/// Create or update a query ruleset.
/// </para>
/// </summary>
public sealed partial class PutRulesetRequestDescriptor : RequestDescriptor<PutRulesetRequestDescriptor, PutRulesetRequestParameters>
{
	internal PutRulesetRequestDescriptor(Action<PutRulesetRequestDescriptor> configure) => configure.Invoke(this);

	public PutRulesetRequestDescriptor(Elastic.Clients.Elasticsearch.Id rulesetId) : base(r => r.Required("ruleset_id", rulesetId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.QueryRulesPutRuleset;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "query_rules.put_ruleset";

	public PutRulesetRequestDescriptor RulesetId(Elastic.Clients.Elasticsearch.Id rulesetId)
	{
		RouteValues.Required("ruleset_id", rulesetId);
		return Self;
	}

	private ICollection<Elastic.Clients.Elasticsearch.QueryRules.QueryRule> RulesValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryRules.QueryRuleDescriptor RulesDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryRules.QueryRuleDescriptor> RulesDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryRules.QueryRuleDescriptor>[] RulesDescriptorActions { get; set; }

	public PutRulesetRequestDescriptor Rules(ICollection<Elastic.Clients.Elasticsearch.QueryRules.QueryRule> rules)
	{
		RulesDescriptor = null;
		RulesDescriptorAction = null;
		RulesDescriptorActions = null;
		RulesValue = rules;
		return Self;
	}

	public PutRulesetRequestDescriptor Rules(Elastic.Clients.Elasticsearch.QueryRules.QueryRuleDescriptor descriptor)
	{
		RulesValue = null;
		RulesDescriptorAction = null;
		RulesDescriptorActions = null;
		RulesDescriptor = descriptor;
		return Self;
	}

	public PutRulesetRequestDescriptor Rules(Action<Elastic.Clients.Elasticsearch.QueryRules.QueryRuleDescriptor> configure)
	{
		RulesValue = null;
		RulesDescriptor = null;
		RulesDescriptorActions = null;
		RulesDescriptorAction = configure;
		return Self;
	}

	public PutRulesetRequestDescriptor Rules(params Action<Elastic.Clients.Elasticsearch.QueryRules.QueryRuleDescriptor>[] configure)
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
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryRules.QueryRuleDescriptor(RulesDescriptorAction), options);
		}
		else if (RulesDescriptorActions is not null)
		{
			writer.WritePropertyName("rules");
			if (RulesDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in RulesDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryRules.QueryRuleDescriptor(action), options);
			}

			if (RulesDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else
		{
			writer.WritePropertyName("rules");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryRules.QueryRule>(RulesValue, writer, options);
		}

		writer.WriteEndObject();
	}
}