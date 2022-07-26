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
	public sealed class RecoveryRequestParameters : RequestParameters<RecoveryRequestParameters>
	{
		[JsonIgnore]
		public bool? ActiveOnly { get => Q<bool?>("active_only"); set => Q("active_only", value); }

		[JsonIgnore]
		public bool? Detailed { get => Q<bool?>("detailed"); set => Q("detailed", value); }
	}

	public sealed partial class RecoveryRequest : PlainRequestBase<RecoveryRequestParameters>
	{
		public RecoveryRequest()
		{
		}

		public RecoveryRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementRecovery;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? ActiveOnly { get => Q<bool?>("active_only"); set => Q("active_only", value); }

		[JsonIgnore]
		public bool? Detailed { get => Q<bool?>("detailed"); set => Q("detailed", value); }
	}

	public sealed partial class RecoveryRequestDescriptor<TDocument> : RequestDescriptorBase<RecoveryRequestDescriptor<TDocument>, RecoveryRequestParameters>
	{
		internal RecoveryRequestDescriptor(Action<RecoveryRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public RecoveryRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementRecovery;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public RecoveryRequestDescriptor<TDocument> ActiveOnly(bool? activeOnly = true) => Qs("active_only", activeOnly);
		public RecoveryRequestDescriptor<TDocument> Detailed(bool? detailed = true) => Qs("detailed", detailed);
		public RecoveryRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices? indices)
		{
			RouteValues.Optional("index", indices);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}

	public sealed partial class RecoveryRequestDescriptor : RequestDescriptorBase<RecoveryRequestDescriptor, RecoveryRequestParameters>
	{
		internal RecoveryRequestDescriptor(Action<RecoveryRequestDescriptor> configure) => configure.Invoke(this);
		public RecoveryRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementRecovery;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public RecoveryRequestDescriptor ActiveOnly(bool? activeOnly = true) => Qs("active_only", activeOnly);
		public RecoveryRequestDescriptor Detailed(bool? detailed = true) => Qs("detailed", detailed);
		public RecoveryRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
		{
			RouteValues.Optional("index", indices);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}