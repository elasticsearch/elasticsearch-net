/*
 * Licensed to Elasticsearch B.V. under one or more contributor
 * license agreements. See the NOTICE file distributed with
 * this work for additional information regarding copyright
 * ownership. Elasticsearch B.V. licenses this file to you under
 * the Apache License, Version 2.0 (the "License"); you may
 * not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.ComponentModel;
using Elastic.Transport;
using Elastic.Transport.Products;
using Elastic.Transport.Products.Elasticsearch;

namespace Elasticsearch.Net
{
	/// <inheritdoc cref="IConnectionConfigurationValues" />
	public class ConnectionConfiguration : ConnectionConfigurationBase<ConnectionConfiguration>
	{
		/// <summary>
		/// The default user agent for Elasticsearch.Net
		/// </summary>
		public static readonly UserAgent DefaultUserAgent = Elastic.Transport.UserAgent.Create("elasticsearch-net", typeof(ITransportConfiguration));

		public ConnectionConfiguration(Uri uri = null)
			: this(new SingleNodeConnectionPool(uri ?? new Uri("http://localhost:9200"))) { }

		public ConnectionConfiguration(InMemoryConnection connection)
			: this(new SingleNodeConnectionPool(new Uri("http://localhost:9200")), connection) { }

		/// <summary>
		/// Sets up the client to communicate to Elastic Cloud using <paramref name="cloudId"/>,
		/// <para><see cref="CloudConnectionPool"/> documentation for more information on how to obtain your Cloud Id</para>
		/// </summary>
		public ConnectionConfiguration(string cloudId, IAuthenticationHeader credentials) : this(new CloudConnectionPool(cloudId, credentials)) { }

		public ConnectionConfiguration(IConnectionPool connectionPool) : this(connectionPool, null, null) { }

		public ConnectionConfiguration(IConnectionPool connectionPool, IConnection connection) : this(connectionPool, connection, null) { }

		public ConnectionConfiguration(IConnectionPool connectionPool, ITransportSerializer serializer) : this(connectionPool, null, serializer) { }

		public ConnectionConfiguration(IConnectionPool connectionPool, IConnection connection, ITransportSerializer serializer)
			: base(connectionPool, connection, serializer) { }

	}

	/// <inheritdoc cref="IConnectionConfigurationValues" />
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public abstract class ConnectionConfigurationBase<TConnectionConfiguration> : TransportConfigurationBase<TConnectionConfiguration>, IConnectionConfigurationValues
		where TConnectionConfiguration : ConnectionConfigurationBase<TConnectionConfiguration>, IConnectionConfigurationValues
	{
		protected ConnectionConfigurationBase(IConnectionPool connectionPool, IConnection connection, ITransportSerializer serializer,
			IProductRegistration registration = null)
			: base(connectionPool, connection, serializer, registration ?? ElasticsearchProductRegistration.Default) =>
			UserAgent(ConnectionConfiguration.DefaultUserAgent);

		private bool _includeServerStackTraceOnError;
		bool IConnectionConfigurationValues.IncludeServerStackTraceOnError => _includeServerStackTraceOnError;

		public override TConnectionConfiguration EnableDebugMode(Action<IApiCallDetails> onRequestCompleted = null) =>
			base.EnableDebugMode(onRequestCompleted)
				.PrettyJson()
				.IncludeServerStackTraceOnError();

		/// <summary>
		/// Forces all requests to have ?pretty=true querystring parameter appended,
		/// causing Elasticsearch to return formatted JSON.
		/// Defaults to <c>false</c>
		/// </summary>
		public override TConnectionConfiguration PrettyJson(bool b = true) =>
			base.PrettyJson(b).UpdateGlobalQueryString("pretty", "true", b);

		/// <summary>
		/// Forces all requests to have ?error_trace=true querystring parameter appended,
		/// causing Elasticsearch to return stack traces as part of serialized exceptions
		/// Defaults to <c>false</c>
		/// </summary>
		public TConnectionConfiguration IncludeServerStackTraceOnError(bool b = true) => Assign(b, (a, v) =>
		{
			a._includeServerStackTraceOnError = true;
			const string key = "error_trace";
			UpdateGlobalQueryString(key, "true", v);
		});


	}
}
