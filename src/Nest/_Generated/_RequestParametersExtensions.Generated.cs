
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elasticsearch.Net;
using Nest;

//This file contains all the typed request parameters that are generated of the client spec.
//This file is automatically generated from https://github.com/elastic/elasticsearch/tree/master/rest-api-spec

namespace Nest
{
	public static class RequestPameterExtensions
	{
		
		///<summary>Default comma-separated list of fields to return in the response for updates, can be overridden on each sub-request</summary>
		internal static BulkRequestParameters _Fields<T>(this BulkRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(Field)e));
		
		///<summary>Default list of fields to exclude from the returned _source field, can be overridden on each sub-request</summary>
		internal static BulkRequestParameters _SourceExclude<T>(this BulkRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_exclude) where T : class =>
			qs.AddQueryString("_source_exclude", source_exclude.Select(e=>(Field)e));
		
		///<summary>Default list of fields to extract and return from the _source field, can be overridden on each sub-request</summary>
		internal static BulkRequestParameters _SourceInclude<T>(this BulkRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_include) where T : class =>
			qs.AddQueryString("_source_include", source_include.Select(e=>(Field)e));
		
		///<summary>A list of fields to exclude from the returned _source field</summary>
		internal static DeleteByQueryRequestParameters _SourceExclude<T>(this DeleteByQueryRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_exclude) where T : class =>
			qs.AddQueryString("_source_exclude", source_exclude.Select(e=>(Field)e));
		
		///<summary>A list of fields to extract and return from the _source field</summary>
		internal static DeleteByQueryRequestParameters _SourceInclude<T>(this DeleteByQueryRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_include) where T : class =>
			qs.AddQueryString("_source_include", source_include.Select(e=>(Field)e));
		
		///<summary>A comma-separated list of stored fields to return in the response</summary>
		internal static DocumentExistsRequestParameters _StoredFields<T>(this DocumentExistsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  stored_fields) where T : class =>
			qs.AddQueryString("stored_fields", stored_fields.Select(e=>(Field)e));
		
		///<summary>A list of fields to exclude from the returned _source field</summary>
		internal static DocumentExistsRequestParameters _SourceExclude<T>(this DocumentExistsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_exclude) where T : class =>
			qs.AddQueryString("_source_exclude", source_exclude.Select(e=>(Field)e));
		
		///<summary>A list of fields to extract and return from the _source field</summary>
		internal static DocumentExistsRequestParameters _SourceInclude<T>(this DocumentExistsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_include) where T : class =>
			qs.AddQueryString("_source_include", source_include.Select(e=>(Field)e));
		
		///<summary>A list of fields to exclude from the returned _source field</summary>
		internal static SourceExistsRequestParameters _SourceExclude<T>(this SourceExistsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_exclude) where T : class =>
			qs.AddQueryString("_source_exclude", source_exclude.Select(e=>(Field)e));
		
		///<summary>A list of fields to extract and return from the _source field</summary>
		internal static SourceExistsRequestParameters _SourceInclude<T>(this SourceExistsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_include) where T : class =>
			qs.AddQueryString("_source_include", source_include.Select(e=>(Field)e));
		
		///<summary>A comma-separated list of stored fields to return in the response</summary>
		internal static ExplainRequestParameters _StoredFields<T>(this ExplainRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  stored_fields) where T : class =>
			qs.AddQueryString("stored_fields", stored_fields.Select(e=>(Field)e));
		
		///<summary>A list of fields to exclude from the returned _source field</summary>
		internal static ExplainRequestParameters _SourceExclude<T>(this ExplainRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_exclude) where T : class =>
			qs.AddQueryString("_source_exclude", source_exclude.Select(e=>(Field)e));
		
		///<summary>A list of fields to extract and return from the _source field</summary>
		internal static ExplainRequestParameters _SourceInclude<T>(this ExplainRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_include) where T : class =>
			qs.AddQueryString("_source_include", source_include.Select(e=>(Field)e));
		
		///<summary>A comma-separated list of field names</summary>
		internal static FieldCapabilitiesRequestParameters _Fields<T>(this FieldCapabilitiesRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(Field)e));
		
		///<summary>A comma-separated list of stored fields to return in the response</summary>
		internal static GetRequestParameters _StoredFields<T>(this GetRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  stored_fields) where T : class =>
			qs.AddQueryString("stored_fields", stored_fields.Select(e=>(Field)e));
		
		///<summary>A list of fields to exclude from the returned _source field</summary>
		internal static GetRequestParameters _SourceExclude<T>(this GetRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_exclude) where T : class =>
			qs.AddQueryString("_source_exclude", source_exclude.Select(e=>(Field)e));
		
		///<summary>A list of fields to extract and return from the _source field</summary>
		internal static GetRequestParameters _SourceInclude<T>(this GetRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_include) where T : class =>
			qs.AddQueryString("_source_include", source_include.Select(e=>(Field)e));
		
		///<summary>A list of fields to exclude from the returned _source field</summary>
		internal static SourceRequestParameters _SourceExclude<T>(this SourceRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_exclude) where T : class =>
			qs.AddQueryString("_source_exclude", source_exclude.Select(e=>(Field)e));
		
		///<summary>A list of fields to extract and return from the _source field</summary>
		internal static SourceRequestParameters _SourceInclude<T>(this SourceRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_include) where T : class =>
			qs.AddQueryString("_source_include", source_include.Select(e=>(Field)e));
		
		///<summary>A comma-separated list of fields to clear when using the `field_data` parameter (default: all)</summary>
		internal static ClearCacheRequestParameters _Fields<T>(this ClearCacheRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(Field)e));
		
		///<summary>A comma-separated list of fields for `fielddata` and `suggest` index metric (supports wildcards)</summary>
		internal static IndicesStatsRequestParameters _CompletionFields<T>(this IndicesStatsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  completion_fields) where T : class =>
			qs.AddQueryString("completion_fields", completion_fields.Select(e=>(Field)e));
		
		///<summary>A comma-separated list of fields for `fielddata` index metric (supports wildcards)</summary>
		internal static IndicesStatsRequestParameters _FielddataFields<T>(this IndicesStatsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fielddata_fields) where T : class =>
			qs.AddQueryString("fielddata_fields", fielddata_fields.Select(e=>(Field)e));
		
		///<summary>A comma-separated list of fields for `fielddata` and `completion` index metric (supports wildcards)</summary>
		internal static IndicesStatsRequestParameters _Fields<T>(this IndicesStatsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(Field)e));
		
		///<summary>A comma-separated list of stored fields to return in the response</summary>
		internal static MultiGetRequestParameters _StoredFields<T>(this MultiGetRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  stored_fields) where T : class =>
			qs.AddQueryString("stored_fields", stored_fields.Select(e=>(Field)e));
		
		///<summary>A list of fields to exclude from the returned _source field</summary>
		internal static MultiGetRequestParameters _SourceExclude<T>(this MultiGetRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_exclude) where T : class =>
			qs.AddQueryString("_source_exclude", source_exclude.Select(e=>(Field)e));
		
		///<summary>A list of fields to extract and return from the _source field</summary>
		internal static MultiGetRequestParameters _SourceInclude<T>(this MultiGetRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_include) where T : class =>
			qs.AddQueryString("_source_include", source_include.Select(e=>(Field)e));
		
		///<summary>A comma-separated list of fields to return. Applies to all returned documents unless otherwise specified in body &quot;params&quot; or &quot;docs&quot;.</summary>
		internal static MultiTermVectorsRequestParameters _Fields<T>(this MultiTermVectorsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(Field)e));
		
		///<summary>A comma-separated list of fields for `fielddata` and `suggest` index metric (supports wildcards)</summary>
		internal static NodesStatsRequestParameters _CompletionFields<T>(this NodesStatsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  completion_fields) where T : class =>
			qs.AddQueryString("completion_fields", completion_fields.Select(e=>(Field)e));
		
		///<summary>A comma-separated list of fields for `fielddata` index metric (supports wildcards)</summary>
		internal static NodesStatsRequestParameters _FielddataFields<T>(this NodesStatsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fielddata_fields) where T : class =>
			qs.AddQueryString("fielddata_fields", fielddata_fields.Select(e=>(Field)e));
		
		///<summary>A comma-separated list of fields for `fielddata` and `completion` index metric (supports wildcards)</summary>
		internal static NodesStatsRequestParameters _Fields<T>(this NodesStatsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(Field)e));
		
		///<summary>A comma-separated list of fields to return as the docvalue representation of a field for each hit</summary>
		internal static SearchRequestParameters _DocvalueFields<T>(this SearchRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  docvalue_fields) where T : class =>
			qs.AddQueryString("docvalue_fields", docvalue_fields.Select(e=>(Field)e));
		
		///<summary>Specify which field to use for suggestions</summary>
		internal static SearchRequestParameters _SuggestField<T>(this SearchRequestParameters qs, Expression<Func<T, object>> suggest_field) where T : class =>
			qs.AddQueryString("suggest_field", (Field)suggest_field);
		
		///<summary>A comma-separated list of fields to return.</summary>
		internal static TermVectorsRequestParameters _Fields<T>(this TermVectorsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(Field)e));
		
		///<summary>A list of fields to exclude from the returned _source field</summary>
		internal static UpdateByQueryRequestParameters _SourceExclude<T>(this UpdateByQueryRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_exclude) where T : class =>
			qs.AddQueryString("_source_exclude", source_exclude.Select(e=>(Field)e));
		
		///<summary>A list of fields to extract and return from the _source field</summary>
		internal static UpdateByQueryRequestParameters _SourceInclude<T>(this UpdateByQueryRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_include) where T : class =>
			qs.AddQueryString("_source_include", source_include.Select(e=>(Field)e));
	}
}
 