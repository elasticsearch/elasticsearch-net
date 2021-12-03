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
	public partial class EnrichProcessor : Ingest.ProcessorBase, IProcessorContainerVariant
	{
		[JsonIgnore]
		string Ingest.IProcessorContainerVariant.ProcessorContainerVariantName => "enrich";
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_matches")]
		public int? MaxMatches { get; set; }

		[JsonInclude]
		[JsonPropertyName("override")]
		public bool? Override { get; set; }

		[JsonInclude]
		[JsonPropertyName("policy_name")]
		public string PolicyName { get; set; }

		[JsonInclude]
		[JsonPropertyName("shape_relation")]
		public Elastic.Clients.Elasticsearch.GeoShapeRelation? ShapeRelation { get; set; }

		[JsonInclude]
		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field TargetField { get; set; }
	}

	public sealed partial class EnrichProcessorDescriptor<T> : DescriptorBase<EnrichProcessorDescriptor<T>>
	{
		public EnrichProcessorDescriptor()
		{
		}

		internal EnrichProcessorDescriptor(Action<EnrichProcessorDescriptor<T>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Field FieldValue { get; private set; }

		internal bool? IgnoreMissingValue { get; private set; }

		internal int? MaxMatchesValue { get; private set; }

		internal bool? OverrideValue { get; private set; }

		internal string PolicyNameValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.GeoShapeRelation? ShapeRelationValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field TargetFieldValue { get; private set; }

		internal string? IfValue { get; private set; }

		internal bool? IgnoreFailureValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; private set; }

		internal string? TagValue { get; private set; }

		public EnrichProcessorDescriptor<T> Field(Elastic.Clients.Elasticsearch.Field field) => Assign(field, (a, v) => a.FieldValue = v);
		public EnrichProcessorDescriptor<T> Field<TValue>(Expression<Func<T, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public EnrichProcessorDescriptor<T> IgnoreMissing(bool? ignoreMissing = true) => Assign(ignoreMissing, (a, v) => a.IgnoreMissingValue = v);
		public EnrichProcessorDescriptor<T> MaxMatches(int? maxMatches) => Assign(maxMatches, (a, v) => a.MaxMatchesValue = v);
		public EnrichProcessorDescriptor<T> Override(bool? overrideValue = true) => Assign(overrideValue, (a, v) => a.OverrideValue = v);
		public EnrichProcessorDescriptor<T> PolicyName(string policyName) => Assign(policyName, (a, v) => a.PolicyNameValue = v);
		public EnrichProcessorDescriptor<T> ShapeRelation(Elastic.Clients.Elasticsearch.GeoShapeRelation? shapeRelation) => Assign(shapeRelation, (a, v) => a.ShapeRelationValue = v);
		public EnrichProcessorDescriptor<T> TargetField(Elastic.Clients.Elasticsearch.Field targetField) => Assign(targetField, (a, v) => a.TargetFieldValue = v);
		public EnrichProcessorDescriptor<T> TargetField<TValue>(Expression<Func<T, TValue>> targetField) => Assign(targetField, (a, v) => a.TargetFieldValue = v);
		public EnrichProcessorDescriptor<T> If(string? ifValue) => Assign(ifValue, (a, v) => a.IfValue = v);
		public EnrichProcessorDescriptor<T> IgnoreFailure(bool? ignoreFailure = true) => Assign(ignoreFailure, (a, v) => a.IgnoreFailureValue = v);
		public EnrichProcessorDescriptor<T> OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure) => Assign(onFailure, (a, v) => a.OnFailureValue = v);
		public EnrichProcessorDescriptor<T> Tag(string? tag) => Assign(tag, (a, v) => a.TagValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (IgnoreMissingValue.HasValue)
			{
				writer.WritePropertyName("ignore_missing");
				writer.WriteBooleanValue(IgnoreMissingValue.Value);
			}

			if (MaxMatchesValue.HasValue)
			{
				writer.WritePropertyName("max_matches");
				writer.WriteNumberValue(MaxMatchesValue.Value);
			}

			if (OverrideValue.HasValue)
			{
				writer.WritePropertyName("override");
				writer.WriteBooleanValue(OverrideValue.Value);
			}

			writer.WritePropertyName("policy_name");
			writer.WriteStringValue(PolicyNameValue);
			if (ShapeRelationValue is not null)
			{
				writer.WritePropertyName("shape_relation");
				JsonSerializer.Serialize(writer, ShapeRelationValue, options);
			}

			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
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

			if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
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