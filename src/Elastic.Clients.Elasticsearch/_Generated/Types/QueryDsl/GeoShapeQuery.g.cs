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
	internal sealed class GeoShapeQueryConverter : JsonConverter<GeoShapeQuery>
	{
		public override GeoShapeQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			var variant = new GeoShapeQuery();
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					var property = reader.GetString();
					if (property == "ignore_unmapped")
					{
						variant.IgnoreUnmapped = JsonSerializer.Deserialize<bool?>(ref reader, options);
						continue;
					}

					if (property == "_name")
					{
						variant.QueryName = JsonSerializer.Deserialize<string?>(ref reader, options);
						continue;
					}

					if (property == "boost")
					{
						variant.Boost = JsonSerializer.Deserialize<float?>(ref reader, options);
						continue;
					}

					variant.Field = property;
					reader.Read();
					variant.Shape = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.GeoShapeFieldQuery>(ref reader, options);
				}
			}

			reader.Read();
			return variant;
		}

		public override void Write(Utf8JsonWriter writer, GeoShapeQuery value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (value.Field is not null && value.Shape is not null)
			{
				if (!options.TryGetClientSettings(out var settings))
				{
					throw new JsonException("Unable to retrive client settings for JsonSerializerOptions.");
				}

				var propertyName = settings.Inferrer.Field(value.Field);
				writer.WritePropertyName(propertyName);
				JsonSerializer.Serialize(writer, value.Shape, options);
			}

			if (value.IgnoreUnmapped.HasValue)
			{
				writer.WritePropertyName("ignore_unmapped");
				writer.WriteBooleanValue(value.IgnoreUnmapped.Value);
			}

			if (!string.IsNullOrEmpty(value.QueryName))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(value.QueryName);
			}

			if (value.Boost.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(value.Boost.Value);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(GeoShapeQueryConverter))]
	public partial class GeoShapeQuery : QueryBase, IQueryVariant
	{
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		public bool? IgnoreUnmapped { get; set; }

		public Elastic.Clients.Elasticsearch.QueryDsl.GeoShapeFieldQuery Shape { get; set; }
	}

	public sealed partial class GeoShapeQueryDescriptor<TDocument> : SerializableDescriptorBase<GeoShapeQueryDescriptor<TDocument>>
	{
		internal GeoShapeQueryDescriptor(Action<GeoShapeQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public GeoShapeQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private bool? IgnoreUnmappedValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.GeoShapeFieldQuery ShapeValue { get; set; }

		private GeoShapeFieldQueryDescriptor<TDocument> ShapeDescriptor { get; set; }

		private Action<GeoShapeFieldQueryDescriptor<TDocument>> ShapeDescriptorAction { get; set; }

		public GeoShapeQueryDescriptor<TDocument> QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public GeoShapeQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public GeoShapeQueryDescriptor<TDocument> IgnoreUnmapped(bool? ignoreUnmapped = true)
		{
			IgnoreUnmappedValue = ignoreUnmapped;
			return Self;
		}

		public GeoShapeQueryDescriptor<TDocument> Shape(Elastic.Clients.Elasticsearch.QueryDsl.GeoShapeFieldQuery shape)
		{
			ShapeValue = shape;
			return Self;
		}

		public GeoShapeQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public GeoShapeQueryDescriptor<TDocument> Shape(GeoShapeFieldQueryDescriptor<TDocument> descriptor)
		{
			ShapeValue = null;
			ShapeDescriptorAction = null;
			ShapeDescriptor = descriptor;
			return Self;
		}

		public GeoShapeQueryDescriptor<TDocument> Shape(Action<GeoShapeFieldQueryDescriptor<TDocument>> configure)
		{
			ShapeValue = null;
			ShapeDescriptor = null;
			ShapeDescriptorAction = configure;
			return Self;
		}

		public GeoShapeQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FieldValue is not null && (ShapeValue is not null || ShapeDescriptor is not null || ShapeDescriptorAction is not null))
			{
				var propertyName = settings.Inferrer.Field(FieldValue);
				writer.WritePropertyName(propertyName);
				if (ShapeValue is not null)
				{
					JsonSerializer.Serialize(writer, ShapeValue, options);
				}
				else if (ShapeDescriptor is not null)
				{
					JsonSerializer.Serialize(writer, ShapeDescriptor, options);
				}
				else if (ShapeDescriptorAction is not null)
				{
					var descriptor = new GeoShapeFieldQueryDescriptor<TDocument>(ShapeDescriptorAction);
					JsonSerializer.Serialize(writer, descriptor, options);
				}
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

			if (IgnoreUnmappedValue.HasValue)
			{
				writer.WritePropertyName("ignore_unmapped");
				writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class GeoShapeQueryDescriptor : SerializableDescriptorBase<GeoShapeQueryDescriptor>
	{
		internal GeoShapeQueryDescriptor(Action<GeoShapeQueryDescriptor> configure) => configure.Invoke(this);
		public GeoShapeQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private bool? IgnoreUnmappedValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.GeoShapeFieldQuery ShapeValue { get; set; }

		private GeoShapeFieldQueryDescriptor ShapeDescriptor { get; set; }

		private Action<GeoShapeFieldQueryDescriptor> ShapeDescriptorAction { get; set; }

		public GeoShapeQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public GeoShapeQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public GeoShapeQueryDescriptor IgnoreUnmapped(bool? ignoreUnmapped = true)
		{
			IgnoreUnmappedValue = ignoreUnmapped;
			return Self;
		}

		public GeoShapeQueryDescriptor Shape(Elastic.Clients.Elasticsearch.QueryDsl.GeoShapeFieldQuery shape)
		{
			ShapeValue = shape;
			return Self;
		}

		public GeoShapeQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public GeoShapeQueryDescriptor Shape(GeoShapeFieldQueryDescriptor descriptor)
		{
			ShapeValue = null;
			ShapeDescriptorAction = null;
			ShapeDescriptor = descriptor;
			return Self;
		}

		public GeoShapeQueryDescriptor Shape(Action<GeoShapeFieldQueryDescriptor> configure)
		{
			ShapeValue = null;
			ShapeDescriptor = null;
			ShapeDescriptorAction = configure;
			return Self;
		}

		public GeoShapeQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public GeoShapeQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FieldValue is not null && (ShapeValue is not null || ShapeDescriptor is not null || ShapeDescriptorAction is not null))
			{
				var propertyName = settings.Inferrer.Field(FieldValue);
				writer.WritePropertyName(propertyName);
				if (ShapeValue is not null)
				{
					JsonSerializer.Serialize(writer, ShapeValue, options);
				}
				else if (ShapeDescriptor is not null)
				{
					JsonSerializer.Serialize(writer, ShapeDescriptor, options);
				}
				else if (ShapeDescriptorAction is not null)
				{
					var descriptor = new GeoShapeFieldQueryDescriptor(ShapeDescriptorAction);
					JsonSerializer.Serialize(writer, descriptor, options);
				}
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

			if (IgnoreUnmappedValue.HasValue)
			{
				writer.WritePropertyName("ignore_unmapped");
				writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}