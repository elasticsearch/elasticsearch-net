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

namespace Elastic.Clients.Elasticsearch.Ingest;

public sealed partial class ProcessorGrokRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Run a grok processor.
/// Extract structured fields out of a single text field within a document.
/// You must choose which field to extract matched fields from, as well as the grok pattern you expect will match.
/// A grok pattern is like a regular expression that supports aliased expressions that can be reused.
/// </para>
/// </summary>
public sealed partial class ProcessorGrokRequest : PlainRequest<ProcessorGrokRequestParameters>
{
	[JsonConstructor]
	internal ProcessorGrokRequest()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestProcessorGrok;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ingest.processor_grok";
}

/// <summary>
/// <para>
/// Run a grok processor.
/// Extract structured fields out of a single text field within a document.
/// You must choose which field to extract matched fields from, as well as the grok pattern you expect will match.
/// A grok pattern is like a regular expression that supports aliased expressions that can be reused.
/// </para>
/// </summary>
public sealed partial class ProcessorGrokRequestDescriptor : RequestDescriptor<ProcessorGrokRequestDescriptor, ProcessorGrokRequestParameters>
{
	internal ProcessorGrokRequestDescriptor(Action<ProcessorGrokRequestDescriptor> configure) => configure.Invoke(this);

	public ProcessorGrokRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestProcessorGrok;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ingest.processor_grok";

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}