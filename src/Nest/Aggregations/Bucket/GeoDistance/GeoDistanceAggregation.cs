using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Newtonsoft.Json;

namespace Nest
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	[ContractJsonConverter(typeof(AggregationJsonConverter<GeoDistanceAggregation>))]
	public interface IGeoDistanceAggregation : IBucketAggregation
	{
		[JsonProperty("distance_type")]
		GeoDistanceType? DistanceType { get; set; }

		[JsonProperty("field")]
		Field Field { get; set; }

		[JsonProperty("origin")]
		GeoLocation Origin { get; set; }

		[JsonProperty(PropertyName = "ranges")]
#pragma warning disable 618
		IEnumerable<IRange> Ranges { get; set; }
#pragma warning restore 618

		[JsonProperty("unit")]
		DistanceUnit? Unit { get; set; }
	}

	public class GeoDistanceAggregation : BucketAggregationBase, IGeoDistanceAggregation
	{
		internal GeoDistanceAggregation() { }

		public GeoDistanceAggregation(string name) : base(name) { }

		public GeoDistanceType? DistanceType { get; set; }
		public Field Field { get; set; }

		public GeoLocation Origin { get; set; }

#pragma warning disable 618
		public IEnumerable<IRange> Ranges { get; set; }
#pragma warning restore 618

		public DistanceUnit? Unit { get; set; }

		internal override void WrapInContainer(AggregationContainer c) => c.GeoDistance = this;
	}

	public class GeoDistanceAggregationDescriptor<T>
		: BucketAggregationDescriptorBase<GeoDistanceAggregationDescriptor<T>, IGeoDistanceAggregation, T>
			, IGeoDistanceAggregation
		where T : class
	{
		GeoDistanceType? IGeoDistanceAggregation.DistanceType { get; set; }
		Field IGeoDistanceAggregation.Field { get; set; }

		GeoLocation IGeoDistanceAggregation.Origin { get; set; }

#pragma warning disable 618
		IEnumerable<IRange> IGeoDistanceAggregation.Ranges { get; set; }
#pragma warning restore 618

		DistanceUnit? IGeoDistanceAggregation.Unit { get; set; }

		public GeoDistanceAggregationDescriptor<T> Field(Field field) => Assign(a => a.Field = field);

		public GeoDistanceAggregationDescriptor<T> Field(Expression<Func<T, object>> field) => Assign(a => a.Field = field);

		public GeoDistanceAggregationDescriptor<T> Origin(double lat, double lon) => Assign(a => a.Origin = new GeoLocation(lat, lon));

		public GeoDistanceAggregationDescriptor<T> Origin(GeoLocation geoLocation) => Assign(a => a.Origin = geoLocation);

		public GeoDistanceAggregationDescriptor<T> Unit(DistanceUnit unit) => Assign(a => a.Unit = unit);

		public GeoDistanceAggregationDescriptor<T> DistanceType(GeoDistanceType? geoDistance) => Assign(a => a.DistanceType = geoDistance);

#pragma warning disable 618
		public GeoDistanceAggregationDescriptor<T> Ranges(params Func<RangeDescriptor, IRange>[] ranges) =>
			Assign(a => a.Ranges = ranges?.Select(r => r(new RangeDescriptor())));
#pragma warning restore 618
	}
}
