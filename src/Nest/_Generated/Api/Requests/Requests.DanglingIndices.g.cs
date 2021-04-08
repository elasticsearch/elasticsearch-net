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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using System;
using System.Text.Json.Serialization;
using Elastic.Transport;
using System.Collections.Generic;

#nullable restore
namespace Nest
{
	[JsonInterfaceConverter(typeof(InterfaceConverter<IDeleteDanglingIndexRequest, DeleteDanglingIndexRequest>))]
	public interface IDeleteDanglingIndexRequest : IRequest<DeleteDanglingIndexRequestParameters>
	{
	}

	public class DeleteDanglingIndexRequest : PlainRequestBase<DeleteDanglingIndexRequestParameters>, IDeleteDanglingIndexRequest
	{
		protected IDeleteDanglingIndexRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.DanglingIndicesDeleteDanglingIndex;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;
		///<summary>/_dangling/{index_uuid}</summary>
        public DeleteDanglingIndexRequest(IndexUuid indexUuid) : base(r => r)
		{
		}

		[JsonIgnore]
		public string StubB { get => Q<string>("stub_b"); set => Q("stub_b", value); }

		[JsonPropertyName("stub_c")]
		public string StubC
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}
}