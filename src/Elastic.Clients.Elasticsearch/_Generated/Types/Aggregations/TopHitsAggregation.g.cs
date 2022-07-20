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
					if (reader.ValueTextEquals("_source"))
					{
						reader.Read();
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.SourceConfig?>(ref reader, options);
						if (value is not null)
						{
							agg.Source = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("docvalue_fields"))
					{
						reader.Read();
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Fields?>(ref reader, options);
						if (value is not null)
						{
							agg.DocvalueFields = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("explain"))
					{
						reader.Read();
						var value = JsonSerializer.Deserialize<bool?>(ref reader, options);
						if (value is not null)
						{
							agg.Explain = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("from"))
					{
						reader.Read();
						var value = JsonSerializer.Deserialize<int?>(ref reader, options);
						if (value is not null)
						{
							agg.From = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("highlight"))
					{
						reader.Read();
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Highlight?>(ref reader, options);
						if (value is not null)
						{
							agg.Highlight = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("script_fields"))
					{
						reader.Read();
						var value = JsonSerializer.Deserialize<Dictionary<string, Elastic.Clients.Elasticsearch.ScriptField>?>(ref reader, options);
						if (value is not null)
						{
							agg.ScriptFields = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("seq_no_primary_term"))
					{
						reader.Read();
						var value = JsonSerializer.Deserialize<bool?>(ref reader, options);
						if (value is not null)
						{
							agg.SeqNoPrimaryTerm = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("size"))
					{
						reader.Read();
						var value = JsonSerializer.Deserialize<int?>(ref reader, options);
						if (value is not null)
						{
							agg.Size = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("sort"))
					{
						reader.Read();
						var value = SingleOrManySerializationHelper.Deserialize<Elastic.Clients.Elasticsearch.SortCombinations>(ref reader, options);
						if (value is not null)
						{
							agg.Sort = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("stored_fields"))
					{
						reader.Read();
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Fields?>(ref reader, options);
						if (value is not null)
						{
							agg.StoredFields = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("track_scores"))
					{
						reader.Read();
						var value = JsonSerializer.Deserialize<bool?>(ref reader, options);
						if (value is not null)
						{
							agg.TrackScores = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("version"))
					{
						reader.Read();
						var value = JsonSerializer.Deserialize<bool?>(ref reader, options);
						if (value is not null)
						{
							agg.Version = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("field"))
					{
						reader.Read();
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
						if (value is not null)
						{
							agg.Field = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("script"))
					{
						reader.Read();
						var value = JsonSerializer.Deserialize<ScriptBase?>(ref reader, options);
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
			if (value.Source is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, value.Source, options);
			}

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

			if (value.SeqNoPrimaryTerm.HasValue)
			{
				writer.WritePropertyName("seq_no_primary_term");
				writer.WriteBooleanValue(value.SeqNoPrimaryTerm.Value);
			}

			if (value.Size.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(value.Size.Value);
			}

			if (value.Sort is not null)
			{
				writer.WritePropertyName("sort");
				SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.SortCombinations>(value.Sort, writer, options);
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

			if (value.Field is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, value.Field, options);
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
	public partial class TopHitsAggregation : MetricAggregationBase
	{
		public TopHitsAggregation(string name, Field field) : base(name) => Field = field;
		public TopHitsAggregation(string name) : base(name)
		{
		}

		public Elastic.Clients.Elasticsearch.SourceConfig? Source { get; set; }

		public Elastic.Clients.Elasticsearch.Fields? DocvalueFields { get; set; }

		public bool? Explain { get; set; }

		public int? From { get; set; }

		public Elastic.Clients.Elasticsearch.Highlight? Highlight { get; set; }

		public Dictionary<string, Elastic.Clients.Elasticsearch.ScriptField>? ScriptFields { get; set; }

		public bool? SeqNoPrimaryTerm { get; set; }

		public int? Size { get; set; }

		[JsonConverter(typeof(SortConverter))]
		public IEnumerable<Elastic.Clients.Elasticsearch.SortCombinations>? Sort { get; set; }

		public Elastic.Clients.Elasticsearch.Fields? StoredFields { get; set; }

		public bool? TrackScores { get; set; }

		public bool? Version { get; set; }
	}

	public sealed partial class TopHitsAggregationDescriptor<TDocument> : SerializableDescriptorBase<TopHitsAggregationDescriptor<TDocument>>
	{
		internal TopHitsAggregationDescriptor(Action<TopHitsAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
		public TopHitsAggregationDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Highlight? HighlightValue { get; set; }

		private HighlightDescriptor<TDocument> HighlightDescriptor { get; set; }

		private Action<HighlightDescriptor<TDocument>> HighlightDescriptorAction { get; set; }

		private ScriptBase? ScriptValue { get; set; }

		private ScriptDescriptor ScriptDescriptor { get; set; }

		private Action<ScriptDescriptor> ScriptDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.SourceConfig? SourceValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields? DocvalueFieldsValue { get; set; }

		private bool? ExplainValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private int? FromValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private Dictionary<string, Elastic.Clients.Elasticsearch.ScriptField>? ScriptFieldsValue { get; set; }

		private bool? SeqNoPrimaryTermValue { get; set; }

		private int? SizeValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.SortCombinations>? SortValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields? StoredFieldsValue { get; set; }

		private bool? TrackScoresValue { get; set; }

		private bool? VersionValue { get; set; }

		public TopHitsAggregationDescriptor<TDocument> Highlight(Elastic.Clients.Elasticsearch.Highlight? highlight)
		{
			HighlightDescriptor = null;
			HighlightDescriptorAction = null;
			HighlightValue = highlight;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> Highlight(HighlightDescriptor<TDocument> descriptor)
		{
			HighlightValue = null;
			HighlightDescriptorAction = null;
			HighlightDescriptor = descriptor;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> Highlight(Action<HighlightDescriptor<TDocument>> configure)
		{
			HighlightValue = null;
			HighlightDescriptor = null;
			HighlightDescriptorAction = configure;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> Script(ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			ScriptValue = script;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> Script(ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			ScriptDescriptor = descriptor;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> Script(Action<ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptor = null;
			ScriptDescriptorAction = configure;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> Source(Elastic.Clients.Elasticsearch.SourceConfig? source)
		{
			SourceValue = source;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> DocvalueFields(Elastic.Clients.Elasticsearch.Fields? docvalueFields)
		{
			DocvalueFieldsValue = docvalueFields;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> DocvalueFields<TValue>(Expression<Func<TDocument, TValue>> docvalueFields)
		{
			DocvalueFieldsValue = docvalueFields;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> Explain(bool? explain = true)
		{
			ExplainValue = explain;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> From(int? from)
		{
			FromValue = from;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> ScriptFields(Func<FluentDictionary<string, Elastic.Clients.Elasticsearch.ScriptField>, FluentDictionary<string, Elastic.Clients.Elasticsearch.ScriptField>> selector)
		{
			ScriptFieldsValue = selector?.Invoke(new FluentDictionary<string, Elastic.Clients.Elasticsearch.ScriptField>());
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> SeqNoPrimaryTerm(bool? seqNoPrimaryTerm = true)
		{
			SeqNoPrimaryTermValue = seqNoPrimaryTerm;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> Size(int? size)
		{
			SizeValue = size;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> Sort(IEnumerable<Elastic.Clients.Elasticsearch.SortCombinations>? sort)
		{
			SortValue = sort;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> StoredFields(Elastic.Clients.Elasticsearch.Fields? storedFields)
		{
			StoredFieldsValue = storedFields;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> StoredFields<TValue>(Expression<Func<TDocument, TValue>> storedFields)
		{
			StoredFieldsValue = storedFields;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> TrackScores(bool? trackScores = true)
		{
			TrackScoresValue = trackScores;
			return Self;
		}

		public TopHitsAggregationDescriptor<TDocument> Version(bool? version = true)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("top_hits");
			writer.WriteStartObject();
			if (HighlightDescriptor is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, HighlightDescriptor, options);
			}
			else if (HighlightDescriptorAction is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, new HighlightDescriptor<TDocument>(HighlightDescriptorAction), options);
			}
			else if (HighlightValue is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, HighlightValue, options);
			}

			if (ScriptDescriptor is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptDescriptor, options);
			}
			else if (ScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, new ScriptDescriptor(ScriptDescriptorAction), options);
			}
			else if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (SourceValue is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, SourceValue, options);
			}

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

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (FromValue.HasValue)
			{
				writer.WritePropertyName("from");
				writer.WriteNumberValue(FromValue.Value);
			}

			if (ScriptFieldsValue is not null)
			{
				writer.WritePropertyName("script_fields");
				JsonSerializer.Serialize(writer, ScriptFieldsValue, options);
			}

			if (SeqNoPrimaryTermValue.HasValue)
			{
				writer.WritePropertyName("seq_no_primary_term");
				writer.WriteBooleanValue(SeqNoPrimaryTermValue.Value);
			}

			if (SizeValue.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(SizeValue.Value);
			}

			if (SortValue is not null)
			{
				writer.WritePropertyName("sort");
				SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.SortCombinations>(SortValue, writer, options);
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

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class TopHitsAggregationDescriptor : SerializableDescriptorBase<TopHitsAggregationDescriptor>
	{
		internal TopHitsAggregationDescriptor(Action<TopHitsAggregationDescriptor> configure) => configure.Invoke(this);
		public TopHitsAggregationDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Highlight? HighlightValue { get; set; }

		private HighlightDescriptor HighlightDescriptor { get; set; }

		private Action<HighlightDescriptor> HighlightDescriptorAction { get; set; }

		private ScriptBase? ScriptValue { get; set; }

		private ScriptDescriptor ScriptDescriptor { get; set; }

		private Action<ScriptDescriptor> ScriptDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.SourceConfig? SourceValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields? DocvalueFieldsValue { get; set; }

		private bool? ExplainValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private int? FromValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private Dictionary<string, Elastic.Clients.Elasticsearch.ScriptField>? ScriptFieldsValue { get; set; }

		private bool? SeqNoPrimaryTermValue { get; set; }

		private int? SizeValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.SortCombinations>? SortValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields? StoredFieldsValue { get; set; }

		private bool? TrackScoresValue { get; set; }

		private bool? VersionValue { get; set; }

		public TopHitsAggregationDescriptor Highlight(Elastic.Clients.Elasticsearch.Highlight? highlight)
		{
			HighlightDescriptor = null;
			HighlightDescriptorAction = null;
			HighlightValue = highlight;
			return Self;
		}

		public TopHitsAggregationDescriptor Highlight(HighlightDescriptor descriptor)
		{
			HighlightValue = null;
			HighlightDescriptorAction = null;
			HighlightDescriptor = descriptor;
			return Self;
		}

		public TopHitsAggregationDescriptor Highlight(Action<HighlightDescriptor> configure)
		{
			HighlightValue = null;
			HighlightDescriptor = null;
			HighlightDescriptorAction = configure;
			return Self;
		}

		public TopHitsAggregationDescriptor Script(ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			ScriptValue = script;
			return Self;
		}

		public TopHitsAggregationDescriptor Script(ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			ScriptDescriptor = descriptor;
			return Self;
		}

		public TopHitsAggregationDescriptor Script(Action<ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptor = null;
			ScriptDescriptorAction = configure;
			return Self;
		}

		public TopHitsAggregationDescriptor Source(Elastic.Clients.Elasticsearch.SourceConfig? source)
		{
			SourceValue = source;
			return Self;
		}

		public TopHitsAggregationDescriptor DocvalueFields(Elastic.Clients.Elasticsearch.Fields? docvalueFields)
		{
			DocvalueFieldsValue = docvalueFields;
			return Self;
		}

		public TopHitsAggregationDescriptor DocvalueFields<TDocument, TValue>(Expression<Func<TDocument, TValue>> docvalueFields)
		{
			DocvalueFieldsValue = docvalueFields;
			return Self;
		}

		public TopHitsAggregationDescriptor DocvalueFields<TDocument>(Expression<Func<TDocument, object>> docvalueFields)
		{
			DocvalueFieldsValue = docvalueFields;
			return Self;
		}

		public TopHitsAggregationDescriptor Explain(bool? explain = true)
		{
			ExplainValue = explain;
			return Self;
		}

		public TopHitsAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public TopHitsAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public TopHitsAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public TopHitsAggregationDescriptor From(int? from)
		{
			FromValue = from;
			return Self;
		}

		public TopHitsAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public TopHitsAggregationDescriptor ScriptFields(Func<FluentDictionary<string, Elastic.Clients.Elasticsearch.ScriptField>, FluentDictionary<string, Elastic.Clients.Elasticsearch.ScriptField>> selector)
		{
			ScriptFieldsValue = selector?.Invoke(new FluentDictionary<string, Elastic.Clients.Elasticsearch.ScriptField>());
			return Self;
		}

		public TopHitsAggregationDescriptor SeqNoPrimaryTerm(bool? seqNoPrimaryTerm = true)
		{
			SeqNoPrimaryTermValue = seqNoPrimaryTerm;
			return Self;
		}

		public TopHitsAggregationDescriptor Size(int? size)
		{
			SizeValue = size;
			return Self;
		}

		public TopHitsAggregationDescriptor Sort(IEnumerable<Elastic.Clients.Elasticsearch.SortCombinations>? sort)
		{
			SortValue = sort;
			return Self;
		}

		public TopHitsAggregationDescriptor StoredFields(Elastic.Clients.Elasticsearch.Fields? storedFields)
		{
			StoredFieldsValue = storedFields;
			return Self;
		}

		public TopHitsAggregationDescriptor StoredFields<TDocument, TValue>(Expression<Func<TDocument, TValue>> storedFields)
		{
			StoredFieldsValue = storedFields;
			return Self;
		}

		public TopHitsAggregationDescriptor StoredFields<TDocument>(Expression<Func<TDocument, object>> storedFields)
		{
			StoredFieldsValue = storedFields;
			return Self;
		}

		public TopHitsAggregationDescriptor TrackScores(bool? trackScores = true)
		{
			TrackScoresValue = trackScores;
			return Self;
		}

		public TopHitsAggregationDescriptor Version(bool? version = true)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("top_hits");
			writer.WriteStartObject();
			if (HighlightDescriptor is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, HighlightDescriptor, options);
			}
			else if (HighlightDescriptorAction is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, new HighlightDescriptor(HighlightDescriptorAction), options);
			}
			else if (HighlightValue is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, HighlightValue, options);
			}

			if (ScriptDescriptor is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptDescriptor, options);
			}
			else if (ScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, new ScriptDescriptor(ScriptDescriptorAction), options);
			}
			else if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (SourceValue is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, SourceValue, options);
			}

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

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (FromValue.HasValue)
			{
				writer.WritePropertyName("from");
				writer.WriteNumberValue(FromValue.Value);
			}

			if (ScriptFieldsValue is not null)
			{
				writer.WritePropertyName("script_fields");
				JsonSerializer.Serialize(writer, ScriptFieldsValue, options);
			}

			if (SeqNoPrimaryTermValue.HasValue)
			{
				writer.WritePropertyName("seq_no_primary_term");
				writer.WriteBooleanValue(SeqNoPrimaryTermValue.Value);
			}

			if (SizeValue.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(SizeValue.Value);
			}

			if (SortValue is not null)
			{
				writer.WritePropertyName("sort");
				SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.SortCombinations>(SortValue, writer, options);
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