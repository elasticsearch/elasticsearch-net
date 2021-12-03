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
	public partial class KeyValueProcessor : Ingest.ProcessorBase, IProcessorContainerVariant
	{
		[JsonIgnore]
		string Ingest.IProcessorContainerVariant.ProcessorContainerVariantName => "kv";
		[JsonInclude]
		[JsonPropertyName("exclude_keys")]
		public IEnumerable<string>? ExcludeKeys { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("field_split")]
		public string FieldSplit { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_missing")]
		public bool? IgnoreMissing { get; set; }

		[JsonInclude]
		[JsonPropertyName("include_keys")]
		public IEnumerable<string>? IncludeKeys { get; set; }

		[JsonInclude]
		[JsonPropertyName("prefix")]
		public string? Prefix { get; set; }

		[JsonInclude]
		[JsonPropertyName("strip_brackets")]
		public bool? StripBrackets { get; set; }

		[JsonInclude]
		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }

		[JsonInclude]
		[JsonPropertyName("trim_key")]
		public string? TrimKey { get; set; }

		[JsonInclude]
		[JsonPropertyName("trim_value")]
		public string? TrimValue { get; set; }

		[JsonInclude]
		[JsonPropertyName("value_split")]
		public string ValueSplit { get; set; }
	}

	public sealed partial class KeyValueProcessorDescriptor<T> : DescriptorBase<KeyValueProcessorDescriptor<T>>
	{
		public KeyValueProcessorDescriptor()
		{
		}

		internal KeyValueProcessorDescriptor(Action<KeyValueProcessorDescriptor<T>> configure) => configure.Invoke(this);
		internal IEnumerable<string>? ExcludeKeysValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field FieldValue { get; private set; }

		internal string FieldSplitValue { get; private set; }

		internal bool? IgnoreMissingValue { get; private set; }

		internal IEnumerable<string>? IncludeKeysValue { get; private set; }

		internal string? PrefixValue { get; private set; }

		internal bool? StripBracketsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field? TargetFieldValue { get; private set; }

		internal string? TrimKeyValue { get; private set; }

		internal string? TrimValueValue { get; private set; }

		internal string ValueSplitValue { get; private set; }

		internal string? IfValue { get; private set; }

		internal bool? IgnoreFailureValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; private set; }

		internal string? TagValue { get; private set; }

		public KeyValueProcessorDescriptor<T> ExcludeKeys(IEnumerable<string>? excludeKeys) => Assign(excludeKeys, (a, v) => a.ExcludeKeysValue = v);
		public KeyValueProcessorDescriptor<T> Field(Elastic.Clients.Elasticsearch.Field field) => Assign(field, (a, v) => a.FieldValue = v);
		public KeyValueProcessorDescriptor<T> Field<TValue>(Expression<Func<T, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public KeyValueProcessorDescriptor<T> FieldSplit(string fieldSplit) => Assign(fieldSplit, (a, v) => a.FieldSplitValue = v);
		public KeyValueProcessorDescriptor<T> IgnoreMissing(bool? ignoreMissing = true) => Assign(ignoreMissing, (a, v) => a.IgnoreMissingValue = v);
		public KeyValueProcessorDescriptor<T> IncludeKeys(IEnumerable<string>? includeKeys) => Assign(includeKeys, (a, v) => a.IncludeKeysValue = v);
		public KeyValueProcessorDescriptor<T> Prefix(string? prefix) => Assign(prefix, (a, v) => a.PrefixValue = v);
		public KeyValueProcessorDescriptor<T> StripBrackets(bool? stripBrackets = true) => Assign(stripBrackets, (a, v) => a.StripBracketsValue = v);
		public KeyValueProcessorDescriptor<T> TargetField(Elastic.Clients.Elasticsearch.Field? targetField) => Assign(targetField, (a, v) => a.TargetFieldValue = v);
		public KeyValueProcessorDescriptor<T> TargetField<TValue>(Expression<Func<T, TValue>> targetField) => Assign(targetField, (a, v) => a.TargetFieldValue = v);
		public KeyValueProcessorDescriptor<T> TrimKey(string? trimKey) => Assign(trimKey, (a, v) => a.TrimKeyValue = v);
		public KeyValueProcessorDescriptor<T> TrimValue(string? trimValue) => Assign(trimValue, (a, v) => a.TrimValueValue = v);
		public KeyValueProcessorDescriptor<T> ValueSplit(string valueSplit) => Assign(valueSplit, (a, v) => a.ValueSplitValue = v);
		public KeyValueProcessorDescriptor<T> If(string? ifValue) => Assign(ifValue, (a, v) => a.IfValue = v);
		public KeyValueProcessorDescriptor<T> IgnoreFailure(bool? ignoreFailure = true) => Assign(ignoreFailure, (a, v) => a.IgnoreFailureValue = v);
		public KeyValueProcessorDescriptor<T> OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure) => Assign(onFailure, (a, v) => a.OnFailureValue = v);
		public KeyValueProcessorDescriptor<T> Tag(string? tag) => Assign(tag, (a, v) => a.TagValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ExcludeKeysValue is not null)
			{
				writer.WritePropertyName("exclude_keys");
				JsonSerializer.Serialize(writer, ExcludeKeysValue, options);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			writer.WritePropertyName("field_split");
			writer.WriteStringValue(FieldSplitValue);
			if (IgnoreMissingValue.HasValue)
			{
				writer.WritePropertyName("ignore_missing");
				writer.WriteBooleanValue(IgnoreMissingValue.Value);
			}

			if (IncludeKeysValue is not null)
			{
				writer.WritePropertyName("include_keys");
				JsonSerializer.Serialize(writer, IncludeKeysValue, options);
			}

			if (!string.IsNullOrEmpty(PrefixValue))
			{
				writer.WritePropertyName("prefix");
				writer.WriteStringValue(PrefixValue);
			}

			if (StripBracketsValue.HasValue)
			{
				writer.WritePropertyName("strip_brackets");
				writer.WriteBooleanValue(StripBracketsValue.Value);
			}

			if (TargetFieldValue is not null)
			{
				writer.WritePropertyName("target_field");
				JsonSerializer.Serialize(writer, TargetFieldValue, options);
			}

			if (!string.IsNullOrEmpty(TrimKeyValue))
			{
				writer.WritePropertyName("trim_key");
				writer.WriteStringValue(TrimKeyValue);
			}

			if (!string.IsNullOrEmpty(TrimValueValue))
			{
				writer.WritePropertyName("trim_value");
				writer.WriteStringValue(TrimValueValue);
			}

			writer.WritePropertyName("value_split");
			writer.WriteStringValue(ValueSplitValue);
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