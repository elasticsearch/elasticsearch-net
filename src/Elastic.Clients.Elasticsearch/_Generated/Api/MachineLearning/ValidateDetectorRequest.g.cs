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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class ValidateDetectorRequestParameters : RequestParameters
{
}

internal sealed partial class ValidateDetectorRequestConverter : System.Text.Json.Serialization.JsonConverter<ValidateDetectorRequest>
{
	public override ValidateDetectorRequest Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		return new ValidateDetectorRequest { Detector = reader.ReadValue<Elastic.Clients.Elasticsearch.MachineLearning.Detector>(options) };
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, ValidateDetectorRequest value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteValue(options, value.Detector);
	}
}

/// <summary>
/// <para>
/// Validate an anomaly detection job.
/// </para>
/// </summary>
[JsonConverter(typeof(ValidateDetectorRequestConverter))]
public sealed partial class ValidateDetectorRequest : PlainRequest<ValidateDetectorRequestParameters>
{
	[JsonConstructor]
	internal ValidateDetectorRequest()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningValidateDetector;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.validate_detector";

	public Elastic.Clients.Elasticsearch.MachineLearning.Detector Detector { get; set; }
}

/// <summary>
/// <para>
/// Validate an anomaly detection job.
/// </para>
/// </summary>
public sealed partial class ValidateDetectorRequestDescriptor<TDocument> : RequestDescriptor<ValidateDetectorRequestDescriptor<TDocument>, ValidateDetectorRequestParameters>
{
	internal ValidateDetectorRequestDescriptor(Action<ValidateDetectorRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public ValidateDetectorRequestDescriptor(Elastic.Clients.Elasticsearch.MachineLearning.Detector detector) => DetectorValue = detector;

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningValidateDetector;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.validate_detector";

	private Elastic.Clients.Elasticsearch.MachineLearning.Detector DetectorValue { get; set; }
	private Elastic.Clients.Elasticsearch.MachineLearning.DetectorDescriptor<TDocument> DetectorDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.MachineLearning.DetectorDescriptor<TDocument>> DetectorDescriptorAction { get; set; }

	public ValidateDetectorRequestDescriptor<TDocument> Detector(Elastic.Clients.Elasticsearch.MachineLearning.Detector detector)
	{
		DetectorDescriptor = null;
		DetectorDescriptorAction = null;
		DetectorValue = detector;
		return Self;
	}

	public ValidateDetectorRequestDescriptor<TDocument> Detector(Elastic.Clients.Elasticsearch.MachineLearning.DetectorDescriptor<TDocument> descriptor)
	{
		DetectorValue = null;
		DetectorDescriptorAction = null;
		DetectorDescriptor = descriptor;
		return Self;
	}

	public ValidateDetectorRequestDescriptor<TDocument> Detector(Action<Elastic.Clients.Elasticsearch.MachineLearning.DetectorDescriptor<TDocument>> configure)
	{
		DetectorValue = null;
		DetectorDescriptor = null;
		DetectorDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		JsonSerializer.Serialize(writer, DetectorValue, options);
	}
}

/// <summary>
/// <para>
/// Validate an anomaly detection job.
/// </para>
/// </summary>
public sealed partial class ValidateDetectorRequestDescriptor : RequestDescriptor<ValidateDetectorRequestDescriptor, ValidateDetectorRequestParameters>
{
	internal ValidateDetectorRequestDescriptor(Action<ValidateDetectorRequestDescriptor> configure) => configure.Invoke(this);
	public ValidateDetectorRequestDescriptor(Elastic.Clients.Elasticsearch.MachineLearning.Detector detector) => DetectorValue = detector;

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningValidateDetector;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.validate_detector";

	private Elastic.Clients.Elasticsearch.MachineLearning.Detector DetectorValue { get; set; }
	private Elastic.Clients.Elasticsearch.MachineLearning.DetectorDescriptor DetectorDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.MachineLearning.DetectorDescriptor> DetectorDescriptorAction { get; set; }

	public ValidateDetectorRequestDescriptor Detector(Elastic.Clients.Elasticsearch.MachineLearning.Detector detector)
	{
		DetectorDescriptor = null;
		DetectorDescriptorAction = null;
		DetectorValue = detector;
		return Self;
	}

	public ValidateDetectorRequestDescriptor Detector(Elastic.Clients.Elasticsearch.MachineLearning.DetectorDescriptor descriptor)
	{
		DetectorValue = null;
		DetectorDescriptorAction = null;
		DetectorDescriptor = descriptor;
		return Self;
	}

	public ValidateDetectorRequestDescriptor Detector(Action<Elastic.Clients.Elasticsearch.MachineLearning.DetectorDescriptor> configure)
	{
		DetectorValue = null;
		DetectorDescriptor = null;
		DetectorDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		JsonSerializer.Serialize(writer, DetectorValue, options);
	}
}