// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch;

// TODO : We need to handle these cases https://github.com/elastic/elasticsearch-specification/pull/1589

internal sealed class IsADictionaryConverter : JsonConverterFactory
{
	public override bool CanConvert(Type typeToConvert) =>
		typeToConvert.BaseType is not null &&
		typeToConvert.BaseType.IsGenericType &&
		typeToConvert.BaseType.GetGenericTypeDefinition() == typeof(IsADictionaryBase<,>);

	public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
	{
		var args = typeToConvert.BaseType.GetGenericArguments();

		var keyType = args[0];
		var valueType = args[1];

		if (keyType.IsClass)
		{
			return (JsonConverter)Activator.CreateInstance(
				typeof(IsADictionaryConverterInner<,,>).MakeGenericType(typeToConvert, keyType, valueType));
		}

		return null;
	}

	private class IsADictionaryConverterInner<TType, TKey, TValue> : JsonConverter<TType>
		where TKey : class
		where TType : IsADictionaryBase<TKey, TValue>, new()
	{
		public override TType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var dictionary = JsonSerializer.Deserialize<Dictionary<TKey, TValue>>(ref reader, options);

			if (dictionary is null)
				return null;

			return (TType)Activator.CreateInstance(typeof(TType), new object[] { dictionary });
		}

		public override void Write(Utf8JsonWriter writer, TType value, JsonSerializerOptions options) =>
			JsonSerializer.Serialize<Dictionary<TKey, TValue>>(writer, value.BackingDictionary, options);
	}
}

