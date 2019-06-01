﻿using System;
using System.Runtime.Serialization;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	[JsonFormatter(typeof(GeoShapeFormatter<IPointGeoShape>))]
	public interface IPointGeoShape : IGeoShape
	{
		[DataMember(Name ="coordinates")]
		GeoCoordinate Coordinates { get; set; }
	}

	[JsonFormatter(typeof(GeoShapeFormatter<PointGeoShape>))]
	public class PointGeoShape : GeoShapeBase, IPointGeoShape
	{
		internal PointGeoShape() : base("point") { }

		public PointGeoShape(GeoCoordinate coordinates) : this() =>
			Coordinates = coordinates ?? throw new ArgumentNullException(nameof(coordinates));

		public GeoCoordinate Coordinates { get; set; }
	}
}
