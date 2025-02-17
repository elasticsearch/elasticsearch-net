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

internal sealed partial class TopMetricsAggregationConverter : System.Text.Json.Serialization.JsonConverter<TopMetricsAggregation>
{
	private static readonly System.Text.Json.JsonEncodedText PropField = System.Text.Json.JsonEncodedText.Encode("field");
	private static readonly System.Text.Json.JsonEncodedText PropMetrics = System.Text.Json.JsonEncodedText.Encode("metrics");
	private static readonly System.Text.Json.JsonEncodedText PropMissing = System.Text.Json.JsonEncodedText.Encode("missing");
	private static readonly System.Text.Json.JsonEncodedText PropScript = System.Text.Json.JsonEncodedText.Encode("script");
	private static readonly System.Text.Json.JsonEncodedText PropSize = System.Text.Json.JsonEncodedText.Encode("size");
	private static readonly System.Text.Json.JsonEncodedText PropSort = System.Text.Json.JsonEncodedText.Encode("sort");

	public override TopMetricsAggregation Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<Elastic.Clients.Elasticsearch.Field?> propField = default;
		LocalJsonValue<ICollection<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>?> propMetrics = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.FieldValue?> propMissing = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.Script?> propScript = default;
		LocalJsonValue<int?> propSize = default;
		LocalJsonValue<ICollection<Elastic.Clients.Elasticsearch.SortOptions>?> propSort = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propField.TryReadProperty(ref reader, options, PropField, null))
			{
				continue;
			}

			if (propMetrics.TryReadProperty(ref reader, options, PropMetrics, static ICollection<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>(o, null)))
			{
				continue;
			}

			if (propMissing.TryReadProperty(ref reader, options, PropMissing, null))
			{
				continue;
			}

			if (propScript.TryReadProperty(ref reader, options, PropScript, null))
			{
				continue;
			}

			if (propSize.TryReadProperty(ref reader, options, PropSize, null))
			{
				continue;
			}

			if (propSort.TryReadProperty(ref reader, options, PropSort, static ICollection<Elastic.Clients.Elasticsearch.SortOptions>? (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.SortOptions>(o, null)))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new TopMetricsAggregation
		{
			Field = propField.Value
,
			Metrics = propMetrics.Value
,
			Missing = propMissing.Value
,
			Script = propScript.Value
,
			Size = propSize.Value
,
			Sort = propSort.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, TopMetricsAggregation value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropField, value.Field, null, null);
		writer.WriteProperty(options, PropMetrics, value.Metrics, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>? v) => w.WriteSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>(o, v, null));
		writer.WriteProperty(options, PropMissing, value.Missing, null, null);
		writer.WriteProperty(options, PropScript, value.Script, null, null);
		writer.WriteProperty(options, PropSize, value.Size, null, null);
		writer.WriteProperty(options, PropSort, value.Sort, null, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, ICollection<Elastic.Clients.Elasticsearch.SortOptions>? v) => w.WriteSingleOrManyCollectionValue<Elastic.Clients.Elasticsearch.SortOptions>(o, v, null));
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(TopMetricsAggregationConverter))]
public sealed partial class TopMetricsAggregation
{
	/// <summary>
	/// <para>
	/// The field on which to run the aggregation.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

	/// <summary>
	/// <para>
	/// The fields of the top document to return.
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>? Metrics { get; set; }

	/// <summary>
	/// <para>
	/// The value to apply to documents that do not have a value.
	/// By default, documents without a value are ignored.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.FieldValue? Missing { get; set; }
	public Elastic.Clients.Elasticsearch.Script? Script { get; set; }

	/// <summary>
	/// <para>
	/// The number of top documents from which to return metrics.
	/// </para>
	/// </summary>
	public int? Size { get; set; }

	/// <summary>
	/// <para>
	/// The sort order of the documents.
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.SortOptions>? Sort { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Aggregations.Aggregation(TopMetricsAggregation topMetricsAggregation) => Elastic.Clients.Elasticsearch.Aggregations.Aggregation.TopMetrics(topMetricsAggregation);
}

public sealed partial class TopMetricsAggregationDescriptor<TDocument> : SerializableDescriptor<TopMetricsAggregationDescriptor<TDocument>>
{
	internal TopMetricsAggregationDescriptor(Action<TopMetricsAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public TopMetricsAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>? MetricsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValueDescriptor<TDocument> MetricsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValueDescriptor<TDocument>> MetricsDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValueDescriptor<TDocument>>[] MetricsDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.FieldValue? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }
	private Elastic.Clients.Elasticsearch.ScriptDescriptor ScriptDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> ScriptDescriptorAction { get; set; }
	private int? SizeValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.SortOptions>? SortValue { get; set; }
	private Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument> SortDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>> SortDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>>[] SortDescriptorActions { get; set; }

	/// <summary>
	/// <para>
	/// The field on which to run the aggregation.
	/// </para>
	/// </summary>
	public TopMetricsAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field on which to run the aggregation.
	/// </para>
	/// </summary>
	public TopMetricsAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field on which to run the aggregation.
	/// </para>
	/// </summary>
	public TopMetricsAggregationDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The fields of the top document to return.
	/// </para>
	/// </summary>
	public TopMetricsAggregationDescriptor<TDocument> Metrics(ICollection<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>? metrics)
	{
		MetricsDescriptor = null;
		MetricsDescriptorAction = null;
		MetricsDescriptorActions = null;
		MetricsValue = metrics;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Metrics(Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValueDescriptor<TDocument> descriptor)
	{
		MetricsValue = null;
		MetricsDescriptorAction = null;
		MetricsDescriptorActions = null;
		MetricsDescriptor = descriptor;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Metrics(Action<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValueDescriptor<TDocument>> configure)
	{
		MetricsValue = null;
		MetricsDescriptor = null;
		MetricsDescriptorActions = null;
		MetricsDescriptorAction = configure;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Metrics(params Action<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValueDescriptor<TDocument>>[] configure)
	{
		MetricsValue = null;
		MetricsDescriptor = null;
		MetricsDescriptorAction = null;
		MetricsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The value to apply to documents that do not have a value.
	/// By default, documents without a value are ignored.
	/// </para>
	/// </summary>
	public TopMetricsAggregationDescriptor<TDocument> Missing(Elastic.Clients.Elasticsearch.FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptDescriptor = null;
		ScriptDescriptorAction = null;
		ScriptValue = script;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.ScriptDescriptor descriptor)
	{
		ScriptValue = null;
		ScriptDescriptorAction = null;
		ScriptDescriptor = descriptor;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Script(Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> configure)
	{
		ScriptValue = null;
		ScriptDescriptor = null;
		ScriptDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The number of top documents from which to return metrics.
	/// </para>
	/// </summary>
	public TopMetricsAggregationDescriptor<TDocument> Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The sort order of the documents.
	/// </para>
	/// </summary>
	public TopMetricsAggregationDescriptor<TDocument> Sort(ICollection<Elastic.Clients.Elasticsearch.SortOptions>? sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortValue = sort;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Sort(Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument> descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Sort(Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorActions = null;
		SortDescriptorAction = configure;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Sort(params Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>>[] configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (MetricsDescriptor is not null)
		{
			writer.WritePropertyName("metrics");
			JsonSerializer.Serialize(writer, MetricsDescriptor, options);
		}
		else if (MetricsDescriptorAction is not null)
		{
			writer.WritePropertyName("metrics");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValueDescriptor<TDocument>(MetricsDescriptorAction), options);
		}
		else if (MetricsDescriptorActions is not null)
		{
			writer.WritePropertyName("metrics");
			if (MetricsDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in MetricsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValueDescriptor<TDocument>(action), options);
			}

			if (MetricsDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (MetricsValue is not null)
		{
			writer.WritePropertyName("metrics");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>(MetricsValue, writer, options);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (ScriptDescriptor is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptDescriptor, options);
		}
		else if (ScriptDescriptorAction is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.ScriptDescriptor(ScriptDescriptorAction), options);
		}
		else if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>(SortDescriptorAction), options);
		}
		else if (SortDescriptorActions is not null)
		{
			writer.WritePropertyName("sort");
			if (SortDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in SortDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.SortOptionsDescriptor<TDocument>(action), options);
			}

			if (SortDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (SortValue is not null)
		{
			writer.WritePropertyName("sort");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.SortOptions>(SortValue, writer, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class TopMetricsAggregationDescriptor : SerializableDescriptor<TopMetricsAggregationDescriptor>
{
	internal TopMetricsAggregationDescriptor(Action<TopMetricsAggregationDescriptor> configure) => configure.Invoke(this);

	public TopMetricsAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>? MetricsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValueDescriptor MetricsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValueDescriptor> MetricsDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValueDescriptor>[] MetricsDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.FieldValue? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }
	private Elastic.Clients.Elasticsearch.ScriptDescriptor ScriptDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> ScriptDescriptorAction { get; set; }
	private int? SizeValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.SortOptions>? SortValue { get; set; }
	private Elastic.Clients.Elasticsearch.SortOptionsDescriptor SortDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor> SortDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor>[] SortDescriptorActions { get; set; }

	/// <summary>
	/// <para>
	/// The field on which to run the aggregation.
	/// </para>
	/// </summary>
	public TopMetricsAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field on which to run the aggregation.
	/// </para>
	/// </summary>
	public TopMetricsAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The field on which to run the aggregation.
	/// </para>
	/// </summary>
	public TopMetricsAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The fields of the top document to return.
	/// </para>
	/// </summary>
	public TopMetricsAggregationDescriptor Metrics(ICollection<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>? metrics)
	{
		MetricsDescriptor = null;
		MetricsDescriptorAction = null;
		MetricsDescriptorActions = null;
		MetricsValue = metrics;
		return Self;
	}

	public TopMetricsAggregationDescriptor Metrics(Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValueDescriptor descriptor)
	{
		MetricsValue = null;
		MetricsDescriptorAction = null;
		MetricsDescriptorActions = null;
		MetricsDescriptor = descriptor;
		return Self;
	}

	public TopMetricsAggregationDescriptor Metrics(Action<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValueDescriptor> configure)
	{
		MetricsValue = null;
		MetricsDescriptor = null;
		MetricsDescriptorActions = null;
		MetricsDescriptorAction = configure;
		return Self;
	}

	public TopMetricsAggregationDescriptor Metrics(params Action<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValueDescriptor>[] configure)
	{
		MetricsValue = null;
		MetricsDescriptor = null;
		MetricsDescriptorAction = null;
		MetricsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The value to apply to documents that do not have a value.
	/// By default, documents without a value are ignored.
	/// </para>
	/// </summary>
	public TopMetricsAggregationDescriptor Missing(Elastic.Clients.Elasticsearch.FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public TopMetricsAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptDescriptor = null;
		ScriptDescriptorAction = null;
		ScriptValue = script;
		return Self;
	}

	public TopMetricsAggregationDescriptor Script(Elastic.Clients.Elasticsearch.ScriptDescriptor descriptor)
	{
		ScriptValue = null;
		ScriptDescriptorAction = null;
		ScriptDescriptor = descriptor;
		return Self;
	}

	public TopMetricsAggregationDescriptor Script(Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> configure)
	{
		ScriptValue = null;
		ScriptDescriptor = null;
		ScriptDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The number of top documents from which to return metrics.
	/// </para>
	/// </summary>
	public TopMetricsAggregationDescriptor Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The sort order of the documents.
	/// </para>
	/// </summary>
	public TopMetricsAggregationDescriptor Sort(ICollection<Elastic.Clients.Elasticsearch.SortOptions>? sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortValue = sort;
		return Self;
	}

	public TopMetricsAggregationDescriptor Sort(Elastic.Clients.Elasticsearch.SortOptionsDescriptor descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public TopMetricsAggregationDescriptor Sort(Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorActions = null;
		SortDescriptorAction = configure;
		return Self;
	}

	public TopMetricsAggregationDescriptor Sort(params Action<Elastic.Clients.Elasticsearch.SortOptionsDescriptor>[] configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (MetricsDescriptor is not null)
		{
			writer.WritePropertyName("metrics");
			JsonSerializer.Serialize(writer, MetricsDescriptor, options);
		}
		else if (MetricsDescriptorAction is not null)
		{
			writer.WritePropertyName("metrics");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValueDescriptor(MetricsDescriptorAction), options);
		}
		else if (MetricsDescriptorActions is not null)
		{
			writer.WritePropertyName("metrics");
			if (MetricsDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in MetricsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValueDescriptor(action), options);
			}

			if (MetricsDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (MetricsValue is not null)
		{
			writer.WritePropertyName("metrics");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>(MetricsValue, writer, options);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (ScriptDescriptor is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptDescriptor, options);
		}
		else if (ScriptDescriptorAction is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.ScriptDescriptor(ScriptDescriptorAction), options);
		}
		else if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.SortOptionsDescriptor(SortDescriptorAction), options);
		}
		else if (SortDescriptorActions is not null)
		{
			writer.WritePropertyName("sort");
			if (SortDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in SortDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.SortOptionsDescriptor(action), options);
			}

			if (SortDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (SortValue is not null)
		{
			writer.WritePropertyName("sort");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.SortOptions>(SortValue, writer, options);
		}

		writer.WriteEndObject();
	}
}