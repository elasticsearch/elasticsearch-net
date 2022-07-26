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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public sealed partial class IndexVersioning
	{
		[JsonInclude]
		[JsonPropertyName("created")]
		public string Created { get; set; }

		[JsonInclude]
		[JsonPropertyName("created_string")]
		public string? CreatedString { get; set; }
	}

	public sealed partial class IndexVersioningDescriptor : SerializableDescriptorBase<IndexVersioningDescriptor>
	{
		internal IndexVersioningDescriptor(Action<IndexVersioningDescriptor> configure) => configure.Invoke(this);
		public IndexVersioningDescriptor() : base()
		{
		}

		private string CreatedValue { get; set; }

		private string? CreatedStringValue { get; set; }

		public IndexVersioningDescriptor Created(string created)
		{
			CreatedValue = created;
			return Self;
		}

		public IndexVersioningDescriptor CreatedString(string? createdString)
		{
			CreatedStringValue = createdString;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("created");
			JsonSerializer.Serialize(writer, CreatedValue, options);
			if (CreatedStringValue is not null)
			{
				writer.WritePropertyName("created_string");
				JsonSerializer.Serialize(writer, CreatedStringValue, options);
			}

			writer.WriteEndObject();
		}
	}
}