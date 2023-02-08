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
public sealed partial class IcuTokenizer : ITokenFilter, ITokenizer
{
	[JsonInclude, JsonPropertyName("rule_files")]
	public string RuleFiles { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "icu_tokenizer";
	[JsonInclude, JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class IcuTokenizerDescriptor : SerializableDescriptor<IcuTokenizerDescriptor>, IBuildableDescriptor<IcuTokenizer>
{
	internal IcuTokenizerDescriptor(Action<IcuTokenizerDescriptor> configure) => configure.Invoke(this);
	public IcuTokenizerDescriptor() : base()
	{
	}

	private string RuleFilesValue { get; set; }

	private string? VersionValue { get; set; }

	public IcuTokenizerDescriptor RuleFiles(string ruleFiles)
	{
		RuleFilesValue = ruleFiles;
		return Self;
	}

	public IcuTokenizerDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("rule_files");
		writer.WriteStringValue(RuleFilesValue);
		writer.WritePropertyName("type");
		writer.WriteStringValue("icu_tokenizer");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	IcuTokenizer IBuildableDescriptor<IcuTokenizer>.Build() => new()
	{ RuleFiles = RuleFilesValue, Version = VersionValue };
}