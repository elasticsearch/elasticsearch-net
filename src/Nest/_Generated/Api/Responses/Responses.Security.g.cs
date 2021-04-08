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

using System.Text.Json.Serialization;

#nullable restore
namespace Nest
{
	public class DeleteRoleMappingResponse : ResponseBase
	{
		[JsonPropertyName("found")]
		public bool Found
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	public class GetRoleMappingResponse : DictionaryResponseBase
	{
	}

	public class PutRoleMappingResponse : ResponseBase
	{
		[JsonPropertyName("created")]
		public bool? Created
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("role_mapping")]
		public PutRoleMappingStatus RoleMapping
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	public class PutUserResponse : ResponseBase
	{
		[JsonPropertyName("created")]
		public bool Created
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}
}