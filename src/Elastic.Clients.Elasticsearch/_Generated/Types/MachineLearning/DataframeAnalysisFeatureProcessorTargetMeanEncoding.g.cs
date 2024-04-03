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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class DataframeAnalysisFeatureProcessorTargetMeanEncoding
{
	/// <summary>
	/// <para>The default value if field value is not found in the target_map.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("default_value")]
	public int DefaultValue { get; set; }

	/// <summary>
	/// <para>The resulting feature name.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("feature_name")]
	public Elastic.Clients.Elasticsearch.Name FeatureName { get; set; }

	/// <summary>
	/// <para>The name of the field to encode.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	/// <summary>
	/// <para>The field value to target mean transition map.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("target_map")]
	public IDictionary<string, object> TargetMap { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessor(DataframeAnalysisFeatureProcessorTargetMeanEncoding dataframeAnalysisFeatureProcessorTargetMeanEncoding) => Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessor.TargetMeanEncoding(dataframeAnalysisFeatureProcessorTargetMeanEncoding);
}

public sealed partial class DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor<TDocument> : SerializableDescriptor<DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor<TDocument>>
{
	internal DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor(Action<DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor<TDocument>> configure) => configure.Invoke(this);

	public DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor() : base()
	{
	}

	private int DefaultValueValue { get; set; }
	private Elastic.Clients.Elasticsearch.Name FeatureNameValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private IDictionary<string, object> TargetMapValue { get; set; }

	/// <summary>
	/// <para>The default value if field value is not found in the target_map.</para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor<TDocument> DefaultValue(int defaultValue)
	{
		DefaultValueValue = defaultValue;
		return Self;
	}

	/// <summary>
	/// <para>The resulting feature name.</para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor<TDocument> FeatureName(Elastic.Clients.Elasticsearch.Name featureName)
	{
		FeatureNameValue = featureName;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field to encode.</para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field to encode.</para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field to encode.</para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field value to target mean transition map.</para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor<TDocument> TargetMap(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		TargetMapValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("default_value");
		writer.WriteNumberValue(DefaultValueValue);
		writer.WritePropertyName("feature_name");
		JsonSerializer.Serialize(writer, FeatureNameValue, options);
		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		writer.WritePropertyName("target_map");
		JsonSerializer.Serialize(writer, TargetMapValue, options);
		writer.WriteEndObject();
	}
}

public sealed partial class DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor : SerializableDescriptor<DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor>
{
	internal DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor(Action<DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor> configure) => configure.Invoke(this);

	public DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor() : base()
	{
	}

	private int DefaultValueValue { get; set; }
	private Elastic.Clients.Elasticsearch.Name FeatureNameValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private IDictionary<string, object> TargetMapValue { get; set; }

	/// <summary>
	/// <para>The default value if field value is not found in the target_map.</para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor DefaultValue(int defaultValue)
	{
		DefaultValueValue = defaultValue;
		return Self;
	}

	/// <summary>
	/// <para>The resulting feature name.</para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor FeatureName(Elastic.Clients.Elasticsearch.Name featureName)
	{
		FeatureNameValue = featureName;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field to encode.</para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field to encode.</para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field to encode.</para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field value to target mean transition map.</para>
	/// </summary>
	public DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor TargetMap(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		TargetMapValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("default_value");
		writer.WriteNumberValue(DefaultValueValue);
		writer.WritePropertyName("feature_name");
		JsonSerializer.Serialize(writer, FeatureNameValue, options);
		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		writer.WritePropertyName("target_map");
		JsonSerializer.Serialize(writer, TargetMapValue, options);
		writer.WriteEndObject();
	}
}