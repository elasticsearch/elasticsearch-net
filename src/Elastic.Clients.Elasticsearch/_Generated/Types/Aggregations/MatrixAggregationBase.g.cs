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
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public abstract partial class MatrixAggregationBase : AggregationBase
	{
		protected MatrixAggregationBase(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("fields")]
		public Elastic.Clients.Elasticsearch.Fields? Fields { get; set; }

		[JsonInclude]
		[JsonPropertyName("missing")]
		public Dictionary<Elastic.Clients.Elasticsearch.Field, double>? Missing { get; set; }
	}

	public sealed partial class MatrixAggregationBaseDescriptor<TDocument> : DescriptorBase<MatrixAggregationBaseDescriptor<TDocument>>
	{
		internal MatrixAggregationBaseDescriptor(Action<MatrixAggregationBaseDescriptor<TDocument>> configure) => configure.Invoke(this);
		public MatrixAggregationBaseDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private Dictionary<Elastic.Clients.Elasticsearch.Field, double>? MissingValue { get; set; }

		private string? NameValue { get; set; }

		public MatrixAggregationBaseDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public MatrixAggregationBaseDescriptor<TDocument> Fields<TValue>(Expression<Func<TDocument, TValue>> fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public MatrixAggregationBaseDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public MatrixAggregationBaseDescriptor<TDocument> Missing(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>> selector)
		{
			MissingValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>());
			return Self;
		}

		public MatrixAggregationBaseDescriptor<TDocument> Name(string? name)
		{
			NameValue = name;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (!string.IsNullOrEmpty(NameValue))
			{
				writer.WritePropertyName("name");
				writer.WriteStringValue(NameValue);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class MatrixAggregationBaseDescriptor : DescriptorBase<MatrixAggregationBaseDescriptor>
	{
		internal MatrixAggregationBaseDescriptor(Action<MatrixAggregationBaseDescriptor> configure) => configure.Invoke(this);
		public MatrixAggregationBaseDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private Dictionary<Elastic.Clients.Elasticsearch.Field, double>? MissingValue { get; set; }

		private string? NameValue { get; set; }

		public MatrixAggregationBaseDescriptor Fields(Elastic.Clients.Elasticsearch.Fields? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public MatrixAggregationBaseDescriptor Fields<TDocument, TValue>(Expression<Func<TDocument, TValue>> fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public MatrixAggregationBaseDescriptor Fields<TDocument>(Expression<Func<TDocument, object>> fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public MatrixAggregationBaseDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public MatrixAggregationBaseDescriptor Missing(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>> selector)
		{
			MissingValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>());
			return Self;
		}

		public MatrixAggregationBaseDescriptor Name(string? name)
		{
			NameValue = name;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (!string.IsNullOrEmpty(NameValue))
			{
				writer.WritePropertyName("name");
				writer.WriteStringValue(NameValue);
			}

			writer.WriteEndObject();
		}
	}
}