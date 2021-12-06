// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
using Elasticsearch.Net.Specification.TransformApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	[InterfaceDataContract]
	public partial interface IDeleteTransformRequest : IRequest<DeleteTransformRequestParameters>
	{
		[IgnoreDataMember]
		Id TransformId
		{
			get;
		}
	}

	///<summary>Request for Delete <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/delete-transform.html</para></summary>
	public partial class DeleteTransformRequest : PlainRequestBase<DeleteTransformRequestParameters>, IDeleteTransformRequest
	{
		protected IDeleteTransformRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformDelete;
		///<summary>/_transform/{transform_id}</summary>
		///<param name = "transformId">this parameter is required</param>
		public DeleteTransformRequest(Id transformId): base(r => r.Required("transform_id", transformId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteTransformRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IDeleteTransformRequest.TransformId => Self.RouteValues.Get<Id>("transform_id");
		// Request parameters
		///<summary>
		/// When `true`, the transform is deleted regardless of its current state. The default value is `false`, meaning that the transform must be
		/// `stopped` before it can be deleted.
		///</summary>
		public bool? Force
		{
			get => Q<bool? >("force");
			set => Q("force", value);
		}

		///<summary>Controls the time to wait for the transform deletion</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IGetTransformRequest : IRequest<GetTransformRequestParameters>
	{
		[IgnoreDataMember]
		Id TransformId
		{
			get;
		}
	}

	///<summary>Request for Get <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/get-transform.html</para></summary>
	public partial class GetTransformRequest : PlainRequestBase<GetTransformRequestParameters>, IGetTransformRequest
	{
		protected IGetTransformRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformGet;
		///<summary>/_transform/{transform_id}</summary>
		///<param name = "transformId">Optional, accepts null</param>
		public GetTransformRequest(Id transformId): base(r => r.Optional("transform_id", transformId))
		{
		}

		///<summary>/_transform</summary>
		public GetTransformRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IGetTransformRequest.TransformId => Self.RouteValues.Get<Id>("transform_id");
		// Request parameters
		///<summary>Whether to ignore if a wildcard expression matches no transforms. (This includes `_all` string or when no transforms have been specified)</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}

		///<summary>Omits fields that are illegal to set on transform PUT</summary>
		public bool? ExcludeGenerated
		{
			get => Q<bool? >("exclude_generated");
			set => Q("exclude_generated", value);
		}

		///<summary>skips a number of transform configs, defaults to 0</summary>
		public int? From
		{
			get => Q<int? >("from");
			set => Q("from", value);
		}

		///<summary>specifies a max number of transforms to get, defaults to 100</summary>
		public int? Size
		{
			get => Q<int? >("size");
			set => Q("size", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IGetTransformStatsRequest : IRequest<GetTransformStatsRequestParameters>
	{
		[IgnoreDataMember]
		Id TransformId
		{
			get;
		}
	}

	///<summary>Request for GetStats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/get-transform-stats.html</para></summary>
	public partial class GetTransformStatsRequest : PlainRequestBase<GetTransformStatsRequestParameters>, IGetTransformStatsRequest
	{
		protected IGetTransformStatsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformGetStats;
		///<summary>/_transform/{transform_id}/_stats</summary>
		///<param name = "transformId">this parameter is required</param>
		public GetTransformStatsRequest(Id transformId): base(r => r.Required("transform_id", transformId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected GetTransformStatsRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IGetTransformStatsRequest.TransformId => Self.RouteValues.Get<Id>("transform_id");
		// Request parameters
		///<summary>Whether to ignore if a wildcard expression matches no transforms. (This includes `_all` string or when no transforms have been specified)</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}

		///<summary>skips a number of transform stats, defaults to 0</summary>
		public long? From
		{
			get => Q<long? >("from");
			set => Q("from", value);
		}

		///<summary>specifies a max number of transform stats to get, defaults to 100</summary>
		public long? Size
		{
			get => Q<long? >("size");
			set => Q("size", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IPreviewTransformRequest : IRequest<PreviewTransformRequestParameters>
	{
		[IgnoreDataMember]
		Id TransformId
		{
			get;
		}
	}

	///<summary>Request for Preview <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/preview-transform.html</para></summary>
	public partial class PreviewTransformRequest : PlainRequestBase<PreviewTransformRequestParameters>, IPreviewTransformRequest
	{
		protected IPreviewTransformRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformPreview;
		///<summary>/_transform/{transform_id}/_preview</summary>
		///<param name = "transformId">Optional, accepts null</param>
		public PreviewTransformRequest(Id transformId): base(r => r.Optional("transform_id", transformId))
		{
		}

		///<summary>/_transform/_preview</summary>
		public PreviewTransformRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IPreviewTransformRequest.TransformId => Self.RouteValues.Get<Id>("transform_id");
		// Request parameters
		///<summary>Controls the time to wait for the preview</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IPutTransformRequest : IRequest<PutTransformRequestParameters>
	{
		[IgnoreDataMember]
		Id TransformId
		{
			get;
		}
	}

	///<summary>Request for Put <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/put-transform.html</para></summary>
	public partial class PutTransformRequest : PlainRequestBase<PutTransformRequestParameters>, IPutTransformRequest
	{
		protected IPutTransformRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformPut;
		///<summary>/_transform/{transform_id}</summary>
		///<param name = "transformId">this parameter is required</param>
		public PutTransformRequest(Id transformId): base(r => r.Required("transform_id", transformId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PutTransformRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IPutTransformRequest.TransformId => Self.RouteValues.Get<Id>("transform_id");
		// Request parameters
		///<summary>If validations should be deferred until transform starts, defaults to false.</summary>
		public bool? DeferValidation
		{
			get => Q<bool? >("defer_validation");
			set => Q("defer_validation", value);
		}

		///<summary>Controls the time to wait for the transform to start</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IStartTransformRequest : IRequest<StartTransformRequestParameters>
	{
		[IgnoreDataMember]
		Id TransformId
		{
			get;
		}
	}

	///<summary>Request for Start <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/start-transform.html</para></summary>
	public partial class StartTransformRequest : PlainRequestBase<StartTransformRequestParameters>, IStartTransformRequest
	{
		protected IStartTransformRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformStart;
		///<summary>/_transform/{transform_id}/_start</summary>
		///<param name = "transformId">this parameter is required</param>
		public StartTransformRequest(Id transformId): base(r => r.Required("transform_id", transformId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected StartTransformRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IStartTransformRequest.TransformId => Self.RouteValues.Get<Id>("transform_id");
		// Request parameters
		///<summary>Controls the time to wait for the transform to start</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IStopTransformRequest : IRequest<StopTransformRequestParameters>
	{
		[IgnoreDataMember]
		Id TransformId
		{
			get;
		}
	}

	///<summary>Request for Stop <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/stop-transform.html</para></summary>
	public partial class StopTransformRequest : PlainRequestBase<StopTransformRequestParameters>, IStopTransformRequest
	{
		protected IStopTransformRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformStop;
		///<summary>/_transform/{transform_id}/_stop</summary>
		///<param name = "transformId">this parameter is required</param>
		public StopTransformRequest(Id transformId): base(r => r.Required("transform_id", transformId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected StopTransformRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IStopTransformRequest.TransformId => Self.RouteValues.Get<Id>("transform_id");
		// Request parameters
		///<summary>Whether to ignore if a wildcard expression matches no transforms. (This includes `_all` string or when no transforms have been specified)</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}

		///<summary>Whether to force stop a failed transform or not. Default to false</summary>
		public bool? Force
		{
			get => Q<bool? >("force");
			set => Q("force", value);
		}

		///<summary>Controls the time to wait until the transform has stopped. Default to 30 seconds</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Whether to wait for the transform to reach a checkpoint before stopping. Default to false</summary>
		public bool? WaitForCheckpoint
		{
			get => Q<bool? >("wait_for_checkpoint");
			set => Q("wait_for_checkpoint", value);
		}

		///<summary>Whether to wait for the transform to fully stop before returning or not. Default to false</summary>
		public bool? WaitForCompletion
		{
			get => Q<bool? >("wait_for_completion");
			set => Q("wait_for_completion", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IUpdateTransformRequest : IRequest<UpdateTransformRequestParameters>
	{
		[IgnoreDataMember]
		Id TransformId
		{
			get;
		}
	}

	///<summary>Request for Update <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/update-transform.html</para></summary>
	public partial class UpdateTransformRequest : PlainRequestBase<UpdateTransformRequestParameters>, IUpdateTransformRequest
	{
		protected IUpdateTransformRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformUpdate;
		///<summary>/_transform/{transform_id}/_update</summary>
		///<param name = "transformId">this parameter is required</param>
		public UpdateTransformRequest(Id transformId): base(r => r.Required("transform_id", transformId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected UpdateTransformRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IUpdateTransformRequest.TransformId => Self.RouteValues.Get<Id>("transform_id");
		// Request parameters
		///<summary>If validations should be deferred until transform starts, defaults to false.</summary>
		public bool? DeferValidation
		{
			get => Q<bool? >("defer_validation");
			set => Q("defer_validation", value);
		}

		///<summary>Controls the time to wait for the update</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}
}