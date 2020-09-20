// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.Runtime.Serialization;
using Elastic.Transport.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	[StringEnum]
	public enum GapPolicy
	{
		[EnumMember(Value = "skip")]
		Skip,

		[EnumMember(Value = "insert_zeros")]
		InsertZeros
	}
}
