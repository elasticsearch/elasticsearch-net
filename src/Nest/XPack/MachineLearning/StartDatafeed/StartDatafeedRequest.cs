/*
 * Licensed to Elasticsearch B.V. under one or more contributor
 * license agreements. See the NOTICE file distributed with
 * this work for additional information regarding copyright
 * ownership. Elasticsearch B.V. licenses this file to you under
 * the Apache License, Version 2.0 (the "License"); you may
 * not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Runtime.Serialization;
using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	[MapsApi("ml.start_datafeed.json")]
	public partial interface IStartDatafeedRequest
	{
		/// <summary>
		/// The time that the datafeed should end. This value is exclusive.
		/// </summary>
		[DataMember(Name = "end")]
		[JsonFormatter(typeof(NullableDateTimeOffsetEpochMillisecondsFormatter))]
		DateTimeOffset? End { get; set; }

		/// <summary>
		/// The time that the datafeed should begin. This value is inclusive.
		/// </summary>
		[DataMember(Name = "start")]
		[JsonFormatter(typeof(NullableDateTimeOffsetEpochMillisecondsFormatter))]
		DateTimeOffset? Start { get; set; }

		/// <summary>
		/// Controls the amount of time to wait until a datafeed starts.
		/// </summary>
		[DataMember(Name = "timeout")]
		Time Timeout { get; set; }
	}

	/// <inheritdoc />
	public partial class StartDatafeedRequest
	{
		/// <inheritdoc />
		public DateTimeOffset? End { get; set; }

		/// <inheritdoc />
		public DateTimeOffset? Start { get; set; }

		/// <inheritdoc />
		public Time Timeout { get; set; }
	}

	/// <inheritdoc />
	public partial class StartDatafeedDescriptor
	{
		DateTimeOffset? IStartDatafeedRequest.End { get; set; }
		DateTimeOffset? IStartDatafeedRequest.Start { get; set; }
		Time IStartDatafeedRequest.Timeout { get; set; }

		/// <inheritdoc />
		public StartDatafeedDescriptor Timeout(Time timeout) => Assign(timeout, (a, v) => a.Timeout = v);

		/// <inheritdoc />
		public StartDatafeedDescriptor Start(DateTimeOffset? start) => Assign(start, (a, v) => a.Start = v);

		/// <inheritdoc />
		public StartDatafeedDescriptor End(DateTimeOffset? end) => Assign(end, (a, v) => a.End = v);
	}
}
