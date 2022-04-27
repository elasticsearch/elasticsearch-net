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
namespace Elastic.Clients.Elasticsearch.Security
{
	public partial class RoleDescriptor
	{
		[JsonInclude]
		[JsonPropertyName("applications")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Security.ApplicationPrivileges>? Applications { get; set; }

		[JsonInclude]
		[JsonPropertyName("cluster")]
		public IEnumerable<string> Cluster { get; set; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Security.IndexPrivileges> Index { get; set; }
	}

	public sealed partial class RoleDescriptorDescriptor : SerializableDescriptorBase<RoleDescriptorDescriptor>
	{
		internal RoleDescriptorDescriptor(Action<RoleDescriptorDescriptor> configure) => configure.Invoke(this);
		public RoleDescriptorDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Security.ApplicationPrivileges>? ApplicationsValue { get; set; }

		private IEnumerable<string> ClusterValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.Security.IndexPrivileges> IndexValue { get; set; }

		public RoleDescriptorDescriptor Applications(IEnumerable<Elastic.Clients.Elasticsearch.Security.ApplicationPrivileges>? applications)
		{
			ApplicationsValue = applications;
			return Self;
		}

		public RoleDescriptorDescriptor Cluster(IEnumerable<string> cluster)
		{
			ClusterValue = cluster;
			return Self;
		}

		public RoleDescriptorDescriptor Index(IEnumerable<Elastic.Clients.Elasticsearch.Security.IndexPrivileges> index)
		{
			IndexValue = index;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ApplicationsValue is not null)
			{
				writer.WritePropertyName("applications");
				JsonSerializer.Serialize(writer, ApplicationsValue, options);
			}

			writer.WritePropertyName("cluster");
			JsonSerializer.Serialize(writer, ClusterValue, options);
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
			writer.WriteEndObject();
		}
	}
}