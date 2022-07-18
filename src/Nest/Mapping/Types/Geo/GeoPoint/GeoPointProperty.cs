// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	/// <summary>
	/// Data type mapping to map a property as a geopoint
	/// </summary>
	[InterfaceDataContract]
	public interface IGeoPointProperty : IDocValuesProperty
	{
		/// <summary>
		/// If true, malformed geo-points are ignored. If false (default), malformed
		/// geo-points throw an exception and reject the whole document.
		/// </summary>
		[DataMember(Name ="ignore_malformed")]
		bool? IgnoreMalformed { get; set; }


		/// <summary>
		/// If true (default) three dimension points will be accepted (stored in source) but only
		/// latitude and longitude values will be indexed; the third dimension is ignored. If false, geo-points
		/// containing any more than latitude and longitude (two dimensions) values
		/// throw an exception and reject the whole document.
		/// </summary>
		[DataMember(Name ="ignore_z_value")]
		bool? IgnoreZValue { get; set; }

		/// <summary>
		/// Accepts a geo_point value which is substituted for any explicit null values.
		/// Defaults to null, which means the field is treated as missing.
		/// </summary>
		[DataMember(Name ="null_value")]
		GeoLocation NullValue { get; set; }

		/// <summary>
		/// If this parameter is set, then the field will index values generated by this script, rather than reading the values directly from 
		/// the source. If a value is set for this field on the input document, then the document will be rejected with an error. Scripts are 
		/// in the same format as their runtime equivalent, and should emit points as a pair of (lat, lon) double values.
		/// </summary>
		[DataMember(Name = "script")]
		IInlineScript Script { get; set; }

		/// <summary>
		/// Defines what to do if the script defined by the `script` parameter throws an error at indexing time.Accepts `reject` (default), which
		/// will cause the entire document to be rejected, and `ignore`, which will register the field in the document's ignored metadata field and
		/// continue indexing.This parameter can only be set if the `script` field is also set.
		/// </summary>
		[DataMember(Name = "on_script_error")]
		OnScriptError? OnScriptError { get; set; }
	}

	/// <inheritdoc cref="IGeoPointProperty"/>
	[DebuggerDisplay("{DebugDisplay}")]
	public class GeoPointProperty : DocValuesPropertyBase, IGeoPointProperty
	{
		public GeoPointProperty() : base(FieldType.GeoPoint) { }

		/// <inheritdoc />
		public bool? IgnoreMalformed { get; set; }

		/// <inheritdoc />
		public bool? IgnoreZValue { get; set; }

		/// <inheritdoc />
		public GeoLocation NullValue { get; set; }

		/// <inheritdoc />
		public IInlineScript Script { get; set; }

		/// <inheritdoc />
		public OnScriptError? OnScriptError { get; set; }
	}

	/// <inheritdoc cref="IGeoPointProperty"/>
	[DebuggerDisplay("{DebugDisplay}")]
	public class GeoPointPropertyDescriptor<T>
		: DocValuesPropertyDescriptorBase<GeoPointPropertyDescriptor<T>, IGeoPointProperty, T>, IGeoPointProperty
		where T : class
	{
		public GeoPointPropertyDescriptor() : base(FieldType.GeoPoint) { }

		bool? IGeoPointProperty.IgnoreMalformed { get; set; }
		bool? IGeoPointProperty.IgnoreZValue { get; set; }
		GeoLocation IGeoPointProperty.NullValue { get; set; }
		IInlineScript IGeoPointProperty.Script { get; set; }
		OnScriptError? IGeoPointProperty.OnScriptError { get; set; }

		/// <inheritdoc cref="IGeoPointProperty.IgnoreMalformed" />
		public GeoPointPropertyDescriptor<T> IgnoreMalformed(bool? ignoreMalformed = true) => Assign(ignoreMalformed, (a, v) => a.IgnoreMalformed = v);

		/// <inheritdoc cref="IGeoPointProperty.IgnoreZValue" />
		public GeoPointPropertyDescriptor<T> IgnoreZValue(bool? ignoreZValue = true) => Assign(ignoreZValue, (a, v) => a.IgnoreZValue = v);

		/// <inheritdoc cref="IGeoPointProperty.NullValue" />
		public GeoPointPropertyDescriptor<T> NullValue(GeoLocation defaultValue) => Assign(defaultValue, (a, v) => a.NullValue = v);
	
		/// <inheritdoc cref="INumberProperty.Script" />
		public GeoPointPropertyDescriptor<T> Script(IInlineScript inlineScript) => Assign(inlineScript, (a, v) => a.Script = v);

		/// <inheritdoc cref="INumberProperty.Script" />
		public GeoPointPropertyDescriptor<T> Script(string source) => Assign(source, (a, v) => a.Script = new InlineScript(source));

		/// <inheritdoc cref="INumberProperty.Script" />
		public GeoPointPropertyDescriptor<T> Script(Func<InlineScriptDescriptor, IInlineScript> selector) => Assign(selector, (a, v) => a.Script = v?.Invoke(new InlineScriptDescriptor()));
		
		/// <inheritdoc cref="INumberProperty.OnScriptError" />
		public GeoPointPropertyDescriptor<T> OnScriptError(OnScriptError? onScriptError) => Assign(onScriptError, (a, v) => a.OnScriptError = v);
	}
}
