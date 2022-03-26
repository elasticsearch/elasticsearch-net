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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class CreateDataStreamRequestParameters : RequestParameters<CreateDataStreamRequestParameters>
	{
	}

	public partial class CreateDataStreamRequest : PlainRequestBase<CreateDataStreamRequestParameters>
	{
		public CreateDataStreamRequest(Elastic.Clients.Elasticsearch.DataStreamName name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementCreateDataStream;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
	}

	public sealed partial class CreateDataStreamRequestDescriptor : RequestDescriptorBase<CreateDataStreamRequestDescriptor, CreateDataStreamRequestParameters>
	{
		internal CreateDataStreamRequestDescriptor(Action<CreateDataStreamRequestDescriptor> configure) => configure.Invoke(this);
		public CreateDataStreamRequestDescriptor(Elastic.Clients.Elasticsearch.DataStreamName name) : base(r => r.Required("name", name))
		{
		}

		internal CreateDataStreamRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementCreateDataStream;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		public CreateDataStreamRequestDescriptor Name(Elastic.Clients.Elasticsearch.DataStreamName name)
		{
			RouteValues.Required("name", name);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}