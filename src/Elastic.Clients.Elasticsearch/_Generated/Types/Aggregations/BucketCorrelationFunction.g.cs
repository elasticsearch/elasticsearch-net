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

public sealed partial class BucketCorrelationFunction
{
	/// <summary>
	/// <para>The configuration to calculate a count correlation. This function is designed for determining the correlation of a term value and a given metric.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("count_correlation")]
	public Elastic.Clients.Elasticsearch.Aggregations.BucketCorrelationFunctionCountCorrelation CountCorrelation { get; set; }
}

public sealed partial class BucketCorrelationFunctionDescriptor : SerializableDescriptor<BucketCorrelationFunctionDescriptor>
{
	internal BucketCorrelationFunctionDescriptor(Action<BucketCorrelationFunctionDescriptor> configure) => configure.Invoke(this);

	public BucketCorrelationFunctionDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.BucketCorrelationFunctionCountCorrelation CountCorrelationValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.BucketCorrelationFunctionCountCorrelationDescriptor CountCorrelationDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Aggregations.BucketCorrelationFunctionCountCorrelationDescriptor> CountCorrelationDescriptorAction { get; set; }

	/// <summary>
	/// <para>The configuration to calculate a count correlation. This function is designed for determining the correlation of a term value and a given metric.</para>
	/// </summary>
	public BucketCorrelationFunctionDescriptor CountCorrelation(Elastic.Clients.Elasticsearch.Aggregations.BucketCorrelationFunctionCountCorrelation countCorrelation)
	{
		CountCorrelationDescriptor = null;
		CountCorrelationDescriptorAction = null;
		CountCorrelationValue = countCorrelation;
		return Self;
	}

	public BucketCorrelationFunctionDescriptor CountCorrelation(Elastic.Clients.Elasticsearch.Aggregations.BucketCorrelationFunctionCountCorrelationDescriptor descriptor)
	{
		CountCorrelationValue = null;
		CountCorrelationDescriptorAction = null;
		CountCorrelationDescriptor = descriptor;
		return Self;
	}

	public BucketCorrelationFunctionDescriptor CountCorrelation(Action<Elastic.Clients.Elasticsearch.Aggregations.BucketCorrelationFunctionCountCorrelationDescriptor> configure)
	{
		CountCorrelationValue = null;
		CountCorrelationDescriptor = null;
		CountCorrelationDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (CountCorrelationDescriptor is not null)
		{
			writer.WritePropertyName("count_correlation");
			JsonSerializer.Serialize(writer, CountCorrelationDescriptor, options);
		}
		else if (CountCorrelationDescriptorAction is not null)
		{
			writer.WritePropertyName("count_correlation");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Aggregations.BucketCorrelationFunctionCountCorrelationDescriptor(CountCorrelationDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("count_correlation");
			JsonSerializer.Serialize(writer, CountCorrelationValue, options);
		}

		writer.WriteEndObject();
	}
}