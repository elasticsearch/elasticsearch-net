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
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------

using System.Text.Json.Serialization;

#nullable restore
namespace Nest
{
	public class CatNodeAttributesRecord
	{
		[JsonInclude, JsonPropertyName("h")]
		private string? _h = default;
		[JsonInclude, JsonPropertyName("host")]
		private string? _host = default;
		[JsonInclude, JsonPropertyName("i")]
		private string? _i = default;
		[JsonInclude, JsonPropertyName("ip")]
		private string? _ip = default;
		[JsonPropertyName("attr")]
		public string Attr
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		public string? Host => _h ?? _host;
		[JsonPropertyName("id")]
		public string Id
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		public string? Ip => _i ?? _ip;
		[JsonPropertyName("node")]
		public string Node
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("pid")]
		public string Pid
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("port")]
		public string Port
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("value")]
		public string Value
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