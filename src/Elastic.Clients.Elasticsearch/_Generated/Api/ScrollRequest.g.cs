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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch;
public sealed class ScrollRequestParameters : RequestParameters<ScrollRequestParameters>
{
	[JsonIgnore]
	public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }
}

public sealed partial class ScrollRequest : PlainRequest<ScrollRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceScroll;
	internal override HttpMethod HttpMethod => HttpMethod.POST;
	internal override bool SupportsBody => true;
	[JsonIgnore]
	public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

	[JsonInclude]
	[JsonPropertyName("scroll")]
	public Elastic.Clients.Elasticsearch.Duration? Scroll { get; set; }

	[JsonInclude]
	[JsonPropertyName("scroll_id")]
	public Elastic.Clients.Elasticsearch.ScrollId ScrollId { get; set; }
}

public sealed partial class ScrollRequestDescriptor : RequestDescriptor<ScrollRequestDescriptor, ScrollRequestParameters>
{
	internal ScrollRequestDescriptor(Action<ScrollRequestDescriptor> configure) => configure.Invoke(this);
	public ScrollRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceScroll;
	internal override HttpMethod HttpMethod => HttpMethod.POST;
	internal override bool SupportsBody => true;
	public ScrollRequestDescriptor RestTotalHitsAsInt(bool? restTotalHitsAsInt = true) => Qs("rest_total_hits_as_int", restTotalHitsAsInt);
	private Elastic.Clients.Elasticsearch.Duration? ScrollValue { get; set; }

	private Elastic.Clients.Elasticsearch.ScrollId ScrollIdValue { get; set; }

	public ScrollRequestDescriptor Scroll(Elastic.Clients.Elasticsearch.Duration? scroll)
	{
		ScrollValue = scroll;
		return Self;
	}

	public ScrollRequestDescriptor ScrollId(Elastic.Clients.Elasticsearch.ScrollId scrollId)
	{
		ScrollIdValue = scrollId;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ScrollValue is not null)
		{
			writer.WritePropertyName("scroll");
			JsonSerializer.Serialize(writer, ScrollValue, options);
		}

		writer.WritePropertyName("scroll_id");
		JsonSerializer.Serialize(writer, ScrollIdValue, options);
		writer.WriteEndObject();
	}
}