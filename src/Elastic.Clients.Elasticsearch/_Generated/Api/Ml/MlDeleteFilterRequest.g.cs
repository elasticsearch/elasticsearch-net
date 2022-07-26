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
namespace Elastic.Clients.Elasticsearch.Ml
{
	public sealed class MlDeleteFilterRequestParameters : RequestParameters<MlDeleteFilterRequestParameters>
	{
	}

	public sealed partial class MlDeleteFilterRequest : PlainRequestBase<MlDeleteFilterRequestParameters>
	{
		public MlDeleteFilterRequest(Elastic.Clients.Elasticsearch.Id filter_id) : base(r => r.Required("filter_id", filter_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningDeleteFilter;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public sealed partial class MlDeleteFilterRequestDescriptor : RequestDescriptorBase<MlDeleteFilterRequestDescriptor, MlDeleteFilterRequestParameters>
	{
		internal MlDeleteFilterRequestDescriptor(Action<MlDeleteFilterRequestDescriptor> configure) => configure.Invoke(this);
		public MlDeleteFilterRequestDescriptor(Elastic.Clients.Elasticsearch.Id filter_id) : base(r => r.Required("filter_id", filter_id))
		{
		}

		internal MlDeleteFilterRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningDeleteFilter;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public MlDeleteFilterRequestDescriptor FilterId(Elastic.Clients.Elasticsearch.Id filter_id)
		{
			RouteValues.Required("filter_id", filter_id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}