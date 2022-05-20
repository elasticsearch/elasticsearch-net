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
	public partial class SourceFilter
	{
		[JsonInclude]
		[JsonPropertyName("excludes")]
		public Elastic.Clients.Elasticsearch.Fields? Excludes { get; set; }

		[JsonInclude]
		[JsonPropertyName("includes")]
		public Elastic.Clients.Elasticsearch.Fields? Includes { get; set; }
	}

	public sealed partial class SourceFilterDescriptor : SerializableDescriptorBase<SourceFilterDescriptor>
	{
		internal SourceFilterDescriptor(Action<SourceFilterDescriptor> configure) => configure.Invoke(this);
		public SourceFilterDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Fields? ExcludesValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields? IncludesValue { get; set; }

		public SourceFilterDescriptor Excludes(Elastic.Clients.Elasticsearch.Fields? excludes)
		{
			ExcludesValue = excludes;
			return Self;
		}

		public SourceFilterDescriptor Excludes<TDocument, TValue>(Expression<Func<TDocument, TValue>> excludes)
		{
			ExcludesValue = excludes;
			return Self;
		}

		public SourceFilterDescriptor Excludes<TDocument>(Expression<Func<TDocument, object>> excludes)
		{
			ExcludesValue = excludes;
			return Self;
		}

		public SourceFilterDescriptor Includes(Elastic.Clients.Elasticsearch.Fields? includes)
		{
			IncludesValue = includes;
			return Self;
		}

		public SourceFilterDescriptor Includes<TDocument, TValue>(Expression<Func<TDocument, TValue>> includes)
		{
			IncludesValue = includes;
			return Self;
		}

		public SourceFilterDescriptor Includes<TDocument>(Expression<Func<TDocument, object>> includes)
		{
			IncludesValue = includes;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ExcludesValue is not null)
			{
				writer.WritePropertyName("excludes");
				JsonSerializer.Serialize(writer, ExcludesValue, options);
			}

			if (IncludesValue is not null)
			{
				writer.WritePropertyName("includes");
				JsonSerializer.Serialize(writer, IncludesValue, options);
			}

			writer.WriteEndObject();
		}
	}
}