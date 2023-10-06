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
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Analysis;

public sealed partial class PredicateTokenFilter : ITokenFilter
{
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Serverless.Script Script { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "predicate_token_filter";

	[JsonInclude, JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class PredicateTokenFilterDescriptor : SerializableDescriptor<PredicateTokenFilterDescriptor>, IBuildableDescriptor<PredicateTokenFilter>
{
	internal PredicateTokenFilterDescriptor(Action<PredicateTokenFilterDescriptor> configure) => configure.Invoke(this);

	public PredicateTokenFilterDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Script ScriptValue { get; set; }
	private string? VersionValue { get; set; }

	public PredicateTokenFilterDescriptor Script(Elastic.Clients.Elasticsearch.Serverless.Script script)
	{
		ScriptValue = script;
		return Self;
	}

	public PredicateTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("script");
		JsonSerializer.Serialize(writer, ScriptValue, options);
		writer.WritePropertyName("type");
		writer.WriteStringValue("predicate_token_filter");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	PredicateTokenFilter IBuildableDescriptor<PredicateTokenFilter>.Build() => new()
	{
		Script = ScriptValue,
		Version = VersionValue
	};
}