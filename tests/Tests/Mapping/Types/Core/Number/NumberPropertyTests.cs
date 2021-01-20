// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System;
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Nest;
using Tests.Core.ManagedElasticsearch.Clusters;
using Tests.Domain;
using Tests.Framework.EndpointTests.TestState;

namespace Tests.Mapping.Types.Core.Number
{
	public class NumberPropertyTests : PropertyTestsBase
	{
		public NumberPropertyTests(WritableCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override object ExpectJson => new
		{
			properties = new
			{
				numberOfCommits = new
				{
					type = "integer",
					doc_values = true,
					store = true,
					index = false,
					null_value = 0.0,
					ignore_malformed = true,
					coerce = true
				}
			}
		};

		protected override Func<PropertiesDescriptor<Project>, IPromise<IProperties>> FluentProperties => f => f
			.Number(n => n
				.Name(p => p.NumberOfCommits)
				.Type(NumberType.Integer)
				.DocValues()
				.Store()
				.Index(false)
				.NullValue(0.0)
				.IgnoreMalformed()
				.Coerce()
			);


		protected override IProperties InitializerProperties => new Properties
		{
			{
				"numberOfCommits", new NumberProperty(NumberType.Integer)
				{
					DocValues = true,
					Store = true,
					Index = false,
					NullValue = 0.0,
					IgnoreMalformed = true,
					Coerce = true
				}
			}
		};
	}

	public class ScaledFloatNumberPropertyTests : PropertyTestsBase
	{
		public ScaledFloatNumberPropertyTests(WritableCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override object ExpectJson => new
		{
			properties = new
			{
				numberOfCommits = new
				{
					type = "scaled_float",
					scaling_factor = 10.0,
					doc_values = true,
					store = true,
					index = false,
					null_value = 0.0,
					ignore_malformed = true,
					coerce = true
				}
			}
		};

		protected override Func<PropertiesDescriptor<Project>, IPromise<IProperties>> FluentProperties => f => f
			.Number(n => n
				.Name(p => p.NumberOfCommits)
				.Type(NumberType.ScaledFloat)
				.ScalingFactor(10)
				.DocValues()
				.Store()
				.Index(false)
				.NullValue(0.0)
				.IgnoreMalformed()
				.Coerce()
			);


		protected override IProperties InitializerProperties => new Properties
		{
			{
				"numberOfCommits", new NumberProperty(NumberType.ScaledFloat)
				{
					ScalingFactor = 10,
					DocValues = true,
					Store = true,
					Index = false,
					NullValue = 0.0,
					IgnoreMalformed = true,
					Coerce = true
				}
			}
		};
	}

	[SkipVersion("<7.10.0", "Introduced in 7.10.0")]
	public class UnsignedLongNumberPropertyTests : PropertyTestsBase
	{
		public UnsignedLongNumberPropertyTests(WritableCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override object ExpectJson => new
		{
			properties = new
			{
				numberOfCommits = new
				{
					type = "unsigned_long",
					doc_values = true,
					similarity = "BM25",
					store = true,
					index = false,
					ignore_malformed = true
				}
			}
		};

		protected override Func<PropertiesDescriptor<Project>, IPromise<IProperties>> FluentProperties => f => f
			.Number(n => n
				.Name(p => p.NumberOfCommits)
				.Type(NumberType.UnsignedLong)
				.DocValues()
				.Similarity("BM25")
				.Store()
				.Index(false)
				.IgnoreMalformed()
			);
		
		protected override IProperties InitializerProperties => new Properties
		{
			{
				"numberOfCommits", new NumberProperty(NumberType.UnsignedLong)
				{
					DocValues = true,
					Similarity = "BM25",
					Store = true,
					Index = false,
					IgnoreMalformed = true
				}
			}
		};
	}
}
