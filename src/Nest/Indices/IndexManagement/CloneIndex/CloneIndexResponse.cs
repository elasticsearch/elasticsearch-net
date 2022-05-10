// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.Runtime.Serialization;

namespace Nest
{
	public class CloneIndexResponse : AcknowledgedResponseBase
	{
		[DataMember(Name = "shards_acknowledged")]
		public bool ShardsAcknowledged { get; set; }

		/// <summary>
		/// The target index created
		/// </summary>
		[DataMember(Name = "index")]
		public string Index { get; set; }
	}
}