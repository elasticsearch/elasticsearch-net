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

namespace Elastic.Clients.Elasticsearch.TransformManagement;

public sealed partial class TimeRetentionPolicy
{
	/// <summary>
	/// <para>The date field that is used to calculate the age of the document.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	/// <summary>
	/// <para>Specifies the maximum age of a document in the destination index. Documents that are older than the configured<br/>value are removed from the destination index.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("max_age")]
	public Elastic.Clients.Elasticsearch.Duration MaxAge { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.TransformManagement.RetentionPolicy(TimeRetentionPolicy timeRetentionPolicy) => Elastic.Clients.Elasticsearch.TransformManagement.RetentionPolicy.Time(timeRetentionPolicy);
}

public sealed partial class TimeRetentionPolicyDescriptor<TDocument> : SerializableDescriptor<TimeRetentionPolicyDescriptor<TDocument>>
{
	internal TimeRetentionPolicyDescriptor(Action<TimeRetentionPolicyDescriptor<TDocument>> configure) => configure.Invoke(this);

	public TimeRetentionPolicyDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Duration MaxAgeValue { get; set; }

	/// <summary>
	/// <para>The date field that is used to calculate the age of the document.</para>
	/// </summary>
	public TimeRetentionPolicyDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The date field that is used to calculate the age of the document.</para>
	/// </summary>
	public TimeRetentionPolicyDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The date field that is used to calculate the age of the document.</para>
	/// </summary>
	public TimeRetentionPolicyDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the maximum age of a document in the destination index. Documents that are older than the configured<br/>value are removed from the destination index.</para>
	/// </summary>
	public TimeRetentionPolicyDescriptor<TDocument> MaxAge(Elastic.Clients.Elasticsearch.Duration maxAge)
	{
		MaxAgeValue = maxAge;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		writer.WritePropertyName("max_age");
		JsonSerializer.Serialize(writer, MaxAgeValue, options);
		writer.WriteEndObject();
	}
}

public sealed partial class TimeRetentionPolicyDescriptor : SerializableDescriptor<TimeRetentionPolicyDescriptor>
{
	internal TimeRetentionPolicyDescriptor(Action<TimeRetentionPolicyDescriptor> configure) => configure.Invoke(this);

	public TimeRetentionPolicyDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Duration MaxAgeValue { get; set; }

	/// <summary>
	/// <para>The date field that is used to calculate the age of the document.</para>
	/// </summary>
	public TimeRetentionPolicyDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The date field that is used to calculate the age of the document.</para>
	/// </summary>
	public TimeRetentionPolicyDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The date field that is used to calculate the age of the document.</para>
	/// </summary>
	public TimeRetentionPolicyDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the maximum age of a document in the destination index. Documents that are older than the configured<br/>value are removed from the destination index.</para>
	/// </summary>
	public TimeRetentionPolicyDescriptor MaxAge(Elastic.Clients.Elasticsearch.Duration maxAge)
	{
		MaxAgeValue = maxAge;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		writer.WritePropertyName("max_age");
		JsonSerializer.Serialize(writer, MaxAgeValue, options);
		writer.WriteEndObject();
	}
}