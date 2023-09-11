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

namespace Elastic.Clients.Elasticsearch.Aggregations;

public sealed partial class GeoLineSort
{
	/// <summary>
	/// <para>The name of the numeric field to use as the sort key for ordering the points.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }
}

public sealed partial class GeoLineSortDescriptor<TDocument> : SerializableDescriptor<GeoLineSortDescriptor<TDocument>>
{
	internal GeoLineSortDescriptor(Action<GeoLineSortDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GeoLineSortDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

	/// <summary>
	/// <para>The name of the numeric field to use as the sort key for ordering the points.</para>
	/// </summary>
	public GeoLineSortDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the numeric field to use as the sort key for ordering the points.</para>
	/// </summary>
	public GeoLineSortDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		writer.WriteEndObject();
	}
}

public sealed partial class GeoLineSortDescriptor : SerializableDescriptor<GeoLineSortDescriptor>
{
	internal GeoLineSortDescriptor(Action<GeoLineSortDescriptor> configure) => configure.Invoke(this);

	public GeoLineSortDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

	/// <summary>
	/// <para>The name of the numeric field to use as the sort key for ordering the points.</para>
	/// </summary>
	public GeoLineSortDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the numeric field to use as the sort key for ordering the points.</para>
	/// </summary>
	public GeoLineSortDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the numeric field to use as the sort key for ordering the points.</para>
	/// </summary>
	public GeoLineSortDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		writer.WriteEndObject();
	}
}