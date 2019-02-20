using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotSpatial.Data;
using DotSpatial.Modeling.Forms;
using DotSpatial.Topology;
using DotSpatial.Topology.Algorithm;
using DotSpatial.Topology.Simplify;
using System.Data;

namespace MyGIS.Tools.Specific {
	public class LiLine : Tool {
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

		public LiLine() {
			this.Name = TextStrings.LiLine;
			this.Category = TextStrings.Category;
			this.Description = TextStrings.LiLineDescription;
			this.ToolTip = TextStrings.LiLineTip;
		}

		public override void Initialize() {
			_inputParam = new Parameter[2];
			_inputParam[0] = new LineFeatureSetParam(TextStrings.InputFeatureSet);
			_inputParam[1] = new DoubleParam(TextStrings.LiLinePara, 10.0);
			_outputParam = new Parameter[1];
			_outputParam[0] = new LineFeatureSetParam(TextStrings.OutputFeatureSet);
		}

// 		public bool ExecuteTestings(ICancelProgressHandler cancelProgressHandler) {
// 			IFeatureSet inputFeatures = _inputParam[0].Value as IFeatureSet;
// 			DoubleParam dp = _inputParam[1] as DoubleParam;
// 			double bufferDistance = 1;
// 			if (dp != null) {
// 				bufferDistance = dp.Value;
// 			}
// 			IFeatureSet outputFeatures = _outputParam[0].Value as IFeatureSet;
// 
// 			//Desktop.Logger.log("hhh");
// 			outputFeatures.CopyFeatures(inputFeatures, false);
// 
// 			if (true) {
// 				outputFeatures.Save();
// 				return true;
// 			}
// 			else {
// 				_outputParam = null;
// 				return false;
// 			}
// 		}

		public override bool Execute(ICancelProgressHandler cancelProgressHandler) {
			IFeatureSet input = _inputParam[0].Value as IFeatureSet;
			if (input != null) {
				input.FillAttributes();
			}

			double tolerance = (double)_inputParam[1].Value;
			IFeatureSet output = _outputParam[0].Value as IFeatureSet;

			return Execute(input, tolerance, output, cancelProgressHandler);
		}

		public bool Execute(
			IFeatureSet input, double tolerance, IFeatureSet output,
			ICancelProgressHandler cancelProgressHandler) {

			if (input == null || output == null) {
				return false;
			}

			// 复制表
			foreach (DataColumn inputColumn in input.DataTable.Columns) {
				output.DataTable.Columns.Add(new DataColumn(inputColumn.ColumnName, inputColumn.DataType));
			}

			int numTotalOldPoints = 0;
			int numTotalNewPoints = 0;

			for (int j = 0; j < input.Features.Count; j++) {
				int numOldPoints = 0;
				int numNewPoints = 0;

				Geometry geom = input.Features[j].BasicGeometry as Geometry;
				if (geom != null) {
					numOldPoints = geom.NumPoints;
				}

				numTotalOldPoints += numOldPoints;
				if (geom != null) {
					for (int part = 0; part < geom.NumGeometries; part++) {
						Geometry geomPart = (Geometry)geom.GetGeometryN(part);

						// 简化
						IList<Coordinate> oldCoords = geomPart.Coordinates;
						IList<Coordinate> newCoords = DouglasPeuckerLineSimplifier.Simplify(
							oldCoords, tolerance);

						// coordinates -> geometry
						Geometry newGeom = new LineString(newCoords);
						numNewPoints += newGeom.NumPoints;
						numTotalNewPoints += numNewPoints;
						Feature newFeature = new Feature(newGeom, output);
						foreach (DataColumn colSource in input.DataTable.Columns) {
							newFeature.DataRow[colSource.ColumnName] = input.Features[j].DataRow[colSource.ColumnName];
						}
					}
				}

				cancelProgressHandler.Progress(
					string.Empty,
					Convert.ToInt32((Convert.ToDouble(j) / Convert.ToDouble(input.Features.Count)) * 100),
					numOldPoints + "-->" + numNewPoints);
				if (cancelProgressHandler.Cancel) {
					return false;
				}
			}

			cancelProgressHandler.Progress(
				string.Empty,
				100,
				"Old / Processed number of points:" + numTotalOldPoints + "/"
				+ numTotalNewPoints);

			output.Save();
			return true;
		}
	}
}
