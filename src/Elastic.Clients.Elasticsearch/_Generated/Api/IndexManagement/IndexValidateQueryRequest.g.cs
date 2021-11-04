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

using Elastic.Clients.Elasticsearch.Experimental;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndexValidateQueryRequestParameters : RequestParameters<IndexValidateQueryRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public bool? AllShards { get => Q<bool?>("all_shards"); set => Q("all_shards", value); }

		[JsonIgnore]
		public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

		[JsonIgnore]
		public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.DefaultOperator? DefaultOperator { get => Q<Elastic.Clients.Elasticsearch.DefaultOperator?>("default_operator"); set => Q("default_operator", value); }

		[JsonIgnore]
		public string? Df { get => Q<string?>("df"); set => Q("df", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? Explain { get => Q<bool?>("explain"); set => Q("explain", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

		[JsonIgnore]
		public bool? Rewrite { get => Q<bool?>("rewrite"); set => Q("rewrite", value); }

		[JsonIgnore]
		public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }
	}

	public partial class IndexValidateQueryRequest : PlainRequestBase<IndexValidateQueryRequestParameters>
	{
		public IndexValidateQueryRequest()
		{
		}

		public IndexValidateQueryRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementValidateQuery;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public bool? AllShards { get => Q<bool?>("all_shards"); set => Q("all_shards", value); }

		[JsonIgnore]
		public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

		[JsonIgnore]
		public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.DefaultOperator? DefaultOperator { get => Q<Elastic.Clients.Elasticsearch.DefaultOperator?>("default_operator"); set => Q("default_operator", value); }

		[JsonIgnore]
		public string? Df { get => Q<string?>("df"); set => Q("df", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? Explain { get => Q<bool?>("explain"); set => Q("explain", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

		[JsonIgnore]
		public bool? Rewrite { get => Q<bool?>("rewrite"); set => Q("rewrite", value); }

		[JsonIgnore]
		public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }

		[JsonInclude]
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Query { get; set; }
	}

	[JsonConverter(typeof(IndexValidateQueryRequestDescriptorConverter))]
	public sealed partial class IndexValidateQueryRequestDescriptor : RequestDescriptorBase<IndexValidateQueryRequestDescriptor, IndexValidateQueryRequestParameters>
	{
		public IndexValidateQueryRequestDescriptor()
		{
		}

		public IndexValidateQueryRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? _query;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementValidateQuery;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public IndexValidateQueryRequestDescriptor AllowNoIndices(bool? allowNoIndices) => Qs("allow_no_indices", allowNoIndices);
		public IndexValidateQueryRequestDescriptor AllShards(bool? allShards) => Qs("all_shards", allShards);
		public IndexValidateQueryRequestDescriptor Analyzer(string? analyzer) => Qs("analyzer", analyzer);
		public IndexValidateQueryRequestDescriptor AnalyzeWildcard(bool? analyzeWildcard) => Qs("analyze_wildcard", analyzeWildcard);
		public IndexValidateQueryRequestDescriptor DefaultOperator(Elastic.Clients.Elasticsearch.DefaultOperator? defaultOperator) => Qs("default_operator", defaultOperator);
		public IndexValidateQueryRequestDescriptor Df(string? df) => Qs("df", df);
		public IndexValidateQueryRequestDescriptor ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public IndexValidateQueryRequestDescriptor Explain(bool? explain) => Qs("explain", explain);
		public IndexValidateQueryRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable) => Qs("ignore_unavailable", ignoreUnavailable);
		public IndexValidateQueryRequestDescriptor Lenient(bool? lenient) => Qs("lenient", lenient);
		public IndexValidateQueryRequestDescriptor Rewrite(bool? rewrite) => Qs("rewrite", rewrite);
		public IndexValidateQueryRequestDescriptor QueryLuceneSyntax(string? q) => Qs("q", q);
		public IndexValidateQueryRequestDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? query) => Assign(query, (a, v) => a._query = v);
	}

	internal sealed class IndexValidateQueryRequestDescriptorConverter : JsonConverter<IndexValidateQueryRequestDescriptor>
	{
		public override IndexValidateQueryRequestDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, IndexValidateQueryRequestDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (value._query is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, value._query, options);
			}

			writer.WriteEndObject();
		}
	}
}