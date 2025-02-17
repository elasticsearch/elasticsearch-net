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

namespace Elastic.Clients.Elasticsearch.Core.MGet;

[JsonConverter(typeof(MultiGetResponseItemConverterFactory))]
public sealed partial class MultiGetResponseItem<TDocument> : Union<Elastic.Clients.Elasticsearch.Core.Get.GetResult<TDocument>, Elastic.Clients.Elasticsearch.Core.MGet.MultiGetError>
{
	public MultiGetResponseItem(Elastic.Clients.Elasticsearch.Core.Get.GetResult<TDocument> result) : base(result)
	{
	}

	public MultiGetResponseItem(Elastic.Clients.Elasticsearch.Core.MGet.MultiGetError failure) : base(failure)
	{
	}

	public static implicit operator MultiGetResponseItem<TDocument>(Elastic.Clients.Elasticsearch.Core.Get.GetResult<TDocument> result) => new MultiGetResponseItem<TDocument>(result);
	public static implicit operator MultiGetResponseItem<TDocument>(Elastic.Clients.Elasticsearch.Core.MGet.MultiGetError failure) => new MultiGetResponseItem<TDocument>(failure);
}

internal sealed partial class MultiGetResponseItemConverter<TDocument> : System.Text.Json.Serialization.JsonConverter<MultiGetResponseItem<TDocument>>
{
	public override MultiGetResponseItem<TDocument> Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		var selector = static (ref System.Text.Json.Utf8JsonReader r, System.Text.Json.JsonSerializerOptions o) => JsonUnionSelector.ByPropertyOfT1(ref r, o, "found");
		return selector(ref reader, options) switch
		{
			Elastic.Clients.Elasticsearch.UnionTag.T1 => new MultiGetResponseItem<TDocument>(reader.ReadValue<Elastic.Clients.Elasticsearch.Core.Get.GetResult<TDocument>>(options, null)),
			Elastic.Clients.Elasticsearch.UnionTag.T2 => new MultiGetResponseItem<TDocument>(reader.ReadValue<Elastic.Clients.Elasticsearch.Core.MGet.MultiGetError>(options, null)),
			_ => throw new System.InvalidOperationException($"Failed to select a union variant for type '{nameof(MultiGetResponseItem<TDocument>)}")
		};
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, MultiGetResponseItem<TDocument> value, System.Text.Json.JsonSerializerOptions options)
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
					writer.WriteValue(options, value.Value2, null);
					break;
				}

			default:
				throw new System.InvalidOperationException($"Unrecognized tag value: {value.Tag}");
		}
	}
}

internal sealed partial class MultiGetResponseItemConverterFactory : System.Text.Json.Serialization.JsonConverterFactory
{
	public override bool CanConvert(System.Type typeToConvert)
	{
		return typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(MultiGetResponseItem<>);
	}

	public override System.Text.Json.Serialization.JsonConverter CreateConverter(System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		var args = typeToConvert.GetGenericArguments();
#pragma warning disable IL3050
		var converter = (System.Text.Json.Serialization.JsonConverter)System.Activator.CreateInstance(typeof(MultiGetResponseItemConverter<>).MakeGenericType(args[0]), System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public, binder: null, args: null, culture: null)!;
#pragma warning restore IL3050
		return converter;
	}
}