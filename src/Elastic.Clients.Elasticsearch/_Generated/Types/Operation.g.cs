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
	public sealed partial class Operation
	{
		[JsonInclude]
		[JsonPropertyName("_id")]
		public Elastic.Clients.Elasticsearch.Id Id { get; set; }

		[JsonInclude]
		[JsonPropertyName("_index")]
		public Elastic.Clients.Elasticsearch.IndexName? Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("_source")]
		public Elastic.Clients.Elasticsearch.SourceConfig? Source { get; set; }

		[JsonInclude]
		[JsonPropertyName("routing")]
		public Elastic.Clients.Elasticsearch.Routing? Routing { get; set; }

		[JsonInclude]
		[JsonPropertyName("stored_fields")]
		public Elastic.Clients.Elasticsearch.Fields? StoredFields { get; set; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public long? Version { get; set; }

		[JsonInclude]
		[JsonPropertyName("version_type")]
		public Elastic.Clients.Elasticsearch.VersionType? VersionType { get; set; }
	}

	public sealed partial class OperationDescriptor : SerializableDescriptorBase<OperationDescriptor>
	{
		internal OperationDescriptor(Action<OperationDescriptor> configure) => configure.Invoke(this);
		public OperationDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Id IdValue { get; set; }

		private Elastic.Clients.Elasticsearch.IndexName? IndexValue { get; set; }

		private Elastic.Clients.Elasticsearch.SourceConfig? SourceValue { get; set; }

		private Elastic.Clients.Elasticsearch.Routing? RoutingValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields? StoredFieldsValue { get; set; }

		private long? VersionValue { get; set; }

		private Elastic.Clients.Elasticsearch.VersionType? VersionTypeValue { get; set; }

		public OperationDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
		{
			IdValue = id;
			return Self;
		}

		public OperationDescriptor Index(Elastic.Clients.Elasticsearch.IndexName? index)
		{
			IndexValue = index;
			return Self;
		}

		public OperationDescriptor Source(Elastic.Clients.Elasticsearch.SourceConfig? source)
		{
			SourceValue = source;
			return Self;
		}

		public OperationDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing)
		{
			RoutingValue = routing;
			return Self;
		}

		public OperationDescriptor StoredFields(Elastic.Clients.Elasticsearch.Fields? storedFields)
		{
			StoredFieldsValue = storedFields;
			return Self;
		}

		public OperationDescriptor StoredFields<TDocument, TValue>(Expression<Func<TDocument, TValue>> storedFields)
		{
			StoredFieldsValue = storedFields;
			return Self;
		}

		public OperationDescriptor StoredFields<TDocument>(Expression<Func<TDocument, object>> storedFields)
		{
			StoredFieldsValue = storedFields;
			return Self;
		}

		public OperationDescriptor Version(long? version)
		{
			VersionValue = version;
			return Self;
		}

		public OperationDescriptor VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType)
		{
			VersionTypeValue = versionType;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("_id");
			JsonSerializer.Serialize(writer, IdValue, options);
			if (IndexValue is not null)
			{
				writer.WritePropertyName("_index");
				JsonSerializer.Serialize(writer, IndexValue, options);
			}

			if (SourceValue is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, SourceValue, options);
			}

			if (RoutingValue is not null)
			{
				writer.WritePropertyName("routing");
				JsonSerializer.Serialize(writer, RoutingValue, options);
			}

			if (StoredFieldsValue is not null)
			{
				writer.WritePropertyName("stored_fields");
				JsonSerializer.Serialize(writer, StoredFieldsValue, options);
			}

			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			if (VersionTypeValue is not null)
			{
				writer.WritePropertyName("version_type");
				JsonSerializer.Serialize(writer, VersionTypeValue, options);
			}

			writer.WriteEndObject();
		}
	}
}