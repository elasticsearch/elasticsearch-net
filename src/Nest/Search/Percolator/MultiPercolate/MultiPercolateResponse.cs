﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Elasticsearch.Net;
using Newtonsoft.Json;

namespace Nest
{
	[JsonObject(MemberSerialization.OptIn)]
	[Obsolete("Deprecated. Will be removed in the next major release. Use a percolate query with multi search api")]
	public interface IMultiPercolateResponse : IResponse
	{
		IEnumerable<PercolateResponse> Responses { get; }
	}

	[JsonObject(MemberSerialization.OptIn)]
	[Obsolete("Deprecated. Will be removed in the next major release. Use a percolate query with multi search api")]
	public class MultiPercolateResponse : ResponseBase, IMultiPercolateResponse
	{
		public override bool IsValid => base.IsValid && Responses.All(r => r.IsValid);

		public IEnumerable<PercolateResponse> Responses => _allResponses();

		[JsonProperty("responses")]
		internal IReadOnlyCollection<PercolateResponse> AllResponses { get; set; } = EmptyReadOnly<PercolateResponse>.Collection;

		IEnumerable<PercolateResponse> IMultiPercolateResponse.Responses => Responses;

		protected override void DebugIsValid(StringBuilder sb)
		{
			sb.AppendLine($"# Invalid percolations (inspect individual response.DebugInformation for more detail):");
			foreach (var i in AllResponses.Select((item, i) => new { item, i }).Where(i => !i.item.IsValid))
				sb.AppendLine($"  search[{i.i}]: {i.item}");
		}

		private IEnumerable<PercolateResponse> _allResponses()
		{
			foreach (var r in AllResponses)
			{
				IBodyWithApiCallDetails d = r;
				d.ApiCall = ApiCall;
				yield return r;
			}
		}
	}
}
