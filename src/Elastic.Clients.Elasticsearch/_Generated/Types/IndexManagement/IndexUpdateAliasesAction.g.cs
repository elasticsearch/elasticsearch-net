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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

[JsonConverter(typeof(IndexUpdateAliasesActionConverter))]
public sealed partial class IndexUpdateAliasesAction
{
	internal IndexUpdateAliasesAction(string variantName, object variant)
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

	public static IndexUpdateAliasesAction Add(Elastic.Clients.Elasticsearch.IndexManagement.AddAction addAction) => new IndexUpdateAliasesAction("add", addAction);
	public static IndexUpdateAliasesAction Remove(Elastic.Clients.Elasticsearch.IndexManagement.RemoveAction removeAction) => new IndexUpdateAliasesAction("remove", removeAction);
	public static IndexUpdateAliasesAction RemoveIndex(Elastic.Clients.Elasticsearch.IndexManagement.RemoveIndexAction removeIndexAction) => new IndexUpdateAliasesAction("remove_index", removeIndexAction);

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

internal sealed partial class IndexUpdateAliasesActionConverter : JsonConverter<IndexUpdateAliasesAction>
{
	public override IndexUpdateAliasesAction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException("Expected start token.");
		}

		object? variantValue = default;
		string? variantNameValue = default;
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
			if (propertyName == "add")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.IndexManagement.AddAction?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "remove")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.IndexManagement.RemoveAction?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "remove_index")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.IndexManagement.RemoveIndexAction?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			throw new JsonException($"Unknown property name '{propertyName}' received while deserializing the 'IndexUpdateAliasesAction' from the response.");
		}

		reader.Read();
		var result = new IndexUpdateAliasesAction(variantNameValue, variantValue);
		return result;
	}

	public override void Write(Utf8JsonWriter writer, IndexUpdateAliasesAction value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (value.VariantName is not null && value.Variant is not null)
		{
			writer.WritePropertyName(value.VariantName);
			switch (value.VariantName)
			{
				case "add":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.IndexManagement.AddAction>(writer, (Elastic.Clients.Elasticsearch.IndexManagement.AddAction)value.Variant, options);
					break;
				case "remove":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.IndexManagement.RemoveAction>(writer, (Elastic.Clients.Elasticsearch.IndexManagement.RemoveAction)value.Variant, options);
					break;
				case "remove_index":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.IndexManagement.RemoveIndexAction>(writer, (Elastic.Clients.Elasticsearch.IndexManagement.RemoveIndexAction)value.Variant, options);
					break;
			}
		}

		writer.WriteEndObject();
	}
}

public sealed partial class IndexUpdateAliasesActionDescriptor<TDocument> : SerializableDescriptor<IndexUpdateAliasesActionDescriptor<TDocument>>
{
	internal IndexUpdateAliasesActionDescriptor(Action<IndexUpdateAliasesActionDescriptor<TDocument>> configure) => configure.Invoke(this);

	public IndexUpdateAliasesActionDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private IndexUpdateAliasesActionDescriptor<TDocument> Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private IndexUpdateAliasesActionDescriptor<TDocument> Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public IndexUpdateAliasesActionDescriptor<TDocument> Add(Elastic.Clients.Elasticsearch.IndexManagement.AddAction addAction) => Set(addAction, "add");
	public IndexUpdateAliasesActionDescriptor<TDocument> Add(Action<Elastic.Clients.Elasticsearch.IndexManagement.AddActionDescriptor<TDocument>> configure) => Set(configure, "add");
	public IndexUpdateAliasesActionDescriptor<TDocument> Remove(Elastic.Clients.Elasticsearch.IndexManagement.RemoveAction removeAction) => Set(removeAction, "remove");
	public IndexUpdateAliasesActionDescriptor<TDocument> Remove(Action<Elastic.Clients.Elasticsearch.IndexManagement.RemoveActionDescriptor> configure) => Set(configure, "remove");
	public IndexUpdateAliasesActionDescriptor<TDocument> RemoveIndex(Elastic.Clients.Elasticsearch.IndexManagement.RemoveIndexAction removeIndexAction) => Set(removeIndexAction, "remove_index");
	public IndexUpdateAliasesActionDescriptor<TDocument> RemoveIndex(Action<Elastic.Clients.Elasticsearch.IndexManagement.RemoveIndexActionDescriptor> configure) => Set(configure, "remove_index");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
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

public sealed partial class IndexUpdateAliasesActionDescriptor : SerializableDescriptor<IndexUpdateAliasesActionDescriptor>
{
	internal IndexUpdateAliasesActionDescriptor(Action<IndexUpdateAliasesActionDescriptor> configure) => configure.Invoke(this);

	public IndexUpdateAliasesActionDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private IndexUpdateAliasesActionDescriptor Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private IndexUpdateAliasesActionDescriptor Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public IndexUpdateAliasesActionDescriptor Add(Elastic.Clients.Elasticsearch.IndexManagement.AddAction addAction) => Set(addAction, "add");
	public IndexUpdateAliasesActionDescriptor Add<TDocument>(Action<Elastic.Clients.Elasticsearch.IndexManagement.AddActionDescriptor> configure) => Set(configure, "add");
	public IndexUpdateAliasesActionDescriptor Remove(Elastic.Clients.Elasticsearch.IndexManagement.RemoveAction removeAction) => Set(removeAction, "remove");
	public IndexUpdateAliasesActionDescriptor Remove(Action<Elastic.Clients.Elasticsearch.IndexManagement.RemoveActionDescriptor> configure) => Set(configure, "remove");
	public IndexUpdateAliasesActionDescriptor RemoveIndex(Elastic.Clients.Elasticsearch.IndexManagement.RemoveIndexAction removeIndexAction) => Set(removeIndexAction, "remove_index");
	public IndexUpdateAliasesActionDescriptor RemoveIndex(Action<Elastic.Clients.Elasticsearch.IndexManagement.RemoveIndexActionDescriptor> configure) => Set(configure, "remove_index");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
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