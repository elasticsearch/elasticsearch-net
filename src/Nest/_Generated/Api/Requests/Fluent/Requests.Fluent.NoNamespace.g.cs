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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using Elastic.Transport;

#nullable restore
namespace Nest
{
	public class ClosePointInTimeDescriptor : RequestDescriptorBase<ClosePointInTimeDescriptor, ClosePointInTimeRequestParameters, IClosePointInTimeRequest>, IClosePointInTimeRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceClosePointInTime;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public class OpenPointInTimeDescriptor : RequestDescriptorBase<OpenPointInTimeDescriptor, OpenPointInTimeRequestParameters, IOpenPointInTimeRequest>, IOpenPointInTimeRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceOpenPointInTime;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public class PingDescriptor : RequestDescriptorBase<PingDescriptor, PingRequestParameters, IPingRequest>, IPingRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespacePing;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
	}
}