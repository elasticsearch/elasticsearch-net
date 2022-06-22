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
namespace Elastic.Clients.Elasticsearch.Ilm
{
	public sealed class IlmExplainLifecycleRequestParameters : RequestParameters<IlmExplainLifecycleRequestParameters>
	{
		[JsonIgnore]
		public bool? OnlyErrors { get => Q<bool?>("only_errors"); set => Q("only_errors", value); }

		[JsonIgnore]
		public bool? OnlyManaged { get => Q<bool?>("only_managed"); set => Q("only_managed", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
	}

	public partial class IlmExplainLifecycleRequest : PlainRequestBase<IlmExplainLifecycleRequestParameters>
	{
		public IlmExplainLifecycleRequest(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementExplainLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? OnlyErrors { get => Q<bool?>("only_errors"); set => Q("only_errors", value); }

		[JsonIgnore]
		public bool? OnlyManaged { get => Q<bool?>("only_managed"); set => Q("only_managed", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
	}

	public sealed partial class IlmExplainLifecycleRequestDescriptor<TDocument> : RequestDescriptorBase<IlmExplainLifecycleRequestDescriptor<TDocument>, IlmExplainLifecycleRequestParameters>
	{
		internal IlmExplainLifecycleRequestDescriptor(Action<IlmExplainLifecycleRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public IlmExplainLifecycleRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		public IlmExplainLifecycleRequestDescriptor(TDocument document) : this(typeof(TDocument))
		{
		}

		internal IlmExplainLifecycleRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementExplainLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public IlmExplainLifecycleRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
		public IlmExplainLifecycleRequestDescriptor<TDocument> OnlyErrors(bool? onlyErrors = true) => Qs("only_errors", onlyErrors);
		public IlmExplainLifecycleRequestDescriptor<TDocument> OnlyManaged(bool? onlyManaged = true) => Qs("only_managed", onlyManaged);
		public IlmExplainLifecycleRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
		public IlmExplainLifecycleRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName index)
		{
			RouteValues.Required("index", index);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}

	public sealed partial class IlmExplainLifecycleRequestDescriptor : RequestDescriptorBase<IlmExplainLifecycleRequestDescriptor, IlmExplainLifecycleRequestParameters>
	{
		internal IlmExplainLifecycleRequestDescriptor(Action<IlmExplainLifecycleRequestDescriptor> configure) => configure.Invoke(this);
		public IlmExplainLifecycleRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		internal IlmExplainLifecycleRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementExplainLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public IlmExplainLifecycleRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
		public IlmExplainLifecycleRequestDescriptor OnlyErrors(bool? onlyErrors = true) => Qs("only_errors", onlyErrors);
		public IlmExplainLifecycleRequestDescriptor OnlyManaged(bool? onlyManaged = true) => Qs("only_managed", onlyManaged);
		public IlmExplainLifecycleRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
		public IlmExplainLifecycleRequestDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index)
		{
			RouteValues.Required("index", index);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}