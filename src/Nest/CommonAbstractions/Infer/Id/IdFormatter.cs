﻿using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	internal class IdFormatter : IJsonFormatter<Id>
	{
		public Id Deserialize(ref JsonReader reader, IJsonFormatterResolver formatterResolver)
		{
			var token = reader.GetCurrentJsonToken();

			return token == JsonToken.Number
				? new Id(reader.ReadInt64())
				: new Id(reader.ReadString());
		}

		public void Serialize(ref JsonWriter writer, Id value, IJsonFormatterResolver formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}

			if (value.Document != null)
			{
				var settings = formatterResolver.GetConnectionSettings();
				var documentId = settings.Inferrer.Id(value.Document.GetType(), value.Document);
				writer.WriteString(documentId);
			}
			else if (value.LongValue != null)
				writer.WriteInt64(value.LongValue.Value);
			else
				writer.WriteString(value.StringValue);
		}
	}

	internal class IdStringFormatter : IJsonFormatter<string>
	{
		public string Deserialize(ref JsonReader reader, IJsonFormatterResolver formatterResolver)
		{
			var token = reader.GetCurrentJsonToken();

			return token == JsonToken.Number
				? reader.ReadInt64().ToString()
				: reader.ReadString();
		}

		public void Serialize(ref JsonWriter writer, string value, IJsonFormatterResolver formatterResolver) =>
			writer.WriteString(value);
	}
}
