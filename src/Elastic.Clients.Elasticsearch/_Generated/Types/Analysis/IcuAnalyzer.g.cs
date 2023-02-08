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
public sealed partial class IcuAnalyzer : IAnalyzer
{
	[JsonInclude, JsonPropertyName("method")]
	public Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationType Method { get; set; }

	[JsonInclude, JsonPropertyName("mode")]
	public Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationMode Mode { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "icu_analyzer";
}

public sealed partial class IcuAnalyzerDescriptor : SerializableDescriptor<IcuAnalyzerDescriptor>, IBuildableDescriptor<IcuAnalyzer>
{
	internal IcuAnalyzerDescriptor(Action<IcuAnalyzerDescriptor> configure) => configure.Invoke(this);
	public IcuAnalyzerDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationType MethodValue { get; set; }

	private Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationMode ModeValue { get; set; }

	public IcuAnalyzerDescriptor Method(Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationType method)
	{
		MethodValue = method;
		return Self;
	}

	public IcuAnalyzerDescriptor Mode(Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationMode mode)
	{
		ModeValue = mode;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("method");
		JsonSerializer.Serialize(writer, MethodValue, options);
		writer.WritePropertyName("mode");
		JsonSerializer.Serialize(writer, ModeValue, options);
		writer.WritePropertyName("type");
		writer.WriteStringValue("icu_analyzer");
		writer.WriteEndObject();
	}

	IcuAnalyzer IBuildableDescriptor<IcuAnalyzer>.Build() => new()
	{ Method = MethodValue, Mode = ModeValue };
}