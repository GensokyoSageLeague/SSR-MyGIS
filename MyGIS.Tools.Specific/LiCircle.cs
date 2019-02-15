using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotSpatial.Data;
using DotSpatial.Modeling.Forms;
using DotSpatial.Topology;
using DotSpatial.Topology.Algorithm;

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
			_inputParam = new Parameter[2];
			_inputParam[0] = new LineFeatureSetParam(TextStrings.InputFeatureSet);
			_inputParam[1] = new DoubleParam(TextStrings.LiLinePara, 10.0);
			_outputParam = new Parameter[1];
			_outputParam[0] = new PolygonFeatureSetParam(TextStrings.OutputFeatureSet);
		}

		public override bool Execute(ICancelProgressHandler cancelProgressHandler) {
			IFeatureSet input = _inputParam[0].Value as IFeatureSet;
			IFeatureSet output = _outputParam[0].Value as IFeatureSet;
			DoubleParam dp = _inputParam[1] as DoubleParam;
			double para = dp != null ? dp.Value : 1;

			for (int i = 0; i < input.Features.Count; i++) {
				IFeature  feature = input.Features[i];
				IEnvelope envelop = input.Features[i].Envelope;

				var c1 = envelop.TopLeft();
				var c2 = envelop.BottomRight();

				output.Features.Add(
					new Polygon(
						new Coordinate[] {
							new Coordinate(c1.X, c1.Y),
							new Coordinate(c1.X, c2.Y),
							new Coordinate(c2.X, c2.Y),
							new Coordinate(c2.X, c1.Y),
							new Coordinate(c1.X, c1.Y)
						}
					)
				);

				cancelProgressHandler.Progress(
					string.Empty,
					Convert.ToInt32((Convert.ToDouble(i) / Convert.ToDouble(input.Features.Count)) * 100),
					c1.ToString() + " " + c2.ToString()
				);
			}

			if (true) {
				output.Save();
				return true;
			}
			else {
				_outputParam = null;
				return false;
			}
		}

		//private bool CheckContain
	}
}
