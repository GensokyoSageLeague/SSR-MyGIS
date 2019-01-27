using DotSpatial.Topology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGIS.Desktop {
	public enum ShapeType {
		NonShape = 0,
		Line = 1,
		Ellipse = 2,
		Crescent = 3
	}

	public enum Unit {
		Meter = 1,
		Kilometer = 2
	}

	public struct Line {
		public Point p1;
		public Point p2;
		public Unit unit;
		public string Reserved;
	}

	public struct Ellipse {
		public Point center;
		public double rx;
		public double ry;
		public Unit unit;
		public string Reserved;
	}

	public struct Crescent { } //可能来不及做咯

	public class IdentificationResult<T> {
		public IdentificationResult(ShapeType shapeType) {
			this.shapeType = shapeType;
		}

		public T shape { get; set; }
		public ShapeType shapeType { get; }
	}
}
