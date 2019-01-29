using DotSpatial.Topology;
using MyGIS.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGIS.Tools.Specific {
	public static class Core {
		public static IdentificationResult<Line> LI_Line(double[] data) {
			for (int i = 0; i < data.Count(); i++) {
				Logger.log("X:" + data[i].ToString() +
					", Y:" + data[++i].ToString());
			}
			return null;
		}

		public static IdentificationResult<Ellipse> LI_Circle(double[] data) {
			Ellipse e = new Ellipse();
			e.center = new Point(0, 0);
			e.unit = Unit.Meter;
			e.rx = 1;
			e.ry = 1;

			IdentificationResult<Ellipse> iResult = new IdentificationResult<Ellipse>(ShapeType.Ellipse);
			iResult.shape = e;
			return iResult;
		}
	}
}
