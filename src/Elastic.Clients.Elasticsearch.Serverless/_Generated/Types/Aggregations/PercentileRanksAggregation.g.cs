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

namespace Elastic.Clients.Elasticsearch.Serverless.Aggregations;

public sealed partial class PercentileRanksAggregation
{
	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field? Field { get; set; }
	[JsonInclude, JsonPropertyName("format")]
	public string? Format { get; set; }

	/// <summary>
	/// <para>Uses the alternative High Dynamic Range Histogram algorithm to calculate percentile ranks.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("hdr")]
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.HdrMethod? Hdr { get; set; }

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("missing")]
	public Elastic.Clients.Elasticsearch.Serverless.FieldValue? Missing { get; set; }
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Serverless.Script? Script { get; set; }

	/// <summary>
	/// <para>Sets parameters for the default TDigest algorithm used to calculate percentile ranks.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tdigest")]
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.TDigest? TDigest { get; set; }

	/// <summary>
	/// <para>An array of values for which to calculate the percentile ranks.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("values")]
	public ICollection<double>? Values { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.Aggregations.Aggregation(PercentileRanksAggregation percentileRanksAggregation) => Elastic.Clients.Elasticsearch.Serverless.Aggregations.Aggregation.PercentileRanks(percentileRanksAggregation);
}

public sealed partial class PercentileRanksAggregationDescriptor<TDocument> : SerializableDescriptor<PercentileRanksAggregationDescriptor<TDocument>>
{
	internal PercentileRanksAggregationDescriptor(Action<PercentileRanksAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public PercentileRanksAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Field? FieldValue { get; set; }
	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.HdrMethod? HdrValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.HdrMethodDescriptor HdrDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.HdrMethodDescriptor> HdrDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.FieldValue? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Script? ScriptValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.ScriptDescriptor ScriptDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.ScriptDescriptor> ScriptDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.TDigest? TDigestValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.TDigestDescriptor TDigestDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.TDigestDescriptor> TDigestDescriptorAction { get; set; }
	private ICollection<double>? ValuesValue { get; set; }

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public PercentileRanksAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public PercentileRanksAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public PercentileRanksAggregationDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public PercentileRanksAggregationDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	/// <summary>
	/// <para>Uses the alternative High Dynamic Range Histogram algorithm to calculate percentile ranks.</para>
	/// </summary>
	public PercentileRanksAggregationDescriptor<TDocument> Hdr(Elastic.Clients.Elasticsearch.Serverless.Aggregations.HdrMethod? hdr)
	{
		HdrDescriptor = null;
		HdrDescriptorAction = null;
		HdrValue = hdr;
		return Self;
	}

	public PercentileRanksAggregationDescriptor<TDocument> Hdr(Elastic.Clients.Elasticsearch.Serverless.Aggregations.HdrMethodDescriptor descriptor)
	{
		HdrValue = null;
		HdrDescriptorAction = null;
		HdrDescriptor = descriptor;
		return Self;
	}

	public PercentileRanksAggregationDescriptor<TDocument> Hdr(Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.HdrMethodDescriptor> configure)
	{
		HdrValue = null;
		HdrDescriptor = null;
		HdrDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	public PercentileRanksAggregationDescriptor<TDocument> Missing(Elastic.Clients.Elasticsearch.Serverless.FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public PercentileRanksAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Serverless.Script? script)
	{
		ScriptDescriptor = null;
		ScriptDescriptorAction = null;
		ScriptValue = script;
		return Self;
	}

	public PercentileRanksAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Serverless.ScriptDescriptor descriptor)
	{
		ScriptValue = null;
		ScriptDescriptorAction = null;
		ScriptDescriptor = descriptor;
		return Self;
	}

	public PercentileRanksAggregationDescriptor<TDocument> Script(Action<Elastic.Clients.Elasticsearch.Serverless.ScriptDescriptor> configure)
	{
		ScriptValue = null;
		ScriptDescriptor = null;
		ScriptDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Sets parameters for the default TDigest algorithm used to calculate percentile ranks.</para>
	/// </summary>
	public PercentileRanksAggregationDescriptor<TDocument> TDigest(Elastic.Clients.Elasticsearch.Serverless.Aggregations.TDigest? tDigest)
	{
		TDigestDescriptor = null;
		TDigestDescriptorAction = null;
		TDigestValue = tDigest;
		return Self;
	}

	public PercentileRanksAggregationDescriptor<TDocument> TDigest(Elastic.Clients.Elasticsearch.Serverless.Aggregations.TDigestDescriptor descriptor)
	{
		TDigestValue = null;
		TDigestDescriptorAction = null;
		TDigestDescriptor = descriptor;
		return Self;
	}

	public PercentileRanksAggregationDescriptor<TDocument> TDigest(Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.TDigestDescriptor> configure)
	{
		TDigestValue = null;
		TDigestDescriptor = null;
		TDigestDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>An array of values for which to calculate the percentile ranks.</para>
	/// </summary>
	public PercentileRanksAggregationDescriptor<TDocument> Values(ICollection<double>? values)
	{
		ValuesValue = values;
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

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (HdrDescriptor is not null)
		{
			writer.WritePropertyName("hdr");
			JsonSerializer.Serialize(writer, HdrDescriptor, options);
		}
		else if (HdrDescriptorAction is not null)
		{
			writer.WritePropertyName("hdr");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Aggregations.HdrMethodDescriptor(HdrDescriptorAction), options);
		}
		else if (HdrValue is not null)
		{
			writer.WritePropertyName("hdr");
			JsonSerializer.Serialize(writer, HdrValue, options);
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
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.ScriptDescriptor(ScriptDescriptorAction), options);
		}
		else if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (TDigestDescriptor is not null)
		{
			writer.WritePropertyName("tdigest");
			JsonSerializer.Serialize(writer, TDigestDescriptor, options);
		}
		else if (TDigestDescriptorAction is not null)
		{
			writer.WritePropertyName("tdigest");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Aggregations.TDigestDescriptor(TDigestDescriptorAction), options);
		}
		else if (TDigestValue is not null)
		{
			writer.WritePropertyName("tdigest");
			JsonSerializer.Serialize(writer, TDigestValue, options);
		}

		if (ValuesValue is not null)
		{
			writer.WritePropertyName("values");
			JsonSerializer.Serialize(writer, ValuesValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class PercentileRanksAggregationDescriptor : SerializableDescriptor<PercentileRanksAggregationDescriptor>
{
	internal PercentileRanksAggregationDescriptor(Action<PercentileRanksAggregationDescriptor> configure) => configure.Invoke(this);

	public PercentileRanksAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Field? FieldValue { get; set; }
	private string? FormatValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.HdrMethod? HdrValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.HdrMethodDescriptor HdrDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.HdrMethodDescriptor> HdrDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.FieldValue? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Script? ScriptValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.ScriptDescriptor ScriptDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.ScriptDescriptor> ScriptDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.TDigest? TDigestValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.TDigestDescriptor TDigestDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.TDigestDescriptor> TDigestDescriptorAction { get; set; }
	private ICollection<double>? ValuesValue { get; set; }

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public PercentileRanksAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public PercentileRanksAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public PercentileRanksAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public PercentileRanksAggregationDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	/// <summary>
	/// <para>Uses the alternative High Dynamic Range Histogram algorithm to calculate percentile ranks.</para>
	/// </summary>
	public PercentileRanksAggregationDescriptor Hdr(Elastic.Clients.Elasticsearch.Serverless.Aggregations.HdrMethod? hdr)
	{
		HdrDescriptor = null;
		HdrDescriptorAction = null;
		HdrValue = hdr;
		return Self;
	}

	public PercentileRanksAggregationDescriptor Hdr(Elastic.Clients.Elasticsearch.Serverless.Aggregations.HdrMethodDescriptor descriptor)
	{
		HdrValue = null;
		HdrDescriptorAction = null;
		HdrDescriptor = descriptor;
		return Self;
	}

	public PercentileRanksAggregationDescriptor Hdr(Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.HdrMethodDescriptor> configure)
	{
		HdrValue = null;
		HdrDescriptor = null;
		HdrDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	public PercentileRanksAggregationDescriptor Missing(Elastic.Clients.Elasticsearch.Serverless.FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public PercentileRanksAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Serverless.Script? script)
	{
		ScriptDescriptor = null;
		ScriptDescriptorAction = null;
		ScriptValue = script;
		return Self;
	}

	public PercentileRanksAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Serverless.ScriptDescriptor descriptor)
	{
		ScriptValue = null;
		ScriptDescriptorAction = null;
		ScriptDescriptor = descriptor;
		return Self;
	}

	public PercentileRanksAggregationDescriptor Script(Action<Elastic.Clients.Elasticsearch.Serverless.ScriptDescriptor> configure)
	{
		ScriptValue = null;
		ScriptDescriptor = null;
		ScriptDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Sets parameters for the default TDigest algorithm used to calculate percentile ranks.</para>
	/// </summary>
	public PercentileRanksAggregationDescriptor TDigest(Elastic.Clients.Elasticsearch.Serverless.Aggregations.TDigest? tDigest)
	{
		TDigestDescriptor = null;
		TDigestDescriptorAction = null;
		TDigestValue = tDigest;
		return Self;
	}

	public PercentileRanksAggregationDescriptor TDigest(Elastic.Clients.Elasticsearch.Serverless.Aggregations.TDigestDescriptor descriptor)
	{
		TDigestValue = null;
		TDigestDescriptorAction = null;
		TDigestDescriptor = descriptor;
		return Self;
	}

	public PercentileRanksAggregationDescriptor TDigest(Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.TDigestDescriptor> configure)
	{
		TDigestValue = null;
		TDigestDescriptor = null;
		TDigestDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>An array of values for which to calculate the percentile ranks.</para>
	/// </summary>
	public PercentileRanksAggregationDescriptor Values(ICollection<double>? values)
	{
		ValuesValue = values;
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

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (HdrDescriptor is not null)
		{
			writer.WritePropertyName("hdr");
			JsonSerializer.Serialize(writer, HdrDescriptor, options);
		}
		else if (HdrDescriptorAction is not null)
		{
			writer.WritePropertyName("hdr");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Aggregations.HdrMethodDescriptor(HdrDescriptorAction), options);
		}
		else if (HdrValue is not null)
		{
			writer.WritePropertyName("hdr");
			JsonSerializer.Serialize(writer, HdrValue, options);
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
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.ScriptDescriptor(ScriptDescriptorAction), options);
		}
		else if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (TDigestDescriptor is not null)
		{
			writer.WritePropertyName("tdigest");
			JsonSerializer.Serialize(writer, TDigestDescriptor, options);
		}
		else if (TDigestDescriptorAction is not null)
		{
			writer.WritePropertyName("tdigest");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Aggregations.TDigestDescriptor(TDigestDescriptorAction), options);
		}
		else if (TDigestValue is not null)
		{
			writer.WritePropertyName("tdigest");
			JsonSerializer.Serialize(writer, TDigestValue, options);
		}

		if (ValuesValue is not null)
		{
			writer.WritePropertyName("values");
			JsonSerializer.Serialize(writer, ValuesValue, options);
		}

		writer.WriteEndObject();
	}
}