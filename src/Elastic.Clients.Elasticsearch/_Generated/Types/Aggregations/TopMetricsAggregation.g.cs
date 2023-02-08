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
namespace Elastic.Clients.Elasticsearch.Aggregations;
internal sealed class TopMetricsAggregationConverter : JsonConverter<TopMetricsAggregation>
{
	public override TopMetricsAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "top_metrics")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new TopMetricsAggregation(aggName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("field"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
					if (value is not null)
					{
						agg.Field = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("metrics"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<ICollection<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>?>(ref reader, options);
					if (value is not null)
					{
						agg.Metrics = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("missing"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<FieldValue?>(ref reader, options);
					if (value is not null)
					{
						agg.Missing = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("script"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
					if (value is not null)
					{
						agg.Script = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("size"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<int?>(ref reader, options);
					if (value is not null)
					{
						agg.Size = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("sort"))
				{
					reader.Read();
					var value = SingleOrManySerializationHelper.Deserialize<Elastic.Clients.Elasticsearch.SortOptions>(ref reader, options);
					if (value is not null)
					{
						agg.Sort = value;
					}

					continue;
				}
			}
		}

		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("meta"))
				{
					var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
					if (value is not null)
					{
						agg.Meta = value;
					}

					continue;
				}
			}
		}

		return agg;
	}

	public override void Write(Utf8JsonWriter writer, TopMetricsAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("top_metrics");
		writer.WriteStartObject();
		if (value.Field is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, value.Field, options);
		}

		if (value.Metrics is not null)
		{
			writer.WritePropertyName("metrics");
			JsonSerializer.Serialize(writer, value.Metrics, options);
		}

		if (value.Missing is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, value.Missing, options);
		}

		if (value.Script is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, value.Script, options);
		}

		if (value.Size.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(value.Size.Value);
		}

		if (value.Sort is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, value.Sort, options);
		}

		writer.WriteEndObject();
		if (value.Meta is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, value.Meta, options);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(TopMetricsAggregationConverter))]
public sealed partial class TopMetricsAggregation : SearchAggregation
{
	public TopMetricsAggregation(string name, Field field) : this(name) => Field = field;
	public TopMetricsAggregation(string name) => Name = name;
	internal TopMetricsAggregation()
	{
	}

	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

	public IDictionary<string, object>? Meta { get; set; }

	public ICollection<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>? Metrics { get; set; }

	public FieldValue? Missing { get; set; }

	public override string? Name { get; internal set; }

	public Elastic.Clients.Elasticsearch.Script? Script { get; set; }

	public int? Size { get; set; }

	[JsonConverter(typeof(SortConverter))]
	public ICollection<Elastic.Clients.Elasticsearch.SortOptions>? Sort { get; set; }
}

public sealed partial class TopMetricsAggregationDescriptor<TDocument> : SerializableDescriptor<TopMetricsAggregationDescriptor<TDocument>>
{
	internal TopMetricsAggregationDescriptor(Action<TopMetricsAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
	public TopMetricsAggregationDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>? MetricsValue { get; set; }

	private TopMetricsValueDescriptor<TDocument> MetricsDescriptor { get; set; }

	private Action<TopMetricsValueDescriptor<TDocument>> MetricsDescriptorAction { get; set; }

	private Action<TopMetricsValueDescriptor<TDocument>>[] MetricsDescriptorActions { get; set; }

	private ICollection<Elastic.Clients.Elasticsearch.SortOptions>? SortValue { get; set; }

	private SortOptionsDescriptor<TDocument> SortDescriptor { get; set; }

	private Action<SortOptionsDescriptor<TDocument>> SortDescriptorAction { get; set; }

	private Action<SortOptionsDescriptor<TDocument>>[] SortDescriptorActions { get; set; }

	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

	private IDictionary<string, object>? MetaValue { get; set; }

	private FieldValue? MissingValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }

	private int? SizeValue { get; set; }

	public TopMetricsAggregationDescriptor<TDocument> Metrics(ICollection<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>? metrics)
	{
		MetricsDescriptor = null;
		MetricsDescriptorAction = null;
		MetricsDescriptorActions = null;
		MetricsValue = metrics;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Metrics(TopMetricsValueDescriptor<TDocument> descriptor)
	{
		MetricsValue = null;
		MetricsDescriptorAction = null;
		MetricsDescriptorActions = null;
		MetricsDescriptor = descriptor;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Metrics(Action<TopMetricsValueDescriptor<TDocument>> configure)
	{
		MetricsValue = null;
		MetricsDescriptor = null;
		MetricsDescriptorActions = null;
		MetricsDescriptorAction = configure;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Metrics(params Action<TopMetricsValueDescriptor<TDocument>>[] configure)
	{
		MetricsValue = null;
		MetricsDescriptor = null;
		MetricsDescriptorAction = null;
		MetricsDescriptorActions = configure;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Sort(ICollection<Elastic.Clients.Elasticsearch.SortOptions>? sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortValue = sort;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Sort(SortOptionsDescriptor<TDocument> descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Sort(Action<SortOptionsDescriptor<TDocument>> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorActions = null;
		SortDescriptorAction = configure;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Sort(params Action<SortOptionsDescriptor<TDocument>>[] configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = configure;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Missing(FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	public TopMetricsAggregationDescriptor<TDocument> Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("top_metrics");
		writer.WriteStartObject();
		if (MetricsDescriptor is not null)
		{
			writer.WritePropertyName("metrics");
			JsonSerializer.Serialize(writer, MetricsDescriptor, options);
		}
		else if (MetricsDescriptorAction is not null)
		{
			writer.WritePropertyName("metrics");
			JsonSerializer.Serialize(writer, new TopMetricsValueDescriptor<TDocument>(MetricsDescriptorAction), options);
		}
		else if (MetricsDescriptorActions is not null)
		{
			writer.WritePropertyName("metrics");
			if (MetricsDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in MetricsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new TopMetricsValueDescriptor<TDocument>(action), options);
			}

			if (MetricsDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (MetricsValue is not null)
		{
			writer.WritePropertyName("metrics");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>(MetricsValue, writer, options);
		}

		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new SortOptionsDescriptor<TDocument>(SortDescriptorAction), options);
		}
		else if (SortDescriptorActions is not null)
		{
			writer.WritePropertyName("sort");
			if (SortDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in SortDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new SortOptionsDescriptor<TDocument>(action), options);
			}

			if (SortDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (SortValue is not null)
		{
			writer.WritePropertyName("sort");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.SortOptions>(SortValue, writer, options);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
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

	private ICollection<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>? MetricsValue { get; set; }

	private TopMetricsValueDescriptor MetricsDescriptor { get; set; }

	private Action<TopMetricsValueDescriptor> MetricsDescriptorAction { get; set; }

	private Action<TopMetricsValueDescriptor>[] MetricsDescriptorActions { get; set; }

	private ICollection<Elastic.Clients.Elasticsearch.SortOptions>? SortValue { get; set; }

	private SortOptionsDescriptor SortDescriptor { get; set; }

	private Action<SortOptionsDescriptor> SortDescriptorAction { get; set; }

	private Action<SortOptionsDescriptor>[] SortDescriptorActions { get; set; }

	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

	private IDictionary<string, object>? MetaValue { get; set; }

	private FieldValue? MissingValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }

	private int? SizeValue { get; set; }

	public TopMetricsAggregationDescriptor Metrics(ICollection<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>? metrics)
	{
		MetricsDescriptor = null;
		MetricsDescriptorAction = null;
		MetricsDescriptorActions = null;
		MetricsValue = metrics;
		return Self;
	}

	public TopMetricsAggregationDescriptor Metrics(TopMetricsValueDescriptor descriptor)
	{
		MetricsValue = null;
		MetricsDescriptorAction = null;
		MetricsDescriptorActions = null;
		MetricsDescriptor = descriptor;
		return Self;
	}

	public TopMetricsAggregationDescriptor Metrics(Action<TopMetricsValueDescriptor> configure)
	{
		MetricsValue = null;
		MetricsDescriptor = null;
		MetricsDescriptorActions = null;
		MetricsDescriptorAction = configure;
		return Self;
	}

	public TopMetricsAggregationDescriptor Metrics(params Action<TopMetricsValueDescriptor>[] configure)
	{
		MetricsValue = null;
		MetricsDescriptor = null;
		MetricsDescriptorAction = null;
		MetricsDescriptorActions = configure;
		return Self;
	}

	public TopMetricsAggregationDescriptor Sort(ICollection<Elastic.Clients.Elasticsearch.SortOptions>? sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortValue = sort;
		return Self;
	}

	public TopMetricsAggregationDescriptor Sort(SortOptionsDescriptor descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public TopMetricsAggregationDescriptor Sort(Action<SortOptionsDescriptor> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorActions = null;
		SortDescriptorAction = configure;
		return Self;
	}

	public TopMetricsAggregationDescriptor Sort(params Action<SortOptionsDescriptor>[] configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = configure;
		return Self;
	}

	public TopMetricsAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	public TopMetricsAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TopMetricsAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TopMetricsAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public TopMetricsAggregationDescriptor Missing(FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public TopMetricsAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	public TopMetricsAggregationDescriptor Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("top_metrics");
		writer.WriteStartObject();
		if (MetricsDescriptor is not null)
		{
			writer.WritePropertyName("metrics");
			JsonSerializer.Serialize(writer, MetricsDescriptor, options);
		}
		else if (MetricsDescriptorAction is not null)
		{
			writer.WritePropertyName("metrics");
			JsonSerializer.Serialize(writer, new TopMetricsValueDescriptor(MetricsDescriptorAction), options);
		}
		else if (MetricsDescriptorActions is not null)
		{
			writer.WritePropertyName("metrics");
			if (MetricsDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in MetricsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new TopMetricsValueDescriptor(action), options);
			}

			if (MetricsDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (MetricsValue is not null)
		{
			writer.WritePropertyName("metrics");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>(MetricsValue, writer, options);
		}

		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new SortOptionsDescriptor(SortDescriptorAction), options);
		}
		else if (SortDescriptorActions is not null)
		{
			writer.WritePropertyName("sort");
			if (SortDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in SortDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new SortOptionsDescriptor(action), options);
			}

			if (SortDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (SortValue is not null)
		{
			writer.WritePropertyName("sort");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.SortOptions>(SortValue, writer, options);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}