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
	public partial class IndexSettingsTimeSeries
	{
		[JsonInclude]
		[JsonPropertyName("end_time")]
		public Elastic.Clients.Elasticsearch.DateOrEpochMillis? EndTime { get; set; }

		[JsonInclude]
		[JsonPropertyName("start_time")]
		public Elastic.Clients.Elasticsearch.DateOrEpochMillis? StartTime { get; set; }
	}

	public sealed partial class IndexSettingsTimeSeriesDescriptor : DescriptorBase<IndexSettingsTimeSeriesDescriptor>
	{
		internal IndexSettingsTimeSeriesDescriptor(Action<IndexSettingsTimeSeriesDescriptor> configure) => configure.Invoke(this);
		public IndexSettingsTimeSeriesDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.DateOrEpochMillis? EndTimeValue { get; set; }

		private Elastic.Clients.Elasticsearch.DateOrEpochMillis? StartTimeValue { get; set; }

		public IndexSettingsTimeSeriesDescriptor EndTime(Elastic.Clients.Elasticsearch.DateOrEpochMillis? endTime)
		{
			EndTimeValue = endTime;
			return Self;
		}

		public IndexSettingsTimeSeriesDescriptor StartTime(Elastic.Clients.Elasticsearch.DateOrEpochMillis? startTime)
		{
			StartTimeValue = startTime;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (EndTimeValue is not null)
			{
				writer.WritePropertyName("end_time");
				JsonSerializer.Serialize(writer, EndTimeValue, options);
			}

			if (StartTimeValue is not null)
			{
				writer.WritePropertyName("start_time");
				JsonSerializer.Serialize(writer, StartTimeValue, options);
			}

			writer.WriteEndObject();
		}
	}
}