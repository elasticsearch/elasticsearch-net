// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Specification.TasksApi;

// ReSharper disable once CheckNamespace
// ReSharper disable RedundantTypeArgumentsOfMethod
namespace Nest.Specification.TasksApi
{
	///<summary>
	/// Tasks APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticClient.Tasks"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class TasksNamespace : NamespacedClientProxy
	{
		internal TasksNamespace(ElasticClient client): base(client)
		{
		}

		/// <summary>
		/// <c>POST</c> request to the <c>tasks.cancel</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</a>
		/// </summary>
		public CancelTasksResponse Cancel(Func<CancelTasksDescriptor, ICancelTasksRequest> selector = null) => Cancel(selector.InvokeOrDefault(new CancelTasksDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>tasks.cancel</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</a>
		/// </summary>
		public Task<CancelTasksResponse> CancelAsync(Func<CancelTasksDescriptor, ICancelTasksRequest> selector = null, CancellationToken ct = default) => CancelAsync(selector.InvokeOrDefault(new CancelTasksDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>tasks.cancel</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</a>
		/// </summary>
		public CancelTasksResponse Cancel(ICancelTasksRequest request) => DoRequest<ICancelTasksRequest, CancelTasksResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>tasks.cancel</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</a>
		/// </summary>
		public Task<CancelTasksResponse> CancelAsync(ICancelTasksRequest request, CancellationToken ct = default) => DoRequestAsync<ICancelTasksRequest, CancelTasksResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>tasks.get</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</a>
		/// </summary>
		public GetTaskResponse GetTask(TaskId taskId, Func<GetTaskDescriptor, IGetTaskRequest> selector = null) => GetTask(selector.InvokeOrDefault(new GetTaskDescriptor(taskId: taskId)));
		/// <summary>
		/// <c>GET</c> request to the <c>tasks.get</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</a>
		/// </summary>
		public Task<GetTaskResponse> GetTaskAsync(TaskId taskId, Func<GetTaskDescriptor, IGetTaskRequest> selector = null, CancellationToken ct = default) => GetTaskAsync(selector.InvokeOrDefault(new GetTaskDescriptor(taskId: taskId)), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>tasks.get</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</a>
		/// </summary>
		public GetTaskResponse GetTask(IGetTaskRequest request) => DoRequest<IGetTaskRequest, GetTaskResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>tasks.get</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</a>
		/// </summary>
		public Task<GetTaskResponse> GetTaskAsync(IGetTaskRequest request, CancellationToken ct = default) => DoRequestAsync<IGetTaskRequest, GetTaskResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>tasks.list</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</a>
		/// </summary>
		public ListTasksResponse List(Func<ListTasksDescriptor, IListTasksRequest> selector = null) => List(selector.InvokeOrDefault(new ListTasksDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>tasks.list</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</a>
		/// </summary>
		public Task<ListTasksResponse> ListAsync(Func<ListTasksDescriptor, IListTasksRequest> selector = null, CancellationToken ct = default) => ListAsync(selector.InvokeOrDefault(new ListTasksDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>tasks.list</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</a>
		/// </summary>
		public ListTasksResponse List(IListTasksRequest request) => DoRequest<IListTasksRequest, ListTasksResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>tasks.list</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</a>
		/// </summary>
		public Task<ListTasksResponse> ListAsync(IListTasksRequest request, CancellationToken ct = default) => DoRequestAsync<IListTasksRequest, ListTasksResponse>(request, request.RequestParameters, ct);
	}
}