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

namespace Elastic.Clients.Elasticsearch.Serverless;

public sealed partial class PutScriptRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Period to wait for a connection to the master node.<br/>If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>Period to wait for a response.<br/>If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>Create or update a script or search template.<br/>Creates or updates a stored script or search template.</para>
/// </summary>
public sealed partial class PutScriptRequest : PlainRequest<PutScriptRequestParameters>
{
	public PutScriptRequest(Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("id", id))
	{
	}

	public PutScriptRequest(Elastic.Clients.Elasticsearch.Serverless.Id id, Elastic.Clients.Elasticsearch.Serverless.Name? context) : base(r => r.Required("id", id).Optional("context", context))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespacePutScript;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "put_script";

	/// <summary>
	/// <para>Period to wait for a connection to the master node.<br/>If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	/// <summary>
	/// <para>Period to wait for a response.<br/>If no response is received before the timeout expires, the request fails and returns an error.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>Contains the script or search template, its parameters, and its language.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Serverless.StoredScript Script { get; set; }
}

/// <summary>
/// <para>Create or update a script or search template.<br/>Creates or updates a stored script or search template.</para>
/// </summary>
public sealed partial class PutScriptRequestDescriptor<TDocument> : RequestDescriptor<PutScriptRequestDescriptor<TDocument>, PutScriptRequestParameters>
{
	internal PutScriptRequestDescriptor(Action<PutScriptRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public PutScriptRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id id, Elastic.Clients.Elasticsearch.Serverless.Name? context) : base(r => r.Required("id", id).Optional("context", context))
	{
	}

	public PutScriptRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespacePutScript;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "put_script";

	public PutScriptRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public PutScriptRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout) => Qs("timeout", timeout);

	public PutScriptRequestDescriptor<TDocument> Context(Elastic.Clients.Elasticsearch.Serverless.Name? context)
	{
		RouteValues.Optional("context", context);
		return Self;
	}

	public PutScriptRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Serverless.StoredScript ScriptValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.StoredScriptDescriptor ScriptDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.StoredScriptDescriptor> ScriptDescriptorAction { get; set; }

	/// <summary>
	/// <para>Contains the script or search template, its parameters, and its language.</para>
	/// </summary>
	public PutScriptRequestDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Serverless.StoredScript script)
	{
		ScriptDescriptor = null;
		ScriptDescriptorAction = null;
		ScriptValue = script;
		return Self;
	}

	public PutScriptRequestDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Serverless.StoredScriptDescriptor descriptor)
	{
		ScriptValue = null;
		ScriptDescriptorAction = null;
		ScriptDescriptor = descriptor;
		return Self;
	}

	public PutScriptRequestDescriptor<TDocument> Script(Action<Elastic.Clients.Elasticsearch.Serverless.StoredScriptDescriptor> configure)
	{
		ScriptValue = null;
		ScriptDescriptor = null;
		ScriptDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ScriptDescriptor is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptDescriptor, options);
		}
		else if (ScriptDescriptorAction is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.StoredScriptDescriptor(ScriptDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Create or update a script or search template.<br/>Creates or updates a stored script or search template.</para>
/// </summary>
public sealed partial class PutScriptRequestDescriptor : RequestDescriptor<PutScriptRequestDescriptor, PutScriptRequestParameters>
{
	internal PutScriptRequestDescriptor(Action<PutScriptRequestDescriptor> configure) => configure.Invoke(this);

	public PutScriptRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id id, Elastic.Clients.Elasticsearch.Serverless.Name? context) : base(r => r.Required("id", id).Optional("context", context))
	{
	}

	public PutScriptRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespacePutScript;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "put_script";

	public PutScriptRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public PutScriptRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout) => Qs("timeout", timeout);

	public PutScriptRequestDescriptor Context(Elastic.Clients.Elasticsearch.Serverless.Name? context)
	{
		RouteValues.Optional("context", context);
		return Self;
	}

	public PutScriptRequestDescriptor Id(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.Serverless.StoredScript ScriptValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.StoredScriptDescriptor ScriptDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.StoredScriptDescriptor> ScriptDescriptorAction { get; set; }

	/// <summary>
	/// <para>Contains the script or search template, its parameters, and its language.</para>
	/// </summary>
	public PutScriptRequestDescriptor Script(Elastic.Clients.Elasticsearch.Serverless.StoredScript script)
	{
		ScriptDescriptor = null;
		ScriptDescriptorAction = null;
		ScriptValue = script;
		return Self;
	}

	public PutScriptRequestDescriptor Script(Elastic.Clients.Elasticsearch.Serverless.StoredScriptDescriptor descriptor)
	{
		ScriptValue = null;
		ScriptDescriptorAction = null;
		ScriptDescriptor = descriptor;
		return Self;
	}

	public PutScriptRequestDescriptor Script(Action<Elastic.Clients.Elasticsearch.Serverless.StoredScriptDescriptor> configure)
	{
		ScriptValue = null;
		ScriptDescriptor = null;
		ScriptDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ScriptDescriptor is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptDescriptor, options);
		}
		else if (ScriptDescriptorAction is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.StoredScriptDescriptor(ScriptDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		writer.WriteEndObject();
	}
}