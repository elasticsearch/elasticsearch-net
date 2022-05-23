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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using Elastic.Transport;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	[JsonConverter(typeof(FeatureConverter))]
	public enum Feature
	{
		[EnumMember(Value = "settings")]
		Settings,
		[EnumMember(Value = "mappings")]
		Mappings,
		[EnumMember(Value = "aliases")]
		Aliases
	}

	internal sealed class FeatureConverter : JsonConverter<Feature>
	{
		public override Feature Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "settings":
					return Feature.Settings;
				case "mappings":
					return Feature.Mappings;
				case "aliases":
					return Feature.Aliases;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, Feature value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case Feature.Settings:
					writer.WriteStringValue("settings");
					return;
				case Feature.Mappings:
					writer.WriteStringValue("mappings");
					return;
				case Feature.Aliases:
					writer.WriteStringValue("aliases");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(IndexCheckOnStartupConverter))]
	public enum IndexCheckOnStartup
	{
		[EnumMember(Value = "true")]
		True,
		[EnumMember(Value = "false")]
		False,
		[EnumMember(Value = "checksum")]
		Checksum
	}

	internal sealed class IndexCheckOnStartupConverter : JsonConverter<IndexCheckOnStartup>
	{
		public override IndexCheckOnStartup Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "true":
					return IndexCheckOnStartup.True;
				case "false":
					return IndexCheckOnStartup.False;
				case "checksum":
					return IndexCheckOnStartup.Checksum;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, IndexCheckOnStartup value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case IndexCheckOnStartup.True:
					writer.WriteStringValue("true");
					return;
				case IndexCheckOnStartup.False:
					writer.WriteStringValue("false");
					return;
				case IndexCheckOnStartup.Checksum:
					writer.WriteStringValue("checksum");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(IndexMetadataStateConverter))]
	public enum IndexMetadataState
	{
		[EnumMember(Value = "open")]
		Open,
		[EnumMember(Value = "close")]
		Close
	}

	internal sealed class IndexMetadataStateConverter : JsonConverter<IndexMetadataState>
	{
		public override IndexMetadataState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "open":
					return IndexMetadataState.Open;
				case "close":
					return IndexMetadataState.Close;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, IndexMetadataState value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case IndexMetadataState.Open:
					writer.WriteStringValue("open");
					return;
				case IndexMetadataState.Close:
					writer.WriteStringValue("close");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(IndexRoutingAllocationOptionsConverter))]
	public enum IndexRoutingAllocationOptions
	{
		[EnumMember(Value = "primaries")]
		Primaries,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "new_primaries")]
		NewPrimaries,
		[EnumMember(Value = "all")]
		All
	}

	internal sealed class IndexRoutingAllocationOptionsConverter : JsonConverter<IndexRoutingAllocationOptions>
	{
		public override IndexRoutingAllocationOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "primaries":
					return IndexRoutingAllocationOptions.Primaries;
				case "none":
					return IndexRoutingAllocationOptions.None;
				case "new_primaries":
					return IndexRoutingAllocationOptions.NewPrimaries;
				case "all":
					return IndexRoutingAllocationOptions.All;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, IndexRoutingAllocationOptions value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case IndexRoutingAllocationOptions.Primaries:
					writer.WriteStringValue("primaries");
					return;
				case IndexRoutingAllocationOptions.None:
					writer.WriteStringValue("none");
					return;
				case IndexRoutingAllocationOptions.NewPrimaries:
					writer.WriteStringValue("new_primaries");
					return;
				case IndexRoutingAllocationOptions.All:
					writer.WriteStringValue("all");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(IndexRoutingRebalanceOptionsConverter))]
	public enum IndexRoutingRebalanceOptions
	{
		[EnumMember(Value = "replicas")]
		Replicas,
		[EnumMember(Value = "primaries")]
		Primaries,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "all")]
		All
	}

	internal sealed class IndexRoutingRebalanceOptionsConverter : JsonConverter<IndexRoutingRebalanceOptions>
	{
		public override IndexRoutingRebalanceOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "replicas":
					return IndexRoutingRebalanceOptions.Replicas;
				case "primaries":
					return IndexRoutingRebalanceOptions.Primaries;
				case "none":
					return IndexRoutingRebalanceOptions.None;
				case "all":
					return IndexRoutingRebalanceOptions.All;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, IndexRoutingRebalanceOptions value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case IndexRoutingRebalanceOptions.Replicas:
					writer.WriteStringValue("replicas");
					return;
				case IndexRoutingRebalanceOptions.Primaries:
					writer.WriteStringValue("primaries");
					return;
				case IndexRoutingRebalanceOptions.None:
					writer.WriteStringValue("none");
					return;
				case IndexRoutingRebalanceOptions.All:
					writer.WriteStringValue("all");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(NumericFielddataFormatConverter))]
	public enum NumericFielddataFormat
	{
		[EnumMember(Value = "disabled")]
		Disabled,
		[EnumMember(Value = "array")]
		Array
	}

	internal sealed class NumericFielddataFormatConverter : JsonConverter<NumericFielddataFormat>
	{
		public override NumericFielddataFormat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "disabled":
					return NumericFielddataFormat.Disabled;
				case "array":
					return NumericFielddataFormat.Array;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, NumericFielddataFormat value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case NumericFielddataFormat.Disabled:
					writer.WriteStringValue("disabled");
					return;
				case NumericFielddataFormat.Array:
					writer.WriteStringValue("array");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(SegmentSortMissingConverter))]
	public enum SegmentSortMissing
	{
		[EnumMember(Value = "_last")]
		Last,
		[EnumMember(Value = "_first")]
		First
	}

	internal sealed class SegmentSortMissingConverter : JsonConverter<SegmentSortMissing>
	{
		public override SegmentSortMissing Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "_last":
					return SegmentSortMissing.Last;
				case "_first":
					return SegmentSortMissing.First;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, SegmentSortMissing value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case SegmentSortMissing.Last:
					writer.WriteStringValue("_last");
					return;
				case SegmentSortMissing.First:
					writer.WriteStringValue("_first");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(SegmentSortModeConverter))]
	public enum SegmentSortMode
	{
		[EnumMember(Value = "min")]
		Min,
		[EnumMember(Value = "max")]
		Max
	}

	internal sealed class SegmentSortModeConverter : JsonConverter<SegmentSortMode>
	{
		public override SegmentSortMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "min":
					return SegmentSortMode.Min;
				case "max":
					return SegmentSortMode.Max;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, SegmentSortMode value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case SegmentSortMode.Min:
					writer.WriteStringValue("min");
					return;
				case SegmentSortMode.Max:
					writer.WriteStringValue("max");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(SegmentSortOrderConverter))]
	public enum SegmentSortOrder
	{
		[EnumMember(Value = "desc")]
		Desc,
		[EnumMember(Value = "asc")]
		Asc
	}

	internal sealed class SegmentSortOrderConverter : JsonConverter<SegmentSortOrder>
	{
		public override SegmentSortOrder Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "desc":
					return SegmentSortOrder.Desc;
				case "asc":
					return SegmentSortOrder.Asc;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, SegmentSortOrder value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case SegmentSortOrder.Desc:
					writer.WriteStringValue("desc");
					return;
				case SegmentSortOrder.Asc:
					writer.WriteStringValue("asc");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(ShardRoutingStateConverter))]
	public enum ShardRoutingState
	{
		[EnumMember(Value = "UNASSIGNED")]
		Unassigned,
		[EnumMember(Value = "STARTED")]
		Started,
		[EnumMember(Value = "RELOCATING")]
		Relocating,
		[EnumMember(Value = "INITIALIZING")]
		Initializing
	}

	internal sealed class ShardRoutingStateConverter : JsonConverter<ShardRoutingState>
	{
		public override ShardRoutingState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "UNASSIGNED":
					return ShardRoutingState.Unassigned;
				case "STARTED":
					return ShardRoutingState.Started;
				case "RELOCATING":
					return ShardRoutingState.Relocating;
				case "INITIALIZING":
					return ShardRoutingState.Initializing;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, ShardRoutingState value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case ShardRoutingState.Unassigned:
					writer.WriteStringValue("UNASSIGNED");
					return;
				case ShardRoutingState.Started:
					writer.WriteStringValue("STARTED");
					return;
				case ShardRoutingState.Relocating:
					writer.WriteStringValue("RELOCATING");
					return;
				case ShardRoutingState.Initializing:
					writer.WriteStringValue("INITIALIZING");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(ShardStoreAllocationConverter))]
	public enum ShardStoreAllocation
	{
		[EnumMember(Value = "unused")]
		Unused,
		[EnumMember(Value = "replica")]
		Replica,
		[EnumMember(Value = "primary")]
		Primary
	}

	internal sealed class ShardStoreAllocationConverter : JsonConverter<ShardStoreAllocation>
	{
		public override ShardStoreAllocation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "unused":
					return ShardStoreAllocation.Unused;
				case "replica":
					return ShardStoreAllocation.Replica;
				case "primary":
					return ShardStoreAllocation.Primary;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, ShardStoreAllocation value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case ShardStoreAllocation.Unused:
					writer.WriteStringValue("unused");
					return;
				case ShardStoreAllocation.Replica:
					writer.WriteStringValue("replica");
					return;
				case ShardStoreAllocation.Primary:
					writer.WriteStringValue("primary");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(ShardStoreStatusConverter))]
	public enum ShardStoreStatus
	{
		[EnumMember(Value = "yellow")]
		Yellow,
		[EnumMember(Value = "red")]
		Red,
		[EnumMember(Value = "green")]
		Green,
		[EnumMember(Value = "all")]
		All
	}

	internal sealed class ShardStoreStatusConverter : JsonConverter<ShardStoreStatus>
	{
		public override ShardStoreStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "yellow":
					return ShardStoreStatus.Yellow;
				case "red":
					return ShardStoreStatus.Red;
				case "green":
					return ShardStoreStatus.Green;
				case "all":
					return ShardStoreStatus.All;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, ShardStoreStatus value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case ShardStoreStatus.Yellow:
					writer.WriteStringValue("yellow");
					return;
				case ShardStoreStatus.Red:
					writer.WriteStringValue("red");
					return;
				case ShardStoreStatus.Green:
					writer.WriteStringValue("green");
					return;
				case ShardStoreStatus.All:
					writer.WriteStringValue("all");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(StorageTypeConverter))]
	public enum StorageType
	{
		[EnumMember(Value = "niofs")]
		Niofs,
		[EnumMember(Value = "mmapfs")]
		Mmapfs,
		[EnumMember(Value = "hybridfs")]
		Hybridfs,
		[EnumMember(Value = "fs")]
		Fs
	}

	internal sealed class StorageTypeConverter : JsonConverter<StorageType>
	{
		public override StorageType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "niofs":
					return StorageType.Niofs;
				case "mmapfs":
					return StorageType.Mmapfs;
				case "hybridfs":
					return StorageType.Hybridfs;
				case "fs":
					return StorageType.Fs;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, StorageType value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case StorageType.Niofs:
					writer.WriteStringValue("niofs");
					return;
				case StorageType.Mmapfs:
					writer.WriteStringValue("mmapfs");
					return;
				case StorageType.Hybridfs:
					writer.WriteStringValue("hybridfs");
					return;
				case StorageType.Fs:
					writer.WriteStringValue("fs");
					return;
			}

			writer.WriteNullValue();
		}
	}

	[JsonConverter(typeof(TranslogDurabilityConverter))]
	public enum TranslogDurability
	{
		[EnumMember(Value = "request")]
		Request,
		[EnumMember(Value = "async")]
		Async
	}

	internal sealed class TranslogDurabilityConverter : JsonConverter<TranslogDurability>
	{
		public override TranslogDurability Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var enumString = reader.GetString();
			switch (enumString)
			{
				case "request":
					return TranslogDurability.Request;
				case "async":
					return TranslogDurability.Async;
			}

			ThrowHelper.ThrowJsonException();
			return default;
		}

		public override void Write(Utf8JsonWriter writer, TranslogDurability value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case TranslogDurability.Request:
					writer.WriteStringValue("request");
					return;
				case TranslogDurability.Async:
					writer.WriteStringValue("async");
					return;
			}

			writer.WriteNullValue();
		}
	}
}