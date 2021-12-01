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
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public partial class HdrMethod
	{
		[JsonInclude]
		[JsonPropertyName("number_of_significant_value_digits")]
		public int? NumberOfSignificantValueDigits { get; set; }
	}

	public sealed partial class HdrMethodDescriptor : DescriptorBase<HdrMethodDescriptor>
	{
		public HdrMethodDescriptor()
		{
		}

		internal HdrMethodDescriptor(Action<HdrMethodDescriptor> configure) => configure.Invoke(this);
		internal int? NumberOfSignificantValueDigitsValue { get; private set; }

		public HdrMethodDescriptor NumberOfSignificantValueDigits(int? numberOfSignificantValueDigits) => Assign(numberOfSignificantValueDigits, (a, v) => a.NumberOfSignificantValueDigitsValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (NumberOfSignificantValueDigitsValue.HasValue)
			{
				writer.WritePropertyName("number_of_significant_value_digits");
				writer.WriteNumberValue(NumberOfSignificantValueDigitsValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}