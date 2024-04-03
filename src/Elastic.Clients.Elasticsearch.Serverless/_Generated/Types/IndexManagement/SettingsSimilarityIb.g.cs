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

public sealed partial class SettingsSimilarityIb : ISettingsSimilarity
{
	[JsonInclude, JsonPropertyName("distribution")]
	public Elastic.Clients.Elasticsearch.Serverless.IBDistribution Distribution { get; set; }
	[JsonInclude, JsonPropertyName("lambda")]
	public Elastic.Clients.Elasticsearch.Serverless.IBLambda Lambda { get; set; }
	[JsonInclude, JsonPropertyName("normalization")]
	public Elastic.Clients.Elasticsearch.Serverless.Normalization Normalization { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "IB";
}

public sealed partial class SettingsSimilarityIbDescriptor : SerializableDescriptor<SettingsSimilarityIbDescriptor>, IBuildableDescriptor<SettingsSimilarityIb>
{
	internal SettingsSimilarityIbDescriptor(Action<SettingsSimilarityIbDescriptor> configure) => configure.Invoke(this);

	public SettingsSimilarityIbDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.IBDistribution DistributionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IBLambda LambdaValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Normalization NormalizationValue { get; set; }

	public SettingsSimilarityIbDescriptor Distribution(Elastic.Clients.Elasticsearch.Serverless.IBDistribution distribution)
	{
		DistributionValue = distribution;
		return Self;
	}

	public SettingsSimilarityIbDescriptor Lambda(Elastic.Clients.Elasticsearch.Serverless.IBLambda lambda)
	{
		LambdaValue = lambda;
		return Self;
	}

	public SettingsSimilarityIbDescriptor Normalization(Elastic.Clients.Elasticsearch.Serverless.Normalization normalization)
	{
		NormalizationValue = normalization;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("distribution");
		JsonSerializer.Serialize(writer, DistributionValue, options);
		writer.WritePropertyName("lambda");
		JsonSerializer.Serialize(writer, LambdaValue, options);
		writer.WritePropertyName("normalization");
		JsonSerializer.Serialize(writer, NormalizationValue, options);
		writer.WritePropertyName("type");
		writer.WriteStringValue("IB");
		writer.WriteEndObject();
	}

	SettingsSimilarityIb IBuildableDescriptor<SettingsSimilarityIb>.Build() => new()
	{
		Distribution = DistributionValue,
		Lambda = LambdaValue,
		Normalization = NormalizationValue
	};
}