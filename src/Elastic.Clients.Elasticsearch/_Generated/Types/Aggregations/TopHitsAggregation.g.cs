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
	internal sealed class TopHitsAggregationConverter : JsonConverter<TopHitsAggregation>
	{
		public override TopHitsAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "top_hits")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new TopHitsAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("docvalue_fields"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Fields?>(ref reader, options);
						if (value is not null)
						{
							agg.DocvalueFields = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("explain"))
					{
						var value = JsonSerializer.Deserialize<bool?>(ref reader, options);
						if (value is not null)
						{
							agg.Explain = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("from"))
					{
						var value = JsonSerializer.Deserialize<int?>(ref reader, options);
						if (value is not null)
						{
							agg.From = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("highlight"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Highlight?>(ref reader, options);
						if (value is not null)
						{
							agg.Highlight = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("script_fields"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, Elastic.Clients.Elasticsearch.ScriptField>?>(ref reader, options);
						if (value is not null)
						{
							agg.ScriptFields = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("size"))
					{
						var value = JsonSerializer.Deserialize<int?>(ref reader, options);
						if (value is not null)
						{
							agg.Size = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("sort"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Sort?>(ref reader, options);
						if (value is not null)
						{
							agg.Sort = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("_source"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.SourceConfig?>(ref reader, options);
						if (value is not null)
						{
							agg.Source = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("stored_fields"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Fields?>(ref reader, options);
						if (value is not null)
						{
							agg.StoredFields = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("track_scores"))
					{
						var value = JsonSerializer.Deserialize<bool?>(ref reader, options);
						if (value is not null)
						{
							agg.TrackScores = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("version"))
					{
						var value = JsonSerializer.Deserialize<bool?>(ref reader, options);
						if (value is not null)
						{
							agg.Version = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("seq_no_primary_term"))
					{
						var value = JsonSerializer.Deserialize<bool?>(ref reader, options);
						if (value is not null)
						{
							agg.SeqNoPrimaryTerm = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("field"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
						if (value is not null)
						{
							agg.Field = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("missing"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.Missing?>(ref reader, options);
						if (value is not null)
						{
							agg.Missing = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("script"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
						if (value is not null)
						{
							agg.Script = value;
						}

						continue;
					}
				}
			}

			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("meta"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
						if (value is not null)
						{
							agg.Meta = value;
						}

						continue;
					}
				}
			}

			reader.Read();
			return agg;
		}

		public override void Write(Utf8JsonWriter writer, TopHitsAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("top_hits");
			writer.WriteStartObject();
			if (value.DocvalueFields is not null)
			{
				writer.WritePropertyName("docvalue_fields");
				JsonSerializer.Serialize(writer, value.DocvalueFields, options);
			}

			if (value.Explain.HasValue)
			{
				writer.WritePropertyName("explain");
				writer.WriteBooleanValue(value.Explain.Value);
			}

			if (value.From.HasValue)
			{
				writer.WritePropertyName("from");
				writer.WriteNumberValue(value.From.Value);
			}

			if (value.Highlight is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, value.Highlight, options);
			}

			if (value.ScriptFields is not null)
			{
				writer.WritePropertyName("script_fields");
				JsonSerializer.Serialize(writer, value.ScriptFields, options);
			}

			if (value.Size.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(value.Size.Value);
			}

			if (value.Sort is not null)
			{
				writer.WritePropertyName("sort");
				JsonSerializer.Serialize(writer, value.Sort, options);
			}

			if (value.Source is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, value.Source, options);
			}

			if (value.StoredFields is not null)
			{
				writer.WritePropertyName("stored_fields");
				JsonSerializer.Serialize(writer, value.StoredFields, options);
			}

			if (value.TrackScores.HasValue)
			{
				writer.WritePropertyName("track_scores");
				writer.WriteBooleanValue(value.TrackScores.Value);
			}

			if (value.Version.HasValue)
			{
				writer.WritePropertyName("version");
				writer.WriteBooleanValue(value.Version.Value);
			}

			if (value.SeqNoPrimaryTerm.HasValue)
			{
				writer.WritePropertyName("seq_no_primary_term");
				writer.WriteBooleanValue(value.SeqNoPrimaryTerm.Value);
			}

			if (value.Field is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, value.Field, options);
			}

			if (value.Missing is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, value.Missing, options);
			}

			if (value.Script is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, value.Script, options);
			}

			writer.WriteEndObject();
			if (value.Meta is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, value.Meta, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(TopHitsAggregationConverter))]
	public partial class TopHitsAggregation : Aggregations.MetricAggregationBase
	{
		public TopHitsAggregation(string name, Field field) : base(name) => Field = field;
		public TopHitsAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("docvalue_fields")]
		public Elastic.Clients.Elasticsearch.Fields? DocvalueFields { get; set; }

		[JsonInclude]
		[JsonPropertyName("explain")]
		public bool? Explain { get; set; }

		[JsonInclude]
		[JsonPropertyName("from")]
		public int? From { get; set; }

		[JsonInclude]
		[JsonPropertyName("highlight")]
		public Elastic.Clients.Elasticsearch.Highlight? Highlight { get; set; }

		[JsonInclude]
		[JsonPropertyName("script_fields")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.ScriptField>? ScriptFields { get; set; }

		[JsonInclude]
		[JsonPropertyName("size")]
		public int? Size { get; set; }

		[JsonInclude]
		[JsonPropertyName("sort")]
		public Elastic.Clients.Elasticsearch.Sort? Sort { get; set; }

		[JsonInclude]
		[JsonPropertyName("_source")]
		public Elastic.Clients.Elasticsearch.SourceConfig? Source { get; set; }

		[JsonInclude]
		[JsonPropertyName("stored_fields")]
		public Elastic.Clients.Elasticsearch.Fields? StoredFields { get; set; }

		[JsonInclude]
		[JsonPropertyName("track_scores")]
		public bool? TrackScores { get; set; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public bool? Version { get; set; }

		[JsonInclude]
		[JsonPropertyName("seq_no_primary_term")]
		public bool? SeqNoPrimaryTerm { get; set; }
	}

	public sealed partial class TopHitsAggregationDescriptor<T> : DescriptorBase<TopHitsAggregationDescriptor<T>>
	{
		public TopHitsAggregationDescriptor()
		{
		}

		internal TopHitsAggregationDescriptor(Action<TopHitsAggregationDescriptor<T>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Fields? DocvalueFieldsValue { get; private set; }

		internal bool? ExplainValue { get; private set; }

		internal int? FromValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Highlight? HighlightValue { get; private set; }

		internal Dictionary<string, Elastic.Clients.Elasticsearch.ScriptField>? ScriptFieldsValue { get; private set; }

		internal int? SizeValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Sort? SortValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.SourceConfig? SourceValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Fields? StoredFieldsValue { get; private set; }

		internal bool? TrackScoresValue { get; private set; }

		internal bool? VersionValue { get; private set; }

		internal bool? SeqNoPrimaryTermValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field? FieldValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.Missing? MissingValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Script? ScriptValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal HighlightDescriptor<T> HighlightDescriptor { get; private set; }

		internal Action<HighlightDescriptor<T>> HighlightDescriptorAction { get; private set; }

		public TopHitsAggregationDescriptor<T> DocvalueFields(Elastic.Clients.Elasticsearch.Fields? docvalueFields) => Assign(docvalueFields, (a, v) => a.DocvalueFieldsValue = v);
		public TopHitsAggregationDescriptor<T> DocvalueFields<TValue>(Expression<Func<T, TValue>> docvalueFields) => Assign(docvalueFields, (a, v) => a.DocvalueFieldsValue = v);
		public TopHitsAggregationDescriptor<T> Explain(bool? explain = true) => Assign(explain, (a, v) => a.ExplainValue = v);
		public TopHitsAggregationDescriptor<T> From(int? from) => Assign(from, (a, v) => a.FromValue = v);
		public TopHitsAggregationDescriptor<T> Highlight(Elastic.Clients.Elasticsearch.Highlight? highlight)
		{
			HighlightDescriptor = null;
			HighlightDescriptorAction = null;
			return Assign(highlight, (a, v) => a.HighlightValue = v);
		}

		public TopHitsAggregationDescriptor<T> Highlight(HighlightDescriptor<T> descriptor)
		{
			HighlightValue = null;
			HighlightDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.HighlightDescriptor = v);
		}

		public TopHitsAggregationDescriptor<T> Highlight(Action<HighlightDescriptor<T>> configure)
		{
			HighlightValue = null;
			HighlightDescriptorAction = null;
			return Assign(configure, (a, v) => a.HighlightDescriptorAction = v);
		}

		public TopHitsAggregationDescriptor<T> ScriptFields(Func<FluentDictionary<string, Elastic.Clients.Elasticsearch.ScriptField>, FluentDictionary<string, Elastic.Clients.Elasticsearch.ScriptField>> selector) => Assign(selector, (a, v) => a.ScriptFieldsValue = v?.Invoke(new FluentDictionary<string, Elastic.Clients.Elasticsearch.ScriptField>()));
		public TopHitsAggregationDescriptor<T> Size(int? size) => Assign(size, (a, v) => a.SizeValue = v);
		public TopHitsAggregationDescriptor<T> Sort(Elastic.Clients.Elasticsearch.Sort? sort) => Assign(sort, (a, v) => a.SortValue = v);
		public TopHitsAggregationDescriptor<T> Source(Elastic.Clients.Elasticsearch.SourceConfig? source) => Assign(source, (a, v) => a.SourceValue = v);
		public TopHitsAggregationDescriptor<T> StoredFields(Elastic.Clients.Elasticsearch.Fields? storedFields) => Assign(storedFields, (a, v) => a.StoredFieldsValue = v);
		public TopHitsAggregationDescriptor<T> StoredFields<TValue>(Expression<Func<T, TValue>> storedFields) => Assign(storedFields, (a, v) => a.StoredFieldsValue = v);
		public TopHitsAggregationDescriptor<T> TrackScores(bool? trackScores = true) => Assign(trackScores, (a, v) => a.TrackScoresValue = v);
		public TopHitsAggregationDescriptor<T> Version(bool? version = true) => Assign(version, (a, v) => a.VersionValue = v);
		public TopHitsAggregationDescriptor<T> SeqNoPrimaryTerm(bool? seqNoPrimaryTerm = true) => Assign(seqNoPrimaryTerm, (a, v) => a.SeqNoPrimaryTermValue = v);
		public TopHitsAggregationDescriptor<T> Field(Elastic.Clients.Elasticsearch.Field? field) => Assign(field, (a, v) => a.FieldValue = v);
		public TopHitsAggregationDescriptor<T> Field<TValue>(Expression<Func<T, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public TopHitsAggregationDescriptor<T> Missing(Elastic.Clients.Elasticsearch.Aggregations.Missing? missing) => Assign(missing, (a, v) => a.MissingValue = v);
		public TopHitsAggregationDescriptor<T> Script(Elastic.Clients.Elasticsearch.Script? script) => Assign(script, (a, v) => a.ScriptValue = v);
		public TopHitsAggregationDescriptor<T> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("top_hits");
			writer.WriteStartObject();
			if (DocvalueFieldsValue is not null)
			{
				writer.WritePropertyName("docvalue_fields");
				JsonSerializer.Serialize(writer, DocvalueFieldsValue, options);
			}

			if (ExplainValue.HasValue)
			{
				writer.WritePropertyName("explain");
				writer.WriteBooleanValue(ExplainValue.Value);
			}

			if (FromValue.HasValue)
			{
				writer.WritePropertyName("from");
				writer.WriteNumberValue(FromValue.Value);
			}

			if (HighlightDescriptor is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, HighlightDescriptor, options);
			}
			else if (HighlightDescriptorAction is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, new HighlightDescriptor<T>(HighlightDescriptorAction), options);
			}
			else if (HighlightValue is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, HighlightValue, options);
			}

			if (ScriptFieldsValue is not null)
			{
				writer.WritePropertyName("script_fields");
				JsonSerializer.Serialize(writer, ScriptFieldsValue, options);
			}

			if (SizeValue.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(SizeValue.Value);
			}

			if (SortValue is not null)
			{
				writer.WritePropertyName("sort");
				JsonSerializer.Serialize(writer, SortValue, options);
			}

			if (SourceValue is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, SourceValue, options);
			}

			if (StoredFieldsValue is not null)
			{
				writer.WritePropertyName("stored_fields");
				JsonSerializer.Serialize(writer, StoredFieldsValue, options);
			}

			if (TrackScoresValue.HasValue)
			{
				writer.WritePropertyName("track_scores");
				writer.WriteBooleanValue(TrackScoresValue.Value);
			}

			if (VersionValue.HasValue)
			{
				writer.WritePropertyName("version");
				writer.WriteBooleanValue(VersionValue.Value);
			}

			if (SeqNoPrimaryTermValue.HasValue)
			{
				writer.WritePropertyName("seq_no_primary_term");
				writer.WriteBooleanValue(SeqNoPrimaryTermValue.Value);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			writer.WriteEndObject();
		}
	}
}