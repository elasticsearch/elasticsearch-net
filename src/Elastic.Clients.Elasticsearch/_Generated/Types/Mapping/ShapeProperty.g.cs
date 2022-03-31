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
namespace Elastic.Clients.Elasticsearch.Mapping
{
	public partial class ShapeProperty : Mapping.DocValuesPropertyBase, IProperty
	{
		[JsonInclude]
		[JsonPropertyName("coerce")]
		public bool? Coerce { get; init; }

		[JsonInclude]
		[JsonPropertyName("ignore_malformed")]
		public bool? IgnoreMalformed { get; init; }

		[JsonInclude]
		[JsonPropertyName("ignore_z_value")]
		public bool? IgnoreZValue { get; init; }

		[JsonInclude]
		[JsonPropertyName("orientation")]
		public Elastic.Clients.Elasticsearch.Mapping.GeoOrientation? Orientation { get; init; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "shape";
	}
}