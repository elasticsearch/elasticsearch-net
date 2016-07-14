﻿using System;
using System.Collections.Generic;
using System.Threading;
using FluentAssertions;
using Nest;
using Tests.Framework;
using Tests.Framework.Integration;
using Xunit;

namespace Tests.Document.Multiple.PartitionedBulk
{
	[Collection(TypeOfCluster.Indexing)]
	public class PartitionedBulkApiTests : SerializationTestBase
	{
		private class SmallObject
		{
			public int Id { get; set; }
		}

		private readonly IElasticClient _client;

		private static string IndexName { get; } = $"project-copy-{Guid.NewGuid().ToString("N").Substring(8)}";

		private IEnumerable<SmallObject> CreateLazyStreamOfDocuments(int count)
		{
			for (var i = 0; i < count; i++)
				yield return new SmallObject() { Id = i };
		}

		public PartitionedBulkApiTests(IndexingCluster cluster, EndpointUsage usage)
		{
			this._client = cluster.Client();
		}

		[I] public void ReturnsExpectedResponse()
		{
			var handle = new ManualResetEvent(false);

			var size = 1000;
			var pages = 100;
			var seenPages = 0;
			var numberOfDocuments = size * pages;
			var documents = this.CreateLazyStreamOfDocuments(numberOfDocuments);

			//first we setup our cold observable
			var observableBulk = this._client.PartitionedBulk(documents, f => f
				.MaxDegreeOfParallelism(8)
				.BackOff(TimeSpan.FromSeconds(10))
				.NumberOfBackOffRetries(2)
				.Size(size)
				.RefreshOnCompleted()
				.Index(IndexName)
			);
			//we set up an observer
			var bulkObserver = new PartitionedBulkObserver(
				onError: (e) => { throw e; },
				onCompleted: () => handle.Set(),
				onNext: (b) => Interlocked.Increment(ref seenPages)
			);
			//when we subscribe the observable becomes hot
			observableBulk.Subscribe(bulkObserver);

			handle.WaitOne(TimeSpan.FromMinutes(5));

			seenPages.Should().Be(pages);
			var count = this._client.Count<SmallObject>(f => f.Index(IndexName));
			count.Count.Should().Be(numberOfDocuments);
			bulkObserver.TotalNumberOfFailedBuffers.Should().Be(0);
			bulkObserver.TotalNumberOfRetries.Should().Be(0);


		}
	}
}
