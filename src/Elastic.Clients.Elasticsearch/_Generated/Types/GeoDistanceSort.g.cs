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
	internal sealed class GeoDistanceSortConverter : JsonConverter<GeoDistanceSort>
	{
		public override GeoDistanceSort Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			var variant = new GeoDistanceSort();
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					var property = reader.GetString();
					if (property == "distance_type")
					{
						variant.DistanceType = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.GeoDistanceType?>(ref reader, options);
						continue;
					}

					if (property == "ignore_unmapped")
					{
						variant.IgnoreUnmapped = JsonSerializer.Deserialize<bool?>(ref reader, options);
						continue;
					}

					if (property == "mode")
					{
						variant.Mode = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.SortMode?>(ref reader, options);
						continue;
					}

					if (property == "order")
					{
						variant.Order = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.SortOrder?>(ref reader, options);
						continue;
					}

					if (property == "unit")
					{
						variant.Unit = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.DistanceUnit?>(ref reader, options);
						continue;
					}

					variant.Field = property;
					reader.Read();
					variant.Location = JsonSerializer.Deserialize<IEnumerable<Elastic.Clients.Elasticsearch.GeoLocation>>(ref reader, options);
				}
			}

			reader.Read();
			return variant;
		}

		public override void Write(Utf8JsonWriter writer, GeoDistanceSort value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (value.Field is not null && value.Location is not null)
			{
				if (!options.TryGetClientSettings(out var settings))
				{
					throw new JsonException("Unable to retrive client settings for JsonSerializerOptions.");
				}

				var propertyName = settings.Inferrer.Field(value.Field);
				writer.WritePropertyName(propertyName);
				JsonSerializer.Serialize(writer, value.Location, options);
			}

			if (value.DistanceType is not null)
			{
				writer.WritePropertyName("distance_type");
				JsonSerializer.Serialize(writer, value.DistanceType, options);
			}

			if (value.IgnoreUnmapped.HasValue)
			{
				writer.WritePropertyName("ignore_unmapped");
				writer.WriteBooleanValue(value.IgnoreUnmapped.Value);
			}

			if (value.Mode is not null)
			{
				writer.WritePropertyName("mode");
				JsonSerializer.Serialize(writer, value.Mode, options);
			}

			if (value.Order is not null)
			{
				writer.WritePropertyName("order");
				JsonSerializer.Serialize(writer, value.Order, options);
			}

			if (value.Unit is not null)
			{
				writer.WritePropertyName("unit");
				JsonSerializer.Serialize(writer, value.Unit, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(GeoDistanceSortConverter))]
	public partial class GeoDistanceSort : ISortOptionsVariant
	{
		[JsonInclude]
		[JsonPropertyName("distance_type")]
		public Elastic.Clients.Elasticsearch.GeoDistanceType? DistanceType { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_unmapped")]
		public bool? IgnoreUnmapped { get; set; }

		[JsonInclude]
		[JsonPropertyName("location")]
		public IEnumerable<Elastic.Clients.Elasticsearch.GeoLocation> Location { get; set; }

		[JsonInclude]
		[JsonPropertyName("mode")]
		public Elastic.Clients.Elasticsearch.SortMode? Mode { get; set; }

		[JsonInclude]
		[JsonPropertyName("order")]
		public Elastic.Clients.Elasticsearch.SortOrder? Order { get; set; }

		[JsonInclude]
		[JsonPropertyName("unit")]
		public Elastic.Clients.Elasticsearch.DistanceUnit? Unit { get; set; }
	}

	public sealed partial class GeoDistanceSortDescriptor<TDocument> : SerializableDescriptorBase<GeoDistanceSortDescriptor<TDocument>>
	{
		internal GeoDistanceSortDescriptor(Action<GeoDistanceSortDescriptor<TDocument>> configure) => configure.Invoke(this);
		public GeoDistanceSortDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.GeoDistanceType? DistanceTypeValue { get; set; }

		private bool? IgnoreUnmappedValue { get; set; }

		private Elastic.Clients.Elasticsearch.SortMode? ModeValue { get; set; }

		private Elastic.Clients.Elasticsearch.SortOrder? OrderValue { get; set; }

		private Elastic.Clients.Elasticsearch.DistanceUnit? UnitValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.GeoLocation> LocationValue { get; set; }

		public GeoDistanceSortDescriptor<TDocument> DistanceType(Elastic.Clients.Elasticsearch.GeoDistanceType? distanceType)
		{
			DistanceTypeValue = distanceType;
			return Self;
		}

		public GeoDistanceSortDescriptor<TDocument> IgnoreUnmapped(bool? ignoreUnmapped = true)
		{
			IgnoreUnmappedValue = ignoreUnmapped;
			return Self;
		}

		public GeoDistanceSortDescriptor<TDocument> Mode(Elastic.Clients.Elasticsearch.SortMode? mode)
		{
			ModeValue = mode;
			return Self;
		}

		public GeoDistanceSortDescriptor<TDocument> Order(Elastic.Clients.Elasticsearch.SortOrder? order)
		{
			OrderValue = order;
			return Self;
		}

		public GeoDistanceSortDescriptor<TDocument> Unit(Elastic.Clients.Elasticsearch.DistanceUnit? unit)
		{
			UnitValue = unit;
			return Self;
		}

		public GeoDistanceSortDescriptor<TDocument> Location(IEnumerable<Elastic.Clients.Elasticsearch.GeoLocation> location)
		{
			LocationValue = location;
			return Self;
		}

		public GeoDistanceSortDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public GeoDistanceSortDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FieldValue is not null && LocationValue is not null)
			{
				var propertyName = settings.Inferrer.Field(FieldValue);
				writer.WritePropertyName(propertyName);
				JsonSerializer.Serialize(writer, LocationValue, options);
			}

			if (DistanceTypeValue is not null)
			{
				writer.WritePropertyName("distance_type");
				JsonSerializer.Serialize(writer, DistanceTypeValue, options);
			}

			if (IgnoreUnmappedValue.HasValue)
			{
				writer.WritePropertyName("ignore_unmapped");
				writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
			}

			if (ModeValue is not null)
			{
				writer.WritePropertyName("mode");
				JsonSerializer.Serialize(writer, ModeValue, options);
			}

			if (OrderValue is not null)
			{
				writer.WritePropertyName("order");
				JsonSerializer.Serialize(writer, OrderValue, options);
			}

			if (UnitValue is not null)
			{
				writer.WritePropertyName("unit");
				JsonSerializer.Serialize(writer, UnitValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class GeoDistanceSortDescriptor : SerializableDescriptorBase<GeoDistanceSortDescriptor>
	{
		internal GeoDistanceSortDescriptor(Action<GeoDistanceSortDescriptor> configure) => configure.Invoke(this);
		public GeoDistanceSortDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.GeoDistanceType? DistanceTypeValue { get; set; }

		private bool? IgnoreUnmappedValue { get; set; }

		private Elastic.Clients.Elasticsearch.SortMode? ModeValue { get; set; }

		private Elastic.Clients.Elasticsearch.SortOrder? OrderValue { get; set; }

		private Elastic.Clients.Elasticsearch.DistanceUnit? UnitValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.GeoLocation> LocationValue { get; set; }

		public GeoDistanceSortDescriptor DistanceType(Elastic.Clients.Elasticsearch.GeoDistanceType? distanceType)
		{
			DistanceTypeValue = distanceType;
			return Self;
		}

		public GeoDistanceSortDescriptor IgnoreUnmapped(bool? ignoreUnmapped = true)
		{
			IgnoreUnmappedValue = ignoreUnmapped;
			return Self;
		}

		public GeoDistanceSortDescriptor Mode(Elastic.Clients.Elasticsearch.SortMode? mode)
		{
			ModeValue = mode;
			return Self;
		}

		public GeoDistanceSortDescriptor Order(Elastic.Clients.Elasticsearch.SortOrder? order)
		{
			OrderValue = order;
			return Self;
		}

		public GeoDistanceSortDescriptor Unit(Elastic.Clients.Elasticsearch.DistanceUnit? unit)
		{
			UnitValue = unit;
			return Self;
		}

		public GeoDistanceSortDescriptor Location(IEnumerable<Elastic.Clients.Elasticsearch.GeoLocation> location)
		{
			LocationValue = location;
			return Self;
		}

		public GeoDistanceSortDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public GeoDistanceSortDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public GeoDistanceSortDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FieldValue is not null && LocationValue is not null)
			{
				var propertyName = settings.Inferrer.Field(FieldValue);
				writer.WritePropertyName(propertyName);
				JsonSerializer.Serialize(writer, LocationValue, options);
			}

			if (DistanceTypeValue is not null)
			{
				writer.WritePropertyName("distance_type");
				JsonSerializer.Serialize(writer, DistanceTypeValue, options);
			}

			if (IgnoreUnmappedValue.HasValue)
			{
				writer.WritePropertyName("ignore_unmapped");
				writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
			}

			if (ModeValue is not null)
			{
				writer.WritePropertyName("mode");
				JsonSerializer.Serialize(writer, ModeValue, options);
			}

			if (OrderValue is not null)
			{
				writer.WritePropertyName("order");
				JsonSerializer.Serialize(writer, OrderValue, options);
			}

			if (UnitValue is not null)
			{
				writer.WritePropertyName("unit");
				JsonSerializer.Serialize(writer, UnitValue, options);
			}

			writer.WriteEndObject();
		}
	}
}