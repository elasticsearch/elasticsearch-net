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

using Elastic.Clients.Elasticsearch.Core;
using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Core.Search;

/// <summary>
/// <para>
/// Defines how to fetch a source. Fetching can be disabled entirely, or the source can be filtered.
/// Used as a query parameter along with the <c>_source_includes</c> and <c>_source_excludes</c> parameters.
/// </para>
/// </summary>
[JsonConverter(typeof(SourceConfigParamConverter))]
public sealed partial class SourceConfigParam : Union<bool, Elastic.Clients.Elasticsearch.Fields>
{
	public SourceConfigParam(bool fetch) : base(fetch)
	{
	}

	public SourceConfigParam(Elastic.Clients.Elasticsearch.Fields fields) : base(fields)
	{
	}

	public static implicit operator SourceConfigParam(bool fetch) => new SourceConfigParam(fetch);
	public static implicit operator SourceConfigParam(Elastic.Clients.Elasticsearch.Fields fields) => new SourceConfigParam(fields);
}

internal sealed partial class SourceConfigParamConverter : System.Text.Json.Serialization.JsonConverter<SourceConfigParam>
{
	public override SourceConfigParam Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		var selector = static (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => JsonUnionSelector.ByTokenType(ref r, o, Elastic.Clients.Elasticsearch.Serialization.JsonTokenTypes.True | Elastic.Clients.Elasticsearch.Serialization.JsonTokenTypes.False, Elastic.Clients.Elasticsearch.Serialization.JsonTokenTypes.String | Elastic.Clients.Elasticsearch.Serialization.JsonTokenTypes.StartArray);
		return selector(ref reader, options) switch
		{
			Elastic.Clients.Elasticsearch.UnionTag.T1 => new SourceConfigParam(reader.ReadValue<bool>(options, null)),
			Elastic.Clients.Elasticsearch.UnionTag.T2 => new SourceConfigParam(reader.ReadValue<Elastic.Clients.Elasticsearch.Fields>(options, static Elastic.Clients.Elasticsearch.Fields (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => r.ReadValueEx<Elastic.Clients.Elasticsearch.Fields>(o, typeof(SingleOrManyFieldsMarker))!)),
			_ => throw new System.InvalidOperationException($"Failed to select a union variant for type '{nameof(SourceConfigParam)}")
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, SourceConfigParam value, System.Text.Json.JsonSerializerOptions options)
	{
		switch (value.Tag)
		{
			case Elastic.Clients.Elasticsearch.UnionTag.T1:
				{
					writer.WriteValue(options, value.Value1, null);
					break;
				}

			case Elastic.Clients.Elasticsearch.UnionTag.T2:
				{
					writer.WriteValue(options, value.Value2, static (System.Text.Json.Utf8JsonWriter w, System.Text.Json.JsonSerializerOptions o, Elastic.Clients.Elasticsearch.Fields v) => w.WriteValueEx<Elastic.Clients.Elasticsearch.Fields>(o, v, typeof(SingleOrManyFieldsMarker)));
					break;
				}

			default:
				throw new System.InvalidOperationException($"Unrecognized tag value: {value.Tag}");
		}
	}
}