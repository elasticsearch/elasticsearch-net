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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.QueryRules;

public sealed partial class ListRulesetsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Starting offset (default: 0)
	/// </para>
	/// </summary>
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>
	/// specifies a max number of results to get
	/// </para>
	/// </summary>
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }
}

/// <summary>
/// <para>
/// Get all query rulesets.
/// Get summarized information about the query rulesets.
/// </para>
/// </summary>
public sealed partial class ListRulesetsRequest : PlainRequest<ListRulesetsRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.QueryRulesListRulesets;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "query_rules.list_rulesets";

	/// <summary>
	/// <para>
	/// Starting offset (default: 0)
	/// </para>
	/// </summary>
	[JsonIgnore]
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>
	/// specifies a max number of results to get
	/// </para>
	/// </summary>
	[JsonIgnore]
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }
}

/// <summary>
/// <para>
/// Get all query rulesets.
/// Get summarized information about the query rulesets.
/// </para>
/// </summary>
public sealed partial class ListRulesetsRequestDescriptor : RequestDescriptor<ListRulesetsRequestDescriptor, ListRulesetsRequestParameters>
{
	internal ListRulesetsRequestDescriptor(Action<ListRulesetsRequestDescriptor> configure) => configure.Invoke(this);

	public ListRulesetsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.QueryRulesListRulesets;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "query_rules.list_rulesets";

	public ListRulesetsRequestDescriptor From(int? from) => Qs("from", from);
	public ListRulesetsRequestDescriptor Size(int? size) => Qs("size", size);

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}