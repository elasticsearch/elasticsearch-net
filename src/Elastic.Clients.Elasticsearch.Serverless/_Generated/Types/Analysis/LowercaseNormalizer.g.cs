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

public sealed partial class LowercaseNormalizer : INormalizer
{
	[JsonInclude, JsonPropertyName("type")]
	public string Type => "lowercase";
}

public sealed partial class LowercaseNormalizerDescriptor : SerializableDescriptor<LowercaseNormalizerDescriptor>, IBuildableDescriptor<LowercaseNormalizer>
{
	internal LowercaseNormalizerDescriptor(Action<LowercaseNormalizerDescriptor> configure) => configure.Invoke(this);

	public LowercaseNormalizerDescriptor() : base()
	{
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("type");
		writer.WriteStringValue("lowercase");
		writer.WriteEndObject();
	}

	LowercaseNormalizer IBuildableDescriptor<LowercaseNormalizer>.Build() => new()
	{
	};
}