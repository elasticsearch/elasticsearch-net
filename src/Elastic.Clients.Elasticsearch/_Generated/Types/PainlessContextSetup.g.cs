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
	public partial class PainlessContextSetup
	{
		[JsonInclude]
		[JsonPropertyName("document")]
		public object Document { get; set; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer Query { get; set; }
	}

	public sealed partial class PainlessContextSetupDescriptor<TDocument> : DescriptorBase<PainlessContextSetupDescriptor<TDocument>>
	{
		internal PainlessContextSetupDescriptor(Action<PainlessContextSetupDescriptor<TDocument>> configure) => configure.Invoke(this);
		public PainlessContextSetupDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer QueryValue { get; set; }

		private QueryDsl.QueryContainerDescriptor<TDocument> QueryDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor<TDocument>> QueryDescriptorAction { get; set; }

		private object DocumentValue { get; set; }

		private Elastic.Clients.Elasticsearch.IndexName IndexValue { get; set; }

		public PainlessContextSetupDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			QueryValue = query;
			return Self;
		}

		public PainlessContextSetupDescriptor<TDocument> Query(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptor = descriptor;
			return Self;
		}

		public PainlessContextSetupDescriptor<TDocument> Query(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptorAction = configure;
			return Self;
		}

		public PainlessContextSetupDescriptor<TDocument> Document(object document)
		{
			DocumentValue = document;
			return Self;
		}

		public PainlessContextSetupDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName index)
		{
			IndexValue = index;
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
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(QueryDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
			writer.WriteEndObject();
		}
	}

	public sealed partial class PainlessContextSetupDescriptor : DescriptorBase<PainlessContextSetupDescriptor>
	{
		internal PainlessContextSetupDescriptor(Action<PainlessContextSetupDescriptor> configure) => configure.Invoke(this);
		public PainlessContextSetupDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer QueryValue { get; set; }

		private QueryDsl.QueryContainerDescriptor QueryDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor> QueryDescriptorAction { get; set; }

		private object DocumentValue { get; set; }

		private Elastic.Clients.Elasticsearch.IndexName IndexValue { get; set; }

		public PainlessContextSetupDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			QueryValue = query;
			return Self;
		}

		public PainlessContextSetupDescriptor Query(QueryDsl.QueryContainerDescriptor descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptor = descriptor;
			return Self;
		}

		public PainlessContextSetupDescriptor Query(Action<QueryDsl.QueryContainerDescriptor> configure)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptorAction = configure;
			return Self;
		}

		public PainlessContextSetupDescriptor Document(object document)
		{
			DocumentValue = document;
			return Self;
		}

		public PainlessContextSetupDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index)
		{
			IndexValue = index;
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
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor(QueryDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
			writer.WriteEndObject();
		}
	}
}