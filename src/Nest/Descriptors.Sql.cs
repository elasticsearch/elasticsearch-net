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
using Elastic.Transport;
using Elasticsearch.Net;
using Nest.Utf8Json;
using Elasticsearch.Net.Specification.SqlApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	///<summary>Descriptor for ClearCursor <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/clear-sql-cursor-api.html</para></summary>
	public partial class ClearSqlCursorDescriptor : RequestDescriptorBase<ClearSqlCursorDescriptor, ClearSqlCursorRequestParameters, IClearSqlCursorRequest>, IClearSqlCursorRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlClearCursor;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for Delete <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html</para></summary>
	public partial class SqlDeleteDescriptor : RequestDescriptorBase<SqlDeleteDescriptor, SqlDeleteRequestParameters, ISqlDeleteRequest>, ISqlDeleteRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_sql/async/delete/{id}</summary>
		///<param name = "id">this parameter is required</param>
		public SqlDeleteDescriptor(Id id): base(r => r.Required("id", id))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected SqlDeleteDescriptor(): base()
		{
		}

		// values part of the url path
		Id ISqlDeleteRequest.Id => Self.RouteValues.Get<Id>("id");
	// Request parameters
	}

	///<summary>Descriptor for Get <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html</para></summary>
	public partial class SqlGetDescriptor : RequestDescriptorBase<SqlGetDescriptor, SqlGetRequestParameters, ISqlGetRequest>, ISqlGetRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlGet;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_sql/async/{id}</summary>
		///<param name = "id">this parameter is required</param>
		public SqlGetDescriptor(Id id): base(r => r.Required("id", id))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected SqlGetDescriptor(): base()
		{
		}

		// values part of the url path
		Id ISqlGetRequest.Id => Self.RouteValues.Get<Id>("id");
		// Request parameters
		///<summary>Separator for CSV results</summary>
		public SqlGetDescriptor Delimiter(string delimiter) => Qs("delimiter", delimiter);
		///<summary>Short version of the Accept header, e.g. json, yaml</summary>
		public SqlGetDescriptor Format(string format) => Qs("format", format);
		///<summary>Retention period for the search and its results</summary>
		public SqlGetDescriptor KeepAlive(Time keepalive) => Qs("keep_alive", keepalive);
		///<summary>Duration to wait for complete results</summary>
		public SqlGetDescriptor WaitForCompletionTimeout(Time waitforcompletiontimeout) => Qs("wait_for_completion_timeout", waitforcompletiontimeout);
	}

	///<summary>Descriptor for SearchStatus <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html</para></summary>
	public partial class SqlSearchStatusDescriptor : RequestDescriptorBase<SqlSearchStatusDescriptor, SqlSearchStatusRequestParameters, ISqlSearchStatusRequest>, ISqlSearchStatusRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlSearchStatus;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_sql/async/status/{id}</summary>
		///<param name = "id">this parameter is required</param>
		public SqlSearchStatusDescriptor(Id id): base(r => r.Required("id", id))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected SqlSearchStatusDescriptor(): base()
		{
		}

		// values part of the url path
		Id ISqlSearchStatusRequest.Id => Self.RouteValues.Get<Id>("id");
	// Request parameters
	}

	///<summary>Descriptor for Query <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html</para></summary>
	public partial class QuerySqlDescriptor : RequestDescriptorBase<QuerySqlDescriptor, QuerySqlRequestParameters, IQuerySqlRequest>, IQuerySqlRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlQuery;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		// values part of the url path
		// Request parameters
		///<summary>a short version of the Accept header, e.g. json, yaml</summary>
		public QuerySqlDescriptor Format(string format) => Qs("format", format);
	}

	///<summary>Descriptor for Translate <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate-api.html</para></summary>
	public partial class TranslateSqlDescriptor : RequestDescriptorBase<TranslateSqlDescriptor, TranslateSqlRequestParameters, ITranslateSqlRequest>, ITranslateSqlRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlTranslate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
	// values part of the url path
	// Request parameters
	}
}