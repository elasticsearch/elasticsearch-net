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
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public sealed class GetRequestParameters : RequestParameters<GetRequestParameters>
	{
		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public bool? Realtime { get => Q<bool?>("realtime"); set => Q("realtime", value); }

		[JsonIgnore]
		public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.SourceConfigParam? Source { get => Q<Elastic.Clients.Elasticsearch.SourceConfigParam?>("_source"); set => Q("_source", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_includes"); set => Q("_source_includes", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? StoredFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("stored_fields"); set => Q("stored_fields", value); }

		[JsonIgnore]
		public long? Version { get => Q<long?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.VersionType?>("version_type"); set => Q("version_type", value); }
	}

	public sealed partial class GetRequest : PlainRequestBase<GetRequestParameters>
	{
		public GetRequest(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceGet;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public bool? Realtime { get => Q<bool?>("realtime"); set => Q("realtime", value); }

		[JsonIgnore]
		public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.SourceConfigParam? Source { get => Q<Elastic.Clients.Elasticsearch.SourceConfigParam?>("_source"); set => Q("_source", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_includes"); set => Q("_source_includes", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? StoredFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("stored_fields"); set => Q("stored_fields", value); }

		[JsonIgnore]
		public long? Version { get => Q<long?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.VersionType?>("version_type"); set => Q("version_type", value); }
	}

	public sealed partial class GetRequestDescriptor<TDocument> : RequestDescriptorBase<GetRequestDescriptor<TDocument>, GetRequestParameters>
	{
		internal GetRequestDescriptor(Action<GetRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public GetRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}

		public GetRequestDescriptor(TDocument document) : this(typeof(TDocument), Elasticsearch.Id.From(document))
		{
		}

		public GetRequestDescriptor(TDocument document, IndexName index, Id id) : this(index, id)
		{
		}

		public GetRequestDescriptor(TDocument document, IndexName index) : this(index, Elasticsearch.Id.From(document))
		{
		}

		public GetRequestDescriptor(TDocument document, Id id) : this(typeof(TDocument), id)
		{
		}

		public GetRequestDescriptor(Id id) : this(typeof(TDocument), id)
		{
		}

		internal GetRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceGet;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public GetRequestDescriptor<TDocument> Source(Elastic.Clients.Elasticsearch.SourceConfigParam? source) => Qs("_source", source);
		public GetRequestDescriptor<TDocument> SourceExcludes(Elastic.Clients.Elasticsearch.Fields? sourceExcludes) => Qs("_source_excludes", sourceExcludes);
		public GetRequestDescriptor<TDocument> SourceIncludes(Elastic.Clients.Elasticsearch.Fields? sourceIncludes) => Qs("_source_includes", sourceIncludes);
		public GetRequestDescriptor<TDocument> Preference(string? preference) => Qs("preference", preference);
		public GetRequestDescriptor<TDocument> Realtime(bool? realtime = true) => Qs("realtime", realtime);
		public GetRequestDescriptor<TDocument> Refresh(bool? refresh = true) => Qs("refresh", refresh);
		public GetRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
		public GetRequestDescriptor<TDocument> StoredFields(Elastic.Clients.Elasticsearch.Fields? storedFields) => Qs("stored_fields", storedFields);
		public GetRequestDescriptor<TDocument> Version(long? version) => Qs("version", version);
		public GetRequestDescriptor<TDocument> VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType) => Qs("version_type", versionType);
		public GetRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
		{
			RouteValues.Required("id", id);
			return Self;
		}

		public GetRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName index)
		{
			RouteValues.Required("index", index);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}

	public sealed partial class GetRequestDescriptor : RequestDescriptorBase<GetRequestDescriptor, GetRequestParameters>
	{
		internal GetRequestDescriptor(Action<GetRequestDescriptor> configure) => configure.Invoke(this);
		public GetRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}

		internal GetRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceGet;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public GetRequestDescriptor Source(Elastic.Clients.Elasticsearch.SourceConfigParam? source) => Qs("_source", source);
		public GetRequestDescriptor SourceExcludes(Elastic.Clients.Elasticsearch.Fields? sourceExcludes) => Qs("_source_excludes", sourceExcludes);
		public GetRequestDescriptor SourceIncludes(Elastic.Clients.Elasticsearch.Fields? sourceIncludes) => Qs("_source_includes", sourceIncludes);
		public GetRequestDescriptor Preference(string? preference) => Qs("preference", preference);
		public GetRequestDescriptor Realtime(bool? realtime = true) => Qs("realtime", realtime);
		public GetRequestDescriptor Refresh(bool? refresh = true) => Qs("refresh", refresh);
		public GetRequestDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
		public GetRequestDescriptor StoredFields(Elastic.Clients.Elasticsearch.Fields? storedFields) => Qs("stored_fields", storedFields);
		public GetRequestDescriptor Version(long? version) => Qs("version", version);
		public GetRequestDescriptor VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType) => Qs("version_type", versionType);
		public GetRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
		{
			RouteValues.Required("id", id);
			return Self;
		}

		public GetRequestDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index)
		{
			RouteValues.Required("index", index);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}