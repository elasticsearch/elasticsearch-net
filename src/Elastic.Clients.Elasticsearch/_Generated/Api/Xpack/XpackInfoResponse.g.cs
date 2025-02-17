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
using Elastic.Transport.Products.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Xpack;

internal sealed partial class XpackInfoResponseConverter : System.Text.Json.Serialization.JsonConverter<XpackInfoResponse>
{
	private static readonly System.Text.Json.JsonEncodedText PropBuild = System.Text.Json.JsonEncodedText.Encode("build");
	private static readonly System.Text.Json.JsonEncodedText PropFeatures = System.Text.Json.JsonEncodedText.Encode("features");
	private static readonly System.Text.Json.JsonEncodedText PropLicense = System.Text.Json.JsonEncodedText.Encode("license");
	private static readonly System.Text.Json.JsonEncodedText PropTagline = System.Text.Json.JsonEncodedText.Encode("tagline");

	public override XpackInfoResponse Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.StartObject);
		LocalJsonValue<Elastic.Clients.Elasticsearch.Xpack.BuildInformation> propBuild = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.Xpack.Features> propFeatures = default;
		LocalJsonValue<Elastic.Clients.Elasticsearch.Xpack.MinimalLicenseInformation> propLicense = default;
		LocalJsonValue<string> propTagline = default;
		while (reader.Read() && reader.TokenType is System.Text.Json.JsonTokenType.PropertyName)
		{
			if (propBuild.TryReadProperty(ref reader, options, PropBuild, null))
			{
				continue;
			}

			if (propFeatures.TryReadProperty(ref reader, options, PropFeatures, null))
			{
				continue;
			}

			if (propLicense.TryReadProperty(ref reader, options, PropLicense, null))
			{
				continue;
			}

			if (propTagline.TryReadProperty(ref reader, options, PropTagline, null))
			{
				continue;
			}

			throw new System.Text.Json.JsonException($"Unknown JSON property '{reader.GetString()}' for type '{typeToConvert.Name}'.");
		}

		reader.ValidateToken(System.Text.Json.JsonTokenType.EndObject);
		return new XpackInfoResponse
		{
			Build = propBuild.Value
,
			Features = propFeatures.Value
,
			License = propLicense.Value
,
			Tagline = propTagline.Value
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, XpackInfoResponse value, System.Text.Json.JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WriteProperty(options, PropBuild, value.Build, null, null);
		writer.WriteProperty(options, PropFeatures, value.Features, null, null);
		writer.WriteProperty(options, PropLicense, value.License, null, null);
		writer.WriteProperty(options, PropTagline, value.Tagline, null, null);
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(XpackInfoResponseConverter))]
public sealed partial class XpackInfoResponse : ElasticsearchResponse
{
	public Elastic.Clients.Elasticsearch.Xpack.BuildInformation Build { get; init; }
	public Elastic.Clients.Elasticsearch.Xpack.Features Features { get; init; }
	public Elastic.Clients.Elasticsearch.Xpack.MinimalLicenseInformation License { get; init; }
	public string Tagline { get; init; }
}