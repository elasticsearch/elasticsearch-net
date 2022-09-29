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
	public sealed partial class RetentionPolicy
	{
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_age")]
		public Elastic.Clients.Elasticsearch.Duration MaxAge { get; set; }
	}

	public sealed partial class RetentionPolicyDescriptor<TDocument> : SerializableDescriptorBase<RetentionPolicyDescriptor<TDocument>>
	{
		internal RetentionPolicyDescriptor(Action<RetentionPolicyDescriptor<TDocument>> configure) => configure.Invoke(this);
		public RetentionPolicyDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Duration MaxAgeValue { get; set; }

		public RetentionPolicyDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public RetentionPolicyDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public RetentionPolicyDescriptor<TDocument> MaxAge(Elastic.Clients.Elasticsearch.Duration maxAge)
		{
			MaxAgeValue = maxAge;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			writer.WritePropertyName("max_age");
			JsonSerializer.Serialize(writer, MaxAgeValue, options);
			writer.WriteEndObject();
		}
	}

	public sealed partial class RetentionPolicyDescriptor : SerializableDescriptorBase<RetentionPolicyDescriptor>
	{
		internal RetentionPolicyDescriptor(Action<RetentionPolicyDescriptor> configure) => configure.Invoke(this);
		public RetentionPolicyDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Duration MaxAgeValue { get; set; }

		public RetentionPolicyDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public RetentionPolicyDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public RetentionPolicyDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public RetentionPolicyDescriptor MaxAge(Elastic.Clients.Elasticsearch.Duration maxAge)
		{
			MaxAgeValue = maxAge;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			writer.WritePropertyName("max_age");
			JsonSerializer.Serialize(writer, MaxAgeValue, options);
			writer.WriteEndObject();
		}
	}
}