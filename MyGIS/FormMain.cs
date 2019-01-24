using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatial.Controls;
using DotSpatial.Data;
using DotSpatial.Projections;
using DotSpatial.Symbology;
using DotSpatial.Topology;

namespace MyGIS {
	public partial class FormMain : Form {
		public FormMain() {
			InitializeComponent();

			Configurations.formMain = this;
			Configurations.formLogger = new FormLogger();
			Configurations.formLogger.Show();

			this.Text = AppInfo.Name;
			statusBar.Text = "Idle";
			Logger.log("Started at " + DateTime.Now.ToString() + " on " + AppInfo.Name + " " + AppInfo.Version + " " + AppInfo.VersionState);
			Logger.log("===============Logger Start===============");

			map1.GeoMouseMove += map1_GeoMouseMove;
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show(AppInfo.Name + " " + AppInfo.Version +" "+ AppInfo.VersionState + "\r\n\r\n" +
				"Proudly Made by\r\n\t10170320 李云烽\r\n\t10170325 李健纯\r\n\t10170347 姜子威\r\n\t10170348 姚迪昭" + "\r\n\r\n" +
				"in Nanjing Normal University",
				"About " + AppInfo.Name);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
			new FormOptions().ShowDialog(this);
		}

		private void toolStripButton1_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void toggleDebugLogToolStripMenuItem_Click(object sender, EventArgs e) {
			if (Configurations.formLogger != null) {
				Configurations.formLogger.Visible = !Configurations.formLogger.Visible;
			}
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
			Application.Exit();
		}

		private void dotSpatialTestToolStripMenuItem_Click(object sender, EventArgs e) {
			Logger.log("new FormTestDotSpatial().ShowDialog()");
			new FormTestDotSpatial().ShowDialog();
		}

		private void sSRTestToolStripMenuItem_Click(object sender, EventArgs e) {
			InitializeMapper();
		}

		// --------------MAP Ctr Start----------------
		private void InitializeMapper() {
			Logger.log("Shapefile.OpenFile(\"so/腾冲/腾冲_Casted1.shp\")");
			var shp = Shapefile.OpenFile("so/腾冲/腾冲_Casted1.shp");
			shp.Projection = KnownCoordinateSystems.Geographic.World.WGS1984;

			foreach (var item in shp.Features) {
				Logger.log("X:" + item.ToShape().Vertices[0].ToString() +
					", Y:" + item.ToShape().Vertices[1].ToString());
			}

			var layer = map1.Layers.Add(shp) as MapLineLayer;
			layer.Symbolizer = new LineSymbolizer(Color.FromArgb(0x33, 0x33, 0x33), 1);
		}

		void map1_GeoMouseMove(object sender, GeoMouseArgs e) {
			string locStr = "X:" + e.GeographicLocation.X.ToString("F2") + 
				", Y:" + e.GeographicLocation.Y.ToString("F2");
			statusBar.Text = locStr;
		}
		// --------------MAP Ctr End----------------

		private void sSREnumToolStripMenuItem_Click(object sender, EventArgs e) {
			//查看与选中要素重叠的要素
			if (map1.Layers.Count == 0) {
				return;
			}
			//重叠分析
			//遍历要素，显示面积
			PolygonLayer pLayer = map1.Layers[0] as PolygonLayer;
			FeatureSet fs = null;
			fs = (FeatureSet)map1.Layers[0].DataSet;
			if (pLayer.Selection.Count == 0) {
				MessageBox.Show("无选中记录", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			foreach (Feature feature in pLayer.Selection.ToFeatureList()) {
				////实现方式1==================
				IEnvelope pEnvelope = null;
				pLayer.Select(null, feature.Envelope, DotSpatial.Symbology.SelectionMode.Intersects, out pEnvelope);
			}
		}
	}
}
