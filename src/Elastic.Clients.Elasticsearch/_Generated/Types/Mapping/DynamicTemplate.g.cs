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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Mapping;
public sealed partial class DynamicTemplate
{
	[JsonInclude, JsonPropertyName("mapping")]
	public Elastic.Clients.Elasticsearch.Mapping.IProperty? Mapping { get; set; }

	[JsonInclude, JsonPropertyName("match")]
	public string? Match { get; set; }

	[JsonInclude, JsonPropertyName("match_mapping_type")]
	public string? MatchMappingType { get; set; }

	[JsonInclude, JsonPropertyName("match_pattern")]
	public Elastic.Clients.Elasticsearch.Mapping.MatchType? MatchPattern { get; set; }

	[JsonInclude, JsonPropertyName("path_match")]
	public string? PathMatch { get; set; }

	[JsonInclude, JsonPropertyName("path_unmatch")]
	public string? PathUnmatch { get; set; }

	[JsonInclude, JsonPropertyName("unmatch")]
	public string? Unmatch { get; set; }
}

public sealed partial class DynamicTemplateDescriptor : SerializableDescriptor<DynamicTemplateDescriptor>
{
	internal DynamicTemplateDescriptor(Action<DynamicTemplateDescriptor> configure) => configure.Invoke(this);
	public DynamicTemplateDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Mapping.Properties? MappingValue { get; set; }

	private string? MatchValue { get; set; }

	private string? MatchMappingTypeValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.MatchType? MatchPatternValue { get; set; }

	private string? PathMatchValue { get; set; }

	private string? PathUnmatchValue { get; set; }

	private string? UnmatchValue { get; set; }

	public DynamicTemplateDescriptor Mapping(Elastic.Clients.Elasticsearch.Mapping.Properties? mapping)
	{
		MappingValue = mapping;
		return Self;
	}

	public DynamicTemplateDescriptor Match(string? match)
	{
		MatchValue = match;
		return Self;
	}

	public DynamicTemplateDescriptor MatchMappingType(string? matchMappingType)
	{
		MatchMappingTypeValue = matchMappingType;
		return Self;
	}

	public DynamicTemplateDescriptor MatchPattern(Elastic.Clients.Elasticsearch.Mapping.MatchType? matchPattern)
	{
		MatchPatternValue = matchPattern;
		return Self;
	}

	public DynamicTemplateDescriptor PathMatch(string? pathMatch)
	{
		PathMatchValue = pathMatch;
		return Self;
	}

	public DynamicTemplateDescriptor PathUnmatch(string? pathUnmatch)
	{
		PathUnmatchValue = pathUnmatch;
		return Self;
	}

	public DynamicTemplateDescriptor Unmatch(string? unmatch)
	{
		UnmatchValue = unmatch;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (MappingValue is not null)
		{
			writer.WritePropertyName("mapping");
			JsonSerializer.Serialize(writer, MappingValue, options);
		}

		if (!string.IsNullOrEmpty(MatchValue))
		{
			writer.WritePropertyName("match");
			writer.WriteStringValue(MatchValue);
		}

		if (!string.IsNullOrEmpty(MatchMappingTypeValue))
		{
			writer.WritePropertyName("match_mapping_type");
			writer.WriteStringValue(MatchMappingTypeValue);
		}

		if (MatchPatternValue is not null)
		{
			writer.WritePropertyName("match_pattern");
			JsonSerializer.Serialize(writer, MatchPatternValue, options);
		}

		if (!string.IsNullOrEmpty(PathMatchValue))
		{
			writer.WritePropertyName("path_match");
			writer.WriteStringValue(PathMatchValue);
		}

		if (!string.IsNullOrEmpty(PathUnmatchValue))
		{
			writer.WritePropertyName("path_unmatch");
			writer.WriteStringValue(PathUnmatchValue);
		}

		if (!string.IsNullOrEmpty(UnmatchValue))
		{
			writer.WritePropertyName("unmatch");
			writer.WriteStringValue(UnmatchValue);
		}

		writer.WriteEndObject();
	}
}
