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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Analysis;
public sealed partial class ConditionTokenFilter : ITokenFilterDefinition
{
	[JsonInclude]
	[JsonPropertyName("filter")]
	public ICollection<string> Filter { get; set; }

	[JsonInclude]
	[JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Script Script { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "condition";
	[JsonInclude]
	[JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class ConditionTokenFilterDescriptor : SerializableDescriptor<ConditionTokenFilterDescriptor>, IBuildableDescriptor<ConditionTokenFilter>
{
	internal ConditionTokenFilterDescriptor(Action<ConditionTokenFilterDescriptor> configure) => configure.Invoke(this);
	public ConditionTokenFilterDescriptor() : base()
	{
	}

	private ICollection<string> FilterValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script ScriptValue { get; set; }

	private string? VersionValue { get; set; }

	public ConditionTokenFilterDescriptor Filter(ICollection<string> filter)
	{
		FilterValue = filter;
		return Self;
	}

	public ConditionTokenFilterDescriptor Script(Elastic.Clients.Elasticsearch.Script script)
	{
		ScriptValue = script;
		return Self;
	}

	public ConditionTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("filter");
		JsonSerializer.Serialize(writer, FilterValue, options);
		writer.WritePropertyName("script");
		JsonSerializer.Serialize(writer, ScriptValue, options);
		writer.WritePropertyName("type");
		writer.WriteStringValue("condition");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	ConditionTokenFilter IBuildableDescriptor<ConditionTokenFilter>.Build() => new()
	{ Filter = FilterValue, Script = ScriptValue, Version = VersionValue };
}