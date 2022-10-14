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
public sealed partial class IcuTransformTokenFilter : ITokenFilterDefinition
{
	[JsonInclude]
	[JsonPropertyName("dir")]
	public Elastic.Clients.Elasticsearch.Analysis.IcuTransformDirection? Dir { get; set; }

	[JsonInclude]
	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "icu_transform";
	[JsonInclude]
	[JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class IcuTransformTokenFilterDescriptor : SerializableDescriptor<IcuTransformTokenFilterDescriptor>, IBuildableDescriptor<IcuTransformTokenFilter>
{
	internal IcuTransformTokenFilterDescriptor(Action<IcuTransformTokenFilterDescriptor> configure) => configure.Invoke(this);
	public IcuTransformTokenFilterDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Analysis.IcuTransformDirection? DirValue { get; set; }

	private string IdValue { get; set; }

	private string? VersionValue { get; set; }

	public IcuTransformTokenFilterDescriptor Dir(Elastic.Clients.Elasticsearch.Analysis.IcuTransformDirection? dir)
	{
		DirValue = dir;
		return Self;
	}

	public IcuTransformTokenFilterDescriptor Id(string id)
	{
		IdValue = id;
		return Self;
	}

	public IcuTransformTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DirValue is not null)
		{
			writer.WritePropertyName("dir");
			JsonSerializer.Serialize(writer, DirValue, options);
		}

		writer.WritePropertyName("id");
		writer.WriteStringValue(IdValue);
		writer.WritePropertyName("type");
		writer.WriteStringValue("icu_transform");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	IcuTransformTokenFilter IBuildableDescriptor<IcuTransformTokenFilter>.Build() => new()
	{ Dir = DirValue, Id = IdValue, Version = VersionValue };
}