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

		string shapeType;

        #endregion
        #region Polyline  ShapeFile class level variables

        MapLineLayer lineLayer = default(MapLineLayer);

        //the line feature set
        FeatureSet lineF = new FeatureSet(FeatureType.Line);

        int lineID = 0;

        //boolean variable for first time mouse click
        bool firstClick = false;

        //It controls the drawing the polyline after the polyline saved operation.
        bool linemouseClick = false;

        #endregion
        #region Polygon ShapeFile class level variables

        FeatureSet polygonF = new FeatureSet(FeatureType.Polygon);

        int polygonID = 0;

        bool polygonmouseClick = false;

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
			switch (shapeType) {
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
					}
					else {
						//mouse right click
						map1.Cursor = Cursors.Default;
						pointmouseClick = false;
					}
              
					break;
                case "line":
                    if (e.Button == MouseButtons.Left) {
                        //left click - fill array of coordinates
                        //coordinate of clicked point
                        Coordinate coord = map1.PixelToProj(e.Location);
                        if (linemouseClick) {
                            //first time left click - create empty line feature
                            if (firstClick) {
                                //Create a new List called lineArray.                          
                                //This list will store the Coordinates
                                //We are going to store the mouse click coordinates into this array.
                                List<Coordinate> lineArray = new List<Coordinate>();

                                //Create an instance for LineString class.
                                //We need to pass collection of list coordinates
                                LineString lineGeometry = new LineString(lineArray);

                                //Add the linegeometry to line feature
                                IFeature lineFeature = lineF.AddFeature(lineGeometry);

                                //add first coordinate to the line feature
                                lineFeature.Coordinates.Add(coord);
                                //set the line feature attribute
                                lineID = lineID + 1;
                                lineFeature.DataRow["LineID"] = lineID;
                                firstClick = false;
                            } else {
                                //second or more clicks - add points to the existing feature
                                IFeature existingFeature = lineF.Features[lineF.Features.Count - 1];
                                existingFeature.Coordinates.Add(coord);

                                //refresh the map if line has 2 or more points
                                if (existingFeature.Coordinates.Count >= 2) {
                                    lineF.InitializeVertices();
                                    map1.ResetBuffer();
                                }
                            }
                        }
                    } else {
                        //right click - reset first mouse click
                        firstClick = true;
                        map1.ResetBuffer();
                    }
                    break;
                case "polygon":

                    if (e.Button == MouseButtons.Left) {
                        //left click - fill array of coordinates
                        Coordinate coord = map1.PixelToProj(e.Location);

                        if (polygonmouseClick) {
                            //first time left click - create empty line feature
                            if (firstClick) {
                                //Create a new List called polygonArray.

                                //this list will store the Coordinates
                                //We are going to store the mouse click coordinates into this array.

                                List<Coordinate> polygonArray = new List<Coordinate>();

                                //Create an instance for LinearRing class.
                                //We pass the polygon List to the constructor of this class
                                LinearRing polygonGeometry = new LinearRing(polygonArray);

                                //Add the polygonGeometry instance to PolygonFeature
                                IFeature polygonFeature = polygonF.AddFeature(polygonGeometry);

                                //add first coordinate to the polygon feature
                                polygonFeature.Coordinates.Add(coord);

                                //set the polygon feature attribute
                                polygonID = polygonID + 1;
                                polygonFeature.DataRow["PolygonID"] = polygonID;
                                firstClick = false;
                            } else {
                                //second or more clicks - add points to the existing feature
                                IFeature existingFeature = (IFeature)polygonF.Features[polygonF.Features.Count - 1];

                                existingFeature.Coordinates.Add(coord);

                                //refresh the map if line has 2 or more points
                                if (existingFeature.Coordinates.Count >= 3) {
                                    //refresh the map
                                    polygonF.InitializeVertices();
                                    map1.ResetBuffer();
                                }
                            }
                        }
                    } else {
                        //right click - reset first mouse click
                        firstClick = true;
                    }
                    break;


            }
        }

		private void saveToolStripMenuItem_Click(object sender, EventArgs e) {

            pointF.SaveAs("point.shp", true);
            MessageBox.Show("The point shapefile has been saved.");
            map1.Cursor = Cursors.Arrow;
			
		}

        private void createToolStripMenuItem1_Click(object sender, EventArgs e) {
            //Change the mouse cursor
            map1.Cursor = Cursors.Cross;

            //set shape type
            shapeType = "line";

            //set projection
            lineF.Projection = map1.Projection;

            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("LineID");

            if (!lineF.DataTable.Columns.Contains("LineID")) {
                lineF.DataTable.Columns.Add(column);
            }

            //add the featureSet as map layer
            lineLayer = (MapLineLayer)map1.Layers.Add(lineF);

            //Set the symbolizer to the line feature. 
            LineSymbolizer symbol = new LineSymbolizer(Color.Blue, 2);
            lineLayer.Symbolizer = symbol;
            lineLayer.LegendText = "line";

            firstClick = true;

            linemouseClick = true;
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e) {
            lineF.SaveAs("c:\\MW\\line.shp", true);
            MessageBox.Show("The line shapefile has been saved.");
            map1.Cursor = Cursors.Arrow;
            linemouseClick = false;
        }

        private void createToolStripMenuItem2_Click(object sender, EventArgs e) {
            //initialize polyline feature set
            map1.Cursor = Cursors.Cross;

            //set shape type
            shapeType = "polygon";

            //set projection
            polygonF.Projection = map1.Projection;

            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("PolygonID");

            if (!polygonF.DataTable.Columns.Contains("PolygonID")) {
                polygonF.DataTable.Columns.Add(column);
            }

            //add the featureSet as map layer
            MapPolygonLayer polygonLayer = (MapPolygonLayer)map1.Layers.Add(polygonF);

            PolygonSymbolizer symbol = new PolygonSymbolizer(Color.Green);

            polygonLayer.Symbolizer = symbol;
            polygonLayer.LegendText = "polygon";

            firstClick = true;

            polygonmouseClick = true;

        }

        private void saveToolStripMenuItem2_Click(object sender, EventArgs e) {
            polygonF.SaveAs("c:\\MW\\polygon.shp", true);
            MessageBox.Show("The polygon shapefile has been saved.");
            map1.Cursor = Cursors.Arrow;
            polygonmouseClick = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            map1.Select();
        }

        private void button2_Click(object sender, EventArgs e) {
            map1.ClearSelection();
        }
    }
}