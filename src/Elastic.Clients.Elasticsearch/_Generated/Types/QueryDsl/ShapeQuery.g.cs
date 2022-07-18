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
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class ShapeQuery : QueryBase, IQueryVariant
	{
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_unmapped")]
		public bool? IgnoreUnmapped { get; set; }

		[JsonInclude]
		[JsonPropertyName("shape")]
		public Elastic.Clients.Elasticsearch.QueryDsl.ShapeFieldQuery Shape { get; set; }
	}

	public sealed partial class ShapeQueryDescriptor<TDocument> : SerializableDescriptorBase<ShapeQueryDescriptor<TDocument>>
	{
		internal ShapeQueryDescriptor(Action<ShapeQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public ShapeQueryDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.ShapeFieldQuery ShapeValue { get; set; }

		private ShapeFieldQueryDescriptor<TDocument> ShapeDescriptor { get; set; }

		private Action<ShapeFieldQueryDescriptor<TDocument>> ShapeDescriptorAction { get; set; }

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private bool? IgnoreUnmappedValue { get; set; }

		public ShapeQueryDescriptor<TDocument> Shape(Elastic.Clients.Elasticsearch.QueryDsl.ShapeFieldQuery shape)
		{
			ShapeDescriptor = null;
			ShapeDescriptorAction = null;
			ShapeValue = shape;
			return Self;
		}

		public ShapeQueryDescriptor<TDocument> Shape(ShapeFieldQueryDescriptor<TDocument> descriptor)
		{
			ShapeValue = null;
			ShapeDescriptorAction = null;
			ShapeDescriptor = descriptor;
			return Self;
		}

		public ShapeQueryDescriptor<TDocument> Shape(Action<ShapeFieldQueryDescriptor<TDocument>> configure)
		{
			ShapeValue = null;
			ShapeDescriptor = null;
			ShapeDescriptorAction = configure;
			return Self;
		}

		public ShapeQueryDescriptor<TDocument> QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public ShapeQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public ShapeQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public ShapeQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public ShapeQueryDescriptor<TDocument> IgnoreUnmapped(bool? ignoreUnmapped = true)
		{
			IgnoreUnmappedValue = ignoreUnmapped;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ShapeDescriptor is not null)
			{
				writer.WritePropertyName("shape");
				JsonSerializer.Serialize(writer, ShapeDescriptor, options);
			}
			else if (ShapeDescriptorAction is not null)
			{
				writer.WritePropertyName("shape");
				JsonSerializer.Serialize(writer, new ShapeFieldQueryDescriptor<TDocument>(ShapeDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("shape");
				JsonSerializer.Serialize(writer, ShapeValue, options);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (IgnoreUnmappedValue.HasValue)
			{
				writer.WritePropertyName("ignore_unmapped");
				writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class ShapeQueryDescriptor : SerializableDescriptorBase<ShapeQueryDescriptor>
	{
		internal ShapeQueryDescriptor(Action<ShapeQueryDescriptor> configure) => configure.Invoke(this);
		public ShapeQueryDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.ShapeFieldQuery ShapeValue { get; set; }

		private ShapeFieldQueryDescriptor ShapeDescriptor { get; set; }

		private Action<ShapeFieldQueryDescriptor> ShapeDescriptorAction { get; set; }

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private bool? IgnoreUnmappedValue { get; set; }

		public ShapeQueryDescriptor Shape(Elastic.Clients.Elasticsearch.QueryDsl.ShapeFieldQuery shape)
		{
			ShapeDescriptor = null;
			ShapeDescriptorAction = null;
			ShapeValue = shape;
			return Self;
		}

		public ShapeQueryDescriptor Shape(ShapeFieldQueryDescriptor descriptor)
		{
			ShapeValue = null;
			ShapeDescriptorAction = null;
			ShapeDescriptor = descriptor;
			return Self;
		}

		public ShapeQueryDescriptor Shape(Action<ShapeFieldQueryDescriptor> configure)
		{
			ShapeValue = null;
			ShapeDescriptor = null;
			ShapeDescriptorAction = configure;
			return Self;
		}

		public ShapeQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public ShapeQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public ShapeQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public ShapeQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public ShapeQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public ShapeQueryDescriptor IgnoreUnmapped(bool? ignoreUnmapped = true)
		{
			IgnoreUnmappedValue = ignoreUnmapped;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ShapeDescriptor is not null)
			{
				writer.WritePropertyName("shape");
				JsonSerializer.Serialize(writer, ShapeDescriptor, options);
			}
			else if (ShapeDescriptorAction is not null)
			{
				writer.WritePropertyName("shape");
				JsonSerializer.Serialize(writer, new ShapeFieldQueryDescriptor(ShapeDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("shape");
				JsonSerializer.Serialize(writer, ShapeValue, options);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (IgnoreUnmappedValue.HasValue)
			{
				writer.WritePropertyName("ignore_unmapped");
				writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}