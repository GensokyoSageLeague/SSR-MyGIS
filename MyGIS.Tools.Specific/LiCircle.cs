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
			_outputParam[0] = new LineFeatureSetParam(TextStrings.OutputFeatureSet);
		}

		public override bool Execute(ICancelProgressHandler cancelProgressHandler) {
			IFeatureSet inputFeatures = _inputParam[0].Value as IFeatureSet;
			DoubleParam dp = _inputParam[1] as DoubleParam;
			double bufferDistance = 1;
			if (dp != null) {
				bufferDistance = dp.Value;
			}
			IFeatureSet outputFeatures = _outputParam[0].Value as IFeatureSet;

			Desktop.Logger.log("hhh");
			outputFeatures.CopyFeatures(inputFeatures, false);

			if (true) {
				outputFeatures.Save();
				return true;
			}
			else {
				_outputParam = null;
				return false;
			}
		}
	}
}
