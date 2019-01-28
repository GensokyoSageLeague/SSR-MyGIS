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
using System.Reflection;
using System.ComponentModel.Composition;

namespace MyGIS.Desktop {
	public partial class FormMain : Form {
		[Export("Shell", typeof(ContainerControl))]
		private static ContainerControl Shell;

		public FormMain() {
			InitializeComponent();

			Configurations.formMain = this;
			this.Text = Configurations.appNameProduct;
			statusBar1.Text = "Idle";
			//spatialHeaderControl.Add();

			Shell = this;
			appManager.LoadExtensions();
			map1.MouseWheel += new MouseEventHandler(map1_MouseWheel);
			map1.FunctionMode = FunctionMode.Pan;
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			Logger.log(Configurations.appName + " " + Configurations.appVersion + "\r\n\r\n" +
				"Proudly Made by\r\n\t10170320 李云烽\r\n\t10170325 李健纯\r\n\t10170347 姜子威\r\n\t10170348 姚迪昭" + "\r\n\r\n" +
				"in Nanjing Normal University");

			var form = new FormAboutBox();
			Icon icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
			if (icon != null)
				form.AppImage = icon;
			form.Show();
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
			new FormOptions().ShowDialog(this);
		}

		private void toggleDebugLogToolStripMenuItem_Click(object sender, EventArgs e) {
			if (Configurations.formLogger != null) {
				Configurations.formLogger.Visible = !Configurations.formLogger.Visible;
			}
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
			Configurations.formLogger.Visible = false;
			//Application.Exit();
		}

		private void dotSpatialTestToolStripMenuItem_Click(object sender, EventArgs e) {
			Logger.log("new FormTestDotSpatial().ShowDialog() is Disposed");
			//new FormTestDotSpatial().ShowDialog();
		}

		private void sSRTestToolStripMenuItem_Click(object sender, EventArgs e) {
			InitializeMapper();
		}

		void map1_GeoMouseMove(object sender, GeoMouseArgs e) {
			string locStr = "X:" + e.GeographicLocation.X.ToString("F2") +
				", Y:" + e.GeographicLocation.Y.ToString("F2");
			statusBarBlocker2.Text = locStr;
			statusBar1.Width = this.Width - statusBarBlocker2.Width - 100;
		}

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

		private void toolStripButton10_Click(object sender, EventArgs e) {
			shapefileToolStripMenuItem_Click(sender, e);
		}

		private void mapRenderingToolStripMenuItem_Click(object sender, EventArgs e) {
			if (map1.Enabled)
				map1.SuspendLayout();
			else
				map1.ResumeLayout();
			map1.Enabled = !map1.Enabled;
			map1.Visible = !map1.Visible;
			mapRenderingToolStripMenuItem.Checked = !mapRenderingToolStripMenuItem.Checked;
		}

		private void FormMain_Load(object sender, EventArgs e) {
			Configurations.formLogger.Visible = false;
			Configurations.formSplashWrapper.Deactivate();
		}

		private void progressBar_Paint(object sender, PaintEventArgs e) {
			//Logger.log("！！！");
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

		private void assemblyToolStripMenuItem_Click(object sender, EventArgs e) {
			Assembly asm = Assembly.GetExecutingAssembly();
			AssemblyDescriptionAttribute asmdis = (AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(asm, typeof(AssemblyDescriptionAttribute));
			AssemblyCopyrightAttribute asmcpr = (AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(asm, typeof(AssemblyCopyrightAttribute));
			AssemblyCompanyAttribute asmcpn = (AssemblyCompanyAttribute)Attribute.GetCustomAttribute(asm, typeof(AssemblyCompanyAttribute));

			string s = string.Format("{0}  {1}  {2} ", asmdis.Description, asmcpr.Copyright, asmcpn.Company);
			MessageBox.Show(s);
		}
		// --------------MAP Ctr End----------------
	}
}
