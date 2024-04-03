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

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class TrainedModelTreeNode
{
	[JsonInclude, JsonPropertyName("decision_type")]
	public string? DecisionType { get; set; }
	[JsonInclude, JsonPropertyName("default_left")]
	public bool? DefaultLeft { get; set; }
	[JsonInclude, JsonPropertyName("leaf_value")]
	public double? LeafValue { get; set; }
	[JsonInclude, JsonPropertyName("left_child")]
	public int? LeftChild { get; set; }
	[JsonInclude, JsonPropertyName("node_index")]
	public int NodeIndex { get; set; }
	[JsonInclude, JsonPropertyName("right_child")]
	public int? RightChild { get; set; }
	[JsonInclude, JsonPropertyName("split_feature")]
	public int? SplitFeature { get; set; }
	[JsonInclude, JsonPropertyName("split_gain")]
	public int? SplitGain { get; set; }
	[JsonInclude, JsonPropertyName("threshold")]
	public double? Threshold { get; set; }
}

public sealed partial class TrainedModelTreeNodeDescriptor : SerializableDescriptor<TrainedModelTreeNodeDescriptor>
{
	internal TrainedModelTreeNodeDescriptor(Action<TrainedModelTreeNodeDescriptor> configure) => configure.Invoke(this);

	public TrainedModelTreeNodeDescriptor() : base()
	{
	}

	private string? DecisionTypeValue { get; set; }
	private bool? DefaultLeftValue { get; set; }
	private double? LeafValueValue { get; set; }
	private int? LeftChildValue { get; set; }
	private int NodeIndexValue { get; set; }
	private int? RightChildValue { get; set; }
	private int? SplitFeatureValue { get; set; }
	private int? SplitGainValue { get; set; }
	private double? ThresholdValue { get; set; }

	public TrainedModelTreeNodeDescriptor DecisionType(string? decisionType)
	{
		DecisionTypeValue = decisionType;
		return Self;
	}

	public TrainedModelTreeNodeDescriptor DefaultLeft(bool? defaultLeft = true)
	{
		DefaultLeftValue = defaultLeft;
		return Self;
	}

	public TrainedModelTreeNodeDescriptor LeafValue(double? leafValue)
	{
		LeafValueValue = leafValue;
		return Self;
	}

	public TrainedModelTreeNodeDescriptor LeftChild(int? leftChild)
	{
		LeftChildValue = leftChild;
		return Self;
	}

	public TrainedModelTreeNodeDescriptor NodeIndex(int nodeIndex)
	{
		NodeIndexValue = nodeIndex;
		return Self;
	}

	public TrainedModelTreeNodeDescriptor RightChild(int? rightChild)
	{
		RightChildValue = rightChild;
		return Self;
	}

	public TrainedModelTreeNodeDescriptor SplitFeature(int? splitFeature)
	{
		SplitFeatureValue = splitFeature;
		return Self;
	}

	public TrainedModelTreeNodeDescriptor SplitGain(int? splitGain)
	{
		SplitGainValue = splitGain;
		return Self;
	}

	public TrainedModelTreeNodeDescriptor Threshold(double? threshold)
	{
		ThresholdValue = threshold;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(DecisionTypeValue))
		{
			writer.WritePropertyName("decision_type");
			writer.WriteStringValue(DecisionTypeValue);
		}

		if (DefaultLeftValue.HasValue)
		{
			writer.WritePropertyName("default_left");
			writer.WriteBooleanValue(DefaultLeftValue.Value);
		}

		if (LeafValueValue.HasValue)
		{
			writer.WritePropertyName("leaf_value");
			writer.WriteNumberValue(LeafValueValue.Value);
		}

		if (LeftChildValue.HasValue)
		{
			writer.WritePropertyName("left_child");
			writer.WriteNumberValue(LeftChildValue.Value);
		}

		writer.WritePropertyName("node_index");
		writer.WriteNumberValue(NodeIndexValue);
		if (RightChildValue.HasValue)
		{
			writer.WritePropertyName("right_child");
			writer.WriteNumberValue(RightChildValue.Value);
		}

		if (SplitFeatureValue.HasValue)
		{
			writer.WritePropertyName("split_feature");
			writer.WriteNumberValue(SplitFeatureValue.Value);
		}

		if (SplitGainValue.HasValue)
		{
			writer.WritePropertyName("split_gain");
			writer.WriteNumberValue(SplitGainValue.Value);
		}

		if (ThresholdValue.HasValue)
		{
			writer.WritePropertyName("threshold");
			writer.WriteNumberValue(ThresholdValue.Value);
		}

		writer.WriteEndObject();
	}
}