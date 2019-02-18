using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotSpatial.Data;
using DotSpatial.Modeling.Forms;
using DotSpatial.Topology;
using DotSpatial.Topology.Algorithm;
using System.Collections;

namespace MyGIS.Tools.Specific {
	public class LiCircle : Tool {
		private Parameter[] _inputParam;
		private Parameter[] _outputParam;

		public override Parameter[] InputParameters {
			get {
				return _inputParam;
			}
		}

		public override Parameter[] OutputParameters {
			get {
				return _outputParam;
			}
		}

		public LiCircle() {
			this.Name = TextStrings.LiCircle;
			this.Category = TextStrings.Category;
			this.Description = TextStrings.LiCircleDescription;
			this.ToolTip = TextStrings.LICircleTip;
		}

		public override void Initialize() {
			_inputParam = new Parameter[4];
			_inputParam[0] = new LineFeatureSetParam(TextStrings.InputFeatureSet);
			_inputParam[1] = new DoubleParam(TextStrings.LiLinePara, 60.0);
			_inputParam[2] = new DoubleParam(TextStrings.LiLinePara1, 2.0);
			_inputParam[3] = new DoubleParam(TextStrings.LiLinePara2, 100.0);
			_outputParam = new Parameter[1];
			_outputParam[0] = new PolygonFeatureSetParam(TextStrings.OutputFeatureSet);
		}

		struct FeatureUnion {
			internal IFeature originalLine;
			internal IFeature linkedPolygon;
			internal IFeature envelopedRect;
			internal IFeature centroidOfPolygon;
		}

		public override bool Execute(ICancelProgressHandler cancelProgressHandler) {
			IFeatureSet input = _inputParam[0].Value as IFeatureSet;
			IFeatureSet output = _outputParam[0].Value as IFeatureSet;
			DoubleParam para = _inputParam[1] as DoubleParam;
			double tolerance1 = para != null ? para.Value : 60;
			para = _inputParam[2] as DoubleParam;
			double tolerance2 = para != null ? para.Value : 2;
			para = _inputParam[3] as DoubleParam;
			double parameter = para != null ? para.Value : 100;

			List<FeatureUnion> myunion = new List<FeatureUnion>();

			for (int i = 0; i < input.Features.Count; i++) {
				IFeature  feature = input.Features[i];
				IEnvelope envelop = input.Features[i].Envelope;

				if (feature.BasicGeometry.Coordinates[feature.BasicGeometry.Coordinates.Count - 1]
					!=
					feature.BasicGeometry.Coordinates[0])
				{
					continue;
				}

				var c1 = envelop.TopLeft();
				var c2 = envelop.BottomRight();
				var lp = new Polygon(feature.BasicGeometry.Coordinates);
				var lpf = new Feature(lp);
				var er = new Polygon(
					new Coordinate[] {
						new Coordinate(c1.X, c1.Y),
						new Coordinate(c1.X, c2.Y),
						new Coordinate(c2.X, c2.Y),
						new Coordinate(c2.X, c1.Y),
						new Coordinate(c1.X, c1.Y)
				});
				var erf = new Feature(er);
				var cop = lpf.Centroid();

				if (double.IsNaN(cop.Coordinates[0].X) ||
					double.IsNaN(cop.Coordinates[0].Y)) 
				{
					continue;
				}

				if (Math.Abs(lpf.ConvexHull().Area() - lpf.Area()) > parameter) {
					continue;
				}

				myunion.Add(new FeatureUnion {
					originalLine = input.Features[i],
					linkedPolygon = lpf,
					envelopedRect = erf,
					centroidOfPolygon = cop
				});

				output.Features.Add(myunion[myunion.Count - 1].centroidOfPolygon.Buffer(tolerance1));

				cancelProgressHandler.Progress(
					string.Empty,
					Convert.ToInt32((Convert.ToDouble(i) / Convert.ToDouble(input.Features.Count)) * 100),
					string.Empty
					//(myunion[i].linkedPolygon.Area() / myunion[i].envelopedRect.Area()).ToString()
				);
			}

			try {
				for (int i = 0; i < myunion.Count; i++) {
					Coordinate c = myunion[i].centroidOfPolygon.BasicGeometry.Coordinates[0];
					int covers = 0;
					for (int j = 0; j < i; j++) {
						if (myunion[i].centroidOfPolygon.Buffer(tolerance1).Covers(myunion[j].centroidOfPolygon)) {
							covers++;
						}
					}
					for (int j = i + 1; j < myunion.Count; j++) {
						if (myunion[i].centroidOfPolygon.Buffer(tolerance1).Covers(myunion[j].centroidOfPolygon)) {
							covers++;
						}
					}
					if (covers >= tolerance2) {
						//output.Features.Add(myunion[i].centroidOfPolygon.Buffer(tolerance));
					}

					cancelProgressHandler.Progress(
						string.Empty,
						Convert.ToInt32((Convert.ToDouble(i) / Convert.ToDouble(input.Features.Count)) * 100),
						string.Empty
);
				}
			}
			catch (Exception) {
			}

			// 测试
// 			for (int i = 0; i < myunion.Count; i++) {
// 				output.Features.Add(myunion[i].centroidOfPolygon.Buffer(tolerance));
// 				output.Features.Add(myunion[i].envelopedRect);
// 				cancelProgressHandler.Progress(
// 					string.Empty,
// 					Convert.ToInt32((Convert.ToDouble(i) / Convert.ToDouble(input.Features.Count)) * 100),
// 					string.Empty
// 				);
// 			}

			output.Save();
			return true;
		}
	}
}
