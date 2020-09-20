// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using Elastic.Transport.Utf8Json;
using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	[InterfaceDataContract]
	[ReadAs(typeof(MatchNoneQuery))]
	public interface IMatchNoneQuery : IQuery { }

	public class MatchNoneQuery : QueryBase, IMatchNoneQuery
	{
		protected override bool Conditionless => false;

		internal override void InternalWrapInContainer(IQueryContainer container) => container.MatchNone = this;
	}

	public class MatchNoneQueryDescriptor
		: QueryDescriptorBase<MatchNoneQueryDescriptor, IMatchNoneQuery>
			, IMatchNoneQuery
	{
		protected override bool Conditionless => false;
	}
}
