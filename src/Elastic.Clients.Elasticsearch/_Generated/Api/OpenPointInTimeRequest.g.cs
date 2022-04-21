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
namespace Elastic.Clients.Elasticsearch
{
	public sealed class OpenPointInTimeRequestParameters : RequestParameters<OpenPointInTimeRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time KeepAlive { get => Q<Elastic.Clients.Elasticsearch.Time>("keep_alive"); set => Q("keep_alive", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }
	}

	public partial class OpenPointInTimeRequest : PlainRequestBase<OpenPointInTimeRequestParameters>
	{
		public OpenPointInTimeRequest(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceOpenPointInTime;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time KeepAlive { get => Q<Elastic.Clients.Elasticsearch.Time>("keep_alive"); set => Q("keep_alive", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }
	}

	public sealed partial class OpenPointInTimeRequestDescriptor<TDocument> : RequestDescriptorBase<OpenPointInTimeRequestDescriptor<TDocument>, OpenPointInTimeRequestParameters>
	{
		internal OpenPointInTimeRequestDescriptor(Action<OpenPointInTimeRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public OpenPointInTimeRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
		{
		}

		internal OpenPointInTimeRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceOpenPointInTime;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public OpenPointInTimeRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
		public OpenPointInTimeRequestDescriptor<TDocument> KeepAlive(Elastic.Clients.Elasticsearch.Time keepAlive) => Qs("keep_alive", keepAlive);
		public OpenPointInTimeRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices indices)
		{
			RouteValues.Required("index", indices);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}

	public sealed partial class OpenPointInTimeRequestDescriptor : RequestDescriptorBase<OpenPointInTimeRequestDescriptor, OpenPointInTimeRequestParameters>
	{
		internal OpenPointInTimeRequestDescriptor(Action<OpenPointInTimeRequestDescriptor> configure) => configure.Invoke(this);
		public OpenPointInTimeRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
		{
		}

		internal OpenPointInTimeRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceOpenPointInTime;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public OpenPointInTimeRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
		public OpenPointInTimeRequestDescriptor KeepAlive(Elastic.Clients.Elasticsearch.Time keepAlive) => Qs("keep_alive", keepAlive);
		public OpenPointInTimeRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices indices)
		{
			RouteValues.Required("index", indices);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}