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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public sealed class IngestGetPipelineRequestParameters : RequestParameters<IngestGetPipelineRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public bool? Summary { get => Q<bool?>("summary"); set => Q("summary", value); }
	}

	public partial class IngestGetPipelineRequest : PlainRequestBase<IngestGetPipelineRequestParameters>
	{
		public IngestGetPipelineRequest()
		{
		}

		public IngestGetPipelineRequest(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IngestGetPipeline;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public bool? Summary { get => Q<bool?>("summary"); set => Q("summary", value); }
	}

	public sealed partial class IngestGetPipelineRequestDescriptor<TDocument> : RequestDescriptorBase<IngestGetPipelineRequestDescriptor<TDocument>, IngestGetPipelineRequestParameters>
	{
		internal IngestGetPipelineRequestDescriptor(Action<IngestGetPipelineRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public IngestGetPipelineRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IngestGetPipeline;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public IngestGetPipelineRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
		public IngestGetPipelineRequestDescriptor<TDocument> Summary(bool? summary = true) => Qs("summary", summary);
		public IngestGetPipelineRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id? id)
		{
			RouteValues.Optional("id", id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}

	public sealed partial class IngestGetPipelineRequestDescriptor : RequestDescriptorBase<IngestGetPipelineRequestDescriptor, IngestGetPipelineRequestParameters>
	{
		internal IngestGetPipelineRequestDescriptor(Action<IngestGetPipelineRequestDescriptor> configure) => configure.Invoke(this);
		public IngestGetPipelineRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IngestGetPipeline;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public IngestGetPipelineRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
		public IngestGetPipelineRequestDescriptor Summary(bool? summary = true) => Qs("summary", summary);
		public IngestGetPipelineRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id? id)
		{
			RouteValues.Optional("id", id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}