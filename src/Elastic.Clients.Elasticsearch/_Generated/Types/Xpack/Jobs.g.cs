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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Xpack
{
	internal sealed class JobsConverter : JsonConverter<Jobs>
	{
		public override Jobs Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			var variant = new Jobs();
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					var property = reader.GetString();
					if (property == "_all")
					{
						variant.All = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Xpack.AllJobs?>(ref reader, options);
						continue;
					}
				}
			}

			reader.Read();
			return variant;
		}

		public override void Write(Utf8JsonWriter writer, Jobs value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (value.All is not null)
			{
				writer.WritePropertyName("_all");
				JsonSerializer.Serialize(writer, value.All, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(JobsConverter))]
	public partial class Jobs
	{
		public Elastic.Clients.Elasticsearch.Xpack.AllJobs? All { get; init; }

		public Dictionary<string, Elastic.Clients.Elasticsearch.Ml.Job> JobsDictionary { get; init; }
	}
}