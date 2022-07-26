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
namespace Elastic.Clients.Elasticsearch.Ml
{
	public sealed partial class DataframeAnalysisAnalyzedFields
	{
		[JsonInclude]
		[JsonPropertyName("excludes")]
		public IEnumerable<string> Excludes { get; set; }

		[JsonInclude]
		[JsonPropertyName("includes")]
		public IEnumerable<string> Includes { get; set; }
	}

	public sealed partial class DataframeAnalysisAnalyzedFieldsDescriptor : SerializableDescriptorBase<DataframeAnalysisAnalyzedFieldsDescriptor>
	{
		internal DataframeAnalysisAnalyzedFieldsDescriptor(Action<DataframeAnalysisAnalyzedFieldsDescriptor> configure) => configure.Invoke(this);
		public DataframeAnalysisAnalyzedFieldsDescriptor() : base()
		{
		}

		private IEnumerable<string> ExcludesValue { get; set; }

		private IEnumerable<string> IncludesValue { get; set; }

		public DataframeAnalysisAnalyzedFieldsDescriptor Excludes(IEnumerable<string> excludes)
		{
			ExcludesValue = excludes;
			return Self;
		}

		public DataframeAnalysisAnalyzedFieldsDescriptor Includes(IEnumerable<string> includes)
		{
			IncludesValue = includes;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("excludes");
			JsonSerializer.Serialize(writer, ExcludesValue, options);
			writer.WritePropertyName("includes");
			JsonSerializer.Serialize(writer, IncludesValue, options);
			writer.WriteEndObject();
		}
	}
}