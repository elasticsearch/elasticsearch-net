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
namespace Elastic.Clients.Elasticsearch.Eql
{
	public sealed class EqlSearchRequestParameters : RequestParameters<EqlSearchRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }
	}

	public partial class EqlSearchRequest : PlainRequestBase<EqlSearchRequestParameters>
	{
		public EqlSearchRequest(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.EqlSearch;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonInclude]
		[JsonPropertyName("query")]
		public string Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("case_sensitive")]
		public bool? CaseSensitive { get; set; }

		[JsonInclude]
		[JsonPropertyName("event_category_field")]
		public Elastic.Clients.Elasticsearch.Field? EventCategoryField { get; set; }

		[JsonInclude]
		[JsonPropertyName("tiebreaker_field")]
		public Elastic.Clients.Elasticsearch.Field? TiebreakerField { get; set; }

		[JsonInclude]
		[JsonPropertyName("timestamp_field")]
		public Elastic.Clients.Elasticsearch.Field? TimestampField { get; set; }

		[JsonInclude]
		[JsonPropertyName("fetch_size")]
		public int? FetchSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("filter")]
		public IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer>? Filter { get; set; }

		[JsonInclude]
		[JsonPropertyName("keep_alive")]
		public Elastic.Clients.Elasticsearch.Duration? KeepAlive { get; set; }

		[JsonInclude]
		[JsonPropertyName("keep_on_completion")]
		public bool? KeepOnCompletion { get; set; }

		[JsonInclude]
		[JsonPropertyName("wait_for_completion_timeout")]
		public Elastic.Clients.Elasticsearch.Duration? WaitForCompletionTimeout { get; set; }

		[JsonInclude]
		[JsonPropertyName("size")]
		public int? Size { get; set; }

		[JsonInclude]
		[JsonPropertyName("fields")]
		public IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormat>? Fields { get; set; }

		[JsonInclude]
		[JsonPropertyName("result_position")]
		public Elastic.Clients.Elasticsearch.Eql.ResultPosition? ResultPosition { get; set; }

		[JsonInclude]
		[JsonPropertyName("runtime_mappings")]
		public Dictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>? RuntimeMappings { get; set; }
	}

	public sealed partial class EqlSearchRequestDescriptor<TDocument> : RequestDescriptorBase<EqlSearchRequestDescriptor<TDocument>, EqlSearchRequestParameters>
	{
		internal EqlSearchRequestDescriptor(Action<EqlSearchRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public EqlSearchRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
		{
		}

		internal EqlSearchRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.EqlSearch;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public EqlSearchRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
		public EqlSearchRequestDescriptor<TDocument> ExpandWildcards(IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public EqlSearchRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
		public EqlSearchRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices indices)
		{
			RouteValues.Required("index", indices);
			return Self;
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormat>? FieldsValue { get; set; }

		private QueryDsl.FieldAndFormatDescriptor<TDocument> FieldsDescriptor { get; set; }

		private Action<QueryDsl.FieldAndFormatDescriptor<TDocument>> FieldsDescriptorAction { get; set; }

		private Action<QueryDsl.FieldAndFormatDescriptor<TDocument>>[] FieldsDescriptorActions { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer>? FilterValue { get; set; }

		private QueryDsl.QueryContainerDescriptor<TDocument> FilterDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor<TDocument>> FilterDescriptorAction { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor<TDocument>>[] FilterDescriptorActions { get; set; }

		private bool? CaseSensitiveValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? EventCategoryFieldValue { get; set; }

		private int? FetchSizeValue { get; set; }

		private Elastic.Clients.Elasticsearch.Duration? KeepAliveValue { get; set; }

		private bool? KeepOnCompletionValue { get; set; }

		private string QueryValue { get; set; }

		private Elastic.Clients.Elasticsearch.Eql.ResultPosition? ResultPositionValue { get; set; }

		private Dictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>? RuntimeMappingsValue { get; set; }

		private int? SizeValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? TiebreakerFieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? TimestampFieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Duration? WaitForCompletionTimeoutValue { get; set; }

		public EqlSearchRequestDescriptor<TDocument> Fields(IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormat>? fields)
		{
			FieldsDescriptor = null;
			FieldsDescriptorAction = null;
			FieldsDescriptorActions = null;
			FieldsValue = fields;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> Fields(QueryDsl.FieldAndFormatDescriptor<TDocument> descriptor)
		{
			FieldsValue = null;
			FieldsDescriptorAction = null;
			FieldsDescriptorActions = null;
			FieldsDescriptor = descriptor;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> Fields(Action<QueryDsl.FieldAndFormatDescriptor<TDocument>> configure)
		{
			FieldsValue = null;
			FieldsDescriptor = null;
			FieldsDescriptorActions = null;
			FieldsDescriptorAction = configure;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> Fields(params Action<QueryDsl.FieldAndFormatDescriptor<TDocument>>[] configure)
		{
			FieldsValue = null;
			FieldsDescriptor = null;
			FieldsDescriptorAction = null;
			FieldsDescriptorActions = configure;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> Filter(IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer>? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterDescriptorActions = null;
			FilterValue = filter;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> Filter(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptorActions = null;
			FilterDescriptor = descriptor;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> Filter(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			FilterValue = null;
			FilterDescriptor = null;
			FilterDescriptorActions = null;
			FilterDescriptorAction = configure;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> Filter(params Action<QueryDsl.QueryContainerDescriptor<TDocument>>[] configure)
		{
			FilterValue = null;
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterDescriptorActions = configure;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> CaseSensitive(bool? caseSensitive = true)
		{
			CaseSensitiveValue = caseSensitive;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> EventCategoryField(Elastic.Clients.Elasticsearch.Field? eventCategoryField)
		{
			EventCategoryFieldValue = eventCategoryField;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> EventCategoryField<TValue>(Expression<Func<TDocument, TValue>> eventCategoryField)
		{
			EventCategoryFieldValue = eventCategoryField;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> FetchSize(int? fetchSize)
		{
			FetchSizeValue = fetchSize;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> KeepAlive(Elastic.Clients.Elasticsearch.Duration? keepAlive)
		{
			KeepAliveValue = keepAlive;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> KeepOnCompletion(bool? keepOnCompletion = true)
		{
			KeepOnCompletionValue = keepOnCompletion;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> Query(string query)
		{
			QueryValue = query;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> ResultPosition(Elastic.Clients.Elasticsearch.Eql.ResultPosition? resultPosition)
		{
			ResultPositionValue = resultPosition;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> RuntimeMappings(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>> selector)
		{
			RuntimeMappingsValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>());
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> Size(int? size)
		{
			SizeValue = size;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> TiebreakerField(Elastic.Clients.Elasticsearch.Field? tiebreakerField)
		{
			TiebreakerFieldValue = tiebreakerField;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> TiebreakerField<TValue>(Expression<Func<TDocument, TValue>> tiebreakerField)
		{
			TiebreakerFieldValue = tiebreakerField;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> TimestampField(Elastic.Clients.Elasticsearch.Field? timestampField)
		{
			TimestampFieldValue = timestampField;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> TimestampField<TValue>(Expression<Func<TDocument, TValue>> timestampField)
		{
			TimestampFieldValue = timestampField;
			return Self;
		}

		public EqlSearchRequestDescriptor<TDocument> WaitForCompletionTimeout(Elastic.Clients.Elasticsearch.Duration? waitForCompletionTimeout)
		{
			WaitForCompletionTimeoutValue = waitForCompletionTimeout;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FieldsDescriptor is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsDescriptor, options);
			}
			else if (FieldsDescriptorAction is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, new QueryDsl.FieldAndFormatDescriptor<TDocument>(FieldsDescriptorAction), options);
			}
			else if (FieldsDescriptorActions is not null)
			{
				writer.WritePropertyName("fields");
				writer.WriteStartArray();
				foreach (var action in FieldsDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new QueryDsl.FieldAndFormatDescriptor<TDocument>(action), options);
				}

				writer.WriteEndArray();
			}
			else if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (FilterDescriptor is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterDescriptor, options);
			}
			else if (FilterDescriptorAction is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(FilterDescriptorAction), options);
			}
			else if (FilterDescriptorActions is not null)
			{
				writer.WritePropertyName("filter");
				writer.WriteStartArray();
				foreach (var action in FilterDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(action), options);
				}

				writer.WriteEndArray();
			}
			else if (FilterValue is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterValue, options);
			}

			if (CaseSensitiveValue.HasValue)
			{
				writer.WritePropertyName("case_sensitive");
				writer.WriteBooleanValue(CaseSensitiveValue.Value);
			}

			if (EventCategoryFieldValue is not null)
			{
				writer.WritePropertyName("event_category_field");
				JsonSerializer.Serialize(writer, EventCategoryFieldValue, options);
			}

			if (FetchSizeValue.HasValue)
			{
				writer.WritePropertyName("fetch_size");
				writer.WriteNumberValue(FetchSizeValue.Value);
			}

			if (KeepAliveValue is not null)
			{
				writer.WritePropertyName("keep_alive");
				JsonSerializer.Serialize(writer, KeepAliveValue, options);
			}

			if (KeepOnCompletionValue.HasValue)
			{
				writer.WritePropertyName("keep_on_completion");
				writer.WriteBooleanValue(KeepOnCompletionValue.Value);
			}

			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
			if (ResultPositionValue is not null)
			{
				writer.WritePropertyName("result_position");
				JsonSerializer.Serialize(writer, ResultPositionValue, options);
			}

			if (RuntimeMappingsValue is not null)
			{
				writer.WritePropertyName("runtime_mappings");
				JsonSerializer.Serialize(writer, RuntimeMappingsValue, options);
			}

			if (SizeValue.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(SizeValue.Value);
			}

			if (TiebreakerFieldValue is not null)
			{
				writer.WritePropertyName("tiebreaker_field");
				JsonSerializer.Serialize(writer, TiebreakerFieldValue, options);
			}

			if (TimestampFieldValue is not null)
			{
				writer.WritePropertyName("timestamp_field");
				JsonSerializer.Serialize(writer, TimestampFieldValue, options);
			}

			if (WaitForCompletionTimeoutValue is not null)
			{
				writer.WritePropertyName("wait_for_completion_timeout");
				JsonSerializer.Serialize(writer, WaitForCompletionTimeoutValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class EqlSearchRequestDescriptor : RequestDescriptorBase<EqlSearchRequestDescriptor, EqlSearchRequestParameters>
	{
		internal EqlSearchRequestDescriptor(Action<EqlSearchRequestDescriptor> configure) => configure.Invoke(this);
		public EqlSearchRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
		{
		}

		internal EqlSearchRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.EqlSearch;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public EqlSearchRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
		public EqlSearchRequestDescriptor ExpandWildcards(IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public EqlSearchRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
		public EqlSearchRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices indices)
		{
			RouteValues.Required("index", indices);
			return Self;
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormat>? FieldsValue { get; set; }

		private QueryDsl.FieldAndFormatDescriptor FieldsDescriptor { get; set; }

		private Action<QueryDsl.FieldAndFormatDescriptor> FieldsDescriptorAction { get; set; }

		private Action<QueryDsl.FieldAndFormatDescriptor>[] FieldsDescriptorActions { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer>? FilterValue { get; set; }

		private QueryDsl.QueryContainerDescriptor FilterDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor> FilterDescriptorAction { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor>[] FilterDescriptorActions { get; set; }

		private bool? CaseSensitiveValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? EventCategoryFieldValue { get; set; }

		private int? FetchSizeValue { get; set; }

		private Elastic.Clients.Elasticsearch.Duration? KeepAliveValue { get; set; }

		private bool? KeepOnCompletionValue { get; set; }

		private string QueryValue { get; set; }

		private Elastic.Clients.Elasticsearch.Eql.ResultPosition? ResultPositionValue { get; set; }

		private Dictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>? RuntimeMappingsValue { get; set; }

		private int? SizeValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? TiebreakerFieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? TimestampFieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Duration? WaitForCompletionTimeoutValue { get; set; }

		public EqlSearchRequestDescriptor Fields(IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormat>? fields)
		{
			FieldsDescriptor = null;
			FieldsDescriptorAction = null;
			FieldsDescriptorActions = null;
			FieldsValue = fields;
			return Self;
		}

		public EqlSearchRequestDescriptor Fields(QueryDsl.FieldAndFormatDescriptor descriptor)
		{
			FieldsValue = null;
			FieldsDescriptorAction = null;
			FieldsDescriptorActions = null;
			FieldsDescriptor = descriptor;
			return Self;
		}

		public EqlSearchRequestDescriptor Fields(Action<QueryDsl.FieldAndFormatDescriptor> configure)
		{
			FieldsValue = null;
			FieldsDescriptor = null;
			FieldsDescriptorActions = null;
			FieldsDescriptorAction = configure;
			return Self;
		}

		public EqlSearchRequestDescriptor Fields(params Action<QueryDsl.FieldAndFormatDescriptor>[] configure)
		{
			FieldsValue = null;
			FieldsDescriptor = null;
			FieldsDescriptorAction = null;
			FieldsDescriptorActions = configure;
			return Self;
		}

		public EqlSearchRequestDescriptor Filter(IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer>? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterDescriptorActions = null;
			FilterValue = filter;
			return Self;
		}

		public EqlSearchRequestDescriptor Filter(QueryDsl.QueryContainerDescriptor descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			FilterDescriptorActions = null;
			FilterDescriptor = descriptor;
			return Self;
		}

		public EqlSearchRequestDescriptor Filter(Action<QueryDsl.QueryContainerDescriptor> configure)
		{
			FilterValue = null;
			FilterDescriptor = null;
			FilterDescriptorActions = null;
			FilterDescriptorAction = configure;
			return Self;
		}

		public EqlSearchRequestDescriptor Filter(params Action<QueryDsl.QueryContainerDescriptor>[] configure)
		{
			FilterValue = null;
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			FilterDescriptorActions = configure;
			return Self;
		}

		public EqlSearchRequestDescriptor CaseSensitive(bool? caseSensitive = true)
		{
			CaseSensitiveValue = caseSensitive;
			return Self;
		}

		public EqlSearchRequestDescriptor EventCategoryField(Elastic.Clients.Elasticsearch.Field? eventCategoryField)
		{
			EventCategoryFieldValue = eventCategoryField;
			return Self;
		}

		public EqlSearchRequestDescriptor EventCategoryField<TDocument, TValue>(Expression<Func<TDocument, TValue>> eventCategoryField)
		{
			EventCategoryFieldValue = eventCategoryField;
			return Self;
		}

		public EqlSearchRequestDescriptor EventCategoryField<TDocument>(Expression<Func<TDocument, object>> eventCategoryField)
		{
			EventCategoryFieldValue = eventCategoryField;
			return Self;
		}

		public EqlSearchRequestDescriptor FetchSize(int? fetchSize)
		{
			FetchSizeValue = fetchSize;
			return Self;
		}

		public EqlSearchRequestDescriptor KeepAlive(Elastic.Clients.Elasticsearch.Duration? keepAlive)
		{
			KeepAliveValue = keepAlive;
			return Self;
		}

		public EqlSearchRequestDescriptor KeepOnCompletion(bool? keepOnCompletion = true)
		{
			KeepOnCompletionValue = keepOnCompletion;
			return Self;
		}

		public EqlSearchRequestDescriptor Query(string query)
		{
			QueryValue = query;
			return Self;
		}

		public EqlSearchRequestDescriptor ResultPosition(Elastic.Clients.Elasticsearch.Eql.ResultPosition? resultPosition)
		{
			ResultPositionValue = resultPosition;
			return Self;
		}

		public EqlSearchRequestDescriptor RuntimeMappings(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>> selector)
		{
			RuntimeMappingsValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, IEnumerable<Elastic.Clients.Elasticsearch.Mapping.RuntimeField>>());
			return Self;
		}

		public EqlSearchRequestDescriptor Size(int? size)
		{
			SizeValue = size;
			return Self;
		}

		public EqlSearchRequestDescriptor TiebreakerField(Elastic.Clients.Elasticsearch.Field? tiebreakerField)
		{
			TiebreakerFieldValue = tiebreakerField;
			return Self;
		}

		public EqlSearchRequestDescriptor TiebreakerField<TDocument, TValue>(Expression<Func<TDocument, TValue>> tiebreakerField)
		{
			TiebreakerFieldValue = tiebreakerField;
			return Self;
		}

		public EqlSearchRequestDescriptor TiebreakerField<TDocument>(Expression<Func<TDocument, object>> tiebreakerField)
		{
			TiebreakerFieldValue = tiebreakerField;
			return Self;
		}

		public EqlSearchRequestDescriptor TimestampField(Elastic.Clients.Elasticsearch.Field? timestampField)
		{
			TimestampFieldValue = timestampField;
			return Self;
		}

		public EqlSearchRequestDescriptor TimestampField<TDocument, TValue>(Expression<Func<TDocument, TValue>> timestampField)
		{
			TimestampFieldValue = timestampField;
			return Self;
		}

		public EqlSearchRequestDescriptor TimestampField<TDocument>(Expression<Func<TDocument, object>> timestampField)
		{
			TimestampFieldValue = timestampField;
			return Self;
		}

		public EqlSearchRequestDescriptor WaitForCompletionTimeout(Elastic.Clients.Elasticsearch.Duration? waitForCompletionTimeout)
		{
			WaitForCompletionTimeoutValue = waitForCompletionTimeout;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FieldsDescriptor is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsDescriptor, options);
			}
			else if (FieldsDescriptorAction is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, new QueryDsl.FieldAndFormatDescriptor(FieldsDescriptorAction), options);
			}
			else if (FieldsDescriptorActions is not null)
			{
				writer.WritePropertyName("fields");
				writer.WriteStartArray();
				foreach (var action in FieldsDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new QueryDsl.FieldAndFormatDescriptor(action), options);
				}

				writer.WriteEndArray();
			}
			else if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (FilterDescriptor is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterDescriptor, options);
			}
			else if (FilterDescriptorAction is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor(FilterDescriptorAction), options);
			}
			else if (FilterDescriptorActions is not null)
			{
				writer.WritePropertyName("filter");
				writer.WriteStartArray();
				foreach (var action in FilterDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor(action), options);
				}

				writer.WriteEndArray();
			}
			else if (FilterValue is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterValue, options);
			}

			if (CaseSensitiveValue.HasValue)
			{
				writer.WritePropertyName("case_sensitive");
				writer.WriteBooleanValue(CaseSensitiveValue.Value);
			}

			if (EventCategoryFieldValue is not null)
			{
				writer.WritePropertyName("event_category_field");
				JsonSerializer.Serialize(writer, EventCategoryFieldValue, options);
			}

			if (FetchSizeValue.HasValue)
			{
				writer.WritePropertyName("fetch_size");
				writer.WriteNumberValue(FetchSizeValue.Value);
			}

			if (KeepAliveValue is not null)
			{
				writer.WritePropertyName("keep_alive");
				JsonSerializer.Serialize(writer, KeepAliveValue, options);
			}

			if (KeepOnCompletionValue.HasValue)
			{
				writer.WritePropertyName("keep_on_completion");
				writer.WriteBooleanValue(KeepOnCompletionValue.Value);
			}

			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
			if (ResultPositionValue is not null)
			{
				writer.WritePropertyName("result_position");
				JsonSerializer.Serialize(writer, ResultPositionValue, options);
			}

			if (RuntimeMappingsValue is not null)
			{
				writer.WritePropertyName("runtime_mappings");
				JsonSerializer.Serialize(writer, RuntimeMappingsValue, options);
			}

			if (SizeValue.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(SizeValue.Value);
			}

			if (TiebreakerFieldValue is not null)
			{
				writer.WritePropertyName("tiebreaker_field");
				JsonSerializer.Serialize(writer, TiebreakerFieldValue, options);
			}

			if (TimestampFieldValue is not null)
			{
				writer.WritePropertyName("timestamp_field");
				JsonSerializer.Serialize(writer, TimestampFieldValue, options);
			}

			if (WaitForCompletionTimeoutValue is not null)
			{
				writer.WritePropertyName("wait_for_completion_timeout");
				JsonSerializer.Serialize(writer, WaitForCompletionTimeoutValue, options);
			}

			writer.WriteEndObject();
		}
	}
}