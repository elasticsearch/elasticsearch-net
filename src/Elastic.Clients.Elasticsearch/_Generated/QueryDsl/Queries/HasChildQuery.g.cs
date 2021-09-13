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

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	[ConvertAs(typeof(HasChildQuery))]
	public partial interface IHasChildQuery : IQuery
	{
		bool? IgnoreUnmapped { get; set; }

		Elastic.Clients.Elasticsearch.Global.Search.InnerHits? InnerHits { get; set; }

		int? MaxChildren { get; set; }

		int? MinChildren { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.IQueryContainer Query { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.ChildScoreMode? ScoreMode { get; set; }

		Elastic.Clients.Elasticsearch.RelationName Type { get; set; }
	}

	public partial class HasChildQuery : QueryBase, IHasChildQuery
	{
		[JsonInclude]
		[JsonPropertyName("ignore_unmapped")]
		public bool? IgnoreUnmapped { get; set; }

		[JsonInclude]
		[JsonPropertyName("inner_hits")]
		public Elastic.Clients.Elasticsearch.Global.Search.InnerHits? InnerHits { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_children")]
		public int? MaxChildren { get; set; }

		[JsonInclude]
		[JsonPropertyName("min_children")]
		public int? MinChildren { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.IQueryContainer Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("score_mode")]
		public Elastic.Clients.Elasticsearch.QueryDsl.ChildScoreMode? ScoreMode { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public Elastic.Clients.Elasticsearch.RelationName Type { get; set; }
	}

	public partial class HasChildQueryDescriptor : QueryDescriptorBase<HasChildQueryDescriptor, IHasChildQuery>, IHasChildQuery
	{
		bool? IHasChildQuery.IgnoreUnmapped { get; set; }

		Elastic.Clients.Elasticsearch.Global.Search.InnerHits? IHasChildQuery.InnerHits { get; set; }

		int? IHasChildQuery.MaxChildren { get; set; }

		int? IHasChildQuery.MinChildren { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.IQueryContainer IHasChildQuery.Query { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.ChildScoreMode? IHasChildQuery.ScoreMode { get; set; }

		Elastic.Clients.Elasticsearch.RelationName IHasChildQuery.Type { get; set; }
	}
}