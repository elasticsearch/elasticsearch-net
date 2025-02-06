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
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.CrossClusterReplication;

[JsonConverter(typeof(FollowerIndexStatusConverter))]
public enum FollowerIndexStatus
{
	[EnumMember(Value = "paused")]
	Paused,
	[EnumMember(Value = "active")]
	Active
}

internal sealed partial class FollowerIndexStatusConverter : System.Text.Json.Serialization.JsonConverter<FollowerIndexStatus>
{
	private static readonly System.Text.Json.JsonEncodedText MemberPaused = System.Text.Json.JsonEncodedText.Encode("paused");
	private static readonly System.Text.Json.JsonEncodedText MemberActive = System.Text.Json.JsonEncodedText.Encode("active");

	public override FollowerIndexStatus Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.String);
		if (reader.ValueTextEquals(MemberPaused))
		{
			return FollowerIndexStatus.Paused;
		}

		if (reader.ValueTextEquals(MemberActive))
		{
			return FollowerIndexStatus.Active;
		}

		var value = reader.GetString()!;
		if (string.Equals(value, MemberPaused.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return FollowerIndexStatus.Paused;
		}

		if (string.Equals(value, MemberActive.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return FollowerIndexStatus.Active;
		}

		throw new System.Text.Json.JsonException($"Unknown member '{value}' for enum '{nameof(FollowerIndexStatus)}'.");
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, FollowerIndexStatus value, System.Text.Json.JsonSerializerOptions options)
	{
		switch (value)
		{
			case FollowerIndexStatus.Paused:
				writer.WriteStringValue(MemberPaused);
				break;
			case FollowerIndexStatus.Active:
				writer.WriteStringValue(MemberActive);
				break;
			default:
				throw new System.Text.Json.JsonException($"Invalid value '{value}' for enum '{nameof(FollowerIndexStatus)}'.");
		}
	}
}