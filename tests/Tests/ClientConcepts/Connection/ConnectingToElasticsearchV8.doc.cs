// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System;
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Elasticsearch.Net;
using Nest;

namespace Tests.ClientConcepts.Connection
{
	public class ConnectingToElasticsearchV8
	{
		/**[[connecting-to-elasticsearch-v8]]
		 * === Connecting to Elasticsearch v8.x using the v7.17.x client
		 *
		 * We recommend using the latest client with a corresponding major version when connecting to Elasticsearch. Until the v8 .NET client is 
		 * generally available, you may use the v7.17.x client to communicate with a 8.x Elasticsearch cluster. There are several important considerations 
		 * regarding configuration. Failure to correctly configure the client to connect using the security features enabled on the server will result in 
		 * an exception being thrown during the initial client communication that will prevent further use of the client.
		 *
		 * :security: https://www.elastic.co/guide/en/elasticsearch/reference/8.1/configuring-stack-security.html
		 * :security-clients: https://www.elastic.co/guide/en/elasticsearch/reference/8.1/configuring-stack-security.html#_connect_clients_to_elasticsearch_5
		 *
		 * ==== Security and Certificates
		 * Newly installed Elasticsearch v8 clusters start with security configuration {security}[enabled automatically by default]. As a result, 
		 * a certificate authority and certificate is created for secure HTTPS communication. Additionally, an `elastic` user is created with a
		 * unique, secure password. Elasticsearch logs details of the security configuration when it first starts, enabling the collection of a
		 * certificate fingerprint, along with the password configured for the `elastic` user. In a development environment, you will need to collect
		 * these pieces of information, required to configure the client to securely communicate with the server. The 
		 * {security-clients}[Elasticsearch documentation] provides commands which may also be used to retrieve this information after the cluster has started.
		 * 
		 * [[ca-fingerprint]]
		 * ===== Applying the CA Fingerprint
		 *
		 * The simplest configuration option during development is to connect to the server using the CA fingerprint logged by the server at initial startup. 
		 * The fingerprint can be set by calling the `CertificateFingerprint` method on a `ConnectionSettings` instance.
		 */
		[U] public void CertificateFingerprint()
		{
			var pool = new SingleNodeConnectionPool(new Uri("http://localhost:9200"));

			var settings = new ConnectionSettings(pool)
				.CertificateFingerprint("94:75:CE:4F:EB:05:32:83:40:B8:18:BB:79:01:7B:E0:F0:B6:C3:01:57:DB:4D:F5:D8:B8:A6:BA:BD:6D:C5:C4");

			var client = new ElasticClient(settings);
		}

		/**
		 * If preferred, you may also configure the client to work with the certificate in the usual way. 
		 * See <<working-with-certificates, Working with certificates>> for further details.

		 * [[basic-authentication]]
		 * ===== Basic Authentication
		 * 
		 * Additionally, you will need to provide the basic authentication credentials for a user account configured on the server. During development, 
		 * you may begin by using the `elastic` user and the automatically generated password captured from the server logs.
		 */
		[U] public void BasicAuth()
		{
			var pool = new SingleNodeConnectionPool(new Uri("http://localhost:9200"));

			var settings = new ConnectionSettings(pool)
				.CertificateFingerprint("94:75:CE:4F:EB:05:32:83:40:B8:18:BB:79:01:7B:E0:F0:B6:C3:01:57:DB:4D:F5:D8:B8:A6:BA:BD:6D:C5:C4")
				.BasicAuthentication("elastic", "password");

			var client = new ElasticClient(settings);
		}
		
		/**
		 * [[enabling-compatibility-mode]]
		 * ==== Enabling Compatibility Mode
		 *
		 * The Elasticsearch server version 8.0 is introducing a new compatibility mode that allows you a smoother upgrade 
		 * experience from v7 to v8. In a nutshell, you can use the latest 7.x Elasticsearch client with an 8.x Elasticsearch 
		 * server, giving more room to coordinate the upgrade of your codebase to the next major version. 

		 * If you want to leverage this functionality, please make sure that you are using the latest 7.x client and set 
		 * the environment variable `ELASTIC_CLIENT_APIVERSIONING` to `true`. The client is handling the rest internally. 
		 *
		 * Compatibility mode may also be enabled directly on `ConnectionSettings` by calling `EnableApiVersioningHeader`.
		 */
		[U] public void CompatibilityMode()
		{
			var pool = new SingleNodeConnectionPool(new Uri("http://localhost:9200"));

			var settings = new ConnectionSettings(pool)
				.CertificateFingerprint("94:75:CE:4F:EB:05:32:83:40:B8:18:BB:79:01:7B:E0:F0:B6:C3:01:57:DB:4D:F5:D8:B8:A6:BA:BD:6D:C5:C4")
				.BasicAuthentication("elastic", "password")
				.EnableApiVersioningHeader();

			var client = new ElasticClient(settings);
		}
	}
}