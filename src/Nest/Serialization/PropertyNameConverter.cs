using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nest.Core;

namespace Nest
{
	public class PropertyNameConverter : JsonConverter<PropertyName>
	{
		public override PropertyName?
			Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
			throw new NotImplementedException();

		public override void Write(Utf8JsonWriter writer, PropertyName? value, JsonSerializerOptions options)
		{
			if (value is null)
			{
				writer.WriteNullValue();
				return;
			}

			writer.WriteStringValue(value.Name);
		}
	}
}
