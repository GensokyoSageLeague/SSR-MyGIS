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
using DotSpatial.Symbology;
using DotSpatial.Data;
using DotSpatial.Topology;


namespace MyGIS {
    public partial class FormTestDotSpatial : Form {
        [Export("Shell", typeof(ContainerControl))]
        private static ContainerControl Shell;

        #region Point ShapeFile class level variable

        //the new point feature set
        FeatureSet pointF = new FeatureSet(FeatureType.Point);

        //the id of point
        int pointID = 0;

        //to differentiate the right and left mouse click
        bool pointmouseClick = false;

        #endregion
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

        private void toolStripButton4_Click(object sender, EventArgs e) {
            map1.AddLayer();
        }

        private void toolStripButton5_Click(object sender, EventArgs e) {
            map1.ClearLayers();
        }

        private void toolStripButton6_Click(object sender, EventArgs e) {
            map1.ZoomToMaxExtent();
        }

        private void toolStripButton7_Click(object sender, EventArgs e) {
            map1.ZoomToPrevious();
        }

        private void toolStripButton8_Click(object sender, EventArgs e) {
            map1.ZoomToNext();
        }

        private void toolStripButton9_Click(object sender, EventArgs e) {
            map1.Select();
        }

        private void toolStripButton10_Click(object sender, EventArgs e) {
            map1.ClearSelection();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e) {

            //Change the cursor style
            map1.Cursor = Cursors.Cross;
            //set the shape type to the classlevel string variable
            //we are going to use this variable in select case statement
            shapeType = "Point";
            //set projection
            pointF.Projection = map1.Projection;
            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("ID");
            pointF.DataTable.Columns.Add(column);
            //add the featureSet as map layer
            MapPointLayer pointLayer = (MapPointLayer)map1.Layers.Add(pointF);
            //Create a new symbolizer
            PointSymbolizer symbol = new PointSymbolizer(Color.Red, DotSpatial.Symbology.PointShape.Ellipse, 3);
            //Set the symbolizer to the point layer
            pointLayer.Symbolizer = symbol;
            //Set the legentText as point
            pointLayer.LegendText = "point";
            //Set left mouse click as true
            pointmouseClick = true;

        }

        private void map1_MouseDown(object sender, MouseEventArgs e) {
           // switch (shapeType) {
                case "Point":
                    if (e.Button == MouseButtons.Left) {
                        if ((pointmouseClick)) {
                            //This method is used to convert the screen cordinate to map coordinate
                            //e.location is the mouse click point on the map control
                            Coordinate coord = map1.PixelToProj(e.Location);

                            //Create a new point
                            //Input parameter is clicked point coordinate
                            DotSpatial.Topology.Point point = new DotSpatial.Topology.Point(coord);

                            //Add the point into the Point Feature
                            //assigning the point feature to IFeature because via it only we can set the attributes.
                            IFeature currentFeature = pointF.AddFeature(point);

                            //increase the point id
                            pointID = pointID + 1;

                            //set the ID attribute
                            currentFeature.DataRow["PointID"] = pointID;

                            //refresh the map
                            map1.ResetBuffer();
                        }
                    } else {
                        //mouse right click
                        map1.Cursor = Cursors.Default;
                        pointmouseClick = false;
                    }
                    break;

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            {
                pointF.SaveAs("point.shp", true);
                MessageBox.Show("The point shapefile has been saved.");
                map1.Cursor = Cursors.Arrow;
            }

        }
    }
}