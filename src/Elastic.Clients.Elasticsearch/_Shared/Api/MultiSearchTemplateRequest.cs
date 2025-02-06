// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;

namespace Elastic.Clients.Elasticsearch;

public partial class MultiSearchTemplateResponse<TDocument>
{
	public override bool IsValidResponse => base.IsValidResponse && (Responses?.All(b => b.Item1 is not null && b.Item1.Status == 200) ?? true);

	[JsonIgnore]
	public int TotalResponses => Responses.HasAny() ? Responses.Count() : 0;
}

public sealed partial class MultiSearchTemplateRequestDescriptor<TDocument>
{
	internal override void BeforeRequest() => TypedKeys(true);
}

public sealed partial class MultiSearchTemplateRequestDescriptor
{
	internal override void BeforeRequest() => TypedKeys(true);
}

public partial class MultiSearchTemplateRequest : IStreamSerializable
{
	internal override void BeforeRequest() => TypedKeys = true;

	void IStreamSerializable.Serialize(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (SearchTemplates is null)
			return;
		foreach (var item in SearchTemplates)
		{
			if (item is IStreamSerializable serializable)
				serializable.Serialize(stream, settings, formatting);
		}
	}

	async Task IStreamSerializable.SerializeAsync(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (SearchTemplates is null)
			return;
		foreach (var item in SearchTemplates)
		{
			if (item is IStreamSerializable serializable)
				await serializable.SerializeAsync(stream, settings, formatting).ConfigureAwait(false);
		}
	}
}
