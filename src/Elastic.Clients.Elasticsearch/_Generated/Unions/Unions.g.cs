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
using OneOf;
using Elastic.Transport;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public partial class ByteSize : Union<object?, string?>
	{
		public ByteSize(object? item) : base(item)
		{
		}

		public ByteSize(string? item) : base(item)
		{
		}
	}

	public partial class Context : Union<string?, Elastic.Clients.Elasticsearch.QueryDsl.GeoLocation?>
	{
		public Context(string? item) : base(item)
		{
		}

		public Context(Elastic.Clients.Elasticsearch.QueryDsl.GeoLocation? item) : base(item)
		{
		}
	}

	public partial class EpochMillis : Union<string?, object?>
	{
		public EpochMillis(string? item) : base(item)
		{
		}

		public EpochMillis(object? item) : base(item)
		{
		}
	}

	public partial class ExpandWildcards
	{
	}

	public partial class Fuzziness : Union<string?, int?>
	{
		public Fuzziness(string? item) : base(item)
		{
		}

		public Fuzziness(int? item) : base(item)
		{
		}
	}

	public partial class Ids
	{
		private readonly List<Id> _idList = new();
	}

	public partial class MinimumShouldMatch : Union<int?, string?>
	{
		public MinimumShouldMatch(int? item) : base(item)
		{
		}

		public MinimumShouldMatch(string? item) : base(item)
		{
		}
	}

	public partial class Percentage : Union<string?, float?>
	{
		public Percentage(string? item) : base(item)
		{
		}

		public Percentage(float? item) : base(item)
		{
		}
	}

	public partial class Script
	{
	}

	public partial class Sort
	{
		private readonly List<SortCombinations> _sortCombinationsList = new();
	}

	public partial class SortCombinations
	{
	}

	public partial class SuggestOption<TDocument>
	{
	}

	public partial class Time : Union<string?, int?>
	{
		public Time(string? item) : base(item)
		{
		}

		public Time(int? item) : base(item)
		{
		}
	}

	public partial class Types
	{
		private readonly List<DocType> _docTypeList = new();
	}

	public partial class WaitForActiveShards : Union<int?, Elastic.Clients.Elasticsearch.WaitForActiveShardOptions?>
	{
		public WaitForActiveShards(int? item) : base(item)
		{
		}

		public WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShardOptions? item) : base(item)
		{
		}
	}
}