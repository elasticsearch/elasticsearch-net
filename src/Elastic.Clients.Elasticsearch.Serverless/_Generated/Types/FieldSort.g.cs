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

namespace Elastic.Clients.Elasticsearch.Serverless;

public sealed partial class FieldSort
{
	[JsonInclude, JsonPropertyName("format")]
	public string? Format { get; set; }
	[JsonInclude, JsonPropertyName("missing")]
	public Elastic.Clients.Elasticsearch.Serverless.FieldValue? Missing { get; set; }
	[JsonInclude, JsonPropertyName("mode")]
	public Elastic.Clients.Elasticsearch.Serverless.SortMode? Mode { get; set; }
	[JsonInclude, JsonPropertyName("nested")]
	public Elastic.Clients.Elasticsearch.Serverless.NestedSortValue? Nested { get; set; }
	[JsonInclude, JsonPropertyName("numeric_type")]
	public Elastic.Clients.Elasticsearch.Serverless.FieldSortNumericType? NumericType { get; set; }
	[JsonInclude, JsonPropertyName("order")]
	public Elastic.Clients.Elasticsearch.Serverless.SortOrder? Order { get; set; }
	[JsonInclude, JsonPropertyName("unmapped_type")]
	public Elastic.Clients.Elasticsearch.Serverless.Mapping.FieldType? UnmappedType { get; set; }
}

public sealed partial class FieldSortDescriptor<TDocument> : SerializableDescriptor<FieldSortDescriptor<TDocument>>
{
	internal FieldSortDescriptor(Action<FieldSortDescriptor<TDocument>> configure) => configure.Invoke(this);

	public FieldSortDescriptor() : base()
	{
	}

	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.FieldValue? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.SortMode? ModeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.NestedSortValue? NestedValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.NestedSortValueDescriptor<TDocument> NestedDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.NestedSortValueDescriptor<TDocument>> NestedDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.FieldSortNumericType? NumericTypeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.SortOrder? OrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.FieldType? UnmappedTypeValue { get; set; }

	public FieldSortDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public FieldSortDescriptor<TDocument> Missing(Elastic.Clients.Elasticsearch.Serverless.FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public FieldSortDescriptor<TDocument> Mode(Elastic.Clients.Elasticsearch.Serverless.SortMode? mode)
	{
		ModeValue = mode;
		return Self;
	}

	public FieldSortDescriptor<TDocument> Nested(Elastic.Clients.Elasticsearch.Serverless.NestedSortValue? nested)
	{
		NestedDescriptor = null;
		NestedDescriptorAction = null;
		NestedValue = nested;
		return Self;
	}

	public FieldSortDescriptor<TDocument> Nested(Elastic.Clients.Elasticsearch.Serverless.NestedSortValueDescriptor<TDocument> descriptor)
	{
		NestedValue = null;
		NestedDescriptorAction = null;
		NestedDescriptor = descriptor;
		return Self;
	}

	public FieldSortDescriptor<TDocument> Nested(Action<Elastic.Clients.Elasticsearch.Serverless.NestedSortValueDescriptor<TDocument>> configure)
	{
		NestedValue = null;
		NestedDescriptor = null;
		NestedDescriptorAction = configure;
		return Self;
	}

	public FieldSortDescriptor<TDocument> NumericType(Elastic.Clients.Elasticsearch.Serverless.FieldSortNumericType? numericType)
	{
		NumericTypeValue = numericType;
		return Self;
	}

	public FieldSortDescriptor<TDocument> Order(Elastic.Clients.Elasticsearch.Serverless.SortOrder? order)
	{
		OrderValue = order;
		return Self;
	}

	public FieldSortDescriptor<TDocument> UnmappedType(Elastic.Clients.Elasticsearch.Serverless.Mapping.FieldType? unmappedType)
	{
		UnmappedTypeValue = unmappedType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (ModeValue is not null)
		{
			writer.WritePropertyName("mode");
			JsonSerializer.Serialize(writer, ModeValue, options);
		}

		if (NestedDescriptor is not null)
		{
			writer.WritePropertyName("nested");
			JsonSerializer.Serialize(writer, NestedDescriptor, options);
		}
		else if (NestedDescriptorAction is not null)
		{
			writer.WritePropertyName("nested");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.NestedSortValueDescriptor<TDocument>(NestedDescriptorAction), options);
		}
		else if (NestedValue is not null)
		{
			writer.WritePropertyName("nested");
			JsonSerializer.Serialize(writer, NestedValue, options);
		}

		if (NumericTypeValue is not null)
		{
			writer.WritePropertyName("numeric_type");
			JsonSerializer.Serialize(writer, NumericTypeValue, options);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			JsonSerializer.Serialize(writer, OrderValue, options);
		}

		if (UnmappedTypeValue is not null)
		{
			writer.WritePropertyName("unmapped_type");
			JsonSerializer.Serialize(writer, UnmappedTypeValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class FieldSortDescriptor : SerializableDescriptor<FieldSortDescriptor>
{
	internal FieldSortDescriptor(Action<FieldSortDescriptor> configure) => configure.Invoke(this);

	public FieldSortDescriptor() : base()
	{
	}

	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.FieldValue? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.SortMode? ModeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.NestedSortValue? NestedValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.NestedSortValueDescriptor NestedDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.NestedSortValueDescriptor> NestedDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.FieldSortNumericType? NumericTypeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.SortOrder? OrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Mapping.FieldType? UnmappedTypeValue { get; set; }

	public FieldSortDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public FieldSortDescriptor Missing(Elastic.Clients.Elasticsearch.Serverless.FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public FieldSortDescriptor Mode(Elastic.Clients.Elasticsearch.Serverless.SortMode? mode)
	{
		ModeValue = mode;
		return Self;
	}

	public FieldSortDescriptor Nested(Elastic.Clients.Elasticsearch.Serverless.NestedSortValue? nested)
	{
		NestedDescriptor = null;
		NestedDescriptorAction = null;
		NestedValue = nested;
		return Self;
	}

	public FieldSortDescriptor Nested(Elastic.Clients.Elasticsearch.Serverless.NestedSortValueDescriptor descriptor)
	{
		NestedValue = null;
		NestedDescriptorAction = null;
		NestedDescriptor = descriptor;
		return Self;
	}

	public FieldSortDescriptor Nested(Action<Elastic.Clients.Elasticsearch.Serverless.NestedSortValueDescriptor> configure)
	{
		NestedValue = null;
		NestedDescriptor = null;
		NestedDescriptorAction = configure;
		return Self;
	}

	public FieldSortDescriptor NumericType(Elastic.Clients.Elasticsearch.Serverless.FieldSortNumericType? numericType)
	{
		NumericTypeValue = numericType;
		return Self;
	}

	public FieldSortDescriptor Order(Elastic.Clients.Elasticsearch.Serverless.SortOrder? order)
	{
		OrderValue = order;
		return Self;
	}

	public FieldSortDescriptor UnmappedType(Elastic.Clients.Elasticsearch.Serverless.Mapping.FieldType? unmappedType)
	{
		UnmappedTypeValue = unmappedType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (ModeValue is not null)
		{
			writer.WritePropertyName("mode");
			JsonSerializer.Serialize(writer, ModeValue, options);
		}

		if (NestedDescriptor is not null)
		{
			writer.WritePropertyName("nested");
			JsonSerializer.Serialize(writer, NestedDescriptor, options);
		}
		else if (NestedDescriptorAction is not null)
		{
			writer.WritePropertyName("nested");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.NestedSortValueDescriptor(NestedDescriptorAction), options);
		}
		else if (NestedValue is not null)
		{
			writer.WritePropertyName("nested");
			JsonSerializer.Serialize(writer, NestedValue, options);
		}

		if (NumericTypeValue is not null)
		{
			writer.WritePropertyName("numeric_type");
			JsonSerializer.Serialize(writer, NumericTypeValue, options);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			JsonSerializer.Serialize(writer, OrderValue, options);
		}

		if (UnmappedTypeValue is not null)
		{
			writer.WritePropertyName("unmapped_type");
			JsonSerializer.Serialize(writer, UnmappedTypeValue, options);
		}

		writer.WriteEndObject();
	}
}