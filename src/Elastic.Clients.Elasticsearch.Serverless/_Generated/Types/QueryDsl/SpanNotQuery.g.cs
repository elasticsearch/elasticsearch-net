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

namespace Elastic.Clients.Elasticsearch.Serverless.QueryDsl;

public sealed partial class SpanNotQuery : SearchQuery
{
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }
	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }

	/// <summary>
	/// <para>The number of tokens from within the include span that can’t have overlap with the exclude span.<br/>Equivalent to setting both `pre` and `post`.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("dist")]
	public int? Dist { get; set; }

	/// <summary>
	/// <para>Span query whose matches must not overlap those returned.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("exclude")]
	public Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQuery Exclude { get; set; }

	/// <summary>
	/// <para>Span query whose matches are filtered.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("include")]
	public Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQuery Include { get; set; }

	/// <summary>
	/// <para>The number of tokens after the include span that can’t have overlap with the exclude span.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("post")]
	public int? Post { get; set; }

	/// <summary>
	/// <para>The number of tokens before the include span that can’t have overlap with the exclude span.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("pre")]
	public int? Pre { get; set; }

	internal override void InternalWrapInContainer(Query container) => container.WrapVariant("span_not", this);
}

public sealed partial class SpanNotQueryDescriptor<TDocument> : SerializableDescriptor<SpanNotQueryDescriptor<TDocument>>
{
	internal SpanNotQueryDescriptor(Action<SpanNotQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public SpanNotQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private int? DistValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQuery ExcludeValue { get; set; }
	private SpanQueryDescriptor<TDocument> ExcludeDescriptor { get; set; }
	private Action<SpanQueryDescriptor<TDocument>> ExcludeDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQuery IncludeValue { get; set; }
	private SpanQueryDescriptor<TDocument> IncludeDescriptor { get; set; }
	private Action<SpanQueryDescriptor<TDocument>> IncludeDescriptorAction { get; set; }
	private int? PostValue { get; set; }
	private int? PreValue { get; set; }
	private string? QueryNameValue { get; set; }

	public SpanNotQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>The number of tokens from within the include span that can’t have overlap with the exclude span.<br/>Equivalent to setting both `pre` and `post`.</para>
	/// </summary>
	public SpanNotQueryDescriptor<TDocument> Dist(int? dist)
	{
		DistValue = dist;
		return Self;
	}

	/// <summary>
	/// <para>Span query whose matches must not overlap those returned.</para>
	/// </summary>
	public SpanNotQueryDescriptor<TDocument> Exclude(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQuery exclude)
	{
		ExcludeDescriptor = null;
		ExcludeDescriptorAction = null;
		ExcludeValue = exclude;
		return Self;
	}

	public SpanNotQueryDescriptor<TDocument> Exclude(SpanQueryDescriptor<TDocument> descriptor)
	{
		ExcludeValue = null;
		ExcludeDescriptorAction = null;
		ExcludeDescriptor = descriptor;
		return Self;
	}

	public SpanNotQueryDescriptor<TDocument> Exclude(Action<SpanQueryDescriptor<TDocument>> configure)
	{
		ExcludeValue = null;
		ExcludeDescriptor = null;
		ExcludeDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Span query whose matches are filtered.</para>
	/// </summary>
	public SpanNotQueryDescriptor<TDocument> Include(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQuery include)
	{
		IncludeDescriptor = null;
		IncludeDescriptorAction = null;
		IncludeValue = include;
		return Self;
	}

	public SpanNotQueryDescriptor<TDocument> Include(SpanQueryDescriptor<TDocument> descriptor)
	{
		IncludeValue = null;
		IncludeDescriptorAction = null;
		IncludeDescriptor = descriptor;
		return Self;
	}

	public SpanNotQueryDescriptor<TDocument> Include(Action<SpanQueryDescriptor<TDocument>> configure)
	{
		IncludeValue = null;
		IncludeDescriptor = null;
		IncludeDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The number of tokens after the include span that can’t have overlap with the exclude span.</para>
	/// </summary>
	public SpanNotQueryDescriptor<TDocument> Post(int? post)
	{
		PostValue = post;
		return Self;
	}

	/// <summary>
	/// <para>The number of tokens before the include span that can’t have overlap with the exclude span.</para>
	/// </summary>
	public SpanNotQueryDescriptor<TDocument> Pre(int? pre)
	{
		PreValue = pre;
		return Self;
	}

	public SpanNotQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (DistValue.HasValue)
		{
			writer.WritePropertyName("dist");
			writer.WriteNumberValue(DistValue.Value);
		}

		if (ExcludeDescriptor is not null)
		{
			writer.WritePropertyName("exclude");
			JsonSerializer.Serialize(writer, ExcludeDescriptor, options);
		}
		else if (ExcludeDescriptorAction is not null)
		{
			writer.WritePropertyName("exclude");
			JsonSerializer.Serialize(writer, new SpanQueryDescriptor<TDocument>(ExcludeDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("exclude");
			JsonSerializer.Serialize(writer, ExcludeValue, options);
		}

		if (IncludeDescriptor is not null)
		{
			writer.WritePropertyName("include");
			JsonSerializer.Serialize(writer, IncludeDescriptor, options);
		}
		else if (IncludeDescriptorAction is not null)
		{
			writer.WritePropertyName("include");
			JsonSerializer.Serialize(writer, new SpanQueryDescriptor<TDocument>(IncludeDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("include");
			JsonSerializer.Serialize(writer, IncludeValue, options);
		}

		if (PostValue.HasValue)
		{
			writer.WritePropertyName("post");
			writer.WriteNumberValue(PostValue.Value);
		}

		if (PreValue.HasValue)
		{
			writer.WritePropertyName("pre");
			writer.WriteNumberValue(PreValue.Value);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class SpanNotQueryDescriptor : SerializableDescriptor<SpanNotQueryDescriptor>
{
	internal SpanNotQueryDescriptor(Action<SpanNotQueryDescriptor> configure) => configure.Invoke(this);

	public SpanNotQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private int? DistValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQuery ExcludeValue { get; set; }
	private SpanQueryDescriptor ExcludeDescriptor { get; set; }
	private Action<SpanQueryDescriptor> ExcludeDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQuery IncludeValue { get; set; }
	private SpanQueryDescriptor IncludeDescriptor { get; set; }
	private Action<SpanQueryDescriptor> IncludeDescriptorAction { get; set; }
	private int? PostValue { get; set; }
	private int? PreValue { get; set; }
	private string? QueryNameValue { get; set; }

	public SpanNotQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>The number of tokens from within the include span that can’t have overlap with the exclude span.<br/>Equivalent to setting both `pre` and `post`.</para>
	/// </summary>
	public SpanNotQueryDescriptor Dist(int? dist)
	{
		DistValue = dist;
		return Self;
	}

	/// <summary>
	/// <para>Span query whose matches must not overlap those returned.</para>
	/// </summary>
	public SpanNotQueryDescriptor Exclude(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQuery exclude)
	{
		ExcludeDescriptor = null;
		ExcludeDescriptorAction = null;
		ExcludeValue = exclude;
		return Self;
	}

	public SpanNotQueryDescriptor Exclude(SpanQueryDescriptor descriptor)
	{
		ExcludeValue = null;
		ExcludeDescriptorAction = null;
		ExcludeDescriptor = descriptor;
		return Self;
	}

	public SpanNotQueryDescriptor Exclude(Action<SpanQueryDescriptor> configure)
	{
		ExcludeValue = null;
		ExcludeDescriptor = null;
		ExcludeDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Span query whose matches are filtered.</para>
	/// </summary>
	public SpanNotQueryDescriptor Include(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQuery include)
	{
		IncludeDescriptor = null;
		IncludeDescriptorAction = null;
		IncludeValue = include;
		return Self;
	}

	public SpanNotQueryDescriptor Include(SpanQueryDescriptor descriptor)
	{
		IncludeValue = null;
		IncludeDescriptorAction = null;
		IncludeDescriptor = descriptor;
		return Self;
	}

	public SpanNotQueryDescriptor Include(Action<SpanQueryDescriptor> configure)
	{
		IncludeValue = null;
		IncludeDescriptor = null;
		IncludeDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The number of tokens after the include span that can’t have overlap with the exclude span.</para>
	/// </summary>
	public SpanNotQueryDescriptor Post(int? post)
	{
		PostValue = post;
		return Self;
	}

	/// <summary>
	/// <para>The number of tokens before the include span that can’t have overlap with the exclude span.</para>
	/// </summary>
	public SpanNotQueryDescriptor Pre(int? pre)
	{
		PreValue = pre;
		return Self;
	}

	public SpanNotQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (DistValue.HasValue)
		{
			writer.WritePropertyName("dist");
			writer.WriteNumberValue(DistValue.Value);
		}

		if (ExcludeDescriptor is not null)
		{
			writer.WritePropertyName("exclude");
			JsonSerializer.Serialize(writer, ExcludeDescriptor, options);
		}
		else if (ExcludeDescriptorAction is not null)
		{
			writer.WritePropertyName("exclude");
			JsonSerializer.Serialize(writer, new SpanQueryDescriptor(ExcludeDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("exclude");
			JsonSerializer.Serialize(writer, ExcludeValue, options);
		}

		if (IncludeDescriptor is not null)
		{
			writer.WritePropertyName("include");
			JsonSerializer.Serialize(writer, IncludeDescriptor, options);
		}
		else if (IncludeDescriptorAction is not null)
		{
			writer.WritePropertyName("include");
			JsonSerializer.Serialize(writer, new SpanQueryDescriptor(IncludeDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("include");
			JsonSerializer.Serialize(writer, IncludeValue, options);
		}

		if (PostValue.HasValue)
		{
			writer.WritePropertyName("post");
			writer.WriteNumberValue(PostValue.Value);
		}

		if (PreValue.HasValue)
		{
			writer.WritePropertyName("pre");
			writer.WriteNumberValue(PreValue.Value);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		writer.WriteEndObject();
	}
}