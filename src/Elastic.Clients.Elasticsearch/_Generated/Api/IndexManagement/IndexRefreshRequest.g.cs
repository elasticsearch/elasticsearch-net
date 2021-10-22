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
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndexRefreshRequestParameters : RequestParameters<IndexRefreshRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }
	}

	[InterfaceConverterAttribute(typeof(IndexRefreshRequestDescriptorConverter<IndexRefreshRequest>))]
	public partial interface IIndexRefreshRequest : IRequest<IndexRefreshRequestParameters>
	{
	}

	public partial class IndexRefreshRequest : PlainRequestBase<IndexRefreshRequestParameters>, IIndexRefreshRequest
	{
		public IndexRefreshRequest()
		{
		}

		public IndexRefreshRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementRefresh;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }
	}

	public partial class IndexRefreshRequestDescriptor : RequestDescriptorBase<IndexRefreshRequestDescriptor, IndexRefreshRequestParameters, IIndexRefreshRequest>, IIndexRefreshRequest
	{
		///<summary>/_refresh</summary>
        public IndexRefreshRequestDescriptor() : base()
		{
		}

		///<summary>/{index}/_refresh</summary>
        public IndexRefreshRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementRefresh;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public IndexRefreshRequestDescriptor AllowNoIndices(bool? allowNoIndices) => Qs("allow_no_indices", allowNoIndices);
		public IndexRefreshRequestDescriptor ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public IndexRefreshRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable) => Qs("ignore_unavailable", ignoreUnavailable);
	}

	internal sealed class IndexRefreshRequestDescriptorConverter<TReadAs> : JsonConverter<IIndexRefreshRequest> where TReadAs : class, IIndexRefreshRequest
	{
		public override IIndexRefreshRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => JsonSerializer.Deserialize<TReadAs>(ref reader, options);
		public override void Write(Utf8JsonWriter writer, IIndexRefreshRequest value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}