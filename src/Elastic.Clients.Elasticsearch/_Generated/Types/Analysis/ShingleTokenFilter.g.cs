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
namespace Elastic.Clients.Elasticsearch.Analysis;
public sealed partial class ShingleTokenFilter : ITokenFilter
{
	[JsonInclude, JsonPropertyName("filler_token")]
	public string? FillerToken { get; set; }

	[JsonInclude, JsonPropertyName("max_shingle_size")]
	public Union<int?, string?>? MaxShingleSize { get; set; }

	[JsonInclude, JsonPropertyName("min_shingle_size")]
	public Union<int?, string?>? MinShingleSize { get; set; }

	[JsonInclude, JsonPropertyName("output_unigrams")]
	public bool? OutputUnigrams { get; set; }

	[JsonInclude, JsonPropertyName("output_unigrams_if_no_shingles")]
	public bool? OutputUnigramsIfNoShingles { get; set; }

	[JsonInclude, JsonPropertyName("token_separator")]
	public string? TokenSeparator { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "shingle";
	[JsonInclude, JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class ShingleTokenFilterDescriptor : SerializableDescriptor<ShingleTokenFilterDescriptor>, IBuildableDescriptor<ShingleTokenFilter>
{
	internal ShingleTokenFilterDescriptor(Action<ShingleTokenFilterDescriptor> configure) => configure.Invoke(this);
	public ShingleTokenFilterDescriptor() : base()
	{
	}

	private string? FillerTokenValue { get; set; }

	private Union<int?, string?>? MaxShingleSizeValue { get; set; }

	private Union<int?, string?>? MinShingleSizeValue { get; set; }

	private bool? OutputUnigramsValue { get; set; }

	private bool? OutputUnigramsIfNoShinglesValue { get; set; }

	private string? TokenSeparatorValue { get; set; }

	private string? VersionValue { get; set; }

	public ShingleTokenFilterDescriptor FillerToken(string? fillerToken)
	{
		FillerTokenValue = fillerToken;
		return Self;
	}

	public ShingleTokenFilterDescriptor MaxShingleSize(Union<int?, string?>? maxShingleSize)
	{
		MaxShingleSizeValue = maxShingleSize;
		return Self;
	}

	public ShingleTokenFilterDescriptor MinShingleSize(Union<int?, string?>? minShingleSize)
	{
		MinShingleSizeValue = minShingleSize;
		return Self;
	}

	public ShingleTokenFilterDescriptor OutputUnigrams(bool? outputUnigrams = true)
	{
		OutputUnigramsValue = outputUnigrams;
		return Self;
	}

	public ShingleTokenFilterDescriptor OutputUnigramsIfNoShingles(bool? outputUnigramsIfNoShingles = true)
	{
		OutputUnigramsIfNoShinglesValue = outputUnigramsIfNoShingles;
		return Self;
	}

	public ShingleTokenFilterDescriptor TokenSeparator(string? tokenSeparator)
	{
		TokenSeparatorValue = tokenSeparator;
		return Self;
	}

	public ShingleTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(FillerTokenValue))
		{
			writer.WritePropertyName("filler_token");
			writer.WriteStringValue(FillerTokenValue);
		}

		if (MaxShingleSizeValue is not null)
		{
			writer.WritePropertyName("max_shingle_size");
			JsonSerializer.Serialize(writer, MaxShingleSizeValue, options);
		}

		if (MinShingleSizeValue is not null)
		{
			writer.WritePropertyName("min_shingle_size");
			JsonSerializer.Serialize(writer, MinShingleSizeValue, options);
		}

		if (OutputUnigramsValue.HasValue)
		{
			writer.WritePropertyName("output_unigrams");
			writer.WriteBooleanValue(OutputUnigramsValue.Value);
		}

		if (OutputUnigramsIfNoShinglesValue.HasValue)
		{
			writer.WritePropertyName("output_unigrams_if_no_shingles");
			writer.WriteBooleanValue(OutputUnigramsIfNoShinglesValue.Value);
		}

		if (!string.IsNullOrEmpty(TokenSeparatorValue))
		{
			writer.WritePropertyName("token_separator");
			writer.WriteStringValue(TokenSeparatorValue);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("shingle");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	ShingleTokenFilter IBuildableDescriptor<ShingleTokenFilter>.Build() => new()
	{ FillerToken = FillerTokenValue, MaxShingleSize = MaxShingleSizeValue, MinShingleSize = MinShingleSizeValue, OutputUnigrams = OutputUnigramsValue, OutputUnigramsIfNoShingles = OutputUnigramsIfNoShinglesValue, TokenSeparator = TokenSeparatorValue, Version = VersionValue };
}