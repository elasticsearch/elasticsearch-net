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
public sealed partial class IcuNormalizationCharFilter : ICharFilter
{
	[JsonInclude, JsonPropertyName("mode")]
	public Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationMode? Mode { get; set; }

	[JsonInclude, JsonPropertyName("name")]
	public Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationType? Name { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "icu_normalizer";
	[JsonInclude, JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class IcuNormalizationCharFilterDescriptor : SerializableDescriptor<IcuNormalizationCharFilterDescriptor>, IBuildableDescriptor<IcuNormalizationCharFilter>
{
	internal IcuNormalizationCharFilterDescriptor(Action<IcuNormalizationCharFilterDescriptor> configure) => configure.Invoke(this);
	public IcuNormalizationCharFilterDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationMode? ModeValue { get; set; }

	private Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationType? NameValue { get; set; }

	private string? VersionValue { get; set; }

	public IcuNormalizationCharFilterDescriptor Mode(Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationMode? mode)
	{
		ModeValue = mode;
		return Self;
	}

	public IcuNormalizationCharFilterDescriptor Name(Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationType? name)
	{
		NameValue = name;
		return Self;
	}

	public IcuNormalizationCharFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ModeValue is not null)
		{
			writer.WritePropertyName("mode");
			JsonSerializer.Serialize(writer, ModeValue, options);
		}

		if (NameValue is not null)
		{
			writer.WritePropertyName("name");
			JsonSerializer.Serialize(writer, NameValue, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("icu_normalizer");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	IcuNormalizationCharFilter IBuildableDescriptor<IcuNormalizationCharFilter>.Build() => new()
	{ Mode = ModeValue, Name = NameValue, Version = VersionValue };
}