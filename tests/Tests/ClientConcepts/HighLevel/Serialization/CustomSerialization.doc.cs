// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using static Tests.Core.Serialization.SerializationTestHelper;
using Elastic.Clients.Elasticsearch.QueryDsl;
using Elastic.Clients.Elasticsearch.JsonNetSerializer;

namespace Tests.ClientConcepts.HighLevel.Serialization
{
	/**[[custom-serialization]]
	 * === Custom Serialization
	 *
	 * After internalizing the serialization routines, and IL-merging the Newtonsoft.Json package in 6.x, we are pleased to
	 * announce that the next stage of serialization improvements have been completed in 7.0.
	 *
	 * Both SimpleJson and Newtonsoft.Json have been completely removed and replaced with an implementation of Utf8Json, a fast
	 * serializer that works directly with UTF-8 binary.
	 *
	 * With the move to Utf8Json, we have removed some features that were available in the previous JSON libraries that have
	 * proven too onerous to carry forward at this stage.
	 *
	 * - JSON in the request is never indented, even if SerializationFormatting.Indented is specified. The serialization
	 * routines generated by Utf8Json never generate an IJsonFormatter<T> that will indent JSON, for performance reasons.
	 * We are considering options for exposing indented JSON for development and debugging purposes.
	 *
	 * - NEST types cannot be extended by inheritance. With NEST 6.x, additional properties can be included for a type by deriving from
	 * that type and annotating these new properties. With the current implementation of serialization with Utf8Json, this approach will not work.
	 *
	 * - Serializer uses Reflection.Emit. Utf8Json uses Reflection.Emit to generate efficient formatters for serializing types that it sees.
	 * Reflection.Emit is not supported on all platforms, for example, UWP, Xamarin.iOS, and Xamarin.Android.
	 *
	 * - Elasticsearch.Net.DynamicResponse deserializes JSON arrays to List<object>. SimpleJson deserialized JSON arrays to object[],
	 * but Utf8Json deserializes them to List<object>. This change is preferred for allocation and performance reasons.
	 *
	 * - Utf8Json is much stricter when deserializing JSON object field names to C# POCO properties. With the internal Json.NET serializer
	 * in 6.x, JSON object field names would attempt to be matched with C# POCO property names first by an exact match, falling back to a
	 * case insensitive match. With Utf8Json in 7.x however, JSON object field names must match exactly the name configured for the
	 * C# POCO property name.
	 */
	public class GettingStarted
	{
		/**[float]
		 * ==== Injecting a new serializer
		 *
		 * You can inject a serializer that is isolated to only be called for the (de)serialization of `_source`, `_fields`, or
		 * wherever a user provided value is expected to be written and returned.
		 *
		 * Within NEST, we refer to this serializer as the `SourceSerializer`.
		 *
		 * Another serializer also exists within NEST known as the `RequestResponseSerializer`. This serializer is internal
		 * and is responsible for serializing the request and response types that are part of NEST.
		 *
		 * If `SourceSerializer` is left unconfigured, the internal `RequestResponseSerializer` is the `SourceSerializer` as well.
		 *
		 * Implementing `IElasticsearchSerializer` is technically enough to inject your own `SourceSerializer`
		 */
		public class VanillaSerializer : Serializer
		{
			public override T Deserialize<T>(Stream stream) => throw new NotImplementedException();

			public override object Deserialize(Type type, Stream stream) => throw new NotImplementedException();

			public override ValueTask<T> DeserializeAsync<T>(Stream stream, CancellationToken cancellationToken = default(CancellationToken)) =>
				throw new NotImplementedException();

			public override ValueTask<object> DeserializeAsync(Type type, Stream stream, CancellationToken cancellationToken = default(CancellationToken)) =>
				throw new NotImplementedException();

			public override void Serialize<T>(T data, Stream stream, SerializationFormatting formatting = SerializationFormatting.Indented) =>
				throw new NotImplementedException();

			public override Task SerializeAsync<T>(T data, Stream stream, SerializationFormatting formatting = SerializationFormatting.Indented,
				CancellationToken cancellationToken = default) => throw new NotImplementedException();
		}

		/**
		 * Hooking up the serializer is performed in the `ConnectionSettings` constructor
		 */
		public void TheNewContract()
		{
			var pool = new SingleNodePool(new Uri("http://localhost:9200"));
			var connectionSettings = new ElasticsearchClientSettings(
				pool,
				sourceSerializer: (builtin, settings) => new VanillaSerializer()); // <1> what the Func?
			var client = new ElasticsearchClient(connectionSettings);
		}

		/**
		 * If implementing `IElasticsearchSerializer` is enough, why do we need to provide an instance wrapped in a factory `Func`?
		 *
		 * There are various cases where you might have a POCO type that contains a NEST type as one of its properties. For example,
		 * consider if you want to use percolation; you need to store Elasticsearch queries as part of the `_source` of your document,
		 * which means you need to have a POCO that looks something like this
		 */
		public class MyPercolationDocument
		{
			public QueryContainer Query { get; set; }
			public string Category { get; set; }
		}

		/**
		 * A custom serializer would not know how to serialize `QueryContainer` or other NEST types that could appear as part of
		 * the `_source` of a document, therefore a custom serializer needs to have a way to delegate serialization of NEST types
		 * back to NEST's built-in serializer.
		 */

		/**
		 * ==== JsonNetSerializer
		 *
		 * We ship a separate {nuget}/NEST.JsonNetSerializer[NEST.JsonNetSerializer] package that helps in composing a custom `SourceSerializer`
		 * using `Json.NET`, that is smart enough to delegate the serialization of known NEST types back to the built-in
		 * `RequestResponseSerializer`. This package is also useful if
		 *
		 * . You want to control how your documents and values are stored and retrieved from Elasticsearch using `Json.NET`
		 * . You want to use `Newtonsoft.Json.Linq` types such as `JObject` within your documents
		 *
		 * The easiest way to hook this custom source serializer up is as follows
		 */
		public void DefaultJsonNetSerializer()
		{
			var pool = new SingleNodePool(new Uri("http://localhost:9200"));
			var connectionSettings =
				new ElasticsearchClientSettings(pool, sourceSerializer: JsonNetSerializer.Default);
			var client = new ElasticsearchClient(connectionSettings);
		}
		/**
		 * `JsonNetSerializer.Default` is just syntactic sugar for passing a delegate like
		 */

		public void DefaultJsonNetSerializerUnsugared()
		{
			var pool = new SingleNodePool(new Uri("http://localhost:9200"));
			var connectionSettings = new ElasticsearchClientSettings(
				pool,
				sourceSerializer: (builtin, settings) => new JsonNetSerializer(builtin, settings));
			var client = new ElasticsearchClient(connectionSettings);
		}
		/**
		 * `JsonNetSerializer`'s constructor takes several methods that allow you to control the `JsonSerializerSettings` and modify
		 * the contract resolver from `Json.NET`.
		 */

		public void DefaultJsonNetSerializerFactoryMethods()
		{
			var pool = new SingleNodePool(new Uri("http://localhost:9200"));
			var connectionSettings =
				new ElasticsearchClientSettings(pool, sourceSerializer: (builtin, settings) => new JsonNetSerializer(
					builtin, settings,
					() => new JsonSerializerSettings { NullValueHandling = NullValueHandling.Include },
					resolver => resolver.NamingStrategy = new SnakeCaseNamingStrategy()
				));
			var client = new ElasticsearchClient(connectionSettings);
		}

		/**
		 * ==== Derived serializers
		 *
		 * If you'd like to be more explicit, you can also derive from `ConnectionSettingsAwareSerializer`
		 * and override the `CreateJsonSerializerSettings` and `ModifyContractResolver` methods
		 */
		public class MyFirstCustomJsonNetSerializer : ConnectionSettingsAwareSerializer
		{
			public MyFirstCustomJsonNetSerializer(Serializer builtinSerializer, IElasticsearchClientSettings connectionSettings)
				: base(builtinSerializer, connectionSettings) { }

			protected override JsonSerializerSettings CreateJsonSerializerSettings() =>
				new JsonSerializerSettings
				{
					NullValueHandling = NullValueHandling.Include
				};

			protected override void ModifyContractResolver(ConnectionSettingsAwareContractResolver resolver) =>
				resolver.NamingStrategy = new SnakeCaseNamingStrategy();
		}
		/**
		 * Using `MyFirstCustomJsonNetSerializer`, we can serialize using
		 *
		 * - a Json.NET `NamingStrategy` that snake cases property names
		 * - `JsonSerializerSettings` that includes `null` properties
		 *
		 * without affecting how NEST's own types are serialized. Furthermore, because this serializer is aware of
		 * the built-in serializer, we can automatically inject a `JsonConverter` to handle
		 * known NEST types that could appear as part of the source, such as the aformentioned `QueryContainer`.
		 *
		 * Let's demonstrate with an example document type
		 */
		public class MyDocument
		{
			public int Id { get; set; }

			public string Name { get; set; }

			public string FilePath { get; set; }

			public int OwnerId { get; set; }

			public IEnumerable<MySubDocument> SubDocuments { get; set; }
		}

		public class MySubDocument
		{
			public string Name { get; set; }
		}

		/**
		 * Hooking up the serializer and using it is as follows
		 */
		[U] public void UsingJsonNetSerializer()
		{
			var pool = new SingleNodePool(new Uri("http://localhost:9200"));
			var connectionSettings = new ElasticsearchClientSettings(
				pool,
				connection: new InMemoryConnection(), // <1> an _in-memory_ connection is used here for example purposes. In your production application, you would use an `TransportClient` implementation that actually sends a request.
				sourceSerializer: (builtin, settings) => new MyFirstCustomJsonNetSerializer(builtin, settings))
				.DefaultIndex("my-index");

			//hide
			connectionSettings.DisableDirectStreaming();

			var client = new ElasticsearchClient(connectionSettings);

			/** Now, if we index an instance of our document type */
			var document = new MyDocument
			{
				Id = 1,
				Name = "My first document",
				OwnerId = 2
			};

			var indexResponse = client.Index(document, d => { });

			/** it serializes to */
			//json
			var expected = new
			{
				id = 1,
				name = "My first document",
				file_path = (string) null,
				owner_id = 2,
				sub_documents = (object) null
			};
			/**
			 * which adheres to the conventions of our configured `MyCustomJsonNetSerializer` serializer.
			 */

			// hide
			Expect(expected, preserveNullInExpected: true).FromRequest(indexResponse);
		}

		/** ==== Serializing Type Information
		 * Here's another example that implements a custom contract resolver. The custom contract resolver
		 * will include the type name within the serialized JSON for the document, which can be useful when
		 * returning covariant document types within a collection.
		 */
		public class MySecondCustomContractResolver : ConnectionSettingsAwareContractResolver
		{
			public MySecondCustomContractResolver(IElasticsearchClientSettings connectionSettings)
				: base(connectionSettings) { }

			protected override JsonContract CreateContract(Type objectType)
			{
				var contract = base.CreateContract(objectType);
				if (contract is JsonContainerContract containerContract)
				{
					if (containerContract.ItemTypeNameHandling == null)
						containerContract.ItemTypeNameHandling = TypeNameHandling.None;
				}

				return contract;
			}
		}

		//public class MySecondCustomJsonNetSerializer : ConnectionSettingsAwareSerializer
		//{
		//	public MySecondCustomJsonNetSerializer(Serializer builtinSerializer, IElasticsearchClientSettings connectionSettings)
		//		: base(builtinSerializer, connectionSettings) { }

		//	protected override JsonSerializerSettings CreateJsonSerializerSettings() =>
		//		new JsonSerializerSettings
		//		{
		//			TypeNameHandling = TypeNameHandling.All,
		//			NullValueHandling = NullValueHandling.Ignore,
		//			TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple
		//		};

		//	protected override ConnectionSettingsAwareContractResolver CreateContractResolver() =>
		//		new MySecondCustomContractResolver(ConnectionSettings); // <1> override the contract resolver
		//}

		///**
		// * Now, hooking up this serializer
  //       */
		//[U] public void MySecondJsonNetSerializer()
		//{
		//	var pool = new SingleNodePool(new Uri("http://localhost:9200"));
		//	var connectionSettings = new ElasticsearchClientSettings(
		//			pool,
		//			connection: new InMemoryConnection(),
		//			sourceSerializer: (builtin, settings) => new MySecondCustomJsonNetSerializer(builtin, settings))
		//		.DefaultIndex("my-index");

		//	//hide
		//	connectionSettings.DisableDirectStreaming();

		//	var client = new ElasticsearchClient(connectionSettings);

		//	/** and indexing an instance of our document type */
		//	var document = new MyDocument
		//	{
		//		Id = 1,
		//		Name = "My first document",
		//		OwnerId = 2,
		//		SubDocuments = new []
		//		{
		//			new MySubDocument { Name = "my first sub document" },
		//			new MySubDocument { Name = "my second sub document" },
		//		}
		//	};

		//	//ar ndexResponse = client.IndexDocument(document);
		//	var indexResponse = client.Index(document, d => { });

		//	/** serializes to */
		//	//json
		//	var expected = new JObject
		//	{
		//		{ "$type", "Tests.ClientConcepts.HighLevel.Serialization.GettingStarted+MyDocument, Tests" },
		//		{ "id", 1 },
		//		{ "name", "My first document" },
		//		{ "ownerId", 2 },
		//		{ "subDocuments", new JArray
		//			{
		//				new JObject { { "name", "my first sub document" } },
		//				new JObject { { "name", "my second sub document" } },
		//			}
		//		}
		//	};
		//	/**
		//	 * the type information is serialized for the outer `MyDocument` instance, but not for each
		//	 * `MySubDocument` instance in the `SubDocuments` collection.
		//	 *
		//	 * When implementing a custom contract resolver derived from `ConnectionSettingsAwareContractResolver`,
		//	 * be careful not to change the behaviour of the resolver for NEST types; doing so will result in
		//	 * unexpected behaviour.
		//	 *
		//	 * [WARNING]
		//	 * --
		//	 * Per the https://www.newtonsoft.com/json/help/html/T_Newtonsoft_Json_TypeNameHandling.htm[Json.NET documentation on TypeNameHandling],
		//	 * it should be used with caution when your application deserializes JSON from an external source.
		//	 * --
		//	 */

		//	// hide
		//	Expect(expected).FromRequest(indexResponse);
		//}
	}
}
