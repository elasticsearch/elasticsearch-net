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
	public partial class Rescore
	{
		[JsonInclude]
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.RescoreQuery Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("window_size")]
		public int? WindowSize { get; set; }
	}

	public sealed partial class RescoreDescriptor<TDocument> : DescriptorBase<RescoreDescriptor<TDocument>>
	{
		internal RescoreDescriptor(Action<RescoreDescriptor<TDocument>> configure) => configure.Invoke(this);
		public RescoreDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.RescoreQuery QueryValue { get; set; }

		private RescoreQueryDescriptor<TDocument> QueryDescriptor { get; set; }

		private Action<RescoreQueryDescriptor<TDocument>> QueryDescriptorAction { get; set; }

		private int? WindowSizeValue { get; set; }

		public RescoreDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.RescoreQuery query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			QueryValue = query;
			return Self;
		}

		public RescoreDescriptor<TDocument> Query(RescoreQueryDescriptor<TDocument> descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptor = descriptor;
			return Self;
		}

		public RescoreDescriptor<TDocument> Query(Action<RescoreQueryDescriptor<TDocument>> configure)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptorAction = configure;
			return Self;
		}

		public RescoreDescriptor<TDocument> WindowSize(int? windowSize)
		{
			WindowSizeValue = windowSize;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, new RescoreQueryDescriptor<TDocument>(QueryDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			if (WindowSizeValue.HasValue)
			{
				writer.WritePropertyName("window_size");
				writer.WriteNumberValue(WindowSizeValue.Value);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class RescoreDescriptor : DescriptorBase<RescoreDescriptor>
	{
		internal RescoreDescriptor(Action<RescoreDescriptor> configure) => configure.Invoke(this);
		public RescoreDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.RescoreQuery QueryValue { get; set; }

		private RescoreQueryDescriptor QueryDescriptor { get; set; }

		private Action<RescoreQueryDescriptor> QueryDescriptorAction { get; set; }

		private int? WindowSizeValue { get; set; }

		public RescoreDescriptor Query(Elastic.Clients.Elasticsearch.RescoreQuery query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			QueryValue = query;
			return Self;
		}

		public RescoreDescriptor Query(RescoreQueryDescriptor descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptor = descriptor;
			return Self;
		}

		public RescoreDescriptor Query(Action<RescoreQueryDescriptor> configure)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptorAction = configure;
			return Self;
		}

		public RescoreDescriptor WindowSize(int? windowSize)
		{
			WindowSizeValue = windowSize;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, new RescoreQueryDescriptor(QueryDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			if (WindowSizeValue.HasValue)
			{
				writer.WritePropertyName("window_size");
				writer.WriteNumberValue(WindowSizeValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}