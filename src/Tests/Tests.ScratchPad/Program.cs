﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Running;
using Elasticsearch.Net;
using Elasticsearch.Net.Diagnostics;
using Nest;

namespace Tests.ScratchPad
{
	public class Program
	{
		private class ListenerObserver : IObserver<DiagnosticListener>
		{
			public void OnCompleted() => Console.WriteLine("Completed");

			public void OnError(Exception error) => Console.Error.WriteLine(error.Message);

			public void OnNext(DiagnosticListener value)
			{
				void WriteToConsole<T>(string eventName, T data)
				{
					var a = Activity.Current;
					Console.WriteLine($"{eventName?.PadRight(30)} {a.Id?.PadRight(32)} {a.ParentId?.PadRight(32)} {data?.ToString().PadRight(10)}");
				}
				if (value.Name == DiagnosticSources.AuditTrailEvents.SourceName)
					value.Subscribe(new AuditDiagnosticListener(v => WriteToConsole(v.EventName, v.Audit)));
				
				if (value.Name == DiagnosticSources.RequestPipeline.SourceName)
					value.Subscribe(new RequestPipelineDiagnosticListener(
						v => WriteToConsole(v.EventName, v.RequestData),
						v => WriteToConsole(v.EventName, v.Response))
					);
				
				if (value.Name == DiagnosticSources.HttpConnection.SourceName)
					value.Subscribe(new HttpConnectionDiagnosticListener(
						v => WriteToConsole(v.EventName, v.RequestData),
						v => WriteToConsole(v.EventName, v.StatusCode)
					));
				
				if (value.Name == DiagnosticSources.Serializer.SourceName)
					value.Subscribe(new SerializerDiagnosticListener(v => WriteToConsole(v.EventName, v.Registration)));
			}
		}

		private static async Task Main(string[] args)
		{
			DiagnosticListener.AllListeners.Subscribe(new ListenerObserver());
				
			using (var node = new Elastic.Managed.Ephemeral.EphemeralCluster("7.0.0"))
			{
				node.Start();

				var settings = new ConnectionSettings(new SniffingConnectionPool(new[] { node.NodesUris().First() }))
					.SniffOnStartup();
				var client = new ElasticClient(settings);

				var x = client.Search<object>(s=>s.AllIndices());

				await Task.Delay(TimeSpan.FromSeconds(7));
				
				Console.WriteLine(new string('-', Console.WindowWidth - 1));
				
				var y = client.Search<object>(s=>s.Index("does-not-exist"));
				
				await Task.Delay(TimeSpan.FromSeconds(7));


			}
		}

		private static void Bench<TBenchmark>() where TBenchmark : RunBase => BenchmarkRunner.Run<TBenchmark>();

		private static void Run<TRun>() where TRun : RunBase, new()
		{
			var runner = new TRun { IsNotBenchmark = true };
			runner.GlobalSetup();
			runner.Run();
		}

		private static void RunCreateOnce<TRun>() where TRun : RunBase, new()
		{
			var runner = new TRun { IsNotBenchmark = true };
			runner.GlobalSetup();
			runner.RunCreateOnce();
		}
	}
}
