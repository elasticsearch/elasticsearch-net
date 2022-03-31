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
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public partial class SetSecurityUserProcessor : ProcessorBase, IProcessorContainerVariant
	{
		[JsonIgnore]
		string IProcessorContainerVariant.ProcessorContainerVariantName => "set_security_user";
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("properties")]
		public IEnumerable<string>? Properties { get; set; }
	}

	public sealed partial class SetSecurityUserProcessorDescriptor<TDocument> : DescriptorBase<SetSecurityUserProcessorDescriptor<TDocument>>
	{
		internal SetSecurityUserProcessorDescriptor(Action<SetSecurityUserProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);
		public SetSecurityUserProcessorDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private string? IfValue { get; set; }

		private bool? IgnoreFailureValue { get; set; }

		private IEnumerable<string>? PropertiesValue { get; set; }

		private string? TagValue { get; set; }

		public SetSecurityUserProcessorDescriptor<TDocument> OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure)
		{
			OnFailureValue = onFailure;
			return Self;
		}

		public SetSecurityUserProcessorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public SetSecurityUserProcessorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public SetSecurityUserProcessorDescriptor<TDocument> If(string? ifValue)
		{
			IfValue = ifValue;
			return Self;
		}

		public SetSecurityUserProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
		{
			IgnoreFailureValue = ignoreFailure;
			return Self;
		}

		public SetSecurityUserProcessorDescriptor<TDocument> Properties(IEnumerable<string>? properties)
		{
			PropertiesValue = properties;
			return Self;
		}

		public SetSecurityUserProcessorDescriptor<TDocument> Tag(string? tag)
		{
			TagValue = tag;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (!string.IsNullOrEmpty(IfValue))
			{
				writer.WritePropertyName("if");
				writer.WriteStringValue(IfValue);
			}

			if (IgnoreFailureValue.HasValue)
			{
				writer.WritePropertyName("ignore_failure");
				writer.WriteBooleanValue(IgnoreFailureValue.Value);
			}

			if (PropertiesValue is not null)
			{
				writer.WritePropertyName("properties");
				JsonSerializer.Serialize(writer, PropertiesValue, options);
			}

			if (!string.IsNullOrEmpty(TagValue))
			{
				writer.WritePropertyName("tag");
				writer.WriteStringValue(TagValue);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class SetSecurityUserProcessorDescriptor : DescriptorBase<SetSecurityUserProcessorDescriptor>
	{
		internal SetSecurityUserProcessorDescriptor(Action<SetSecurityUserProcessorDescriptor> configure) => configure.Invoke(this);
		public SetSecurityUserProcessorDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private string? IfValue { get; set; }

		private bool? IgnoreFailureValue { get; set; }

		private IEnumerable<string>? PropertiesValue { get; set; }

		private string? TagValue { get; set; }

		public SetSecurityUserProcessorDescriptor OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure)
		{
			OnFailureValue = onFailure;
			return Self;
		}

		public SetSecurityUserProcessorDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public SetSecurityUserProcessorDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public SetSecurityUserProcessorDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public SetSecurityUserProcessorDescriptor If(string? ifValue)
		{
			IfValue = ifValue;
			return Self;
		}

		public SetSecurityUserProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
		{
			IgnoreFailureValue = ignoreFailure;
			return Self;
		}

		public SetSecurityUserProcessorDescriptor Properties(IEnumerable<string>? properties)
		{
			PropertiesValue = properties;
			return Self;
		}

		public SetSecurityUserProcessorDescriptor Tag(string? tag)
		{
			TagValue = tag;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (!string.IsNullOrEmpty(IfValue))
			{
				writer.WritePropertyName("if");
				writer.WriteStringValue(IfValue);
			}

			if (IgnoreFailureValue.HasValue)
			{
				writer.WritePropertyName("ignore_failure");
				writer.WriteBooleanValue(IgnoreFailureValue.Value);
			}

			if (PropertiesValue is not null)
			{
				writer.WritePropertyName("properties");
				JsonSerializer.Serialize(writer, PropertiesValue, options);
			}

			if (!string.IsNullOrEmpty(TagValue))
			{
				writer.WritePropertyName("tag");
				writer.WriteStringValue(TagValue);
			}

			writer.WriteEndObject();
		}
	}
}