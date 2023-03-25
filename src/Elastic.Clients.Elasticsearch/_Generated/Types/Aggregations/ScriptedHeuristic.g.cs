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
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Aggregations;

public sealed partial class ScriptedHeuristic
{
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Script Script { get; set; }
}

public sealed partial class ScriptedHeuristicDescriptor : SerializableDescriptor<ScriptedHeuristicDescriptor>
{
	internal ScriptedHeuristicDescriptor(Action<ScriptedHeuristicDescriptor> configure) => configure.Invoke(this);

	public ScriptedHeuristicDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Script ScriptValue { get; set; }

	public ScriptedHeuristicDescriptor Script(Elastic.Clients.Elasticsearch.Script script)
	{
		ScriptValue = script;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("script");
		JsonSerializer.Serialize(writer, ScriptValue, options);
		writer.WriteEndObject();
	}
}