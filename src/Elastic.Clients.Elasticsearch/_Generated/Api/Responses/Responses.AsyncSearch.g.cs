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

using OneOf;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.AsyncSearch
{
	public partial class DeleteResponse : AcknowledgedResponseBase
	{
	}

	public partial class GetResponse<TDocument> : AsyncSearchDocumentResponseBase<TDocument>
	{
	}

	public partial class StatusResponse<TDocument> : AsyncSearch.AsyncSearchResponseBase
	{
		[JsonInclude]
		[JsonPropertyName("completion_status")]
		public int CompletionStatus
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_shards")]
		public Elastic.Clients.Elasticsearch.ShardStatistics Shards
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class SubmitResponse<TDocument> : AsyncSearchDocumentResponseBase<TDocument>
	{
	}
}