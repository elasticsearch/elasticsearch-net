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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public class MlUpdateModelSnapshotRequestParameters : RequestParameters<MlUpdateModelSnapshotRequestParameters>
	{
	}

	public partial class MlUpdateModelSnapshotRequest : PlainRequestBase<MlUpdateModelSnapshotRequestParameters>
	{
		public MlUpdateModelSnapshotRequest(Elastic.Clients.Elasticsearch.Id job_id, Elastic.Clients.Elasticsearch.Id snapshot_id) : base(r => r.Required("job_id", job_id).Required("snapshot_id", snapshot_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningUpdateModelSnapshot;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonInclude]
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		[JsonInclude]
		[JsonPropertyName("retain")]
		public bool? Retain { get; set; }
	}

	public sealed partial class MlUpdateModelSnapshotRequestDescriptor : RequestDescriptorBase<MlUpdateModelSnapshotRequestDescriptor, MlUpdateModelSnapshotRequestParameters>
	{
		internal MlUpdateModelSnapshotRequestDescriptor(Action<MlUpdateModelSnapshotRequestDescriptor> configure) => configure.Invoke(this);
		public MlUpdateModelSnapshotRequestDescriptor(Elastic.Clients.Elasticsearch.Id job_id, Elastic.Clients.Elasticsearch.Id snapshot_id) : base(r => r.Required("job_id", job_id).Required("snapshot_id", snapshot_id))
		{
		}

		internal MlUpdateModelSnapshotRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningUpdateModelSnapshot;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public MlUpdateModelSnapshotRequestDescriptor JobId(Elastic.Clients.Elasticsearch.Id job_id)
		{
			RouteValues.Required("job_id", job_id);
			return Self;
		}

		public MlUpdateModelSnapshotRequestDescriptor SnapshotId(Elastic.Clients.Elasticsearch.Id snapshot_id)
		{
			RouteValues.Required("snapshot_id", snapshot_id);
			return Self;
		}

		private string? DescriptionValue { get; set; }

		private bool? RetainValue { get; set; }

		public MlUpdateModelSnapshotRequestDescriptor Description(string? description)
		{
			DescriptionValue = description;
			return Self;
		}

		public MlUpdateModelSnapshotRequestDescriptor Retain(bool? retain = true)
		{
			RetainValue = retain;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(DescriptionValue))
			{
				writer.WritePropertyName("description");
				writer.WriteStringValue(DescriptionValue);
			}

			if (RetainValue.HasValue)
			{
				writer.WritePropertyName("retain");
				writer.WriteBooleanValue(RetainValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}