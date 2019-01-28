using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGIS.Desktop {
	public partial class FormOptions : Form {
		public FormOptions() {
			InitializeComponent();
			checkBox1.Checked = Configurations.usingClassicHough;
			checkBox2.Checked = Configurations.unlimitedZoom;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e) {
			Configurations.usingClassicHough = checkBox1.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e) {
			Configurations.unlimitedZoom = checkBox2.Checked;
		}
	}
}
