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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed partial class SettingsSimilarityBm25 : ISettingsSimilarity
{
	[JsonInclude, JsonPropertyName("b")]
	public double? b { get; set; }
	[JsonInclude, JsonPropertyName("discount_overlaps")]
	public bool? DiscountOverlaps { get; set; }
	[JsonInclude, JsonPropertyName("k1")]
	public double? K1 { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "BM25";
}

public sealed partial class SettingsSimilarityBm25Descriptor : SerializableDescriptor<SettingsSimilarityBm25Descriptor>, IBuildableDescriptor<SettingsSimilarityBm25>
{
	internal SettingsSimilarityBm25Descriptor(Action<SettingsSimilarityBm25Descriptor> configure) => configure.Invoke(this);

	public SettingsSimilarityBm25Descriptor() : base()
	{
	}

	private double? bValue { get; set; }
	private bool? DiscountOverlapsValue { get; set; }
	private double? K1Value { get; set; }

	public SettingsSimilarityBm25Descriptor b(double? b)
	{
		bValue = b;
		return Self;
	}

	public SettingsSimilarityBm25Descriptor DiscountOverlaps(bool? discountOverlaps = true)
	{
		DiscountOverlapsValue = discountOverlaps;
		return Self;
	}

	public SettingsSimilarityBm25Descriptor K1(double? k1)
	{
		K1Value = k1;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (bValue.HasValue)
		{
			writer.WritePropertyName("b");
			writer.WriteNumberValue(bValue.Value);
		}

		if (DiscountOverlapsValue.HasValue)
		{
			writer.WritePropertyName("discount_overlaps");
			writer.WriteBooleanValue(DiscountOverlapsValue.Value);
		}

		if (K1Value.HasValue)
		{
			writer.WritePropertyName("k1");
			writer.WriteNumberValue(K1Value.Value);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("BM25");
		writer.WriteEndObject();
	}

	SettingsSimilarityBm25 IBuildableDescriptor<SettingsSimilarityBm25>.Build() => new()
	{
		b = bValue,
		DiscountOverlaps = DiscountOverlapsValue,
		K1 = K1Value
	};
}