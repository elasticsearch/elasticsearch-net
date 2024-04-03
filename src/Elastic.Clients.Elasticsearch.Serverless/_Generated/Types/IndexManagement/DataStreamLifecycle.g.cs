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

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

/// <summary>
/// <para>Data lifecycle denotes that a data stream is managed by the data stream lifecycle and contains the configuration.</para>
/// </summary>
public sealed partial class DataStreamLifecycle
{
	[JsonInclude, JsonPropertyName("data_retention")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? DataRetention { get; set; }
	[JsonInclude, JsonPropertyName("downsampling")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamLifecycleDownsampling? Downsampling { get; set; }
}

/// <summary>
/// <para>Data lifecycle denotes that a data stream is managed by the data stream lifecycle and contains the configuration.</para>
/// </summary>
public sealed partial class DataStreamLifecycleDescriptor : SerializableDescriptor<DataStreamLifecycleDescriptor>
{
	internal DataStreamLifecycleDescriptor(Action<DataStreamLifecycleDescriptor> configure) => configure.Invoke(this);

	public DataStreamLifecycleDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Duration? DataRetentionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamLifecycleDownsampling? DownsamplingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamLifecycleDownsamplingDescriptor DownsamplingDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamLifecycleDownsamplingDescriptor> DownsamplingDescriptorAction { get; set; }

	public DataStreamLifecycleDescriptor DataRetention(Elastic.Clients.Elasticsearch.Serverless.Duration? dataRetention)
	{
		DataRetentionValue = dataRetention;
		return Self;
	}

	public DataStreamLifecycleDescriptor Downsampling(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamLifecycleDownsampling? downsampling)
	{
		DownsamplingDescriptor = null;
		DownsamplingDescriptorAction = null;
		DownsamplingValue = downsampling;
		return Self;
	}

	public DataStreamLifecycleDescriptor Downsampling(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamLifecycleDownsamplingDescriptor descriptor)
	{
		DownsamplingValue = null;
		DownsamplingDescriptorAction = null;
		DownsamplingDescriptor = descriptor;
		return Self;
	}

	public DataStreamLifecycleDescriptor Downsampling(Action<Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamLifecycleDownsamplingDescriptor> configure)
	{
		DownsamplingValue = null;
		DownsamplingDescriptor = null;
		DownsamplingDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DataRetentionValue is not null)
		{
			writer.WritePropertyName("data_retention");
			JsonSerializer.Serialize(writer, DataRetentionValue, options);
		}

		if (DownsamplingDescriptor is not null)
		{
			writer.WritePropertyName("downsampling");
			JsonSerializer.Serialize(writer, DownsamplingDescriptor, options);
		}
		else if (DownsamplingDescriptorAction is not null)
		{
			writer.WritePropertyName("downsampling");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamLifecycleDownsamplingDescriptor(DownsamplingDescriptorAction), options);
		}
		else if (DownsamplingValue is not null)
		{
			writer.WritePropertyName("downsampling");
			JsonSerializer.Serialize(writer, DownsamplingValue, options);
		}

		writer.WriteEndObject();
	}
}