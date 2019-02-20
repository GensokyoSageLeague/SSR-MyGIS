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
			_inputParam = new Parameter[5];
			_inputParam[0] = new LineFeatureSetParam(TextStrings.InputFeatureSet);
			_inputParam[1] = new DoubleParam(TextStrings.LiCirclePara1, 60.0);
			_inputParam[2] = new DoubleParam(TextStrings.LiCirclePara2, 3.0);
			_inputParam[3] = new DoubleParam(TextStrings.LiCirclePara3, 5.0);
			_inputParam[4] = new StringParam(TextStrings.LiCirclePara4, string.Empty);
#if DEBUG
			_outputParam = new Parameter[2];
			_outputParam[0] = new PointFeatureSetParam(TextStrings.OutputFeatureSet);
			_outputParam[1] = new PolygonFeatureSetParam("DEBUG MODE OUTPUT");
#else
			_outputParam = new Parameter[1];
			_outputParam[0] = new PointFeatureSetParam(TextStrings.OutputFeatureSet);
#endif
		}

		class FeatureUnion {
			internal IFeature OriginalLine;
			internal IFeature LinkedPolygon;
			internal IFeature EnvelopedRect;
			internal IFeature CentroidOfPolygon;
			internal bool Visited;
		}

		public override bool Execute(ICancelProgressHandler cancelProgressHandler) {
			IFeatureSet input = _inputParam[0].Value as IFeatureSet;
			IFeatureSet output = _outputParam[0].Value as IFeatureSet;
#if DEBUG
			IFeatureSet output1 = _outputParam[1].Value as IFeatureSet;
#endif
			DoubleParam para;
			para = _inputParam[1] as DoubleParam;
			double paraSearchRadius = para != null ? para.Value : 60;
			para = _inputParam[2] as DoubleParam;
			double paraSearchCount = para != null ? para.Value : 3;
			para = _inputParam[3] as DoubleParam;
			double paraToleranceOfConvexHull = para != null ? para.Value : 5;
			string column = ((StringParam)_inputParam[4]).Value;
			int columnIndex = -1;

			List<FeatureUnion> myunion = new List<FeatureUnion>();

			if (column != string.Empty) {
				columnIndex = input.DataTable.Columns.IndexOf(column);
				if (columnIndex == -1) {
					cancelProgressHandler.Progress(string.Empty, 100, "[Error] Column Not Found.");
					return false;
				}
			}

			cancelProgressHandler.Progress(string.Empty, 0, "[Info] Stage 1/2: Cancellable.");

			for (int i = 0; i < input.Features.Count; i++) {
				IFeature feature = input.Features[i];
				IEnvelope envelop = input.Features[i].Envelope;

				// 不闭合
				if (feature.BasicGeometry.Coordinates[feature.BasicGeometry.Coordinates.Count - 1]
					!=
					feature.BasicGeometry.Coordinates[0]
				) {
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

				// 无面积
				if (double.IsNaN(cop.Coordinates[0].X) ||
					double.IsNaN(cop.Coordinates[0].Y)
				) {
					continue;
				}

				// paraToleranceOfConvexHull
				if (Math.Abs(lpf.ConvexHull().Area() - lpf.Area()) / lpf.Area() > paraToleranceOfConvexHull / 100) {
					continue;
				}

				myunion.Add(new FeatureUnion {
					OriginalLine = input.Features[i],
					LinkedPolygon = lpf,
					EnvelopedRect = erf,
					CentroidOfPolygon = cop,
					Visited = false
				});

#if DEBUG
				output1.Features.Add(myunion[myunion.Count - 1].CentroidOfPolygon.Buffer(paraSearchRadius));
				//output1.Features.Add(myunion[myunion.Count - 1].EnvelopedRect);
#endif

				cancelProgressHandler.Progress(
					string.Empty,
					Convert.ToInt32((Convert.ToDouble(i) / Convert.ToDouble(input.Features.Count)) * 100),
					string.Empty
				//(myunion[i].LinkedPolygon.Area() / myunion[i].EnvelopedRect.Area()).ToString()
				);
				if (cancelProgressHandler.Cancel) {
					cancelProgressHandler.Progress(string.Empty, 100, "[Error] Cancelled.");
					return false;
				}
			}

			cancelProgressHandler.Progress(string.Empty, 0, "[Info] Stage 2/2: Cancellable.");

			for (int i = 0; i < myunion.Count; i++) {
				List<int> coversList = new List<int>();

				for (int j = 0; j < i; j++) {
					if (myunion[i].CentroidOfPolygon.Buffer(paraSearchRadius).Intersects(myunion[j].CentroidOfPolygon.Buffer(paraSearchRadius)) &&
						!myunion[i].Visited
					) {
						coversList.Add(j);
						myunion[j].Visited = true;
					}
				}
				for (int j = i + 1; j < myunion.Count; j++) {
					if (myunion[i].CentroidOfPolygon.Buffer(paraSearchRadius).Intersects(myunion[j].CentroidOfPolygon.Buffer(paraSearchRadius)) &&
						!myunion[i].Visited
					) {
						coversList.Add(j);
						myunion[j].Visited = true;
					}
				}
				coversList.Add(i); // 自己也算一个
				myunion[i].Visited = true;

				// 排序使coversList存储的Index与面积正相关
				coversList.Sort(
					(a, b) =>
					myunion[a].LinkedPolygon.Area().CompareTo(
						myunion[b].LinkedPolygon.Area()
					)
				);

				if (coversList.Count >= paraSearchCount) {
					//output.Features.Add(myunion[i].CentroidOfPolygon);
					bool flag = true;
					double max = 0;

					// columnIndex of Height
					if (column != string.Empty
						&&
						myunion[coversList[0]].OriginalLine.DataRow[columnIndex] is double
					) {
						for (int j = 1; j < coversList.Count; j++) {
							double current = (double)(myunion[coversList[j]].OriginalLine.DataRow[columnIndex]);
							if (max < current)
								max = current;
						}
						if (
							(double)(myunion[coversList[0]].OriginalLine.DataRow[columnIndex])
							>=
							max
						) {
							flag = false;
						}
					}

					if (flag) {
						output.Features.Add(myunion[coversList[0]].CentroidOfPolygon);
					}
				}

				cancelProgressHandler.Progress(
					string.Empty,
					Convert.ToInt32((Convert.ToDouble(i) / Convert.ToDouble(myunion.Count)) * 100),
					string.Empty
				);
				if (cancelProgressHandler.Cancel) {
					cancelProgressHandler.Progress(string.Empty, 100, "[Error] Cancelled.");
					return false;
				}
			}

			output.Save();
#if DEBUG
			output1.Save();
#endif
			return true;
		}
	}
}
