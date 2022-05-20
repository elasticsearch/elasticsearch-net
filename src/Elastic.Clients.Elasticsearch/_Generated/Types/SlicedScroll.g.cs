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
	public partial class SlicedScroll
	{
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonInclude]
		[JsonPropertyName("max")]
		public int Max { get; set; }
	}

	public sealed partial class SlicedScrollDescriptor<TDocument> : SerializableDescriptorBase<SlicedScrollDescriptor<TDocument>>
	{
		internal SlicedScrollDescriptor(Action<SlicedScrollDescriptor<TDocument>> configure) => configure.Invoke(this);
		public SlicedScrollDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private int IdValue { get; set; }

		private int MaxValue { get; set; }

		public SlicedScrollDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public SlicedScrollDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public SlicedScrollDescriptor<TDocument> Id(int id)
		{
			IdValue = id;
			return Self;
		}

		public SlicedScrollDescriptor<TDocument> Max(int max)
		{
			MaxValue = max;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			writer.WritePropertyName("id");
			writer.WriteNumberValue(IdValue);
			writer.WritePropertyName("max");
			writer.WriteNumberValue(MaxValue);
			writer.WriteEndObject();
		}
	}

	public sealed partial class SlicedScrollDescriptor : SerializableDescriptorBase<SlicedScrollDescriptor>
	{
		internal SlicedScrollDescriptor(Action<SlicedScrollDescriptor> configure) => configure.Invoke(this);
		public SlicedScrollDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private int IdValue { get; set; }

		private int MaxValue { get; set; }

		public SlicedScrollDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public SlicedScrollDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public SlicedScrollDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public SlicedScrollDescriptor Id(int id)
		{
			IdValue = id;
			return Self;
		}

		public SlicedScrollDescriptor Max(int max)
		{
			MaxValue = max;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			writer.WritePropertyName("id");
			writer.WriteNumberValue(IdValue);
			writer.WritePropertyName("max");
			writer.WriteNumberValue(MaxValue);
			writer.WriteEndObject();
		}
	}
}