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

		private void MenuRemover(MenuStrip menuStrip, string itemName, string parentName) {
			try {
				foreach (var menuItem in menuStrip.Items) {
					if (menuItem is ToolStripDropDownButton &&
						(parentName == ((ToolStripDropDownButton)menuItem).Text)) {
						foreach (var item in ((ToolStripDropDownButton)menuItem).DropDownItems) {
							if (item is ToolStripMenuItem &&
								(itemName == ((ToolStripMenuItem)item).Text)) {
								((ToolStripDropDownButton)menuItem).DropDownItems.Remove((ToolStripMenuItem)item);
								break;
							}
						}
					}
				}
			}
			catch (InvalidCastException) { }
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			Logger.log(Configurations.appName + " " + Configurations.appVersion + "\r\n\r\n" +
				"Proudly Made by\r\n\t10170320 李云烽\r\n\t10170325 李健纯\r\n\t10170347 姜子威\r\n\t10170348 姚迪昭" + "\r\n\r\n" +
				"in Nanjing Normal University");

			Configurations.formSplashWrapper.Activate();
			Logger.doDelay(1);
			Configurations.formSplashWrapper.Deactivate();

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

		void map1_GeoMouseMove(object sender, GeoMouseArgs e) {
			string locStr = "X:" + e.GeographicLocation.X.ToString("F2") +
				", Y:" + e.GeographicLocation.Y.ToString("F2");
			statusBarBlocker2.Text = locStr;
			statusBar1.Width = this.Width - statusBarBlocker2.Width - 100;
		}

		private void map1_MouseWheel(object sender, MouseEventArgs e) {
			if (e.Delta > 0)
				map1.ZoomIn();
			else
				map1.ZoomOut();
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

		private void layersToolStripMenuItem_Click(object sender, EventArgs e) {
			spatialDockManager1.Panel1Collapsed = !spatialDockManager1.Panel1Collapsed;
			layersToolStripMenuItem.Checked = !layersToolStripMenuItem.Checked;
		}

		private void toolsToolStripMenuItem_Click(object sender, EventArgs e) {
			Configurations.showTool = !Configurations.showTool;
		}

		private void toolBarToolStripMenuItem_Click(object sender, EventArgs e) {
			spatialStatusStrip.Visible = !spatialStatusStrip.Visible;
			toolBarToolStripMenuItem.Checked = !toolBarToolStripMenuItem.Checked;
		}

		private void FormMain_Load(object sender, EventArgs e) {
			Configurations.formLogger.Visible = false;
			Configurations.formSplashWrapper.Deactivate();
			MenuRemover(menuStrip, "Options", "File");
		}

		private void basicOperationsToolStripMenuItem_Click(object sender, EventArgs e) {
			Configurations.showTool = !Configurations.showTool;
			if (Configurations.showTool)
				foreach (TabPage tabpage in tabControl1.TabPages)
					if (tabpage.Text == "Tools") {
						tabControl1.SelectedTab = tabpage;
						break;
					}
		}

		private void selectNoneToolStripMenuItem_Click(object sender, EventArgs e) {
			map1.ClearSelection();
		}

		private void zoomToExtentToolStripMenuItem_Click(object sender, EventArgs e) {
			map1.ZoomToMaxExtent();
		}

		private void progressBar_Paint(object sender, PaintEventArgs e) {
			//Logger.log("progressBar.Paint");
		}

		private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e) {
			System.Diagnostics.Process.Start("https://github.com/GensokyoSageLeague/SSR-MyGIS/wiki");
		}
	}
}
