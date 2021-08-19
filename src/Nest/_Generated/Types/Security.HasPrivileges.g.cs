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

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.Security.HasPrivileges
{
	public partial class ApplicationPrivilegesCheck
	{
		[JsonPropertyName("application")]
		public string Application { get; set; }

		[JsonPropertyName("privileges")]
		public IEnumerable<string> Privileges { get; set; }

		[JsonPropertyName("resources")]
		public IEnumerable<string> Resources { get; set; }
	}

	public partial class IndexPrivilegesCheck
	{
		[JsonPropertyName("names")]
		public IEnumerable<string> Names { get; set; }

		[JsonPropertyName("privileges")]
		public IEnumerable<string> Privileges { get; set; }
	}
}