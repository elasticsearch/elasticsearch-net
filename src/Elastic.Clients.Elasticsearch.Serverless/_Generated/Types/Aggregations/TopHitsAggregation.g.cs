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

#nullable restore

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Aggregations;

public sealed partial class TopHitsAggregation
{
	/// <summary>
	/// <para>Fields for which to return doc values.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("docvalue_fields")]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? DocvalueFields { get; set; }

	/// <summary>
	/// <para>If `true`, returns detailed information about score computation as part of a hit.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("explain")]
	public bool? Explain { get; set; }

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field? Field { get; set; }

	/// <summary>
	/// <para>Starting document offset.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("from")]
	public int? From { get; set; }

	/// <summary>
	/// <para>Specifies the highlighter to use for retrieving highlighted snippets from one or more fields in the search results.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("highlight")]
	public Elastic.Clients.Elasticsearch.Serverless.Core.Search.Highlight? Highlight { get; set; }

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("missing")]
	public Elastic.Clients.Elasticsearch.Serverless.FieldValue? Missing { get; set; }
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Serverless.Script? Script { get; set; }

	/// <summary>
	/// <para>Returns the result of one or more script evaluations for each hit.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("script_fields")]
	public IDictionary<string, Elastic.Clients.Elasticsearch.Serverless.ScriptField>? ScriptFields { get; set; }

	/// <summary>
	/// <para>If `true`, returns sequence number and primary term of the last modification of each hit.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("seq_no_primary_term")]
	public bool? SeqNoPrimaryTerm { get; set; }

	/// <summary>
	/// <para>The maximum number of top matching hits to return per bucket.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("size")]
	public int? Size { get; set; }

	/// <summary>
	/// <para>Sort order of the top matching hits.<br/>By default, the hits are sorted by the score of the main query.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("sort")]
	[SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.Serverless.SortOptions))]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.SortOptions>? Sort { get; set; }

	/// <summary>
	/// <para>Selects the fields of the source that are returned.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_source")]
	public Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfig? Source { get; set; }

	/// <summary>
	/// <para>Returns values for the specified stored fields (fields that use the `store` mapping option).</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("stored_fields")]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? StoredFields { get; set; }

	/// <summary>
	/// <para>If `true`, calculates and returns document scores, even if the scores are not used for sorting.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("track_scores")]
	public bool? TrackScores { get; set; }

	/// <summary>
	/// <para>If `true`, returns document version as part of a hit.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("version")]
	public bool? Version { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.Aggregations.Aggregation(TopHitsAggregation topHitsAggregation) => Elastic.Clients.Elasticsearch.Serverless.Aggregations.Aggregation.TopHits(topHitsAggregation);
}

public sealed partial class TopHitsAggregationDescriptor<TDocument> : SerializableDescriptor<TopHitsAggregationDescriptor<TDocument>>
{
	internal TopHitsAggregationDescriptor(Action<TopHitsAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public TopHitsAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Fields? DocvalueFieldsValue { get; set; }
	private bool? ExplainValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? FieldValue { get; set; }
	private int? FromValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.Highlight? HighlightValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlightDescriptor<TDocument> HighlightDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlightDescriptor<TDocument>> HighlightDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.FieldValue? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Script? ScriptValue { get; set; }
	private IDictionary<string, Elastic.Clients.Elasticsearch.Serverless.ScriptFieldDescriptor> ScriptFieldsValue { get; set; }
	private bool? SeqNoPrimaryTermValue { get; set; }
	private int? SizeValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.SortOptions>? SortValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor<TDocument> SortDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor<TDocument>> SortDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor<TDocument>>[] SortDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfig? SourceValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fields? StoredFieldsValue { get; set; }
	private bool? TrackScoresValue { get; set; }
	private bool? VersionValue { get; set; }

	/// <summary>
	/// <para>Fields for which to return doc values.</para>
	/// </summary>
	public TopHitsAggregationDescriptor<TDocument> DocvalueFields(Elastic.Clients.Elasticsearch.Serverless.Fields? docvalueFields)
	{
		DocvalueFieldsValue = docvalueFields;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, returns detailed information about score computation as part of a hit.</para>
	/// </summary>
	public TopHitsAggregationDescriptor<TDocument> Explain(bool? explain = true)
	{
		ExplainValue = explain;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public TopHitsAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public TopHitsAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public TopHitsAggregationDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Starting document offset.</para>
	/// </summary>
	public TopHitsAggregationDescriptor<TDocument> From(int? from)
	{
		FromValue = from;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the highlighter to use for retrieving highlighted snippets from one or more fields in the search results.</para>
	/// </summary>
	public TopHitsAggregationDescriptor<TDocument> Highlight(Elastic.Clients.Elasticsearch.Serverless.Core.Search.Highlight? highlight)
	{
		HighlightDescriptor = null;
		HighlightDescriptorAction = null;
		HighlightValue = highlight;
		return Self;
	}

	public TopHitsAggregationDescriptor<TDocument> Highlight(Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlightDescriptor<TDocument> descriptor)
	{
		HighlightValue = null;
		HighlightDescriptorAction = null;
		HighlightDescriptor = descriptor;
		return Self;
	}

	public TopHitsAggregationDescriptor<TDocument> Highlight(Action<Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlightDescriptor<TDocument>> configure)
	{
		HighlightValue = null;
		HighlightDescriptor = null;
		HighlightDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	public TopHitsAggregationDescriptor<TDocument> Missing(Elastic.Clients.Elasticsearch.Serverless.FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public TopHitsAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Serverless.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	/// <summary>
	/// <para>Returns the result of one or more script evaluations for each hit.</para>
	/// </summary>
	public TopHitsAggregationDescriptor<TDocument> ScriptFields(Func<FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Serverless.ScriptFieldDescriptor>, FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Serverless.ScriptFieldDescriptor>> selector)
	{
		ScriptFieldsValue = selector?.Invoke(new FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Serverless.ScriptFieldDescriptor>());
		return Self;
	}

	/// <summary>
	/// <para>If `true`, returns sequence number and primary term of the last modification of each hit.</para>
	/// </summary>
	public TopHitsAggregationDescriptor<TDocument> SeqNoPrimaryTerm(bool? seqNoPrimaryTerm = true)
	{
		SeqNoPrimaryTermValue = seqNoPrimaryTerm;
		return Self;
	}

	/// <summary>
	/// <para>The maximum number of top matching hits to return per bucket.</para>
	/// </summary>
	public TopHitsAggregationDescriptor<TDocument> Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	/// <summary>
	/// <para>Sort order of the top matching hits.<br/>By default, the hits are sorted by the score of the main query.</para>
	/// </summary>
	public TopHitsAggregationDescriptor<TDocument> Sort(ICollection<Elastic.Clients.Elasticsearch.Serverless.SortOptions>? sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortValue = sort;
		return Self;
	}

	public TopHitsAggregationDescriptor<TDocument> Sort(Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor<TDocument> descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public TopHitsAggregationDescriptor<TDocument> Sort(Action<Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor<TDocument>> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorActions = null;
		SortDescriptorAction = configure;
		return Self;
	}

	public TopHitsAggregationDescriptor<TDocument> Sort(params Action<Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor<TDocument>>[] configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Selects the fields of the source that are returned.</para>
	/// </summary>
	public TopHitsAggregationDescriptor<TDocument> Source(Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfig? source)
	{
		SourceValue = source;
		return Self;
	}

	/// <summary>
	/// <para>Returns values for the specified stored fields (fields that use the `store` mapping option).</para>
	/// </summary>
	public TopHitsAggregationDescriptor<TDocument> StoredFields(Elastic.Clients.Elasticsearch.Serverless.Fields? storedFields)
	{
		StoredFieldsValue = storedFields;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, calculates and returns document scores, even if the scores are not used for sorting.</para>
	/// </summary>
	public TopHitsAggregationDescriptor<TDocument> TrackScores(bool? trackScores = true)
	{
		TrackScoresValue = trackScores;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, returns document version as part of a hit.</para>
	/// </summary>
	public TopHitsAggregationDescriptor<TDocument> Version(bool? version = true)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
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

		if (HighlightDescriptor is not null)
		{
			writer.WritePropertyName("highlight");
			JsonSerializer.Serialize(writer, HighlightDescriptor, options);
		}
		else if (HighlightDescriptorAction is not null)
		{
			writer.WritePropertyName("highlight");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlightDescriptor<TDocument>(HighlightDescriptorAction), options);
		}
		else if (HighlightValue is not null)
		{
			writer.WritePropertyName("highlight");
			JsonSerializer.Serialize(writer, HighlightValue, options);
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

		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor<TDocument>(SortDescriptorAction), options);
		}
		else if (SortDescriptorActions is not null)
		{
			writer.WritePropertyName("sort");
			if (SortDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in SortDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor<TDocument>(action), options);
			}

			if (SortDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (SortValue is not null)
		{
			writer.WritePropertyName("sort");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.Serverless.SortOptions>(SortValue, writer, options);
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

		writer.WriteEndObject();
	}
}

public sealed partial class TopHitsAggregationDescriptor : SerializableDescriptor<TopHitsAggregationDescriptor>
{
	internal TopHitsAggregationDescriptor(Action<TopHitsAggregationDescriptor> configure) => configure.Invoke(this);

	public TopHitsAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Fields? DocvalueFieldsValue { get; set; }
	private bool? ExplainValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? FieldValue { get; set; }
	private int? FromValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.Highlight? HighlightValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlightDescriptor HighlightDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlightDescriptor> HighlightDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.FieldValue? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Script? ScriptValue { get; set; }
	private IDictionary<string, Elastic.Clients.Elasticsearch.Serverless.ScriptFieldDescriptor> ScriptFieldsValue { get; set; }
	private bool? SeqNoPrimaryTermValue { get; set; }
	private int? SizeValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.SortOptions>? SortValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor SortDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor> SortDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor>[] SortDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfig? SourceValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fields? StoredFieldsValue { get; set; }
	private bool? TrackScoresValue { get; set; }
	private bool? VersionValue { get; set; }

	/// <summary>
	/// <para>Fields for which to return doc values.</para>
	/// </summary>
	public TopHitsAggregationDescriptor DocvalueFields(Elastic.Clients.Elasticsearch.Serverless.Fields? docvalueFields)
	{
		DocvalueFieldsValue = docvalueFields;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, returns detailed information about score computation as part of a hit.</para>
	/// </summary>
	public TopHitsAggregationDescriptor Explain(bool? explain = true)
	{
		ExplainValue = explain;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public TopHitsAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public TopHitsAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public TopHitsAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Starting document offset.</para>
	/// </summary>
	public TopHitsAggregationDescriptor From(int? from)
	{
		FromValue = from;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the highlighter to use for retrieving highlighted snippets from one or more fields in the search results.</para>
	/// </summary>
	public TopHitsAggregationDescriptor Highlight(Elastic.Clients.Elasticsearch.Serverless.Core.Search.Highlight? highlight)
	{
		HighlightDescriptor = null;
		HighlightDescriptorAction = null;
		HighlightValue = highlight;
		return Self;
	}

	public TopHitsAggregationDescriptor Highlight(Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlightDescriptor descriptor)
	{
		HighlightValue = null;
		HighlightDescriptorAction = null;
		HighlightDescriptor = descriptor;
		return Self;
	}

	public TopHitsAggregationDescriptor Highlight(Action<Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlightDescriptor> configure)
	{
		HighlightValue = null;
		HighlightDescriptor = null;
		HighlightDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	public TopHitsAggregationDescriptor Missing(Elastic.Clients.Elasticsearch.Serverless.FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public TopHitsAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Serverless.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	/// <summary>
	/// <para>Returns the result of one or more script evaluations for each hit.</para>
	/// </summary>
	public TopHitsAggregationDescriptor ScriptFields(Func<FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Serverless.ScriptFieldDescriptor>, FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Serverless.ScriptFieldDescriptor>> selector)
	{
		ScriptFieldsValue = selector?.Invoke(new FluentDescriptorDictionary<string, Elastic.Clients.Elasticsearch.Serverless.ScriptFieldDescriptor>());
		return Self;
	}

	/// <summary>
	/// <para>If `true`, returns sequence number and primary term of the last modification of each hit.</para>
	/// </summary>
	public TopHitsAggregationDescriptor SeqNoPrimaryTerm(bool? seqNoPrimaryTerm = true)
	{
		SeqNoPrimaryTermValue = seqNoPrimaryTerm;
		return Self;
	}

	/// <summary>
	/// <para>The maximum number of top matching hits to return per bucket.</para>
	/// </summary>
	public TopHitsAggregationDescriptor Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	/// <summary>
	/// <para>Sort order of the top matching hits.<br/>By default, the hits are sorted by the score of the main query.</para>
	/// </summary>
	public TopHitsAggregationDescriptor Sort(ICollection<Elastic.Clients.Elasticsearch.Serverless.SortOptions>? sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortValue = sort;
		return Self;
	}

	public TopHitsAggregationDescriptor Sort(Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public TopHitsAggregationDescriptor Sort(Action<Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorActions = null;
		SortDescriptorAction = configure;
		return Self;
	}

	public TopHitsAggregationDescriptor Sort(params Action<Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor>[] configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Selects the fields of the source that are returned.</para>
	/// </summary>
	public TopHitsAggregationDescriptor Source(Elastic.Clients.Elasticsearch.Serverless.Core.Search.SourceConfig? source)
	{
		SourceValue = source;
		return Self;
	}

	/// <summary>
	/// <para>Returns values for the specified stored fields (fields that use the `store` mapping option).</para>
	/// </summary>
	public TopHitsAggregationDescriptor StoredFields(Elastic.Clients.Elasticsearch.Serverless.Fields? storedFields)
	{
		StoredFieldsValue = storedFields;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, calculates and returns document scores, even if the scores are not used for sorting.</para>
	/// </summary>
	public TopHitsAggregationDescriptor TrackScores(bool? trackScores = true)
	{
		TrackScoresValue = trackScores;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, returns document version as part of a hit.</para>
	/// </summary>
	public TopHitsAggregationDescriptor Version(bool? version = true)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
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

		if (HighlightDescriptor is not null)
		{
			writer.WritePropertyName("highlight");
			JsonSerializer.Serialize(writer, HighlightDescriptor, options);
		}
		else if (HighlightDescriptorAction is not null)
		{
			writer.WritePropertyName("highlight");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlightDescriptor(HighlightDescriptorAction), options);
		}
		else if (HighlightValue is not null)
		{
			writer.WritePropertyName("highlight");
			JsonSerializer.Serialize(writer, HighlightValue, options);
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

		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor(SortDescriptorAction), options);
		}
		else if (SortDescriptorActions is not null)
		{
			writer.WritePropertyName("sort");
			if (SortDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in SortDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.SortOptionsDescriptor(action), options);
			}

			if (SortDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (SortValue is not null)
		{
			writer.WritePropertyName("sort");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.Serverless.SortOptions>(SortValue, writer, options);
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

		writer.WriteEndObject();
	}
}