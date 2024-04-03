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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class PreviewDataFrameAnalyticsRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Previews the extracted features used by a data frame analytics config.</para>
/// </summary>
public sealed partial class PreviewDataFrameAnalyticsRequest : PlainRequest<PreviewDataFrameAnalyticsRequestParameters>
{
	public PreviewDataFrameAnalyticsRequest()
	{
	}

	public PreviewDataFrameAnalyticsRequest(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningPreviewDataFrameAnalytics;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.preview_data_frame_analytics";

	/// <summary>
	/// <para>A data frame analytics config as described in create data frame analytics<br/>jobs. Note that `id` and `dest` don’t need to be provided in the context of<br/>this API.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("config")]
	public Elastic.Clients.Elasticsearch.MachineLearning.DataframePreviewConfig? Config { get; set; }
}

/// <summary>
/// <para>Previews the extracted features used by a data frame analytics config.</para>
/// </summary>
public sealed partial class PreviewDataFrameAnalyticsRequestDescriptor<TDocument> : RequestDescriptor<PreviewDataFrameAnalyticsRequestDescriptor<TDocument>, PreviewDataFrameAnalyticsRequestParameters>
{
	internal PreviewDataFrameAnalyticsRequestDescriptor(Action<PreviewDataFrameAnalyticsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public PreviewDataFrameAnalyticsRequestDescriptor(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
	{
	}

	public PreviewDataFrameAnalyticsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningPreviewDataFrameAnalytics;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.preview_data_frame_analytics";

	public PreviewDataFrameAnalyticsRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id? id)
	{
		RouteValues.Optional("id", id);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.MachineLearning.DataframePreviewConfig? ConfigValue { get; set; }
	private Elastic.Clients.Elasticsearch.MachineLearning.DataframePreviewConfigDescriptor<TDocument> ConfigDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframePreviewConfigDescriptor<TDocument>> ConfigDescriptorAction { get; set; }

	/// <summary>
	/// <para>A data frame analytics config as described in create data frame analytics<br/>jobs. Note that `id` and `dest` don’t need to be provided in the context of<br/>this API.</para>
	/// </summary>
	public PreviewDataFrameAnalyticsRequestDescriptor<TDocument> Config(Elastic.Clients.Elasticsearch.MachineLearning.DataframePreviewConfig? config)
	{
		ConfigDescriptor = null;
		ConfigDescriptorAction = null;
		ConfigValue = config;
		return Self;
	}

	public PreviewDataFrameAnalyticsRequestDescriptor<TDocument> Config(Elastic.Clients.Elasticsearch.MachineLearning.DataframePreviewConfigDescriptor<TDocument> descriptor)
	{
		ConfigValue = null;
		ConfigDescriptorAction = null;
		ConfigDescriptor = descriptor;
		return Self;
	}

	public PreviewDataFrameAnalyticsRequestDescriptor<TDocument> Config(Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframePreviewConfigDescriptor<TDocument>> configure)
	{
		ConfigValue = null;
		ConfigDescriptor = null;
		ConfigDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ConfigDescriptor is not null)
		{
			writer.WritePropertyName("config");
			JsonSerializer.Serialize(writer, ConfigDescriptor, options);
		}
		else if (ConfigDescriptorAction is not null)
		{
			writer.WritePropertyName("config");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.MachineLearning.DataframePreviewConfigDescriptor<TDocument>(ConfigDescriptorAction), options);
		}
		else if (ConfigValue is not null)
		{
			writer.WritePropertyName("config");
			JsonSerializer.Serialize(writer, ConfigValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Previews the extracted features used by a data frame analytics config.</para>
/// </summary>
public sealed partial class PreviewDataFrameAnalyticsRequestDescriptor : RequestDescriptor<PreviewDataFrameAnalyticsRequestDescriptor, PreviewDataFrameAnalyticsRequestParameters>
{
	internal PreviewDataFrameAnalyticsRequestDescriptor(Action<PreviewDataFrameAnalyticsRequestDescriptor> configure) => configure.Invoke(this);

	public PreviewDataFrameAnalyticsRequestDescriptor(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
	{
	}

	public PreviewDataFrameAnalyticsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningPreviewDataFrameAnalytics;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.preview_data_frame_analytics";

	public PreviewDataFrameAnalyticsRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id? id)
	{
		RouteValues.Optional("id", id);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.MachineLearning.DataframePreviewConfig? ConfigValue { get; set; }
	private Elastic.Clients.Elasticsearch.MachineLearning.DataframePreviewConfigDescriptor ConfigDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframePreviewConfigDescriptor> ConfigDescriptorAction { get; set; }

	/// <summary>
	/// <para>A data frame analytics config as described in create data frame analytics<br/>jobs. Note that `id` and `dest` don’t need to be provided in the context of<br/>this API.</para>
	/// </summary>
	public PreviewDataFrameAnalyticsRequestDescriptor Config(Elastic.Clients.Elasticsearch.MachineLearning.DataframePreviewConfig? config)
	{
		ConfigDescriptor = null;
		ConfigDescriptorAction = null;
		ConfigValue = config;
		return Self;
	}

	public PreviewDataFrameAnalyticsRequestDescriptor Config(Elastic.Clients.Elasticsearch.MachineLearning.DataframePreviewConfigDescriptor descriptor)
	{
		ConfigValue = null;
		ConfigDescriptorAction = null;
		ConfigDescriptor = descriptor;
		return Self;
	}

	public PreviewDataFrameAnalyticsRequestDescriptor Config(Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframePreviewConfigDescriptor> configure)
	{
		ConfigValue = null;
		ConfigDescriptor = null;
		ConfigDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ConfigDescriptor is not null)
		{
			writer.WritePropertyName("config");
			JsonSerializer.Serialize(writer, ConfigDescriptor, options);
		}
		else if (ConfigDescriptorAction is not null)
		{
			writer.WritePropertyName("config");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.MachineLearning.DataframePreviewConfigDescriptor(ConfigDescriptorAction), options);
		}
		else if (ConfigValue is not null)
		{
			writer.WritePropertyName("config");
			JsonSerializer.Serialize(writer, ConfigValue, options);
		}

		writer.WriteEndObject();
	}
}