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

public sealed partial class SimpleAnalyzer : IAnalyzer
{
	[JsonInclude, JsonPropertyName("type")]
	public string Type => "simple";

	[JsonInclude, JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class SimpleAnalyzerDescriptor : SerializableDescriptor<SimpleAnalyzerDescriptor>, IBuildableDescriptor<SimpleAnalyzer>
{
	internal SimpleAnalyzerDescriptor(Action<SimpleAnalyzerDescriptor> configure) => configure.Invoke(this);

	public SimpleAnalyzerDescriptor() : base()
	{
	}

	private string? VersionValue { get; set; }

	public SimpleAnalyzerDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("type");
		writer.WriteStringValue("simple");
		if (!string.IsNullOrEmpty(VersionValue))
		{
			writer.WritePropertyName("version");
			writer.WriteStringValue(VersionValue);
		}

		writer.WriteEndObject();
	}

	SimpleAnalyzer IBuildableDescriptor<SimpleAnalyzer>.Build() => new()
	{
		Version = VersionValue
	};
}