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

namespace MyGIS {
	public partial class FormMain : Form {
		public FormMain() {
			InitializeComponent();

			Configurations.formMain = this;
			Configurations.formLogger = new FormLogger();
			Configurations.formLogger.Show();

			statusBar.Text = "Initialized.";
			Logger.log("Initialized.");
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show("MyGIS Desktop " + AppInfo.Version +" "+ AppInfo.VersionState + "\r\n\r\n" +
				"Proudly Made by\r\n\t10170320 李云烽\r\n\t10170325 李健纯\r\n\t10170347 姜子威\r\n\t10170348 姚迪昭",
				"About MyGIS");
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
		private Map mapCtrl = null;
		private Label coordLabelCtrl = null;

		private void InitializeMapper() {
			Logger.log("Shapefile.OpenFile(\"so/腾冲/腾冲_Casted1.shp\")");
			mapCtrl = map1;
			var shp = Shapefile.OpenFile("so/腾冲/腾冲_Casted1.shp");
			shp.Projection = KnownCoordinateSystems.Geographic.World.WGS1984;

			var layer = mapCtrl.Layers.Add(shp) as MapLineLayer;
			layer.Symbolizer = new DotSpatial.Symbology.LineSymbolizer(Color.FromArgb(0x33, 0x33, 0x33), 1);
			mapCtrl.GeoMouseMove += mapCtrl_GeoMouseMove;

			coordLabelCtrl = new Label() {
				Name = "coordLabelCtrl",
				Text = "X:00.0000,Y:00.0000",
				Width = 200,
				BackColor = Color.Transparent
			};
			mapCtrl.Controls.Add(coordLabelCtrl);
		}

		void mapCtrl_GeoMouseMove(object sender, GeoMouseArgs e) {
			string locStr = "X:" + e.GeographicLocation.X.ToString("F6");
			locStr += "Y:" + e.GeographicLocation.Y.ToString("F6");
			coordLabelCtrl.Text = locStr;
		}
		// --------------MAP Ctr End----------------

		private void sSREnumToolStripMenuItem_Click(object sender, EventArgs e) {
			//map1.Layers[0].
		}
	}
}
