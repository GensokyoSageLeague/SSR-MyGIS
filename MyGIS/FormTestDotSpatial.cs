using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using DotSpatial.Controls;

namespace MyGIS {
	public partial class FormTestDotSpatial : Form {
		[Export("Shell", typeof(ContainerControl))]
		private static ContainerControl Shell;

		public FormTestDotSpatial() {
			InitializeComponent();

		/*	if (DesignMode) return;
			Shell = this;
			appManager1.LoadExtensions();
            */
		}

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void FormTestDotSpatial_Load(object sender, EventArgs e) {

        }

        private void map1_MouseWheel(object sender, MouseEventArgs e) {
            if (e.Delta > 0) { // Zoom In
                map1.ZoomIn();
            }
            if (e.Delta < 0) { // Zoom Out
                map1.ZoomOut();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void openLayerToolStripMenuItem_Click(object sender, EventArgs e) {
            map1.AddLayer();
        }

        private void closeLayerToolStripMenuItem_Click(object sender, EventArgs e) {
            map1.ClearLayers();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e) {
            map1.ZoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e) {
            map1.ZoomOut();
        }

        private void zoomToExtendToolStripMenuItem_Click(object sender, EventArgs e) {
            map1.ZoomToMaxExtent();
        }


        private void toolStripButton1_Click(object sender, EventArgs e) {
            map1.FunctionMode = FunctionMode.Pan;
        }

        private void toolStripButton2_Click(object sender, EventArgs e) {
            map1.ZoomIn();
        }

        private void toolStripButton3_Click(object sender, EventArgs e) {
            map1.ZoomOut();
        }
    }
}
