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

namespace Elastic.Clients.Elasticsearch.Security;

[JsonConverter(typeof(FieldRuleConverter))]
public sealed partial class FieldRule
{
	internal FieldRule(string variantName, object variant)
	{
		if (variantName is null)
			throw new ArgumentNullException(nameof(variantName));
		if (variant is null)
			throw new ArgumentNullException(nameof(variant));
		if (string.IsNullOrWhiteSpace(variantName))
			throw new ArgumentException("Variant name must not be empty or whitespace.");
		VariantType = variantName;
		Variant = variant;
	}

	internal FieldRule()
	{
	}

	public object Variant { get; internal set; }
	public string VariantType { get; internal set; }

	public static FieldRule Dn(Elastic.Clients.Elasticsearch.Names names) => new FieldRule("dn", names);
	public static FieldRule Groups(Elastic.Clients.Elasticsearch.Names names) => new FieldRule("groups", names);
	public static FieldRule Username(Elastic.Clients.Elasticsearch.Names names) => new FieldRule("username", names);

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

internal sealed partial class FieldRuleConverter : System.Text.Json.Serialization.JsonConverter<FieldRule>
{
	private static readonly System.Text.Json.JsonEncodedText VariantDn = System.Text.Json.JsonEncodedText.Encode("dn");
	private static readonly System.Text.Json.JsonEncodedText VariantGroups = System.Text.Json.JsonEncodedText.Encode("groups");
	private static readonly System.Text.Json.JsonEncodedText VariantUsername = System.Text.Json.JsonEncodedText.Encode("username");

	public override FieldRule Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		var variantType = string.Empty;
		object? variant = null;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (reader.ValueTextEquals(VariantDn))
			{
				variantType = VariantDn.Value;
				reader.Read();
				variant = reader.ReadValue<Elastic.Clients.Elasticsearch.Names?>(options, null);
				continue;
			}

			if (reader.ValueTextEquals(VariantGroups))
			{
				variantType = VariantGroups.Value;
				reader.Read();
				variant = reader.ReadValue<Elastic.Clients.Elasticsearch.Names?>(options, null);
				continue;
			}

			if (reader.ValueTextEquals(VariantUsername))
			{
				variantType = VariantUsername.Value;
				reader.Read();
				variant = reader.ReadValue<Elastic.Clients.Elasticsearch.Names?>(options, null);
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new FieldRule { VariantType = variantType, Variant = variant };
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, FieldRule value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		switch (value.VariantType)
		{
			case "":
				break;
			case "dn":
				writer.WriteProperty(options, value.VariantType, (Elastic.Clients.Elasticsearch.Names?)value.Variant, null, null);
				break;
			case "groups":
				writer.WriteProperty(options, value.VariantType, (Elastic.Clients.Elasticsearch.Names?)value.Variant, null, null);
				break;
			case "username":
				writer.WriteProperty(options, value.VariantType, (Elastic.Clients.Elasticsearch.Names?)value.Variant, null, null);
				break;
			default:
				throw new System.Text.Json.JsonException($"Variant '{value.VariantType}' is not supported for type '{nameof(FieldRule)}'.");
		}

		writer.WriteEndObject();
	}
}

public sealed partial class FieldRuleDescriptor<TDocument> : SerializableDescriptor<FieldRuleDescriptor<TDocument>>
{
	internal FieldRuleDescriptor(Action<FieldRuleDescriptor<TDocument>> configure) => configure.Invoke(this);

	public FieldRuleDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private FieldRuleDescriptor<TDocument> Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private FieldRuleDescriptor<TDocument> Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public FieldRuleDescriptor<TDocument> Dn(Elastic.Clients.Elasticsearch.Names names) => Set(names, "dn");
	public FieldRuleDescriptor<TDocument> Groups(Elastic.Clients.Elasticsearch.Names names) => Set(names, "groups");
	public FieldRuleDescriptor<TDocument> Username(Elastic.Clients.Elasticsearch.Names names) => Set(names, "username");

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

public sealed partial class FieldRuleDescriptor : SerializableDescriptor<FieldRuleDescriptor>
{
	internal FieldRuleDescriptor(Action<FieldRuleDescriptor> configure) => configure.Invoke(this);

	public FieldRuleDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private FieldRuleDescriptor Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private FieldRuleDescriptor Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public FieldRuleDescriptor Dn(Elastic.Clients.Elasticsearch.Names names) => Set(names, "dn");
	public FieldRuleDescriptor Groups(Elastic.Clients.Elasticsearch.Names names) => Set(names, "groups");
	public FieldRuleDescriptor Username(Elastic.Clients.Elasticsearch.Names names) => Set(names, "username");

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