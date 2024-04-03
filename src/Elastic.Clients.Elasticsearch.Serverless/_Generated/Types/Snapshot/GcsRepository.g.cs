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

namespace Elastic.Clients.Elasticsearch.Serverless.Snapshot;

public sealed partial class GcsRepository : IRepository
{
	[JsonInclude, JsonPropertyName("settings")]
	public Elastic.Clients.Elasticsearch.Serverless.Snapshot.GcsRepositorySettings Settings { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "gcs";

	[JsonInclude, JsonPropertyName("uuid")]
	public string? Uuid { get; set; }
}

public sealed partial class GcsRepositoryDescriptor : SerializableDescriptor<GcsRepositoryDescriptor>, IBuildableDescriptor<GcsRepository>
{
	internal GcsRepositoryDescriptor(Action<GcsRepositoryDescriptor> configure) => configure.Invoke(this);

	public GcsRepositoryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Snapshot.GcsRepositorySettings SettingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Snapshot.GcsRepositorySettingsDescriptor SettingsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Snapshot.GcsRepositorySettingsDescriptor> SettingsDescriptorAction { get; set; }
	private string? UuidValue { get; set; }

	public GcsRepositoryDescriptor Settings(Elastic.Clients.Elasticsearch.Serverless.Snapshot.GcsRepositorySettings settings)
	{
		SettingsDescriptor = null;
		SettingsDescriptorAction = null;
		SettingsValue = settings;
		return Self;
	}

	public GcsRepositoryDescriptor Settings(Elastic.Clients.Elasticsearch.Serverless.Snapshot.GcsRepositorySettingsDescriptor descriptor)
	{
		SettingsValue = null;
		SettingsDescriptorAction = null;
		SettingsDescriptor = descriptor;
		return Self;
	}

	public GcsRepositoryDescriptor Settings(Action<Elastic.Clients.Elasticsearch.Serverless.Snapshot.GcsRepositorySettingsDescriptor> configure)
	{
		SettingsValue = null;
		SettingsDescriptor = null;
		SettingsDescriptorAction = configure;
		return Self;
	}

	public GcsRepositoryDescriptor Uuid(string? uuid)
	{
		UuidValue = uuid;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (SettingsDescriptor is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsDescriptor, options);
		}
		else if (SettingsDescriptorAction is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Snapshot.GcsRepositorySettingsDescriptor(SettingsDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsValue, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("gcs");
		if (!string.IsNullOrEmpty(UuidValue))
		{
			writer.WritePropertyName("uuid");
			writer.WriteStringValue(UuidValue);
		}

		writer.WriteEndObject();
	}

	private Elastic.Clients.Elasticsearch.Serverless.Snapshot.GcsRepositorySettings BuildSettings()
	{
		if (SettingsValue is not null)
		{
			return SettingsValue;
		}

		if ((object)SettingsDescriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Serverless.Snapshot.GcsRepositorySettings> buildable)
		{
			return buildable.Build();
		}

		if (SettingsDescriptorAction is not null)
		{
			var descriptor = new Elastic.Clients.Elasticsearch.Serverless.Snapshot.GcsRepositorySettingsDescriptor(SettingsDescriptorAction);
			if ((object)descriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Serverless.Snapshot.GcsRepositorySettings> buildableFromAction)
			{
				return buildableFromAction.Build();
			}
		}

		return null;
	}

	GcsRepository IBuildableDescriptor<GcsRepository>.Build() => new()
	{
		Settings = BuildSettings(),
		Uuid = UuidValue
	};
}