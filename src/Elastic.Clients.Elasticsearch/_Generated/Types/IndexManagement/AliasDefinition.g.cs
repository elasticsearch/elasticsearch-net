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
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public sealed partial class AliasDefinition
	{
		[JsonInclude]
		[JsonPropertyName("filter")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Filter { get; set; }

		[JsonInclude]
		[JsonPropertyName("index_routing")]
		public string? IndexRouting { get; set; }

		[JsonInclude]
		[JsonPropertyName("is_hidden")]
		public bool? IsHidden { get; set; }

		[JsonInclude]
		[JsonPropertyName("is_write_index")]
		public bool? IsWriteIndex { get; set; }

		[JsonInclude]
		[JsonPropertyName("routing")]
		public string? Routing { get; set; }

		[JsonInclude]
		[JsonPropertyName("search_routing")]
		public string? SearchRouting { get; set; }
	}

	public sealed partial class AliasDefinitionDescriptor<TDocument> : SerializableDescriptorBase<AliasDefinitionDescriptor<TDocument>>
	{
		internal AliasDefinitionDescriptor(Action<AliasDefinitionDescriptor<TDocument>> configure) => configure.Invoke(this);
		public AliasDefinitionDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? FilterValue { get; set; }

		private QueryDsl.QueryContainerDescriptor<TDocument> FilterDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor<TDocument>> FilterDescriptorAction { get; set; }

		private string? IndexRoutingValue { get; set; }

		private bool? IsHiddenValue { get; set; }

		private bool? IsWriteIndexValue { get; set; }

		private string? RoutingValue { get; set; }

		private string? SearchRoutingValue { get; set; }

		public AliasDefinitionDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterValue = filter;
			return Self;
		}

		public AliasDefinitionDescriptor<TDocument> Filter(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptor = descriptor;
			return Self;
		}

		public AliasDefinitionDescriptor<TDocument> Filter(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			FilterValue = null;
			FilterDescriptor = null;
			FilterDescriptorAction = configure;
			return Self;
		}

		public AliasDefinitionDescriptor<TDocument> IndexRouting(string? indexRouting)
		{
			IndexRoutingValue = indexRouting;
			return Self;
		}

		public AliasDefinitionDescriptor<TDocument> IsHidden(bool? isHidden = true)
		{
			IsHiddenValue = isHidden;
			return Self;
		}

		public AliasDefinitionDescriptor<TDocument> IsWriteIndex(bool? isWriteIndex = true)
		{
			IsWriteIndexValue = isWriteIndex;
			return Self;
		}

		public AliasDefinitionDescriptor<TDocument> Routing(string? routing)
		{
			RoutingValue = routing;
			return Self;
		}

		public AliasDefinitionDescriptor<TDocument> SearchRouting(string? searchRouting)
		{
			SearchRoutingValue = searchRouting;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FilterDescriptor is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterDescriptor, options);
			}
			else if (FilterDescriptorAction is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(FilterDescriptorAction), options);
			}
			else if (FilterValue is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterValue, options);
			}

			if (!string.IsNullOrEmpty(IndexRoutingValue))
			{
				writer.WritePropertyName("index_routing");
				writer.WriteStringValue(IndexRoutingValue);
			}

			if (IsHiddenValue.HasValue)
			{
				writer.WritePropertyName("is_hidden");
				writer.WriteBooleanValue(IsHiddenValue.Value);
			}

			if (IsWriteIndexValue.HasValue)
			{
				writer.WritePropertyName("is_write_index");
				writer.WriteBooleanValue(IsWriteIndexValue.Value);
			}

			if (!string.IsNullOrEmpty(RoutingValue))
			{
				writer.WritePropertyName("routing");
				writer.WriteStringValue(RoutingValue);
			}

			if (!string.IsNullOrEmpty(SearchRoutingValue))
			{
				writer.WritePropertyName("search_routing");
				writer.WriteStringValue(SearchRoutingValue);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class AliasDefinitionDescriptor : SerializableDescriptorBase<AliasDefinitionDescriptor>
	{
		internal AliasDefinitionDescriptor(Action<AliasDefinitionDescriptor> configure) => configure.Invoke(this);
		public AliasDefinitionDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? FilterValue { get; set; }

		private QueryDsl.QueryContainerDescriptor FilterDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor> FilterDescriptorAction { get; set; }

		private string? IndexRoutingValue { get; set; }

		private bool? IsHiddenValue { get; set; }

		private bool? IsWriteIndexValue { get; set; }

		private string? RoutingValue { get; set; }

		private string? SearchRoutingValue { get; set; }

		public AliasDefinitionDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterValue = filter;
			return Self;
		}

		public AliasDefinitionDescriptor Filter(QueryDsl.QueryContainerDescriptor descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptor = descriptor;
			return Self;
		}

		public AliasDefinitionDescriptor Filter(Action<QueryDsl.QueryContainerDescriptor> configure)
		{
			FilterValue = null;
			FilterDescriptor = null;
			FilterDescriptorAction = configure;
			return Self;
		}

		public AliasDefinitionDescriptor IndexRouting(string? indexRouting)
		{
			IndexRoutingValue = indexRouting;
			return Self;
		}

		public AliasDefinitionDescriptor IsHidden(bool? isHidden = true)
		{
			IsHiddenValue = isHidden;
			return Self;
		}

		public AliasDefinitionDescriptor IsWriteIndex(bool? isWriteIndex = true)
		{
			IsWriteIndexValue = isWriteIndex;
			return Self;
		}

		public AliasDefinitionDescriptor Routing(string? routing)
		{
			RoutingValue = routing;
			return Self;
		}

		public AliasDefinitionDescriptor SearchRouting(string? searchRouting)
		{
			SearchRoutingValue = searchRouting;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FilterDescriptor is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterDescriptor, options);
			}
			else if (FilterDescriptorAction is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor(FilterDescriptorAction), options);
			}
			else if (FilterValue is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterValue, options);
			}

			if (!string.IsNullOrEmpty(IndexRoutingValue))
			{
				writer.WritePropertyName("index_routing");
				writer.WriteStringValue(IndexRoutingValue);
			}

			if (IsHiddenValue.HasValue)
			{
				writer.WritePropertyName("is_hidden");
				writer.WriteBooleanValue(IsHiddenValue.Value);
			}

			if (IsWriteIndexValue.HasValue)
			{
				writer.WritePropertyName("is_write_index");
				writer.WriteBooleanValue(IsWriteIndexValue.Value);
			}

			if (!string.IsNullOrEmpty(RoutingValue))
			{
				writer.WritePropertyName("routing");
				writer.WriteStringValue(RoutingValue);
			}

			if (!string.IsNullOrEmpty(SearchRoutingValue))
			{
				writer.WritePropertyName("search_routing");
				writer.WriteStringValue(SearchRoutingValue);
			}

			writer.WriteEndObject();
		}
	}
}