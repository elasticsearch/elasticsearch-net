﻿using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Nest;
using Newtonsoft.Json;
using Tests.Framework;
using Tests.Framework.Integration;
using Tests.Framework.ManagedElasticsearch.Clusters;
using Tests.Framework.MockData;
using static Nest.Infer;

namespace Tests.Aggregations.Bucket.Composite
{
	/**
	 * A multi-bucket aggregation that creates composite buckets from different sources.
     *
     * Unlike the other multi-bucket aggregation the composite aggregation can be
	 * used to paginate all buckets from a multi-level aggregation efficiently.
	 * This aggregation provides a way to stream all buckets of a specific aggregation
	 * similarly to what scroll does for documents.
     *
     * The composite buckets are built from the combinations of the values extracted/created
	 * for each document and each combination is considered as a composite bucket.
	 *
	 * NOTE: Only available in Elasticsearch 6.1.0+
	 *
	 * Be sure to read the Elasticsearch documentation on {ref_current}/search-aggregations-bucket-composite-aggregation.html[Composite Aggregation].
	*/
	[SkipVersion("<6.1.0", "Composite Aggregation is only available in Elasticsearch 6.1.0+")]
	public class CompositeAggregationUsageTests : ProjectsOnlyAggregationUsageTestBase
	{
		public CompositeAggregationUsageTests(ReadOnlyCluster i, EndpointUsage usage) : base(i, usage) { }

		protected override object AggregationJson => new
		{
			my_buckets = new
			{
				composite = new
				{
					sources = new object[]
					{
						new
						{
							branches = new
							{
								terms = new
								{
									field = "branches.keyword"
								}
							}
						},
						new
						{
							started = new
							{
								date_histogram = new
								{
									field = "startedOn",
									interval = "month"
								}
							}
						},
						new
						{
							branch_count = new
							{
								histogram = new
								{
									field = "requiredBranches",
									interval = 1d
								}
							}
						},
					}
				},
				aggs = new
				{
					project_tags = new
					{
						nested = new
						{
							path = "tags"
						},
						aggs = new
						{
							tags = new
							{
								terms = new {field = "tags.name"}
							}
						}
					}
				}
			}
		};

		protected override Func<AggregationContainerDescriptor<Project>, IAggregationContainer> FluentAggs => a => a
			.Composite("my_buckets", date => date
				.Sources(s => s
					.Terms("branches", t => t
						.Field(f => f.Branches.Suffix("keyword"))
					)
					.DateHistogram("started", d => d
						.Field(f => f.StartedOn)
						.Interval(DateInterval.Month)
					)
					.Histogram("branch_count", h => h
						.Field(f => f.RequiredBranches)
						.Interval(1)
					)
				)
				.Aggregations(childAggs => childAggs
					.Nested("project_tags", n => n
						.Path(p => p.Tags)
						.Aggregations(nestedAggs => nestedAggs
							.Terms("tags", avg => avg.Field(p => p.Tags.First().Name))
						)
					)
				)
			);

		protected override AggregationDictionary InitializerAggs =>
			new CompositeAggregation("my_buckets")
			{
				Sources = new List<ICompositeAggregationSource>
				{
					new TermsCompositeAggregationSource("branches")
					{
						Field = Infer.Field<Project>(f => f.Branches.Suffix("keyword"))
					},
					new DateHistogramCompositeAggregationSource("started")
					{
						Field = Infer.Field<Project>(f => f.StartedOn),
						Interval = DateInterval.Month
					},
					new HistogramCompositeAggregationSource("branch_count")
					{
						Field = Infer.Field<Project>(f => f.RequiredBranches),
						Interval = 1
					}
				},
				Aggregations = new NestedAggregation("project_tags")
				{
					Path = Field<Project>(p => p.Tags),
					Aggregations = new TermsAggregation("tags")
					{
						Field = Field<Project>(p => p.Tags.First().Name)
					}
				}
			};

		/**==== Handling Responses
		 * Each Composite aggregation buckey key is an `ILazyDocument` that can be converted
		 * to a type of your choosing. Here, we demonstrate converting to
		 * an `IDictionary<string, object>` and a `CompositeKey` type we have
		 * defined.
		 */
		public class CompositeKey
		{
			public string Branches { get; set; }
			public long Started { get; set; }
			[PropertyName("branch_count"), JsonProperty("branch_count")]
			public double BranchCount { get; set; }
		}

		protected override void ExpectResponse(ISearchResponse<Project> response)
		{
			response.ShouldBeValid();

			var composite = response.Aggregations.Composite("my_buckets");
			composite.Should().NotBeNull();
			composite.Buckets.Should().NotBeNullOrEmpty();
			var count = 0;
			foreach (var item in composite.Buckets)
			{
				count++;
				if (count % 2 == 0)
				{
					var key = item.Key.As<IDictionary<string, object>>();
					key.Should().NotBeNull().And.ContainKeys("branches", "started", "branch_count");
				}
				else
				{
					var key = item.Key.As<CompositeKey>();
					key.Should().NotBeNull();
					key.Branches.Should().NotBeNullOrEmpty();
					/** note that date values are returned as `long` */
					key.Started.Should().BeGreaterThan(0);
					key.BranchCount.Should().BeGreaterThan(0);
				}

				item.DocCount.Should().BeGreaterThan(0);

				var nested = item.Nested("project_tags");
				nested.Should().NotBeNull();

				var nestedTerms = nested.Terms("tags");
				nestedTerms.Buckets.Count.Should().BeGreaterThan(0);
			}
		}
	}
}
