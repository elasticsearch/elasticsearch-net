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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ilm.ExplainLifecycle
{
	public partial class LifecycleExplains : IsADictionaryBase<string, ILifecycleExplain>
	{
		public LifecycleExplains()
		{
		}

		public LifecycleExplains(IDictionary<string, ILifecycleExplain> container) : base(container)
		{
		}

		public void Add(string name, ILifecycleExplain lifecycleexplains) => BackingDictionary.Add(name, lifecycleexplains);
	}

	internal sealed partial class LifecycleExplainInterfaceConverter
	{
		private static ILifecycleExplain DeserializeVariant(string type, ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			switch (type)
			{
				default:
					throw new JsonException("Encounted an unknown variant type which could not be deserialised.");
			}
		}
	}

	public partial interface ILifecycleExplain
	{
		public bool Managed { get; }
	}
}