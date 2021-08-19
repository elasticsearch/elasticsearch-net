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
namespace Nest.TextStructure
{
	public partial class FindStructureDescriptor<TJsonDocument> : RequestDescriptorBase<FindStructureDescriptor<TJsonDocument>, FindStructureRequestParameters, IFindStructureRequest<TJsonDocument>>, IFindStructureRequest<TJsonDocument>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TextStructureFindStructure;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_text_structure/find_structure</summary>
        public FindStructureDescriptor() : base()
		{
		}
	}
}