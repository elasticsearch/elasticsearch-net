﻿using System;
using System.Collections.Generic;
using Elasticsearch.Net;
using NUnit.Framework;
using Nest.Tests.MockData.Domain;

namespace Nest.Tests.Unit.Core.Index
{
    [TestFixture]
    public class IndexTests : BaseJsonTests
    {
        [Test]
        public void IndexParameters()
        {
            var o = new ElasticsearchProject { Id = 1, Name = "Test" };
            var result = this._client.Index(o, i => i.Version(1));
            var status = result.ConnectionStatus;
            StringAssert.Contains("version=1", status.RequestUrl);
        }

        [Test]
        public void IndexByIndexName_ProcessingRequestWithNotNullString_SendsIndexingRequestToNamedIndex()
        {
            var o = new ElasticsearchProject { Id = 1, Name = "Test" };
            const string testIndexName = "myTestIndexName";
            var result = ((ElasticClient)this._client).Index(o, testIndexName);
            var status = result.ConnectionStatus;
            StringAssert.Contains(testIndexName, status.RequestUrl);
            StringAssert.DoesNotContain(UnitTestDefaults.DefaultIndex, status.RequestUrl);
        }

        [Test]
        public void IndexByIndexName_ProcessingRequestWithNullString_SendsIndexingRequestToDefaultIndex()
        {
            var o = new ElasticsearchProject { Id = 1, Name = "Test" };
            const string testIndexName = null;
            var result = ((ElasticClient)this._client).Index(o, testIndexName);
            var status = result.ConnectionStatus;
            StringAssert.Contains(UnitTestDefaults.DefaultIndex, status.RequestUrl);
        }

        [Test]
        public void IndexingDictionaryRespectsCasing()
        {
            var x = new
            {
                FirstDictionary = new Dictionary<string, object>
				{
					{"ALLCAPS", 1 },
					{"PascalCase", "should work as well"},
					{"camelCase", DateTime.Now}
				}
            };
            var result = this._client.Index(x, i => i.Id(1));

            var request = result.ConnectionStatus.Request.Utf8String();
            StringAssert.Contains("ALLCAPS", request);
            StringAssert.Contains("PascalCase", request);
            StringAssert.Contains("camelCase", request);
            StringAssert.Contains("firstDictionary", request);
        }
    }
}
