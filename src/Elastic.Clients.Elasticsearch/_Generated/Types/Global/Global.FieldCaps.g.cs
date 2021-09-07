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

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Global.FieldCaps
{
	public partial class FieldCapabilitiesBodyIndexFilter
	{
		[JsonPropertyName("match_none")]
		public Elastic.Clients.Elasticsearch.EmptyObject? MatchNone { get; set; }

		[JsonPropertyName("range")]
		public Elastic.Clients.Elasticsearch.Global.FieldCaps.FieldCapabilitiesBodyIndexFilterRange? Range { get; set; }

		[JsonPropertyName("term")]
		public Elastic.Clients.Elasticsearch.Global.FieldCaps.FieldCapabilitiesBodyIndexFilterTerm? Term { get; set; }
	}

	public partial class FieldCapabilitiesBodyIndexFilterRange
	{
		[JsonPropertyName("timestamp")]
		public Elastic.Clients.Elasticsearch.Global.FieldCaps.FieldCapabilitiesBodyIndexFilterRangeTimestamp Timestamp { get; set; }
	}

	public partial class FieldCapabilitiesBodyIndexFilterRangeTimestamp
	{
		[JsonPropertyName("gt")]
		public int? Gt { get; set; }

		[JsonPropertyName("gte")]
		public int? Gte { get; set; }

		[JsonPropertyName("lt")]
		public int? Lt { get; set; }

		[JsonPropertyName("lte")]
		public int? Lte { get; set; }
	}

	public partial class FieldCapabilitiesBodyIndexFilterTerm
	{
		[JsonPropertyName("versionControl")]
		public Elastic.Clients.Elasticsearch.Global.FieldCaps.FieldCapabilitiesBodyIndexFilterTermVersionControl Versioncontrol { get; set; }
	}

	public partial class FieldCapabilitiesBodyIndexFilterTermVersionControl
	{
		[JsonPropertyName("value")]
		public string Value { get; set; }
	}

	public partial class FieldCapability
	{
		[JsonPropertyName("aggregatable")]
		public bool Aggregatable
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("indices")]
		public Elastic.Clients.Elasticsearch.Indices? Indices
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("meta")]
		public Dictionary<string, IReadOnlyCollection<string>>? Meta
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("metadata_field")]
		public bool? MetadataField
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("non_aggregatable_indices")]
		public Elastic.Clients.Elasticsearch.Indices? NonAggregatableIndices
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("non_searchable_indices")]
		public Elastic.Clients.Elasticsearch.Indices? NonSearchableIndices
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("searchable")]
		public bool Searchable
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("type")]
		public string Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}
}