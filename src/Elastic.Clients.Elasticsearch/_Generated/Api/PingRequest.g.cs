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

using Elastic.Clients.Elasticsearch.Experimental;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public class PingRequestParameters : RequestParameters<PingRequestParameters>
	{
	}

	public partial class PingRequest : PlainRequestBase<PingRequestParameters>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespacePing;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
	}

	[JsonConverter(typeof(PingRequestDescriptorConverter))]
	public sealed partial class PingRequestDescriptor : RequestDescriptorBase<PingRequestDescriptor, PingRequestParameters>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespacePing;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
	}

	internal sealed class PingRequestDescriptorConverter : JsonConverter<PingRequestDescriptor>
	{
		public override PingRequestDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, PingRequestDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}