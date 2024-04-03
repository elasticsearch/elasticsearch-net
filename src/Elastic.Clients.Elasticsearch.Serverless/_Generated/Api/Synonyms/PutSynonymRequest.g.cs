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

namespace Elastic.Clients.Elasticsearch.Serverless.Synonyms;

public sealed partial class PutSynonymRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Creates or updates a synonym set.</para>
/// </summary>
public sealed partial class PutSynonymRequest : PlainRequest<PutSynonymRequestParameters>
{
	public PutSynonymRequest(Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SynonymsPutSynonym;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "synonyms.put_synonym";

	/// <summary>
	/// <para>The synonym set information to update</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("synonyms_set")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRule> SynonymsSet { get; set; }
}

/// <summary>
/// <para>Creates or updates a synonym set.</para>
/// </summary>
public sealed partial class PutSynonymRequestDescriptor<TDocument> : RequestDescriptor<PutSynonymRequestDescriptor<TDocument>, PutSynonymRequestParameters>
{
	internal PutSynonymRequestDescriptor(Action<PutSynonymRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public PutSynonymRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SynonymsPutSynonym;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "synonyms.put_synonym";

	public PutSynonymRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRule> SynonymsSetValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRuleDescriptor SynonymsSetDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRuleDescriptor> SynonymsSetDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRuleDescriptor>[] SynonymsSetDescriptorActions { get; set; }

	/// <summary>
	/// <para>The synonym set information to update</para>
	/// </summary>
	public PutSynonymRequestDescriptor<TDocument> SynonymsSet(ICollection<Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRule> synonymsSet)
	{
		SynonymsSetDescriptor = null;
		SynonymsSetDescriptorAction = null;
		SynonymsSetDescriptorActions = null;
		SynonymsSetValue = synonymsSet;
		return Self;
	}

	public PutSynonymRequestDescriptor<TDocument> SynonymsSet(Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRuleDescriptor descriptor)
	{
		SynonymsSetValue = null;
		SynonymsSetDescriptorAction = null;
		SynonymsSetDescriptorActions = null;
		SynonymsSetDescriptor = descriptor;
		return Self;
	}

	public PutSynonymRequestDescriptor<TDocument> SynonymsSet(Action<Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRuleDescriptor> configure)
	{
		SynonymsSetValue = null;
		SynonymsSetDescriptor = null;
		SynonymsSetDescriptorActions = null;
		SynonymsSetDescriptorAction = configure;
		return Self;
	}

	public PutSynonymRequestDescriptor<TDocument> SynonymsSet(params Action<Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRuleDescriptor>[] configure)
	{
		SynonymsSetValue = null;
		SynonymsSetDescriptor = null;
		SynonymsSetDescriptorAction = null;
		SynonymsSetDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (SynonymsSetDescriptor is not null)
		{
			writer.WritePropertyName("synonyms_set");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, SynonymsSetDescriptor, options);
			writer.WriteEndArray();
		}
		else if (SynonymsSetDescriptorAction is not null)
		{
			writer.WritePropertyName("synonyms_set");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRuleDescriptor(SynonymsSetDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (SynonymsSetDescriptorActions is not null)
		{
			writer.WritePropertyName("synonyms_set");
			writer.WriteStartArray();
			foreach (var action in SynonymsSetDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRuleDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else
		{
			writer.WritePropertyName("synonyms_set");
			JsonSerializer.Serialize(writer, SynonymsSetValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Creates or updates a synonym set.</para>
/// </summary>
public sealed partial class PutSynonymRequestDescriptor : RequestDescriptor<PutSynonymRequestDescriptor, PutSynonymRequestParameters>
{
	internal PutSynonymRequestDescriptor(Action<PutSynonymRequestDescriptor> configure) => configure.Invoke(this);

	public PutSynonymRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SynonymsPutSynonym;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "synonyms.put_synonym";

	public PutSynonymRequestDescriptor Id(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRule> SynonymsSetValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRuleDescriptor SynonymsSetDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRuleDescriptor> SynonymsSetDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRuleDescriptor>[] SynonymsSetDescriptorActions { get; set; }

	/// <summary>
	/// <para>The synonym set information to update</para>
	/// </summary>
	public PutSynonymRequestDescriptor SynonymsSet(ICollection<Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRule> synonymsSet)
	{
		SynonymsSetDescriptor = null;
		SynonymsSetDescriptorAction = null;
		SynonymsSetDescriptorActions = null;
		SynonymsSetValue = synonymsSet;
		return Self;
	}

	public PutSynonymRequestDescriptor SynonymsSet(Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRuleDescriptor descriptor)
	{
		SynonymsSetValue = null;
		SynonymsSetDescriptorAction = null;
		SynonymsSetDescriptorActions = null;
		SynonymsSetDescriptor = descriptor;
		return Self;
	}

	public PutSynonymRequestDescriptor SynonymsSet(Action<Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRuleDescriptor> configure)
	{
		SynonymsSetValue = null;
		SynonymsSetDescriptor = null;
		SynonymsSetDescriptorActions = null;
		SynonymsSetDescriptorAction = configure;
		return Self;
	}

	public PutSynonymRequestDescriptor SynonymsSet(params Action<Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRuleDescriptor>[] configure)
	{
		SynonymsSetValue = null;
		SynonymsSetDescriptor = null;
		SynonymsSetDescriptorAction = null;
		SynonymsSetDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (SynonymsSetDescriptor is not null)
		{
			writer.WritePropertyName("synonyms_set");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, SynonymsSetDescriptor, options);
			writer.WriteEndArray();
		}
		else if (SynonymsSetDescriptorAction is not null)
		{
			writer.WritePropertyName("synonyms_set");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRuleDescriptor(SynonymsSetDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (SynonymsSetDescriptorActions is not null)
		{
			writer.WritePropertyName("synonyms_set");
			writer.WriteStartArray();
			foreach (var action in SynonymsSetDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Synonyms.SynonymRuleDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else
		{
			writer.WritePropertyName("synonyms_set");
			JsonSerializer.Serialize(writer, SynonymsSetValue, options);
		}

		writer.WriteEndObject();
	}
}