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
namespace Elastic.Clients.Elasticsearch.Mapping
{
	public partial class JoinProperty : PropertyBase, IProperty
	{
		[JsonInclude]
		[JsonPropertyName("relations")]
		public Dictionary<string, IEnumerable<string>>? Relations { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "join";
	}

	public sealed partial class JoinPropertyDescriptor<TDocument> : SerializableDescriptorBase<JoinPropertyDescriptor<TDocument>>, IBuildableDescriptor<JoinProperty>
	{
		internal JoinPropertyDescriptor(Action<JoinPropertyDescriptor<TDocument>> configure) => configure.Invoke(this);
		public JoinPropertyDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

		private int? IgnoreAboveValue { get; set; }

		private Dictionary<string, object>? LocalMetadataValue { get; set; }

		private Dictionary<string, string>? MetaValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

		private Dictionary<string, IEnumerable<string>>? RelationsValue { get; set; }

		public JoinPropertyDescriptor<TDocument> Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
		{
			DynamicValue = dynamic;
			return Self;
		}

		public JoinPropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public JoinPropertyDescriptor<TDocument> IgnoreAbove(int? ignoreAbove)
		{
			IgnoreAboveValue = ignoreAbove;
			return Self;
		}

		public JoinPropertyDescriptor<TDocument> LocalMetadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			LocalMetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public JoinPropertyDescriptor<TDocument> Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
			return Self;
		}

		public JoinPropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
		{
			PropertiesValue = properties;
			return Self;
		}

		public JoinPropertyDescriptor<TDocument> Relations(Func<FluentDictionary<string, IEnumerable<string>>, FluentDictionary<string, IEnumerable<string>>> selector)
		{
			RelationsValue = selector?.Invoke(new FluentDictionary<string, IEnumerable<string>>());
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (DynamicValue is not null)
			{
				writer.WritePropertyName("dynamic");
				JsonSerializer.Serialize(writer, DynamicValue, options);
			}

			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (IgnoreAboveValue.HasValue)
			{
				writer.WritePropertyName("ignore_above");
				writer.WriteNumberValue(IgnoreAboveValue.Value);
			}

			if (LocalMetadataValue is not null)
			{
				writer.WritePropertyName("local_metadata");
				JsonSerializer.Serialize(writer, LocalMetadataValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (PropertiesValue is not null)
			{
				writer.WritePropertyName("properties");
				JsonSerializer.Serialize(writer, PropertiesValue, options);
			}

			if (RelationsValue is not null)
			{
				writer.WritePropertyName("relations");
				JsonSerializer.Serialize(writer, RelationsValue, options);
			}

			writer.WritePropertyName("type");
			writer.WriteStringValue("join");
			writer.WriteEndObject();
		}

		JoinProperty IBuildableDescriptor<JoinProperty>.Build() => new()
		{ Dynamic = DynamicValue, Fields = FieldsValue, IgnoreAbove = IgnoreAboveValue, LocalMetadata = LocalMetadataValue, Meta = MetaValue, Properties = PropertiesValue, Relations = RelationsValue };
	}

	public sealed partial class JoinPropertyDescriptor : SerializableDescriptorBase<JoinPropertyDescriptor>, IBuildableDescriptor<JoinProperty>
	{
		internal JoinPropertyDescriptor(Action<JoinPropertyDescriptor> configure) => configure.Invoke(this);
		public JoinPropertyDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

		private int? IgnoreAboveValue { get; set; }

		private Dictionary<string, object>? LocalMetadataValue { get; set; }

		private Dictionary<string, string>? MetaValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

		private Dictionary<string, IEnumerable<string>>? RelationsValue { get; set; }

		public JoinPropertyDescriptor Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
		{
			DynamicValue = dynamic;
			return Self;
		}

		public JoinPropertyDescriptor Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public JoinPropertyDescriptor IgnoreAbove(int? ignoreAbove)
		{
			IgnoreAboveValue = ignoreAbove;
			return Self;
		}

		public JoinPropertyDescriptor LocalMetadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			LocalMetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public JoinPropertyDescriptor Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
			return Self;
		}

		public JoinPropertyDescriptor Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
		{
			PropertiesValue = properties;
			return Self;
		}

		public JoinPropertyDescriptor Relations(Func<FluentDictionary<string, IEnumerable<string>>, FluentDictionary<string, IEnumerable<string>>> selector)
		{
			RelationsValue = selector?.Invoke(new FluentDictionary<string, IEnumerable<string>>());
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (DynamicValue is not null)
			{
				writer.WritePropertyName("dynamic");
				JsonSerializer.Serialize(writer, DynamicValue, options);
			}

			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (IgnoreAboveValue.HasValue)
			{
				writer.WritePropertyName("ignore_above");
				writer.WriteNumberValue(IgnoreAboveValue.Value);
			}

			if (LocalMetadataValue is not null)
			{
				writer.WritePropertyName("local_metadata");
				JsonSerializer.Serialize(writer, LocalMetadataValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (PropertiesValue is not null)
			{
				writer.WritePropertyName("properties");
				JsonSerializer.Serialize(writer, PropertiesValue, options);
			}

			if (RelationsValue is not null)
			{
				writer.WritePropertyName("relations");
				JsonSerializer.Serialize(writer, RelationsValue, options);
			}

			writer.WritePropertyName("type");
			writer.WriteStringValue("join");
			writer.WriteEndObject();
		}

		JoinProperty IBuildableDescriptor<JoinProperty>.Build() => new()
		{ Dynamic = DynamicValue, Fields = FieldsValue, IgnoreAbove = IgnoreAboveValue, LocalMetadata = LocalMetadataValue, Meta = MetaValue, Properties = PropertiesValue, Relations = RelationsValue };
	}
}