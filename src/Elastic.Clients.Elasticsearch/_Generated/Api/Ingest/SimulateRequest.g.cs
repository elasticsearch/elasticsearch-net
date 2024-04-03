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

namespace Elastic.Clients.Elasticsearch.Ingest;

public sealed partial class SimulateRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If `true`, the response includes output data for each processor in the executed pipeline.</para>
	/// </summary>
	public bool? Verbose { get => Q<bool?>("verbose"); set => Q("verbose", value); }
}

/// <summary>
/// <para>Executes an ingest pipeline against a set of provided documents.</para>
/// </summary>
public sealed partial class SimulateRequest : PlainRequest<SimulateRequestParameters>
{
	public SimulateRequest()
	{
	}

	public SimulateRequest(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestSimulate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ingest.simulate";

	/// <summary>
	/// <para>If `true`, the response includes output data for each processor in the executed pipeline.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Verbose { get => Q<bool?>("verbose"); set => Q("verbose", value); }

	/// <summary>
	/// <para>Sample documents to test in the pipeline.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("docs")]
	public ICollection<Elastic.Clients.Elasticsearch.Ingest.Document>? Docs { get; set; }

	/// <summary>
	/// <para>Pipeline to test.<br/>If you don’t specify the `pipeline` request path parameter, this parameter is required.<br/>If you specify both this and the request path parameter, the API only uses the request path parameter.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("pipeline")]
	public Elastic.Clients.Elasticsearch.Ingest.Pipeline? Pipeline { get; set; }
}

/// <summary>
/// <para>Executes an ingest pipeline against a set of provided documents.</para>
/// </summary>
public sealed partial class SimulateRequestDescriptor<TDocument> : RequestDescriptor<SimulateRequestDescriptor<TDocument>, SimulateRequestParameters>
{
	internal SimulateRequestDescriptor(Action<SimulateRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public SimulateRequestDescriptor(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
	{
	}

	public SimulateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestSimulate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ingest.simulate";

	public SimulateRequestDescriptor<TDocument> Verbose(bool? verbose = true) => Qs("verbose", verbose);

	public SimulateRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id? id)
	{
		RouteValues.Optional("id", id);
		return Self;
	}

	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Document>? DocsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.DocumentDescriptor DocsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.DocumentDescriptor> DocsDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.DocumentDescriptor>[] DocsDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.Pipeline? PipelineValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.PipelineDescriptor<TDocument> PipelineDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.PipelineDescriptor<TDocument>> PipelineDescriptorAction { get; set; }

	/// <summary>
	/// <para>Sample documents to test in the pipeline.</para>
	/// </summary>
	public SimulateRequestDescriptor<TDocument> Docs(ICollection<Elastic.Clients.Elasticsearch.Ingest.Document>? docs)
	{
		DocsDescriptor = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = null;
		DocsValue = docs;
		return Self;
	}

	public SimulateRequestDescriptor<TDocument> Docs(Elastic.Clients.Elasticsearch.Ingest.DocumentDescriptor descriptor)
	{
		DocsValue = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = null;
		DocsDescriptor = descriptor;
		return Self;
	}

	public SimulateRequestDescriptor<TDocument> Docs(Action<Elastic.Clients.Elasticsearch.Ingest.DocumentDescriptor> configure)
	{
		DocsValue = null;
		DocsDescriptor = null;
		DocsDescriptorActions = null;
		DocsDescriptorAction = configure;
		return Self;
	}

	public SimulateRequestDescriptor<TDocument> Docs(params Action<Elastic.Clients.Elasticsearch.Ingest.DocumentDescriptor>[] configure)
	{
		DocsValue = null;
		DocsDescriptor = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Pipeline to test.<br/>If you don’t specify the `pipeline` request path parameter, this parameter is required.<br/>If you specify both this and the request path parameter, the API only uses the request path parameter.</para>
	/// </summary>
	public SimulateRequestDescriptor<TDocument> Pipeline(Elastic.Clients.Elasticsearch.Ingest.Pipeline? pipeline)
	{
		PipelineDescriptor = null;
		PipelineDescriptorAction = null;
		PipelineValue = pipeline;
		return Self;
	}

	public SimulateRequestDescriptor<TDocument> Pipeline(Elastic.Clients.Elasticsearch.Ingest.PipelineDescriptor<TDocument> descriptor)
	{
		PipelineValue = null;
		PipelineDescriptorAction = null;
		PipelineDescriptor = descriptor;
		return Self;
	}

	public SimulateRequestDescriptor<TDocument> Pipeline(Action<Elastic.Clients.Elasticsearch.Ingest.PipelineDescriptor<TDocument>> configure)
	{
		PipelineValue = null;
		PipelineDescriptor = null;
		PipelineDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DocsDescriptor is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, DocsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (DocsDescriptorAction is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.DocumentDescriptor(DocsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (DocsDescriptorActions is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			foreach (var action in DocsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.DocumentDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (DocsValue is not null)
		{
			writer.WritePropertyName("docs");
			JsonSerializer.Serialize(writer, DocsValue, options);
		}

		if (PipelineDescriptor is not null)
		{
			writer.WritePropertyName("pipeline");
			JsonSerializer.Serialize(writer, PipelineDescriptor, options);
		}
		else if (PipelineDescriptorAction is not null)
		{
			writer.WritePropertyName("pipeline");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.PipelineDescriptor<TDocument>(PipelineDescriptorAction), options);
		}
		else if (PipelineValue is not null)
		{
			writer.WritePropertyName("pipeline");
			JsonSerializer.Serialize(writer, PipelineValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Executes an ingest pipeline against a set of provided documents.</para>
/// </summary>
public sealed partial class SimulateRequestDescriptor : RequestDescriptor<SimulateRequestDescriptor, SimulateRequestParameters>
{
	internal SimulateRequestDescriptor(Action<SimulateRequestDescriptor> configure) => configure.Invoke(this);

	public SimulateRequestDescriptor(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
	{
	}

	public SimulateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestSimulate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ingest.simulate";

	public SimulateRequestDescriptor Verbose(bool? verbose = true) => Qs("verbose", verbose);

	public SimulateRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id? id)
	{
		RouteValues.Optional("id", id);
		return Self;
	}

	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Document>? DocsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.DocumentDescriptor DocsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.DocumentDescriptor> DocsDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.DocumentDescriptor>[] DocsDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.Pipeline? PipelineValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.PipelineDescriptor PipelineDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.PipelineDescriptor> PipelineDescriptorAction { get; set; }

	/// <summary>
	/// <para>Sample documents to test in the pipeline.</para>
	/// </summary>
	public SimulateRequestDescriptor Docs(ICollection<Elastic.Clients.Elasticsearch.Ingest.Document>? docs)
	{
		DocsDescriptor = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = null;
		DocsValue = docs;
		return Self;
	}

	public SimulateRequestDescriptor Docs(Elastic.Clients.Elasticsearch.Ingest.DocumentDescriptor descriptor)
	{
		DocsValue = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = null;
		DocsDescriptor = descriptor;
		return Self;
	}

	public SimulateRequestDescriptor Docs(Action<Elastic.Clients.Elasticsearch.Ingest.DocumentDescriptor> configure)
	{
		DocsValue = null;
		DocsDescriptor = null;
		DocsDescriptorActions = null;
		DocsDescriptorAction = configure;
		return Self;
	}

	public SimulateRequestDescriptor Docs(params Action<Elastic.Clients.Elasticsearch.Ingest.DocumentDescriptor>[] configure)
	{
		DocsValue = null;
		DocsDescriptor = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Pipeline to test.<br/>If you don’t specify the `pipeline` request path parameter, this parameter is required.<br/>If you specify both this and the request path parameter, the API only uses the request path parameter.</para>
	/// </summary>
	public SimulateRequestDescriptor Pipeline(Elastic.Clients.Elasticsearch.Ingest.Pipeline? pipeline)
	{
		PipelineDescriptor = null;
		PipelineDescriptorAction = null;
		PipelineValue = pipeline;
		return Self;
	}

	public SimulateRequestDescriptor Pipeline(Elastic.Clients.Elasticsearch.Ingest.PipelineDescriptor descriptor)
	{
		PipelineValue = null;
		PipelineDescriptorAction = null;
		PipelineDescriptor = descriptor;
		return Self;
	}

	public SimulateRequestDescriptor Pipeline(Action<Elastic.Clients.Elasticsearch.Ingest.PipelineDescriptor> configure)
	{
		PipelineValue = null;
		PipelineDescriptor = null;
		PipelineDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DocsDescriptor is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, DocsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (DocsDescriptorAction is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.DocumentDescriptor(DocsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (DocsDescriptorActions is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			foreach (var action in DocsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.DocumentDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (DocsValue is not null)
		{
			writer.WritePropertyName("docs");
			JsonSerializer.Serialize(writer, DocsValue, options);
		}

		if (PipelineDescriptor is not null)
		{
			writer.WritePropertyName("pipeline");
			JsonSerializer.Serialize(writer, PipelineDescriptor, options);
		}
		else if (PipelineDescriptorAction is not null)
		{
			writer.WritePropertyName("pipeline");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.PipelineDescriptor(PipelineDescriptorAction), options);
		}
		else if (PipelineValue is not null)
		{
			writer.WritePropertyName("pipeline");
			JsonSerializer.Serialize(writer, PipelineValue, options);
		}

		writer.WriteEndObject();
	}
}