// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public class IngestNamespace : NamespacedClientProxy
	{
		internal IngestNamespace(ElasticsearchClient client) : base(client)
		{
		}

		public IngestDeletePipelineResponse DeletePipeline(IngestDeletePipelineRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IngestDeletePipelineRequest, IngestDeletePipelineResponse>(request);
		}

		public Task<IngestDeletePipelineResponse> DeletePipelineAsync(IngestDeletePipelineRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IngestDeletePipelineRequest, IngestDeletePipelineResponse>(request, cancellationToken);
		}

		public IngestDeletePipelineResponse DeletePipeline(Elastic.Clients.Elasticsearch.Id id, Action<IngestDeletePipelineRequestDescriptor> configureRequest = null)
		{
			var descriptor = new IngestDeletePipelineRequestDescriptor(id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IngestDeletePipelineRequestDescriptor, IngestDeletePipelineResponse>(descriptor);
		}

		public IngestDeletePipelineResponse DeletePipeline<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<IngestDeletePipelineRequestDescriptor<TDocument>> configureRequest = null)
		{
			var descriptor = new IngestDeletePipelineRequestDescriptor<TDocument>(id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IngestDeletePipelineRequestDescriptor<TDocument>, IngestDeletePipelineResponse>(descriptor);
		}

		public Task<IngestDeletePipelineResponse> DeletePipelineAsync(Elastic.Clients.Elasticsearch.Id id, Action<IngestDeletePipelineRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new IngestDeletePipelineRequestDescriptor(id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IngestDeletePipelineRequestDescriptor, IngestDeletePipelineResponse>(descriptor);
		}

		public Task<IngestDeletePipelineResponse> DeletePipelineAsync<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<IngestDeletePipelineRequestDescriptor<TDocument>> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new IngestDeletePipelineRequestDescriptor<TDocument>(id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IngestDeletePipelineRequestDescriptor<TDocument>, IngestDeletePipelineResponse>(descriptor);
		}

		public IngestGeoIpStatsResponse GeoIpStats(IngestGeoIpStatsRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IngestGeoIpStatsRequest, IngestGeoIpStatsResponse>(request);
		}

		public Task<IngestGeoIpStatsResponse> GeoIpStatsAsync(IngestGeoIpStatsRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IngestGeoIpStatsRequest, IngestGeoIpStatsResponse>(request, cancellationToken);
		}

		public IngestGeoIpStatsResponse GeoIpStats(Action<IngestGeoIpStatsRequestDescriptor> configureRequest = null)
		{
			var descriptor = new IngestGeoIpStatsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IngestGeoIpStatsRequestDescriptor, IngestGeoIpStatsResponse>(descriptor);
		}

		public Task<IngestGeoIpStatsResponse> GeoIpStatsAsync(Action<IngestGeoIpStatsRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new IngestGeoIpStatsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IngestGeoIpStatsRequestDescriptor, IngestGeoIpStatsResponse>(descriptor);
		}

		public IngestGetPipelineResponse GetPipeline(IngestGetPipelineRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IngestGetPipelineRequest, IngestGetPipelineResponse>(request);
		}

		public Task<IngestGetPipelineResponse> GetPipelineAsync(IngestGetPipelineRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IngestGetPipelineRequest, IngestGetPipelineResponse>(request, cancellationToken);
		}

		public IngestGetPipelineResponse GetPipeline(Action<IngestGetPipelineRequestDescriptor> configureRequest = null)
		{
			var descriptor = new IngestGetPipelineRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IngestGetPipelineRequestDescriptor, IngestGetPipelineResponse>(descriptor);
		}

		public IngestGetPipelineResponse GetPipeline<TDocument>(Action<IngestGetPipelineRequestDescriptor<TDocument>> configureRequest = null)
		{
			var descriptor = new IngestGetPipelineRequestDescriptor<TDocument>();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IngestGetPipelineRequestDescriptor<TDocument>, IngestGetPipelineResponse>(descriptor);
		}

		public Task<IngestGetPipelineResponse> GetPipelineAsync(Action<IngestGetPipelineRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new IngestGetPipelineRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IngestGetPipelineRequestDescriptor, IngestGetPipelineResponse>(descriptor);
		}

		public Task<IngestGetPipelineResponse> GetPipelineAsync<TDocument>(Action<IngestGetPipelineRequestDescriptor<TDocument>> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new IngestGetPipelineRequestDescriptor<TDocument>();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IngestGetPipelineRequestDescriptor<TDocument>, IngestGetPipelineResponse>(descriptor);
		}

		public IngestProcessorGrokResponse ProcessorGrok(IngestProcessorGrokRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IngestProcessorGrokRequest, IngestProcessorGrokResponse>(request);
		}

		public Task<IngestProcessorGrokResponse> ProcessorGrokAsync(IngestProcessorGrokRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IngestProcessorGrokRequest, IngestProcessorGrokResponse>(request, cancellationToken);
		}

		public IngestProcessorGrokResponse ProcessorGrok(Action<IngestProcessorGrokRequestDescriptor> configureRequest = null)
		{
			var descriptor = new IngestProcessorGrokRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IngestProcessorGrokRequestDescriptor, IngestProcessorGrokResponse>(descriptor);
		}

		public Task<IngestProcessorGrokResponse> ProcessorGrokAsync(Action<IngestProcessorGrokRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new IngestProcessorGrokRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IngestProcessorGrokRequestDescriptor, IngestProcessorGrokResponse>(descriptor);
		}

		public IngestPutPipelineResponse PutPipeline(IngestPutPipelineRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IngestPutPipelineRequest, IngestPutPipelineResponse>(request);
		}

		public Task<IngestPutPipelineResponse> PutPipelineAsync(IngestPutPipelineRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IngestPutPipelineRequest, IngestPutPipelineResponse>(request, cancellationToken);
		}

		public IngestPutPipelineResponse PutPipeline(Elastic.Clients.Elasticsearch.Id id, Action<IngestPutPipelineRequestDescriptor> configureRequest = null)
		{
			var descriptor = new IngestPutPipelineRequestDescriptor(id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IngestPutPipelineRequestDescriptor, IngestPutPipelineResponse>(descriptor);
		}

		public IngestPutPipelineResponse PutPipeline<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<IngestPutPipelineRequestDescriptor<TDocument>> configureRequest = null)
		{
			var descriptor = new IngestPutPipelineRequestDescriptor<TDocument>(id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IngestPutPipelineRequestDescriptor<TDocument>, IngestPutPipelineResponse>(descriptor);
		}

		public Task<IngestPutPipelineResponse> PutPipelineAsync(Elastic.Clients.Elasticsearch.Id id, Action<IngestPutPipelineRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new IngestPutPipelineRequestDescriptor(id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IngestPutPipelineRequestDescriptor, IngestPutPipelineResponse>(descriptor);
		}

		public Task<IngestPutPipelineResponse> PutPipelineAsync<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<IngestPutPipelineRequestDescriptor<TDocument>> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new IngestPutPipelineRequestDescriptor<TDocument>(id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IngestPutPipelineRequestDescriptor<TDocument>, IngestPutPipelineResponse>(descriptor);
		}

		public IngestSimulateResponse Simulate(IngestSimulateRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IngestSimulateRequest, IngestSimulateResponse>(request);
		}

		public Task<IngestSimulateResponse> SimulateAsync(IngestSimulateRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IngestSimulateRequest, IngestSimulateResponse>(request, cancellationToken);
		}

		public IngestSimulateResponse Simulate(Action<IngestSimulateRequestDescriptor> configureRequest = null)
		{
			var descriptor = new IngestSimulateRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IngestSimulateRequestDescriptor, IngestSimulateResponse>(descriptor);
		}

		public IngestSimulateResponse Simulate<TDocument>(Action<IngestSimulateRequestDescriptor<TDocument>> configureRequest = null)
		{
			var descriptor = new IngestSimulateRequestDescriptor<TDocument>();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IngestSimulateRequestDescriptor<TDocument>, IngestSimulateResponse>(descriptor);
		}

		public Task<IngestSimulateResponse> SimulateAsync(Action<IngestSimulateRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new IngestSimulateRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IngestSimulateRequestDescriptor, IngestSimulateResponse>(descriptor);
		}

		public Task<IngestSimulateResponse> SimulateAsync<TDocument>(Action<IngestSimulateRequestDescriptor<TDocument>> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new IngestSimulateRequestDescriptor<TDocument>();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IngestSimulateRequestDescriptor<TDocument>, IngestSimulateResponse>(descriptor);
		}
	}
}