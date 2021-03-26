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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using System;
using System.Text.Json.Serialization;
using Elastic.Transport;

#nullable restore
namespace Nest
{
	[JsonInterfaceConverter(typeof(InterfaceConverter<IDeleteRollupJobRequest, DeleteRollupJobRequest>))]
	public interface IDeleteRollupJobRequest : IRequest<DeleteRollupJobRequestParameters>
	{
	}

	public class DeleteRollupJobRequest : PlainRequestBase<DeleteRollupJobRequestParameters>, IDeleteRollupJobRequest
	{
		protected IDeleteRollupJobRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.RollupDeleteJob;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_rollup/job/{id}</summary>
        public DeleteRollupJobRequest(Id id) : base(r => r.Required("id", id))
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IGetRollupJobRequest, GetRollupJobRequest>))]
	public interface IGetRollupJobRequest : IRequest<GetRollupJobRequestParameters>
	{
	}

	public class GetRollupJobRequest : PlainRequestBase<GetRollupJobRequestParameters>, IGetRollupJobRequest
	{
		protected IGetRollupJobRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.RollupGetJobs;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_rollup/job/{id}</summary>
        public GetRollupJobRequest(Id id) : base(r => r.Optional("id", id))
		{
		}

		///<summary>/_rollup/job/</summary>
        public GetRollupJobRequest() : base()
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IGetRollupCapabilitiesRequest, GetRollupCapabilitiesRequest>))]
	public interface IGetRollupCapabilitiesRequest : IRequest<GetRollupCapabilitiesRequestParameters>
	{
	}

	public class GetRollupCapabilitiesRequest : PlainRequestBase<GetRollupCapabilitiesRequestParameters>, IGetRollupCapabilitiesRequest
	{
		protected IGetRollupCapabilitiesRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.RollupGetRollupCaps;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_rollup/data/{id}</summary>
        public GetRollupCapabilitiesRequest(Id id) : base(r => r.Optional("id", id))
		{
		}

		///<summary>/_rollup/data/</summary>
        public GetRollupCapabilitiesRequest() : base()
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IGetRollupIndexCapabilitiesRequest, GetRollupIndexCapabilitiesRequest>))]
	public interface IGetRollupIndexCapabilitiesRequest : IRequest<GetRollupIndexCapabilitiesRequestParameters>
	{
	}

	public class GetRollupIndexCapabilitiesRequest : PlainRequestBase<GetRollupIndexCapabilitiesRequestParameters>, IGetRollupIndexCapabilitiesRequest
	{
		protected IGetRollupIndexCapabilitiesRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.RollupGetRollupIndexCaps;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/{index}/_rollup/data</summary>
        public GetRollupIndexCapabilitiesRequest(Id index) : base(r => r.Required("index", index))
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICreateRollupJobRequest, CreateRollupJobRequest>))]
	public interface ICreateRollupJobRequest : IRequest<CreateRollupJobRequestParameters>
	{
	}

	public class CreateRollupJobRequest : PlainRequestBase<CreateRollupJobRequestParameters>, ICreateRollupJobRequest
	{
		protected ICreateRollupJobRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.RollupPutJob;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => Cron is null && Groups is null && IndexPattern is null;
		///<summary>/_rollup/job/{id}</summary>
        public CreateRollupJobRequest(Id id) : base(r => r.Required("id", id))
		{
		}

		[JsonPropertyName("cron")]
		public string? Cron
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("groups")]
		public RollupGroupings? Groups
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("index_pattern")]
		public string? IndexPattern
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IRollupRequest, RollupRequest>))]
	public interface IRollupRequest : IRequest<RollupRequestParameters>
	{
	}

	public class RollupRequest : PlainRequestBase<RollupRequestParameters>, IRollupRequest
	{
		protected IRollupRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.RollupRollup;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;
		///<summary>/{index}/_rollup/{rollup_index}</summary>
        public RollupRequest(Index index, RollupIndex rollupIndex) : base(r => r)
		{
		}

		[JsonIgnore]
		public int Stuba { get => Q<int>("stuba"); set => Q("stuba", value); }

		[JsonPropertyName("stub")]
		public int Stub
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IRollupSearchRequest, RollupSearchRequest>))]
	public interface IRollupSearchRequest : IRequest<RollupSearchRequestParameters>
	{
	}

	public class RollupSearchRequest : PlainRequestBase<RollupSearchRequestParameters>, IRollupSearchRequest
	{
		protected IRollupSearchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.RollupRollupSearch;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => Query is null && Size is null;
		///<summary>/{index}/_rollup_search</summary>
        public RollupSearchRequest(Indices index) : base(r => r.Required("index", index))
		{
		}

		[JsonIgnore]
		public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

		[JsonIgnore]
		public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }

		[JsonPropertyName("query")]
		public QueryContainer? Query
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("size")]
		public int? Size
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IStartRollupJobRequest, StartRollupJobRequest>))]
	public interface IStartRollupJobRequest : IRequest<StartRollupJobRequestParameters>
	{
	}

	public class StartRollupJobRequest : PlainRequestBase<StartRollupJobRequestParameters>, IStartRollupJobRequest
	{
		protected IStartRollupJobRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.RollupStartJob;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_rollup/job/{id}/_start</summary>
        public StartRollupJobRequest(Id id) : base(r => r.Required("id", id))
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IStopRollupJobRequest, StopRollupJobRequest>))]
	public interface IStopRollupJobRequest : IRequest<StopRollupJobRequestParameters>
	{
	}

	public class StopRollupJobRequest : PlainRequestBase<StopRollupJobRequestParameters>, IStopRollupJobRequest
	{
		protected IStopRollupJobRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.RollupStopJob;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_rollup/job/{id}/_stop</summary>
        public StopRollupJobRequest(Id id) : base(r => r.Required("id", id))
		{
		}

		[JsonIgnore]
		public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
	}
}