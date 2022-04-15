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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public class MlSetUpgradeModeRequestParameters : RequestParameters<MlSetUpgradeModeRequestParameters>
	{
		[JsonIgnore]
		public bool? Enabled { get => Q<bool?>("enabled"); set => Q("enabled", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	public partial class MlSetUpgradeModeRequest : PlainRequestBase<MlSetUpgradeModeRequestParameters>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningSetUpgradeMode;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? Enabled { get => Q<bool?>("enabled"); set => Q("enabled", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	public sealed partial class MlSetUpgradeModeRequestDescriptor : RequestDescriptorBase<MlSetUpgradeModeRequestDescriptor, MlSetUpgradeModeRequestParameters>
	{
		internal MlSetUpgradeModeRequestDescriptor(Action<MlSetUpgradeModeRequestDescriptor> configure) => configure.Invoke(this);
		public MlSetUpgradeModeRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningSetUpgradeMode;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public MlSetUpgradeModeRequestDescriptor Enabled(bool? enabled = true) => Qs("enabled", enabled);
		public MlSetUpgradeModeRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}