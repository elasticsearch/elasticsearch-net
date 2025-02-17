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

namespace Elastic.Clients.Elasticsearch.Watcher;

[JsonConverter(typeof(ActionStatusOptionsConverter))]
public enum ActionStatusOptions
{
	[EnumMember(Value = "throttled")]
	Throttled,
	[EnumMember(Value = "success")]
	Success,
	[EnumMember(Value = "simulated")]
	Simulated,
	[EnumMember(Value = "failure")]
	Failure
}

internal sealed partial class ActionStatusOptionsConverter : System.Text.Json.Serialization.JsonConverter<ActionStatusOptions>
{
	private static readonly System.Text.Json.JsonEncodedText MemberThrottled = System.Text.Json.JsonEncodedText.Encode("throttled");
	private static readonly System.Text.Json.JsonEncodedText MemberSuccess = System.Text.Json.JsonEncodedText.Encode("success");
	private static readonly System.Text.Json.JsonEncodedText MemberSimulated = System.Text.Json.JsonEncodedText.Encode("simulated");
	private static readonly System.Text.Json.JsonEncodedText MemberFailure = System.Text.Json.JsonEncodedText.Encode("failure");

	public override ActionStatusOptions Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
	{
		reader.ValidateToken(System.Text.Json.JsonTokenType.String);
		if (reader.ValueTextEquals(MemberThrottled))
		{
			return ActionStatusOptions.Throttled;
		}

		if (reader.ValueTextEquals(MemberSuccess))
		{
			return ActionStatusOptions.Success;
		}

		if (reader.ValueTextEquals(MemberSimulated))
		{
			return ActionStatusOptions.Simulated;
		}

		if (reader.ValueTextEquals(MemberFailure))
		{
			return ActionStatusOptions.Failure;
		}

		var value = reader.GetString()!;
		if (string.Equals(value, MemberThrottled.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return ActionStatusOptions.Throttled;
		}

		if (string.Equals(value, MemberSuccess.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return ActionStatusOptions.Success;
		}

		if (string.Equals(value, MemberSimulated.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return ActionStatusOptions.Simulated;
		}

		if (string.Equals(value, MemberFailure.Value, System.StringComparison.OrdinalIgnoreCase))
		{
			return ActionStatusOptions.Failure;
		}

		throw new System.Text.Json.JsonException($"Unknown member '{value}' for enum '{nameof(ActionStatusOptions)}'.");
	}

	public override void Write(System.Text.Json.Utf8JsonWriter writer, ActionStatusOptions value, System.Text.Json.JsonSerializerOptions options)
	{
		switch (value)
		{
			case ActionStatusOptions.Throttled:
				writer.WriteStringValue(MemberThrottled);
				break;
			case ActionStatusOptions.Success:
				writer.WriteStringValue(MemberSuccess);
				break;
			case ActionStatusOptions.Simulated:
				writer.WriteStringValue(MemberSimulated);
				break;
			case ActionStatusOptions.Failure:
				writer.WriteStringValue(MemberFailure);
				break;
			default:
				throw new System.Text.Json.JsonException($"Invalid value '{value}' for enum '{nameof(ActionStatusOptions)}'.");
		}
	}
}