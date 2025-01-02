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

namespace Elastic.Clients.Elasticsearch.Security;

[JsonConverter(typeof(AccessTokenGrantTypeConverter))]
public enum AccessTokenGrantType
{
	[EnumMember(Value = "refresh_token")]
	RefreshToken,
	[EnumMember(Value = "password")]
	Password,
	[EnumMember(Value = "_kerberos")]
	Kerberos,
	[EnumMember(Value = "client_credentials")]
	ClientCredentials
}

internal sealed class AccessTokenGrantTypeConverter : JsonConverter<AccessTokenGrantType>
{
	public override AccessTokenGrantType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "refresh_token":
				return AccessTokenGrantType.RefreshToken;
			case "password":
				return AccessTokenGrantType.Password;
			case "_kerberos":
				return AccessTokenGrantType.Kerberos;
			case "client_credentials":
				return AccessTokenGrantType.ClientCredentials;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, AccessTokenGrantType value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case AccessTokenGrantType.RefreshToken:
				writer.WriteStringValue("refresh_token");
				return;
			case AccessTokenGrantType.Password:
				writer.WriteStringValue("password");
				return;
			case AccessTokenGrantType.Kerberos:
				writer.WriteStringValue("_kerberos");
				return;
			case AccessTokenGrantType.ClientCredentials:
				writer.WriteStringValue("client_credentials");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(ApiKeyGrantTypeConverter))]
public enum ApiKeyGrantType
{
	[EnumMember(Value = "password")]
	Password,
	[EnumMember(Value = "access_token")]
	AccessToken
}

internal sealed class ApiKeyGrantTypeConverter : JsonConverter<ApiKeyGrantType>
{
	public override ApiKeyGrantType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "password":
				return ApiKeyGrantType.Password;
			case "access_token":
				return ApiKeyGrantType.AccessToken;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, ApiKeyGrantType value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case ApiKeyGrantType.Password:
				writer.WriteStringValue("password");
				return;
			case ApiKeyGrantType.AccessToken:
				writer.WriteStringValue("access_token");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(ApiKeyTypeConverter))]
public enum ApiKeyType
{
	[EnumMember(Value = "rest")]
	Rest,
	[EnumMember(Value = "cross_cluster")]
	CrossCluster
}

internal sealed class ApiKeyTypeConverter : JsonConverter<ApiKeyType>
{
	public override ApiKeyType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "rest":
				return ApiKeyType.Rest;
			case "cross_cluster":
				return ApiKeyType.CrossCluster;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, ApiKeyType value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case ApiKeyType.Rest:
				writer.WriteStringValue("rest");
				return;
			case ApiKeyType.CrossCluster:
				writer.WriteStringValue("cross_cluster");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(EnumStructConverter<ClusterPrivilege>))]
public readonly partial struct ClusterPrivilege : IEnumStruct<ClusterPrivilege>
{
	public ClusterPrivilege(string value) => Value = value;

	ClusterPrivilege IEnumStruct<ClusterPrivilege>.Create(string value) => value;

	public readonly string Value { get; }
	public static ClusterPrivilege WriteFleetSecrets { get; } = new ClusterPrivilege("write_fleet_secrets");
	public static ClusterPrivilege WriteConnectorSecrets { get; } = new ClusterPrivilege("write_connector_secrets");
	public static ClusterPrivilege TransportClient { get; } = new ClusterPrivilege("transport_client");
	public static ClusterPrivilege ReadSlm { get; } = new ClusterPrivilege("read_slm");
	public static ClusterPrivilege ReadSecurity { get; } = new ClusterPrivilege("read_security");
	public static ClusterPrivilege ReadPipeline { get; } = new ClusterPrivilege("read_pipeline");
	public static ClusterPrivilege ReadIlm { get; } = new ClusterPrivilege("read_ilm");
	public static ClusterPrivilege ReadFleetSecrets { get; } = new ClusterPrivilege("read_fleet_secrets");
	public static ClusterPrivilege ReadCcr { get; } = new ClusterPrivilege("read_ccr");
	public static ClusterPrivilege PostBehavioralAnalyticsEvent { get; } = new ClusterPrivilege("post_behavioral_analytics_event");
	public static ClusterPrivilege None { get; } = new ClusterPrivilege("none");
	public static ClusterPrivilege MonitorWatcher { get; } = new ClusterPrivilege("monitor_watcher");
	public static ClusterPrivilege MonitorTransform { get; } = new ClusterPrivilege("monitor_transform");
	public static ClusterPrivilege MonitorTextStructure { get; } = new ClusterPrivilege("monitor_text_structure");
	public static ClusterPrivilege MonitorStats { get; } = new ClusterPrivilege("monitor_stats");
	public static ClusterPrivilege MonitorSnapshot { get; } = new ClusterPrivilege("monitor_snapshot");
	public static ClusterPrivilege MonitorRollup { get; } = new ClusterPrivilege("monitor_rollup");
	public static ClusterPrivilege MonitorMl { get; } = new ClusterPrivilege("monitor_ml");
	public static ClusterPrivilege MonitorInference { get; } = new ClusterPrivilege("monitor_inference");
	public static ClusterPrivilege MonitorEnrich { get; } = new ClusterPrivilege("monitor_enrich");
	public static ClusterPrivilege MonitorDataStreamGlobalRetention { get; } = new ClusterPrivilege("monitor_data_stream_global_retention");
	public static ClusterPrivilege MonitorDataFrameTransforms { get; } = new ClusterPrivilege("monitor_data_frame_transforms");
	public static ClusterPrivilege Monitor { get; } = new ClusterPrivilege("monitor");
	public static ClusterPrivilege ManageWatcher { get; } = new ClusterPrivilege("manage_watcher");
	public static ClusterPrivilege ManageUserProfile { get; } = new ClusterPrivilege("manage_user_profile");
	public static ClusterPrivilege ManageTransform { get; } = new ClusterPrivilege("manage_transform");
	public static ClusterPrivilege ManageToken { get; } = new ClusterPrivilege("manage_token");
	public static ClusterPrivilege ManageSlm { get; } = new ClusterPrivilege("manage_slm");
	public static ClusterPrivilege ManageServiceAccount { get; } = new ClusterPrivilege("manage_service_account");
	public static ClusterPrivilege ManageSecurity { get; } = new ClusterPrivilege("manage_security");
	public static ClusterPrivilege ManageSearchSynonyms { get; } = new ClusterPrivilege("manage_search_synonyms");
	public static ClusterPrivilege ManageSearchQueryRules { get; } = new ClusterPrivilege("manage_search_query_rules");
	public static ClusterPrivilege ManageSearchApplication { get; } = new ClusterPrivilege("manage_search_application");
	public static ClusterPrivilege ManageSaml { get; } = new ClusterPrivilege("manage_saml");
	public static ClusterPrivilege ManageRollup { get; } = new ClusterPrivilege("manage_rollup");
	public static ClusterPrivilege ManagePipeline { get; } = new ClusterPrivilege("manage_pipeline");
	public static ClusterPrivilege ManageOwnApiKey { get; } = new ClusterPrivilege("manage_own_api_key");
	public static ClusterPrivilege ManageOidc { get; } = new ClusterPrivilege("manage_oidc");
	public static ClusterPrivilege ManageMl { get; } = new ClusterPrivilege("manage_ml");
	public static ClusterPrivilege ManageLogstashPipelines { get; } = new ClusterPrivilege("manage_logstash_pipelines");
	public static ClusterPrivilege ManageIngestPipelines { get; } = new ClusterPrivilege("manage_ingest_pipelines");
	public static ClusterPrivilege ManageInference { get; } = new ClusterPrivilege("manage_inference");
	public static ClusterPrivilege ManageIndexTemplates { get; } = new ClusterPrivilege("manage_index_templates");
	public static ClusterPrivilege ManageIlm { get; } = new ClusterPrivilege("manage_ilm");
	public static ClusterPrivilege ManageEnrich { get; } = new ClusterPrivilege("manage_enrich");
	public static ClusterPrivilege ManageDataStreamGlobalRetention { get; } = new ClusterPrivilege("manage_data_stream_global_retention");
	public static ClusterPrivilege ManageDataFrameTransforms { get; } = new ClusterPrivilege("manage_data_frame_transforms");
	public static ClusterPrivilege ManageCcr { get; } = new ClusterPrivilege("manage_ccr");
	public static ClusterPrivilege ManageBehavioralAnalytics { get; } = new ClusterPrivilege("manage_behavioral_analytics");
	public static ClusterPrivilege ManageAutoscaling { get; } = new ClusterPrivilege("manage_autoscaling");
	public static ClusterPrivilege ManageApiKey { get; } = new ClusterPrivilege("manage_api_key");
	public static ClusterPrivilege Manage { get; } = new ClusterPrivilege("manage");
	public static ClusterPrivilege GrantApiKey { get; } = new ClusterPrivilege("grant_api_key");
	public static ClusterPrivilege DelegatePki { get; } = new ClusterPrivilege("delegate_pki");
	public static ClusterPrivilege CrossClusterSearch { get; } = new ClusterPrivilege("cross_cluster_search");
	public static ClusterPrivilege CrossClusterReplication { get; } = new ClusterPrivilege("cross_cluster_replication");
	public static ClusterPrivilege CreateSnapshot { get; } = new ClusterPrivilege("create_snapshot");
	public static ClusterPrivilege CancelTask { get; } = new ClusterPrivilege("cancel_task");
	public static ClusterPrivilege All { get; } = new ClusterPrivilege("all");

	public override string ToString() => Value ?? string.Empty;

	public static implicit operator string(ClusterPrivilege clusterPrivilege) => clusterPrivilege.Value;
	public static implicit operator ClusterPrivilege(string value) => new(value);

	public override int GetHashCode() => Value.GetHashCode();
	public override bool Equals(object obj) => obj is ClusterPrivilege other && this.Equals(other);
	public bool Equals(ClusterPrivilege other) => Value == other.Value;

	public static bool operator ==(ClusterPrivilege a, ClusterPrivilege b) => a.Equals(b);
	public static bool operator !=(ClusterPrivilege a, ClusterPrivilege b) => !(a == b);
}

[JsonConverter(typeof(GrantTypeConverter))]
public enum GrantType
{
	/// <summary>
	/// <para>
	/// In this type of grant, you must supply the user ID and password for which you want to create the API key.
	/// </para>
	/// </summary>
	[EnumMember(Value = "password")]
	Password,
	/// <summary>
	/// <para>
	/// In this type of grant, you must supply an access token that was created by the Elasticsearch token service.
	/// </para>
	/// </summary>
	[EnumMember(Value = "access_token")]
	AccessToken
}

internal sealed class GrantTypeConverter : JsonConverter<GrantType>
{
	public override GrantType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "password":
				return GrantType.Password;
			case "access_token":
				return GrantType.AccessToken;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, GrantType value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case GrantType.Password:
				writer.WriteStringValue("password");
				return;
			case GrantType.AccessToken:
				writer.WriteStringValue("access_token");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(EnumStructConverter<IndexPrivilege>))]
public readonly partial struct IndexPrivilege : IEnumStruct<IndexPrivilege>
{
	public IndexPrivilege(string value) => Value = value;

	IndexPrivilege IEnumStruct<IndexPrivilege>.Create(string value) => value;

	public readonly string Value { get; }
	public static IndexPrivilege Write { get; } = new IndexPrivilege("write");
	public static IndexPrivilege ViewIndexMetadata { get; } = new IndexPrivilege("view_index_metadata");
	public static IndexPrivilege ReadCrossCluster { get; } = new IndexPrivilege("read_cross_cluster");
	public static IndexPrivilege Read { get; } = new IndexPrivilege("read");
	public static IndexPrivilege None { get; } = new IndexPrivilege("none");
	public static IndexPrivilege Monitor { get; } = new IndexPrivilege("monitor");
	public static IndexPrivilege ManageLeaderIndex { get; } = new IndexPrivilege("manage_leader_index");
	public static IndexPrivilege ManageIlm { get; } = new IndexPrivilege("manage_ilm");
	public static IndexPrivilege ManageFollowIndex { get; } = new IndexPrivilege("manage_follow_index");
	public static IndexPrivilege ManageDataStreamLifecycle { get; } = new IndexPrivilege("manage_data_stream_lifecycle");
	public static IndexPrivilege Manage { get; } = new IndexPrivilege("manage");
	public static IndexPrivilege Maintenance { get; } = new IndexPrivilege("maintenance");
	public static IndexPrivilege Index { get; } = new IndexPrivilege("index");
	public static IndexPrivilege DeleteIndex { get; } = new IndexPrivilege("delete_index");
	public static IndexPrivilege Delete { get; } = new IndexPrivilege("delete");
	public static IndexPrivilege CrossClusterReplicationInternal { get; } = new IndexPrivilege("cross_cluster_replication_internal");
	public static IndexPrivilege CrossClusterReplication { get; } = new IndexPrivilege("cross_cluster_replication");
	public static IndexPrivilege CreateIndex { get; } = new IndexPrivilege("create_index");
	public static IndexPrivilege CreateDoc { get; } = new IndexPrivilege("create_doc");
	public static IndexPrivilege Create { get; } = new IndexPrivilege("create");
	public static IndexPrivilege AutoConfigure { get; } = new IndexPrivilege("auto_configure");
	public static IndexPrivilege All { get; } = new IndexPrivilege("all");

	public override string ToString() => Value ?? string.Empty;

	public static implicit operator string(IndexPrivilege indexPrivilege) => indexPrivilege.Value;
	public static implicit operator IndexPrivilege(string value) => new(value);

	public override int GetHashCode() => Value.GetHashCode();
	public override bool Equals(object obj) => obj is IndexPrivilege other && this.Equals(other);
	public bool Equals(IndexPrivilege other) => Value == other.Value;

	public static bool operator ==(IndexPrivilege a, IndexPrivilege b) => a.Equals(b);
	public static bool operator !=(IndexPrivilege a, IndexPrivilege b) => !(a == b);
}

[JsonConverter(typeof(RemoteClusterPrivilegeConverter))]
public enum RemoteClusterPrivilege
{
	[EnumMember(Value = "monitor_stats")]
	MonitorStats,
	[EnumMember(Value = "monitor_enrich")]
	MonitorEnrich
}

internal sealed class RemoteClusterPrivilegeConverter : JsonConverter<RemoteClusterPrivilege>
{
	public override RemoteClusterPrivilege Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "monitor_stats":
				return RemoteClusterPrivilege.MonitorStats;
			case "monitor_enrich":
				return RemoteClusterPrivilege.MonitorEnrich;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, RemoteClusterPrivilege value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case RemoteClusterPrivilege.MonitorStats:
				writer.WriteStringValue("monitor_stats");
				return;
			case RemoteClusterPrivilege.MonitorEnrich:
				writer.WriteStringValue("monitor_enrich");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(EnumStructConverter<RestrictionWorkflow>))]
public readonly partial struct RestrictionWorkflow : IEnumStruct<RestrictionWorkflow>
{
	public RestrictionWorkflow(string value) => Value = value;

	RestrictionWorkflow IEnumStruct<RestrictionWorkflow>.Create(string value) => value;

	public readonly string Value { get; }
	public static RestrictionWorkflow SearchApplicationQuery { get; } = new RestrictionWorkflow("search_application_query");

	public override string ToString() => Value ?? string.Empty;

	public static implicit operator string(RestrictionWorkflow restrictionWorkflow) => restrictionWorkflow.Value;
	public static implicit operator RestrictionWorkflow(string value) => new(value);

	public override int GetHashCode() => Value.GetHashCode();
	public override bool Equals(object obj) => obj is RestrictionWorkflow other && this.Equals(other);
	public bool Equals(RestrictionWorkflow other) => Value == other.Value;

	public static bool operator ==(RestrictionWorkflow a, RestrictionWorkflow b) => a.Equals(b);
	public static bool operator !=(RestrictionWorkflow a, RestrictionWorkflow b) => !(a == b);
}

[JsonConverter(typeof(TemplateFormatConverter))]
public enum TemplateFormat
{
	[EnumMember(Value = "string")]
	String,
	[EnumMember(Value = "json")]
	Json
}

internal sealed class TemplateFormatConverter : JsonConverter<TemplateFormat>
{
	public override TemplateFormat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "string":
				return TemplateFormat.String;
			case "json":
				return TemplateFormat.Json;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, TemplateFormat value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case TemplateFormat.String:
				writer.WriteStringValue("string");
				return;
			case TemplateFormat.Json:
				writer.WriteStringValue("json");
				return;
		}

		writer.WriteNullValue();
	}
}