// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.Runtime.Serialization;

namespace Nest
{
	/// <summary>
	/// The histogram value source can be applied on numeric values to build fixed size interval over the values.
	/// </summary>
	public interface IHistogramGroupSource : ISingleGroupSource
	{
		/// <summary>
		/// The interval to use when bucketing documents
		/// </summary>
		[DataMember(Name ="interval")]
		double? Interval { get; set; }
	}

	/// <inheritdoc cref="IHistogramGroupSource"/>
	public class HistogramGroupSource : SingleGroupSourceBase, IHistogramGroupSource
	{
		/// <inheritdoc cref="IHistogramGroupSource.Interval"/>
		public double? Interval { get; set; }
	}

	/// <inheritdoc cref="IHistogramGroupSource"/>
	public class HistogramGroupSourceDescriptor<T>
		: SingleGroupSourceDescriptorBase<HistogramGroupSourceDescriptor<T>, IHistogramGroupSource, T>,
			IHistogramGroupSource
	{
		double? IHistogramGroupSource.Interval { get; set; }

		/// <inheritdoc cref="IHistogramGroupSource.Interval"/>
		public HistogramGroupSourceDescriptor<T> Interval(double? interval) => Assign(interval, (a, v) => a.Interval = v);
	}
}
