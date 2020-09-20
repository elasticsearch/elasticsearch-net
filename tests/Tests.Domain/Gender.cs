// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using Elastic.Transport.Serialization;
using Elasticsearch.Net;

namespace Tests.Domain
{
	[StringEnum]
	public enum Gender
	{
		Male,
		Female,
		NoneOfYourBeeswax
	}
}
