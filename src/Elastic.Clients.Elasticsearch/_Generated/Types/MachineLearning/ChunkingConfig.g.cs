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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class ChunkingConfig
{
	/// <summary>
	/// <para>If the mode is `auto`, the chunk size is dynamically calculated;<br/>this is the recommended value when the datafeed does not use aggregations.<br/>If the mode is `manual`, chunking is applied according to the specified `time_span`;<br/>use this mode when the datafeed uses aggregations. If the mode is `off`, no chunking is applied.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("mode")]
	public Elastic.Clients.Elasticsearch.MachineLearning.ChunkingMode Mode { get; set; }

	/// <summary>
	/// <para>The time span that each search will be querying. This setting is applicable only when the `mode` is set to `manual`.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("time_span")]
	public Elastic.Clients.Elasticsearch.Duration? TimeSpan { get; set; }
}

public sealed partial class ChunkingConfigDescriptor : SerializableDescriptor<ChunkingConfigDescriptor>
{
	internal ChunkingConfigDescriptor(Action<ChunkingConfigDescriptor> configure) => configure.Invoke(this);

	public ChunkingConfigDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.MachineLearning.ChunkingMode ModeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Duration? TimeSpanValue { get; set; }

	/// <summary>
	/// <para>If the mode is `auto`, the chunk size is dynamically calculated;<br/>this is the recommended value when the datafeed does not use aggregations.<br/>If the mode is `manual`, chunking is applied according to the specified `time_span`;<br/>use this mode when the datafeed uses aggregations. If the mode is `off`, no chunking is applied.</para>
	/// </summary>
	public ChunkingConfigDescriptor Mode(Elastic.Clients.Elasticsearch.MachineLearning.ChunkingMode mode)
	{
		ModeValue = mode;
		return Self;
	}

	/// <summary>
	/// <para>The time span that each search will be querying. This setting is applicable only when the `mode` is set to `manual`.</para>
	/// </summary>
	public ChunkingConfigDescriptor TimeSpan(Elastic.Clients.Elasticsearch.Duration? timeSpan)
	{
		TimeSpanValue = timeSpan;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("mode");
		JsonSerializer.Serialize(writer, ModeValue, options);
		if (TimeSpanValue is not null)
		{
			writer.WritePropertyName("time_span");
			JsonSerializer.Serialize(writer, TimeSpanValue, options);
		}

		writer.WriteEndObject();
	}
}