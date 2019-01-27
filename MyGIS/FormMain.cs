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
		[System.ComponentModel.Composition.Export("Shell", typeof(ContainerControl))]
		private static ContainerControl Shell;

		public FormMain() {
			InitializeComponent();

			Shell = this;
			appManager1.LoadExtensions();

			Configurations.formMain = this;
			Configurations.formLogger = new FormLogger();
			Configurations.formLogger.Show();

			this.Text = AppInfo.Name;
			statusBar1.Text = "Idle";
			Logger.log("Started at " + DateTime.Now.ToString() + " on " + AppInfo.Name + " " + AppInfo.Version + " " + AppInfo.VersionState);
			Logger.log("===============Logger Start===============");

			map1.GeoMouseMove += map1_GeoMouseMove;
			map1.MouseWheel += new MouseEventHandler(map1_MouseWheel);

			map1.FunctionMode = FunctionMode.Pan;
			statusBar1.Width = this.Width - statusBar2.Width - 100;
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
			//new FormTestDotSpatial().ShowDialog();
		}

		private void sSRTestToolStripMenuItem_Click(object sender, EventArgs e) {
			InitializeMapper();
		}

		void map1_GeoMouseMove(object sender, GeoMouseArgs e) {
			string locStr = "X:" + e.GeographicLocation.X.ToString("F2") +
				", Y:" + e.GeographicLocation.Y.ToString("F2");
			statusBar2.Text = locStr;
			statusBar1.Width = this.Width - statusBar2.Width - 100;
		}

		// --------------MAP Ctr Start----------------
		private void InitializeMapper() {
			Logger.log("Shapefile.OpenFile(\"so/腾冲/腾冲_Casted1.shp\")");
			Shapefile shp = Shapefile.OpenFile("so/腾冲/腾冲_Casted1.shp");
			shp.Projection = KnownCoordinateSystems.Geographic.World.WGS1984;

			foreach (var item in shp.Features) {
				LICore.LI_Line(item.ToShape().Vertices);
// 				Logger.log("X:" + item.ToShape().Vertices[0].ToString() +
// 					", Y:" + item.ToShape().Vertices[1].ToString());
			}

			var layer = map1.Layers.Add(shp) as MapLineLayer;
			layer.Symbolizer = new LineSymbolizer(Color.FromArgb(0x33, 0x33, 0x33), 1);
		}

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
		// --------------MAP Ctr End----------------

		private void shapefileToolStripMenuItem_Click(object sender, EventArgs e) {
			string fileName = "";
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Filter = "Shapefile|*.shp";
			if (openFile.ShowDialog() == DialogResult.OK) {
				fileName = openFile.FileName;
				map1.AddLayer(fileName);
			}
		}

		private void map1_MouseWheel(object sender, MouseEventArgs e) {
			FunctionMode ori = map1.FunctionMode;
			if (e.Delta > 0) {
				map1.FunctionMode = FunctionMode.ZoomIn;
			}
			else {
				map1.FunctionMode = FunctionMode.ZoomOut;
			}
			map1.FunctionMode = ori;
		}

		private void toolStripButton2_Click(object sender, EventArgs e) {
			map1.FunctionMode = FunctionMode.Info;
			clntoolStripButtonChecked();
			toolStripButton2.Checked = true;
		}

		private void toolStripButton3_Click(object sender, EventArgs e) {
			map1.FunctionMode = FunctionMode.ZoomIn;
			clntoolStripButtonChecked();
			toolStripButton3.Checked = true;
		}

		private void toolStripButton4_Click(object sender, EventArgs e) {
			map1.FunctionMode = FunctionMode.ZoomOut;
			clntoolStripButtonChecked();
			toolStripButton4.Checked = true;
		}

		private void toolStripButton5_Click(object sender, EventArgs e) {
			map1.FunctionMode = FunctionMode.ZoomPan;
			clntoolStripButtonChecked();
			toolStripButton5.Checked = true;
		}

		private void toolStripButton6_Click(object sender, EventArgs e) {
			map1.FunctionMode = FunctionMode.Pan;
			clntoolStripButtonChecked();
			toolStripButton6.Checked = true;
		}

		private void toolStripButton7_Click(object sender, EventArgs e) {
			map1.FunctionMode = FunctionMode.Select;
			clntoolStripButtonChecked();
			toolStripButton7.Checked = true;
		}

		private void toolStripButton8_Click(object sender, EventArgs e) {
			map1.FunctionMode = FunctionMode.Label;
			clntoolStripButtonChecked();
			toolStripButton8.Checked = true;
		}

		private void toolStripButton9_Click(object sender, EventArgs e) {
			map1.FunctionMode = FunctionMode.None;
			clntoolStripButtonChecked();
			toolStripButton9.Checked = true;
		}

		private void clntoolStripButtonChecked() {
			toolStripButton2.Checked = false;
			toolStripButton3.Checked = false;
			toolStripButton4.Checked = false;
			toolStripButton5.Checked = false;
			toolStripButton6.Checked = false;
			toolStripButton7.Checked = false;
			toolStripButton8.Checked = false;
			toolStripButton9.Checked = false;
		}

		private void toolStripButton10_Click(object sender, EventArgs e) {
			shapefileToolStripMenuItem_Click(sender, e);
		}

		private void FormMain_ResizeEnd(object sender, EventArgs e) {
			statusBar1.Width = this.Width - statusBar2.Width - 100;
		}

		private void lineToolStripMenuItem_Click(object sender, EventArgs e) {
			
		}

		private void mapRenderingToolStripMenuItem_Click(object sender, EventArgs e) {
			map1.Enabled = !map1.Enabled;
			mapRenderingToolStripMenuItem.Checked = !mapRenderingToolStripMenuItem.Checked;
		}
	}
}
