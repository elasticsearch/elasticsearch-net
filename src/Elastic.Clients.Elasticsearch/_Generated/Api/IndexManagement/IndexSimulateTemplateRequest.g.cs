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

using Elastic.Clients.Elasticsearch.Experimental;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndexSimulateTemplateRequestParameters : RequestParameters<IndexSimulateTemplateRequestParameters>
	{
		[JsonIgnore]
		public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }
	}

	public partial class IndexSimulateTemplateRequest : PlainRequestBase<IndexSimulateTemplateRequestParameters>
	{
		public IndexSimulateTemplateRequest()
		{
		}

		public IndexSimulateTemplateRequest(Elastic.Clients.Elasticsearch.Name? name) : base(r => r.Optional("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementSimulateTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }
	}

	[JsonConverter(typeof(IndexSimulateTemplateRequestDescriptorConverter))]
	public partial class IndexSimulateTemplateRequestDescriptor : RequestDescriptorBase<IndexSimulateTemplateRequestDescriptor, IndexSimulateTemplateRequestParameters>
	{
		public IndexSimulateTemplateRequestDescriptor()
		{
		}

		public IndexSimulateTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name? name) : base(r => r.Optional("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementSimulateTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public IndexSimulateTemplateRequestDescriptor Create(bool? create) => Qs("create", create);
		public IndexSimulateTemplateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
	}

	internal sealed class IndexSimulateTemplateRequestDescriptorConverter : JsonConverter<IndexSimulateTemplateRequestDescriptor>
	{
		public override IndexSimulateTemplateRequestDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, IndexSimulateTemplateRequestDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}