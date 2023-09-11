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

namespace Elastic.Clients.Elasticsearch.Ingest;

public sealed partial class Document
{
	/// <summary>
	/// <para>Unique identifier for the document.<br/>This ID must be unique within the `_index`.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_id")]
	public Elastic.Clients.Elasticsearch.Id? Id { get; set; }

	/// <summary>
	/// <para>Name of the index containing the document.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_index")]
	public Elastic.Clients.Elasticsearch.IndexName? Index { get; set; }

	/// <summary>
	/// <para>JSON body for the document.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_source")]
	public object Source { get; set; }
}

public sealed partial class DocumentDescriptor : SerializableDescriptor<DocumentDescriptor>
{
	internal DocumentDescriptor(Action<DocumentDescriptor> configure) => configure.Invoke(this);

	public DocumentDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Id? IdValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexName? IndexValue { get; set; }
	private object SourceValue { get; set; }

	/// <summary>
	/// <para>Unique identifier for the document.<br/>This ID must be unique within the `_index`.</para>
	/// </summary>
	public DocumentDescriptor Id(Elastic.Clients.Elasticsearch.Id? id)
	{
		IdValue = id;
		return Self;
	}

	/// <summary>
	/// <para>Name of the index containing the document.</para>
	/// </summary>
	public DocumentDescriptor Index(Elastic.Clients.Elasticsearch.IndexName? index)
	{
		IndexValue = index;
		return Self;
	}

	/// <summary>
	/// <para>JSON body for the document.</para>
	/// </summary>
	public DocumentDescriptor Source(object source)
	{
		SourceValue = source;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IdValue is not null)
		{
			writer.WritePropertyName("_id");
			JsonSerializer.Serialize(writer, IdValue, options);
		}

		if (IndexValue is not null)
		{
			writer.WritePropertyName("_index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		writer.WritePropertyName("_source");
		JsonSerializer.Serialize(writer, SourceValue, options);
		writer.WriteEndObject();
	}
}