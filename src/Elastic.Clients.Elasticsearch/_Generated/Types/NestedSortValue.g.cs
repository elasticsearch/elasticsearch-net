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
namespace Elastic.Clients.Elasticsearch
{
	public sealed partial class NestedSortValue
	{
		[JsonInclude]
		[JsonPropertyName("filter")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Filter { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_children")]
		public int? MaxChildren { get; set; }

		[JsonInclude]
		[JsonPropertyName("nested")]
		public Elastic.Clients.Elasticsearch.NestedSortValue? Nested { get; set; }

		[JsonInclude]
		[JsonPropertyName("path")]
		public Elastic.Clients.Elasticsearch.Field Path { get; set; }
	}

	public sealed partial class NestedSortValueDescriptor<TDocument> : SerializableDescriptorBase<NestedSortValueDescriptor<TDocument>>
	{
		internal NestedSortValueDescriptor(Action<NestedSortValueDescriptor<TDocument>> configure) => configure.Invoke(this);
		public NestedSortValueDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? FilterValue { get; set; }

		private QueryDsl.QueryContainerDescriptor<TDocument> FilterDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor<TDocument>> FilterDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.NestedSortValue? NestedValue { get; set; }

		private NestedSortValueDescriptor<TDocument> NestedDescriptor { get; set; }

		private Action<NestedSortValueDescriptor<TDocument>> NestedDescriptorAction { get; set; }

		private int? MaxChildrenValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field PathValue { get; set; }

		public NestedSortValueDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterValue = filter;
			return Self;
		}

		public NestedSortValueDescriptor<TDocument> Filter(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptor = descriptor;
			return Self;
		}

		public NestedSortValueDescriptor<TDocument> Filter(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			FilterValue = null;
			FilterDescriptor = null;
			FilterDescriptorAction = configure;
			return Self;
		}

		public NestedSortValueDescriptor<TDocument> Nested(Elastic.Clients.Elasticsearch.NestedSortValue? nested)
		{
			NestedDescriptor = null;
			NestedDescriptorAction = null;
			NestedValue = nested;
			return Self;
		}

		public NestedSortValueDescriptor<TDocument> Nested(NestedSortValueDescriptor<TDocument> descriptor)
		{
			NestedValue = null;
			NestedDescriptorAction = null;
			NestedDescriptor = descriptor;
			return Self;
		}

		public NestedSortValueDescriptor<TDocument> Nested(Action<NestedSortValueDescriptor<TDocument>> configure)
		{
			NestedValue = null;
			NestedDescriptor = null;
			NestedDescriptorAction = configure;
			return Self;
		}

		public NestedSortValueDescriptor<TDocument> MaxChildren(int? maxChildren)
		{
			MaxChildrenValue = maxChildren;
			return Self;
		}

		public NestedSortValueDescriptor<TDocument> Path(Elastic.Clients.Elasticsearch.Field path)
		{
			PathValue = path;
			return Self;
		}

		public NestedSortValueDescriptor<TDocument> Path<TValue>(Expression<Func<TDocument, TValue>> path)
		{
			PathValue = path;
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

			if (NestedDescriptor is not null)
			{
				writer.WritePropertyName("nested");
				JsonSerializer.Serialize(writer, NestedDescriptor, options);
			}
			else if (NestedDescriptorAction is not null)
			{
				writer.WritePropertyName("nested");
				JsonSerializer.Serialize(writer, new NestedSortValueDescriptor<TDocument>(NestedDescriptorAction), options);
			}
			else if (NestedValue is not null)
			{
				writer.WritePropertyName("nested");
				JsonSerializer.Serialize(writer, NestedValue, options);
			}

			if (MaxChildrenValue.HasValue)
			{
				writer.WritePropertyName("max_children");
				writer.WriteNumberValue(MaxChildrenValue.Value);
			}

			writer.WritePropertyName("path");
			JsonSerializer.Serialize(writer, PathValue, options);
			writer.WriteEndObject();
		}
	}

	public sealed partial class NestedSortValueDescriptor : SerializableDescriptorBase<NestedSortValueDescriptor>
	{
		internal NestedSortValueDescriptor(Action<NestedSortValueDescriptor> configure) => configure.Invoke(this);
		public NestedSortValueDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? FilterValue { get; set; }

		private QueryDsl.QueryContainerDescriptor FilterDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor> FilterDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.NestedSortValue? NestedValue { get; set; }

		private NestedSortValueDescriptor NestedDescriptor { get; set; }

		private Action<NestedSortValueDescriptor> NestedDescriptorAction { get; set; }

		private int? MaxChildrenValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field PathValue { get; set; }

		public NestedSortValueDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterValue = filter;
			return Self;
		}

		public NestedSortValueDescriptor Filter(QueryDsl.QueryContainerDescriptor descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptor = descriptor;
			return Self;
		}

		public NestedSortValueDescriptor Filter(Action<QueryDsl.QueryContainerDescriptor> configure)
		{
			FilterValue = null;
			FilterDescriptor = null;
			FilterDescriptorAction = configure;
			return Self;
		}

		public NestedSortValueDescriptor Nested(Elastic.Clients.Elasticsearch.NestedSortValue? nested)
		{
			NestedDescriptor = null;
			NestedDescriptorAction = null;
			NestedValue = nested;
			return Self;
		}

		public NestedSortValueDescriptor Nested(NestedSortValueDescriptor descriptor)
		{
			NestedValue = null;
			NestedDescriptorAction = null;
			NestedDescriptor = descriptor;
			return Self;
		}

		public NestedSortValueDescriptor Nested(Action<NestedSortValueDescriptor> configure)
		{
			NestedValue = null;
			NestedDescriptor = null;
			NestedDescriptorAction = configure;
			return Self;
		}

		public NestedSortValueDescriptor MaxChildren(int? maxChildren)
		{
			MaxChildrenValue = maxChildren;
			return Self;
		}

		public NestedSortValueDescriptor Path(Elastic.Clients.Elasticsearch.Field path)
		{
			PathValue = path;
			return Self;
		}

		public NestedSortValueDescriptor Path<TDocument, TValue>(Expression<Func<TDocument, TValue>> path)
		{
			PathValue = path;
			return Self;
		}

		public NestedSortValueDescriptor Path<TDocument>(Expression<Func<TDocument, object>> path)
		{
			PathValue = path;
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

			if (NestedDescriptor is not null)
			{
				writer.WritePropertyName("nested");
				JsonSerializer.Serialize(writer, NestedDescriptor, options);
			}
			else if (NestedDescriptorAction is not null)
			{
				writer.WritePropertyName("nested");
				JsonSerializer.Serialize(writer, new NestedSortValueDescriptor(NestedDescriptorAction), options);
			}
			else if (NestedValue is not null)
			{
				writer.WritePropertyName("nested");
				JsonSerializer.Serialize(writer, NestedValue, options);
			}

			if (MaxChildrenValue.HasValue)
			{
				writer.WritePropertyName("max_children");
				writer.WriteNumberValue(MaxChildrenValue.Value);
			}

			writer.WritePropertyName("path");
			JsonSerializer.Serialize(writer, PathValue, options);
			writer.WriteEndObject();
		}
	}
}