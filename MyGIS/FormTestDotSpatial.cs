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

namespace MyGIS {
	public partial class FormTestDotSpatial : Form {
		[Export("Shell", typeof(ContainerControl))]
		private static ContainerControl Shell;

		public FormTestDotSpatial() {
			InitializeComponent();

			if (DesignMode) return;
			Shell = this;
			appManager1.LoadExtensions();
		}
	}
}
