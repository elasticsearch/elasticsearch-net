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

namespace Elastic.Clients.Elasticsearch.Serverless.QueryDsl;

public sealed partial class RankFeatureFunctionLogarithm
{
	/// <summary>
	/// <para>Configurable scaling factor.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("scaling_factor")]
	public float ScalingFactor { get; set; }
}

public sealed partial class RankFeatureFunctionLogarithmDescriptor : SerializableDescriptor<RankFeatureFunctionLogarithmDescriptor>
{
	internal RankFeatureFunctionLogarithmDescriptor(Action<RankFeatureFunctionLogarithmDescriptor> configure) => configure.Invoke(this);

	public RankFeatureFunctionLogarithmDescriptor() : base()
	{
	}

	private float ScalingFactorValue { get; set; }

	/// <summary>
	/// <para>Configurable scaling factor.</para>
	/// </summary>
	public RankFeatureFunctionLogarithmDescriptor ScalingFactor(float scalingFactor)
	{
		ScalingFactorValue = scalingFactor;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("scaling_factor");
		writer.WriteNumberValue(ScalingFactorValue);
		writer.WriteEndObject();
	}
}