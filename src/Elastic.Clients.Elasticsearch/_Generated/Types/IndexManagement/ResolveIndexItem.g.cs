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
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement.ResolveIndex
{
	public partial class ResolveIndexItem
	{
		[JsonInclude]
		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name { get; init; }

		[JsonInclude]
		[JsonPropertyName("aliases")]
		public IReadOnlyCollection<string>? Aliases { get; init; }

		[JsonInclude]
		[JsonPropertyName("attributes")]
		public IReadOnlyCollection<string> Attributes { get; init; }

		[JsonInclude]
		[JsonPropertyName("data_stream")]
		public Elastic.Clients.Elasticsearch.DataStreamName? DataStream { get; init; }
	}
}