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
namespace Elastic.Clients.Elasticsearch.TransformManagement
{
	public interface ISyncVariant
	{
	}

	[JsonConverter(typeof(SyncContainerConverter))]
	public sealed partial class SyncContainer
	{
		internal SyncContainer(string variantName, ISyncVariant variant)
		{
			if (variantName is null)
				throw new ArgumentNullException(nameof(variantName));
			if (variant is null)
				throw new ArgumentNullException(nameof(variant));
			if (string.IsNullOrWhiteSpace(variantName))
				throw new ArgumentException("Variant name must not be empty or whitespace.");
			VariantName = variantName;
			Variant = variant;
		}

		internal ISyncVariant Variant { get; }

		internal string VariantName { get; }

		public static SyncContainer Time(Elastic.Clients.Elasticsearch.TransformManagement.TimeSync timeSync) => new SyncContainer("time", timeSync);
	}

	internal sealed class SyncContainerConverter : JsonConverter<SyncContainer>
	{
		public override SyncContainer Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
			{
				throw new JsonException("Expected start token.");
			}

			reader.Read();
			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException("Expected property name token.");
			}

			var propertyName = reader.GetString();
			reader.Read();
			if (propertyName == "time")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.TransformManagement.TimeSync?>(ref reader, options);
				reader.Read();
				return new SyncContainer(propertyName, variant);
			}

			throw new JsonException();
		}

		public override void Write(Utf8JsonWriter writer, SyncContainer value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName(value.VariantName);
			switch (value.VariantName)
			{
				case "time":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.TransformManagement.TimeSync>(writer, (Elastic.Clients.Elasticsearch.TransformManagement.TimeSync)value.Variant, options);
					break;
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class SyncContainerDescriptor<TDocument> : SerializableDescriptorBase<SyncContainerDescriptor<TDocument>>
	{
		internal SyncContainerDescriptor(Action<SyncContainerDescriptor<TDocument>> configure) => configure.Invoke(this);
		public SyncContainerDescriptor() : base()
		{
		}

		private bool ContainsVariant { get; set; }

		private string ContainedVariantName { get; set; }

		private object Variant { get; set; }

		private Descriptor Descriptor { get; set; }

		private void Set<T>(Action<T> descriptorAction, string variantName)
			where T : Descriptor
		{
			if (ContainsVariant)
				throw new InvalidOperationException("A variant has already been assigned to the SyncContainerDescriptor. Only a single SyncContainer variant can be added to this container type.");
			ContainedVariantName = variantName;
			ContainsVariant = true;
			var descriptor = (T)Activator.CreateInstance(typeof(T), true);
			descriptorAction?.Invoke(descriptor);
			Descriptor = descriptor;
		}

		private void Set(ISyncVariant variant, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("A variant has already been assigned to the SyncContainerDescriptor. Only a single SyncContainer variant can be added to this container type.");
			Variant = variant;
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		public void Time(TimeSync variant) => Set(variant, "time");
		public void Time(Action<TimeSyncDescriptor<TDocument>> configure) => Set(configure, "time");
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (!ContainsVariant)
			{
				writer.WriteNullValue();
				return;
			}

			writer.WriteStartObject();
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
			}
			else
			{
				JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class SyncContainerDescriptor : SerializableDescriptorBase<SyncContainerDescriptor>
	{
		internal SyncContainerDescriptor(Action<SyncContainerDescriptor> configure) => configure.Invoke(this);
		public SyncContainerDescriptor() : base()
		{
		}

		private bool ContainsVariant { get; set; }

		private string ContainedVariantName { get; set; }

		private object Variant { get; set; }

		private Descriptor Descriptor { get; set; }

		private void Set<T>(Action<T> descriptorAction, string variantName)
			where T : Descriptor
		{
			if (ContainsVariant)
				throw new InvalidOperationException("A variant has already been assigned to the SyncContainerDescriptor. Only a single SyncContainer variant can be added to this container type.");
			ContainedVariantName = variantName;
			ContainsVariant = true;
			var descriptor = (T)Activator.CreateInstance(typeof(T), true);
			descriptorAction?.Invoke(descriptor);
			Descriptor = descriptor;
		}

		private void Set(ISyncVariant variant, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("A variant has already been assigned to the SyncContainerDescriptor. Only a single SyncContainer variant can be added to this container type.");
			Variant = variant;
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		public void Time(TimeSync variant) => Set(variant, "time");
		public void Time(Action<TimeSyncDescriptor> configure) => Set(configure, "time");
		public void Time<TDocument>(Action<TimeSyncDescriptor<TDocument>> configure) => Set(configure, "time");
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (!ContainsVariant)
			{
				writer.WriteNullValue();
				return;
			}

			writer.WriteStartObject();
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
			}
			else
			{
				JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
			}

			writer.WriteEndObject();
		}
	}
}