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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Mapping;

[JsonConverter(typeof(DynamicTemplateConverter))]
public sealed partial class DynamicTemplate
{
	internal DynamicTemplate(string variantName, object variant)
	{
		if (variantName is null)
			throw new ArgumentNullException(nameof(variantName));
		if (variant is null)
			throw new ArgumentNullException(nameof(variant));
		if (string.IsNullOrWhiteSpace(variantName))
			throw new ArgumentException("Variant name must not be empty or whitespace.");
		VariantName = variantName;
		Variant = variant;
	}

	internal object Variant { get; }
	internal string VariantName { get; }

	public static DynamicTemplate Mapping(Elastic.Clients.Elasticsearch.Mapping.IProperty property) => new DynamicTemplate("mapping", property);
	public static DynamicTemplate Runtime(Elastic.Clients.Elasticsearch.Mapping.IProperty property) => new DynamicTemplate("runtime", property);

	[JsonInclude, JsonPropertyName("match")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public ICollection<string>? Match { get; set; }
	[JsonInclude, JsonPropertyName("match_mapping_type")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public ICollection<string>? MatchMappingType { get; set; }
	[JsonInclude, JsonPropertyName("match_pattern")]
	public Elastic.Clients.Elasticsearch.Mapping.MatchType? MatchPattern { get; set; }
	[JsonInclude, JsonPropertyName("path_match")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public ICollection<string>? PathMatch { get; set; }
	[JsonInclude, JsonPropertyName("path_unmatch")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public ICollection<string>? PathUnmatch { get; set; }
	[JsonInclude, JsonPropertyName("unmatch")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public ICollection<string>? Unmatch { get; set; }
	[JsonInclude, JsonPropertyName("unmatch_mapping_type")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public ICollection<string>? UnmatchMappingType { get; set; }

	public bool TryGet<T>([NotNullWhen(true)] out T? result) where T : class
	{
		result = default;
		if (Variant is T variant)
		{
			result = variant;
			return true;
		}

		return false;
	}
}

internal sealed partial class DynamicTemplateConverter : JsonConverter<DynamicTemplate>
{
	public override DynamicTemplate Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException("Expected start token.");
		}

		object? variantValue = default;
		string? variantNameValue = default;
		ICollection<string>? matchValue = default;
		ICollection<string>? matchMappingTypeValue = default;
		Elastic.Clients.Elasticsearch.Mapping.MatchType? matchPatternValue = default;
		ICollection<string>? pathMatchValue = default;
		ICollection<string>? pathUnmatchValue = default;
		ICollection<string>? unmatchValue = default;
		ICollection<string>? unmatchMappingTypeValue = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException("Expected a property name token.");
			}

			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException("Expected a property name token representing the name of an Elasticsearch field.");
			}

			var propertyName = reader.GetString();
			reader.Read();
			if (propertyName == "match")
			{
				matchValue = SingleOrManySerializationHelper.Deserialize<string>(ref reader, options);
				continue;
			}

			if (propertyName == "match_mapping_type")
			{
				matchMappingTypeValue = SingleOrManySerializationHelper.Deserialize<string>(ref reader, options);
				continue;
			}

			if (propertyName == "match_pattern")
			{
				matchPatternValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Mapping.MatchType?>(ref reader, options);
				continue;
			}

			if (propertyName == "path_match")
			{
				pathMatchValue = SingleOrManySerializationHelper.Deserialize<string>(ref reader, options);
				continue;
			}

			if (propertyName == "path_unmatch")
			{
				pathUnmatchValue = SingleOrManySerializationHelper.Deserialize<string>(ref reader, options);
				continue;
			}

			if (propertyName == "unmatch")
			{
				unmatchValue = SingleOrManySerializationHelper.Deserialize<string>(ref reader, options);
				continue;
			}

			if (propertyName == "unmatch_mapping_type")
			{
				unmatchMappingTypeValue = SingleOrManySerializationHelper.Deserialize<string>(ref reader, options);
				continue;
			}

			if (propertyName == "mapping")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Mapping.IProperty?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "runtime")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Mapping.IProperty?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			throw new JsonException($"Unknown property name '{propertyName}' received while deserializing the 'DynamicTemplate' from the response.");
		}

		var result = new DynamicTemplate(variantNameValue, variantValue);
		result.Match = matchValue;
		result.MatchMappingType = matchMappingTypeValue;
		result.MatchPattern = matchPatternValue;
		result.PathMatch = pathMatchValue;
		result.PathUnmatch = pathUnmatchValue;
		result.Unmatch = unmatchValue;
		result.UnmatchMappingType = unmatchMappingTypeValue;
		return result;
	}

	public override void Write(Utf8JsonWriter writer, DynamicTemplate value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (value.Match is not null)
		{
			writer.WritePropertyName("match");
			SingleOrManySerializationHelper.Serialize<string>(value.Match, writer, options);
		}

		if (value.MatchMappingType is not null)
		{
			writer.WritePropertyName("match_mapping_type");
			SingleOrManySerializationHelper.Serialize<string>(value.MatchMappingType, writer, options);
		}

		if (value.MatchPattern is not null)
		{
			writer.WritePropertyName("match_pattern");
			JsonSerializer.Serialize(writer, value.MatchPattern, options);
		}

		if (value.PathMatch is not null)
		{
			writer.WritePropertyName("path_match");
			SingleOrManySerializationHelper.Serialize<string>(value.PathMatch, writer, options);
		}

		if (value.PathUnmatch is not null)
		{
			writer.WritePropertyName("path_unmatch");
			SingleOrManySerializationHelper.Serialize<string>(value.PathUnmatch, writer, options);
		}

		if (value.Unmatch is not null)
		{
			writer.WritePropertyName("unmatch");
			SingleOrManySerializationHelper.Serialize<string>(value.Unmatch, writer, options);
		}

		if (value.UnmatchMappingType is not null)
		{
			writer.WritePropertyName("unmatch_mapping_type");
			SingleOrManySerializationHelper.Serialize<string>(value.UnmatchMappingType, writer, options);
		}

		if (value.VariantName is not null && value.Variant is not null)
		{
			writer.WritePropertyName(value.VariantName);
			switch (value.VariantName)
			{
				case "mapping":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Mapping.IProperty>(writer, (Elastic.Clients.Elasticsearch.Mapping.IProperty)value.Variant, options);
					break;
				case "runtime":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Mapping.IProperty>(writer, (Elastic.Clients.Elasticsearch.Mapping.IProperty)value.Variant, options);
					break;
			}
		}

		writer.WriteEndObject();
	}
}

public sealed partial class DynamicTemplateDescriptor<TDocument> : SerializableDescriptor<DynamicTemplateDescriptor<TDocument>>
{
	internal DynamicTemplateDescriptor(Action<DynamicTemplateDescriptor<TDocument>> configure) => configure.Invoke(this);

	public DynamicTemplateDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private DynamicTemplateDescriptor<TDocument> Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private DynamicTemplateDescriptor<TDocument> Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	private ICollection<string>? MatchValue { get; set; }
	private ICollection<string>? MatchMappingTypeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.MatchType? MatchPatternValue { get; set; }
	private ICollection<string>? PathMatchValue { get; set; }
	private ICollection<string>? PathUnmatchValue { get; set; }
	private ICollection<string>? UnmatchValue { get; set; }
	private ICollection<string>? UnmatchMappingTypeValue { get; set; }

	public DynamicTemplateDescriptor<TDocument> Match(ICollection<string>? match)
	{
		MatchValue = match;
		return Self;
	}

	public DynamicTemplateDescriptor<TDocument> MatchMappingType(ICollection<string>? matchMappingType)
	{
		MatchMappingTypeValue = matchMappingType;
		return Self;
	}

	public DynamicTemplateDescriptor<TDocument> MatchPattern(Elastic.Clients.Elasticsearch.Mapping.MatchType? matchPattern)
	{
		MatchPatternValue = matchPattern;
		return Self;
	}

	public DynamicTemplateDescriptor<TDocument> PathMatch(ICollection<string>? pathMatch)
	{
		PathMatchValue = pathMatch;
		return Self;
	}

	public DynamicTemplateDescriptor<TDocument> PathUnmatch(ICollection<string>? pathUnmatch)
	{
		PathUnmatchValue = pathUnmatch;
		return Self;
	}

	public DynamicTemplateDescriptor<TDocument> Unmatch(ICollection<string>? unmatch)
	{
		UnmatchValue = unmatch;
		return Self;
	}

	public DynamicTemplateDescriptor<TDocument> UnmatchMappingType(ICollection<string>? unmatchMappingType)
	{
		UnmatchMappingTypeValue = unmatchMappingType;
		return Self;
	}

	public DynamicTemplateDescriptor<TDocument> Mapping(Elastic.Clients.Elasticsearch.Mapping.IProperty property) => Set(property, "mapping");
	public DynamicTemplateDescriptor<TDocument> Runtime(Elastic.Clients.Elasticsearch.Mapping.IProperty property) => Set(property, "runtime");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (MatchValue is not null)
		{
			writer.WritePropertyName("match");
			SingleOrManySerializationHelper.Serialize<string>(MatchValue, writer, options);
		}

		if (MatchMappingTypeValue is not null)
		{
			writer.WritePropertyName("match_mapping_type");
			SingleOrManySerializationHelper.Serialize<string>(MatchMappingTypeValue, writer, options);
		}

		if (MatchPatternValue is not null)
		{
			writer.WritePropertyName("match_pattern");
			JsonSerializer.Serialize(writer, MatchPatternValue, options);
		}

		if (PathMatchValue is not null)
		{
			writer.WritePropertyName("path_match");
			SingleOrManySerializationHelper.Serialize<string>(PathMatchValue, writer, options);
		}

		if (PathUnmatchValue is not null)
		{
			writer.WritePropertyName("path_unmatch");
			SingleOrManySerializationHelper.Serialize<string>(PathUnmatchValue, writer, options);
		}

		if (UnmatchValue is not null)
		{
			writer.WritePropertyName("unmatch");
			SingleOrManySerializationHelper.Serialize<string>(UnmatchValue, writer, options);
		}

		if (UnmatchMappingTypeValue is not null)
		{
			writer.WritePropertyName("unmatch_mapping_type");
			SingleOrManySerializationHelper.Serialize<string>(UnmatchMappingTypeValue, writer, options);
		}

		if (!string.IsNullOrEmpty(ContainedVariantName))
		{
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
				writer.WriteEndObject();
				return;
			}

			JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class DynamicTemplateDescriptor : SerializableDescriptor<DynamicTemplateDescriptor>
{
	internal DynamicTemplateDescriptor(Action<DynamicTemplateDescriptor> configure) => configure.Invoke(this);

	public DynamicTemplateDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private DynamicTemplateDescriptor Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private DynamicTemplateDescriptor Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	private ICollection<string>? MatchValue { get; set; }
	private ICollection<string>? MatchMappingTypeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Mapping.MatchType? MatchPatternValue { get; set; }
	private ICollection<string>? PathMatchValue { get; set; }
	private ICollection<string>? PathUnmatchValue { get; set; }
	private ICollection<string>? UnmatchValue { get; set; }
	private ICollection<string>? UnmatchMappingTypeValue { get; set; }

	public DynamicTemplateDescriptor Match(ICollection<string>? match)
	{
		MatchValue = match;
		return Self;
	}

	public DynamicTemplateDescriptor MatchMappingType(ICollection<string>? matchMappingType)
	{
		MatchMappingTypeValue = matchMappingType;
		return Self;
	}

	public DynamicTemplateDescriptor MatchPattern(Elastic.Clients.Elasticsearch.Mapping.MatchType? matchPattern)
	{
		MatchPatternValue = matchPattern;
		return Self;
	}

	public DynamicTemplateDescriptor PathMatch(ICollection<string>? pathMatch)
	{
		PathMatchValue = pathMatch;
		return Self;
	}

	public DynamicTemplateDescriptor PathUnmatch(ICollection<string>? pathUnmatch)
	{
		PathUnmatchValue = pathUnmatch;
		return Self;
	}

	public DynamicTemplateDescriptor Unmatch(ICollection<string>? unmatch)
	{
		UnmatchValue = unmatch;
		return Self;
	}

	public DynamicTemplateDescriptor UnmatchMappingType(ICollection<string>? unmatchMappingType)
	{
		UnmatchMappingTypeValue = unmatchMappingType;
		return Self;
	}

	public DynamicTemplateDescriptor Mapping(Elastic.Clients.Elasticsearch.Mapping.IProperty property) => Set(property, "mapping");
	public DynamicTemplateDescriptor Runtime(Elastic.Clients.Elasticsearch.Mapping.IProperty property) => Set(property, "runtime");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (MatchValue is not null)
		{
			writer.WritePropertyName("match");
			SingleOrManySerializationHelper.Serialize<string>(MatchValue, writer, options);
		}

		if (MatchMappingTypeValue is not null)
		{
			writer.WritePropertyName("match_mapping_type");
			SingleOrManySerializationHelper.Serialize<string>(MatchMappingTypeValue, writer, options);
		}

		if (MatchPatternValue is not null)
		{
			writer.WritePropertyName("match_pattern");
			JsonSerializer.Serialize(writer, MatchPatternValue, options);
		}

		if (PathMatchValue is not null)
		{
			writer.WritePropertyName("path_match");
			SingleOrManySerializationHelper.Serialize<string>(PathMatchValue, writer, options);
		}

		if (PathUnmatchValue is not null)
		{
			writer.WritePropertyName("path_unmatch");
			SingleOrManySerializationHelper.Serialize<string>(PathUnmatchValue, writer, options);
		}

		if (UnmatchValue is not null)
		{
			writer.WritePropertyName("unmatch");
			SingleOrManySerializationHelper.Serialize<string>(UnmatchValue, writer, options);
		}

		if (UnmatchMappingTypeValue is not null)
		{
			writer.WritePropertyName("unmatch_mapping_type");
			SingleOrManySerializationHelper.Serialize<string>(UnmatchMappingTypeValue, writer, options);
		}

		if (!string.IsNullOrEmpty(ContainedVariantName))
		{
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
				writer.WriteEndObject();
				return;
			}

			JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		}

		writer.WriteEndObject();
	}
}