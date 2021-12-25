// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch
{
	public class BulkUpdateOperationWithScript : BulkUpdateOperationBase
	{
		public BulkUpdateOperationWithScript(Id id, ScriptBase script)
		{
			Id = id;
			Script = script;
		}

		public BulkUpdateOperationWithScript(Id id, IndexName index, ScriptBase script)
		{
			Id = id;
			Index = index;
			Script = script;
		}

		[JsonIgnore]
		public ScriptBase Script { get; set; }

		protected override string Operation => "update";

		protected override void BeforeSerialize(IElasticsearchClientSettings settings)
		{
		}

		protected override void WriteOperation(Utf8JsonWriter writer, JsonSerializerOptions options = null) => JsonSerializer.Serialize<BulkUpdateOperationWithScript>(writer, this, options);

		protected override object GetBody() => new ScriptedBulkUpdateBody { Script = Script };
	}

	public sealed class BulkUpdateOperationWithScript<TDocument> : BulkUpdateOperationWithScript
	{
		public BulkUpdateOperationWithScript(TDocument upsert, Id id, ScriptBase script) : base(id, script) => Upsert = upsert;

		public BulkUpdateOperationWithScript(TDocument upsert, Id id, IndexName index, ScriptBase script) : base(id, index, script) => Upsert = upsert;

		[JsonIgnore]
		public TDocument Upsert { get; set; }

		protected override object GetBody() => new ScriptedBulkUpdateBody<TDocument> { Script = Script, Upsert = Upsert };
	}
}
