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
	public class IndexGetAliasRequestParameters : RequestParameters<IndexGetAliasRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
	}

	public partial class IndexGetAliasRequest : PlainRequestBase<IndexGetAliasRequestParameters>
	{
		public IndexGetAliasRequest()
		{
		}

		public IndexGetAliasRequest(Elastic.Clients.Elasticsearch.Names? name) : base(r => r.Optional("name", name))
		{
		}

		public IndexGetAliasRequest(Elastic.Clients.Elasticsearch.Indices? indices, Elastic.Clients.Elasticsearch.Names? name) : base(r => r.Optional("index", indices).Optional("name", name))
		{
		}

		public IndexGetAliasRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementGetAlias;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
	}

	public sealed partial class IndexGetAliasRequestDescriptor : RequestDescriptorBase<IndexGetAliasRequestDescriptor, IndexGetAliasRequestParameters>
	{
		public IndexGetAliasRequestDescriptor()
		{
		}

		public IndexGetAliasRequestDescriptor(Elastic.Clients.Elasticsearch.Names? name) : base(r => r.Optional("name", name))
		{
		}

		public IndexGetAliasRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices, Elastic.Clients.Elasticsearch.Names? name) : base(r => r.Optional("index", indices).Optional("name", name))
		{
		}

		public IndexGetAliasRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal IndexGetAliasRequestDescriptor(Action<IndexGetAliasRequestDescriptor> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementGetAlias;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public IndexGetAliasRequestDescriptor AllowNoIndices(bool? allowNoIndices) => Qs("allow_no_indices", allowNoIndices);
		public IndexGetAliasRequestDescriptor ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public IndexGetAliasRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable) => Qs("ignore_unavailable", ignoreUnavailable);
		public IndexGetAliasRequestDescriptor Local(bool? local) => Qs("local", local);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}