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
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Ingest;

public sealed partial class GeoIpProcessor
{
	/// <summary>
	/// <para>The database filename referring to a database the module ships with (GeoLite2-City.mmdb, GeoLite2-Country.mmdb, or GeoLite2-ASN.mmdb) or a custom database in the ingest-geoip config directory.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("database_file")]
	public string? DatabaseFile { get; set; }

	/// <summary>
	/// <para>Description of the processor.<br/>Useful for describing the purpose of the processor or its configuration.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// <para>The field to get the ip address from for the geographical lookup.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	/// <summary>
	/// <para>If `true`, only the first found geoip data will be returned, even if the field contains an array.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("first_only")]
	public bool? FirstOnly { get; set; }

	/// <summary>
	/// <para>Conditionally execute the processor.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("if")]
	public string? If { get; set; }

	/// <summary>
	/// <para>Ignore failures for the processor.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ignore_failure")]
	public bool? IgnoreFailure { get; set; }

	/// <summary>
	/// <para>If `true` and `field` does not exist, the processor quietly exits without modifying the document.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ignore_missing")]
	public bool? IgnoreMissing { get; set; }

	/// <summary>
	/// <para>Handle failures for the processor.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("on_failure")]
	public ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailure { get; set; }

	/// <summary>
	/// <para>Controls what properties are added to the `target_field` based on the geoip lookup.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("properties")]
	public ICollection<string>? Properties { get; set; }

	/// <summary>
	/// <para>Identifier for the processor.<br/>Useful for debugging and metrics.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tag")]
	public string? Tag { get; set; }

	/// <summary>
	/// <para>The field that will hold the geographical information looked up from the MaxMind database.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("target_field")]
	public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Ingest.Processor(GeoIpProcessor geoIpProcessor) => Elastic.Clients.Elasticsearch.Ingest.Processor.Geoip(geoIpProcessor);
}

public sealed partial class GeoIpProcessorDescriptor<TDocument> : SerializableDescriptor<GeoIpProcessorDescriptor<TDocument>>
{
	internal GeoIpProcessorDescriptor(Action<GeoIpProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GeoIpProcessorDescriptor() : base()
	{
	}

	private string? DatabaseFileValue { get; set; }
	private string? DescriptionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private bool? FirstOnlyValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private bool? IgnoreMissingValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument> OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }
	private ICollection<string>? PropertiesValue { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? TargetFieldValue { get; set; }

	/// <summary>
	/// <para>The database filename referring to a database the module ships with (GeoLite2-City.mmdb, GeoLite2-Country.mmdb, or GeoLite2-ASN.mmdb) or a custom database in the ingest-geoip config directory.</para>
	/// </summary>
	public GeoIpProcessorDescriptor<TDocument> DatabaseFile(string? databaseFile)
	{
		DatabaseFileValue = databaseFile;
		return Self;
	}

	/// <summary>
	/// <para>Description of the processor.<br/>Useful for describing the purpose of the processor or its configuration.</para>
	/// </summary>
	public GeoIpProcessorDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>The field to get the ip address from for the geographical lookup.</para>
	/// </summary>
	public GeoIpProcessorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to get the ip address from for the geographical lookup.</para>
	/// </summary>
	public GeoIpProcessorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to get the ip address from for the geographical lookup.</para>
	/// </summary>
	public GeoIpProcessorDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, only the first found geoip data will be returned, even if the field contains an array.</para>
	/// </summary>
	public GeoIpProcessorDescriptor<TDocument> FirstOnly(bool? firstOnly = true)
	{
		FirstOnlyValue = firstOnly;
		return Self;
	}

	/// <summary>
	/// <para>Conditionally execute the processor.</para>
	/// </summary>
	public GeoIpProcessorDescriptor<TDocument> If(string? value)
	{
		IfValue = value;
		return Self;
	}

	/// <summary>
	/// <para>Ignore failures for the processor.</para>
	/// </summary>
	public GeoIpProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>If `true` and `field` does not exist, the processor quietly exits without modifying the document.</para>
	/// </summary>
	public GeoIpProcessorDescriptor<TDocument> IgnoreMissing(bool? ignoreMissing = true)
	{
		IgnoreMissingValue = ignoreMissing;
		return Self;
	}

	/// <summary>
	/// <para>Handle failures for the processor.</para>
	/// </summary>
	public GeoIpProcessorDescriptor<TDocument> OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public GeoIpProcessorDescriptor<TDocument> OnFailure(Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument> descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public GeoIpProcessorDescriptor<TDocument> OnFailure(Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public GeoIpProcessorDescriptor<TDocument> OnFailure(params Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Controls what properties are added to the `target_field` based on the geoip lookup.</para>
	/// </summary>
	public GeoIpProcessorDescriptor<TDocument> Properties(ICollection<string>? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	/// <summary>
	/// <para>Identifier for the processor.<br/>Useful for debugging and metrics.</para>
	/// </summary>
	public GeoIpProcessorDescriptor<TDocument> Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>The field that will hold the geographical information looked up from the MaxMind database.</para>
	/// </summary>
	public GeoIpProcessorDescriptor<TDocument> TargetField(Elastic.Clients.Elasticsearch.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field that will hold the geographical information looked up from the MaxMind database.</para>
	/// </summary>
	public GeoIpProcessorDescriptor<TDocument> TargetField<TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field that will hold the geographical information looked up from the MaxMind database.</para>
	/// </summary>
	public GeoIpProcessorDescriptor<TDocument> TargetField(Expression<Func<TDocument, object>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(DatabaseFileValue))
		{
			writer.WritePropertyName("database_file");
			writer.WriteStringValue(DatabaseFileValue);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (FirstOnlyValue.HasValue)
		{
			writer.WritePropertyName("first_only");
			writer.WriteBooleanValue(FirstOnlyValue.Value);
		}

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

		if (IgnoreMissingValue.HasValue)
		{
			writer.WritePropertyName("ignore_missing");
			writer.WriteBooleanValue(IgnoreMissingValue.Value);
		}

		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (PropertiesValue is not null)
		{
			writer.WritePropertyName("properties");
			JsonSerializer.Serialize(writer, PropertiesValue, options);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		if (TargetFieldValue is not null)
		{
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class GeoIpProcessorDescriptor : SerializableDescriptor<GeoIpProcessorDescriptor>
{
	internal GeoIpProcessorDescriptor(Action<GeoIpProcessorDescriptor> configure) => configure.Invoke(this);

	public GeoIpProcessorDescriptor() : base()
	{
	}

	private string? DatabaseFileValue { get; set; }
	private string? DescriptionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private bool? FirstOnlyValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private bool? IgnoreMissingValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor>[] OnFailureDescriptorActions { get; set; }
	private ICollection<string>? PropertiesValue { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? TargetFieldValue { get; set; }

	/// <summary>
	/// <para>The database filename referring to a database the module ships with (GeoLite2-City.mmdb, GeoLite2-Country.mmdb, or GeoLite2-ASN.mmdb) or a custom database in the ingest-geoip config directory.</para>
	/// </summary>
	public GeoIpProcessorDescriptor DatabaseFile(string? databaseFile)
	{
		DatabaseFileValue = databaseFile;
		return Self;
	}

	/// <summary>
	/// <para>Description of the processor.<br/>Useful for describing the purpose of the processor or its configuration.</para>
	/// </summary>
	public GeoIpProcessorDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>The field to get the ip address from for the geographical lookup.</para>
	/// </summary>
	public GeoIpProcessorDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to get the ip address from for the geographical lookup.</para>
	/// </summary>
	public GeoIpProcessorDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to get the ip address from for the geographical lookup.</para>
	/// </summary>
	public GeoIpProcessorDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, only the first found geoip data will be returned, even if the field contains an array.</para>
	/// </summary>
	public GeoIpProcessorDescriptor FirstOnly(bool? firstOnly = true)
	{
		FirstOnlyValue = firstOnly;
		return Self;
	}

	/// <summary>
	/// <para>Conditionally execute the processor.</para>
	/// </summary>
	public GeoIpProcessorDescriptor If(string? value)
	{
		IfValue = value;
		return Self;
	}

	/// <summary>
	/// <para>Ignore failures for the processor.</para>
	/// </summary>
	public GeoIpProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>If `true` and `field` does not exist, the processor quietly exits without modifying the document.</para>
	/// </summary>
	public GeoIpProcessorDescriptor IgnoreMissing(bool? ignoreMissing = true)
	{
		IgnoreMissingValue = ignoreMissing;
		return Self;
	}

	/// <summary>
	/// <para>Handle failures for the processor.</para>
	/// </summary>
	public GeoIpProcessorDescriptor OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public GeoIpProcessorDescriptor OnFailure(Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public GeoIpProcessorDescriptor OnFailure(Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public GeoIpProcessorDescriptor OnFailure(params Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Controls what properties are added to the `target_field` based on the geoip lookup.</para>
	/// </summary>
	public GeoIpProcessorDescriptor Properties(ICollection<string>? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	/// <summary>
	/// <para>Identifier for the processor.<br/>Useful for debugging and metrics.</para>
	/// </summary>
	public GeoIpProcessorDescriptor Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>The field that will hold the geographical information looked up from the MaxMind database.</para>
	/// </summary>
	public GeoIpProcessorDescriptor TargetField(Elastic.Clients.Elasticsearch.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field that will hold the geographical information looked up from the MaxMind database.</para>
	/// </summary>
	public GeoIpProcessorDescriptor TargetField<TDocument, TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field that will hold the geographical information looked up from the MaxMind database.</para>
	/// </summary>
	public GeoIpProcessorDescriptor TargetField<TDocument>(Expression<Func<TDocument, object>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(DatabaseFileValue))
		{
			writer.WritePropertyName("database_file");
			writer.WriteStringValue(DatabaseFileValue);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (FirstOnlyValue.HasValue)
		{
			writer.WritePropertyName("first_only");
			writer.WriteBooleanValue(FirstOnlyValue.Value);
		}

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

		if (IgnoreMissingValue.HasValue)
		{
			writer.WritePropertyName("ignore_missing");
			writer.WriteBooleanValue(IgnoreMissingValue.Value);
		}

		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (PropertiesValue is not null)
		{
			writer.WritePropertyName("properties");
			JsonSerializer.Serialize(writer, PropertiesValue, options);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		if (TargetFieldValue is not null)
		{
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
		}

		writer.WriteEndObject();
	}
}