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

public sealed partial class GetInfluencersRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If true, the results are sorted in descending order.</para>
	/// </summary>
	public bool? Desc { get => Q<bool?>("desc"); set => Q("desc", value); }

	/// <summary>
	/// <para>Returns influencers with timestamps earlier than this time.<br/>The default value means it is unset and results are not limited to<br/>specific timestamps.</para>
	/// </summary>
	public DateTimeOffset? End { get => Q<DateTimeOffset?>("end"); set => Q("end", value); }

	/// <summary>
	/// <para>If true, the output excludes interim results. By default, interim results<br/>are included.</para>
	/// </summary>
	public bool? ExcludeInterim { get => Q<bool?>("exclude_interim"); set => Q("exclude_interim", value); }

	/// <summary>
	/// <para>Skips the specified number of influencers.</para>
	/// </summary>
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>Returns influencers with anomaly scores greater than or equal to this<br/>value.</para>
	/// </summary>
	public double? InfluencerScore { get => Q<double?>("influencer_score"); set => Q("influencer_score", value); }

	/// <summary>
	/// <para>Specifies the maximum number of influencers to obtain.</para>
	/// </summary>
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }

	/// <summary>
	/// <para>Specifies the sort field for the requested influencers. By default, the<br/>influencers are sorted by the `influencer_score` value.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Field? Sort { get => Q<Elastic.Clients.Elasticsearch.Field?>("sort"); set => Q("sort", value); }

	/// <summary>
	/// <para>Returns influencers with timestamps after this time. The default value<br/>means it is unset and results are not limited to specific timestamps.</para>
	/// </summary>
	public DateTimeOffset? Start { get => Q<DateTimeOffset?>("start"); set => Q("start", value); }
}

/// <summary>
/// <para>Retrieves anomaly detection job results for one or more influencers.<br/>Influencers are the entities that have contributed to, or are to blame for,<br/>the anomalies. Influencer results are available only if an<br/>`influencer_field_name` is specified in the job configuration.</para>
/// </summary>
public sealed partial class GetInfluencersRequest : PlainRequest<GetInfluencersRequestParameters>
{
	public GetInfluencersRequest(Elastic.Clients.Elasticsearch.Id jobId) : base(r => r.Required("job_id", jobId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningGetInfluencers;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.get_influencers";

	/// <summary>
	/// <para>If true, the results are sorted in descending order.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Desc { get => Q<bool?>("desc"); set => Q("desc", value); }

	/// <summary>
	/// <para>Returns influencers with timestamps earlier than this time.<br/>The default value means it is unset and results are not limited to<br/>specific timestamps.</para>
	/// </summary>
	[JsonIgnore]
	public DateTimeOffset? End { get => Q<DateTimeOffset?>("end"); set => Q("end", value); }

	/// <summary>
	/// <para>If true, the output excludes interim results. By default, interim results<br/>are included.</para>
	/// </summary>
	[JsonIgnore]
	public bool? ExcludeInterim { get => Q<bool?>("exclude_interim"); set => Q("exclude_interim", value); }

	/// <summary>
	/// <para>Skips the specified number of influencers.</para>
	/// </summary>
	[JsonIgnore]
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>Returns influencers with anomaly scores greater than or equal to this<br/>value.</para>
	/// </summary>
	[JsonIgnore]
	public double? InfluencerScore { get => Q<double?>("influencer_score"); set => Q("influencer_score", value); }

	/// <summary>
	/// <para>Specifies the maximum number of influencers to obtain.</para>
	/// </summary>
	[JsonIgnore]
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }

	/// <summary>
	/// <para>Specifies the sort field for the requested influencers. By default, the<br/>influencers are sorted by the `influencer_score` value.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Field? Sort { get => Q<Elastic.Clients.Elasticsearch.Field?>("sort"); set => Q("sort", value); }

	/// <summary>
	/// <para>Returns influencers with timestamps after this time. The default value<br/>means it is unset and results are not limited to specific timestamps.</para>
	/// </summary>
	[JsonIgnore]
	public DateTimeOffset? Start { get => Q<DateTimeOffset?>("start"); set => Q("start", value); }

	/// <summary>
	/// <para>Configures pagination.<br/>This parameter has the `from` and `size` properties.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("page")]
	public Elastic.Clients.Elasticsearch.MachineLearning.Page? Page { get; set; }
}

/// <summary>
/// <para>Retrieves anomaly detection job results for one or more influencers.<br/>Influencers are the entities that have contributed to, or are to blame for,<br/>the anomalies. Influencer results are available only if an<br/>`influencer_field_name` is specified in the job configuration.</para>
/// </summary>
public sealed partial class GetInfluencersRequestDescriptor<TDocument> : RequestDescriptor<GetInfluencersRequestDescriptor<TDocument>, GetInfluencersRequestParameters>
{
	internal GetInfluencersRequestDescriptor(Action<GetInfluencersRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GetInfluencersRequestDescriptor(Elastic.Clients.Elasticsearch.Id jobId) : base(r => r.Required("job_id", jobId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningGetInfluencers;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.get_influencers";

	public GetInfluencersRequestDescriptor<TDocument> Desc(bool? desc = true) => Qs("desc", desc);
	public GetInfluencersRequestDescriptor<TDocument> End(DateTimeOffset? end) => Qs("end", end);
	public GetInfluencersRequestDescriptor<TDocument> ExcludeInterim(bool? excludeInterim = true) => Qs("exclude_interim", excludeInterim);
	public GetInfluencersRequestDescriptor<TDocument> From(int? from) => Qs("from", from);
	public GetInfluencersRequestDescriptor<TDocument> InfluencerScore(double? influencerScore) => Qs("influencer_score", influencerScore);
	public GetInfluencersRequestDescriptor<TDocument> Size(int? size) => Qs("size", size);
	public GetInfluencersRequestDescriptor<TDocument> Sort(Elastic.Clients.Elasticsearch.Field? sort) => Qs("sort", sort);
	public GetInfluencersRequestDescriptor<TDocument> Start(DateTimeOffset? start) => Qs("start", start);

	public GetInfluencersRequestDescriptor<TDocument> JobId(Elastic.Clients.Elasticsearch.Id jobId)
	{
		RouteValues.Required("job_id", jobId);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.MachineLearning.Page? PageValue { get; set; }
	private Elastic.Clients.Elasticsearch.MachineLearning.PageDescriptor PageDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.MachineLearning.PageDescriptor> PageDescriptorAction { get; set; }

	/// <summary>
	/// <para>Configures pagination.<br/>This parameter has the `from` and `size` properties.</para>
	/// </summary>
	public GetInfluencersRequestDescriptor<TDocument> Page(Elastic.Clients.Elasticsearch.MachineLearning.Page? page)
	{
		PageDescriptor = null;
		PageDescriptorAction = null;
		PageValue = page;
		return Self;
	}

	public GetInfluencersRequestDescriptor<TDocument> Page(Elastic.Clients.Elasticsearch.MachineLearning.PageDescriptor descriptor)
	{
		PageValue = null;
		PageDescriptorAction = null;
		PageDescriptor = descriptor;
		return Self;
	}

	public GetInfluencersRequestDescriptor<TDocument> Page(Action<Elastic.Clients.Elasticsearch.MachineLearning.PageDescriptor> configure)
	{
		PageValue = null;
		PageDescriptor = null;
		PageDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (PageDescriptor is not null)
		{
			writer.WritePropertyName("page");
			JsonSerializer.Serialize(writer, PageDescriptor, options);
		}
		else if (PageDescriptorAction is not null)
		{
			writer.WritePropertyName("page");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.MachineLearning.PageDescriptor(PageDescriptorAction), options);
		}
		else if (PageValue is not null)
		{
			writer.WritePropertyName("page");
			JsonSerializer.Serialize(writer, PageValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Retrieves anomaly detection job results for one or more influencers.<br/>Influencers are the entities that have contributed to, or are to blame for,<br/>the anomalies. Influencer results are available only if an<br/>`influencer_field_name` is specified in the job configuration.</para>
/// </summary>
public sealed partial class GetInfluencersRequestDescriptor : RequestDescriptor<GetInfluencersRequestDescriptor, GetInfluencersRequestParameters>
{
	internal GetInfluencersRequestDescriptor(Action<GetInfluencersRequestDescriptor> configure) => configure.Invoke(this);

	public GetInfluencersRequestDescriptor(Elastic.Clients.Elasticsearch.Id jobId) : base(r => r.Required("job_id", jobId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningGetInfluencers;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ml.get_influencers";

	public GetInfluencersRequestDescriptor Desc(bool? desc = true) => Qs("desc", desc);
	public GetInfluencersRequestDescriptor End(DateTimeOffset? end) => Qs("end", end);
	public GetInfluencersRequestDescriptor ExcludeInterim(bool? excludeInterim = true) => Qs("exclude_interim", excludeInterim);
	public GetInfluencersRequestDescriptor From(int? from) => Qs("from", from);
	public GetInfluencersRequestDescriptor InfluencerScore(double? influencerScore) => Qs("influencer_score", influencerScore);
	public GetInfluencersRequestDescriptor Size(int? size) => Qs("size", size);
	public GetInfluencersRequestDescriptor Sort(Elastic.Clients.Elasticsearch.Field? sort) => Qs("sort", sort);
	public GetInfluencersRequestDescriptor Start(DateTimeOffset? start) => Qs("start", start);

	public GetInfluencersRequestDescriptor JobId(Elastic.Clients.Elasticsearch.Id jobId)
	{
		RouteValues.Required("job_id", jobId);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.MachineLearning.Page? PageValue { get; set; }
	private Elastic.Clients.Elasticsearch.MachineLearning.PageDescriptor PageDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.MachineLearning.PageDescriptor> PageDescriptorAction { get; set; }

	/// <summary>
	/// <para>Configures pagination.<br/>This parameter has the `from` and `size` properties.</para>
	/// </summary>
	public GetInfluencersRequestDescriptor Page(Elastic.Clients.Elasticsearch.MachineLearning.Page? page)
	{
		PageDescriptor = null;
		PageDescriptorAction = null;
		PageValue = page;
		return Self;
	}

	public GetInfluencersRequestDescriptor Page(Elastic.Clients.Elasticsearch.MachineLearning.PageDescriptor descriptor)
	{
		PageValue = null;
		PageDescriptorAction = null;
		PageDescriptor = descriptor;
		return Self;
	}

	public GetInfluencersRequestDescriptor Page(Action<Elastic.Clients.Elasticsearch.MachineLearning.PageDescriptor> configure)
	{
		PageValue = null;
		PageDescriptor = null;
		PageDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (PageDescriptor is not null)
		{
			writer.WritePropertyName("page");
			JsonSerializer.Serialize(writer, PageDescriptor, options);
		}
		else if (PageDescriptorAction is not null)
		{
			writer.WritePropertyName("page");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.MachineLearning.PageDescriptor(PageDescriptorAction), options);
		}
		else if (PageValue is not null)
		{
			writer.WritePropertyName("page");
			JsonSerializer.Serialize(writer, PageValue, options);
		}

		writer.WriteEndObject();
	}
}