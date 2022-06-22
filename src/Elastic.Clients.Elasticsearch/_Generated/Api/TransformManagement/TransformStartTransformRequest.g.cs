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
namespace Elastic.Clients.Elasticsearch.TransformManagement
{
	public sealed class TransformStartTransformRequestParameters : RequestParameters<TransformStartTransformRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
	}

	public partial class TransformStartTransformRequest : PlainRequestBase<TransformStartTransformRequestParameters>
	{
		public TransformStartTransformRequest(Elastic.Clients.Elasticsearch.Id transform_id) : base(r => r.Required("transform_id", transform_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformManagementStartTransform;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
	}

	public sealed partial class TransformStartTransformRequestDescriptor : RequestDescriptorBase<TransformStartTransformRequestDescriptor, TransformStartTransformRequestParameters>
	{
		internal TransformStartTransformRequestDescriptor(Action<TransformStartTransformRequestDescriptor> configure) => configure.Invoke(this);
		public TransformStartTransformRequestDescriptor(Elastic.Clients.Elasticsearch.Id transform_id) : base(r => r.Required("transform_id", transform_id))
		{
		}

		internal TransformStartTransformRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformManagementStartTransform;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public TransformStartTransformRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
		public TransformStartTransformRequestDescriptor TransformId(Elastic.Clients.Elasticsearch.Id transform_id)
		{
			RouteValues.Required("transform_id", transform_id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}