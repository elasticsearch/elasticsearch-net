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

namespace Elastic.Clients.Elasticsearch.Serverless.Mapping;

public sealed partial class RuntimeFieldFetchFields
{
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field Field { get; set; }
	[JsonInclude, JsonPropertyName("format")]
	public string? Format { get; set; }
}

public sealed partial class RuntimeFieldFetchFieldsDescriptor<TDocument> : SerializableDescriptor<RuntimeFieldFetchFieldsDescriptor<TDocument>>
{
	internal RuntimeFieldFetchFieldsDescriptor(Action<RuntimeFieldFetchFieldsDescriptor<TDocument>> configure) => configure.Invoke(this);

	public RuntimeFieldFetchFieldsDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private string? FormatValue { get; set; }

	public RuntimeFieldFetchFieldsDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public RuntimeFieldFetchFieldsDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public RuntimeFieldFetchFieldsDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class RuntimeFieldFetchFieldsDescriptor : SerializableDescriptor<RuntimeFieldFetchFieldsDescriptor>
{
	internal RuntimeFieldFetchFieldsDescriptor(Action<RuntimeFieldFetchFieldsDescriptor> configure) => configure.Invoke(this);

	public RuntimeFieldFetchFieldsDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private string? FormatValue { get; set; }

	public RuntimeFieldFetchFieldsDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public RuntimeFieldFetchFieldsDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public RuntimeFieldFetchFieldsDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public RuntimeFieldFetchFieldsDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		writer.WriteEndObject();
	}
}